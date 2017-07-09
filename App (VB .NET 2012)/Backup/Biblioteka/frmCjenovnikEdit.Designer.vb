<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCjenovnikEdit
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblKnjiga = New System.Windows.Forms.Label
        Me.txtCijena = New System.Windows.Forms.TextBox
        Me.txtKazna = New System.Windows.Forms.TextBox
        Me.txtCijena2 = New System.Windows.Forms.TextBox
        Me.txtCijena1 = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.btnOk = New System.Windows.Forms.Button
        Me.btnIzadji = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'lblKnjiga
        '
        Me.lblKnjiga.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblKnjiga.Location = New System.Drawing.Point(31, 9)
        Me.lblKnjiga.Name = "lblKnjiga"
        Me.lblKnjiga.Size = New System.Drawing.Size(210, 35)
        Me.lblKnjiga.TabIndex = 18
        Me.lblKnjiga.Text = "Knjiga"
        Me.lblKnjiga.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtCijena
        '
        Me.txtCijena.Location = New System.Drawing.Point(125, 73)
        Me.txtCijena.Name = "txtCijena"
        Me.txtCijena.Size = New System.Drawing.Size(98, 20)
        Me.txtCijena.TabIndex = 19
        '
        'txtKazna
        '
        Me.txtKazna.Location = New System.Drawing.Point(125, 191)
        Me.txtKazna.Name = "txtKazna"
        Me.txtKazna.Size = New System.Drawing.Size(98, 20)
        Me.txtKazna.TabIndex = 20
        '
        'txtCijena2
        '
        Me.txtCijena2.Location = New System.Drawing.Point(125, 149)
        Me.txtCijena2.Name = "txtCijena2"
        Me.txtCijena2.Size = New System.Drawing.Size(98, 20)
        Me.txtCijena2.TabIndex = 21
        '
        'txtCijena1
        '
        Me.txtCijena1.Location = New System.Drawing.Point(125, 111)
        Me.txtCijena1.Name = "txtCijena1"
        Me.txtCijena1.Size = New System.Drawing.Size(98, 20)
        Me.txtCijena1.TabIndex = 22
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(46, 76)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "5 dana"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(46, 194)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 13)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "Kazna"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(46, 152)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 13)
        Me.Label3.TabIndex = 25
        Me.Label3.Text = "15 dana"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(46, 114)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 13)
        Me.Label4.TabIndex = 26
        Me.Label4.Text = "10 dana"
        '
        'btnOk
        '
        Me.btnOk.Location = New System.Drawing.Point(49, 251)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(78, 26)
        Me.btnOk.TabIndex = 27
        Me.btnOk.Text = "OK"
        Me.btnOk.UseVisualStyleBackColor = True
        '
        'btnIzadji
        '
        Me.btnIzadji.Location = New System.Drawing.Point(145, 251)
        Me.btnIzadji.Name = "btnIzadji"
        Me.btnIzadji.Size = New System.Drawing.Size(78, 26)
        Me.btnIzadji.TabIndex = 28
        Me.btnIzadji.Text = "Izadji"
        Me.btnIzadji.UseVisualStyleBackColor = True
        '
        'frmCjenovnikEdit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(278, 302)
        Me.Controls.Add(Me.btnIzadji)
        Me.Controls.Add(Me.btnOk)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtCijena1)
        Me.Controls.Add(Me.txtCijena2)
        Me.Controls.Add(Me.txtKazna)
        Me.Controls.Add(Me.txtCijena)
        Me.Controls.Add(Me.lblKnjiga)
        Me.Name = "frmCjenovnikEdit"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmCjenovnikEdit"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblKnjiga As System.Windows.Forms.Label
    Friend WithEvents txtCijena As System.Windows.Forms.TextBox
    Friend WithEvents txtKazna As System.Windows.Forms.TextBox
    Friend WithEvents txtCijena2 As System.Windows.Forms.TextBox
    Friend WithEvents txtCijena1 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnOk As System.Windows.Forms.Button
    Friend WithEvents btnIzadji As System.Windows.Forms.Button
End Class
