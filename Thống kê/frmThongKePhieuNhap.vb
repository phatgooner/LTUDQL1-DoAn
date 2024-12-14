Public Class frmThongKePhieuNhap
    Dim SoLuongPhieuNhap As DataTable
    Dim SoLuongPhieuNhap_View As DataView

    Sub HienThiDanhSach()
        SoLuongPhieuNhap = XuLyDuLieu.DocDuLieu(String.Format("select PN_Ngay, Count(Distinct(PN_Ma)) as SoLuongPhieu, SUM(CTPN_ThanhTien) as TongGiaTri
from PhieuNhap join ChiTietPhieuNhap on PN_Ma = CTPN_MaPhieuNhap
where PN_Xoa = 'false' and CTPN_Xoa = 'false' and Month(PN_Ngay) = '{0}' and YEAR(PN_Ngay) = '{1}'
group by PN_Ngay", cbbThang.SelectedItem, cbbNam.SelectedItem))
        SoLuongPhieuNhap_View = New DataView(SoLuongPhieuNhap)
        dgvThongKeSoLuong.DataSource = SoLuongPhieuNhap_View
    End Sub

    Private Sub ColumnEditing()
        dgvThongKeSoLuong.AllowUserToAddRows = False
        dgvThongKeSoLuong.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgvThongKeSoLuong.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgvThongKeSoLuong.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dgvThongKeSoLuong.Columns(2).DefaultCellStyle.Format = "#,##0"
        dgvThongKeSoLuong.Columns(0).DefaultCellStyle.Format = "dd/MM/yyyy"

        dgvThongKeSoLuong.Columns(0).HeaderText = "Ngày nhập"
        dgvThongKeSoLuong.Columns(1).HeaderText = "Tổng số phiếu nhập"
        dgvThongKeSoLuong.Columns(2).HeaderText = "Tổng giá trị nhập (VNĐ)"

    End Sub

    Private Sub frmThongKePhieuNhap_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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