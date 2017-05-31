Module Module1

    Sub Main()
        'Dim x, y As Integer
        Dim nomb(8), nombre, eleccion As String
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
        'For x = 1 To 7
        '    For y = x + 1 To 8
        '        If (nomb(x) > nomb(y) And nomb(y) <> " ") Or nomb(x) = " " Then
        '            Console.WriteLine(Str(x) + "-" + Str(y) + "nombre= " + nombre)
        '            Console.WriteLine(Str(x) + "-" + Str(y) + "nombre x= " + nomb(x))
        '            Console.WriteLine(Str(x) + "-" + Str(y) + "nombre y= " + nomb(y))
        '            nombre = nomb(x)
        '            nomb(x) = nomb(y)
        '            nomb(y) = nombre
        '            Console.WriteLine(Str(x) + "-" + Str(y) + "nombre= " + nombre)
        '            Console.WriteLine(Str(x) + "-" + Str(y) + "nombre x= " + nomb(x))
        '            Console.WriteLine(Str(x) + "-" + Str(y) + "nombre y= " + nomb(y))
        '        End If
        '    Next
        'Next
        Console.Write("ELIJA SI QUIERE QUE SE ORDENE DE FORMA ASCENDENTE(a) O DESCENDENTE(b) ")
        eleccion = Console.ReadLine()
        Do While eleccion <> "a" And eleccion <> "d"
            Console.Write("SU RESPUESTA ES INCORRECTA VUELVA A INGRESAR PARA QUE SE ORDENE DE FORMA ASCENDENTE(a) O DESCENDENTE(b) ")
            eleccion = Console.ReadLine()
        Loop


        For x = 1 To 7
            For y = x + 1 To 8
                If eleccion = "a" Then 'eleccion del usuario para que sea ascendente o descendente
                    If (nomb(x) > nomb(y) And nomb(y) <> " ") Or nomb(x) = " " Then
                        'Para entender
                        Console.WriteLine(Str(x) + "-" + Str(y) + "nombre= " + nombre)
                        Console.WriteLine(Str(x) + "-" + Str(y) + "nombre x= " + nomb(x))
                        Console.WriteLine(Str(x) + "-" + Str(y) + "nombre y= " + nomb(y))
                        nombre = nomb(x) 'esto solo se procedera a ejecutar solo cuando se cumpla
                        nomb(x) = nomb(y) 'nomb(x)>nomb(y)
                        nomb(y) = nombre
                        Console.WriteLine(Str(x) + "-" + Str(y) + "nombre= " + nombre)
                        Console.WriteLine(Str(x) + "-" + Str(y) + "nombre x= " + nomb(x))
                        Console.WriteLine(Str(x) + "-" + Str(y) + "nombre y= " + nomb(y))

                    End If
                Else
                    If nomb(x) < nomb(y) Then
                        'Para entender
                        'Console.WriteLine(Str(x) + "-" + Str(y) + "nombre= " + nombre)
                        'Console.WriteLine(Str(x) + "-" + Str(y) + "nombre x= " + nomb(x))
                        'Console.WriteLine(Str(x) + "-" + Str(y) + "nombre y= " + nomb(y))
                        nombre = nomb(x) 'esto solo se procedera a ejecutar solo cuando se cumpla
                        nomb(x) = nomb(y) 'nomb(x)>nomb(y)
                        nomb(y) = nombre
                        'Console.WriteLine(Str(x) + "-" + Str(y) + "nombre= " + nombre)
                        'Console.WriteLine(Str(x) + "-" + Str(y) + "nombre x= " + nomb(x))
                        'Console.WriteLine(Str(x) + "-" + Str(y) + "nombre y= " + nomb(y))

                    End If
                End If
            Next
        Next

        Console.WriteLine("------------------------------------------------")
        Console.WriteLine("---------------DATOS ORDENADOS------------------")
        Console.WriteLine("------------------------------------------------")
        For c = 1 To 8
            Console.WriteLine("DATOS " + Str(c) + " " + nomb(c))
        Next

        Console.ReadLine()

    End Sub

End Module
