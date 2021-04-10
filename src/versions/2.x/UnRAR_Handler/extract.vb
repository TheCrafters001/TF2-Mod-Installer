Public Class extract
    Public Shared Sub ExtractNow(ByVal fileName As String, ByVal modName As String, ByVal installLocation As String)
        ' Define SysDri as Windows Drive Letter
        Dim SysDri As String = Environment.GetEnvironmentVariable("SystemDrive")
        Dim tmp As String = SysDri + "\TF2ModTemp\"
        ' Define WinRAR Location
        Dim SevZip As String = ".\util\WinRAR\UnRAR.exe"
        ' Define extractMod as new Process
        Dim extractMod As New ProcessStartInfo
        extractMod.FileName = SevZip
        ' Define WinRAR arguments
        extractMod.Arguments = "x -y """ + tmp + "\" + fileName + """ """ + installLocation + """"
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
