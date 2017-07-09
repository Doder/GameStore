<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.btnCjenovnik = New System.Windows.Forms.Button
        Me.btnBiblioteka = New System.Windows.Forms.Button
        Me.btnRent = New System.Windows.Forms.Button
        Me.btnExit = New System.Windows.Forms.Button
        Me.btnKorisnik = New System.Windows.Forms.Button
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnCjenovnik
        '
        Me.btnCjenovnik.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCjenovnik.Location = New System.Drawing.Point(567, 90)
        Me.btnCjenovnik.Name = "btnCjenovnik"
        Me.btnCjenovnik.Size = New System.Drawing.Size(147, 38)
        Me.btnCjenovnik.TabIndex = 1
        Me.btnCjenovnik.Text = "Cjenovnik usluga"
        Me.btnCjenovnik.UseVisualStyleBackColor = True
        '
        'btnBiblioteka
        '
        Me.btnBiblioteka.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBiblioteka.Location = New System.Drawing.Point(567, 32)
        Me.btnBiblioteka.Name = "btnBiblioteka"
        Me.btnBiblioteka.Size = New System.Drawing.Size(147, 38)
        Me.btnBiblioteka.TabIndex = 2
        Me.btnBiblioteka.Text = "Biblioteka"
        Me.btnBiblioteka.UseVisualStyleBackColor = True
        '
        'btnRent
        '
        Me.btnRent.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRent.Location = New System.Drawing.Point(567, 209)
        Me.btnRent.Name = "btnRent"
        Me.btnRent.Size = New System.Drawing.Size(147, 38)
        Me.btnRent.TabIndex = 3
        Me.btnRent.Text = "Rent"
        Me.btnRent.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(567, 318)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(147, 38)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "Izadji"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnKorisnik
        '
        Me.btnKorisnik.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnKorisnik.Location = New System.Drawing.Point(567, 150)
        Me.btnKorisnik.Name = "btnKorisnik"
        Me.btnKorisnik.Size = New System.Drawing.Size(147, 38)
        Me.btnKorisnik.TabIndex = 5
        Me.btnKorisnik.Text = "Korisnici"
        Me.btnKorisnik.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.Biblioteka.My.Resources.Resources.athenaeum_library2
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(551, 383)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(726, 383)
        Me.Controls.Add(Me.btnKorisnik)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnRent)
        Me.Controls.Add(Me.btnBiblioteka)
        Me.Controls.Add(Me.btnCjenovnik)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btnCjenovnik As System.Windows.Forms.Button
    Friend WithEvents btnBiblioteka As System.Windows.Forms.Button
    Friend WithEvents btnRent As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnKorisnik As System.Windows.Forms.Button

End Class
