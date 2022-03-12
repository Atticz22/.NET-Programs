Public Class frmCalcVarsta
    Private Sub btnINFO_Click(sender As Object, e As EventArgs) Handles btnINFO.Click
        Dim nume, prenume As String
        Dim datanasterii, datacurenta As Date
        Dim interval As TimeSpan
        Dim varstaani As Integer
        Dim info As String

        nume = txtbNUME.Text
        prenume = txtbPRENUME.Text
        datanasterii = dtpDATANASTERII.Value
        datacurenta = Now

        If datanasterii > datacurenta Then
            MsgBox("Data nasterii nu poate fi in viitor")
        Else
            interval = datacurenta - datanasterii
            varstaani = Math.Floor(interval.Days / 365.25)
            prenume = Strings.Left(prenume, 1) & "."
            info = nume & " " & prenume & " are " & varstaani & " ani "
            txtbINFO.Text = info

        End If
    End Sub
End Class
