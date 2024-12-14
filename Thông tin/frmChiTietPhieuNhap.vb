Public Class frmChiTietPhieuNhap
    Private Sub frmChiTietPhieuNhap_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvChiTietPhieuNhap.AllowUserToAddRows = False

        dgvChiTietPhieuNhap.Columns(0).HeaderText = "Tên sản phẩm"
        dgvChiTietPhieuNhap.Columns(1).HeaderText = "Đơn vị"
        dgvChiTietPhieuNhap.Columns(2).HeaderText = "Đơn giá (VNĐ)"
        dgvChiTietPhieuNhap.Columns(3).HeaderText = "Chiết khấu"
        dgvChiTietPhieuNhap.Columns(4).HeaderText = "Số lượng"
        dgvChiTietPhieuNhap.Columns(5).HeaderText = "Thành tiền (VNĐ)"

        dgvChiTietPhieuNhap.Columns(2).DefaultCellStyle.Format = "#,##0"
        dgvChiTietPhieuNhap.Columns(5).DefaultCellStyle.Format = "#,##0"

        dgvChiTietPhieuNhap.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgvChiTietPhieuNhap.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgvChiTietPhieuNhap.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgvChiTietPhieuNhap.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dgvChiTietPhieuNhap.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
    End Sub
End Class