<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVracanje
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
        Me.btnRentBack = New System.Windows.Forms.Button
        Me.lstRent = New System.Windows.Forms.ListView
        Me.SuspendLayout()
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(361, 374)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(146, 34)
        Me.btnBack.TabIndex = 10
        Me.btnBack.Text = "Izadji"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'btnRentBack
        '
        Me.btnRentBack.Location = New System.Drawing.Point(169, 374)
        Me.btnRentBack.Name = "btnRentBack"
        Me.btnRentBack.Size = New System.Drawing.Size(146, 34)
        Me.btnRentBack.TabIndex = 9
        Me.btnRentBack.Text = "Vracanje knjige"
        Me.btnRentBack.UseVisualStyleBackColor = True
        '
        'lstRent
        '
        Me.lstRent.FullRowSelect = True
        Me.lstRent.GridLines = True
        Me.lstRent.Location = New System.Drawing.Point(12, 32)
        Me.lstRent.MultiSelect = False
        Me.lstRent.Name = "lstRent"
        Me.lstRent.Size = New System.Drawing.Size(654, 325)
        Me.lstRent.TabIndex = 8
        Me.lstRent.UseCompatibleStateImageBehavior = False
        '
        'frmVracanje
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(680, 429)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnRentBack)
        Me.Controls.Add(Me.lstRent)
        Me.Name = "frmVracanje"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmVracanje"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents btnRentBack As System.Windows.Forms.Button
    Friend WithEvents lstRent As System.Windows.Forms.ListView
End Class
