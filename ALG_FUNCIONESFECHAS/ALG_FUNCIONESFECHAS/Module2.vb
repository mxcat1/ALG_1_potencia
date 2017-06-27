Module Module2
    Function diasemana(d1, m1, a1) As String
        Dim cd1, uldia(12), aux1, aux2, x, rd As Integer
        Dim ndia(7), nomdia As String
        uldia(1) = 31
        uldia(2) = 28
        uldia(3) = 31
        uldia(4) = 30
        uldia(5) = 31
        uldia(6) = 30
        uldia(7) = 31
        uldia(8) = 31
        uldia(9) = 30
        uldia(10) = 31
        uldia(11) = 30
        uldia(12) = 31

        ndia(1) = "Domingo"
        ndia(2) = "Lunes"
        ndia(3) = "Martes"
        ndia(4) = "Miercoles"
        ndia(5) = "Jueves"
        ndia(6) = "Viernes"
        ndia(7) = "Sabado"

        cd1 = (a1 - 1) * 365
        cd1 = cd1 + Int((a1 - 1) / 4)
        aux1 = Int(a1 / 4)
        aux2 = aux1 * 4
        If aux2 = a1 Then
            uldia(2) = 29
        Else
            uldia(2) = 28
        End If

        x = 1
        Do While x < m1
            cd1 = cd1 + uldia(x)
            x = x + 1
        Loop
        cd1 = cd1 + d1

        aux1 = Int(cd1 / 7)
        aux2 = aux1 * 7

        rd = cd1 - aux2
        nomdia = ndia(rd + 1)
        Return nomdia


    End Function
    Function nommes(m1) As String
        Dim meses(12), nmes As String
        meses(1) = "ENERO"
        meses(2) = "FEBRERO"
        meses(3) = "MARZO"
        meses(4) = "ABRIL"
        meses(5) = "MAYO"
        meses(6) = "JUNIO"
        meses(7) = "JULIO"
        meses(8) = "AGOSTO"
        meses(9) = "SETIEMBRE"
        meses(10) = "OCTUBRE"
        meses(11) = "NOVIEMBRE"
        meses(12) = "DICIEMBRE"

        nmes = meses(m1)
        Return nmes

    End Function
End Module
