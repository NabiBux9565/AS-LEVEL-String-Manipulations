Module Module1

    Sub Main()
        Dim text, Searched, output, looping, ulooping As String

        text = ""
        Searched = ""
        output = ""
        looping = ""
        ulooping = ""
        Do While output <> "0"
            Console.WriteLine("            This program searches the text in the given string : ")
            Console.WriteLine()
            Console.WriteLine()
            Console.WriteLine()
            Console.WriteLine()

            Console.Write("Enter the text : ")
            text = Console.ReadLine

            Console.Write(" Enter the text to search  :")
            Searched = Console.ReadLine

            output = InStr(text, Searched)
            Console.WriteLine(" Result :  " & output)

            If output = 0 Then
                Console.WriteLine(" not found ")
            End If
            Console.ReadKey()
            Console.Clear()
        Loop

    End Sub

End Module
