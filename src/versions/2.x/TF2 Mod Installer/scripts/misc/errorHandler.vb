Imports System.Windows.Forms
Imports ErrorLogger

Public Class errorHandler
    Public Shared Sub errorHandler(ByVal Er As String, Optional ByVal errorName As String = "Unknown", Optional ByVal errorCode As String = "TF2MI-Error-00000", Optional ByVal errorString As String = "No full error is needed for this type of error.")
        Logger.Input(errorName + " (" + errorCode + ") (" + errorString + ")" + vbCrLf + Er)
        Console.WriteLine("")
        Console.WriteLine("")
        Console.WriteLine("")
        Console.ForegroundColor = ConsoleColor.Red
        Console.WriteLine("=========")
        Console.WriteLine("= ERROR =")
        Console.WriteLine("=========")
        Console.WriteLine("The following error occured: ")
        Console.WriteLine("")
        Console.WriteLine(errorName + " (" + errorCode + ")")
        Console.WriteLine("")
        Console.WriteLine("If you would like to report it, please visit the GitHub issues page here:")
        Console.WriteLine("https://github.com/TheCrafters001/TF2-Mod-Installer/issues/new")
        Console.WriteLine("The full error will now be displayed, if needed:")
        Console.WriteLine("")
        Console.WriteLine(errorString)
        Console.WriteLine("")
        Console.WriteLine("For full error details, an error file has been saved at: " & Environment.CurrentDirectory & "\ErrorLog.txt")
        Console.WriteLine("Press ENTER to attempt to recover.")
        Console.ReadKey(Keys.Enter)
        Try
            Main.Main()
        Catch ex As Exception
            Console.WriteLine("Cannot recover. The app will now close.")
            Console.WriteLine("Press ENTER to exit.")
            Console.ReadKey(Keys.Enter)
            Application.Exit()
        End Try
    End Sub
End Class
