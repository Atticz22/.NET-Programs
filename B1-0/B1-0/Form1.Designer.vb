<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCalcVarsta
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
        Me.dtpDATANASTERII = New System.Windows.Forms.DateTimePicker()
        Me.txtbPRENUME = New System.Windows.Forms.TextBox()
        Me.txtbNUME = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnINFO = New System.Windows.Forms.Button()
        Me.txtbINFO = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dtpDATANASTERII)
        Me.GroupBox1.Controls.Add(Me.txtbPRENUME)
        Me.GroupBox1.Controls.Add(Me.txtbNUME)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(38, 39)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(633, 264)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Informatii personale"
        '
        'dtpDATANASTERII
        '
        Me.dtpDATANASTERII.Font = New System.Drawing.Font("Sitka Text", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.dtpDATANASTERII.Location = New System.Drawing.Point(148, 161)
        Me.dtpDATANASTERII.Name = "dtpDATANASTERII"
        Me.dtpDATANASTERII.Size = New System.Drawing.Size(273, 33)
        Me.dtpDATANASTERII.TabIndex = 5
        '
        'txtbPRENUME
        '
        Me.txtbPRENUME.Font = New System.Drawing.Font("Sitka Text", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtbPRENUME.Location = New System.Drawing.Point(148, 102)
        Me.txtbPRENUME.Name = "txtbPRENUME"
        Me.txtbPRENUME.Size = New System.Drawing.Size(273, 33)
        Me.txtbPRENUME.TabIndex = 4
        Me.txtbPRENUME.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtbNUME
        '
        Me.txtbNUME.Font = New System.Drawing.Font("Sitka Text", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtbNUME.Location = New System.Drawing.Point(148, 49)
        Me.txtbNUME.Name = "txtbNUME"
        Me.txtbNUME.Size = New System.Drawing.Size(273, 33)
        Me.txtbNUME.TabIndex = 3
        Me.txtbNUME.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(33, 166)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(96, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Data nasterii:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(33, 109)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Prenume:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(33, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nume:"
        '
        'btnINFO
        '
        Me.btnINFO.Location = New System.Drawing.Point(38, 345)
        Me.btnINFO.Name = "btnINFO"
        Me.btnINFO.Size = New System.Drawing.Size(258, 36)
        Me.btnINFO.TabIndex = 1
        Me.btnINFO.Text = "Extragere informatii"
        Me.btnINFO.UseVisualStyleBackColor = True
        '
        'txtbINFO
        '
        Me.txtbINFO.Font = New System.Drawing.Font("Sitka Text", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtbINFO.ForeColor = System.Drawing.Color.Firebrick
        Me.txtbINFO.Location = New System.Drawing.Point(337, 345)
        Me.txtbINFO.Name = "txtbINFO"
        Me.txtbINFO.Size = New System.Drawing.Size(305, 33)
        Me.txtbINFO.TabIndex = 2
        Me.txtbINFO.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'frmCalcVarsta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(712, 414)
        Me.Controls.Add(Me.txtbINFO)
        Me.Controls.Add(Me.btnINFO)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmCalcVarsta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Calculator Varsta"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents dtpDATANASTERII As DateTimePicker
    Friend WithEvents txtbPRENUME As TextBox
    Friend WithEvents txtbNUME As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnINFO As Button
    Friend WithEvents txtbINFO As TextBox
End Class
