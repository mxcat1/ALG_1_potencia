Module Module1

    Sub Main()
        Dim NN, c As Integer
        Console.Write("INGRESE UN VALOR PARA NN ------------>")
        NN = Console.ReadLine()
        c = 1
        Do Until c = 11
            NN += 4
            If c > 5 Then
                NN -= 2
            End If
            c += 1
        Loop
        Console.WriteLine("EL NUEVO VALOR DE NN ES --------------> " + Str(NN))
        Console.ReadLine()


    End Sub

End Module
