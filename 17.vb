Module Module1

    ' Функция для сортировки массива методом выбора
    Sub sort(ByRef list As String())
        Dim n As Integer = list.Length
        For i As Integer = 0 To n - 2
            Dim minIndex As Integer = i
            For j As Integer = i + 1 To n - 1
                If list(j) < list(minIndex) Then
                    minIndex = j
                End If
            Next
            If minIndex <> i Then
                Dim temp As String = list(minIndex)
                list(minIndex) = list(i)
                list(i) = temp
            End If
        Next
    End Sub

    Sub Main()
        Dim arr(4) As String

        For i As Integer = 0 To 4
            arr(i) = Console.ReadLine()
        Next

        sort(arr) ' Вызываем функцию для сортировки элементов массива

        For i As Integer = 0 To 4 ' Выводим отсортированные элементы массива
            Console.WriteLine(arr(i))
        Next

        Console.ReadKey()
    End Sub

End Module
