Public Class HapusKoleksi




    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub HapusKoleksi_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub LblConsole_Click(sender As Object, e As EventArgs) Handles LblConsole.Click
    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        'perpustakaan.ListBoxPerpustakaan.Items.RemoveAt(perpustakaan.ListBoxPerpustakaan.SelectedIndex)
        perpustakaan.data_perpus.DeleteDataKoleksiByIdDatabase(perpustakaan.selectedtableKoleksi)
        Me.Close()
    End Sub
End Class