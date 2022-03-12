<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFactor
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
        Me.numericN = New System.Windows.Forms.NumericUpDown()
        Me.btnCalcFor = New System.Windows.Forms.Button()
        Me.btnCalcDo = New System.Windows.Forms.Button()
        Me.txtbFor = New System.Windows.Forms.TextBox()
        Me.txtbDo = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.numericN, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(46, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(20, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "n:"
        '
        'numericN
        '
        Me.numericN.Location = New System.Drawing.Point(72, 35)
        Me.numericN.Maximum = New Decimal(New Integer() {20, 0, 0, 0})
        Me.numericN.Name = "numericN"
        Me.numericN.Size = New System.Drawing.Size(57, 27)
        Me.numericN.TabIndex = 1
        Me.numericN.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'btnCalcFor
        '
        Me.btnCalcFor.Location = New System.Drawing.Point(46, 137)
        Me.btnCalcFor.Name = "btnCalcFor"
        Me.btnCalcFor.Size = New System.Drawing.Size(228, 29)
        Me.btnCalcFor.TabIndex = 2
        Me.btnCalcFor.Text = "Calcul cu For"
        Me.btnCalcFor.UseVisualStyleBackColor = True
        '
        'btnCalcDo
        '
        Me.btnCalcDo.Location = New System.Drawing.Point(304, 137)
        Me.btnCalcDo.Name = "btnCalcDo"
        Me.btnCalcDo.Size = New System.Drawing.Size(228, 29)
        Me.btnCalcDo.TabIndex = 3
        Me.btnCalcDo.Text = "Calcul cu Do"
        Me.btnCalcDo.UseVisualStyleBackColor = True
        '
        'txtbFor
        '
        Me.txtbFor.Location = New System.Drawing.Point(46, 224)
        Me.txtbFor.Name = "txtbFor"
        Me.txtbFor.ReadOnly = True
        Me.txtbFor.Size = New System.Drawing.Size(228, 27)
        Me.txtbFor.TabIndex = 4
        '
        'txtbDo
        '
        Me.txtbDo.Location = New System.Drawing.Point(304, 224)
        Me.txtbDo.Name = "txtbDo"
        Me.txtbDo.ReadOnly = True
        Me.txtbDo.Size = New System.Drawing.Size(228, 27)
        Me.txtbDo.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(46, 201)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 20)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Rezultat For:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(304, 201)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 20)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Rezultat Do:"
        '
        'frmFactor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(663, 279)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtbDo)
        Me.Controls.Add(Me.txtbFor)
        Me.Controls.Add(Me.btnCalcDo)
        Me.Controls.Add(Me.btnCalcFor)
        Me.Controls.Add(Me.numericN)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmFactor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Factorial"
        CType(Me.numericN, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents numericN As NumericUpDown
    Friend WithEvents btnCalcFor As Button
    Friend WithEvents btnCalcDo As Button
    Friend WithEvents txtbFor As TextBox
    Friend WithEvents txtbDo As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
End Class
