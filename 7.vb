Module Module1

    Sub Main()
        Dim total_seconds As Integer
        Dim hours As Integer
        Dim minutes As Integer
        Dim seconds As Integer

        Console.WriteLine("Введите время в секундах:")
        total_seconds = Console.ReadLine()

        hours = total_seconds \ 3600 ' количество часов
        total_seconds = total_seconds Mod 3600 ' оставшиеся секунды
        minutes = total_seconds \ 60 ' количество минут
        seconds = total_seconds Mod 60 ' оставшиеся секунды

        ' вывод времени в формате "часы минуты секунды"
        Console.WriteLine(hours & " час " & minutes & " мин " & seconds & " с")

        Console.ReadKey()
    End Sub

End Module
