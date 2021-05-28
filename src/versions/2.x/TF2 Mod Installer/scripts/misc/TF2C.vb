Public Class TF2C
    Public Shared Sub TF2CInst()
        Dim SysDri As String = Environment.GetEnvironmentVariable("SystemDrive")
        Dim tmp As String = SysDri + "\TF2ModTemp\"
        Try
            Console.WriteLine("Waiting for TF2 Classic Installer to close...")

            'Run Process
            Dim Installer As New ProcessStartInfo
            Installer.FileName = tmp + "tf2c_installer.exe"
            Installer.Arguments = "/SILENT /TYPE=""full"""
            Installer.UseShellExecute = True
            Installer.WindowStyle = ProcessWindowStyle.Normal
            Dim proc As Process = Process.Start(Installer)
            proc.WaitForExit()
        Catch ex As Exception
            errorHandler.errorHandler(ex.ToString, "Failed to Install/Uninstall Mod", "TF2MI-Error-00007", "Something went wrong, and the mod could not be installed/uninstalled." + vbCrLf + "Please press enter to recover.")
        End Try
    End Sub

    Public Shared Sub TF2CUNInst()
        Dim SysDri As String = Environment.GetEnvironmentVariable("SystemDrive")
        Dim tmp As String = SysDri + "\TF2ModTemp\"
        Try
            Console.WriteLine("Waiting for TF2 Classic Installer to close...")

            'Run Process
            Dim Installer As New ProcessStartInfo
            Installer.FileName = My.Settings.CustomFolder + "\unins000.exe"
            Installer.Arguments = "/SILENT"
            Installer.UseShellExecute = True
            Installer.WindowStyle = ProcessWindowStyle.Normal
            Dim proc As Process = Process.Start(Installer)
            proc.WaitForExit()
        Catch ex As Exception
            errorHandler.errorHandler(ex.ToString, "Failed to Install/Uninstall Mod", "TF2MI-Error-00007", "Something went wrong, and the mod could not be installed/uninstalled." + vbCrLf + "Please press enter to recover.")
        End Try
    End Sub
End Class
