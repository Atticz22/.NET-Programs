<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmCalcTrigonom
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtbUnghi = New System.Windows.Forms.TextBox()
        Me.txtbRezultat = New System.Windows.Forms.TextBox()
        Me.btnCalc = New System.Windows.Forms.Button()
        Me.grpbFunctie = New System.Windows.Forms.GroupBox()
        Me.rbCtg = New System.Windows.Forms.RadioButton()
        Me.rbTg = New System.Windows.Forms.RadioButton()
        Me.rbCos = New System.Windows.Forms.RadioButton()
        Me.rbSin = New System.Windows.Forms.RadioButton()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.grpbFunctie.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(47, 54)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Unghi:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(195, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "grade"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(47, 219)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Rezultat:"
        '
        'txtbUnghi
        '
        Me.txtbUnghi.Location = New System.Drawing.Point(104, 51)
        Me.txtbUnghi.Name = "txtbUnghi"
        Me.txtbUnghi.Size = New System.Drawing.Size(85, 27)
        Me.txtbUnghi.TabIndex = 3
        '
        'txtbRezultat
        '
        Me.txtbRezultat.Location = New System.Drawing.Point(119, 216)
        Me.txtbRezultat.Name = "txtbRezultat"
        Me.txtbRezultat.Size = New System.Drawing.Size(139, 27)
        Me.txtbRezultat.TabIndex = 4
        '
        'btnCalc
        '
        Me.btnCalc.Location = New System.Drawing.Point(84, 168)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(174, 32)
        Me.btnCalc.TabIndex = 5
        Me.btnCalc.Text = "Calculeaza"
        Me.btnCalc.UseVisualStyleBackColor = True
        '
        'grpbFunctie
        '
        Me.grpbFunctie.Controls.Add(Me.rbCtg)
        Me.grpbFunctie.Controls.Add(Me.rbTg)
        Me.grpbFunctie.Controls.Add(Me.rbCos)
        Me.grpbFunctie.Controls.Add(Me.rbSin)
        Me.grpbFunctie.Location = New System.Drawing.Point(309, 51)
        Me.grpbFunctie.Name = "grpbFunctie"
        Me.grpbFunctie.Size = New System.Drawing.Size(85, 149)
        Me.grpbFunctie.TabIndex = 6
        Me.grpbFunctie.TabStop = False
        Me.grpbFunctie.Text = "Functie"
        '
        'rbCtg
        '
        Me.rbCtg.AutoSize = True
        Me.rbCtg.Location = New System.Drawing.Point(6, 116)
        Me.rbCtg.Name = "rbCtg"
        Me.rbCtg.Size = New System.Drawing.Size(51, 24)
        Me.rbCtg.TabIndex = 3
        Me.rbCtg.Text = "ctg"
        Me.rbCtg.UseVisualStyleBackColor = True
        '
        'rbTg
        '
        Me.rbTg.AutoSize = True
        Me.rbTg.Location = New System.Drawing.Point(6, 86)
        Me.rbTg.Name = "rbTg"
        Me.rbTg.Size = New System.Drawing.Size(44, 24)
        Me.rbTg.TabIndex = 2
        Me.rbTg.Text = "tg"
        Me.rbTg.UseVisualStyleBackColor = True
        '
        'rbCos
        '
        Me.rbCos.AutoSize = True
        Me.rbCos.Location = New System.Drawing.Point(6, 56)
        Me.rbCos.Name = "rbCos"
        Me.rbCos.Size = New System.Drawing.Size(52, 24)
        Me.rbCos.TabIndex = 1
        Me.rbCos.Text = "cos"
        Me.rbCos.UseVisualStyleBackColor = True
        '
        'rbSin
        '
        Me.rbSin.AutoSize = True
        Me.rbSin.Checked = True
        Me.rbSin.Location = New System.Drawing.Point(6, 26)
        Me.rbSin.Name = "rbSin"
        Me.rbSin.Size = New System.Drawing.Size(48, 24)
        Me.rbSin.TabIndex = 0
        Me.rbSin.TabStop = True
        Me.rbSin.Text = "sin"
        Me.rbSin.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(84, 129)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(174, 32)
        Me.btnReset.TabIndex = 7
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'frmCalcTrigonom
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(477, 281)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.grpbFunctie)
        Me.Controls.Add(Me.btnCalc)
        Me.Controls.Add(Me.txtbRezultat)
        Me.Controls.Add(Me.txtbUnghi)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmCalcTrigonom"
        Me.Text = "Calcule trigonometrice"
        Me.grpbFunctie.ResumeLayout(False)
        Me.grpbFunctie.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtbUnghi As TextBox
    Friend WithEvents txtbRezultat As TextBox
    Friend WithEvents btnCalc As Button
    Friend WithEvents grpbFunctie As GroupBox
    Friend WithEvents rbCtg As RadioButton
    Friend WithEvents rbTg As RadioButton
    Friend WithEvents rbCos As RadioButton
    Friend WithEvents rbSin As RadioButton
    Friend WithEvents btnReset As Button
End Class
