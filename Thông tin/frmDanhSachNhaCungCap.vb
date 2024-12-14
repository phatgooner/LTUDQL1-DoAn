Public Class frmDanhSachNhaCungCap
    Dim dsNhaCungCap As DataTable
    Dim dsNhaCungCapView As DataView

    Private Sub ColumnEditing()
        dgvDanhSachNhaCungCap.AllowUserToAddRows = False
        dgvDanhSachNhaCungCap.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgvDanhSachNhaCungCap.Columns(6).Visible = False

        dgvDanhSachNhaCungCap.Columns(0).HeaderText = "Mã"
        dgvDanhSachNhaCungCap.Columns(1).HeaderText = "Tên"
        dgvDanhSachNhaCungCap.Columns(2).HeaderText = "Mô tả"
        dgvDanhSachNhaCungCap.Columns(3).HeaderText = "Địa chỉ"
        dgvDanhSachNhaCungCap.Columns(4).HeaderText = "Số điện thoại"
        dgvDanhSachNhaCungCap.Columns(5).HeaderText = "Người liên lạc"
    End Sub

    Sub HienThiDanhSach(ByVal HienTatCa As Boolean)
        If HienTatCa Then
            dsNhaCungCap = XuLyDuLieu.DocDuLieu(String.Format("Select * from NhaSanXuat"))
        Else
            dsNhaCungCap = XuLyDuLieu.DocDuLieu(String.Format("Select * from NhaSanXuat where NSX_Xoa = '{0}'", HienTatCa.ToString()))
        End If
        dsNhaCungCapView = New DataView(dsNhaCungCap)
        dgvDanhSachNhaCungCap.DataSource = dsNhaCungCapView
    End Sub

    Public Sub frmDanhSachNhaCungCap_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        HienThiDanhSach(cbHienTatCa.Checked)
        ColumnEditing()
    End Sub

    Private Sub cbHienTatCa_CheckedChanged(sender As Object, e As EventArgs) Handles cbHienTatCa.CheckedChanged
        HienThiDanhSach(cbHienTatCa.Checked)
    End Sub

    Private Sub tbTimKiem_TextChanged(sender As Object, e As EventArgs) Handles tbTimKiem.TextChanged
        If tbTimKiem.Text = "" Then
            dsNhaCungCapView.RowFilter = ""
        Else
            dsNhaCungCapView.RowFilter = String.Format("NSX_Ten like '%{0}%'", tbTimKiem.Text)
        End If
    End Sub
End Class