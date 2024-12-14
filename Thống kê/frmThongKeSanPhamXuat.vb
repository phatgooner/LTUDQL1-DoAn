Public Class frmThongKeSanPhamXuat
    Dim SoLuongSPXuat As DataTable
    Dim SoLuongSPXuat_View As DataView

    Sub HienThiDanhSach()
        SoLuongSPXuat = XuLyDuLieu.DocDuLieu(String.Format("select SP_Ma, SP_Ten, DM_Ten, Sum(CTPX_SoLuong)	as SoLuongXuat, SUM(CTPX_ThanhTien) as TongTienXuat
from ChiTietPhieuXuat join SanPham on CTPX_MaSP = SP_Ma join PhieuXuat on CTPX_MaPhieuXuat = PX_Ma join DanhMuc on SP_DanhMuc = DM_Ma
where PX_Xoa = 'false' and CTPX_Xoa = 'false' and Month(PX_Ngay) = '{0}' and YEAR(PX_Ngay) = '{1}'
group by SP_Ma, SP_Ten, DM_Ten", cbbThang.SelectedItem, cbbNam.SelectedItem))

        SoLuongSPXuat_View = New DataView(SoLuongSPXuat)
        dgvThongKeSoLuong.DataSource = SoLuongSPXuat_View
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
        dgvThongKeSoLuong.Columns(3).HeaderText = "Số lượng đã xuất"
        dgvThongKeSoLuong.Columns(4).HeaderText = "Tổng số tiền xuất (VNĐ)"
    End Sub

    Private Sub frmThongKeSanPhamXuat_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbbThang.SelectedIndex = 7
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