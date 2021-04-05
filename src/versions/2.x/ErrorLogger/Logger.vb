Imports System.IO

Public Class Logger
    ' Well, this solution was made by Microsoft
    ' https://docs.microsoft.com/en-us/dotnet/standard/io/how-to-open-and-append-to-a-log-file
    ' Credit goes to them
    '
    ' Altered for my use case.
    Public Shared Sub Input(ByVal ErrorText As String)
        Using w As StreamWriter = File.AppendText("ErrorLog.txt")
            Log(ErrorText, w)
        End Using

        Using r As StreamReader = File.OpenText("ErrorLog.txt")
            DumpLog(r)
        End Using
    End Sub

    Public Shared Sub Log(logMessage As String, w As TextWriter)
        w.Write(vbCrLf + "Log Entry : ")
        w.WriteLine($"{DateTime.Now.ToLongTimeString()} {DateTime.Now.ToLongDateString()}")
        w.WriteLine("  :")
        w.WriteLine($"  :{logMessage}")
        w.WriteLine("-------------------------------")
    End Sub

    Public Shared Sub DumpLog(r As StreamReader)
        Dim line As String
        line = r.ReadLine()
        While Not (line Is Nothing)
            Console.WriteLine(line)
            line = r.ReadLine()
        End While
    End Sub
End Class
