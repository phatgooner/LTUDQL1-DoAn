Public Class frmThongKeXuatHang
    Dim SoLuongXuat As DataTable
    Dim SoLuongXuat_View As DataView

    Sub HienThiDanhSach()
        SoLuongXuat = XuLyDuLieu.DocDuLieu(String.Format("select KH_Ma, KH_Ten, SUM(CTPX_ThanhTien) as TongSoTien
from PhieuXuat join KhachHang on PX_KhachHang = KH_Ma join ChiTietPhieuXuat on PX_Ma = CTPX_MaPhieuXuat
where PX_Xoa = 'false' and CTPX_Xoa = 'false' and Month(PX_Ngay) = '{0}' and YEAR(PX_Ngay) = '{1}'
group by KH_Ma, KH_Ten", cbbThang.SelectedItem, cbbNam.SelectedItem))
        SoLuongXuat_View = New DataView(SoLuongXuat)
        dgvThongKeSoLuong.DataSource = SoLuongXuat_View
    End Sub

    Private Sub ColumnEditing()
        dgvThongKeSoLuong.AllowUserToAddRows = False
        dgvThongKeSoLuong.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgvThongKeSoLuong.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dgvThongKeSoLuong.Columns(2).DefaultCellStyle.Format = "#,##0"

        dgvThongKeSoLuong.Columns(0).HeaderText = "Mã khách hàng"
        dgvThongKeSoLuong.Columns(1).HeaderText = "Tên khách hàng"
        dgvThongKeSoLuong.Columns(2).HeaderText = "Tổng giá trị xuất (VNĐ)"
        'Xem chi tiết
        Dim buttonColumn As New DataGridViewButtonColumn()
        buttonColumn.HeaderText = "Chi tiết"
        buttonColumn.Text = "Xem danh sách phiếu xuất"
        buttonColumn.Name = "btXemChiTiet"
        buttonColumn.UseColumnTextForButtonValue = True
        dgvThongKeSoLuong.Columns.Add(buttonColumn)
    End Sub

    Private Sub frmThongKeXuatHang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

    Private Sub dgvThongKeSoLuong_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvThongKeSoLuong.CellContentClick
        If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
            Dim clickedCell As DataGridViewCell = dgvThongKeSoLuong.Rows(e.RowIndex).Cells(e.ColumnIndex)
            If TypeOf clickedCell Is DataGridViewButtonCell Then
                Dim selectedRow As DataGridViewRow = dgvThongKeSoLuong.Rows(e.RowIndex)
                Dim Ma As String = selectedRow.Cells(1).Value.ToString()

                Dim dataTable As DataTable = XuLyDuLieu.DocDuLieu(String.Format("Select PX_Ma, PX_Ngay, KH_Ten, SUM(CTPX_ThanhTien) AS GiaTri, ND_Ten
                                                         from (PhieuXuat Join ChiTietPhieuXuat on PX_Ma = CTPX_MaPhieuXuat) join KhachHang on PX_KhachHang = KH_Ma join NguoiDung on PX_NguoiLapPhieu = ND_Ma
                                                         where PX_Xoa = 'false' and CTPX_Xoa = 'false' and KH_Ma = '{0}' and Month(PX_Ngay) = '{1}' and Year(PX_Ngay) = '{2}'
                                                         group by PX_Ma, PX_Ngay, KH_Ten, ND_Ten", Ma, cbbThang.SelectedItem, cbbNam.SelectedItem))
                Dim frm As frmDanhSachPhieuXuat = New frmDanhSachPhieuXuat(dataTable)
                frm.ControlBox = True
                frm.dtpNgay1.Enabled = False
                frm.dtpNgay2.Enabled = False
                frm.btTimKiem.Enabled = False
                frm.btLamMoi.Enabled = False

                frm.ShowDialog()
            End If
        End If
    End Sub
End Class