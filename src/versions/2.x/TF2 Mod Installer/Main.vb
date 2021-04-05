Imports System.IO
Imports System.Windows.Forms

Module Main

    Sub Main()
        ' Change console foreground color to green,
        ' This will change the text color.
        Console.ForegroundColor = ConsoleColor.Green
        Console.Title = "Team Fortress 2 Mod Installer"
        Console.WriteLine("===================================")
        Console.WriteLine("= Team Fortress 2 Mod Installer   =")
        Console.WriteLine("===================================")
        Console.WriteLine("= GNU GPL V3.0                    =")
        Console.WriteLine("= Copyright (C) TheCrafters001 2020 =")
        Console.WriteLine("===================================")
        Checker()
    End Sub

    Sub ModInstaller()
        Console.WriteLine("Loading...")
        ' Define all user settings.
        ' This is done in case I need to use them as
        ' arguments in the main menu.
        Dim preferredName As String = My.Settings.PersonalName
        Dim customFolder As String = My.Settings.CustomFolder
        Dim tf2InstallPath As String = My.Settings.tf2InstallPath
        Dim backupMCS As Boolean = My.Settings.BackupMyCustomStuff
        Dim steam As String = My.Settings.SteamFolder
        Dim keeptemp As Boolean = My.Settings.KeepTempFiles

        ' Create choices.
        Dim choice As Integer

        Console.Clear()
        Console.Title = "Team Fortress 2 Mod Installer"
        Console.WriteLine("===================================")
        Console.WriteLine("= Team Fortress 2 Mod Installer   =")
        Console.WriteLine("===================================")
        Console.WriteLine("= GNU GPL V3.0                    =")
        Console.WriteLine("= Copyright (C) TheCrafters001 2020 =")
        Console.WriteLine("===================================")
        Console.WriteLine("Welcome, " + preferredName)
        Console.WriteLine("1) Install a Mod")
        Console.WriteLine("2) Uninstall a Mod")
        Console.WriteLine("3) Backup Options")
        Console.WriteLine("4) Settings")
        Console.WriteLine("5) About")
        Console.WriteLine("")
        Console.WriteLine("")
        Console.Write("Select an option: ")
        ' Read the input.
        Try
            choice = Console.ReadLine()
        Catch ex As Exception
            errorHandler.errorHandler(ex.ToString, "Selection menu error", "TF2MI-Error-00004", "You selected an option that either doesn't exist in the list, or is not a number." + vbCrLf + "Please press enter to recover.")
        End Try

        ' Check input.
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
        Else
            errorHandler.errorHandler("", "Selection menu error", "TF2MI-Error-00004", "You selected an option that either doesn't exist in the list, or is not a number." + vbCrLf + "Please press enter to recover.")
        End If
    End Sub

    Sub Checker()
        Console.WriteLine("Initializing...")
        If My.Settings.IsFirstTime = True Then
            ' Launch Presetup if this is the users first time
            ' using the tool.
            setup.PreSetup()
            Console.Title = "Team Fortress 2 Mod Installer"
            ModInstaller()
        ElseIf My.Settings.IsFirstTime = False Then
            ' Otherwise, carry on.
            ModInstaller()
        End If
    End Sub

End Module
