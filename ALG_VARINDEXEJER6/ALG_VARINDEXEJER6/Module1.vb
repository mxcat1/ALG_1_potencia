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
        notas(13) = 12
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

        For x = 1 To v
            Console.WriteLine("LA PERSONA " + persona(x) + " EN LA POSICION" + Str(lugar(x)) + " TIENE LA NOTA IGUAL A " + Str(mayor))
        Next

        'ALGORITMO MEJORADO EN CLASE 05-07-2017
        Console.ReadLine()
    End Sub

End Module
