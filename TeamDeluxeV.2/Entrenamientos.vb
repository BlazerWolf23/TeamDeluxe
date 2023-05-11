Imports System.Globalization
Imports System.IO

Public Class Entrenamientos
    Dim rsentrenameintos As New ADODB.Recordset
    Dim rsAux As New ADODB.Recordset
    Dim SaltoCombo As Boolean = True
    Dim hora As DateTime

    Public Sub Nuevo()
        TxID.Text = "" : DateTimePicker1.Value = Now.Date
        If Not SaltoCombo Then
            CboEquipo.SelectedIndex = 0 : CboLugar.SelectedIndex = 0
            If Not CboObjetivoGuardar.Items.Count <= 0 Then
                CboObjetivoGuardar.SelectedIndex = 0
            End If
            If Not CboEjercicioGuardar.Items.Count <= 0 Then
                CboEjercicioGuardar.SelectedIndex = 0
            End If
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
            rsentrenameintos("descripcion").Value = Trim(TxDescripcion.Text)
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
            If Not CboObjetivoGuardar.Items.Count <= 0 Then
                CboObjetivoGuardar.SelectedIndex = 0
            End If

            If Not CboEjercicioGuardar.Items.Count <= 0 Then
                CboEjercicioGuardar.SelectedIndex = 0
            End If
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
        Dim sql As String = "select Entrenamientos.idEntrenamiento, Entrenamientos.FechaCreacion,  equipos.nombre nombreEquipo, isnull(Ubicaciones.Nombre , '') nombreUbi, Entrenamientos.HoraIni, Entrenamientos.HoraFin from entrenamientos 
            inner join Equipos on Equipos.IdEquipos = Entrenamientos.idEquipo
            left outer join Ubicaciones on Entrenamientos.idUbicacon = Ubicaciones.Idubicacion
            where Entrenamientos.fechaCreacion < '" & Format(CDate(DateTimePicker2.Value), "dd/MM/yyyy") & "'"
        DbgBusEntreno.Rows.Clear()

        If TxIDbus.Text <> "" Then
            sql &= "  and Entrenamientos.identrenamiento = " & CInt(TxIDbus.Text)
        End If

        If TxHoraIniBus.TextLength < 5 Then
            sql &= "  and format(Entrenamientos.horaini, 'hh:mm') = '" & Format(CDate(TxHoraIniBus.Text), "hh:mm") & "'"
        End If

        If TxHoraFinBus.TextLength < 5 Then
            sql &= "  and format(Entrenamientos.horafin, 'hh:mm') = '" & Format(CDate(TxHoraFinBus.Text), "hh:mm") & "'"
        End If



        Dim rs As New ADODB.Recordset
        rs.Open(sql, Database.Connection, ADODB.CursorTypeEnum.adOpenForwardOnly, ADODB.LockTypeEnum.adLockOptimistic, 1)

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

    Private Sub DbgBusEntreno_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DbgBusEntreno.CellDoubleClick
        If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
            CargarEntreno(CInt(DbgBusEntreno.Rows(e.RowIndex).Cells(0).Value))
        End If
    End Sub


    Private Sub CargarEntreno(idEntrenamiento As Integer)
        Dim rs As New ADODB.Recordset
        Dim rsAux2 As New ADODB.Recordset

        rs.Open("select *, isnull(idubicacon, -1) idubicacon1, isnull(descripcion, '') descripcion1  from entrenamientos where identrenamiento = " & idEntrenamiento, Database.Connection, ADODB.CursorTypeEnum.adOpenForwardOnly, ADODB.LockTypeEnum.adLockOptimistic, 1)

        If Not rs.EOF Then
            TxID.Text = CInt(rs("identrenamiento").Value)
            DateTimePicker1.Value = CDate(rs("fechaCreacion").Value)
            CboEquipo.SelectedValue = CInt(rs("idequipo").Value)
            CboLugar.SelectedValue = CInt(rs("idubicacon1").Value)
            TxHoraInicio.Text = Format(CDate(rs("HoraIni").Value), "HH:mm")
            TxHoraFin.Text = Format(CDate(rs("HoraFin").Value), "HH:mm")
            TxDescripcion.Text = Trim(rs("descripcion1").Value)
            rsAux2 = New ADODB.Recordset
            rsAux2.Open("select entrenamientos.identrenamiento, Objetivos_Entrenamiento.tiempo, Objetivos.Idobjetivo, Objetivos.Descripcion, Ejercicios.IdEjercicios, Ejercicios.Nombre from entrenamientos 
                inner join Objetivos_Entrenamiento On Objetivos_Entrenamiento.idEntrenamiento = Entrenamientos.idEntrenamiento
                inner join Objetivos on Objetivos.Idobjetivo = Objetivos_Entrenamiento.Idobjetivo
                inner join Ejercicios on Ejercicios.IdEjercicios = Objetivos_Entrenamiento.idejercicio where Entrenamientos.idEntrenamiento = " & idEntrenamiento, Database.Connection, ADODB.CursorTypeEnum.adOpenForwardOnly, ADODB.LockTypeEnum.adLockOptimistic, 1)

            Do Until rsAux2.EOF
                Dim newRow As DataGridViewRow = New DataGridViewRow()
                newRow.CreateCells(DbgEntrenamiento)
                newRow.Cells(0).Value = Format(CDate(rsAux2("tiempo").Value), "HH:mm") ' ' Tiempo
                newRow.Cells(1).Value = CInt(rsAux2("Idobjetivo").Value) ' IdObjetivo
                newRow.Cells(2).Value = Trim(rsAux2("Descripcion").Value) ' DescripcionObje
                newRow.Cells(3).Value = CInt(rsAux2("IdEjercicios").Value) ' IdEjercicio
                newRow.Cells(4).Value = Trim(rsAux2("Nombre").Value)
                DbgEntrenamiento.Rows.Add(newRow)
                rsAux2.MoveNext()
            Loop
        End If
        TabControl1.SelectedTab = TabEntreno
    End Sub

    'prueba
    Private Sub CargarEjercicio(IDejercicio As Integer)
        Dim imageData As Byte()
        Dim ms As MemoryStream
        Dim img As Image
        Dim rs As New ADODB.Recordset
        rs = New ADODB.Recordset
        rs.Open("Select * from ejercicios where IdEjercicios = " & IDejercicio, Database.Connection, ADODB.CursorTypeEnum.adOpenForwardOnly, ADODB.LockTypeEnum.adLockOptimistic, 1)
        If Not rs.EOF Then
            TxNombre.Text = Trim(rs("nombre").Value)
            TxPorteros.Text = Trim(rs("NumPorteros").Value)
            TxJugadores.Text = Trim(rs("NumJugadores").Value)
            TxDescripcion.Text = Trim(rs("descripcion").Value)
            TxMaterialEjer.Text = Trim(rs("material").Value)
            PBImagenCampo.BackgroundImage = Image.FromFile(rs("RutaImagen").Value)
        End If
    End Sub

    Private Sub DbgEntrenamiento_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DbgEntrenamiento.CellDoubleClick
        If Not IsNumeric(DbgEntrenamiento.Rows(e.RowIndex).Cells(3).Value) Then Exit Sub
        CargarEjercicio(CInt(DbgEntrenamiento.Rows(e.RowIndex).Cells(3).Value))
    End Sub

    'select * from entrenamientos 
    'Inner join Objetivos_Entrenamiento On Objetivos_Entrenamiento.idEntrenamiento = Entrenamientos.idEntrenamiento
    'inner join Objetivos on Objetivos.Idobjetivo = Objetivos_Entrenamiento.Idobjetivo
    'inner join Ejercicios on Ejercicios.IdEjercicios = Objetivos_Entrenamiento.idejercicio
End Class