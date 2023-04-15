Imports System.Net.Http
Imports System.Windows.Forms

Public Class MDI_Principal
    Dim formu As Form
    Dim FormUsuarios As New Usuarios
    Dim FormEntrenamientos As New Usuarios
    Dim FormEjercicios As New Usuarios
    Dim FormObjetivos As New Usuarios
    Private Sub ShowNewForm(ByVal sender As Object, ByVal e As EventArgs) Handles MDIusuarios.Click, MDIentrenamientos.Click, MDIejercicios.Click, MDIobjetivos.Click
        Select Case sender.name
            Case MDIusuarios.Name : AbrirFormu("Usuarios")
            Case MDIentrenamientos.Name : AbrirFormu("Entrenamientos")
            Case MDIejercicios.Name : AbrirFormu("Ejercicios")
            Case MDIobjetivos.Name : AbrirFormu("Objetivos")
        End Select


    End Sub

    Private Sub AbrirFormu(Nombreformu As String)
        Select Case Nombreformu
            Case "Usuarios"
                FormUsuarios.MdiParent = Me
                FormUsuarios.Show()
            Case "Entrenamientos"
                FormEntrenamientos.MdiParent = Me
                FormEntrenamientos.Show()
            Case "Ejercicios"
                FormEjercicios.MdiParent = Me
                FormEjercicios.Show()
            Case "Objetivos"
                FormObjetivos.MdiParent = Me
                FormObjetivos.Show()
        End Select
    End Sub
    Private Sub BtnSalirInicio_Click(sender As Object, e As EventArgs) Handles BtnSalirInicio.Click
        Me.Dispose()
        Inicio.Show()
    End Sub

    Private Sub MDI_Principal_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If MsgBox("Desea salir de TeamDeluxe?", vbOKCancel) = vbOK Then
            Me.Dispose()
            Inicio.Show()
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
        Dim str As String
        formu = Me.ActiveMdiChild
        Select Case sender.name
            Case BtnMDINuevo.Name
                str = "Nuevo"
            Case BtnMDIGuardar.Name
                str = "Guardar"
            Case BtnMDIEliminar.Name
                str = "Eliminar"
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
