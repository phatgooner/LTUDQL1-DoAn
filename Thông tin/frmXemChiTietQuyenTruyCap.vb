Public Class frmXemChiTietQuyenTruyCap
    Private Sub frmXemChiTietQuyenTruyCap_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvDanhSachQuyen.AllowUserToAddRows = False
        dgvDanhSachQuyen.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

        dgvDanhSachQuyen.Columns(0).HeaderText = "Vai trò"
        dgvDanhSachQuyen.Columns(1).HeaderText = "Mã quyền"
        dgvDanhSachQuyen.Columns(2).HeaderText = "Tên quyền truy cập"
    End Sub
End Class