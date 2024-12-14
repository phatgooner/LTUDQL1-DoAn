Public Class frmXemChiTietSanPham

    Private Sub frmXemChiTietSanPham_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvChiTietSanPham.AllowUserToAddRows = False

        dgvChiTietSanPham.Columns(0).HeaderText = "Mã sản phẩm"
        dgvChiTietSanPham.Columns(1).HeaderText = "Tên sản phẩm"
        dgvChiTietSanPham.Columns(2).HeaderText = "Mô tả"
        dgvChiTietSanPham.Columns(3).HeaderText = "Loại hàng"
        dgvChiTietSanPham.Columns(4).HeaderText = "Nhà sản xuất"
        dgvChiTietSanPham.Columns(5).HeaderText = "Giá nhập (VNĐ)"
        dgvChiTietSanPham.Columns(6).HeaderText = "Giá bán (VNĐ)"

        dgvChiTietSanPham.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgvChiTietSanPham.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dgvChiTietSanPham.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dgvChiTietSanPham.Columns(5).DefaultCellStyle.Format = "#,##0"
        dgvChiTietSanPham.Columns(6).DefaultCellStyle.Format = "#,##0"

    End Sub
End Class