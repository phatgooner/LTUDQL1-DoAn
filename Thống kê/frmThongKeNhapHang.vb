Public Class frmThongKeNhapHang
    Dim SoLuongNhap As DataTable
    Dim SoLuongNhap_View As DataView

    Sub HienThiDanhSach()
        SoLuongNhap = XuLyDuLieu.DocDuLieu(String.Format("select NSX_Ma, NSX_Ten, SUM(CTPN_ThanhTien) as TongSoTien
from PhieuNhap join NhaSanXuat on PN_NhaCungCap = NSX_Ma join ChiTietPhieuNhap on PN_Ma = CTPN_MaPhieuNhap
where PN_Xoa = 'false' and CTPN_Xoa = 'false' and Month(PN_Ngay) = '{0}' and YEAR(PN_Ngay) = '{1}'
group by NSX_Ma, NSX_Ten", cbbThang.SelectedItem, cbbNam.SelectedItem))
        SoLuongNhap_View = New DataView(SoLuongNhap)
        dgvThongKeSoLuong.DataSource = SoLuongNhap_View
    End Sub

    Private Sub ColumnEditing()
        dgvThongKeSoLuong.AllowUserToAddRows = False
        dgvThongKeSoLuong.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgvThongKeSoLuong.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dgvThongKeSoLuong.Columns(2).DefaultCellStyle.Format = "#,##0"

        dgvThongKeSoLuong.Columns(0).HeaderText = "Mã nhà cung cấp"
        dgvThongKeSoLuong.Columns(1).HeaderText = "Tên nhà cung cấp"
        dgvThongKeSoLuong.Columns(2).HeaderText = "Tổng giá trị nhập (VNĐ)"
        'Xem chi tiết
        Dim buttonColumn As New DataGridViewButtonColumn()
        buttonColumn.HeaderText = "Chi tiết"
        buttonColumn.Text = "Xem danh sách phiếu nhập"
        buttonColumn.Name = "btXemChiTiet"
        buttonColumn.UseColumnTextForButtonValue = True
        dgvThongKeSoLuong.Columns.Add(buttonColumn)
    End Sub

    Private Sub frmThongKeNhapHang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

    Private Sub dgvThongKeSoLuong_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvThongKeSoLuong.CellContentClick
        If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
            Dim clickedCell As DataGridViewCell = dgvThongKeSoLuong.Rows(e.RowIndex).Cells(e.ColumnIndex)
            If TypeOf clickedCell Is DataGridViewButtonCell Then
                Dim selectedRow As DataGridViewRow = dgvThongKeSoLuong.Rows(e.RowIndex)
                Dim Ma As String = selectedRow.Cells(1).Value.ToString()

                Dim dataTable As DataTable = XuLyDuLieu.DocDuLieu(String.Format("Select PN_Ma, PN_Ngay, NSX_Ten, SUM(CTPN_ThanhTien) AS GiaTri, ND_Ten
                                                         from (PhieuNhap Join ChiTietPhieuNhap on PN_Ma = CTPN_MaPhieuNhap) join NhaSanXuat on PN_NhaCungCap = NSX_Ma join NguoiDung on PN_NguoiLapPhieu = ND_Ma
                                                         where PN_Xoa = 'false' and CTPN_Xoa = 'false' and NSX_Ma = '{0}' and Month(PN_Ngay) = '{1}' and Year(PN_Ngay) = '{2}'
                                                         group by PN_Ma, PN_Ngay, NSX_Ten, ND_Ten", Ma, cbbThang.SelectedItem, cbbNam.SelectedItem))
                Dim frm As frmDanhSachPhieuNhap = New frmDanhSachPhieuNhap(dataTable)
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