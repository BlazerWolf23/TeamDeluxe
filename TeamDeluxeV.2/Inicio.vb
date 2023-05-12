Imports System.Security.Cryptography
Imports Microsoft.Win32

Public Class Inicio

    Dim FormMDI As New MDI_Principal

    Private Sub BtnConnection_Click(sender As Object, e As EventArgs) Handles BtnConnection.Click
        PanelBD.Visible = True
    End Sub

    Public Sub Inicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.StartPosition = FormStartPosition.CenterScreen
        PanelBD.Visible = False
        TxServerBD.Text = Registry.GetValue("HKEY_CURRENT_USER\SOFTWARE\TeamDeluxe", "ServerSQL", "")
        TxDatabase.Text = Registry.GetValue("HKEY_CURRENT_USER\SOFTWARE\TeamDeluxe", "DatabaseSQL", "")
        TxUserBD.Text = Registry.GetValue("HKEY_CURRENT_USER\SOFTWARE\TeamDeluxe", "UsernameSQL", "")
        TxPasswordBD.Text = Registry.GetValue("HKEY_CURRENT_USER\SOFTWARE\TeamDeluxe", "PasswordSQL", "")
        Try
            Cursor = Cursors.WaitCursor
            Database.InicializarBD(Trim(TxUserBD.Text), Trim(TxPasswordBD.Text), Trim(TxServerBD.Text), Trim(TxDatabase.Text))
            CargarUsuarios()
        Catch ex As Exception

        End Try
        Cursor = Cursors.Arrow
    End Sub

    Private Sub MaterialButton2_Click(sender As Object, e As EventArgs) Handles BtnRealizarConexion.Click
        PanelBD.Visible = False
        Database.InicializarBD(Trim(TxUserBD.Text), Trim(TxPasswordBD.Text), Trim(TxServerBD.Text), Trim(TxDatabase.Text))
        CargarUsuarios()
    End Sub

    Private Sub CargarUsuarios()
        Dim rs As New ADODB.Recordset
        rs.Open("Select * from usuarios where rol in ('entrenador' , 'admin')", Database.Connection, ADODB.CursorTypeEnum.adOpenForwardOnly, ADODB.LockTypeEnum.adLockOptimistic, 1)

        Dim items As New List(Of ItemCBO)
        Do Until rs.EOF
            items.Add(New ItemCBO With {.Value = CInt(rs("idUsuario").Value), .Description = Trim(rs("nombre").Value)})
            rs.MoveNext()
        Loop
        CboUsuarios.DataSource = items
        CboUsuarios.ValueMember = "Value"
        CboUsuarios.DisplayMember = "Description"
        CboUsuarios.SelectedIndex = 0
    End Sub

    Private Sub BtnComprobarContra_Click(sender As Object, e As EventArgs) Handles BtnComprobarContra.Click
        Dim rs As New ADODB.Recordset
        rs.Open("Select password, rol, nombre, idUsuario from usuarios where idUsuario = " & CInt(CboUsuarios.SelectedValue), Connection, ADODB.CursorTypeEnum.adOpenForwardOnly, ADODB.LockTypeEnum.adLockOptimistic, 1)
        If rs.EOF Then Exit Sub
        If Trim(rs("password").Value) = Trim(TxPassword.Text) Then
            Cursor = Cursors.WaitCursor
            FormMDI = Nothing
            FormMDI = New MDI_Principal
            FormMDI.Show()
            Me.Visible = False
            VariablesAPP.IdUsuarioApp = Trim(rs("idUsuario").Value)
            VariablesAPP.UsuarioApp = Trim(rs("Nombre").Value)
            VariablesAPP.RolUsuario = Trim(rs("rol").Value)
            Cursor = Cursors.Arrow
        Else
            MsgBox("Credenciales incorrectas, Compruebe el usuario y la contraseña y inicie sesión de nuevo.", vbExclamation)
            TxPassword.Text = ""
        End If
    End Sub

    Private Sub Inicio_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        End
    End Sub

    Private Sub CboUsuarios_SelectedValueChanged(sender As Object, e As EventArgs) Handles CboUsuarios.SelectedValueChanged
        TxPassword.Text = ""
    End Sub
End Class
