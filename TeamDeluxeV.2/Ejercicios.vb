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
                rsEjercicios("idEjercicios").Value = CInt(rsAux("idEjercicios").Value) + 1
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

    Private Sub CargarObjetivos()
        rsAux = New ADODB.Recordset
        'Mirar con javeier a ver si poner el id del entrenador en la tabla de objetivos esta bien, para poder filtar
        'por los objetivos que ha creado un usuario
        rsAux.Open("Select * from Objetivos", Database.Connection, ADODB.CursorTypeEnum.adOpenForwardOnly, ADODB.LockTypeEnum.adLockOptimistic, 1)
        Do Until rsAux.EOF
            Dim newRow As DataGridViewRow = New DataGridViewRow()
            newRow.CreateCells(DbgObjetivos)
            newRow.Cells(0).Value = CInt(rsAux("IDobjetivo").Value)
            newRow.Cells(1).Value = Trim(rsAux("Descripcion").Value)
            DbgObjetivos.Rows.Add(newRow)
            rsAux.MoveNext()
        Loop
    End Sub
End Class