<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAnsamblare
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.listbSub = New System.Windows.Forms.ListBox()
        Me.listbPre = New System.Windows.Forms.ListBox()
        Me.listbComp = New System.Windows.Forms.ListBox()
        Me.groupbTip = New System.Windows.Forms.GroupBox()
        Me.rb3 = New System.Windows.Forms.RadioButton()
        Me.rb2 = New System.Windows.Forms.RadioButton()
        Me.rb1 = New System.Windows.Forms.RadioButton()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnSterge = New System.Windows.Forms.Button()
        Me.btnStergeTot = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.listbPropozitii = New System.Windows.Forms.ListBox()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.groupbTip.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(37, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Subiect:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(173, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Predicat:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(319, 42)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(98, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Complement:"
        '
        'listbSub
        '
        Me.listbSub.FormattingEnabled = True
        Me.listbSub.ItemHeight = 20
        Me.listbSub.Items.AddRange(New Object() {"Ana", "Studentul", "Profesorul", "Cainele", "Inginerul", "El", "Soferul"})
        Me.listbSub.Location = New System.Drawing.Point(37, 65)
        Me.listbSub.Name = "listbSub"
        Me.listbSub.Size = New System.Drawing.Size(93, 204)
        Me.listbSub.TabIndex = 3
        '
        'listbPre
        '
        Me.listbPre.FormattingEnabled = True
        Me.listbPre.ItemHeight = 20
        Me.listbPre.Items.AddRange(New Object() {"merge", "invata", "alearga", "doarme", "sare"})
        Me.listbPre.Location = New System.Drawing.Point(173, 65)
        Me.listbPre.Name = "listbPre"
        Me.listbPre.Size = New System.Drawing.Size(93, 204)
        Me.listbPre.TabIndex = 4
        '
        'listbComp
        '
        Me.listbComp.FormattingEnabled = True
        Me.listbComp.ItemHeight = 20
        Me.listbComp.Items.AddRange(New Object() {"bine", "tare", "incet", "usor", "cateodata", "mereu"})
        Me.listbComp.Location = New System.Drawing.Point(307, 65)
        Me.listbComp.Name = "listbComp"
        Me.listbComp.Size = New System.Drawing.Size(93, 204)
        Me.listbComp.TabIndex = 5
        '
        'groupbTip
        '
        Me.groupbTip.Controls.Add(Me.rb3)
        Me.groupbTip.Controls.Add(Me.rb2)
        Me.groupbTip.Controls.Add(Me.rb1)
        Me.groupbTip.Location = New System.Drawing.Point(31, 310)
        Me.groupbTip.Name = "groupbTip"
        Me.groupbTip.Size = New System.Drawing.Size(413, 86)
        Me.groupbTip.TabIndex = 6
        Me.groupbTip.TabStop = False
        Me.groupbTip.Text = "Tip:"
        '
        'rb3
        '
        Me.rb3.AutoSize = True
        Me.rb3.Location = New System.Drawing.Point(276, 37)
        Me.rb3.Name = "rb3"
        Me.rb3.Size = New System.Drawing.Size(109, 24)
        Me.rb3.TabIndex = 2
        Me.rb3.TabStop = True
        Me.rb3.Text = "Exclamativa"
        Me.rb3.UseVisualStyleBackColor = True
        '
        'rb2
        '
        Me.rb2.AutoSize = True
        Me.rb2.Location = New System.Drawing.Point(142, 37)
        Me.rb2.Name = "rb2"
        Me.rb2.Size = New System.Drawing.Size(110, 24)
        Me.rb2.TabIndex = 1
        Me.rb2.TabStop = True
        Me.rb2.Text = "Interogativa"
        Me.rb2.UseVisualStyleBackColor = True
        '
        'rb1
        '
        Me.rb1.AutoSize = True
        Me.rb1.Location = New System.Drawing.Point(6, 37)
        Me.rb1.Name = "rb1"
        Me.rb1.Size = New System.Drawing.Size(99, 24)
        Me.rb1.TabIndex = 0
        Me.rb1.TabStop = True
        Me.rb1.Text = "Afirmativa"
        Me.rb1.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(31, 411)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(94, 29)
        Me.btnAdd.TabIndex = 7
        Me.btnAdd.Text = "Adauga"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnSterge
        '
        Me.btnSterge.Location = New System.Drawing.Point(240, 411)
        Me.btnSterge.Name = "btnSterge"
        Me.btnSterge.Size = New System.Drawing.Size(94, 29)
        Me.btnSterge.TabIndex = 8
        Me.btnSterge.Text = "Sterge una"
        Me.btnSterge.UseVisualStyleBackColor = True
        '
        'btnStergeTot
        '
        Me.btnStergeTot.Location = New System.Drawing.Point(350, 411)
        Me.btnStergeTot.Name = "btnStergeTot"
        Me.btnStergeTot.Size = New System.Drawing.Size(94, 29)
        Me.btnStergeTot.TabIndex = 9
        Me.btnStergeTot.Text = "Sterge tot"
        Me.btnStergeTot.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(31, 472)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 20)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Propozitii:"
        '
        'listbPropozitii
        '
        Me.listbPropozitii.FormattingEnabled = True
        Me.listbPropozitii.ItemHeight = 20
        Me.listbPropozitii.Location = New System.Drawing.Point(31, 495)
        Me.listbPropozitii.Name = "listbPropozitii"
        Me.listbPropozitii.Size = New System.Drawing.Size(413, 224)
        Me.listbPropozitii.TabIndex = 11
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(350, 743)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(94, 29)
        Me.btnExit.TabIndex = 12
        Me.btnExit.Text = "Inchide"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmAnsamblare
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(484, 794)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.listbPropozitii)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnStergeTot)
        Me.Controls.Add(Me.btnSterge)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.groupbTip)
        Me.Controls.Add(Me.listbComp)
        Me.Controls.Add(Me.listbPre)
        Me.Controls.Add(Me.listbSub)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmAnsamblare"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ansamblare propozitii"
        Me.groupbTip.ResumeLayout(False)
        Me.groupbTip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents listbSub As ListBox
    Friend WithEvents listbPre As ListBox
    Friend WithEvents listbComp As ListBox
    Friend WithEvents groupbTip As GroupBox
    Friend WithEvents rb3 As RadioButton
    Friend WithEvents rb2 As RadioButton
    Friend WithEvents rb1 As RadioButton
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnSterge As Button
    Friend WithEvents btnStergeTot As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents listbPropozitii As ListBox
    Friend WithEvents btnExit As Button
End Class
