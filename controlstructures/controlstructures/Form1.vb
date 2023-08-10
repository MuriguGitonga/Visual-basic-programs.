Public Class Form1


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim num, reslt As Integer
        num = 5

        For counter = 1 To 10
            reslt = num * counter
            lbloutput.Text += num & " * " & counter & " = " & reslt & vbCrLf
        Next

        Button1.Visible = False


    End Sub


End Class
