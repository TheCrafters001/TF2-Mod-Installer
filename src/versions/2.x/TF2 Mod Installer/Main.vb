Module Main

    Sub Main()
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

    End Sub

    Sub Checker()
        If My.Settings.IsFirstTime = True Then
            setup.PreSetup()
        ElseIf My.Settings.IsFirstTime = False Then
            ModInstaller()
        End If
    End Sub

End Module
