<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainFrm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainFrm))
        Me.lblGameName = New System.Windows.Forms.Label()
        Me.lblCharacterName = New System.Windows.Forms.Label()
        Me.cbxGameTitle = New System.Windows.Forms.ComboBox()
        Me.cbxCharName = New System.Windows.Forms.ComboBox()
        Me.gbxCharacter1 = New System.Windows.Forms.GroupBox()
        Me.pbxSuper_1 = New System.Windows.Forms.PictureBox()
        Me.pbxHK_1 = New System.Windows.Forms.PictureBox()
        Me.pbxLK_1 = New System.Windows.Forms.PictureBox()
        Me.pbxHP_1 = New System.Windows.Forms.PictureBox()
        Me.pbxLP_1 = New System.Windows.Forms.PictureBox()
        Me.lblCharNotes1 = New System.Windows.Forms.Label()
        Me.btnNotes1 = New System.Windows.Forms.Button()
        Me.rtbNotes1 = New System.Windows.Forms.RichTextBox()
        Me.lblCharName1 = New System.Windows.Forms.Label()
        Me.lblSuper_Dmg1 = New System.Windows.Forms.Label()
        Me.lblHK_Dmg1 = New System.Windows.Forms.Label()
        Me.lblLK_Dmg1 = New System.Windows.Forms.Label()
        Me.lblHP_Dmg1 = New System.Windows.Forms.Label()
        Me.lblLP_Dmg1 = New System.Windows.Forms.Label()
        Me.lblSuper1 = New System.Windows.Forms.Label()
        Me.lblHK1 = New System.Windows.Forms.Label()
        Me.lblLK1 = New System.Windows.Forms.Label()
        Me.lblHP1 = New System.Windows.Forms.Label()
        Me.lblLP1 = New System.Windows.Forms.Label()
        Me.lblChar1 = New System.Windows.Forms.Label()
        Me.pbxGameImage = New System.Windows.Forms.PictureBox()
        Me.lstCharacters = New System.Windows.Forms.ListBox()
        Me.gbxCharacter2 = New System.Windows.Forms.GroupBox()
        Me.pbxSuper_2 = New System.Windows.Forms.PictureBox()
        Me.lblCharNotes2 = New System.Windows.Forms.Label()
        Me.pbxHK_2 = New System.Windows.Forms.PictureBox()
        Me.rtbNotes2 = New System.Windows.Forms.RichTextBox()
        Me.pbxLK_2 = New System.Windows.Forms.PictureBox()
        Me.btnNotes2 = New System.Windows.Forms.Button()
        Me.pbxHP_2 = New System.Windows.Forms.PictureBox()
        Me.lblCharName2 = New System.Windows.Forms.Label()
        Me.pbxLP_2 = New System.Windows.Forms.PictureBox()
        Me.lblSuper_Dmg2 = New System.Windows.Forms.Label()
        Me.lblChar2 = New System.Windows.Forms.Label()
        Me.lblHK_Dmg2 = New System.Windows.Forms.Label()
        Me.lblLP2 = New System.Windows.Forms.Label()
        Me.lblLK_Dmg2 = New System.Windows.Forms.Label()
        Me.lblHP2 = New System.Windows.Forms.Label()
        Me.lblHP_Dmg2 = New System.Windows.Forms.Label()
        Me.lblLK2 = New System.Windows.Forms.Label()
        Me.lblLP_Dmg2 = New System.Windows.Forms.Label()
        Me.lblHK2 = New System.Windows.Forms.Label()
        Me.lblSuper2 = New System.Windows.Forms.Label()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnAddChar2 = New System.Windows.Forms.Button()
        Me.btnAddChar1 = New System.Windows.Forms.Button()
        Me.btnClearList = New System.Windows.Forms.Button()
        Me.gbxCharacter1.SuspendLayout()
        CType(Me.pbxSuper_1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxHK_1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxLK_1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxHP_1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxLP_1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxGameImage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbxCharacter2.SuspendLayout()
        CType(Me.pbxSuper_2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxHK_2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxLK_2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxHP_2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxLP_2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblGameName
        '
        Me.lblGameName.AutoSize = True
        Me.lblGameName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGameName.Location = New System.Drawing.Point(12, 13)
        Me.lblGameName.Name = "lblGameName"
        Me.lblGameName.Size = New System.Drawing.Size(77, 16)
        Me.lblGameName.TabIndex = 0
        Me.lblGameName.Text = "Game Title:"
        '
        'lblCharacterName
        '
        Me.lblCharacterName.AutoSize = True
        Me.lblCharacterName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCharacterName.Location = New System.Drawing.Point(12, 56)
        Me.lblCharacterName.Name = "lblCharacterName"
        Me.lblCharacterName.Size = New System.Drawing.Size(109, 16)
        Me.lblCharacterName.TabIndex = 1
        Me.lblCharacterName.Text = "Character Name:"
        '
        'cbxGameTitle
        '
        Me.cbxGameTitle.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.cbxGameTitle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxGameTitle.FormattingEnabled = True
        Me.cbxGameTitle.Items.AddRange(New Object() {"Ultra Street Fighter 4"})
        Me.cbxGameTitle.Location = New System.Drawing.Point(95, 12)
        Me.cbxGameTitle.Name = "cbxGameTitle"
        Me.cbxGameTitle.Size = New System.Drawing.Size(153, 21)
        Me.cbxGameTitle.TabIndex = 2
        '
        'cbxCharName
        '
        Me.cbxCharName.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.cbxCharName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxCharName.FormattingEnabled = True
        Me.cbxCharName.Location = New System.Drawing.Point(127, 55)
        Me.cbxCharName.Name = "cbxCharName"
        Me.cbxCharName.Size = New System.Drawing.Size(121, 21)
        Me.cbxCharName.TabIndex = 3
        '
        'gbxCharacter1
        '
        Me.gbxCharacter1.BackColor = System.Drawing.SystemColors.ControlDark
        Me.gbxCharacter1.Controls.Add(Me.pbxSuper_1)
        Me.gbxCharacter1.Controls.Add(Me.pbxHK_1)
        Me.gbxCharacter1.Controls.Add(Me.pbxLK_1)
        Me.gbxCharacter1.Controls.Add(Me.pbxHP_1)
        Me.gbxCharacter1.Controls.Add(Me.pbxLP_1)
        Me.gbxCharacter1.Controls.Add(Me.lblCharNotes1)
        Me.gbxCharacter1.Controls.Add(Me.btnNotes1)
        Me.gbxCharacter1.Controls.Add(Me.rtbNotes1)
        Me.gbxCharacter1.Controls.Add(Me.lblCharName1)
        Me.gbxCharacter1.Controls.Add(Me.lblSuper_Dmg1)
        Me.gbxCharacter1.Controls.Add(Me.lblHK_Dmg1)
        Me.gbxCharacter1.Controls.Add(Me.lblLK_Dmg1)
        Me.gbxCharacter1.Controls.Add(Me.lblHP_Dmg1)
        Me.gbxCharacter1.Controls.Add(Me.lblLP_Dmg1)
        Me.gbxCharacter1.Controls.Add(Me.lblSuper1)
        Me.gbxCharacter1.Controls.Add(Me.lblHK1)
        Me.gbxCharacter1.Controls.Add(Me.lblLK1)
        Me.gbxCharacter1.Controls.Add(Me.lblHP1)
        Me.gbxCharacter1.Controls.Add(Me.lblLP1)
        Me.gbxCharacter1.Controls.Add(Me.lblChar1)
        Me.gbxCharacter1.Location = New System.Drawing.Point(254, 8)
        Me.gbxCharacter1.Name = "gbxCharacter1"
        Me.gbxCharacter1.Size = New System.Drawing.Size(296, 240)
        Me.gbxCharacter1.TabIndex = 4
        Me.gbxCharacter1.TabStop = False
        Me.gbxCharacter1.Text = "Character 1:"
        '
        'pbxSuper_1
        '
        Me.pbxSuper_1.Image = CType(resources.GetObject("pbxSuper_1.Image"), System.Drawing.Image)
        Me.pbxSuper_1.Location = New System.Drawing.Point(16, 194)
        Me.pbxSuper_1.Name = "pbxSuper_1"
        Me.pbxSuper_1.Size = New System.Drawing.Size(64, 28)
        Me.pbxSuper_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.pbxSuper_1.TabIndex = 23
        Me.pbxSuper_1.TabStop = False
        '
        'pbxHK_1
        '
        Me.pbxHK_1.Image = CType(resources.GetObject("pbxHK_1.Image"), System.Drawing.Image)
        Me.pbxHK_1.Location = New System.Drawing.Point(16, 160)
        Me.pbxHK_1.Name = "pbxHK_1"
        Me.pbxHK_1.Size = New System.Drawing.Size(28, 28)
        Me.pbxHK_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.pbxHK_1.TabIndex = 22
        Me.pbxHK_1.TabStop = False
        '
        'pbxLK_1
        '
        Me.pbxLK_1.Image = CType(resources.GetObject("pbxLK_1.Image"), System.Drawing.Image)
        Me.pbxLK_1.Location = New System.Drawing.Point(16, 126)
        Me.pbxLK_1.Name = "pbxLK_1"
        Me.pbxLK_1.Size = New System.Drawing.Size(28, 28)
        Me.pbxLK_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.pbxLK_1.TabIndex = 21
        Me.pbxLK_1.TabStop = False
        '
        'pbxHP_1
        '
        Me.pbxHP_1.Image = CType(resources.GetObject("pbxHP_1.Image"), System.Drawing.Image)
        Me.pbxHP_1.Location = New System.Drawing.Point(16, 92)
        Me.pbxHP_1.Name = "pbxHP_1"
        Me.pbxHP_1.Size = New System.Drawing.Size(28, 28)
        Me.pbxHP_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.pbxHP_1.TabIndex = 20
        Me.pbxHP_1.TabStop = False
        '
        'pbxLP_1
        '
        Me.pbxLP_1.Image = CType(resources.GetObject("pbxLP_1.Image"), System.Drawing.Image)
        Me.pbxLP_1.Location = New System.Drawing.Point(16, 57)
        Me.pbxLP_1.Name = "pbxLP_1"
        Me.pbxLP_1.Size = New System.Drawing.Size(28, 29)
        Me.pbxLP_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.pbxLP_1.TabIndex = 19
        Me.pbxLP_1.TabStop = False
        '
        'lblCharNotes1
        '
        Me.lblCharNotes1.AutoSize = True
        Me.lblCharNotes1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCharNotes1.Location = New System.Drawing.Point(192, 51)
        Me.lblCharNotes1.Name = "lblCharNotes1"
        Me.lblCharNotes1.Size = New System.Drawing.Size(98, 15)
        Me.lblCharNotes1.TabIndex = 18
        Me.lblCharNotes1.Text = "Character Notes:"
        '
        'btnNotes1
        '
        Me.btnNotes1.Location = New System.Drawing.Point(190, 160)
        Me.btnNotes1.Name = "btnNotes1"
        Me.btnNotes1.Size = New System.Drawing.Size(100, 23)
        Me.btnNotes1.TabIndex = 15
        Me.btnNotes1.Text = "Update Notes"
        Me.btnNotes1.UseVisualStyleBackColor = True
        '
        'rtbNotes1
        '
        Me.rtbNotes1.Location = New System.Drawing.Point(190, 69)
        Me.rtbNotes1.MaxLength = 150
        Me.rtbNotes1.Name = "rtbNotes1"
        Me.rtbNotes1.Size = New System.Drawing.Size(100, 85)
        Me.rtbNotes1.TabIndex = 14
        Me.rtbNotes1.Text = ""
        '
        'lblCharName1
        '
        Me.lblCharName1.AutoSize = True
        Me.lblCharName1.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCharName1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblCharName1.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.lblCharName1.Location = New System.Drawing.Point(50, 22)
        Me.lblCharName1.Name = "lblCharName1"
        Me.lblCharName1.Size = New System.Drawing.Size(19, 25)
        Me.lblCharName1.TabIndex = 12
        Me.lblCharName1.Text = "*"
        '
        'lblSuper_Dmg1
        '
        Me.lblSuper_Dmg1.AutoSize = True
        Me.lblSuper_Dmg1.Location = New System.Drawing.Point(137, 201)
        Me.lblSuper_Dmg1.Name = "lblSuper_Dmg1"
        Me.lblSuper_Dmg1.Size = New System.Drawing.Size(11, 13)
        Me.lblSuper_Dmg1.TabIndex = 11
        Me.lblSuper_Dmg1.Text = "*"
        '
        'lblHK_Dmg1
        '
        Me.lblHK_Dmg1.AutoSize = True
        Me.lblHK_Dmg1.Location = New System.Drawing.Point(101, 166)
        Me.lblHK_Dmg1.Name = "lblHK_Dmg1"
        Me.lblHK_Dmg1.Size = New System.Drawing.Size(11, 13)
        Me.lblHK_Dmg1.TabIndex = 10
        Me.lblHK_Dmg1.Text = "*"
        '
        'lblLK_Dmg1
        '
        Me.lblLK_Dmg1.AutoSize = True
        Me.lblLK_Dmg1.Location = New System.Drawing.Point(101, 132)
        Me.lblLK_Dmg1.Name = "lblLK_Dmg1"
        Me.lblLK_Dmg1.Size = New System.Drawing.Size(11, 13)
        Me.lblLK_Dmg1.TabIndex = 9
        Me.lblLK_Dmg1.Text = "*"
        '
        'lblHP_Dmg1
        '
        Me.lblHP_Dmg1.AutoSize = True
        Me.lblHP_Dmg1.Location = New System.Drawing.Point(101, 97)
        Me.lblHP_Dmg1.Name = "lblHP_Dmg1"
        Me.lblHP_Dmg1.Size = New System.Drawing.Size(11, 13)
        Me.lblHP_Dmg1.TabIndex = 8
        Me.lblHP_Dmg1.Text = "*"
        '
        'lblLP_Dmg1
        '
        Me.lblLP_Dmg1.AutoSize = True
        Me.lblLP_Dmg1.Location = New System.Drawing.Point(101, 65)
        Me.lblLP_Dmg1.Name = "lblLP_Dmg1"
        Me.lblLP_Dmg1.Size = New System.Drawing.Size(11, 13)
        Me.lblLP_Dmg1.TabIndex = 7
        Me.lblLP_Dmg1.Text = "*"
        '
        'lblSuper1
        '
        Me.lblSuper1.AutoSize = True
        Me.lblSuper1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSuper1.Location = New System.Drawing.Point(81, 201)
        Me.lblSuper1.Name = "lblSuper1"
        Me.lblSuper1.Size = New System.Drawing.Size(57, 13)
        Me.lblSuper1.TabIndex = 6
        Me.lblSuper1.Text = "Damage:"
        '
        'lblHK1
        '
        Me.lblHK1.AutoSize = True
        Me.lblHK1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHK1.Location = New System.Drawing.Point(45, 166)
        Me.lblHK1.Name = "lblHK1"
        Me.lblHK1.Size = New System.Drawing.Size(57, 13)
        Me.lblHK1.TabIndex = 5
        Me.lblHK1.Text = "Damage:"
        '
        'lblLK1
        '
        Me.lblLK1.AutoSize = True
        Me.lblLK1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLK1.Location = New System.Drawing.Point(45, 132)
        Me.lblLK1.Name = "lblLK1"
        Me.lblLK1.Size = New System.Drawing.Size(57, 13)
        Me.lblLK1.TabIndex = 4
        Me.lblLK1.Text = "Damage:"
        '
        'lblHP1
        '
        Me.lblHP1.AutoSize = True
        Me.lblHP1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHP1.Location = New System.Drawing.Point(44, 97)
        Me.lblHP1.Name = "lblHP1"
        Me.lblHP1.Size = New System.Drawing.Size(57, 13)
        Me.lblHP1.TabIndex = 3
        Me.lblHP1.Text = "Damage:"
        '
        'lblLP1
        '
        Me.lblLP1.AutoSize = True
        Me.lblLP1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLP1.Location = New System.Drawing.Point(44, 65)
        Me.lblLP1.Name = "lblLP1"
        Me.lblLP1.Size = New System.Drawing.Size(57, 13)
        Me.lblLP1.TabIndex = 2
        Me.lblLP1.Text = "Damage:"
        '
        'lblChar1
        '
        Me.lblChar1.AutoSize = True
        Me.lblChar1.Location = New System.Drawing.Point(6, 31)
        Me.lblChar1.Name = "lblChar1"
        Me.lblChar1.Size = New System.Drawing.Size(38, 13)
        Me.lblChar1.TabIndex = 1
        Me.lblChar1.Text = "Name:"
        '
        'pbxGameImage
        '
        Me.pbxGameImage.BackColor = System.Drawing.SystemColors.ControlDark
        Me.pbxGameImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.pbxGameImage.Location = New System.Drawing.Point(15, 100)
        Me.pbxGameImage.Name = "pbxGameImage"
        Me.pbxGameImage.Size = New System.Drawing.Size(233, 146)
        Me.pbxGameImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.pbxGameImage.TabIndex = 6
        Me.pbxGameImage.TabStop = False
        '
        'lstCharacters
        '
        Me.lstCharacters.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.lstCharacters.FormattingEnabled = True
        Me.lstCharacters.Location = New System.Drawing.Point(12, 266)
        Me.lstCharacters.Name = "lstCharacters"
        Me.lstCharacters.Size = New System.Drawing.Size(130, 225)
        Me.lstCharacters.TabIndex = 8
        '
        'gbxCharacter2
        '
        Me.gbxCharacter2.BackColor = System.Drawing.SystemColors.ControlDark
        Me.gbxCharacter2.Controls.Add(Me.pbxSuper_2)
        Me.gbxCharacter2.Controls.Add(Me.lblCharNotes2)
        Me.gbxCharacter2.Controls.Add(Me.pbxHK_2)
        Me.gbxCharacter2.Controls.Add(Me.rtbNotes2)
        Me.gbxCharacter2.Controls.Add(Me.pbxLK_2)
        Me.gbxCharacter2.Controls.Add(Me.btnNotes2)
        Me.gbxCharacter2.Controls.Add(Me.pbxHP_2)
        Me.gbxCharacter2.Controls.Add(Me.lblCharName2)
        Me.gbxCharacter2.Controls.Add(Me.pbxLP_2)
        Me.gbxCharacter2.Controls.Add(Me.lblSuper_Dmg2)
        Me.gbxCharacter2.Controls.Add(Me.lblChar2)
        Me.gbxCharacter2.Controls.Add(Me.lblHK_Dmg2)
        Me.gbxCharacter2.Controls.Add(Me.lblLP2)
        Me.gbxCharacter2.Controls.Add(Me.lblLK_Dmg2)
        Me.gbxCharacter2.Controls.Add(Me.lblHP2)
        Me.gbxCharacter2.Controls.Add(Me.lblHP_Dmg2)
        Me.gbxCharacter2.Controls.Add(Me.lblLK2)
        Me.gbxCharacter2.Controls.Add(Me.lblLP_Dmg2)
        Me.gbxCharacter2.Controls.Add(Me.lblHK2)
        Me.gbxCharacter2.Controls.Add(Me.lblSuper2)
        Me.gbxCharacter2.Location = New System.Drawing.Point(254, 254)
        Me.gbxCharacter2.Name = "gbxCharacter2"
        Me.gbxCharacter2.Size = New System.Drawing.Size(296, 239)
        Me.gbxCharacter2.TabIndex = 15
        Me.gbxCharacter2.TabStop = False
        Me.gbxCharacter2.Text = "Character 2:"
        '
        'pbxSuper_2
        '
        Me.pbxSuper_2.Image = CType(resources.GetObject("pbxSuper_2.Image"), System.Drawing.Image)
        Me.pbxSuper_2.Location = New System.Drawing.Point(16, 193)
        Me.pbxSuper_2.Name = "pbxSuper_2"
        Me.pbxSuper_2.Size = New System.Drawing.Size(64, 28)
        Me.pbxSuper_2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.pbxSuper_2.TabIndex = 38
        Me.pbxSuper_2.TabStop = False
        '
        'lblCharNotes2
        '
        Me.lblCharNotes2.AutoSize = True
        Me.lblCharNotes2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCharNotes2.Location = New System.Drawing.Point(192, 51)
        Me.lblCharNotes2.Name = "lblCharNotes2"
        Me.lblCharNotes2.Size = New System.Drawing.Size(98, 15)
        Me.lblCharNotes2.TabIndex = 17
        Me.lblCharNotes2.Text = "Character Notes:"
        '
        'pbxHK_2
        '
        Me.pbxHK_2.Image = CType(resources.GetObject("pbxHK_2.Image"), System.Drawing.Image)
        Me.pbxHK_2.Location = New System.Drawing.Point(16, 159)
        Me.pbxHK_2.Name = "pbxHK_2"
        Me.pbxHK_2.Size = New System.Drawing.Size(28, 28)
        Me.pbxHK_2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.pbxHK_2.TabIndex = 37
        Me.pbxHK_2.TabStop = False
        '
        'rtbNotes2
        '
        Me.rtbNotes2.Location = New System.Drawing.Point(190, 69)
        Me.rtbNotes2.MaxLength = 150
        Me.rtbNotes2.Name = "rtbNotes2"
        Me.rtbNotes2.Size = New System.Drawing.Size(100, 85)
        Me.rtbNotes2.TabIndex = 16
        Me.rtbNotes2.Text = ""
        '
        'pbxLK_2
        '
        Me.pbxLK_2.Image = CType(resources.GetObject("pbxLK_2.Image"), System.Drawing.Image)
        Me.pbxLK_2.Location = New System.Drawing.Point(16, 125)
        Me.pbxLK_2.Name = "pbxLK_2"
        Me.pbxLK_2.Size = New System.Drawing.Size(28, 28)
        Me.pbxLK_2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.pbxLK_2.TabIndex = 36
        Me.pbxLK_2.TabStop = False
        '
        'btnNotes2
        '
        Me.btnNotes2.Location = New System.Drawing.Point(190, 160)
        Me.btnNotes2.Name = "btnNotes2"
        Me.btnNotes2.Size = New System.Drawing.Size(100, 23)
        Me.btnNotes2.TabIndex = 16
        Me.btnNotes2.Text = "Update Notes"
        Me.btnNotes2.UseVisualStyleBackColor = True
        '
        'pbxHP_2
        '
        Me.pbxHP_2.Image = CType(resources.GetObject("pbxHP_2.Image"), System.Drawing.Image)
        Me.pbxHP_2.Location = New System.Drawing.Point(16, 91)
        Me.pbxHP_2.Name = "pbxHP_2"
        Me.pbxHP_2.Size = New System.Drawing.Size(28, 28)
        Me.pbxHP_2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.pbxHP_2.TabIndex = 35
        Me.pbxHP_2.TabStop = False
        '
        'lblCharName2
        '
        Me.lblCharName2.AutoSize = True
        Me.lblCharName2.BackColor = System.Drawing.Color.Transparent
        Me.lblCharName2.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCharName2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblCharName2.Location = New System.Drawing.Point(50, 22)
        Me.lblCharName2.Name = "lblCharName2"
        Me.lblCharName2.Size = New System.Drawing.Size(19, 25)
        Me.lblCharName2.TabIndex = 12
        Me.lblCharName2.Text = "*"
        '
        'pbxLP_2
        '
        Me.pbxLP_2.Image = CType(resources.GetObject("pbxLP_2.Image"), System.Drawing.Image)
        Me.pbxLP_2.Location = New System.Drawing.Point(16, 56)
        Me.pbxLP_2.Name = "pbxLP_2"
        Me.pbxLP_2.Size = New System.Drawing.Size(28, 29)
        Me.pbxLP_2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.pbxLP_2.TabIndex = 34
        Me.pbxLP_2.TabStop = False
        '
        'lblSuper_Dmg2
        '
        Me.lblSuper_Dmg2.AutoSize = True
        Me.lblSuper_Dmg2.Location = New System.Drawing.Point(137, 200)
        Me.lblSuper_Dmg2.Name = "lblSuper_Dmg2"
        Me.lblSuper_Dmg2.Size = New System.Drawing.Size(11, 13)
        Me.lblSuper_Dmg2.TabIndex = 33
        Me.lblSuper_Dmg2.Text = "*"
        '
        'lblChar2
        '
        Me.lblChar2.AutoSize = True
        Me.lblChar2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblChar2.Location = New System.Drawing.Point(6, 31)
        Me.lblChar2.Name = "lblChar2"
        Me.lblChar2.Size = New System.Drawing.Size(43, 13)
        Me.lblChar2.TabIndex = 1
        Me.lblChar2.Text = "Name:"
        '
        'lblHK_Dmg2
        '
        Me.lblHK_Dmg2.AutoSize = True
        Me.lblHK_Dmg2.Location = New System.Drawing.Point(101, 165)
        Me.lblHK_Dmg2.Name = "lblHK_Dmg2"
        Me.lblHK_Dmg2.Size = New System.Drawing.Size(11, 13)
        Me.lblHK_Dmg2.TabIndex = 32
        Me.lblHK_Dmg2.Text = "*"
        '
        'lblLP2
        '
        Me.lblLP2.AutoSize = True
        Me.lblLP2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLP2.Location = New System.Drawing.Point(44, 64)
        Me.lblLP2.Name = "lblLP2"
        Me.lblLP2.Size = New System.Drawing.Size(57, 13)
        Me.lblLP2.TabIndex = 24
        Me.lblLP2.Text = "Damage:"
        '
        'lblLK_Dmg2
        '
        Me.lblLK_Dmg2.AutoSize = True
        Me.lblLK_Dmg2.Location = New System.Drawing.Point(101, 131)
        Me.lblLK_Dmg2.Name = "lblLK_Dmg2"
        Me.lblLK_Dmg2.Size = New System.Drawing.Size(11, 13)
        Me.lblLK_Dmg2.TabIndex = 31
        Me.lblLK_Dmg2.Text = "*"
        '
        'lblHP2
        '
        Me.lblHP2.AutoSize = True
        Me.lblHP2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHP2.Location = New System.Drawing.Point(44, 96)
        Me.lblHP2.Name = "lblHP2"
        Me.lblHP2.Size = New System.Drawing.Size(57, 13)
        Me.lblHP2.TabIndex = 25
        Me.lblHP2.Text = "Damage:"
        '
        'lblHP_Dmg2
        '
        Me.lblHP_Dmg2.AutoSize = True
        Me.lblHP_Dmg2.Location = New System.Drawing.Point(101, 96)
        Me.lblHP_Dmg2.Name = "lblHP_Dmg2"
        Me.lblHP_Dmg2.Size = New System.Drawing.Size(11, 13)
        Me.lblHP_Dmg2.TabIndex = 30
        Me.lblHP_Dmg2.Text = "*"
        '
        'lblLK2
        '
        Me.lblLK2.AutoSize = True
        Me.lblLK2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLK2.Location = New System.Drawing.Point(45, 131)
        Me.lblLK2.Name = "lblLK2"
        Me.lblLK2.Size = New System.Drawing.Size(57, 13)
        Me.lblLK2.TabIndex = 26
        Me.lblLK2.Text = "Damage:"
        '
        'lblLP_Dmg2
        '
        Me.lblLP_Dmg2.AutoSize = True
        Me.lblLP_Dmg2.Location = New System.Drawing.Point(101, 64)
        Me.lblLP_Dmg2.Name = "lblLP_Dmg2"
        Me.lblLP_Dmg2.Size = New System.Drawing.Size(11, 13)
        Me.lblLP_Dmg2.TabIndex = 29
        Me.lblLP_Dmg2.Text = "*"
        '
        'lblHK2
        '
        Me.lblHK2.AutoSize = True
        Me.lblHK2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHK2.Location = New System.Drawing.Point(45, 165)
        Me.lblHK2.Name = "lblHK2"
        Me.lblHK2.Size = New System.Drawing.Size(57, 13)
        Me.lblHK2.TabIndex = 27
        Me.lblHK2.Text = "Damage:"
        '
        'lblSuper2
        '
        Me.lblSuper2.AutoSize = True
        Me.lblSuper2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSuper2.Location = New System.Drawing.Point(81, 200)
        Me.lblSuper2.Name = "lblSuper2"
        Me.lblSuper2.Size = New System.Drawing.Size(57, 13)
        Me.lblSuper2.TabIndex = 28
        Me.lblSuper2.Text = "Damage:"
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnClear.Location = New System.Drawing.Point(151, 382)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(97, 52)
        Me.btnClear.TabIndex = 16
        Me.btnClear.Text = "Clear Character 1 and 2"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'btnAddChar2
        '
        Me.btnAddChar2.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnAddChar2.Location = New System.Drawing.Point(151, 323)
        Me.btnAddChar2.Name = "btnAddChar2"
        Me.btnAddChar2.Size = New System.Drawing.Size(97, 53)
        Me.btnAddChar2.TabIndex = 18
        Me.btnAddChar2.Text = "Add to Character 2"
        Me.btnAddChar2.UseVisualStyleBackColor = False
        '
        'btnAddChar1
        '
        Me.btnAddChar1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnAddChar1.Location = New System.Drawing.Point(151, 265)
        Me.btnAddChar1.Name = "btnAddChar1"
        Me.btnAddChar1.Size = New System.Drawing.Size(97, 52)
        Me.btnAddChar1.TabIndex = 19
        Me.btnAddChar1.Text = "Add to Character 1"
        Me.btnAddChar1.UseVisualStyleBackColor = False
        '
        'btnClearList
        '
        Me.btnClearList.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnClearList.Location = New System.Drawing.Point(151, 440)
        Me.btnClearList.Name = "btnClearList"
        Me.btnClearList.Size = New System.Drawing.Size(97, 52)
        Me.btnClearList.TabIndex = 20
        Me.btnClearList.Text = "Clear Character List"
        Me.btnClearList.UseVisualStyleBackColor = False
        '
        'MainFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDark
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(560, 506)
        Me.Controls.Add(Me.btnClearList)
        Me.Controls.Add(Me.btnAddChar1)
        Me.Controls.Add(Me.btnAddChar2)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.gbxCharacter2)
        Me.Controls.Add(Me.lstCharacters)
        Me.Controls.Add(Me.pbxGameImage)
        Me.Controls.Add(Me.gbxCharacter1)
        Me.Controls.Add(Me.cbxCharName)
        Me.Controls.Add(Me.cbxGameTitle)
        Me.Controls.Add(Me.lblCharacterName)
        Me.Controls.Add(Me.lblGameName)
        Me.Name = "MainFrm"
        Me.Text = "Fighting Game Analyzer "
        Me.gbxCharacter1.ResumeLayout(False)
        Me.gbxCharacter1.PerformLayout()
        CType(Me.pbxSuper_1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxHK_1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxLK_1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxHP_1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxLP_1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxGameImage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbxCharacter2.ResumeLayout(False)
        Me.gbxCharacter2.PerformLayout()
        CType(Me.pbxSuper_2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxHK_2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxLK_2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxHP_2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxLP_2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblGameName As Label
    Friend WithEvents lblCharacterName As Label
    Friend WithEvents cbxGameTitle As ComboBox
    Friend WithEvents cbxCharName As ComboBox
    Friend WithEvents gbxCharacter1 As GroupBox
    Friend WithEvents pbxGameImage As PictureBox
    Friend WithEvents lstCharacters As ListBox
    Friend WithEvents lblSuper_Dmg1 As Label
    Friend WithEvents lblHK_Dmg1 As Label
    Friend WithEvents lblLK_Dmg1 As Label
    Friend WithEvents lblHP_Dmg1 As Label
    Friend WithEvents lblLP_Dmg1 As Label
    Friend WithEvents lblSuper1 As Label
    Friend WithEvents lblHK1 As Label
    Friend WithEvents lblLK1 As Label
    Friend WithEvents lblHP1 As Label
    Friend WithEvents lblLP1 As Label
    Friend WithEvents lblChar1 As Label
    Friend WithEvents lblCharName1 As Label
    Friend WithEvents gbxCharacter2 As GroupBox
    Friend WithEvents lblCharName2 As Label
    Friend WithEvents lblChar2 As Label
    Friend WithEvents btnClear As Button
    Friend WithEvents btnAddChar2 As Button
    Friend WithEvents btnAddChar1 As Button
    Friend WithEvents rtbNotes1 As RichTextBox
    Friend WithEvents btnNotes1 As Button
    Friend WithEvents btnNotes2 As Button
    Friend WithEvents rtbNotes2 As RichTextBox
    Friend WithEvents lblCharNotes1 As Label
    Friend WithEvents lblCharNotes2 As Label
    Friend WithEvents pbxLP_1 As PictureBox
    Friend WithEvents pbxHP_1 As PictureBox
    Friend WithEvents pbxSuper_1 As PictureBox
    Friend WithEvents pbxHK_1 As PictureBox
    Friend WithEvents pbxLK_1 As PictureBox
    Friend WithEvents pbxSuper_2 As PictureBox
    Friend WithEvents pbxHK_2 As PictureBox
    Friend WithEvents pbxLK_2 As PictureBox
    Friend WithEvents pbxHP_2 As PictureBox
    Friend WithEvents pbxLP_2 As PictureBox
    Friend WithEvents lblSuper_Dmg2 As Label
    Friend WithEvents lblHK_Dmg2 As Label
    Friend WithEvents lblLP2 As Label
    Friend WithEvents lblLK_Dmg2 As Label
    Friend WithEvents lblHP2 As Label
    Friend WithEvents lblHP_Dmg2 As Label
    Friend WithEvents lblLK2 As Label
    Friend WithEvents lblLP_Dmg2 As Label
    Friend WithEvents lblHK2 As Label
    Friend WithEvents lblSuper2 As Label
    Friend WithEvents btnClearList As Button
End Class
