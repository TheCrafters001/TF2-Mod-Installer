Imports System.IO
Imports System.Windows.Forms

Module Main

    Sub Main()
        Console.ForegroundColor = ConsoleColor.Green
        Console.Title = "Team Fortress 2 Mod Installer"
        Console.WriteLine("===================================")
        Console.WriteLine("= Team Fortress 2 Mod Installer   =")
        Console.WriteLine("===================================")
        Console.WriteLine("= GNU GPL V3.0                    =")
        Console.WriteLine("= Copyright © TheCrafters001 2020 =")
        Console.WriteLine("===================================")
        Checker()
    End Sub

    Sub ModInstaller()
        Console.WriteLine("Loading...")
        Dim preferredName As String = My.Settings.PersonalName
        Dim customFolder As String = My.Settings.CustomFolder
        Dim tf2InstallPath As String = My.Settings.tf2InstallPath
        Dim backupMCS As Boolean = My.Settings.BackupMyCustomStuff
        Dim steam As String = My.Settings.SteamFolder
        Dim keeptemp As Boolean = My.Settings.KeepTempFiles

        Dim choice As Integer

        Console.Clear()
        Console.Title = "Team Fortress 2 Mod Installer"
        Console.WriteLine("===================================")
        Console.WriteLine("= Team Fortress 2 Mod Installer   =")
        Console.WriteLine("===================================")
        Console.WriteLine("= GNU GPL V3.0                    =")
        Console.WriteLine("= Copyright © TheCrafters001 2020 =")
        Console.WriteLine("===================================")
        Console.WriteLine("Welcome, " + preferredName)
        Console.WriteLine("1) Install a Mod")
        Console.WriteLine("2) Uninstall a Mod")
        Console.WriteLine("3) Backup Options")
        Console.WriteLine("4) Settings")
        Console.WriteLine("5) About")
        Console.WriteLine("6) Check for Updates")
        Console.WriteLine("")
        Console.WriteLine("")
        Console.Write("Select an option: ")
        Try
            choice = Console.ReadLine()
        Catch ex As Exception
            errorHandler.errorHandler("Selection menu error", "TF2MI-Error-00004", "You selected an option that either doesn't exist in the list, or is not a number." + vbCrLf + "Please press enter to recover.")
        End Try


        If choice = 1 Then
            modSelecter.ModMenu(False)
        ElseIf choice = 2 Then
            modSelecter.ModMenu(True)
        ElseIf choice = 3 Then
            backupMenu.backupMenu()
        ElseIf choice = 4 Then
            settingsMenu.settings()
        ElseIf choice = 5 Then
            settingsMenu.about()
        ElseIf choice = 6 Then
            Console.WriteLine("Checking for updates...")
            settingsMenu.updateCheck()
        Else
            errorHandler.errorHandler("Selection menu error", "TF2MI-Error-00004", "You selected an option that either doesn't exist in the list, or is not a number." + vbCrLf + "Please press enter to recover.")
        End If
    End Sub

    Sub Checker()
        Console.WriteLine("Initializing...")
        If My.Settings.IsFirstTime = True Then
            setup.PreSetup()
            Console.Title = "Team Fortress 2 Mod Installer"
            ModInstaller()
        ElseIf My.Settings.IsFirstTime = False Then
            ModInstaller()
        End If
    End Sub

End Module
