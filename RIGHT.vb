Module Module1

    Sub Main()
        Dim text, Extraction As String
        Dim NoCharacters As Integer

        text = ""
        NoCharacters = 0
        Extraction = ""

        Console.WriteLine("         THIS PROGRAM EXTRACTS NO OF CHARACTERS FROM THE TEXT : ")
        Console.WriteLine()
        Console.WriteLine()
        Console.WriteLine()
        Console.Write("Enter the string  :")
        text = Console.ReadLine
        Console.Write("Enter number of characters to extract from the text ")
        NoCharacters = Console.ReadLine
        Extraction = Right(text, NoCharacters)
        Console.WriteLine("  The extracted characters are : " & Extraction)
        Console.ReadKey()

    End Sub

End Module
