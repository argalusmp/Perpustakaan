Imports System.Text
Imports MySql.Data.MySqlClient

Public Class DataPerpus

    Private Nama_Koleksi As String
    Private Jenis_Koleksi As String
    Private Deskripsi As String
    Private Penerbit As String
    Private Tahun_Terbit As String
    Private Lokasi_Rak As String
    Private tanggal_masuk As Date
    Private Stock As String
    Private Bahasa As String
    Private Kategori As New List(Of String)
    Private Foto As String


    Private koleksiDataTable As New ArrayList()

    Public Shared dbConn As New MySqlConnection
    Public Shared sqlCommand As New MySqlCommand
    Public Shared sqlRead As MySqlDataReader
    Private sqlQuery As String

    Private server As String = "localhost"
    Private username As String = "root"
    Private password As String = ""
    Private database As String = "perpustakaan"

    Public Function GetDataKoleksiDatabase() As DataTable
        Dim result As New DataTable

        dbConn.ConnectionString = "server =" + server + ";" + "user id=" + username + ";" _
            + "password=" + password + ";" + "database =" + database
        dbConn.Open()
        sqlCommand.Connection = dbConn
        sqlCommand.CommandText = "SELECT id_koleksi AS 'ID',
                                  nama_koleksi AS 'Nama Koleksi',
                                  jenis_koleksi AS 'Jenis Koleksi',
                                  penerbit AS 'Penerbit',
                                  tahun_terbit AS 'Tahun Terbit',
                                  tanggal_masuk_koleksi AS 'Tanggal Masuk',
                                  lokasi AS 'Lokasi Rak',
                                  stock AS 'Stock',
                                  bahasa AS 'Bahasa'
                                  FROM koleksi"

        sqlRead = sqlCommand.ExecuteReader

        result.Load(sqlRead)
        sqlRead.Close()
        dbConn.Close()
        Return result

    End Function

    Public Function AddDataKoleksiDatabase(dir_gambar As String,
                                           nama_koleksi As String,
                                           jenis_koleksi As String,
                                           penerbit_koleksi As String,
                                           deskripsi_koleksi As String,
                                           tahun_terbit As String,
                                           lokasi_rak As String,
                                           tanggal_masuk As Date,
                                           stock_koleksi As Integer,
                                           bahasa_koleksi As String,
                                           kategori_koleksi As String)

        dbConn.ConnectionString = "server =" + server + ";" + "user id=" + username + ";" + "password=" + password + ";" + "database =" + database

        Try
            dbConn.Open()
            sqlCommand.Connection = dbConn
            sqlQuery = "INSERT INTO KOLEKSI(nama_koleksi, dir_gambar,
                        deskripsi,penerbit,jenis_koleksi,tahun_terbit,
                        lokasi,tanggal_masuk_koleksi,stock,bahasa,kategori) VALUE('" _
                    & nama_koleksi & " ', '" _
                    & dir_gambar & "', '" _
                    & deskripsi_koleksi & "', '" _
                    & penerbit_koleksi & "', '" _
                    & jenis_koleksi & "', '" _
                    & tahun_terbit & "', '" _
                    & lokasi_rak & "', '" _
                    & tanggal_masuk.ToString("yyyy/MM/dd") & "', '" _
                    & stock_koleksi & "', '" _
                    & bahasa_koleksi & "', '" _
                    & kategori_koleksi & "')"

            sqlCommand = New MySqlCommand(sqlQuery, dbConn)
            sqlRead = sqlCommand.ExecuteReader
            dbConn.Close()

            'Perpustakaan.sqlDt.Load(sqlRead)
            sqlRead.Close()
            dbConn.Close()


        Catch ex As Exception
            Return ex.Message
        Finally
            dbConn.Dispose()
        End Try

    End Function


    Public Function GetDataKoleksiByIDDatabase(ID As Integer) As List(Of String)
        Dim result As New List(Of String)

        dbConn.ConnectionString = "server = " + server + ";" + "user id= " + username + ";" _
        + "password = " + password + ";" + "database = " + database
        dbConn.Open()
        sqlCommand.Connection = dbConn
        sqlCommand.CommandText = "SELECT id_koleksi,
                                   nama_koleksi,
                                   dir_gambar,
                                   deskripsi,
                                   penerbit,
                                   jenis_koleksi,
                                   tahun_terbit,
                                   lokasi,  
                                   tanggal_masuk_koleksi,
                                   stock,
                                   bahasa,
                                   kategori
                                   FROM koleksi 
                                   WHERE id_koleksi = '" & ID & " ' "

        sqlRead = sqlCommand.ExecuteReader

        While sqlRead.Read
            result.Add(sqlRead.GetString(0).ToString())
            result.Add(sqlRead.GetString(1).ToString())
            result.Add(sqlRead.GetString(2).ToString())
            result.Add(sqlRead.GetString(3).ToString())
            result.Add(sqlRead.GetString(4).ToString())
            result.Add(sqlRead.GetString(5).ToString())
            result.Add(sqlRead.GetString(6).ToString())
            result.Add(sqlRead.GetString(7).ToString())
            result.Add(sqlRead.GetString(8).ToString())
            result.Add(sqlRead.GetString(9).ToString())
            result.Add(sqlRead.GetString(10).ToString())
            result.Add(sqlRead.GetString(11).ToString())
        End While

        sqlRead.Close()
        dbConn.Close()
        Return result

    End Function

    Public Function UpdateDataKoleksiByIDDatabase(ID As Integer,
                                                  dir_gambar As String,
                                                  nama_koleksi As String,
                                                  jenis_koleksi As String,
                                                  penerbit_koleksi As String,
                                                  deskripsi_koleksi As String,
                                                  tahun_terbit As String,
                                                  lokasi_rak As String,
                                                  tanggal_masuk As String,
                                                  stock_koleksi As Integer,
                                                  bahasa_koleksi As String,
                                                  kategori_koleksi As String)
        tahun_terbit = tahun_terbit.ToString()
        dbConn.ConnectionString = "server = " + server + ";" + "user id= " + username + ";" _
        + "password = " + password + ";" + "database = " + database

        Try
            dbConn.Open()
            sqlCommand.Connection = dbConn
            sqlQuery = "UPDATE KOLEKSI SET " &
                    "nama_koleksi= '" & nama_koleksi & " ', '" &
                    "dir_gambar= '" & dir_gambar & "', '" &
                    "deskripsi= '" & deskripsi_koleksi & "', '" &
                    "penerbit= '" & penerbit_koleksi & "', '" &
                    "jenis_koleksi= '" & jenis_koleksi & "', '" &
                    "tahun_terbit= '" & tahun_terbit & "', '" &
                    "lokasi= '" & lokasi_rak & "', '" &
                    "tanggal_masuk_koleksi= '" & tanggal_masuk & "', '" &
                    "stock= '" & stock_koleksi & "', '" &
                    "bahasa= '" & bahasa_koleksi & "', '" &
                    "kategori= '" & kategori_koleksi & "' " &
                    "WHERE id_koleksi='" & ID & "'"

            sqlCommand = New MySqlCommand(sqlQuery, dbConn)
            sqlRead = sqlCommand.ExecuteReader
            dbConn.Close()

            'Perpustakaan.sqlDt.Load(sqlRead)
            sqlRead.Close()
            dbConn.Close()


        Catch ex As Exception
            Return ex.Message
        Finally
            dbConn.Dispose()

        End Try
    End Function

    'Sebelum Menggunakan DataBase
    Public Function AddKoleksiDataTable(Nama_Koleksi As String, Jenis_Koleksi As String, Deskripsi As String, Penerbit As String, Tahun_Terbit As String, Lokasi_Rak As String, tanggal_masuk As String, Stock As String, Bahasa As String, Kategori As String, Foto As String)

        koleksiDataTable.Add({Nama_Koleksi, Jenis_Koleksi, Deskripsi, Penerbit, Tahun_Terbit, Lokasi_Rak, tanggal_masuk, Stock, Bahasa, Kategori, Foto})

    End Function

    Public Function RemoveKoleksiDataTable(index As Integer)
        koleksiDataTable.RemoveAt(index)
    End Function

    Public Function DeleteDataKoleksiByIdDatabase(ID As Integer)

        dbConn.ConnectionString = "server = " + server + ";" + "user id = " + username + ";" + "password= " + password + ";" + "database=" + database

        Try
            dbConn.Open()
            sqlCommand.Connection = dbConn
            sqlQuery = "DELETE FROM Koleksi WHERE id_koleksi='" & ID.ToString & "'"

            Debug.WriteLine(sqlQuery)

            sqlCommand = New MySqlCommand(sqlQuery, dbConn)
            sqlRead = sqlCommand.ExecuteReader

            sqlRead.Close()
            dbConn.Close()
        Catch ex As Exception
            Return ex.Message
        End Try
        dbConn.Dispose()
    End Function

    Public ReadOnly Property getKoleksiDataTable() As ArrayList
        Get
            Return koleksiDataTable
        End Get
    End Property

    Public Function ConvertKoleksiToString(vals As List(Of String))
        Dim builder As StringBuilder = New StringBuilder()

        For Each val As String In vals
            builder.Append(val).Append("|")
        Next

        'convert to string

        Dim res = builder.ToString()
        Return res
    End Function

    Public Function ConvertStringToKoleksi(value As String)
        Dim arr() As String = value.Split("|")

        'Convert To list
        Dim vals As List(Of String) = arr.ToList()
        Return vals
    End Function




    Public Property GSNamaKoleksi() As String
        Get
            Return Nama_Koleksi
        End Get
        Set(value As String)
            Nama_Koleksi = value
        End Set
    End Property

    Public Property GSJenisKoleksi() As String
        Get
            Return Jenis_Koleksi
        End Get
        Set(value As String)
            Jenis_Koleksi = value
        End Set
    End Property
    Public Property GSDeskripsi() As String
        Get
            Return Deskripsi
        End Get
        Set(value As String)
            Deskripsi = value
        End Set
    End Property
    Public Property GSPenerbit() As String
        Get
            Return Penerbit
        End Get
        Set(value As String)
            Penerbit = value
        End Set
    End Property
    Public Property GSTahunTerbit() As String
        Get
            Return Tahun_Terbit
        End Get
        Set(value As String)
            Tahun_Terbit = value
        End Set
    End Property
    Public Property GSLokasiRak() As String
        Get
            Return Lokasi_Rak
        End Get
        Set(value As String)
            Lokasi_Rak = value
        End Set
    End Property

    Public Property GSDateMasuk() As String
        Get
            Return tanggal_masuk
        End Get
        Set(value As String)
            tanggal_masuk = value
        End Set
    End Property

    Public Property GSStock() As String
        Get
            Return Stock
        End Get
        Set(value As String)
            Stock = value
        End Set
    End Property

    Public Property GSBahasa() As String
        Get
            Return Bahasa
        End Get
        Set(value As String)
            Bahasa = value
        End Set
    End Property

    Public Property GSKategori() As List(Of String)
        Get
            Return Kategori
        End Get
        Set(value As List(Of String))
            Kategori = value
        End Set
    End Property
    Public Property GSFoto() As String
        Get
            Return Foto
        End Get
        Set(value As String)
            Foto = value
        End Set
    End Property








End Class
