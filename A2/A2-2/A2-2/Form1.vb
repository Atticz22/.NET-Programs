Public Class frmCalcTr
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub btnSin_Click(sender As Object, e As EventArgs) Handles btnSin.Click
        Dim u As Single, r As Single

        u = txtU.Text

        r = Math.Sin(u * Math.PI / 180)

        txtRez.Text = r
        lblRez.Text = "sin:"



    End Sub


    Private Sub btnCos_Click(sender As Object, e As EventArgs) Handles btnCos.Click
        Dim u, r As Single

        u = txtU.Text

        r = Math.Cos(u * Math.PI / 180)

        txtRez.Text = Math.Round(r, 5)


    End Sub

    Private Sub btnTg_Click(sender As Object, e As EventArgs) Handles btnTg.Click
        Dim u, r As Single

        u = txtU.Text

        r = Math.Tan(u * Math.PI / 180)

        txtRez.Text = r

    End Sub

    Private Sub btnCtg_Click(sender As Object, e As EventArgs) Handles btnCtg.Click
        Dim u, r As Single

        u = txtU.Text

        r = 1 / Math.Tan(u * Math.PI / 180)

        txtRez.Text = r

    End Sub

    Private Sub txtU_TextChanged(sender As Object, e As EventArgs) Handles txtU.TextChanged

    End Sub
End Class
