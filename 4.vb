Module Module1

    Sub Main()
        Dim name As String
        Dim price_kg As Integer
        Dim weight_kg As Double

        Console.WriteLine("Введите наименование товара:")
        name = Console.ReadLine()

        Console.WriteLine("Введите цену за килограмм в рублях:")
        price_kg = Console.ReadLine()

        Console.WriteLine("Введите вес товара в килограммах (с точностью до грамма):")
        weight_kg = Console.ReadLine()

        Dim total_price As Double
        total_price = price_kg * weight_kg

        Console.WriteLine(name & ", " & price_kg & " руб./кг, " & weight_kg & " кг, " & total_price & " руб.")

        Console.ReadKey()
    End Sub

End Module
