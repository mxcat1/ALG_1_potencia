Module Module1

    Sub Main()
        Dim num, potencia, numero, cont As Double
        Dim SI As String

        Do Until SI = "no"
            cont = 1
            Console.ForegroundColor = 10
            Console.WriteLine("PROGRAMA QUE ELVA UN NÚMERO A UNA POTENCIA ")
            Console.WriteLine("----------------------------------------------------------------------------")
            Console.Write("ESCRIBA EL NUMERO A ELEVAR A LA POTENCIA -----> ")
            num = Console.ReadLine()
            Do While num < 2 Or num > 99
                Console.WriteLine("EL NUMERO NO ES VALIDO PORFAVOR")
                Console.WriteLine("INGRESE UN NUMERO DEL 2 AL 99 PORFAVOR ")
                num = Console.ReadLine()
            Loop
            Console.Write("ESCRIBA A CUANTO LO VA A ELEVAR ------->")
            potencia = Convert.ToInt64(Console.ReadLine())
            Do While potencia < 2 Or potencia > 9
                Console.WriteLine("NO SE PUEDE ELEVAR A ESE NUMERO SOLO SE PERMITE DEL 2 AL 9")
                Console.Write("VUELVA A ESCRIBIR UN NUMERO --------------> ")
                potencia = Console.ReadLine
            Loop
            numero = num

            'letra = Console.ReadLine()
            'asccc = Asc(letra)
            'Console.WriteLine(asccc)
            Do While cont < potencia
                num = num * numero
                cont = cont + 1
            Loop

            Console.WriteLine("LA POTENCIA DE " & numero & " ES ------> " & num)

            Console.WriteLine("ESCRIBE SI PARA COLOCAR OTRO NUMERO O NO PARA TERMINAR")
            SI = Console.ReadLine
        Loop
        Console.WriteLine("ADIOS")
        Console.ReadLine()

    End Sub

End Module
