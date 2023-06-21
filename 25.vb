Imports System.IO

Module Module1
    Sub Main()
        Dim lines(4) As String ' Создаем массив для хранения строк

        ' Читаем 5 строк с консоли
        For i As Integer = 0 To 4
            Console.WriteLine("Введите строку {0}:", i + 1)
            lines(i) = Console.ReadLine()
        Next

        ' Записываем строки в файл
        Dim writer As New StreamWriter("output.txt")
        For Each line In lines
            writer.WriteLine(line)
        Next
        writer.Close()

        Console.WriteLine("Данные успешно записаны в файл output.txt")

        Console.ReadKey()
    End Sub
End Module