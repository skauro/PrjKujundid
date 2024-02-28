<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormKujundid
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
        Me.txtKylgA = New System.Windows.Forms.TextBox()
        Me.txtKylgB = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtYmbermoot = New System.Windows.Forms.TextBox()
        Me.txtPindala = New System.Windows.Forms.TextBox()
        Me.btnKolmnurk = New System.Windows.Forms.Button()
        Me.btnRuut = New System.Windows.Forms.Button()
        Me.btnRistkylik = New System.Windows.Forms.Button()
        Me.lblTyyp = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtKorgus = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnRomb = New System.Windows.Forms.Button()
        Me.btnRoopkylik = New System.Windows.Forms.Button()
        Me.LabelError = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtKylgA
        '
        Me.txtKylgA.Location = New System.Drawing.Point(128, 33)
        Me.txtKylgA.Name = "txtKylgA"
        Me.txtKylgA.Size = New System.Drawing.Size(100, 26)
        Me.txtKylgA.TabIndex = 0
        '
        'txtKylgB
        '
        Me.txtKylgB.Location = New System.Drawing.Point(128, 82)
        Me.txtKylgB.Name = "txtKylgB"
        Me.txtKylgB.Size = New System.Drawing.Size(100, 26)
        Me.txtKylgB.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(79, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(27, 20)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "a="
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(79, 88)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(27, 20)
        Me.label2.TabIndex = 3
        Me.label2.Text = "b="
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(50, 205)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(107, 20)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "kujundi tüüp : "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(50, 249)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(93, 20)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Ümbermõõt"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(79, 292)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(61, 20)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Pindala"
        '
        'txtYmbermoot
        '
        Me.txtYmbermoot.Enabled = False
        Me.txtYmbermoot.Location = New System.Drawing.Point(168, 243)
        Me.txtYmbermoot.Name = "txtYmbermoot"
        Me.txtYmbermoot.ReadOnly = True
        Me.txtYmbermoot.Size = New System.Drawing.Size(100, 26)
        Me.txtYmbermoot.TabIndex = 7
        '
        'txtPindala
        '
        Me.txtPindala.BackColor = System.Drawing.SystemColors.Control
        Me.txtPindala.Enabled = False
        Me.txtPindala.Location = New System.Drawing.Point(168, 292)
        Me.txtPindala.Name = "txtPindala"
        Me.txtPindala.ReadOnly = True
        Me.txtPindala.Size = New System.Drawing.Size(100, 26)
        Me.txtPindala.TabIndex = 8
        '
        'btnKolmnurk
        '
        Me.btnKolmnurk.Location = New System.Drawing.Point(642, 50)
        Me.btnKolmnurk.Name = "btnKolmnurk"
        Me.btnKolmnurk.Size = New System.Drawing.Size(101, 31)
        Me.btnKolmnurk.TabIndex = 9
        Me.btnKolmnurk.Text = "kolmnurk"
        Me.btnKolmnurk.UseVisualStyleBackColor = True
        '
        'btnRuut
        '
        Me.btnRuut.Location = New System.Drawing.Point(642, 100)
        Me.btnRuut.Name = "btnRuut"
        Me.btnRuut.Size = New System.Drawing.Size(101, 29)
        Me.btnRuut.TabIndex = 10
        Me.btnRuut.Text = "Ruut"
        Me.btnRuut.UseVisualStyleBackColor = True
        '
        'btnRistkylik
        '
        Me.btnRistkylik.Location = New System.Drawing.Point(642, 146)
        Me.btnRistkylik.Name = "btnRistkylik"
        Me.btnRistkylik.Size = New System.Drawing.Size(101, 30)
        Me.btnRistkylik.TabIndex = 11
        Me.btnRistkylik.Text = "Ristkülik"
        Me.btnRistkylik.UseVisualStyleBackColor = True
        '
        'lblTyyp
        '
        Me.lblTyyp.AutoSize = True
        Me.lblTyyp.Location = New System.Drawing.Point(178, 205)
        Me.lblTyyp.Name = "lblTyyp"
        Me.lblTyyp.Size = New System.Drawing.Size(90, 20)
        Me.lblTyyp.TabIndex = 12
        Me.lblTyyp.Text = "määramata"
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"0", "1", "2", "3"})
        Me.ComboBox1.Location = New System.Drawing.Point(128, 131)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 28)
        Me.ComboBox1.TabIndex = 13
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(37, 134)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(69, 20)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "täpsus : "
        '
        'TxtKorgus
        '
        Me.TxtKorgus.Location = New System.Drawing.Point(365, 39)
        Me.TxtKorgus.Name = "TxtKorgus"
        Me.TxtKorgus.Size = New System.Drawing.Size(100, 26)
        Me.TxtKorgus.TabIndex = 15
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(315, 42)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(27, 20)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "h="
        '
        'btnRomb
        '
        Me.btnRomb.Location = New System.Drawing.Point(642, 202)
        Me.btnRomb.Name = "btnRomb"
        Me.btnRomb.Size = New System.Drawing.Size(101, 32)
        Me.btnRomb.TabIndex = 18
        Me.btnRomb.Text = "Romb"
        Me.btnRomb.UseVisualStyleBackColor = True
        '
        'btnRoopkylik
        '
        Me.btnRoopkylik.Location = New System.Drawing.Point(642, 249)
        Me.btnRoopkylik.Name = "btnRoopkylik"
        Me.btnRoopkylik.Size = New System.Drawing.Size(101, 30)
        Me.btnRoopkylik.TabIndex = 19
        Me.btnRoopkylik.Text = "Rööpkülik"
        Me.btnRoopkylik.UseVisualStyleBackColor = True
        '
        'LabelError
        '
        Me.LabelError.AutoSize = True
        Me.LabelError.Location = New System.Drawing.Point(284, 82)
        Me.LabelError.Name = "LabelError"
        Me.LabelError.Size = New System.Drawing.Size(0, 20)
        Me.LabelError.TabIndex = 20
        '
        'FormKujundid
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.LabelError)
        Me.Controls.Add(Me.btnRoopkylik)
        Me.Controls.Add(Me.btnRomb)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.TxtKorgus)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.lblTyyp)
        Me.Controls.Add(Me.btnRistkylik)
        Me.Controls.Add(Me.btnRuut)
        Me.Controls.Add(Me.btnKolmnurk)
        Me.Controls.Add(Me.txtPindala)
        Me.Controls.Add(Me.txtYmbermoot)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtKylgB)
        Me.Controls.Add(Me.txtKylgA)
        Me.Name = "FormKujundid"
        Me.Text = "Kujundid"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtKylgA As TextBox
    Friend WithEvents txtKylgB As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtYmbermoot As TextBox
    Friend WithEvents txtPindala As TextBox
    Friend WithEvents btnKolmnurk As Button
    Friend WithEvents btnRuut As Button
    Friend WithEvents btnRistkylik As Button
    Friend WithEvents lblTyyp As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TxtKorgus As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents btnRomb As Button
    Friend WithEvents btnRoopkylik As Button
    Friend WithEvents LabelError As Label
End Class
