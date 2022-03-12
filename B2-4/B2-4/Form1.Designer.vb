<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTransfer
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
        Me.lstbListaProduse = New System.Windows.Forms.ListBox()
        Me.lstbProduseCump = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnAddAll = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.btnRemoveAll = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.chbX = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'lstbListaProduse
        '
        Me.lstbListaProduse.Font = New System.Drawing.Font("Verdana", 16.2!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point)
        Me.lstbListaProduse.FormattingEnabled = True
        Me.lstbListaProduse.ItemHeight = 32
        Me.lstbListaProduse.Items.AddRange(New Object() {"Mere", "Banane", "Kiwi", "Portocale", "Mandarine", "Alune", "Cartofi", "Praz", "Rosii", "Castraveti", "Sfecla rosie"})
        Me.lstbListaProduse.Location = New System.Drawing.Point(32, 52)
        Me.lstbListaProduse.Name = "lstbListaProduse"
        Me.lstbListaProduse.Size = New System.Drawing.Size(172, 356)
        Me.lstbListaProduse.TabIndex = 0
        '
        'lstbProduseCump
        '
        Me.lstbProduseCump.Font = New System.Drawing.Font("Verdana", 16.2!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point)
        Me.lstbProduseCump.FormattingEnabled = True
        Me.lstbProduseCump.ItemHeight = 32
        Me.lstbProduseCump.Location = New System.Drawing.Point(323, 52)
        Me.lstbProduseCump.Name = "lstbProduseCump"
        Me.lstbProduseCump.Size = New System.Drawing.Size(172, 356)
        Me.lstbProduseCump.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(32, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 20)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Lista produse:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(323, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(137, 20)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Produse cumparate"
        '
        'btnAddAll
        '
        Me.btnAddAll.Location = New System.Drawing.Point(232, 52)
        Me.btnAddAll.Name = "btnAddAll"
        Me.btnAddAll.Size = New System.Drawing.Size(69, 70)
        Me.btnAddAll.TabIndex = 4
        Me.btnAddAll.Text = ">>"
        Me.btnAddAll.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(232, 156)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(69, 70)
        Me.btnAdd.TabIndex = 5
        Me.btnAdd.Text = ">"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnRemove
        '
        Me.btnRemove.Location = New System.Drawing.Point(232, 260)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(69, 70)
        Me.btnRemove.TabIndex = 6
        Me.btnRemove.Text = "<"
        Me.btnRemove.UseVisualStyleBackColor = True
        '
        'btnRemoveAll
        '
        Me.btnRemoveAll.Location = New System.Drawing.Point(232, 364)
        Me.btnRemoveAll.Name = "btnRemoveAll"
        Me.btnRemoveAll.Size = New System.Drawing.Size(69, 70)
        Me.btnRemoveAll.TabIndex = 7
        Me.btnRemoveAll.Text = "<<"
        Me.btnRemoveAll.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(232, 228)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(69, 70)
        Me.Button7.TabIndex = 6
        Me.Button7.Text = "Button3"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'chbX
        '
        Me.chbX.AutoSize = True
        Me.chbX.Location = New System.Drawing.Point(323, 433)
        Me.chbX.Name = "chbX"
        Me.chbX.Size = New System.Drawing.Size(64, 24)
        Me.chbX.TabIndex = 8
        Me.chbX.Text = "chbX"
        Me.chbX.UseVisualStyleBackColor = True
        '
        'frmTransfer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(690, 479)
        Me.Controls.Add(Me.chbX)
        Me.Controls.Add(Me.btnRemoveAll)
        Me.Controls.Add(Me.btnRemove)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.btnAddAll)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lstbProduseCump)
        Me.Controls.Add(Me.lstbListaProduse)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmTransfer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Transfer intre liste"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lstbListaProduse As ListBox
    Friend WithEvents lstbProduseCump As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnAddAll As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnRemove As Button
    Friend WithEvents btnRemoveAll As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents chbX As CheckBox
End Class
