Public Class frmMain
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub

    Private Sub NumericUpDown2_ValueChanged(sender As Object, e As EventArgs) Handles nudTermen.ValueChanged

    End Sub

    Private Sub btnValori_Click(sender As Object, e As EventArgs) Handles btnValori.Click
        txtbDepozit.Text = ""
        txtbSumaFinala.Text = ""
        nudDobanda.Value = 2
        nudTermen.Value = 6






    End Sub

    Private Sub btnCalcSuma_Click(sender As Object, e As EventArgs) Handles btnCalcSuma.Click
        Dim dp, db, t, Dbac As Double

        dp = txtbDepozit.Text
        db = nudDobanda.Value
        t = nudTermen.Value


        Dbac = dp * (db / 100) * (t / 12)

        txtbSumaFinala.Text = Math.Round(Dbac, 5)
        txtbSumaFinala.Text = Dbac + dp




    End Sub

    Private Sub btnInfo_Click(sender As Object, e As EventArgs) Handles btnInfo.Click
        Me.Show()
        frmInfo.ShowDialog()

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()

    End Sub
End Class
