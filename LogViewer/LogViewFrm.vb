Option Strict On
Imports System.Drawing.Printing
Imports System.IO

Public Class LogViewFrm
	Dim m_fileTabs As New Dictionary(Of String, FileTab)

	Private Function SelectedTab() As FileTab
		Return m_fileTabs(TabControl1.SelectedTab.Name)
	End Function

	Private Function CheckIfOpen(path As String) As Boolean
		Dim ReturnVal As Boolean = False
		If path <> Nothing Then
            For Each tabKey In m_fileTabs
                If tabKey.Key = path Then
                    ReturnVal = True
                End If
            Next
        End If
		Return ReturnVal
	End Function

	Private Function ReturnPath(path As String) As String
        If path Is Nothing Then
            path = GetLogFilePath()
        End If

        If Not CheckIfOpen(path) Then
			Return path
		Else
			MessageBox.Show("File is already open", "Duplicate", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
		End If
		Return Nothing
	End Function

    Private Sub OpenDialog(Optional FilePath As String = Nothing)
        Dim logFilePath As String = ReturnPath(FilePath)
        If logFilePath Is Nothing Then Exit Sub

        Dim newFileTab As New FileTab(TabControl1, logFilePath)
        With newFileTab
            .EnableFileMonitor = My.Settings.FileMonitor
            .EnableAutoHighLight = My.Settings.AutoHighlight

            .CreateTab()
            .ScrollToEnd()
        End With

        m_fileTabs.Add(logFilePath, newFileTab)
    End Sub

    Private Sub SelectLastTab()
		If TabControl1.TabPages.Count > 0 Then
			TabControl1.SelectedTab = TabControl1.TabPages(TabControl1.TabPages.Count - 1)
		End If
	End Sub

	Private Sub QuickSearch(val As Boolean)
		If val Then
			ShowSearchFilterToolStripMenuItem.Checked = True
			SplitContainer1.Panel2Collapsed = False
		Else
			ShowSearchFilterToolStripMenuItem.Checked = False
			SplitContainer1.Panel2Collapsed = True
		End If
	End Sub

	Private Sub LogViewFrm_Load(sender As Object, e As EventArgs) Handles Me.Load
		'Load all start environment settings
		With My.Settings
			If Not .ShowStartTab Then
				TabControl1.Controls.RemoveByKey("StartUp")
			End If

			'Fill Dropbox (need before next procedure)
			LoadDropDowns(cboSearch)
			LoadDropDowns(cboFilter)

			For i As Integer = 0 To .ShowFilesOnStartUp.Count - 1
				tsscboQuickLoad.Items.Add(.ShowFilesOnStartUp(i))

				If CBool(.ShowFilesOnStartUpCheck(i)) Then
					If Not CheckIfOpen(.ShowFilesOnStartUp(i)) Then
						OpenDialog(.ShowFilesOnStartUp(i))
					End If
				End If
			Next

			'WindowState
			If .WindowStateDefault Then Me.WindowState = FormWindowState.Normal
			If .WindowStateMax Then Me.WindowState = FormWindowState.Maximized
			If .WindowStateMin Then Me.WindowState = FormWindowState.Minimized

			'Show/Hide QuickSearch
			QuickSearch(.ShowQuickSearch)
		End With
	End Sub

	Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
		If m_fileTabs.ContainsKey(TabControl1.SelectedTab.Name) Then
			SelectedTab.ResetTextFormat()
		End If
	End Sub

	Private Sub cboFilter_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboFilter.SelectedIndexChanged
		chkRemoveBlankLines.Checked = False
	End Sub

	Private Sub btnResetFilter_Click(sender As Object, e As EventArgs) Handles btnResetFilter.Click
		If m_fileTabs.ContainsKey(TabControl1.SelectedTab.Name) Then
			cboFilter.Text = String.Empty
			chkRemoveBlankLines.Checked = False
			SelectedTab.Reload()
		End If
	End Sub

	Private Sub tsbReload_Click(sender As Object, e As EventArgs) Handles tsbReload.Click, btnApplyFilter.Click
		SelectedTab.Reload()
	End Sub

	Private Sub SearchForFilesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SearchForFilesToolStripMenuItem.Click
		BrowseFrm.Show()
	End Sub

	Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
		Me.Close()
	End Sub

	Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem.Click, OpenToolStripButton.Click
		OpenDialog()
	End Sub

	Private Sub OpenFileToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles OpenFileToolStripMenuItem1.Click
        OpenExternally(CStr(TabControl1.SelectedTab.Name))
    End Sub

    Private Sub tsscboQuickLoad_SelectedIndexChanged(sender As Object, e As EventArgs) Handles tsscboQuickLoad.SelectedIndexChanged
        Dim cbo = DirectCast(sender, ToolStripComboBox)
        OpenDialog(cbo.Text)
    End Sub

    Private Sub SdfToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SdfToolStripMenuItem.Click
        Try
            Process.Start("mmc.exe", "eventvwr.msc")
        Catch filenotfound As FileNotFoundException
            MsgBox("mmc.exe eventvwr.msc -  could not be found")
        End Try
    End Sub

    Private Sub AboutToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem1.Click
        Dim about As New AboutBox1
        about.Show()
    End Sub

    Private Sub ShowSearchFilterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ShowSearchFilterToolStripMenuItem.Click
        Dim mnuItem As ToolStripMenuItem = DirectCast(sender, ToolStripMenuItem)
        QuickSearch(mnuItem.Checked)
    End Sub

    Private Sub SaveACopy(sender As Object, e As EventArgs) Handles SaveAsToolStripMenuItem1.Click, SaveToolStripButton.Click
        SelectedTab.SaveACopy()
        MsgBox("A copy has been saved.")
    End Sub



    Private Sub CloseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseToolStripMenuItem.Click
        Dim tab As TabPage = TabControl1.SelectedTab
        If m_fileTabs.ContainsKey(TabControl1.SelectedTab.Name) Then
            TabControl1.Controls.Remove(TabControl1.SelectedTab)
            m_fileTabs.Remove(tab.Name)
            SelectLastTab()
        Else
            TabControl1.Controls.Remove(TabControl1.SelectedTab)
        End If
    End Sub

    Private Sub CloseAllToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseAllToolStripMenuItem.Click
        For Each tab As TabPage In TabControl1.TabPages
            If Not tab.Name = "StartUp" Then
                TabControl1.Controls.Remove(tab)
                m_fileTabs.Remove(tab.Name)
            End If
        Next
        SelectLastTab()
    End Sub

    Private Sub FileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FileToolStripMenuItem.Click
        Try
            If TabControl1.SelectedTab.Name <> "StartUp" Then
                SaveAsToolStripMenuItem.Enabled = True
            Else
                SaveAsToolStripMenuItem.Enabled = False
            End If
        Catch
            SaveAsToolStripMenuItem.Enabled = False
        End Try
    End Sub

    Private Sub OptionsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OptionsToolStripMenuItem.Click, LinkLabel1.LinkClicked
        Dim optFrm As New Options
        Options.ShowDialog()
        LoadDropDowns(cboFilter)
        LoadDropDowns(cboSearch)
    End Sub

    Private Sub cboSearch_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboSearch.SelectedIndexChanged
        If m_fileTabs.ContainsKey(TabControl1.SelectedTab.Name) Then
            SelectedTab.HighLightWord(cboSearch.Text)
        End If
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        If m_fileTabs.ContainsKey(TabControl1.SelectedTab.Name) Then
            SelectedTab.HighLightWord(cboSearch.Text)
        End If
    End Sub

    Private Sub TabControl1_MouseDown(sender As Object, e As MouseEventArgs) Handles TabControl1.MouseDown
        Dim toolStripItem As ToolStripItem
        If TabControl1.SelectedTab.Name = "StartUp" Then
            If e.Button = MouseButtons.Right Then
                SaveToolStripButton.Enabled = False
                tsbReload.Enabled = False
                For Each toolStripItem In ContextMenuStrip1.Items
                    If toolStripItem.Text <> "Close" Then
                        toolStripItem.Enabled = False
                    End If
                Next
            Else
                Exit Sub
            End If
        Else
            SaveToolStripButton.Enabled = True
            tsbReload.Enabled = True
            For Each toolStripItem In ContextMenuStrip1.Items
                toolStripItem.Enabled = True
            Next
            If e.Button = MouseButtons.Left Then
                If My.Settings.AutoReloadFile Then
                    SelectedTab.Reload()
                End If
            End If
        End If
    End Sub

    Private Sub OpenFile(sender As Object, e As EventArgs) Handles OpenFileToolStripMenuItem.Click
        Dim filePath As String = GetLogFilePath()
        If filePath Is Nothing Then Exit Sub
        OpenExternally(filePath)
    End Sub

    Shared Function GetMatchType() As RichTextBoxFinds
        Dim ReturnVal As RichTextBoxFinds = RichTextBoxFinds.WholeWord
        If LogViewFrm.rdoMatchAny.Checked Then ReturnVal = RichTextBoxFinds.None
        If LogViewFrm.rdoMatchWhole.Checked Then ReturnVal = RichTextBoxFinds.WholeWord
        If LogViewFrm.rdoMatchCase.Checked Then ReturnVal = RichTextBoxFinds.MatchCase
        Return ReturnVal
    End Function
End Class
