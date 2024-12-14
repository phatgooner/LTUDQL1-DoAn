Public Class frmQuanLyKhachHang
    Dim dsKhachHang As DataTable
    Dim dsKhachHangView As DataView
    Dim key As String
    Dim index As Integer

    Private Sub ColumnEditing()
        dgvDanhSachKhachHang.AllowUserToAddRows = False
        dgvDanhSachKhachHang.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgvDanhSachKhachHang.Columns(6).Visible = False
        dgvDanhSachKhachHang.Columns(7).Visible = False


        dgvDanhSachKhachHang.Columns(0).HeaderText = "Mã KH"
        dgvDanhSachKhachHang.Columns(1).HeaderText = "Tên KH"
        dgvDanhSachKhachHang.Columns(2).HeaderText = "Địa chỉ"
        dgvDanhSachKhachHang.Columns(3).HeaderText = "Email"
        dgvDanhSachKhachHang.Columns(4).HeaderText = "Số điện thoại"
        dgvDanhSachKhachHang.Columns(5).HeaderText = "Nhóm KH"
    End Sub

    Private Sub HienThiDanhSach()
        dsKhachHang = XuLyDuLieu.DocDuLieu("Select KH_Ma, KH_Ten, KH_DiaChi, KH_Email,
KH_SDT, NKH_Ten, KH_NhomKH, KH_Xoa from KhachHang, NhomKhachHang where KH_NhomKH = NKH_Ma and KH_Xoa = 'false'")
        dsKhachHangView = New DataView(dsKhachHang)
        dgvDanhSachKhachHang.DataSource = dsKhachHangView
    End Sub

    Private Sub Lock()
        btThem.Focus()

        btThem.Enabled = True
        btLuu.Enabled = False
        btTimKiem.Enabled = True
        btThemNKH.Enabled = False

        tb_Ma.ReadOnly = True
        tb_Ten.ReadOnly = True
        tb_DiaChi.ReadOnly = True
        cbb_NhomKH.Enabled = False
        tb_Email.ReadOnly = True
        tb_SDT.ReadOnly = True
    End Sub

    Private Sub Unlock()
        tb_Ten.Focus()

        btThem.Enabled = False
        btXoa.Enabled = False
        btSua.Enabled = False
        btLuu.Enabled = True
        btTimKiem.Enabled = False
        btThemNKH.Enabled = True


        tb_Ma.ReadOnly = True
        tb_Ten.ReadOnly = False
        tb_DiaChi.ReadOnly = False
        cbb_NhomKH.Enabled = True
        tb_Email.ReadOnly = False
        tb_SDT.ReadOnly = False
    End Sub

    Private Sub ComboBoxLoad()
        Dim dsNhomKH As DataTable = XuLyDuLieu.DocDuLieu("Select * from NhomKhachHang where NKH_Xoa = 'false'")
        cbb_NhomKH.DataSource = dsNhomKH
        cbb_NhomKH.DisplayMember = "NKH_Ten"
        cbb_NhomKH.ValueMember = "NKH_Ma"
    End Sub

    Private Sub frmQuanLyKhachHang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBoxLoad()
        Lock()
        HienThiDanhSach()
        ColumnEditing()
        If dgvDanhSachKhachHang.Rows.Count > 0 Then
            btXoa.Enabled = True
            btSua.Enabled = True
        Else
            btXoa.Enabled = False
            btSua.Enabled = False
        End If
    End Sub

    Private Sub btTimKiem_Click(sender As Object, e As EventArgs) Handles btTimKiem.Click
        Dim frm As frmDanhSachKhachHang = New frmDanhSachKhachHang
        frm.ControlBox = True
        frm.StartPosition = FormStartPosition.CenterScreen
        frm.frmDanhSachKhachHang_Load(sender, e)
        frm.ShowDialog()
    End Sub

    Private Sub btThem_Click(sender As Object, e As EventArgs) Handles btThem.Click
        Unlock()
        key = "add"

        tb_Ma.Clear()
        tb_Ten.Clear()
        tb_DiaChi.Clear()
        tb_SDT.Clear()
        tb_Email.Clear()
    End Sub

    Private Sub dgvDanhSachKhachHang_SelectionChanged(sender As Object, e As EventArgs) Handles dgvDanhSachKhachHang.SelectionChanged
        If dgvDanhSachKhachHang.SelectedCells.Count > 0 Then
            index = dgvDanhSachKhachHang.SelectedCells(0).RowIndex
            Dim KhachHangView As DataRowView = dgvDanhSachKhachHang.Rows(index).DataBoundItem
            If Not (KhachHangView Is Nothing) Then
                Dim KhachHang As DataRow = KhachHangView.Row

                tb_Ma.Text = KhachHang("KH_Ma")
                tb_Ten.Text = KhachHang("KH_Ten")
                tb_DiaChi.Text = KhachHang("KH_DiaChi")
                tb_SDT.Text = KhachHang("KH_SDT")
                tb_Email.Text = KhachHang("KH_Email")
                cbb_NhomKH.Text = KhachHang("NKH_Ten")
            End If
        End If
    End Sub

    Private Sub btSua_Click(sender As Object, e As EventArgs) Handles btSua.Click
        Unlock()
        key = "edit"
    End Sub

    Private Sub btXoa_Click(sender As Object, e As EventArgs) Handles btXoa.Click
        Dim dr As DialogResult = MessageBox.Show("Bạn có chắc muốn xóa khách hàng này?",
                                                 "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If dr = DialogResult.Yes Then
            If dgvDanhSachKhachHang.SelectedCells.Count > 0 Then
                index = dgvDanhSachKhachHang.SelectedCells(0).RowIndex
                Dim KhachHangView As DataRowView = dgvDanhSachKhachHang.Rows(index).DataBoundItem
                Dim KhachHang As DataRow = KhachHangView.Row
                KhachHang("KH_Xoa") = True

                XuLyDuLieu.GhiDuLieu("KhachHang", dsKhachHang)
                dsKhachHang.Rows.Remove(KhachHang)
            Else
                MessageBox.Show("Vui lòng chọn khách hàng cần xóa!", "Thông báo")
            End If
            frmQuanLyKhachHang_Load(sender, e)
        End If
    End Sub

    Private Function Check_OK() As Boolean
        If String.IsNullOrWhiteSpace(tb_Ten.Text) Then
            MessageBox.Show("Bạn chưa nhập tên khách hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        ElseIf String.IsNullOrWhiteSpace(tb_DiaChi.Text) Then
            MessageBox.Show("Bạn chưa nhập địa chỉ khách hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        ElseIf String.IsNullOrWhiteSpace(tb_SDT.Text) Then
            MessageBox.Show("Bạn chưa nhập SĐT khách hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If
        Return True
    End Function

    Private Sub btLuu_Click(sender As Object, e As EventArgs) Handles btLuu.Click
        If key = "add" Then
            If Check_OK() Then
                Dim kh As DataRow = dsKhachHang.NewRow()
                kh("KH_Ten") = tb_Ten.Text
                kh("KH_DiaChi") = tb_DiaChi.Text
                kh("KH_NhomKH") = cbb_NhomKH.SelectedValue
                kh("NKH_Ten") = cbb_NhomKH.Items(cbb_NhomKH.SelectedIndex)("NKH_Ten")
                kh("KH_SDT") = tb_SDT.Text
                kh("KH_Email") = tb_Email.Text
                kh("KH_Xoa") = False

                dsKhachHang.Rows.Add(kh)
                XuLyDuLieu.GhiDuLieu("KhachHang", dsKhachHang)
            End If
        ElseIf key = "edit" Then
            If Check_OK() Then
                If dgvDanhSachKhachHang.SelectedCells.Count > 0 Then
                    index = dgvDanhSachKhachHang.SelectedCells(0).RowIndex
                    Dim KhachHangView As DataRowView = dgvDanhSachKhachHang.Rows(index).DataBoundItem
                    If Not (KhachHangView Is Nothing) Then
                        Dim kh As DataRow = KhachHangView.Row
                        kh("KH_Ten") = tb_Ten.Text
                        kh("KH_DiaChi") = tb_DiaChi.Text
                        kh("KH_NhomKH") = cbb_NhomKH.SelectedValue
                        kh("NKH_Ten") = cbb_NhomKH.Items(cbb_NhomKH.SelectedIndex)("NKH_Ten")
                        kh("KH_SDT") = tb_SDT.Text
                        kh("KH_Email") = tb_Email.Text
                        kh("KH_Xoa") = False

                        XuLyDuLieu.GhiDuLieu("KhachHang", dsKhachHang)
                    Else
                        MessageBox.Show("Vui lòng chọn khách hàng cần sửa!", "Thông báo")
                    End If
                Else
                    MessageBox.Show("Vui lòng chọn khách hàng cần sửa!", "Thông báo")
                End If
            End If
        End If
        frmQuanLyKhachHang_Load(sender, e)
    End Sub

    Private Sub btThemNKH_Click(sender As Object, e As EventArgs) Handles btThemNKH.Click
        Dim frm As frmQuanLyNhomKhachHang = New frmQuanLyNhomKhachHang
        frm.ControlBox = True
        frm.ShowDialog()
    End Sub

    Private Sub cbb_NhomKH_Click(sender As Object, e As EventArgs) Handles cbb_NhomKH.Click
        ComboBoxLoad()
    End Sub
End Class