Module Module1

    Sub Main()
        Dim str1, str2, char1, char2, newstr, char3 As String
        Dim loop1 As Integer
        Dim repeat As Boolean = False

        str1 = ""
        str2 = ""
        char1 = ""
        char2 = ""
        loop1 = 0
        newstr = ""
        char3 = ""

        Console.WriteLine("This program replaces the special charachter in the string :")
        Console.WriteLine()
        Console.WriteLine()
        Console.WriteLine()
        Console.WriteLine()
        Console.WriteLine()

        Do While repeat = False
            Console.Write("Enter the string with the special character :")
            str1 = Console.ReadLine

            Console.Write("Enter the special character in the string : ")
            str2 = Console.ReadLine

            Console.Write("Enter the character the character to repalace : ")
            char1 = Console.ReadLine

            For loop1 = 1 To Len(str1)
                char2 = Mid(str1, loop1, 1)
                If char2 = str2 Then
                    char2 = char1
                End If
                newstr = newstr & char2
            Next
            Console.Write("NEW STRING : " & newstr)
            Console.WriteLine()
            Console.WriteLine()
            Console.WriteLine()

            Console.WriteLine("Enter E to exit.....")
            char3 = Console.ReadLine
            char3 = UCase(char3)
            If char3 = "E" Then
                repeat = False
            End If
        Console.Clear()
        Console.ReadKey()
        Loop
    End Sub

End Module
