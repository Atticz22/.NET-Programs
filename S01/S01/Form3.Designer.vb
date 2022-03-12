<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNumere
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
        Me.btnStergeLista = New System.Windows.Forms.Button()
        Me.btnSterge = New System.Windows.Forms.Button()
        Me.btnAdauga = New System.Windows.Forms.Button()
        Me.textbNumereLista = New System.Windows.Forms.TextBox()
        Me.listboxNumere = New System.Windows.Forms.ListBox()
        Me.listboxNrPare = New System.Windows.Forms.ListBox()
        Me.listboxNrImpare = New System.Windows.Forms.ListBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.radiobtnRoz = New System.Windows.Forms.RadioButton()
        Me.radiobtnAlb = New System.Windows.Forms.RadioButton()
        Me.radiobtnVerde = New System.Windows.Forms.RadioButton()
        Me.btnIesireNumere = New System.Windows.Forms.Button()
        Me.btnAnalizeazaNumere = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.checkbFisier = New System.Windows.Forms.CheckBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnStergeLista)
        Me.GroupBox1.Controls.Add(Me.btnSterge)
        Me.GroupBox1.Controls.Add(Me.btnAdauga)
        Me.GroupBox1.Controls.Add(Me.textbNumereLista)
        Me.GroupBox1.Location = New System.Drawing.Point(32, 37)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(209, 215)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Control Lista"
        '
        'btnStergeLista
        '
        Me.btnStergeLista.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnStergeLista.Location = New System.Drawing.Point(19, 157)
        Me.btnStergeLista.Name = "btnStergeLista"
        Me.btnStergeLista.Size = New System.Drawing.Size(164, 30)
        Me.btnStergeLista.TabIndex = 3
        Me.btnStergeLista.Text = "Sterge Lista"
        Me.btnStergeLista.UseVisualStyleBackColor = True
        '
        'btnSterge
        '
        Me.btnSterge.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSterge.Location = New System.Drawing.Point(104, 106)
        Me.btnSterge.Name = "btnSterge"
        Me.btnSterge.Size = New System.Drawing.Size(79, 35)
        Me.btnSterge.TabIndex = 2
        Me.btnSterge.Text = "-"
        Me.btnSterge.UseVisualStyleBackColor = True
        '
        'btnAdauga
        '
        Me.btnAdauga.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAdauga.Location = New System.Drawing.Point(19, 106)
        Me.btnAdauga.Name = "btnAdauga"
        Me.btnAdauga.Size = New System.Drawing.Size(79, 35)
        Me.btnAdauga.TabIndex = 1
        Me.btnAdauga.Text = "+"
        Me.btnAdauga.UseVisualStyleBackColor = True
        '
        'textbNumereLista
        '
        Me.textbNumereLista.Location = New System.Drawing.Point(19, 48)
        Me.textbNumereLista.Name = "textbNumereLista"
        Me.textbNumereLista.Size = New System.Drawing.Size(175, 27)
        Me.textbNumereLista.TabIndex = 0
        '
        'listboxNumere
        '
        Me.listboxNumere.FormattingEnabled = True
        Me.listboxNumere.ItemHeight = 20
        Me.listboxNumere.Location = New System.Drawing.Point(283, 55)
        Me.listboxNumere.Name = "listboxNumere"
        Me.listboxNumere.Size = New System.Drawing.Size(138, 264)
        Me.listboxNumere.TabIndex = 1
        '
        'listboxNrPare
        '
        Me.listboxNrPare.FormattingEnabled = True
        Me.listboxNrPare.ItemHeight = 20
        Me.listboxNrPare.Location = New System.Drawing.Point(462, 55)
        Me.listboxNrPare.Name = "listboxNrPare"
        Me.listboxNrPare.Size = New System.Drawing.Size(138, 264)
        Me.listboxNrPare.TabIndex = 2
        '
        'listboxNrImpare
        '
        Me.listboxNrImpare.FormattingEnabled = True
        Me.listboxNrImpare.ItemHeight = 20
        Me.listboxNrImpare.Location = New System.Drawing.Point(623, 55)
        Me.listboxNrImpare.Name = "listboxNrImpare"
        Me.listboxNrImpare.Size = New System.Drawing.Size(138, 264)
        Me.listboxNrImpare.TabIndex = 3
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnRefresh)
        Me.GroupBox2.Controls.Add(Me.radiobtnRoz)
        Me.GroupBox2.Controls.Add(Me.radiobtnAlb)
        Me.GroupBox2.Controls.Add(Me.radiobtnVerde)
        Me.GroupBox2.Location = New System.Drawing.Point(802, 57)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(175, 229)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Culoare Lista"
        '
        'btnRefresh
        '
        Me.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnRefresh.Location = New System.Drawing.Point(6, 160)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(163, 35)
        Me.btnRefresh.TabIndex = 3
        Me.btnRefresh.Text = "Refresh"
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'radiobtnRoz
        '
        Me.radiobtnRoz.AutoSize = True
        Me.radiobtnRoz.Location = New System.Drawing.Point(6, 104)
        Me.radiobtnRoz.Name = "radiobtnRoz"
        Me.radiobtnRoz.Size = New System.Drawing.Size(55, 24)
        Me.radiobtnRoz.TabIndex = 2
        Me.radiobtnRoz.TabStop = True
        Me.radiobtnRoz.Text = "Roz"
        Me.radiobtnRoz.UseVisualStyleBackColor = True
        '
        'radiobtnAlb
        '
        Me.radiobtnAlb.AutoSize = True
        Me.radiobtnAlb.Location = New System.Drawing.Point(6, 74)
        Me.radiobtnAlb.Name = "radiobtnAlb"
        Me.radiobtnAlb.Size = New System.Drawing.Size(53, 24)
        Me.radiobtnAlb.TabIndex = 1
        Me.radiobtnAlb.TabStop = True
        Me.radiobtnAlb.Text = "Alb"
        Me.radiobtnAlb.UseVisualStyleBackColor = True
        '
        'radiobtnVerde
        '
        Me.radiobtnVerde.AutoSize = True
        Me.radiobtnVerde.Location = New System.Drawing.Point(6, 44)
        Me.radiobtnVerde.Name = "radiobtnVerde"
        Me.radiobtnVerde.Size = New System.Drawing.Size(68, 24)
        Me.radiobtnVerde.TabIndex = 0
        Me.radiobtnVerde.TabStop = True
        Me.radiobtnVerde.Text = "Verde"
        Me.radiobtnVerde.UseVisualStyleBackColor = True
        '
        'btnIesireNumere
        '
        Me.btnIesireNumere.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnIesireNumere.Location = New System.Drawing.Point(808, 369)
        Me.btnIesireNumere.Name = "btnIesireNumere"
        Me.btnIesireNumere.Size = New System.Drawing.Size(163, 41)
        Me.btnIesireNumere.TabIndex = 5
        Me.btnIesireNumere.Text = "Iesire"
        Me.btnIesireNumere.UseVisualStyleBackColor = True
        '
        'btnAnalizeazaNumere
        '
        Me.btnAnalizeazaNumere.Cursor = System.Windows.Forms.Cursors.AppStarting
        Me.btnAnalizeazaNumere.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAnalizeazaNumere.Location = New System.Drawing.Point(283, 350)
        Me.btnAnalizeazaNumere.Name = "btnAnalizeazaNumere"
        Me.btnAnalizeazaNumere.Size = New System.Drawing.Size(478, 33)
        Me.btnAnalizeazaNumere.TabIndex = 6
        Me.btnAnalizeazaNumere.Text = "Analizeaza numere"
        Me.btnAnalizeazaNumere.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(283, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 20)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Numere:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(462, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 20)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Pare:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(623, 32)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 20)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Impare:"
        '
        'checkbFisier
        '
        Me.checkbFisier.AutoSize = True
        Me.checkbFisier.Location = New System.Drawing.Point(32, 305)
        Me.checkbFisier.Name = "checkbFisier"
        Me.checkbFisier.Size = New System.Drawing.Size(115, 24)
        Me.checkbFisier.TabIndex = 10
        Me.checkbFisier.Text = "Scrie in fisier"
        Me.checkbFisier.UseVisualStyleBackColor = True
        '
        'frmNumere
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1047, 494)
        Me.Controls.Add(Me.checkbFisier)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnAnalizeazaNumere)
        Me.Controls.Add(Me.btnIesireNumere)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.listboxNrImpare)
        Me.Controls.Add(Me.listboxNrPare)
        Me.Controls.Add(Me.listboxNumere)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmNumere"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Numere pare/impare"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnStergeLista As Button
    Friend WithEvents btnSterge As Button
    Friend WithEvents btnAdauga As Button
    Friend WithEvents textbNumereLista As TextBox
    Friend WithEvents listboxNumere As ListBox
    Friend WithEvents listboxNrPare As ListBox
    Friend WithEvents listboxNrImpare As ListBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnRefresh As Button
    Friend WithEvents radiobtnRoz As RadioButton
    Friend WithEvents radiobtnAlb As RadioButton
    Friend WithEvents radiobtnVerde As RadioButton
    Friend WithEvents btnIesireNumere As Button
    Friend WithEvents btnAnalizeazaNumere As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents checkbFisier As CheckBox
End Class
