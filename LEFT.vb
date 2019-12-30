Module Module1

    Sub Main()
        Dim x, y As String
        x = ""
        y = ""
        Console.Write("Enter your string : ")
        x = Console.ReadLine
        y = Left(x, 4)
        Console.WriteLine(" The last for characters of this string are as follows " & y)
        Console.ReadKey()



    End Sub

End Module
