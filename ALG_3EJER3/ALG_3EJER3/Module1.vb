Module Module1

    Sub Main()
        Dim n As Integer
        n = 2
        Do While n < 100
            n = n * 3
            Console.WriteLine("el valor de n final es -----------> " + Str(n))
        Loop
        n = 2
        Console.WriteLine("CON DO UNTIL")
        Do Until Not n < 100
            n = n * 3
            Console.WriteLine("el valor de n final es -----------> " + Str(n))
        Loop



        Console.ReadLine()



    End Sub

End Module
