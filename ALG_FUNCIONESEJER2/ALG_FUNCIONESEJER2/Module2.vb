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
        Process.Start("D:\Imagen.jpg")
        Console.WriteLine(nueve_digitos(n))
        Console.ReadLine()

    End Sub

End Module
