Module Module1

    Sub Main()
        Dim arr(5) As Integer

        Console.WriteLine("Введите 5 цифр по отдельности:")

        For i As Integer = 0 To 4
            arr(i) = Console.ReadLine()
        Next

        Console.WriteLine("Массив в прямом порядке: ")

        For i As Integer = 0 To 4
            Console.Write(arr(i) & " ")
        Next

        Console.WriteLine(vbNewLine & "Массив в обратном порядке: ")

        For i As Integer = 4 To 0 Step -1
            Console.Write(arr(i) & " ")
        Next

        Console.WriteLine(vbNewLine & "Введите строку:")

        Dim str As String = Console.ReadLine()

        Console.Write("Строка в обратном порядке: ")

        For i As Integer = str.Length - 1 To 0 Step -1
            Console.Write(str(i))
        Next

        Console.ReadKey()
    End Sub

End Module
