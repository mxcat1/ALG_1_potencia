Module Module1
    Dim r, s, t As Integer
    Dim e As String
    Sub Main()
        e = "MM"
        Console.ForegroundColor = 10
        Console.Write("ingrese un valor para la variable R: ")
        r = Console.ReadLine()
        Console.Write("ingrese un valor para la variable S: ")
        s = Console.ReadLine()
        Console.Write("ingrese un valor para la variable T: ")
        t = Console.ReadLine()

        'Do Until r = 7
        'If t = 1 Then

        's += 3
        't = 0
        'Console.WriteLine(r & " " & s & " " & t)
        'Else
        's += 5
        't = 1
        'Console.WriteLine(r & " " & s & " " & t)
        'End If
        'r += 1
        '
        'Loop
        'Do While r < 7
        'If t = 1 Then
        's += 3
        't = 0
        'Else
        's += 5
        't = 1
        '
        'End If
        'r += 1
        'Loop

        For r = r To 6
            If t = 1 Then
                s += 3
                t = 0
            Else
                s += 5
                t = 1
            End If
        Next

        Console.WriteLine("EL VALOR FINAL DE R ES ------------> " + Str(r))
        Console.WriteLine("EL VALOR FINAL DE S ES ------------> " + Str(s))
        Console.WriteLine("EL VALOR FINAL DE T ES ------------> " + Str(t))
        Console.ReadLine()

    End Sub

End Module
