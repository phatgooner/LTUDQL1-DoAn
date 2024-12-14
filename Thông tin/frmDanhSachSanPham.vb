Public Class frmDanhSachSanPham
    Dim dsSanPham As DataTable
    Dim dsSanPhamView As DataView

    Private Sub ColumnEditing()
        dgvDanhSachSanPham.AllowUserToAddRows = False
        'Format
        dgvDanhSachSanPham.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgvDanhSachSanPham.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dgvDanhSachSanPham.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dgvDanhSachSanPham.Columns(5).DefaultCellStyle.Format = "#,##0"
        dgvDanhSachSanPham.Columns(6).DefaultCellStyle.Format = "#,##0"

        dgvDanhSachSanPham.Columns(0).HeaderText = "Mã sản phẩm"
        dgvDanhSachSanPham.Columns(1).HeaderText = "Tên sản phẩm"
        dgvDanhSachSanPham.Columns(2).HeaderText = "Mô tả"
        dgvDanhSachSanPham.Columns(3).HeaderText = "Loại hàng"
        dgvDanhSachSanPham.Columns(4).HeaderText = "Nhà sản xuất"
        dgvDanhSachSanPham.Columns(5).HeaderText = "Giá nhập (VNĐ)"
        dgvDanhSachSanPham.Columns(6).HeaderText = "Giá bán (VNĐ)"
    End Sub

    Public Sub frmDanhSachSanPham_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        HienThiDanhSach(cbHienTatCa.Checked)
        ColumnEditing()
    End Sub

    Sub HienThiDanhSach(ByVal HienTatCa As Boolean)
        If HienTatCa Then
            dsSanPham = XuLyDuLieu.DocDuLieu(String.Format("Select SP_Ma, SP_Ten, SP_MoTa, DM_Ten,
            NSX_Ten, SP_GiaNhap, SP_GiaBan from SanPham, DanhMuc, NhaSanXuat where SP_DanhMuc = DM_Ma 
            and SP_NhaSanXuat = NSX_Ma and DM_Xoa = 'false' and NSX_Xoa = 'false'"))
        Else
            dsSanPham = XuLyDuLieu.DocDuLieu(String.Format("Select SP_Ma, SP_Ten, SP_MoTa, DM_Ten,
            NSX_Ten, SP_GiaNhap, SP_GiaBan from SanPham, DanhMuc, NhaSanXuat where SP_DanhMuc = DM_Ma 
            and SP_NhaSanXuat = NSX_Ma and DM_Xoa = 'false' and NSX_Xoa = 'false' and SP_Xoa = '{0}'", HienTatCa.ToString()))
        End If
        dsSanPhamView = New DataView(dsSanPham)
        dgvDanhSachSanPham.DataSource = dsSanPhamView
    End Sub

    Private Sub cbHienTatCa_CheckedChanged(sender As Object, e As EventArgs) Handles cbHienTatCa.CheckedChanged
        HienThiDanhSach(cbHienTatCa.Checked)
    End Sub

    Private Sub tbTimKiem_TextChanged(sender As Object, e As EventArgs) Handles tbTimKiem.TextChanged
        If tbTimKiem.Text = "" Then
            dsSanPhamView.RowFilter = ""
        Else
            dsSanPhamView.RowFilter = String.Format("SP_Ten like '%{0}%'", tbTimKiem.Text)
        End If
    End Sub
End Class