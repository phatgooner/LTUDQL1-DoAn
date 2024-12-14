Public Class frmDanhSachLoaiHang
    Dim dsLoaiHang As DataTable
    Dim dsLoaiHangView As DataView


    Sub HienThiDanhSach(ByVal HienTatCa As Boolean)
        If HienTatCa Then
            dsLoaiHang = XuLyDuLieu.DocDuLieu(String.Format("Select DM_Ma, DM_Ten, DM_MoTa from DanhMuc"))
        Else
            dsLoaiHang = XuLyDuLieu.DocDuLieu(String.Format("Select DM_Ma, DM_Ten, DM_MoTa from DanhMuc where DM_Xoa = '{0}'", HienTatCa.ToString()))
        End If
        dsLoaiHangView = New DataView(dsLoaiHang)
        dgvDanhSachLoaiHang.DataSource = dsLoaiHangView
    End Sub

    Private Sub tbTimKiem_TextChanged(sender As Object, e As EventArgs) Handles tbTimKiem.TextChanged
        If tbTimKiem.Text = "" Then
            dsLoaiHangView.RowFilter = ""
        Else
            dsLoaiHangView.RowFilter = String.Format("DM_Ten like '%{0}%'", tbTimKiem.Text)
        End If
    End Sub

    Private Sub ColumnEditing()
        dgvDanhSachLoaiHang.AllowUserToAddRows = False
        dgvDanhSachLoaiHang.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

        If dgvDanhSachLoaiHang.Columns.Count = 3 Then
            dgvDanhSachLoaiHang.Columns(0).HeaderText = "Mã loại hàng"
            dgvDanhSachLoaiHang.Columns(1).HeaderText = "Tên loại hàng"
            dgvDanhSachLoaiHang.Columns(2).HeaderText = "Mô tả"

            Dim buttonColumn As New DataGridViewButtonColumn()
            buttonColumn.HeaderText = "Danh sách sản phẩm"
            buttonColumn.Text = "Xem Chi Tiết"
            buttonColumn.Name = "btXemChiTiet"
            buttonColumn.UseColumnTextForButtonValue = True
            dgvDanhSachLoaiHang.Columns.Add(buttonColumn)
        End If
    End Sub

    Public Sub frmDanhSachLoaiHang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        HienThiDanhSach(cbHienTatCa.Checked)
        ColumnEditing()
    End Sub

    Private Sub cbHienTatCa_CheckedChanged(sender As Object, e As EventArgs) Handles cbHienTatCa.CheckedChanged
        HienThiDanhSach(cbHienTatCa.Checked)
    End Sub

    Private Sub dgvDanhSachLoaiHang_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDanhSachLoaiHang.CellContentClick
        If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
            Dim clickedCell As DataGridViewCell = dgvDanhSachLoaiHang.Rows(e.RowIndex).Cells(e.ColumnIndex)
            If TypeOf clickedCell Is DataGridViewButtonCell Then
                Dim selectedRow As DataGridViewRow = dgvDanhSachLoaiHang.Rows(e.RowIndex)
                Dim MaLoaiHang As String = selectedRow.Cells(1).Value.ToString()
                Dim frm As frmXemChiTietSanPham = New frmXemChiTietSanPham()
                Dim dataTable As DataTable = XuLyDuLieu.DocDuLieu(String.Format("Select SP_Ma, SP_Ten, SP_MoTa, DM_Ten,
                NSX_Ten, SP_GiaNhap, SP_GiaBan from SanPham, DanhMuc, NhaSanXuat where SP_DanhMuc = DM_Ma 
                and SP_NhaSanXuat = NSX_Ma and SP_Xoa = 'false' and SP_DanhMuc = '{0}'", MaLoaiHang))
                Dim dataView As DataView = New DataView(dataTable)
                frm.dgvChiTietSanPham.DataSource = dataView
                frm.ShowDialog()
            End If
        End If
    End Sub
End Class