Public Class InfoTambahKoleksi

    Dim nama As String


    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        If Not String.IsNullOrEmpty(perpustakaan.data_perpus.GSFoto) Then
            PicBox.Load(perpustakaan.data_perpus.GSFoto)
            PicBox.SizeMode = PictureBoxSizeMode.StretchImage
        End If

        LblNamaKoleksi.Text = perpustakaan.data_perpus.GSNamaKoleksi
        LblTerbit.Text = perpustakaan.data_perpus.GSTahunTerbit
        LblJenisKoleksi.Text = perpustakaan.data_perpus.GSJenisKoleksi
        LblBahasa.Text = perpustakaan.data_perpus.GSBahasa
        LblDateKoleksi.Text = perpustakaan.data_perpus.GSDateMasuk
        LblDeskripsi.Text = perpustakaan.data_perpus.GSDeskripsi
        LblLokasiRak.Text = perpustakaan.data_perpus.GSLokasiRak
        LblPenerbit.Text = perpustakaan.data_perpus.GSPenerbit
        LblStock.Text = perpustakaan.data_perpus.GSStock
        For Each kategori In perpustakaan.data_perpus.GSKategori
            ListBoxKategori.Items.Add(kategori)
        Next

        perpustakaan.data_perpus.GSKategori.Clear()


    End Sub


    Private Sub InfoTambahKoleksi_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub
End Class