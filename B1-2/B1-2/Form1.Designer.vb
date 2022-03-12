<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSistem
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
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtbX1 = New System.Windows.Forms.TextBox()
        Me.txtbX2 = New System.Windows.Forms.TextBox()
        Me.txtbY1 = New System.Windows.Forms.TextBox()
        Me.txtbY2 = New System.Windows.Forms.TextBox()
        Me.txtbEC1 = New System.Windows.Forms.TextBox()
        Me.txtbEC2 = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtbYSolutie = New System.Windows.Forms.TextBox()
        Me.txtbXSolutie = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnCALC = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Lucida Sans Unicode", 10.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(37, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(105, 22)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Ecuatia 1:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Lucida Sans Unicode", 10.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(37, 106)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(105, 22)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Ecuatia 2:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(234, 50)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(36, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "X  +"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(234, 106)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(36, 20)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "X  +"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(363, 50)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(35, 20)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Y  ="
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(363, 106)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(35, 20)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Y  ="
        '
        'txtbX1
        '
        Me.txtbX1.Location = New System.Drawing.Point(147, 47)
        Me.txtbX1.Name = "txtbX1"
        Me.txtbX1.Size = New System.Drawing.Size(81, 27)
        Me.txtbX1.TabIndex = 6
        '
        'txtbX2
        '
        Me.txtbX2.Location = New System.Drawing.Point(147, 103)
        Me.txtbX2.Name = "txtbX2"
        Me.txtbX2.Size = New System.Drawing.Size(81, 27)
        Me.txtbX2.TabIndex = 7
        '
        'txtbY1
        '
        Me.txtbY1.Location = New System.Drawing.Point(276, 47)
        Me.txtbY1.Name = "txtbY1"
        Me.txtbY1.Size = New System.Drawing.Size(81, 27)
        Me.txtbY1.TabIndex = 8
        '
        'txtbY2
        '
        Me.txtbY2.Location = New System.Drawing.Point(276, 103)
        Me.txtbY2.Name = "txtbY2"
        Me.txtbY2.Size = New System.Drawing.Size(81, 27)
        Me.txtbY2.TabIndex = 9
        '
        'txtbEC1
        '
        Me.txtbEC1.Location = New System.Drawing.Point(404, 47)
        Me.txtbEC1.Name = "txtbEC1"
        Me.txtbEC1.Size = New System.Drawing.Size(81, 27)
        Me.txtbEC1.TabIndex = 10
        '
        'txtbEC2
        '
        Me.txtbEC2.Location = New System.Drawing.Point(404, 103)
        Me.txtbEC2.Name = "txtbEC2"
        Me.txtbEC2.Size = New System.Drawing.Size(81, 27)
        Me.txtbEC2.TabIndex = 11
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtbYSolutie)
        Me.GroupBox1.Controls.Add(Me.txtbXSolutie)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Location = New System.Drawing.Point(276, 176)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(201, 136)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Solutie"
        '
        'txtbYSolutie
        '
        Me.txtbYSolutie.Location = New System.Drawing.Point(32, 89)
        Me.txtbYSolutie.Name = "txtbYSolutie"
        Me.txtbYSolutie.ReadOnly = True
        Me.txtbYSolutie.Size = New System.Drawing.Size(134, 27)
        Me.txtbYSolutie.TabIndex = 3
        '
        'txtbXSolutie
        '
        Me.txtbXSolutie.Location = New System.Drawing.Point(33, 31)
        Me.txtbXSolutie.Name = "txtbXSolutie"
        Me.txtbXSolutie.ReadOnly = True
        Me.txtbXSolutie.Size = New System.Drawing.Size(134, 27)
        Me.txtbXSolutie.TabIndex = 2
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 92)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(20, 20)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "Y:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 34)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(21, 20)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "X:"
        '
        'btnCALC
        '
        Me.btnCALC.BackColor = System.Drawing.Color.BlanchedAlmond
        Me.btnCALC.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCALC.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCALC.Font = New System.Drawing.Font("Lucida Sans Unicode", 13.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point)
        Me.btnCALC.ForeColor = System.Drawing.Color.DarkOrange
        Me.btnCALC.Location = New System.Drawing.Point(37, 176)
        Me.btnCALC.Name = "btnCALC"
        Me.btnCALC.Size = New System.Drawing.Size(164, 136)
        Me.btnCALC.TabIndex = 13
        Me.btnCALC.Text = "Calculeaza Solutia"
        Me.btnCALC.UseVisualStyleBackColor = False
        '
        'frmSistem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(557, 369)
        Me.Controls.Add(Me.btnCALC)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtbEC2)
        Me.Controls.Add(Me.txtbEC1)
        Me.Controls.Add(Me.txtbY2)
        Me.Controls.Add(Me.txtbY1)
        Me.Controls.Add(Me.txtbX2)
        Me.Controls.Add(Me.txtbX1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmSistem"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " Sistem de 2 ecuatii cu 2 necunoscute"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtbX1 As TextBox
    Friend WithEvents txtbX2 As TextBox
    Friend WithEvents txtbY1 As TextBox
    Friend WithEvents txtbY2 As TextBox
    Friend WithEvents txtbEC1 As TextBox
    Friend WithEvents txtbEC2 As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtbYSolutie As TextBox
    Friend WithEvents txtbXSolutie As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents btnCALC As Button
End Class
