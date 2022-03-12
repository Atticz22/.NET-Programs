<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPrimulNr
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
        Me.txtbNumere = New System.Windows.Forms.TextBox()
        Me.listbNumere = New System.Windows.Forms.ListBox()
        Me.btnCauta = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnStergeLista)
        Me.GroupBox1.Controls.Add(Me.btnSterge)
        Me.GroupBox1.Controls.Add(Me.btnAdauga)
        Me.GroupBox1.Controls.Add(Me.txtbNumere)
        Me.GroupBox1.Location = New System.Drawing.Point(23, 47)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(143, 257)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Control lista"
        '
        'btnStergeLista
        '
        Me.btnStergeLista.Location = New System.Drawing.Point(6, 170)
        Me.btnStergeLista.Name = "btnStergeLista"
        Me.btnStergeLista.Size = New System.Drawing.Size(122, 36)
        Me.btnStergeLista.TabIndex = 3
        Me.btnStergeLista.Text = "Sterge Lista"
        Me.btnStergeLista.UseVisualStyleBackColor = True
        '
        'btnSterge
        '
        Me.btnSterge.Location = New System.Drawing.Point(73, 110)
        Me.btnSterge.Name = "btnSterge"
        Me.btnSterge.Size = New System.Drawing.Size(64, 29)
        Me.btnSterge.TabIndex = 2
        Me.btnSterge.Text = "-"
        Me.btnSterge.UseVisualStyleBackColor = True
        '
        'btnAdauga
        '
        Me.btnAdauga.Location = New System.Drawing.Point(0, 110)
        Me.btnAdauga.Name = "btnAdauga"
        Me.btnAdauga.Size = New System.Drawing.Size(64, 29)
        Me.btnAdauga.TabIndex = 1
        Me.btnAdauga.Text = "+"
        Me.btnAdauga.UseVisualStyleBackColor = True
        '
        'txtbNumere
        '
        Me.txtbNumere.Location = New System.Drawing.Point(3, 47)
        Me.txtbNumere.Name = "txtbNumere"
        Me.txtbNumere.Size = New System.Drawing.Size(125, 27)
        Me.txtbNumere.TabIndex = 0
        '
        'listbNumere
        '
        Me.listbNumere.FormattingEnabled = True
        Me.listbNumere.ItemHeight = 20
        Me.listbNumere.Location = New System.Drawing.Point(208, 47)
        Me.listbNumere.Name = "listbNumere"
        Me.listbNumere.Size = New System.Drawing.Size(150, 264)
        Me.listbNumere.TabIndex = 1
        '
        'btnCauta
        '
        Me.btnCauta.Location = New System.Drawing.Point(23, 344)
        Me.btnCauta.Name = "btnCauta"
        Me.btnCauta.Size = New System.Drawing.Size(409, 34)
        Me.btnCauta.TabIndex = 2
        Me.btnCauta.Text = "Cauta"
        Me.btnCauta.UseVisualStyleBackColor = True
        '
        'frmPrimulNr
        '
        Me.AcceptButton = Me.btnAdauga
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(451, 403)
        Me.Controls.Add(Me.btnCauta)
        Me.Controls.Add(Me.listbNumere)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmPrimulNr"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Primul numar negativ 2"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnStergeLista As Button
    Friend WithEvents btnSterge As Button
    Friend WithEvents btnAdauga As Button
    Friend WithEvents txtbNumere As TextBox
    Friend WithEvents listbNumere As ListBox
    Friend WithEvents btnCauta As Button
End Class
