Public Class Form1
    Dim d1, m1, a1 As Integer
    Dim texto As String
    Public Sub lafecha() 'procedimiento que manda el formato de la fecha al lblfecha para poder visualizar
        d1 = nuddia.Value
        m1 = nudmes.Value
        a1 = nudano.Value
        If rbt1.Checked Then
            texto = Str(d1) + " de " + meses(m1) + " del" + Str(a1 + 2000)
        Else
            If rbt2.Checked Then
                texto = meses(m1) + "," + Str(d1) + " del" + Str(a1 + 2000)
            Else
                If rbt3.Checked Then
                    texto = diasemana(d1, m1, a1) + "," + Str(d1) + " de " + meses(m1)
                End If
            End If
        End If
        lblfecha.Text = texto

    End Sub
    Public Sub verificacionmes() 'procedimiento que verifica el mes y el año si es bisiesto
        'o no y tmb la cantidad maxima del dia que desees poner dependiendo el mes o el año 
        Dim mes, meses(12) As Integer
        meses(1) = 31
        meses(2) = 28
        meses(3) = 31
        meses(4) = 30
        meses(5) = 31
        meses(6) = 30
        meses(7) = 31
        meses(8) = 31
        meses(9) = 30
        meses(10) = 31
        meses(11) = 30
        meses(12) = 31
        mes = nudmes.Value
        meses(2) = bisisesto(nudano.Value)
        nuddia.Maximum = meses(mes)
    End Sub

    Private Sub rbt1_CheckedChanged(sender As Object, e As EventArgs) Handles rbt1.CheckedChanged
        lafecha()
    End Sub

    Private Sub rbt2_CheckedChanged(sender As Object, e As EventArgs) Handles rbt2.CheckedChanged
        lafecha()
    End Sub

    Private Sub rbt3_CheckedChanged(sender As Object, e As EventArgs) Handles rbt3.CheckedChanged
        lafecha()
    End Sub

    Private Sub nudmes_ValueChanged(sender As Object, e As EventArgs) Handles nudmes.ValueChanged
        verificacionmes()
    End Sub

    Private Sub nudano_ValueChanged(sender As Object, e As EventArgs) Handles nudano.ValueChanged
        verificacionmes()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lafecha()
    End Sub

    Private Sub btnfecha_Click(sender As Object, e As EventArgs) Handles btnfecha.Click
        lafecha()

    End Sub
End Class
