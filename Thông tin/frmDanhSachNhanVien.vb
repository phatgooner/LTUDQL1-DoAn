Public Class frmDanhSachNhanVien
    Dim dsNhanVien As DataTable
    Dim dsNhanVienView As DataView

    Private Sub ColumnEditing()
        dgvDanhSachNhanVien.AllowUserToAddRows = False
        'Format
        dgvDanhSachNhanVien.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgvDanhSachNhanVien.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgvDanhSachNhanVien.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgvDanhSachNhanVien.Columns(2).DefaultCellStyle.Format = "dd/MM/yyyy"



        dgvDanhSachNhanVien.Columns(0).HeaderText = "Mã nhân viên"
        dgvDanhSachNhanVien.Columns(1).HeaderText = "Tên nhân viên"
        dgvDanhSachNhanVien.Columns(2).HeaderText = "Ngày sinh"
        dgvDanhSachNhanVien.Columns(3).HeaderText = "Giới tính"
        dgvDanhSachNhanVien.Columns(4).HeaderText = "Địa chỉ"
        dgvDanhSachNhanVien.Columns(5).HeaderText = "Vai trò - Chức vụ"
    End Sub

    Sub HienThiDanhSach(ByVal HienTatCa As Boolean)
        If HienTatCa Then
            dsNhanVien = XuLyDuLieu.DocDuLieu(String.Format("Select ND_Ma, ND_Ten, ND_NgaySinh, ND_GioiTinh, ND_DiaChi, VT_Ten 
            from NguoiDung join TaiKhoan on ND_MaTaiKhoan = TK_Ma join VaiTro on TK_VaiTro = VT_Ma"))
        Else
            dsNhanVien = XuLyDuLieu.DocDuLieu(String.Format("Select ND_Ma, ND_Ten, ND_NgaySinh, ND_GioiTinh, ND_DiaChi, VT_Ten 
            from NguoiDung join TaiKhoan on ND_MaTaiKhoan = TK_Ma join VaiTro on TK_VaiTro = VT_Ma
            where ND_Xoa = '{0}' and VT_Xoa = '{0}'", HienTatCa.ToString()))
        End If
        dsNhanVienView = New DataView(dsNhanVien)
        dgvDanhSachNhanVien.DataSource = dsNhanVienView
    End Sub

    Private Sub cbHienTatCa_CheckedChanged(sender As Object, e As EventArgs) Handles cbHienTatCa.CheckedChanged
        HienThiDanhSach(cbHienTatCa.Checked)
    End Sub

    Private Sub frmDanhSachNhanVien_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        HienThiDanhSach(cbHienTatCa.Checked)
        ColumnEditing()
    End Sub

    Private Sub tbTimKiem_TextChanged(sender As Object, e As EventArgs) Handles tbTimKiem.TextChanged
        If tbTimKiem.Text = "" Then
            dsNhanVienView.RowFilter = ""
        Else
            dsNhanVienView.RowFilter = String.Format("ND_Ten like '%{0}%'", tbTimKiem.Text)
        End If
    End Sub
End Class