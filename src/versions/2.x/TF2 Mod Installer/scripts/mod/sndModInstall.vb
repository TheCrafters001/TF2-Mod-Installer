Public Class sndModInstall
    Public Shared Sub Install(ByVal modName As String, ByVal TmpFolder As String, Optional ByVal SoundType As String = "ui")
        ' Define SysDri as Windows Drive Letter
        Dim SysDri As String = Environment.GetEnvironmentVariable("SystemDrive")
        Dim tmp As String = SysDri + "\TF2ModTemp\"

        'Generate Missing Folders
        my_Custom_Stuff_Gen.Generate()

        'Check Backup Settings
        Console.WriteLine("Checking Backup Settings...")

        If My.Settings.BackupMyCustomStuff = True Then
            Console.WriteLine("Backing up my_custom_stuff...")
            My.Computer.FileSystem.CopyDirectory(My.Settings.CustomFolder + "\my_custom_stuff", My.Settings.CustomFolder + "\my_custom_stuff_backup")
        ElseIf My.Settings.BackupMyCustomStuff = False Then
            Console.WriteLine("Not backing up my_custom_stuff.")
        End If

        Console.WriteLine("Installing " + modName)
        ' Copy the mod to the my_custom_stuff file.
        My.Computer.FileSystem.CopyDirectory(tmp + "\" + TmpFolder, My.Settings.CustomFolder + "\my_custom_stuff\sound\" + SoundType)
    End Sub
End Class
