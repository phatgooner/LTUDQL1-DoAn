Public Class frmNguoiDung
    Dim dsNguoiDung As DataTable
    Dim dsNguoiDungView As DataView

    Private Sub HienThiDanhSach()
        dsNguoiDung = XuLyDuLieu.DocDuLieu(String.Format("Select ND_Ma, ND_Ten, ND_NgaySinh, ND_GioiTinh, ND_DiaChi, VT_Ten, TK_TenDangNhap, ND_Xoa, ND_MaTaiKhoan 
            from NguoiDung join TaiKhoan on ND_MaTaiKhoan = TK_Ma join VaiTro on TK_VaiTro = VT_Ma
            where ND_Xoa = 'false' and VT_Xoa = 'false'"))
        dsNguoiDungView = New DataView(dsNguoiDung)
        dgvDanhSachNguoiDung.DataSource = dsNguoiDungView
    End Sub

    Private Sub ColumnEditing()
        dgvDanhSachNguoiDung.AllowUserToAddRows = False
        'Format
        dgvDanhSachNguoiDung.Columns(2).DefaultCellStyle.Format = "dd/MM/yyyy"
        dgvDanhSachNguoiDung.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgvDanhSachNguoiDung.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgvDanhSachNguoiDung.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgvDanhSachNguoiDung.Columns(7).Visible = False
        dgvDanhSachNguoiDung.Columns(8).Visible = False

        dgvDanhSachNguoiDung.Columns(0).HeaderText = "Mã người dùng"
        dgvDanhSachNguoiDung.Columns(1).HeaderText = "Tên người dùng"
        dgvDanhSachNguoiDung.Columns(2).HeaderText = "Ngày sinh"
        dgvDanhSachNguoiDung.Columns(3).HeaderText = "Giới tính"
        dgvDanhSachNguoiDung.Columns(4).HeaderText = "Địa chỉ"
        dgvDanhSachNguoiDung.Columns(5).HeaderText = "Vai trò - Chức vụ"
        dgvDanhSachNguoiDung.Columns(6).HeaderText = "Tên đăng nhập"
    End Sub

    Private Sub frmNguoiDung_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        HienThiDanhSach()
        ColumnEditing()
        If dgvDanhSachNguoiDung.Rows.Count > 0 Then
            btXoa.Enabled = True
            btSua.Enabled = True
        Else
            btXoa.Enabled = False
            btSua.Enabled = False
        End If
    End Sub

    Private Sub btTimKiem_Click(sender As Object, e As EventArgs) Handles btTimKiem.Click
        Dim frm As frmDanhSachNhanVien = New frmDanhSachNhanVien
        frm.ControlBox = True
        frm.ShowDialog()
    End Sub

    Private Sub btXoa_Click(sender As Object, e As EventArgs) Handles btXoa.Click
        Dim dr As DialogResult = MessageBox.Show("Bạn có chắc muốn xóa người dùng này?",
                                                 "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If dr = DialogResult.Yes Then
            If dgvDanhSachNguoiDung.SelectedCells.Count > 0 Then
                Dim Index As Integer = dgvDanhSachNguoiDung.SelectedCells(0).RowIndex
                Dim NguoiDungView As DataRowView = dgvDanhSachNguoiDung.Rows(Index).DataBoundItem
                Dim NguoiDung As DataRow = NguoiDungView.Row
                If NguoiDung("ND_Ma") = 1 Then
                    MessageBox.Show("Bạn không thể xóa người dùng mặc định!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    NguoiDung("ND_Xoa") = True
                    XuLyDuLieu.GhiDuLieu("NguoiDung", dsNguoiDung)
                    dsNguoiDung.Rows.Remove(NguoiDung)
                End If
            End If
            frmNguoiDung_Load(sender, e)
        End If
    End Sub

    Private Sub btThem_Click(sender As Object, e As EventArgs) Handles btThem.Click
        Dim frm As frmThietLapNguoiDung = New frmThietLapNguoiDung("add")
        frm.dtp_NgaySinh.MaxDate = Today
        frm.lbPassCu.Visible = False
        frm.tbPassCu.Visible = False
        frm.lbNote.Visible = False
        frm.btDoiPass.Visible = False
        frm.ShowDialog()
    End Sub

    Private Sub btSua_Click(sender As Object, e As EventArgs) Handles btSua.Click
        Dim ViTri As Integer = dgvDanhSachNguoiDung.SelectedCells(0).RowIndex
        Dim dsNDView As DataRowView = dgvDanhSachNguoiDung.Rows(ViTri).DataBoundItem
        Dim dsND As DataRow = dsNDView.Row
        Dim frm As frmThietLapNguoiDung = New frmThietLapNguoiDung("edit")
        frm.tbUsername.ReadOnly = True
        frm.tbPassMoi.Visible = False
        frm.tb_XacNhanPass.Visible = False
        frm.lbMKmoi.Visible = False
        frm.lbXacNhanMK.Visible = False

        frm.tbMaNguoiDung.Text = dsND("ND_Ma")
        frm.tbHoTen.Text = dsND("ND_Ten")
        frm.dtp_NgaySinh.Value = dsND("ND_NgaySinh")
        frm.tb_DiaChi.Text = dsND("ND_DiaChi")
        frm.cbbGioiTinh.Text = dsND("ND_GioiTinh")
        frm.tbUsername.Text = dsND("TK_TenDangNhap")
        frm.ShowDialog()
    End Sub
End Class