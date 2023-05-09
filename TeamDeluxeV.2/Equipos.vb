Imports System.Security.Cryptography

Public Class Equipos
    Dim sql As String
    Dim salto As Boolean
    Dim rsAux As New ADODB.Recordset
    Dim rsEquipos As New ADODB.Recordset
    Dim idequi As Integer = 0
    Public Sub Guardar()
        If Trim(TxNombreEquipo.Text) = "" Or Trim(TxHoraPartido.Text) = "" Or Trim(TxCategoria.Text) = "" Then
            MsgBox("Rellene todos los campos", vbExclamation)
            Exit Sub
        End If
        Cursor = Cursors.WaitCursor
        rsEquipos = New ADODB.Recordset
        rsEquipos.Open("Select * from equipos where Idequipos = " & IIf(TxIDEquipo.Text = "", 0, TxIDEquipo.Text), Database.Connection, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic, 1)
        If rsEquipos.EOF Then
            rsAux = New ADODB.Recordset
            rsAux.Open("select top 1 Idequipos from equipos order by Idequipos desc", Database.Connection, ADODB.CursorTypeEnum.adOpenForwardOnly, ADODB.LockTypeEnum.adLockOptimistic, 1)

            rsEquipos.AddNew()
            If rsAux.EOF Then
                idequi = 1
                rsEquipos("Idequipos").Value = CInt(idequi)
            Else
                idequi = CInt(rsAux("Idequipos").Value)
                rsEquipos("Idequipos").Value = CInt(idequi) + 1
            End If
        End If
        rsEquipos("nombre").Value = Trim(TxNombreEquipo.Text)
        rsEquipos("Temporada").Value = Trim(TxTemporada.Text)
        rsEquipos("Categoria").Value = Trim(TxCategoria.Text)
        rsEquipos("InicioCompeticion").Value = Format(CDate(DTPInicioCompe.Value), "yyyy/MM/dd")
        rsEquipos("HoraPartidos").Value = Format(CDate(TxHoraPartido.Text), "HH:mm")
        rsEquipos("IdUsuario").Value = Trim(CboUsuario.SelectedValue)
        rsEquipos.Update()
        Cursor = Cursors.Arrow
        Nuevo()
    End Sub

    Public Sub Consulta()
        DbgEquipos.Rows.Clear()
        rsEquipos = New ADODB.Recordset
        If UCase(VariablesAPP.RolUsuario) = UCase("admin") Then
            sql = "Select Equipos.*, Usuarios.nombre as Entrenador " &
            " from Equipos inner join Usuarios on Equipos.IdUsuario = Usuarios.IdUsuario "
        Else
            sql = "Select Equipos.*, Usuarios.Nombre as Entrenador " &
            " from Equipos inner join Usuarios on Equipos.IdUsuario = Usuarios.IdUsuario " &
            " where Usuarios.idusuario = " & VariablesAPP.IdUsuarioApp
        End If

        rsEquipos.Open(sql, Database.Connection, ADODB.CursorTypeEnum.adOpenForwardOnly, ADODB.LockTypeEnum.adLockOptimistic)
        Do Until rsEquipos.EOF
            AniadirLineaGridEquipos(CInt(rsEquipos("Idequipos").Value), Trim(rsEquipos("nombre").Value), Trim(rsEquipos("Temporada").Value), Trim(rsEquipos("Categoria").Value), Trim(rsEquipos("InicioCompeticion").Value), Trim(rsEquipos("Entrenador").Value))
            rsEquipos.MoveNext()
        Loop
    End Sub

    Private Sub AniadirLineaGridEquipos(id As Integer, nombre As String, temporada As String, categoria As String, InicioCompe As Date, Entrenador As String)
        Dim newRow As DataGridViewRow = New DataGridViewRow()
        newRow.CreateCells(DbgEquipos)
        newRow.Cells(0).Value = id
        newRow.Cells(1).Value = nombre
        newRow.Cells(2).Value = temporada
        newRow.Cells(3).Value = categoria
        newRow.Cells(4).Value = InicioCompe
        newRow.Cells(5).Value = Entrenador
        DbgEquipos.Rows.Add(newRow)
    End Sub

    Public Sub Eliminar()
        If Trim(TxIDEquipo.Text) = "" Or Trim(TxIDEquipo.Text) = "0" Then
            MsgBox("Seleccione un ID valido para eliminar", vbExclamation)
            Nuevo()
            Exit Sub
        Else
            If MsgBox("Desea eliminar el Usuario seleccionado (" & Trim(TxIDEquipo.Text) & ")", vbOKCancel) = vbOK Then
                Try
                    Database.Connection.BeginTrans()
                    Database.Connection.Execute("Delete from equipos where idequipos = " & CInt(TxIDEquipo.Text))
                    Database.Connection.CommitTrans()
                Catch ex As Exception
                    Database.Connection.RollbackTrans()
                    MsgBox("Error, no se ha podido eliminar el usuario")
                    Exit Sub
                End Try
            End If
        End If
    End Sub

    Public Sub Nuevo()
        Cursor = Cursors.WaitCursor
        TxIDEquipo.Text = ""
        TxNombreEquipo.Text = ""
        TxTemporada.Text = ""
        TxCategoria.Text = ""
        DTPInicioCompe.Value = Now.Date
        TxHoraPartido.Text = "00:00"
        TxIDubicacion.Text = ""
        TxNombreUbicacion.Text = ""
        TxDireccionUbicacion.Text = ""
        TxCampoUbicacion.Text = ""
        If CboUsuario.Items.Count > 0 Then
            CboUsuario.SelectedIndex = 0
        End If
        CargarGridEquipos()
        DbgUbicaciones.Rows.Clear()
        Cursor = Cursors.Arrow
    End Sub

    Private Sub TxIDEquipo_KeyDown(sender As Object, e As KeyEventArgs) Handles TxIDEquipo.KeyDown, TxNombreEquipo.KeyDown, TxTemporada.KeyDown, TxCategoria.KeyDown, DTPInicioCompe.KeyDown, TxHoraPartido.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub LostFocus1(sender As Object, e As EventArgs) Handles TxIDEquipo.LostFocus
        If Trim(TxIDEquipo.Text) = "" And Not IsNumeric(TxIDEquipo.Text) Then Exit Sub
        rsAux = New ADODB.Recordset
        rsAux.Open("Select * from equipos where idequipos = " & CInt(TxIDEquipo.Text), Database.Connection, ADODB.CursorTypeEnum.adOpenForwardOnly, ADODB.LockTypeEnum.adLockOptimistic, 1)
        If Not rsAux.EOF Then
            CargarEquipoDeConsulta(CInt(rsAux("Idequipos").Value))
        Else
            Nuevo()
        End If
    End Sub

    Private Sub CargarEquipoDeConsulta(IdEquipo As Integer)
        Dim rs As New ADODB.Recordset
        rs.Open("select * from equipos where Idequipos = " & IdEquipo, Database.Connection, ADODB.CursorTypeEnum.adOpenForwardOnly, ADODB.LockTypeEnum.adLockOptimistic, 1)
        If rs.EOF Then Exit Sub : Nuevo()
        TxIDEquipo.Text = CInt(rs("Idequipos").Value)
        TxNombreEquipo.Text = Trim(rs("Nombre").Value)
        TxTemporada.Text = Trim(rs("Temporada").Value)
        TxCategoria.Text = Trim(rs("Categoria").Value)
        DTPInicioCompe.Value = CDate(rs("InicioCompeticion").Value)
        TxHoraPartido.Text = Trim(rs("HoraPartidos").Value)
        CboUsuario.SelectedValue = CInt(rs("idUsuario").Value)
    End Sub

    Private Sub CargarEntrenadores()
        If salto Then Exit Sub
        rsAux = New ADODB.Recordset
        rsAux.Open("Select * from usuarios where rol = 'entrenador'", Database.Connection, ADODB.CursorTypeEnum.adOpenForwardOnly, ADODB.LockTypeEnum.adLockOptimistic, 1)
        Dim items As New List(Of ItemCBO)
        Do Until rsAux.EOF
            items.Add(New ItemCBO With {.Value = CInt(rsAux("idUsuario").Value), .Description = Trim(rsAux("nombre").Value)})
            rsAux.MoveNext()
        Loop
        CboUsuario.DataSource = items
        CboUsuario.ValueMember = "Value"
        CboUsuario.DisplayMember = "Description"
    End Sub


    Private Sub Equipos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarEntrenadores()
        Nuevo()
        Consulta()
    End Sub

    Private Sub TxGuardarUbicacion_Click(sender As Object, e As EventArgs) Handles TxGuardarUbicacion.Click
        Dim rsUbi As New ADODB.Recordset
        If Trim(TxIDEquipo.Text) = "" Then Exit Sub
        rsUbi.Open("Select * from ubicaciones where idubicacion = " & IIf(Trim(TxIDubicacion.Text) = "", "999", 0), Database.Connection, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic, 1)
        If rsUbi.EOF Then
            rsUbi.AddNew()
            rsAux = New ADODB.Recordset
            rsAux.Open("Select top 1 idubicacion from ubicaciones order by idubicacion desc", Database.Connection, ADODB.CursorTypeEnum.adOpenForwardOnly, ADODB.LockTypeEnum.adLockOptimistic, 1)
            If rsAux.EOF Then
                rsUbi("idubicacion").Value = 1
            Else
                rsUbi("idubicacion").Value = CInt(rsAux("idubicacion").Value) + 1
            End If
        End If
        rsUbi("Direccion").Value = Trim(TxDireccionUbicacion.Text)
        rsUbi("Nombre").Value = Trim(TxNombreUbicacion.Text)
        rsUbi("Campo").Value = Trim(TxCampoUbicacion.Text)
        rsUbi("idequipo").Value = CInt(TxIDEquipo.Text)
        rsUbi.Update()
        Nuevo()
    End Sub


    Private Sub AniadirLineaUbicaciones(id As Integer, direccion As String, nombre As String, campo As String)
        Dim newRow As DataGridViewRow = New DataGridViewRow()
        newRow.CreateCells(DbgUbicaciones)
        newRow.Cells(0).Value = id
        newRow.Cells(1).Value = direccion
        newRow.Cells(2).Value = nombre
        newRow.Cells(3).Value = campo
        DbgUbicaciones.Rows.Add(newRow)
    End Sub


    Private Sub CargarGridUbicaciones(idequipo As Integer)
        DbgUbicaciones.Rows.Clear()
        rsAux = New ADODB.Recordset
        rsAux.Open("Select * from ubicaciones where idequipo = " & CInt(idequipo), Database.Connection, ADODB.CursorTypeEnum.adOpenForwardOnly, ADODB.LockTypeEnum.adLockOptimistic, 1)
        Do Until rsAux.EOF
            AniadirLineaUbicaciones(CInt(rsAux("idubicacion").Value), Trim(rsAux("Direccion").Value), Trim(rsAux("nombre").Value), Trim(rsAux("campo").Value))
            rsAux.MoveNext()
        Loop
    End Sub

    Private Sub CargarGridEquipos()
        DbgEquipos.Rows.Clear()
        Dim Sql As String
        If UCase(VariablesAPP.IdUsuarioApp) = UCase("admin") Then
            Sql = "Select * from equipos"
        Else
            Sql = "Select * from equipos where idusuario = " & VariablesAPP.IdUsuarioApp
        End If
        rsAux = New ADODB.Recordset
        rsAux.Open(Sql, Database.Connection, ADODB.CursorTypeEnum.adOpenForwardOnly, ADODB.LockTypeEnum.adLockOptimistic, 1)
        Do Until rsAux.EOF
            AniadirLineaGridEquipos(CInt(rsAux("idequipos").Value), Trim(rsAux("nombre").Value), Trim(rsAux("temporada").Value), Trim(rsAux("categoria").Value), Trim(rsAux("inicioCompeticion").Value), CInt(rsAux("idusuario").Value))
            rsAux.MoveNext()
        Loop
    End Sub


    Private Sub DbgUbiciones_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DbgUbicaciones.CellContentDoubleClick
        If Trim(TxIDEquipo.Text) = "" Then Exit Sub
        rsAux = New ADODB.Recordset
        rsAux.Open("select * from ubicaciones where idequipo = " & CInt(TxIDEquipo.Text), Database.Connection, ADODB.CursorTypeEnum.adOpenForwardOnly, ADODB.LockTypeEnum.adLockOptimistic, 1)
        If rsAux.EOF Then Nuevo() : Exit Sub
        TxIDubicacion.Text = CInt(rsAux("idubicacion").Value)
        TxDireccionUbicacion.Text = Trim(rsAux("Direccion").Value)
        TxNombreUbicacion.Text = Trim(rsAux("nombre").Value)
        TxCampoUbicacion.Text = Trim(rsAux("campo").Value)
    End Sub

    Private Sub DbgEquipos_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DbgEquipos.CellContentDoubleClick
        If Trim(DbgEquipos.Rows(e.RowIndex).Cells(0).Value) = "" Then Exit Sub
        rsAux = New ADODB.Recordset
        rsAux.Open("select * from equipos where idequipos = " & CInt(DbgEquipos.Rows(e.RowIndex).Cells(0).Value), Database.Connection, ADODB.CursorTypeEnum.adOpenForwardOnly, ADODB.LockTypeEnum.adLockOptimistic, 1)
        If rsAux.EOF Then Nuevo() : Exit Sub
        CargarEquipoDeConsulta(CInt(rsAux("idequipos").Value))
        CargarGridUbicaciones(CInt(rsAux("idequipos").Value))
    End Sub

    Private Sub TxEliminarUbicacion_Click(sender As Object, e As EventArgs) Handles TxEliminarUbicacion.Click
        If TxIDubicacion.Text = "" Or Not IsNumeric(TxIDubicacion.Text) Or TxIDubicacion.Text = 0 Then
            Exit Sub
        End If
        If TxIDEquipo.Text = "" Or Not IsNumeric(TxIDEquipo.Text) Or TxIDEquipo.Text = 0 Then
            Exit Sub
        End If
        If MsgBox("¿Desea eliminar la ubicacion del equipo seleccionado?", vbQuestion + vbYesNo) = vbYes Then
            Try
                Database.Connection.BeginTrans()
                Database.Connection.Execute("update entrenamientos set idubicacon = null where idequipo = " & CInt(TxIDEquipo.Text) & "and idubicacon = " & CInt(TxIDubicacion.Text))
                Database.Connection.Execute("Delete from ubicaciones where idequipo = " & CInt(TxIDEquipo.Text))
                Database.Connection.CommitTrans()
            Catch ex As Exception
                Database.Connection.RollbackTrans()
                MsgBox("Erro. No se ha podido eliminar la ubicacion. " & vbCrLf & ex.Message)
                Exit Sub
            End Try
        End If
        Nuevo()
    End Sub
End Class