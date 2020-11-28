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
        Console.Clear()
        Console.Title = "Team Fortress 2 Mod Installer"
        Console.WriteLine("===================================")
        Console.WriteLine("= Team Fortress 2 Mod Installer   =")
        Console.WriteLine("===================================")
        Console.WriteLine("= GNU GPL V3.0                    =")
        Console.WriteLine("= Copyright © TheCrafters001 2020 =")
        Console.WriteLine("===================================")
        Console.WriteLine("Welcome, " + preferredName)
        Console.WriteLine("Press ENTER to continue.")
        Console.ReadKey(Keys.Enter)
    End Sub

    Sub Checker()
        If My.Settings.IsFirstTime = True Then
            setup.PreSetup()
            Console.Title = "Team Fortress 2 Mod Installer"
            ModInstaller()
        ElseIf My.Settings.IsFirstTime = False Then
            ModInstaller()
        End If
    End Sub

End Module
