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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtbX3 = New System.Windows.Forms.TextBox()
        Me.txtbFX = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.checkbX3 = New System.Windows.Forms.CheckBox()
        Me.combobX3 = New System.Windows.Forms.ComboBox()
        Me.combobX2 = New System.Windows.Forms.ComboBox()
        Me.txtbX2 = New System.Windows.Forms.TextBox()
        Me.checkbX2 = New System.Windows.Forms.CheckBox()
        Me.combobX = New System.Windows.Forms.ComboBox()
        Me.txtbX = New System.Windows.Forms.TextBox()
        Me.checkbX = New System.Windows.Forms.CheckBox()
        Me.combobN = New System.Windows.Forms.ComboBox()
        Me.txtbN = New System.Windows.Forms.TextBox()
        Me.checkbN = New System.Windows.Forms.CheckBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtbSuma = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(31, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "f(x)="
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(31, 155)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(31, 25)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "f("
        '
        'txtbX3
        '
        Me.txtbX3.Location = New System.Drawing.Point(161, 44)
        Me.txtbX3.Name = "txtbX3"
        Me.txtbX3.Size = New System.Drawing.Size(88, 27)
        Me.txtbX3.TabIndex = 5
        '
        'txtbFX
        '
        Me.txtbFX.Location = New System.Drawing.Point(60, 157)
        Me.txtbFX.Name = "txtbFX"
        Me.txtbFX.Size = New System.Drawing.Size(43, 27)
        Me.txtbFX.TabIndex = 9
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label6.Location = New System.Drawing.Point(109, 155)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(23, 25)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = ")"
        '
        'checkbX3
        '
        Me.checkbX3.AutoSize = True
        Me.checkbX3.Location = New System.Drawing.Point(255, 46)
        Me.checkbX3.Name = "checkbX3"
        Me.checkbX3.Size = New System.Drawing.Size(56, 24)
        Me.checkbX3.TabIndex = 11
        Me.checkbX3.Text = "x^3"
        Me.checkbX3.UseVisualStyleBackColor = True
        '
        'combobX3
        '
        Me.combobX3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.combobX3.FormattingEnabled = True
        Me.combobX3.Items.AddRange(New Object() {"+" & Global.Microsoft.VisualBasic.ChrW(9), "-"})
        Me.combobX3.Location = New System.Drawing.Point(102, 44)
        Me.combobX3.Name = "combobX3"
        Me.combobX3.Size = New System.Drawing.Size(53, 28)
        Me.combobX3.TabIndex = 12
        '
        'combobX2
        '
        Me.combobX2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.combobX2.FormattingEnabled = True
        Me.combobX2.Items.AddRange(New Object() {"+" & Global.Microsoft.VisualBasic.ChrW(9), "-"})
        Me.combobX2.Location = New System.Drawing.Point(317, 46)
        Me.combobX2.Name = "combobX2"
        Me.combobX2.Size = New System.Drawing.Size(53, 28)
        Me.combobX2.TabIndex = 13
        '
        'txtbX2
        '
        Me.txtbX2.Location = New System.Drawing.Point(376, 47)
        Me.txtbX2.Name = "txtbX2"
        Me.txtbX2.Size = New System.Drawing.Size(88, 27)
        Me.txtbX2.TabIndex = 14
        '
        'checkbX2
        '
        Me.checkbX2.AutoSize = True
        Me.checkbX2.Location = New System.Drawing.Point(470, 50)
        Me.checkbX2.Name = "checkbX2"
        Me.checkbX2.Size = New System.Drawing.Size(56, 24)
        Me.checkbX2.TabIndex = 15
        Me.checkbX2.Text = "x^2"
        Me.checkbX2.UseVisualStyleBackColor = True
        '
        'combobX
        '
        Me.combobX.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.combobX.FormattingEnabled = True
        Me.combobX.Items.AddRange(New Object() {"+" & Global.Microsoft.VisualBasic.ChrW(9), "-"})
        Me.combobX.Location = New System.Drawing.Point(532, 47)
        Me.combobX.Name = "combobX"
        Me.combobX.Size = New System.Drawing.Size(53, 28)
        Me.combobX.TabIndex = 16
        '
        'txtbX
        '
        Me.txtbX.Location = New System.Drawing.Point(591, 47)
        Me.txtbX.Name = "txtbX"
        Me.txtbX.Size = New System.Drawing.Size(88, 27)
        Me.txtbX.TabIndex = 17
        '
        'checkbX
        '
        Me.checkbX.AutoSize = True
        Me.checkbX.Location = New System.Drawing.Point(685, 50)
        Me.checkbX.Name = "checkbX"
        Me.checkbX.Size = New System.Drawing.Size(38, 24)
        Me.checkbX.TabIndex = 18
        Me.checkbX.Text = "x"
        Me.checkbX.UseVisualStyleBackColor = True
        '
        'combobN
        '
        Me.combobN.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.combobN.Enabled = False
        Me.combobN.FormattingEnabled = True
        Me.combobN.Items.AddRange(New Object() {"+" & Global.Microsoft.VisualBasic.ChrW(9), "-"})
        Me.combobN.Location = New System.Drawing.Point(729, 48)
        Me.combobN.Name = "combobN"
        Me.combobN.Size = New System.Drawing.Size(53, 28)
        Me.combobN.TabIndex = 19
        '
        'txtbN
        '
        Me.txtbN.Enabled = False
        Me.txtbN.Location = New System.Drawing.Point(788, 48)
        Me.txtbN.Name = "txtbN"
        Me.txtbN.Size = New System.Drawing.Size(88, 27)
        Me.txtbN.TabIndex = 20
        '
        'checkbN
        '
        Me.checkbN.AutoSize = True
        Me.checkbN.Location = New System.Drawing.Point(882, 52)
        Me.checkbN.Name = "checkbN"
        Me.checkbN.Size = New System.Drawing.Size(18, 17)
        Me.checkbN.TabIndex = 21
        Me.checkbN.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(138, 155)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(48, 29)
        Me.Button1.TabIndex = 22
        Me.Button1.Text = "="
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtbSuma
        '
        Me.txtbSuma.Location = New System.Drawing.Point(208, 157)
        Me.txtbSuma.Name = "txtbSuma"
        Me.txtbSuma.Size = New System.Drawing.Size(103, 27)
        Me.txtbSuma.TabIndex = 23
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 214)
        Me.Controls.Add(Me.txtbSuma)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.checkbN)
        Me.Controls.Add(Me.txtbN)
        Me.Controls.Add(Me.combobN)
        Me.Controls.Add(Me.checkbX)
        Me.Controls.Add(Me.txtbX)
        Me.Controls.Add(Me.combobX)
        Me.Controls.Add(Me.checkbX2)
        Me.Controls.Add(Me.txtbX2)
        Me.Controls.Add(Me.combobX2)
        Me.Controls.Add(Me.combobX3)
        Me.Controls.Add(Me.checkbX3)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtbFX)
        Me.Controls.Add(Me.txtbX3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Calcul functie polinomala"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtbX3 As TextBox
    Friend WithEvents txtbFX As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents checkbX3 As CheckBox
    Friend WithEvents combobX3 As ComboBox
    Friend WithEvents combobX2 As ComboBox
    Friend WithEvents txtbX2 As TextBox
    Friend WithEvents checkbX2 As CheckBox
    Friend WithEvents combobX As ComboBox
    Friend WithEvents txtbX As TextBox
    Friend WithEvents checkbX As CheckBox
    Friend WithEvents combobN As ComboBox
    Friend WithEvents txtbN As TextBox
    Friend WithEvents checkbN As CheckBox
    Friend WithEvents Button1 As Button
    Friend WithEvents txtbSuma As TextBox
End Class
