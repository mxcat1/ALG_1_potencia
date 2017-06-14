Module Module1

    Sub Main()
        Dim ll(10) As String
        Dim nn(3, 5), A, V, c, b, valto As Integer

        'ASIGNACION DE VALORES PARA LL
        ll(1) = "Arequipa"
        ll(2) = "Camaná"
        ll(3) = "Camaná"
        ll(4) = "Ilo"
        ll(5) = "Ilo"
        ll(6) = "Jauja"
        ll(7) = "Marcona"
        ll(8) = "Mollendo"
        ll(9) = "Piura"
        ll(10) = "Piura"
        'ASIGNACION PARA LA VARIABLE NN
        nn(1, 1) = 16 'AREA 1 VENDEDOR 1
        nn(1, 2) = 28 'AREA 1 VENDEDOR 2
        nn(1, 3) = 17 'AREA 1 VENDEDOR 3
        nn(1, 4) = 21 'AREA 1 VENDEDOR 4
        nn(1, 5) = 42 'AREA 1 VENDEDOR 5
        nn(2, 1) = 21 'AREA 2 VENDEDOR 1
        nn(2, 2) = 32 'AREA 2 VENDEDOR 2
        nn(2, 3) = 17 'AREA 2 VENDEDOR 3
        nn(2, 4) = 22 'AREA 2 VENDEDOR 4
        nn(2, 5) = 29 'AREA 2 VENDEDOR 5
        nn(3, 1) = 23 'AREA 3 VENDEDOR 1
        nn(3, 2) = 16 'AREA 3 VENDEDOR 2
        nn(3, 3) = 30 'AREA 3 VENDEDOR 3
        nn(3, 4) = 31 'AREA 3 VENDEDOR 4
        nn(3, 5) = 27 'AREA 3 VENDEDOR 5

        'PRIMER ALGORITMO PARA SACAR EL NUMERO DE ELEMENTOS QUE SE REPITEN EN LA VARIABLE LL

        Console.ForegroundColor = 10 'CAMBIO EL COLOR DE LAS LETRAS EN LA CONSOLA A VERDE
        Console.WriteLine("-----------PROGRAMA PARA SACAR LA CANTIDAD DE ELEMENTOS QUE SE REPITEN CON DO UNTIL-------------")
        A = 1 'ASIGNAMOS ALA VARIABLE A EL VALOR DE 1
        Do Until A > 9 'INICIO DEL BUCLE PARA RECORRER LA VARIABLE INDEXADA LL
            'b = A + 1 'asignamos otro variable con el valor de A +1
            If ll(A) = ll(A + 1) Then 'BIFURCACION PARA VERIFICAR SI SON IGUALES
                c += 1 'AUMENTO AL CONTADOR C
                Console.WriteLine("EL DATO NUMERO" + Str(A) + " QUE ES " + ll(A) + " SE REPITE EN EL SIGUIENTE DATO" + Str(A + 1) + " QUE ES " + ll(A + 1))
                A += 1 'AUMENTO ALA VARIABLE A

            End If
            A += 1 'AUMENTO ALA VARIABLE A
        Loop
        Console.WriteLine("LA CANTIDAD DE ELEMENTOS QUE SE REPITEN SON------> " + Str(c))
        'PRIMER ALGORITMO PARA SACAR EL NUMERO DE ELEMENTOS QUE SE REPITEN EN LA VARIABLE LL CON SO WHILE
        c = 0
        Console.WriteLine("-----------------------------------------------------------------------------------------------------")
        Console.WriteLine("-----------PROGRAMA PARA SACAR LA CANTIDAD DE ELEMENTOS QUE SE REPITEN CON  DO WHILE-------------")
        A = 1 'ASIGNAMOS ALA VARIABLE A EL VALOR DE 1
        Do While A < 10 'INICIO DEL BUCLE PARA RECORRER LA VARIABLE INDEXADA LL
            'b = A + 1 'asignamos otro variable con el valor de A +1
            If ll(A) = ll(A + 1) Then 'BIFURCACION PARA VERIFICAR SI SON IGUALES
                c += 1 'AUMENTO AL CONTADOR C
                Console.WriteLine("EL DATO NUMERO" + Str(A) + " QUE ES " + ll(A) + " SE REPITE EN EL SIGUIENTE DATO" + Str(A + 1) + " QUE ES " + ll(A + 1))
                A += 1 'AUMENTO ALA VARIABLE A

            End If
            A += 1 'AUMENTO ALA VARIABLE A
        Loop

        Console.WriteLine("LA CANTIDAD DE ELEMENTOS QUE SE REPITEN SON------> " + Str(c))
        'PRIMER ALGORITMO PARA SACAR EL NUMERO DE ELEMENTOS QUE SE REPITEN EN LA VARIABLE LL CON SO WHILE
        Console.WriteLine("-----------------------------------------------------------------------------------------------------")
        Console.WriteLine("-----------PROGRAMA PARA SACAR LA CANTIDAD DE ELEMENTOS QUE SE REPITEN CON  CON FOR-------------")
        c = 0
        For d = 1 To 10
            If ll(d) = ll(d + 1) Then
                c += 1 'AUMENTO AL CONTADOR C
                Console.WriteLine("EL DATO NUMERO" + Str(d) + " QUE ES " + ll(d) + " SE REPITE EN EL SIGUIENTE DATO" + Str(d + 1) + " QUE ES " + ll(d + 1))
                d += 1 'AUMENTO ALA VARIABLE d
            End If

        Next
        Console.WriteLine("LA CANTIDAD DE ELEMENTOS QUE SE REPITEN SON------> " + Str(c))
        'SEGUNDO ALGORITMO PARA SACAR EL MENOR NUMERO DE VENTAS DE CADA VENDEDOR EN LA VARIABLE nn CON SO WHILE
        Console.WriteLine("-----------------------------------------------------------------------------------------------------")
        Console.WriteLine("--------------PROGRAMA PARA SACAR LA VENTA MENOR DE CADA VENDEDOR JUNTO CON EL AREA CON DO UNTIL Y DO WHILE------------------------")
        A = 1
        V = 1

        'Console.WriteLine("EL VALOR MAS BAJO DEL VENDEDOR " + Str(V) + "ES" + Str(valto) + " -.-")
        Do Until V = 6 'COMIENZO DEL BUCLE PARA RECORRER A TODOS LOS VENDEDORES
            valto = nn(1, V) 'LE DOY UN VALOR INICIAL ALA VARIABVLE VALTO CON EL PRIMER VALOR DE LA PRIMERA AREA Y SU RESPECTIVO VENDEDOR
            Do Until A = 4 'INICIALIZO BUCLE PARA QUE RECORRA CADA AREA

                If nn(A, V) < valto Then 'CON EL VALOR DE VALTOCOMPARO CON EL PRIMERI VALO DE LA VARIABLE INDEXADA NN
                    valto = nn(A, V) '
                End If

                A = A + 1

            Loop
            Console.Write("EL VALOR MAS BAJO DEL VENDEDOR " + Str(V) + " ES" + Str(valto) + "  -.-  ")
            A = 1
            Do While A < 4
                If nn(A, V) = valto Then
                    b = A
                    Console.WriteLine("ESTA EN EL AREA " + Str(b))
                End If
                A = A + 1
            Loop
            A = 1
            V = V + 1

        Loop
        'SEGUNDO ALGORITMO PARA SACAR EL MENOR NUMERO DE VENTAS DE CADA VENDEDOR EN LA VARIABLE nn CON FOR
        Console.WriteLine("-----------------------------------------------------------------------------------------------------")
        Console.WriteLine("--------------PROGRAMA PARA SACAR LA VENTA MENOR DE CADA VENDEDOR JUNTO CON EL AREA CON FOR------------------------")
        A = 1
        V = 1


        For X = 1 To 5
            valto = nn(1, X)
            For y = 1 To 3

                If nn(y, X) < valto Then
                    valto = nn(y, X)
                End If

            Next
            Console.Write("EL VALOR MAS BAJO DEL VENDEDOR " + Str(X) + " ES" + Str(valto) + "  -.-  ")

            For f = 1 To 3
                If nn(f, X) = valto Then
                    Console.WriteLine("ESTA EN EL AREA " + Str(f))
                End If

            Next

        Next

        Console.ReadLine() 'CODIGO PARA PAUSAR LA EJECUCION Y NO SE CIERRE EL PROGRAMA



    End Sub

End Module
