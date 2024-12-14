<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmChiTietPhieuXuat
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
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        lbNguoiLapPhieu = New Label()
        Label6 = New Label()
        lbTongSoTien = New Label()
        lbNgay = New Label()
        lbTen = New Label()
        lbMa = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        dgvChiTietPhieuXuat = New DataGridView()
        CType(dgvChiTietPhieuXuat, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lbNguoiLapPhieu
        ' 
        lbNguoiLapPhieu.Anchor = AnchorStyles.Bottom
        lbNguoiLapPhieu.AutoSize = True
        lbNguoiLapPhieu.Location = New Point(338, 413)
        lbNguoiLapPhieu.Name = "lbNguoiLapPhieu"
        lbNguoiLapPhieu.Size = New Size(117, 20)
        lbNguoiLapPhieu.TabIndex = 33
        lbNguoiLapPhieu.Text = "Người lập phiếu"
        ' 
        ' Label6
        ' 
        Label6.Anchor = AnchorStyles.Bottom
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(163))
        Label6.Location = New Point(340, 350)
        Label6.Name = "Label6"
        Label6.Size = New Size(121, 20)
        Label6.TabIndex = 32
        Label6.Text = "Người lập phiếu"
        ' 
        ' lbTongSoTien
        ' 
        lbTongSoTien.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        lbTongSoTien.AutoSize = True
        lbTongSoTien.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(163))
        lbTongSoTien.Location = New Point(685, 330)
        lbTongSoTien.Name = "lbTongSoTien"
        lbTongSoTien.Size = New Size(103, 20)
        lbTongSoTien.TabIndex = 31
        lbTongSoTien.Text = "TỔNG CỘNG:"
        lbTongSoTien.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lbNgay
        ' 
        lbNgay.AutoSize = True
        lbNgay.Location = New Point(152, 152)
        lbNgay.Name = "lbNgay"
        lbNgay.Size = New Size(44, 20)
        lbNgay.TabIndex = 30
        lbNgay.Text = "Ngày"
        ' 
        ' lbTen
        ' 
        lbTen.AutoSize = True
        lbTen.Location = New Point(152, 117)
        lbTen.Name = "lbTen"
        lbTen.Size = New Size(32, 20)
        lbTen.TabIndex = 29
        lbTen.Text = "Tên"
        ' 
        ' lbMa
        ' 
        lbMa.AutoSize = True
        lbMa.Location = New Point(152, 80)
        lbMa.Name = "lbMa"
        lbMa.Size = New Size(30, 20)
        lbMa.TabIndex = 28
        lbMa.Text = "Mã"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label4.Location = New Point(12, 152)
        Label4.Name = "Label4"
        Label4.Size = New Size(120, 20)
        Label4.TabIndex = 27
        Label4.Text = "Ngày tạo phiếu:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label3.Location = New Point(12, 117)
        Label3.Name = "Label3"
        Label3.Size = New Size(122, 20)
        Label3.TabIndex = 26
        Label3.Text = "Tên khách hàng:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label2.Location = New Point(12, 80)
        Label2.Name = "Label2"
        Label2.Size = New Size(113, 20)
        Label2.TabIndex = 25
        Label2.Text = "Mã phiếu xuất:"
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.Top
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(163))
        Label1.Location = New Point(278, 25)
        Label1.Margin = New Padding(3)
        Label1.Name = "Label1"
        Label1.Size = New Size(245, 31)
        Label1.TabIndex = 24
        Label1.Text = "CHI TIẾT PHIẾU XUẤT"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' dgvChiTietPhieuXuat
        ' 
        dgvChiTietPhieuXuat.AllowUserToOrderColumns = True
        dgvChiTietPhieuXuat.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        dgvChiTietPhieuXuat.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = SystemColors.Control
        DataGridViewCellStyle1.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(163))
        DataGridViewCellStyle1.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        dgvChiTietPhieuXuat.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        dgvChiTietPhieuXuat.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvChiTietPhieuXuat.Location = New Point(12, 187)
        dgvChiTietPhieuXuat.Name = "dgvChiTietPhieuXuat"
        dgvChiTietPhieuXuat.ReadOnly = True
        dgvChiTietPhieuXuat.RowHeadersWidth = 51
        dgvChiTietPhieuXuat.Size = New Size(776, 130)
        dgvChiTietPhieuXuat.TabIndex = 23
        ' 
        ' frmChiTietPhieuXuat
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(lbNguoiLapPhieu)
        Controls.Add(Label6)
        Controls.Add(lbTongSoTien)
        Controls.Add(lbNgay)
        Controls.Add(lbTen)
        Controls.Add(lbMa)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(dgvChiTietPhieuXuat)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Name = "frmChiTietPhieuXuat"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Chi Tiết Phiếu Xuất"
        CType(dgvChiTietPhieuXuat, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lbNguoiLapPhieu As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents lbTongSoTien As Label
    Friend WithEvents lbNgay As Label
    Friend WithEvents lbTen As Label
    Friend WithEvents lbMa As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents dgvChiTietPhieuXuat As DataGridView
End Class
