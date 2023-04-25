Imports System.Data.SqlClient
Imports System.Drawing.Drawing2D
Imports System.Drawing.Imaging
Imports System.IO
Imports System.Net
Imports System.Windows.Forms.LinkLabel
Imports System.Windows.Media
Imports System.Windows.Shapes
Imports MaterialSkin.Controls
Imports Microsoft.VisualBasic.Devices

Public Class Ejercicios
    Dim rsEjercicios As New ADODB.Recordset
    Dim rsAux As New ADODB.Recordset
    Dim lineasSolidas As New List(Of Linea)
    Dim lineasPunteadas As New List(Of Linea)
    Dim saltoPintarLineas As Boolean
    Private Structure Linea
        Public PuntoInicio As Point
        Public PuntoFinal As Point
    End Structure

    Private X1, Y1, X2, Y2 As Integer
    Private selectedImage As Image = Nothing
    Dim AnteriorBoton As MaterialButton = Nothing
    Dim AnteriorBoton2 As MaterialButton = Nothing
    Dim Punteado As Boolean = False

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles BtnPersona.Click, BtnCono.Click
        If sender.UseAccentColor = True Then
            sender.UseAccentColor = False
        Else
            If AnteriorBoton IsNot Nothing Then
                AnteriorBoton.UseAccentColor = False
            End If
            sender.UseAccentColor = True
        End If
        If sender.name = BtnPersona.Name Then
            selectedImage = New Bitmap(sender.BackgroundImage, 20, 20)
        ElseIf sender.name = BtnCono.Name Then
            selectedImage = New Bitmap(sender.BackgroundImage, 10, 10)
        End If
        AnteriorBoton = sender
    End Sub

    Private Sub BtnLineaNomal_Click(sender As Object, e As EventArgs) Handles BtnLineaNomal.Click, BtnLineaPunteada.Click
        If sender.UseAccentColor = True Then
            sender.UseAccentColor = False
        Else
            If AnteriorBoton2 IsNot Nothing Then
                AnteriorBoton2.UseAccentColor = False
            End If
            sender.UseAccentColor = True
        End If
        If sender.name = BtnLineaNomal.Name Then
            Punteado = False
        Else
            Punteado = True
        End If

        AnteriorBoton2 = sender
    End Sub

    Private Sub PictureBox1_MouseClick(sender As Object, e As MouseEventArgs) Handles PBImagenCampo.MouseClick
        If BtnPersona.UseAccentColor = True Or BtnCono.UseAccentColor = True Then
            If selectedImage IsNot Nothing Then
                Dim pictureboxImage As New PictureBox()
                pictureboxImage.Size = selectedImage.Size
                pictureboxImage.BackgroundImage = selectedImage
                pictureboxImage.Location = New Point(e.Location.X - 5, e.Location.Y)
                PBImagenCampo.Controls.Add(pictureboxImage)
            End If
        End If
    End Sub

    Private Sub PictureBox1_Paint(sender As Object, e As PaintEventArgs) Handles PBImagenCampo.Paint
        Dim LapizSolido As New System.Drawing.Pen(System.Drawing.Color.Black, 5)
        Dim LapizPunteado As New System.Drawing.Pen(System.Drawing.Color.Black, 5)
        If saltoPintarLineas Then
            lineasPunteadas.Clear()
            lineasSolidas.Clear()
            saltoPintarLineas = False
            Exit Sub
        End If
        LapizSolido.EndCap = LineCap.ArrowAnchor
        LapizPunteado.EndCap = LineCap.ArrowAnchor
        LapizPunteado.DashStyle = Drawing2D.DashStyle.Dot
        For Each linea In lineasPunteadas
            e.Graphics.DrawLine(LapizPunteado, linea.PuntoInicio, linea.PuntoFinal)
        Next
        For Each linea In lineasSolidas
            e.Graphics.DrawLine(LapizSolido, linea.PuntoInicio, linea.PuntoFinal)
        Next
    End Sub

    Private Sub PictureBox1_MouseDown(sender As Object, e As MouseEventArgs) Handles PBImagenCampo.MouseDown
        X1 = e.X
        Y1 = e.Y
    End Sub
    Private Sub PictureBox1_MouseUp(sender As Object, e As MouseEventArgs) Handles PBImagenCampo.MouseUp
        X2 = e.X
        Y2 = e.Y
        If Punteado Then
            lineasPunteadas.Add(New Linea With {.PuntoInicio = New Point(X1, Y1), .PuntoFinal = New Point(X2, Y2)})
        Else
            lineasSolidas.Add(New Linea With {.PuntoInicio = New Point(X1, Y1), .PuntoFinal = New Point(X2, Y2)})
        End If
        PBImagenCampo.Invalidate()
    End Sub

    Private Sub Vaciarimagen_Click(sender As Object, e As EventArgs) Handles Vaciarimagen.Click
        saltoPintarLineas = True
        For Each c As Control In PBImagenCampo.Controls
            c.Dispose()
        Next
        PBImagenCampo.Invalidate()
    End Sub

    Public Sub Guardar()
        Dim rsObjetivosEjercicios As New ADODB.Recordset
        If Trim(TxNombre.Text) = "" Then
            MsgBox("Introduzca un nombre para el entrenamiento", vbExclamation)
            Exit Sub
        End If
        If DbgObjetivosEjercicios.RowCount = 0 Then
            MsgBox("No puedes guardar un ejercicio si no tiene un objetivo", vbExclamation)
            Exit Sub
        End If
        rsEjercicios = New ADODB.Recordset
        rsEjercicios.Open("Select * from ejercicios where idejercicios = " & IIf(Trim(TxID.Text) = "", 0, Trim(TxID.Text)), Database.Connection, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic, 1)
        If rsEjercicios.EOF Then
            rsEjercicios.AddNew()
            rsAux = New ADODB.Recordset
            rsAux.Open("select top 1 idejercicios from ejercicios order by idejercicios desc", Database.Connection, ADODB.CursorTypeEnum.adOpenForwardOnly, ADODB.LockTypeEnum.adLockOptimistic, 1)
            If rsAux.EOF Then
                rsEjercicios("idEjercicios").Value = 1
            Else
                rsEjercicios("idEjercicios").Value = CInt(rsAux("idEjercicios").Value) + 1
            End If
        End If
        rsEjercicios("Nombre").Value = Trim(TxNombre.Text)
            rsEjercicios("Descripcion").Value = Trim(TxDescripcion.Text)
            rsEjercicios("Observaciones").Value = Trim(TxObservaciones.Text)
            rsEjercicios("Material").Value = Trim(TxMaterial.Text)
            rsEjercicios("NumJugadores").Value = CInt(TxJugadores.Text)
            rsEjercicios("NumPorteros").Value = CInt(TxPorteros.Text)
        rsEjercicios("RutaImagen").Value = Trim(PBImagenCampo.Tag)

        Dim bmp As New Bitmap(PBImagenCampo.Width, PBImagenCampo.Height)
        Dim gfx As Graphics = Graphics.FromImage(bmp)
        PBImagenCampo.DrawToBitmap(bmp, PBImagenCampo.ClientRectangle)
        Dim ms As New MemoryStream()
        bmp.Save(ms, System.Drawing.Imaging.ImageFormat.Png)
        rsEjercicios("imagenEjer").Value = ms.GetBuffer

        rsEjercicios.Update()

            Database.Connection.Execute("Delete from ObjetivosEjercicios where idEjercicios = " & CInt(rsEjercicios("idEjercicios").Value))
            rsAux = New ADODB.Recordset
            rsAux.Open("Select * from ObjetivosEjercicios", Database.Connection, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic, 1)
            For i As Integer = 0 To DbgObjetivosEjercicios.Rows.Count - 2
                rsAux.AddNew()
                rsAux("idEjercicios").Value = CInt(rsEjercicios("idEjercicios").Value)
                rsAux("idObjetivo").Value = CInt(DbgObjetivosEjercicios.Rows(i).Cells("ID").Value)
                rsAux.Update()
            Next


            TxID.Text = CInt(rsAux("idEjercicios").Value)
    End Sub


    Public Sub Consulta()
        ' Mirar a ver si podemos hacer un tab para hacer la consulta de ejercicios
    End Sub

    Private Sub MaterialButton6_Click(sender As Object, e As EventArgs) Handles BtnNuevoObjetivo.Click
        Dim ID As Integer
        If Trim(TxNombreNuvObjetivo.Text) = "" Then
            MsgBox("No se puede guardar, el nombre esta vacio", vbExclamation)
            Exit Sub
        End If

        If MsgBox("Desea Guardar el Objetivo como '" & Trim(TxNombreNuvObjetivo.Text) & "'", vbQuestion) = MsgBoxResult.Ok Then
            rsEjercicios = New ADODB.Recordset
            rsEjercicios.Open("Select * from Objetivos where idobjetivo = 0", Database.Connection, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic, 1)
            Try
                rsAux = New ADODB.Recordset
                rsAux.Open("select top 1 idobjetivo from Objetivos order by idobjetivo desc", Database.Connection, ADODB.CursorTypeEnum.adOpenForwardOnly, ADODB.LockTypeEnum.adLockOptimistic, 1)
                If rsAux.EOF Then
                    ID = 1
                Else
                    ID = CInt(rsAux("idobjetivo").Value) + 1
                End If
                rsEjercicios.AddNew()
                rsEjercicios("idobjetivo").Value = CInt(ID)
                rsEjercicios("descripcion").Value = Trim(TxNombreNuvObjetivo.Text)
                rsEjercicios.Update()
            Catch ex As Exception
                MsgBox("Error al guardar el objetivo error(" & ex.Message & ")", vbExclamation)
                Exit Sub
            End Try
        End If
        TxNombreNuvObjetivo.Text = ""
        CargarObjetivos()
    End Sub

    Private Sub BtnExportarImagen_Click(sender As Object, e As EventArgs) Handles BtnExportarImagen.Click



    End Sub

    Private Sub BtnImportarImagen_Click(sender As Object, e As EventArgs) Handles BtnImportarImagen.Click

    End Sub

    Private Sub DbgObjetivos_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DbgObjetivosEjercicios.CellDoubleClick
        DbgObjetivosEjercicios.Rows.RemoveAt(e.RowIndex)
    End Sub

    Private Sub Ejercicios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Nuevo()
    End Sub

    Private Sub DbgObjetivos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DbgObjetivos.CellContentDoubleClick
        AniadirLineaGrid(DbgObjetivos.Rows(e.RowIndex).Cells(0).Value, DbgObjetivos.Rows(e.RowIndex).Cells(1).Value)
    End Sub

    Private Sub AniadirLineaGrid(id As Integer, Descripcion As String)
        Dim newRow As DataGridViewRow = New DataGridViewRow()
        newRow.CreateCells(DbgObjetivosEjercicios)
        newRow.Cells(0).Value = id
        newRow.Cells(1).Value = Descripcion
        DbgObjetivosEjercicios.Rows.Add(newRow)
    End Sub


    Private Sub TxID_KeyDown(sender As Object, e As KeyEventArgs) Handles TxID.KeyDown
        Dim imageData As Byte()
        Dim ms As MemoryStream
        Dim img As Image
        If e.KeyValue = Keys.Enter Then
            If IsNumeric(TxID.Text) Then
                rsAux = New ADODB.Recordset
                rsAux.Open("Select * from ejercicios where idejercicios = " & CInt(TxID.Text), Database.Connection, ADODB.CursorTypeEnum.adOpenForwardOnly, ADODB.LockTypeEnum.adLockOptimistic)
                If Not rsAux.EOF Then
                    TxID.Text = CInt(rsAux("idejercicios").Value)
                    TxNombre.Text = Trim(rsAux("nombre").Value)
                    TxJugadores.Text = CInt(rsAux("numJugadores").Value)
                    TxPorteros.Text = CInt(rsAux("Numporteros").Value)
                    TxDescripcion.Text = Trim(rsAux("descripcion").Value)
                    TxMaterial.Text = Trim(rsAux("material").Value)
                    TxObservaciones.Text = Trim(rsAux("observaciones").Value)

                    imageData = DirectCast(rsAux("imagenEjer").Value, Byte())
                    ms = New MemoryStream(imageData)
                    img = Image.FromStream(ms)
                    PBImagenCampo.BackgroundImage = img

                    CargarObjetivos(CInt(TxID.Text))
                End If
            End If
        End If
    End Sub

    Public Sub Eliminar()
        If Trim(TxID.Text) = "" Then
            MsgBox("Antes de eliminar introduzca un ID de objetivo", vbExclamation)
            Exit Sub
        End If
        If MsgBox("Desea elminar el objetivo con el ID '" & CInt(TxID.Text) & "'", vbQuestion) = vbOK Then
            Try
                Database.Connection.BeginTrans()
                Database.Connection.Execute("Delete from Objetivos where idobjetivo = " & CInt(TxID.Text))
                Database.Connection.CommitTrans()
            Catch ex As Exception
                Database.Connection.RollbackTrans()
                MsgBox("Error al eliminar el objetivo error(" & ex.Message & ")")
            End Try
        End If

    End Sub

    Public Sub Nuevo()
        TxID.Text = "" : TxNombre.Text = ""
        TxDescripcion.Text = "" : TxJugadores.Text = ""
        TxPorteros.Text = "" : TxObservaciones.Text = ""
        TxMaterial.Text = ""
        Vaciarimagen_Click(Vaciarimagen, New EventArgs)
        DbgObjetivosEjercicios.Rows.Clear()
        DbgObjetivos.Rows.Clear()
        CargarObjetivos()
    End Sub

    Private Sub CargarObjetivos(Optional idejercicio As Integer = 0)
        If idejercicio <> 0 Then
            DbgObjetivosEjercicios.Rows.Clear()
        Else
            DbgObjetivos.Rows.Clear()
        End If
        rsAux = New ADODB.Recordset
        Dim sql As String
        If idejercicio <> 0 Then
            sql = "select objetivos.idobjetivo, objetivos.descripcion from objetivos 
                inner join objetivosEjercicios on objetivos.idobjetivo = objetivosEjercicios.idobjetivo
                where idejercicios = " & CInt(idejercicio)
        Else
            sql = "Select * from Objetivos"
        End If
        'poner el id del ususario en la bd acuerdate
        rsAux.Open(sql, Database.Connection, ADODB.CursorTypeEnum.adOpenForwardOnly, ADODB.LockTypeEnum.adLockOptimistic, 1)
        Do Until rsAux.EOF
            Dim newRow As DataGridViewRow = New DataGridViewRow()
            If idejercicio <> 0 Then
                newRow.CreateCells(DbgObjetivosEjercicios)
            Else
                newRow.CreateCells(DbgObjetivos)
            End If
            newRow.Cells(0).Value = CInt(rsAux("IDobjetivo").Value)
            newRow.Cells(1).Value = Trim(rsAux("Descripcion").Value)
            If idejercicio <> 0 Then
                DbgObjetivosEjercicios.Rows.Add(newRow)
            Else
                DbgObjetivos.Rows.Add(newRow)
            End If
            rsAux.MoveNext()
        Loop
    End Sub
End Class