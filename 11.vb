Module Module1

    Sub Main()
        Dim start_num As Integer = Console.ReadLine()
        Const end_num As Integer = 10

        If start_num < end_num Then
            Console.WriteLine("Ничего не выводится")
        Else
            While start_num >= end_num
                Console.Write(start_num & " ")
                start_num -= 1
            End While
        End If

        Console.ReadKey()
    End Sub

End Module
