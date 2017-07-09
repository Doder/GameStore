<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBiblioteka
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
        Me.lstBiblio = New System.Windows.Forms.ListView
        Me.btnKarakteristike = New System.Windows.Forms.Button
        Me.btnRaspolozivost = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.txtFilter = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.btnAdd = New System.Windows.Forms.Button
        Me.btnDel = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'lstBiblio
        '
        Me.lstBiblio.FullRowSelect = True
        Me.lstBiblio.GridLines = True
        Me.lstBiblio.Location = New System.Drawing.Point(21, 37)
        Me.lstBiblio.MultiSelect = False
        Me.lstBiblio.Name = "lstBiblio"
        Me.lstBiblio.Size = New System.Drawing.Size(280, 259)
        Me.lstBiblio.TabIndex = 0
        Me.lstBiblio.UseCompatibleStateImageBehavior = False
        '
        'btnKarakteristike
        '
        Me.btnKarakteristike.Location = New System.Drawing.Point(362, 177)
        Me.btnKarakteristike.Name = "btnKarakteristike"
        Me.btnKarakteristike.Size = New System.Drawing.Size(179, 25)
        Me.btnKarakteristike.TabIndex = 1
        Me.btnKarakteristike.Text = "Detaljno o knijzi"
        Me.btnKarakteristike.UseVisualStyleBackColor = True
        '
        'btnRaspolozivost
        '
        Me.btnRaspolozivost.Location = New System.Drawing.Point(362, 141)
        Me.btnRaspolozivost.Name = "btnRaspolozivost"
        Me.btnRaspolozivost.Size = New System.Drawing.Size(179, 25)
        Me.btnRaspolozivost.TabIndex = 2
        Me.btnRaspolozivost.Text = "Raspolozivost knjige"
        Me.btnRaspolozivost.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(362, 262)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(179, 34)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Izadji"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtFilter
        '
        Me.txtFilter.Location = New System.Drawing.Point(172, 11)
        Me.txtFilter.Name = "txtFilter"
        Me.txtFilter.Size = New System.Drawing.Size(129, 20)
        Me.txtFilter.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(18, 14)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(148, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Pretrazivanje po nazivu knjige"
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(362, 37)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(179, 25)
        Me.btnAdd.TabIndex = 7
        Me.btnAdd.Text = "Dodaj novu knjigu"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnDel
        '
        Me.btnDel.Location = New System.Drawing.Point(362, 74)
        Me.btnDel.Name = "btnDel"
        Me.btnDel.Size = New System.Drawing.Size(179, 25)
        Me.btnDel.TabIndex = 8
        Me.btnDel.Text = "Izbrisi knjigu"
        Me.btnDel.UseVisualStyleBackColor = True
        '
        'frmBiblioteka
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(569, 323)
        Me.Controls.Add(Me.btnDel)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtFilter)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnRaspolozivost)
        Me.Controls.Add(Me.btnKarakteristike)
        Me.Controls.Add(Me.lstBiblio)
        Me.Name = "frmBiblioteka"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Biblioteka"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lstBiblio As System.Windows.Forms.ListView
    Friend WithEvents btnKarakteristike As System.Windows.Forms.Button
    Friend WithEvents btnRaspolozivost As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents txtFilter As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnDel As System.Windows.Forms.Button
End Class
