Public Class frmQuyen_VaiTro
    Dim dsVaiTro As DataTable
    Dim dsVaiTroView As DataView
    Dim key As String
    Dim ten As String = ""
    Dim index As Integer

    Private Sub ColumnEditing()
        dgvDanhSachVaiTro.AllowUserToAddRows = False
        dgvDanhSachVaiTro.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

        If dgvDanhSachVaiTro.Columns.Count = 4 Then
            dgvDanhSachVaiTro.Columns(0).HeaderText = "Mã vai trò"
            dgvDanhSachVaiTro.Columns(1).HeaderText = "Tên vai trò"
            dgvDanhSachVaiTro.Columns(2).HeaderText = "Mô tả"
            dgvDanhSachVaiTro.Columns(3).Visible = False

            Dim buttonColumn As New DataGridViewButtonColumn()
            buttonColumn.HeaderText = "Quyền truy cập"
            buttonColumn.Text = "Thiết lập quyền truy cập"
            buttonColumn.Name = "btXemChiTiet"
            buttonColumn.UseColumnTextForButtonValue = True
            dgvDanhSachVaiTro.Columns.Add(buttonColumn)
        End If
    End Sub

    Sub HienThiDanhSach()
        dsVaiTro = XuLyDuLieu.DocDuLieu("Select * from VaiTro where VT_Xoa = 'false'")
        dsVaiTroView = New DataView(dsVaiTro)
        dgvDanhSachVaiTro.DataSource = dsVaiTroView
    End Sub

    Private Sub Lock()
        btThem.Focus()

        btThem.Enabled = True
        btLuu.Enabled = False
        btTimKiem.Enabled = True

        tb_Ten.ReadOnly = True
        tb_MoTa.ReadOnly = True
    End Sub

    Private Sub Unlock()
        tb_Ten.Focus()

        btThem.Enabled = False
        btXoa.Enabled = False
        btSua.Enabled = False
        btLuu.Enabled = True
        btTimKiem.Enabled = False

        tb_Ten.ReadOnly = False
        tb_MoTa.ReadOnly = False
    End Sub

    Private Sub btTimKiem_Click(sender As Object, e As EventArgs) Handles btTimKiem.Click
        Dim frm As frmDanhSachVaiTro = New frmDanhSachVaiTro
        frm.frmDanhSachVaiTro_Load(sender, e)
        frm.ShowDialog()
    End Sub

    Private Sub frmQuyen_VaiTro_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Lock()
        HienThiDanhSach()
        ColumnEditing()
        If dgvDanhSachVaiTro.Rows.Count > 0 Then
            btXoa.Enabled = True
            btSua.Enabled = True
        Else
            btXoa.Enabled = False
            btSua.Enabled = False
        End If
    End Sub

    Private Sub dgvDanhSachVaiTro_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDanhSachVaiTro.CellContentClick
        If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
            Dim clickedCell As DataGridViewCell = dgvDanhSachVaiTro.Rows(e.RowIndex).Cells(e.ColumnIndex)
            If TypeOf clickedCell Is DataGridViewButtonCell Then
                Dim selectedRow As DataGridViewRow = dgvDanhSachVaiTro.Rows(e.RowIndex)
                Dim MaVaiTro As String = selectedRow.Cells(1).Value.ToString()
                If MaVaiTro = 1 Then
                    Dim form As frmXemChiTietQuyenTruyCap = New frmXemChiTietQuyenTruyCap()
                    Dim dataTable As DataTable = XuLyDuLieu.DocDuLieu(String.Format("Select VT_Ten, Q_Ma, Q_Ten from VaiTro_Quyen join Quyen on VTQ_Quyen = Q_Ma join VaiTro on VTQ_VaiTro = VT_Ma where VTQ_VaiTro = '{0}' and VTQ_Xoa = 'false'", MaVaiTro))
                    Dim dataView As DataView = New DataView(dataTable)
                    form.dgvDanhSachQuyen.DataSource = dataView
                    form.ShowDialog()
                Else
                    Dim frm As frmThietLapQuyenTruyCap = New frmThietLapQuyenTruyCap()
                    frm.tbMaVaiTro.Text = MaVaiTro
                    frm.ShowDialog()
                End If
            End If
        End If
    End Sub

    Private Sub btThem_Click(sender As Object, e As EventArgs) Handles btThem.Click
        Unlock()
        key = "add"

        tb_Ma.Clear()
        tb_Ten.Clear()
        tb_MoTa.Clear()
    End Sub

    Private Sub dgvDanhSachVaiTro_SelectionChanged(sender As Object, e As EventArgs) Handles dgvDanhSachVaiTro.SelectionChanged
        If dgvDanhSachVaiTro.SelectedCells.Count > 0 Then
            index = dgvDanhSachVaiTro.SelectedCells(0).RowIndex
            Dim VaiTroView As DataRowView = dgvDanhSachVaiTro.Rows(index).DataBoundItem
            If Not (VaiTroView Is Nothing) Then
                Dim VaiTro As DataRow = VaiTroView.Row
                tb_Ma.Text = VaiTro("VT_Ma")
                tb_Ten.Text = VaiTro("VT_Ten")
                tb_MoTa.Text = VaiTro("VT_MoTa")
            End If
        End If
    End Sub

    Private Sub btSua_Click(sender As Object, e As EventArgs) Handles btSua.Click
        Unlock()
        key = "edit"
        index = dgvDanhSachVaiTro.SelectedCells(0).RowIndex
        Dim VaiTroView As DataRowView = dgvDanhSachVaiTro.Rows(index).DataBoundItem
        Dim VaiTro As DataRow = VaiTroView.Row
        ten = VaiTro("VT_Ten")
        If VaiTro("VT_Ma") = 1 Then
            tb_Ten.ReadOnly = True
        End If
    End Sub

    Private Sub btXoa_Click(sender As Object, e As EventArgs) Handles btXoa.Click
        Dim dr As DialogResult = MessageBox.Show("Việc này dẫn đến những tài khoản có vai trò này sẽ bị mất, bạn có chắc muốn xóa vai trò này?",
                                                 "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If dr = DialogResult.Yes Then
            If dgvDanhSachVaiTro.SelectedCells.Count > 0 Then
                index = dgvDanhSachVaiTro.SelectedCells(0).RowIndex
                Dim VaiTroView As DataRowView = dgvDanhSachVaiTro.Rows(index).DataBoundItem
                Dim VaiTro As DataRow = VaiTroView.Row
                If VaiTro("VT_Ma") = 1 Then
                    MessageBox.Show("Bạn không thể xóa vai trò mặc định!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    VaiTro("VT_Xoa") = True
                    XuLyDuLieu.GhiDuLieu("VaiTro", dsVaiTro)
                    dsVaiTro.Rows.Remove(VaiTro)
                End If
            Else
                MessageBox.Show("Anh chị vui lòng chọn vai trò cần xóa!", "Thông báo")
            End If
            frmQuyen_VaiTro_Load(sender, e)
        End If
    End Sub

    Private Function NullCheck_OK() As Boolean
        If String.IsNullOrWhiteSpace(tb_Ten.Text) Then
            MessageBox.Show("Bạn chưa nhập tên vai trò", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If
        Return True
    End Function

    Private Function DuplicateCheck_OK(ByVal TenVT As String) As Boolean
        If (Not String.IsNullOrEmpty(ten)) And ten.ToUpper = TenVT.ToUpper Then
            Return True
        End If
        For Each row As DataGridViewRow In dgvDanhSachVaiTro.Rows
            If row.Cells(2).Value.ToString.ToUpper = TenVT.ToUpper Then
                MessageBox.Show("Bạn không thể nhập tên trùng với tên vai trò đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return False
            End If
        Next
        Return True
    End Function

    Private Sub btLuu_Click(sender As Object, e As EventArgs) Handles btLuu.Click
        If key = "add" Then
            If NullCheck_OK() And DuplicateCheck_OK(tb_Ten.Text) Then
                Dim VaiTro As DataRow = dsVaiTro.NewRow()
                VaiTro("VT_Ten") = tb_Ten.Text
                VaiTro("VT_MoTa") = tb_MoTa.Text
                VaiTro("VT_Xoa") = False

                dsVaiTro.Rows.Add(VaiTro)

                XuLyDuLieu.GhiDuLieu("VaiTro", dsVaiTro)
            End If
        ElseIf key = "edit" Then
            If NullCheck_OK() And DuplicateCheck_OK(tb_Ten.Text) Then
                Dim ViTri As Integer = dgvDanhSachVaiTro.SelectedCells(0).RowIndex
                Dim VaiTroView As DataRowView = dgvDanhSachVaiTro.Rows(ViTri).DataBoundItem
                Dim VaiTro As DataRow = VaiTroView.Row
                VaiTro("VT_Ten") = tb_Ten.Text
                VaiTro("VT_MoTa") = tb_MoTa.Text

                XuLyDuLieu.GhiDuLieu("VaiTro", dsVaiTro)
            End If
        End If
        frmQuyen_VaiTro_Load(sender, e)
    End Sub
End Class