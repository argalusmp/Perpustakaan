<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HapusKoleksi
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LblConsole = New System.Windows.Forms.Label()
        Me.BtnDelete = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(255, 57)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(206, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Apakah Ingin Menghapus Koleksi"
        '
        'LblConsole
        '
        Me.LblConsole.AutoSize = True
        Me.LblConsole.Location = New System.Drawing.Point(323, 152)
        Me.LblConsole.Name = "LblConsole"
        Me.LblConsole.Size = New System.Drawing.Size(48, 16)
        Me.LblConsole.TabIndex = 1
        Me.LblConsole.Text = "Label2"
        '
        'BtnDelete
        '
        Me.BtnDelete.Location = New System.Drawing.Point(273, 278)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(160, 44)
        Me.BtnDelete.TabIndex = 2
        Me.BtnDelete.Text = "kamu nanyaaa??"
        Me.BtnDelete.UseVisualStyleBackColor = True
        '
        'HapusKoleksi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.BtnDelete)
        Me.Controls.Add(Me.LblConsole)
        Me.Controls.Add(Me.Label1)
        Me.Name = "HapusKoleksi"
        Me.Text = "HapusKoleksi"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents LblConsole As Label
    Friend WithEvents BtnDelete As Button
End Class
