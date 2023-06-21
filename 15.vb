Module Module1

    Sub Main()
        Dim arr(4) As Integer

        For i As Integer = 0 To 4
            arr(i) = Console.ReadLine()
        Next

        Console.WriteLine("Введите искомое число:")
        Dim searchValue As Integer = Console.ReadLine()
        Dim index As Integer = -1

        For i As Integer = 0 To 4
            If arr(i) = searchValue Then
                index = i
                Exit For
            End If
        Next

        If index <> -1 Then
            Console.WriteLine("Искомое число найдено в массиве")
            Console.WriteLine("Индекс искомого числа: " & index)
        Else
            Console.WriteLine("Искомое число не найдено в массиве")
        End If

        Console.ReadKey()
    End Sub

End Module
