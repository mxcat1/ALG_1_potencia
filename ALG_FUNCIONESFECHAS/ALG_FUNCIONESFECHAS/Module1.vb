Module Module1

    Sub Main()
        Dim d1, m1, a1, tipo As Integer
        Dim testo As String

        Console.Write("INGRESE EL DÍA EN DOS DIGITOS=====> ")
        d1 = Console.ReadLine
        Console.Write("INGRESE EL MES EN DOS DIGITOS=====> ")
        m1 = Console.ReadLine
        Console.Write("INGRESE EL AÑO EN DOS DIGITOS=====> ")
        a1 = Console.ReadLine
        Console.WriteLine("INGRESE EL EL TIPO DE FORMATO DE FECHA: ")
        Console.WriteLine("TIPO 1 EJM => 27 DE JUNIO DEL 2017")
        Console.WriteLine("TIPO 2 EJM => JUNIO, 27 DEL 2017")
        Console.WriteLine("TIPO 3 EJM => MARTES 27, DE JUNIO")
        tipo = Console.ReadLine
        If tipo = 1 Then
            testo = Str(d1) + " DE " + nommes(m1) + " DEL" + Str(a1 + 2000)
        Else
            If tipo = 2 Then
                testo = nommes(m1) + "," + Str(d1) + " DEL" + Str(a1 + 2000)
            Else
                If tipo = 3 Then
                    testo = diasemana(d1, m1, a1) + Str(d1) + ", DE " + nommes(m1)
                End If
            End If
        End If
        Console.WriteLine(testo)
        Console.ReadLine()

    End Sub

End Module
