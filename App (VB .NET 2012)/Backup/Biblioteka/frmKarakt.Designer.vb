<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmKarakt
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
        Me.lblNaziv = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.lblStrane = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.lblGod = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.lblAutor = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.lblIzdavac = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'lblNaziv
        '
        Me.lblNaziv.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNaziv.Location = New System.Drawing.Point(12, 19)
        Me.lblNaziv.Name = "lblNaziv"
        Me.lblNaziv.Size = New System.Drawing.Size(300, 38)
        Me.lblNaziv.TabIndex = 11
        Me.lblNaziv.Text = "Knjiga"
        Me.lblNaziv.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(33, 105)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 13)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Broj strana: "
        '
        'lblStrane
        '
        Me.lblStrane.AutoSize = True
        Me.lblStrane.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStrane.Location = New System.Drawing.Point(139, 105)
        Me.lblStrane.Name = "lblStrane"
        Me.lblStrane.Size = New System.Drawing.Size(68, 13)
        Me.lblStrane.TabIndex = 13
        Me.lblStrane.Text = "Broj strana"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(33, 139)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 13)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Godina izdavanja :"
        '
        'lblGod
        '
        Me.lblGod.AutoSize = True
        Me.lblGod.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGod.Location = New System.Drawing.Point(139, 139)
        Me.lblGod.Name = "lblGod"
        Me.lblGod.Size = New System.Drawing.Size(105, 13)
        Me.lblGod.TabIndex = 15
        Me.lblGod.Text = "Godina izdavanja"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(33, 175)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 13)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Autor:"
        '
        'lblAutor
        '
        Me.lblAutor.AutoSize = True
        Me.lblAutor.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAutor.Location = New System.Drawing.Point(139, 175)
        Me.lblAutor.Name = "lblAutor"
        Me.lblAutor.Size = New System.Drawing.Size(37, 13)
        Me.lblAutor.TabIndex = 17
        Me.lblAutor.Text = "Autor"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(33, 207)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 13)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Izdavac:"
        '
        'lblIzdavac
        '
        Me.lblIzdavac.AutoSize = True
        Me.lblIzdavac.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIzdavac.Location = New System.Drawing.Point(139, 207)
        Me.lblIzdavac.Name = "lblIzdavac"
        Me.lblIzdavac.Size = New System.Drawing.Size(52, 13)
        Me.lblIzdavac.TabIndex = 19
        Me.lblIzdavac.Text = "Izdavac"
        '
        'frmKarakt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(314, 259)
        Me.Controls.Add(Me.lblIzdavac)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblAutor)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblGod)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblStrane)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblNaziv)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmKarakt"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmKarakt"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblNaziv As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblStrane As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblGod As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblAutor As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblIzdavac As System.Windows.Forms.Label
End Class
