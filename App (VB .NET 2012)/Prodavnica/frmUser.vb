Public Class frmUser

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub InitHeaderUser()
        lstUser.View = View.Details

        lstUser.Columns.Add("Email", 110, HorizontalAlignment.Left)
        lstUser.Columns.Add("Name", 90, HorizontalAlignment.Left)
        lstUser.Columns.Add("Surname", 100, HorizontalAlignment.Left)
        lstUser.Columns.Add("Phone", 80, HorizontalAlignment.Left)
        lstUser.Columns.Add("Address", 100, HorizontalAlignment.Left)
        lstUser.Columns.Add("Birthday", 120, HorizontalAlignment.Left)
        lstUser.Columns.Add("Balance", 110, HorizontalAlignment.Left)
    End Sub

    Private Sub initListUser()
        lstUser.Items.Clear()
        Dim users() As User
        Dim count As Integer
        Dim i As Integer


        users = User.ListUsers(count, txtFilter.Text)

        For i = 0 To count - 1
            Dim lvItem As New ListViewItem(users(i).getEmail)
            lvItem.SubItems.Add(users(i).getName)
            lvItem.SubItems.Add(users(i).getSurname)
            lvItem.SubItems.Add(users(i).getPhoneNumber)
            lvItem.SubItems.Add(users(i).getAdr)
            lvItem.SubItems.Add(users(i).getBd)
            lvItem.SubItems.Add(users(i).getBalance)
            lstUser.Items.Add(lvItem)
        Next i

    End Sub
    Private Sub frmKorisnik_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        InitHeaderUser()
        initListUser()
    End Sub

    Private Sub btnDel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDel.Click
        If lstUser.SelectedItems.Count = 0 Then
            MsgBox("Please first select user you want to delete!", MsgBoxStyle.Exclamation, "Delete")
        Else
            Dim p As MsgBoxResult
            p = MsgBox("Are you sure you want to delete this user?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Delete")
            If p = MsgBoxResult.Yes Then
                Dim l As New User(Me.lstUser.SelectedItems(0).SubItems(0).Text)
                If l.DeleteUser() Then
                    initListUser()
                Else
                    MsgBox("It's not possible to delete this user!")
                End If
            End If
        End If
    End Sub

    Private Sub txtFilter_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtFilter.TextChanged
        initListUser()
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        Dim f As New frmUserAdd
        f.ShowDialog()
        initListUser()
    End Sub
End Class