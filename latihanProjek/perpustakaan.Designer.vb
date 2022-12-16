<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class perpustakaan
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.KoleksiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TambahKoleksiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BtnAdd = New System.Windows.Forms.Button()
        Me.BtnRemove = New System.Windows.Forms.Button()
        Me.ListBoxPerpustakaan = New System.Windows.Forms.ListBox()
        Me.DataGridKoleksi = New System.Windows.Forms.DataGridView()
        Me.BtnUpdate = New System.Windows.Forms.Button()
        Me.BtnDelete = New System.Windows.Forms.Button()
        Me.BtnSelect = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.DataGridKoleksi, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.KoleksiToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(5, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(1604, 28)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'KoleksiToolStripMenuItem
        '
        Me.KoleksiToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TambahKoleksiToolStripMenuItem})
        Me.KoleksiToolStripMenuItem.Name = "KoleksiToolStripMenuItem"
        Me.KoleksiToolStripMenuItem.Size = New System.Drawing.Size(70, 24)
        Me.KoleksiToolStripMenuItem.Text = "Koleksi"
        '
        'TambahKoleksiToolStripMenuItem
        '
        Me.TambahKoleksiToolStripMenuItem.Name = "TambahKoleksiToolStripMenuItem"
        Me.TambahKoleksiToolStripMenuItem.Size = New System.Drawing.Size(195, 26)
        Me.TambahKoleksiToolStripMenuItem.Text = "Tambah Koleksi"
        '
        'BtnAdd
        '
        Me.BtnAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.BtnAdd.Location = New System.Drawing.Point(13, 32)
        Me.BtnAdd.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnAdd.Name = "BtnAdd"
        Me.BtnAdd.Size = New System.Drawing.Size(31, 30)
        Me.BtnAdd.TabIndex = 1
        Me.BtnAdd.Text = "+"
        Me.BtnAdd.UseVisualStyleBackColor = True
        '
        'BtnRemove
        '
        Me.BtnRemove.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.BtnRemove.Location = New System.Drawing.Point(51, 31)
        Me.BtnRemove.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnRemove.Name = "BtnRemove"
        Me.BtnRemove.Size = New System.Drawing.Size(31, 30)
        Me.BtnRemove.TabIndex = 2
        Me.BtnRemove.Text = "-"
        Me.BtnRemove.UseVisualStyleBackColor = True
        '
        'ListBoxPerpustakaan
        '
        Me.ListBoxPerpustakaan.FormattingEnabled = True
        Me.ListBoxPerpustakaan.ItemHeight = 16
        Me.ListBoxPerpustakaan.Location = New System.Drawing.Point(12, 68)
        Me.ListBoxPerpustakaan.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ListBoxPerpustakaan.Name = "ListBoxPerpustakaan"
        Me.ListBoxPerpustakaan.Size = New System.Drawing.Size(485, 356)
        Me.ListBoxPerpustakaan.TabIndex = 3
        '
        'DataGridKoleksi
        '
        Me.DataGridKoleksi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridKoleksi.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridKoleksi.BackgroundColor = System.Drawing.SystemColors.ButtonShadow
        Me.DataGridKoleksi.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DataGridKoleksi.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.DataGridKoleksi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridKoleksi.GridColor = System.Drawing.SystemColors.ControlText
        Me.DataGridKoleksi.Location = New System.Drawing.Point(520, 68)
        Me.DataGridKoleksi.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DataGridKoleksi.Name = "DataGridKoleksi"
        Me.DataGridKoleksi.RowHeadersWidth = 51
        Me.DataGridKoleksi.RowTemplate.Height = 24
        Me.DataGridKoleksi.Size = New System.Drawing.Size(1004, 342)
        Me.DataGridKoleksi.TabIndex = 4
        '
        'BtnUpdate
        '
        Me.BtnUpdate.Location = New System.Drawing.Point(541, 431)
        Me.BtnUpdate.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtnUpdate.Name = "BtnUpdate"
        Me.BtnUpdate.Size = New System.Drawing.Size(100, 28)
        Me.BtnUpdate.TabIndex = 5
        Me.BtnUpdate.Text = "Update"
        Me.BtnUpdate.UseVisualStyleBackColor = True
        '
        'BtnDelete
        '
        Me.BtnDelete.Location = New System.Drawing.Point(649, 431)
        Me.BtnDelete.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(100, 28)
        Me.BtnDelete.TabIndex = 6
        Me.BtnDelete.Text = "Remove"
        Me.BtnDelete.UseVisualStyleBackColor = True
        '
        'BtnSelect
        '
        Me.BtnSelect.Location = New System.Drawing.Point(757, 431)
        Me.BtnSelect.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnSelect.Name = "BtnSelect"
        Me.BtnSelect.Size = New System.Drawing.Size(100, 28)
        Me.BtnSelect.TabIndex = 7
        Me.BtnSelect.Text = "Select"
        Me.BtnSelect.UseVisualStyleBackColor = True
        '
        'perpustakaan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1604, 466)
        Me.Controls.Add(Me.BtnSelect)
        Me.Controls.Add(Me.BtnDelete)
        Me.Controls.Add(Me.BtnUpdate)
        Me.Controls.Add(Me.DataGridKoleksi)
        Me.Controls.Add(Me.ListBoxPerpustakaan)
        Me.Controls.Add(Me.BtnRemove)
        Me.Controls.Add(Me.BtnAdd)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "perpustakaan"
        Me.Text = "perpustakaan"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.DataGridKoleksi, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents KoleksiToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TambahKoleksiToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BtnAdd As Button
    Friend WithEvents BtnRemove As Button
    Friend WithEvents ListBoxPerpustakaan As ListBox
    Friend WithEvents DataGridKoleksi As DataGridView
    Friend WithEvents BtnUpdate As Button
    Friend WithEvents BtnDelete As Button
    Friend WithEvents BtnSelect As Button
End Class
