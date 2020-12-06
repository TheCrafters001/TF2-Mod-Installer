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
        Console.WriteLine("0) Cancel")
        Console.WriteLine("1) HUDs")
        Console.WriteLine("2) View models (54 FOV)")
        Console.WriteLine("2) View models (70+ FOV)")
        Console.WriteLine("3) Model Replacer")
        Console.WriteLine("4) Misc")
        Console.Write("Select a Category: ")
        Try
            choice = Console.ReadLine()
        Catch ex As Exception
            errorHandler.errorHandler("Selection menu error", "TF2MI-Error-00004", "You selected an option that either doesn't exist in the list, or is not a number." + vbCrLf + "Please press enter to recover.")
        End Try


        If choice = 0 Then
            Main.Main()
        ElseIf choice = 1 Then

        ElseIf choice = 2 Then

        ElseIf choice = 3 Then

        ElseIf choice = 4 Then

        ElseIf choice = 5 Then

        Else
            errorHandler.errorHandler("Selection menu error", "TF2MI-Error-00004", "You selected an option that either doesn't exist in the list, or is not a number." + vbCrLf + "Please press enter to recover.")
        End If
    End Sub
End Class
