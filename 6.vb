Module Module1

    Structure TaxiOrder
        Dim address As String
        Dim distance As Integer
        Dim price As Double
    End Structure

    Sub Main()
        Const price_per_km As Double = 10 ' стоимость 1 километра
        Dim order As TaxiOrder

        Console.WriteLine("Введите улицу и номер дома пункта назначения:")
        order.address = Console.ReadLine()

        Console.WriteLine("Введите расстояние до пункта назначения в километрах:")
        order.distance = Console.ReadLine()

        order.price = order.distance * price_per_km

        Console.WriteLine("Задание таксисту:")
        Console.WriteLine(order.address & ", " & order.distance & " км")
        Console.WriteLine("Стоимость: " & Format(order.price, "#.00") & " руб.")

        Console.ReadKey()
    End Sub

End Module
