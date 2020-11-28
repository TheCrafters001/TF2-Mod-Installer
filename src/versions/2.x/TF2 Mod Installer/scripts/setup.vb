Imports System.IO
Imports System.Windows.Forms

Public Class setup
    Public Shared Sub PreSetup()
        Dim steamFolder As New FolderBrowserDialog
        Dim defaultPath As String
        Console.WriteLine("Please wait... Finding steam...")
        If My.Computer.FileSystem.FileExists(Path.GetPathRoot(Environment.GetFolderPath(Environment.SpecialFolder.System)) & "Program Files (x86)\Steam\steam.exe") Then
            Console.WriteLine("Steam (64-bit) found.")
            defaultPath = Path.GetPathRoot(Environment.GetFolderPath(Environment.SpecialFolder.System)) & "Program Files (x86)\Steam\steamapps\common\Team Fortress 2\tf\custom"
        ElseIf My.Computer.FileSystem.FileExists(Path.GetPathRoot(Environment.GetFolderPath(Environment.SpecialFolder.System)) & "Program Files\Steam\steam.exe") Then
            Console.WriteLine("Steam (32-bit) found.")
            defaultPath = Path.GetPathRoot(Environment.GetFolderPath(Environment.SpecialFolder.System)) & "Program Files\Steam\steamapps\common\Team Fortress 2\tf\custom"
        Else
            Console.WriteLine("Sorry, I cannot find steam. I need to know where steam is in order to do the mod installs.")
            Console.WriteLine("Please locate your steam folder.")
            steamFolder.Description = "Select your Steam folder"
            steamFolder.ShowNewFolderButton = False
            steamFolder.RootFolder = Environment.SpecialFolder.Desktop
            steamFolder.ShowDialog()
            If My.Computer.FileSystem.FileExists(steamFolder.SelectedPath + "\steam.exe") Then
                Console.WriteLine("Steam located!")
                Console.WriteLine(steamFolder.SelectedPath + "\steam.exe")
                defaultPath = steamFolder.SelectedPath + "\steamapps\common\Team Fortress 2\tf\custom"
            End If
        End If
        My.Settings.SteamFolder = steamFolder.selectedPath
        My.Settings.CustomFolder = defaultPath
        Setup()
    End Sub
    Public Shared Sub Setup()
        Dim tf2InstallPath As String
        Dim TF2Finder As New FolderBrowserDialog
        Console.WriteLine("Welcome to the Team Fortress 2 Mod Installer!")
        Console.WriteLine("This app allows you to install TF2 mods easier!")
        Console.WriteLine("")
        Console.WriteLine("Before you use this app, I need to do a little setup.")
        Console.WriteLine("I will ask you some questions, and you will provide the")
        Console.WriteLine("answers. You don't have to answer any of them, but")
        Console.WriteLine("I will assume you want the default settings.")
        Console.WriteLine("")
        Console.WriteLine("Press ANY KEY to continue.")
        Console.Read()
        Console.Clear()
        Console.Title = "TF2 Mod Installer Setup"
        Console.WriteLine("===================")
        Console.WriteLine("= Setup           =")
        Console.WriteLine("===================")
        Console.WriteLine("Where is your tf\custom folder?")
        Dim defaultRight1 As DialogResult = MessageBox.Show("Default tf\custom folder:" + vbCrLf & My.Settings.CustomFolder + vbCrLf + vbCrLf _
                                                            + "Is this correct?", "TF2 Mod Installer Setup", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If defaultRight1 = DialogResult.No Then
            Console.WriteLine("You said that the default path isn't correct. I am assuming that you have TF2 installed in a different folder.")
            Console.WriteLine("Please tell me where you have TF2 installed.")
            TF2Finder.Description = "Please tell me where you have TF2 installed."
            TF2Finder.ShowNewFolderButton = False
            TF2Finder.RootFolder = Environment.SpecialFolder.Desktop
            TF2Finder.ShowDialog()
            Console.WriteLine("Thank you! I will now use the following folder to install mods to: " + vbCrLf + TF2Finder.SelectedPath + vbCrLf + "(This can be changed later)")
            Console.ReadLine()
        End If
    End Sub
End Class
