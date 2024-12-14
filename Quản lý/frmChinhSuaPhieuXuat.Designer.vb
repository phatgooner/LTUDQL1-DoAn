<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmChinhSuaPhieuXuat
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmChinhSuaPhieuXuat))
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Label1 = New Label()
        gbThongTinChung = New GroupBox()
        btThemKH = New Button()
        bt_LuuThongTin = New Button()
        tb_SDT = New TextBox()
        tb_DiaChi = New TextBox()
        cbb_KhachHang = New ComboBox()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        dtp_NgayTaoPhieu = New DateTimePicker()
        cbb_NguoiLapPhieu = New ComboBox()
        tbMaPhieu = New TextBox()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        dgvChiTietPhieuXuat = New DataGridView()
        Label15 = New Label()
        Label14 = New Label()
        Label13 = New Label()
        tb_MaSP = New TextBox()
        Label12 = New Label()
        Label11 = New Label()
        Label10 = New Label()
        cbb_TenSP = New ComboBox()
        tb_DonGia = New TextBox()
        tb_KhuyenMai = New TextBox()
        tb_DonVi = New TextBox()
        num_SoLuong = New NumericUpDown()
        btThem = New Button()
        btXoa = New Button()
        btSua = New Button()
        btLuu = New Button()
        Label8 = New Label()
        btLuuPhieu = New Button()
        tb_TongGiaTri = New TextBox()
        gbThongTinMatHang = New GroupBox()
        gbThongTinChung.SuspendLayout()
        CType(dgvChiTietPhieuXuat, ComponentModel.ISupportInitialize).BeginInit()
        CType(num_SoLuong, ComponentModel.ISupportInitialize).BeginInit()
        gbThongTinMatHang.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.Top
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(163))
        Label1.Location = New Point(319, 26)
        Label1.Margin = New Padding(3)
        Label1.Name = "Label1"
        Label1.Size = New Size(281, 31)
        Label1.TabIndex = 24
        Label1.Text = "THÔNG TIN PHIẾU XUẤT"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' gbThongTinChung
        ' 
        gbThongTinChung.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        gbThongTinChung.Controls.Add(btThemKH)
        gbThongTinChung.Controls.Add(bt_LuuThongTin)
        gbThongTinChung.Controls.Add(tb_SDT)
        gbThongTinChung.Controls.Add(tb_DiaChi)
        gbThongTinChung.Controls.Add(cbb_KhachHang)
        gbThongTinChung.Controls.Add(Label5)
        gbThongTinChung.Controls.Add(Label6)
        gbThongTinChung.Controls.Add(Label7)
        gbThongTinChung.Controls.Add(dtp_NgayTaoPhieu)
        gbThongTinChung.Controls.Add(cbb_NguoiLapPhieu)
        gbThongTinChung.Controls.Add(tbMaPhieu)
        gbThongTinChung.Controls.Add(Label4)
        gbThongTinChung.Controls.Add(Label3)
        gbThongTinChung.Controls.Add(Label2)
        gbThongTinChung.Location = New Point(12, 63)
        gbThongTinChung.Name = "gbThongTinChung"
        gbThongTinChung.Size = New Size(894, 192)
        gbThongTinChung.TabIndex = 50
        gbThongTinChung.TabStop = False
        gbThongTinChung.Text = "Thông tin chung"
        ' 
        ' btThemKH
        ' 
        btThemKH.Anchor = AnchorStyles.Top
        btThemKH.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(163))
        btThemKH.Location = New Point(836, 28)
        btThemKH.Name = "btThemKH"
        btThemKH.Size = New Size(30, 30)
        btThemKH.TabIndex = 52
        btThemKH.Text = "+"
        btThemKH.UseVisualStyleBackColor = True
        ' 
        ' bt_LuuThongTin
        ' 
        bt_LuuThongTin.Anchor = AnchorStyles.Top
        bt_LuuThongTin.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold)
        bt_LuuThongTin.Image = CType(resources.GetObject("bt_LuuThongTin.Image"), Image)
        bt_LuuThongTin.ImageAlign = ContentAlignment.MiddleLeft
        bt_LuuThongTin.Location = New Point(363, 144)
        bt_LuuThongTin.Name = "bt_LuuThongTin"
        bt_LuuThongTin.Size = New Size(169, 42)
        bt_LuuThongTin.TabIndex = 59
        bt_LuuThongTin.Text = "Lưu thông tin"
        bt_LuuThongTin.TextAlign = ContentAlignment.MiddleRight
        bt_LuuThongTin.UseVisualStyleBackColor = True
        ' 
        ' tb_SDT
        ' 
        tb_SDT.Anchor = AnchorStyles.Top
        tb_SDT.Location = New Point(585, 104)
        tb_SDT.Name = "tb_SDT"
        tb_SDT.ReadOnly = True
        tb_SDT.Size = New Size(250, 27)
        tb_SDT.TabIndex = 5
        ' 
        ' tb_DiaChi
        ' 
        tb_DiaChi.Anchor = AnchorStyles.Top
        tb_DiaChi.Location = New Point(585, 67)
        tb_DiaChi.Name = "tb_DiaChi"
        tb_DiaChi.ReadOnly = True
        tb_DiaChi.Size = New Size(250, 27)
        tb_DiaChi.TabIndex = 4
        ' 
        ' cbb_KhachHang
        ' 
        cbb_KhachHang.Anchor = AnchorStyles.Top
        cbb_KhachHang.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        cbb_KhachHang.AutoCompleteSource = AutoCompleteSource.ListItems
        cbb_KhachHang.DropDownStyle = ComboBoxStyle.DropDownList
        cbb_KhachHang.FormattingEnabled = True
        cbb_KhachHang.Location = New Point(585, 29)
        cbb_KhachHang.Name = "cbb_KhachHang"
        cbb_KhachHang.Size = New Size(250, 28)
        cbb_KhachHang.TabIndex = 3
        ' 
        ' Label5
        ' 
        Label5.Anchor = AnchorStyles.Top
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        Label5.Location = New Point(462, 106)
        Label5.Name = "Label5"
        Label5.Size = New Size(103, 20)
        Label5.TabIndex = 55
        Label5.Text = "Số điện thoại:"
        ' 
        ' Label6
        ' 
        Label6.Anchor = AnchorStyles.Top
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        Label6.Location = New Point(462, 70)
        Label6.Name = "Label6"
        Label6.Size = New Size(60, 20)
        Label6.TabIndex = 54
        Label6.Text = "Địa chỉ:"
        ' 
        ' Label7
        ' 
        Label7.Anchor = AnchorStyles.Top
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        Label7.Location = New Point(462, 34)
        Label7.Name = "Label7"
        Label7.Size = New Size(94, 20)
        Label7.TabIndex = 53
        Label7.Text = "Khách hàng:"
        ' 
        ' dtp_NgayTaoPhieu
        ' 
        dtp_NgayTaoPhieu.Anchor = AnchorStyles.Top
        dtp_NgayTaoPhieu.Location = New Point(183, 104)
        dtp_NgayTaoPhieu.Name = "dtp_NgayTaoPhieu"
        dtp_NgayTaoPhieu.Size = New Size(250, 27)
        dtp_NgayTaoPhieu.TabIndex = 2
        dtp_NgayTaoPhieu.Value = New Date(2024, 11, 6, 0, 0, 0, 0)
        ' 
        ' cbb_NguoiLapPhieu
        ' 
        cbb_NguoiLapPhieu.Anchor = AnchorStyles.Top
        cbb_NguoiLapPhieu.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        cbb_NguoiLapPhieu.AutoCompleteSource = AutoCompleteSource.ListItems
        cbb_NguoiLapPhieu.DropDownStyle = ComboBoxStyle.DropDownList
        cbb_NguoiLapPhieu.FormattingEnabled = True
        cbb_NguoiLapPhieu.Location = New Point(183, 66)
        cbb_NguoiLapPhieu.Name = "cbb_NguoiLapPhieu"
        cbb_NguoiLapPhieu.Size = New Size(250, 28)
        cbb_NguoiLapPhieu.TabIndex = 1
        ' 
        ' tbMaPhieu
        ' 
        tbMaPhieu.Anchor = AnchorStyles.Top
        tbMaPhieu.Location = New Point(183, 29)
        tbMaPhieu.Name = "tbMaPhieu"
        tbMaPhieu.ReadOnly = True
        tbMaPhieu.Size = New Size(250, 27)
        tbMaPhieu.TabIndex = 0
        ' 
        ' Label4
        ' 
        Label4.Anchor = AnchorStyles.Top
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        Label4.Location = New Point(60, 106)
        Label4.Name = "Label4"
        Label4.Size = New Size(119, 20)
        Label4.TabIndex = 49
        Label4.Text = "Ngày tạo phiếu:"
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.Top
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        Label3.Location = New Point(60, 70)
        Label3.Name = "Label3"
        Label3.Size = New Size(124, 20)
        Label3.TabIndex = 48
        Label3.Text = "Người lập phiếu:"
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.Top
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        Label2.Location = New Point(60, 34)
        Label2.Name = "Label2"
        Label2.Size = New Size(112, 20)
        Label2.TabIndex = 47
        Label2.Text = "Mã phiếu xuất:"
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
        dgvChiTietPhieuXuat.Location = New Point(15, 203)
        dgvChiTietPhieuXuat.Name = "dgvChiTietPhieuXuat"
        dgvChiTietPhieuXuat.ReadOnly = True
        dgvChiTietPhieuXuat.RowHeadersWidth = 51
        dgvChiTietPhieuXuat.Size = New Size(865, 161)
        dgvChiTietPhieuXuat.TabIndex = 63
        ' 
        ' Label15
        ' 
        Label15.Anchor = AnchorStyles.Top
        Label15.AutoSize = True
        Label15.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        Label15.Location = New Point(60, 41)
        Label15.Name = "Label15"
        Label15.Size = New Size(105, 20)
        Label15.TabIndex = 67
        Label15.Text = "Mã sản phẩm:"
        ' 
        ' Label14
        ' 
        Label14.Anchor = AnchorStyles.Top
        Label14.AutoSize = True
        Label14.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        Label14.Location = New Point(60, 77)
        Label14.Name = "Label14"
        Label14.Size = New Size(58, 20)
        Label14.TabIndex = 68
        Label14.Text = "Đơn vị:"
        ' 
        ' Label13
        ' 
        Label13.Anchor = AnchorStyles.Top
        Label13.AutoSize = True
        Label13.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        Label13.Location = New Point(60, 113)
        Label13.Name = "Label13"
        Label13.Size = New Size(74, 20)
        Label13.TabIndex = 69
        Label13.Text = "Số lượng:"
        ' 
        ' tb_MaSP
        ' 
        tb_MaSP.Anchor = AnchorStyles.Top
        tb_MaSP.Location = New Point(183, 36)
        tb_MaSP.Name = "tb_MaSP"
        tb_MaSP.ReadOnly = True
        tb_MaSP.Size = New Size(250, 27)
        tb_MaSP.TabIndex = 0
        ' 
        ' Label12
        ' 
        Label12.Anchor = AnchorStyles.Top
        Label12.AutoSize = True
        Label12.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        Label12.Location = New Point(462, 41)
        Label12.Name = "Label12"
        Label12.Size = New Size(107, 20)
        Label12.TabIndex = 71
        Label12.Text = "Tên sản phẩm:"
        ' 
        ' Label11
        ' 
        Label11.Anchor = AnchorStyles.Top
        Label11.AutoSize = True
        Label11.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        Label11.Location = New Point(462, 77)
        Label11.Name = "Label11"
        Label11.Size = New Size(114, 20)
        Label11.TabIndex = 72
        Label11.Text = "Đơn giá (VNĐ):"
        ' 
        ' Label10
        ' 
        Label10.Anchor = AnchorStyles.Top
        Label10.AutoSize = True
        Label10.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        Label10.Location = New Point(462, 113)
        Label10.Name = "Label10"
        Label10.Size = New Size(121, 20)
        Label10.TabIndex = 73
        Label10.Text = "Khuyến mãi (%):"
        ' 
        ' cbb_TenSP
        ' 
        cbb_TenSP.Anchor = AnchorStyles.Top
        cbb_TenSP.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        cbb_TenSP.AutoCompleteSource = AutoCompleteSource.ListItems
        cbb_TenSP.DropDownStyle = ComboBoxStyle.DropDownList
        cbb_TenSP.FormattingEnabled = True
        cbb_TenSP.Location = New Point(585, 36)
        cbb_TenSP.Name = "cbb_TenSP"
        cbb_TenSP.Size = New Size(250, 28)
        cbb_TenSP.TabIndex = 3
        ' 
        ' tb_DonGia
        ' 
        tb_DonGia.Anchor = AnchorStyles.Top
        tb_DonGia.Location = New Point(585, 74)
        tb_DonGia.Name = "tb_DonGia"
        tb_DonGia.ReadOnly = True
        tb_DonGia.Size = New Size(250, 27)
        tb_DonGia.TabIndex = 4
        ' 
        ' tb_KhuyenMai
        ' 
        tb_KhuyenMai.Anchor = AnchorStyles.Top
        tb_KhuyenMai.Location = New Point(585, 111)
        tb_KhuyenMai.Name = "tb_KhuyenMai"
        tb_KhuyenMai.Size = New Size(250, 27)
        tb_KhuyenMai.TabIndex = 5
        ' 
        ' tb_DonVi
        ' 
        tb_DonVi.Anchor = AnchorStyles.Top
        tb_DonVi.Location = New Point(183, 74)
        tb_DonVi.Name = "tb_DonVi"
        tb_DonVi.Size = New Size(250, 27)
        tb_DonVi.TabIndex = 1
        ' 
        ' num_SoLuong
        ' 
        num_SoLuong.Location = New Point(183, 112)
        num_SoLuong.Maximum = New Decimal(New Integer() {50, 0, 0, 0})
        num_SoLuong.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        num_SoLuong.Name = "num_SoLuong"
        num_SoLuong.Size = New Size(250, 27)
        num_SoLuong.TabIndex = 2
        num_SoLuong.TextAlign = HorizontalAlignment.Center
        num_SoLuong.Value = New Decimal(New Integer() {1, 0, 0, 0})
        ' 
        ' btThem
        ' 
        btThem.Anchor = AnchorStyles.Top
        btThem.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold)
        btThem.Image = CType(resources.GetObject("btThem.Image"), Image)
        btThem.ImageAlign = ContentAlignment.MiddleLeft
        btThem.Location = New Point(177, 155)
        btThem.Name = "btThem"
        btThem.Size = New Size(107, 42)
        btThem.TabIndex = 6
        btThem.Text = "Thêm"
        btThem.TextAlign = ContentAlignment.MiddleRight
        btThem.UseVisualStyleBackColor = True
        ' 
        ' btXoa
        ' 
        btXoa.Anchor = AnchorStyles.Top
        btXoa.Enabled = False
        btXoa.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold)
        btXoa.Image = CType(resources.GetObject("btXoa.Image"), Image)
        btXoa.ImageAlign = ContentAlignment.MiddleLeft
        btXoa.Location = New Point(337, 155)
        btXoa.Name = "btXoa"
        btXoa.Size = New Size(92, 42)
        btXoa.TabIndex = 7
        btXoa.Text = "Xóa"
        btXoa.TextAlign = ContentAlignment.MiddleRight
        btXoa.UseVisualStyleBackColor = True
        ' 
        ' btSua
        ' 
        btSua.Anchor = AnchorStyles.Top
        btSua.Enabled = False
        btSua.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold)
        btSua.Image = CType(resources.GetObject("btSua.Image"), Image)
        btSua.ImageAlign = ContentAlignment.MiddleLeft
        btSua.Location = New Point(482, 155)
        btSua.Name = "btSua"
        btSua.Size = New Size(90, 42)
        btSua.TabIndex = 8
        btSua.Text = "Sửa"
        btSua.TextAlign = ContentAlignment.MiddleRight
        btSua.UseVisualStyleBackColor = True
        ' 
        ' btLuu
        ' 
        btLuu.Anchor = AnchorStyles.Top
        btLuu.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold)
        btLuu.Image = CType(resources.GetObject("btLuu.Image"), Image)
        btLuu.ImageAlign = ContentAlignment.MiddleLeft
        btLuu.Location = New Point(625, 155)
        btLuu.Name = "btLuu"
        btLuu.Size = New Size(92, 42)
        btLuu.TabIndex = 9
        btLuu.Text = "Lưu"
        btLuu.TextAlign = ContentAlignment.MiddleRight
        btLuu.UseVisualStyleBackColor = True
        ' 
        ' Label8
        ' 
        Label8.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(163))
        Label8.Location = New Point(629, 376)
        Label8.Name = "Label8"
        Label8.Size = New Size(103, 20)
        Label8.TabIndex = 85
        Label8.Text = "TỔNG CỘNG:"
        Label8.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' btLuuPhieu
        ' 
        btLuuPhieu.Anchor = AnchorStyles.Bottom
        btLuuPhieu.Enabled = False
        btLuuPhieu.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold)
        btLuuPhieu.Image = CType(resources.GetObject("btLuuPhieu.Image"), Image)
        btLuuPhieu.ImageAlign = ContentAlignment.MiddleLeft
        btLuuPhieu.Location = New Point(358, 397)
        btLuuPhieu.Name = "btLuuPhieu"
        btLuuPhieu.Size = New Size(179, 42)
        btLuuPhieu.TabIndex = 10
        btLuuPhieu.Text = "Lưu phiếu xuất"
        btLuuPhieu.TextAlign = ContentAlignment.MiddleRight
        btLuuPhieu.UseVisualStyleBackColor = True
        ' 
        ' tb_TongGiaTri
        ' 
        tb_TongGiaTri.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        tb_TongGiaTri.Location = New Point(735, 372)
        tb_TongGiaTri.Name = "tb_TongGiaTri"
        tb_TongGiaTri.ReadOnly = True
        tb_TongGiaTri.Size = New Size(145, 27)
        tb_TongGiaTri.TabIndex = 87
        ' 
        ' gbThongTinMatHang
        ' 
        gbThongTinMatHang.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        gbThongTinMatHang.Controls.Add(tb_TongGiaTri)
        gbThongTinMatHang.Controls.Add(btLuuPhieu)
        gbThongTinMatHang.Controls.Add(Label8)
        gbThongTinMatHang.Controls.Add(btLuu)
        gbThongTinMatHang.Controls.Add(btSua)
        gbThongTinMatHang.Controls.Add(btXoa)
        gbThongTinMatHang.Controls.Add(btThem)
        gbThongTinMatHang.Controls.Add(num_SoLuong)
        gbThongTinMatHang.Controls.Add(tb_DonVi)
        gbThongTinMatHang.Controls.Add(tb_KhuyenMai)
        gbThongTinMatHang.Controls.Add(tb_DonGia)
        gbThongTinMatHang.Controls.Add(cbb_TenSP)
        gbThongTinMatHang.Controls.Add(Label10)
        gbThongTinMatHang.Controls.Add(Label11)
        gbThongTinMatHang.Controls.Add(Label12)
        gbThongTinMatHang.Controls.Add(tb_MaSP)
        gbThongTinMatHang.Controls.Add(Label13)
        gbThongTinMatHang.Controls.Add(Label14)
        gbThongTinMatHang.Controls.Add(Label15)
        gbThongTinMatHang.Controls.Add(dgvChiTietPhieuXuat)
        gbThongTinMatHang.Location = New Point(12, 261)
        gbThongTinMatHang.Name = "gbThongTinMatHang"
        gbThongTinMatHang.Size = New Size(894, 449)
        gbThongTinMatHang.TabIndex = 51
        gbThongTinMatHang.TabStop = False
        gbThongTinMatHang.Text = "Thông tin các mặt hàng"
        ' 
        ' frmChinhSuaPhieuXuat
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(918, 722)
        Controls.Add(gbThongTinMatHang)
        Controls.Add(gbThongTinChung)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        Name = "frmChinhSuaPhieuXuat"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Chỉnh Sửa Phiếu Xuất"
        gbThongTinChung.ResumeLayout(False)
        gbThongTinChung.PerformLayout()
        CType(dgvChiTietPhieuXuat, ComponentModel.ISupportInitialize).EndInit()
        CType(num_SoLuong, ComponentModel.ISupportInitialize).EndInit()
        gbThongTinMatHang.ResumeLayout(False)
        gbThongTinMatHang.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents gbThongTinChung As GroupBox
    Friend WithEvents bt_LuuThongTin As Button
    Friend WithEvents tb_SDT As TextBox
    Friend WithEvents tb_DiaChi As TextBox
    Friend WithEvents cbb_KhachHang As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents dtp_NgayTaoPhieu As DateTimePicker
    Friend WithEvents cbb_NguoiLapPhieu As ComboBox
    Friend WithEvents tbMaPhieu As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents dgvChiTietPhieuXuat As DataGridView
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents tb_MaSP As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents cbb_TenSP As ComboBox
    Friend WithEvents tb_DonGia As TextBox
    Friend WithEvents tb_KhuyenMai As TextBox
    Friend WithEvents tb_DonVi As TextBox
    Friend WithEvents num_SoLuong As NumericUpDown
    Friend WithEvents btThem As Button
    Friend WithEvents btXoa As Button
    Friend WithEvents btSua As Button
    Friend WithEvents btLuu As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents btLuuPhieu As Button
    Friend WithEvents tb_TongGiaTri As TextBox
    Friend WithEvents gbThongTinMatHang As GroupBox
    Friend WithEvents btThemKH As Button
End Class
