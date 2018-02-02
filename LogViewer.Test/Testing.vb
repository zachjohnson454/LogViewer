Imports LogViewer
Imports System.Windows.Forms

<TestClass()> Public Class Testing

    <TestMethod()> Public Sub CheckForAddedSlash()
        'Arrange
        Dim testPath As String = "C:\desktop"

        'Act
        Dim testReturn = BrowseFrm.ReturnPathWithSlash(testPath)

        'Asert
        Assert.AreEqual(testPath & "\", testReturn)
    End Sub

    <TestMethod()> Public Sub CheckWithSlash()
        'Arrange
        Dim testPath As String = "C:\"

        'Act
        Dim testReturn = BrowseFrm.ReturnPathWithSlash(testPath)

        'Asert
        Assert.AreEqual(testPath, testReturn)
    End Sub

End Class
