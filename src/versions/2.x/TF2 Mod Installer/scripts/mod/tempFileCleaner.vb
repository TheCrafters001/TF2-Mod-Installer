Imports System.IO
Imports System.Windows.Forms

Public Class tempFileCleaner
    Public Shared Sub Init()
        Console.WriteLine("Checking Keep Temporary Files setting...")
        If My.Settings.KeepTempFiles = True Then
            Console.WriteLine("Temporary files will be kept.")
        ElseIf My.Settings.KeepTempFiles = False Then
            Try
                Console.WriteLine("Attempting to delete temporary files...")
                cleanTemp()
            Catch ex As Exception
                Debug.WriteLine(ex)
                errorHandler.errorHandler("Temporary File Cleaner", "TF2MI-Error-00005", "Cannot delete temporary files.")
            End Try
        End If
    End Sub
    Public Shared Sub cleanTemp()
        Dim SysDri As String = Environment.GetEnvironmentVariable("SystemDrive")
        Dim tmp As String = SysDri + "\TF2ModTemp\"
        My.Computer.FileSystem.DeleteDirectory(tmp, FileIO.UIOption.OnlyErrorDialogs, FileIO.RecycleOption.DeletePermanently)
    End Sub
End Class
