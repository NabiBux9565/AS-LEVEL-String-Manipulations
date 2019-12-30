Module Module1

    Sub Main()
        Dim ValidBinaryString, ValidNum, ValidLen As Boolean
        Dim Count, NumCount, NextNum, sum As Integer
        Dim Num1 As String
        Dim Binary As Integer = 128

        Count = 0
        NumCount = 0
        sum = 0
        Num1 = ""
        NextNum = 0
        ValidBinaryString = True
        ValidNum = True
        ValidLen = True

        Console.WriteLine("             This program converts binary into dec :")
        Console.WriteLine()
        Console.WriteLine()
        Console.WriteLine()
        Console.Write("Enter a binary numebr of 8 digits : ")
        Num1 = Console.ReadLine

        For Count = 1 To Len(Num1)
            NextNum = Mid(Num1, Count, 1)
            NumCount = NumCount + 1
            If NumCount > 8 Then
                ValidLen = False
            End If
        Next

        For Count = 1 To Len(Num1)
            NextNum = Mid(Num1, Count, 1)
            If Asc(NextNum) < 48 And Asc(NextNum) > 49 Then
                ValidLen = False
            End If
        Next

        If ValidLen = False Or ValidNum = False Then
            Console.WriteLine("Invalid binary : ")
        ElseIf ValidLen = True And ValidNum = True Then
            For Count = 1 To Len(Num1)
                NextNum = Mid(Num1, Count, 1)
                sum = sum + (NextNum * Binary)
                Binary = Binary / 2
            Next
            Console.Write("DECIMAL : " & sum)
        End If
        Console.ReadKey()






    End Sub

End Module
