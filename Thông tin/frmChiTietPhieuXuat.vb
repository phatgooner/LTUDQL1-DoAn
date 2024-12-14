Public Class frmChiTietPhieuXuat
    Private Sub frmChiTietPhieuXuat_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvChiTietPhieuXuat.AllowUserToAddRows = False

        dgvChiTietPhieuXuat.Columns(0).HeaderText = "Tên sản phẩm"
        dgvChiTietPhieuXuat.Columns(1).HeaderText = "Đơn vị"
        dgvChiTietPhieuXuat.Columns(2).HeaderText = "Đơn giá (VNĐ)"
        dgvChiTietPhieuXuat.Columns(3).HeaderText = "Khuyến mãi"
        dgvChiTietPhieuXuat.Columns(4).HeaderText = "Số lượng"
        dgvChiTietPhieuXuat.Columns(5).HeaderText = "Thành tiền (VNĐ)"

        dgvChiTietPhieuXuat.Columns(2).DefaultCellStyle.Format = "#,##0"
        dgvChiTietPhieuXuat.Columns(5).DefaultCellStyle.Format = "#,##0"

        dgvChiTietPhieuXuat.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgvChiTietPhieuXuat.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgvChiTietPhieuXuat.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgvChiTietPhieuXuat.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dgvChiTietPhieuXuat.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
    End Sub
End Class