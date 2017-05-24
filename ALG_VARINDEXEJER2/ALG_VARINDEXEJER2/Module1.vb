Module Module1
    Function ale()
        Dim s As Boolean
        Dim n As Integer
        n = 0
        s = True
        Return n
    End Function

    Sub Main()
        Console.WriteLine("PROGRAMA DE VENTAS")
        Console.WriteLine("--------------------------------------------------------")
        Dim n As Integer
        Console.WriteLine("INDIQUE CUANTAS TIENDAS HAY---> ")
        n = Console.ReadLine()
        Dim ventas(n), total, m, b, ti As Integer
        n = 0
        ventas(1) = 16
        ventas(2) = 23
        ventas(3) = 42
        ventas(4) = 27
        ventas(5) = 45
        ventas(6) = 51
        ventas(7) = 26
        ventas(8) = 47
        ventas(9) = 36
        ventas(10) = 40

        For c = 1 To 10
            If ventas(c) > 40 Then
                m = m + 1
                Console.WriteLine("LA TIENDA : " + Str(ventas(c)))
            End If
        Next
        Console.WriteLine("LA CANTIDAD DE TIENDAS CON VENTAS MAYORES A 40 : " + Str(m))

        For x = 1 To 10
            If ventas(x) > b Then
                b = ventas(x)
                ti = x
            Else
                b = b
            End If
        Next
        Console.WriteLine("LA TIENDA " + Str(ti) + " TIENE LA MAYOR VENTA DE : " + Str(b))

        For c = 1 To 10
            total = total + ventas(c)

        Next
        Console.WriteLine("LAS VENTAS TOTAL SON : " + Str(total))
        Console.WriteLine("LAS VENTAS TOTAL SON : " + Str(total / n))

        Console.ReadLine()


    End Sub

End Module
