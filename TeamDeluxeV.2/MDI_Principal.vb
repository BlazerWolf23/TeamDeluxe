Imports System.Net.Http
Imports System.Windows.Forms

Public Class MDI_Principal
    Dim formu As Form
    Dim FormUsuarios As New Usuarios
    Dim FormEntrenamientos As New Entrenamientos
    Dim FormEjercicios As New Ejercicios
    Dim formEquipos As New Equipos
    Private Sub ShowNewForm(ByVal sender As Object, ByVal e As EventArgs) Handles MDIusuarios.Click, MDIentrenamientos.Click, MDIejercicios.Click, MDIequipos.Click
        Select Case sender.name
            Case MDIusuarios.Name : AbrirFormu("Usuarios")
            Case MDIentrenamientos.Name : AbrirFormu("Entrenamientos")
            Case MDIejercicios.Name : AbrirFormu("Ejercicios")
            Case MDIequipos.Name : AbrirFormu("Equipos")
        End Select


    End Sub

    Private Sub AbrirFormu(Nombreformu As String)
        Select Case Nombreformu
            Case "Usuarios"
                FormUsuarios = New Usuarios
                FormUsuarios.MdiParent = Me
                FormUsuarios.Show()
            Case "Entrenamientos"
                FormEntrenamientos = New Entrenamientos
                FormEntrenamientos.MdiParent = Me
                FormEntrenamientos.Show()
            Case "Ejercicios"
                FormEjercicios = New Ejercicios
                FormEjercicios.MdiParent = Me
                FormEjercicios.Show()
            Case "Equipos"
                formEquipos = New Equipos
                formEquipos.MdiParent = Me
                formEquipos.Show()
        End Select
    End Sub
    Private Sub BtnSalirInicio_Click(sender As Object, e As EventArgs) Handles BtnSalirInicio.Click
        Me.Dispose()
        Inicio.Inicio_Load(sender, New EventArgs)
        Inicio.Show()
    End Sub

    Private Sub MDI_Principal_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If MsgBox("Desea salir de TeamDeluxe?", vbOKCancel) = vbOK Then
            Me.Dispose()
            End
        Else
            e.Cancel = True
        End If
    End Sub

    Private Sub MDI_Principal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LabelSpacios.Text = Space(250)
    End Sub

    Private Sub BtnCerrarFormulario_Click(sender As Object, e As EventArgs) Handles BtnCerrarFormulario.Click
        ' Encuentra el formulario activo
        formu = Me.ActiveMdiChild

        ' Si hay algún formulario activo, ciérralo
        If formu IsNot Nothing Then
            formu.Close()
        End If
    End Sub

    Private Sub NewToolStripButton_Click(sender As Object, e As EventArgs) Handles BtnMDINuevo.Click, BtnMDIGuardar.Click, BtnMDIEliminar.Click
        formu = Me.ActiveMdiChild
        Select Case sender.name
            Case BtnMDINuevo.Name
                If TypeOf formu Is Entrenamientos Then
                    DirectCast(formu, Entrenamientos).Nuevo()
                End If
                If TypeOf formu Is Ejercicios Then
                    DirectCast(formu, Ejercicios).Nuevo()
                End If
                If TypeOf formu Is Usuarios Then
                    DirectCast(formu, Usuarios).Nuevo()
                End If
                If TypeOf formu Is Equipos Then
                    DirectCast(formu, Equipos).Nuevo()
                End If
            Case BtnMDIGuardar.Name
                If TypeOf formu Is Ejercicios Then
                    DirectCast(formu, Ejercicios).Guardar()
                End If
                If TypeOf formu Is Usuarios Then
                    DirectCast(formu, Usuarios).Guardar()
                End If
                If TypeOf formu Is Equipos Then
                    DirectCast(formu, Equipos).Guardar()
                End If
                If TypeOf formu Is Entrenamientos Then
                    DirectCast(formu, Entrenamientos).Guardar()
                End If
            Case BtnMDIEliminar.Name
                If TypeOf formu Is Ejercicios Then
                    DirectCast(formu, Ejercicios).Eliminar()
                End If
                If TypeOf formu Is Usuarios Then
                    DirectCast(formu, Usuarios).Eliminar()
                End If
                If TypeOf formu Is Equipos Then
                    DirectCast(formu, Equipos).Eliminar()
                End If
                If TypeOf formu Is Entrenamientos Then
                    DirectCast(formu, Entrenamientos).Eliminar()
                End If
        End Select
    End Sub

    ' PARA UN FUTURO SI ME SALE DE LAS PELOTAS NO CAP

    'Private Sub OpenFile(ByVal sender As Object, ByVal e As EventArgs)
    '    Dim OpenFileDialog As New OpenFileDialog
    '    OpenFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
    '    OpenFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*"
    '    If (OpenFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
    '        Dim FileName As String = OpenFileDialog.FileName
    '        ' TODO: Add code here to open the file.
    '    End If
    'End Sub

    'Private Sub SaveAsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
    '    Dim SaveFileDialog As New SaveFileDialog
    '    SaveFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
    '    SaveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*"

    '    If (SaveFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
    '        Dim FileName As String = SaveFileDialog.FileName
    '        ' TODO: Add code here to save the current contents of the form to a file.
    '    End If
    'End Sub


End Class
