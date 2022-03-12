Public Class frmAdunare
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub frmAdunare_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnInfo.Click
        MsgBox("GG EASY :)
")
    End Sub

    Private Sub btnAduna_Click(sender As Object, e As EventArgs) Handles btnAduna.Click
        Dim a As Integer, b As Integer
        Dim s As Integer

        a = txtA.Text
        b = txtB.Text

        s = a + b

        txtSuma.Text = s


    End Sub

    Private Sub txtSuma_TextChanged(sender As Object, e As EventArgs) Handles txtSuma.TextChanged

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()

    End Sub
End Class
