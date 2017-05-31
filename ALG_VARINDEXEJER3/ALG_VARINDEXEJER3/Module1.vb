Module Module1

    Sub Main()
        'Dim x, y As Integer
        Dim nomb(8), nombre As String
        'nomb(1) = "Mario"
        'nomb(2) = "Susana"
        'nomb(3) = "Andres"
        'nomb(4) = "Nora"
        'nomb(5) = "Gustavo"
        'nomb(5) = ""
        'nomb(6) = "Daniela"
        'nomb(7) = "Ricardo"
        'nomb(6) = ""
        'nomb(8) = "Pedro"
        Console.ForegroundColor = 10
        Console.WriteLine("-----------------------------------")
        Console.WriteLine("PROGRAMA QUE ORDENA DATOS ALFANUMERICOS")
        For v = 1 To 8
            Console.Write("INGRESE EL NOMBRE " + Str(v) + " -------------> ")
            nomb(v) = Console.ReadLine

        Next
        For c = 1 To 8
            Console.WriteLine("DATOS " + Str(c) + " " + nomb(c))
        Next
        'x = 1
        'y = 1
        'Do While x < 8
        '    y = x + 1
        '    Do While y < 8
        '        If nomb(x) > nomb(y) Then
        '            nombre = nomb(x)
        '            nomb(x) = nomb(y)
        '            nomb(y) = nombre
        '        End If
        '        y = y + 1
        '    Loop
        '    x = x + 1
        'Loop
        For x = 1 To 7
            For y = x + 1 To 8
                If nomb(x) > nomb(y) Then
                    nombre = nomb(x)
                    nomb(x) = nomb(y)
                    nomb(y) = nombre
                Else

                End If
            Next
        Next
        Console.WriteLine("------------------------------------------------")
        Console.WriteLine("DATOS ORDENADOS")
        Console.WriteLine("------------------------------------------------")
        For c = 1 To 8
            Console.WriteLine("DATOS " + Str(c) + " " + nomb(c))
        Next

        Console.ReadLine()

    End Sub

End Module
