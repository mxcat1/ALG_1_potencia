Module Module1

    Sub Main()
        Dim nombres(13), persona(2) As String
        Dim notas(13), mayor, max(2), lugar(2), v As Integer

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
        notas(7) = 9
        notas(8) = 14
        notas(9) = 14
        notas(10) = 17
        notas(11) = 12
        notas(12) = 17
        notas(13) = 12
        mayor = notas(1)
        v = 1
        For x = 1 To 12
            If mayor < notas(x + 1) Then
                mayor = notas(x + 1)
            End If
            If mayor = notas(x + 1) Then
                lugar(v) = x + 1
                persona(v) = nombres(lugar(v))
                max(v) = mayor
                'Console.WriteLine("LA PERSONA " + persona(v) + " EN EL LUGAR" + Str(lugar(v)) + " TIENE LA NOTA IGUAL A " + Str(mayor))
                'Console.WriteLine(Str(v))
                If v = 1 Then
                    v = 2
                Else
                    v = 1
                End If
            End If

        Next
        'el caso de que haya mas de 2 valores mayores iguales la variable indexada que las almacenaria
        'se crearia dependiendo de eso
        If max(1) = max(2) Then
            For g = 1 To 2
                Console.WriteLine("LA NOTA MAYOR ES DE" + Str(mayor) + " Y LA TIENE " + persona(g))
            Next
        Else
            If max(1) > max(2) Then
                Console.WriteLine("LA NOTA MAYOR ES DE" + Str(mayor) + " Y LA TIENE " + persona(1))
            Else
                If max(2) > max(1) Then
                    Console.WriteLine("LA NOTA MAYOR ES DE" + Str(mayor) + " Y LA TIENE " + persona(2))
                End If
            End If
            End If


        Console.ReadLine()
    End Sub

End Module
