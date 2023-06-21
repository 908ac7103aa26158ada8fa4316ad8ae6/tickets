Module Module1
    Const N As Integer = 5
    Const RANDOM_MIN = 10
    Const RANDOM_MAX = 213213213

    Dim digits(N - 1) As Integer

    Sub checkRepeats(ByRef list As Integer(), ByRef result As Boolean)
        Dim list_set As New HashSet(Of Integer)()
        For Each number As Integer In list
            If list_set.Contains(number) Then
                result = True ' Число повторилось, возвращаем True
                Exit For
            Else
                list_set.Add(number)
            End If
        Next
        result = False
    End Sub

    Sub Main()
        Randomize()

        Dim list_set As New HashSet(Of Integer)()

        For i As Integer = 0 To N - 1
            Dim random_digit As Integer = Int((100000 * Rnd()) + 1) Mod 10

            While list_set.Contains(random_digit)
                random_digit = Int((100000 * Rnd()) + 1) Mod 10
            End While

            list_set.Add(random_digit)
        Next

        For i As Integer = 0 To N - 1
            digits(i) = list_set(i)
            Console.Write(digits(i))
        Next

        Console.ReadKey()
    End Sub
End Module
