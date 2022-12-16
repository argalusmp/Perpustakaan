<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UpdateKoleksi
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.DateMasukKoleksi = New System.Windows.Forms.DateTimePicker()
        Me.PictureBox = New System.Windows.Forms.PictureBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.CheckBoxBudaya = New System.Windows.Forms.CheckBox()
        Me.CheckBoxTeknologi = New System.Windows.Forms.CheckBox()
        Me.CheckBoxSosial = New System.Windows.Forms.CheckBox()
        Me.CheckBoxSains = New System.Windows.Forms.CheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RdButtonEnglish = New System.Windows.Forms.RadioButton()
        Me.RdButtonIndo = New System.Windows.Forms.RadioButton()
        Me.RTBoxDeskripsi = New System.Windows.Forms.RichTextBox()
        Me.CBJenisKoleksi = New System.Windows.Forms.ComboBox()
        Me.TxtStock = New System.Windows.Forms.TextBox()
        Me.TxtLokasiRak = New System.Windows.Forms.TextBox()
        Me.TxtTahunTerbit = New System.Windows.Forms.TextBox()
        Me.TxtPenerbit = New System.Windows.Forms.TextBox()
        Me.BtnTambahGambar = New System.Windows.Forms.Button()
        Me.BtnTambahKoleksi = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtNamaKoleksi = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        CType(Me.PictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DateMasukKoleksi
        '
        Me.DateMasukKoleksi.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateMasukKoleksi.Location = New System.Drawing.Point(444, 230)
        Me.DateMasukKoleksi.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DateMasukKoleksi.Name = "DateMasukKoleksi"
        Me.DateMasukKoleksi.Size = New System.Drawing.Size(167, 22)
        Me.DateMasukKoleksi.TabIndex = 45
        '
        'PictureBox
        '
        Me.PictureBox.Location = New System.Drawing.Point(37, 14)
        Me.PictureBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox.Name = "PictureBox"
        Me.PictureBox.Size = New System.Drawing.Size(136, 153)
        Me.PictureBox.TabIndex = 44
        Me.PictureBox.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.CheckBoxBudaya)
        Me.GroupBox2.Controls.Add(Me.CheckBoxTeknologi)
        Me.GroupBox2.Controls.Add(Me.CheckBoxSosial)
        Me.GroupBox2.Controls.Add(Me.CheckBoxSains)
        Me.GroupBox2.Location = New System.Drawing.Point(444, 385)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox2.Size = New System.Drawing.Size(165, 121)
        Me.GroupBox2.TabIndex = 43
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "GroupBox2"
        '
        'CheckBoxBudaya
        '
        Me.CheckBoxBudaya.AutoSize = True
        Me.CheckBoxBudaya.Location = New System.Drawing.Point(5, 95)
        Me.CheckBoxBudaya.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CheckBoxBudaya.Name = "CheckBoxBudaya"
        Me.CheckBoxBudaya.Size = New System.Drawing.Size(76, 20)
        Me.CheckBoxBudaya.TabIndex = 3
        Me.CheckBoxBudaya.Text = "Budaya"
        Me.CheckBoxBudaya.UseVisualStyleBackColor = True
        '
        'CheckBoxTeknologi
        '
        Me.CheckBoxTeknologi.AutoSize = True
        Me.CheckBoxTeknologi.Location = New System.Drawing.Point(5, 73)
        Me.CheckBoxTeknologi.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CheckBoxTeknologi.Name = "CheckBoxTeknologi"
        Me.CheckBoxTeknologi.Size = New System.Drawing.Size(90, 20)
        Me.CheckBoxTeknologi.TabIndex = 2
        Me.CheckBoxTeknologi.Text = "Teknologi"
        Me.CheckBoxTeknologi.UseVisualStyleBackColor = True
        '
        'CheckBoxSosial
        '
        Me.CheckBoxSosial.AutoSize = True
        Me.CheckBoxSosial.Location = New System.Drawing.Point(5, 47)
        Me.CheckBoxSosial.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CheckBoxSosial.Name = "CheckBoxSosial"
        Me.CheckBoxSosial.Size = New System.Drawing.Size(67, 20)
        Me.CheckBoxSosial.TabIndex = 1
        Me.CheckBoxSosial.Text = "Sosial"
        Me.CheckBoxSosial.UseVisualStyleBackColor = True
        '
        'CheckBoxSains
        '
        Me.CheckBoxSains.AutoSize = True
        Me.CheckBoxSains.Location = New System.Drawing.Point(5, 21)
        Me.CheckBoxSains.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CheckBoxSains.Name = "CheckBoxSains"
        Me.CheckBoxSains.Size = New System.Drawing.Size(63, 20)
        Me.CheckBoxSains.TabIndex = 0
        Me.CheckBoxSains.Text = "Sains"
        Me.CheckBoxSains.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RdButtonEnglish)
        Me.GroupBox1.Controls.Add(Me.RdButtonIndo)
        Me.GroupBox1.Location = New System.Drawing.Point(444, 294)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Size = New System.Drawing.Size(165, 76)
        Me.GroupBox1.TabIndex = 42
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Bahasa"
        '
        'RdButtonEnglish
        '
        Me.RdButtonEnglish.AutoSize = True
        Me.RdButtonEnglish.Location = New System.Drawing.Point(7, 48)
        Me.RdButtonEnglish.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.RdButtonEnglish.Name = "RdButtonEnglish"
        Me.RdButtonEnglish.Size = New System.Drawing.Size(118, 20)
        Me.RdButtonEnglish.TabIndex = 1
        Me.RdButtonEnglish.TabStop = True
        Me.RdButtonEnglish.Text = "Bahasa Inggris"
        Me.RdButtonEnglish.UseVisualStyleBackColor = True
        '
        'RdButtonIndo
        '
        Me.RdButtonIndo.AutoSize = True
        Me.RdButtonIndo.Location = New System.Drawing.Point(5, 22)
        Me.RdButtonIndo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.RdButtonIndo.Name = "RdButtonIndo"
        Me.RdButtonIndo.Size = New System.Drawing.Size(137, 20)
        Me.RdButtonIndo.TabIndex = 0
        Me.RdButtonIndo.TabStop = True
        Me.RdButtonIndo.Text = "Bahasa Indonesia"
        Me.RdButtonIndo.UseVisualStyleBackColor = True
        '
        'RTBoxDeskripsi
        '
        Me.RTBoxDeskripsi.Location = New System.Drawing.Point(444, 74)
        Me.RTBoxDeskripsi.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.RTBoxDeskripsi.Name = "RTBoxDeskripsi"
        Me.RTBoxDeskripsi.Size = New System.Drawing.Size(167, 66)
        Me.RTBoxDeskripsi.TabIndex = 41
        Me.RTBoxDeskripsi.Text = ""
        '
        'CBJenisKoleksi
        '
        Me.CBJenisKoleksi.FormattingEnabled = True
        Me.CBJenisKoleksi.Items.AddRange(New Object() {"Buku", "Ensiklopedia", "Koran", "Majalah", "Publikasi", "Penelitian"})
        Me.CBJenisKoleksi.Location = New System.Drawing.Point(444, 38)
        Me.CBJenisKoleksi.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CBJenisKoleksi.Name = "CBJenisKoleksi"
        Me.CBJenisKoleksi.Size = New System.Drawing.Size(167, 24)
        Me.CBJenisKoleksi.TabIndex = 40
        '
        'TxtStock
        '
        Me.TxtStock.Location = New System.Drawing.Point(444, 258)
        Me.TxtStock.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtStock.Name = "TxtStock"
        Me.TxtStock.Size = New System.Drawing.Size(167, 22)
        Me.TxtStock.TabIndex = 39
        '
        'TxtLokasiRak
        '
        Me.TxtLokasiRak.Location = New System.Drawing.Point(444, 199)
        Me.TxtLokasiRak.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtLokasiRak.Name = "TxtLokasiRak"
        Me.TxtLokasiRak.Size = New System.Drawing.Size(167, 22)
        Me.TxtLokasiRak.TabIndex = 38
        '
        'TxtTahunTerbit
        '
        Me.TxtTahunTerbit.Location = New System.Drawing.Point(444, 170)
        Me.TxtTahunTerbit.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtTahunTerbit.Name = "TxtTahunTerbit"
        Me.TxtTahunTerbit.Size = New System.Drawing.Size(167, 22)
        Me.TxtTahunTerbit.TabIndex = 37
        '
        'TxtPenerbit
        '
        Me.TxtPenerbit.Location = New System.Drawing.Point(444, 146)
        Me.TxtPenerbit.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtPenerbit.Name = "TxtPenerbit"
        Me.TxtPenerbit.Size = New System.Drawing.Size(167, 22)
        Me.TxtPenerbit.TabIndex = 36
        '
        'BtnTambahGambar
        '
        Me.BtnTambahGambar.Location = New System.Drawing.Point(37, 180)
        Me.BtnTambahGambar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnTambahGambar.Name = "BtnTambahGambar"
        Me.BtnTambahGambar.Size = New System.Drawing.Size(136, 23)
        Me.BtnTambahGambar.TabIndex = 35
        Me.BtnTambahGambar.Text = "Tambah Gambar"
        Me.BtnTambahGambar.UseVisualStyleBackColor = True
        '
        'BtnTambahKoleksi
        '
        Me.BtnTambahKoleksi.Location = New System.Drawing.Point(351, 523)
        Me.BtnTambahKoleksi.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnTambahKoleksi.Name = "BtnTambahKoleksi"
        Me.BtnTambahKoleksi.Size = New System.Drawing.Size(136, 23)
        Me.BtnTambahKoleksi.TabIndex = 34
        Me.BtnTambahKoleksi.Text = "Update Koleksi"
        Me.BtnTambahKoleksi.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(251, 385)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(57, 16)
        Me.Label10.TabIndex = 33
        Me.Label10.Text = "Kategori"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(251, 294)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(54, 16)
        Me.Label9.TabIndex = 32
        Me.Label9.Text = "Bahasa"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(251, 263)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(41, 16)
        Me.Label8.TabIndex = 31
        Me.Label8.Text = "Stock"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(251, 235)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(148, 16)
        Me.Label7.TabIndex = 30
        Me.Label7.Text = "Tanggal Masuk Koleksi"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(251, 206)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(75, 16)
        Me.Label6.TabIndex = 29
        Me.Label6.Text = "Lokasi Rak"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(251, 176)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(83, 16)
        Me.Label5.TabIndex = 28
        Me.Label5.Text = "Tahun Terbit"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(251, 149)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 16)
        Me.Label4.TabIndex = 27
        Me.Label4.Text = "Penerbit"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(251, 74)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 16)
        Me.Label3.TabIndex = 26
        Me.Label3.Text = "Deskripsi"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(251, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 16)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "Jenis Koleksi"
        '
        'TxtNamaKoleksi
        '
        Me.TxtNamaKoleksi.Location = New System.Drawing.Point(442, 8)
        Me.TxtNamaKoleksi.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtNamaKoleksi.Name = "TxtNamaKoleksi"
        Me.TxtNamaKoleksi.Size = New System.Drawing.Size(167, 22)
        Me.TxtNamaKoleksi.TabIndex = 47
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(251, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 16)
        Me.Label1.TabIndex = 46
        Me.Label1.Text = "Nama Koleksi"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'UpdateKoleksi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(868, 554)
        Me.Controls.Add(Me.TxtNamaKoleksi)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DateMasukKoleksi)
        Me.Controls.Add(Me.PictureBox)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.RTBoxDeskripsi)
        Me.Controls.Add(Me.CBJenisKoleksi)
        Me.Controls.Add(Me.TxtStock)
        Me.Controls.Add(Me.TxtLokasiRak)
        Me.Controls.Add(Me.TxtTahunTerbit)
        Me.Controls.Add(Me.TxtPenerbit)
        Me.Controls.Add(Me.BtnTambahGambar)
        Me.Controls.Add(Me.BtnTambahKoleksi)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "UpdateKoleksi"
        Me.Text = "UpdateKoleksi"
        CType(Me.PictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DateMasukKoleksi As DateTimePicker
    Friend WithEvents PictureBox As PictureBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents CheckBoxBudaya As CheckBox
    Friend WithEvents CheckBoxTeknologi As CheckBox
    Friend WithEvents CheckBoxSosial As CheckBox
    Friend WithEvents CheckBoxSains As CheckBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents RdButtonEnglish As RadioButton
    Friend WithEvents RdButtonIndo As RadioButton
    Friend WithEvents RTBoxDeskripsi As RichTextBox
    Friend WithEvents CBJenisKoleksi As ComboBox
    Friend WithEvents TxtStock As TextBox
    Friend WithEvents TxtLokasiRak As TextBox
    Friend WithEvents TxtTahunTerbit As TextBox
    Friend WithEvents TxtPenerbit As TextBox
    Friend WithEvents BtnTambahGambar As Button
    Friend WithEvents BtnTambahKoleksi As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtNamaKoleksi As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
End Class
