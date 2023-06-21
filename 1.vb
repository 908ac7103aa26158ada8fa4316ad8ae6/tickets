Module Module1

    Sub Main()
        Console.WriteLine("Введите натуральное число:")

        Dim user_number As ULong
        Dim factorial As ULong
        Dim i As ULong

        user_number = ULong.Parse(Console.ReadLine())
        factorial = 1

        For i = 1 To user_number
            factorial = factorial * i
        Next

        Console.WriteLine("Факториал числа " & user_number & " равен " & factorial)
        Console.ReadKey()
    End Sub

End Module
