Module Module1
    Function letras(n)
        Dim c_cv, d_cv, u_cv As Integer
        Dim cen_cv(9), dec_cv(9), uni_cv(9), exc_cv(5), texto_cv As String
        cen_cv(1) = "CIENTO"
        cen_cv(2) = "DOSCIENTOS"
        cen_cv(3) = "TRESCIENTOS"
        cen_cv(4) = "CUATROCIENTOS"
        cen_cv(5) = "QUINIENTOS"
        cen_cv(6) = "SEISCIENTOS"
        cen_cv(7) = "SETECIENTOS"
        cen_cv(8) = "OCHOCIENTOS"
        cen_cv(9) = "NOVECIENTOS"
        dec_cv(1) = "DIEZ"
        dec_cv(2) = "VEINTE"
        dec_cv(3) = "TREINTA"
        dec_cv(4) = "CUARENTA"
        dec_cv(5) = "CINCUENTA"
        dec_cv(6) = "SESENTA"
        dec_cv(7) = "SETENTA"
        dec_cv(8) = "OCHENTA"
        dec_cv(9) = "NOVENTA"
        uni_cv(1) = "UNO"
        uni_cv(2) = "DOS"
        uni_cv(3) = "TRES"
        uni_cv(4) = "CUATRO"
        uni_cv(5) = "CINCO"
        uni_cv(6) = "SEIS"
        uni_cv(7) = "SIETE"
        uni_cv(8) = "OCHO"
        uni_cv(9) = "NUEVE"
        exc_cv(1) = "ONCE"
        exc_cv(2) = "DOCE"
        exc_cv(3) = "TRECE"
        exc_cv(4) = "CATORCE"
        exc_cv(5) = "QUINCE"
        n = x
        c_cv = Int(n / 100)
        d_cv = Int((n - (c_cv * 100)) / 10)
        u_cv = Int(n - (c_cv * 100) - (d_cv * 10))
        If c_cv = 0 And d_cv = 0 And u_cv = 0 Then
            texto_cv = "CERO"

        Else
            If c_cv = 1 And d_cv = 0 And u_cv = 0 Then
                texto_cv = "CIEN"
            Else
                If c_cv > 0 And d_cv = 0 And u_cv > 0 Then
                    texto_cv = cen_cv(c_cv) & " " & uni_cv(u_cv)
                Else
                    If c_cv > 0 And d_cv > 0 And u_cv = 0 Then
                        texto_cv = cen_cv(c_cv) & "  " & dec_cv(d_cv)
                    Else
                        If c_cv > 0 And d_cv = 1 And (u_cv > 0 And u_cv < 6) Then
                            texto_cv = cen_cv(c_cv) & " " & exc_cv(u_cv)
                        Else
                            If c_cv > 0 And d_cv = 0 And u_cv = 0 Then
                                texto_cv = cen_cv(c_cv)
                            Else
                                If c_cv = 0 And d_cv > 0 And u_cv = 0 Then
                                    texto_cv = dec_cv(d_cv)
                                Else
                                    If c_cv = 0 And d_cv = 1 And (u_cv > 0 And u_cv < 6) Then
                                        texto_cv = exc_cv(u_cv)
                                    Else
                                        If c_cv = 0 And d_cv = 0 And u_cv > 0 Then
                                            texto_cv = uni_cv(u_cv)
                                        Else
                                            If c_cv = 0 And d_cv > 0 And u_cv > 0 Then
                                                texto_cv = dec_cv(d_cv) & " Y " & uni_cv(u_cv)
                                            Else
                                                texto_cv = cen_cv(c_cv) & " " & dec_cv(d_cv) & " Y " & uni_cv(u_cv)
                                            End If
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If
        Return texto_cv
    End Function
    Sub Main()
        Dim n As Integer
        Console.WriteLine("INGRESE UN VALOR DE 3 DIGITOS")
        n = Console.ReadLine()
        Do While n < 0 Or n > 1000
            Console.WriteLine("ERROR - INGRESE UN VALOR DE 3 DIGITOS")
            n = Console.ReadLine()
        Loop
        Console.WriteLine(letras(n))
        Console.ReadLine()
    End Sub

End Module
