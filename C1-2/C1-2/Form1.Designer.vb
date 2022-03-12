<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProdus
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnStergeTot = New System.Windows.Forms.Button()
        Me.btnSterge = New System.Windows.Forms.Button()
        Me.btnAdauga = New System.Windows.Forms.Button()
        Me.txtbNumere = New System.Windows.Forms.TextBox()
        Me.listbNumere = New System.Windows.Forms.ListBox()
        Me.btnCalcul = New System.Windows.Forms.Button()
        Me.txtbNumerePoz = New System.Windows.Forms.TextBox()
        Me.txtbNumereNeg = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnStergeTot)
        Me.GroupBox1.Controls.Add(Me.btnSterge)
        Me.GroupBox1.Controls.Add(Me.btnAdauga)
        Me.GroupBox1.Controls.Add(Me.txtbNumere)
        Me.GroupBox1.Location = New System.Drawing.Point(34, 31)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(154, 196)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Control lista"
        '
        'btnStergeTot
        '
        Me.btnStergeTot.Location = New System.Drawing.Point(6, 142)
        Me.btnStergeTot.Name = "btnStergeTot"
        Me.btnStergeTot.Size = New System.Drawing.Size(142, 29)
        Me.btnStergeTot.TabIndex = 3
        Me.btnStergeTot.Text = " Sterge lista"
        Me.btnStergeTot.UseVisualStyleBackColor = True
        '
        'btnSterge
        '
        Me.btnSterge.Location = New System.Drawing.Point(90, 90)
        Me.btnSterge.Name = "btnSterge"
        Me.btnSterge.Size = New System.Drawing.Size(58, 29)
        Me.btnSterge.TabIndex = 2
        Me.btnSterge.Text = "-"
        Me.btnSterge.UseVisualStyleBackColor = True
        '
        'btnAdauga
        '
        Me.btnAdauga.Location = New System.Drawing.Point(6, 90)
        Me.btnAdauga.Name = "btnAdauga"
        Me.btnAdauga.Size = New System.Drawing.Size(58, 29)
        Me.btnAdauga.TabIndex = 1
        Me.btnAdauga.Text = "+"
        Me.btnAdauga.UseVisualStyleBackColor = True
        '
        'txtbNumere
        '
        Me.txtbNumere.Location = New System.Drawing.Point(6, 37)
        Me.txtbNumere.Name = "txtbNumere"
        Me.txtbNumere.Size = New System.Drawing.Size(142, 27)
        Me.txtbNumere.TabIndex = 0
        '
        'listbNumere
        '
        Me.listbNumere.FormattingEnabled = True
        Me.listbNumere.ItemHeight = 20
        Me.listbNumere.Location = New System.Drawing.Point(249, 31)
        Me.listbNumere.Name = "listbNumere"
        Me.listbNumere.Size = New System.Drawing.Size(158, 204)
        Me.listbNumere.TabIndex = 1
        '
        'btnCalcul
        '
        Me.btnCalcul.Location = New System.Drawing.Point(453, 31)
        Me.btnCalcul.Name = "btnCalcul"
        Me.btnCalcul.Size = New System.Drawing.Size(161, 29)
        Me.btnCalcul.TabIndex = 4
        Me.btnCalcul.Text = "Calcul"
        Me.btnCalcul.UseVisualStyleBackColor = True
        '
        'txtbNumerePoz
        '
        Me.txtbNumerePoz.Location = New System.Drawing.Point(453, 135)
        Me.txtbNumerePoz.Name = "txtbNumerePoz"
        Me.txtbNumerePoz.ReadOnly = True
        Me.txtbNumerePoz.Size = New System.Drawing.Size(161, 27)
        Me.txtbNumerePoz.TabIndex = 5
        '
        'txtbNumereNeg
        '
        Me.txtbNumereNeg.Location = New System.Drawing.Point(453, 208)
        Me.txtbNumereNeg.Name = "txtbNumereNeg"
        Me.txtbNumereNeg.ReadOnly = True
        Me.txtbNumereNeg.Size = New System.Drawing.Size(161, 27)
        Me.txtbNumereNeg.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(453, 112)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(168, 20)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Produs numere pozitive:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(453, 185)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(172, 20)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Produs numere negative:"
        '
        'frmProdus
        '
        Me.AcceptButton = Me.btnAdauga
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(735, 262)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtbNumereNeg)
        Me.Controls.Add(Me.txtbNumerePoz)
        Me.Controls.Add(Me.btnCalcul)
        Me.Controls.Add(Me.listbNumere)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmProdus"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Produs numere pozitive/negative"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnStergeTot As Button
    Friend WithEvents btnSterge As Button
    Friend WithEvents btnAdauga As Button
    Friend WithEvents txtbNumere As TextBox
    Friend WithEvents listbNumere As ListBox
    Friend WithEvents btnCalcul As Button
    Friend WithEvents txtbNumerePoz As TextBox
    Friend WithEvents txtbNumereNeg As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
