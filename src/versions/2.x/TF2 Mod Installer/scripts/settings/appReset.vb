Imports System.Windows.Forms

Public Class appReset
    Public Shared Sub resetWarning()
        Dim choice As String
        Dim finalChoice As String
        Console.Clear()
        Console.ForegroundColor = ConsoleColor.Red
        My.Computer.Audio.Play(My.Resources.siren, AudioPlayMode.BackgroundLoop)
        Console.WriteLine("===============================")
        Console.WriteLine("=           WARNING           =")
        Console.WriteLine("===============================")
        Console.WriteLine("THIS WILL RESET ALL SETTINGS IN THE APP.")
        Console.WriteLine("THE APP WILL NO LONGER REMEMBER ANYTHING IF YOU RESET IT!")
        Console.WriteLine("ONCE YOU RESET THE APP, IT WILL RESTART, AND THE SETUP WILL START")
        Console.WriteLine("")
        Console.Write("ARE YOU SURE YOU WANT TO RESET? [Y/N]: ")
        choice = Console.ReadLine()
        choice = choice.ToUpper
        Try
            If choice = "Y" Then
                My.Computer.Audio.Stop()
                My.Computer.Audio.Play(My.Resources.siren2, AudioPlayMode.BackgroundLoop)
                Console.WriteLine("")
                Console.WriteLine("FINAL WARNING.")
                Console.Write("ARE YOU REALLY SURE YOU WANT TO RESET? [Y/N]: ")
                finalChoice = Console.ReadLine()
                finalChoice = finalChoice.ToUpper
                If finalChoice = "Y" Then
                    My.Computer.Audio.Stop()
                    Console.Clear()
                    resetApp()
                ElseIf finalChoice = "N" Then
                    My.Computer.Audio.Stop()
                    Main.Main()
                End If
            ElseIf choice = "N" Then
                My.Computer.Audio.Stop()
                Main.Main()
            End If
        Catch ex As Exception

        End Try
    End Sub
    Public Shared Sub resetApp()
        Console.Title = "Resetting app..."
        Console.WriteLine("Resetting app...")
        Dim preferredName As String = ""
        Dim customFolder As String = ""
        Dim tf2InstallPath As String = ""
        Dim backupMCS As Boolean = True
        Dim steam As String = ""
        Dim keeptemp As Boolean = False
        Dim isFirstTime As Boolean = True
        My.Settings.PersonalName = preferredName
        My.Settings.CustomFolder = customFolder
        My.Settings.tf2InstallPath = tf2InstallPath
        My.Settings.BackupMyCustomStuff = backupMCS
        My.Settings.SteamFolder = steam
        My.Settings.KeepTempFiles = keeptemp
        My.Settings.IsFirstTime = isFirstTime
        My.Settings.Save()
        Threading.Thread.Sleep(5000)
        Console.WriteLine("TF2 Mod Installer has been reset, the app will now restart.")
        Threading.Thread.Sleep(5000)
        Application.Restart()
    End Sub
End Class
