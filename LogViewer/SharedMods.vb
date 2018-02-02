Option Strict On
Imports System.IO

Module SharedFunctions
    Public Function ReturnFolderPath() As String
        Dim ReturnVal As String = Nothing
        Using oFolderDialog As New FolderBrowserDialog
            With oFolderDialog
                .RootFolder = Environment.SpecialFolder.Desktop
                .ShowNewFolderButton = True
                If .ShowDialog() = DialogResult.OK Then
                    ReturnVal = .SelectedPath
                End If
            End With
        End Using
        Return ReturnVal
    End Function


    Public Sub OpenExternally(path As String)
        Try
            Process.Start(path)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub LoadDropDowns(currentCbo As ComboBox)
        currentCbo.Items.Clear()
        For i As Integer = 0 To My.Settings.HighLightWords.Count - 1
            currentCbo.Items.Add(My.Settings.HighLightWords(i))
        Next
    End Sub

    Public Function GetLogFilePath() As String
        GetLogFilePath = Nothing
        Using oDialog As New OpenFileDialog()
            With oDialog
                .InitialDirectory = My.Settings.DefaultSavedCopy
                .Filter = GetFilterList()
                .FilterIndex = 1
                .Multiselect = True
                If .ShowDialog = DialogResult.OK Then
                    GetLogFilePath = .FileName
                End If
            End With
        End Using
    End Function

    Public Function GetFilterList() As String
        Dim str As String = Nothing
        Dim split As String = Nothing
        Dim fileType As String = Nothing

        For i As Integer = 0 To My.Settings.FileTypes.Count - 1
            fileType = My.Settings.FileTypes(i)
            split = Mid(fileType, InStr(fileType, "("), (fileType.Length - InStr(fileType, "(") + 1)).Replace("(", "|").Replace(")", "|")
            str &= My.Settings.FileTypes(i) & split
        Next
        GetFilterList = str.Remove(str.Length - 1)
    End Function

    Public Function ReturnFilename(filename As String) As String
        Dim ReturnVal As String = Nothing
        If My.Settings.AddDateToCopy Then
            Dim ext As String = Path.GetExtension(filename)
            Dim fname As String = Path.GetFileNameWithoutExtension(filename)
            ReturnVal = fname & "_" & Format(Today(), "yyMMdd") & ext
        End If
        Return ReturnVal
    End Function
End Module
