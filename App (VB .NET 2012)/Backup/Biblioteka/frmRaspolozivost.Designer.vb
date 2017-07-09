<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRaspolozivost
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
        Me.btnBack = New System.Windows.Forms.Button
        Me.btnDel = New System.Windows.Forms.Button
        Me.btnAdd = New System.Windows.Forms.Button
        Me.lstRaspolozivost = New System.Windows.Forms.ListView
        Me.lblKnjiga = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(285, 312)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(136, 36)
        Me.btnBack.TabIndex = 20
        Me.btnBack.Text = "Izadji"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'btnDel
        '
        Me.btnDel.Location = New System.Drawing.Point(285, 127)
        Me.btnDel.Name = "btnDel"
        Me.btnDel.Size = New System.Drawing.Size(136, 36)
        Me.btnDel.TabIndex = 19
        Me.btnDel.Text = "Brisanje primjerka"
        Me.btnDel.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(285, 74)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(136, 36)
        Me.btnAdd.TabIndex = 18
        Me.btnAdd.Text = "Dodavanje novog primjerka ove knjige"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'lstRaspolozivost
        '
        Me.lstRaspolozivost.FullRowSelect = True
        Me.lstRaspolozivost.GridLines = True
        Me.lstRaspolozivost.Location = New System.Drawing.Point(25, 74)
        Me.lstRaspolozivost.MultiSelect = False
        Me.lstRaspolozivost.Name = "lstRaspolozivost"
        Me.lstRaspolozivost.Size = New System.Drawing.Size(227, 274)
        Me.lstRaspolozivost.TabIndex = 17
        Me.lstRaspolozivost.UseCompatibleStateImageBehavior = False
        '
        'lblKnjiga
        '
        Me.lblKnjiga.AutoSize = True
        Me.lblKnjiga.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblKnjiga.Location = New System.Drawing.Point(145, 23)
        Me.lblKnjiga.Name = "lblKnjiga"
        Me.lblKnjiga.Size = New System.Drawing.Size(58, 20)
        Me.lblKnjiga.TabIndex = 21
        Me.lblKnjiga.Text = "Knjiga"
        Me.lblKnjiga.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmRaspolozivost
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(449, 377)
        Me.Controls.Add(Me.lblKnjiga)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnDel)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.lstRaspolozivost)
        Me.Name = "frmRaspolozivost"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmRaspolozivost"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents btnDel As System.Windows.Forms.Button
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents lstRaspolozivost As System.Windows.Forms.ListView
    Friend WithEvents lblKnjiga As System.Windows.Forms.Label
End Class
