Public Class frmMain
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn2D.Click
        Me.Hide()
        frm2D.Show()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnIesire.Click
        Me.Close()

    End Sub

    Private Sub btn3D_Click(sender As Object, e As EventArgs) Handles btn3D.Click
        Me.Hide()
        frm3D.Show()

    End Sub
End Class
