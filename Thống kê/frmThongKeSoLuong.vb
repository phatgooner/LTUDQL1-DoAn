Public Class frmThongKeSoLuong
    Dim SoLuongSP As DataTable
    Dim SoLuongSP_View As DataView

    Sub HienThiDanhSach(ByVal HienTatCa As Boolean)
        If HienTatCa Then
            SoLuongSP = XuLyDuLieu.DocDuLieu("select a.SP_Ma, a.SP_Ten, TongSoLuongNhap, ISNULL(TongSoLuongXuat, 0) AS SoLuongXuat, TongSoLuongNhap - ISNULL(TongSoLuongXuat, 0) as ConLai
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
on a.SP_Ma = b.SP_Ma")
        Else
            SoLuongSP = XuLyDuLieu.DocDuLieu("select a.SP_Ma, a.SP_Ten, TongSoLuongNhap, ISNULL(TongSoLuongXuat, 0) AS SoLuongXuat, TongSoLuongNhap - ISNULL(TongSoLuongXuat, 0) as ConLai
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
        End If
        SoLuongSP_View = New DataView(SoLuongSP)
        dgvThongKeSoLuong.DataSource = SoLuongSP_View
    End Sub

    Private Sub tbTimKiem_TextChanged(sender As Object, e As EventArgs) Handles tbTimKiem.TextChanged
        If tbTimKiem.Text = "" Then
            SoLuongSP_View.RowFilter = ""
        Else
            SoLuongSP_View.RowFilter = String.Format("SP_Ten like '%{0}%'", tbTimKiem.Text)
        End If
    End Sub

    Private Sub ColumnEditing()
        dgvThongKeSoLuong.AllowUserToAddRows = False
        dgvThongKeSoLuong.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgvThongKeSoLuong.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgvThongKeSoLuong.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgvThongKeSoLuong.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

        dgvThongKeSoLuong.Columns(0).HeaderText = "Mã sản phẩm"
        dgvThongKeSoLuong.Columns(1).HeaderText = "Tên sản phẩm"
        dgvThongKeSoLuong.Columns(2).HeaderText = "Số lượng đã nhập"
        dgvThongKeSoLuong.Columns(3).HeaderText = "Số lượng đã xuất"
        dgvThongKeSoLuong.Columns(4).HeaderText = "Số lượng còn lại"
    End Sub

    Private Sub frmThongKeSoLuong_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        HienThiDanhSach(cbHienTatCa.Checked)
        ColumnEditing()
    End Sub

    Private Sub cbHienTatCa_CheckedChanged(sender As Object, e As EventArgs) Handles cbHienTatCa.CheckedChanged
        HienThiDanhSach(cbHienTatCa.Checked)
    End Sub
End Class