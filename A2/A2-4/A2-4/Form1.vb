Public Class frmMain
    Private Sub btnS_Click(sender As Object, e As EventArgs) Handles btnS.Click
        Dim p As Integer

        p = 7860
        txtbDensitate.Text = p



    End Sub

    Private Sub txtbMasa_TextChanged(sender As Object, e As EventArgs) Handles txtbMasa.TextChanged



    End Sub

    Private Sub btnCalcMasa_Click(sender As Object, e As EventArgs) Handles btnCalcMasa.Click
        Dim a, b, m, p, V As Integer

        a = txtbRExt.Text
        b = txtbRInt.Text

        V = (4 / 3 * Math.PI) * (a ^ 3 - b ^ 3) / 10 ^ 6
        p = txtbDensitate.Text
        m = p * V

        txtbMasa.Text = Math.Round(m, 3)


    End Sub

    Private Sub btnAl_Click(sender As Object, e As EventArgs) Handles btnAl.Click
        Dim p As Integer

        p = 2700
        txtbDensitate.Text = p

    End Sub

    Private Sub btnCu_Click(sender As Object, e As EventArgs) Handles btnCu.Click
        Dim p As Integer

        p = 8960
        txtbDensitate.Text = p

    End Sub
End Class
