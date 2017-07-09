Public Class frmUserAdd

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click
        If txtEmail.Text = "" Or txtName.Text = "" Or txtSurname.Text = "" Or txtAddress.Text = "" Or txtTel.Text = "" Then
            MsgBox("Please fill all data!", MsgBoxStyle.Exclamation, "Error")
        Else

            Dim l As New User(txtEmail.Text, txtName.Text, txtSurname.Text, txtTel.Text, txtAddress.Text, DateTimePicker1.Value.ToString("MM-dd-yyyy"), cbAdmin.CheckState, txtPwd.Text, txtBalance.Text)
            If l.InsertUser Then
                Me.Close()
            Else
                MsgBox("Incorrect data!", MsgBoxStyle.Exclamation, "Error")
            End If
        End If
    End Sub

    Private Sub frmUserAdd_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DateTimePicker1.Format = DateTimePickerFormat.Custom
        DateTimePicker1.CustomFormat = "dd/MM/yyyy"
    End Sub

End Class