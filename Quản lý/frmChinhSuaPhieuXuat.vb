Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.Design.ObjectSelectorEditor
Imports System.Runtime.Intrinsics
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class frmChinhSuaPhieuXuat
    Dim dsCTPX As DataTable
    Dim dsCTPX_View As DataView
    Dim key As String
    Dim tuKhoa As String
    Dim tensp As String = ""
    Dim index As Integer
    Dim don_gia As Integer
    Dim soluong As Integer

    Public Sub New(ByVal tuKhoa As String)
        InitializeComponent()
        key = tuKhoa
    End Sub

    Private Sub ComboBoxLoad()
        Dim dsNguoiDung As DataTable = XuLyDuLieu.DocDuLieu("Select * from NguoiDung where ND_Xoa = 'false'")
        Dim dsKhachHang As DataTable = XuLyDuLieu.DocDuLieu("Select * from KhachHang where KH_Xoa = 'false'")

        cbb_NguoiLapPhieu.DataSource = dsNguoiDung
        cbb_NguoiLapPhieu.DisplayMember = "ND_Ten"
        cbb_NguoiLapPhieu.ValueMember = "ND_Ma"

        cbb_KhachHang.DataSource = dsKhachHang
        cbb_KhachHang.DisplayMember = "KH_Ten"
        cbb_KhachHang.ValueMember = "KH_Ma"
    End Sub

    Private Sub ColumnEditing()
        dgvChiTietPhieuXuat.AllowUserToAddRows = False
        dgvChiTietPhieuXuat.Columns(6).Visible = False
        dgvChiTietPhieuXuat.Columns(7).Visible = False
        dgvChiTietPhieuXuat.Columns(8).Visible = False
        dgvChiTietPhieuXuat.Columns(9).Visible = False

        dgvChiTietPhieuXuat.Columns(0).HeaderText = "Tên sản phẩm"
        dgvChiTietPhieuXuat.Columns(1).HeaderText = "Đơn vị"
        dgvChiTietPhieuXuat.Columns(2).HeaderText = "Đơn giá (VNĐ)"
        dgvChiTietPhieuXuat.Columns(3).HeaderText = "Khuyến mãi"
        dgvChiTietPhieuXuat.Columns(4).HeaderText = "Số lượng"
        dgvChiTietPhieuXuat.Columns(5).HeaderText = "Thành tiền (VNĐ)"

        dgvChiTietPhieuXuat.Columns(2).DefaultCellStyle.Format = "#,##0"
        dgvChiTietPhieuXuat.Columns(5).DefaultCellStyle.Format = "#,##0"

        dgvChiTietPhieuXuat.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgvChiTietPhieuXuat.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgvChiTietPhieuXuat.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgvChiTietPhieuXuat.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dgvChiTietPhieuXuat.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
    End Sub

    Private Sub HienThiDanhSach(MaPhieuXuat As String)
        dsCTPX = XuLyDuLieu.DocDuLieu(String.Format("Select SP_Ten, CTPX_DonVi, CTPX_DonGia, CTPX_KhuyenMai, CTPX_SoLuong, CTPX_ThanhTien, CTPX_MaPhieuXuat, CTPX_Xoa, CTPX_Ma, CTPX_MaSP
                from ChiTietPhieuXuat, SanPham
                where CTPX_MaSP = SP_Ma and CTPX_Xoa = 'false' and CTPX_MaPhieuXuat = '{0}'", MaPhieuXuat))
        dsCTPX_View = New DataView(dsCTPX)
        dgvChiTietPhieuXuat.DataSource = dsCTPX_View
    End Sub

    Private Sub Lock()
        gbThongTinChung.Enabled = True
        gbThongTinMatHang.Enabled = False
        dtp_NgayTaoPhieu.MaxDate = Today
    End Sub

    Private Sub Unlock()
        gbThongTinChung.Enabled = False
        gbThongTinMatHang.Enabled = True
        dtp_NgayTaoPhieu.MaxDate = Today
    End Sub

    Private Sub LockSP()
        btThem.Focus()

        btThem.Enabled = True
        btLuu.Enabled = False

        tb_DonVi.ReadOnly = True
        tb_KhuyenMai.ReadOnly = True
        cbb_TenSP.Enabled = False
        num_SoLuong.Enabled = False
    End Sub

    Private Sub UnlockSP()
        cbb_TenSP.Focus()

        btThem.Enabled = False
        btSua.Enabled = False
        btXoa.Enabled = False
        btLuu.Enabled = True

        tb_DonVi.ReadOnly = False
        tb_KhuyenMai.ReadOnly = False
        cbb_TenSP.Enabled = True
        num_SoLuong.Enabled = True
    End Sub

    Private Sub TinhTong()
        Dim total As Integer

        For Each row As DataGridViewRow In dgvChiTietPhieuXuat.Rows
            If Not row.IsNewRow Then
                Dim price As Integer
                If Integer.TryParse(row.Cells(5).Value.ToString(), price) Then
                    total += price
                End If
            End If
        Next
        tb_TongGiaTri.Text = total.ToString("#,##0") + " (VNĐ)"
        If total > 0 Then
            btLuuPhieu.Enabled = True
            btXoa.Enabled = True
            btSua.Enabled = True
        Else
            btLuuPhieu.Enabled = False
            btXoa.Enabled = False
            btSua.Enabled = False
        End If
    End Sub

    Private Sub frmChinhSuaPhieuXuat_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBoxLoad()

        If key = "add" Then
            HienThiDanhSach(tbMaPhieu.Text)
            ColumnEditing()
            Lock()

        ElseIf key = "edit" Then
            HienThiDanhSach(tbMaPhieu.Text)
            ColumnEditing()
            TinhTong()
            Lock()

            Dim dsKH As DataTable = XuLyDuLieu.DocDuLieu(String.Format("Select KH_Ma from PhieuXuat join KhachHang on PX_KhachHang = KH_Ma where PX_Ma = N'{0}'", tbMaPhieu.Text))
            Dim dsKH_View As DataView = New DataView(dsKH)
            Dim KH As DataRowView = dsKH_View(0)
            cbb_KhachHang.SelectedValue = KH("KH_Ma")

            Dim dsNguoiDung As DataTable = XuLyDuLieu.DocDuLieu(String.Format("Select ND_Ma from PhieuXuat join NguoiDung on PX_NguoiLapPhieu = ND_Ma where PX_Ma = N'{0}'", tbMaPhieu.Text))
            Dim dsNguoiDung_View As DataView = New DataView(dsNguoiDung)
            Dim ND As DataRowView = dsNguoiDung_View(0)
            cbb_NguoiLapPhieu.SelectedValue = ND("ND_Ma")
        End If
    End Sub

    Private Sub bt_LuuThongTin_Click(sender As Object, e As EventArgs) Handles bt_LuuThongTin.Click
        Unlock()
        LockSP()
        If key = "add" Then
            Dim dsPhieuXuat As DataTable = XuLyDuLieu.DocDuLieu("Select * from PhieuXuat")
            Dim PX As DataRow = dsPhieuXuat.NewRow()
            PX("PX_Ngay") = dtp_NgayTaoPhieu.Value.Date
            PX("PX_KhachHang") = cbb_KhachHang.SelectedValue
            PX("PX_NguoiLapPhieu") = cbb_NguoiLapPhieu.SelectedValue
            PX("PX_Xoa") = True

            dsPhieuXuat.Rows.Add(PX)
            XuLyDuLieu.GhiDuLieu("PhieuXuat", dsPhieuXuat)

            dsPhieuXuat = XuLyDuLieu.DocDuLieu("Select * from PhieuXuat")
            Dim num As Integer = dsPhieuXuat.Rows.Count
            Dim dsPhieuXuatView As DataView = New DataView(dsPhieuXuat)
            Dim PhieuXuatView As DataRowView = dsPhieuXuatView(num - 1)
            PX = PhieuXuatView.Row
            tbMaPhieu.Text = PX("PX_Ma")

        ElseIf key = "edit" Then
            Dim dsPhieuXuat As DataTable = XuLyDuLieu.DocDuLieu(String.Format("Select * from PhieuXuat where PX_Ma = '{0}'", tbMaPhieu.Text))
            Dim dsPhieuXuatView As DataView = New DataView(dsPhieuXuat)
            Dim PhieuXuatView As DataRowView = dsPhieuXuatView(0)
            If Not (PhieuXuatView Is Nothing) Then
                Dim PX As DataRow = PhieuXuatView.Row
                PX("PX_Ngay") = dtp_NgayTaoPhieu.Value.Date
                PX("PX_KhachHang") = cbb_KhachHang.SelectedValue
                PX("PX_NguoiLapPhieu") = cbb_NguoiLapPhieu.SelectedValue
                PX("PX_Xoa") = False

                XuLyDuLieu.GhiDuLieu("PhieuXuat", dsPhieuXuat)
            Else
                MessageBox.Show("Không tìm thấy Phiếu xuất cần sửa!", "Thông báo")
            End If
        Else
            MessageBox.Show("Không tìm thấy Phiếu xuất cần sửa!", "Thông báo")
        End If
    End Sub

    Private Sub btThem_Click(sender As Object, e As EventArgs) Handles btThem.Click
        UnlockSP()
        tuKhoa = "add"

        tb_DonVi.Clear()
        tb_KhuyenMai.Clear()
        num_SoLuong.Value = 1
    End Sub

    Private Sub btSua_Click(sender As Object, e As EventArgs) Handles btSua.Click
        UnlockSP()
        tuKhoa = "edit"
        index = dgvChiTietPhieuXuat.SelectedCells(0).RowIndex
        Dim SanPhamView As DataRowView = dgvChiTietPhieuXuat.Rows(index).DataBoundItem
        Dim SanPham As DataRow = SanPhamView.Row
        tensp = SanPham("SP_Ten")
        soluong = SanPham("CTPX_SoLuong")
        cbb_TenSP.SelectedValue = SanPham("CTPX_MaSP")
    End Sub

    Private Sub cbb_KhachHang_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbb_KhachHang.SelectedIndexChanged
        Dim selected As String = cbb_KhachHang.Items(cbb_KhachHang.SelectedIndex)("KH_Ten")
        Dim dsKH As DataTable = XuLyDuLieu.DocDuLieu(String.Format("Select KH_DiaChi, KH_SDT from KhachHang where KH_Xoa = 'false' and KH_Ten = N'{0}'", selected))
        Dim dsKH_View As DataView = New DataView(dsKH)
        Dim KH As DataRowView = dsKH_View(0)
        tb_DiaChi.Text = KH("KH_DiaChi")
        tb_SDT.Text = KH("KH_SDT")
    End Sub

    Private Sub cbb_TenSP_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbb_TenSP.SelectedIndexChanged
        If cbb_TenSP.SelectedIndex < 0 Then
            cbb_TenSP.SelectedIndex = 0
        End If
        Dim selected As String = cbb_TenSP.Items(cbb_TenSP.SelectedIndex)("SP_Ten")
        Dim dsSanPham As DataTable = XuLyDuLieu.DocDuLieu(String.Format("Select SP_Ma, SP_GiaBan from SanPham where SP_Xoa = 'false' and SP_Ten = N'{0}'", selected))
        Dim dsSanPham_View As DataView = New DataView(dsSanPham)
        Dim SP As DataRowView = dsSanPham_View(0)
        tb_MaSP.Text = SP("SP_Ma")
        don_gia = SP("SP_GiaBan")
        tb_DonGia.Text = don_gia.ToString("#,##0")

        Dim Data As DataTable = XuLyDuLieu.DocDuLieu(String.Format("select a.SP_Ma, a.SP_Ten, TongSoLuongNhap, ISNULL(TongSoLuongXuat, 0) AS SoLuongXuat, TongSoLuongNhap - ISNULL(TongSoLuongXuat, 0) as ConLai
from 
(select SP_Ma, SP_Ten, SUM(CTPN_SoLuong) as TongSoLuongNhap
from ChiTietPhieuNhap join SanPham on CTPN_MaSP = SP_Ma join PhieuNhap on CTPN_MaPhieuNhap = PN_Ma
where PN_Xoa = 'false' and CTPN_Xoa = 'false' 
group by SP_Ma, SP_Ten) a 
left join
(select SP_Ma, SUM(CTPX_SoLuong) as TongSoLuongXuat
from ChiTietPhieuXuat join SanPham on CTPX_MaSP = SP_Ma join PhieuXuat on CTPX_MaPhieuXuat = PX_Ma
where PX_Xoa = 'false' and CTPX_Xoa = 'false' 
group by SP_Ma) b 
on a.SP_Ma = b.SP_Ma
where (TongSoLuongNhap - ISNULL(TongSoLuongXuat, 0)) > 0 and SP_Ten = N'{0}'", selected))

        Dim Data_View As DataView = New DataView(Data)
        If Data.Rows.Count > 0 Then
            Dim Row As DataRowView = Data_View(0)

            If tuKhoa = "edit" And cbb_TenSP.Items(cbb_TenSP.SelectedIndex)("SP_Ten") = tensp Then
                num_SoLuong.Maximum = Row("ConLai") + soluong
            Else
                num_SoLuong.Maximum = Row("ConLai")
            End If
        End If
    End Sub

    Private Sub tb_KhuyenMai_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tb_KhuyenMai.KeyPress
        If e.KeyChar = ChrW(8) Then
            Exit Sub
        End If

        If Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> "."c Then
            e.Handled = True
        End If

        If e.KeyChar = "."c AndAlso tb_KhuyenMai.Text.Contains("."c) Then
            e.Handled = True
        End If
    End Sub

    Private Sub tb_KhuyenMai_TextChanged(sender As Object, e As EventArgs) Handles tb_KhuyenMai.TextChanged
        If Not IsNumeric(tb_KhuyenMai.Text) Then Exit Sub

        Dim value As Double
        If Double.TryParse(tb_KhuyenMai.Text, value) Then
            If value < 0 Then
                tb_KhuyenMai.Text = "0" ' Nếu giá trị nhỏ hơn 0, đặt lại thành 0
            ElseIf value > 99 Then
                tb_KhuyenMai.Text = "99" ' Nếu giá trị lớn hơn 99, đặt lại thành 99
            End If
        End If
    End Sub

    Private Sub frmChinhSuaPhieuXuat_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If String.IsNullOrEmpty(tb_TongGiaTri.Text) Or tb_TongGiaTri.Text = "0 (VNĐ)" Then
            If Not String.IsNullOrEmpty(tbMaPhieu.Text) Then
                Dim dsPhieuXuat As DataTable = XuLyDuLieu.DocDuLieu(String.Format("Select * from PhieuXuat where PX_Ma = '{0}'", tbMaPhieu.Text))
                Dim dsPhieuXuatView As DataView = New DataView(dsPhieuXuat)
                Dim PhieuXuatView As DataRowView = dsPhieuXuatView(0)
                If Not (PhieuXuatView Is Nothing) Then
                    Dim PX As DataRow = PhieuXuatView.Row
                    PX("PX_Ngay") = dtp_NgayTaoPhieu.Value.Date
                    PX("PX_KhachHang") = cbb_KhachHang.SelectedValue
                    PX("PX_NguoiLapPhieu") = cbb_NguoiLapPhieu.SelectedValue
                    PX("PX_Xoa") = True

                    XuLyDuLieu.GhiDuLieu("PhieuXuat", dsPhieuXuat)
                End If
            End If
        End If
        frmMain.PhiếuXuấtToolStripMenuItem_Click(sender, e)
    End Sub

    Private Sub dgvChiTietPhieuXuat_SelectionChanged(sender As Object, e As EventArgs) Handles dgvChiTietPhieuXuat.SelectionChanged
        If dgvChiTietPhieuXuat.SelectedCells.Count > 0 Then
            index = dgvChiTietPhieuXuat.SelectedCells(0).RowIndex
            Dim SanPhamView As DataRowView = dgvChiTietPhieuXuat.Rows(index).DataBoundItem
            If Not (SanPhamView Is Nothing) Then
                Dim SanPham As DataRow = SanPhamView.Row

                num_SoLuong.Text = SanPham("CTPX_SoLuong")
                tb_KhuyenMai.Text = SanPham("CTPX_KhuyenMai") * 100
                tb_DonVi.Text = SanPham("CTPX_DonVi")
                cbb_TenSP.SelectedValue = SanPham("CTPX_MaSP")
            End If
        End If
    End Sub

    Private Function Check_OK() As Boolean
        Dim num As Double
        If String.IsNullOrWhiteSpace(tb_DonVi.Text) Then
            MessageBox.Show("Bạn chưa nhập đơn vị!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        ElseIf Not Double.TryParse(tb_KhuyenMai.Text, num) Then
            MessageBox.Show("Khuyến mãi của sản phẩm không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If
        Return True
    End Function

    Private Function DuplicateCheck_OK(ByVal Ten As String) As Boolean
        If (Not String.IsNullOrEmpty(tensp)) And Ten.ToUpper = tensp.ToUpper Then
            Return True
        End If
        For Each row As DataGridViewRow In dgvChiTietPhieuXuat.Rows
            If row.Cells(0).Value.ToString.ToUpper = Ten.ToUpper Then
                MessageBox.Show("Mặt hàng này đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return False
            End If
        Next
        Return True
    End Function

    Private Sub btLuu_Click(sender As Object, e As EventArgs) Handles btLuu.Click
        If tuKhoa = "add" And Not String.IsNullOrEmpty(cbb_TenSP.Text) Then
            If Check_OK() And DuplicateCheck_OK(cbb_TenSP.Items(cbb_TenSP.SelectedIndex)("SP_Ten")) Then
                Dim ctPX As DataRow = dsCTPX.NewRow()
                ctPX("CTPX_MaSP") = tb_MaSP.Text
                ctPX("CTPX_MaPhieuXuat") = tbMaPhieu.Text
                ctPX("CTPX_DonVi") = tb_DonVi.Text
                ctPX("CTPX_DonGia") = don_gia
                ctPX("CTPX_KhuyenMai") = tb_KhuyenMai.Text / 100
                ctPX("CTPX_SoLuong") = num_SoLuong.Value
                ctPX("CTPX_Xoa") = False

                dsCTPX.Rows.Add(ctPX)
                XuLyDuLieu.GhiDuLieu("ChiTietPhieuXuat", dsCTPX)
            End If
        ElseIf tuKhoa = "edit" And Not String.IsNullOrEmpty(cbb_TenSP.Text) Then
            If Check_OK() And DuplicateCheck_OK(cbb_TenSP.Items(cbb_TenSP.SelectedIndex)("SP_Ten")) Then
                index = dgvChiTietPhieuXuat.SelectedCells(0).RowIndex
                Dim CTPX_View As DataRowView = dgvChiTietPhieuXuat.Rows(index).DataBoundItem
                If Not (CTPX_View Is Nothing) Then
                    Dim ctPX As DataRow = CTPX_View.Row
                    ctPX("CTPX_MaSP") = tb_MaSP.Text
                    ctPX("CTPX_MaPhieuXuat") = tbMaPhieu.Text
                    ctPX("CTPX_DonVi") = tb_DonVi.Text
                    ctPX("CTPX_DonGia") = don_gia
                    ctPX("CTPX_KhuyenMai") = tb_KhuyenMai.Text / 100
                    ctPX("CTPX_SoLuong") = num_SoLuong.Value
                    ctPX("CTPX_Xoa") = False

                    XuLyDuLieu.GhiDuLieu("ChiTietPhieuXuat", dsCTPX)
                Else
                    MessageBox.Show("Vui lòng chọn sản phẩm cần sửa!", "Thông báo")
                End If
            End If
        Else
            MessageBox.Show("Thông tin mặt hàng không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        LockSP()
        HienThiDanhSach(tbMaPhieu.Text)
        TinhTong()
        tensp = ""
    End Sub

    Private Sub btLuuPhieu_Click(sender As Object, e As EventArgs) Handles btLuuPhieu.Click
        Dim dsPhieuXuat As DataTable = XuLyDuLieu.DocDuLieu(String.Format("Select * from PhieuXuat where PX_Ma = '{0}'", tbMaPhieu.Text))
        Dim dsPhieuXuatView As DataView = New DataView(dsPhieuXuat)
        Dim PhieuXuatView As DataRowView = dsPhieuXuatView(0)
        Dim PX As DataRow = PhieuXuatView.Row
        PX("PX_Ngay") = dtp_NgayTaoPhieu.Value.Date
        PX("PX_KhachHang") = cbb_KhachHang.SelectedValue
        PX("PX_NguoiLapPhieu") = cbb_NguoiLapPhieu.SelectedValue
        PX("PX_Xoa") = False
        XuLyDuLieu.GhiDuLieu("PhieuXuat", dsPhieuXuat)

        Close()
    End Sub

    Private Sub btXoa_Click(sender As Object, e As EventArgs) Handles btXoa.Click
        Dim dr As DialogResult = MessageBox.Show("Bạn có chắc muốn xóa mặt hàng này?",
                                                 "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If dr = DialogResult.Yes Then
            If dgvChiTietPhieuXuat.SelectedCells.Count > 0 Then
                index = dgvChiTietPhieuXuat.SelectedCells(0).RowIndex
                Dim SanPhamView As DataRowView = dgvChiTietPhieuXuat.Rows(index).DataBoundItem
                Dim SanPham As DataRow = SanPhamView.Row
                SanPham("CTPX_Xoa") = True

                XuLyDuLieu.GhiDuLieu("ChiTietPhieuXuat", dsCTPX)
                dsCTPX.Rows.Remove(SanPham)
            Else
                MessageBox.Show("Vui lòng chọn mặt hàng cần xóa!", "Thông báo")
            End If
        End If
        HienThiDanhSach(tbMaPhieu.Text)
        TinhTong()
    End Sub

    Private Sub btThemKH_Click(sender As Object, e As EventArgs) Handles btThemKH.Click
        Dim frm As frmQuanLyKhachHang = New frmQuanLyKhachHang
        frm.ControlBox = True
        frm.ShowDialog()
    End Sub

    Private Sub cbb_KhachHang_Click(sender As Object, e As EventArgs) Handles cbb_KhachHang.Click
        Dim dsKhachHang As DataTable = XuLyDuLieu.DocDuLieu("Select * from KhachHang where KH_Xoa = 'false'")
        cbb_KhachHang.DataSource = dsKhachHang
        cbb_KhachHang.DisplayMember = "KH_Ten"
        cbb_KhachHang.ValueMember = "KH_Ma"
    End Sub

    Private Sub cbb_TenSP_Click(sender As Object, e As EventArgs) Handles cbb_TenSP.Click
        Dim sql As String = "select a.SP_Ma, a.SP_Ten, TongSoLuongNhap, ISNULL(TongSoLuongXuat, 0) AS SoLuongXuat, TongSoLuongNhap - ISNULL(TongSoLuongXuat, 0) as ConLai
from 
(select SP_Ma, SP_Ten, SUM(CTPN_SoLuong) as TongSoLuongNhap
from ChiTietPhieuNhap join SanPham on CTPN_MaSP = SP_Ma join PhieuNhap on CTPN_MaPhieuNhap = PN_Ma
where PN_Xoa = 'false' and CTPN_Xoa = 'false' 
group by SP_Ma, SP_Ten) a 
left join
(select SP_Ma, SUM(CTPX_SoLuong) as TongSoLuongXuat
from ChiTietPhieuXuat join SanPham on CTPX_MaSP = SP_Ma join PhieuXuat on CTPX_MaPhieuXuat = PX_Ma
where PX_Xoa = 'false' and CTPX_Xoa = 'false' 
group by SP_Ma) b 
on a.SP_Ma = b.SP_Ma
where (TongSoLuongNhap - ISNULL(TongSoLuongXuat, 0)) > 0"

        Dim dsSanPham As DataTable = XuLyDuLieu.DocDuLieu(sql)
        cbb_TenSP.DataSource = dsSanPham
        cbb_TenSP.DisplayMember = "SP_Ten"
        cbb_TenSP.ValueMember = "SP_Ma"
    End Sub
End Class