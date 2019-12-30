Module Module1

    Sub Main()
        Dim Text, Extraction As String
        Dim NoCharacter, StartingFrom As Integer

        Text = ""
        Extraction = ""
        NoCharacter = 0
        StartingFrom = 0

        Console.WriteLine("             THIS PROGRAM EXTRACTS CHARACTERS FRIOM THE TEXT :")
        Console.WriteLine()
        Console.WriteLine()
        Console.WriteLine("Enter the text : ")
        Text = Console.ReadLine
        Console.Write(" Enter the number of characters to Extract : ")
        NoCharacter = Console.ReadLine
        Console.Write("Enter the starting postion of extraction : ")
        StartingFrom = Console.ReadLine
        Extraction = Mid(Text, StartingFrom, NoCharacter)
        Console.Write(" The extracted text is :  " & Extraction)
        Console.ReadKey()
    End Sub

End Module
