Module Module1

    Sub Main()
        Dim character As String
        Dim int As Integer

        character = ""
        int = 0

        Do While character <> "0"
            Console.WriteLine("         This program outputs the ASCII of given characters ")
            Console.WriteLine()
            Console.WriteLine()
            Console.WriteLine()
            Console.WriteLine()

            Console.Write("Enter the character :  ")
            character = Console.ReadLine

            int = Asc(character)
            Console.Write("  The ASCII value for this character is:  " & int)
            Console.ReadKey()
            Console.Clear()
        Loop




    End Sub

End Module
