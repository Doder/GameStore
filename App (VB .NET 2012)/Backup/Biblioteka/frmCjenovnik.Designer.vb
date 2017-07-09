<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCjenovnik
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCjenovnik))
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.lstCjenovnik = New System.Windows.Forms.ListView
        Me.btnCijenaEdit = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(27, 289)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(34, 272)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(634, 56)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = resources.GetString("Label2.Text")
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lstCjenovnik
        '
        Me.lstCjenovnik.FullRowSelect = True
        Me.lstCjenovnik.GridLines = True
        Me.lstCjenovnik.Location = New System.Drawing.Point(34, 12)
        Me.lstCjenovnik.MultiSelect = False
        Me.lstCjenovnik.Name = "lstCjenovnik"
        Me.lstCjenovnik.Size = New System.Drawing.Size(634, 257)
        Me.lstCjenovnik.TabIndex = 6
        Me.lstCjenovnik.UseCompatibleStateImageBehavior = False
        '
        'btnCijenaEdit
        '
        Me.btnCijenaEdit.Location = New System.Drawing.Point(141, 342)
        Me.btnCijenaEdit.Name = "btnCijenaEdit"
        Me.btnCijenaEdit.Size = New System.Drawing.Size(145, 36)
        Me.btnCijenaEdit.TabIndex = 7
        Me.btnCijenaEdit.Text = "Promijeni"
        Me.btnCijenaEdit.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(430, 342)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(145, 36)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Izadji"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'frmCjenovnik
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(702, 406)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnCijenaEdit)
        Me.Controls.Add(Me.lstCjenovnik)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmCjenovnik"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmCjenovnik"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lstCjenovnik As System.Windows.Forms.ListView
    Friend WithEvents btnCijenaEdit As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
