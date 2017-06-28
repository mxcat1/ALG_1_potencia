Public Class Form1
    Private Sub btnmostrar_Click(sender As Object, e As EventArgs) Handles btnmostrar.Click
        lblnomnum.Text = nuevedigitos(nudnum.Value)
        For x = 1 To 5
            Process.Start("D:\Imagen.jpg")
        Next
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub nudnum_ValueChanged(sender As Object, e As EventArgs) Handles nudnum.ValueChanged
        lblnomnum.Text = nuevedigitos(nudnum.Value)
    End Sub
End Class
