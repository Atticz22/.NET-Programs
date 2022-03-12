<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSuma
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
        Me.groupControl = New System.Windows.Forms.GroupBox()
        Me.txtbNumar = New System.Windows.Forms.TextBox()
        Me.btnAdauga = New System.Windows.Forms.Button()
        Me.btnSterge = New System.Windows.Forms.Button()
        Me.btnStergeLista = New System.Windows.Forms.Button()
        Me.btnAleatoriu = New System.Windows.Forms.Button()
        Me.lstbNumere = New System.Windows.Forms.ListBox()
        Me.btnCalculSuma = New System.Windows.Forms.Button()
        Me.btnIesire = New System.Windows.Forms.Button()
        Me.btnInfo = New System.Windows.Forms.Button()
        Me.txtbSuma = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.groupControl.SuspendLayout()
        Me.SuspendLayout()
        '
        'groupControl
        '
        Me.groupControl.Controls.Add(Me.btnAleatoriu)
        Me.groupControl.Controls.Add(Me.btnStergeLista)
        Me.groupControl.Controls.Add(Me.btnSterge)
        Me.groupControl.Controls.Add(Me.btnAdauga)
        Me.groupControl.Controls.Add(Me.txtbNumar)
        Me.groupControl.Location = New System.Drawing.Point(26, 33)
        Me.groupControl.Name = "groupControl"
        Me.groupControl.Size = New System.Drawing.Size(187, 309)
        Me.groupControl.TabIndex = 0
        Me.groupControl.TabStop = False
        Me.groupControl.Text = "Control lista"
        '
        'txtbNumar
        '
        Me.txtbNumar.Location = New System.Drawing.Point(18, 49)
        Me.txtbNumar.Name = "txtbNumar"
        Me.txtbNumar.Size = New System.Drawing.Size(148, 27)
        Me.txtbNumar.TabIndex = 0
        '
        'btnAdauga
        '
        Me.btnAdauga.Location = New System.Drawing.Point(18, 99)
        Me.btnAdauga.Name = "btnAdauga"
        Me.btnAdauga.Size = New System.Drawing.Size(62, 29)
        Me.btnAdauga.TabIndex = 1
        Me.btnAdauga.Text = "+"
        Me.btnAdauga.UseVisualStyleBackColor = True
        '
        'btnSterge
        '
        Me.btnSterge.Location = New System.Drawing.Point(101, 99)
        Me.btnSterge.Name = "btnSterge"
        Me.btnSterge.Size = New System.Drawing.Size(65, 29)
        Me.btnSterge.TabIndex = 2
        Me.btnSterge.Text = "-"
        Me.btnSterge.UseVisualStyleBackColor = True
        '
        'btnStergeLista
        '
        Me.btnStergeLista.Location = New System.Drawing.Point(18, 169)
        Me.btnStergeLista.Name = "btnStergeLista"
        Me.btnStergeLista.Size = New System.Drawing.Size(148, 29)
        Me.btnStergeLista.TabIndex = 3
        Me.btnStergeLista.Text = "Sterge lista"
        Me.btnStergeLista.UseVisualStyleBackColor = True
        '
        'btnAleatoriu
        '
        Me.btnAleatoriu.Location = New System.Drawing.Point(18, 227)
        Me.btnAleatoriu.Name = "btnAleatoriu"
        Me.btnAleatoriu.Size = New System.Drawing.Size(148, 29)
        Me.btnAleatoriu.TabIndex = 4
        Me.btnAleatoriu.Text = "Aleatoriu"
        Me.btnAleatoriu.UseVisualStyleBackColor = True
        '
        'lstbNumere
        '
        Me.lstbNumere.FormattingEnabled = True
        Me.lstbNumere.ItemHeight = 20
        Me.lstbNumere.Location = New System.Drawing.Point(273, 33)
        Me.lstbNumere.Name = "lstbNumere"
        Me.lstbNumere.Size = New System.Drawing.Size(184, 304)
        Me.lstbNumere.TabIndex = 1
        '
        'btnCalculSuma
        '
        Me.btnCalculSuma.Location = New System.Drawing.Point(525, 66)
        Me.btnCalculSuma.Name = "btnCalculSuma"
        Me.btnCalculSuma.Size = New System.Drawing.Size(148, 29)
        Me.btnCalculSuma.TabIndex = 5
        Me.btnCalculSuma.Text = "Calcul suma"
        Me.btnCalculSuma.UseVisualStyleBackColor = True
        '
        'btnIesire
        '
        Me.btnIesire.Location = New System.Drawing.Point(525, 280)
        Me.btnIesire.Name = "btnIesire"
        Me.btnIesire.Size = New System.Drawing.Size(148, 29)
        Me.btnIesire.TabIndex = 6
        Me.btnIesire.Text = "Iesire"
        Me.btnIesire.UseVisualStyleBackColor = True
        '
        'btnInfo
        '
        Me.btnInfo.Location = New System.Drawing.Point(525, 227)
        Me.btnInfo.Name = "btnInfo"
        Me.btnInfo.Size = New System.Drawing.Size(148, 29)
        Me.btnInfo.TabIndex = 7
        Me.btnInfo.Text = "Info"
        Me.btnInfo.UseVisualStyleBackColor = True
        '
        'txtbSuma
        '
        Me.txtbSuma.Location = New System.Drawing.Point(525, 150)
        Me.txtbSuma.Name = "txtbSuma"
        Me.txtbSuma.Size = New System.Drawing.Size(148, 27)
        Me.txtbSuma.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(525, 127)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 20)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Suma:"
        '
        'frmSuma
        '
        Me.AcceptButton = Me.btnAdauga
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(733, 371)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtbSuma)
        Me.Controls.Add(Me.btnInfo)
        Me.Controls.Add(Me.btnIesire)
        Me.Controls.Add(Me.btnCalculSuma)
        Me.Controls.Add(Me.lstbNumere)
        Me.Controls.Add(Me.groupControl)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmSuma"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Suma Sir"
        Me.groupControl.ResumeLayout(False)
        Me.groupControl.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents groupControl As GroupBox
    Friend WithEvents btnAleatoriu As Button
    Friend WithEvents btnStergeLista As Button
    Friend WithEvents btnSterge As Button
    Friend WithEvents btnAdauga As Button
    Friend WithEvents txtbNumar As TextBox
    Friend WithEvents lstbNumere As ListBox
    Friend WithEvents btnCalculSuma As Button
    Friend WithEvents btnIesire As Button
    Friend WithEvents btnInfo As Button
    Friend WithEvents txtbSuma As TextBox
    Friend WithEvents Label1 As Label
End Class
