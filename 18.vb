Module Module1

    ' Функция для сортировки массива методом пузырька
    Sub bubbleSort(ByRef list As String())
        Dim n As Integer = list.Length
        For i As Integer = 0 To n - 2
            For j As Integer = 0 To n - i - 2
                If list(j) > list(j + 1) Then
                    Dim temp As String = list(j)
                    list(j) = list(j + 1)
                    list(j + 1) = temp
                End If
            Next
        Next
    End Sub

    Sub Main()
        Dim arr(4) As String

        For i As Integer = 0 To 4
            arr(i) = Console.ReadLine()
        Next

        bubbleSort(arr) ' Вызываем функцию для сортировки элементов массива

        For i As Integer = 0 To 4 ' Выводим отсортированные элементы массива
            Console.WriteLine(arr(i))
        Next

        Console.ReadKey()
    End Sub

End Module
