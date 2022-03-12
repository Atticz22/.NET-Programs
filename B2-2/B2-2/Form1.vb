Public Class frmDepozit
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub frmDepozit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        combobTermen.SelectedIndex = 0
    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        Dim depozit, i, dobanda, dobandaAC, suma As Single

        i = combobTermen.SelectedItem
        dobanda = txtbDobanda.Text
        depozit = txtbDepozit.Text

        dobandaAC = depozit * (i / 12) * (dobanda / 100)

        If chbSumaNeta.Checked Then
            suma = depozit + (dobandaAC * 0.84)
            txtbSuma.BackColor = Color.LightGreen
        Else
            suma = depozit + dobandaAC
            txtbSuma.BackColor = Color.LightYellow
        End If

        txtbSuma.Text = Math.Round(suma, 3)

    End Sub

    Private Sub txtbDobanda_TextChanged(sender As Object, e As EventArgs) Handles txtbDobanda.TextChanged

    End Sub

    Private Sub combobTermen_SelectedIndexChanged(sender As Object, e As EventArgs) Handles combobTermen.SelectedIndexChanged
        Dim i, dobanda As Single

        i = combobTermen.SelectedIndex

        Select Case i
            Case 0
                i = 0
                dobanda = 2.5
            Case 1
                i = 1
                dobanda = 3
            Case 2
                i = 2
                dobanda = 3.5
        End Select

        txtbDobanda.Text = dobanda

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
