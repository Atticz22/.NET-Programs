<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSubiect
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
        Me.btnPlan = New System.Windows.Forms.Button()
        Me.btnNumere = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnPlan
        '
        Me.btnPlan.Location = New System.Drawing.Point(61, 56)
        Me.btnPlan.Name = "btnPlan"
        Me.btnPlan.Size = New System.Drawing.Size(224, 100)
        Me.btnPlan.TabIndex = 0
        Me.btnPlan.Text = "Modul plan inclinat"
        Me.btnPlan.UseVisualStyleBackColor = True
        '
        'btnNumere
        '
        Me.btnNumere.Location = New System.Drawing.Point(429, 56)
        Me.btnNumere.Name = "btnNumere"
        Me.btnNumere.Size = New System.Drawing.Size(224, 100)
        Me.btnNumere.TabIndex = 1
        Me.btnNumere.Text = "Modul numere pare/impare"
        Me.btnNumere.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(242, 200)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(224, 100)
        Me.btnClose.TabIndex = 2
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'frmSubiect
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(745, 338)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnNumere)
        Me.Controls.Add(Me.btnPlan)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmSubiect"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Subiectul S01"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnPlan As Button
    Friend WithEvents btnNumere As Button
    Friend WithEvents btnClose As Button
End Class
