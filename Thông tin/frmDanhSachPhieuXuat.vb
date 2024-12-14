Public Class frmDanhSachPhieuXuat
    Dim dsPhieuXuat As DataTable
    Dim dsPhieuXuatView As DataView

    Public Sub New(ByVal data As DataTable)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        dsPhieuXuat = data
    End Sub

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        dsPhieuXuat = XuLyDuLieu.DocDuLieu(String.Format("Select PX_Ma, PX_Ngay, KH_Ten, SUM(CTPX_ThanhTien) AS GiaTri, ND_Ten
                                                         from (PhieuXuat Join ChiTietPhieuXuat on PX_Ma = CTPX_MaPhieuXuat) join KhachHang on PX_KhachHang = KH_Ma join NguoiDung on PX_NguoiLapPhieu = ND_Ma
                                                         where PX_Xoa = 'false' and CTPX_Xoa = 'false'
                                                         group by PX_Ma, PX_Ngay, KH_Ten, ND_Ten"))
    End Sub

    Sub HienThiDanhSach(ByVal ds As DataTable)
        dsPhieuXuatView = New DataView(ds)
        dgvDanhSachPhieuXuat.DataSource = dsPhieuXuatView
    End Sub

    Private Sub ColumnEditing()
        If dgvDanhSachPhieuXuat.Columns.Count = 5 Then
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

            'Xem chi tiết
            Dim buttonColumn As New DataGridViewButtonColumn()
            buttonColumn.HeaderText = "Thông tin"
            buttonColumn.Text = "Xem Chi Tiết"
            buttonColumn.Name = "btXemChiTiet"
            buttonColumn.UseColumnTextForButtonValue = True
            dgvDanhSachPhieuXuat.Columns.Add(buttonColumn)
        End If
    End Sub

    Public Sub frmDanhSachPhieuXuat_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        HienThiDanhSach(dsPhieuXuat)
        ColumnEditing()
    End Sub

    Private Sub dgvDanhSachPhieuXuat_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgvDanhSachPhieuXuat.CellFormatting
        If dgvDanhSachPhieuXuat.Columns(e.ColumnIndex).Name = "PX_Ngay" AndAlso e.Value IsNot Nothing Then
            e.Value = CType(e.Value, DateTime).ToString("dd/MM/yyyy")
            e.FormattingApplied = True
        End If
    End Sub

    Private Sub dgvDanhSachPhieuXuat_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDanhSachPhieuXuat.CellContentClick
        If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
            Dim clickedCell As DataGridViewCell = dgvDanhSachPhieuXuat.Rows(e.RowIndex).Cells(e.ColumnIndex)
            If TypeOf clickedCell Is DataGridViewButtonCell Then
                Dim selectedRow As DataGridViewRow = dgvDanhSachPhieuXuat.Rows(e.RowIndex)
                Dim MaPhieu As String = selectedRow.Cells("PX_Ma").Value.ToString()
                Dim NgayTaoPhieu As Date = selectedRow.Cells("PX_Ngay").Value
                Dim KhachHang As String = selectedRow.Cells("KH_Ten").Value.ToString()
                Dim SoTien As Integer = selectedRow.Cells("GiaTri").Value
                Dim NguoiLapPhieu As String = selectedRow.Cells("ND_Ten").Value.ToString()

                Dim frm As frmChiTietPhieuXuat = New frmChiTietPhieuXuat()
                Dim dataTable As DataTable = XuLyDuLieu.DocDuLieu(String.Format("Select SP_Ten,
                CTPX_DonVi, CTPX_DonGia, CTPX_KhuyenMai, CTPX_SoLuong, CTPX_ThanhTien from ChiTietPhieuXuat, SanPham
                where CTPX_MaSP = SP_Ma and CTPX_Xoa = 'false' and CTPX_MaPhieuXuat = '{0}'", MaPhieu))
                Dim dataView As DataView = New DataView(dataTable)
                frm.dgvChiTietPhieuXuat.DataSource = dataView

                frm.lbMa.Text = MaPhieu
                frm.lbNgay.Text = NgayTaoPhieu.ToString("dd/MM/yyyy")
                frm.lbTen.Text = KhachHang
                frm.lbTongSoTien.Text = "TỔNG CỘNG: " + SoTien.ToString("#,##0") + " (VNĐ)"
                frm.lbNguoiLapPhieu.Text = NguoiLapPhieu

                frm.ShowDialog()
            End If
        End If
    End Sub

    Private Sub btTimKiem_Click(sender As Object, e As EventArgs) Handles btTimKiem.Click
        Dim date1 As String = dtpNgay1.Value.ToString("yyyy/MM/dd")
        Dim date2 As String = dtpNgay2.Value.ToString("yyyy/MM/dd")

        dsPhieuXuat = XuLyDuLieu.DocDuLieu(String.Format("Select PX_Ma, PX_Ngay, KH_Ten, SUM(CTPX_ThanhTien) AS GiaTri, ND_Ten
                                                         from (PhieuXuat Join ChiTietPhieuXuat on PX_Ma = CTPX_MaPhieuXuat) join KhachHang on PX_KhachHang = KH_Ma join NguoiDung on PX_NguoiLapPhieu = ND_Ma
                                                         where PX_Xoa = 'false' and PX_Ngay BETWEEN '{0}' AND '{1}'
                                                         group by PX_Ma, PX_Ngay, KH_Ten, ND_Ten", date1, date2))
        dsPhieuXuatView = New DataView(dsPhieuXuat)
        dgvDanhSachPhieuXuat.DataSource = dsPhieuXuatView
    End Sub

    Private Sub btLamMoi_Click(sender As Object, e As EventArgs) Handles btLamMoi.Click
        dsPhieuXuat = XuLyDuLieu.DocDuLieu(String.Format("Select PX_Ma, PX_Ngay, KH_Ten, SUM(CTPX_ThanhTien) AS GiaTri, ND_Ten
                                                         from (PhieuXuat Join ChiTietPhieuXuat on PX_Ma = CTPX_MaPhieuXuat) join KhachHang on PX_KhachHang = KH_Ma join NguoiDung on PX_NguoiLapPhieu = ND_Ma
                                                         where PX_Xoa = 'false' and CTPX_Xoa = 'false'
                                                         group by PX_Ma, PX_Ngay, KH_Ten, ND_Ten"))
        dsPhieuXuatView = New DataView(dsPhieuXuat)
        dgvDanhSachPhieuXuat.DataSource = dsPhieuXuatView
    End Sub
End Class