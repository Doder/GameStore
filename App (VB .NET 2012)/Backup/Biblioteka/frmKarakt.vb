Public Class frmKarakt
    Public naziv As String

    Public Sub New(ByVal s As String)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        naziv = s

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub frmKarakt_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Click
        Me.Close()
    End Sub

    Private Sub frmKarakt_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim k() As Knjiga
        Dim count As Integer


        lblNaziv.Text = naziv

        'ovaj upit ce vratiti samo jedan record u svakom slucaju
        'i bice smjesten u a(0)
        k = Knjiga.ListaKnjiga(count, naziv)

        lblStrane.Text = k(0).GetBrStrana
        lblGod.Text = k(0).GetGod
        lblAutor.Text = k(0).GetAutor
        lblIzdavac.Text = k(0).GetIzdavac

    End Sub
End Class