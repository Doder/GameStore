Public Class frmCjenovnikEdit

    Public naziv As String

    Public Sub New(ByVal s As String)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        naziv = s
        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub btnIzadji_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIzadji.Click
        Me.Close()
    End Sub

    Private Sub frmCjenovnikEdit_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim k() As Knjiga
        Dim count As Integer

        lblKnjiga.Text = naziv

        'ovaj upit ce vratiti samo jedan rekord u svakom slucaju
        'i bice smjesten u k(0)
        k = Knjiga.ListaKnjiga(count, naziv)

        txtCijena.Text = k(0).GetCijena
        txtCijena1.Text = k(0).GetCijena1
        txtCijena2.Text = k(0).GetCijena2
        txtKazna.Text = k(0).GetKazna


    End Sub

    Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click
        If txtCijena.Text = "" Or txtCijena1.Text = "" Or txtCijena2.Text = "" Or txtKazna.Text = "" Then
            MsgBox("Morate unijeti sve cijene", MsgBoxStyle.Exclamation, "Greska")
        Else
            Dim k As New Knjiga(naziv, txtCijena.Text, txtCijena1.Text, txtCijena2.Text, txtKazna.Text)
            If k.PromjenaCijena Then
                Me.Close()
            Else
                MsgBox("Neka od cijena nije validna", MsgBoxStyle.Exclamation, "Greska")
            End If
        End If

    End Sub
End Class