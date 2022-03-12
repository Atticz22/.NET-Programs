Public Class frmLuni
    Private Sub nudLuna_ValueChanged(sender As Object, e As EventArgs) Handles nudLuna.ValueChanged
        Select Case nudLuna.Value
            Case 1
                txtbRo.Text = "Ianuarie"
                txtbEng.Text = "January"
                txtbES.Text = "Enero"
                txtbNRZile.Text = "31"
            Case 2
                txtbRo.Text = "Februarie"
                txtbEng.Text = "February"
                txtbES.Text = "Febrero"
                txtbNRZile.Text = "28"
            Case 3
                txtbRo.Text = "Martie"
                txtbEng.Text = "March"
                txtbES.Text = "Marcha"
                txtbNRZile.Text = "31"
            Case 4
                txtbRo.Text = "Aprilie"
                txtbEng.Text = "April"
                txtbES.Text = "Abril"
                txtbNRZile.Text = "30"
            Case 5
                txtbRo.Text = "Mai"
                txtbEng.Text = "May"
                txtbES.Text = "Mayo"
                txtbNRZile.Text = "31"
            Case 6
                txtbRo.Text = "Iunie"
                txtbEng.Text = "June"
                txtbES.Text = "Junio"
                txtbNRZile.Text = "30"
            Case 7
                txtbRo.Text = "Iulie"
                txtbEng.Text = "July"
                txtbES.Text = "Julio"
                txtbNRZile.Text = "31"
            Case 8
                txtbRo.Text = "August"
                txtbEng.Text = "August"
                txtbES.Text = "Agosto"
                txtbNRZile.Text = "31"
            Case 9
                txtbRo.Text = "Septembrie"
                txtbEng.Text = "September"
                txtbES.Text = "Septiembre"
                txtbNRZile.Text = "30"
            Case 10
                txtbRo.Text = "Octombrie"
                txtbEng.Text = "October"
                txtbES.Text = "Octubre"
                txtbNRZile.Text = "31"
            Case 11
                txtbRo.Text = "Novembrie"
                txtbEng.Text = "November"
                txtbES.Text = "Noviembre"
                txtbNRZile.Text = "30"
            Case 12
                txtbRo.Text = "Decembrie"
                txtbEng.Text = "December"
                txtbES.Text = "Deciembre"
                txtbNRZile.Text = "31"

        End Select



    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class