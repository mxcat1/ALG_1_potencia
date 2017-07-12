Module Module1
    Function cantidivi(num) As Integer
        Dim x, div, t1, t2, conta As Integer
        Do Until x > num / 2
            t1 = num / x
            t2 = t1 * x
            If t2 = num Then
                div = x

            End If
            x += 1
        Loop
        Return conta
    End Function
    Sub Main()
        Dim x, div, num, t1, t2 As Integer
        x = 2
        Console.WriteLine("ALGORITMO QUE INDICA LOS NUMEROS DIVISIBLES DE UN NUMERO ")

        Do Until num > 1
            Console.Write("INGRESE UN NUMERO")
            num = Console.ReadLine()
        Loop

        Dim divisibles(cantidivi(num)) As Integer
        Do Until x > num / 2
            t1 = num / x
            t2 = t1 * x
            If t2 = num Then
                divisibles(x) = x

            End If
            x += 1
        Loop
        For c = 1 To cantidivi(num)
            Console.Write("EL NUMERO TIENE DIVISIBLES COMO ={}")
        Next
        Console.ReadLine()
    End Sub

End Module
