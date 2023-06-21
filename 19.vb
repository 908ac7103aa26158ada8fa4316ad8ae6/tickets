Module Module1


    ' Подпрограмма для удаления элемента из массива
    Sub delete(ByVal list As String(), ByVal index As Integer)

        Dim n As Integer = list.Length

        If index >= 0 And index < n Then
            For i As Integer = index To n - 2
                list(i) = list(i + 1)
            Next
            ReDim Preserve list(n - 2)
        End If

    End Sub

    Sub Main()
        Dim arr(4) As String

        For i As Integer = 0 To 4
            arr(i) = Console.ReadLine()
        Next

        delete(arr, 2) ' Удаляем третью строку из массива

        For i As Integer = 0 To 3 ' Выводим массив
            Console.WriteLine(arr(i))
        Next

        Console.ReadKey()
    End Sub

End Module
