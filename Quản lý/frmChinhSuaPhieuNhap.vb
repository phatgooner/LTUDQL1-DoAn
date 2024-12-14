Imports System.ComponentModel.Design.ObjectSelectorEditor
Imports System.Runtime.Intrinsics
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class frmChinhSuaPhieuNhap
    Dim dsCTPN As DataTable
    Dim dsCTPN_View As DataView
    Dim key As String
    Dim tuKhoa As String
    Dim tensp As String = ""
    Dim index As Integer
    Dim don_gia As Integer

    Public Sub New(ByVal tuKhoa As String)
        InitializeComponent()
        key = tuKhoa
    End Sub

    Private Sub ComboBoxLoad()
        Dim dsNguoiDung As DataTable = XuLyDuLieu.DocDuLieu("Select * from NguoiDung where ND_Xoa = 'false'")
        Dim dsNhaSanXuat As DataTable = XuLyDuLieu.DocDuLieu("Select * from NhaSanXuat where NSX_Xoa = 'false'")

        cbb_NguoiLapPhieu.DataSource = dsNguoiDung
        cbb_NguoiLapPhieu.DisplayMember = "ND_Ten"
        cbb_NguoiLapPhieu.ValueMember = "ND_Ma"

        cbb_NhaCungCap.DataSource = dsNhaSanXuat
        cbb_NhaCungCap.DisplayMember = "NSX_Ten"
        cbb_NhaCungCap.ValueMember = "NSX_Ma"
    End Sub

    Private Sub ColumnEditing()
        dgvChiTietPhieuNhap.AllowUserToAddRows = False
        dgvChiTietPhieuNhap.Columns(6).Visible = False
        dgvChiTietPhieuNhap.Columns(7).Visible = False
        dgvChiTietPhieuNhap.Columns(8).Visible = False
        dgvChiTietPhieuNhap.Columns(9).Visible = False

        dgvChiTietPhieuNhap.Columns(0).HeaderText = "Tên sản phẩm"
        dgvChiTietPhieuNhap.Columns(1).HeaderText = "Đơn vị"
        dgvChiTietPhieuNhap.Columns(2).HeaderText = "Đơn giá (VNĐ)"
        dgvChiTietPhieuNhap.Columns(3).HeaderText = "Chiết khấu"
        dgvChiTietPhieuNhap.Columns(4).HeaderText = "Số lượng"
        dgvChiTietPhieuNhap.Columns(5).HeaderText = "Thành tiền (VNĐ)"

        dgvChiTietPhieuNhap.Columns(2).DefaultCellStyle.Format = "#,##0"
        dgvChiTietPhieuNhap.Columns(5).DefaultCellStyle.Format = "#,##0"

        dgvChiTietPhieuNhap.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgvChiTietPhieuNhap.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgvChiTietPhieuNhap.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgvChiTietPhieuNhap.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dgvChiTietPhieuNhap.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
    End Sub

    Private Sub HienThiDanhSach(MaPhieuNhap As String)
        dsCTPN = XuLyDuLieu.DocDuLieu(String.Format("Select SP_Ten, CTPN_DonVi, CTPN_DonGia, CTPN_ChietKhau, CTPN_SoLuong, CTPN_ThanhTien, CTPN_MaPhieuNhap, CTPN_Xoa, CTPN_Ma, CTPN_MaSP 
                from ChiTietPhieuNhap, SanPham
                where CTPN_MaSP = SP_Ma and CTPN_Xoa = 'false' and CTPN_MaPhieuNhap = '{0}'", MaPhieuNhap))
        dsCTPN_View = New DataView(dsCTPN)
        dgvChiTietPhieuNhap.DataSource = dsCTPN_View
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
        btThemSanPham.Enabled = False

        tb_DonVi.ReadOnly = True
        tb_ChietKhau.ReadOnly = True
        cbb_TenSP.Enabled = False
        num_SoLuong.Enabled = False
    End Sub

    Private Sub UnlockSP()
        cbb_TenSP.Focus()

        btThem.Enabled = False
        btSua.Enabled = False
        btXoa.Enabled = False
        btLuu.Enabled = True
        btThemSanPham.Enabled = True

        tb_DonVi.ReadOnly = False
        tb_ChietKhau.ReadOnly = False
        cbb_TenSP.Enabled = True
        num_SoLuong.Enabled = True
    End Sub

    Private Sub frmChinhSuaPhieuNhap_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

            Dim dsNSX As DataTable = XuLyDuLieu.DocDuLieu(String.Format("Select NSX_Ma from PhieuNhap join NhaSanXuat on PN_NhaCungCap = NSX_Ma where PN_Ma = N'{0}'", tbMaPhieu.Text))
            Dim dsNSX_View As DataView = New DataView(dsNSX)
            Dim NSX As DataRowView = dsNSX_View(0)
            cbb_NhaCungCap.SelectedValue = NSX("NSX_Ma")

            Dim dsNguoiDung As DataTable = XuLyDuLieu.DocDuLieu(String.Format("Select ND_Ma from PhieuNhap join NguoiDung on PN_NguoiLapPhieu = ND_Ma where PN_Ma = N'{0}'", tbMaPhieu.Text))
            Dim dsNguoiDung_View As DataView = New DataView(dsNguoiDung)
            Dim ND As DataRowView = dsNguoiDung_View(0)
            cbb_NguoiLapPhieu.SelectedValue = ND("ND_Ma")
        End If
    End Sub

    Private Sub bt_LuuThongTin_Click(sender As Object, e As EventArgs) Handles bt_LuuThongTin.Click
        Unlock()
        LockSP()
        If key = "add" Then
            Dim dsPhieuNhap As DataTable = XuLyDuLieu.DocDuLieu("Select * from PhieuNhap")
            Dim pn As DataRow = dsPhieuNhap.NewRow()
            pn("PN_Ngay") = dtp_NgayTaoPhieu.Value.Date
            pn("PN_NhaCungCap") = cbb_NhaCungCap.SelectedValue
            pn("PN_NguoiLapPhieu") = cbb_NguoiLapPhieu.SelectedValue
            pn("PN_Xoa") = True

            dsPhieuNhap.Rows.Add(pn)
            XuLyDuLieu.GhiDuLieu("PhieuNhap", dsPhieuNhap)

            dsPhieuNhap = XuLyDuLieu.DocDuLieu("Select * from PhieuNhap")
            Dim num As Integer = dsPhieuNhap.Rows.Count
            Dim dsPhieuNhapView As DataView = New DataView(dsPhieuNhap)
            Dim PhieuNhapView As DataRowView = dsPhieuNhapView(num - 1)
            pn = PhieuNhapView.Row
            tbMaPhieu.Text = pn("PN_Ma")

        ElseIf key = "edit" Then
            Dim dsPhieuNhap As DataTable = XuLyDuLieu.DocDuLieu(String.Format("Select * from PhieuNhap where PN_Ma = '{0}'", tbMaPhieu.Text))
            Dim dsPhieuNhapView As DataView = New DataView(dsPhieuNhap)
            Dim PhieuNhapView As DataRowView = dsPhieuNhapView(0)
            If Not (PhieuNhapView Is Nothing) Then
                Dim pn As DataRow = PhieuNhapView.Row
                pn("PN_Ngay") = dtp_NgayTaoPhieu.Value.Date
                pn("PN_NhaCungCap") = cbb_NhaCungCap.SelectedValue
                pn("PN_NguoiLapPhieu") = cbb_NguoiLapPhieu.SelectedValue
                pn("PN_Xoa") = False

                XuLyDuLieu.GhiDuLieu("PhieuNhap", dsPhieuNhap)
            Else
                MessageBox.Show("Không tìm thấy phiếu nhập cần sửa!", "Thông báo")
            End If
        Else
            MessageBox.Show("Không tìm thấy phiếu nhập cần sửa!", "Thông báo")
        End If
    End Sub

    Private Sub btThem_Click(sender As Object, e As EventArgs) Handles btThem.Click
        UnlockSP()
        tuKhoa = "add"

        tb_DonVi.Clear()
        tb_ChietKhau.Clear()
        num_SoLuong.Value = 1
    End Sub

    Private Sub btSua_Click(sender As Object, e As EventArgs) Handles btSua.Click
        UnlockSP()
        tuKhoa = "edit"
        index = dgvChiTietPhieuNhap.SelectedCells(0).RowIndex
        Dim SanPhamView As DataRowView = dgvChiTietPhieuNhap.Rows(index).DataBoundItem
        Dim SanPham As DataRow = SanPhamView.Row
        tensp = SanPham("SP_Ten")
        cbb_TenSP.SelectedValue = SanPham("CTPN_MaSP")
    End Sub

    Private Sub cbb_NhaCungCap_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbb_NhaCungCap.SelectedIndexChanged
        If cbb_NhaCungCap.SelectedIndex < 0 Then
            cbb_NhaCungCap.SelectedIndex = 0
        End If
        Dim selected As String = cbb_NhaCungCap.Items(cbb_NhaCungCap.SelectedIndex)("NSX_Ten")
        Dim dsNSX As DataTable = XuLyDuLieu.DocDuLieu(String.Format("Select NSX_DiaChi, NSX_SDT from NhaSanXuat where NSX_Xoa = 'false' and NSX_Ten = N'{0}'", selected))
        Dim dsNSX_View As DataView = New DataView(dsNSX)
        Dim NSX As DataRowView = dsNSX_View(0)
        tb_DiaChi.Text = NSX("NSX_DiaChi")
        tb_SDT.Text = NSX("NSX_SDT")
    End Sub

    Private Sub cbb_TenSP_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbb_TenSP.SelectedIndexChanged
        If cbb_TenSP.SelectedIndex < 0 Then
            cbb_TenSP.SelectedIndex = 0
        End If
        Dim selected As String = cbb_TenSP.Items(cbb_TenSP.SelectedIndex)("SP_Ten")
        Dim dsSanPham As DataTable = XuLyDuLieu.DocDuLieu(String.Format("Select SP_Ma, SP_GiaNhap from SanPham where SP_Xoa = 'false' and SP_Ten = N'{0}'", selected))
        Dim dsSanPham_View As DataView = New DataView(dsSanPham)
        Dim SP As DataRowView = dsSanPham_View(0)
        tb_MaSP.Text = SP("SP_Ma")
        don_gia = SP("SP_GiaNhap")
        tb_DonGia.Text = don_gia.ToString("#,##0")
    End Sub

    Private Sub tb_ChietKhau_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tb_ChietKhau.KeyPress
        If e.KeyChar = ChrW(8) Then
            Exit Sub
        End If

        If Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> "."c Then
            e.Handled = True
        End If

        If e.KeyChar = "."c AndAlso tb_ChietKhau.Text.Contains("."c) Then
            e.Handled = True
        End If
    End Sub

    Private Sub tb_ChietKhau_TextChanged(sender As Object, e As EventArgs) Handles tb_ChietKhau.TextChanged
        If Not IsNumeric(tb_ChietKhau.Text) Then Exit Sub

        Dim value As Double
        If Double.TryParse(tb_ChietKhau.Text, value) Then
            If value < 0 Then
                tb_ChietKhau.Text = "0" ' Nếu giá trị nhỏ hơn 0, đặt lại thành 0
            ElseIf value > 99 Then
                tb_ChietKhau.Text = "99" ' Nếu giá trị lớn hơn 99, đặt lại thành 99
            End If
        End If
    End Sub

    Private Sub frmChinhSuaPhieuNhap_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If String.IsNullOrEmpty(tb_TongGiaTri.Text) Or tb_TongGiaTri.Text = "0 (VNĐ)" Then
            If Not String.IsNullOrEmpty(tbMaPhieu.Text) Then
                Dim dsPhieuNhap As DataTable = XuLyDuLieu.DocDuLieu(String.Format("Select * from PhieuNhap where PN_Ma = '{0}'", tbMaPhieu.Text))
                Dim dsPhieuNhapView As DataView = New DataView(dsPhieuNhap)
                Dim PhieuNhapView As DataRowView = dsPhieuNhapView(0)
                If Not (PhieuNhapView Is Nothing) Then
                    Dim pn As DataRow = PhieuNhapView.Row
                    pn("PN_Ngay") = dtp_NgayTaoPhieu.Value.Date
                    pn("PN_NhaCungCap") = cbb_NhaCungCap.SelectedValue
                    pn("PN_NguoiLapPhieu") = cbb_NguoiLapPhieu.SelectedValue
                    pn("PN_Xoa") = True

                    XuLyDuLieu.GhiDuLieu("PhieuNhap", dsPhieuNhap)
                End If
            End If
        End If
        frmMain.PhiếuNhậpToolStripMenuItem_Click(sender, e)
    End Sub

    Private Sub dgvChiTietPhieuNhap_SelectionChanged(sender As Object, e As EventArgs) Handles dgvChiTietPhieuNhap.SelectionChanged
        If dgvChiTietPhieuNhap.SelectedCells.Count > 0 Then
            index = dgvChiTietPhieuNhap.SelectedCells(0).RowIndex
            Dim SanPhamView As DataRowView = dgvChiTietPhieuNhap.Rows(index).DataBoundItem
            If Not (SanPhamView Is Nothing) Then
                Dim SanPham As DataRow = SanPhamView.Row

                num_SoLuong.Text = SanPham("CTPN_SoLuong")
                tb_ChietKhau.Text = SanPham("CTPN_ChietKhau") * 100
                tb_DonVi.Text = SanPham("CTPN_DonVi")
                cbb_TenSP.SelectedValue = SanPham("CTPN_MaSP")
            End If
        End If
    End Sub

    Private Function Check_OK() As Boolean
        Dim num As Double
        If String.IsNullOrWhiteSpace(tb_DonVi.Text) Then
            MessageBox.Show("Bạn chưa nhập đơn vị!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        ElseIf Not Double.TryParse(tb_ChietKhau.Text, num) Then
            MessageBox.Show("Chiết khấu của sản phẩm không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If
        Return True
    End Function

    Private Function DuplicateCheck_OK(ByVal Ten As String) As Boolean
        If (Not String.IsNullOrEmpty(tensp)) And Ten.ToUpper = tensp.ToUpper Then
            Return True
        End If
        For Each row As DataGridViewRow In dgvChiTietPhieuNhap.Rows
            If row.Cells(0).Value.ToString.ToUpper = Ten.ToUpper Then
                MessageBox.Show("Mặt hàng này đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return False
            End If
        Next
        Return True
    End Function

    Private Sub TinhTong()
        Dim total As Integer

        For Each row As DataGridViewRow In dgvChiTietPhieuNhap.Rows
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

    Private Sub btLuu_Click(sender As Object, e As EventArgs) Handles btLuu.Click
        If tuKhoa = "add" And Not String.IsNullOrEmpty(cbb_TenSP.Text) Then
            If Check_OK() And DuplicateCheck_OK(cbb_TenSP.Items(cbb_TenSP.SelectedIndex)("SP_Ten")) Then
                Dim ctpn As DataRow = dsCTPN.NewRow()
                ctpn("CTPN_MaSP") = tb_MaSP.Text
                ctpn("CTPN_MaPhieuNhap") = tbMaPhieu.Text
                ctpn("CTPN_DonVi") = tb_DonVi.Text
                ctpn("CTPN_DonGia") = don_gia
                ctpn("CTPN_ChietKhau") = tb_ChietKhau.Text / 100
                ctpn("CTPN_SoLuong") = num_SoLuong.Value
                ctpn("CTPN_Xoa") = False

                dsCTPN.Rows.Add(ctpn)
                XuLyDuLieu.GhiDuLieu("ChiTietPhieuNhap", dsCTPN)
            End If
        ElseIf tuKhoa = "edit" And Not String.IsNullOrEmpty(cbb_TenSP.Text) Then
            If Check_OK() And DuplicateCheck_OK(cbb_TenSP.Items(cbb_TenSP.SelectedIndex)("SP_Ten")) Then
                index = dgvChiTietPhieuNhap.SelectedCells(0).RowIndex
                Dim CTPN_View As DataRowView = dgvChiTietPhieuNhap.Rows(index).DataBoundItem
                If Not (CTPN_View Is Nothing) Then
                    Dim ctpn As DataRow = CTPN_View.Row
                    ctpn("CTPN_MaSP") = tb_MaSP.Text
                    ctpn("CTPN_MaPhieuNhap") = tbMaPhieu.Text
                    ctpn("CTPN_DonVi") = tb_DonVi.Text
                    ctpn("CTPN_DonGia") = don_gia
                    ctpn("CTPN_ChietKhau") = tb_ChietKhau.Text / 100
                    ctpn("CTPN_SoLuong") = num_SoLuong.Value
                    ctpn("CTPN_Xoa") = False

                    XuLyDuLieu.GhiDuLieu("ChiTietPhieuNhap", dsCTPN)
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
        Dim dsPhieuNhap As DataTable = XuLyDuLieu.DocDuLieu(String.Format("Select * from PhieuNhap where PN_Ma = '{0}'", tbMaPhieu.Text))
        Dim dsPhieuNhapView As DataView = New DataView(dsPhieuNhap)
        Dim PhieuNhapView As DataRowView = dsPhieuNhapView(0)
        Dim pn As DataRow = PhieuNhapView.Row
        pn("PN_Ngay") = dtp_NgayTaoPhieu.Value.Date
        pn("PN_NhaCungCap") = cbb_NhaCungCap.SelectedValue
        pn("PN_NguoiLapPhieu") = cbb_NguoiLapPhieu.SelectedValue
        pn("PN_Xoa") = False
        XuLyDuLieu.GhiDuLieu("PhieuNhap", dsPhieuNhap)

        Close()
    End Sub

    Private Sub btXoa_Click(sender As Object, e As EventArgs) Handles btXoa.Click
        Dim dr As DialogResult = MessageBox.Show("Bạn có chắc muốn xóa mặt hàng này?",
                                                 "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If dr = DialogResult.Yes Then
            If dgvChiTietPhieuNhap.SelectedCells.Count > 0 Then
                index = dgvChiTietPhieuNhap.SelectedCells(0).RowIndex
                Dim SanPhamView As DataRowView = dgvChiTietPhieuNhap.Rows(index).DataBoundItem
                Dim SanPham As DataRow = SanPhamView.Row
                SanPham("CTPN_Xoa") = True

                XuLyDuLieu.GhiDuLieu("ChiTietPhieuNhap", dsCTPN)
                dsCTPN.Rows.Remove(SanPham)
            Else
                MessageBox.Show("Vui lòng chọn mặt hàng cần xóa!", "Thông báo")
            End If
        End If
        HienThiDanhSach(tbMaPhieu.Text)
        TinhTong()
    End Sub

    Private Sub btThemNSX_Click(sender As Object, e As EventArgs) Handles btThemNSX.Click
        Dim frm As frmQuanLyNhaCungCap = New frmQuanLyNhaCungCap
        frm.ControlBox = True
        frm.ShowDialog()
    End Sub

    Private Sub cbb_NhaCungCap_Click(sender As Object, e As EventArgs) Handles cbb_NhaCungCap.Click
        Dim dsNhaSanXuat As DataTable = XuLyDuLieu.DocDuLieu("Select * from NhaSanXuat where NSX_Xoa = 'false'")
        cbb_NhaCungCap.DataSource = dsNhaSanXuat
        cbb_NhaCungCap.DisplayMember = "NSX_Ten"
        cbb_NhaCungCap.ValueMember = "NSX_Ma"
    End Sub

    Private Sub btThemSanPham_Click(sender As Object, e As EventArgs) Handles btThemSanPham.Click
        Dim frm As frmQuanLySanPham = New frmQuanLySanPham
        frm.ControlBox = True
        frm.ShowDialog()
    End Sub

    Private Sub cbb_TenSP_Click(sender As Object, e As EventArgs) Handles cbb_TenSP.Click
        Dim dsSanPham As DataTable = XuLyDuLieu.DocDuLieu(String.Format("Select * from SanPham join NhaSanXuat on SP_NhaSanXuat = NSX_Ma where SP_Xoa = 'false' and NSX_Ten = N'{0}'", cbb_NhaCungCap.Text))
        cbb_TenSP.DataSource = dsSanPham
        cbb_TenSP.DisplayMember = "SP_Ten"
        cbb_TenSP.ValueMember = "SP_Ma"
    End Sub
End Class