Imports System.ComponentModel

Public Class frmEcuatii
    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtbA.TextChanged
        If Not IsNumeric(txtbA.Text) Then
            MessageBox.Show("Trebuie introdusa valori corecte", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtbA.SelectAll()
            txtbA.Focus()
            Exit Sub
        End If
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnIESIRE.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnCALCULEAZA.Click
        Dim a, b, c, D, x1, x2 As Single


        a = txtbA.Text
        b = txtbB.Text
        c = txtbC.Text

        D = b ^ 2 - 4 * a * c

        If D < 0 Then
            MessageBox.Show("Eroare: Solutii complexe!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Else
            x1 = (-b + Math.Sqrt(D)) / (2 * a)
            x2 = (-b - Math.Sqrt(D)) / (2 * a)
            txtbX1.Text = Math.Round(x1, 2)
            txtbX2.Text = Math.Round(x2, 2)

        End If

        If D = 0 Then
            MessageBox.Show("Ecuatia are o singura solutie!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub

    Private Sub txtbB_TextChanged(sender As Object, e As EventArgs) Handles txtbB.TextChanged
        If Not IsNumeric(txtbB.Text) Then
            MessageBox.Show("Trebuie introdusa valori corecte", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtbB.SelectAll()
            txtbB.Focus()
            Exit Sub
        End If
    End Sub

    Private Sub txtbC_TextChanged(sender As Object, e As EventArgs) Handles txtbC.TextChanged
        If Not IsNumeric(txtbC.Text) Then
            MessageBox.Show("Trebuie introdusa valori corecte", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtbC.SelectAll()
            txtbC.Focus()
            Exit Sub
        End If
    End Sub

    Private Sub txtbB_Validating(sender As Object, e As CancelEventArgs) Handles txtbB.Validating
        If Not IsNumeric(txtbB.Text) Then
            e.Cancel = True

        End If
    End Sub
End Class
