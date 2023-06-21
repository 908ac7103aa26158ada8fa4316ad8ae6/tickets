Module Module1

    Sub Main()
        Dim x_1 As Double
        Dim x_2 As Double
        Dim x_3 As Double

        x_1 = -2
        x_2 = 1.7
        x_3 = 0.4

        Dim c_z_x1 As Double
        Dim c_z_x2 As Double
        Dim c_z_x3 As Double

        c_z_x1 = C(Z(x_1))
        c_z_x2 = C(Z(x_2))
        c_z_x3 = C(Z(x_3))

        Console.WriteLine("Результаты вычислений:")
        Console.WriteLine("x=-2: C(Z(x)) = " & c_z_x1)
        Console.WriteLine("x=1.7: C(Z(x)) = " & c_z_x2)
        Console.WriteLine("x=0.4: C(Z(x)) = " & c_z_x3)

        Console.ReadKey()

    End Sub

    Function Z(ByVal x As Double) As Double
        Z = Math.Sin(x ^ 2) + 2 * x
    End Function

    Function C(ByVal z As Double) As Double
        C = Math.Exp(z) - 1 / (z + 1)
    End Function

End Module
