Public Class frmThongKePhieuXuat
    Dim SoLuongPhieuXuat As DataTable
    Dim SoLuongPhieuXuat_View As DataView

    Sub HienThiDanhSach()
        SoLuongPhieuXuat = XuLyDuLieu.DocDuLieu(String.Format("select PX_Ngay, Count(Distinct(PX_Ma)) as SoLuongPhieu, SUM(CTPX_ThanhTien) as TongGiaTri
from PhieuXuat join ChiTietPhieuXuat on PX_Ma = CTPX_MaPhieuXuat
where PX_Xoa = 'false' and CTPX_Xoa = 'false' and Month(PX_Ngay) = '{0}' and YEAR(PX_Ngay) = '{1}'
group by PX_Ngay", cbbThang.SelectedItem, cbbNam.SelectedItem))
        SoLuongPhieuXuat_View = New DataView(SoLuongPhieuXuat)
        dgvThongKeSoLuong.DataSource = SoLuongPhieuXuat_View
    End Sub

    Private Sub ColumnEditing()
        dgvThongKeSoLuong.AllowUserToAddRows = False
        dgvThongKeSoLuong.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgvThongKeSoLuong.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgvThongKeSoLuong.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dgvThongKeSoLuong.Columns(2).DefaultCellStyle.Format = "#,##0"
        dgvThongKeSoLuong.Columns(0).DefaultCellStyle.Format = "dd/MM/yyyy"

        dgvThongKeSoLuong.Columns(0).HeaderText = "Ngày xuất"
        dgvThongKeSoLuong.Columns(1).HeaderText = "Tổng số phiếu xuất"
        dgvThongKeSoLuong.Columns(2).HeaderText = "Tổng giá trị xuất (VNĐ)"
    End Sub

    Private Sub frmThongKePhieuXuat_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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