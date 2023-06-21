Module Module1

    Sub Main()
        ' Считывание строки
        Console.WriteLine("Введите строку:")
        Dim input_str As String = Console.ReadLine()

        ' Объявление переменных
        Dim letter_count As Integer = 0 ' число букв
        Dim space_count As Integer = 0 ' число пробелов
        Dim punctuation_count As Integer = 0 ' число знаков препинания

        ' Подсчет количества букв, пробелов и знаков препинания с использованием оператора SELECT CASE
        For Each c As Char In input_str
            Select Case c
                Case "a" To "z", "A" To "Z" ' Если символ - буква, увеличим счетчик букв
                    letter_count += 1
                Case " " ' Если символ - пробел, увеличим счетчик пробелов
                    space_count += 1
                Case ".", ",", "!", "?" ' Если символ - знак препинания, увеличим счетчик знаков препинания
                    punctuation_count += 1
            End Select
        Next c

        ' Вывод результатов на экран
        Console.WriteLine("Количество букв: " & letter_count)
        Console.WriteLine("Количество пробелов: " & space_count)
        Console.WriteLine("Количество знаков препинания: " & punctuation_count)

        Console.ReadKey()
    End Sub

End Module
