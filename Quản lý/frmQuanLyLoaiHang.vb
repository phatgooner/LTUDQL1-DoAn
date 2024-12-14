Public Class frmQuanLyLoaiHang
    Dim dsLoaiHang As DataTable
    Dim dsLoaiHangView As DataView
    Dim key As String
    Dim ten As String = ""
    Dim index As Integer

    Private Sub ColumnEditing()
        dgvDanhSachLoaiHang.AllowUserToAddRows = False
        dgvDanhSachLoaiHang.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

        If dgvDanhSachLoaiHang.Columns.Count = 4 Then
            dgvDanhSachLoaiHang.Columns(0).HeaderText = "Mã loại hàng"
            dgvDanhSachLoaiHang.Columns(1).HeaderText = "Tên loại hàng"
            dgvDanhSachLoaiHang.Columns(2).HeaderText = "Mô tả"
            dgvDanhSachLoaiHang.Columns(3).Visible = False

            Dim buttonColumn As New DataGridViewButtonColumn()
            buttonColumn.HeaderText = "Danh sách sản phẩm"
            buttonColumn.Text = "Xem Chi Tiết"
            buttonColumn.Name = "btXemChiTiet"
            buttonColumn.UseColumnTextForButtonValue = True
            dgvDanhSachLoaiHang.Columns.Add(buttonColumn)
        End If
    End Sub

    Sub HienThiDanhSach()
        dsLoaiHang = XuLyDuLieu.DocDuLieu("Select * from DanhMuc where DM_Xoa = 'false'")
        dsLoaiHangView = New DataView(dsLoaiHang)
        dgvDanhSachLoaiHang.DataSource = dsLoaiHangView
    End Sub

    Private Sub Lock()
        btThem.Focus()

        btThem.Enabled = True
        btLuu.Enabled = False
        btTimKiem.Enabled = True

        tb_Ma.ReadOnly = True
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

        tb_Ma.ReadOnly = True
        tb_Ten.ReadOnly = False
        tb_MoTa.ReadOnly = False
    End Sub

    Private Sub frmQuanLyLoaiHang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Lock()
        HienThiDanhSach()
        ColumnEditing()
        If dgvDanhSachLoaiHang.Rows.Count > 0 Then
            btXoa.Enabled = True
            btSua.Enabled = True
        Else
            btXoa.Enabled = False
            btSua.Enabled = False
        End If
    End Sub

    Private Sub btTimKiem_Click(sender As Object, e As EventArgs) Handles btTimKiem.Click
        Dim frm As frmDanhSachLoaiHang = New frmDanhSachLoaiHang
        frm.ControlBox = True
        frm.StartPosition = FormStartPosition.CenterScreen
        frm.frmDanhSachLoaiHang_Load(sender, e)
        frm.ShowDialog()
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

    Private Sub btThem_Click(sender As Object, e As EventArgs) Handles btThem.Click
        Unlock()
        key = "add"

        tb_Ma.Clear()
        tb_Ten.Clear()
        tb_MoTa.Clear()
    End Sub

    Private Sub dgvDanhSachLoaiHang_SelectionChanged(sender As Object, e As EventArgs) Handles dgvDanhSachLoaiHang.SelectionChanged
        If dgvDanhSachLoaiHang.SelectedCells.Count > 0 Then
            index = dgvDanhSachLoaiHang.SelectedCells(0).RowIndex
            Dim DanhMucView As DataRowView = dgvDanhSachLoaiHang.Rows(index).DataBoundItem
            If Not (DanhMucView Is Nothing) Then
                Dim DanhMuc As DataRow = DanhMucView.Row
                tb_Ma.Text = DanhMuc("DM_Ma")
                tb_Ten.Text = DanhMuc("DM_Ten")
                tb_MoTa.Text = DanhMuc("DM_MoTa")
            End If
        End If
    End Sub

    Private Sub btSua_Click(sender As Object, e As EventArgs) Handles btSua.Click
        Unlock()
        key = "edit"
        index = dgvDanhSachLoaiHang.SelectedCells(0).RowIndex
        Dim LoaiHangView As DataRowView = dgvDanhSachLoaiHang.Rows(index).DataBoundItem
        Dim LoaiHang As DataRow = LoaiHangView.Row
        ten = LoaiHang("DM_Ten")
    End Sub

    Private Sub btXoa_Click(sender As Object, e As EventArgs) Handles btXoa.Click
        Dim dr As DialogResult = MessageBox.Show("Việc này dẫn đến các sản phẩm thuộc loại hàng này sẽ bị mất, bạn có chắc muốn xóa loại hàng này?",
                                                 "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If dr = DialogResult.Yes Then
            If dgvDanhSachLoaiHang.SelectedCells.Count > 0 Then
                index = dgvDanhSachLoaiHang.SelectedCells(0).RowIndex
                Dim DanhMucView As DataRowView = dgvDanhSachLoaiHang.Rows(index).DataBoundItem
                Dim DanhMuc As DataRow = DanhMucView.Row
                DanhMuc("DM_Xoa") = True

                XuLyDuLieu.GhiDuLieu("DanhMuc", dsLoaiHang)
                dsLoaiHang.Rows.Remove(DanhMuc)
            Else
                MessageBox.Show("Anh chị vui lòng chọn danh mục cần xóa!", "Thông báo")
            End If
            frmQuanLyLoaiHang_Load(sender, e)
        End If
    End Sub

    Private Function NullCheck_OK() As Boolean
        If String.IsNullOrWhiteSpace(tb_Ten.Text) Then
            MessageBox.Show("Bạn chưa nhập tên loại hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If
        Return True
    End Function

    Private Function DuplicateCheck_OK(ByVal TenLH As String) As Boolean
        If (Not String.IsNullOrEmpty(ten)) And ten.ToUpper = TenLH.ToUpper Then
            Return True
        End If
        For Each row As DataGridViewRow In dgvDanhSachLoaiHang.Rows
            If row.Cells(2).Value.ToString.ToUpper = TenLH.ToUpper Then
                MessageBox.Show("Bạn không thể nhập tên trùng với tên loại hàng đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return False
            End If
        Next
        Return True
    End Function

    Private Sub btLuu_Click(sender As Object, e As EventArgs) Handles btLuu.Click
        If key = "add" Then
            If NullCheck_OK() And DuplicateCheck_OK(tb_Ten.Text) Then
                Dim DanhMuc As DataRow = dsLoaiHang.NewRow()
                DanhMuc("DM_Ten") = tb_Ten.Text
                DanhMuc("DM_MoTa") = tb_MoTa.Text
                DanhMuc("DM_Xoa") = False

                dsLoaiHang.Rows.Add(DanhMuc)

                XuLyDuLieu.GhiDuLieu("DanhMuc", dsLoaiHang)
            End If
        ElseIf key = "edit" Then
            If NullCheck_OK() And DuplicateCheck_OK(tb_Ten.Text) Then
                Dim ViTri As Integer = dgvDanhSachLoaiHang.SelectedCells(0).RowIndex
                Dim DanhMucView As DataRowView = dgvDanhSachLoaiHang.Rows(ViTri).DataBoundItem
                Dim DanhMuc As DataRow = DanhMucView.Row
                DanhMuc("DM_Ten") = tb_Ten.Text
                DanhMuc("DM_MoTa") = tb_MoTa.Text

                XuLyDuLieu.GhiDuLieu("DanhMuc", dsLoaiHang)
            End If
        End If
        frmQuanLyLoaiHang_Load(sender, e)
    End Sub

    Private Sub frmQuanLyLoaiHang_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        frmQuanLySanPham.frmQuanLySanPham_Load(sender, e)
    End Sub
End Class