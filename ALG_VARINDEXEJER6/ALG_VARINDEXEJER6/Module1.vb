Module Module1

    Sub Main()
        Dim nombres(13), persona(13) As String
        Dim notas(13), mayor, lugar(13), v As Integer
        nombres(1) = "Andrea"
        nombres(2) = "Lucia"
        nombres(3) = "Miguel"
        nombres(4) = "Jose"
        nombres(5) = "Mariana"
        nombres(6) = "Rocio"
        nombres(7) = "Alberto"
        nombres(8) = "Eduardo"
        nombres(9) = "Josefina"
        nombres(10) = "Rosa"
        nombres(11) = "Pedro"
        nombres(12) = "Arturo"
        nombres(13) = "Susana"
        notas(1) = 12
        notas(2) = 11
        notas(3) = 13
        notas(4) = 10
        notas(5) = 13
        notas(6) = 14
        notas(7) = 17
        notas(8) = 14
        notas(9) = 14
        notas(10) = 17
        notas(11) = 12
        notas(12) = 17
        notas(13) = 14
        mayor = notas(1)
        v = 1
        For x = 1 To 13
            If notas(x) > mayor Then
                v = 1
                persona(v) = nombres(x)
                lugar(v) = x
                mayor = notas(x)
            Else
                If mayor = notas(x) Then
                    v = v + 1
                    lugar(v) = x
                    persona(v) = nombres(lugar(v))
                    'Console.WriteLine("LA PERSONA " + persona(v) + " EN EL LUGAR" + Str(lugar(v)) + " TIENE LA NOTA IGUAL A " + Str(mayor))
                    'Console.WriteLine(Str(v))
                End If
            End If

        Next

        If v = 1 Then
            Console.WriteLine("LA NOTA MAYOR ES" + Str(mayor) + " Y LA TIENE")
        Else
            Console.WriteLine("LA NOTA MAYOR ES" + Str(mayor) + " Y LA TIENEN")
        End If
        For x = 1 To v
            Console.WriteLine("LA PERSONA " + persona(x) + " EN LA POSICION" + Str(lugar(x)))

        Next
        'PRUEBA PARA QUE SE PUEDA AVERIGUAR EL TAMAÑO DE UNA VARIABLE INDEXADA
        Console.WriteLine(Str(UBound(lugar)) + Str(Int(Rnd() * 10)))
        Dim pp(Int(Rnd() * 100)), d, c As Integer
        For d = 1 To UBound(pp)
            pp(d) = Int(Rnd() * 100)
        Next
        Console.WriteLine(UBound(pp))
        d = 1
        Try
            Do While d > 0
                If pp(d) <> 0 Then
                    c += 1
                End If
                d = d + 1
            Loop

        Catch ex As Exception
            Console.WriteLine(c)
        End Try
        'FIN DE LA PRUEBA
        'ALGORITMO MEJORADO EN CLASE 05-07-2017
        Console.ReadLine()

    End Sub

End Module
