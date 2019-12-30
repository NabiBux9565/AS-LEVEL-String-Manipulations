Module Module1

    Sub Main()
        Dim Str1, Str2 As String
        Dim Count As Integer
        Dim NextChar As Char
        Dim IsPangram As Boolean



        Str1 = ""
        Str2 = ""
        Count = 0
        NextChar = ""
        IsPangram = True



        Console.WriteLine("                     PANGRAM ")
        Console.WriteLine()
        Console.WriteLine()
        Console.WriteLine()
        Console.WriteLine()
        Str1 = "ABCDEFGHIJKLMNOPQRSTUVWXYZ"

        Console.WriteLine("Enter the string : ")
        Str2 = Console.ReadLine
        Str2 = UCase(Str2)

        For Count = 1 To Len(Str1)
            NextChar = Mid(Str1, Count, 1)
            If InStr(Str1, NextChar) = 0 Then
                IsPangram = False
                Exit For
            End If
        Next

        If IsPangram = True Then
            Console.WriteLine("It is a pangram ")
        ElseIf IsPangram = False Then
            Console.WriteLine("Its not pangram ")
        End If

        Console.ReadKey()


    End Sub

End Module
