Module Module2
    Function nuevedigitos(n) As String
        Dim g1, g2, g3 As Integer
        Dim nnum As String = ""
        If n = 0 Then
            nnum = "CERO"
        Else
            g1 = Int(n / 1000000)
            g2 = Int((n - (g1 * 1000000)) / 1000)
            g3 = n - (g1 * 1000000) - (g2 * 1000)
            If g1 = 1 Then
                nnum = " UN MILLON "
            Else
                If g1 > 1 Then
                    nnum = tredigitos(g1) + " MILLONES "
                End If
            End If
            If g2 = 1 Then
                nnum = nnum + " UN MIL "
            Else
                If g2 > 1 Then
                    nnum = nnum + tredigitos(g2) + " MIL "
                End If
            End If
            If g3 > 0 Then
                nnum = nnum + tredigitos(g3)
            End If
        End If

        Return nnum

    End Function
End Module
