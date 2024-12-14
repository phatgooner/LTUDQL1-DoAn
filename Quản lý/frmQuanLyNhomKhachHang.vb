Public Class frmQuanLyNhomKhachHang
    Dim dsNhomKH As DataTable
    Dim dsNhomKHView As DataView
    Dim key As String
    Dim ten_nkh As String = ""
    Dim index As Integer

    Private Sub ColumnEditing()
        dgvDanhSachNhomKhachHang.AllowUserToAddRows = False
        dgvDanhSachNhomKhachHang.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

        dgvDanhSachNhomKhachHang.Columns(0).HeaderText = "Mã nhóm KH"
        dgvDanhSachNhomKhachHang.Columns(1).HeaderText = "Tên nhóm KH"
        dgvDanhSachNhomKhachHang.Columns(2).HeaderText = "Mô tả"
        dgvDanhSachNhomKhachHang.Columns(3).Visible = False
    End Sub

    Sub HienThiDanhSach()
        dsNhomKH = XuLyDuLieu.DocDuLieu("Select * from NhomKhachHang where NKH_Xoa = 'false'")
        dsNhomKHView = New DataView(dsNhomKH)
        dgvDanhSachNhomKhachHang.DataSource = dsNhomKHView
    End Sub

    Private Sub Lock()
        btThem.Focus()

        btThem.Enabled = True
        btLuu.Enabled = False

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

        tb_Ma.ReadOnly = True
        tb_Ten.ReadOnly = False
        tb_MoTa.ReadOnly = False
    End Sub

    Private Sub frmQuanLyNhomKhachHang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Lock()
        HienThiDanhSach()
        ColumnEditing()
        If dgvDanhSachNhomKhachHang.Rows.Count > 0 Then
            btXoa.Enabled = True
            btSua.Enabled = True
        Else
            btXoa.Enabled = False
            btSua.Enabled = False
        End If
    End Sub

    Private Sub btThem_Click(sender As Object, e As EventArgs) Handles btThem.Click
        Unlock()
        key = "add"

        tb_Ma.Clear()
        tb_Ten.Clear()
        tb_MoTa.Clear()
    End Sub

    Private Sub dgvDanhSachNhomKhachHang_SelectionChanged(sender As Object, e As EventArgs) Handles dgvDanhSachNhomKhachHang.SelectionChanged
        If dgvDanhSachNhomKhachHang.SelectedCells.Count > 0 Then
            index = dgvDanhSachNhomKhachHang.SelectedCells(0).RowIndex
            Dim NhomKHView As DataRowView = dgvDanhSachNhomKhachHang.Rows(index).DataBoundItem
            If Not (NhomKHView Is Nothing) Then
                Dim NhomKH As DataRow = NhomKHView.Row
                tb_Ma.Text = NhomKH("NKH_Ma")
                tb_Ten.Text = NhomKH("NKH_Ten")
                tb_MoTa.Text = NhomKH("NKH_MoTa")
            End If
        End If
    End Sub

    Private Sub btSua_Click(sender As Object, e As EventArgs) Handles btSua.Click
        Unlock()
        key = "edit"
        index = dgvDanhSachNhomKhachHang.SelectedCells(0).RowIndex
        Dim NKH_View As DataRowView = dgvDanhSachNhomKhachHang.Rows(index).DataBoundItem
        Dim NKH As DataRow = NKH_View.Row
        ten_nkh = NKH("NKH_Ten")
    End Sub

    Private Sub btXoa_Click(sender As Object, e As EventArgs) Handles btXoa.Click
        Dim dr As DialogResult = MessageBox.Show("Bạn có chắc muốn xóa nhóm khách hàng này?",
                                                 "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If dr = DialogResult.Yes Then
            If dgvDanhSachNhomKhachHang.SelectedCells.Count > 0 Then
                index = dgvDanhSachNhomKhachHang.SelectedCells(0).RowIndex
                Dim NhomKHView As DataRowView = dgvDanhSachNhomKhachHang.Rows(index).DataBoundItem
                Dim NhomKH As DataRow = NhomKHView.Row
                NhomKH("NKH_Xoa") = True

                XuLyDuLieu.GhiDuLieu("NhomKhachHang", dsNhomKH)
                dsNhomKH.Rows.Remove(NhomKH)
            Else
                MessageBox.Show("Anh chị vui lòng chọn danh mục cần xóa!", "Thông báo")
            End If
            frmQuanLyNhomKhachHang_Load(sender, e)
        End If
    End Sub

    Private Function NullCheck_OK() As Boolean
        If String.IsNullOrWhiteSpace(tb_Ten.Text) Then
            MessageBox.Show("Bạn chưa nhập tên nhóm KH", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If
        Return True
    End Function

    Private Function DuplicateCheck_OK(ByVal Ten As String) As Boolean
        If (Not String.IsNullOrEmpty(ten_nkh)) And Ten.ToUpper = ten_nkh.ToUpper Then
            Return True
        End If
        For Each row As DataGridViewRow In dgvDanhSachNhomKhachHang.Rows
            If row.Cells(1).Value.ToString.ToUpper = Ten.ToUpper Then
                MessageBox.Show("Bạn không thể nhập tên trùng với tên nhóm KH đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return False
            End If
        Next
        Return True
    End Function

    Private Sub btLuu_Click(sender As Object, e As EventArgs) Handles btLuu.Click
        If key = "add" Then
            If NullCheck_OK() And DuplicateCheck_OK(tb_Ten.Text) Then
                Dim NhomKH As DataRow = dsNhomKH.NewRow()
                NhomKH("NKH_Ten") = tb_Ten.Text
                NhomKH("NKH_MoTa") = tb_MoTa.Text
                NhomKH("NKH_Xoa") = False

                dsNhomKH.Rows.Add(NhomKH)

                XuLyDuLieu.GhiDuLieu("NhomKhachHang", dsNhomKH)
            End If
        ElseIf key = "edit" Then
            If NullCheck_OK() And DuplicateCheck_OK(tb_Ten.Text) Then
                Dim ViTri As Integer = dgvDanhSachNhomKhachHang.SelectedCells(0).RowIndex
                Dim NhomKHView As DataRowView = dgvDanhSachNhomKhachHang.Rows(ViTri).DataBoundItem
                Dim NhomKH As DataRow = NhomKHView.Row
                NhomKH("NKH_Ten") = tb_Ten.Text
                NhomKH("NKH_MoTa") = tb_MoTa.Text

                XuLyDuLieu.GhiDuLieu("NhomKhachHang", dsNhomKH)
            End If
        End If
        frmQuanLyNhomKhachHang_Load(sender, e)
    End Sub
End Class