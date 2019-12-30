Module Module1

    Sub Main()
        Dim str1, str2, newstr, char1 As String
        Dim loop1 As Integer
        Dim repeat As Boolean = False

        str1 = ""
        str2 = ""
        newstr = ""
        char1 = ""
        Console.WriteLine("                 This program inverses the string   : ")
        Console.WriteLine()
        Console.WriteLine()
        Console.WriteLine()
        Console.WriteLine()
        Console.WriteLine()

            Console.Write("Enter the string: ")
            str1 = Console.ReadLine

            For loop1 = 1 To Len(str1)
                str2 = Mid(str1, loop1, 1)
                newstr = str2 & newstr
            Next
            Console.Write("INVERSE STRING : " & newstr)
            Console.ReadKey()






    End Sub

End Module
