Imports System.Windows.Forms
Imports ModDownload
Imports UnRAR_Handler
Imports _7zhandler

Public Class MiscMenu
    Public Shared Sub Misc(ByVal IsUninstall As Boolean)
        Dim choice As Integer
        Dim isUninstallByVal As Boolean = IsUninstall
        Console.Clear()
        Console.Title = "TF2 Mod Installer - Mod Menu"
        If IsUninstall = False Then
            Console.WriteLine("=================================")
            Console.WriteLine("= Select a Misc to Install      =")
            Console.WriteLine("=================================")
        ElseIf IsUninstall = True Then
            Console.WriteLine("=================================")
            Console.WriteLine("= Select a Misc to Uninstall    =")
            Console.WriteLine("=================================")
        End If
        Console.WriteLine("1) Tiny Desk Engie Over Intel")
        Console.WriteLine("2) New Valve Intro")
        Console.WriteLine("3) Robo Heavy Sentry")
        Console.WriteLine("4) JJBA ""RETIRED"" Killsound")
        Console.WriteLine("5) Team Fortress 2 Classic")
        Console.WriteLine("0) Cancel")
        Console.WriteLine("")
        Console.WriteLine("")
        Console.Write("Select a HUD: ")
        Try
            choice = Console.ReadLine()
        Catch ex As Exception
            errorHandler.errorHandler("Selection menu error", "TF2MI-Error-00004", "You selected an option that either doesn't exist in the list, or is not a number." + vbCrLf + "Please press enter to recover.")
        End Try


        If choice = 0 Then
            modSelecter.ModMenu(IsUninstall)
        ElseIf choice = 1 Then
            Try
                If IsUninstall = False Then
                    Downloader.DownloadNow("TDE.zip", "https://files.gamebanana.com/skins/tiny_desk_engineers.zip", "Tiny Desk Engie Over Intel")
                    extract_install.ExtractNow("TDE.zip", "Tiny Desk Engie Over Intel", My.Settings.CustomFolder)
                    tempFileCleaner.Init()
                    Console.WriteLine("Done installing mod.")
                    Console.WriteLine("Press ENTER to continue.")
                    Console.ReadKey(Keys.Enter)
                    Main.Main()
                ElseIf IsUninstall = True Then
                    modUninstaller.UninstallFolder(My.Settings.CustomFolder & "\ahud-master", "ahud")
                    Console.WriteLine("Done removing mod.")
                    Console.WriteLine("Press ENTER to continue.")
                    Console.ReadKey(Keys.Enter)
                    Main.Main()
                End If
            Catch ex As Exception
                errorHandler.errorHandler(ex.ToString, "Failed to Install/Uninstall Mod", "TF2MI-Error-00007", "Something went wrong, and the mod could not be installed/uninstalled." + vbCrLf + "Please press enter to recover.")
            End Try
        ElseIf choice = 4 Then
            Try
                If IsUninstall = False Then
                    Downloader.DownloadNow("jjba_killsound.rar", "https://files.gamebanana.com/sounds/retired_killsound_9ce09.rar", "JJBA ""RETIRED"" Killsound")
                    UnRAR_Handler.extract_NoInstall.ExtractNow("jjba_killsound.rar", "JJBA RETIRED Killsound", My.Settings.CustomFolder)
                    sndModInstall.Install("JJBA ""RETIRED"" Killsound", "JJBA RETIRED Killsound\RETIRED! Killsound\ui", "ui")
                    tempFileCleaner.Init()
                    Console.WriteLine("Done installing mod.")
                    Console.WriteLine("Press ENTER to continue.")
                    Console.ReadKey(Keys.Enter)
                    Main.Main()
                ElseIf IsUninstall = True Then
                    ' modUninstaller.UninstallFolder(My.Settings.CustomFolder & "\tf2hudplus-master", "TF2 Hud Plus")
                    Console.WriteLine("Done removing mod.")
                    Console.WriteLine("Press ENTER to continue.")
                    Console.ReadKey(Keys.Enter)
                    Main.Main()
                End If
            Catch ex As Exception
                errorHandler.errorHandler(ex.ToString, "Failed to Install/Uninstall Mod", "TF2MI-Error-00007", "Something went wrong, and the mod could not be installed/uninstalled." + vbCrLf + "Please press enter to recover.")
            End Try
        ElseIf choice = 5 Then
            If IsUninstall = False Then
                Downloader.DownloadNow("tf2c_installer.exe", "https://github.com/TheCrafters001/TF2-Mod-Installer/releases/download/1.6/TF2-Classic_Installer.exe", "Team Fortress 2 Classic")
                TF2C.TF2CInst()
                tempFileCleaner.Init()
                Console.WriteLine("Done installing mod.")
                Console.WriteLine("Press ENTER to continue.")
                Console.ReadKey(Keys.Enter)
                Main.Main()
            ElseIf IsUninstall = True Then
                TF2C.TF2CUNInst()
                Console.WriteLine("Done removing mod.")
                Console.WriteLine("Press ENTER to continue.")
                Console.ReadKey(Keys.Enter)
                Main.Main()
            End If

        End If
    End Sub
End Class
