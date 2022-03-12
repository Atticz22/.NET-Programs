<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCalcGeo
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
        Me.btnDrept = New System.Windows.Forms.Button()
        Me.btnCerc = New System.Windows.Forms.Button()
        Me.btnIesire = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnDrept
        '
        Me.btnDrept.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDrept.Location = New System.Drawing.Point(53, 34)
        Me.btnDrept.Name = "btnDrept"
        Me.btnDrept.Size = New System.Drawing.Size(166, 47)
        Me.btnDrept.TabIndex = 0
        Me.btnDrept.Text = "&Dreptunghi"
        Me.btnDrept.UseVisualStyleBackColor = True
        '
        'btnCerc
        '
        Me.btnCerc.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCerc.Location = New System.Drawing.Point(352, 34)
        Me.btnCerc.Name = "btnCerc"
        Me.btnCerc.Size = New System.Drawing.Size(166, 47)
        Me.btnCerc.TabIndex = 1
        Me.btnCerc.Text = "&Cerc"
        Me.btnCerc.UseVisualStyleBackColor = True
        '
        'btnIesire
        '
        Me.btnIesire.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnIesire.Location = New System.Drawing.Point(205, 154)
        Me.btnIesire.Name = "btnIesire"
        Me.btnIesire.Size = New System.Drawing.Size(166, 47)
        Me.btnIesire.TabIndex = 2
        Me.btnIesire.Text = "I&esire"
        Me.btnIesire.UseVisualStyleBackColor = True
        '
        'frmCalcGeo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(581, 235)
        Me.Controls.Add(Me.btnIesire)
        Me.Controls.Add(Me.btnCerc)
        Me.Controls.Add(Me.btnDrept)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmCalcGeo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Calcule Geometrice"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnDrept As Button
    Friend WithEvents btnCerc As Button
    Friend WithEvents btnIesire As Button
End Class
