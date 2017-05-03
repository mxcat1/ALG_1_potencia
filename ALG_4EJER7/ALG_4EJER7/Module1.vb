Module Module1

    Sub Main()
        Dim ff, c, i As Integer
        Console.ForegroundColor = 10
        Console.Write("INGRESE UN NUEVO VALOR PARA FF-----------------------> ")
        ff = Console.ReadLine()
        c = 1
        i = 1
        Do While c < 21
            If i = 1 Then
                i = 0
                Console.WriteLine(Str(c) + "-" + Str(ff))
            Else
                ff *= 2
                Console.WriteLine(Str(c) + "-" + Str(ff))
                i = 1
            End If
            ff += 5
            Console.WriteLine(Str(c) + "-" + Str(ff))
            c += 1

        Loop
        Console.WriteLine("EL VALOR FINAL DE FF ES ----------------------->  " + Str(ff))
        Console.WriteLine("-----------------------------------------------------------------------")
        Console.WriteLine("CON DO UNTIL")


        Console.Write("INGRESE UN NUEVO VALOR PARA FF-----------------------> ")
        ff = Console.ReadLine()
        c = 1
        i = 0
        Do Until c = 21
            If i = 0 Then
                i = 1
                Console.WriteLine(Str(c) + "-" + Str(ff))
            Else
                ff *= 2
                Console.WriteLine(Str(c) + "-" + Str(ff))
                i = 0
            End If
            ff += 5
            Console.WriteLine(Str(c) + "-" + Str(ff))
            c += 1

        Loop
        Console.WriteLine("EL VALOR FINAL DE FF ES ----------------------->  " + Str(ff))
        Console.WriteLine("-----------------------------------------------------------------------")
        Console.WriteLine("CON FOR")
        Console.Write("INGRESE UN NUEVO VALOR PARA FF-----------------------> ")
        ff = Console.ReadLine()
        i = 1
        For x = 1 To 20
            If i = 1 Then
                i = 0
                Console.WriteLine(Str(x) + "-" + Str(ff))
            Else
                ff *= 2
                Console.WriteLine(Str(x) + "-" + Str(ff))
                i = 1
            End If
            ff += 5
            Console.WriteLine(Str(x) + "-" + Str(ff))

        Next
        Console.WriteLine("EL VALOR FINAL DE FF ES ----------------------->  " + Str(ff))
        Console.WriteLine("-----------------------------------------------------------------------")
        Console.ReadLine()
    End Sub

End Module
