<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm2D
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
        Me.gbPct1 = New System.Windows.Forms.GroupBox()
        Me.txtbY1 = New System.Windows.Forms.TextBox()
        Me.txtbX1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.gbPunct2 = New System.Windows.Forms.GroupBox()
        Me.txtbY2 = New System.Windows.Forms.TextBox()
        Me.txtbX2 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnCalcDis = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtbDistanta = New System.Windows.Forms.TextBox()
        Me.gbPct1.SuspendLayout()
        Me.gbPunct2.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbPct1
        '
        Me.gbPct1.Controls.Add(Me.txtbY1)
        Me.gbPct1.Controls.Add(Me.txtbX1)
        Me.gbPct1.Controls.Add(Me.Label2)
        Me.gbPct1.Controls.Add(Me.Label1)
        Me.gbPct1.Location = New System.Drawing.Point(53, 43)
        Me.gbPct1.Name = "gbPct1"
        Me.gbPct1.Size = New System.Drawing.Size(524, 72)
        Me.gbPct1.TabIndex = 0
        Me.gbPct1.TabStop = False
        Me.gbPct1.Text = "Punct 1"
        '
        'txtbY1
        '
        Me.txtbY1.Location = New System.Drawing.Point(330, 30)
        Me.txtbY1.Name = "txtbY1"
        Me.txtbY1.Size = New System.Drawing.Size(135, 27)
        Me.txtbY1.TabIndex = 3
        '
        'txtbX1
        '
        Me.txtbX1.Location = New System.Drawing.Point(66, 30)
        Me.txtbX1.Name = "txtbX1"
        Me.txtbX1.Size = New System.Drawing.Size(135, 27)
        Me.txtbX1.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(285, 33)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(28, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Y1:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(29, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "X1:"
        '
        'gbPunct2
        '
        Me.gbPunct2.Controls.Add(Me.txtbY2)
        Me.gbPunct2.Controls.Add(Me.txtbX2)
        Me.gbPunct2.Controls.Add(Me.Label3)
        Me.gbPunct2.Controls.Add(Me.Label4)
        Me.gbPunct2.Location = New System.Drawing.Point(53, 133)
        Me.gbPunct2.Name = "gbPunct2"
        Me.gbPunct2.Size = New System.Drawing.Size(524, 72)
        Me.gbPunct2.TabIndex = 4
        Me.gbPunct2.TabStop = False
        Me.gbPunct2.Text = "Punct 2"
        '
        'txtbY2
        '
        Me.txtbY2.Location = New System.Drawing.Point(330, 30)
        Me.txtbY2.Name = "txtbY2"
        Me.txtbY2.Size = New System.Drawing.Size(135, 27)
        Me.txtbY2.TabIndex = 3
        '
        'txtbX2
        '
        Me.txtbX2.Location = New System.Drawing.Point(66, 30)
        Me.txtbX2.Name = "txtbX2"
        Me.txtbX2.Size = New System.Drawing.Size(135, 27)
        Me.txtbX2.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(285, 33)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(28, 20)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Y2:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(22, 33)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(29, 20)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "X2:"
        '
        'btnCalcDis
        '
        Me.btnCalcDis.Location = New System.Drawing.Point(53, 231)
        Me.btnCalcDis.Name = "btnCalcDis"
        Me.btnCalcDis.Size = New System.Drawing.Size(201, 36)
        Me.btnCalcDis.TabIndex = 5
        Me.btnCalcDis.Text = "&Calcul distanta"
        Me.btnCalcDis.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(419, 231)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(136, 36)
        Me.btnReset.TabIndex = 6
        Me.btnReset.Text = "&Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(419, 300)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(136, 36)
        Me.btnExit.TabIndex = 7
        Me.btnExit.Text = "I&esire"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(53, 308)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(23, 20)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "D:"
        '
        'txtbDistanta
        '
        Me.txtbDistanta.Location = New System.Drawing.Point(82, 305)
        Me.txtbDistanta.Name = "txtbDistanta"
        Me.txtbDistanta.Size = New System.Drawing.Size(172, 27)
        Me.txtbDistanta.TabIndex = 9
        '
        'frm2D
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(636, 368)
        Me.Controls.Add(Me.txtbDistanta)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnCalcDis)
        Me.Controls.Add(Me.gbPunct2)
        Me.Controls.Add(Me.gbPct1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frm2D"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frm2D"
        Me.gbPct1.ResumeLayout(False)
        Me.gbPct1.PerformLayout()
        Me.gbPunct2.ResumeLayout(False)
        Me.gbPunct2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents gbPct1 As GroupBox
    Friend WithEvents txtbY1 As TextBox
    Friend WithEvents txtbX1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents gbPunct2 As GroupBox
    Friend WithEvents txtbY2 As TextBox
    Friend WithEvents txtbX2 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btnCalcDis As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents txtbDistanta As TextBox
End Class
