<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Options
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
		Me.components = New System.ComponentModel.Container()
		Dim TreeNode1 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Startup")
		Dim TreeNode2 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Locations")
		Dim TreeNode3 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("File Types")
		Dim TreeNode4 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Fonts")
		Dim TreeNode5 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Application ", New System.Windows.Forms.TreeNode() {TreeNode1, TreeNode2, TreeNode3, TreeNode4})
		Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Options))
		Me.trvOptions = New System.Windows.Forms.TreeView()
		Me.btnOk = New System.Windows.Forms.Button()
		Me.btnCancel = New System.Windows.Forms.Button()
		Me.pnlFonts = New System.Windows.Forms.Panel()
		Me.GroupBox2 = New System.Windows.Forms.GroupBox()
		Me.Label9 = New System.Windows.Forms.Label()
		Me.Label8 = New System.Windows.Forms.Label()
		Me.Label6 = New System.Windows.Forms.Label()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.Label5 = New System.Windows.Forms.Label()
		Me.Label7 = New System.Windows.Forms.Label()
		Me.GroupBox3 = New System.Windows.Forms.GroupBox()
		Me.dgvHighLightWord = New System.Windows.Forms.DataGridView()
		Me.colHighLightWord = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.colColor = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.colFontStyle = New System.Windows.Forms.DataGridViewComboBoxColumn()
		Me.pnlStartup = New System.Windows.Forms.Panel()
		Me.lblAddMoreFiles = New System.Windows.Forms.LinkLabel()
		Me.dgvOpenFiles = New System.Windows.Forms.DataGridView()
		Me.colOpen = New System.Windows.Forms.DataGridViewCheckBoxColumn()
		Me.colFilePath = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.GroupBox1 = New System.Windows.Forms.GroupBox()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.pnlLocations = New System.Windows.Forms.Panel()
		Me.btnDefaultSavedCopy = New System.Windows.Forms.Button()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.dgvFileTypes = New System.Windows.Forms.DataGridView()
		Me.colFileType = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.pnlFileTypes = New System.Windows.Forms.Panel()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
		Me.Label2 = New System.Windows.Forms.Label()
		Me.btnRestoreDefaults = New System.Windows.Forms.Button()
		Me.chkLockFont = New System.Windows.Forms.CheckBox()
		Me.pnlLineBackColor = New System.Windows.Forms.Panel()
		Me.chkLockSize = New System.Windows.Forms.CheckBox()
		Me.pnlTextBackColor = New System.Windows.Forms.Panel()
		Me.cboLineNumberFontSize = New System.Windows.Forms.ComboBox()
		Me.cboTextFontSize = New System.Windows.Forms.ComboBox()
		Me.pnlLineNumberFontColor = New System.Windows.Forms.Panel()
		Me.lblTextFont = New System.Windows.Forms.Label()
		Me.pnlTextFontColor = New System.Windows.Forms.Panel()
		Me.lblLineNumberFont = New System.Windows.Forms.Label()
		Me.cboLineNumberFont = New System.Windows.Forms.ComboBox()
		Me.cboTextFont = New System.Windows.Forms.ComboBox()
		Me.chkScrollToEnd = New System.Windows.Forms.CheckBox()
		Me.chkExpandSearch = New System.Windows.Forms.CheckBox()
		Me.chkMonitorFile = New System.Windows.Forms.CheckBox()
		Me.chkWarnBeforeReload = New System.Windows.Forms.CheckBox()
		Me.chkShowStartTab = New System.Windows.Forms.CheckBox()
		Me.chkAutoHighLight = New System.Windows.Forms.CheckBox()
		Me.chkAutoReload = New System.Windows.Forms.CheckBox()
		Me.rdoWindowDefault = New System.Windows.Forms.RadioButton()
		Me.rdoWindowMin = New System.Windows.Forms.RadioButton()
		Me.rdoWindowMax = New System.Windows.Forms.RadioButton()
		Me.chkAddDateToCopy = New System.Windows.Forms.CheckBox()
		Me.chkAskForCopyPath = New System.Windows.Forms.CheckBox()
		Me.txtDefaultSavedCopy = New System.Windows.Forms.TextBox()
		Me.pnlFonts.SuspendLayout()
		Me.GroupBox2.SuspendLayout()
		Me.GroupBox3.SuspendLayout()
		CType(Me.dgvHighLightWord, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.pnlStartup.SuspendLayout()
		CType(Me.dgvOpenFiles, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.GroupBox1.SuspendLayout()
		Me.pnlLocations.SuspendLayout()
		CType(Me.dgvFileTypes, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.pnlFileTypes.SuspendLayout()
		Me.SuspendLayout()
		'
		'trvOptions
		'
		Me.trvOptions.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
		Me.trvOptions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.trvOptions.Location = New System.Drawing.Point(11, 12)
		Me.trvOptions.Name = "trvOptions"
		TreeNode1.Name = "cnStartup"
		TreeNode1.Text = "Startup"
		TreeNode2.Name = "rnLocations"
		TreeNode2.Text = "Locations"
		TreeNode3.Name = "cnFileTypes"
		TreeNode3.Text = "File Types"
		TreeNode4.Name = "cnFonts"
		TreeNode4.Text = "Fonts"
		TreeNode5.Name = "rnApplication"
		TreeNode5.Text = "Application "
		Me.trvOptions.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode5})
		Me.trvOptions.Size = New System.Drawing.Size(178, 663)
		Me.trvOptions.TabIndex = 0
		'
		'btnOk
		'
		Me.btnOk.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.btnOk.Location = New System.Drawing.Point(1010, 690)
		Me.btnOk.Name = "btnOk"
		Me.btnOk.Size = New System.Drawing.Size(75, 23)
		Me.btnOk.TabIndex = 1
		Me.btnOk.Text = "Ok"
		Me.btnOk.UseVisualStyleBackColor = True
		'
		'btnCancel
		'
		Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
		Me.btnCancel.Location = New System.Drawing.Point(1091, 690)
		Me.btnCancel.Name = "btnCancel"
		Me.btnCancel.Size = New System.Drawing.Size(75, 23)
		Me.btnCancel.TabIndex = 2
		Me.btnCancel.Text = "Cancel"
		Me.btnCancel.UseVisualStyleBackColor = True
		'
		'pnlFonts
		'
		Me.pnlFonts.Anchor = System.Windows.Forms.AnchorStyles.None
		Me.pnlFonts.AutoScroll = True
		Me.pnlFonts.BackColor = System.Drawing.SystemColors.ButtonFace
		Me.pnlFonts.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.pnlFonts.Controls.Add(Me.GroupBox2)
		Me.pnlFonts.Controls.Add(Me.GroupBox3)
		Me.pnlFonts.Location = New System.Drawing.Point(213, 12)
		Me.pnlFonts.Name = "pnlFonts"
		Me.pnlFonts.Size = New System.Drawing.Size(435, 322)
		Me.pnlFonts.TabIndex = 4
		'
		'GroupBox2
		'
		Me.GroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.GroupBox2.Controls.Add(Me.Label9)
		Me.GroupBox2.Controls.Add(Me.Label8)
		Me.GroupBox2.Controls.Add(Me.Label6)
		Me.GroupBox2.Controls.Add(Me.Label4)
		Me.GroupBox2.Controls.Add(Me.Label5)
		Me.GroupBox2.Controls.Add(Me.chkLockFont)
		Me.GroupBox2.Controls.Add(Me.pnlLineBackColor)
		Me.GroupBox2.Controls.Add(Me.chkLockSize)
		Me.GroupBox2.Controls.Add(Me.pnlTextBackColor)
		Me.GroupBox2.Controls.Add(Me.cboLineNumberFontSize)
		Me.GroupBox2.Controls.Add(Me.Label7)
		Me.GroupBox2.Controls.Add(Me.cboTextFontSize)
		Me.GroupBox2.Controls.Add(Me.pnlLineNumberFontColor)
		Me.GroupBox2.Controls.Add(Me.lblTextFont)
		Me.GroupBox2.Controls.Add(Me.pnlTextFontColor)
		Me.GroupBox2.Controls.Add(Me.lblLineNumberFont)
		Me.GroupBox2.Controls.Add(Me.cboLineNumberFont)
		Me.GroupBox2.Controls.Add(Me.cboTextFont)
		Me.GroupBox2.Location = New System.Drawing.Point(3, 1)
		Me.GroupBox2.Name = "GroupBox2"
		Me.GroupBox2.Size = New System.Drawing.Size(410, 288)
		Me.GroupBox2.TabIndex = 17
		Me.GroupBox2.TabStop = False
		Me.GroupBox2.Text = "Font Properties"
		'
		'Label9
		'
		Me.Label9.AutoSize = True
		Me.Label9.Location = New System.Drawing.Point(218, 186)
		Me.Label9.Name = "Label9"
		Me.Label9.Size = New System.Drawing.Size(27, 13)
		Me.Label9.TabIndex = 15
		Me.Label9.Text = "Size"
		'
		'Label8
		'
		Me.Label8.AutoSize = True
		Me.Label8.Location = New System.Drawing.Point(218, 82)
		Me.Label8.Name = "Label8"
		Me.Label8.Size = New System.Drawing.Size(27, 13)
		Me.Label8.TabIndex = 14
		Me.Label8.Text = "Size"
		'
		'Label6
		'
		Me.Label6.AutoSize = True
		Me.Label6.Location = New System.Drawing.Point(15, 25)
		Me.Label6.Name = "Label6"
		Me.Label6.Size = New System.Drawing.Size(91, 13)
		Me.Label6.TabIndex = 3
		Me.Label6.Text = "Line Number Font"
		'
		'Label4
		'
		Me.Label4.AutoSize = True
		Me.Label4.Location = New System.Drawing.Point(59, 79)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(55, 13)
		Me.Label4.TabIndex = 0
		Me.Label4.Text = "Backcolor"
		'
		'Label5
		'
		Me.Label5.AutoSize = True
		Me.Label5.Location = New System.Drawing.Point(64, 181)
		Me.Label5.Name = "Label5"
		Me.Label5.Size = New System.Drawing.Size(55, 13)
		Me.Label5.TabIndex = 1
		Me.Label5.Text = "Backcolor"
		'
		'Label7
		'
		Me.Label7.AutoSize = True
		Me.Label7.Location = New System.Drawing.Point(15, 127)
		Me.Label7.Name = "Label7"
		Me.Label7.Size = New System.Drawing.Size(55, 13)
		Me.Label7.TabIndex = 4
		Me.Label7.Text = "Text Font "
		'
		'GroupBox3
		'
		Me.GroupBox3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.GroupBox3.Controls.Add(Me.dgvHighLightWord)
		Me.GroupBox3.Location = New System.Drawing.Point(4, 299)
		Me.GroupBox3.Name = "GroupBox3"
		Me.GroupBox3.Size = New System.Drawing.Size(409, 194)
		Me.GroupBox3.TabIndex = 18
		Me.GroupBox3.TabStop = False
		Me.GroupBox3.Text = "Keyword Highlighting"
		'
		'dgvHighLightWord
		'
		Me.dgvHighLightWord.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
		DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveBorder
		DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
		DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White
		DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
		DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
		Me.dgvHighLightWord.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
		Me.dgvHighLightWord.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.dgvHighLightWord.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colHighLightWord, Me.colColor, Me.colFontStyle})
		Me.dgvHighLightWord.Location = New System.Drawing.Point(14, 28)
		Me.dgvHighLightWord.Name = "dgvHighLightWord"
		Me.dgvHighLightWord.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
		Me.dgvHighLightWord.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
		Me.dgvHighLightWord.Size = New System.Drawing.Size(389, 150)
		Me.dgvHighLightWord.TabIndex = 15
		'
		'colHighLightWord
		'
		Me.colHighLightWord.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
		DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
		Me.colHighLightWord.DefaultCellStyle = DataGridViewCellStyle2
		Me.colHighLightWord.HeaderText = "HightLight Word"
		Me.colHighLightWord.Name = "colHighLightWord"
		'
		'colColor
		'
		DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
		Me.colColor.DefaultCellStyle = DataGridViewCellStyle3
		Me.colColor.HeaderText = "Color"
		Me.colColor.Name = "colColor"
		Me.colColor.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
		Me.colColor.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
		Me.colColor.Width = 35
		'
		'colFontStyle
		'
		Me.colFontStyle.HeaderText = "Font Style"
		Me.colFontStyle.Items.AddRange(New Object() {"FontStyle.Regular", "FontStyle.Bold", "FontStyle.Italic", "FontStyle.Underline", "FontStyle.Strikeout"})
		Me.colFontStyle.Name = "colFontStyle"
		Me.colFontStyle.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
		Me.colFontStyle.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
		Me.colFontStyle.Width = 125
		'
		'pnlStartup
		'
		Me.pnlStartup.Anchor = System.Windows.Forms.AnchorStyles.None
		Me.pnlStartup.AutoScroll = True
		Me.pnlStartup.BackColor = System.Drawing.SystemColors.ButtonFace
		Me.pnlStartup.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.pnlStartup.Controls.Add(Me.chkScrollToEnd)
		Me.pnlStartup.Controls.Add(Me.chkExpandSearch)
		Me.pnlStartup.Controls.Add(Me.chkMonitorFile)
		Me.pnlStartup.Controls.Add(Me.lblAddMoreFiles)
		Me.pnlStartup.Controls.Add(Me.chkWarnBeforeReload)
		Me.pnlStartup.Controls.Add(Me.chkShowStartTab)
		Me.pnlStartup.Controls.Add(Me.chkAutoHighLight)
		Me.pnlStartup.Controls.Add(Me.chkAutoReload)
		Me.pnlStartup.Controls.Add(Me.dgvOpenFiles)
		Me.pnlStartup.Controls.Add(Me.GroupBox1)
		Me.pnlStartup.Controls.Add(Me.Label1)
		Me.pnlStartup.Location = New System.Drawing.Point(708, 12)
		Me.pnlStartup.MinimumSize = New System.Drawing.Size(437, 344)
		Me.pnlStartup.Name = "pnlStartup"
		Me.pnlStartup.Size = New System.Drawing.Size(437, 344)
		Me.pnlStartup.TabIndex = 4
		'
		'lblAddMoreFiles
		'
		Me.lblAddMoreFiles.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.lblAddMoreFiles.AutoSize = True
		Me.lblAddMoreFiles.Location = New System.Drawing.Point(335, 195)
		Me.lblAddMoreFiles.Name = "lblAddMoreFiles"
		Me.lblAddMoreFiles.Size = New System.Drawing.Size(82, 13)
		Me.lblAddMoreFiles.TabIndex = 11
		Me.lblAddMoreFiles.TabStop = True
		Me.lblAddMoreFiles.Text = "Add more files..."
		'
		'dgvOpenFiles
		'
		Me.dgvOpenFiles.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.dgvOpenFiles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.dgvOpenFiles.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colOpen, Me.colFilePath})
		Me.dgvOpenFiles.Location = New System.Drawing.Point(16, 211)
		Me.dgvOpenFiles.Name = "dgvOpenFiles"
		Me.dgvOpenFiles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
		Me.dgvOpenFiles.Size = New System.Drawing.Size(401, 119)
		Me.dgvOpenFiles.TabIndex = 7
		'
		'colOpen
		'
		Me.colOpen.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
		Me.colOpen.FillWeight = 50.76142!
		Me.colOpen.HeaderText = "Open"
		Me.colOpen.Name = "colOpen"
		Me.colOpen.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
		Me.colOpen.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
		Me.colOpen.Width = 50
		'
		'colFilePath
		'
		Me.colFilePath.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
		Me.colFilePath.FillWeight = 149.2386!
		Me.colFilePath.HeaderText = "Path"
		Me.colFilePath.Name = "colFilePath"
		'
		'GroupBox1
		'
		Me.GroupBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.GroupBox1.Controls.Add(Me.rdoWindowDefault)
		Me.GroupBox1.Controls.Add(Me.rdoWindowMin)
		Me.GroupBox1.Controls.Add(Me.rdoWindowMax)
		Me.GroupBox1.Location = New System.Drawing.Point(278, 12)
		Me.GroupBox1.Name = "GroupBox1"
		Me.GroupBox1.Size = New System.Drawing.Size(139, 95)
		Me.GroupBox1.TabIndex = 5
		Me.GroupBox1.TabStop = False
		Me.GroupBox1.Text = "Window Size at Startup"
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Location = New System.Drawing.Point(12, 195)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(104, 13)
		Me.Label1.TabIndex = 3
		Me.Label1.Text = "Open files on startup"
		'
		'pnlLocations
		'
		Me.pnlLocations.Anchor = System.Windows.Forms.AnchorStyles.None
		Me.pnlLocations.BackColor = System.Drawing.SystemColors.ButtonFace
		Me.pnlLocations.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.pnlLocations.Controls.Add(Me.chkAddDateToCopy)
		Me.pnlLocations.Controls.Add(Me.chkAskForCopyPath)
		Me.pnlLocations.Controls.Add(Me.btnDefaultSavedCopy)
		Me.pnlLocations.Controls.Add(Me.txtDefaultSavedCopy)
		Me.pnlLocations.Controls.Add(Me.Label3)
		Me.pnlLocations.Location = New System.Drawing.Point(708, 362)
		Me.pnlLocations.Name = "pnlLocations"
		Me.pnlLocations.Size = New System.Drawing.Size(437, 381)
		Me.pnlLocations.TabIndex = 5
		'
		'btnDefaultSavedCopy
		'
		Me.btnDefaultSavedCopy.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.btnDefaultSavedCopy.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnDefaultSavedCopy.Location = New System.Drawing.Point(389, 37)
		Me.btnDefaultSavedCopy.Name = "btnDefaultSavedCopy"
		Me.btnDefaultSavedCopy.Size = New System.Drawing.Size(27, 23)
		Me.btnDefaultSavedCopy.TabIndex = 2
		Me.btnDefaultSavedCopy.Text = "..."
		Me.btnDefaultSavedCopy.UseVisualStyleBackColor = True
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.Location = New System.Drawing.Point(16, 20)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(178, 13)
		Me.Label3.TabIndex = 0
		Me.Label3.Text = "Default location when saving copies"
		'
		'dgvFileTypes
		'
		Me.dgvFileTypes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.dgvFileTypes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colFileType})
		Me.dgvFileTypes.Location = New System.Drawing.Point(21, 20)
		Me.dgvFileTypes.Name = "dgvFileTypes"
		Me.dgvFileTypes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
		Me.dgvFileTypes.Size = New System.Drawing.Size(321, 392)
		Me.dgvFileTypes.TabIndex = 5
		'
		'colFileType
		'
		Me.colFileType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
		Me.colFileType.HeaderText = "File Types"
		Me.colFileType.Name = "colFileType"
		'
		'pnlFileTypes
		'
		Me.pnlFileTypes.Anchor = System.Windows.Forms.AnchorStyles.None
		Me.pnlFileTypes.BackColor = System.Drawing.SystemColors.ButtonFace
		Me.pnlFileTypes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.pnlFileTypes.Controls.Add(Me.dgvFileTypes)
		Me.pnlFileTypes.Location = New System.Drawing.Point(213, 359)
		Me.pnlFileTypes.Name = "pnlFileTypes"
		Me.pnlFileTypes.Size = New System.Drawing.Size(476, 343)
		Me.pnlFileTypes.TabIndex = 6
		'
		'Label2
		'
		Me.Label2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.Label2.AutoSize = True
		Me.Label2.ForeColor = System.Drawing.SystemColors.AppWorkspace
		Me.Label2.Location = New System.Drawing.Point(8, 670)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(931, 13)
		Me.Label2.TabIndex = 7
		Me.Label2.Text = "_________________________________________________________________________________" &
	"_________________________________________________________________________"
		'
		'btnRestoreDefaults
		'
		Me.btnRestoreDefaults.Location = New System.Drawing.Point(11, 516)
		Me.btnRestoreDefaults.Name = "btnRestoreDefaults"
		Me.btnRestoreDefaults.Size = New System.Drawing.Size(104, 23)
		Me.btnRestoreDefaults.TabIndex = 8
		Me.btnRestoreDefaults.Text = "Restore Defaults"
		Me.btnRestoreDefaults.UseVisualStyleBackColor = True
		'
		'chkLockFont
		'
		Me.chkLockFont.AutoSize = True
		Me.chkLockFont.Checked = Global.LogViewer.My.MySettings.Default.LockFont
		Me.chkLockFont.CheckState = System.Windows.Forms.CheckState.Checked
		Me.chkLockFont.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.LogViewer.My.MySettings.Default, "LockFont", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
		Me.chkLockFont.Location = New System.Drawing.Point(28, 251)
		Me.chkLockFont.Name = "chkLockFont"
		Me.chkLockFont.Size = New System.Drawing.Size(152, 17)
		Me.chkLockFont.TabIndex = 13
		Me.chkLockFont.Text = "Lock font (Recommended)"
		Me.chkLockFont.UseVisualStyleBackColor = True
		'
		'pnlLineBackColor
		'
		Me.pnlLineBackColor.BackColor = Global.LogViewer.My.MySettings.Default.LineNumberBackColor
		Me.pnlLineBackColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.pnlLineBackColor.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.LogViewer.My.MySettings.Default, "LineNumberBackColor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
		Me.pnlLineBackColor.Location = New System.Drawing.Point(28, 72)
		Me.pnlLineBackColor.Name = "pnlLineBackColor"
		Me.pnlLineBackColor.Size = New System.Drawing.Size(20, 20)
		Me.pnlLineBackColor.TabIndex = 2
		'
		'chkLockSize
		'
		Me.chkLockSize.AutoSize = True
		Me.chkLockSize.Checked = Global.LogViewer.My.MySettings.Default.LockFontSizes
		Me.chkLockSize.CheckState = System.Windows.Forms.CheckState.Checked
		Me.chkLockSize.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.LogViewer.My.MySettings.Default, "LockFontSizes", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
		Me.chkLockSize.Location = New System.Drawing.Point(28, 230)
		Me.chkLockSize.Name = "chkLockSize"
		Me.chkLockSize.Size = New System.Drawing.Size(178, 17)
		Me.chkLockSize.TabIndex = 12
		Me.chkLockSize.Text = "Lock font sizes (Recommended)"
		Me.chkLockSize.UseVisualStyleBackColor = True
		'
		'pnlTextBackColor
		'
		Me.pnlTextBackColor.BackColor = Global.LogViewer.My.MySettings.Default.TextBackColor
		Me.pnlTextBackColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.pnlTextBackColor.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.LogViewer.My.MySettings.Default, "TextBackColor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
		Me.pnlTextBackColor.Location = New System.Drawing.Point(28, 174)
		Me.pnlTextBackColor.Name = "pnlTextBackColor"
		Me.pnlTextBackColor.Size = New System.Drawing.Size(20, 20)
		Me.pnlTextBackColor.TabIndex = 3
		'
		'cboLineNumberFontSize
		'
		Me.cboLineNumberFontSize.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.LogViewer.My.MySettings.Default, "LineNumberFontSize", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
		Me.cboLineNumberFontSize.FormattingEnabled = True
		Me.cboLineNumberFontSize.Location = New System.Drawing.Point(166, 74)
		Me.cboLineNumberFontSize.Name = "cboLineNumberFontSize"
		Me.cboLineNumberFontSize.Size = New System.Drawing.Size(46, 21)
		Me.cboLineNumberFontSize.TabIndex = 11
		Me.cboLineNumberFontSize.Text = Global.LogViewer.My.MySettings.Default.LineNumberFontSize
		'
		'cboTextFontSize
		'
		Me.cboTextFontSize.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.LogViewer.My.MySettings.Default, "TextFontSize", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
		Me.cboTextFontSize.FormattingEnabled = True
		Me.cboTextFontSize.Location = New System.Drawing.Point(166, 178)
		Me.cboTextFontSize.Name = "cboTextFontSize"
		Me.cboTextFontSize.Size = New System.Drawing.Size(46, 21)
		Me.cboTextFontSize.TabIndex = 10
		Me.cboTextFontSize.Text = Global.LogViewer.My.MySettings.Default.TextFontSize
		'
		'pnlLineNumberFontColor
		'
		Me.pnlLineNumberFontColor.BackColor = Global.LogViewer.My.MySettings.Default.LineNumberFontColor
		Me.pnlLineNumberFontColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.pnlLineNumberFontColor.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.LogViewer.My.MySettings.Default, "LineNumberFontColor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
		Me.pnlLineNumberFontColor.Location = New System.Drawing.Point(28, 46)
		Me.pnlLineNumberFontColor.Name = "pnlLineNumberFontColor"
		Me.pnlLineNumberFontColor.Size = New System.Drawing.Size(20, 20)
		Me.pnlLineNumberFontColor.TabIndex = 4
		'
		'lblTextFont
		'
		Me.lblTextFont.AutoSize = True
		Me.lblTextFont.BackColor = Global.LogViewer.My.MySettings.Default.TextBackColor
		Me.lblTextFont.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.lblTextFont.DataBindings.Add(New System.Windows.Forms.Binding("Font", Global.LogViewer.My.MySettings.Default, "TextFont", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
		Me.lblTextFont.DataBindings.Add(New System.Windows.Forms.Binding("ForeColor", Global.LogViewer.My.MySettings.Default, "TextFontColor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
		Me.lblTextFont.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.LogViewer.My.MySettings.Default, "TextBackColor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
		Me.lblTextFont.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.LogViewer.My.MySettings.Default, "TextFontString", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
		Me.lblTextFont.Font = Global.LogViewer.My.MySettings.Default.TextFont
		Me.lblTextFont.ForeColor = Global.LogViewer.My.MySettings.Default.TextFontColor
		Me.lblTextFont.Location = New System.Drawing.Point(223, 147)
		Me.lblTextFont.Name = "lblTextFont"
		Me.lblTextFont.Size = New System.Drawing.Size(57, 15)
		Me.lblTextFont.TabIndex = 9
		Me.lblTextFont.Text = Global.LogViewer.My.MySettings.Default.TextFontString
		'
		'pnlTextFontColor
		'
		Me.pnlTextFontColor.BackColor = Global.LogViewer.My.MySettings.Default.TextFontColor
		Me.pnlTextFontColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.pnlTextFontColor.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.LogViewer.My.MySettings.Default, "TextFontColor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
		Me.pnlTextFontColor.Location = New System.Drawing.Point(28, 148)
		Me.pnlTextFontColor.Name = "pnlTextFontColor"
		Me.pnlTextFontColor.Size = New System.Drawing.Size(20, 20)
		Me.pnlTextFontColor.TabIndex = 5
		'
		'lblLineNumberFont
		'
		Me.lblLineNumberFont.AutoSize = True
		Me.lblLineNumberFont.BackColor = Global.LogViewer.My.MySettings.Default.LineNumberBackColor
		Me.lblLineNumberFont.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.lblLineNumberFont.DataBindings.Add(New System.Windows.Forms.Binding("Font", Global.LogViewer.My.MySettings.Default, "LineNumberFont", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
		Me.lblLineNumberFont.DataBindings.Add(New System.Windows.Forms.Binding("ForeColor", Global.LogViewer.My.MySettings.Default, "LineNumberFontColor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
		Me.lblLineNumberFont.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.LogViewer.My.MySettings.Default, "LineNumberBackColor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
		Me.lblLineNumberFont.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.LogViewer.My.MySettings.Default, "LineNumberFontString", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
		Me.lblLineNumberFont.Font = Global.LogViewer.My.MySettings.Default.LineNumberFont
		Me.lblLineNumberFont.ForeColor = Global.LogViewer.My.MySettings.Default.LineNumberFontColor
		Me.lblLineNumberFont.Location = New System.Drawing.Point(225, 45)
		Me.lblLineNumberFont.Name = "lblLineNumberFont"
		Me.lblLineNumberFont.Size = New System.Drawing.Size(57, 15)
		Me.lblLineNumberFont.TabIndex = 8
		Me.lblLineNumberFont.Text = Global.LogViewer.My.MySettings.Default.LineNumberFontString
		'
		'cboLineNumberFont
		'
		Me.cboLineNumberFont.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.LogViewer.My.MySettings.Default, "LineNumberFontString", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
		Me.cboLineNumberFont.DisplayMember = "Consolas"
		Me.cboLineNumberFont.FormattingEnabled = True
		Me.cboLineNumberFont.Location = New System.Drawing.Point(61, 45)
		Me.cboLineNumberFont.Name = "cboLineNumberFont"
		Me.cboLineNumberFont.Size = New System.Drawing.Size(152, 21)
		Me.cboLineNumberFont.TabIndex = 6
		Me.cboLineNumberFont.Text = Global.LogViewer.My.MySettings.Default.LineNumberFontString
		'
		'cboTextFont
		'
		Me.cboTextFont.BackColor = System.Drawing.Color.White
		Me.cboTextFont.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.LogViewer.My.MySettings.Default, "TextFontString", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
		Me.cboTextFont.DisplayMember = "Consolas"
		Me.cboTextFont.FormattingEnabled = True
		Me.cboTextFont.Location = New System.Drawing.Point(61, 147)
		Me.cboTextFont.Name = "cboTextFont"
		Me.cboTextFont.Size = New System.Drawing.Size(152, 21)
		Me.cboTextFont.TabIndex = 7
		Me.cboTextFont.Text = Global.LogViewer.My.MySettings.Default.TextFontString
		'
		'chkScrollToEnd
		'
		Me.chkScrollToEnd.AutoSize = True
		Me.chkScrollToEnd.Checked = Global.LogViewer.My.MySettings.Default.ScrollToEnd
		Me.chkScrollToEnd.CheckState = System.Windows.Forms.CheckState.Checked
		Me.chkScrollToEnd.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.LogViewer.My.MySettings.Default, "ScrollToEnd", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
		Me.chkScrollToEnd.Location = New System.Drawing.Point(16, 132)
		Me.chkScrollToEnd.Name = "chkScrollToEnd"
		Me.chkScrollToEnd.Size = New System.Drawing.Size(177, 17)
		Me.chkScrollToEnd.TabIndex = 14
		Me.chkScrollToEnd.Text = "Scroll to end of file when loaded"
		Me.chkScrollToEnd.UseVisualStyleBackColor = True
		'
		'chkExpandSearch
		'
		Me.chkExpandSearch.AutoSize = True
		Me.chkExpandSearch.Checked = Global.LogViewer.My.MySettings.Default.ShowQuickSearch
		Me.chkExpandSearch.CheckState = System.Windows.Forms.CheckState.Checked
		Me.chkExpandSearch.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.LogViewer.My.MySettings.Default, "ShowQuickSearch", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
		Me.chkExpandSearch.Location = New System.Drawing.Point(16, 35)
		Me.chkExpandSearch.Name = "chkExpandSearch"
		Me.chkExpandSearch.Size = New System.Drawing.Size(188, 17)
		Me.chkExpandSearch.TabIndex = 13
		Me.chkExpandSearch.Text = "Start with Quick Search expanded"
		Me.chkExpandSearch.UseVisualStyleBackColor = True
		'
		'chkMonitorFile
		'
		Me.chkMonitorFile.AutoSize = True
		Me.chkMonitorFile.Checked = Global.LogViewer.My.MySettings.Default.FileMonitor
		Me.chkMonitorFile.CheckState = System.Windows.Forms.CheckState.Checked
		Me.chkMonitorFile.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.LogViewer.My.MySettings.Default, "FileMonitor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
		Me.chkMonitorFile.Location = New System.Drawing.Point(16, 155)
		Me.chkMonitorFile.Name = "chkMonitorFile"
		Me.chkMonitorFile.Size = New System.Drawing.Size(216, 17)
		Me.chkMonitorFile.TabIndex = 12
		Me.chkMonitorFile.Text = "Turn on file monitor (runs in background)"
		Me.chkMonitorFile.UseVisualStyleBackColor = True
		'
		'chkWarnBeforeReload
		'
		Me.chkWarnBeforeReload.AutoSize = True
		Me.chkWarnBeforeReload.Checked = Global.LogViewer.My.MySettings.Default.WarnBeforeReload
		Me.chkWarnBeforeReload.CheckState = System.Windows.Forms.CheckState.Checked
		Me.chkWarnBeforeReload.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.LogViewer.My.MySettings.Default, "WarnBeforeReload", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
		Me.chkWarnBeforeReload.Location = New System.Drawing.Point(16, 109)
		Me.chkWarnBeforeReload.Name = "chkWarnBeforeReload"
		Me.chkWarnBeforeReload.Size = New System.Drawing.Size(131, 17)
		Me.chkWarnBeforeReload.TabIndex = 10
		Me.chkWarnBeforeReload.Text = "Warn before reloading"
		Me.ToolTip1.SetToolTip(Me.chkWarnBeforeReload, "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10))
		Me.chkWarnBeforeReload.UseVisualStyleBackColor = True
		'
		'chkShowStartTab
		'
		Me.chkShowStartTab.AutoSize = True
		Me.chkShowStartTab.Checked = Global.LogViewer.My.MySettings.Default.ShowStartTab
		Me.chkShowStartTab.CheckState = System.Windows.Forms.CheckState.Checked
		Me.chkShowStartTab.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.LogViewer.My.MySettings.Default, "ShowStartTab", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
		Me.chkShowStartTab.Location = New System.Drawing.Point(16, 12)
		Me.chkShowStartTab.Name = "chkShowStartTab"
		Me.chkShowStartTab.Size = New System.Drawing.Size(201, 17)
		Me.chkShowStartTab.TabIndex = 0
		Me.chkShowStartTab.Text = "Show start tab on application start up"
		Me.chkShowStartTab.UseVisualStyleBackColor = True
		'
		'chkAutoHighLight
		'
		Me.chkAutoHighLight.AutoSize = True
		Me.chkAutoHighLight.Checked = Global.LogViewer.My.MySettings.Default.AutoHighlight
		Me.chkAutoHighLight.CheckState = System.Windows.Forms.CheckState.Checked
		Me.chkAutoHighLight.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.LogViewer.My.MySettings.Default, "AutoHighlight", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
		Me.chkAutoHighLight.Location = New System.Drawing.Point(16, 61)
		Me.chkAutoHighLight.Name = "chkAutoHighLight"
		Me.chkAutoHighLight.Size = New System.Drawing.Size(201, 17)
		Me.chkAutoHighLight.TabIndex = 9
		Me.chkAutoHighLight.Text = "Highlight keywords when opening file"
		Me.ToolTip1.SetToolTip(Me.chkAutoHighLight, "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10))
		Me.chkAutoHighLight.UseVisualStyleBackColor = True
		'
		'chkAutoReload
		'
		Me.chkAutoReload.AutoSize = True
		Me.chkAutoReload.Checked = Global.LogViewer.My.MySettings.Default.AutoReloadFile
		Me.chkAutoReload.CheckState = System.Windows.Forms.CheckState.Checked
		Me.chkAutoReload.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.LogViewer.My.MySettings.Default, "AutoReloadFile", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
		Me.chkAutoReload.Location = New System.Drawing.Point(16, 84)
		Me.chkAutoReload.Name = "chkAutoReload"
		Me.chkAutoReload.Size = New System.Drawing.Size(178, 17)
		Me.chkAutoReload.TabIndex = 8
		Me.chkAutoReload.Text = "Reload file when returning focus"
		Me.ToolTip1.SetToolTip(Me.chkAutoReload, "If file is open, this will reload file when clicking back onto tab" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "from another " &
		"to capture new changes if any." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10))
		Me.chkAutoReload.UseVisualStyleBackColor = True
		'
		'rdoWindowDefault
		'
		Me.rdoWindowDefault.AutoSize = True
		Me.rdoWindowDefault.Checked = Global.LogViewer.My.MySettings.Default.WindowStateDefault
		Me.rdoWindowDefault.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.LogViewer.My.MySettings.Default, "WindowStateDefault", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
		Me.rdoWindowDefault.Location = New System.Drawing.Point(17, 21)
		Me.rdoWindowDefault.Name = "rdoWindowDefault"
		Me.rdoWindowDefault.Size = New System.Drawing.Size(101, 17)
		Me.rdoWindowDefault.TabIndex = 2
		Me.rdoWindowDefault.TabStop = True
		Me.rdoWindowDefault.Text = "Normal (Default)"
		Me.rdoWindowDefault.UseVisualStyleBackColor = True
		'
		'rdoWindowMin
		'
		Me.rdoWindowMin.AutoSize = True
		Me.rdoWindowMin.Checked = Global.LogViewer.My.MySettings.Default.WindowStateMin
		Me.rdoWindowMin.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.LogViewer.My.MySettings.Default, "WindowStateMin", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
		Me.rdoWindowMin.Location = New System.Drawing.Point(17, 67)
		Me.rdoWindowMin.Name = "rdoWindowMin"
		Me.rdoWindowMin.Size = New System.Drawing.Size(71, 17)
		Me.rdoWindowMin.TabIndex = 1
		Me.rdoWindowMin.Text = "Minimized"
		Me.rdoWindowMin.UseVisualStyleBackColor = True
		'
		'rdoWindowMax
		'
		Me.rdoWindowMax.AutoSize = True
		Me.rdoWindowMax.Checked = Global.LogViewer.My.MySettings.Default.WindowStateMax
		Me.rdoWindowMax.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.LogViewer.My.MySettings.Default, "WindowStateMax", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
		Me.rdoWindowMax.Location = New System.Drawing.Point(17, 44)
		Me.rdoWindowMax.Name = "rdoWindowMax"
		Me.rdoWindowMax.Size = New System.Drawing.Size(74, 17)
		Me.rdoWindowMax.TabIndex = 0
		Me.rdoWindowMax.Text = "Maximized"
		Me.rdoWindowMax.UseVisualStyleBackColor = True
		'
		'chkAddDateToCopy
		'
		Me.chkAddDateToCopy.AutoSize = True
		Me.chkAddDateToCopy.Checked = Global.LogViewer.My.MySettings.Default.AddDateToCopy
		Me.chkAddDateToCopy.CheckState = System.Windows.Forms.CheckState.Checked
		Me.chkAddDateToCopy.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.LogViewer.My.MySettings.Default, "AddDateToCopy", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
		Me.chkAddDateToCopy.Location = New System.Drawing.Point(23, 97)
		Me.chkAddDateToCopy.Name = "chkAddDateToCopy"
		Me.chkAddDateToCopy.Size = New System.Drawing.Size(149, 17)
		Me.chkAddDateToCopy.TabIndex = 4
		Me.chkAddDateToCopy.Text = "Add date to copy filename"
		Me.chkAddDateToCopy.UseVisualStyleBackColor = True
		'
		'chkAskForCopyPath
		'
		Me.chkAskForCopyPath.AutoSize = True
		Me.chkAskForCopyPath.Checked = Global.LogViewer.My.MySettings.Default.AskForCopyPath
		Me.chkAskForCopyPath.CheckState = System.Windows.Forms.CheckState.Checked
		Me.chkAskForCopyPath.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.LogViewer.My.MySettings.Default, "AskForCopyPath", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
		Me.chkAskForCopyPath.Location = New System.Drawing.Point(23, 73)
		Me.chkAskForCopyPath.Name = "chkAskForCopyPath"
		Me.chkAskForCopyPath.Size = New System.Drawing.Size(198, 17)
		Me.chkAskForCopyPath.TabIndex = 3
		Me.chkAskForCopyPath.Text = "Ask for copy path location each time"
		Me.chkAskForCopyPath.UseVisualStyleBackColor = True
		'
		'txtDefaultSavedCopy
		'
		Me.txtDefaultSavedCopy.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.txtDefaultSavedCopy.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.LogViewer.My.MySettings.Default, "DefaultSavedCopy", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
		Me.txtDefaultSavedCopy.Location = New System.Drawing.Point(19, 39)
		Me.txtDefaultSavedCopy.Name = "txtDefaultSavedCopy"
		Me.txtDefaultSavedCopy.Size = New System.Drawing.Size(361, 20)
		Me.txtDefaultSavedCopy.TabIndex = 1
		Me.txtDefaultSavedCopy.Text = Global.LogViewer.My.MySettings.Default.DefaultSavedCopy
		'
		'Options
		'
		Me.AcceptButton = Me.btnOk
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.CancelButton = Me.btnCancel
		Me.ClientSize = New System.Drawing.Size(1183, 725)
		Me.Controls.Add(Me.pnlFonts)
		Me.Controls.Add(Me.pnlFileTypes)
		Me.Controls.Add(Me.pnlStartup)
		Me.Controls.Add(Me.pnlLocations)
		Me.Controls.Add(Me.trvOptions)
		Me.Controls.Add(Me.btnRestoreDefaults)
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.btnCancel)
		Me.Controls.Add(Me.btnOk)
		Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.MaximizeBox = False
		Me.MinimizeBox = False
		Me.Name = "Options"
		Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show
		Me.Text = "Options"
		Me.pnlFonts.ResumeLayout(False)
		Me.GroupBox2.ResumeLayout(False)
		Me.GroupBox2.PerformLayout()
		Me.GroupBox3.ResumeLayout(False)
		CType(Me.dgvHighLightWord, System.ComponentModel.ISupportInitialize).EndInit()
		Me.pnlStartup.ResumeLayout(False)
		Me.pnlStartup.PerformLayout()
		CType(Me.dgvOpenFiles, System.ComponentModel.ISupportInitialize).EndInit()
		Me.GroupBox1.ResumeLayout(False)
		Me.GroupBox1.PerformLayout()
		Me.pnlLocations.ResumeLayout(False)
		Me.pnlLocations.PerformLayout()
		CType(Me.dgvFileTypes, System.ComponentModel.ISupportInitialize).EndInit()
		Me.pnlFileTypes.ResumeLayout(False)
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents trvOptions As TreeView
	Friend WithEvents btnOk As Button
	Friend WithEvents btnCancel As Button
	Friend WithEvents pnlFonts As Panel
	Friend WithEvents pnlStartup As Panel
	Friend WithEvents pnlLocations As Panel
	Friend WithEvents pnlFileTypes As Panel
	Friend WithEvents GroupBox1 As GroupBox
	Friend WithEvents rdoWindowDefault As RadioButton
	Friend WithEvents rdoWindowMin As RadioButton
	Friend WithEvents rdoWindowMax As RadioButton
	Friend WithEvents Label1 As Label
	Friend WithEvents chkShowStartTab As CheckBox
	Friend WithEvents dgvOpenFiles As DataGridView
	Friend WithEvents colOpen As DataGridViewCheckBoxColumn
	Friend WithEvents colFilePath As DataGridViewTextBoxColumn
	Friend WithEvents chkAutoReload As CheckBox
	Friend WithEvents ToolTip1 As ToolTip
	Friend WithEvents Label2 As Label
	Friend WithEvents btnDefaultSavedCopy As Button
	Friend WithEvents txtDefaultSavedCopy As TextBox
	Friend WithEvents Label3 As Label
	Friend WithEvents pnlTextBackColor As Panel
	Friend WithEvents pnlLineBackColor As Panel
	Friend WithEvents Label5 As Label
	Friend WithEvents Label4 As Label
	Friend WithEvents pnlTextFontColor As Panel
	Friend WithEvents pnlLineNumberFontColor As Panel
	Friend WithEvents Label7 As Label
	Friend WithEvents Label6 As Label
	Friend WithEvents cboLineNumberFont As ComboBox
	Friend WithEvents cboTextFont As ComboBox
	Friend WithEvents lblLineNumberFont As Label
	Friend WithEvents lblTextFont As Label
	Friend WithEvents cboLineNumberFontSize As ComboBox
	Friend WithEvents cboTextFontSize As ComboBox
	Friend WithEvents chkAskForCopyPath As CheckBox
	Friend WithEvents chkAddDateToCopy As CheckBox
	Friend WithEvents chkLockSize As CheckBox
	Friend WithEvents chkLockFont As CheckBox
	Friend WithEvents dgvHighLightWord As DataGridView
	Friend WithEvents GroupBox3 As GroupBox
	Friend WithEvents GroupBox2 As GroupBox
	Friend WithEvents Label9 As Label
	Friend WithEvents Label8 As Label
	Friend WithEvents btnRestoreDefaults As Button
	Friend WithEvents dgvFileTypes As DataGridView
	Friend WithEvents colFileType As DataGridViewTextBoxColumn
	Friend WithEvents colHighLightWord As DataGridViewTextBoxColumn
	Friend WithEvents colColor As DataGridViewTextBoxColumn
	Friend WithEvents colFontStyle As DataGridViewComboBoxColumn
	Friend WithEvents chkAutoHighLight As CheckBox
	Friend WithEvents chkWarnBeforeReload As CheckBox
	Friend WithEvents lblAddMoreFiles As LinkLabel
	Friend WithEvents chkMonitorFile As CheckBox
	Friend WithEvents chkExpandSearch As CheckBox
	Friend WithEvents chkScrollToEnd As CheckBox
End Class
