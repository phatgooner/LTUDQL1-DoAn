Public Class frmQuanLyNhaCungCap
    Dim dsNhaCungCap As DataTable
    Dim dsNhaCungCapView As DataView
    Dim key As String
    Dim ten_nsx As String = ""
    Dim index As Integer

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

    Private Sub HienThiDanhSach()
        dsNhaCungCap = XuLyDuLieu.DocDuLieu("Select * from NhaSanXuat where NSX_Xoa = 'false'")
        dsNhaCungCapView = New DataView(dsNhaCungCap)
        dgvDanhSachNhaCungCap.DataSource = dsNhaCungCapView
    End Sub

    Private Sub Lock()
        btThem.Focus()

        btThem.Enabled = True
        btLuu.Enabled = False
        btTimKiem.Enabled = True

        tb_Ma.ReadOnly = True
        tb_Ten.ReadOnly = True
        tb_MoTa.ReadOnly = True
        tb_SDT.ReadOnly = True
        tb_DiaChi.ReadOnly = True
        tb_NLL.ReadOnly = True
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
        tb_SDT.ReadOnly = False
        tb_DiaChi.ReadOnly = False
        tb_NLL.ReadOnly = False
    End Sub

    Private Sub frmQuanLyNhaCungCap_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Lock()
        HienThiDanhSach()
        ColumnEditing()
        If dgvDanhSachNhaCungCap.Rows.Count > 0 Then
            btXoa.Enabled = True
            btSua.Enabled = True
        Else
            btXoa.Enabled = False
            btSua.Enabled = False
        End If
    End Sub

    Private Sub dgvDanhSachNhaCungCap_SelectionChanged(sender As Object, e As EventArgs) Handles dgvDanhSachNhaCungCap.SelectionChanged
        If dgvDanhSachNhaCungCap.SelectedCells.Count > 0 Then
            index = dgvDanhSachNhaCungCap.SelectedCells(0).RowIndex
            Dim NhaCungCapView As DataRowView = dgvDanhSachNhaCungCap.Rows(index).DataBoundItem
            If Not (NhaCungCapView Is Nothing) Then
                Dim NhaCungCap As DataRow = NhaCungCapView.Row

                tb_Ma.Text = NhaCungCap("NSX_Ma")
                tb_Ten.Text = NhaCungCap("NSX_Ten")
                tb_MoTa.Text = NhaCungCap("NSX_MoTa")
                tb_DiaChi.Text = NhaCungCap("NSX_DiaChi")
                tb_SDT.Text = NhaCungCap("NSX_SDT")
                tb_NLL.Text = NhaCungCap("NSX_NguoiLienLac")
            End If
        End If
    End Sub

    Private Sub btThem_Click(sender As Object, e As EventArgs) Handles btThem.Click
        Unlock()
        key = "add"

        tb_Ma.Clear()
        tb_Ten.Clear()
        tb_MoTa.Clear()
        tb_DiaChi.Clear()
        tb_SDT.Clear()
        tb_NLL.Clear()
    End Sub

    Private Sub btSua_Click(sender As Object, e As EventArgs) Handles btSua.Click
        Unlock()
        key = "edit"
        index = dgvDanhSachNhaCungCap.SelectedCells(0).RowIndex
        Dim NSXView As DataRowView = dgvDanhSachNhaCungCap.Rows(index).DataBoundItem
        Dim NSX As DataRow = NSXView.Row
        ten_nsx = NSX("NSX_Ten")
    End Sub

    Private Sub btXoa_Click(sender As Object, e As EventArgs) Handles btXoa.Click
        Dim dr As DialogResult = MessageBox.Show("Tất cả sản phẩm từ nhà cung cấp này sẽ bị mất, bạn có chắc muốn xóa nhà cung cấp này?",
                                                 "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If dr = DialogResult.Yes Then
            If dgvDanhSachNhaCungCap.SelectedCells.Count > 0 Then
                index = dgvDanhSachNhaCungCap.SelectedCells(0).RowIndex
                Dim NhaCungCapView As DataRowView = dgvDanhSachNhaCungCap.Rows(index).DataBoundItem
                Dim NhaCungCap As DataRow = NhaCungCapView.Row
                NhaCungCap("NSX_Xoa") = True

                XuLyDuLieu.GhiDuLieu("NhaSanXuat", dsNhaCungCap)
                dsNhaCungCap.Rows.Remove(NhaCungCap)
            Else
                MessageBox.Show("Vui lòng chọn nhà cung cấp cần xóa!", "Thông báo")
            End If
            frmQuanLyNhaCungCap_Load(sender, e)
        End If
    End Sub

    Private Function Check_OK() As Boolean
        If String.IsNullOrWhiteSpace(tb_Ten.Text) Then
            MessageBox.Show("Bạn chưa nhập tên nhà cung cấp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        ElseIf String.IsNullOrWhiteSpace(tb_DiaChi.Text) Then
            MessageBox.Show("Bạn chưa nhập địa chỉ nhà cung cấp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        ElseIf String.IsNullOrWhiteSpace(tb_SDT.Text) Then
            MessageBox.Show("Bạn chưa nhập SĐT nhà cung cấp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        ElseIf String.IsNullOrWhiteSpace(tb_NLL.Text) Then
            MessageBox.Show("Bạn chưa nhập tên người liên lạc!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If
        Return True
    End Function

    Private Function DuplicateCheck_OK(ByVal Ten As String) As Boolean
        If (Not String.IsNullOrEmpty(ten_nsx)) And Ten.ToUpper = ten_nsx.ToUpper Then
            Return True
        End If
        For Each row As DataGridViewRow In dgvDanhSachNhaCungCap.Rows
            If row.Cells(1).Value.ToString.ToUpper = Ten.ToUpper Then
                MessageBox.Show("Bạn không thể nhập tên trùng với tên nhà cung cấp đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return False
            End If
        Next
        Return True
    End Function

    Private Sub btLuu_Click(sender As Object, e As EventArgs) Handles btLuu.Click
        If key = "add" Then
            If Check_OK() And DuplicateCheck_OK(tb_Ten.Text) Then
                Dim nsx As DataRow = dsNhaCungCap.NewRow()
                nsx("NSX_Ten") = tb_Ten.Text
                nsx("NSX_MoTa") = tb_MoTa.Text
                nsx("NSX_DiaChi") = tb_DiaChi.Text
                nsx("NSX_SDT") = tb_SDT.Text
                nsx("NSX_NguoiLienLac") = tb_NLL.Text
                nsx("NSX_Xoa") = False

                dsNhaCungCap.Rows.Add(nsx)
                XuLyDuLieu.GhiDuLieu("NhaSanXuat", dsNhaCungCap)
            End If
        ElseIf key = "edit" Then
            If Check_OK() And DuplicateCheck_OK(tb_Ten.Text) Then
                If dgvDanhSachNhaCungCap.SelectedCells.Count > 0 Then
                    index = dgvDanhSachNhaCungCap.SelectedCells(0).RowIndex
                    Dim NhaCungCapView As DataRowView = dgvDanhSachNhaCungCap.Rows(index).DataBoundItem
                    If Not (NhaCungCapView Is Nothing) Then
                        Dim nsx As DataRow = NhaCungCapView.Row
                        nsx("NSX_Ten") = tb_Ten.Text
                        nsx("NSX_MoTa") = tb_MoTa.Text
                        nsx("NSX_DiaChi") = tb_DiaChi.Text
                        nsx("NSX_SDT") = tb_SDT.Text
                        nsx("NSX_NguoiLienLac") = tb_NLL.Text
                        nsx("NSX_Xoa") = False

                        XuLyDuLieu.GhiDuLieu("NhaSanXuat", dsNhaCungCap)
                    Else
                        MessageBox.Show("Vui lòng chọn nhà cung cấp cần sửa!", "Thông báo")
                    End If
                Else
                    MessageBox.Show("Vui lòng chọn nhà cung cấp cần sửa!", "Thông báo")
                End If
            End If
        End If
        frmQuanLyNhaCungCap_Load(sender, e)
    End Sub

    Private Sub btTimKiem_Click(sender As Object, e As EventArgs) Handles btTimKiem.Click
        Dim frm As frmDanhSachNhaCungCap = New frmDanhSachNhaCungCap
        frm.ControlBox = True
        frm.StartPosition = FormStartPosition.CenterScreen
        frm.frmDanhSachNhaCungCap_Load(sender, e)
        frm.ShowDialog()
    End Sub
End Class