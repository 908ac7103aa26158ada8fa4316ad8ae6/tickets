Module Module1

    ' Функция для вставки элемента в массив
    Sub insert(ByRef list As String(), ByVal item As String, ByVal index As Integer)
        ReDim Preserve list(UBound(list) + 1) ' Увеличиваем размер массива на 1
        For i As Integer = UBound(list) - 1 To index Step -1 ' Сдвигаем элементы массива вправо
            list(i + 1) = list(i)
        Next
        list(index) = item ' Вставляем элемент на нужную позицию
    End Sub

    Sub Main()
        Dim arr(4) As String

        For i As Integer = 0 To 4
            arr(i) = Console.ReadLine()
        Next

        insert(arr, "********", 1) ' Вызываем функцию для вставки элемента на вторую позицию

        For i As Integer = 0 To arr.Length - 1 ' Выводим элементы массива после вставки
            Console.WriteLine(arr(i))
        Next

        Console.ReadKey()
    End Sub

End Module
