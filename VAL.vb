Module Module1

    Sub Main()
        Dim input, KEY As String
        Dim output As Integer
        Dim Ekey As Boolean = True
        input = ""
        output = 0

        Do While Ekey <> False
            Console.WriteLine("                 THIS PROGRAM USES VAL FUNCTION  ")
            Console.WriteLine()
            Console.WriteLine()
            Console.WriteLine()
            Console.WriteLine()
            Console.WriteLine()

            Console.WriteLine("Enter string : ")
            input = Console.ReadLine

            output = Val(input)

            Console.WriteLine("Result : " & input)

            Console.WriteLine()
            Console.WriteLine()
            Console.WriteLine()
            Console.WriteLine()
            Console.WriteLine()
            Console.WriteLine()

            Console.WriteLine("PRESS ANY KEY TO CONTINUE AND  E TO EXIT :  ")
            KEY = Console.ReadLine
            KEY = UCase(KEY)
            If KEY = "E" Then
                Ekey = False
            End If

            Console.ReadKey()
            Console.Clear()
        Loop


    End Sub

End Module
