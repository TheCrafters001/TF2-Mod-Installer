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
        Console.WriteLine("= This menu is non-functional   =")
        Console.WriteLine("= at the moment                 =")
        Console.WriteLine("=================================")
        Console.WriteLine("1) Tiny Desk Engie Over Intel")
        Console.WriteLine("2) New Valve Intro")
        Console.WriteLine("3) Robo Heavy Sentry")
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
        End If
    End Sub
End Class
