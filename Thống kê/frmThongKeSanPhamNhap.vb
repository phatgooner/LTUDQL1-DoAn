Public Class frmThongKeSanPhamNhap
    Dim SoLuongSPNhap As DataTable
    Dim SoLuongSPNhap_View As DataView

    Sub HienThiDanhSach()
        SoLuongSPNhap = XuLyDuLieu.DocDuLieu(String.Format("select SP_Ma, SP_Ten, DM_Ten, Sum(CTPN_SoLuong)	as SoLuongNhap, SUM(CTPN_ThanhTien) as TongTienNhap
from ChiTietPhieuNhap join SanPham on CTPN_MaSP = SP_Ma join PhieuNhap on CTPN_MaPhieuNhap = PN_Ma join DanhMuc on SP_DanhMuc = DM_Ma
where PN_Xoa = 'false' and CTPN_Xoa = 'false' and Month(PN_Ngay) = '{0}' and YEAR(PN_Ngay) = '{1}'
group by SP_Ma, SP_Ten, DM_Ten", cbbThang.SelectedItem, cbbNam.SelectedItem))

        SoLuongSPNhap_View = New DataView(SoLuongSPNhap)
        dgvThongKeSoLuong.DataSource = SoLuongSPNhap_View
    End Sub

    Private Sub ColumnEditing()
        dgvThongKeSoLuong.AllowUserToAddRows = False
        dgvThongKeSoLuong.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgvThongKeSoLuong.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgvThongKeSoLuong.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dgvThongKeSoLuong.Columns(4).DefaultCellStyle.Format = "#,##0"

        dgvThongKeSoLuong.Columns(0).HeaderText = "Mã sản phẩm"
        dgvThongKeSoLuong.Columns(1).HeaderText = "Tên sản phẩm"
        dgvThongKeSoLuong.Columns(2).HeaderText = "Danh mục"
        dgvThongKeSoLuong.Columns(3).HeaderText = "Số lượng đã nhập"
        dgvThongKeSoLuong.Columns(4).HeaderText = "Tổng số tiền nhập (VNĐ)"
    End Sub

    Private Sub frmThongKeSanPhamNhap_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbbThang.SelectedIndex = 6
        cbbNam.SelectedIndex = 6
        HienThiDanhSach()
        ColumnEditing()
    End Sub

    Private Sub cbbThang_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbbThang.SelectedIndexChanged
        HienThiDanhSach()
    End Sub

    Private Sub cbbNam_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbbNam.SelectedIndexChanged
        HienThiDanhSach()
    End Sub
End Class