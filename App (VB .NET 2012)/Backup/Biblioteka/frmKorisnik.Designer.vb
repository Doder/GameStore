<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmKorisnik
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
        Me.lstLice = New System.Windows.Forms.ListView
        Me.btnDodaj = New System.Windows.Forms.Button
        Me.btnBrisi = New System.Windows.Forms.Button
        Me.txtFilter = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'lstLice
        '
        Me.lstLice.FullRowSelect = True
        Me.lstLice.GridLines = True
        Me.lstLice.Location = New System.Drawing.Point(44, 48)
        Me.lstLice.MultiSelect = False
        Me.lstLice.Name = "lstLice"
        Me.lstLice.Size = New System.Drawing.Size(509, 214)
        Me.lstLice.TabIndex = 0
        Me.lstLice.UseCompatibleStateImageBehavior = False
        '
        'btnDodaj
        '
        Me.btnDodaj.Location = New System.Drawing.Point(72, 284)
        Me.btnDodaj.Name = "btnDodaj"
        Me.btnDodaj.Size = New System.Drawing.Size(148, 28)
        Me.btnDodaj.TabIndex = 1
        Me.btnDodaj.Text = "Dodaj korisnika"
        Me.btnDodaj.UseVisualStyleBackColor = True
        '
        'btnBrisi
        '
        Me.btnBrisi.Location = New System.Drawing.Point(364, 284)
        Me.btnBrisi.Name = "btnBrisi"
        Me.btnBrisi.Size = New System.Drawing.Size(148, 28)
        Me.btnBrisi.TabIndex = 2
        Me.btnBrisi.Text = "Izbrisi korisnika"
        Me.btnBrisi.UseVisualStyleBackColor = True
        '
        'txtFilter
        '
        Me.txtFilter.Location = New System.Drawing.Point(410, 12)
        Me.txtFilter.Name = "txtFilter"
        Me.txtFilter.Size = New System.Drawing.Size(143, 20)
        Me.txtFilter.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(253, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(134, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Pretrazivanje po prezimenu"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(247, 323)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(90, 28)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Izadji"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'frmKorisnik
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(592, 363)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtFilter)
        Me.Controls.Add(Me.btnBrisi)
        Me.Controls.Add(Me.btnDodaj)
        Me.Controls.Add(Me.lstLice)
        Me.Name = "frmKorisnik"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Korisnici"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lstLice As System.Windows.Forms.ListView
    Friend WithEvents btnDodaj As System.Windows.Forms.Button
    Friend WithEvents btnBrisi As System.Windows.Forms.Button
    Friend WithEvents txtFilter As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
