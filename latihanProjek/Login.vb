Imports System.Configuration
Imports System.Text.RegularExpressions

Public Class Login

    Public Shared users As Users




    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        users = New Users

    End Sub

    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles BtnLogin.Click
        Dim plainUsername As String = TxtUsername.Text
        Dim plainPassword As String = TxtPassword.Text
        Dim AuthStatus As Boolean = users.CheckAuth(plainUsername, plainPassword)
        'If AuthStatus Then
        '    perpustakaan.Show()
        'Else
        '    MessageBox.Show("Username or Password Wrong")
        'End If

        'Menggunakan Database
        Dim data_user As List(Of String) = users.CheckAuthDatabase(plainUsername, plainPassword)
        If data_user.Count > 0 Then
            users.GSusername = data_user(1)
            perpustakaan.Show()
            Me.Hide()
        Else
            MessageBox.Show("Salah Password")
        End If

    End Sub

    Private Sub BtnRegis_Click(sender As Object, e As EventArgs) Handles BtnRegis.Click
        Register.Show()
    End Sub
End Class