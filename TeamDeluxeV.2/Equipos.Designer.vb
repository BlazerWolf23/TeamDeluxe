<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Equipos
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.MaterialCard2 = New MaterialSkin.Controls.MaterialCard()
        Me.DbgEquipos = New System.Windows.Forms.DataGridView()
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Temporada = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Categoria = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.InicioCompeticion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Entrenador = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MaterialCard1 = New MaterialSkin.Controls.MaterialCard()
        Me.CboUsuario = New MaterialSkin.Controls.MaterialComboBox()
        Me.MaterialLabel12 = New MaterialSkin.Controls.MaterialLabel()
        Me.TxHoraPartido = New MaterialSkin.Controls.MaterialMaskedTextBox()
        Me.MaterialLabel6 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialLabel5 = New MaterialSkin.Controls.MaterialLabel()
        Me.DTPInicioCompe = New System.Windows.Forms.DateTimePicker()
        Me.TxIDEquipo = New MaterialSkin.Controls.MaterialMaskedTextBox()
        Me.MaterialLabel1 = New MaterialSkin.Controls.MaterialLabel()
        Me.TxCategoria = New MaterialSkin.Controls.MaterialMaskedTextBox()
        Me.TxNombreEquipo = New MaterialSkin.Controls.MaterialMaskedTextBox()
        Me.MaterialLabel4 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialLabel2 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialLabel3 = New MaterialSkin.Controls.MaterialLabel()
        Me.TxTemporada = New MaterialSkin.Controls.MaterialMaskedTextBox()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.MaterialCard2.SuspendLayout()
        CType(Me.DbgEquipos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MaterialCard1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Location = New System.Drawing.Point(1, 1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1167, 774)
        Me.Panel1.TabIndex = 1
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(207, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.MaterialCard2)
        Me.Panel2.Controls.Add(Me.MaterialCard1)
        Me.Panel2.Location = New System.Drawing.Point(3, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1159, 766)
        Me.Panel2.TabIndex = 1
        '
        'MaterialCard2
        '
        Me.MaterialCard2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MaterialCard2.Controls.Add(Me.DbgEquipos)
        Me.MaterialCard2.Depth = 0
        Me.MaterialCard2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialCard2.Location = New System.Drawing.Point(5, 192)
        Me.MaterialCard2.Margin = New System.Windows.Forms.Padding(14)
        Me.MaterialCard2.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialCard2.Name = "MaterialCard2"
        Me.MaterialCard2.Padding = New System.Windows.Forms.Padding(14)
        Me.MaterialCard2.Size = New System.Drawing.Size(642, 372)
        Me.MaterialCard2.TabIndex = 7
        '
        'DbgEquipos
        '
        Me.DbgEquipos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DbgEquipos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID, Me.Nombre, Me.Temporada, Me.Categoria, Me.InicioCompeticion, Me.Entrenador})
        Me.DbgEquipos.Location = New System.Drawing.Point(5, 7)
        Me.DbgEquipos.Name = "DbgEquipos"
        Me.DbgEquipos.Size = New System.Drawing.Size(632, 360)
        Me.DbgEquipos.TabIndex = 0
        '
        'ID
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ID.DefaultCellStyle = DataGridViewCellStyle2
        Me.ID.HeaderText = "ID"
        Me.ID.Name = "ID"
        Me.ID.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.ID.Width = 50
        '
        'Nombre
        '
        Me.Nombre.HeaderText = "Nombre"
        Me.Nombre.Name = "Nombre"
        '
        'Temporada
        '
        Me.Temporada.HeaderText = "Temporada"
        Me.Temporada.Name = "Temporada"
        Me.Temporada.Width = 140
        '
        'Categoria
        '
        Me.Categoria.HeaderText = "Categoria"
        Me.Categoria.Name = "Categoria"
        '
        'InicioCompeticion
        '
        Me.InicioCompeticion.HeaderText = "Ini. Competicion"
        Me.InicioCompeticion.Name = "InicioCompeticion"
        '
        'Entrenador
        '
        Me.Entrenador.HeaderText = "Entrenador"
        Me.Entrenador.Name = "Entrenador"
        '
        'MaterialCard1
        '
        Me.MaterialCard1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MaterialCard1.Controls.Add(Me.CboUsuario)
        Me.MaterialCard1.Controls.Add(Me.MaterialLabel12)
        Me.MaterialCard1.Controls.Add(Me.TxHoraPartido)
        Me.MaterialCard1.Controls.Add(Me.MaterialLabel6)
        Me.MaterialCard1.Controls.Add(Me.MaterialLabel5)
        Me.MaterialCard1.Controls.Add(Me.DTPInicioCompe)
        Me.MaterialCard1.Controls.Add(Me.TxIDEquipo)
        Me.MaterialCard1.Controls.Add(Me.MaterialLabel1)
        Me.MaterialCard1.Controls.Add(Me.TxCategoria)
        Me.MaterialCard1.Controls.Add(Me.TxNombreEquipo)
        Me.MaterialCard1.Controls.Add(Me.MaterialLabel4)
        Me.MaterialCard1.Controls.Add(Me.MaterialLabel2)
        Me.MaterialCard1.Controls.Add(Me.MaterialLabel3)
        Me.MaterialCard1.Controls.Add(Me.TxTemporada)
        Me.MaterialCard1.Depth = 0
        Me.MaterialCard1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialCard1.Location = New System.Drawing.Point(5, 6)
        Me.MaterialCard1.Margin = New System.Windows.Forms.Padding(14)
        Me.MaterialCard1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialCard1.Name = "MaterialCard1"
        Me.MaterialCard1.Padding = New System.Windows.Forms.Padding(14)
        Me.MaterialCard1.Size = New System.Drawing.Size(642, 176)
        Me.MaterialCard1.TabIndex = 6
        '
        'CboUsuario
        '
        Me.CboUsuario.AutoResize = False
        Me.CboUsuario.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CboUsuario.Depth = 0
        Me.CboUsuario.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me.CboUsuario.DropDownHeight = 118
        Me.CboUsuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboUsuario.DropDownWidth = 121
        Me.CboUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.CboUsuario.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.CboUsuario.FormattingEnabled = True
        Me.CboUsuario.IntegralHeight = False
        Me.CboUsuario.ItemHeight = 29
        Me.CboUsuario.Location = New System.Drawing.Point(412, 124)
        Me.CboUsuario.MaxDropDownItems = 4
        Me.CboUsuario.MouseState = MaterialSkin.MouseState.OUT
        Me.CboUsuario.Name = "CboUsuario"
        Me.CboUsuario.Size = New System.Drawing.Size(175, 35)
        Me.CboUsuario.StartIndex = 0
        Me.CboUsuario.TabIndex = 13
        Me.CboUsuario.UseTallSize = False
        '
        'MaterialLabel12
        '
        Me.MaterialLabel12.AutoSize = True
        Me.MaterialLabel12.Depth = 0
        Me.MaterialLabel12.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.MaterialLabel12.FontType = MaterialSkin.MaterialSkinManager.fontType.Caption
        Me.MaterialLabel12.Location = New System.Drawing.Point(349, 135)
        Me.MaterialLabel12.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel12.Name = "MaterialLabel12"
        Me.MaterialLabel12.Size = New System.Drawing.Size(61, 14)
        Me.MaterialLabel12.TabIndex = 28
        Me.MaterialLabel12.Text = "Entrenador"
        '
        'TxHoraPartido
        '
        Me.TxHoraPartido.AllowPromptAsInput = True
        Me.TxHoraPartido.AnimateReadOnly = False
        Me.TxHoraPartido.AsciiOnly = False
        Me.TxHoraPartido.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.TxHoraPartido.BeepOnError = False
        Me.TxHoraPartido.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals
        Me.TxHoraPartido.Depth = 0
        Me.TxHoraPartido.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.TxHoraPartido.HidePromptOnLeave = False
        Me.TxHoraPartido.HideSelection = True
        Me.TxHoraPartido.InsertKeyMode = System.Windows.Forms.InsertKeyMode.[Default]
        Me.TxHoraPartido.LeadingIcon = Nothing
        Me.TxHoraPartido.Location = New System.Drawing.Point(171, 123)
        Me.TxHoraPartido.Mask = "00:00"
        Me.TxHoraPartido.MaxLength = 32767
        Me.TxHoraPartido.MouseState = MaterialSkin.MouseState.OUT
        Me.TxHoraPartido.Name = "TxHoraPartido"
        Me.TxHoraPartido.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxHoraPartido.PrefixSuffixText = Nothing
        Me.TxHoraPartido.PromptChar = Global.Microsoft.VisualBasic.ChrW(95)
        Me.TxHoraPartido.ReadOnly = False
        Me.TxHoraPartido.RejectInputOnFirstFailure = False
        Me.TxHoraPartido.ResetOnPrompt = True
        Me.TxHoraPartido.ResetOnSpace = True
        Me.TxHoraPartido.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TxHoraPartido.SelectedText = ""
        Me.TxHoraPartido.SelectionLength = 0
        Me.TxHoraPartido.SelectionStart = 0
        Me.TxHoraPartido.ShortcutsEnabled = True
        Me.TxHoraPartido.Size = New System.Drawing.Size(74, 36)
        Me.TxHoraPartido.SkipLiterals = True
        Me.TxHoraPartido.TabIndex = 6
        Me.TxHoraPartido.TabStop = False
        Me.TxHoraPartido.Text = "  :"
        Me.TxHoraPartido.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TxHoraPartido.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals
        Me.TxHoraPartido.TrailingIcon = Nothing
        Me.TxHoraPartido.UseSystemPasswordChar = False
        Me.TxHoraPartido.UseTallSize = False
        Me.TxHoraPartido.ValidatingType = Nothing
        '
        'MaterialLabel6
        '
        Me.MaterialLabel6.AutoSize = True
        Me.MaterialLabel6.Depth = 0
        Me.MaterialLabel6.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.MaterialLabel6.FontType = MaterialSkin.MaterialSkinManager.fontType.Caption
        Me.MaterialLabel6.Location = New System.Drawing.Point(75, 134)
        Me.MaterialLabel6.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel6.Name = "MaterialLabel6"
        Me.MaterialLabel6.Size = New System.Drawing.Size(77, 14)
        Me.MaterialLabel6.TabIndex = 15
        Me.MaterialLabel6.Text = "Hora Partidos"
        '
        'MaterialLabel5
        '
        Me.MaterialLabel5.AutoSize = True
        Me.MaterialLabel5.Depth = 0
        Me.MaterialLabel5.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.MaterialLabel5.FontType = MaterialSkin.MaterialSkinManager.fontType.Caption
        Me.MaterialLabel5.Location = New System.Drawing.Point(371, 82)
        Me.MaterialLabel5.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel5.Name = "MaterialLabel5"
        Me.MaterialLabel5.Size = New System.Drawing.Size(102, 14)
        Me.MaterialLabel5.TabIndex = 14
        Me.MaterialLabel5.Text = "Inicio Competicion"
        '
        'DTPInicioCompe
        '
        Me.DTPInicioCompe.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.DTPInicioCompe.CalendarMonthBackground = System.Drawing.Color.White
        Me.DTPInicioCompe.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTPInicioCompe.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTPInicioCompe.Location = New System.Drawing.Point(480, 79)
        Me.DTPInicioCompe.Name = "DTPInicioCompe"
        Me.DTPInicioCompe.Size = New System.Drawing.Size(107, 20)
        Me.DTPInicioCompe.TabIndex = 5
        '
        'TxIDEquipo
        '
        Me.TxIDEquipo.AllowPromptAsInput = True
        Me.TxIDEquipo.AnimateReadOnly = False
        Me.TxIDEquipo.AsciiOnly = False
        Me.TxIDEquipo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.TxIDEquipo.BeepOnError = False
        Me.TxIDEquipo.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals
        Me.TxIDEquipo.Depth = 0
        Me.TxIDEquipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 5.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.TxIDEquipo.HidePromptOnLeave = False
        Me.TxIDEquipo.HideSelection = True
        Me.TxIDEquipo.InsertKeyMode = System.Windows.Forms.InsertKeyMode.[Default]
        Me.TxIDEquipo.LeadingIcon = Nothing
        Me.TxIDEquipo.Location = New System.Drawing.Point(37, 17)
        Me.TxIDEquipo.Mask = ""
        Me.TxIDEquipo.MaxLength = 32767
        Me.TxIDEquipo.MouseState = MaterialSkin.MouseState.OUT
        Me.TxIDEquipo.Name = "TxIDEquipo"
        Me.TxIDEquipo.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxIDEquipo.PrefixSuffixText = Nothing
        Me.TxIDEquipo.PromptChar = Global.Microsoft.VisualBasic.ChrW(95)
        Me.TxIDEquipo.ReadOnly = False
        Me.TxIDEquipo.RejectInputOnFirstFailure = False
        Me.TxIDEquipo.ResetOnPrompt = True
        Me.TxIDEquipo.ResetOnSpace = True
        Me.TxIDEquipo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TxIDEquipo.SelectedText = ""
        Me.TxIDEquipo.SelectionLength = 0
        Me.TxIDEquipo.SelectionStart = 0
        Me.TxIDEquipo.ShortcutsEnabled = True
        Me.TxIDEquipo.Size = New System.Drawing.Size(58, 36)
        Me.TxIDEquipo.SkipLiterals = True
        Me.TxIDEquipo.TabIndex = 1
        Me.TxIDEquipo.TabStop = False
        Me.TxIDEquipo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.TxIDEquipo.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals
        Me.TxIDEquipo.TrailingIcon = Nothing
        Me.TxIDEquipo.UseSystemPasswordChar = False
        Me.TxIDEquipo.UseTallSize = False
        Me.TxIDEquipo.ValidatingType = Nothing
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
        'TxCategoria
        '
        Me.TxCategoria.AllowPromptAsInput = True
        Me.TxCategoria.AnimateReadOnly = False
        Me.TxCategoria.AsciiOnly = False
        Me.TxCategoria.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.TxCategoria.BeepOnError = False
        Me.TxCategoria.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals
        Me.TxCategoria.Depth = 0
        Me.TxCategoria.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.TxCategoria.HidePromptOnLeave = False
        Me.TxCategoria.HideSelection = True
        Me.TxCategoria.InsertKeyMode = System.Windows.Forms.InsertKeyMode.[Default]
        Me.TxCategoria.LeadingIcon = Nothing
        Me.TxCategoria.Location = New System.Drawing.Point(70, 73)
        Me.TxCategoria.Mask = ""
        Me.TxCategoria.MaxLength = 32767
        Me.TxCategoria.MouseState = MaterialSkin.MouseState.OUT
        Me.TxCategoria.Name = "TxCategoria"
        Me.TxCategoria.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxCategoria.PrefixSuffixText = Nothing
        Me.TxCategoria.PromptChar = Global.Microsoft.VisualBasic.ChrW(95)
        Me.TxCategoria.ReadOnly = False
        Me.TxCategoria.RejectInputOnFirstFailure = False
        Me.TxCategoria.ResetOnPrompt = True
        Me.TxCategoria.ResetOnSpace = True
        Me.TxCategoria.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TxCategoria.SelectedText = ""
        Me.TxCategoria.SelectionLength = 0
        Me.TxCategoria.SelectionStart = 0
        Me.TxCategoria.ShortcutsEnabled = True
        Me.TxCategoria.Size = New System.Drawing.Size(254, 36)
        Me.TxCategoria.SkipLiterals = True
        Me.TxCategoria.TabIndex = 4
        Me.TxCategoria.TabStop = False
        Me.TxCategoria.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.TxCategoria.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals
        Me.TxCategoria.TrailingIcon = Nothing
        Me.TxCategoria.UseSystemPasswordChar = False
        Me.TxCategoria.UseTallSize = False
        Me.TxCategoria.ValidatingType = Nothing
        '
        'TxNombreEquipo
        '
        Me.TxNombreEquipo.AllowPromptAsInput = True
        Me.TxNombreEquipo.AnimateReadOnly = False
        Me.TxNombreEquipo.AsciiOnly = False
        Me.TxNombreEquipo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.TxNombreEquipo.BeepOnError = False
        Me.TxNombreEquipo.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals
        Me.TxNombreEquipo.Depth = 0
        Me.TxNombreEquipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.TxNombreEquipo.HidePromptOnLeave = False
        Me.TxNombreEquipo.HideSelection = True
        Me.TxNombreEquipo.InsertKeyMode = System.Windows.Forms.InsertKeyMode.[Default]
        Me.TxNombreEquipo.LeadingIcon = Nothing
        Me.TxNombreEquipo.Location = New System.Drawing.Point(171, 17)
        Me.TxNombreEquipo.Mask = ""
        Me.TxNombreEquipo.MaxLength = 32767
        Me.TxNombreEquipo.MouseState = MaterialSkin.MouseState.OUT
        Me.TxNombreEquipo.Name = "TxNombreEquipo"
        Me.TxNombreEquipo.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxNombreEquipo.PrefixSuffixText = Nothing
        Me.TxNombreEquipo.PromptChar = Global.Microsoft.VisualBasic.ChrW(95)
        Me.TxNombreEquipo.ReadOnly = False
        Me.TxNombreEquipo.RejectInputOnFirstFailure = False
        Me.TxNombreEquipo.ResetOnPrompt = True
        Me.TxNombreEquipo.ResetOnSpace = True
        Me.TxNombreEquipo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TxNombreEquipo.SelectedText = ""
        Me.TxNombreEquipo.SelectionLength = 0
        Me.TxNombreEquipo.SelectionStart = 0
        Me.TxNombreEquipo.ShortcutsEnabled = True
        Me.TxNombreEquipo.Size = New System.Drawing.Size(199, 36)
        Me.TxNombreEquipo.SkipLiterals = True
        Me.TxNombreEquipo.TabIndex = 2
        Me.TxNombreEquipo.TabStop = False
        Me.TxNombreEquipo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.TxNombreEquipo.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals
        Me.TxNombreEquipo.TrailingIcon = Nothing
        Me.TxNombreEquipo.UseSystemPasswordChar = False
        Me.TxNombreEquipo.UseTallSize = False
        Me.TxNombreEquipo.ValidatingType = Nothing
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
        Me.MaterialLabel4.Size = New System.Drawing.Size(54, 14)
        Me.MaterialLabel4.TabIndex = 11
        Me.MaterialLabel4.Text = "Categoria"
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
        Me.MaterialLabel3.Location = New System.Drawing.Point(411, 28)
        Me.MaterialLabel3.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel3.Name = "MaterialLabel3"
        Me.MaterialLabel3.Size = New System.Drawing.Size(64, 14)
        Me.MaterialLabel3.TabIndex = 9
        Me.MaterialLabel3.Text = "Temporada"
        '
        'TxTemporada
        '
        Me.TxTemporada.AllowPromptAsInput = True
        Me.TxTemporada.AnimateReadOnly = False
        Me.TxTemporada.AsciiOnly = False
        Me.TxTemporada.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.TxTemporada.BeepOnError = False
        Me.TxTemporada.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals
        Me.TxTemporada.Depth = 0
        Me.TxTemporada.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.TxTemporada.HidePromptOnLeave = False
        Me.TxTemporada.HideSelection = True
        Me.TxTemporada.InsertKeyMode = System.Windows.Forms.InsertKeyMode.[Default]
        Me.TxTemporada.LeadingIcon = Nothing
        Me.TxTemporada.Location = New System.Drawing.Point(480, 17)
        Me.TxTemporada.Mask = ""
        Me.TxTemporada.MaxLength = 32767
        Me.TxTemporada.MouseState = MaterialSkin.MouseState.OUT
        Me.TxTemporada.Name = "TxTemporada"
        Me.TxTemporada.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxTemporada.PrefixSuffixText = Nothing
        Me.TxTemporada.PromptChar = Global.Microsoft.VisualBasic.ChrW(95)
        Me.TxTemporada.ReadOnly = False
        Me.TxTemporada.RejectInputOnFirstFailure = False
        Me.TxTemporada.ResetOnPrompt = True
        Me.TxTemporada.ResetOnSpace = True
        Me.TxTemporada.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TxTemporada.SelectedText = ""
        Me.TxTemporada.SelectionLength = 0
        Me.TxTemporada.SelectionStart = 0
        Me.TxTemporada.ShortcutsEnabled = True
        Me.TxTemporada.Size = New System.Drawing.Size(147, 36)
        Me.TxTemporada.SkipLiterals = True
        Me.TxTemporada.TabIndex = 3
        Me.TxTemporada.TabStop = False
        Me.TxTemporada.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.TxTemporada.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals
        Me.TxTemporada.TrailingIcon = Nothing
        Me.TxTemporada.UseSystemPasswordChar = False
        Me.TxTemporada.UseTallSize = False
        Me.TxTemporada.ValidatingType = Nothing
        '
        'Equipos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1335, 779)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Equipos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Equipos"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.MaterialCard2.ResumeLayout(False)
        CType(Me.DbgEquipos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MaterialCard1.ResumeLayout(False)
        Me.MaterialCard1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents MaterialCard2 As MaterialSkin.Controls.MaterialCard
    Friend WithEvents DbgEquipos As DataGridView
    Friend WithEvents MaterialCard1 As MaterialSkin.Controls.MaterialCard
    Friend WithEvents CboUsuario As MaterialSkin.Controls.MaterialComboBox
    Friend WithEvents MaterialLabel12 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents TxHoraPartido As MaterialSkin.Controls.MaterialMaskedTextBox
    Friend WithEvents MaterialLabel6 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents TxIDEquipo As MaterialSkin.Controls.MaterialMaskedTextBox
    Friend WithEvents MaterialLabel1 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents TxCategoria As MaterialSkin.Controls.MaterialMaskedTextBox
    Friend WithEvents TxNombreEquipo As MaterialSkin.Controls.MaterialMaskedTextBox
    Friend WithEvents MaterialLabel4 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel2 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel3 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents TxTemporada As MaterialSkin.Controls.MaterialMaskedTextBox
    Friend WithEvents MaterialLabel5 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents DTPInicioCompe As DateTimePicker
    Friend WithEvents ID As DataGridViewTextBoxColumn
    Friend WithEvents Nombre As DataGridViewTextBoxColumn
    Friend WithEvents Temporada As DataGridViewTextBoxColumn
    Friend WithEvents Categoria As DataGridViewTextBoxColumn
    Friend WithEvents InicioCompeticion As DataGridViewTextBoxColumn
    Friend WithEvents Entrenador As DataGridViewTextBoxColumn
End Class
