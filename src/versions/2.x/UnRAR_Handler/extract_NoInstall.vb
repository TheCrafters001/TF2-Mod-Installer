Public Class extract_NoInstall
    Public Shared Sub ExtractNow(ByVal fileName As String, ByVal modName As String, ByVal installLocation As String)
        ' Define SysDri as Windows Drive Letter
        Dim SysDri As String = Environment.GetEnvironmentVariable("SystemDrive")
        Dim tmp As String = SysDri + "\TF2ModTemp\"
        ' Define WinRAR Location
        Dim UnRar As String = ".\util\WinRAR\UnRAR.exe"
        ' Make Folder For Mod, because WinRAR won't.
        MkDir(tmp + "\" + modName)
        ' Define extractMod as new Process
        Dim extractMod As New ProcessStartInfo
        extractMod.FileName = UnRar
        ' Define WinRAR arguments
        extractMod.Arguments = "x -y """ + tmp + "\" + fileName + """ """ + tmp + "\" + modName + """"
        extractMod.UseShellExecute = True
        ' Hide WinRAR Window.
        ' This is done to make the process smoother.
        extractMod.WindowStyle = ProcessWindowStyle.Minimized
        ' Tell the user that the file is extracting, but not installing
        Console.WriteLine("Extracting " + modName + "...")
        Dim startProc As Process = Process.Start(extractMod)
        ' Wait until startProc ends.
        startProc.WaitForExit()
    End Sub
End Class
