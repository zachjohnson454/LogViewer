Option Strict On
Imports System.Drawing.Text

Public Class Options

    Private Function ReturnColor() As Color
        Dim SelectedColor As Color
        Using cDialog As New ColorDialog
            With cDialog
                .FullOpen = True
                If .ShowDialog = DialogResult.OK Then
                    SelectedColor = cDialog.Color
                End If
            End With
        End Using
        Return SelectedColor
    End Function


    Private Sub trvOptions_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles trvOptions.AfterSelect
        Select Case e.Node.Text
            Case "Fonts"
                pnlFonts.BringToFront()
            Case "Startup"
                pnlStartup.BringToFront()
            Case "Locations"
                pnlLocations.BringToFront()
            Case "File Types"
                pnlFileTypes.BringToFront()
        End Select
    End Sub

    Private Sub CloseForm(sender As Object, e As EventArgs) Handles btnCancel.Click, btnOk.Click
        Me.Close()
    End Sub

    Private Sub Options_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.Size = New Size(663, 589)
        Me.MinimumSize = New Size(656, 589)
        Me.MaximumSize = New Size(907, 589)
        Me.trvOptions.ExpandAll()
        Me.pnlStartup.BringToFront()

        RearrangePanels()
        LoadUserSettings()
    End Sub

    Private Sub LoadUserSettings()
        LoadOpenFilesList()
        LoadHightLightWordList()
        LoadFileTypeList()
        LoadFontFamilies()
        LoadFontSizes()
    End Sub

    Private Sub RearrangePanels()
        For Each cntrl As Control In Me.Controls
            If TypeOf (cntrl) Is Panel Then
                cntrl.Location = New Point(200, 12)
                cntrl.Size = New Size(435, 488)
                cntrl.Anchor = AnchorStyles.Left Or AnchorStyles.Top Or AnchorStyles.Right Or AnchorStyles.Bottom
            End If
        Next
    End Sub

    Private Sub LoadOpenFilesList()
        With dgvOpenFiles
            .Rows.Clear()
            For i As Integer = 0 To My.Settings.ShowFilesOnStartUp.Count - 1
                If My.Settings.ShowFilesOnStartUp(i) = String.Empty Then Exit For
                .Rows.Add(1)
                .Item(0, i).Value = My.Settings.ShowFilesOnStartUpCheck(i)
                .Item(1, i).Value = My.Settings.ShowFilesOnStartUp(i)
            Next
        End With
    End Sub

    Private Sub LoadHightLightWordList()
        With dgvHighLightWord
            .Rows.Clear()
            For i As Integer = 0 To My.Settings.HighLightWords.Count - 1
                If My.Settings.HighLightWords(i) = String.Empty Then Exit For
                .Rows.Add(1)
                .Item(0, i).Value = My.Settings.HighLightWords(i)
                .Item(1, i).Style.BackColor = Color.FromArgb(CInt(My.Settings.HighLightWordsColors(i)))
                .Item(2, i).Value = My.Settings.HighLightWordsFontStyle(i)
            Next
        End With
    End Sub

    Private Sub LoadFileTypeList()
        With dgvFileTypes
            .Rows.Clear()
            For i As Integer = 0 To My.Settings.FileTypes.Count - 1
                If My.Settings.FileTypes(i) = String.Empty Then Exit For
                .Rows.Add(1)
                .Item(0, i).Value = My.Settings.FileTypes(i)
            Next
        End With
    End Sub

    Private Sub LoadFontFamilies()
        Dim fonts As New InstalledFontCollection
        For Each val As FontFamily In fonts.Families
            cboLineNumberFont.Items.Add(val.Name)
            cboTextFont.Items.Add(val.Name)
        Next
    End Sub

    Private Sub LoadFontSizes()
        For i As Double = 6 To 20 Step 0.5
            cboTextFontSize.Items.Add(i)
            cboLineNumberFontSize.Items.Add(i)
        Next
    End Sub

    Private Sub dgvOpenFiles_Validated(sender As Object, e As EventArgs) Handles dgvOpenFiles.Validated
        SaveOpenFilesList()
    End Sub

    Private Sub SaveOpenFilesList()
        With My.Settings
            .ShowFilesOnStartUp.Clear()
            .ShowFilesOnStartUpCheck.Clear()
            For i As Integer = 0 To dgvOpenFiles.RowCount - 2
                .ShowFilesOnStartUpCheck.Add(dgvOpenFiles.Rows(i).Cells(0).Value.ToString)
                .ShowFilesOnStartUp.Add(dgvOpenFiles.Rows(i).Cells(1).Value.ToString)
            Next
        End With
    End Sub

    Private Sub btnDefaultSavedCopy_Click(sender As Object, e As EventArgs) Handles btnDefaultSavedCopy.Click
        txtDefaultSavedCopy.Text = ReturnFolderPath()
    End Sub

    Private Sub ChangeBackColor(sender As Object, e As EventArgs) Handles pnlLineBackColor.Click, pnlTextBackColor.Click
        Dim currentPanel As Panel = DirectCast(sender, Panel)
        currentPanel.BackColor = ReturnColor()
    End Sub

    Private Sub pnlLineNumberFontColor_Click(sender As Object, e As EventArgs) Handles pnlLineNumberFontColor.Click
        pnlLineNumberFontColor.BackColor = ReturnColor()
        lblLineNumberFont.ForeColor = pnlLineNumberFontColor.BackColor
    End Sub

    Private Sub pnlTextFontColor_Click(sender As Object, e As EventArgs) Handles pnlTextFontColor.Click
        pnlTextFontColor.BackColor = ReturnColor()
        lblTextFont.ForeColor = pnlTextFontColor.BackColor
    End Sub

    Private Sub cboLineNumberFont_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboLineNumberFont.SelectedIndexChanged
        If My.Settings.LockFont Then
            cboTextFont.Text = cboLineNumberFont.Text
        End If
        lblLineNumberFont.Font = New Font(cboLineNumberFont.Text, CSng(cboLineNumberFontSize.Text))
    End Sub

    Private Sub cboTextFont_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboTextFont.SelectedIndexChanged
        If My.Settings.LockFont Then
            cboLineNumberFont.Text = cboTextFont.Text
        End If
        lblTextFont.Font = New Font(cboTextFont.Text, CSng(cboTextFontSize.Text))
    End Sub

    Private Sub cboTextFontSize_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboTextFontSize.SelectedIndexChanged
        If My.Settings.LockFontSizes Then
            cboLineNumberFontSize.Text = cboTextFontSize.Text
        End If
        lblTextFont.Font = New Font(cboTextFont.Text, CSng(cboTextFontSize.Text))
    End Sub

    Private Sub cboLineNumberFontSize_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles cboLineNumberFontSize.SelectedIndexChanged
        If My.Settings.LockFontSizes Then
            cboTextFontSize.Text = cboLineNumberFontSize.Text
        End If
        lblLineNumberFont.Font = New Font(cboLineNumberFont.Text, CSng(cboLineNumberFontSize.Text))
    End Sub

    Private Sub dgvHighLightWord_Validated(sender As Object, e As EventArgs) Handles dgvHighLightWord.Validated
        SaveHighLightWordList()
    End Sub

    Private Sub SaveHighLightWordList()
        With My.Settings
            .HighLightWords.Clear()
            .HighLightWordsColors.Clear()
            .HighLightWordsFontStyle.Clear()
            For i As Integer = 0 To dgvHighLightWord.RowCount - 2
                .HighLightWords.Add(dgvHighLightWord.Rows(i).Cells(0).Value.ToString)
                .HighLightWordsColors.Add(dgvHighLightWord.Rows(i).Cells(1).Style.BackColor.ToArgb.ToString)
                .HighLightWordsFontStyle.Add(dgvHighLightWord.Rows(i).Cells(2).Value.ToString)
            Next
        End With
    End Sub

    Private Sub dgvHighLightWord_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvHighLightWord.CellMouseClick
        If e.ColumnIndex = 1 Then
            Using cDialog As New ColorDialog
                With cDialog
                    .AllowFullOpen = True
                    If .ShowDialog = DialogResult.OK Then
                        dgvHighLightWord.CurrentCell.Style.BackColor = Color.FromArgb(cDialog.Color.ToArgb)
                    End If
                End With
            End Using

            dgvHighLightWord.CurrentCell = dgvHighLightWord(e.ColumnIndex + 1, e.RowIndex)
        ElseIf e.ColumnIndex = 2 Then
        End If
    End Sub

    Private Sub btnRestoreDefaults_Click(sender As Object, e As EventArgs) Handles btnRestoreDefaults.Click
        If MessageBox.Show("Are you sure you want to reset all options to default values?", "Reset to Default", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            My.Settings.Reset()
        End If
    End Sub

    Private Sub dgvOpenFiles_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvOpenFiles.CellDoubleClick
        Dim filePath As String = dgvOpenFiles.Rows(e.RowIndex).Cells(1).FormattedValue.ToString
        OpenExternally(filePath)
    End Sub

    Private Sub lblAddMoreFiles_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lblAddMoreFiles.LinkClicked
        Using BrowseFiles As New BrowseFrm
            BrowseFiles.ShowDialog()
        End Using
    End Sub

    Private Sub dgvFileTypes_Validated(sender As Object, e As EventArgs) Handles dgvFileTypes.Validated
        With My.Settings
            .FileTypes.Clear()
            For i As Integer = 0 To dgvFileTypes.RowCount - 2
                .FileTypes.Add(dgvFileTypes.Rows(i).Cells(0).Value.ToString)
            Next
        End With
    End Sub
End Class