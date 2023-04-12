<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Inicio
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Inicio))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PanelBD = New MaterialSkin.Controls.MaterialCard()
        Me.BtnRealizarConexion = New MaterialSkin.Controls.MaterialButton()
        Me.TxPasswordBD = New MaterialSkin.Controls.MaterialTextBox()
        Me.TxUserBD = New MaterialSkin.Controls.MaterialTextBox()
        Me.TxDatabase = New MaterialSkin.Controls.MaterialTextBox()
        Me.TxServerBD = New MaterialSkin.Controls.MaterialTextBox()
        Me.BtnConnection = New MaterialSkin.Controls.MaterialButton()
        Me.BtnComprobarContra = New MaterialSkin.Controls.MaterialButton()
        Me.TxPassword = New MaterialSkin.Controls.MaterialTextBox2()
        Me.CboUsuarios = New MaterialSkin.Controls.MaterialComboBox()
        Me.Panel1.SuspendLayout()
        Me.PanelBD.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel1.Controls.Add(Me.PanelBD)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(476, 100)
        Me.Panel1.TabIndex = 0
        '
        'PanelBD
        '
        Me.PanelBD.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.PanelBD.Controls.Add(Me.BtnRealizarConexion)
        Me.PanelBD.Controls.Add(Me.TxPasswordBD)
        Me.PanelBD.Controls.Add(Me.TxUserBD)
        Me.PanelBD.Controls.Add(Me.TxDatabase)
        Me.PanelBD.Controls.Add(Me.TxServerBD)
        Me.PanelBD.Depth = 0
        Me.PanelBD.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.PanelBD.Location = New System.Drawing.Point(5, 5)
        Me.PanelBD.Margin = New System.Windows.Forms.Padding(14)
        Me.PanelBD.MouseState = MaterialSkin.MouseState.HOVER
        Me.PanelBD.Name = "PanelBD"
        Me.PanelBD.Padding = New System.Windows.Forms.Padding(14)
        Me.PanelBD.Size = New System.Drawing.Size(465, 88)
        Me.PanelBD.TabIndex = 9
        '
        'BtnRealizarConexion
        '
        Me.BtnRealizarConexion.AutoSize = False
        Me.BtnRealizarConexion.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BtnRealizarConexion.BackColor = System.Drawing.Color.Transparent
        Me.BtnRealizarConexion.BackgroundImage = CType(resources.GetObject("BtnRealizarConexion.BackgroundImage"), System.Drawing.Image)
        Me.BtnRealizarConexion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnRealizarConexion.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Dense
        Me.BtnRealizarConexion.Depth = 0
        Me.BtnRealizarConexion.HighEmphasis = True
        Me.BtnRealizarConexion.Icon = Nothing
        Me.BtnRealizarConexion.Image = CType(resources.GetObject("BtnRealizarConexion.Image"), System.Drawing.Image)
        Me.BtnRealizarConexion.ImageAlign = System.Drawing.ContentAlignment.TopRight
        Me.BtnRealizarConexion.Location = New System.Drawing.Point(413, 49)
        Me.BtnRealizarConexion.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.BtnRealizarConexion.MouseState = MaterialSkin.MouseState.HOVER
        Me.BtnRealizarConexion.Name = "BtnRealizarConexion"
        Me.BtnRealizarConexion.NoAccentTextColor = System.Drawing.Color.Empty
        Me.BtnRealizarConexion.Size = New System.Drawing.Size(45, 33)
        Me.BtnRealizarConexion.TabIndex = 9
        Me.BtnRealizarConexion.Text = "BD"
        Me.BtnRealizarConexion.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.BtnRealizarConexion.UseAccentColor = False
        Me.BtnRealizarConexion.UseVisualStyleBackColor = False
        '
        'TxPasswordBD
        '
        Me.TxPasswordBD.AnimateReadOnly = False
        Me.TxPasswordBD.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxPasswordBD.Depth = 0
        Me.TxPasswordBD.Font = New System.Drawing.Font("Roboto", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.TxPasswordBD.Hint = "PasswordBD"
        Me.TxPasswordBD.LeadingIcon = Nothing
        Me.TxPasswordBD.Location = New System.Drawing.Point(205, 49)
        Me.TxPasswordBD.MaxLength = 50
        Me.TxPasswordBD.MouseState = MaterialSkin.MouseState.OUT
        Me.TxPasswordBD.Multiline = False
        Me.TxPasswordBD.Name = "TxPasswordBD"
        Me.TxPasswordBD.Password = True
        Me.TxPasswordBD.Size = New System.Drawing.Size(176, 36)
        Me.TxPasswordBD.TabIndex = 3
        Me.TxPasswordBD.Text = ""
        Me.TxPasswordBD.TrailingIcon = CType(resources.GetObject("TxPasswordBD.TrailingIcon"), System.Drawing.Image)
        Me.TxPasswordBD.UseTallSize = False
        '
        'TxUserBD
        '
        Me.TxUserBD.AnimateReadOnly = False
        Me.TxUserBD.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxUserBD.Depth = 0
        Me.TxUserBD.Font = New System.Drawing.Font("Roboto", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.TxUserBD.Hint = "UsuarioBD"
        Me.TxUserBD.LeadingIcon = Nothing
        Me.TxUserBD.Location = New System.Drawing.Point(205, 7)
        Me.TxUserBD.MaxLength = 50
        Me.TxUserBD.MouseState = MaterialSkin.MouseState.OUT
        Me.TxUserBD.Multiline = False
        Me.TxUserBD.Name = "TxUserBD"
        Me.TxUserBD.Size = New System.Drawing.Size(176, 36)
        Me.TxUserBD.TabIndex = 2
        Me.TxUserBD.Text = ""
        Me.TxUserBD.TrailingIcon = CType(resources.GetObject("TxUserBD.TrailingIcon"), System.Drawing.Image)
        Me.TxUserBD.UseTallSize = False
        '
        'TxDatabase
        '
        Me.TxDatabase.AnimateReadOnly = False
        Me.TxDatabase.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxDatabase.Depth = 0
        Me.TxDatabase.Font = New System.Drawing.Font("Roboto", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.TxDatabase.Hint = "Base de datos"
        Me.TxDatabase.LeadingIcon = Nothing
        Me.TxDatabase.Location = New System.Drawing.Point(7, 49)
        Me.TxDatabase.MaxLength = 50
        Me.TxDatabase.MouseState = MaterialSkin.MouseState.OUT
        Me.TxDatabase.Multiline = False
        Me.TxDatabase.Name = "TxDatabase"
        Me.TxDatabase.Size = New System.Drawing.Size(176, 36)
        Me.TxDatabase.TabIndex = 1
        Me.TxDatabase.Text = ""
        Me.TxDatabase.TrailingIcon = CType(resources.GetObject("TxDatabase.TrailingIcon"), System.Drawing.Image)
        Me.TxDatabase.UseTallSize = False
        '
        'TxServerBD
        '
        Me.TxServerBD.AnimateReadOnly = False
        Me.TxServerBD.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxServerBD.Depth = 0
        Me.TxServerBD.Font = New System.Drawing.Font("Roboto", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.TxServerBD.Hint = "Servidor"
        Me.TxServerBD.LeadingIcon = Nothing
        Me.TxServerBD.Location = New System.Drawing.Point(7, 7)
        Me.TxServerBD.MaxLength = 50
        Me.TxServerBD.MouseState = MaterialSkin.MouseState.OUT
        Me.TxServerBD.Multiline = False
        Me.TxServerBD.Name = "TxServerBD"
        Me.TxServerBD.Size = New System.Drawing.Size(176, 36)
        Me.TxServerBD.TabIndex = 0
        Me.TxServerBD.Text = ""
        Me.TxServerBD.TrailingIcon = CType(resources.GetObject("TxServerBD.TrailingIcon"), System.Drawing.Image)
        Me.TxServerBD.UseTallSize = False
        '
        'BtnConnection
        '
        Me.BtnConnection.AutoSize = False
        Me.BtnConnection.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BtnConnection.BackColor = System.Drawing.Color.Transparent
        Me.BtnConnection.BackgroundImage = CType(resources.GetObject("BtnConnection.BackgroundImage"), System.Drawing.Image)
        Me.BtnConnection.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnConnection.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Dense
        Me.BtnConnection.Depth = 0
        Me.BtnConnection.HighEmphasis = True
        Me.BtnConnection.Icon = Nothing
        Me.BtnConnection.Image = CType(resources.GetObject("BtnConnection.Image"), System.Drawing.Image)
        Me.BtnConnection.ImageAlign = System.Drawing.ContentAlignment.TopRight
        Me.BtnConnection.Location = New System.Drawing.Point(6, 207)
        Me.BtnConnection.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.BtnConnection.MouseState = MaterialSkin.MouseState.HOVER
        Me.BtnConnection.Name = "BtnConnection"
        Me.BtnConnection.NoAccentTextColor = System.Drawing.Color.Empty
        Me.BtnConnection.Size = New System.Drawing.Size(45, 33)
        Me.BtnConnection.TabIndex = 0
        Me.BtnConnection.Text = "BD"
        Me.BtnConnection.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.BtnConnection.UseAccentColor = False
        Me.BtnConnection.UseVisualStyleBackColor = False
        '
        'BtnComprobarContra
        '
        Me.BtnComprobarContra.AutoSize = False
        Me.BtnComprobarContra.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BtnComprobarContra.BackColor = System.Drawing.Color.Transparent
        Me.BtnComprobarContra.BackgroundImage = CType(resources.GetObject("BtnComprobarContra.BackgroundImage"), System.Drawing.Image)
        Me.BtnComprobarContra.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnComprobarContra.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Dense
        Me.BtnComprobarContra.Depth = 0
        Me.BtnComprobarContra.HighEmphasis = True
        Me.BtnComprobarContra.Icon = Nothing
        Me.BtnComprobarContra.Image = CType(resources.GetObject("BtnComprobarContra.Image"), System.Drawing.Image)
        Me.BtnComprobarContra.ImageAlign = System.Drawing.ContentAlignment.TopRight
        Me.BtnComprobarContra.Location = New System.Drawing.Point(390, 207)
        Me.BtnComprobarContra.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.BtnComprobarContra.MouseState = MaterialSkin.MouseState.HOVER
        Me.BtnComprobarContra.Name = "BtnComprobarContra"
        Me.BtnComprobarContra.NoAccentTextColor = System.Drawing.Color.Empty
        Me.BtnComprobarContra.Size = New System.Drawing.Size(73, 33)
        Me.BtnComprobarContra.TabIndex = 6
        Me.BtnComprobarContra.Text = "Iniciar"
        Me.BtnComprobarContra.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.BtnComprobarContra.UseAccentColor = False
        Me.BtnComprobarContra.UseVisualStyleBackColor = False
        '
        'TxPassword
        '
        Me.TxPassword.AnimateReadOnly = True
        Me.TxPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.TxPassword.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.TxPassword.Depth = 0
        Me.TxPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.TxPassword.HideSelection = False
        Me.TxPassword.Hint = "Contraseña"
        Me.TxPassword.LeadingIcon = Nothing
        Me.TxPassword.Location = New System.Drawing.Point(146, 161)
        Me.TxPassword.MaxLength = 32767
        Me.TxPassword.MouseState = MaterialSkin.MouseState.OUT
        Me.TxPassword.Name = "TxPassword"
        Me.TxPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.TxPassword.PrefixSuffixText = Nothing
        Me.TxPassword.ReadOnly = False
        Me.TxPassword.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TxPassword.SelectedText = ""
        Me.TxPassword.SelectionLength = 0
        Me.TxPassword.SelectionStart = 0
        Me.TxPassword.ShortcutsEnabled = True
        Me.TxPassword.Size = New System.Drawing.Size(180, 36)
        Me.TxPassword.TabIndex = 8
        Me.TxPassword.TabStop = False
        Me.TxPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.TxPassword.TrailingIcon = CType(resources.GetObject("TxPassword.TrailingIcon"), System.Drawing.Image)
        Me.TxPassword.UseSystemPasswordChar = True
        Me.TxPassword.UseTallSize = False
        '
        'CboUsuarios
        '
        Me.CboUsuarios.AutoResize = False
        Me.CboUsuarios.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CboUsuarios.Depth = 0
        Me.CboUsuarios.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me.CboUsuarios.DropDownHeight = 118
        Me.CboUsuarios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboUsuarios.DropDownWidth = 121
        Me.CboUsuarios.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.CboUsuarios.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.CboUsuarios.FormattingEnabled = True
        Me.CboUsuarios.IntegralHeight = False
        Me.CboUsuarios.ItemHeight = 29
        Me.CboUsuarios.Location = New System.Drawing.Point(146, 106)
        Me.CboUsuarios.MaxDropDownItems = 4
        Me.CboUsuarios.MouseState = MaterialSkin.MouseState.OUT
        Me.CboUsuarios.Name = "CboUsuarios"
        Me.CboUsuarios.Size = New System.Drawing.Size(180, 35)
        Me.CboUsuarios.Sorted = True
        Me.CboUsuarios.StartIndex = 0
        Me.CboUsuarios.TabIndex = 9
        Me.CboUsuarios.UseTallSize = False
        '
        'Inicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(476, 247)
        Me.Controls.Add(Me.CboUsuarios)
        Me.Controls.Add(Me.TxPassword)
        Me.Controls.Add(Me.BtnComprobarContra)
        Me.Controls.Add(Me.BtnConnection)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Inicio"
        Me.Text = "Login"
        Me.Panel1.ResumeLayout(False)
        Me.PanelBD.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents BtnConnection As MaterialSkin.Controls.MaterialButton
    Friend WithEvents BtnComprobarContra As MaterialSkin.Controls.MaterialButton
    Friend WithEvents TxPassword As MaterialSkin.Controls.MaterialTextBox2
    Friend WithEvents PanelBD As MaterialSkin.Controls.MaterialCard
    Friend WithEvents BtnRealizarConexion As MaterialSkin.Controls.MaterialButton
    Friend WithEvents TxPasswordBD As MaterialSkin.Controls.MaterialTextBox
    Friend WithEvents TxUserBD As MaterialSkin.Controls.MaterialTextBox
    Friend WithEvents TxDatabase As MaterialSkin.Controls.MaterialTextBox
    Friend WithEvents TxServerBD As MaterialSkin.Controls.MaterialTextBox
    Friend WithEvents CboUsuarios As MaterialSkin.Controls.MaterialComboBox
End Class
