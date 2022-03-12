<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMedie
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtbMate = New System.Windows.Forms.TextBox()
        Me.txtbProg = New System.Windows.Forms.TextBox()
        Me.txtbMec = New System.Windows.Forms.TextBox()
        Me.btnCalcMedie = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtbMedie = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtbMec)
        Me.GroupBox1.Controls.Add(Me.txtbProg)
        Me.GroupBox1.Controls.Add(Me.txtbMate)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 21)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(178, 219)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Note"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Matematica:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 109)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Programare:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 170)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Mecanica:"
        '
        'txtbMate
        '
        Me.txtbMate.Location = New System.Drawing.Point(103, 42)
        Me.txtbMate.Name = "txtbMate"
        Me.txtbMate.Size = New System.Drawing.Size(63, 27)
        Me.txtbMate.TabIndex = 3
        '
        'txtbProg
        '
        Me.txtbProg.Location = New System.Drawing.Point(103, 106)
        Me.txtbProg.Name = "txtbProg"
        Me.txtbProg.Size = New System.Drawing.Size(63, 27)
        Me.txtbProg.TabIndex = 4
        '
        'txtbMec
        '
        Me.txtbMec.Location = New System.Drawing.Point(103, 167)
        Me.txtbMec.Name = "txtbMec"
        Me.txtbMec.Size = New System.Drawing.Size(63, 27)
        Me.txtbMec.TabIndex = 5
        '
        'btnCalcMedie
        '
        Me.btnCalcMedie.Location = New System.Drawing.Point(240, 21)
        Me.btnCalcMedie.Name = "btnCalcMedie"
        Me.btnCalcMedie.Size = New System.Drawing.Size(180, 29)
        Me.btnCalcMedie.TabIndex = 1
        Me.btnCalcMedie.Text = "Calcul Medie"
        Me.btnCalcMedie.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(240, 70)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 20)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Medie:"
        '
        'txtbMedie
        '
        Me.txtbMedie.Location = New System.Drawing.Point(300, 63)
        Me.txtbMedie.Name = "txtbMedie"
        Me.txtbMedie.Size = New System.Drawing.Size(120, 27)
        Me.txtbMedie.TabIndex = 3
        '
        'frmMedie
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(474, 272)
        Me.Controls.Add(Me.txtbMedie)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnCalcMedie)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmMedie"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Medie Note"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtbMec As TextBox
    Friend WithEvents txtbProg As TextBox
    Friend WithEvents txtbMate As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnCalcMedie As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents txtbMedie As TextBox
End Class
