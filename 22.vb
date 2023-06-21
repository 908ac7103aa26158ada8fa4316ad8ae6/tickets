Module Module1

    Sub Main()
        Dim arr(4) As Integer

        For i As Integer = 0 To 4
            arr(i) = Console.ReadLine()
        Next

        Dim min As Integer = arr(0)
        Dim min_index As Integer = 0

        For i As Integer = 1 To 4
            If arr(i) < min Then
                min = arr(i)
                min_index = i
            End If
        Next

        Console.WriteLine("Минимальный элемент: " & min)
        Console.WriteLine("Индекс минимального элемента: " & min_index)

        Console.ReadKey()
    End Sub

End Module