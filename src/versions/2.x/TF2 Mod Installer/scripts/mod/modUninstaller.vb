Public Class modUninstaller
    Public Shared Sub UninstallSingleMod(ByVal modFileLocation As String, ByVal ModName As String)
        Console.WriteLine("Uninstalling mod " & ModName & "...")
        Try
            My.Computer.FileSystem.DeleteFile(modFileLocation, FileIO.UIOption.OnlyErrorDialogs, FileIO.RecycleOption.DeletePermanently)
        Catch ex As Exception
            Debug.WriteLine(ex)
            errorHandler.errorHandler("Uninstalling a Mod Failed", "TF2MI-Error-00006", "Failed to uninstall a mod.")
        End Try
    End Sub
    Public Shared Sub UninstallFolder(ByVal modFolderLocation As String, ByVal ModName As String)
        Console.WriteLine("Uninstalling mod " & ModName & "...")
        Try

            My.Computer.FileSystem.DeleteDirectory(modFolderLocation, FileIO.UIOption.OnlyErrorDialogs, FileIO.RecycleOption.DeletePermanently)
        Catch ex As Exception
            Debug.WriteLine(ex)
            errorHandler.errorHandler("Uninstalling a Mod Failed", "TF2MI-Error-00006", "Failed to uninstall a mod.")
        End Try
    End Sub
End Class
