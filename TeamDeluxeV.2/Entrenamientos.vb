Imports System.Globalization

Public Class Entrenamientos
    Dim rsentrenameintos As New ADODB.Recordset
    Dim rsAux As New ADODB.Recordset
    Dim SaltoCombo As Boolean = True
    Dim hora As DateTime

    Public Sub Nuevo()
        TxID.Text = "" : DateTimePicker1.Value = Now.Date
        If Not SaltoCombo Then
            CboEquipo.SelectedIndex = 0 : CboLugar.SelectedIndex = 0
            CboObjetivoGuardar.SelectedIndex = 0 : CboEjercicioGuardar.SelectedIndex = 0
        End If
        TxHoraFin.Text = "00:00" : TxHoraInicio.Text = "00:00"
        TxTiempoGuardar.Text = "00:00"
        TxNombre.Text = "" : TxPorteros.Text = "" : TxJugadores.Text = ""
        TxDescripcionEjer.Text = "" : TxMaterialEjer.Text = ""
        TxDescripcion.Text = ""
        DbgEntrenamiento.Rows.Clear()
        For Each c As Control In PBImagenCampo.Controls
            c.Dispose()
        Next
        PBImagenCampo.Invalidate()
    End Sub


    Public Sub Guardar()
        If MsgBox("Desea Guardar el entrenamiento", vbQuestion) = vbOK Then
            rsentrenameintos = New ADODB.Recordset
            rsentrenameintos.Open("Select * from entrenamientos where identrenamiento = " & IIf(Trim(TxID.Text) = "", 0, Trim(TxID.Text)), Database.Connection, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic, 1)
            If rsentrenameintos.EOF Then
                rsentrenameintos.AddNew()
                rsAux = New ADODB.Recordset
                rsAux.Open("Select top 1 identrenamiento from entrenamientos order by identrenamiento desc", Database.Connection, ADODB.CursorTypeEnum.adOpenForwardOnly, ADODB.LockTypeEnum.adLockOptimistic, 1)
                If rsAux.EOF Then
                    rsentrenameintos("identrenamiento").Value = 1
                Else
                    rsentrenameintos("identrenamiento").Value = CInt(rsAux("identrenamiento").Value) + 1
                End If
            End If

            rsentrenameintos("FechaCreacion").Value = Format(CDate(DateTimePicker1.Value), "yyyy/MM/dd")
            rsentrenameintos("idequipo").Value = CInt(CboEquipo.SelectedValue)
            rsentrenameintos("idusuario").Value = CInt(VariablesAPP.IdUsuarioApp)
            rsentrenameintos("idubicacon").Value = CInt(CboLugar.SelectedValue)
            rsentrenameintos("HoraIni").Value = Format(CDate(TxHoraInicio.Text), "HH:mm")
            rsentrenameintos("HoraFin").Value = Format(CDate(TxHoraFin.Text), "HH:mm")
            rsentrenameintos.Update()

            Database.Connection.Execute("delete from Objetivos_Entrenamiento where idejercicio = " & rsentrenameintos("identrenamiento").Value)
            rsAux = New ADODB.Recordset
            rsAux.Open("Select * from Objetivos_Entrenamiento where idejercicio = 999", Database.Connection, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic, 1)

            For i As Integer = 0 To DbgEntrenamiento.Rows.Count - 2
                rsAux.AddNew()
                rsAux("Tiempo").Value = CDate(DbgEntrenamiento.Rows(i).Cells("Tiempo").Value)
                rsAux("idObjetivo").Value = CInt(DbgEntrenamiento.Rows(i).Cells("IDObj").Value)
                rsAux("identrenamiento").Value = CInt(rsentrenameintos("identrenamiento").Value)
                rsAux("idejercicio").Value = CInt(DbgEntrenamiento.Rows(i).Cells("IdEjercicio").Value)
                rsAux.Update()
            Next
        End If
    End Sub
    Public Sub Eliminar()

    End Sub

    Private Sub TxID_KeyDown(sender As Object, e As KeyEventArgs) Handles TxID.KeyDown
        Dim rs As New ADODB.Recordset
        If IsNumeric(Trim(TxID.Text)) Then
            MsgBox("Introduzca un numero de entrenamiento valido", vbExclamation)
            Exit Sub
        End If
        rs.Open("Select * from entrenamientos where identrenamiento = " & CInt(TxID.Text) &
            " and idusuario = " & VariablesAPP.IdUsuarioApp, Database.Connection, ADODB.CursorTypeEnum.adOpenForwardOnly, ADODB.LockTypeEnum.adLockOptimistic, 1)
        If rs.EOF Then Exit Sub
        TxID.Text = Trim(rs("identrenamiento").Value)
        DateTimePicker1.Value = rs("FechaCreacion").Value
        TxHoraInicio.Text = Format(Trim(rs("HoraIni").Value), "HH:mm")
        TxHoraFin.Text = Format(Trim(rs("HoraFin").Value), "HH:mm")
        TxPorteros.Text = Trim(rs("NumPorteros").Value)
        TxJugadores.Text = Trim(rs("NumJugadores").Value)
        CboEquipo.SelectedValue = CInt(rs("NumJugadores").Value)
        CboLugar.SelectedValue = CInt(rs("idubicacion").Value)

        rsAux = New ADODB.Recordset
        rsAux.Open("select Objetivos_Entrenamiento.tiempo, objetivos.idobjetivo, objetivos.descripcion, ejercicios.idejercicios, ejercicios.nombre from entrenamientos
            inner join Objetivos_Entrenamiento on entrenamientos.identrenamiento = Objetivos_Entrenamiento.identrenamiento
            Inner join Objetivos ON Objetivos_Entrenamiento.idobjetivo = Objetivos.idobjetivo
            inner join Ejercicios ON Objetivos_Entrenamiento.idejercicio = ejercicios.idejercicios where identrenamiento = " & CInt(TxID.Text), Database.Connection, ADODB.CursorTypeEnum.adOpenForwardOnly, ADODB.LockTypeEnum.adLockOptimistic, 1)

        Do Until rsAux.EOF
            Dim newRow As DataGridViewRow = New DataGridViewRow()
            newRow.CreateCells(DbgEntrenamiento)
            newRow.Cells(0).Value = CInt(rsAux("tiempo").Value) ' Tiempo
            newRow.Cells(1).Value = Trim(rsAux("idobjetivo").Value) ' IdObjetivo
            newRow.Cells(2).Value = Trim(rsAux("Descripcion").Value) ' DescripcionObje
            newRow.Cells(3).Value = Trim(rsAux("idejercicios").Value) ' IdEjercicio
            newRow.Cells(4).Value = Trim(rsAux("nombre").Value) ' Descripcion Ejer
            rsAux.MoveNext()
            DbgEntrenamiento.Rows.Add(newRow)
        Loop
    End Sub

    Private Sub CargarEquipos()
        Dim rs As New ADODB.Recordset
        Dim items As New List(Of ItemCBO)
        rs.Open("Select * from equipos where idusuario = " & VariablesAPP.IdUsuarioApp, Database.Connection, ADODB.CursorTypeEnum.adOpenForwardOnly, ADODB.LockTypeEnum.adLockOptimistic, 1)
        Do Until rs.EOF
            items.Add(New ItemCBO With {.Value = CInt(rs("idequipos").Value), .Description = Trim(rs("nombre").Value)})
            rs.MoveNext()
        Loop
        CboEquipo.DataSource = items
        CboEquipo.ValueMember = "Value"
        CboEquipo.DisplayMember = "Description"
    End Sub

    Private Sub CargarUbicaciones()
        If CboEquipo.SelectedValue = Nothing Or CboEquipo.SelectedValue = 0 Then Exit Sub
        Dim rs As New ADODB.Recordset
        Dim items As New List(Of ItemCBO)
        rs.Open("Select * from ubicaciones where idequipo = " & CInt(CboEquipo.SelectedValue), Database.Connection, ADODB.CursorTypeEnum.adOpenForwardOnly, ADODB.LockTypeEnum.adLockOptimistic, 1)
        Do Until rs.EOF
            items.Add(New ItemCBO With {.Value = CInt(rs("idubicacion").Value), .Description = Trim(rs("nombre").Value)})
            rs.MoveNext()
        Loop
        CboLugar.DataSource = items
        CboLugar.ValueMember = "Value"
        CboLugar.DisplayMember = "Description"
    End Sub

    Private Sub cargarObjetivos()
        Dim rs As New ADODB.Recordset
        Dim items As New List(Of ItemCBO)
        rs.Open("Select * from objetivos", Database.Connection, ADODB.CursorTypeEnum.adOpenForwardOnly, ADODB.LockTypeEnum.adLockOptimistic, 1)
        Do Until rs.EOF
            items.Add(New ItemCBO With {.Value = CInt(rs("idobjetivo").Value), .Description = Trim(rs("Descripcion").Value)})
            rs.MoveNext()
        Loop
        CboObjetivoGuardar.DataSource = items
        CboObjetivoGuardar.ValueMember = "Value"
        CboObjetivoGuardar.DisplayMember = "Description"
    End Sub

    Private Sub CragarEjercicios(idObjetivo As Integer)
        If idObjetivo = 0 Then Exit Sub
        Dim rs As New ADODB.Recordset
        Dim items As New List(Of ItemCBO)
        rs.Open("select Ejercicios.* from Ejercicios 
            Inner JOIN ObjetivosEjercicios on Ejercicios.IdEjercicios = ObjetivosEjercicios.IdEjercicios 
            and ObjetivosEjercicios.Idobjetivo = " & CInt(idObjetivo), Database.Connection, ADODB.CursorTypeEnum.adOpenForwardOnly, ADODB.LockTypeEnum.adLockOptimistic, 1)
        Do Until rs.EOF
            items.Add(New ItemCBO With {.Value = CInt(rs("idejercicios").Value), .Description = Trim(rs("Nombre").Value)})
            rs.MoveNext()
        Loop
        CboEjercicioGuardar.DataSource = items
        CboEjercicioGuardar.ValueMember = "Value"
        CboEjercicioGuardar.DisplayMember = "Description"
    End Sub

    Private Sub DbgObjetivos_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DbgEntrenamiento.CellContentDoubleClick

    End Sub

    Private Sub BtnAniadirGrid_Click(sender As Object, e As EventArgs) Handles BtnAniadirGrid.Click

        Dim newRow As DataGridViewRow = New DataGridViewRow()
        If DateTime.TryParseExact(TxTiempoGuardar.Text, "HH:mm", CultureInfo.InvariantCulture, DateTimeStyles.AdjustToUniversal, hora) Then
            newRow.CreateCells(DbgEntrenamiento)
            newRow.Cells(0).Value = Format(CDate(TxTiempoGuardar.Text), "HH:mm") ' Tiempo
            newRow.Cells(1).Value = Trim(CboObjetivoGuardar.SelectedValue) ' IdObjetivo
            newRow.Cells(2).Value = Trim(CboObjetivoGuardar.Text) ' DescripcionObje
            newRow.Cells(3).Value = Trim(CboEjercicioGuardar.SelectedValue) ' IdEjercicio
            newRow.Cells(4).Value = Trim(CboEjercicioGuardar.Text)  ' Descripcion Ejer
            DbgEntrenamiento.Rows.Add(newRow)
            TxTiempoGuardar.Text = "00:00"
            CboObjetivoGuardar.SelectedIndex = 0
            CboEjercicioGuardar.SelectedIndex = 0
        Else
            MsgBox("Introduzca una hora valida", vbExclamation)
            Nuevo()
            Exit Sub
        End If
    End Sub

    Private Sub Entrenamientos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Nuevo()
        CargarEquipos()
        CargarUbicaciones()
        cargarObjetivos()
        CragarEjercicios(1)
        SaltoCombo = False
    End Sub

    Private Sub CargarGridConsulta()
        DbgBusEntreno.Rows.Clear()
        Dim rs As New ADODB.Recordset
        rs.Open("select Entrenamientos.idEntrenamiento, Entrenamientos.FechaCreacion,  equipos.nombre nombreEquipo, Ubicaciones.Nombre nombreUbi, Entrenamientos.HoraIni, Entrenamientos.HoraFin from entrenamientos 
            inner join Equipos on Equipos.IdEquipos = Entrenamientos.idEquipo
            inner join Ubicaciones on Entrenamientos.idUbicacon = Ubicaciones.Idubicacion", Database.Connection, ADODB.CursorTypeEnum.adOpenForwardOnly, ADODB.LockTypeEnum.adLockOptimistic, 1)



        Do Until rs.EOF
            Dim newRow As DataGridViewRow = New DataGridViewRow()
            newRow.CreateCells(DbgBusEntreno)
            newRow.Cells(0).Value = CInt(rs("idEntrenamiento").Value) ' Tiempo
            newRow.Cells(1).Value = CDate(rs("FechaCreacion").Value) ' IdObjetivo
            newRow.Cells(2).Value = Trim(rs("nombreEquipo").Value) ' DescripcionObje
            newRow.Cells(3).Value = Trim(rs("nombreUbi").Value) ' IdEjercicio
            newRow.Cells(4).Value = Format(CDate(rs("horaini").Value), "HH:mm")
            newRow.Cells(5).Value = Format(CDate(rs("horaFin").Value), "HH:mm")
            DbgBusEntreno.Rows.Add(newRow)
            rs.MoveNext()
        Loop

    End Sub


    Private Sub TxHoraInicio_LostFocus(sender As Object, e As EventArgs) Handles TxHoraInicio.LostFocus, TxHoraFin.LostFocus, TxTiempoGuardar.LostFocus
        If Not DateTime.TryParseExact(sender.Text, "HH:mm", CultureInfo.InvariantCulture, DateTimeStyles.AdjustToUniversal, hora) Then
            MsgBox("Introduzca una hora valida para el entrenamiento", vbExclamation)
            sender.text = "00:00"
            Exit Sub
        End If
    End Sub

    Private Sub CboObjetivoGuardar_SelectedValueChanged(sender As Object, e As EventArgs) Handles CboObjetivoGuardar.SelectedValueChanged
        If SaltoCombo Then Exit Sub
        CragarEjercicios(CInt(CboObjetivoGuardar.SelectedValue))
    End Sub

    Private Sub BtnFiltrar_Click(sender As Object, e As EventArgs) Handles BtnFiltrar.Click
        CargarGridConsulta()
    End Sub


    'select * from entrenamientos 
    'Inner join Objetivos_Entrenamiento On Objetivos_Entrenamiento.idEntrenamiento = Entrenamientos.idEntrenamiento
    'inner join Objetivos on Objetivos.Idobjetivo = Objetivos_Entrenamiento.Idobjetivo
    'inner join Ejercicios on Ejercicios.IdEjercicios = Objetivos_Entrenamiento.idejercicio
End Class