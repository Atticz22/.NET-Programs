Public Class frmOra
    Private Sub chbFormatScurt_CheckedChanged(sender As Object, e As EventArgs) Handles chbFormatScurt.CheckedChanged

    End Sub

    Private Sub chbAfisareOras_CheckedChanged(sender As Object, e As EventArgs) Handles chbAfisareOras.CheckedChanged
        lblOras.Visible = chbAfisareOras.Checked
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles rbRosu.CheckedChanged
        lblOras.ForeColor = Color.Red
        lblOra.ForeColor = Color.Red
        lblData.ForeColor = Color.Red
    End Sub

    Private Sub lblOras_Click(sender As Object, e As EventArgs) Handles lblOras.Click

    End Sub

    Private Sub frmOra_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        combobOras.SelectedIndex = 0
        lstbFont.SelectedIndex = 3
    End Sub

    Private Sub combobOras_SelectedIndexChanged(sender As Object, e As EventArgs) Handles combobOras.SelectedIndexChanged
        If chbAfisareOras.Checked Then
            lblOras.Text = combobOras.SelectedItem
        Else
            lblOras.Text = "###"
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim difOra As Integer
        Select Case combobOras.SelectedIndex
            Case 0
                difOra = 3
            Case 1
                difOra = 2
            Case 2
                difOra = 1
            Case 3
                difOra = 3
            Case 4
                difOra = -4
            Case 5
                difOra = 9
        End Select

        Dim t As DateTime
        t = Now.ToUniversalTime.AddHours(difOra)

        lblOra.Text = t.ToLongTimeString
        If chbFormatScurt.Checked Then
            lblData.Text = t.ToShortDateString
        Else
            lblData.Text = t.ToLongDateString
        End If
        lblOras.Text = combobOras.SelectedItem
    End Sub

    Private Sub chbAfisareData_CheckedChanged(sender As Object, e As EventArgs) Handles chbAfisareData.CheckedChanged
        lblData.Visible = chbAfisareData.Checked
        chbFormatScurt.Enabled = chbAfisareData.Checked
    End Sub

    Private Sub lstbFont_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstbFont.SelectedIndexChanged

        Dim h As Integer
        h = lstbFont.SelectedItem

        Dim f, r As Font
        f = New Font("Verdana", h, FontStyle.Bold)
        r = New Font("Verdana", h, FontStyle.Regular)

        If ckbBold.Checked Then
            lblOras.Font = f
            lblOra.Font = f
            lblData.Font = f
        Else
            lblOras.Font = r
            lblOra.Font = r
            lblData.Font = r

        End If

    End Sub

    Private Sub rbNegru_CheckedChanged(sender As Object, e As EventArgs) Handles rbNegru.CheckedChanged
        lblOras.ForeColor = Color.Black
        lblOra.ForeColor = Color.Black
        lblData.ForeColor = Color.Black

    End Sub

    Private Sub rbVerde_CheckedChanged(sender As Object, e As EventArgs) Handles rbVerde.CheckedChanged
        lblOras.ForeColor = Color.Green
        lblOra.ForeColor = Color.Green
        lblData.ForeColor = Color.Green
    End Sub

    Private Sub rbAlbastru_CheckedChanged(sender As Object, e As EventArgs) Handles rbAlbastru.CheckedChanged
        lblOras.ForeColor = Color.Blue
        lblOra.ForeColor = Color.Blue
        lblData.ForeColor = Color.Blue
    End Sub

    Private Sub lblData_Click(sender As Object, e As EventArgs) Handles lblData.Click

    End Sub
End Class
