Imports System.ComponentModel.Design.ObjectSelectorEditor

Public Class frmQuanLyPhieuXuat
    Dim dsPhieuXuat As DataTable
    Dim dsPhieuXuatView As DataView

    Private Sub HienThiDanhSach()
        dsPhieuXuat = XuLyDuLieu.DocDuLieu(String.Format("Select PX_Ma, PX_Ngay, KH_Ten, SUM(CTPX_ThanhTien) AS GiaTri, ND_Ten, PX_Xoa, PX_KhachHang, PX_NguoiLapPhieu
                                                         from (PhieuXuat Join ChiTietPhieuXuat on PX_Ma = CTPX_MaPhieuXuat) join KhachHang on PX_KhachHang = KH_Ma join NguoiDung on PX_NguoiLapPhieu = ND_Ma
                                                         where PX_Xoa = 'false' and CTPX_Xoa = 'false'
                                                         group by PX_Ma, PX_Ngay, KH_Ten, ND_Ten, PX_Xoa, PX_KhachHang, PX_NguoiLapPhieu"))
        dsPhieuXuatView = New DataView(dsPhieuXuat)
        dgvDanhSachPhieuXuat.DataSource = dsPhieuXuatView
    End Sub

    Private Sub ColumnEditing()
        If dgvDanhSachPhieuXuat.Columns.Count = 8 Then
            'Format
            dgvDanhSachPhieuXuat.Columns("PX_Ngay").DefaultCellStyle.Format = "dd/MM/yyyy"
            dgvDanhSachPhieuXuat.Columns(3).DefaultCellStyle.Format = "#,##0"
            dgvDanhSachPhieuXuat.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            dgvDanhSachPhieuXuat.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            dgvDanhSachPhieuXuat.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            dgvDanhSachPhieuXuat.AllowUserToAddRows = False
            'Header
            dgvDanhSachPhieuXuat.Columns(0).HeaderText = "Mã phiếu xuất"
            dgvDanhSachPhieuXuat.Columns(1).HeaderText = "Ngày tạo"
            dgvDanhSachPhieuXuat.Columns(2).HeaderText = "Tên khách hàng"
            dgvDanhSachPhieuXuat.Columns(3).HeaderText = "Tổng giá trị (VNĐ)"
            dgvDanhSachPhieuXuat.Columns(4).HeaderText = "Người lập phiếu"
            dgvDanhSachPhieuXuat.Columns(5).Visible = False
            dgvDanhSachPhieuXuat.Columns(6).Visible = False
            dgvDanhSachPhieuXuat.Columns(7).Visible = False
            'Xem chi tiết
            Dim buttonColumn As New DataGridViewButtonColumn()
            buttonColumn.HeaderText = "Thông tin"
            buttonColumn.Text = "Xem Chi Tiết"
            buttonColumn.Name = "btXemChiTiet"
            buttonColumn.UseColumnTextForButtonValue = True
            dgvDanhSachPhieuXuat.Columns.Add(buttonColumn)
        End If
    End Sub

    Private Sub frmQuanLyPhieuXuat_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        HienThiDanhSach()
        ColumnEditing()
        If dgvDanhSachPhieuXuat.Rows.Count > 0 Then
            btXoa.Enabled = True
            btSua.Enabled = True
        Else
            btXoa.Enabled = False
            btSua.Enabled = False
        End If
    End Sub

    Private Sub dgvDanhSachPhieuXuat_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDanhSachPhieuXuat.CellContentClick
        If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
            Dim clickedCell As DataGridViewCell = dgvDanhSachPhieuXuat.Rows(e.RowIndex).Cells(e.ColumnIndex)
            If TypeOf clickedCell Is DataGridViewButtonCell Then
                Dim selectedRow As DataGridViewRow = dgvDanhSachPhieuXuat.Rows(e.RowIndex)
                Dim MaPhieuXuat As String = selectedRow.Cells(1).Value.ToString()
                Dim NgayTaoPhieu As Date = selectedRow.Cells(2).Value
                Dim TenKhachHang As String = selectedRow.Cells(3).Value.ToString()
                Dim SoTien As Integer = selectedRow.Cells(4).Value
                Dim NguoiLapPhieu As String = selectedRow.Cells(5).Value.ToString()

                Dim frm As frmChiTietPhieuXuat = New frmChiTietPhieuXuat()
                Dim dataTable As DataTable = XuLyDuLieu.DocDuLieu(String.Format("Select SP_Ten,
                CTPX_DonVi, CTPX_DonGia, CTPX_KhuyenMai, CTPX_SoLuong, CTPX_ThanhTien from ChiTietPhieuXuat, SanPham
                where CTPX_MaSP = SP_Ma and CTPX_Xoa = 'false' and CTPX_MaPhieuXuat = '{0}'", MaPhieuXuat))
                Dim dataView As DataView = New DataView(dataTable)
                frm.dgvChiTietPhieuXuat.DataSource = dataView

                frm.lbMa.Text = MaPhieuXuat
                frm.lbNgay.Text = NgayTaoPhieu.ToString("dd/MM/yyyy")
                frm.lbTen.Text = TenKhachHang
                frm.lbTongSoTien.Text = "TỔNG CỘNG: " + SoTien.ToString("#,##0") + " (VNĐ)"
                frm.lbNguoiLapPhieu.Text = NguoiLapPhieu

                frm.ShowDialog()
            End If
        End If
    End Sub

    Private Sub btTimKiem_Click(sender As Object, e As EventArgs) Handles btTimKiem.Click
        Dim frm As frmDanhSachPhieuXuat = New frmDanhSachPhieuXuat
        frm.ControlBox = True
        frm.StartPosition = FormStartPosition.CenterScreen
        frm.frmDanhSachPhieuXuat_Load(sender, e)
        frm.ShowDialog()
    End Sub

    Private Sub btThem_Click(sender As Object, e As EventArgs) Handles btThem.Click
        If KiemTraHangTon() Then
            Dim frm As frmChinhSuaPhieuXuat = New frmChinhSuaPhieuXuat("add")
            frm.dtp_NgayTaoPhieu.Value = Today
            frm.ShowDialog()
        End If
    End Sub

    Private Sub btSua_Click(sender As Object, e As EventArgs) Handles btSua.Click
        Dim ViTri As Integer = dgvDanhSachPhieuXuat.SelectedCells(0).RowIndex
        Dim dsPXView As DataRowView = dgvDanhSachPhieuXuat.Rows(ViTri).DataBoundItem
        Dim dsPX As DataRow = dsPXView.Row
        Dim frm As frmChinhSuaPhieuXuat = New frmChinhSuaPhieuXuat("edit")
        frm.dtp_NgayTaoPhieu.Value = dsPX("PX_Ngay")
        frm.tbMaPhieu.Text = dsPX("PX_Ma")
        frm.ShowDialog()
    End Sub

    Private Sub btXoa_Click(sender As Object, e As EventArgs) Handles btXoa.Click
        Dim dr As DialogResult = MessageBox.Show("Bạn có chắc muốn xóa phiếu xuất này?",
                                                 "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If dr = DialogResult.Yes Then
            If dgvDanhSachPhieuXuat.SelectedCells.Count > 0 Then
                Dim Index As Integer = dgvDanhSachPhieuXuat.SelectedCells(0).RowIndex
                Dim PhieuXuatView As DataRowView = dgvDanhSachPhieuXuat.Rows(Index).DataBoundItem
                Dim PhieuXuat As DataRow = PhieuXuatView.Row
                PhieuXuat("PX_Xoa") = True

                XuLyDuLieu.GhiDuLieu("PhieuXuat", dsPhieuXuat)
                dsPhieuXuat.Rows.Remove(PhieuXuat)
            Else
                MessageBox.Show("Anh chị vui lòng chọn phiếu xuất cần xóa!", "Thông báo")
            End If
            frmQuanLyPhieuXuat_Load(sender, e)
        End If
    End Sub

    Private Function KiemTraHangTon() As Boolean
        Dim Data As DataTable = XuLyDuLieu.DocDuLieu("select a.SP_Ma, a.SP_Ten, TongSoLuongNhap, ISNULL(TongSoLuongXuat, 0) AS SoLuongXuat, TongSoLuongNhap - ISNULL(TongSoLuongXuat, 0) as ConLai
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
where (TongSoLuongNhap - ISNULL(TongSoLuongXuat, 0)) > 0")

        If Data.Rows.Count > 0 Then
            Return True
        Else
            MessageBox.Show("Tất cả mặt hàng trong kho hiện đã hết!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If
    End Function
End Class