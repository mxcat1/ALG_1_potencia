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
        Console.ReadLine()

    End Sub

End Module
