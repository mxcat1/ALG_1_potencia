Module Module1

    Sub Main()
        Dim dd, mm, aa, dd1, mm1, aa1, t1, t2, mesess, diasp, uldias(12) As Integer
        Dim meses(12) As String
        diasp = 0
        meses(1) = "ENERO"
        meses(2) = "FEBRERO"
        meses(3) = "MARZO"
        meses(4) = "ABRIL"
        meses(5) = "MAYO"
        meses(6) = "JUNIO"
        meses(7) = "JULIO"
        meses(8) = "AGOSTO"
        meses(9) = "SETIEMBRE"
        meses(10) = "OCTUBRE"
        meses(11) = "NOVIEMBRE"
        meses(12) = "DICIEMBRE"

        uldias(1) = 31
        uldias(2) = 28
        uldias(3) = 31
        uldias(4) = 30
        uldias(5) = 31
        uldias(6) = 30
        uldias(7) = 31
        uldias(8) = 31
        uldias(9) = 30
        uldias(10) = 31
        uldias(11) = 30
        uldias(12) = 31
        Console.ForegroundColor = 10


        Console.WriteLine("----------------------------------------")
        Console.WriteLine("PROGRAMA QUE AL SUMAR UNOS DIAS, DE UNA FECHA NUEVA Y ")
        Console.WriteLine("PROGRAMA QUE INDIQUE LA CANTIDAD DE DIAS Q HAY ENTRE DOS FECHAS")
        Console.WriteLine("INDIQUE LA FECHA INICIAL")

        Do Until aa > 0 And aa < 99
            Console.Write("INGRESE EL AÑO EN DOS DIGITOS------> ")
            aa = Console.ReadLine()
        Loop
        'INICIO ALGORITMO PARA SACAR SI UN AÑO ES BISISESTO NO INCLUYE AÑOS MULTIPLOS DE 400 O SI SON DIVISIBLES ENTRE 100
        aa = aa + 2000
        t1 = aa / 4
        t2 = t1 * 4
        If t2 = aa Then
            Console.WriteLine("EL AÑO " + Str(aa) + " ES BISIESTO")
            uldias(2) = 29
        Else
            Console.WriteLine("EL AÑO " + Str(aa) + " NO ES BISIESTO")
        End If
        'FIN
        Do Until mm > 0 And mm < 13
            Console.Write("INGRESE EL MES EN DOS DIGITOS------------>")
            mm = Console.ReadLine()
        Loop
        Do Until dd > 0 And dd < uldias(mm) + 1
            Console.Write("INGRESE EL DIA EN DOS DIGITOS-------------->")
            dd = Console.ReadLine()
        Loop

        Console.WriteLine("LA FECHA INICIAL ES" + Str(aa) + " " + meses(mm) + Str(dd))

        'INICIO DEL ALGORITMO PARA SABER CUANTOS DIAS HASYA ENTRE DOS FECHAS
        Console.WriteLine("-----------------------------------------------------")
        Console.WriteLine("PROGRAMA PARA SACARLA CANTIDAD DE DIAS QUE HAY ENTRE DOS FECHAS")
        Console.WriteLine("INDIQUE LA FECHA FINAL")

        Do Until aa1 > 0 And aa1 < 99
            Console.Write("INGRESE EL AÑO EN DOS DIGITOS------> ")
            aa1 = Console.ReadLine()
        Loop
        ''INICIO ALGORITMO PARA SACAR SI UN AÑO ES BISISESTO NO INCLUYE AÑOS MULTIPLOS DE 400 O SI SON DIVISIBLES ENTRE 100
        aa1 = aa1 + 2000
        t1 = aa1 / 4
        t2 = t1 * 4
        If t2 = aa1 Then
            Console.WriteLine("EL AÑO " + Str(aa1) + " ES BISIESTO")
            uldias(2) = 29
        Else
            Console.WriteLine("EL AÑO " + Str(aa1) + " NO ES BISIESTO")
        End If
        ''FIN
        Do Until mm1 > 0 And mm1 < 13
            Console.Write("INGRESE EL MES EN DOS DIGITOS------------>")
            mm1 = Console.ReadLine()
        Loop
        Do Until dd1 > 0 And dd1 < uldias(mm) + 1
            Console.Write("INGRESE EL DIA EN DOS DIGITOS-------------->")
            dd1 = Console.ReadLine()
        Loop
        Console.WriteLine("LA FECHA FINAL ES" + Str(aa1) + " " + meses(mm1) + Str(dd1))

        Do Until mm = mm1 And dd = dd1 And aa = aa1
            If dd = uldias(mm) Then
                dd = 1
                mm = mm + 1
                diasp = diasp + 1
                If mm > 12 Then
                    mm = 1
                    aa = aa + 1
                End If
            Else
                dd = dd + 1
                diasp = diasp + 1
            End If
        Loop

        Console.WriteLine("HAN PASADO" + Str(diasp) + " DIAS")
        'FIN
        Console.ReadLine()
    End Sub

End Module
