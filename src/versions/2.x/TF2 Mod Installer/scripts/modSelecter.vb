Imports ModDownload
Imports _7zhandler
Imports UnRAR_Handler
Imports System.Windows.Forms

Public Class modSelecter
    Public Shared Sub ModMenu(ByVal isUninstall As Boolean)
        Dim choice As Integer
        Dim isUninstallByVal As Boolean = isUninstall
        Console.Clear()
        Console.Title = "TF2 Mod Installer - Mod Menu"
        Console.WriteLine("=======================")
        If isUninstall = False Then
            Console.WriteLine("= Install a Mod       =")
        ElseIf isUninstall = True Then
            Console.WriteLine("= Uninstall a Mod     =")
        End If
        Console.WriteLine("=======================")
        Console.WriteLine("1) HUDs")
        Console.WriteLine("2) Animation Overhauls")
        Console.WriteLine("3) View models (54 FOV)")
        Console.WriteLine("4) View models (70+ FOV)")
        Console.WriteLine("5) Model Replacer")
        Console.WriteLine("6) Misc")
        Console.WriteLine("0) Cancel")
        Console.Write("Select a Category: ")
        Try
            choice = Console.ReadLine()
        Catch ex As Exception
            errorHandler.errorHandler("Selection menu error", "TF2MI-Error-00004", "You selected an option that either doesn't exist in the list, or is not a number." + vbCrLf + "Please press enter to recover.")
        End Try


        If choice = 0 Then
            Main.Main()
        ElseIf choice = 1 Then
            Huds(isUninstall)
        ElseIf choice = 2 Then

        ElseIf choice = 3 Then

        ElseIf choice = 4 Then

        ElseIf choice = 5 Then

        ElseIf choice = 6 Then

        Else
            errorHandler.errorHandler("Selection menu error", "TF2MI-Error-00004", "You selected an option that either doesn't exist in the list, or is not a number." + vbCrLf + "Please press enter to recover.")
        End If
    End Sub

    Public Shared Sub Huds(ByVal isUninstall As Boolean)
        Dim choice As Integer
        Dim isUninstallByVal As Boolean = isUninstall
        Console.Clear()
        Console.Title = "TF2 Mod Installer - Mod Menu"
        Console.WriteLine("=======================")
        If isUninstall = False Then
            Console.WriteLine("= Select a HUD to Install       =")
        ElseIf isUninstall = True Then
            Console.WriteLine("= Select a HUD to Uninstall     =")
        End If
        Console.WriteLine("=======================")
        Console.WriteLine("1) TF2 Hud Plus")
        Console.WriteLine("2) rayshud")
        Console.WriteLine("3) FlawHUD")
        Console.WriteLine("4) ahud")
        Console.WriteLine("5) ToonHUD (default settings)")
        Console.WriteLine("5) Budhud")
        Console.WriteLine("0) Cancel")
        Try
            choice = Console.ReadLine()
        Catch ex As Exception
            errorHandler.errorHandler("Selection menu error", "TF2MI-Error-00004", "You selected an option that either doesn't exist in the list, or is not a number." + vbCrLf + "Please press enter to recover.")
        End Try


        If choice = 0 Then
            ModMenu(isUninstall)
        ElseIf choice = 1 Then
            If isUninstall = False Then
                Downloader.DownloadNow("tf2_Hud_Plus.zip", "https://github.com/SnowshoeIceboot/tf2hudplus/archive/master.zip", "TF2 Hud Plus")
                extract_install.ExtractNow("tf2_Hud_Plus.zip", "TF2 Hud Plus", My.Settings.CustomFolder)

                Console.WriteLine("Done installing mod.")

                Console.WriteLine("Press ENTER to continue.")
                Console.ReadKey(Keys.Enter)
                Main.Main()
            ElseIf isUninstall = True Then

            End If
        ElseIf choice = 2 Then
            If isUninstall = False Then

            ElseIf isUninstall = True Then

            End If
        ElseIf choice = 3 Then
            If isUninstall = False Then

            ElseIf isUninstall = True Then

            End If
        ElseIf choice = 4 Then
            If isUninstall = False Then

            ElseIf isUninstall = True Then

            End If
        ElseIf choice = 5 Then
            If isUninstall = False Then

            ElseIf isUninstall = True Then

            End If
        End If
    End Sub

End Class
