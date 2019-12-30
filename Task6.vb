Module Module1

    Sub Main()
        Dim Str1, Char1, Char2, Str2 As String
        Dim Count, Sum1, Sum2 As Integer

        Str1 = ""
        Char1 = ""
        Char2 = ""
        Str2 = ""
        Count = 0
        Sum1 = 0
        Sum2 = 0

        Console.WriteLine("                 This program identifies ANAGRAM sentences :")
        Console.WriteLine()
        Console.WriteLine()
        Console.WriteLine()

        Console.Write("Enter the first sentence : ")
        Str1 = Console.ReadLine

        Console.WriteLine("Enter the second sentence : ")
        Str2 = Console.ReadLine

        For Count = 1 To Len(Str1)
            Char1 = Mid(Str1, Count, 1)
            Sum1 = Sum1 + Asc(Char1)
        Next

        For Count = 1 To Len(Str2)
            Char2 = Mid(Str2, Count, 1)
            Sum2 = Sum2 + Asc(Char2)
        Next

        If Sum1 = Sum2 Then
            Console.WriteLine("It is a ANAGRAM")
        Else
            Console.WriteLine("It is not an ANAGRAM ")
        End If
        Console.ReadKey()

    End Sub

End Module
