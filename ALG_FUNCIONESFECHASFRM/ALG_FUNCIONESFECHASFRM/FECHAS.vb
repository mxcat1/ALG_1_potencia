Module FECHAS
    Function diasemana(d1, m1, a1) As String 'funcion para hallar el nombre del dia 
        'de una fecha dada
        Dim uldia(12), ndia, cd1, aux1, aux2, x As Integer
        Dim dias(7), nomdia As String

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
        dias(1) = "Domingo"
        dias(2) = "Lunes"
        dias(3) = "Martes"
        dias(4) = "Miercoles"
        dias(5) = "Jueves"
        dias(6) = "Viernes"
        dias(7) = "Sabado"

        cd1 = (a1 - 1) * 365
        cd1 = cd1 + Int((a1 - 1) / 4)
        uldia(2) = bisisesto(a1)
        x = 1
        Do While x < m1
            cd1 = cd1 + uldia(x)
            x = x + 1
        Loop
        cd1 = cd1 + d1
        aux1 = Int(cd1 / 7)
        aux2 = aux1 * 7
        ndia = cd1 - aux2
        nomdia = dias(ndia + 1)
        Return nomdia


    End Function
    Function meses(m1) As String 'funcion para hallar el nombre del mes de un mes dado
        Dim mes(12), nommes As String
        mes(1) = "Enero"
        mes(2) = "Febrero"
        mes(3) = "Marzo"
        mes(4) = "Abril"
        mes(5) = "Mayo"
        mes(6) = "Junio"
        mes(7) = "Julio"
        mes(8) = "Agosto"
        mes(9) = "Setiembre"
        mes(10) = "Octubre"
        mes(11) = "Noviembre"
        mes(12) = "Diciembre"
        nommes = mes(m1)
        Return nommes
    End Function
    Function bisisesto(año) 'funcion que verifica si un año es bisiesto o no y cambia
        'el valor del mes
        Dim dias, ax1, ax2 As Integer
        ax1 = Int(año / 4)
        ax2 = ax1 * 4
        If ax2 = año Then
            dias = 29
        Else
            dias = 28
        End If
        Return dias
    End Function
End Module
