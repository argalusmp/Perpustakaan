Public Class UpdateKoleksi

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        'ComboBoxJenisKoleksi.DataSource = jenis
        'Dim dataPerpus = New perpustakaan

        PictureBox.Load(perpustakaan.data_perpus.GSFoto)
        PictureBox.SizeMode = PictureBoxSizeMode.StretchImage

        DateMasukKoleksi.Format = DateTimePickerFormat.Custom
        DateMasukKoleksi.CustomFormat = "yyyy/MM/dd"
        DateMasukKoleksi.Value = perpustakaan.data_perpus.GSDateMasuk
        TxtNamaKoleksi.Text = perpustakaan.data_perpus.GSNamaKoleksi
        CBJenisKoleksi.SelectedItem() = perpustakaan.data_perpus.GSJenisKoleksi
        RTBoxDeskripsi.Text = perpustakaan.data_perpus.GSDeskripsi
        TxtPenerbit.Text = perpustakaan.data_perpus.GSPenerbit
        TxtLokasiRak.Text = perpustakaan.data_perpus.GSLokasiRak
        TxtStock.Text = perpustakaan.data_perpus.GSStock

        If String.Compare(perpustakaan.data_perpus.GSBahasa, "Indonesia") Then
            RdButtonIndo.Checked = True
        End If
        If String.Compare(perpustakaan.data_perpus.GSBahasa, "Inggris") Then
            RdButtonEnglish.Checked = True
        End If

        For Each kategori In perpustakaan.data_perpus.GSKategori
            If String.Compare(kategori, "Sains") Then
                CheckBoxSains.Checked = True
            ElseIf String.Compare(kategori, "Sosial") Then
                CheckBoxSosial.Checked = True
            ElseIf String.Compare(kategori, "Teknologi") Then
                CheckBoxTeknologi.Checked = True
            ElseIf String.Compare(kategori, "Budaya") Then
                CheckBoxBudaya.Checked = True
            End If
        Next

        perpustakaan.data_perpus.GSKategori.Clear()
    End Sub

    Private Sub BtnTambahKoleksi_Click(sender As Object, e As EventArgs) Handles BtnTambahKoleksi.Click
        perpustakaan.data_perpus.GSNamaKoleksi = TxtNamaKoleksi.Text
        perpustakaan.data_perpus.GSJenisKoleksi = CBJenisKoleksi.SelectedItem
        perpustakaan.data_perpus.GSDeskripsi = RTBoxDeskripsi.Text
        perpustakaan.data_perpus.GSPenerbit = TxtPenerbit.Text
        perpustakaan.data_perpus.GSTahunTerbit = TxtTahunTerbit.Text
        perpustakaan.data_perpus.GSLokasiRak = TxtLokasiRak.Text
        perpustakaan.data_perpus.GSDateMasuk = DateMasukKoleksi.Value
        perpustakaan.data_perpus.GSStock = TxtStock.Text

        If RdButtonEnglish.Checked Then
            perpustakaan.data_perpus.GSBahasa = "Bahasa Inggris"
        ElseIf RdButtonIndo.Checked Then
            perpustakaan.data_perpus.GSBahasa = "Bahasa Indonesia"
        End If

        Dim kategori = New List(Of String)
        If CheckBoxBudaya.Checked() Then
            kategori.Add("Budaya")
        End If
        If CheckBoxSosial.Checked() Then
            kategori.Add("Sosial")
        End If
        If CheckBoxTeknologi.Checked() Then
            kategori.Add("Teknologi")
        End If
        If CheckBoxSains.Checked() Then
            kategori.Add("Sains")
        End If

        perpustakaan.data_perpus.GSKategori = kategori

        Dim convertedKoleksi = perpustakaan.data_perpus.ConvertKoleksiToString(perpustakaan.data_perpus.GSKategori)

        perpustakaan.data_perpus.UpdateDataKoleksiByIDDatabase(
                                                    perpustakaan.selectedtableKoleksi,
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

        Dim infoTambah = New InfoTambahKoleksi()
        Me.Close()
        infoTambah.Show()

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
End Class