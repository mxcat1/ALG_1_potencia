Module Module1
    Sub Main()
        Dim n As Integer
        Console.WriteLine("INGRESE UN VALOR DE 3 DIGITOS")
        n = Console.ReadLine()
        Do While n < 0 Or n > 1000000000
            Console.WriteLine("ERROR - INGRESE UN VALOR DE 9 DIGITOS")
            n = Console.ReadLine()
        Loop
        Console.WriteLine(numeroaletras(n))
        Console.ReadLine()
    End Sub

End Module
