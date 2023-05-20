<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Usuarios
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Usuarios))
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PanelPass = New MaterialSkin.Controls.MaterialCard()
        Me.BtnGuardarPassword = New MaterialSkin.Controls.MaterialButton()
        Me.TxNuevaPassword = New MaterialSkin.Controls.MaterialMaskedTextBox()
        Me.MaterialLabel13 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialCard2 = New MaterialSkin.Controls.MaterialCard()
        Me.DbgUsuarios = New System.Windows.Forms.DataGridView()
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Apellidos = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DNI = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Telefono = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Equipo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.BtnFiltrar = New MaterialSkin.Controls.MaterialButton()
        Me.CboEquipoBus = New MaterialSkin.Controls.MaterialComboBox()
        Me.TxNombreBus = New MaterialSkin.Controls.MaterialMaskedTextBox()
        Me.TxIDbus = New MaterialSkin.Controls.MaterialMaskedTextBox()
        Me.TxDNIbus = New MaterialSkin.Controls.MaterialMaskedTextBox()
        Me.TxApellidoBus = New MaterialSkin.Controls.MaterialMaskedTextBox()
        Me.MaterialCard1 = New MaterialSkin.Controls.MaterialCard()
        Me.BtnAbrirPanelPassword = New MaterialSkin.Controls.MaterialButton()
        Me.CboTipoUsuario = New MaterialSkin.Controls.MaterialComboBox()
        Me.MaterialLabel12 = New MaterialSkin.Controls.MaterialLabel()
        Me.TxLocalidad = New MaterialSkin.Controls.MaterialMaskedTextBox()
        Me.MaterialLabel11 = New MaterialSkin.Controls.MaterialLabel()
        Me.CboEquipo = New MaterialSkin.Controls.MaterialComboBox()
        Me.MaterialLabel7 = New MaterialSkin.Controls.MaterialLabel()
        Me.TxProvincia = New MaterialSkin.Controls.MaterialMaskedTextBox()
        Me.MaterialLabel10 = New MaterialSkin.Controls.MaterialLabel()
        Me.TxPais = New MaterialSkin.Controls.MaterialMaskedTextBox()
        Me.MaterialLabel9 = New MaterialSkin.Controls.MaterialLabel()
        Me.TxDireccion = New MaterialSkin.Controls.MaterialMaskedTextBox()
        Me.MaterialLabel8 = New MaterialSkin.Controls.MaterialLabel()
        Me.TxTelefono = New MaterialSkin.Controls.MaterialMaskedTextBox()
        Me.MaterialLabel6 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialLabel5 = New MaterialSkin.Controls.MaterialLabel()
        Me.DTPfechaNac = New System.Windows.Forms.DateTimePicker()
        Me.TxID = New MaterialSkin.Controls.MaterialMaskedTextBox()
        Me.MaterialLabel1 = New MaterialSkin.Controls.MaterialLabel()
        Me.TxDNI = New MaterialSkin.Controls.MaterialMaskedTextBox()
        Me.TxNombre = New MaterialSkin.Controls.MaterialMaskedTextBox()
        Me.MaterialLabel4 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialLabel2 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialLabel3 = New MaterialSkin.Controls.MaterialLabel()
        Me.TxApellido = New MaterialSkin.Controls.MaterialMaskedTextBox()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.PanelPass.SuspendLayout()
        Me.MaterialCard2.SuspendLayout()
        CType(Me.DbgUsuarios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.MaterialCard1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Location = New System.Drawing.Point(2, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(971, 774)
        Me.Panel1.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(207, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.PanelPass)
        Me.Panel2.Controls.Add(Me.MaterialCard2)
        Me.Panel2.Controls.Add(Me.MaterialCard1)
        Me.Panel2.Location = New System.Drawing.Point(3, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(963, 766)
        Me.Panel2.TabIndex = 1
        '
        'PanelPass
        '
        Me.PanelPass.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.PanelPass.Controls.Add(Me.BtnGuardarPassword)
        Me.PanelPass.Controls.Add(Me.TxNuevaPassword)
        Me.PanelPass.Controls.Add(Me.MaterialLabel13)
        Me.PanelPass.Depth = 0
        Me.PanelPass.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.PanelPass.Location = New System.Drawing.Point(658, 6)
        Me.PanelPass.Margin = New System.Windows.Forms.Padding(14)
        Me.PanelPass.MouseState = MaterialSkin.MouseState.HOVER
        Me.PanelPass.Name = "PanelPass"
        Me.PanelPass.Padding = New System.Windows.Forms.Padding(14)
        Me.PanelPass.Size = New System.Drawing.Size(297, 127)
        Me.PanelPass.TabIndex = 8
        Me.PanelPass.Visible = False
        '
        'BtnGuardarPassword
        '
        Me.BtnGuardarPassword.AutoSize = False
        Me.BtnGuardarPassword.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BtnGuardarPassword.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.BtnGuardarPassword.Depth = 0
        Me.BtnGuardarPassword.HighEmphasis = True
        Me.BtnGuardarPassword.Icon = CType(resources.GetObject("BtnGuardarPassword.Icon"), System.Drawing.Image)
        Me.BtnGuardarPassword.Location = New System.Drawing.Point(246, 76)
        Me.BtnGuardarPassword.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.BtnGuardarPassword.MouseState = MaterialSkin.MouseState.HOVER
        Me.BtnGuardarPassword.Name = "BtnGuardarPassword"
        Me.BtnGuardarPassword.NoAccentTextColor = System.Drawing.Color.Empty
        Me.BtnGuardarPassword.Size = New System.Drawing.Size(42, 42)
        Me.BtnGuardarPassword.TabIndex = 33
        Me.BtnGuardarPassword.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.BtnGuardarPassword.UseAccentColor = False
        Me.BtnGuardarPassword.UseVisualStyleBackColor = True
        '
        'TxNuevaPassword
        '
        Me.TxNuevaPassword.AllowPromptAsInput = True
        Me.TxNuevaPassword.AnimateReadOnly = False
        Me.TxNuevaPassword.AsciiOnly = False
        Me.TxNuevaPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.TxNuevaPassword.BeepOnError = False
        Me.TxNuevaPassword.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals
        Me.TxNuevaPassword.Depth = 0
        Me.TxNuevaPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.TxNuevaPassword.HidePromptOnLeave = False
        Me.TxNuevaPassword.HideSelection = True
        Me.TxNuevaPassword.InsertKeyMode = System.Windows.Forms.InsertKeyMode.[Default]
        Me.TxNuevaPassword.LeadingIcon = Nothing
        Me.TxNuevaPassword.Location = New System.Drawing.Point(9, 31)
        Me.TxNuevaPassword.Mask = ""
        Me.TxNuevaPassword.MaxLength = 32767
        Me.TxNuevaPassword.MouseState = MaterialSkin.MouseState.OUT
        Me.TxNuevaPassword.Name = "TxNuevaPassword"
        Me.TxNuevaPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.TxNuevaPassword.PrefixSuffixText = Nothing
        Me.TxNuevaPassword.PromptChar = Global.Microsoft.VisualBasic.ChrW(95)
        Me.TxNuevaPassword.ReadOnly = False
        Me.TxNuevaPassword.RejectInputOnFirstFailure = False
        Me.TxNuevaPassword.ResetOnPrompt = True
        Me.TxNuevaPassword.ResetOnSpace = True
        Me.TxNuevaPassword.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TxNuevaPassword.SelectedText = ""
        Me.TxNuevaPassword.SelectionLength = 0
        Me.TxNuevaPassword.SelectionStart = 0
        Me.TxNuevaPassword.ShortcutsEnabled = True
        Me.TxNuevaPassword.Size = New System.Drawing.Size(279, 36)
        Me.TxNuevaPassword.SkipLiterals = True
        Me.TxNuevaPassword.TabIndex = 32
        Me.TxNuevaPassword.TabStop = False
        Me.TxNuevaPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.TxNuevaPassword.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals
        Me.TxNuevaPassword.TrailingIcon = Nothing
        Me.TxNuevaPassword.UseSystemPasswordChar = True
        Me.TxNuevaPassword.UseTallSize = False
        Me.TxNuevaPassword.ValidatingType = Nothing
        '
        'MaterialLabel13
        '
        Me.MaterialLabel13.AutoSize = True
        Me.MaterialLabel13.Depth = 0
        Me.MaterialLabel13.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.MaterialLabel13.FontType = MaterialSkin.MaterialSkinManager.fontType.Caption
        Me.MaterialLabel13.Location = New System.Drawing.Point(17, 14)
        Me.MaterialLabel13.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel13.Name = "MaterialLabel13"
        Me.MaterialLabel13.Size = New System.Drawing.Size(102, 14)
        Me.MaterialLabel13.TabIndex = 32
        Me.MaterialLabel13.Text = "Nueva Contraseña"
        '
        'MaterialCard2
        '
        Me.MaterialCard2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MaterialCard2.Controls.Add(Me.DbgUsuarios)
        Me.MaterialCard2.Controls.Add(Me.Panel3)
        Me.MaterialCard2.Depth = 0
        Me.MaterialCard2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialCard2.Location = New System.Drawing.Point(5, 306)
        Me.MaterialCard2.Margin = New System.Windows.Forms.Padding(14)
        Me.MaterialCard2.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialCard2.Name = "MaterialCard2"
        Me.MaterialCard2.Padding = New System.Windows.Forms.Padding(14)
        Me.MaterialCard2.Size = New System.Drawing.Size(642, 452)
        Me.MaterialCard2.TabIndex = 7
        '
        'DbgUsuarios
        '
        Me.DbgUsuarios.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DbgUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DbgUsuarios.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID, Me.Nombre, Me.Apellidos, Me.DNI, Me.Telefono, Me.Equipo})
        Me.DbgUsuarios.Location = New System.Drawing.Point(5, 117)
        Me.DbgUsuarios.Name = "DbgUsuarios"
        Me.DbgUsuarios.Size = New System.Drawing.Size(632, 330)
        Me.DbgUsuarios.TabIndex = 0
        '
        'ID
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ID.DefaultCellStyle = DataGridViewCellStyle3
        Me.ID.HeaderText = "ID"
        Me.ID.Name = "ID"
        Me.ID.ReadOnly = True
        Me.ID.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.ID.Width = 50
        '
        'Nombre
        '
        Me.Nombre.HeaderText = "Nombre"
        Me.Nombre.Name = "Nombre"
        Me.Nombre.ReadOnly = True
        '
        'Apellidos
        '
        Me.Apellidos.HeaderText = "Apellidos"
        Me.Apellidos.Name = "Apellidos"
        Me.Apellidos.ReadOnly = True
        Me.Apellidos.Width = 140
        '
        'DNI
        '
        Me.DNI.HeaderText = "DNI"
        Me.DNI.Name = "DNI"
        Me.DNI.ReadOnly = True
        '
        'Telefono
        '
        Me.Telefono.HeaderText = "Telefono"
        Me.Telefono.Name = "Telefono"
        Me.Telefono.ReadOnly = True
        '
        'Equipo
        '
        Me.Equipo.HeaderText = "Equipo"
        Me.Equipo.Name = "Equipo"
        Me.Equipo.ReadOnly = True
        '
        'Panel3
        '
        Me.Panel3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.BtnFiltrar)
        Me.Panel3.Controls.Add(Me.CboEquipoBus)
        Me.Panel3.Controls.Add(Me.TxNombreBus)
        Me.Panel3.Controls.Add(Me.TxIDbus)
        Me.Panel3.Controls.Add(Me.TxDNIbus)
        Me.Panel3.Controls.Add(Me.TxApellidoBus)
        Me.Panel3.Location = New System.Drawing.Point(5, 9)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(632, 102)
        Me.Panel3.TabIndex = 1
        '
        'BtnFiltrar
        '
        Me.BtnFiltrar.AutoSize = False
        Me.BtnFiltrar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BtnFiltrar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.BtnFiltrar.Depth = 0
        Me.BtnFiltrar.HighEmphasis = True
        Me.BtnFiltrar.Icon = CType(resources.GetObject("BtnFiltrar.Icon"), System.Drawing.Image)
        Me.BtnFiltrar.Location = New System.Drawing.Point(584, 6)
        Me.BtnFiltrar.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.BtnFiltrar.MouseState = MaterialSkin.MouseState.HOVER
        Me.BtnFiltrar.Name = "BtnFiltrar"
        Me.BtnFiltrar.NoAccentTextColor = System.Drawing.Color.Empty
        Me.BtnFiltrar.Size = New System.Drawing.Size(42, 42)
        Me.BtnFiltrar.TabIndex = 34
        Me.BtnFiltrar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.BtnFiltrar.UseAccentColor = False
        Me.BtnFiltrar.UseVisualStyleBackColor = True
        '
        'CboEquipoBus
        '
        Me.CboEquipoBus.AutoResize = False
        Me.CboEquipoBus.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CboEquipoBus.Depth = 0
        Me.CboEquipoBus.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me.CboEquipoBus.DropDownHeight = 118
        Me.CboEquipoBus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboEquipoBus.DropDownWidth = 121
        Me.CboEquipoBus.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.CboEquipoBus.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.CboEquipoBus.FormattingEnabled = True
        Me.CboEquipoBus.Hint = "Equipo"
        Me.CboEquipoBus.IntegralHeight = False
        Me.CboEquipoBus.ItemHeight = 29
        Me.CboEquipoBus.Location = New System.Drawing.Point(180, 56)
        Me.CboEquipoBus.MaxDropDownItems = 4
        Me.CboEquipoBus.MouseState = MaterialSkin.MouseState.OUT
        Me.CboEquipoBus.Name = "CboEquipoBus"
        Me.CboEquipoBus.Size = New System.Drawing.Size(161, 35)
        Me.CboEquipoBus.StartIndex = 0
        Me.CboEquipoBus.TabIndex = 19
        Me.CboEquipoBus.UseTallSize = False
        '
        'TxNombreBus
        '
        Me.TxNombreBus.AllowPromptAsInput = True
        Me.TxNombreBus.AnimateReadOnly = False
        Me.TxNombreBus.AsciiOnly = False
        Me.TxNombreBus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.TxNombreBus.BeepOnError = False
        Me.TxNombreBus.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals
        Me.TxNombreBus.Depth = 0
        Me.TxNombreBus.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.TxNombreBus.HidePromptOnLeave = False
        Me.TxNombreBus.HideSelection = True
        Me.TxNombreBus.Hint = "Nombre"
        Me.TxNombreBus.InsertKeyMode = System.Windows.Forms.InsertKeyMode.[Default]
        Me.TxNombreBus.LeadingIcon = Nothing
        Me.TxNombreBus.Location = New System.Drawing.Point(93, 7)
        Me.TxNombreBus.Mask = ""
        Me.TxNombreBus.MaxLength = 32767
        Me.TxNombreBus.MouseState = MaterialSkin.MouseState.OUT
        Me.TxNombreBus.Name = "TxNombreBus"
        Me.TxNombreBus.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxNombreBus.PrefixSuffixText = Nothing
        Me.TxNombreBus.PromptChar = Global.Microsoft.VisualBasic.ChrW(95)
        Me.TxNombreBus.ReadOnly = False
        Me.TxNombreBus.RejectInputOnFirstFailure = False
        Me.TxNombreBus.ResetOnPrompt = True
        Me.TxNombreBus.ResetOnSpace = True
        Me.TxNombreBus.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TxNombreBus.SelectedText = ""
        Me.TxNombreBus.SelectionLength = 0
        Me.TxNombreBus.SelectionStart = 0
        Me.TxNombreBus.ShortcutsEnabled = True
        Me.TxNombreBus.Size = New System.Drawing.Size(161, 36)
        Me.TxNombreBus.SkipLiterals = True
        Me.TxNombreBus.TabIndex = 16
        Me.TxNombreBus.TabStop = False
        Me.TxNombreBus.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.TxNombreBus.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals
        Me.TxNombreBus.TrailingIcon = Nothing
        Me.TxNombreBus.UseSystemPasswordChar = False
        Me.TxNombreBus.UseTallSize = False
        Me.TxNombreBus.ValidatingType = Nothing
        '
        'TxIDbus
        '
        Me.TxIDbus.AllowPromptAsInput = True
        Me.TxIDbus.AnimateReadOnly = False
        Me.TxIDbus.AsciiOnly = False
        Me.TxIDbus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.TxIDbus.BeepOnError = False
        Me.TxIDbus.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals
        Me.TxIDbus.Depth = 0
        Me.TxIDbus.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.TxIDbus.HidePromptOnLeave = False
        Me.TxIDbus.HideSelection = True
        Me.TxIDbus.Hint = "ID"
        Me.TxIDbus.InsertKeyMode = System.Windows.Forms.InsertKeyMode.[Default]
        Me.TxIDbus.LeadingIcon = Nothing
        Me.TxIDbus.Location = New System.Drawing.Point(7, 7)
        Me.TxIDbus.Mask = ""
        Me.TxIDbus.MaxLength = 32767
        Me.TxIDbus.MouseState = MaterialSkin.MouseState.OUT
        Me.TxIDbus.Name = "TxIDbus"
        Me.TxIDbus.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxIDbus.PrefixSuffixText = Nothing
        Me.TxIDbus.PromptChar = Global.Microsoft.VisualBasic.ChrW(95)
        Me.TxIDbus.ReadOnly = False
        Me.TxIDbus.RejectInputOnFirstFailure = False
        Me.TxIDbus.ResetOnPrompt = True
        Me.TxIDbus.ResetOnSpace = True
        Me.TxIDbus.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TxIDbus.SelectedText = ""
        Me.TxIDbus.SelectionLength = 0
        Me.TxIDbus.SelectionStart = 0
        Me.TxIDbus.ShortcutsEnabled = True
        Me.TxIDbus.Size = New System.Drawing.Size(71, 36)
        Me.TxIDbus.SkipLiterals = True
        Me.TxIDbus.TabIndex = 15
        Me.TxIDbus.TabStop = False
        Me.TxIDbus.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.TxIDbus.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals
        Me.TxIDbus.TrailingIcon = Nothing
        Me.TxIDbus.UseSystemPasswordChar = False
        Me.TxIDbus.UseTallSize = False
        Me.TxIDbus.ValidatingType = Nothing
        '
        'TxDNIbus
        '
        Me.TxDNIbus.AllowPromptAsInput = True
        Me.TxDNIbus.AnimateReadOnly = False
        Me.TxDNIbus.AsciiOnly = False
        Me.TxDNIbus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.TxDNIbus.BeepOnError = False
        Me.TxDNIbus.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals
        Me.TxDNIbus.Depth = 0
        Me.TxDNIbus.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.TxDNIbus.HidePromptOnLeave = False
        Me.TxDNIbus.HideSelection = True
        Me.TxDNIbus.Hint = "DNI"
        Me.TxDNIbus.InsertKeyMode = System.Windows.Forms.InsertKeyMode.[Default]
        Me.TxDNIbus.LeadingIcon = Nothing
        Me.TxDNIbus.Location = New System.Drawing.Point(7, 55)
        Me.TxDNIbus.Mask = ""
        Me.TxDNIbus.MaxLength = 32767
        Me.TxDNIbus.MouseState = MaterialSkin.MouseState.OUT
        Me.TxDNIbus.Name = "TxDNIbus"
        Me.TxDNIbus.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxDNIbus.PrefixSuffixText = Nothing
        Me.TxDNIbus.PromptChar = Global.Microsoft.VisualBasic.ChrW(95)
        Me.TxDNIbus.ReadOnly = False
        Me.TxDNIbus.RejectInputOnFirstFailure = False
        Me.TxDNIbus.ResetOnPrompt = True
        Me.TxDNIbus.ResetOnSpace = True
        Me.TxDNIbus.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TxDNIbus.SelectedText = ""
        Me.TxDNIbus.SelectionLength = 0
        Me.TxDNIbus.SelectionStart = 0
        Me.TxDNIbus.ShortcutsEnabled = True
        Me.TxDNIbus.Size = New System.Drawing.Size(166, 36)
        Me.TxDNIbus.SkipLiterals = True
        Me.TxDNIbus.TabIndex = 18
        Me.TxDNIbus.TabStop = False
        Me.TxDNIbus.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.TxDNIbus.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals
        Me.TxDNIbus.TrailingIcon = Nothing
        Me.TxDNIbus.UseSystemPasswordChar = False
        Me.TxDNIbus.UseTallSize = False
        Me.TxDNIbus.ValidatingType = Nothing
        '
        'TxApellidoBus
        '
        Me.TxApellidoBus.AllowPromptAsInput = True
        Me.TxApellidoBus.AnimateReadOnly = False
        Me.TxApellidoBus.AsciiOnly = False
        Me.TxApellidoBus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.TxApellidoBus.BeepOnError = False
        Me.TxApellidoBus.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals
        Me.TxApellidoBus.Depth = 0
        Me.TxApellidoBus.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.TxApellidoBus.HidePromptOnLeave = False
        Me.TxApellidoBus.HideSelection = True
        Me.TxApellidoBus.Hint = "Apellido"
        Me.TxApellidoBus.InsertKeyMode = System.Windows.Forms.InsertKeyMode.[Default]
        Me.TxApellidoBus.LeadingIcon = Nothing
        Me.TxApellidoBus.Location = New System.Drawing.Point(270, 7)
        Me.TxApellidoBus.Mask = ""
        Me.TxApellidoBus.MaxLength = 32767
        Me.TxApellidoBus.MouseState = MaterialSkin.MouseState.OUT
        Me.TxApellidoBus.Name = "TxApellidoBus"
        Me.TxApellidoBus.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxApellidoBus.PrefixSuffixText = Nothing
        Me.TxApellidoBus.PromptChar = Global.Microsoft.VisualBasic.ChrW(95)
        Me.TxApellidoBus.ReadOnly = False
        Me.TxApellidoBus.RejectInputOnFirstFailure = False
        Me.TxApellidoBus.ResetOnPrompt = True
        Me.TxApellidoBus.ResetOnSpace = True
        Me.TxApellidoBus.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TxApellidoBus.SelectedText = ""
        Me.TxApellidoBus.SelectionLength = 0
        Me.TxApellidoBus.SelectionStart = 0
        Me.TxApellidoBus.ShortcutsEnabled = True
        Me.TxApellidoBus.Size = New System.Drawing.Size(293, 36)
        Me.TxApellidoBus.SkipLiterals = True
        Me.TxApellidoBus.TabIndex = 17
        Me.TxApellidoBus.TabStop = False
        Me.TxApellidoBus.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.TxApellidoBus.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals
        Me.TxApellidoBus.TrailingIcon = Nothing
        Me.TxApellidoBus.UseSystemPasswordChar = False
        Me.TxApellidoBus.UseTallSize = False
        Me.TxApellidoBus.ValidatingType = Nothing
        '
        'MaterialCard1
        '
        Me.MaterialCard1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MaterialCard1.Controls.Add(Me.BtnAbrirPanelPassword)
        Me.MaterialCard1.Controls.Add(Me.CboTipoUsuario)
        Me.MaterialCard1.Controls.Add(Me.MaterialLabel12)
        Me.MaterialCard1.Controls.Add(Me.TxLocalidad)
        Me.MaterialCard1.Controls.Add(Me.MaterialLabel11)
        Me.MaterialCard1.Controls.Add(Me.CboEquipo)
        Me.MaterialCard1.Controls.Add(Me.MaterialLabel7)
        Me.MaterialCard1.Controls.Add(Me.TxProvincia)
        Me.MaterialCard1.Controls.Add(Me.MaterialLabel10)
        Me.MaterialCard1.Controls.Add(Me.TxPais)
        Me.MaterialCard1.Controls.Add(Me.MaterialLabel9)
        Me.MaterialCard1.Controls.Add(Me.TxDireccion)
        Me.MaterialCard1.Controls.Add(Me.MaterialLabel8)
        Me.MaterialCard1.Controls.Add(Me.TxTelefono)
        Me.MaterialCard1.Controls.Add(Me.MaterialLabel6)
        Me.MaterialCard1.Controls.Add(Me.MaterialLabel5)
        Me.MaterialCard1.Controls.Add(Me.DTPfechaNac)
        Me.MaterialCard1.Controls.Add(Me.TxID)
        Me.MaterialCard1.Controls.Add(Me.MaterialLabel1)
        Me.MaterialCard1.Controls.Add(Me.TxDNI)
        Me.MaterialCard1.Controls.Add(Me.TxNombre)
        Me.MaterialCard1.Controls.Add(Me.MaterialLabel4)
        Me.MaterialCard1.Controls.Add(Me.MaterialLabel2)
        Me.MaterialCard1.Controls.Add(Me.MaterialLabel3)
        Me.MaterialCard1.Controls.Add(Me.TxApellido)
        Me.MaterialCard1.Depth = 0
        Me.MaterialCard1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialCard1.Location = New System.Drawing.Point(5, 6)
        Me.MaterialCard1.Margin = New System.Windows.Forms.Padding(14)
        Me.MaterialCard1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialCard1.Name = "MaterialCard1"
        Me.MaterialCard1.Padding = New System.Windows.Forms.Padding(14)
        Me.MaterialCard1.Size = New System.Drawing.Size(642, 292)
        Me.MaterialCard1.TabIndex = 6
        '
        'BtnAbrirPanelPassword
        '
        Me.BtnAbrirPanelPassword.AutoSize = False
        Me.BtnAbrirPanelPassword.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BtnAbrirPanelPassword.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.BtnAbrirPanelPassword.Depth = 0
        Me.BtnAbrirPanelPassword.HighEmphasis = True
        Me.BtnAbrirPanelPassword.Icon = CType(resources.GetObject("BtnAbrirPanelPassword.Icon"), System.Drawing.Image)
        Me.BtnAbrirPanelPassword.Location = New System.Drawing.Point(37, 241)
        Me.BtnAbrirPanelPassword.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.BtnAbrirPanelPassword.MouseState = MaterialSkin.MouseState.HOVER
        Me.BtnAbrirPanelPassword.Name = "BtnAbrirPanelPassword"
        Me.BtnAbrirPanelPassword.NoAccentTextColor = System.Drawing.Color.Empty
        Me.BtnAbrirPanelPassword.Size = New System.Drawing.Size(42, 42)
        Me.BtnAbrirPanelPassword.TabIndex = 35
        Me.BtnAbrirPanelPassword.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.BtnAbrirPanelPassword.UseAccentColor = False
        Me.BtnAbrirPanelPassword.UseVisualStyleBackColor = True
        '
        'CboTipoUsuario
        '
        Me.CboTipoUsuario.AutoResize = False
        Me.CboTipoUsuario.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CboTipoUsuario.Depth = 0
        Me.CboTipoUsuario.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me.CboTipoUsuario.DropDownHeight = 118
        Me.CboTipoUsuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboTipoUsuario.DropDownWidth = 121
        Me.CboTipoUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.CboTipoUsuario.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.CboTipoUsuario.FormattingEnabled = True
        Me.CboTipoUsuario.IntegralHeight = False
        Me.CboTipoUsuario.ItemHeight = 29
        Me.CboTipoUsuario.Location = New System.Drawing.Point(452, 248)
        Me.CboTipoUsuario.MaxDropDownItems = 4
        Me.CboTipoUsuario.MouseState = MaterialSkin.MouseState.OUT
        Me.CboTipoUsuario.Name = "CboTipoUsuario"
        Me.CboTipoUsuario.Size = New System.Drawing.Size(175, 35)
        Me.CboTipoUsuario.StartIndex = 0
        Me.CboTipoUsuario.TabIndex = 13
        Me.CboTipoUsuario.UseTallSize = False
        '
        'MaterialLabel12
        '
        Me.MaterialLabel12.AutoSize = True
        Me.MaterialLabel12.Depth = 0
        Me.MaterialLabel12.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.MaterialLabel12.FontType = MaterialSkin.MaterialSkinManager.fontType.Caption
        Me.MaterialLabel12.Location = New System.Drawing.Point(421, 258)
        Me.MaterialLabel12.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel12.Name = "MaterialLabel12"
        Me.MaterialLabel12.Size = New System.Drawing.Size(25, 14)
        Me.MaterialLabel12.TabIndex = 28
        Me.MaterialLabel12.Text = "Tipo"
        '
        'TxLocalidad
        '
        Me.TxLocalidad.AllowPromptAsInput = True
        Me.TxLocalidad.AnimateReadOnly = False
        Me.TxLocalidad.AsciiOnly = False
        Me.TxLocalidad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.TxLocalidad.BeepOnError = False
        Me.TxLocalidad.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals
        Me.TxLocalidad.Depth = 0
        Me.TxLocalidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.TxLocalidad.HidePromptOnLeave = False
        Me.TxLocalidad.HideSelection = True
        Me.TxLocalidad.InsertKeyMode = System.Windows.Forms.InsertKeyMode.[Default]
        Me.TxLocalidad.LeadingIcon = Nothing
        Me.TxLocalidad.Location = New System.Drawing.Point(494, 185)
        Me.TxLocalidad.Mask = ""
        Me.TxLocalidad.MaxLength = 32767
        Me.TxLocalidad.MouseState = MaterialSkin.MouseState.OUT
        Me.TxLocalidad.Name = "TxLocalidad"
        Me.TxLocalidad.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxLocalidad.PrefixSuffixText = Nothing
        Me.TxLocalidad.PromptChar = Global.Microsoft.VisualBasic.ChrW(95)
        Me.TxLocalidad.ReadOnly = False
        Me.TxLocalidad.RejectInputOnFirstFailure = False
        Me.TxLocalidad.ResetOnPrompt = True
        Me.TxLocalidad.ResetOnSpace = True
        Me.TxLocalidad.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TxLocalidad.SelectedText = ""
        Me.TxLocalidad.SelectionLength = 0
        Me.TxLocalidad.SelectionStart = 0
        Me.TxLocalidad.ShortcutsEnabled = True
        Me.TxLocalidad.Size = New System.Drawing.Size(133, 36)
        Me.TxLocalidad.SkipLiterals = True
        Me.TxLocalidad.TabIndex = 10
        Me.TxLocalidad.TabStop = False
        Me.TxLocalidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.TxLocalidad.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals
        Me.TxLocalidad.TrailingIcon = Nothing
        Me.TxLocalidad.UseSystemPasswordChar = False
        Me.TxLocalidad.UseTallSize = False
        Me.TxLocalidad.ValidatingType = Nothing
        '
        'MaterialLabel11
        '
        Me.MaterialLabel11.AutoSize = True
        Me.MaterialLabel11.Depth = 0
        Me.MaterialLabel11.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.MaterialLabel11.FontType = MaterialSkin.MaterialSkinManager.fontType.Caption
        Me.MaterialLabel11.Location = New System.Drawing.Point(434, 195)
        Me.MaterialLabel11.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel11.Name = "MaterialLabel11"
        Me.MaterialLabel11.Size = New System.Drawing.Size(54, 14)
        Me.MaterialLabel11.TabIndex = 25
        Me.MaterialLabel11.Text = "Localidad"
        '
        'CboEquipo
        '
        Me.CboEquipo.AutoResize = False
        Me.CboEquipo.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CboEquipo.Depth = 0
        Me.CboEquipo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me.CboEquipo.DropDownHeight = 118
        Me.CboEquipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboEquipo.DropDownWidth = 121
        Me.CboEquipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.CboEquipo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.CboEquipo.FormattingEnabled = True
        Me.CboEquipo.IntegralHeight = False
        Me.CboEquipo.ItemHeight = 29
        Me.CboEquipo.Location = New System.Drawing.Point(211, 248)
        Me.CboEquipo.MaxDropDownItems = 4
        Me.CboEquipo.MouseState = MaterialSkin.MouseState.OUT
        Me.CboEquipo.Name = "CboEquipo"
        Me.CboEquipo.Size = New System.Drawing.Size(175, 35)
        Me.CboEquipo.StartIndex = 0
        Me.CboEquipo.TabIndex = 12
        Me.CboEquipo.UseTallSize = False
        '
        'MaterialLabel7
        '
        Me.MaterialLabel7.AutoSize = True
        Me.MaterialLabel7.Depth = 0
        Me.MaterialLabel7.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.MaterialLabel7.FontType = MaterialSkin.MaterialSkinManager.fontType.Caption
        Me.MaterialLabel7.Location = New System.Drawing.Point(166, 258)
        Me.MaterialLabel7.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel7.Name = "MaterialLabel7"
        Me.MaterialLabel7.Size = New System.Drawing.Size(39, 14)
        Me.MaterialLabel7.TabIndex = 18
        Me.MaterialLabel7.Text = "Equipo"
        '
        'TxProvincia
        '
        Me.TxProvincia.AllowPromptAsInput = True
        Me.TxProvincia.AnimateReadOnly = False
        Me.TxProvincia.AsciiOnly = False
        Me.TxProvincia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.TxProvincia.BeepOnError = False
        Me.TxProvincia.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals
        Me.TxProvincia.Depth = 0
        Me.TxProvincia.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.TxProvincia.HidePromptOnLeave = False
        Me.TxProvincia.HideSelection = True
        Me.TxProvincia.InsertKeyMode = System.Windows.Forms.InsertKeyMode.[Default]
        Me.TxProvincia.LeadingIcon = Nothing
        Me.TxProvincia.Location = New System.Drawing.Point(253, 185)
        Me.TxProvincia.Mask = ""
        Me.TxProvincia.MaxLength = 32767
        Me.TxProvincia.MouseState = MaterialSkin.MouseState.OUT
        Me.TxProvincia.Name = "TxProvincia"
        Me.TxProvincia.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxProvincia.PrefixSuffixText = Nothing
        Me.TxProvincia.PromptChar = Global.Microsoft.VisualBasic.ChrW(95)
        Me.TxProvincia.ReadOnly = False
        Me.TxProvincia.RejectInputOnFirstFailure = False
        Me.TxProvincia.ResetOnPrompt = True
        Me.TxProvincia.ResetOnSpace = True
        Me.TxProvincia.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TxProvincia.SelectedText = ""
        Me.TxProvincia.SelectionLength = 0
        Me.TxProvincia.SelectionStart = 0
        Me.TxProvincia.ShortcutsEnabled = True
        Me.TxProvincia.Size = New System.Drawing.Size(133, 36)
        Me.TxProvincia.SkipLiterals = True
        Me.TxProvincia.TabIndex = 9
        Me.TxProvincia.TabStop = False
        Me.TxProvincia.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.TxProvincia.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals
        Me.TxProvincia.TrailingIcon = Nothing
        Me.TxProvincia.UseSystemPasswordChar = False
        Me.TxProvincia.UseTallSize = False
        Me.TxProvincia.ValidatingType = Nothing
        '
        'MaterialLabel10
        '
        Me.MaterialLabel10.AutoSize = True
        Me.MaterialLabel10.Depth = 0
        Me.MaterialLabel10.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.MaterialLabel10.FontType = MaterialSkin.MaterialSkinManager.fontType.Caption
        Me.MaterialLabel10.Location = New System.Drawing.Point(195, 195)
        Me.MaterialLabel10.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel10.Name = "MaterialLabel10"
        Me.MaterialLabel10.Size = New System.Drawing.Size(52, 14)
        Me.MaterialLabel10.TabIndex = 23
        Me.MaterialLabel10.Text = "Provincia"
        '
        'TxPais
        '
        Me.TxPais.AllowPromptAsInput = True
        Me.TxPais.AnimateReadOnly = False
        Me.TxPais.AsciiOnly = False
        Me.TxPais.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.TxPais.BeepOnError = False
        Me.TxPais.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals
        Me.TxPais.Depth = 0
        Me.TxPais.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.TxPais.HidePromptOnLeave = False
        Me.TxPais.HideSelection = True
        Me.TxPais.InsertKeyMode = System.Windows.Forms.InsertKeyMode.[Default]
        Me.TxPais.LeadingIcon = Nothing
        Me.TxPais.Location = New System.Drawing.Point(37, 185)
        Me.TxPais.Mask = ""
        Me.TxPais.MaxLength = 32767
        Me.TxPais.MouseState = MaterialSkin.MouseState.OUT
        Me.TxPais.Name = "TxPais"
        Me.TxPais.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxPais.PrefixSuffixText = Nothing
        Me.TxPais.PromptChar = Global.Microsoft.VisualBasic.ChrW(95)
        Me.TxPais.ReadOnly = False
        Me.TxPais.RejectInputOnFirstFailure = False
        Me.TxPais.ResetOnPrompt = True
        Me.TxPais.ResetOnSpace = True
        Me.TxPais.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TxPais.SelectedText = ""
        Me.TxPais.SelectionLength = 0
        Me.TxPais.SelectionStart = 0
        Me.TxPais.ShortcutsEnabled = True
        Me.TxPais.Size = New System.Drawing.Size(133, 36)
        Me.TxPais.SkipLiterals = True
        Me.TxPais.TabIndex = 8
        Me.TxPais.TabStop = False
        Me.TxPais.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.TxPais.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals
        Me.TxPais.TrailingIcon = Nothing
        Me.TxPais.UseSystemPasswordChar = False
        Me.TxPais.UseTallSize = False
        Me.TxPais.ValidatingType = Nothing
        '
        'MaterialLabel9
        '
        Me.MaterialLabel9.AutoSize = True
        Me.MaterialLabel9.Depth = 0
        Me.MaterialLabel9.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.MaterialLabel9.FontType = MaterialSkin.MaterialSkinManager.fontType.Caption
        Me.MaterialLabel9.Location = New System.Drawing.Point(10, 196)
        Me.MaterialLabel9.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel9.Name = "MaterialLabel9"
        Me.MaterialLabel9.Size = New System.Drawing.Size(25, 14)
        Me.MaterialLabel9.TabIndex = 21
        Me.MaterialLabel9.Text = "Pais"
        '
        'TxDireccion
        '
        Me.TxDireccion.AllowPromptAsInput = True
        Me.TxDireccion.AnimateReadOnly = False
        Me.TxDireccion.AsciiOnly = False
        Me.TxDireccion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.TxDireccion.BeepOnError = False
        Me.TxDireccion.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals
        Me.TxDireccion.Depth = 0
        Me.TxDireccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.TxDireccion.HidePromptOnLeave = False
        Me.TxDireccion.HideSelection = True
        Me.TxDireccion.InsertKeyMode = System.Windows.Forms.InsertKeyMode.[Default]
        Me.TxDireccion.LeadingIcon = Nothing
        Me.TxDireccion.Location = New System.Drawing.Point(67, 130)
        Me.TxDireccion.Mask = ""
        Me.TxDireccion.MaxLength = 32767
        Me.TxDireccion.MouseState = MaterialSkin.MouseState.OUT
        Me.TxDireccion.Name = "TxDireccion"
        Me.TxDireccion.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxDireccion.PrefixSuffixText = Nothing
        Me.TxDireccion.PromptChar = Global.Microsoft.VisualBasic.ChrW(95)
        Me.TxDireccion.ReadOnly = False
        Me.TxDireccion.RejectInputOnFirstFailure = False
        Me.TxDireccion.ResetOnPrompt = True
        Me.TxDireccion.ResetOnSpace = True
        Me.TxDireccion.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TxDireccion.SelectedText = ""
        Me.TxDireccion.SelectionLength = 0
        Me.TxDireccion.SelectionStart = 0
        Me.TxDireccion.ShortcutsEnabled = True
        Me.TxDireccion.Size = New System.Drawing.Size(560, 36)
        Me.TxDireccion.SkipLiterals = True
        Me.TxDireccion.TabIndex = 7
        Me.TxDireccion.TabStop = False
        Me.TxDireccion.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.TxDireccion.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals
        Me.TxDireccion.TrailingIcon = Nothing
        Me.TxDireccion.UseSystemPasswordChar = False
        Me.TxDireccion.UseTallSize = False
        Me.TxDireccion.ValidatingType = Nothing
        '
        'MaterialLabel8
        '
        Me.MaterialLabel8.AutoSize = True
        Me.MaterialLabel8.Depth = 0
        Me.MaterialLabel8.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.MaterialLabel8.FontType = MaterialSkin.MaterialSkinManager.fontType.Caption
        Me.MaterialLabel8.Location = New System.Drawing.Point(10, 139)
        Me.MaterialLabel8.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel8.Name = "MaterialLabel8"
        Me.MaterialLabel8.Size = New System.Drawing.Size(51, 14)
        Me.MaterialLabel8.TabIndex = 19
        Me.MaterialLabel8.Text = "Direccion"
        '
        'TxTelefono
        '
        Me.TxTelefono.AllowPromptAsInput = True
        Me.TxTelefono.AnimateReadOnly = False
        Me.TxTelefono.AsciiOnly = False
        Me.TxTelefono.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.TxTelefono.BeepOnError = False
        Me.TxTelefono.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals
        Me.TxTelefono.Depth = 0
        Me.TxTelefono.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.TxTelefono.HidePromptOnLeave = False
        Me.TxTelefono.HideSelection = True
        Me.TxTelefono.InsertKeyMode = System.Windows.Forms.InsertKeyMode.[Default]
        Me.TxTelefono.LeadingIcon = Nothing
        Me.TxTelefono.Location = New System.Drawing.Point(499, 73)
        Me.TxTelefono.Mask = ""
        Me.TxTelefono.MaxLength = 32767
        Me.TxTelefono.MouseState = MaterialSkin.MouseState.OUT
        Me.TxTelefono.Name = "TxTelefono"
        Me.TxTelefono.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxTelefono.PrefixSuffixText = Nothing
        Me.TxTelefono.PromptChar = Global.Microsoft.VisualBasic.ChrW(95)
        Me.TxTelefono.ReadOnly = False
        Me.TxTelefono.RejectInputOnFirstFailure = False
        Me.TxTelefono.ResetOnPrompt = True
        Me.TxTelefono.ResetOnSpace = True
        Me.TxTelefono.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TxTelefono.SelectedText = ""
        Me.TxTelefono.SelectionLength = 0
        Me.TxTelefono.SelectionStart = 0
        Me.TxTelefono.ShortcutsEnabled = True
        Me.TxTelefono.Size = New System.Drawing.Size(128, 36)
        Me.TxTelefono.SkipLiterals = True
        Me.TxTelefono.TabIndex = 6
        Me.TxTelefono.TabStop = False
        Me.TxTelefono.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.TxTelefono.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals
        Me.TxTelefono.TrailingIcon = Nothing
        Me.TxTelefono.UseSystemPasswordChar = False
        Me.TxTelefono.UseTallSize = False
        Me.TxTelefono.ValidatingType = Nothing
        '
        'MaterialLabel6
        '
        Me.MaterialLabel6.AutoSize = True
        Me.MaterialLabel6.Depth = 0
        Me.MaterialLabel6.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.MaterialLabel6.FontType = MaterialSkin.MaterialSkinManager.fontType.Caption
        Me.MaterialLabel6.Location = New System.Drawing.Point(449, 85)
        Me.MaterialLabel6.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel6.Name = "MaterialLabel6"
        Me.MaterialLabel6.Size = New System.Drawing.Size(48, 14)
        Me.MaterialLabel6.TabIndex = 15
        Me.MaterialLabel6.Text = "Telefono"
        '
        'MaterialLabel5
        '
        Me.MaterialLabel5.AutoSize = True
        Me.MaterialLabel5.Depth = 0
        Me.MaterialLabel5.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.MaterialLabel5.FontType = MaterialSkin.MaterialSkinManager.fontType.Caption
        Me.MaterialLabel5.Location = New System.Drawing.Point(196, 85)
        Me.MaterialLabel5.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel5.Name = "MaterialLabel5"
        Me.MaterialLabel5.Size = New System.Drawing.Size(116, 14)
        Me.MaterialLabel5.TabIndex = 14
        Me.MaterialLabel5.Text = "Fecha de Nacimiento"
        '
        'DTPfechaNac
        '
        Me.DTPfechaNac.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.DTPfechaNac.CalendarMonthBackground = System.Drawing.Color.White
        Me.DTPfechaNac.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTPfechaNac.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTPfechaNac.Location = New System.Drawing.Point(318, 82)
        Me.DTPfechaNac.Name = "DTPfechaNac"
        Me.DTPfechaNac.Size = New System.Drawing.Size(107, 20)
        Me.DTPfechaNac.TabIndex = 5
        '
        'TxID
        '
        Me.TxID.AllowPromptAsInput = True
        Me.TxID.AnimateReadOnly = False
        Me.TxID.AsciiOnly = False
        Me.TxID.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.TxID.BeepOnError = False
        Me.TxID.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals
        Me.TxID.Depth = 0
        Me.TxID.Font = New System.Drawing.Font("Microsoft Sans Serif", 5.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.TxID.HidePromptOnLeave = False
        Me.TxID.HideSelection = True
        Me.TxID.InsertKeyMode = System.Windows.Forms.InsertKeyMode.[Default]
        Me.TxID.LeadingIcon = Nothing
        Me.TxID.Location = New System.Drawing.Point(37, 17)
        Me.TxID.Mask = ""
        Me.TxID.MaxLength = 32767
        Me.TxID.MouseState = MaterialSkin.MouseState.OUT
        Me.TxID.Name = "TxID"
        Me.TxID.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxID.PrefixSuffixText = Nothing
        Me.TxID.PromptChar = Global.Microsoft.VisualBasic.ChrW(95)
        Me.TxID.ReadOnly = False
        Me.TxID.RejectInputOnFirstFailure = False
        Me.TxID.ResetOnPrompt = True
        Me.TxID.ResetOnSpace = True
        Me.TxID.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TxID.SelectedText = ""
        Me.TxID.SelectionLength = 0
        Me.TxID.SelectionStart = 0
        Me.TxID.ShortcutsEnabled = True
        Me.TxID.Size = New System.Drawing.Size(58, 36)
        Me.TxID.SkipLiterals = True
        Me.TxID.TabIndex = 1
        Me.TxID.TabStop = False
        Me.TxID.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.TxID.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals
        Me.TxID.TrailingIcon = Nothing
        Me.TxID.UseSystemPasswordChar = False
        Me.TxID.UseTallSize = False
        Me.TxID.ValidatingType = Nothing
        '
        'MaterialLabel1
        '
        Me.MaterialLabel1.AutoSize = True
        Me.MaterialLabel1.Depth = 0
        Me.MaterialLabel1.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.MaterialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.Caption
        Me.MaterialLabel1.Location = New System.Drawing.Point(19, 28)
        Me.MaterialLabel1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel1.Name = "MaterialLabel1"
        Me.MaterialLabel1.Size = New System.Drawing.Size(12, 14)
        Me.MaterialLabel1.TabIndex = 6
        Me.MaterialLabel1.Text = "ID"
        '
        'TxDNI
        '
        Me.TxDNI.AllowPromptAsInput = True
        Me.TxDNI.AnimateReadOnly = False
        Me.TxDNI.AsciiOnly = False
        Me.TxDNI.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.TxDNI.BeepOnError = False
        Me.TxDNI.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals
        Me.TxDNI.Depth = 0
        Me.TxDNI.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.TxDNI.HidePromptOnLeave = False
        Me.TxDNI.HideSelection = True
        Me.TxDNI.InsertKeyMode = System.Windows.Forms.InsertKeyMode.[Default]
        Me.TxDNI.LeadingIcon = Nothing
        Me.TxDNI.Location = New System.Drawing.Point(37, 73)
        Me.TxDNI.Mask = ""
        Me.TxDNI.MaxLength = 32767
        Me.TxDNI.MouseState = MaterialSkin.MouseState.OUT
        Me.TxDNI.Name = "TxDNI"
        Me.TxDNI.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxDNI.PrefixSuffixText = Nothing
        Me.TxDNI.PromptChar = Global.Microsoft.VisualBasic.ChrW(95)
        Me.TxDNI.ReadOnly = False
        Me.TxDNI.RejectInputOnFirstFailure = False
        Me.TxDNI.ResetOnPrompt = True
        Me.TxDNI.ResetOnSpace = True
        Me.TxDNI.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TxDNI.SelectedText = ""
        Me.TxDNI.SelectionLength = 0
        Me.TxDNI.SelectionStart = 0
        Me.TxDNI.ShortcutsEnabled = True
        Me.TxDNI.Size = New System.Drawing.Size(128, 36)
        Me.TxDNI.SkipLiterals = True
        Me.TxDNI.TabIndex = 4
        Me.TxDNI.TabStop = False
        Me.TxDNI.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.TxDNI.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals
        Me.TxDNI.TrailingIcon = Nothing
        Me.TxDNI.UseSystemPasswordChar = False
        Me.TxDNI.UseTallSize = False
        Me.TxDNI.ValidatingType = Nothing
        '
        'TxNombre
        '
        Me.TxNombre.AllowPromptAsInput = True
        Me.TxNombre.AnimateReadOnly = False
        Me.TxNombre.AsciiOnly = False
        Me.TxNombre.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.TxNombre.BeepOnError = False
        Me.TxNombre.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals
        Me.TxNombre.Depth = 0
        Me.TxNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.TxNombre.HidePromptOnLeave = False
        Me.TxNombre.HideSelection = True
        Me.TxNombre.InsertKeyMode = System.Windows.Forms.InsertKeyMode.[Default]
        Me.TxNombre.LeadingIcon = Nothing
        Me.TxNombre.Location = New System.Drawing.Point(171, 17)
        Me.TxNombre.Mask = ""
        Me.TxNombre.MaxLength = 32767
        Me.TxNombre.MouseState = MaterialSkin.MouseState.OUT
        Me.TxNombre.Name = "TxNombre"
        Me.TxNombre.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxNombre.PrefixSuffixText = Nothing
        Me.TxNombre.PromptChar = Global.Microsoft.VisualBasic.ChrW(95)
        Me.TxNombre.ReadOnly = False
        Me.TxNombre.RejectInputOnFirstFailure = False
        Me.TxNombre.ResetOnPrompt = True
        Me.TxNombre.ResetOnSpace = True
        Me.TxNombre.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TxNombre.SelectedText = ""
        Me.TxNombre.SelectionLength = 0
        Me.TxNombre.SelectionStart = 0
        Me.TxNombre.ShortcutsEnabled = True
        Me.TxNombre.Size = New System.Drawing.Size(135, 36)
        Me.TxNombre.SkipLiterals = True
        Me.TxNombre.TabIndex = 2
        Me.TxNombre.TabStop = False
        Me.TxNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.TxNombre.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals
        Me.TxNombre.TrailingIcon = Nothing
        Me.TxNombre.UseSystemPasswordChar = False
        Me.TxNombre.UseTallSize = False
        Me.TxNombre.ValidatingType = Nothing
        '
        'MaterialLabel4
        '
        Me.MaterialLabel4.AutoSize = True
        Me.MaterialLabel4.Depth = 0
        Me.MaterialLabel4.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.MaterialLabel4.FontType = MaterialSkin.MaterialSkinManager.fontType.Caption
        Me.MaterialLabel4.Location = New System.Drawing.Point(10, 85)
        Me.MaterialLabel4.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel4.Name = "MaterialLabel4"
        Me.MaterialLabel4.Size = New System.Drawing.Size(21, 14)
        Me.MaterialLabel4.TabIndex = 11
        Me.MaterialLabel4.Text = "DNI"
        '
        'MaterialLabel2
        '
        Me.MaterialLabel2.AutoSize = True
        Me.MaterialLabel2.Depth = 0
        Me.MaterialLabel2.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.MaterialLabel2.FontType = MaterialSkin.MaterialSkinManager.fontType.Caption
        Me.MaterialLabel2.Location = New System.Drawing.Point(120, 28)
        Me.MaterialLabel2.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel2.Name = "MaterialLabel2"
        Me.MaterialLabel2.Size = New System.Drawing.Size(45, 14)
        Me.MaterialLabel2.TabIndex = 7
        Me.MaterialLabel2.Text = "Nombre"
        '
        'MaterialLabel3
        '
        Me.MaterialLabel3.AutoSize = True
        Me.MaterialLabel3.Depth = 0
        Me.MaterialLabel3.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.MaterialLabel3.FontType = MaterialSkin.MaterialSkinManager.fontType.Caption
        Me.MaterialLabel3.Location = New System.Drawing.Point(335, 28)
        Me.MaterialLabel3.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel3.Name = "MaterialLabel3"
        Me.MaterialLabel3.Size = New System.Drawing.Size(51, 14)
        Me.MaterialLabel3.TabIndex = 9
        Me.MaterialLabel3.Text = "Apellidos"
        '
        'TxApellido
        '
        Me.TxApellido.AllowPromptAsInput = True
        Me.TxApellido.AnimateReadOnly = False
        Me.TxApellido.AsciiOnly = False
        Me.TxApellido.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.TxApellido.BeepOnError = False
        Me.TxApellido.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals
        Me.TxApellido.Depth = 0
        Me.TxApellido.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.TxApellido.HidePromptOnLeave = False
        Me.TxApellido.HideSelection = True
        Me.TxApellido.InsertKeyMode = System.Windows.Forms.InsertKeyMode.[Default]
        Me.TxApellido.LeadingIcon = Nothing
        Me.TxApellido.Location = New System.Drawing.Point(392, 17)
        Me.TxApellido.Mask = ""
        Me.TxApellido.MaxLength = 32767
        Me.TxApellido.MouseState = MaterialSkin.MouseState.OUT
        Me.TxApellido.Name = "TxApellido"
        Me.TxApellido.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxApellido.PrefixSuffixText = Nothing
        Me.TxApellido.PromptChar = Global.Microsoft.VisualBasic.ChrW(95)
        Me.TxApellido.ReadOnly = False
        Me.TxApellido.RejectInputOnFirstFailure = False
        Me.TxApellido.ResetOnPrompt = True
        Me.TxApellido.ResetOnSpace = True
        Me.TxApellido.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TxApellido.SelectedText = ""
        Me.TxApellido.SelectionLength = 0
        Me.TxApellido.SelectionStart = 0
        Me.TxApellido.ShortcutsEnabled = True
        Me.TxApellido.Size = New System.Drawing.Size(235, 36)
        Me.TxApellido.SkipLiterals = True
        Me.TxApellido.TabIndex = 3
        Me.TxApellido.TabStop = False
        Me.TxApellido.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.TxApellido.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals
        Me.TxApellido.TrailingIcon = Nothing
        Me.TxApellido.UseSystemPasswordChar = False
        Me.TxApellido.UseTallSize = False
        Me.TxApellido.ValidatingType = Nothing
        '
        'Usuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(1335, 779)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Usuarios"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "CrearUsuarios"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.PanelPass.ResumeLayout(False)
        Me.PanelPass.PerformLayout()
        Me.MaterialCard2.ResumeLayout(False)
        CType(Me.DbgUsuarios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.MaterialCard1.ResumeLayout(False)
        Me.MaterialCard1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents DbgUsuarios As DataGridView
    Friend WithEvents Panel3 As Panel
    Friend WithEvents TxIDbus As MaterialSkin.Controls.MaterialMaskedTextBox
    Friend WithEvents DTPfechaNac As DateTimePicker
    Friend WithEvents TxDNI As MaterialSkin.Controls.MaterialMaskedTextBox
    Friend WithEvents MaterialLabel4 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents TxApellido As MaterialSkin.Controls.MaterialMaskedTextBox
    Friend WithEvents MaterialLabel3 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents TxNombre As MaterialSkin.Controls.MaterialMaskedTextBox
    Friend WithEvents MaterialLabel2 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel1 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents TxID As MaterialSkin.Controls.MaterialMaskedTextBox
    Friend WithEvents TxDNIbus As MaterialSkin.Controls.MaterialMaskedTextBox
    Friend WithEvents TxApellidoBus As MaterialSkin.Controls.MaterialMaskedTextBox
    Friend WithEvents TxNombreBus As MaterialSkin.Controls.MaterialMaskedTextBox
    Friend WithEvents MaterialCard1 As MaterialSkin.Controls.MaterialCard
    Friend WithEvents MaterialLabel7 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents CboEquipo As MaterialSkin.Controls.MaterialComboBox
    Friend WithEvents TxTelefono As MaterialSkin.Controls.MaterialMaskedTextBox
    Friend WithEvents MaterialLabel6 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel5 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents TxLocalidad As MaterialSkin.Controls.MaterialMaskedTextBox
    Friend WithEvents MaterialLabel11 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents TxProvincia As MaterialSkin.Controls.MaterialMaskedTextBox
    Friend WithEvents MaterialLabel10 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents TxPais As MaterialSkin.Controls.MaterialMaskedTextBox
    Friend WithEvents MaterialLabel9 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents TxDireccion As MaterialSkin.Controls.MaterialMaskedTextBox
    Friend WithEvents MaterialLabel8 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents CboTipoUsuario As MaterialSkin.Controls.MaterialComboBox
    Friend WithEvents MaterialLabel12 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialCard2 As MaterialSkin.Controls.MaterialCard
    Friend WithEvents CboEquipoBus As MaterialSkin.Controls.MaterialComboBox
    Friend WithEvents PanelPass As MaterialSkin.Controls.MaterialCard
    Friend WithEvents TxNuevaPassword As MaterialSkin.Controls.MaterialMaskedTextBox
    Friend WithEvents MaterialLabel13 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents BtnGuardarPassword As MaterialSkin.Controls.MaterialButton
    Friend WithEvents BtnFiltrar As MaterialSkin.Controls.MaterialButton
    Friend WithEvents BtnAbrirPanelPassword As MaterialSkin.Controls.MaterialButton
    Friend WithEvents ID As DataGridViewTextBoxColumn
    Friend WithEvents Nombre As DataGridViewTextBoxColumn
    Friend WithEvents Apellidos As DataGridViewTextBoxColumn
    Friend WithEvents DNI As DataGridViewTextBoxColumn
    Friend WithEvents Telefono As DataGridViewTextBoxColumn
    Friend WithEvents Equipo As DataGridViewTextBoxColumn
End Class
