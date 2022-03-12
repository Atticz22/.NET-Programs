<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDepozit
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtbDepozit = New System.Windows.Forms.TextBox()
        Me.txtbDobanda = New System.Windows.Forms.TextBox()
        Me.txtbSuma = New System.Windows.Forms.TextBox()
        Me.combobTermen = New System.Windows.Forms.ComboBox()
        Me.btnCalc = New System.Windows.Forms.Button()
        Me.chbSumaNeta = New System.Windows.Forms.CheckBox()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(68, 73)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(135, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Depozit initial(Lei):"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(257, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Termen:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(345, 72)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Dobanda:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(68, 291)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(119, 20)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Suma finala(Lei):"
        '
        'txtbDepozit
        '
        Me.txtbDepozit.Location = New System.Drawing.Point(68, 96)
        Me.txtbDepozit.Name = "txtbDepozit"
        Me.txtbDepozit.Size = New System.Drawing.Size(135, 27)
        Me.txtbDepozit.TabIndex = 4
        '
        'txtbDobanda
        '
        Me.txtbDobanda.Location = New System.Drawing.Point(345, 96)
        Me.txtbDobanda.Name = "txtbDobanda"
        Me.txtbDobanda.ReadOnly = True
        Me.txtbDobanda.Size = New System.Drawing.Size(74, 27)
        Me.txtbDobanda.TabIndex = 5
        '
        'txtbSuma
        '
        Me.txtbSuma.Location = New System.Drawing.Point(68, 314)
        Me.txtbSuma.Name = "txtbSuma"
        Me.txtbSuma.Size = New System.Drawing.Size(135, 27)
        Me.txtbSuma.TabIndex = 6
        '
        'combobTermen
        '
        Me.combobTermen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.combobTermen.FormattingEnabled = True
        Me.combobTermen.Items.AddRange(New Object() {"3", "6", "12"})
        Me.combobTermen.Location = New System.Drawing.Point(257, 95)
        Me.combobTermen.Name = "combobTermen"
        Me.combobTermen.Size = New System.Drawing.Size(61, 28)
        Me.combobTermen.TabIndex = 7
        '
        'btnCalc
        '
        Me.btnCalc.Location = New System.Drawing.Point(68, 223)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(351, 42)
        Me.btnCalc.TabIndex = 8
        Me.btnCalc.Text = "Calculeaza"
        Me.btnCalc.UseVisualStyleBackColor = True
        '
        'chbSumaNeta
        '
        Me.chbSumaNeta.AutoSize = True
        Me.chbSumaNeta.Location = New System.Drawing.Point(68, 148)
        Me.chbSumaNeta.Name = "chbSumaNeta"
        Me.chbSumaNeta.Size = New System.Drawing.Size(200, 24)
        Me.chbSumaNeta.TabIndex = 9
        Me.chbSumaNeta.Text = "Suma neta(dupa depozit)"
        Me.chbSumaNeta.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(396, 339)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(115, 29)
        Me.btnExit.TabIndex = 10
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmDepozit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(607, 405)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.chbSumaNeta)
        Me.Controls.Add(Me.btnCalc)
        Me.Controls.Add(Me.combobTermen)
        Me.Controls.Add(Me.txtbSuma)
        Me.Controls.Add(Me.txtbDobanda)
        Me.Controls.Add(Me.txtbDepozit)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmDepozit"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Depozit la termen"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtbDepozit As TextBox
    Friend WithEvents txtbDobanda As TextBox
    Friend WithEvents txtbSuma As TextBox
    Friend WithEvents combobTermen As ComboBox
    Friend WithEvents btnCalc As Button
    Friend WithEvents chbSumaNeta As CheckBox
    Friend WithEvents btnExit As Button
End Class
