Module Module1

    Sub Main()
        Dim str1, MyNum, MySymbols, MyLetters, Char1, char2 As String
        Dim count As Integer

        str1 = ""
        MyNum = ""
        MySymbols = ""
        MyLetters = ""
        Char1 = ""
        char2 = ""
        count = 0

        Console.WriteLine("      This program identifies number,letters,symbols in a string ")
        Console.WriteLine()
        Console.WriteLine()
        Console.WriteLine()

        Console.Write("Enter the string : ")
        str1 = Console.ReadLine

        For count = 1 To Len(str1)
            Char1 = Mid(str1, count, 1)
            If Asc(UCase(Char1)) >= 65 And Asc(UCase(Char1)) <= 91 Then
                MyLetters = MyLetters & Char1
            ElseIf Asc(Char1) >= 48 And Asc(Char1) <= 57 Then
                MyNum = MyNum & Char1
            Else
                MySymbols = MySymbols & Char1
            End If
        Next
        Console.WriteLine("LETTERS   : " & MyLetters)
        Console.WriteLine("NUMBERS   : " & MyNum)
        Console.WriteLine("symnbols  : " & MySymbols)
        Console.ReadKey()



    End Sub

End Module
