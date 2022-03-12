<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLuni
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
        Me.nudLuna = New System.Windows.Forms.NumericUpDown()
        Me.txtbRo = New System.Windows.Forms.TextBox()
        Me.txtbEng = New System.Windows.Forms.TextBox()
        Me.txtbES = New System.Windows.Forms.TextBox()
        Me.txtbNRZile = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.nudLuna, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(35, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Luna:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(144, 39)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Romana:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(297, 39)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Engleza:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(448, 39)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 20)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Spaniola:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(608, 39)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(58, 20)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Nr. zile:"
        '
        'nudLuna
        '
        Me.nudLuna.Location = New System.Drawing.Point(35, 76)
        Me.nudLuna.Maximum = New Decimal(New Integer() {12, 0, 0, 0})
        Me.nudLuna.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudLuna.Name = "nudLuna"
        Me.nudLuna.ReadOnly = True
        Me.nudLuna.Size = New System.Drawing.Size(50, 27)
        Me.nudLuna.TabIndex = 5
        Me.nudLuna.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'txtbRo
        '
        Me.txtbRo.Location = New System.Drawing.Point(144, 76)
        Me.txtbRo.Name = "txtbRo"
        Me.txtbRo.ReadOnly = True
        Me.txtbRo.Size = New System.Drawing.Size(125, 27)
        Me.txtbRo.TabIndex = 6
        '
        'txtbEng
        '
        Me.txtbEng.Location = New System.Drawing.Point(297, 76)
        Me.txtbEng.Name = "txtbEng"
        Me.txtbEng.ReadOnly = True
        Me.txtbEng.Size = New System.Drawing.Size(125, 27)
        Me.txtbEng.TabIndex = 7
        '
        'txtbES
        '
        Me.txtbES.Location = New System.Drawing.Point(448, 75)
        Me.txtbES.Name = "txtbES"
        Me.txtbES.ReadOnly = True
        Me.txtbES.Size = New System.Drawing.Size(125, 27)
        Me.txtbES.TabIndex = 8
        '
        'txtbNRZile
        '
        Me.txtbNRZile.Location = New System.Drawing.Point(608, 76)
        Me.txtbNRZile.Name = "txtbNRZile"
        Me.txtbNRZile.ReadOnly = True
        Me.txtbNRZile.Size = New System.Drawing.Size(58, 27)
        Me.txtbNRZile.TabIndex = 9
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(511, 140)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(132, 32)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "Iesire"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'frmLuni
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(730, 184)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtbNRZile)
        Me.Controls.Add(Me.txtbES)
        Me.Controls.Add(Me.txtbEng)
        Me.Controls.Add(Me.txtbRo)
        Me.Controls.Add(Me.nudLuna)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmLuni"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Lunile anului"
        CType(Me.nudLuna, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents nudLuna As NumericUpDown
    Friend WithEvents txtbRo As TextBox
    Friend WithEvents txtbEng As TextBox
    Friend WithEvents txtbES As TextBox
    Friend WithEvents txtbNRZile As TextBox
    Friend WithEvents Button1 As Button
End Class
