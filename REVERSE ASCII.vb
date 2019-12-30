Module Module1

    Sub Main()
        Dim character As String
        Dim value As Integer

        character = ""
        value = 0

            Console.WriteLine("    This program is a reverse ASCII converter : ")
            Console.WriteLine()
            Console.WriteLine()
            Console.WriteLine()
            Console.WriteLine()

            Console.Write("Enter the value for the corresponding character : ")
            value = Console.ReadLine
            character = Chr(value)

            Console.WriteLine("  character :  " & character)

        Console.ReadKey()



    End Sub

End Module
