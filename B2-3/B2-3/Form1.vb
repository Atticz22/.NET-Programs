Public Class frmOperatii
    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles textbR.TextChanged

    End Sub

    Private Sub txtbA_TextChanged(sender As Object, e As EventArgs) Handles txtbA.TextChanged

    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        Dim a, b, x, r As Single

        a = txtbA.Text
        b = txtbB.Text
        x = combobOP.SelectedIndex

        Select Case x
            Case 0
                r = a + b
            Case 1
                r = a - b
            Case 2
                r = a * b
            Case 3
                r = a / b
        End Select

        textbR.Text = r
    End Sub
End Class
