Imports ModDownload
Imports _7zhandler
Imports UnRAR_Handler
Imports System.Windows.Forms

Public Class HudMenu
    Public Shared Sub Huds(ByVal isUninstall As Boolean)
        Dim choice As Integer
        Dim isUninstallByVal As Boolean = isUninstall
        Console.Clear()
        Console.Title = "TF2 Mod Installer - Mod Menu"
        If isUninstall = False Then
            Console.WriteLine("=================================")
            Console.WriteLine("= Select a HUD to Install       =")
            Console.WriteLine("=================================")
        ElseIf isUninstall = True Then
            Console.WriteLine("=================================")
            Console.WriteLine("= Select a HUD to Uninstall     =")
            Console.WriteLine("=================================")
        End If
        Console.WriteLine("1) TF2 Hud Plus")
        Console.WriteLine("2) rayshud")
        Console.WriteLine("3) FlawHUD")
        Console.WriteLine("4) ahud")
        Console.WriteLine("5) Budhud")
        Console.WriteLine("0) Cancel")
        Console.WriteLine("")
        Console.WriteLine("")
        Console.Write("Select a HUD: ")
        Try
            choice = Console.ReadLine()
        Catch ex As Exception
            errorHandler.errorHandler(ex.ToString, "Selection menu error", "TF2MI-Error-00004", "You selected an option that either doesn't exist in the list, or is not a number." + vbCrLf + "Please press enter to recover.")
        End Try


        If choice = 0 Then
            modSelecter.ModMenu(isUninstall)
        ElseIf choice = 1 Then
            Try
                If isUninstall = False Then
                    Downloader.DownloadNow("tf2_Hud_Plus.zip", "https://github.com/SnowshoeIceboot/tf2hudplus/archive/master.zip", "TF2 Hud Plus")
                    extract_install.ExtractNow("tf2_Hud_Plus.zip", "TF2 Hud Plus", My.Settings.CustomFolder)
                    tempFileCleaner.Init()
                    Console.WriteLine("Done installing mod.")
                    Console.WriteLine("Press ENTER to continue.")
                    Console.ReadKey(Keys.Enter)
                    Main.Main()
                ElseIf isUninstall = True Then
                    modUninstaller.UninstallFolder(My.Settings.CustomFolder & "\tf2hudplus-master", "TF2 Hud Plus")
                    Console.WriteLine("Done removing mod.")
                    Console.WriteLine("Press ENTER to continue.")
                    Console.ReadKey(Keys.Enter)
                    Main.Main()
                End If
            Catch ex As Exception
                errorHandler.errorHandler(ex.ToString, "Failed to Install/Uninstall Mod", "TF2MI-Error-00007", "Something went wrong, and the mod could not be installed/uninstalled." + vbCrLf + "Please press enter to recover.")
            End Try
        ElseIf choice = 2 Then
            Try
                If isUninstall = False Then
                    Downloader.DownloadNow("rayshud.zip", "https://github.com/raysfire/rayshud/archive/refs/heads/master.zip", "rayshud")
                    extract_install.ExtractNow("rayshud.zip", "rayshud", My.Settings.CustomFolder)
                    tempFileCleaner.Init()
                    Console.WriteLine("Done installing mod.")
                    Console.WriteLine("Press ENTER to continue.")
                    Console.ReadKey(Keys.Enter)
                    Main.Main()
                ElseIf isUninstall = True Then
                    modUninstaller.UninstallFolder(My.Settings.CustomFolder & "\rayshud-master", "rayshud")
                    Console.WriteLine("Done removing mod.")
                    Console.WriteLine("Press ENTER to continue.")
                    Console.ReadKey(Keys.Enter)
                    Main.Main()
                End If
            Catch ex As Exception
                errorHandler.errorHandler(ex.ToString, "Failed to Install/Uninstall Mod", "TF2MI-Error-00007", "Something went wrong, and the mod could not be installed/uninstalled." + vbCrLf + "Please press enter to recover.")
            End Try
        ElseIf choice = 3 Then
            Try
                If isUninstall = False Then
                    Downloader.DownloadNow("FlawHUD.zip", "https://github.com/CriticalFlaw/flawhud/archive/refs/heads/master.zip", "FlawHUD")
                    extract_install.ExtractNow("FlawHUD.zip", "FlawHUD", My.Settings.CustomFolder)
                    tempFileCleaner.Init()
                    Console.WriteLine("Done installing mod.")
                    Console.WriteLine("Press ENTER to continue.")
                    Console.ReadKey(Keys.Enter)
                    Main.Main()
                ElseIf isUninstall = True Then
                    modUninstaller.UninstallFolder(My.Settings.CustomFolder & "\FlawHUD-master", "FlawHUD")
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
                If isUninstall = False Then
                    Downloader.DownloadNow("ahud.zip", "https://github.com/n0kk/ahud/archive/refs/heads/master.zip", "ahud")
                    extract_install.ExtractNow("ahud.zip", "ahud", My.Settings.CustomFolder)
                    tempFileCleaner.Init()
                    Console.WriteLine("Done installing mod.")
                    Console.WriteLine("Press ENTER to continue.")
                    Console.ReadKey(Keys.Enter)
                    Main.Main()
                ElseIf isUninstall = True Then
                    modUninstaller.UninstallFolder(My.Settings.CustomFolder & "\ahud-master", "ahud")
                    Console.WriteLine("Done removing mod.")
                    Console.WriteLine("Press ENTER to continue.")
                    Console.ReadKey(Keys.Enter)
                    Main.Main()
                End If
            Catch ex As Exception
                errorHandler.errorHandler(ex.ToString, "Failed to Install/Uninstall Mod", "TF2MI-Error-00007", "Something went wrong, and the mod could not be installed/uninstalled." + vbCrLf + "Please press enter to recover.")
            End Try
        ElseIf choice = 5 Then
            Try
                If isUninstall = False Then
                    Downloader.DownloadNow("budhud.zip", "https://github.com/rbjaxter/budhud/archive/refs/heads/master.zip", "budhud")
                    extract_install.ExtractNow("budhud.zip", "budhud", My.Settings.CustomFolder)
                    tempFileCleaner.Init()
                    Console.WriteLine("Done installing mod.")
                    Console.WriteLine("Press ENTER to continue.")
                    Console.ReadKey(Keys.Enter)
                    Main.Main()
                ElseIf isUninstall = True Then
                    modUninstaller.UninstallFolder(My.Settings.CustomFolder & "\budhud-master", "budhud")
                    Console.WriteLine("Done removing mod.")
                    Console.WriteLine("Press ENTER to continue.")
                    Console.ReadKey(Keys.Enter)
                    Main.Main()
                End If
            Catch ex As Exception
                errorHandler.errorHandler(ex.ToString, "Failed to Install/Uninstall Mod", "TF2MI-Error-00007", "Something went wrong, and the mod could not be installed/uninstalled." + vbCrLf + "Please press enter to recover.")
            End Try
        End If
    End Sub
End Class
