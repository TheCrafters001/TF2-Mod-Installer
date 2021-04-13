Public Class TF2C
    Public Shared Sub TF2CInst()
        Dim SysDri As String = Environment.GetEnvironmentVariable("SystemDrive")
        Dim tmp As String = SysDri + "\TF2ModTemp\"
        Try
            Process.Start(tmp + "tf2c_installer.exe", "/SILENT /TYPE=""full""")
        Catch ex As Exception
            errorHandler.errorHandler(ex.ToString, "Failed to Install/Uninstall Mod", "TF2MI-Error-00007", "Something went wrong, and the mod could not be installed/uninstalled." + vbCrLf + "Please press enter to recover.")
        End Try
    End Sub
End Class
