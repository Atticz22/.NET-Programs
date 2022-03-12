<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMinMax
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
        Me.btnStergeTot = New System.Windows.Forms.Button()
        Me.btnSterge = New System.Windows.Forms.Button()
        Me.btnAdauga = New System.Windows.Forms.Button()
        Me.txtbNumere = New System.Windows.Forms.TextBox()
        Me.listbNumere = New System.Windows.Forms.ListBox()
        Me.btnMaxMin = New System.Windows.Forms.Button()
        Me.txtbMaxim = New System.Windows.Forms.TextBox()
        Me.txtbMinim = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnStergeTot)
        Me.GroupBox1.Controls.Add(Me.btnSterge)
        Me.GroupBox1.Controls.Add(Me.btnAdauga)
        Me.GroupBox1.Controls.Add(Me.txtbNumere)
        Me.GroupBox1.Location = New System.Drawing.Point(45, 56)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(168, 210)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Control Lista"
        '
        'btnStergeTot
        '
        Me.btnStergeTot.Location = New System.Drawing.Point(6, 155)
        Me.btnStergeTot.Name = "btnStergeTot"
        Me.btnStergeTot.Size = New System.Drawing.Size(156, 34)
        Me.btnStergeTot.TabIndex = 3
        Me.btnStergeTot.Text = "Sterge Lista"
        Me.btnStergeTot.UseVisualStyleBackColor = True
        '
        'btnSterge
        '
        Me.btnSterge.Location = New System.Drawing.Point(94, 97)
        Me.btnSterge.Name = "btnSterge"
        Me.btnSterge.Size = New System.Drawing.Size(68, 34)
        Me.btnSterge.TabIndex = 2
        Me.btnSterge.Text = "-"
        Me.btnSterge.UseVisualStyleBackColor = True
        '
        'btnAdauga
        '
        Me.btnAdauga.Location = New System.Drawing.Point(6, 97)
        Me.btnAdauga.Name = "btnAdauga"
        Me.btnAdauga.Size = New System.Drawing.Size(68, 34)
        Me.btnAdauga.TabIndex = 1
        Me.btnAdauga.Text = "+"
        Me.btnAdauga.UseVisualStyleBackColor = True
        '
        'txtbNumere
        '
        Me.txtbNumere.Location = New System.Drawing.Point(6, 41)
        Me.txtbNumere.Name = "txtbNumere"
        Me.txtbNumere.Size = New System.Drawing.Size(156, 27)
        Me.txtbNumere.TabIndex = 0
        '
        'listbNumere
        '
        Me.listbNumere.FormattingEnabled = True
        Me.listbNumere.ItemHeight = 20
        Me.listbNumere.Location = New System.Drawing.Point(277, 56)
        Me.listbNumere.Name = "listbNumere"
        Me.listbNumere.Size = New System.Drawing.Size(152, 204)
        Me.listbNumere.TabIndex = 1
        '
        'btnMaxMin
        '
        Me.btnMaxMin.Location = New System.Drawing.Point(497, 56)
        Me.btnMaxMin.Name = "btnMaxMin"
        Me.btnMaxMin.Size = New System.Drawing.Size(203, 36)
        Me.btnMaxMin.TabIndex = 2
        Me.btnMaxMin.Text = "Max/Min"
        Me.btnMaxMin.UseVisualStyleBackColor = True
        '
        'txtbMaxim
        '
        Me.txtbMaxim.Location = New System.Drawing.Point(497, 233)
        Me.txtbMaxim.Name = "txtbMaxim"
        Me.txtbMaxim.Size = New System.Drawing.Size(203, 27)
        Me.txtbMaxim.TabIndex = 3
        '
        'txtbMinim
        '
        Me.txtbMinim.Location = New System.Drawing.Point(497, 160)
        Me.txtbMinim.Name = "txtbMinim"
        Me.txtbMinim.Size = New System.Drawing.Size(203, 27)
        Me.txtbMinim.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(497, 137)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 20)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Minim:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(497, 210)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 20)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Maxim:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(277, 33)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 20)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Numere:"
        '
        'frmMinMax
        '
        Me.AcceptButton = Me.btnAdauga
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(758, 311)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtbMinim)
        Me.Controls.Add(Me.txtbMaxim)
        Me.Controls.Add(Me.btnMaxMin)
        Me.Controls.Add(Me.listbNumere)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmMinMax"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Maxim/Minim"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnStergeTot As Button
    Friend WithEvents btnSterge As Button
    Friend WithEvents btnAdauga As Button
    Friend WithEvents txtbNumere As TextBox
    Friend WithEvents listbNumere As ListBox
    Friend WithEvents btnMaxMin As Button
    Friend WithEvents txtbMaxim As TextBox
    Friend WithEvents txtbMinim As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
End Class
