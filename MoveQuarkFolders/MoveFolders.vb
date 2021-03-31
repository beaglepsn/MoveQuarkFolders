Imports System.Configuration
Imports System.IO
Public Class MoveFolders
    Private sSourcePath As String
    Private sDestPath As String
    Private sFolderToFind As String
    Private sDelete As String
    Private Sub MoveFolders_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim appSettingRdr As New AppSettingsReader

        sSourcePath = appSettingRdr.GetValue("SourcePath", GetType(String))
        sDestPath = appSettingRdr.GetValue("DestPath", GetType(String))
        sFolderToFind = appSettingRdr.GetValue("FolderToFind", GetType(String))

        txtSourcePath.Text = sSourcePath
        txtDestPath.Text = sDestPath
        txtFolderToFind.Text = sFolderToFind
    End Sub
    Private Sub btnMove_Click(sender As Object, e As EventArgs) Handles btnMove.Click
        sFolderToFind = txtFolderToFind.Text.Trim
        Dim dlgR As DialogResult

        dlgR = MessageBox.Show("Moved Folders will be deleted from Source Directory",
            "Attention!", MessageBoxButtons.YesNo)

        ' then test it:
        If dlgR = DialogResult.Yes Then
            sDelete = "1"
        Else
            sDelete = "0"
        End If

        CopyDirectory(sSourcePath)
    End Sub

    Public Sub CopyDirectory(ByVal SourcePath As String)
        Dim SourceDir As DirectoryInfo = New DirectoryInfo(SourcePath)

        ' the source directory must exist, otherwise throw an exception

        If SourceDir.Exists Then
            Dim SubDir As DirectoryInfo
            For Each SubDir In SourceDir.GetDirectories()

                If SubDir.Name Like "*" & sFolderToFind & "*" Then
                    Console.WriteLine(SubDir.Name)
                    My.Computer.FileSystem.CopyDirectory(SubDir.FullName, sDestPath & "\" & SubDir.Name, True)
                End If
                CopyDirectory(SubDir.FullName)
            Next
            If SourceDir.Name Like "*" & sFolderToFind & "*" And sDelete = "1" Then
                System.IO.Directory.Delete(SourceDir.FullName, True)
            End If

        Else
            Throw New DirectoryNotFoundException("Source directory does not exist: " + SourceDir.FullName)
        End If

    End Sub

    Private Sub btnSourcePath_Click(sender As Object, e As EventArgs) Handles btnSourcePath.Click
        Dim dlgBrowse As New FolderBrowserDialog
        dlgBrowse.SelectedPath = txtSourcePath.Text
        If dlgBrowse.ShowDialog = DialogResult.OK Then
            sSourcePath = dlgBrowse.SelectedPath
            If Not sSourcePath.EndsWith("\") Then
                sSourcePath &= "\"
            End If
            txtSourcePath.Text = sSourcePath
        End If
    End Sub

    Private Sub btnDestPath_Click(sender As Object, e As EventArgs) Handles btnDestPath.Click
        Dim dlgBrowse As New FolderBrowserDialog
        dlgBrowse.SelectedPath = txtDestPath.Text
        If dlgBrowse.ShowDialog = DialogResult.OK Then
            sDestPath = dlgBrowse.SelectedPath
            If Not sDestPath.EndsWith("\") Then
                sDestPath &= "\"
            End If
            txtDestPath.Text = sDestPath
        End If
    End Sub
End Class
