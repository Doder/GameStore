Public Class frmPrimjerakAdd

    Public primj As Integer

    Public Sub New(ByVal s As String)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        primj = s

        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub frmPrimjerakAdd_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        Me.Close()
    End Sub

    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        If txtPovez.Text = "" Then
            MsgBox("Morate unijeti povez", MsgBoxStyle.Exclamation, "Greska")
        Else 'unesena tablica
            Dim p As New Primjerak(primj, txtPovez.Text)
            If p.UnesiPrimjerak Then
                Me.Close()
            Else
                MsgBox("Podaci nisu validni", MsgBoxStyle.Exclamation, "Greska")
            End If
        End If
    End Sub
End Class