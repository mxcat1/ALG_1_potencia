Module Module1
    Function ale(num As Integer, intervalo As Integer, canti As Integer, varindex() As Integer)
        Dim k, c, g, a, m As Integer
        Dim r, x As Double
        x = 6
        k = 8
        c = 5
        g = intervalo
        a = 1 + (4 * k)
        m = 2
        For d = 2 To g
            m = m * 2
            'Console.WriteLine(Str(m))
        Next
        For conta = 1 To canti
            'Console.WriteLine(Str(a) + Str(Int(x)) + Str(m) + " " + Str((a * x + c) / m))
            x = ((((a * x + c) / m) - Int((a * x + c) / m))) * m
            r = (Int(x) / (m - 1)) * num
            'Console.WriteLine(Str(x))
            varindex(conta) = Int(r)
            'Console.WriteLine(Str(Int(r)))
            Console.WriteLine(Str(varindex(conta)))
        Next
        Return Int(r)

    End Function

    Sub Main()
        Console.WriteLine("PROGRAMA DE VENTAS")
        Console.WriteLine("--------------------------------------------------------")
        Dim a As Double
        Dim matrice(15) As Integer
        a = ale(100, 4, 15, matrice)
        Dim n As Integer
        Console.WriteLine("INDIQUE CUANTAS TIENDAS HAY---> ")
        n = Console.ReadLine()
        Dim ventas(n), total, m, b, ti, mp As Integer

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
        Console.WriteLine("EL PROMEDIO ES : " + Str(total / n))
        For fa = 1 To 10
            If ventas(fa) > total / n Then
                mp += 1
                Console.WriteLine("LA TIENDA" + Str(fa) + " TIENE MAYOR VENTA QUE EL PROMEDIO " + Str(total / n))
            End If
        Next
        Console.WriteLine("HAY" + Str(mp) + " TIENDAS MAYORES QUE EL PROMEDIO " + Str(total / n))



        Console.ReadLine()


    End Sub

End Module
