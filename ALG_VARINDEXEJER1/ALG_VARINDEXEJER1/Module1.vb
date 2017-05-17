Module Module1

    Sub Main()
        Dim meses(12), fecha As String
        Dim dd, mm, aa, dias(12) As Integer

        meses(1) = "enero"
        meses(2) = "Febrero"
        meses(3) = "Marzo"
        meses(4) = "Abril"
        meses(5) = "Mayo"
        meses(6) = "Junio"
        meses(7) = "Julio"
        meses(8) = "Agosto"
        meses(9) = "Septiembre"
        meses(10) = "Octubre"
        meses(11) = "Noviembre"
        meses(12) = "Diciembre"

        dias(1) = 31
        dias(2) = 28
        dias(3) = 31
        dias(4) = 30
        dias(5) = 31
        dias(6) = 30
        dias(7) = 31
        dias(8) = 31
        dias(9) = 30
        dias(10) = 31
        dias(11) = 30
        dias(12) = 31


        Console.WriteLine("Propgrama que edita y valida una fecha")
        Console.Write("Ingrese el año en dos dugitos")
        aa = Console.ReadLine()
        Do While aa < 0 Or aa > 99
            Console.Write("EL AÑO NO ES VALIDO VUELVA A INGRESAR")
            aa = Console.ReadLine()
        Loop
        Console.Write("INGRESE EL MES EN DOS DIGITOS")
        mm = Console.ReadLine()
        Do While mm < 0 Or mm > 12
            Console.Write("EL MES NO ES VALIDO VUELVA A INGRESAR")
            mm = Console.ReadLine()
        Loop
        Console.Write("INGRESE EL DIA EN DOS DIGITOS")
        dd = Console.ReadLine()
        Do While dd < 1 Or dd > dias(mm)
            Console.Write("EL DIA NO ES VALIDO VUELVA A INGRESAR")
            dd = Console.ReadLine()
        Loop
        fecha = Str(dd) + " de " + meses(mm) + " del" & Str(aa + 2000)


        Console.Write("LA FECHA ES :  " + fecha)
        Console.ReadLine()


    End Sub

End Module
