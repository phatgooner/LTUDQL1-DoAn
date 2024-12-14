Public Class frmDanhSachVaiTro
    Dim dsVaiTro As DataTable
    Dim dsVaiTroView As DataView

    Sub HienThiDanhSach(ByVal HienTatCa As Boolean)
        If HienTatCa Then
            dsVaiTro = XuLyDuLieu.DocDuLieu(String.Format("Select VT_Ma, VT_Ten, VT_MoTa from VaiTro"))
        Else
            dsVaiTro = XuLyDuLieu.DocDuLieu(String.Format("Select VT_Ma, VT_Ten, VT_MoTa from VaiTro where VT_Xoa = '{0}'", HienTatCa.ToString()))
        End If
        dsVaiTroView = New DataView(dsVaiTro)
        dgvDanhSachVaiTro.DataSource = dsVaiTroView
    End Sub

    Private Sub tbTimKiem_TextChanged(sender As Object, e As EventArgs) Handles tbTimKiem.TextChanged
        If tbTimKiem.Text = "" Then
            dsVaiTroView.RowFilter = ""
        Else
            dsVaiTroView.RowFilter = String.Format("VT_Ten like '%{0}%'", tbTimKiem.Text)
        End If
    End Sub

    Private Sub ColumnEditing()
        dgvDanhSachVaiTro.AllowUserToAddRows = False
        dgvDanhSachVaiTro.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

        If dgvDanhSachVaiTro.Columns.Count = 3 Then
            dgvDanhSachVaiTro.Columns(0).HeaderText = "Mã vai trò"
            dgvDanhSachVaiTro.Columns(1).HeaderText = "Tên vai trò"
            dgvDanhSachVaiTro.Columns(2).HeaderText = "Mô tả"

            Dim buttonColumn As New DataGridViewButtonColumn()
            buttonColumn.HeaderText = "Danh sách quyền truy cập"
            buttonColumn.Text = "Xem Chi Tiết"
            buttonColumn.Name = "btXemChiTiet"
            buttonColumn.UseColumnTextForButtonValue = True
            dgvDanhSachVaiTro.Columns.Add(buttonColumn)
        End If
    End Sub

    Private Sub dgvDanhSachVaiTro_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDanhSachVaiTro.CellContentClick
        If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
            Dim clickedCell As DataGridViewCell = dgvDanhSachVaiTro.Rows(e.RowIndex).Cells(e.ColumnIndex)
            If TypeOf clickedCell Is DataGridViewButtonCell Then
                Dim selectedRow As DataGridViewRow = dgvDanhSachVaiTro.Rows(e.RowIndex)
                Dim MaVaiTro As String = selectedRow.Cells(1).Value.ToString()
                Dim frm As frmXemChiTietQuyenTruyCap = New frmXemChiTietQuyenTruyCap()
                Dim dataTable As DataTable = XuLyDuLieu.DocDuLieu(String.Format("Select VT_Ten, Q_Ma, Q_Ten from VaiTro_Quyen join Quyen on VTQ_Quyen = Q_Ma join VaiTro on VTQ_VaiTro = VT_Ma where VTQ_VaiTro = '{0}' and VTQ_Xoa = 'false'", MaVaiTro))
                Dim dataView As DataView = New DataView(dataTable)
                frm.dgvDanhSachQuyen.DataSource = dataView
                frm.ShowDialog()
            End If
        End If
    End Sub

    Public Sub frmDanhSachVaiTro_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        HienThiDanhSach(cbHienTatCa.Checked)
        ColumnEditing()
    End Sub

    Private Sub cbHienTatCa_CheckedChanged(sender As Object, e As EventArgs) Handles cbHienTatCa.CheckedChanged
        HienThiDanhSach(cbHienTatCa.Checked)
    End Sub
End Class