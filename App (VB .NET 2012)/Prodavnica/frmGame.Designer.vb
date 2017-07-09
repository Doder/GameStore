<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGame
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
        Me.lstGames = New System.Windows.Forms.ListView()
        Me.btnDetails = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtFilter = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnDel = New System.Windows.Forms.Button()
        Me.btnToCart = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lstGames
        '
        Me.lstGames.FullRowSelect = True
        Me.lstGames.GridLines = True
        Me.lstGames.Location = New System.Drawing.Point(21, 37)
        Me.lstGames.MultiSelect = False
        Me.lstGames.Name = "lstGames"
        Me.lstGames.Size = New System.Drawing.Size(280, 259)
        Me.lstGames.TabIndex = 0
        Me.lstGames.UseCompatibleStateImageBehavior = False
        '
        'btnDetails
        '
        Me.btnDetails.Location = New System.Drawing.Point(362, 177)
        Me.btnDetails.Name = "btnDetails"
        Me.btnDetails.Size = New System.Drawing.Size(179, 25)
        Me.btnDetails.TabIndex = 1
        Me.btnDetails.Text = "Details"
        Me.btnDetails.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(362, 262)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(179, 34)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Cancel"
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
        Me.Label2.Size = New System.Drawing.Size(84, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Search by name"
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(362, 37)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(179, 25)
        Me.btnAdd.TabIndex = 7
        Me.btnAdd.Text = "Add new game"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnDel
        '
        Me.btnDel.Location = New System.Drawing.Point(362, 74)
        Me.btnDel.Name = "btnDel"
        Me.btnDel.Size = New System.Drawing.Size(179, 25)
        Me.btnDel.TabIndex = 8
        Me.btnDel.Text = "Delete game"
        Me.btnDel.UseVisualStyleBackColor = True
        '
        'btnToCart
        '
        Me.btnToCart.Location = New System.Drawing.Point(362, 208)
        Me.btnToCart.Name = "btnToCart"
        Me.btnToCart.Size = New System.Drawing.Size(179, 25)
        Me.btnToCart.TabIndex = 9
        Me.btnToCart.Text = "Add to cart"
        Me.btnToCart.UseVisualStyleBackColor = True
        '
        'frmGame
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(569, 323)
        Me.Controls.Add(Me.btnToCart)
        Me.Controls.Add(Me.btnDel)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtFilter)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnDetails)
        Me.Controls.Add(Me.lstGames)
        Me.Name = "frmGame"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Games"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lstGames As System.Windows.Forms.ListView
    Friend WithEvents btnDetails As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents txtFilter As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnDel As System.Windows.Forms.Button
    Friend WithEvents btnToCart As System.Windows.Forms.Button
End Class
