Imports System.Windows.Controls

Public Class Usuarios
    Dim salto As Boolean
    Dim rsUsuarios As New ADODB.Recordset
    Dim rsAux As New ADODB.Recordset
    Dim sql As String
    Public Sub Guardar()
        If Trim(TxNombre.Text) = "" Then
            MsgBox("Introduzca un nombre para el usuario.", vbExclamation)
            Exit Sub
        End If
        Cursor = Cursors.WaitCursor
        rsUsuarios = New ADODB.Recordset
        rsUsuarios.Open("Select * from Usuarios where IdUsuario = " & IIf(TxID.Text = "", 0, TxID.Text), Database.Connection, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic, 1)
        If rsUsuarios.EOF Then
            rsAux = New ADODB.Recordset
            rsAux.Open("select top 1 IdUsuario from Usuarios order by IdUsuario desc", Database.Connection, ADODB.CursorTypeEnum.adOpenForwardOnly, ADODB.LockTypeEnum.adLockOptimistic, 1)
            rsUsuarios.AddNew()
            rsUsuarios("IDusuario").Value = CInt(rsAux("Idusuario").Value) + 1
        End If
        rsUsuarios("nombre").Value = Trim(TxNombre.Text)
        rsUsuarios("apellido").Value = Trim(TxApellido.Text)
        rsUsuarios("FechaNacimiento").Value = Format(CDate(DTPfechaNac.Value), "yyyy/MM/dd")
        rsUsuarios("telefono").Value = Trim(TxTelefono.Text)
        rsUsuarios("direccion").Value = Trim(TxDireccion.Text)
        rsUsuarios("pais").Value = Trim(TxPais.Text)
        rsUsuarios("provincia").Value = Trim(TxProvincia.Text)
        rsUsuarios("poblacion").Value = Trim(TxLocalidad.Text)
        rsUsuarios("DNI").Value = Trim(TxDNI.Text)
        rsUsuarios("FechaAlta").Value = Format(CDate(Now.Date), "yyyy/MM/dd")
        rsUsuarios("password").Value = Trim(TxNuevaPassword.Text)
        If CInt(CboTipoUsuario.SelectedValue) = 1 Then
            rsUsuarios("Rol").Value = "entrenador"
        ElseIf CInt(CboTipoUsuario.SelectedValue) = 2 Then
            rsUsuarios("Rol").Value = "jugador"
        End If



        If CboTipoUsuario.SelectedValue = 2 Then
            rsUsuarios("IDequipoDondeJuega").Value = CInt(CboEquipo.SelectedValue)
        End If
        rsUsuarios.Update()
        Cursor = Cursors.Arrow
        Nuevo()
    End Sub

    Public Sub Consulta()
        DbgUsuarios.Rows.Clear()
        rsUsuarios = New ADODB.Recordset
        If UCase(VariablesAPP.RolUsuario) <> UCase("admin") Then
            sql = "Select * from usuarios where idusuario <> 1 and idEquipoDondeJuega <> null"
        Else
            sql = "Select * from usuarios where idusuario <> 1"
        End If

        If IsNumeric(TxIDbus.Text) Then
            sql &= " and idusuario = " & CInt(TxIDbus.Text)
        End If

        If Trim(TxNombreBus.Text) <> "" Then
            sql &= " and nombre like '%" & Trim(TxNombreBus.Text) & "%'"
        End If

        If Trim(TxApellidoBus.Text) <> "" Then
            sql &= " and apellido like '%" & Trim(TxApellido.Text) & "%'"
        End If

        If TxDNIbus.Text.Length = 9 Then
            sql &= " and DNI = '" & Trim(TxDNI.Text) & "'"
        End If

        rsUsuarios.Open(sql, Database.Connection, ADODB.CursorTypeEnum.adOpenForwardOnly, ADODB.LockTypeEnum.adLockOptimistic)
        Do Until rsUsuarios.EOF
            AniadirLineaGridUsuarios(CInt(rsUsuarios("IDusuario").Value), Trim(rsUsuarios("nombre").Value), Trim(rsUsuarios("apellido").Value), Trim(rsUsuarios("DNI").Value), Trim(rsUsuarios("Telefono").Value))
            rsUsuarios.MoveNext()
        Loop
    End Sub

    Private Sub AniadirLineaGridUsuarios(id As Integer, nombre As String, apellido As String, DNI As String, telefono As String, Optional equipo As String = "")
        Dim newRow As DataGridViewRow = New DataGridViewRow()
        newRow.CreateCells(DbgUsuarios)
        newRow.Cells(0).Value = id
        newRow.Cells(1).Value = nombre
        newRow.Cells(2).Value = apellido
        newRow.Cells(3).Value = DNI
        newRow.Cells(4).Value = telefono
        newRow.Cells(5).Value = equipo
        DbgUsuarios.Rows.Add(newRow)
    End Sub

    Public Sub Eliminar()
        If Trim(TxID.Text) = "" Or Trim(TxID.Text) = "0" Then
            MsgBox("Seleccione un ID valido para eliminar", vbExclamation)
            Nuevo()
            Exit Sub
        Else
            If MsgBox("Desea eliminar el Usuario seleccionado (" & Trim(TxID.Text) & ")", vbOKCancel) = vbOK Then
                Try
                    Database.Connection.BeginTrans()
                    Database.Connection.Execute("Delete from Usuarios where IDusuario = " & CInt(TxID.Text))
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
        TxID.Text = ""
        TxNombre.Text = ""
        TxApellido.Text = ""
        TxDNI.Text = ""
        DTPfechaNac.Value = Now.Date
        TxTelefono.Text = ""
        TxDireccion.Text = ""
        TxPais.Text = ""
        TxProvincia.Text = ""
        TxLocalidad.Text = ""
        CboTipoUsuario.SelectedValue = 1
        TxNuevaPassword.Text = ""
        Cursor = Cursors.Arrow
    End Sub

    Private Sub MaterialFloatingActionButton2_Click(sender As Object, e As EventArgs) Handles BtnGuardarPassword.Click
        If Trim(TxNuevaPassword.Text) = "" Then MsgBox("No se puede dejar el campo contraseña vacio.", vbExclamation) : Exit Sub
        PanelPass.Visible = False
    End Sub

    Private Sub TxAbrirPanelPassword_Click(sender As Object, e As EventArgs) Handles BtnAbrirPanelPassword.Click
        If Trim(TxNombre.Text) = "" Or Trim(TxApellido.Text) = "" Or Trim(TxDNI.Text) = "" Or Trim(TxTelefono.Text) = "" Then
            MsgBox("Introduzca los datos del usuario antes de poner una contrasenia", vbExclamation)
            Exit Sub
        End If
        PanelPass.Visible = True
    End Sub

    Private Sub CboTipoUsuario_SelectedValueChanged(sender As Object, e As EventArgs) Handles CboTipoUsuario.SelectedValueChanged
        If salto Then Exit Sub
        If CboTipoUsuario.SelectedValue = 2 Then
            MaterialLabel7.Visible = True
            CboEquipo.Visible = True
        Else
            MaterialLabel7.Visible = False
            CboEquipo.Visible = False
        End If
    End Sub

    Private Sub CargarTipoUsuarios()
        Dim items As New List(Of Item)
        If UCase(VariablesAPP.RolUsuario) = UCase("admin") Then
            items.Add(New Item With {.Value = 1, .Description = "Entrenador"})
        End If
        items.Add(New Item With {.Value = 2, .Description = "Jugador"})
        CboTipoUsuario.DataSource = items
        CboTipoUsuario.ValueMember = "Value"
        CboTipoUsuario.DisplayMember = "Description"
    End Sub

    Public Class Item
        Public Property Value As Integer
        Public Property Description As String
    End Class


    Private Sub Usuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Consulta()
        salto = True
        CargarTipoUsuarios()
        salto = False
        CboTipoUsuario.SelectedValue = 2
    End Sub

    Private Sub CargarClienteDeConsulta(idUsuario As Integer)
        Dim rs As New ADODB.Recordset
        rs.Open("select * from usuarios where idusuario = " & idUsuario, Database.Connection, ADODB.CursorTypeEnum.adOpenForwardOnly, ADODB.LockTypeEnum.adLockOptimistic, 1)
        If rs.EOF Then Exit Sub : Nuevo()
        TxID.Text = CInt(rs("IDusuario").Value)
        TxNombre.Text = Trim(rs("Nombre").Value)
        TxApellido.Text = Trim(rs("apellido").Value)
        TxDNI.Text = Trim(rs("DNI").Value)
        DTPfechaNac.Value = CDate(rs("fechaNacimiento").Value)
        TxTelefono.Text = Trim(rs("Telefono").Value)
        TxDireccion.Text = Trim(rs("Direccion").Value)
        TxPais.Text = Trim(rs("Pais").Value)
        TxLocalidad.Text = Trim(rs("Poblacion").Value)
        TxProvincia.Text = Trim(rs("Provincia").Value)
        If Trim(rs("Rol").Value) = "1" Then
            CboTipoUsuario.SelectedValue = 1
        Else
            CboTipoUsuario.SelectedValue = 2
        End If

    End Sub

    Private Sub DbgUsuarios_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DbgUsuarios.CellContentDoubleClick
        CargarClienteDeConsulta(CInt(DbgUsuarios.Rows(e.RowIndex).Cells(0).Value))
    End Sub

    Private Sub TxID_KeyDown(sender As Object, e As KeyEventArgs) Handles TxID.KeyDown, TxNombre.KeyDown, TxApellido.KeyDown, TxDNI.KeyDown, TxTelefono.KeyDown, DTPfechaNac.KeyDown, TxDireccion.KeyDown, TxPais.KeyDown, TxProvincia.KeyDown, TxLocalidad.KeyDown, CboEquipo.KeyDown, CboTipoUsuario.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub LostFocus1(sender As Object, e As EventArgs) Handles TxID.LostFocus
        If Trim(TxID.Text) = "" And Not IsNumeric(TxID.Text) Then Exit Sub
        rsAux = New ADODB.Recordset
        rsAux.Open("Select * from usuarios where IDusuario = " & CInt(TxID.Text), Database.Connection, ADODB.CursorTypeEnum.adOpenForwardOnly, ADODB.LockTypeEnum.adLockOptimistic, 1)
        If Not rsAux.EOF Then CargarClienteDeConsulta(CInt(rsAux("IDusuario").Value))
        Nuevo()
    End Sub

    Private Sub BtnFiltrar_Click(sender As Object, e As EventArgs) Handles BtnFiltrar.Click
        Consulta()
    End Sub

    Private Sub TxNombre_Click(sender As Object, e As EventArgs) Handles TxNombre.Click, TxID.Click, TxApellido.Click, TxDNI.Click, TxTelefono.Click, TxDireccion.Click, TxPais.Click, TxProvincia.Click, TxLocalidad.Click, CboEquipo.Click, CboTipoUsuario.Click, TxApellidoBus.Click, TxNombreBus.Click, TxDNIbus.Click, TxIDbus.Click
        If sender.text.length > 0 Then
            sender.SelectAll()
        End If
    End Sub


    Private Sub CargarEquiposEntrenado()

    End Sub
End Class