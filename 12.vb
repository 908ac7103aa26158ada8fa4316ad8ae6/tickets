Module Module1

    Sub Main()
        Dim product As Integer = 1
        Dim num As Integer

        Do
            num = Console.ReadLine()
            product *= num
        Loop Until num = 1

        Console.WriteLine("Произведение: " & product)

        Console.ReadKey()
    End Sub

End Module
