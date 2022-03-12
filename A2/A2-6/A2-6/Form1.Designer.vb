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
        Me.btn2D = New System.Windows.Forms.Button()
        Me.btn3D = New System.Windows.Forms.Button()
        Me.btnIesire = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btn2D
        '
        Me.btn2D.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btn2D.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn2D.Location = New System.Drawing.Point(31, 42)
        Me.btn2D.Name = "btn2D"
        Me.btn2D.Size = New System.Drawing.Size(212, 54)
        Me.btn2D.TabIndex = 0
        Me.btn2D.Text = "2D"
        Me.btn2D.UseVisualStyleBackColor = False
        '
        'btn3D
        '
        Me.btn3D.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn3D.Location = New System.Drawing.Point(342, 42)
        Me.btn3D.Name = "btn3D"
        Me.btn3D.Size = New System.Drawing.Size(212, 54)
        Me.btn3D.TabIndex = 1
        Me.btn3D.Text = "3D"
        Me.btn3D.UseVisualStyleBackColor = True
        '
        'btnIesire
        '
        Me.btnIesire.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnIesire.Location = New System.Drawing.Point(183, 148)
        Me.btnIesire.Name = "btnIesire"
        Me.btnIesire.Size = New System.Drawing.Size(212, 54)
        Me.btnIesire.TabIndex = 2
        Me.btnIesire.Text = "I&esire"
        Me.btnIesire.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(583, 230)
        Me.Controls.Add(Me.btnIesire)
        Me.Controls.Add(Me.btn3D)
        Me.Controls.Add(Me.btn2D)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Distante"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btn2D As Button
    Friend WithEvents btn3D As Button
    Friend WithEvents btnIesire As Button
End Class
