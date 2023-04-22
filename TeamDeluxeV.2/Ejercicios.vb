Imports System.Drawing.Imaging
Imports System.IO
Imports System.Windows.Media
Imports MaterialSkin.Controls
Imports Microsoft.VisualBasic.Devices

Public Class Ejercicios
    Private selectedImage As Image = Nothing
    Private initialClickPosition As Point
    Dim AnteriorBoton As MaterialButton = Nothing
    Private currentPoint As Point
    Private isDrawing As Boolean = False
    Dim brush = Brushes.Black


    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles MaterialButton2.Click, MaterialButton3.Click
        If AnteriorBoton IsNot Nothing Then
            If sender.name <> AnteriorBoton.Name Then
                AnteriorBoton.UseAccentColor = False
            ElseIf sender.name = AnteriorBoton.Name Then
                sender.UseAccentColor = False
                selectedImage = Nothing
                Exit Sub
            End If
        End If
        If sender.name = MaterialButton2.Name Then
            selectedImage = New Bitmap(sender.BackgroundImage, 20, 20)
        ElseIf sender.name = MaterialButton3.Name Then
            selectedImage = New Bitmap(sender.BackgroundImage, 10, 10)
        End If
        AnteriorBoton = sender
        sender.UseAccentColor = True
    End Sub

    Private Sub PictureBox1_MouseClick(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseClick
        ' Verificar si hay una imagen seleccionada
        If selectedImage IsNot Nothing Then
            ' Calcular la posición de destino para la 
            Dim pictureboxImage As New PictureBox()
            pictureboxImage.Size = selectedImage.Size
            pictureboxImage.BackgroundImage = selectedImage
            pictureboxImage.Location = New Point(e.Location.X - 5, e.Location.Y)
            PictureBox1.Controls.Add(pictureboxImage)
        End If
    End Sub

    Private Sub PictureBox1_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseDown
        currentPoint = e.Location
        isDrawing = True
    End Sub

    Private Sub PictureBox1_MouseMove(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseMove
        If isDrawing Then
            PictureBox1.CreateGraphics.DrawLine(Pens.Black, e.X, e.Y, e.X - 1, e.Y - 1)
        End If
    End Sub

    Private Sub PictureBox1_MouseUp(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseUp
        isDrawing = False
    End Sub
End Class