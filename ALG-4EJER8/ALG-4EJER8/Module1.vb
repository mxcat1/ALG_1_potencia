Module Module1

    Sub Main()
        Dim hh, c, a As Integer
        Console.Write("INGRESE EL NUEVO VALOR DE HH (NO SE PERMITE SER MENOR A 10 O MAYOR A 100)---------> ")
        hh = Console.ReadLine()
        c = 1
        Do Until hh >= 10 And hh <= 100
            Console.Write("INGRESE EL NUEVO VALOR DE HH (NO SE PERMITE SER MENOR A 10 O MAYOR A 100)---------> ")
            hh = Console.ReadLine()
        Loop
        Do While hh <= 1000
            hh *= 2
            Console.WriteLine(Str(c) + "-" + Str(hh))
            If c = 3 Or c = 5 Then

                hh -= 5
                Console.WriteLine(Str(c) + "-" + Str(hh))
            End If
            c += 1
        Loop
        Console.WriteLine("EL NUEVO VALOR DE FF ES --------------> " + Str(hh))
        Console.WriteLine("-----------------------------------------------------------")
        Console.ReadLine()
    End Sub

End Module
