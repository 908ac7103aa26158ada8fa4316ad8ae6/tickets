Module Module1

    Sub Main()
        Dim num As Integer
        Dim digit_1 As Integer
        Dim digit_2 As Integer
        Dim digit_3 As Integer
        Dim digit_4 As Integer

        Randomize()
        num = Int((9999 - 1000 + 1) * Rnd() + 1000)

        Console.WriteLine(num)

        digit_1 = num \ 1000
        digit_2 = (num \ 100) Mod 10
        digit_3 = (num \ 10) Mod 10
        digit_4 = num Mod 10

        If digit_1 = digit_2 Or digit_1 = digit_3 Or digit_1 = digit_4 _
            Or digit_2 = digit_3 Or digit_2 = digit_4 _
            Or digit_3 = digit_4 Then
            Console.WriteLine("В номере есть повторяющиеся цифры")
        Else
            Console.WriteLine("В номере нет повторяющихся цифр")
        End If

        Console.ReadKey()
    End Sub

End Module
