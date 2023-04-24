<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ejercicios
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Ejercicios))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.MaterialCard4 = New MaterialSkin.Controls.MaterialCard()
        Me.BtnNuevoObjetivo = New MaterialSkin.Controls.MaterialButton()
        Me.TxNombreNuvObjetivo = New MaterialSkin.Controls.MaterialMaskedTextBox()
        Me.DbgObjetivos = New System.Windows.Forms.DataGridView()
        Me.MaterialCard3 = New MaterialSkin.Controls.MaterialCard()
        Me.DbgObjetivosEjercicios = New System.Windows.Forms.DataGridView()
        Me.MaterialCard2 = New MaterialSkin.Controls.MaterialCard()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.BtnLineaPunteada = New MaterialSkin.Controls.MaterialButton()
        Me.BtnLineaNomal = New MaterialSkin.Controls.MaterialButton()
        Me.Vaciarimagen = New MaterialSkin.Controls.MaterialButton()
        Me.BtnImportarImagen = New MaterialSkin.Controls.MaterialButton()
        Me.BtnPersona = New MaterialSkin.Controls.MaterialButton()
        Me.BtnExportarImagen = New MaterialSkin.Controls.MaterialButton()
        Me.BtnCono = New MaterialSkin.Controls.MaterialButton()
        Me.PBImagenCampo = New System.Windows.Forms.PictureBox()
        Me.MaterialCard1 = New MaterialSkin.Controls.MaterialCard()
        Me.MaterialLabel8 = New MaterialSkin.Controls.MaterialLabel()
        Me.TxJugadores = New MaterialSkin.Controls.MaterialMaskedTextBox()
        Me.MaterialLabel6 = New MaterialSkin.Controls.MaterialLabel()
        Me.TxMaterial = New MaterialSkin.Controls.MaterialMultiLineTextBox2()
        Me.MaterialLabel5 = New MaterialSkin.Controls.MaterialLabel()
        Me.TxObservaciones = New MaterialSkin.Controls.MaterialMultiLineTextBox2()
        Me.MaterialLabel4 = New MaterialSkin.Controls.MaterialLabel()
        Me.TxDescripcion = New MaterialSkin.Controls.MaterialMultiLineTextBox2()
        Me.TxID = New MaterialSkin.Controls.MaterialMaskedTextBox()
        Me.MaterialLabel1 = New MaterialSkin.Controls.MaterialLabel()
        Me.TxNombre = New MaterialSkin.Controls.MaterialMaskedTextBox()
        Me.MaterialLabel2 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialLabel3 = New MaterialSkin.Controls.MaterialLabel()
        Me.TxPorteros = New MaterialSkin.Controls.MaterialMaskedTextBox()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Objetivo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MaterialLabel7 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialLabel9 = New MaterialSkin.Controls.MaterialLabel()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.MaterialCard4.SuspendLayout()
        CType(Me.DbgObjetivos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MaterialCard3.SuspendLayout()
        CType(Me.DbgObjetivosEjercicios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MaterialCard2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.PBImagenCampo, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Panel1.Size = New System.Drawing.Size(923, 774)
        Me.Panel1.TabIndex = 1
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(207, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.MaterialCard4)
        Me.Panel2.Controls.Add(Me.MaterialCard3)
        Me.Panel2.Controls.Add(Me.MaterialCard2)
        Me.Panel2.Controls.Add(Me.MaterialCard1)
        Me.Panel2.Location = New System.Drawing.Point(3, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(914, 766)
        Me.Panel2.TabIndex = 1
        '
        'MaterialCard4
        '
        Me.MaterialCard4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MaterialCard4.Controls.Add(Me.MaterialLabel9)
        Me.MaterialCard4.Controls.Add(Me.BtnNuevoObjetivo)
        Me.MaterialCard4.Controls.Add(Me.TxNombreNuvObjetivo)
        Me.MaterialCard4.Controls.Add(Me.DbgObjetivos)
        Me.MaterialCard4.Depth = 0
        Me.MaterialCard4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialCard4.Location = New System.Drawing.Point(618, 490)
        Me.MaterialCard4.Margin = New System.Windows.Forms.Padding(14)
        Me.MaterialCard4.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialCard4.Name = "MaterialCard4"
        Me.MaterialCard4.Padding = New System.Windows.Forms.Padding(14)
        Me.MaterialCard4.Size = New System.Drawing.Size(288, 264)
        Me.MaterialCard4.TabIndex = 29
        '
        'BtnNuevoObjetivo
        '
        Me.BtnNuevoObjetivo.AutoSize = False
        Me.BtnNuevoObjetivo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BtnNuevoObjetivo.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.BtnNuevoObjetivo.Depth = 0
        Me.BtnNuevoObjetivo.HighEmphasis = True
        Me.BtnNuevoObjetivo.Icon = CType(resources.GetObject("BtnNuevoObjetivo.Icon"), System.Drawing.Image)
        Me.BtnNuevoObjetivo.Location = New System.Drawing.Point(237, 214)
        Me.BtnNuevoObjetivo.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.BtnNuevoObjetivo.MouseState = MaterialSkin.MouseState.HOVER
        Me.BtnNuevoObjetivo.Name = "BtnNuevoObjetivo"
        Me.BtnNuevoObjetivo.NoAccentTextColor = System.Drawing.Color.Empty
        Me.BtnNuevoObjetivo.Size = New System.Drawing.Size(42, 42)
        Me.BtnNuevoObjetivo.TabIndex = 8
        Me.BtnNuevoObjetivo.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.BtnNuevoObjetivo.UseAccentColor = False
        Me.BtnNuevoObjetivo.UseVisualStyleBackColor = True
        '
        'TxNombreNuvObjetivo
        '
        Me.TxNombreNuvObjetivo.AllowPromptAsInput = True
        Me.TxNombreNuvObjetivo.AnimateReadOnly = False
        Me.TxNombreNuvObjetivo.AsciiOnly = False
        Me.TxNombreNuvObjetivo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.TxNombreNuvObjetivo.BeepOnError = False
        Me.TxNombreNuvObjetivo.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals
        Me.TxNombreNuvObjetivo.Depth = 0
        Me.TxNombreNuvObjetivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.TxNombreNuvObjetivo.HidePromptOnLeave = False
        Me.TxNombreNuvObjetivo.HideSelection = True
        Me.TxNombreNuvObjetivo.InsertKeyMode = System.Windows.Forms.InsertKeyMode.[Default]
        Me.TxNombreNuvObjetivo.LeadingIcon = Nothing
        Me.TxNombreNuvObjetivo.Location = New System.Drawing.Point(7, 220)
        Me.TxNombreNuvObjetivo.Mask = ""
        Me.TxNombreNuvObjetivo.MaxLength = 32767
        Me.TxNombreNuvObjetivo.MouseState = MaterialSkin.MouseState.OUT
        Me.TxNombreNuvObjetivo.Name = "TxNombreNuvObjetivo"
        Me.TxNombreNuvObjetivo.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxNombreNuvObjetivo.PrefixSuffixText = Nothing
        Me.TxNombreNuvObjetivo.PromptChar = Global.Microsoft.VisualBasic.ChrW(95)
        Me.TxNombreNuvObjetivo.ReadOnly = False
        Me.TxNombreNuvObjetivo.RejectInputOnFirstFailure = False
        Me.TxNombreNuvObjetivo.ResetOnPrompt = True
        Me.TxNombreNuvObjetivo.ResetOnSpace = True
        Me.TxNombreNuvObjetivo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TxNombreNuvObjetivo.SelectedText = ""
        Me.TxNombreNuvObjetivo.SelectionLength = 0
        Me.TxNombreNuvObjetivo.SelectionStart = 0
        Me.TxNombreNuvObjetivo.ShortcutsEnabled = True
        Me.TxNombreNuvObjetivo.Size = New System.Drawing.Size(223, 36)
        Me.TxNombreNuvObjetivo.SkipLiterals = True
        Me.TxNombreNuvObjetivo.TabIndex = 27
        Me.TxNombreNuvObjetivo.TabStop = False
        Me.TxNombreNuvObjetivo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.TxNombreNuvObjetivo.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals
        Me.TxNombreNuvObjetivo.TrailingIcon = Nothing
        Me.TxNombreNuvObjetivo.UseSystemPasswordChar = False
        Me.TxNombreNuvObjetivo.UseTallSize = False
        Me.TxNombreNuvObjetivo.ValidatingType = Nothing
        '
        'DbgObjetivos
        '
        Me.DbgObjetivos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DbgObjetivos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2})
        Me.DbgObjetivos.Location = New System.Drawing.Point(7, 32)
        Me.DbgObjetivos.Name = "DbgObjetivos"
        Me.DbgObjetivos.Size = New System.Drawing.Size(272, 166)
        Me.DbgObjetivos.TabIndex = 1
        '
        'MaterialCard3
        '
        Me.MaterialCard3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.MaterialCard3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MaterialCard3.Controls.Add(Me.MaterialLabel7)
        Me.MaterialCard3.Controls.Add(Me.DbgObjetivosEjercicios)
        Me.MaterialCard3.Depth = 0
        Me.MaterialCard3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialCard3.Location = New System.Drawing.Point(618, 300)
        Me.MaterialCard3.Margin = New System.Windows.Forms.Padding(14)
        Me.MaterialCard3.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialCard3.Name = "MaterialCard3"
        Me.MaterialCard3.Padding = New System.Windows.Forms.Padding(14)
        Me.MaterialCard3.Size = New System.Drawing.Size(288, 181)
        Me.MaterialCard3.TabIndex = 28
        '
        'DbgObjetivosEjercicios
        '
        Me.DbgObjetivosEjercicios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DbgObjetivosEjercicios.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID, Me.Objetivo})
        Me.DbgObjetivosEjercicios.Location = New System.Drawing.Point(7, 33)
        Me.DbgObjetivosEjercicios.Name = "DbgObjetivosEjercicios"
        Me.DbgObjetivosEjercicios.Size = New System.Drawing.Size(272, 141)
        Me.DbgObjetivosEjercicios.TabIndex = 0
        '
        'MaterialCard2
        '
        Me.MaterialCard2.AllowDrop = True
        Me.MaterialCard2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MaterialCard2.Controls.Add(Me.Panel3)
        Me.MaterialCard2.Controls.Add(Me.PBImagenCampo)
        Me.MaterialCard2.Depth = 0
        Me.MaterialCard2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialCard2.Location = New System.Drawing.Point(5, 300)
        Me.MaterialCard2.Margin = New System.Windows.Forms.Padding(14)
        Me.MaterialCard2.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialCard2.Name = "MaterialCard2"
        Me.MaterialCard2.Padding = New System.Windows.Forms.Padding(14)
        Me.MaterialCard2.Size = New System.Drawing.Size(607, 457)
        Me.MaterialCard2.TabIndex = 27
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(207, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Panel3.Controls.Add(Me.BtnLineaPunteada)
        Me.Panel3.Controls.Add(Me.BtnLineaNomal)
        Me.Panel3.Controls.Add(Me.Vaciarimagen)
        Me.Panel3.Controls.Add(Me.BtnImportarImagen)
        Me.Panel3.Controls.Add(Me.BtnPersona)
        Me.Panel3.Controls.Add(Me.BtnExportarImagen)
        Me.Panel3.Controls.Add(Me.BtnCono)
        Me.Panel3.Location = New System.Drawing.Point(8, 10)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(588, 52)
        Me.Panel3.TabIndex = 6
        '
        'BtnLineaPunteada
        '
        Me.BtnLineaPunteada.AutoSize = False
        Me.BtnLineaPunteada.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BtnLineaPunteada.BackgroundImage = CType(resources.GetObject("BtnLineaPunteada.BackgroundImage"), System.Drawing.Image)
        Me.BtnLineaPunteada.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.BtnLineaPunteada.Depth = 0
        Me.BtnLineaPunteada.HighEmphasis = True
        Me.BtnLineaPunteada.Icon = CType(resources.GetObject("BtnLineaPunteada.Icon"), System.Drawing.Image)
        Me.BtnLineaPunteada.Location = New System.Drawing.Point(299, 3)
        Me.BtnLineaPunteada.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.BtnLineaPunteada.MouseState = MaterialSkin.MouseState.HOVER
        Me.BtnLineaPunteada.Name = "BtnLineaPunteada"
        Me.BtnLineaPunteada.NoAccentTextColor = System.Drawing.Color.Empty
        Me.BtnLineaPunteada.Size = New System.Drawing.Size(42, 42)
        Me.BtnLineaPunteada.TabIndex = 6
        Me.BtnLineaPunteada.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.BtnLineaPunteada.UseAccentColor = False
        Me.BtnLineaPunteada.UseVisualStyleBackColor = True
        '
        'BtnLineaNomal
        '
        Me.BtnLineaNomal.AutoSize = False
        Me.BtnLineaNomal.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BtnLineaNomal.BackgroundImage = CType(resources.GetObject("BtnLineaNomal.BackgroundImage"), System.Drawing.Image)
        Me.BtnLineaNomal.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.BtnLineaNomal.Depth = 0
        Me.BtnLineaNomal.HighEmphasis = True
        Me.BtnLineaNomal.Icon = CType(resources.GetObject("BtnLineaNomal.Icon"), System.Drawing.Image)
        Me.BtnLineaNomal.Location = New System.Drawing.Point(249, 3)
        Me.BtnLineaNomal.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.BtnLineaNomal.MouseState = MaterialSkin.MouseState.HOVER
        Me.BtnLineaNomal.Name = "BtnLineaNomal"
        Me.BtnLineaNomal.NoAccentTextColor = System.Drawing.Color.Empty
        Me.BtnLineaNomal.Size = New System.Drawing.Size(42, 42)
        Me.BtnLineaNomal.TabIndex = 7
        Me.BtnLineaNomal.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.BtnLineaNomal.UseAccentColor = False
        Me.BtnLineaNomal.UseVisualStyleBackColor = True
        '
        'Vaciarimagen
        '
        Me.Vaciarimagen.AutoSize = False
        Me.Vaciarimagen.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Vaciarimagen.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.Vaciarimagen.Depth = 0
        Me.Vaciarimagen.HighEmphasis = True
        Me.Vaciarimagen.Icon = CType(resources.GetObject("Vaciarimagen.Icon"), System.Drawing.Image)
        Me.Vaciarimagen.Location = New System.Drawing.Point(439, 5)
        Me.Vaciarimagen.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.Vaciarimagen.MouseState = MaterialSkin.MouseState.HOVER
        Me.Vaciarimagen.Name = "Vaciarimagen"
        Me.Vaciarimagen.NoAccentTextColor = System.Drawing.Color.Empty
        Me.Vaciarimagen.Size = New System.Drawing.Size(42, 42)
        Me.Vaciarimagen.TabIndex = 7
        Me.Vaciarimagen.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.Vaciarimagen.UseAccentColor = False
        Me.Vaciarimagen.UseVisualStyleBackColor = True
        '
        'BtnImportarImagen
        '
        Me.BtnImportarImagen.AutoSize = False
        Me.BtnImportarImagen.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BtnImportarImagen.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.BtnImportarImagen.Depth = 0
        Me.BtnImportarImagen.HighEmphasis = True
        Me.BtnImportarImagen.Icon = CType(resources.GetObject("BtnImportarImagen.Icon"), System.Drawing.Image)
        Me.BtnImportarImagen.Location = New System.Drawing.Point(489, 5)
        Me.BtnImportarImagen.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.BtnImportarImagen.MouseState = MaterialSkin.MouseState.HOVER
        Me.BtnImportarImagen.Name = "BtnImportarImagen"
        Me.BtnImportarImagen.NoAccentTextColor = System.Drawing.Color.Empty
        Me.BtnImportarImagen.Size = New System.Drawing.Size(42, 42)
        Me.BtnImportarImagen.TabIndex = 6
        Me.BtnImportarImagen.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.BtnImportarImagen.UseAccentColor = False
        Me.BtnImportarImagen.UseVisualStyleBackColor = True
        '
        'BtnPersona
        '
        Me.BtnPersona.AutoSize = False
        Me.BtnPersona.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BtnPersona.BackgroundImage = CType(resources.GetObject("BtnPersona.BackgroundImage"), System.Drawing.Image)
        Me.BtnPersona.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.BtnPersona.Depth = 0
        Me.BtnPersona.HighEmphasis = True
        Me.BtnPersona.Icon = CType(resources.GetObject("BtnPersona.Icon"), System.Drawing.Image)
        Me.BtnPersona.Location = New System.Drawing.Point(56, 5)
        Me.BtnPersona.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.BtnPersona.MouseState = MaterialSkin.MouseState.HOVER
        Me.BtnPersona.Name = "BtnPersona"
        Me.BtnPersona.NoAccentTextColor = System.Drawing.Color.Empty
        Me.BtnPersona.Size = New System.Drawing.Size(42, 42)
        Me.BtnPersona.TabIndex = 4
        Me.BtnPersona.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.BtnPersona.UseAccentColor = False
        Me.BtnPersona.UseVisualStyleBackColor = True
        '
        'BtnExportarImagen
        '
        Me.BtnExportarImagen.AutoSize = False
        Me.BtnExportarImagen.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BtnExportarImagen.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.BtnExportarImagen.Depth = 0
        Me.BtnExportarImagen.HighEmphasis = True
        Me.BtnExportarImagen.Icon = CType(resources.GetObject("BtnExportarImagen.Icon"), System.Drawing.Image)
        Me.BtnExportarImagen.Location = New System.Drawing.Point(539, 5)
        Me.BtnExportarImagen.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.BtnExportarImagen.MouseState = MaterialSkin.MouseState.HOVER
        Me.BtnExportarImagen.Name = "BtnExportarImagen"
        Me.BtnExportarImagen.NoAccentTextColor = System.Drawing.Color.Empty
        Me.BtnExportarImagen.Size = New System.Drawing.Size(42, 42)
        Me.BtnExportarImagen.TabIndex = 3
        Me.BtnExportarImagen.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.BtnExportarImagen.UseAccentColor = False
        Me.BtnExportarImagen.UseVisualStyleBackColor = True
        '
        'BtnCono
        '
        Me.BtnCono.AutoSize = False
        Me.BtnCono.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BtnCono.BackgroundImage = CType(resources.GetObject("BtnCono.BackgroundImage"), System.Drawing.Image)
        Me.BtnCono.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.BtnCono.Depth = 0
        Me.BtnCono.HighEmphasis = True
        Me.BtnCono.Icon = CType(resources.GetObject("BtnCono.Icon"), System.Drawing.Image)
        Me.BtnCono.Location = New System.Drawing.Point(6, 5)
        Me.BtnCono.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.BtnCono.MouseState = MaterialSkin.MouseState.HOVER
        Me.BtnCono.Name = "BtnCono"
        Me.BtnCono.NoAccentTextColor = System.Drawing.Color.Empty
        Me.BtnCono.Size = New System.Drawing.Size(42, 42)
        Me.BtnCono.TabIndex = 5
        Me.BtnCono.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.BtnCono.UseAccentColor = False
        Me.BtnCono.UseVisualStyleBackColor = True
        '
        'PBImagenCampo
        '
        Me.PBImagenCampo.BackgroundImage = CType(resources.GetObject("PBImagenCampo.BackgroundImage"), System.Drawing.Image)
        Me.PBImagenCampo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PBImagenCampo.Location = New System.Drawing.Point(8, 68)
        Me.PBImagenCampo.Name = "PBImagenCampo"
        Me.PBImagenCampo.Size = New System.Drawing.Size(588, 380)
        Me.PBImagenCampo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PBImagenCampo.TabIndex = 0
        Me.PBImagenCampo.TabStop = False
        '
        'MaterialCard1
        '
        Me.MaterialCard1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MaterialCard1.Controls.Add(Me.MaterialLabel8)
        Me.MaterialCard1.Controls.Add(Me.TxJugadores)
        Me.MaterialCard1.Controls.Add(Me.MaterialLabel6)
        Me.MaterialCard1.Controls.Add(Me.TxMaterial)
        Me.MaterialCard1.Controls.Add(Me.MaterialLabel5)
        Me.MaterialCard1.Controls.Add(Me.TxObservaciones)
        Me.MaterialCard1.Controls.Add(Me.MaterialLabel4)
        Me.MaterialCard1.Controls.Add(Me.TxDescripcion)
        Me.MaterialCard1.Controls.Add(Me.TxID)
        Me.MaterialCard1.Controls.Add(Me.MaterialLabel1)
        Me.MaterialCard1.Controls.Add(Me.TxNombre)
        Me.MaterialCard1.Controls.Add(Me.MaterialLabel2)
        Me.MaterialCard1.Controls.Add(Me.MaterialLabel3)
        Me.MaterialCard1.Controls.Add(Me.TxPorteros)
        Me.MaterialCard1.Depth = 0
        Me.MaterialCard1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialCard1.Location = New System.Drawing.Point(5, 6)
        Me.MaterialCard1.Margin = New System.Windows.Forms.Padding(14)
        Me.MaterialCard1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialCard1.Name = "MaterialCard1"
        Me.MaterialCard1.Padding = New System.Windows.Forms.Padding(14)
        Me.MaterialCard1.Size = New System.Drawing.Size(901, 287)
        Me.MaterialCard1.TabIndex = 6
        '
        'MaterialLabel8
        '
        Me.MaterialLabel8.AutoSize = True
        Me.MaterialLabel8.Depth = 0
        Me.MaterialLabel8.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.MaterialLabel8.FontType = MaterialSkin.MaterialSkinManager.fontType.Caption
        Me.MaterialLabel8.Location = New System.Drawing.Point(625, 28)
        Me.MaterialLabel8.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel8.Name = "MaterialLabel8"
        Me.MaterialLabel8.Size = New System.Drawing.Size(59, 14)
        Me.MaterialLabel8.TabIndex = 26
        Me.MaterialLabel8.Text = "Jugadores"
        '
        'TxJugadores
        '
        Me.TxJugadores.AllowPromptAsInput = True
        Me.TxJugadores.AnimateReadOnly = False
        Me.TxJugadores.AsciiOnly = False
        Me.TxJugadores.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.TxJugadores.BeepOnError = False
        Me.TxJugadores.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals
        Me.TxJugadores.Depth = 0
        Me.TxJugadores.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.TxJugadores.HidePromptOnLeave = False
        Me.TxJugadores.HideSelection = True
        Me.TxJugadores.InsertKeyMode = System.Windows.Forms.InsertKeyMode.[Default]
        Me.TxJugadores.LeadingIcon = Nothing
        Me.TxJugadores.Location = New System.Drawing.Point(690, 17)
        Me.TxJugadores.Mask = ""
        Me.TxJugadores.MaxLength = 32767
        Me.TxJugadores.MouseState = MaterialSkin.MouseState.OUT
        Me.TxJugadores.Name = "TxJugadores"
        Me.TxJugadores.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxJugadores.PrefixSuffixText = Nothing
        Me.TxJugadores.PromptChar = Global.Microsoft.VisualBasic.ChrW(95)
        Me.TxJugadores.ReadOnly = False
        Me.TxJugadores.RejectInputOnFirstFailure = False
        Me.TxJugadores.ResetOnPrompt = True
        Me.TxJugadores.ResetOnSpace = True
        Me.TxJugadores.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TxJugadores.SelectedText = ""
        Me.TxJugadores.SelectionLength = 0
        Me.TxJugadores.SelectionStart = 0
        Me.TxJugadores.ShortcutsEnabled = True
        Me.TxJugadores.Size = New System.Drawing.Size(71, 36)
        Me.TxJugadores.SkipLiterals = True
        Me.TxJugadores.TabIndex = 25
        Me.TxJugadores.TabStop = False
        Me.TxJugadores.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.TxJugadores.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals
        Me.TxJugadores.TrailingIcon = Nothing
        Me.TxJugadores.UseSystemPasswordChar = False
        Me.TxJugadores.UseTallSize = False
        Me.TxJugadores.ValidatingType = Nothing
        '
        'MaterialLabel6
        '
        Me.MaterialLabel6.AutoSize = True
        Me.MaterialLabel6.Depth = 0
        Me.MaterialLabel6.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.MaterialLabel6.FontType = MaterialSkin.MaterialSkinManager.fontType.Caption
        Me.MaterialLabel6.Location = New System.Drawing.Point(483, 28)
        Me.MaterialLabel6.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel6.Name = "MaterialLabel6"
        Me.MaterialLabel6.Size = New System.Drawing.Size(47, 14)
        Me.MaterialLabel6.TabIndex = 24
        Me.MaterialLabel6.Text = "Porteros"
        '
        'TxMaterial
        '
        Me.TxMaterial.AnimateReadOnly = False
        Me.TxMaterial.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.TxMaterial.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.TxMaterial.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxMaterial.Depth = 0
        Me.TxMaterial.HideSelection = True
        Me.TxMaterial.Location = New System.Drawing.Point(486, 83)
        Me.TxMaterial.MaxLength = 32767
        Me.TxMaterial.MouseState = MaterialSkin.MouseState.OUT
        Me.TxMaterial.Name = "TxMaterial"
        Me.TxMaterial.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxMaterial.ReadOnly = False
        Me.TxMaterial.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.TxMaterial.SelectedText = ""
        Me.TxMaterial.SelectionLength = 0
        Me.TxMaterial.SelectionStart = 0
        Me.TxMaterial.ShortcutsEnabled = True
        Me.TxMaterial.Size = New System.Drawing.Size(406, 100)
        Me.TxMaterial.TabIndex = 23
        Me.TxMaterial.TabStop = False
        Me.TxMaterial.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.TxMaterial.UseSystemPasswordChar = False
        '
        'MaterialLabel5
        '
        Me.MaterialLabel5.AutoSize = True
        Me.MaterialLabel5.Depth = 0
        Me.MaterialLabel5.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.MaterialLabel5.FontType = MaterialSkin.MaterialSkinManager.fontType.Caption
        Me.MaterialLabel5.Location = New System.Drawing.Point(483, 66)
        Me.MaterialLabel5.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel5.Name = "MaterialLabel5"
        Me.MaterialLabel5.Size = New System.Drawing.Size(45, 14)
        Me.MaterialLabel5.TabIndex = 22
        Me.MaterialLabel5.Text = "Material"
        '
        'TxObservaciones
        '
        Me.TxObservaciones.AnimateReadOnly = False
        Me.TxObservaciones.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.TxObservaciones.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.TxObservaciones.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxObservaciones.Depth = 0
        Me.TxObservaciones.HideSelection = True
        Me.TxObservaciones.Location = New System.Drawing.Point(22, 210)
        Me.TxObservaciones.MaxLength = 32767
        Me.TxObservaciones.MouseState = MaterialSkin.MouseState.OUT
        Me.TxObservaciones.Name = "TxObservaciones"
        Me.TxObservaciones.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxObservaciones.ReadOnly = False
        Me.TxObservaciones.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.TxObservaciones.SelectedText = ""
        Me.TxObservaciones.SelectionLength = 0
        Me.TxObservaciones.SelectionStart = 0
        Me.TxObservaciones.ShortcutsEnabled = True
        Me.TxObservaciones.Size = New System.Drawing.Size(870, 67)
        Me.TxObservaciones.TabIndex = 21
        Me.TxObservaciones.TabStop = False
        Me.TxObservaciones.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.TxObservaciones.UseSystemPasswordChar = False
        '
        'MaterialLabel4
        '
        Me.MaterialLabel4.AutoSize = True
        Me.MaterialLabel4.Depth = 0
        Me.MaterialLabel4.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.MaterialLabel4.FontType = MaterialSkin.MaterialSkinManager.fontType.Caption
        Me.MaterialLabel4.Location = New System.Drawing.Point(19, 193)
        Me.MaterialLabel4.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel4.Name = "MaterialLabel4"
        Me.MaterialLabel4.Size = New System.Drawing.Size(80, 14)
        Me.MaterialLabel4.TabIndex = 20
        Me.MaterialLabel4.Text = "Observaciones"
        '
        'TxDescripcion
        '
        Me.TxDescripcion.AnimateReadOnly = False
        Me.TxDescripcion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.TxDescripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.TxDescripcion.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxDescripcion.Depth = 0
        Me.TxDescripcion.HideSelection = True
        Me.TxDescripcion.Location = New System.Drawing.Point(22, 83)
        Me.TxDescripcion.MaxLength = 32767
        Me.TxDescripcion.MouseState = MaterialSkin.MouseState.OUT
        Me.TxDescripcion.Name = "TxDescripcion"
        Me.TxDescripcion.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxDescripcion.ReadOnly = False
        Me.TxDescripcion.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.TxDescripcion.SelectedText = ""
        Me.TxDescripcion.SelectionLength = 0
        Me.TxDescripcion.SelectionStart = 0
        Me.TxDescripcion.ShortcutsEnabled = True
        Me.TxDescripcion.Size = New System.Drawing.Size(430, 100)
        Me.TxDescripcion.TabIndex = 19
        Me.TxDescripcion.TabStop = False
        Me.TxDescripcion.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.TxDescripcion.UseSystemPasswordChar = False
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
        Me.TxNombre.Size = New System.Drawing.Size(281, 36)
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
        Me.MaterialLabel3.Location = New System.Drawing.Point(19, 66)
        Me.MaterialLabel3.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel3.Name = "MaterialLabel3"
        Me.MaterialLabel3.Size = New System.Drawing.Size(64, 14)
        Me.MaterialLabel3.TabIndex = 9
        Me.MaterialLabel3.Text = "Descripcion"
        '
        'TxPorteros
        '
        Me.TxPorteros.AllowPromptAsInput = True
        Me.TxPorteros.AnimateReadOnly = False
        Me.TxPorteros.AsciiOnly = False
        Me.TxPorteros.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.TxPorteros.BeepOnError = False
        Me.TxPorteros.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals
        Me.TxPorteros.Depth = 0
        Me.TxPorteros.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.TxPorteros.HidePromptOnLeave = False
        Me.TxPorteros.HideSelection = True
        Me.TxPorteros.InsertKeyMode = System.Windows.Forms.InsertKeyMode.[Default]
        Me.TxPorteros.LeadingIcon = Nothing
        Me.TxPorteros.Location = New System.Drawing.Point(536, 17)
        Me.TxPorteros.Mask = ""
        Me.TxPorteros.MaxLength = 32767
        Me.TxPorteros.MouseState = MaterialSkin.MouseState.OUT
        Me.TxPorteros.Name = "TxPorteros"
        Me.TxPorteros.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxPorteros.PrefixSuffixText = Nothing
        Me.TxPorteros.PromptChar = Global.Microsoft.VisualBasic.ChrW(95)
        Me.TxPorteros.ReadOnly = False
        Me.TxPorteros.RejectInputOnFirstFailure = False
        Me.TxPorteros.ResetOnPrompt = True
        Me.TxPorteros.ResetOnSpace = True
        Me.TxPorteros.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TxPorteros.SelectedText = ""
        Me.TxPorteros.SelectionLength = 0
        Me.TxPorteros.SelectionStart = 0
        Me.TxPorteros.ShortcutsEnabled = True
        Me.TxPorteros.Size = New System.Drawing.Size(71, 36)
        Me.TxPorteros.SkipLiterals = True
        Me.TxPorteros.TabIndex = 3
        Me.TxPorteros.TabStop = False
        Me.TxPorteros.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.TxPorteros.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals
        Me.TxPorteros.TrailingIcon = Nothing
        Me.TxPorteros.UseSystemPasswordChar = False
        Me.TxPorteros.UseTallSize = False
        Me.TxPorteros.ValidatingType = Nothing
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 40
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "Objetivo"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 188
        '
        'ID
        '
        Me.ID.HeaderText = "ID"
        Me.ID.Name = "ID"
        Me.ID.Width = 40
        '
        'Objetivo
        '
        Me.Objetivo.HeaderText = "Objetivo"
        Me.Objetivo.Name = "Objetivo"
        Me.Objetivo.Width = 188
        '
        'MaterialLabel7
        '
        Me.MaterialLabel7.AutoSize = True
        Me.MaterialLabel7.Depth = 0
        Me.MaterialLabel7.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.MaterialLabel7.FontType = MaterialSkin.MaterialSkinManager.fontType.Caption
        Me.MaterialLabel7.Location = New System.Drawing.Point(10, 11)
        Me.MaterialLabel7.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel7.Name = "MaterialLabel7"
        Me.MaterialLabel7.Size = New System.Drawing.Size(114, 14)
        Me.MaterialLabel7.TabIndex = 27
        Me.MaterialLabel7.Text = "Objetivos de ejercicio"
        '
        'MaterialLabel9
        '
        Me.MaterialLabel9.AutoSize = True
        Me.MaterialLabel9.Depth = 0
        Me.MaterialLabel9.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.MaterialLabel9.FontType = MaterialSkin.MaterialSkinManager.fontType.Caption
        Me.MaterialLabel9.Location = New System.Drawing.Point(9, 10)
        Me.MaterialLabel9.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel9.Name = "MaterialLabel9"
        Me.MaterialLabel9.Size = New System.Drawing.Size(51, 14)
        Me.MaterialLabel9.TabIndex = 28
        Me.MaterialLabel9.Text = "Objetivos"
        '
        'Ejercicios
        '
        Me.AllowDrop = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1335, 779)
        Me.Controls.Add(Me.Panel1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Ejercicios"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Ejercicios"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.MaterialCard4.ResumeLayout(False)
        Me.MaterialCard4.PerformLayout()
        CType(Me.DbgObjetivos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MaterialCard3.ResumeLayout(False)
        Me.MaterialCard3.PerformLayout()
        CType(Me.DbgObjetivosEjercicios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MaterialCard2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        CType(Me.PBImagenCampo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MaterialCard1.ResumeLayout(False)
        Me.MaterialCard1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents MaterialCard1 As MaterialSkin.Controls.MaterialCard
    Friend WithEvents TxID As MaterialSkin.Controls.MaterialMaskedTextBox
    Friend WithEvents MaterialLabel1 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents TxNombre As MaterialSkin.Controls.MaterialMaskedTextBox
    Friend WithEvents MaterialLabel2 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel3 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents TxPorteros As MaterialSkin.Controls.MaterialMaskedTextBox
    Friend WithEvents MaterialCard4 As MaterialSkin.Controls.MaterialCard
    Friend WithEvents MaterialCard3 As MaterialSkin.Controls.MaterialCard
    Friend WithEvents MaterialCard2 As MaterialSkin.Controls.MaterialCard
    Friend WithEvents PBImagenCampo As PictureBox
    Friend WithEvents MaterialLabel8 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents TxJugadores As MaterialSkin.Controls.MaterialMaskedTextBox
    Friend WithEvents MaterialLabel6 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents TxMaterial As MaterialSkin.Controls.MaterialMultiLineTextBox2
    Friend WithEvents MaterialLabel5 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents TxObservaciones As MaterialSkin.Controls.MaterialMultiLineTextBox2
    Friend WithEvents MaterialLabel4 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents TxDescripcion As MaterialSkin.Controls.MaterialMultiLineTextBox2
    Friend WithEvents BtnPersona As MaterialSkin.Controls.MaterialButton
    Friend WithEvents BtnExportarImagen As MaterialSkin.Controls.MaterialButton
    Friend WithEvents BtnCono As MaterialSkin.Controls.MaterialButton
    Friend WithEvents BtnNuevoObjetivo As MaterialSkin.Controls.MaterialButton
    Friend WithEvents TxNombreNuvObjetivo As MaterialSkin.Controls.MaterialMaskedTextBox
    Friend WithEvents DbgObjetivos As DataGridView
    Friend WithEvents DbgObjetivosEjercicios As DataGridView
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Vaciarimagen As MaterialSkin.Controls.MaterialButton
    Friend WithEvents BtnImportarImagen As MaterialSkin.Controls.MaterialButton
    Friend WithEvents BtnLineaPunteada As MaterialSkin.Controls.MaterialButton
    Friend WithEvents BtnLineaNomal As MaterialSkin.Controls.MaterialButton
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents ID As DataGridViewTextBoxColumn
    Friend WithEvents Objetivo As DataGridViewTextBoxColumn
    Friend WithEvents MaterialLabel9 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel7 As MaterialSkin.Controls.MaterialLabel
End Class
