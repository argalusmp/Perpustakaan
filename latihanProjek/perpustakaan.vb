Public Class perpustakaan

    Public Shared selected_buku As String
    Public Shared data_perpus As DataPerpus
    Public Shared selectedtableKoleksi
    Public Shared selectedtableKoleksiNama

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        data_perpus = New DataPerpus
        UpdateDataTableArrayList()
        ReloadDataTableDatabase()

    End Sub

    Private Sub ReloadDataTableDatabase()
        DataGridKoleksi.DataSource = data_perpus.GetDataKoleksiDatabase()
    End Sub

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click
        Dim tambah_koleksi = New TambahKoleksi()
        tambah_koleksi.Show()
    End Sub

    Private Sub BtnRemove_Click(sender As Object, e As EventArgs) Handles BtnRemove.Click

        selected_buku = ListBoxPerpustakaan.SelectedItem

        If selected_buku!= "" Then
            MessageBox.Show("Pilih Koleksi yang ingin dihapus")

        Else
            HapusKoleksi.Show()
            HapusKoleksi.LblConsole.Text = selected_buku
        End If
    End Sub

    Private Sub ListBoxPerpustakaan_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBoxPerpustakaan.SelectedIndexChanged

    End Sub

    Private Sub perpustakaan_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


    Public Sub UpdateDataTableArrayList()
        'DataGridKoleksi.Rows.Clear()
        For Each rowKoleksi In data_perpus.getKoleksiDataTable()
            Dim dataTable As String() = {
                rowKoleksi(0),
                rowKoleksi(1),
                rowKoleksi(2),
                rowKoleksi(3),
                rowKoleksi(4),
                rowKoleksi(5),
                rowKoleksi(6),
                rowKoleksi(7),
                rowKoleksi(8),
                rowKoleksi(9)}
            DataGridKoleksi.Rows.Add(dataTable)
        Next
    End Sub


    Private Sub perpustakaan_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        UpdateDataTableArrayList()
        ReloadDataTableDatabase()
    End Sub

    Private Sub DataGridKoleksi_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridKoleksi.CellClick
        'selectedTableKoleksi = DataGrid.CurrentRow.Index
        Dim index As Integer = e.RowIndex
        Dim selectedRow As DataGridViewRow
        selectedRow = DataGridKoleksi.Rows(index)

        selectedtableKoleksi = selectedRow.Cells(0).Value
        selectedtableKoleksiNama = selectedRow.Cells(1).Value
    End Sub

    Private Sub BtnUpdate_Click(sender As Object, e As EventArgs) Handles BtnUpdate.Click
        Dim selectedKoleksi As List(Of String) = data_perpus.GetDataKoleksiByIDDatabase(selectedtableKoleksi)


        data_perpus.GSNamaKoleksi = selectedKoleksi(1)
        data_perpus.GSFoto = selectedKoleksi(2)
        data_perpus.GSJenisKoleksi = selectedKoleksi(5)
        data_perpus.GSDeskripsi = selectedKoleksi(3)
        data_perpus.GSPenerbit = selectedKoleksi(4)
        data_perpus.GSTahunTerbit = selectedKoleksi(6)
        data_perpus.GSLokasiRak = selectedKoleksi(7)
        data_perpus.GSDateMasuk = selectedKoleksi(8)
        data_perpus.GSStock = selectedKoleksi(9)
        data_perpus.GSBahasa = selectedKoleksi(10)
        Dim data_kategori As List(Of String) = data_perpus.ConvertStringToKoleksi(selectedKoleksi(11))
        ' For Each info_kategori In data_kategori
        'data_perpus.GSKategori(info_kategori)
        'Next

        Dim formUpdate = New UpdateKoleksi()
        formUpdate.Show()
    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        Dim formHapus = New HapusKoleksi
        formHapus.Show()
    End Sub

    Private Sub BtnSelect_Click(sender As Object, e As EventArgs) Handles BtnSelect.Click
        Dim dataSelected = data_perpus.GetDataKoleksiByIDDatabase(selectedtableKoleksi)

        data_perpus.GSFoto = dataSelected(2)
        data_perpus.GSNamaKoleksi = dataSelected(1)
        data_perpus.GSJenisKoleksi = dataSelected(5)
        data_perpus.GSDeskripsi = dataSelected(3)
        data_perpus.GSPenerbit = dataSelected(4)
        data_perpus.GSTahunTerbit = dataSelected(6)
        data_perpus.GSLokasiRak = dataSelected(7)
        data_perpus.GSDateMasuk = dataSelected(8)
        data_perpus.GSStock = dataSelected(9)
        data_perpus.GSBahasa = dataSelected(10)

        Dim dataKoleksi As List(Of String) = data_perpus.ConvertStringToKoleksi(dataSelected(11))
        data_perpus.GSKategori = dataKoleksi

        Dim FormAddedKoleksi = New InfoTambahKoleksi()
        FormAddedKoleksi.Show()
    End Sub
End Class