Public Class TambahKoleksi

    Private nama_koleksi As String
    Private foto
    Private kategori_arrlist As New List(Of String)
    'Public Shared data_perpus As DataPerpus

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        'data_perpus = New DataPerpus()

        DateMasukKoleksi.Format = DateTimePickerFormat.Custom
        DateMasukKoleksi.CustomFormat = "yyyy/MM/dd"


    End Sub



    Private Sub Label2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub RichTextBox1_TextChanged(sender As Object, e As EventArgs) Handles RTBoxDeskripsi.TextChanged

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxSains.CheckedChanged

    End Sub

    Private Sub BtnTambahKoleksi_Click(sender As Object, e As EventArgs) Handles BtnTambahKoleksi.Click
        perpustakaan.data_perpus.GSNamaKoleksi = TxtNamaKoleksi.Text
        perpustakaan.data_perpus.GSJenisKoleksi = CBJenisKoleksi.Text
        perpustakaan.data_perpus.GSDeskripsi = RTBoxDeskripsi.Text
        perpustakaan.data_perpus.GSPenerbit = TxtPenerbit.Text
        perpustakaan.data_perpus.GSTahunTerbit = TxtTahunTerbit.Text
        perpustakaan.data_perpus.GSLokasiRak = TxtLokasiRak.Text
        perpustakaan.data_perpus.GSDateMasuk = DateMasukKoleksi.Value.ToString("dd/MM/yyyy")
        perpustakaan.data_perpus.GSStock = TxtStock.Text

        If RdButtonIndo.Checked Then
            perpustakaan.data_perpus.GSBahasa = "Bahasa Indonesia"
        End If
        If RdButtonEnglish.Checked Then
            perpustakaan.data_perpus.GSBahasa = "Bahasa Inggris"
        End If


        If CheckBoxSains.Checked() Then
            kategori_arrlist.Add("Sains, ")
        End If

        If CheckBoxSosial.Checked() Then
            kategori_arrlist.Add("Sosial, ")
        End If

        If CheckBoxBudaya.Checked() Then
            kategori_arrlist.Add("Budaya, ")
        End If
        If CheckBoxTeknologi.Checked() Then
            kategori_arrlist.Add("Teknologi, ")
        End If
        perpustakaan.data_perpus.GSKategori = kategori_arrlist

        perpustakaan.ListBoxPerpustakaan.Items.Add(perpustakaan.data_perpus.GSNamaKoleksi)


        Dim convertedKoleksi = perpustakaan.data_perpus.ConvertKoleksiToString(perpustakaan.data_perpus.GSKategori)
        perpustakaan.data_perpus.AddDataKoleksiDatabase(
            perpustakaan.data_perpus.GSFoto,
            perpustakaan.data_perpus.GSNamaKoleksi,
            perpustakaan.data_perpus.GSJenisKoleksi,
            perpustakaan.data_perpus.GSPenerbit,
            perpustakaan.data_perpus.GSDeskripsi,
            perpustakaan.data_perpus.GSTahunTerbit,
            perpustakaan.data_perpus.GSLokasiRak,
            perpustakaan.data_perpus.GSDateMasuk,
            perpustakaan.data_perpus.GSStock,
            perpustakaan.data_perpus.GSBahasa,
            convertedKoleksi
         )



        Dim info_koleksi = New InfoTambahKoleksi()
        info_koleksi.Show()
        Me.Hide()





    End Sub

    Private Sub BtnTambahGambar_Click(sender As Object, e As EventArgs) Handles BtnTambahGambar.Click
        OpenFileDialog1.Title = "Open Foto"
        OpenFileDialog1.Filter = "Image|*.bmp|Image JPG|*.jpg|Image JPEG|*.jpeg|Image PNG|*.png|Image GIF|*.gif|All Format|*.*"
        OpenFileDialog1.ShowDialog()

        Dim picKoleksiDir As String = OpenFileDialog1.FileName

        PictureBox.Load(picKoleksiDir)
        PictureBox.SizeMode = PictureBoxSizeMode.StretchImage
        'perpustakaan.data_perpus.GSFoto = OpenFileDialog1.FileName
        perpustakaan.data_perpus.GSFoto = picKoleksiDir.ToString()
        perpustakaan.data_perpus.GSFoto = perpustakaan.data_perpus.GSFoto.Replace("\", "/")
    End Sub

    Private Sub TambahKoleksi_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class