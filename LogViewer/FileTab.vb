Option Strict On
Imports System.IO

Public Class FileTab
	Private m_tbcTabControl As TabControl
	Private m_tbThisTab As TabPage
	Private m_sptMainSplit As SplitContainer
	Private m_rtbLineNumber As RichTextBox
	Private m_rtbText As RichTextBox
	Private m_pnlWatcher As Panel
	Private m_pnlStatusBar As StatusBarUser
	Private m_fswFileWatcher As FileSystemWatcher
	Private m_fileStream As TextStream
    Private m_enableMonitor As Boolean
    Private m_enableAutoHighLight As Boolean
    Private m_hideWatcher As Boolean
	Private m_tabNumber As Integer
	Private m_name As String
	Private m_documentPath As String


	Public Property EnableFileMonitor As Boolean
		Get
			Return m_enableMonitor
		End Get
		Set(value As Boolean)
			m_enableMonitor = value
			If Not m_fswFileWatcher Is Nothing Then
				If value Then
					m_fswFileWatcher.EnableRaisingEvents = True
				Else
					m_fswFileWatcher.EnableRaisingEvents = False
				End If
			End If
		End Set
	End Property

	Public Property HideWatcher As Boolean
		Get
			Return m_hideWatcher
		End Get
		Set(value As Boolean)
			If value Then
				HideWatcherPanel()
			Else
				ShowWatcherPanel()
			End If
		End Set
	End Property

	Public Property TabNumber As Integer
		Get
			Return m_tabNumber
		End Get
		Set(value As Integer)
			m_tabNumber = value
		End Set
	End Property

	Public Property Name As String
		Get
			Return m_name
		End Get
		Set(value As String)
			m_name = value
		End Set
	End Property

	Public Property DocumentPath As String
		Get
			Return m_documentPath
		End Get
		Set(value As String)
			m_documentPath = value
		End Set
	End Property

    Public Property EnableAutoHighLight As Boolean
        Get
            Return m_enableAutoHighLight
        End Get
        Set(value As Boolean)
            m_enableAutoHighLight = value
        End Set
    End Property

    Public Sub New()
        'Leave blank
    End Sub

    Public Sub New(Cntrl As TabControl, filePath As String)
		m_tbcTabControl = Cntrl
		m_name = filePath
		m_documentPath = filePath
		m_enableMonitor = My.Settings.FileMonitor
		m_fileStream = New TextStream(filePath)
	End Sub


	Public Sub CreateTab()
        With m_tbcTabControl.TabPages
            Dim tabCount As Integer : tabCount = .Count
            .Add(CStr(tabCount + 1), m_documentPath)
            m_tbThisTab = .Item(tabCount)
            m_tbThisTab.Name = m_documentPath
            m_tbThisTab.Text = Path.GetFileName(m_documentPath)
            m_tabNumber = tabCount
            m_tbcTabControl.SelectedTab = m_tbThisTab
        End With

        AddControlsToNewTab()
        AutoHighLight()
        PopulateFileStats()
    End Sub

    Private Sub AutoHighLight()
        If m_enableAutoHighLight Then
            HighLightListOfWords(My.Settings.HighLightWords)
        End If
    End Sub

    Private Sub AddControlsToNewTab()
        AddSplitterPanel()
        AddMainTextBox()
        AddLineTextBox()
        AddStatsBar()

        If m_enableMonitor Then
            AddWatcher()
        End If
    End Sub

    Private Sub AddSplitterPanel()
		m_sptMainSplit = New SplitContainer
		With m_sptMainSplit
			.FixedPanel = FixedPanel.Panel1
			.Panel1MinSize = 27 + CInt(My.Settings.LineNumberFontSize)
			.SplitterDistance = 30
			.SplitterWidth = 3
			.Dock = DockStyle.Fill
		End With
		m_tbThisTab.Controls.Add(m_sptMainSplit)
	End Sub

	Private Sub AddMainTextBox()
		m_rtbText = New RichTextBox
		With m_rtbText
			.Dock = DockStyle.Fill
			.BorderStyle = BorderStyle.None
			.BackColor = My.Settings.TextBackColor
			.ForeColor = My.Settings.TextFontColor
			.Font = New Font(My.Settings.TextFontString, CSng(My.Settings.TextFontSize))
			.WordWrap = False
			.Text = LoadText()
            AddHandler m_rtbText.VScroll, AddressOf richTextBox_VScroll
            AddHandler m_rtbText.TextChanged, AddressOf richTextBox_TextChanged
            AddHandler m_rtbText.KeyUp, AddressOf richTextBox_TextChanged
            AddHandler m_rtbText.MouseUp, AddressOf richTextBox_TextChanged
        End With
		m_sptMainSplit.Panel2.Controls.Add(m_rtbText)
	End Sub

    Private Function LoadText() As String
        Return m_fileStream.ReadFileWithFilters()
    End Function

    Private Sub AddLineTextBox()
		m_rtbLineNumber = New RichTextBox
		With m_rtbLineNumber
			.ScrollBars = 0
			.Dock = DockStyle.Fill
			.BorderStyle = BorderStyle.None
			.BackColor = My.Settings.LineNumberBackColor
			.ForeColor = My.Settings.LineNumberFontColor
			.Font = New Font(My.Settings.LineNumberFontString, CSng(My.Settings.LineNumberFontSize))
            .Text = ReturnLineNumbers(m_fileStream.LineCount)
        End With
		m_sptMainSplit.Panel1.Controls.Add(m_rtbLineNumber)
	End Sub
    Private Function ReturnLineNumbers(lineCount As Long) As String
        Dim ReturnValue As String = String.Empty
        For i As Long = 1 To lineCount
            ReturnValue &= i & vbNewLine
        Next
        Return ReturnValue
    End Function

    Private Sub AddStatsBar()
		m_pnlStatusBar = New StatusBarUser
		With m_pnlStatusBar
            .Dock = DockStyle.Bottom
        End With
		m_rtbText.Controls.Add(m_pnlStatusBar)
	End Sub

	Private Sub AddWatcher()
		m_pnlWatcher = New Panel
		With m_pnlWatcher
			.BackColor = Color.FromArgb(255, 192, 128)
            .Size = New Size(m_tbThisTab.Width, 26)
            .Location = New Point(1, m_tbThisTab.Height - m_pnlWatcher.Height)
			.BorderStyle = BorderStyle.FixedSingle
			.Anchor = AnchorStyles.Left Or AnchorStyles.Bottom Or AnchorStyles.Right
			.Visible = False
		End With

		Dim newbtn As New Button
		With newbtn
			.Image = LogViewFrm.ImageList1.Images.Item(1)
			.BackColor = Color.Red
			.Size = New Size(16, 16)
            .Location = New Point(m_pnlWatcher.Width - (.Width + 2), 0)
            .Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
            AddHandler newbtn.Click, AddressOf HideWatcher_Click
			m_pnlWatcher.Controls.Add(newbtn)
		End With

		Dim newReloadbtn As New Button
		With newReloadbtn
			.Image = LogViewFrm.ImageList1.Images.Item(3)
			.BackColor = Color.Green
			.TextImageRelation = TextImageRelation.ImageBeforeText
			.Text = "Reload"
			.Size = New Size(80, 24)
            .Location = New Point(m_pnlWatcher.Width - (.Width + 2 + newbtn.Width + 2), 2)
            .Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
            AddHandler newReloadbtn.Click, AddressOf ReloadFromWatcher_Click
			m_pnlWatcher.Controls.Add(newReloadbtn)
		End With

		Dim newlbl As New Label
		With newlbl
			.Size = m_pnlWatcher.Size
			.Location = New Point(0, 7)
			.Font = New Font("Arial", 9, FontStyle.Italic)
			m_pnlWatcher.Controls.Add(newlbl)
		End With
		m_tbThisTab.Controls.Add(m_pnlWatcher)
		m_pnlWatcher.BringToFront()

        m_fswFileWatcher = New FileSystemWatcher()
		With m_fswFileWatcher
			.Path = Path.GetDirectoryName(m_documentPath)
			.Filter = Path.GetFileName(m_documentPath)
			.NotifyFilter = NotifyFilters.LastWrite
			.SynchronizingObject = LogViewFrm
			.EnableRaisingEvents = True
		End With
		AddHandler m_fswFileWatcher.Changed, AddressOf OnChanged
	End Sub

	Private Sub OnChanged(sender As Object, e As FileSystemEventArgs)
		Try
			m_pnlWatcher.Visible = True
            m_pnlWatcher.Controls.Item(2).Text = "This file [ " & m_tbThisTab.Text & " ] has been modified...To reload click 'Reload' ->"
        Catch ex As Exception
			MsgBox(ex.Message)
		End Try
	End Sub

	Public Sub Reload()
        If My.Settings.WarnBeforeReload Then
            m_fileStream = New TextStream(m_documentPath)
            m_rtbText.Text = m_fileStream.ReadFile()
            m_rtbText.AppendText("" & vbNewLine & "")
            m_fileStream.Dispose()
            PopulateFileStats()
        End If
    End Sub

	Public Sub ResetTextFormat()
		With m_rtbText
			.SelectAll()
			.SelectionFont = New Font(.Font, FontStyle.Regular)
			.SelectionColor = My.Settings.TextFontColor
		End With
	End Sub

	Public Sub SaveACopy()
		If My.Settings.AskForCopyPath Then
			Dim sDialog As New SaveFileDialog
			With sDialog
				.InitialDirectory = My.Settings.DefaultSavedCopy
				.OverwritePrompt = True
				.Filter = GetFilterList()
				.FileName = Path.GetFileName(m_documentPath)
				If .ShowDialog = DialogResult.OK Then
					WriteFileOut(.OpenFile)
				End If
			End With
		Else
			WriteFileOut(My.Settings.DefaultSavedCopy & "\" & m_documentPath)
		End If
	End Sub

	Private Sub WriteFileOut(streamPath As Stream)
		If (streamPath IsNot Nothing) Then
			Using myWriter As New StreamWriter(streamPath)
				myWriter.WriteLine(m_fileStream.ReturnModifiedText)
			End Using
			streamPath.Close()
		End If
	End Sub

	Private Sub WriteFileOut(path As String)
		Using myWriter As New StreamWriter(path)
			myWriter.WriteLine(m_fileStream.ReturnModifiedText)
		End Using
	End Sub

    Public Sub HighLightListOfWords(list As Specialized.StringCollection)
        Dim lastVal As Integer : lastVal = 0
        Dim indexOfText As Integer : indexOfText = 0

        Try
            For Each itm As String In list
                Do Until indexOfText = -1
                    indexOfText = m_rtbText.Find(itm, indexOfText + 1, LogViewFrm.GetMatchType)
                    If WordFound(indexOfText) Then
                        HighlightWord(indexOfText, itm)
                        lastVal = indexOfText
                    End If
                Loop
                indexOfText = 0
            Next
        Catch
        End Try
    End Sub

    Public Sub HighLightWord(word As String)
		Dim lastVal As Integer : lastVal = 0
		Dim indexOfText As Integer : indexOfText = 0
		Dim noMoreFound As Integer = -1
		Try
			Do Until indexOfText = noMoreFound
                indexOfText = m_rtbText.Find(word, indexOfText + 1, LogViewFrm.GetMatchType)
                If WordFound(indexOfText) Then
					HighlightWord(indexOfText, word)
					lastVal = indexOfText
				End If
			Loop
		Catch
		End Try
	End Sub

	Private Function WordFound(indexOfWord As Integer) As Boolean
		Return indexOfWord >= 0
	End Function

	Private Sub HighlightWord(indexOfText As Integer, word As String)
		With m_rtbText
			.[Select](indexOfText, word.Length)
			.SelectionFont = New Font(.Font, ReturnKeywordFontStyle(word))
			.SelectionColor = ReturnKeywordColor(word)
		End With
	End Sub

	Public Sub ScrollToEnd()
		ScrollToEndOfLineTextBox()
		ScrollToEndOfTextBox()
	End Sub

	Private Sub ScrollToEndOfLineTextBox()
		m_rtbLineNumber.Select(m_rtbLineNumber.TextLength, 1)
		m_rtbLineNumber.ScrollToCaret()
	End Sub

	Private Sub ScrollToEndOfTextBox()
		m_rtbText.Select(m_rtbText.TextLength, 1)
		m_rtbText.ScrollToCaret()
	End Sub

    Private Function ReturnKeywordFontStyle(word As String) As FontStyle
		Dim ReturnVal As FontStyle = FontStyle.Bold
		For i As Integer = 0 To My.Settings.HighLightWords.Count - 1
			If word = My.Settings.HighLightWords(i) Then
				Select Case My.Settings.HighLightWordsFontStyle(i)
					Case "FontStyle.Regular"
						ReturnVal = FontStyle.Regular
					Case "FontStyle.Bold"
						ReturnVal = FontStyle.Bold
					Case "FontStyle.Italic"
						ReturnVal = FontStyle.Italic
					Case "FontStyle.Underline"
						ReturnVal = FontStyle.Underline
					Case "FontStyle.Strikeout"
						ReturnVal = FontStyle.Strikeout
				End Select
			End If
		Next
		Return ReturnVal
	End Function

	Private Function ReturnKeywordColor(word As String) As Color
		Dim ReturnVal As Color = Color.Tomato
		For i As Integer = 0 To My.Settings.HighLightWords.Count - 1
			If word = My.Settings.HighLightWords(i) Then
				ReturnVal = Color.FromArgb(CInt(My.Settings.HighLightWordsColors(i)))
			End If
		Next
		Return ReturnVal
	End Function

	Private Sub HideWatcherPanel()
		m_hideWatcher = True
		m_pnlWatcher.Visible = False
	End Sub

	Private Sub ShowWatcherPanel()
		m_hideWatcher = False
		m_pnlWatcher.Visible = True
	End Sub


	Const WM_USER As Integer = &H400
	Const EM_GETSCROLLPOS As Integer = WM_USER + 221
	Const EM_SETSCROLLPOS As Integer = WM_USER + 222
	Declare Function SendMessage Lib "user32.dll" Alias "SendMessageW" (ByVal hWnd As IntPtr, ByVal msg As Integer, ByVal wParam As Integer, ByRef lParam As Point) As Integer
	Private Sub richTextBox_VScroll(sender As Object, e As EventArgs)
		Dim pt As Point
		SendMessage(m_rtbText.Handle, EM_GETSCROLLPOS, 0, pt)
		SendMessage(m_rtbLineNumber.Handle, EM_SETSCROLLPOS, 0, pt)
	End Sub

	Private Sub HideWatcher_Click(sender As Object, e As EventArgs)
		HideWatcherPanel()
	End Sub

    Private Sub ReloadFromWatcher_Click(sender As Object, e As EventArgs)
        Reload()
        HideWatcherPanel()
    End Sub

    Private Sub richTextBox_TextChanged(sender As Object, e As EventArgs)
        m_rtbLineNumber.Text = ReturnLineNumbers(m_rtbText.Lines.Count)
        PopulateFileStats()
    End Sub

    Private Sub PopulateFileStats()
        With m_pnlStatusBar
            .tssTotalLines.Text = m_rtbText.Lines.Count.ToString
            .tssTotalTextLength.Text = m_rtbText.TextLength.ToString
            .tssCurrentLinePosition.Text = CurrentLinePosition.ToString
            .tssCurrentTextLength.Text = CurrentLineLength.ToString
            .tssCurrentColumnPosition.Text = CurrentColumnPosition.ToString
            .tssSelectedTextLength.Text = m_rtbText.SelectionLength.ToString
        End With
    End Sub

    Private Function CurrentLinePosition() As Integer
        Return m_rtbText.GetLineFromCharIndex(m_rtbText.GetFirstCharIndexOfCurrentLine) + 1
    End Function

    Private Function CurrentLineLength() As Integer
        Dim startline As Integer = m_rtbText.GetFirstCharIndexFromLine(CurrentLinePosition() - 1)
        Dim endline As Integer = m_rtbText.GetFirstCharIndexFromLine(CurrentLinePosition())

        If IsBlank(endline) Then
            Return 0
        Else
            Return (endline - startline) - 1
        End If
    End Function

    Private Function IsBlank(value As Integer) As Boolean
        If value = -1 Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Function CurrentColumnPosition() As Integer
        Return (m_rtbText.SelectionStart - m_rtbText.GetFirstCharIndexFromLine(CurrentLinePosition() - 1))
    End Function

    Private Class TextStream
		Implements IDisposable

		Private FileStreamReader As StreamReader
		Private filterWord As String = String.Empty
		Private removeBlankLine As Boolean
		Private modifiedText As String
		Private originalText As String
		Private lineCountOfText As Long = 1
		Private line As String

		Public Property KeyWord As String
			Get
				Return filterWord
			End Get
			Set(value As String)
				filterWord = value
			End Set
		End Property

		Public Property RemoveBlankLines As Boolean
			Get
				Return removeBlankLine
			End Get
			Set(value As Boolean)
				removeBlankLine = value
			End Set
		End Property

		Public ReadOnly Property ReturnOrignalText As String
			Get
				Return ReadFile()
			End Get
		End Property

		Public ReadOnly Property ReturnModifiedText As String
			Get
				Return ReadFileWithFilters()
			End Get
		End Property

		Public ReadOnly Property LineCount As Long
			Get
				Return lineCountOfText
			End Get
		End Property

		Public Sub New(path As String)
			Dim fileStream = New FileStream(path, FileMode.Open, FileAccess.Read, FileShare.ReadWrite)
			FileStreamReader = New StreamReader(fileStream)
		End Sub

		Public Function ReadFile() As String
			Do While Not FileStreamReader.EndOfStream
				line = FileStreamReader.ReadLine
				originalText &= line & vbNewLine
			Loop
			Return originalText & vbNewLine & vbNewLine
		End Function

		Public Function ReadFileWithFilters() As String
			Do While Not FileStreamReader.EndOfStream
				line = FileStreamReader.ReadLine
				modifiedText &= ReturnModifiedLine()
				AddLineCount()
			Loop
			Return modifiedText & vbNewLine & vbNewLine
		End Function

		Private Sub AddLineCount()
			lineCountOfText += 1
		End Sub

		Private Function NotEmpty() As Boolean
			Return Trim(line) <> String.Empty
		End Function

		Private Function ReturnModifiedLine() As String
			If NotEmpty() Then
				Return ReturnFilterLine()
			Else
				Return ReturnBlankLine()
			End If
		End Function

		Private Function ReturnFilterLine() As String
			If line.Contains(filterWord) Then
				Return line & vbNewLine
			End If
			Return Nothing
		End Function

		Private Function ReturnBlankLine() As String
			If Not removeBlankLine Then
				Return line & vbNewLine
			End If
			Return Nothing
		End Function

		Public Sub Dispose() Implements IDisposable.Dispose

        End Sub
	End Class

End Class




