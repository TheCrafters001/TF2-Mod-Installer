Imports System.IO
Imports System.Windows.Forms
Imports AutoUpdaterDotNET

Public Class settingsMenu
    Public Shared Sub settings()
        Console.WriteLine("Loading settings...")
        Dim preferredName As String = My.Settings.PersonalName
        Dim customFolder As String = My.Settings.CustomFolder
        Dim tf2InstallPath As String = My.Settings.tf2InstallPath
        Dim backupMCS As Boolean = My.Settings.BackupMyCustomStuff
        Dim steam As String = My.Settings.SteamFolder
        Dim keeptemp As Boolean = My.Settings.KeepTempFiles
        Dim TF2Finder As New FolderBrowserDialog
        Dim question As DialogResult

        Dim choice As Integer

        Console.Clear()
        Console.Title = "TF2 Mod Installer Settings"
        Console.WriteLine("===================================")
        Console.WriteLine("= TF2 Mod Installer Settings      =")
        Console.WriteLine("===================================")
        Console.WriteLine("1) Change Preferred Name")
        Console.WriteLine("2) Change TF2 Install Location")
        Console.WriteLine("3) Change Backup my_custom_stuff Folder")
        Console.WriteLine("4) Change Steam Folder")
        Console.WriteLine("5) Change Keep Temporary Files")
        Console.WriteLine("6) Reset all settings")
        Console.WriteLine("0) Exit Settings")
        Console.WriteLine("")
        Console.WriteLine("")
        Console.Write("Select an option: ")
        Try
            choice = Console.ReadLine()
        Catch ex As Exception
            errorHandler.errorHandler("Selection menu error", "TF2MI-Error-00004", "You selected an option that either doesn't exist in the list, or is not a number." + vbCrLf + "Please press enter to recover.")
        End Try
        If choice = 1 Then
            Console.Clear()
            Console.Title = "TF2 Mod Installer Setup"
            Console.WriteLine("===================")
            Console.WriteLine("= Setup           =")
            Console.WriteLine("===================")
            Console.WriteLine("What would you like me to call you?")
            Console.WriteLine("")
            Console.WriteLine("")
            Console.Write("Enter your preferred name: ")
            preferredName = Console.ReadLine()
            Console.WriteLine("Okay, I will refer to you as: " + preferredName + "! If you made a mistake, you can change this later.")
            My.Settings.PersonalName = preferredName
            My.Settings.Save()
            Console.WriteLine("Press ENTER to continue.")
            Console.ReadKey(Keys.Enter)
            settings()
        ElseIf choice = 2 Then
            Console.Clear()
            Console.Title = "TF2 Mod Installer Setup"
            Console.WriteLine("===================")
            Console.WriteLine("= Setup           =")
            Console.WriteLine("===================")
            Console.WriteLine("Please tell me where you have TF2 installed.")
            TF2Finder.Description = "Please tell me where you have TF2 installed."
            TF2Finder.ShowNewFolderButton = False
            TF2Finder.RootFolder = Environment.SpecialFolder.Desktop
            TF2Finder.ShowDialog()
            Console.WriteLine("Thank you! I will now use the following folder to install mods to: " + vbCrLf + TF2Finder.SelectedPath + "\tf\custom" + vbCrLf + "(This can be changed later)")
            My.Settings.CustomFolder = TF2Finder.SelectedPath + "\tf\custom"
            My.Settings.tf2InstallPath = TF2Finder.SelectedPath
            My.Settings.Save()
            Console.WriteLine("Press ENTER to continue.")
            Console.ReadKey(Keys.Enter)
            settings()
        ElseIf choice = 3 Then
            Console.Clear()
            Console.Title = "TF2 Mod Installer Setup"
            Console.WriteLine("===================")
            Console.WriteLine("= Setup           =")
            Console.WriteLine("===================")
            Console.WriteLine("Would you like to backup the my_custom_stuff folder?")
            Console.WriteLine("This folder contains sound mods. Backing up is highly recommended." + vbCrLf + "Backing up will allow me to restore your old sounds if something goes wrong.")
            question = MessageBox.Show("Backup my_custom_stuff folder?", "TF2 Mod Installer Setup", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)
            If question = DialogResult.No Then
                Console.WriteLine("")
                Console.WriteLine("I WILL NOT backup the my_custom_stuff folder.")
                My.Settings.BackupMyCustomStuff = False
                Console.WriteLine("Press ENTER to continue.")
                Console.ReadKey(Keys.Enter)
            ElseIf question = DialogResult.Yes Then
                Console.WriteLine("")
                Console.WriteLine("Okay, I WILL backup the my_custom_stuff folder.")
                My.Settings.BackupMyCustomStuff = True
                Console.WriteLine("Press ENTER to continue.")
                Console.ReadKey(Keys.Enter)
            End If
            settings()
        ElseIf choice = 4 Then
            Console.Clear()
            Console.Title = "TF2 Mod Installer Setup"
            Console.WriteLine("===================")
            Console.WriteLine("= Setup           =")
            Console.WriteLine("===================")
            Try
                Dim steamFolder As New FolderBrowserDialog
                Console.WriteLine("Please wait... Finding Steam...")
                If My.Computer.FileSystem.FileExists(Path.GetPathRoot(Environment.GetFolderPath(Environment.SpecialFolder.System)) & "Program Files (x86)\Steam\steam.exe") Then
                    Console.WriteLine("Steam (64-bit) found.")
                    Console.WriteLine("There is no need to locate Steam, as it is installed in the default directory.")
                ElseIf My.Computer.FileSystem.FileExists(Path.GetPathRoot(Environment.GetFolderPath(Environment.SpecialFolder.System)) & "Program Files\Steam\steam.exe") Then
                    Console.WriteLine("Steam (32-bit) found.")
                    Console.WriteLine("There is no need to locate Steam, as it is installed in the default directory.")
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
                    End If
                End If
                My.Settings.SteamFolder = steamFolder.SelectedPath
                My.Settings.Save()
                Console.WriteLine("Press ENTER to continue.")
                Console.ReadKey(Keys.Enter)
                settings()
            Catch ex As Exception
                errorHandler.errorHandler("Pre-Setup Error", "TF2MI-Error-00001", ex.ToString)
            End Try
        ElseIf choice = 5 Then
            Console.Clear()
            Console.Title = "TF2 Mod Installer Setup"
            Console.WriteLine("===================")
            Console.WriteLine("= Setup           =")
            Console.WriteLine("===================")
            Console.WriteLine("Do you want to keep the temporary files?")
            Console.WriteLine("Temporary files are files downloaded from the internet that contain the mods that I install for you." + vbCrLf + "Keeping them may allow me to restore mods if they break, but it may use up storage on your hard drive. By default, this is set to NO.")
            question = MessageBox.Show("Keep temporary files?", "TF2 Mod Installer Setup", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
            If question = DialogResult.No Then
                Console.WriteLine("")
                Console.WriteLine("Okay, I WILL NOT keep the temporary files.")
                My.Settings.KeepTempFiles = False
                Console.WriteLine("Press ENTER to continue.")
                Console.ReadKey(Keys.Enter)
            ElseIf question = DialogResult.Yes Then
                Console.WriteLine("")
                Console.WriteLine("Okay, I WILL keep the temporary files.")
                My.Settings.KeepTempFiles = True
                Console.WriteLine("Press ENTER to continue.")
                Console.ReadKey(Keys.Enter)
            End If
            My.Settings.Save()
            settings()
        ElseIf choice = 6 Then
            appReset.resetWarning()
        ElseIf choice = 0 Then
            Main.Main()
        Else
            errorHandler.errorHandler("Selection menu error", "TF2MI-Error-00004", "You selected an option that either doesn't exist in the list, or is not a number." + vbCrLf + "Please press enter to recover.")
        End If
    End Sub
    Public Shared Sub about()
        Console.Clear()
        Console.Title = "Team Fortress 2 Mod Installer"
        Console.WriteLine("===================================")
        Console.WriteLine("= Team Fortress 2 Mod Installer   =")
        Console.WriteLine("===================================")
        Console.WriteLine("= GNU GPL V3.0                    =")
        Console.WriteLine("= Copyright © TheCrafters001 2020 =")
        Console.WriteLine("===================================")
        Console.WriteLine("Team Fortress 2 Mod Installer, or TF2 Mod Installer, is a free-to-use mod installer for the game Team Fortress 2.")
        Console.WriteLine("This software is free, and always will be. You can even view the source code on GitHub.")
        Console.WriteLine("This software uses the GNU GPL V3.0 License")
        Console.WriteLine(String.Format("Version: {0}", My.Application.Info.Version.ToString))
        Console.WriteLine("Press ENTER to continue.")
        Console.ReadKey(Keys.Enter)
        Main.Main()
    End Sub
    Public Shared Sub updateCheck()
        AutoUpdater.ShowSkipButton = True
        AutoUpdater.ShowRemindLaterButton = True
        AutoUpdater.ReportErrors = True
        AutoUpdater.RunUpdateAsAdmin = True
        AutoUpdater.LetUserSelectRemindLater = True
        AutoUpdater.RemindLaterTimeSpan = RemindLaterFormat.Hours
        AutoUpdater.RemindLaterAt = 1
        AutoUpdater.UpdateFormSize = New System.Drawing.Size(925, 665)
        AutoUpdater.Start("https://api.thecrafters001.ga/updates/modinstaller.xml")
        Console.WriteLine("Done!")
        Main.Main()
    End Sub
End Class
