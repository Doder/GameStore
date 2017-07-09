<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmIznajm
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.lstLice = New System.Windows.Forms.ListView
        Me.txtFilter = New System.Windows.Forms.TextBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.lstPrimjerak = New System.Windows.Forms.ListView
        Me.lstKnjiga = New System.Windows.Forms.ListView
        Me.group = New System.Windows.Forms.GroupBox
        Me.lblPrim = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.dtpDo = New System.Windows.Forms.DateTimePicker
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.lblIme = New System.Windows.Forms.Label
        Me.dtpOd = New System.Windows.Forms.DateTimePicker
        Me.lblKnj = New System.Windows.Forms.Label
        Me.lblJmbg = New System.Windows.Forms.Label
        Me.btnBack = New System.Windows.Forms.Button
        Me.btnOK = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.group.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.lstLice)
        Me.GroupBox1.Controls.Add(Me.txtFilter)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 17)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(336, 214)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Korisnik usluga"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(23, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(134, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Pretrazivanje po prezimenu"
        '
        'lstLice
        '
        Me.lstLice.FullRowSelect = True
        Me.lstLice.GridLines = True
        Me.lstLice.Location = New System.Drawing.Point(15, 65)
        Me.lstLice.MultiSelect = False
        Me.lstLice.Name = "lstLice"
        Me.lstLice.Size = New System.Drawing.Size(288, 130)
        Me.lstLice.TabIndex = 2
        Me.lstLice.UseCompatibleStateImageBehavior = False
        '
        'txtFilter
        '
        Me.txtFilter.Location = New System.Drawing.Point(166, 39)
        Me.txtFilter.Name = "txtFilter"
        Me.txtFilter.Size = New System.Drawing.Size(137, 20)
        Me.txtFilter.TabIndex = 1
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.lstPrimjerak)
        Me.GroupBox2.Controls.Add(Me.lstKnjiga)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 280)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(335, 201)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Knjiga"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(204, 32)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(96, 13)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Raspolozive knjige"
        '
        'lstPrimjerak
        '
        Me.lstPrimjerak.FullRowSelect = True
        Me.lstPrimjerak.GridLines = True
        Me.lstPrimjerak.Location = New System.Drawing.Point(192, 48)
        Me.lstPrimjerak.MultiSelect = False
        Me.lstPrimjerak.Name = "lstPrimjerak"
        Me.lstPrimjerak.Size = New System.Drawing.Size(126, 130)
        Me.lstPrimjerak.TabIndex = 15
        Me.lstPrimjerak.UseCompatibleStateImageBehavior = False
        '
        'lstKnjiga
        '
        Me.lstKnjiga.FullRowSelect = True
        Me.lstKnjiga.GridLines = True
        Me.lstKnjiga.Location = New System.Drawing.Point(15, 48)
        Me.lstKnjiga.MultiSelect = False
        Me.lstKnjiga.Name = "lstKnjiga"
        Me.lstKnjiga.Size = New System.Drawing.Size(159, 130)
        Me.lstKnjiga.TabIndex = 14
        Me.lstKnjiga.UseCompatibleStateImageBehavior = False
        '
        'group
        '
        Me.group.Controls.Add(Me.lblPrim)
        Me.group.Controls.Add(Me.Label6)
        Me.group.Controls.Add(Me.dtpDo)
        Me.group.Controls.Add(Me.Label5)
        Me.group.Controls.Add(Me.Label4)
        Me.group.Controls.Add(Me.Label1)
        Me.group.Controls.Add(Me.lblIme)
        Me.group.Controls.Add(Me.dtpOd)
        Me.group.Controls.Add(Me.lblKnj)
        Me.group.Controls.Add(Me.lblJmbg)
        Me.group.Location = New System.Drawing.Point(411, 17)
        Me.group.Name = "group"
        Me.group.Size = New System.Drawing.Size(309, 340)
        Me.group.TabIndex = 19
        Me.group.TabStop = False
        Me.group.Text = "Sklapanje ugovora"
        '
        'lblPrim
        '
        Me.lblPrim.AutoSize = True
        Me.lblPrim.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrim.Location = New System.Drawing.Point(101, 170)
        Me.lblPrim.Name = "lblPrim"
        Me.lblPrim.Size = New System.Drawing.Size(60, 13)
        Me.lblPrim.TabIndex = 20
        Me.lblPrim.Text = "lblPrimjerak"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(31, 293)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(21, 13)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "do"
        '
        'dtpDo
        '
        Me.dtpDo.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDo.Location = New System.Drawing.Point(104, 289)
        Me.dtpDo.Name = "dtpDo"
        Me.dtpDo.Size = New System.Drawing.Size(152, 20)
        Me.dtpDo.TabIndex = 17
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(31, 143)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(42, 13)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Knjiga"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(31, 46)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 13)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Korisnik"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(31, 238)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(21, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "od"
        '
        'lblIme
        '
        Me.lblIme.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIme.Location = New System.Drawing.Point(101, 69)
        Me.lblIme.Name = "lblIme"
        Me.lblIme.Size = New System.Drawing.Size(186, 49)
        Me.lblIme.TabIndex = 9
        Me.lblIme.Text = "Label3"
        '
        'dtpOd
        '
        Me.dtpOd.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpOd.Location = New System.Drawing.Point(104, 234)
        Me.dtpOd.Name = "dtpOd"
        Me.dtpOd.Size = New System.Drawing.Size(154, 20)
        Me.dtpOd.TabIndex = 0
        '
        'lblKnj
        '
        Me.lblKnj.AutoSize = True
        Me.lblKnj.Location = New System.Drawing.Point(101, 143)
        Me.lblKnj.Name = "lblKnj"
        Me.lblKnj.Size = New System.Drawing.Size(44, 13)
        Me.lblKnj.TabIndex = 14
        Me.lblKnj.Text = "lblNaziv"
        '
        'lblJmbg
        '
        Me.lblJmbg.AutoSize = True
        Me.lblJmbg.Location = New System.Drawing.Point(101, 46)
        Me.lblJmbg.Name = "lblJmbg"
        Me.lblJmbg.Size = New System.Drawing.Size(42, 13)
        Me.lblJmbg.TabIndex = 8
        Me.lblJmbg.Text = "lblJmbg"
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(583, 450)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(137, 34)
        Me.btnBack.TabIndex = 21
        Me.btnBack.Text = "Izadji"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'btnOK
        '
        Me.btnOK.Location = New System.Drawing.Point(411, 450)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(137, 34)
        Me.btnOK.TabIndex = 20
        Me.btnOK.Text = "OK"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'frmIznajm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(745, 511)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.group)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmIznajm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Iznajmljivanje"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.group.ResumeLayout(False)
        Me.group.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lstLice As System.Windows.Forms.ListView
    Friend WithEvents txtFilter As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lstPrimjerak As System.Windows.Forms.ListView
    Friend WithEvents lstKnjiga As System.Windows.Forms.ListView
    Friend WithEvents group As System.Windows.Forms.GroupBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents dtpDo As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblIme As System.Windows.Forms.Label
    Friend WithEvents dtpOd As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblKnj As System.Windows.Forms.Label
    Friend WithEvents lblJmbg As System.Windows.Forms.Label
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents btnOK As System.Windows.Forms.Button
    Friend WithEvents lblPrim As System.Windows.Forms.Label
End Class
