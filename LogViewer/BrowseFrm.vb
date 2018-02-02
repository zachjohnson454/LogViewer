Option Strict On
Imports System.IO

Public Class BrowseFrm
	Dim m_extensionColl As New Collection
    Dim m_checkBoxCell As DataGridViewCell
    Dim m_fileNameCell As DataGridViewCell
    Dim m_filePathCell As DataGridViewCell

    Private Sub BrowseFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadFileTypes()
    End Sub

    Private Sub btnSearchPath_Click(sender As Object, e As EventArgs) Handles btnSearchPath.Click
        txtSearchPath.Text = ReturnFolderPath()
    End Sub

    Private Sub ExitToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem1.Click
        Me.Close()
    End Sub

    Private Sub btnBeginSearch_Click(sender As Object, e As EventArgs) Handles btnBeginSearch.Click
        GetList()
    End Sub

    Private Sub dgvBrowse_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvFileList.CellDoubleClick
        Dim SelectedPath As String = ReturnFilePath(dgvFileList.Rows(e.RowIndex).Cells(1).FormattedValue.ToString, dgvFileList.Rows(e.RowIndex).Cells(2).FormattedValue.ToString)
        OpenExternally(SelectedPath)
    End Sub

    Private Function ReturnFilePath(path As String, fileName As String) As String
        Return ReturnPathWithSlash(path) & fileName
    End Function

    Private Sub btnApply_Click(sender As Object, e As EventArgs) Handles btnApply.Click
        AddSelectedFiles()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub AddSelectedFiles()
        For i As Integer = 0 To dgvFileList.RowCount - 1
            m_checkBoxCell = dgvFileList.Rows(i).Cells(0)
            m_filePathCell = dgvFileList.Rows(i).Cells(1)
            m_fileNameCell = dgvFileList.Rows(i).Cells(2)
            If CBool(m_checkBoxCell.Value) Then
                My.Settings.ShowFilesOnStartUpCheck.Add(m_checkBoxCell.Value.ToString)
                My.Settings.ShowFilesOnStartUp.Add(ReturnPathWithSlash(m_filePathCell.FormattedValue.ToString) & m_fileNameCell.FormattedValue.ToString)
            End If
        Next
    End Sub

    Public Shared Function ReturnPathWithSlash(path As String) As String
        Dim lastChar As String = path.Substring(path.Length - 1)
        If lastChar = "\" Then
            Return path
        Else
            Return path & "\"
        End If
    End Function

    Private Sub LoadFileTypes()
        Dim fileType As String

        dgvFileList.Rows.Clear()
        With dgvBrowseFileTypes
            For i As Integer = 0 To My.Settings.FileTypes.Count - 1
                fileType = My.Settings.FileTypes(i)
                If fileType = String.Empty Then Exit For
                .Rows.Add(1)
                .Item(0, i).Value = chkSelectAll.Checked
                .Item(1, i).Value = fileType
            Next
        End With
    End Sub

    Private Sub GetList()
        Dim baseFolder As New DirectoryInfo(txtSearchPath.Text)
        m_extensionColl.Clear()
        With dgvBrowseFileTypes
            dgvFileList.Rows.Clear()
            For i As Integer = 0 To .RowCount - 1
                m_checkBoxCell = .Rows(i).Cells(0)
                m_fileNameCell = .Rows(i).Cells(1)
                If CBool(m_checkBoxCell.Value) Then
                    m_extensionColl.Add(i, ReturnExtension(m_fileNameCell.Value.ToString))
                End If
            Next
		End With
		GetFileList(baseFolder)
	End Sub

	Private Function ReturnExtension(value As String) As String
        Return Path.GetExtension(value.Replace(")", ""))
    End Function

	Private Sub GetFileList(currentDirectory As DirectoryInfo)
		Try
			For Each file As FileInfo In currentDirectory.GetFiles
                If m_extensionColl.Contains(ReturnExtension(file.Name)) Then
                    With dgvFileList
                        .Rows.Add(1)
                        .Item(1, .RowCount - 2).Value = file.Directory
                        .Item(2, .RowCount - 2).Value = file.Name
                        .Item(3, .RowCount - 2).Value = file.LastWriteTime
                        .Item(4, .RowCount - 2).Value = file.CreationTime
                        .Item(5, .RowCount - 2).Value = CDbl(Math.Round(file.Length / 1024, 0)) & " KB"
                    End With
                End If
            Next

			If chkRecursiveSearch.Checked Then
				For Each directory As DirectoryInfo In currentDirectory.GetDirectories
					GetFileList(directory)
				Next
			End If
		Catch
		End Try
	End Sub



    Private Function HasValue(value As String) As Boolean
        Return CBool(value)
    End Function

    Private Sub chkSelectAll_CheckedChanged(sender As Object, e As EventArgs) Handles chkSelectAll.CheckedChanged
        If chkSelectAll.Checked Then
            SelectAll()
        Else
            DeselectAll()
        End If
    End Sub

    Private Sub DeselectAll()
        For i As Integer = 0 To dgvBrowseFileTypes.RowCount - 1
            dgvBrowseFileTypes.Item(0, i).Value = "False"
        Next
    End Sub

    Private Sub SelectAll()
        For i As Integer = 0 To dgvBrowseFileTypes.RowCount - 2
            dgvBrowseFileTypes.Item(0, i).Value = "True"
        Next
    End Sub
End Class