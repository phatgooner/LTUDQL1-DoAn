Public Class frmDanhSachKhachHang
    Dim dsKhachHang As DataTable
    Dim dsKhachHangView As DataView

    Private Sub ColumnEditing()
        dgvDanhSachKhachHang.AllowUserToAddRows = False
        dgvDanhSachKhachHang.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

        dgvDanhSachKhachHang.Columns(0).HeaderText = "Mã KH"
        dgvDanhSachKhachHang.Columns(1).HeaderText = "Tên KH"
        dgvDanhSachKhachHang.Columns(2).HeaderText = "Địa chỉ"
        dgvDanhSachKhachHang.Columns(3).HeaderText = "Email"
        dgvDanhSachKhachHang.Columns(4).HeaderText = "Số điện thoại"
        dgvDanhSachKhachHang.Columns(5).HeaderText = "Nhóm KH"
    End Sub

    Sub HienThiDanhSach(ByVal HienTatCa As Boolean)
        If HienTatCa Then
            dsKhachHang = XuLyDuLieu.DocDuLieu(String.Format("Select KH_Ma, KH_Ten, KH_DiaChi, KH_Email,
KH_SDT, NKH_Ten from KhachHang, NhomKhachHang where KH_NhomKH = NKH_Ma"))
        Else
            dsKhachHang = XuLyDuLieu.DocDuLieu(String.Format("Select KH_Ma, KH_Ten, KH_DiaChi, KH_Email,
KH_SDT, NKH_Ten from KhachHang, NhomKhachHang where KH_NhomKH = NKH_Ma and KH_Xoa = '{0}'", HienTatCa.ToString()))
        End If
        dsKhachHangView = New DataView(dsKhachHang)
        dgvDanhSachKhachHang.DataSource = dsKhachHangView
    End Sub

    Public Sub frmDanhSachKhachHang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        HienThiDanhSach(cbHienTatCa.Checked)
        ColumnEditing()
    End Sub

    Private Sub cbHienTatCa_CheckedChanged(sender As Object, e As EventArgs) Handles cbHienTatCa.CheckedChanged
        HienThiDanhSach(cbHienTatCa.Checked)
    End Sub

    Private Sub tbTimKiem_TextChanged(sender As Object, e As EventArgs) Handles tbTimKiem.TextChanged
        If tbTimKiem.Text = "" Then
            dsKhachHangView.RowFilter = ""
        Else
            dsKhachHangView.RowFilter = String.Format("KH_Ten like '%{0}%'", tbTimKiem.Text)
        End If
    End Sub
End Class