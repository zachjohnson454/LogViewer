<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class StatusBarUser
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.StatusStrip2 = New System.Windows.Forms.StatusStrip()
        Me.tssTotalLines = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tssTotalTextLength = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel3 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tssCurrentLinePosition = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel4 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tssCurrentTextLength = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel5 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tssCurrentColumnPosition = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel6 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel7 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tssSelectedTextLength = New System.Windows.Forms.ToolStripStatusLabel()
        Me.StatusStrip2.SuspendLayout()
        Me.SuspendLayout()
        '
        'StatusStrip2
        '
        Me.StatusStrip2.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.StatusStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.tssTotalLines, Me.ToolStripStatusLabel2, Me.tssTotalTextLength, Me.ToolStripStatusLabel3, Me.ToolStripStatusLabel4, Me.tssCurrentLinePosition, Me.ToolStripStatusLabel6, Me.tssCurrentColumnPosition, Me.ToolStripStatusLabel5, Me.tssCurrentTextLength, Me.ToolStripStatusLabel7, Me.tssSelectedTextLength})
        Me.StatusStrip2.Location = New System.Drawing.Point(0, 0)
        Me.StatusStrip2.Name = "StatusStrip2"
        Me.StatusStrip2.Size = New System.Drawing.Size(1077, 22)
        Me.StatusStrip2.SizingGrip = False
        Me.StatusStrip2.TabIndex = 1
        Me.StatusStrip2.Text = "StatusStrip2"
        '
        'tssTotalLines
        '
        Me.tssTotalLines.Name = "tssTotalLines"
        Me.tssTotalLines.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
        Me.tssTotalLines.Size = New System.Drawing.Size(35, 17)
        Me.tssTotalLines.Text = "[]"
        Me.tssTotalLines.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tssTotalTextLength
        '
        Me.tssTotalTextLength.Name = "tssTotalTextLength"
        Me.tssTotalTextLength.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
        Me.tssTotalTextLength.Size = New System.Drawing.Size(35, 17)
        Me.tssTotalTextLength.Text = "[]"
        Me.tssTotalTextLength.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(71, 17)
        Me.ToolStripStatusLabel1.Text = "Total Lines :"
        Me.ToolStripStatusLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(110, 17)
        Me.ToolStripStatusLabel2.Text = "Total Text Length :"
        Me.ToolStripStatusLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ToolStripStatusLabel3
        '
        Me.ToolStripStatusLabel3.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ToolStripStatusLabel3.Name = "ToolStripStatusLabel3"
        Me.ToolStripStatusLabel3.Size = New System.Drawing.Size(25, 17)
        Me.ToolStripStatusLabel3.Text = "  ||  "
        '
        'tssCurrentLinePosition
        '
        Me.tssCurrentLinePosition.Name = "tssCurrentLinePosition"
        Me.tssCurrentLinePosition.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
        Me.tssCurrentLinePosition.Size = New System.Drawing.Size(35, 17)
        Me.tssCurrentLinePosition.Text = "[]"
        Me.tssCurrentLinePosition.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ToolStripStatusLabel4
        '
        Me.ToolStripStatusLabel4.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ToolStripStatusLabel4.ForeColor = System.Drawing.Color.Blue
        Me.ToolStripStatusLabel4.Name = "ToolStripStatusLabel4"
        Me.ToolStripStatusLabel4.Size = New System.Drawing.Size(132, 17)
        Me.ToolStripStatusLabel4.Text = "Current Line Position : "
        '
        'tssCurrentTextLength
        '
        Me.tssCurrentTextLength.Name = "tssCurrentTextLength"
        Me.tssCurrentTextLength.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
        Me.tssCurrentTextLength.Size = New System.Drawing.Size(35, 17)
        Me.tssCurrentTextLength.Text = "[]"
        Me.tssCurrentTextLength.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ToolStripStatusLabel5
        '
        Me.ToolStripStatusLabel5.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ToolStripStatusLabel5.ForeColor = System.Drawing.Color.Blue
        Me.ToolStripStatusLabel5.Name = "ToolStripStatusLabel5"
        Me.ToolStripStatusLabel5.Size = New System.Drawing.Size(126, 17)
        Me.ToolStripStatusLabel5.Text = "Current Text Length :"
        '
        'tssCurrentColumnPosition
        '
        Me.tssCurrentColumnPosition.Name = "tssCurrentColumnPosition"
        Me.tssCurrentColumnPosition.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
        Me.tssCurrentColumnPosition.Size = New System.Drawing.Size(35, 17)
        Me.tssCurrentColumnPosition.Text = "[]"
        Me.tssCurrentColumnPosition.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ToolStripStatusLabel6
        '
        Me.ToolStripStatusLabel6.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ToolStripStatusLabel6.ForeColor = System.Drawing.Color.Blue
        Me.ToolStripStatusLabel6.Name = "ToolStripStatusLabel6"
        Me.ToolStripStatusLabel6.Size = New System.Drawing.Size(148, 17)
        Me.ToolStripStatusLabel6.Text = "Current Column Position :"
        '
        'ToolStripStatusLabel7
        '
        Me.ToolStripStatusLabel7.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ToolStripStatusLabel7.ForeColor = System.Drawing.Color.Blue
        Me.ToolStripStatusLabel7.Name = "ToolStripStatusLabel7"
        Me.ToolStripStatusLabel7.Size = New System.Drawing.Size(132, 17)
        Me.ToolStripStatusLabel7.Text = "Selected Text Length :"
        '
        'tssSelectedTextLength
        '
        Me.tssSelectedTextLength.Name = "tssSelectedTextLength"
        Me.tssSelectedTextLength.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
        Me.tssSelectedTextLength.Size = New System.Drawing.Size(35, 17)
        Me.tssSelectedTextLength.Text = "[]"
        Me.tssSelectedTextLength.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'StatusBarUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.StatusStrip2)
        Me.Name = "StatusBarUser"
        Me.Size = New System.Drawing.Size(1077, 22)
        Me.StatusStrip2.ResumeLayout(False)
        Me.StatusStrip2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents StatusStrip2 As StatusStrip
    Friend WithEvents tssTotalLines As ToolStripStatusLabel
    Friend WithEvents tssTotalTextLength As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel2 As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel3 As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel4 As ToolStripStatusLabel
    Friend WithEvents tssCurrentLinePosition As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel5 As ToolStripStatusLabel
    Friend WithEvents tssCurrentTextLength As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel6 As ToolStripStatusLabel
    Friend WithEvents tssCurrentColumnPosition As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel7 As ToolStripStatusLabel
    Friend WithEvents tssSelectedTextLength As ToolStripStatusLabel
End Class
