Imports System.Net.Security

Public Class frmQuanLySanPham
    Dim dsSanPham As DataTable
    Dim dsSanPhamView As DataView
    Dim key As String
    Dim tensp As String = ""
    Dim index As Integer

    Private Sub ColumnEditing()
        dgvDanhSachSanPham.AllowUserToAddRows = False
        dgvDanhSachSanPham.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgvDanhSachSanPham.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dgvDanhSachSanPham.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dgvDanhSachSanPham.Columns(5).DefaultCellStyle.Format = "#,##0"
        dgvDanhSachSanPham.Columns(6).DefaultCellStyle.Format = "#,##0"
        dgvDanhSachSanPham.Columns(7).Visible = False
        dgvDanhSachSanPham.Columns(8).Visible = False
        dgvDanhSachSanPham.Columns(9).Visible = False

        dgvDanhSachSanPham.Columns(0).HeaderText = "Mã sản phẩm"
        dgvDanhSachSanPham.Columns(1).HeaderText = "Tên sản phẩm"
        dgvDanhSachSanPham.Columns(2).HeaderText = "Mô tả"
        dgvDanhSachSanPham.Columns(3).HeaderText = "Loại hàng"
        dgvDanhSachSanPham.Columns(4).HeaderText = "Nhà sản xuất"
        dgvDanhSachSanPham.Columns(5).HeaderText = "Giá nhập (VNĐ)"
        dgvDanhSachSanPham.Columns(6).HeaderText = "Giá bán (VNĐ)"
    End Sub

    Private Sub HienThiDanhSach()
        dsSanPham = XuLyDuLieu.DocDuLieu("Select SP_Ma, SP_Ten, SP_MoTa, DM_Ten, NSX_Ten, SP_GiaNhap, 
            SP_GiaBan, SP_Xoa, SP_DanhMuc, SP_NhaSanXuat from SanPham, DanhMuc, NhaSanXuat where SP_DanhMuc = DM_Ma 
            and SP_NhaSanXuat = NSX_Ma and DM_Xoa = 'false' and NSX_Xoa = 'false' and SP_Xoa = 'false'")
        dsSanPhamView = New DataView(dsSanPham)
        dgvDanhSachSanPham.DataSource = dsSanPhamView
    End Sub

    Private Sub Lock()
        btThem.Focus()

        btThem.Enabled = True
        btLuu.Enabled = False
        btTimKiem.Enabled = True
        btThemDanhMuc.Enabled = False
        btThemNSX.Enabled = False

        tb_Ten.ReadOnly = True
        tb_MoTa.ReadOnly = True
        cbbDanhMuc.Enabled = False
        cbb_NSX.Enabled = False
        tb_GiaNhap.ReadOnly = True
        tb_GiaBan.ReadOnly = True
    End Sub

    Private Sub Unlock()
        tb_Ten.Focus()

        btThem.Enabled = False
        btXoa.Enabled = False
        btSua.Enabled = False
        btLuu.Enabled = True
        btTimKiem.Enabled = False
        btThemDanhMuc.Enabled = True
        btThemNSX.Enabled = True

        tb_Ten.ReadOnly = False
        tb_MoTa.ReadOnly = False
        cbbDanhMuc.Enabled = True
        cbb_NSX.Enabled = True
        tb_GiaNhap.ReadOnly = False
        tb_GiaBan.ReadOnly = False
    End Sub

    Public Sub ComboBoxDanhMucLoad()
        Dim dsDanhMuc As DataTable = XuLyDuLieu.DocDuLieu("Select * from DanhMuc where DM_Xoa = 'false'")
        cbbDanhMuc.DataSource = dsDanhMuc
        cbbDanhMuc.DisplayMember = "DM_Ten"
        cbbDanhMuc.ValueMember = "DM_Ma"
    End Sub

    Public Sub ComboBoxNSXLoad()
        Dim dsNhaSanXuat As DataTable = XuLyDuLieu.DocDuLieu("Select * from NhaSanXuat where NSX_Xoa = 'false'")
        cbb_NSX.DataSource = dsNhaSanXuat
        cbb_NSX.DisplayMember = "NSX_Ten"
        cbb_NSX.ValueMember = "NSX_Ma"
    End Sub

    Public Sub frmQuanLySanPham_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBoxDanhMucLoad()
        ComboBoxNSXLoad()
        Lock()
        HienThiDanhSach()
        ColumnEditing()
        If dgvDanhSachSanPham.Rows.Count > 0 Then
            btXoa.Enabled = True
            btSua.Enabled = True
        Else
            btXoa.Enabled = False
            btSua.Enabled = False
        End If
    End Sub

    Private Sub btTimKiem_Click(sender As Object, e As EventArgs) Handles btTimKiem.Click
        Dim frm = New frmDanhSachSanPham
        frm.ControlBox = True
        frm.StartPosition = FormStartPosition.CenterScreen
        frm.frmDanhSachSanPham_Load(sender, e)
        frm.ShowDialog()
    End Sub

    Private Sub btThem_Click(sender As Object, e As EventArgs) Handles btThem.Click
        Unlock()
        key = "add"

        tb_Ten.Clear()
        tb_MoTa.Clear()
        tb_GiaNhap.Clear()
        tb_GiaBan.Clear()
    End Sub

    Private Sub dgvDanhSachSanPham_SelectionChanged(sender As Object, e As EventArgs) Handles dgvDanhSachSanPham.SelectionChanged
        If dgvDanhSachSanPham.SelectedCells.Count > 0 Then
            index = dgvDanhSachSanPham.SelectedCells(0).RowIndex
            Dim SanPhamView As DataRowView = dgvDanhSachSanPham.Rows(index).DataBoundItem
            If Not (SanPhamView Is Nothing) Then
                Dim SanPham As DataRow = SanPhamView.Row

                tb_Ten.Text = SanPham("SP_Ten")
                tb_MoTa.Text = SanPham("SP_MoTa")
                cbbDanhMuc.Text = SanPham("DM_Ten")
                cbb_NSX.Text = SanPham("NSX_Ten")
                tb_GiaNhap.Text = SanPham("SP_GiaNhap")
                tb_GiaBan.Text = SanPham("SP_GiaBan")
            End If
        End If
    End Sub

    Private Sub btSua_Click(sender As Object, e As EventArgs) Handles btSua.Click
        Unlock()
        key = "edit"
        index = dgvDanhSachSanPham.SelectedCells(0).RowIndex
        Dim SanPhamView As DataRowView = dgvDanhSachSanPham.Rows(index).DataBoundItem
        Dim SanPham As DataRow = SanPhamView.Row
        tensp = SanPham("SP_Ten")
    End Sub

    Private Sub btXoa_Click(sender As Object, e As EventArgs) Handles btXoa.Click
        Dim dr As DialogResult = MessageBox.Show("Bạn có chắc muốn xóa sản phẩm này?",
                                                 "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If dr = DialogResult.Yes Then
            If dgvDanhSachSanPham.SelectedCells.Count > 0 Then
                index = dgvDanhSachSanPham.SelectedCells(0).RowIndex
                Dim SanPhamView As DataRowView = dgvDanhSachSanPham.Rows(index).DataBoundItem
                Dim SanPham As DataRow = SanPhamView.Row
                SanPham("SP_Xoa") = True

                XuLyDuLieu.GhiDuLieu("SanPham", dsSanPham)
                dsSanPham.Rows.Remove(SanPham)
            Else
                MessageBox.Show("Vui lòng chọn sản phẩm cần xóa!", "Thông báo")
            End If
            frmQuanLySanPham_Load(sender, e)
        End If
    End Sub

    Private Function Check_OK() As Boolean
        Dim num As Integer
        If String.IsNullOrWhiteSpace(tb_Ten.Text) Then
            MessageBox.Show("Bạn chưa nhập tên sản phẩm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        ElseIf Not Integer.TryParse(tb_GiaNhap.Text, num) Then
            MessageBox.Show("Giá nhập của sản phẩm không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        ElseIf Not Integer.TryParse(tb_GiaBan.Text, num) Then
            MessageBox.Show("Giá bán của sản phẩm không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If
        Return True
    End Function

    Private Function DuplicateCheck_OK(ByVal Ten As String) As Boolean
        If (Not String.IsNullOrEmpty(tensp)) And Ten.ToUpper = tensp.ToUpper Then
            Return True
        End If
        For Each row As DataGridViewRow In dgvDanhSachSanPham.Rows
            If row.Cells(1).Value.ToString.ToUpper = Ten.ToUpper Then
                MessageBox.Show("Bạn không thể nhập tên trùng với tên sản phẩm đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return False
            End If
        Next
        Return True
    End Function

    Private Sub btLuu_Click(sender As Object, e As EventArgs) Handles btLuu.Click
        If key = "add" Then
            If Check_OK() And DuplicateCheck_OK(tb_Ten.Text) Then
                Dim sp As DataRow = dsSanPham.NewRow()
                sp("SP_Ten") = tb_Ten.Text
                sp("SP_MoTa") = tb_MoTa.Text
                sp("SP_DanhMuc") = cbbDanhMuc.SelectedValue
                sp("DM_Ten") = cbbDanhMuc.Items(cbbDanhMuc.SelectedIndex)("DM_Ten")
                sp("SP_NhaSanXuat") = cbb_NSX.SelectedValue
                sp("NSX_Ten") = cbb_NSX.Items(cbb_NSX.SelectedIndex)("NSX_Ten")
                sp("SP_GiaNhap") = tb_GiaNhap.Text
                sp("SP_GiaBan") = tb_GiaBan.Text
                sp("SP_Xoa") = False

                dsSanPham.Rows.Add(sp)
                XuLyDuLieu.GhiDuLieu("SanPham", dsSanPham)
            End If
        ElseIf key = "edit" Then
            If Check_OK() And DuplicateCheck_OK(tb_Ten.Text) Then
                If dgvDanhSachSanPham.SelectedCells.Count > 0 Then
                    index = dgvDanhSachSanPham.SelectedCells(0).RowIndex
                    Dim SanPhamView As DataRowView = dgvDanhSachSanPham.Rows(index).DataBoundItem
                    If Not (SanPhamView Is Nothing) Then
                        Dim sp As DataRow = SanPhamView.Row
                        sp("SP_Ten") = tb_Ten.Text
                        sp("SP_MoTa") = tb_MoTa.Text
                        sp("SP_DanhMuc") = cbbDanhMuc.SelectedValue
                        sp("DM_Ten") = cbbDanhMuc.Items(cbbDanhMuc.SelectedIndex)("DM_Ten")
                        sp("SP_NhaSanXuat") = cbb_NSX.SelectedValue
                        sp("NSX_Ten") = cbb_NSX.Items(cbb_NSX.SelectedIndex)("NSX_Ten")
                        sp("SP_GiaNhap") = tb_GiaNhap.Text
                        sp("SP_GiaBan") = tb_GiaBan.Text
                        sp("SP_Xoa") = False

                        XuLyDuLieu.GhiDuLieu("SanPham", dsSanPham)
                    Else
                        MessageBox.Show("Vui lòng chọn sản phẩm cần sửa!", "Thông báo")
                    End If
                Else
                    MessageBox.Show("Vui lòng chọn sản phẩm cần sửa!", "Thông báo")
                End If
            End If
        End If
        frmQuanLySanPham_Load(sender, e)
    End Sub

    Private Sub btThemDanhMuc_Click(sender As Object, e As EventArgs) Handles btThemDanhMuc.Click
        Dim frm As frmQuanLyLoaiHang = New frmQuanLyLoaiHang
        frm.ControlBox = True
        frm.ShowDialog()
    End Sub

    Private Sub btThemNSX_Click(sender As Object, e As EventArgs) Handles btThemNSX.Click
        Dim frm As frmQuanLyNhaCungCap = New frmQuanLyNhaCungCap
        frm.ControlBox = True
        frm.ShowDialog()
    End Sub

    Public Sub cbb_NSX_Click(sender As Object, e As EventArgs) Handles cbb_NSX.Click
        ComboBoxNSXLoad()
    End Sub

    Private Sub cbbDanhMuc_Click(sender As Object, e As EventArgs) Handles cbbDanhMuc.Click
        ComboBoxDanhMucLoad()
    End Sub
End Class