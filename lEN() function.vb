Module Module1

    Sub Main()
        Dim y As Integer
        Dim x As String

        y = 0
        x = ""

        Console.WriteLine("                 THIS PROGRAM WILL OUTPUT THE NUMBER OF CHADRACTERS IN THE STRING")
        Console.WriteLine()
        Console.WriteLine()
        Console.Write(" Enter your string : ")
        x = Console.ReadLine
        y = Len(x)
        Console.WriteLine(" This string contain " & y & " characters")
        Console.ReadKey()
    End Sub

End Module
