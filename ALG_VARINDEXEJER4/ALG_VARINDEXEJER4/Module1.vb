Module Module1

    Sub Main()
        Dim ventas(3, 5), a, v, total, mayor, vendedor, promedio As Integer
        Dim mayorp As Double
        ventas(1, 1) = 23
        ventas(1, 2) = 16
        ventas(1, 3) = 31
        ventas(1, 4) = 19
        ventas(1, 5) = 22
        ventas(2, 1) = 17
        ventas(2, 2) = 23
        ventas(2, 3) = 38
        ventas(2, 4) = 29
        ventas(2, 5) = 20
        ventas(3, 1) = 24
        ventas(3, 2) = 18
        ventas(3, 3) = 20
        ventas(3, 4) = 42
        ventas(3, 5) = 18
        'CODIGO PARA QUE SE PUEDA PONER LOS VALOR DE VENTAS(3,5) UNO MISMO
        'For x = 1 To 3
        '    For y = 1 To 5
        '        Console.Write("INGRESE LA CANTIDAD DE VENTAS DEL VENDEDOR" + Str(y) + " PARA EL AREA " + Str(x) + " -----> ")
        '        ventas(x, y) = Console.ReadLine()
        '    Next
        'Next
        Console.ForegroundColor = 10
        Console.SetWindowSize(95, 30)
        Console.WriteLine("---------EJERCICIOS DE VARIABLE INDEXADA DE MULTIPLES DIMENSIONES---------")
        Console.WriteLine("--------------------------------------------------------------------------------------------")
        a = 1
        v = 1
        'CODIGO PARA SACAR ERL TOTAL POR AREAS DE LA VARIABLE INDEXADA VENTAS(3,5)
        Do Until a = 4
            Do Until v = 6
                total += ventas(a, v)
                v += 1
            Loop
            Console.WriteLine("EL TOTAL DEL AREA" + Str(a) + " ES : S/ " + Str(total))
            total = 0
            v = 1
            a += 1
        Loop
        Console.WriteLine("--------------------------------------------------------------------------------------------")
        a = 1
        v = 1
        'CODIGO PARA SACAR EL TOTAL DE VENTAS POR VENDENDOR DE LA VARIABLE INDEXADA VENTAS(3,5)
        Do Until v = 6
            Do Until a = 4
                total += ventas(a, v)
                a += 1
            Loop
            Console.WriteLine("EL TOTAL DE VENTAS DEL VENDEDOR" + Str(v) + " ES S/." + Str(total) + "   |")
            promedio = total / 3
            Console.WriteLine("EL PROMEDIO DEL TOTAL DEL VENDEDOR" + Str(v) + " ES S/." + Str(promedio) + "|")
            If (promedio > mayorp) Then
                mayorp = promedio
                vendedor = v
            End If
            Console.WriteLine("----------------------------------------------")
            a = 1
            total = 0
            v += 1
        Loop
        Console.WriteLine("EL PROMEDIO MAS ALTO DEL TOTAL DE LOS VENDEDORES ES S/." + Str(mayorp) + " Y ES DEL VENDEDOR " + Str(vendedor))
        Console.WriteLine("--------------------------------------------------------------------------------------------")
        a = 1
        v = 1
        'CODIGO PARA SACAR EL TOTAL DE VENTAS DE TODAS LAS AREAD Y VENDORES DE LA VARIABLE INDEXADA VENTAS(3,5)
        Do Until a = 4
            Do Until v = 6
                total += ventas(a, v)
                v += 1
            Loop
            v = 1
            a += 1
        Loop
        'CODIGO PARA SACAR EL VALOR MAS ALTO POR AREA DE LA VARIABLE INDEXADA VENTAS(3,5)
        a = 1
        v = 1

        Do Until a = 4
            Do Until v = 6
                If (ventas(a, v) > mayor) Then
                    mayor = ventas(a, v)
                End If
                v += 1
            Loop
            Console.WriteLine("LA MAYOR VENTA DEL AREA" + Str(a) + " ES S/" + Str(mayor))
            mayor = 0
            v = 1
            a += 1
        Loop
        Console.WriteLine("--------------------------------------------------------------------------------------------")

        Console.WriteLine("LA SUMA TOTAL DE TODAS LAS VENTAS ES: S/" + Str(total))
        Console.WriteLine("--------------------------------------------------------------------------------------------")
        Console.WriteLine("EL PROMEDIO DEL TOTAL DE TODAS LAS VENTAS ES: S/" + Str(Int(total / 3)))

        Console.ReadLine()

    End Sub

End Module
