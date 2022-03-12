Public Class frm2D
    Private Sub btnCalcDis_Click(sender As Object, e As EventArgs) Handles btnCalcDis.Click
        Dim x1, y1, x2, y2, D As Double

        x1 = txtbX1.Text
        y1 = txtbY1.Text
        x2 = txtbX2.Text
        y2 = txtbY2.Text

        D = Math.Sqrt((x2 - x1) ^ 2 + (y2 - y1) ^ 2)

        txtbDistanta.Text = D
        txtbDistanta.Text = Math.Round(D, 3)


    End Sub

    Private Sub txtbDistanta_TextChanged(sender As Object, e As EventArgs) Handles txtbDistanta.TextChanged
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        txtbX1.Text = ""
        txtbY1.Text = ""
        txtbX2.Text = ""
        txtbY2.Text = ""
        txtbDistanta.Text = ""

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
        frmMain.Show()

    End Sub
End Class