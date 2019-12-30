Module Module1

    Sub Main()
        'DECLARATION
        Dim string1, string2, FName1, FName2, LName1, LName2, match As String
        Dim position1, position2 As Integer
        Dim RKey As Boolean = True
        Dim EKey As Boolean = True

        'INITIALISATION
        string1 = ""
        string2 = ""
        FName1 = ""
        FName2 = ""
        LName1 = ""
        LName2 = ""
        match = ""
        position1 = 0
        position2 = 0

        'PROCESS
        Do While EKey = True
            Console.WriteLine("               This program reverse the last names of two full names : ")
            Console.WriteLine()
            Console.WriteLine()
            Console.WriteLine()
            Console.WriteLine()
            Console.WriteLine()
            Console.Write("Enter first full name  : ")
            string1 = Console.ReadLine

            Console.Write("Enter second full name : ")
            string2 = Console.ReadLine

            position1 = InStr(string1, " ")
            position2 = InStr(string2, " ")

            FName1 = Left(string1, position1)
            FName2 = Left(string2, position2)

            LName1 = Right(string1, Len(string1) - position1)
            LName2 = Right(string2, Len(string2) - position2)

            'OUTPUT
            Console.Write("RESULT : " & FName1 & LName2)
            Console.WriteLine()
            Console.Write("RESULT : " & FName2 & LName1)
            Console.WriteLine()
            Console.WriteLine()
            Console.WriteLine()
            Console.WriteLine()
            Console.WriteLine()
            Console.WriteLine()
            Console.Write("Press E to end the program ...  ")
            match = Console.ReadLine
            match = UCase(match)
            If match = "E" Then
                EKey = False
            End If
            Console.ReadKey()
            Console.Clear()

        Loop






















    End Sub

End Module
