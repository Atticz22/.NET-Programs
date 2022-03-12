<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCNP
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txtbCNP = New System.Windows.Forms.TextBox()
        Me.txtbValiditate = New System.Windows.Forms.TextBox()
        Me.txtbLN = New System.Windows.Forms.TextBox()
        Me.txtbDN = New System.Windows.Forms.TextBox()
        Me.txtbSex = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnAnalizeaza = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtbCNP
        '
        Me.txtbCNP.Location = New System.Drawing.Point(123, 39)
        Me.txtbCNP.Name = "txtbCNP"
        Me.txtbCNP.Size = New System.Drawing.Size(329, 27)
        Me.txtbCNP.TabIndex = 0
        '
        'txtbValiditate
        '
        Me.txtbValiditate.Location = New System.Drawing.Point(123, 137)
        Me.txtbValiditate.Name = "txtbValiditate"
        Me.txtbValiditate.ReadOnly = True
        Me.txtbValiditate.Size = New System.Drawing.Size(329, 27)
        Me.txtbValiditate.TabIndex = 1
        '
        'txtbLN
        '
        Me.txtbLN.Location = New System.Drawing.Point(123, 237)
        Me.txtbLN.Name = "txtbLN"
        Me.txtbLN.ReadOnly = True
        Me.txtbLN.Size = New System.Drawing.Size(329, 27)
        Me.txtbLN.TabIndex = 2
        '
        'txtbDN
        '
        Me.txtbDN.Location = New System.Drawing.Point(123, 287)
        Me.txtbDN.Name = "txtbDN"
        Me.txtbDN.ReadOnly = True
        Me.txtbDN.Size = New System.Drawing.Size(329, 27)
        Me.txtbDN.TabIndex = 3
        '
        'txtbSex
        '
        Me.txtbSex.Location = New System.Drawing.Point(123, 189)
        Me.txtbSex.Name = "txtbSex"
        Me.txtbSex.ReadOnly = True
        Me.txtbSex.Size = New System.Drawing.Size(329, 27)
        Me.txtbSex.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(26, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 20)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "CNP:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(26, 140)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 20)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Validitate:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(26, 189)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 20)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Sex:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(26, 240)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(87, 20)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Loc nastere:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(26, 290)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(96, 20)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Data nasterii:"
        '
        'btnAnalizeaza
        '
        Me.btnAnalizeaza.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAnalizeaza.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnAnalizeaza.Location = New System.Drawing.Point(504, 37)
        Me.btnAnalizeaza.Name = "btnAnalizeaza"
        Me.btnAnalizeaza.Size = New System.Drawing.Size(154, 29)
        Me.btnAnalizeaza.TabIndex = 10
        Me.btnAnalizeaza.Text = "&Analizeaza"
        Me.btnAnalizeaza.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(504, 237)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(154, 29)
        Me.btnReset.TabIndex = 11
        Me.btnReset.Text = "&Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(504, 287)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(154, 29)
        Me.btnExit.TabIndex = 12
        Me.btnExit.Text = "I&esire"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmCNP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(720, 365)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnAnalizeaza)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtbSex)
        Me.Controls.Add(Me.txtbDN)
        Me.Controls.Add(Me.txtbLN)
        Me.Controls.Add(Me.txtbValiditate)
        Me.Controls.Add(Me.txtbCNP)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmCNP"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CNP"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtbCNP As TextBox
    Friend WithEvents txtbValiditate As TextBox
    Friend WithEvents txtbLN As TextBox
    Friend WithEvents txtbDN As TextBox
    Friend WithEvents txtbSex As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents btnAnalizeaza As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents btnExit As Button

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles txtbSex.TextChanged

    End Sub

    Private Sub btnAnalizeaza_Click(sender As Object, e As EventArgs) Handles btnAnalizeaza.Click
        Dim cnp, constanta, RestImpartire, Luna As String
        Dim c1, c2, c3, c4, c5, c6, c7, c8, c9, c10, c11, c12, Suma As Integer

        cnp = txtbCNP.Text
        Luna = Strings.Mid(cnp, 4, 2)

        If cnp.Length = 13 Then
            constanta = 279146358279

            c1 = Strings.Left(cnp, 1) * Strings.Left(constanta, 1)
            c2 = Strings.Mid(cnp, 2, 1) * Strings.Mid(constanta, 2, 1)
            c3 = Strings.Mid(cnp, 3, 1) * Strings.Mid(constanta, 3, 1)
            c4 = Strings.Mid(cnp, 4, 1) * Strings.Mid(constanta, 4, 1)
            c5 = Strings.Mid(cnp, 5, 1) * Strings.Mid(constanta, 5, 1)
            c6 = Strings.Mid(cnp, 6, 1) * Strings.Mid(constanta, 6, 1)
            c7 = Strings.Mid(cnp, 7, 1) * Strings.Mid(constanta, 7, 1)
            c8 = Strings.Mid(cnp, 8, 1) * Strings.Mid(constanta, 8, 1)
            c9 = Strings.Mid(cnp, 9, 1) * Strings.Mid(constanta, 9, 1)
            c10 = Strings.Mid(cnp, 10, 1) * Strings.Mid(constanta, 10, 1)
            c11 = Strings.Mid(cnp, 11, 1) * Strings.Mid(constanta, 11, 1)
            c12 = Strings.Mid(cnp, 12, 1) * Strings.Mid(constanta, 12, 1)

            Suma = c1 + c2 + c3 + c4 + c5 + c6 + c7 + c8 + c9 + c10 + c11 + c12
            RestImpartire = Suma Mod 11

            If 0 <= RestImpartire <= 10 Then
                txtbValiditate.Text = "Valid"
                txtbValiditate.BackColor = Color.LightGreen
            Else
                txtbValiditate.Text = "Invalid"
                txtbValiditate.BackColor = Color.LightPink
            End If

            If Strings.Left(cnp, 1) = 1 Or Strings.Left(cnp, 1) = 3 Or Strings.Left(cnp, 1) = 5 Then
                txtbSex.Text = "Masculin"
                txtbSex.BackColor = Color.LightBlue

            ElseIf Strings.Left(cnp, 1) = 7 Then
                txtbSex.Text = "Masculin, Persoana rezidenta"
                txtbSex.BackColor = Color.LightBlue
            End If

            If Strings.Left(cnp, 1) = 2 Or Strings.Left(cnp, 1) = 4 Or Strings.Left(cnp, 1) = 6 Then
                txtbSex.Text = "Feminin"
                txtbSex.BackColor = Color.PaleVioletRed
            ElseIf Strings.Left(cnp, 1) = 8 Then
                txtbSex.Text = "Feminin, Persoana rezidenta"
                txtbSex.BackColor = Color.PaleVioletRed
            End If


            If Strings.Mid(cnp, 8, 2) = 26 Then
                txtbLN.Text = "Judetul Mures"
            Else
                txtbLN.Text = "-"
            End If

        Else
            txtbValiditate.Text = "Invalid"
            txtbValiditate.BackColor = Color.LightPink
        End If

        Select Case Luna
            Case 1
                Luna = "Ianuarie"
            Case 2
                Luna = "Februarie"
            Case 3
                Luna = "Martie"
            Case 4
                Luna = "Aprilie"
            Case 5
                Luna = "Mai"
            Case 6
                Luna = "Iunie"
            Case 7
                Luna = "Iulie"
            Case 8
                Luna = "August"
            Case 9
                Luna = "Septembrie"
            Case 10
                Luna = "Octombrie"
            Case 11
                Luna = "Novembrie"
            Case 12
                Luna = "Decembrie"
        End Select

    End Sub
End Class
