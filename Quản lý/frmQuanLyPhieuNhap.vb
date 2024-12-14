Public Class frmQuanLyPhieuNhap
    Dim dsPhieuNhap As DataTable
    Dim dsPhieuNhapView As DataView

    Private Sub HienThiDanhSach()
        dsPhieuNhap = XuLyDuLieu.DocDuLieu(String.Format("Select PN_Ma, PN_Ngay, NSX_Ten, SUM(CTPN_ThanhTien) AS GiaTri, ND_Ten, PN_Xoa, PN_NhaCungCap, PN_NguoiLapPhieu
                                                         from (PhieuNhap Join ChiTietPhieuNhap on PN_Ma = CTPN_MaPhieuNhap) join NhaSanXuat on PN_NhaCungCap = NSX_Ma join NguoiDung on PN_NguoiLapPhieu = ND_Ma
                                                         where PN_Xoa = 'false' and CTPN_Xoa = 'false'
                                                         group by PN_Ma, PN_Ngay, NSX_Ten, ND_Ten, PN_Xoa, PN_NhaCungCap, PN_NguoiLapPhieu"))
        dsPhieuNhapView = New DataView(dsPhieuNhap)
        dgvDanhSachPhieuNhap.DataSource = dsPhieuNhapView
    End Sub

    Private Sub ColumnEditing()
        If dgvDanhSachPhieuNhap.Columns.Count = 8 Then
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
            dgvDanhSachPhieuNhap.Columns(5).Visible = False
            dgvDanhSachPhieuNhap.Columns(6).Visible = False
            dgvDanhSachPhieuNhap.Columns(7).Visible = False
            'Xem chi tiết
            Dim buttonColumn As New DataGridViewButtonColumn()
            buttonColumn.HeaderText = "Thông tin"
            buttonColumn.Text = "Xem Chi Tiết"
            buttonColumn.Name = "btXemChiTiet"
            buttonColumn.UseColumnTextForButtonValue = True
            dgvDanhSachPhieuNhap.Columns.Add(buttonColumn)
        End If
    End Sub

    Public Sub frmQuanLyPhieuNhap_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        HienThiDanhSach()
        ColumnEditing()
        If dgvDanhSachPhieuNhap.Rows.Count > 0 Then
            btXoa.Enabled = True
            btSua.Enabled = True
        Else
            btXoa.Enabled = False
            btSua.Enabled = False
        End If
    End Sub

    Private Sub dgvDanhSachPhieuNhap_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDanhSachPhieuNhap.CellContentClick
        If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
            Dim clickedCell As DataGridViewCell = dgvDanhSachPhieuNhap.Rows(e.RowIndex).Cells(e.ColumnIndex)
            If TypeOf clickedCell Is DataGridViewButtonCell Then
                Dim selectedRow As DataGridViewRow = dgvDanhSachPhieuNhap.Rows(e.RowIndex)
                Dim MaPhieuNhap As String = selectedRow.Cells(1).Value.ToString()
                Dim NgayTaoPhieu As Date = selectedRow.Cells(2).Value
                Dim NhaCungCap As String = selectedRow.Cells(3).Value.ToString()
                Dim SoTien As Integer = selectedRow.Cells(4).Value
                Dim NguoiLapPhieu As String = selectedRow.Cells(5).Value.ToString()

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
        Dim frm As frmDanhSachPhieuNhap = New frmDanhSachPhieuNhap
        frm.ControlBox = True
        frm.StartPosition = FormStartPosition.CenterScreen
        frm.frmDanhSachPhieuNhap_Load(sender, e)
        frm.ShowDialog()
    End Sub

    Private Sub btThem_Click(sender As Object, e As EventArgs) Handles btThem.Click
        Dim frm As frmChinhSuaPhieuNhap = New frmChinhSuaPhieuNhap("add")
        frm.dtp_NgayTaoPhieu.Value = Today
        frm.ShowDialog()
    End Sub

    Private Sub btSua_Click(sender As Object, e As EventArgs) Handles btSua.Click
        Dim ViTri As Integer = dgvDanhSachPhieuNhap.SelectedCells(0).RowIndex
        Dim dsPNView As DataRowView = dgvDanhSachPhieuNhap.Rows(ViTri).DataBoundItem
        Dim dsPN As DataRow = dsPNView.Row
        Dim frm As frmChinhSuaPhieuNhap = New frmChinhSuaPhieuNhap("edit")
        frm.dtp_NgayTaoPhieu.Value = dsPN("PN_Ngay")
        frm.tbMaPhieu.Text = dsPN("PN_Ma")
        frm.ShowDialog()
    End Sub

    Private Sub btXoa_Click(sender As Object, e As EventArgs) Handles btXoa.Click
        Dim dr As DialogResult = MessageBox.Show("Bạn có chắc muốn xóa phiếu nhập này?",
                                                 "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If dr = DialogResult.Yes Then
            If dgvDanhSachPhieuNhap.SelectedCells.Count > 0 Then
                Dim Index As Integer = dgvDanhSachPhieuNhap.SelectedCells(0).RowIndex
                Dim PhieuNhapView As DataRowView = dgvDanhSachPhieuNhap.Rows(Index).DataBoundItem
                Dim PhieuNhap As DataRow = PhieuNhapView.Row
                PhieuNhap("PN_Xoa") = True

                XuLyDuLieu.GhiDuLieu("PhieuNhap", dsPhieuNhap)
                dsPhieuNhap.Rows.Remove(PhieuNhap)
            Else
                MessageBox.Show("Anh chị vui lòng chọn phiếu nhập cần xóa!", "Thông báo")
            End If
            frmQuanLyPhieuNhap_Load(sender, e)
        End If
    End Sub
End Class