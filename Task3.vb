Module Module1

    Sub Main()
        Dim string1, string2, string3 As String
        Dim loop1 As Integer
        Const space = " "

        string3 = ""
        string1 = ""
        string2 = ""
        loop1 = 0

        Console.WriteLine("         This program shows isolated form of words  :")
        Console.WriteLine()
        Console.WriteLine()
        Console.WriteLine()
        Console.WriteLine()
        Console.WriteLine()
        Console.Write("Enter string for isolated form : ")
        string1 = Console.ReadLine

        For loop1 = 1 To Len(string1)
            string2 = Mid(string1, loop1, 1)
            string3 = string3 & string2
            If string2 = space Then
                Console.WriteLine(string3)
                string3 = ""
            End If
        Next
        Console.WriteLine(string3)
        Console.ReadKey()





    End Sub

End Module
