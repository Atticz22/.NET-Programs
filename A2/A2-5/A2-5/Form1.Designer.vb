<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtbDepozit = New System.Windows.Forms.TextBox()
        Me.txtbSumaFinala = New System.Windows.Forms.TextBox()
        Me.btnCalcSuma = New System.Windows.Forms.Button()
        Me.btnValori = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnInfo = New System.Windows.Forms.Button()
        Me.nudDobanda = New System.Windows.Forms.NumericUpDown()
        Me.nudTermen = New System.Windows.Forms.NumericUpDown()
        CType(Me.nudDobanda, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudTermen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(32, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Depozit:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(32, 84)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Dobanda:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(32, 140)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Termen:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(19, 267)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(90, 20)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Suma finala:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(268, 35)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(25, 20)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "lei"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(268, 84)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(21, 20)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "%"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(268, 140)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(33, 20)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "luni"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(268, 267)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(25, 20)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "lei"
        '
        'txtbDepozit
        '
        Me.txtbDepozit.Location = New System.Drawing.Point(115, 32)
        Me.txtbDepozit.Name = "txtbDepozit"
        Me.txtbDepozit.Size = New System.Drawing.Size(147, 27)
        Me.txtbDepozit.TabIndex = 8
        '
        'txtbSumaFinala
        '
        Me.txtbSumaFinala.Location = New System.Drawing.Point(115, 260)
        Me.txtbSumaFinala.Name = "txtbSumaFinala"
        Me.txtbSumaFinala.Size = New System.Drawing.Size(147, 27)
        Me.txtbSumaFinala.TabIndex = 11
        '
        'btnCalcSuma
        '
        Me.btnCalcSuma.Location = New System.Drawing.Point(419, 32)
        Me.btnCalcSuma.Name = "btnCalcSuma"
        Me.btnCalcSuma.Size = New System.Drawing.Size(151, 35)
        Me.btnCalcSuma.TabIndex = 12
        Me.btnCalcSuma.Text = "&Calcul Suma"
        Me.btnCalcSuma.UseVisualStyleBackColor = True
        '
        'btnValori
        '
        Me.btnValori.Location = New System.Drawing.Point(419, 81)
        Me.btnValori.Name = "btnValori"
        Me.btnValori.Size = New System.Drawing.Size(151, 35)
        Me.btnValori.TabIndex = 13
        Me.btnValori.Text = "&Valori Implicite"
        Me.btnValori.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(533, 287)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(151, 35)
        Me.btnExit.TabIndex = 14
        Me.btnExit.Text = "I&esire"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnInfo
        '
        Me.btnInfo.Location = New System.Drawing.Point(365, 287)
        Me.btnInfo.Name = "btnInfo"
        Me.btnInfo.Size = New System.Drawing.Size(151, 35)
        Me.btnInfo.TabIndex = 15
        Me.btnInfo.Text = "&Info"
        Me.btnInfo.UseVisualStyleBackColor = True
        '
        'nudDobanda
        '
        Me.nudDobanda.DecimalPlaces = 1
        Me.nudDobanda.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.nudDobanda.Location = New System.Drawing.Point(115, 81)
        Me.nudDobanda.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.nudDobanda.Minimum = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.nudDobanda.Name = "nudDobanda"
        Me.nudDobanda.Size = New System.Drawing.Size(147, 27)
        Me.nudDobanda.TabIndex = 16
        Me.nudDobanda.Value = New Decimal(New Integer() {2, 0, 0, 0})
        '
        'nudTermen
        '
        Me.nudTermen.Increment = New Decimal(New Integer() {6, 0, 0, 0})
        Me.nudTermen.Location = New System.Drawing.Point(115, 133)
        Me.nudTermen.Maximum = New Decimal(New Integer() {48, 0, 0, 0})
        Me.nudTermen.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudTermen.Name = "nudTermen"
        Me.nudTermen.Size = New System.Drawing.Size(147, 27)
        Me.nudTermen.TabIndex = 17
        Me.nudTermen.Value = New Decimal(New Integer() {6, 0, 0, 0})
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(745, 348)
        Me.Controls.Add(Me.nudTermen)
        Me.Controls.Add(Me.nudDobanda)
        Me.Controls.Add(Me.btnInfo)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnValori)
        Me.Controls.Add(Me.btnCalcSuma)
        Me.Controls.Add(Me.txtbSumaFinala)
        Me.Controls.Add(Me.txtbDepozit)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Calculator Dobanda"
        CType(Me.nudDobanda, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudTermen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtbDepozit As TextBox
    Friend WithEvents txtbSumaFinala As TextBox
    Friend WithEvents btnCalcSuma As Button
    Friend WithEvents btnValori As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents btnInfo As Button
    Friend WithEvents nudDobanda As NumericUpDown
    Friend WithEvents nudTermen As NumericUpDown
End Class
