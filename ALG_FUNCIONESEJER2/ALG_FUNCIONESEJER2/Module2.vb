Module Module2

    Sub main()
        Console.ForegroundColor = 10
        Dim n As Double
        Console.WriteLine("INGRESE UN VALOR DE 3 DIGITOS")
        n = Console.ReadLine()
        Do While n < 0 Or n > 10000000000
            Console.WriteLine("ERROR - INGRESE UN VALOR DE 9 DIGITOS")
            n = Console.ReadLine()
        Loop
        Dim g1, g2, g3 As Integer
        Dim nnum As String = ""
        If n = 0 Then
            nnum = "CERO"
        Else
            g1 = Int(n / 1000000)
            g2 = Int((n - (g1 * 1000000)) / 1000)
            g3 = n - (g1 * 1000000) - (g2 * 1000)
            If g1 = 1 Then
                nnum = " UN MILLON "
            Else
                If g1 > 1 Then
                    nnum = tredigitos(g1) + " MILLONES "
                End If
            End If
            If g2 = 1 Then
                nnum = nnum + " UN MIL "
            Else
                If g2 > 1 Then
                    nnum = nnum + tredigitos(g2) + " MIL "
                End If
            End If
            If g3 > 0 Then
                nnum = nnum + tredigitos(g3)
            End If
        End If
        Process.Start(Environment.GetFolderPath(Environment.SpecialFolder.System) & "\mspaint.exe", "D:\Imagen.jpg")
        Console.WriteLine(nnum)
        Console.ReadLine()

    End Sub

End Module
