Public Class Register


    Private Sub Register_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BtnRegister_Click(sender As Object, e As EventArgs) Handles BtnRegister.Click
        If TxtUsername.Text <> "" And TxtPassword.Text <> "" Then
            Login.users.AddUserDatabase(TxtUsername.Text, TxtPassword.Text)
            Me.Close()
        Else
            MessageBox.Show("salah ")
        End If

        'If TxtUsername.Text.Length > 0 And TxtPassword.Text.Length > 0 Then
        '    Login.users.AddUserDatabase(TxtUsername.Text, TxtPassword.Text)
        '    Me.Close()
        'Else
        '    MessageBox.Show("Lengkapi Data")
        'End If
    End Sub
End Class