Imports System.Security.Cryptography
Imports MySql.Data.MySqlClient

Public Class Users

    Public Shared dbConn As New MySqlConnection
    Public Shared sqlCommand As New MySqlCommand
    Public Shared sqlRead As MySqlDataReader
    Private sqlQuery As String

    Private server As String = "localhost"
    Private usernameDB As String = "root"
    Private passwordDB As String = ""
    Private database As String = "perpustakaan"

    Private TripleDes As New TripleDESCryptoServiceProvider
    Public Shared abc As New ArrayList

    Private loginUsername As String

    Public Property GSusername As String
        Set(value As String)
            loginUsername = value
        End Set
        Get
            Return loginUsername
        End Get
    End Property

    Public Sub New()
        abc.Add({"vidi", EncryptData("1234")})
        abc.Add({"sss", EncryptData("1111")})
    End Sub

    Public Function EncryptData(ByVal plaintext As String) As String

        'convert the plaintext string a byte array.
        Dim plaintextBytes() As Byte =
            System.Text.Encoding.Unicode.GetBytes(plaintext)

        'create the stream.
        Dim ms As New System.IO.MemoryStream
        'Create the encoder to Write to the stream
        Dim encStream As New CryptoStream(ms, TripleDes.CreateEncryptor(), System.Security.Cryptography.CryptoStreamMode.Write)

        'Use the crypto stream to write the byte array to the stream
        encStream.Write(plaintextBytes, 0, plaintextBytes.Length)
        encStream.FlushFinalBlock()


        'Convert the encrypted stream to a printable string
        Return Convert.ToBase64String(ms.ToArray)
    End Function

    Public Function AddUserDatabase(username As String, password As String)
        Try
            Dim today = Date.Now()
            dbConn.ConnectionString = "server = " + server + ";" + "user id = " + usernameDB + ";" + "password= " + passwordDB + ";" + "database=" + database

            dbConn.Open()
            sqlCommand.Connection = dbConn
            sqlQuery = "INSERT INTO  USERS( username, password, registered_at) VALUE('" &
                    username & "', '" & EncryptMD5(password) & "', '" & today.ToString("yyyy/MM/dd") & "')"

            Debug.WriteLine(sqlQuery)

            sqlCommand = New MySqlCommand(sqlQuery, dbConn)
            sqlRead = sqlCommand.ExecuteReader

            sqlRead.Close()
            dbConn.Close()
        Catch ex As Exception
            Return ex.Message
        Finally
            dbConn.Dispose()
        End Try
    End Function


    Public Function CheckAuth(username As String, ByVal plainPassword As String) As String

        'Static Password
        'Dim realPassword As String = EncryptData("1234")
        'static username
        'Dim realUsername As String = "vidi"

        Dim flag = False
        For Each user In abc
            If String.Compare(username, user(0)) = 0 And String.Compare(EncryptData(plainPassword), user(1)) = 0 And Not flag Then
                flag = True
            End If
        Next
        Return flag
    End Function

    Public Function CheckAuthDatabase(username As String, password As String) As List(Of String)
        Try
            Dim result As New List(Of String)
            dbConn.ConnectionString = "server = " + server + ";" + "user id = " + usernameDB + ";" + "password= " + passwordDB + ";" + "database=" + database

            dbConn.Open()
            sqlCommand.Connection = dbConn

            Dim queryAuth = "SELECT id_user, username FROM users WHERE username='" & username & "' AND password='" & EncryptMD5(password) & "'"

            sqlCommand.CommandText = queryAuth
            Debug.WriteLine(queryAuth)
            sqlRead = sqlCommand.ExecuteReader

            If sqlRead.HasRows Then
                While sqlRead.Read
                    result.Add(sqlRead.GetString(0).ToString())
                    result.Add(sqlRead.GetString(1).ToString())
                End While
            End If

            sqlRead.Close()
            dbConn.Close()
            Return result
        Catch ex As Exception
            Debug.WriteLine(ex.Message)
        Finally
            dbConn.Dispose()
        End Try
    End Function

    Public Shared Function EncryptMD5(password As String)
        Using x As New MD5CryptoServiceProvider()
            Dim bs As Byte() = System.Text.Encoding.UTF8.GetBytes(password)
            bs = x.ComputeHash(bs)
            Dim s As New System.Text.StringBuilder()
            For Each b As Byte In bs
                s.Append(b.ToString("x2").ToLower())
            Next
            Return s.ToString()
        End Using
    End Function


End Class
