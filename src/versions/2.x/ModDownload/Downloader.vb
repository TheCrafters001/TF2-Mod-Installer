Imports System.IO
Imports System.IO.Compression
Imports System.HttpStyleUriParser
Imports System.Net
Imports System.Net.Http
Imports System.Windows.Forms

Public Class Downloader
    Public Shared Sub DownloadNow(ByVal fileName As String, ByVal fileURL As String, ByVal modName As String)
        ' Define Windows Drive Letter, and TMP folder.
        Dim SysDri As String = Environment.GetEnvironmentVariable("SystemDrive")
        Dim tmp As String = SysDri + "\TF2ModTemp\"
        Try
            ' Check if the TMP folder exist.
            If (Not System.IO.Directory.Exists(tmp)) Then
                ' Create TMP folder.
                Console.WriteLine("Making temporary directory...")
                MkDir(tmp)
            End If

            If My.Computer.FileSystem.FileExists(tmp + fileName) Then
                Console.WriteLine("Temporary file already downloaded.")
            Else
                'Download Mod ZIP
                Using client = New WebClient
                    Console.WriteLine("Attempting to download: " + modName)
                    client.DownloadFile(New Uri(fileURL), tmp + fileName)
                End Using
            End If

        Catch ex As Exception
            MessageBox.Show("Sorry, cannot download file: " & ex.ToString, "Cannot Download", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class
