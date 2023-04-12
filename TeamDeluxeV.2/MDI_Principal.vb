Imports System.Net.Http
Imports System.Windows.Forms

Public Class MDI_Principal

    Private Sub ShowNewForm(ByVal sender As Object, ByVal e As EventArgs) Handles MDIusuarios.Click, MDIentrenamientos.Click, MDIejercicios.Click, MDIobjetivos.Click
        Select Case sender.name
            Case MDIusuarios.Name : AbrirFormu("Usuarios")
            Case MDIentrenamientos.Name : AbrirFormu("Entrenamientos")
            Case MDIejercicios.Name : AbrirFormu("Ejercicios")
            Case MDIobjetivos.Name : AbrirFormu("Objetivos")
        End Select


    End Sub

    Private Sub AbrirFormu(Nombreformu As String)
        Dim ChildForm As New System.Windows.Forms.Form
        ChildForm.Name = Nombreformu
        ChildForm.Location = New Point(0, 0)
        ChildForm.MdiParent = Me
        ChildForm.Show()
    End Sub


    Private Sub OpenFile(ByVal sender As Object, ByVal e As EventArgs)
        Dim OpenFileDialog As New OpenFileDialog
        OpenFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        OpenFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*"
        If (OpenFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = OpenFileDialog.FileName
            ' TODO: Add code here to open the file.
        End If
    End Sub

    Private Sub SaveAsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim SaveFileDialog As New SaveFileDialog
        SaveFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        SaveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*"

        If (SaveFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = SaveFileDialog.FileName
            ' TODO: Add code here to save the current contents of the form to a file.
        End If
    End Sub

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub

    Private m_ChildFormNumber As Integer

    Private Sub MDI_Principal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Inicio.Close()
    End Sub

End Class
