<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOra
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
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblData = New System.Windows.Forms.Label()
        Me.lblOras = New System.Windows.Forms.Label()
        Me.combobOras = New System.Windows.Forms.ComboBox()
        Me.grbAfisare = New System.Windows.Forms.GroupBox()
        Me.chbFormatScurt = New System.Windows.Forms.CheckBox()
        Me.chbAfisareData = New System.Windows.Forms.CheckBox()
        Me.chbAfisareOras = New System.Windows.Forms.CheckBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ckbBold = New System.Windows.Forms.CheckBox()
        Me.rbAlbastru = New System.Windows.Forms.RadioButton()
        Me.rbVerde = New System.Windows.Forms.RadioButton()
        Me.rbRosu = New System.Windows.Forms.RadioButton()
        Me.rbNegru = New System.Windows.Forms.RadioButton()
        Me.lstbFont = New System.Windows.Forms.ListBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblOra = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.grbAfisare.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(24, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Oras:"
        '
        'lblData
        '
        Me.lblData.Font = New System.Drawing.Font("Verdana", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblData.ForeColor = System.Drawing.Color.Red
        Me.lblData.Location = New System.Drawing.Point(156, 509)
        Me.lblData.Name = "lblData"
        Me.lblData.Size = New System.Drawing.Size(390, 45)
        Me.lblData.TabIndex = 1
        Me.lblData.Text = "###"
        Me.lblData.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblOras
        '
        Me.lblOras.Font = New System.Drawing.Font("Verdana", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblOras.ForeColor = System.Drawing.Color.Red
        Me.lblOras.Location = New System.Drawing.Point(156, 355)
        Me.lblOras.Name = "lblOras"
        Me.lblOras.Size = New System.Drawing.Size(390, 41)
        Me.lblOras.TabIndex = 3
        Me.lblOras.Text = "###"
        Me.lblOras.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'combobOras
        '
        Me.combobOras.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.combobOras.FormattingEnabled = True
        Me.combobOras.Items.AddRange(New Object() {"Bucuresti (UTC+3)", "Budapesta (UTC+2)", "Londra (UTC+1)", "Moscova(UTC+3)", "New York (UTC-4)", "Tokyo (UTC+9)"})
        Me.combobOras.Location = New System.Drawing.Point(24, 60)
        Me.combobOras.Name = "combobOras"
        Me.combobOras.Size = New System.Drawing.Size(140, 28)
        Me.combobOras.TabIndex = 4
        '
        'grbAfisare
        '
        Me.grbAfisare.Controls.Add(Me.chbFormatScurt)
        Me.grbAfisare.Controls.Add(Me.chbAfisareData)
        Me.grbAfisare.Controls.Add(Me.chbAfisareOras)
        Me.grbAfisare.Location = New System.Drawing.Point(24, 117)
        Me.grbAfisare.Name = "grbAfisare"
        Me.grbAfisare.Size = New System.Drawing.Size(178, 127)
        Me.grbAfisare.TabIndex = 5
        Me.grbAfisare.TabStop = False
        Me.grbAfisare.Text = "Afisare"
        '
        'chbFormatScurt
        '
        Me.chbFormatScurt.AutoSize = True
        Me.chbFormatScurt.Location = New System.Drawing.Point(15, 86)
        Me.chbFormatScurt.Name = "chbFormatScurt"
        Me.chbFormatScurt.Size = New System.Drawing.Size(147, 24)
        Me.chbFormatScurt.TabIndex = 2
        Me.chbFormatScurt.Text = "Format data scurt"
        Me.chbFormatScurt.UseVisualStyleBackColor = True
        '
        'chbAfisareData
        '
        Me.chbAfisareData.AutoSize = True
        Me.chbAfisareData.Location = New System.Drawing.Point(15, 56)
        Me.chbAfisareData.Name = "chbAfisareData"
        Me.chbAfisareData.Size = New System.Drawing.Size(111, 24)
        Me.chbAfisareData.TabIndex = 1
        Me.chbAfisareData.Text = "Afisare data"
        Me.chbAfisareData.UseVisualStyleBackColor = True
        '
        'chbAfisareOras
        '
        Me.chbAfisareOras.AutoSize = True
        Me.chbAfisareOras.Location = New System.Drawing.Point(15, 26)
        Me.chbAfisareOras.Name = "chbAfisareOras"
        Me.chbAfisareOras.Size = New System.Drawing.Size(149, 24)
        Me.chbAfisareOras.TabIndex = 0
        Me.chbAfisareOras.Text = "Afisare oras (UTC)"
        Me.chbAfisareOras.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.ckbBold)
        Me.GroupBox2.Controls.Add(Me.rbAlbastru)
        Me.GroupBox2.Controls.Add(Me.rbVerde)
        Me.GroupBox2.Controls.Add(Me.rbRosu)
        Me.GroupBox2.Controls.Add(Me.rbNegru)
        Me.GroupBox2.Controls.Add(Me.lstbFont)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Location = New System.Drawing.Point(281, 60)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(284, 235)
        Me.GroupBox2.TabIndex = 6
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = " Formatare"
        '
        'ckbBold
        '
        Me.ckbBold.AutoSize = True
        Me.ckbBold.Location = New System.Drawing.Point(17, 193)
        Me.ckbBold.Name = "ckbBold"
        Me.ckbBold.Size = New System.Drawing.Size(62, 24)
        Me.ckbBold.TabIndex = 7
        Me.ckbBold.Text = "Bold"
        Me.ckbBold.UseVisualStyleBackColor = True
        '
        'rbAlbastru
        '
        Me.rbAlbastru.AutoSize = True
        Me.rbAlbastru.Location = New System.Drawing.Point(138, 192)
        Me.rbAlbastru.Name = "rbAlbastru"
        Me.rbAlbastru.Size = New System.Drawing.Size(85, 24)
        Me.rbAlbastru.TabIndex = 6
        Me.rbAlbastru.TabStop = True
        Me.rbAlbastru.Text = "Albastru"
        Me.rbAlbastru.UseVisualStyleBackColor = True
        '
        'rbVerde
        '
        Me.rbVerde.AutoSize = True
        Me.rbVerde.Location = New System.Drawing.Point(138, 147)
        Me.rbVerde.Name = "rbVerde"
        Me.rbVerde.Size = New System.Drawing.Size(68, 24)
        Me.rbVerde.TabIndex = 5
        Me.rbVerde.TabStop = True
        Me.rbVerde.Text = "Verde"
        Me.rbVerde.UseVisualStyleBackColor = True
        '
        'rbRosu
        '
        Me.rbRosu.AutoSize = True
        Me.rbRosu.Location = New System.Drawing.Point(138, 102)
        Me.rbRosu.Name = "rbRosu"
        Me.rbRosu.Size = New System.Drawing.Size(62, 24)
        Me.rbRosu.TabIndex = 4
        Me.rbRosu.TabStop = True
        Me.rbRosu.Text = "Rosu"
        Me.rbRosu.UseVisualStyleBackColor = True
        '
        'rbNegru
        '
        Me.rbNegru.AutoSize = True
        Me.rbNegru.Location = New System.Drawing.Point(138, 57)
        Me.rbNegru.Name = "rbNegru"
        Me.rbNegru.Size = New System.Drawing.Size(71, 24)
        Me.rbNegru.TabIndex = 3
        Me.rbNegru.TabStop = True
        Me.rbNegru.Text = "Negru"
        Me.rbNegru.UseVisualStyleBackColor = True
        '
        'lstbFont
        '
        Me.lstbFont.FormattingEnabled = True
        Me.lstbFont.ItemHeight = 20
        Me.lstbFont.Items.AddRange(New Object() {"14", "16", "18", "20", "22", "24"})
        Me.lstbFont.Location = New System.Drawing.Point(17, 57)
        Me.lstbFont.Name = "lstbFont"
        Me.lstbFont.Size = New System.Drawing.Size(44, 124)
        Me.lstbFont.TabIndex = 2
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(138, 23)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(63, 20)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Culoare:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(17, 36)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(63, 20)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Marime:"
        '
        'lblOra
        '
        Me.lblOra.Font = New System.Drawing.Font("Verdana", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblOra.ForeColor = System.Drawing.Color.Red
        Me.lblOra.Location = New System.Drawing.Point(156, 430)
        Me.lblOra.Name = "lblOra"
        Me.lblOra.Size = New System.Drawing.Size(390, 45)
        Me.lblOra.TabIndex = 7
        Me.lblOra.Text = "00:00:00"
        Me.lblOra.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'frmOra
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(799, 642)
        Me.Controls.Add(Me.lblOra)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.grbAfisare)
        Me.Controls.Add(Me.combobOras)
        Me.Controls.Add(Me.lblOras)
        Me.Controls.Add(Me.lblData)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmOra"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ora pe glob"
        Me.grbAfisare.ResumeLayout(False)
        Me.grbAfisare.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lblData As Label
    Friend WithEvents lblOras As Label
    Friend WithEvents combobOras As ComboBox
    Friend WithEvents grbAfisare As GroupBox
    Friend WithEvents chbFormatScurt As CheckBox
    Friend WithEvents chbAfisareData As CheckBox
    Friend WithEvents chbAfisareOras As CheckBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents rbAlbastru As RadioButton
    Friend WithEvents rbVerde As RadioButton
    Friend WithEvents rbRosu As RadioButton
    Friend WithEvents rbNegru As RadioButton
    Friend WithEvents lstbFont As ListBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents ckbBold As CheckBox
    Friend WithEvents lblOra As Label
    Friend WithEvents Timer1 As Timer
End Class
