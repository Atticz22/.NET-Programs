Public Class frmSistem
    Private Sub btnCALC_Click(sender As Object, e As EventArgs) Handles btnCALC.Click
        Dim a11, a12, a21, a22, b1, b2, D, Dx, Dy, X, Y As Double
        a11 = txtbX1.Text
        a12 = txtbY1.Text
        a21 = txtbX2.Text
        a22 = txtbY2.Text
        b1 = txtbEC1.Text
        b2 = txtbEC2.Text

        D = a11 * a22 - a21 * a12

        If D = 0 Then
            MessageBox.Show("Eroare: matricea coeficientilor este singulara!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dx = (b1 * a22) - (b2 * a12)
            Dy = (a11 * b2) - (a21 * b1)
            X = Dx / D
            Y = Dy / D
        End If

        txtbXSolutie.Text = Math.Round(X, 2)
        txtbYSolutie.Text = Math.Round(Y, 2)
    End Sub

End Class
