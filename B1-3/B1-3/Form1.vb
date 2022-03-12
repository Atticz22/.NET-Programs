Public Class frmMedie
    Private Sub btnCalcMedie_Click(sender As Object, e As EventArgs) Handles btnCalcMedie.Click
        Dim n1, n2, n3, m As Single

        n1 = txtbMate.Text
        n2 = txtbProg.Text
        n3 = txtbMec.Text

        If 1 <= n1 And n1 <= 10 And 1 <= n2 And n2 <= 10 And 1 <= n3 And n3 <= 10 Then

            If n1 >= 5 And n2 >= 5 And n3 >= 5 Then
                m = (n1 + n2 + n3) / 3
            Else
                MessageBox.Show("Nu toate notele sunt de trecere", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Else
            MessageBox.Show("Eroare: Notele nu sunt valide!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        txtbMedie.Text = Math.Round(m, 2)

    End Sub
End Class
