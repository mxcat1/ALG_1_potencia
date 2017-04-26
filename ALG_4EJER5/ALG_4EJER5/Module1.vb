Module Module1

    Sub Main()
        Dim ss, rr, tt As Integer
        Console.Write("INGRESA EL VALOR DE SS-------->")
        ss = Console.ReadLine()
        Console.Write("INGRESA EL VALOR DE RR-------->")
        rr = Console.ReadLine()
        Console.Write("INGRESA EL VALOR DE TT-------->")
        tt = Console.ReadLine()
        Do Until ss = 0
            Do Until rr = 5
                If rr > 2 Then
                    tt += 2
                Else
                    tt += 4
                End If
                If rr = 2 Then
                    tt *= 2
                End If
                rr += 1
            Loop
            ss -= 2
            rr = 1
        Loop
        Console.WriteLine("el valor final de ss ------------->" + Str(ss))
        Console.WriteLine("el valor final de rr ------------->" + Str(rr))
        Console.WriteLine("el valor final de tt ------------->" + Str(tt))
        Console.WriteLine("------------------------------------------------------")
        Console.WriteLine("CON DO WHILE")
        Console.Write("INGRESA EL VALOR DE SS-------->")
        ss = Console.ReadLine()
        Console.Write("INGRESA EL VALOR DE RR-------->")
        rr = Console.ReadLine()
        Console.Write("INGRESA EL VALOR DE TT-------->")
        tt = Console.ReadLine()
        Do While ss > 0
            Do While rr < 5
                If rr > 2 Then
                    tt += 2
                Else
                    tt += 4
                End If
                If rr = 2 Then
                    tt *= 2
                End If
                rr += 1
            Loop
            ss -= 2
            rr = 1
        Loop
        Console.WriteLine("el valor final de ss ------------->" + Str(ss))
        Console.WriteLine("el valor final de rr ------------->" + Str(rr))
        Console.WriteLine("el valor final de tt ------------->" + Str(tt))
        Console.WriteLine("------------------------------------------------------")
        Console.WriteLine("CON FOR")
        Console.Write("INGRESA EL VALOR DE SS-------->")
        ss = Console.ReadLine()
        Console.Write("INGRESA EL VALOR DE RR-------->")
        rr = Console.ReadLine()
        Console.Write("INGRESA EL VALOR DE TT-------->")
        tt = Console.ReadLine()
        For ss = ss To 2 Step -2
            'Console.WriteLine("el valor final de rr ------------->" + Str(rr))
            For rr = rr To 4
                If rr > 2 Then
                    tt += 2
                Else
                    tt += 4
                End If
                If rr = 2 Then
                    tt *= 2
                End If
                'rr += 1
            Next
            'ss -= 2
            rr = 1
        Next
        Console.WriteLine("el valor final de ss ------------->" + Str(ss))
        Console.WriteLine("el valor final de rr ------------->" + Str(rr))
        Console.WriteLine("el valor final de tt ------------->" + Str(tt))
        Console.ReadLine()

    End Sub

End Module
