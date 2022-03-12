<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCalcTr
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
        Me.lblRez = New System.Windows.Forms.Label()
        Me.txtU = New System.Windows.Forms.TextBox()
        Me.txtRez = New System.Windows.Forms.TextBox()
        Me.btnSin = New System.Windows.Forms.Button()
        Me.btnCos = New System.Windows.Forms.Button()
        Me.btnTg = New System.Windows.Forms.Button()
        Me.btnCtg = New System.Windows.Forms.Button()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(53, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Unghi:"
        '
        'lblRez
        '
        Me.lblRez.AutoSize = True
        Me.lblRez.Location = New System.Drawing.Point(53, 221)
        Me.lblRez.Name = "lblRez"
        Me.lblRez.Size = New System.Drawing.Size(66, 20)
        Me.lblRez.TabIndex = 1
        Me.lblRez.Text = "Rezultat:"
        '
        'txtU
        '
        Me.txtU.Location = New System.Drawing.Point(134, 56)
        Me.txtU.Name = "txtU"
        Me.txtU.Size = New System.Drawing.Size(209, 27)
        Me.txtU.TabIndex = 2
        '
        'txtRez
        '
        Me.txtRez.Location = New System.Drawing.Point(134, 218)
        Me.txtRez.Name = "txtRez"
        Me.txtRez.Size = New System.Drawing.Size(209, 27)
        Me.txtRez.TabIndex = 3
        '
        'btnSin
        '
        Me.btnSin.AccessibleRole = System.Windows.Forms.AccessibleRole.RadioButton
        Me.btnSin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnSin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSin.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSin.Location = New System.Drawing.Point(90, 120)
        Me.btnSin.Name = "btnSin"
        Me.btnSin.Size = New System.Drawing.Size(82, 61)
        Me.btnSin.TabIndex = 5
        Me.btnSin.Text = "sin"
        Me.btnSin.UseVisualStyleBackColor = True
        '
        'btnCos
        '
        Me.btnCos.AccessibleRole = System.Windows.Forms.AccessibleRole.RadioButton
        Me.btnCos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnCos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCos.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCos.Location = New System.Drawing.Point(189, 120)
        Me.btnCos.Name = "btnCos"
        Me.btnCos.Size = New System.Drawing.Size(82, 61)
        Me.btnCos.TabIndex = 6
        Me.btnCos.Text = "cos"
        Me.btnCos.UseVisualStyleBackColor = True
        '
        'btnTg
        '
        Me.btnTg.AccessibleRole = System.Windows.Forms.AccessibleRole.RadioButton
        Me.btnTg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnTg.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnTg.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnTg.Location = New System.Drawing.Point(289, 120)
        Me.btnTg.Name = "btnTg"
        Me.btnTg.Size = New System.Drawing.Size(82, 61)
        Me.btnTg.TabIndex = 7
        Me.btnTg.Text = "tg"
        Me.btnTg.UseVisualStyleBackColor = True
        '
        'btnCtg
        '
        Me.btnCtg.AccessibleRole = System.Windows.Forms.AccessibleRole.RadioButton
        Me.btnCtg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnCtg.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCtg.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCtg.Location = New System.Drawing.Point(392, 120)
        Me.btnCtg.Name = "btnCtg"
        Me.btnCtg.Size = New System.Drawing.Size(82, 61)
        Me.btnCtg.TabIndex = 8
        Me.btnCtg.Text = "ctg"
        Me.btnCtg.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Checked = True
        Me.CheckBox1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox1.Location = New System.Drawing.Point(53, 277)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(71, 24)
        Me.CheckBox1.TabIndex = 9
        Me.CheckBox1.Text = "Grade"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Location = New System.Drawing.Point(168, 277)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(57, 24)
        Me.CheckBox2.TabIndex = 10
        Me.CheckBox2.Text = "Rad"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'frmCalcTr
        '
        Me.AccessibleRole = System.Windows.Forms.AccessibleRole.RadioButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(538, 313)
        Me.Controls.Add(Me.CheckBox2)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.btnCtg)
        Me.Controls.Add(Me.btnTg)
        Me.Controls.Add(Me.btnCos)
        Me.Controls.Add(Me.btnSin)
        Me.Controls.Add(Me.txtRez)
        Me.Controls.Add(Me.txtU)
        Me.Controls.Add(Me.lblRez)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmCalcTr"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Calcule Trigonometrice"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lblRez As Label
    Friend WithEvents txtU As TextBox
    Friend WithEvents txtRez As TextBox
    Friend WithEvents btnSin As Button
    Friend WithEvents btnCos As Button
    Friend WithEvents btnTg As Button
    Friend WithEvents btnCtg As Button
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents CheckBox2 As CheckBox
End Class
