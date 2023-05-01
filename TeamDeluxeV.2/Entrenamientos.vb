Public Class Entrenamientos
    Dim rsentrenameintos As New ADODB.Recordset
    Dim rsAux As New ADODB.Recordset

    Public Sub Nuevo()
        TxID.Text = "" : DateTimePicker1.Value = Now.Date
        CboEquipo.SelectedIndex = 0 : CboLugar.SelectedIndex = 0
        TxHoraFin.Text = "00:00" : TxHoraInicio.Text = "00:00"
        TxTiempoGuardar.Text = "00:00" : CboObjetivoGuardar.SelectedIndex = 0 : CboEjercicioGuardar.SelectedIndex = 0
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

    End Sub
    Public Sub Eliminar()

    End Sub

    Private Sub TxID_KeyDown(sender As Object, e As KeyEventArgs) Handles TxID.KeyDown
        Dim rs As New ADODB.Recordset
        If TxID.Text = "" Or TxID.Text = 0 Then Exit Sub
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
        rsAux.Open("select * from entrenamientos
            inner join Objetivos_Entrenamiento on entrenamientos.identrenamiento = Objetivos_Entrenamiento.identrenamiento
            Inner join Objetivos ON Objetivos_Entrenamiento.idobjetivo = Objetivos.idobjetivo
            inner join Ejercicios ON Objetivos_Entrenamiento.idejercicio = ejercicios.idejercicios where identrenamiento = " & CInt(TxID.Text), Database.Connection, ADODB.CursorTypeEnum.adOpenForwardOnly, ADODB.LockTypeEnum.adLockOptimistic, 1)

        Do Until rsAux.EOF
            Dim newRow As DataGridViewRow = New DataGridViewRow()
            newRow.CreateCells(DbgEntrenamiento)
            newRow.Cells(0).Value = CInt(rsAux("IDobjetivo").Value) ' Tiempo
            newRow.Cells(1).Value = Trim(rsAux("Descripcion").Value) ' IdObjetivo
            newRow.Cells(2).Value = Trim(rsAux("Descripcion").Value) ' DescripcionObje
            newRow.Cells(3).Value = Trim(rsAux("Descripcion").Value) ' IdEjercicio
            newRow.Cells(4).Value = Trim(rsAux("Descripcion").Value) ' Descripcion Ejer
            rsAux.MoveNext()
            DbgEntrenamiento.Rows.Add(newRow)
        Loop
    End Sub

    Private Sub CargarEquipos()
        Dim rs As New ADODB.Recordset
        Dim items As New List(Of ItemCBO)
        rs.Open("Select * from equipos where idusuario = " & VariablesAPP.IdUsuarioApp, Database.Connection, ADODB.CursorTypeEnum.adOpenForwardOnly, ADODB.LockTypeEnum.adLockOptimistic, 1)
        Do Until rs.EOF
            items.Add(New ItemCBO With {.Value = CInt(rsAux("idequipos").Value), .Description = Trim(rsAux("nombre").Value)})
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
            items.Add(New ItemCBO With {.Value = CInt(rsAux("idubicacion").Value), .Description = Trim(rsAux("nombre").Value)})
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
            items.Add(New ItemCBO With {.Value = CInt(rsAux("idobjetivo").Value), .Description = Trim(rsAux("Descripcion").Value)})
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
            items.Add(New ItemCBO With {.Value = CInt(rsAux("idejercicios").Value), .Description = Trim(rsAux("Nombre").Value)})
            rs.MoveNext()
        Loop
        CboEjercicioGuardar.DataSource = items
        CboEjercicioGuardar.ValueMember = "Value"
        CboEjercicioGuardar.DisplayMember = "Description"
    End Sub

    Private Sub DbgObjetivos_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DbgEntrenamiento.CellContentDoubleClick

    End Sub

    Private Sub BtnAniadirGrid_Click(sender As Object, e As EventArgs) Handles BtnAniadirGrid.Click

    End Sub

    Private Sub Entrenamientos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Nuevo()
        CargarEquipos()
        CargarEquipos()
        cargarObjetivos()
        CragarEjercicios(1)
    End Sub
End Class