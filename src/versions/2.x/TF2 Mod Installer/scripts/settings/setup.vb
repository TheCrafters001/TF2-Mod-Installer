Imports System.IO
Imports System.Windows.Forms

Public Class setup
    Public Shared Sub PreSetup()
        Try
            Dim steamFolder As New FolderBrowserDialog
            Dim defaultPath As String
            Console.WriteLine("Please wait... Finding Steam...")
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
            My.Settings.SteamFolder = steamFolder.SelectedPath
            My.Settings.CustomFolder = defaultPath
            Setup()
        Catch ex As Exception
            errorHandler.errorHandler("Pre-Setup Error", "TF2MI-Error-00001", ex.ToString)
        End Try
    End Sub
    Public Shared Sub Setup()
        Try
            Dim TF2Finder As New FolderBrowserDialog
            Dim defaultRight1 As DialogResult
            Dim defaultRight2 As DialogResult
            Dim defaultRight3 As DialogResult
            Console.WriteLine("Welcome to the Team Fortress 2 Mod Installer!")
            Console.WriteLine("This app allows you to install TF2 mods easier!")
            Console.WriteLine("")
            Console.WriteLine("Before you use this app, I need to do a little setup.")
            Console.WriteLine("I will ask you some questions, and you will provide the")
            Console.WriteLine("answers. You don't have to answer any of them, but")
            Console.WriteLine("I will assume you want the default settings.")
            Console.WriteLine("")
            Console.WriteLine("Press ENTER to continue.")
            Console.ReadKey(Keys.Enter)
            Console.Clear()
            Console.Title = "TF2 Mod Installer Setup"
            Console.WriteLine("===================")
            Console.WriteLine("= Setup           =")
            Console.WriteLine("===================")
            Console.WriteLine("All these settings can be changed later as needed")
            Console.WriteLine("Where is your tf\custom folder?")
            defaultRight1 = MessageBox.Show("Default tf\custom folder:" + vbCrLf & My.Settings.CustomFolder + vbCrLf + vbCrLf _
                                                            + "Is this correct?", "TF2 Mod Installer Setup", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If defaultRight1 = DialogResult.No Then
                Console.WriteLine("You said that the default path isn't correct. I am assuming that you have TF2 installed in a different folder.")
                Console.WriteLine("Please tell me where you have TF2 installed.")
                TF2Finder.Description = "Please tell me where you have TF2 installed."
                TF2Finder.ShowNewFolderButton = False
                TF2Finder.RootFolder = Environment.SpecialFolder.Desktop
                TF2Finder.ShowDialog()
                Console.WriteLine("Thank you! I will now use the following folder to install mods to: " + vbCrLf + TF2Finder.SelectedPath + "\tf\custom" + vbCrLf + "(This can be changed later)")
                My.Settings.CustomFolder = TF2Finder.SelectedPath + "\tf\custom"
                My.Settings.tf2InstallPath = TF2Finder.SelectedPath
                Console.WriteLine("Press ENTER to continue.")
                Console.ReadKey(Keys.Enter)
            ElseIf defaultRight1 = DialogResult.Yes Then
                Console.WriteLine("Perfect! I will install your mods here:")
                Console.WriteLine(My.Settings.CustomFolder)
                Console.WriteLine("Press ENTER to continue.")
                Console.ReadKey(Keys.Enter)
            End If
            Console.Clear()
            Console.WriteLine("===================")
            Console.WriteLine("= Setup           =")
            Console.WriteLine("===================")
            Console.WriteLine("Do you want to keep the temporary files?")
            Console.WriteLine("Temporary files are files downloaded from the internet that contain the mods that I install for you." + vbCrLf + "Keeping them may allow me to restore mods if they break, but it may use up storage on your hard drive. By default, this is set to NO.")
            defaultRight2 = MessageBox.Show("Keep temporary files?", "TF2 Mod Installer Setup", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
            If defaultRight2 = DialogResult.No Then
                Console.WriteLine("")
                Console.WriteLine("Okay, I WILL NOT keep the temporary files.")
                My.Settings.KeepTempFiles = False
                Console.WriteLine("Press ENTER to continue.")
                Console.ReadKey(Keys.Enter)
            ElseIf defaultRight2 = DialogResult.Yes Then
                Console.WriteLine("")
                Console.WriteLine("Okay, I WILL keep the temporary files.")
                My.Settings.KeepTempFiles = True
                Console.WriteLine("Press ENTER to continue.")
                Console.ReadKey(Keys.Enter)
            End If
            Console.Clear()
            Console.WriteLine("===================")
            Console.WriteLine("= Setup           =")
            Console.WriteLine("===================")
            Console.WriteLine("Would you like to backup the my_custom_stuff folder?")
            Console.WriteLine("This folder contains sound mods. Backing up is highly recommended." + vbCrLf + "Backing up will allow me to restore your old sounds if something goes wrong.")
            defaultRight2 = MessageBox.Show("Backup my_custom_stuff folder?", "TF2 Mod Installer Setup", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)
            If defaultRight2 = DialogResult.No Then
                Console.WriteLine("")
                Console.WriteLine("I WILL NOT backup the my_custom_stuff folder.")
                My.Settings.BackupMyCustomStuff = False
                Console.WriteLine("Press ENTER to continue.")
                Console.ReadKey(Keys.Enter)
            ElseIf defaultRight2 = DialogResult.Yes Then
                Console.WriteLine("")
                Console.WriteLine("Okay, I WILL backup the my_custom_stuff folder.")
                My.Settings.BackupMyCustomStuff = True
                Console.WriteLine("Press ENTER to continue.")
                Console.ReadKey(Keys.Enter)
            End If
            PostSetup()
        Catch ex As Exception
            errorHandler.errorHandler("Setup Error", "TF2MI-Error-00002", ex.ToString)
        End Try
    End Sub
    Public Shared Sub PostSetup()
        Try
            Dim preferredName As String
            Console.Clear()
            Console.WriteLine("Thank you! One I have one last question.")
            Console.WriteLine("What would you like me to call you?")
            Console.WriteLine("")
            Console.WriteLine("")
            Console.Write("Enter your preferred name: ")
            preferredName = Console.ReadLine()
            If preferredName = "" Then
                preferredName = "User"
            End If
            Console.WriteLine("Okay, I will refer to you as: " + preferredName + "! If you made a mistake, you can change this later.")
            My.Settings.PersonalName = preferredName
            My.Settings.IsFirstTime = False
            Console.WriteLine("The setup is over! You can now use TF2 Mod Installer!")
            Console.WriteLine("Press ENTER to continue.")
            Console.ReadKey(Keys.Enter)
            Console.Clear()
            My.Settings.Save()
        Catch ex As Exception
            errorHandler.errorHandler("Post-Setup Error", "TF2MI-Error-00003", ex.ToString)
        End Try
    End Sub
End Class
