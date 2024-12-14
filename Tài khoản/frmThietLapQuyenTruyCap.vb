Public Class frmThietLapQuyenTruyCap
    Dim key As String
    Dim index As Integer
    Dim dsQuyen As DataTable
    Dim dsQuyenView As DataView

    Private Sub Lock()
        btThem.Focus()

        btThem.Enabled = True
        btLuu.Enabled = False
        cbbQuyen.Enabled = False
    End Sub

    Private Sub Unlock()
        btThem.Enabled = False
        btXoa.Enabled = False
        btLuu.Enabled = True
        cbbQuyen.Enabled = True
    End Sub

    Private Sub ColumnEditing()
        dgvDanhSachQuyen.AllowUserToAddRows = False
        dgvDanhSachQuyen.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

        dgvDanhSachQuyen.Columns(0).HeaderText = "Vai trò"
        dgvDanhSachQuyen.Columns(1).HeaderText = "Mã quyền"
        dgvDanhSachQuyen.Columns(2).HeaderText = "Tên quyền truy cập"
        dgvDanhSachQuyen.Columns(3).Visible = False
        dgvDanhSachQuyen.Columns(4).Visible = False
        dgvDanhSachQuyen.Columns(5).Visible = False
        dgvDanhSachQuyen.Columns(6).Visible = False

    End Sub

    Sub HienThiDanhSach()
        dsQuyen = XuLyDuLieu.DocDuLieu(String.Format("Select VT_Ten, Q_Ma, Q_Ten, VTQ_Ma, VTQ_Quyen, VTQ_VaiTro, VTQ_Xoa from VaiTro_Quyen join Quyen on VTQ_Quyen = Q_Ma join VaiTro on VTQ_VaiTro = VT_Ma where VTQ_VaiTro = '{0}' and VTQ_Xoa = 'false'", tbMaVaiTro.Text))
        dsQuyenView = New DataView(dsQuyen)
        dgvDanhSachQuyen.DataSource = dsQuyenView
    End Sub

    Private Sub frmThietLapQuyenTruyCap_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Lock()
        HienThiDanhSach()
        ColumnEditing()

        Dim dsCombobox As DataTable = XuLyDuLieu.DocDuLieu("Select * from Quyen where Q_Xoa = 'false'")
        cbbQuyen.DataSource = dsCombobox
        cbbQuyen.DisplayMember = "Q_Ten"
        cbbQuyen.ValueMember = "Q_Ma"

        If dgvDanhSachQuyen.Rows.Count > 0 Then
            btXoa.Enabled = True
        Else
            btXoa.Enabled = False
        End If
    End Sub

    Private Sub btThem_Click(sender As Object, e As EventArgs) Handles btThem.Click
        Unlock()
    End Sub

    Private Sub btXoa_Click(sender As Object, e As EventArgs) Handles btXoa.Click
        Dim dr As DialogResult = MessageBox.Show("Bạn có chắc muốn xóa quyền truy cập này ra khỏi vai trò?",
                                                 "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If dr = DialogResult.Yes Then
            If dgvDanhSachQuyen.SelectedCells.Count > 0 Then
                index = dgvDanhSachQuyen.SelectedCells(0).RowIndex
                Dim Quyen_View As DataRowView = dgvDanhSachQuyen.Rows(index).DataBoundItem
                Dim Quyen As DataRow = Quyen_View.Row
                Quyen("VTQ_Xoa") = True

                XuLyDuLieu.GhiDuLieu("VaiTro_Quyen", dsQuyen)
                dsQuyen.Rows.Remove(Quyen)

            Else
                MessageBox.Show("Anh chị vui lòng chọn quyền truy cập cần xóa!", "Thông báo")
            End If
            frmThietLapQuyenTruyCap_Load(sender, e)
        End If
    End Sub

    Private Function DuplicateCheck_OK() As Boolean
        For Each row As DataGridViewRow In dgvDanhSachQuyen.Rows
            If row.Cells("Q_Ma").Value = cbbQuyen.SelectedValue Then
                MessageBox.Show("Bạn không thể thêm quyền truy cập đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return False
            End If
        Next
        Return True
    End Function

    Private Sub btLuu_Click(sender As Object, e As EventArgs) Handles btLuu.Click
        If DuplicateCheck_OK() Then
            Dim ds As DataRow = dsQuyen.NewRow()
            ds("VTQ_VaiTro") = tbMaVaiTro.Text
            ds("VTQ_Quyen") = cbbQuyen.SelectedValue
            ds("VTQ_Xoa") = False

            dsQuyen.Rows.Add(ds)

            XuLyDuLieu.GhiDuLieu("VaiTro_Quyen", dsQuyen)
        End If
        frmThietLapQuyenTruyCap_Load(sender, e)
    End Sub
End Class