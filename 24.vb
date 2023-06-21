Module Module1

    Sub Main()
        Console.WriteLine("Введите целое число:")
        Dim input As String = Console.ReadLine()

        Try
            Dim number As Integer = Integer.Parse(input)
            Console.WriteLine("Вы ввели число: {0}", number)
        Catch ex As Exception
            Console.WriteLine("Ошибка: {0}", ex.Message)
        End Try

        Console.ReadKey()
    End Sub

End Module
