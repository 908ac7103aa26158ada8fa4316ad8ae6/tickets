Module Module1

    Sub Main()
        ' вычисление значения функции для a=2, x=0
        Dim a As Double = 2
        Dim x As Double = 0
        Dim y As Double

        If x < 0 Then
            y = a
        ElseIf x = 0 Then
            y = 0
        Else
            y = -a
        End If

        Console.WriteLine("Значение функции для a=" & a & ", x=" & x & " равно " & y)

        ' вычисление значения функции для a=1, x=-2
        a = 1
        x = -2

        If x < 0 Then
            y = a
        ElseIf x = 0 Then
            y = 0
        Else
            y = -a
        End If

        Console.WriteLine("Значение функции для a=" & a & ", x=" & x & " равно " & y)

        ' вычисление значения функции для a=2.5, x=1
        a = 2.5
        x = 1

        If x < 0 Then
            y = a
        ElseIf x = 0 Then
            y = 0
        Else
            y = -a
        End If

        Console.WriteLine("Значение функции для a=" & a & ", x=" & x & " равно " & y)

        Console.ReadKey()
    End Sub

End Module
