Public Class extract_install
    Public Shared Sub ExtractNow(ByVal fileName As String, ByVal modName As String, ByVal installLocation As String)
        ' Define SysDri as Windows Drive Letter
        Dim SysDri As String = Environment.GetEnvironmentVariable("SystemDrive")
        Dim tmp As String = SysDri + "\TF2ModTemp\"
        ' Define 7Zip Location
        Dim SevZip As String = ".\util\7Zip\7za.exe"
        ' Define extractMod as new Process
        Dim extractMod As New ProcessStartInfo
        extractMod.FileName = SevZip
        ' Define 7Zip arguments
        extractMod.Arguments = "x """ + tmp + "\" + fileName + """ -o""" + installLocation + """ * -r -aoa"
        extractMod.UseShellExecute = True
        ' Hide 7Zip Window.
        ' This is done to make the process smoother.
        extractMod.WindowStyle = ProcessWindowStyle.Minimized
        ' Tell the user that the file is extracting, but not installing
        Console.WriteLine("Extracting " + modName + "...")
        Dim startProc As Process = Process.Start(extractMod)
        ' Wait until startProc ends.
        startProc.WaitForExit()
    End Sub
End Class
