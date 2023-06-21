Module Module1

    Structure User
        Dim username As String
        Dim points As Integer
    End Structure

    Sub Main()
        Dim users(4) As User ' Создаем массив пользователей
        For i As Integer = 0 To 4 ' Запрашиваем данные для каждого пользователя
            Console.WriteLine("Введите имя пользователя:")
            Dim name As String = Console.ReadLine()
            Console.WriteLine("Введите количество очков:")
            Dim points As Integer = Console.ReadLine()
            Dim newUser As User ' Создаем нового пользователя
            newUser.username = name
            newUser.points = points
            users(i) = newUser ' Добавляем пользователя в массив
        Next

        For Each user As User In users ' Выводим данные каждого пользователя на экран
            Console.WriteLine("Имя пользователя: {0}, количество очков: {1}", user.username, user.points)
        Next

        Console.ReadKey()
    End Sub

End Module
