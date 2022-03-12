<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOperatii
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
        Me.txtbA = New System.Windows.Forms.TextBox()
        Me.txtbB = New System.Windows.Forms.TextBox()
        Me.textbR = New System.Windows.Forms.TextBox()
        Me.combobOP = New System.Windows.Forms.ComboBox()
        Me.btnCalc = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtbA
        '
        Me.txtbA.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.txtbA.Location = New System.Drawing.Point(70, 77)
        Me.txtbA.Name = "txtbA"
        Me.txtbA.Size = New System.Drawing.Size(125, 32)
        Me.txtbA.TabIndex = 0
        '
        'txtbB
        '
        Me.txtbB.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.txtbB.Location = New System.Drawing.Point(264, 76)
        Me.txtbB.Name = "txtbB"
        Me.txtbB.Size = New System.Drawing.Size(125, 32)
        Me.txtbB.TabIndex = 1
        '
        'textbR
        '
        Me.textbR.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.textbR.Location = New System.Drawing.Point(483, 76)
        Me.textbR.Name = "textbR"
        Me.textbR.ReadOnly = True
        Me.textbR.Size = New System.Drawing.Size(125, 32)
        Me.textbR.TabIndex = 2
        '
        'combobOP
        '
        Me.combobOP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.combobOP.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.combobOP.FormattingEnabled = True
        Me.combobOP.Items.AddRange(New Object() {"+", "-", "*", "/"})
        Me.combobOP.Location = New System.Drawing.Point(201, 76)
        Me.combobOP.Name = "combobOP"
        Me.combobOP.Size = New System.Drawing.Size(57, 33)
        Me.combobOP.TabIndex = 3
        '
        'btnCalc
        '
        Me.btnCalc.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCalc.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCalc.Location = New System.Drawing.Point(395, 76)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(82, 33)
        Me.btnCalc.TabIndex = 4
        Me.btnCalc.Text = "="
        Me.btnCalc.UseVisualStyleBackColor = True
        '
        'frmOperatii
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(711, 162)
        Me.Controls.Add(Me.btnCalc)
        Me.Controls.Add(Me.combobOP)
        Me.Controls.Add(Me.textbR)
        Me.Controls.Add(Me.txtbB)
        Me.Controls.Add(Me.txtbA)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmOperatii"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Operatii matematice"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtbA As TextBox
    Friend WithEvents txtbB As TextBox
    Friend WithEvents textbR As TextBox
    Friend WithEvents combobOP As ComboBox
    Friend WithEvents btnCalc As Button
End Class
