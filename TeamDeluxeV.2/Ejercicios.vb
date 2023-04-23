Imports System.Drawing.Drawing2D
Imports System.Drawing.Imaging
Imports System.IO
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
        If Trim(TxNombre.Text) = "" Then
            MsgBox("Introduzca un nombre para el entrenamiento", vbExclamation)
            Exit Sub
        End If
        If DbgObjetivosEjercicios.RowCount = 0 Then
            MsgBox("No puedes guardar un ejercicio si no tiene un objetivo", vbExclamation)
            Exit Sub
        End If
        rsEjercicios = New ADODB.Recordset
        rsEjercicios.Open("Select * from ejercicios where id = " & Trim(TxID.Text), Database.Connection, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic, 1)
        If rsEjercicios.EOF Then

            rsAux = New ADODB.Recordset
            rsAux.Open("select top 1 from ejercicios order by idejercicio desc", Database.Connection, ADODB.CursorTypeEnum.adOpenForwardOnly, ADODB.LockTypeEnum.adLockOptimistic, 1)
            If rsAux.EOF Then
                rsEjercicios("idEjercicios").Value = 1
            Else
                rsEjercicios("idEjercicios").Value = CInt(rsAux("idEjercicios").Value)
            End If
            rsEjercicios.AddNew()
            rsEjercicios("Nombre").Value = Trim(TxNombre.Text)
            rsEjercicios("Descripcion").Value = Trim(TxDescripcion.Text)
            rsEjercicios("Observaciones").Value = Trim(TxObservaciones.Text)
            rsEjercicios("Material").Value = Trim(TxMaterial.Text)
            rsEjercicios("NumJugadores").Value = CInt(TxJugadores.Text)
            rsEjercicios("NumPorteros").Value = CInt(TxPorteros.Text)
            rsEjercicios("RutaImagen").Value = Trim(PBImagenCampo.Tag)

            rsAux = New ADODB.Recordset
            rsAux.Open("Select * from ObjetivosEjercicios", Database.Connection, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic, 1)
            For i As Integer = 0 To DbgObjetivosEjercicios.Rows.Count - 1
                rsAux("idEjercicios").Value = CInt(rsEjercicios("idEjercicios").Value)
                rsAux("idObjetivo").Value = CInt(DbgObjetivosEjercicios.Rows(i).Cells("ID").Value)
            Next
            rsAux.Update()


        End If
        rsEjercicios.Update()
    End Sub


    Public Sub Consulta()

    End Sub

    Public Sub Eliminar()

    End Sub

    Public Sub Nuevo()

    End Sub
End Class