Module Module1

    Sub Main()
        Dim string1, string2, char1 As String
        Dim SPostion1, SPosition2, loop1, lenthM1 As Integer

        string1 = ""
        string2 = ""
        char1 = ""
        SPostion1 = 0
        SPosition2 = 0
        loop1 = 0
        lenthM1 = 0
        Const space = " "

        Console.WriteLine("             THIS PROGRAM OUTPUTS THE MIDDLE WORD OF THE 3 WORDS STRING : ")
        Console.WriteLine()
        Console.WriteLine()
        Console.WriteLine()
        Console.WriteLine()
        Console.WriteLine()
        Console.Write("Enter first string of 3 words : ")
        string1 = Console.ReadLine

        SPostion1 = InStr(string1, " ")
        For loop1 = SPostion1 To Len(string1) - SPostion1
            char1 = Mid(string1, loop1, 1)
            If char1 = space Then
                SPosition2 = loop1
            End If
        Next
        lenthM1 = SPosition2 - SPostion1
        string2 = Mid(string1, SPostion1, lenthM1)
        Console.Write("This is middle string : " & string2)
        Console.ReadKey()










    End Sub

End Module
