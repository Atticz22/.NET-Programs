Public Class frmSubiect
    Private Sub btnPlan_Click(sender As Object, e As EventArgs) Handles btnPlan.Click
        Me.Hide()
        frmPlan.Show()
    End Sub

    Private Sub btnNumere_Click(sender As Object, e As EventArgs) Handles btnNumere.Click
        Me.Hide()
        frmNumere.Show()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class
