Public Class frmDetails
    Public title As String

    Public Sub New(ByVal s As String)

        InitializeComponent()
        title = s

    End Sub

    Private Sub frmDetails_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Click
        Me.Close()
    End Sub

    Private Sub frmDetails_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim k() As Game
        Dim count As Integer


        lblTitle.Text = title

        k = Game.ListGames(count, title)

        lblPrice.Text = k(0).GetPrice
        lblYear.Text = k(0).GetPubYear
        lblDev.Text = k(0).GetDeveloper
        lblMark.Text = k(0).GetMark


    End Sub
End Class