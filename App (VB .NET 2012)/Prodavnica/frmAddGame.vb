Public Class frmAddGame

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click
        If txtPrice.Text = "" Or txtTitle.Text = "" Or txtMark.Text = "" Or txtYear.Text = "" Or cmbDev.Text = "" Then
            MsgBox("Fill all data please!", MsgBoxStyle.Exclamation, "Error")
        Else
            Dim k As New Game(txtTitle.Text, CInt(txtMark.Text), CInt(txtYear.Text), Double.Parse(txtPrice.Text), cmbDev.Text)
            If k.InsertGame Then
                Me.Close()
            Else
                MsgBox("Incorrect info!", MsgBoxStyle.Exclamation, "Error")
            End If
        End If
    End Sub

    Private Sub frmIgraAdd_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        cmbDev.Items.Clear()

        Dim knjige() As Game
        Dim count As Integer
        Dim i As Integer

        knjige = Game.listDevelopers(count)

        For i = 0 To count - 1
            cmbDev.Items.Add(knjige(i).GetDeveloper)
        Next i

    End Sub
End Class