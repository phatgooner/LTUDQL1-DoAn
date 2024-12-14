Imports System.Globalization

Public Class frmDanhSachPhieuNhap
    Dim dsPhieuNhapView As DataView
    Dim dsPhieuNhap As DataTable

    Public Sub New(ByVal dataTable As DataTable)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        dsPhieuNhap = dataTable
    End Sub

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        dsPhieuNhap = XuLyDuLieu.DocDuLieu(String.Format("Select PN_Ma, PN_Ngay, NSX_Ten, SUM(CTPN_ThanhTien) AS GiaTri, ND_Ten
                                                         from (PhieuNhap Join ChiTietPhieuNhap on PN_Ma = CTPN_MaPhieuNhap) join NhaSanXuat on PN_NhaCungCap = NSX_Ma join NguoiDung on PN_NguoiLapPhieu = ND_Ma
                                                         where PN_Xoa = 'false' and CTPN_Xoa = 'false'
                                                         group by PN_Ma, PN_Ngay, NSX_Ten, ND_Ten"))
    End Sub

    Sub HienThiDanhSach(ByVal ds As DataTable)
        dsPhieuNhapView = New DataView(ds)
        dgvDanhSachPhieuNhap.DataSource = dsPhieuNhapView
    End Sub

    Private Sub ColumnEditing()
        If dgvDanhSachPhieuNhap.Columns.Count = 5 Then
            'Format
            dgvDanhSachPhieuNhap.Columns("PN_Ngay").DefaultCellStyle.Format = "dd/MM/yyyy"
            dgvDanhSachPhieuNhap.Columns(3).DefaultCellStyle.Format = "#,##0"
            dgvDanhSachPhieuNhap.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            dgvDanhSachPhieuNhap.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            dgvDanhSachPhieuNhap.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            dgvDanhSachPhieuNhap.AllowUserToAddRows = False
            'Header
            dgvDanhSachPhieuNhap.Columns(0).HeaderText = "Mã phiếu nhập"
            dgvDanhSachPhieuNhap.Columns(1).HeaderText = "Ngày tạo"
            dgvDanhSachPhieuNhap.Columns(2).HeaderText = "Nhà cung cấp"
            dgvDanhSachPhieuNhap.Columns(3).HeaderText = "Tổng giá trị (VNĐ)"
            dgvDanhSachPhieuNhap.Columns(4).HeaderText = "Người lập phiếu"
            'Xem chi tiết
            Dim buttonColumn As New DataGridViewButtonColumn()
            buttonColumn.HeaderText = "Thông tin"
            buttonColumn.Text = "Xem Chi Tiết"
            buttonColumn.Name = "btXemChiTiet"
            buttonColumn.UseColumnTextForButtonValue = True
            dgvDanhSachPhieuNhap.Columns.Add(buttonColumn)
        End If
    End Sub

    Public Sub frmDanhSachPhieuNhap_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        HienThiDanhSach(dsPhieuNhap)
        ColumnEditing()
    End Sub

    Private Sub dgvDanhSachPhieuNhap_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDanhSachPhieuNhap.CellContentClick
        If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
            Dim clickedCell As DataGridViewCell = dgvDanhSachPhieuNhap.Rows(e.RowIndex).Cells(e.ColumnIndex)
            If TypeOf clickedCell Is DataGridViewButtonCell Then
                Dim selectedRow As DataGridViewRow = dgvDanhSachPhieuNhap.Rows(e.RowIndex)
                Dim MaPhieuNhap As String = selectedRow.Cells("PN_Ma").Value.ToString()
                Dim NgayTaoPhieu As Date = selectedRow.Cells("PN_Ngay").Value
                Dim NhaCungCap As String = selectedRow.Cells("NSX_Ten").Value.ToString()
                Dim SoTien As Integer = selectedRow.Cells("GiaTri").Value
                Dim NguoiLapPhieu As String = selectedRow.Cells("ND_Ten").Value.ToString()

                Dim frm As frmChiTietPhieuNhap = New frmChiTietPhieuNhap()
                Dim dataTable As DataTable = XuLyDuLieu.DocDuLieu(String.Format("Select SP_Ten,
                CTPN_DonVi, CTPN_DonGia, CTPN_ChietKhau, CTPN_SoLuong, CTPN_ThanhTien from ChiTietPhieuNhap, SanPham
                where CTPN_MaSP = SP_Ma and CTPN_Xoa = 'false' and CTPN_MaPhieuNhap = '{0}'", MaPhieuNhap))
                Dim dataView As DataView = New DataView(dataTable)
                frm.dgvChiTietPhieuNhap.DataSource = dataView

                frm.lbMa.Text = MaPhieuNhap
                frm.lbNgay.Text = NgayTaoPhieu.ToString("dd/MM/yyyy")
                frm.lbTen.Text = NhaCungCap
                frm.lbTongSoTien.Text = "TỔNG CỘNG: " + SoTien.ToString("#,##0") + " (VNĐ)"
                frm.lbNguoiLapPhieu.Text = NguoiLapPhieu

                frm.ShowDialog()
            End If
        End If
    End Sub

    Private Sub btTimKiem_Click(sender As Object, e As EventArgs) Handles btTimKiem.Click
        Dim date1 As String = dtpNgay1.Value.ToString("yyyy/MM/dd")
        Dim date2 As String = dtpNgay2.Value.ToString("yyyy/MM/dd")

        dsPhieuNhap = XuLyDuLieu.DocDuLieu(String.Format("Select PN_Ma, PN_Ngay, NSX_Ten, SUM(CTPN_ThanhTien) AS GiaTri, ND_Ten
                                                         from (PhieuNhap Join ChiTietPhieuNhap on PN_Ma = CTPN_MaPhieuNhap) join NhaSanXuat on PN_NhaCungCap = NSX_Ma join NguoiDung on PN_NguoiLapPhieu = ND_Ma
                                                         where PN_Xoa = 'false' and PN_Ngay BETWEEN '{0}' AND '{1}'
                                                         group by PN_Ma, PN_Ngay, NSX_Ten, ND_Ten", date1, date2))
        dsPhieuNhapView = New DataView(dsPhieuNhap)
        dgvDanhSachPhieuNhap.DataSource = dsPhieuNhapView
    End Sub

    Private Sub btLamMoi_Click(sender As Object, e As EventArgs) Handles btLamMoi.Click
        dsPhieuNhap = XuLyDuLieu.DocDuLieu(String.Format("Select PN_Ma, PN_Ngay, NSX_Ten, SUM(CTPN_ThanhTien) AS GiaTri, ND_Ten
                                                         from (PhieuNhap Join ChiTietPhieuNhap on PN_Ma = CTPN_MaPhieuNhap) join NhaSanXuat on PN_NhaCungCap = NSX_Ma join NguoiDung on PN_NguoiLapPhieu = ND_Ma
                                                         where PN_Xoa = 'false' and CTPN_Xoa = 'false'
                                                         group by PN_Ma, PN_Ngay, NSX_Ten, ND_Ten"))
        dsPhieuNhapView = New DataView(dsPhieuNhap)
        dgvDanhSachPhieuNhap.DataSource = dsPhieuNhapView
    End Sub
End Class