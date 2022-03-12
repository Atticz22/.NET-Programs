<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.NumericUpDown2 = New System.Windows.Forms.NumericUpDown()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.NumericUpDown3 = New System.Windows.Forms.NumericUpDown()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.NumericUpDown2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.NumericUpDown3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.NumericUpDown2)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.NumericUpDown1)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(25, 35)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(345, 140)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Table size"
        '
        'NumericUpDown2
        '
        Me.NumericUpDown2.Location = New System.Drawing.Point(166, 93)
        Me.NumericUpDown2.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumericUpDown2.Name = "NumericUpDown2"
        Me.NumericUpDown2.Size = New System.Drawing.Size(95, 27)
        Me.NumericUpDown2.TabIndex = 3
        Me.NumericUpDown2.Value = New Decimal(New Integer() {2, 0, 0, 0})
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(20, 97)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Number of &rows" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Location = New System.Drawing.Point(166, 34)
        Me.NumericUpDown1.Maximum = New Decimal(New Integer() {63, 0, 0, 0})
        Me.NumericUpDown1.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(95, 27)
        Me.NumericUpDown1.TabIndex = 1
        Me.NumericUpDown1.Value = New Decimal(New Integer() {5, 0, 0, 0})
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ImageKey = "(none)"
        Me.Label1.Location = New System.Drawing.Point(20, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(124, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Number of &columns"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.RadioButton1)
        Me.GroupBox2.Controls.Add(Me.CheckBox1)
        Me.GroupBox2.Controls.Add(Me.RadioButton3)
        Me.GroupBox2.Controls.Add(Me.RadioButton2)
        Me.GroupBox2.Controls.Add(Me.NumericUpDown3)
        Me.GroupBox2.Location = New System.Drawing.Point(25, 205)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(345, 252)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "AutoFit behavior"
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Checked = True
        Me.RadioButton1.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.RadioButton1.Location = New System.Drawing.Point(32, 50)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(143, 21)
        Me.RadioButton1.TabIndex = 5
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Fixed column &width:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.CheckBox1.Location = New System.Drawing.Point(20, 184)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(251, 21)
        Me.CheckBox1.TabIndex = 4
        Me.CheckBox1.Text = "Remember dimen&sions for new tables"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.RadioButton3.Location = New System.Drawing.Point(32, 130)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(133, 21)
        Me.RadioButton3.TabIndex = 3
        Me.RadioButton3.TabStop = True
        Me.RadioButton3.Text = "Auto&Fit to window"
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.RadioButton2.Location = New System.Drawing.Point(32, 89)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(138, 21)
        Me.RadioButton2.TabIndex = 2
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "Auto&Fit to contents"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'NumericUpDown3
        '
        Me.NumericUpDown3.DecimalPlaces = 1
        Me.NumericUpDown3.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.NumericUpDown3.Location = New System.Drawing.Point(211, 50)
        Me.NumericUpDown3.Name = "NumericUpDown3"
        Me.NumericUpDown3.Size = New System.Drawing.Size(116, 27)
        Me.NumericUpDown3.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(102, 481)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(124, 36)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "OK"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(246, 481)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(124, 36)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Cancel"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(408, 529)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.HelpButton = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Insert Table"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.NumericUpDown2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.NumericUpDown3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents NumericUpDown1 As NumericUpDown
    Friend WithEvents Label1 As Label
    Friend WithEvents NumericUpDown2 As NumericUpDown
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents NumericUpDown3 As NumericUpDown
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
