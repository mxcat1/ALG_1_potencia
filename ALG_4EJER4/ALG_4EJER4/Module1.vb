Module Module1

    Sub Main()
        Dim bb, ff As Integer
        Console.ForegroundColor = 10
        Console.Write("INGRESE EL VALOR PARA BB----------->")
        bb = Console.ReadLine()
        Console.Write("IGRESE EL VALOR PARA FF----------->")
        ff = Console.ReadLine()
        Do While ff < 7
            If ff > 3 Then
                bb = bb + 4
            End If
            bb *= 2
            ff += 1

        Loop
        bb -= 10

        Console.WriteLine("el valor final de BB ---->" + Str(bb))
        Console.WriteLine("el valor final de FF ---->" + Str(ff))
        Console.WriteLine("------------------------------------------------------------")
        Console.WriteLine("CON DU UNTIL")
        Console.Write("INGRESE EL VALOR PARA BB----------->")
        bb = Console.ReadLine()
        Console.Write("IGRESE EL VALOR PARA FF----------->")
        ff = Console.ReadLine()
        Do Until ff > 6
            If ff > 3 Then
                bb = bb + 4
            End If
            bb *= 2
            ff += 1

        Loop
        bb -= 10

        Console.WriteLine("el valor final de BB ---->" + Str(bb))
        Console.WriteLine("el valor final de FF ---->" + Str(ff))
        Console.WriteLine("--------------------------------------------")
        Console.WriteLine("CON FOR")
        Console.Write("INGRESE EL VALOR PARA BB----------->")
        bb = Console.ReadLine()
        Console.Write("IGRESE EL VALOR PARA FF----------->")
        ff = Console.ReadLine()
        For ff = ff To 6
            If ff > 3 Then
                bb = bb + 4
            End If
            bb *= 2

        Next
        bb -= 10

        Console.WriteLine("el valor final de BB ---->" + Str(bb))
        Console.WriteLine("el valor final de FF ---->" + Str(ff))
        Console.ReadLine()
    End Sub

End Module
