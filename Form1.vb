Public Class Form1
    Dim result As Decimal
    Private Sub cmdResultado_Click(sender As Object, e As EventArgs) Handles cmdResultado.Click
        Dim divisor, dividendo As Decimal

        divisor = txtDivisor.Text
        dividendo = txtDividendo.Text

        If divisor = 0 Then

            lblResultado.Text = "NO ES POSIBLE DIVIDOR ENTRE: " & divisor
            lblResultado.ForeColor = Color.Red

        Else

            result = dividendo / divisor

            lblResultado.Text = "EL RESULTADO ES: " & result
            lblResultado.ForeColor = Color.Green

        End If

    End Sub
End Class
