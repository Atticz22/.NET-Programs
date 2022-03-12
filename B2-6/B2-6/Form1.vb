Public Class Form1
    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles checkbX3.CheckedChanged

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles combobX2.SelectedIndexChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim x, a0, a1, a2, a3, i, j, k, l, f As Double


        If Not IsNumeric(txtbFX.Text) Then
            MsgBox("Atentie!")
            Exit Sub
        End If

        x = txtbFX.Text
        i = combobN.SelectedIndex
        j = combobX.SelectedIndex
        k = combobX2.SelectedIndex
        l = combobX3.SelectedIndex

        If checkbN.Checked Then
            a0 = txtbN.Text
            If i = 0 Then
                f = f + a0
            Else
                f = f - a0
            End If
        End If
        If checkbX.Checked Then
            a1 = txtbX.Text
            If j = 0 Then
                f = f + a1 * x
            Else
                f = f - a1 * x
            End If
        End If
        If checkbX2.Checked Then
            a2 = txtbX2.Text
            If k = 0 Then
                f = f + a2 * x ^ 2
            Else
                f = f - a2 * x ^ 2
            End If
        End If
        If checkbX3.Checked Then
            a3 = txtbX3.Text
            If l = 0 Then
                f = f + a3 * x ^ 3
            Else
                f = f - a3 * x ^ 3
            End If
        End If

        txtbSuma.Text = f



    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub checkbN_CheckedChanged(sender As Object, e As EventArgs) Handles checkbN.CheckedChanged
        txtbN.Enabled = checkbN.Checked
        combobN.Enabled = checkbN.Checked
    End Sub
End Class
