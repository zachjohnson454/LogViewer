<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BrowseFrm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BrowseFrm))
        Me.dgvFileList = New System.Windows.Forms.DataGridView()
        Me.colSelect = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.colPath = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colFile = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colLastModified = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colCreated = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colSize = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtSearchPath = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnSearchPath = New System.Windows.Forms.Button()
        Me.chkRecursiveSearch = New System.Windows.Forms.CheckBox()
        Me.dgvBrowseFileTypes = New System.Windows.Forms.DataGridView()
        Me.colCheck = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.colFileType = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ExitToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnBeginSearch = New System.Windows.Forms.Button()
        Me.btnApply = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.chkSelectAll = New System.Windows.Forms.CheckBox()
        CType(Me.dgvFileList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvBrowseFileTypes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvFileList
        '
        Me.dgvFileList.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvFileList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvFileList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvFileList.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colSelect, Me.colPath, Me.colFile, Me.colLastModified, Me.colCreated, Me.colSize})
        Me.dgvFileList.Location = New System.Drawing.Point(12, 269)
        Me.dgvFileList.Name = "dgvFileList"
        Me.dgvFileList.RowHeadersVisible = False
        Me.dgvFileList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvFileList.Size = New System.Drawing.Size(685, 387)
        Me.dgvFileList.TabIndex = 0
        '
        'colSelect
        '
        Me.colSelect.HeaderText = "Select"
        Me.colSelect.Name = "colSelect"
        Me.colSelect.Width = 43
        '
        'colPath
        '
        Me.colPath.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colPath.HeaderText = "Path"
        Me.colPath.Name = "colPath"
        '
        'colFile
        '
        Me.colFile.FillWeight = 25.0!
        Me.colFile.HeaderText = "File Name"
        Me.colFile.Name = "colFile"
        Me.colFile.Width = 79
        '
        'colLastModified
        '
        Me.colLastModified.HeaderText = "Last Modified"
        Me.colLastModified.Name = "colLastModified"
        Me.colLastModified.Width = 95
        '
        'colCreated
        '
        Me.colCreated.HeaderText = "Created"
        Me.colCreated.Name = "colCreated"
        Me.colCreated.Width = 69
        '
        'colSize
        '
        Me.colSize.HeaderText = "File Size"
        Me.colSize.Name = "colSize"
        Me.colSize.Width = 71
        '
        'txtSearchPath
        '
        Me.txtSearchPath.Location = New System.Drawing.Point(18, 42)
        Me.txtSearchPath.Name = "txtSearchPath"
        Me.txtSearchPath.Size = New System.Drawing.Size(344, 20)
        Me.txtSearchPath.TabIndex = 1
        Me.txtSearchPath.Text = "C:\"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Select search path"
        '
        'btnSearchPath
        '
        Me.btnSearchPath.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearchPath.Location = New System.Drawing.Point(368, 39)
        Me.btnSearchPath.Name = "btnSearchPath"
        Me.btnSearchPath.Size = New System.Drawing.Size(33, 23)
        Me.btnSearchPath.TabIndex = 3
        Me.btnSearchPath.Text = "..."
        Me.btnSearchPath.UseVisualStyleBackColor = True
        '
        'chkRecursiveSearch
        '
        Me.chkRecursiveSearch.AutoSize = True
        Me.chkRecursiveSearch.Checked = True
        Me.chkRecursiveSearch.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkRecursiveSearch.Location = New System.Drawing.Point(18, 74)
        Me.chkRecursiveSearch.Name = "chkRecursiveSearch"
        Me.chkRecursiveSearch.Size = New System.Drawing.Size(167, 17)
        Me.chkRecursiveSearch.TabIndex = 4
        Me.chkRecursiveSearch.Text = "Recursively search directories"
        Me.chkRecursiveSearch.UseVisualStyleBackColor = True
        '
        'dgvBrowseFileTypes
        '
        Me.dgvBrowseFileTypes.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvBrowseFileTypes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvBrowseFileTypes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colCheck, Me.colFileType})
        Me.dgvBrowseFileTypes.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.dgvBrowseFileTypes.Location = New System.Drawing.Point(448, 40)
        Me.dgvBrowseFileTypes.Name = "dgvBrowseFileTypes"
        Me.dgvBrowseFileTypes.RowHeadersVisible = False
        Me.dgvBrowseFileTypes.Size = New System.Drawing.Size(231, 163)
        Me.dgvBrowseFileTypes.TabIndex = 6
        '
        'colCheck
        '
        Me.colCheck.HeaderText = "Select"
        Me.colCheck.Name = "colCheck"
        Me.colCheck.Width = 50
        '
        'colFileType
        '
        Me.colFileType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colFileType.HeaderText = "File Types"
        Me.colFileType.Name = "colFileType"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(709, 24)
        Me.MenuStrip1.TabIndex = 8
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator1, Me.ExitToolStripMenuItem1})
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.ExitToolStripMenuItem.Text = "&File"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(89, 6)
        '
        'ExitToolStripMenuItem1
        '
        Me.ExitToolStripMenuItem1.Name = "ExitToolStripMenuItem1"
        Me.ExitToolStripMenuItem1.Size = New System.Drawing.Size(92, 22)
        Me.ExitToolStripMenuItem1.Text = "&Exit"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.chkSelectAll)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.btnBeginSearch)
        Me.GroupBox1.Controls.Add(Me.txtSearchPath)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.chkRecursiveSearch)
        Me.GroupBox1.Controls.Add(Me.dgvBrowseFileTypes)
        Me.GroupBox1.Controls.Add(Me.btnSearchPath)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 39)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(685, 224)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Define Criteria"
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(445, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Select File Types"
        '
        'btnBeginSearch
        '
        Me.btnBeginSearch.Location = New System.Drawing.Point(287, 70)
        Me.btnBeginSearch.Name = "btnBeginSearch"
        Me.btnBeginSearch.Size = New System.Drawing.Size(75, 23)
        Me.btnBeginSearch.TabIndex = 7
        Me.btnBeginSearch.Text = "Search"
        Me.btnBeginSearch.UseVisualStyleBackColor = True
        '
        'btnApply
        '
        Me.btnApply.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnApply.Location = New System.Drawing.Point(579, 662)
        Me.btnApply.Name = "btnApply"
        Me.btnApply.Size = New System.Drawing.Size(118, 23)
        Me.btnApply.TabIndex = 10
        Me.btnApply.Text = "Apply Selected"
        Me.btnApply.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClose.Location = New System.Drawing.Point(455, 662)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(118, 23)
        Me.btnClose.TabIndex = 11
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'chkSelectAll
        '
        Me.chkSelectAll.AutoSize = True
        Me.chkSelectAll.Checked = True
        Me.chkSelectAll.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkSelectAll.Location = New System.Drawing.Point(609, 23)
        Me.chkSelectAll.Name = "chkSelectAll"
        Me.chkSelectAll.Size = New System.Drawing.Size(70, 17)
        Me.chkSelectAll.TabIndex = 9
        Me.chkSelectAll.Text = "Select All"
        Me.chkSelectAll.UseVisualStyleBackColor = True
        '
        'BrowseFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(709, 691)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnApply)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.dgvFileList)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(725, 729)
        Me.Name = "BrowseFrm"
        Me.Text = "Search For Files"
        CType(Me.dgvFileList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvBrowseFileTypes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvFileList As DataGridView
	Friend WithEvents txtSearchPath As TextBox
	Friend WithEvents Label1 As Label
	Friend WithEvents btnSearchPath As Button
	Friend WithEvents chkRecursiveSearch As CheckBox
	Friend WithEvents dgvBrowseFileTypes As DataGridView
	Friend WithEvents colCheck As DataGridViewCheckBoxColumn
	Friend WithEvents colFileType As DataGridViewTextBoxColumn
	Friend WithEvents MenuStrip1 As MenuStrip
	Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
	Friend WithEvents ExitToolStripMenuItem1 As ToolStripMenuItem
	Friend WithEvents GroupBox1 As GroupBox
	Friend WithEvents btnBeginSearch As Button
	Friend WithEvents Label2 As Label
	Friend WithEvents btnApply As Button
	Friend WithEvents btnClose As Button
	Friend WithEvents colSelect As DataGridViewCheckBoxColumn
	Friend WithEvents colPath As DataGridViewTextBoxColumn
	Friend WithEvents colFile As DataGridViewTextBoxColumn
	Friend WithEvents colLastModified As DataGridViewTextBoxColumn
	Friend WithEvents colCreated As DataGridViewTextBoxColumn
    Friend WithEvents colSize As DataGridViewTextBoxColumn
    Friend WithEvents chkSelectAll As CheckBox
End Class
