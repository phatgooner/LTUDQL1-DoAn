Imports System.Runtime.Intrinsics
Imports System.Windows.Forms.Design

Public Class frmThietLapNguoiDung
    Dim key As String
    Dim button As String = ""
    Dim dsNguoiDung As DataTable = XuLyDuLieu.DocDuLieu("Select * from NguoiDung")
    Dim dsTaiKhoan As DataTable = XuLyDuLieu.DocDuLieu("Select * from TaiKhoan")



    Public Sub New(ByVal note As String)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        key = note
    End Sub

    Private Sub btDoiPass_Click(sender As Object, e As EventArgs) Handles btDoiPass.Click
        btDoiPass.Visible = False
        tbPassMoi.Visible = True
        tb_XacNhanPass.Visible = True
        lbMKmoi.Visible = True
        lbXacNhanMK.Visible = True

        button = "click"
    End Sub

    Private Sub bt_LuuThongTin_Click(sender As Object, e As EventArgs) Handles bt_LuuThongTin.Click
        If key = "add" Then
            If NullCheck_OK() And PassCheck_OK() And UsernameCheck_OK() Then
                Dim tk As DataRow = dsTaiKhoan.NewRow()
                tk("TK_TenDangNhap") = tbUsername.Text
                tk("TK_MatKhau") = Util.GetHash(tb_XacNhanPass.Text)
                tk("TK_VaiTro") = cbbVaiTro.SelectedValue
                tk("TK_Xoa") = False

                dsTaiKhoan.Rows.Add(tk)
                XuLyDuLieu.GhiDuLieu("TaiKhoan", dsTaiKhoan)

                Dim nd As DataRow = dsNguoiDung.NewRow()
                nd("ND_Ten") = tbHoTen.Text
                nd("ND_NgaySinh") = dtp_NgaySinh.Value
                nd("ND_GioiTinh") = cbbGioiTinh.SelectedItem
                nd("ND_DiaChi") = tb_DiaChi.Text
                nd("ND_MaTaiKhoan") = tk("TK_Ma")
                nd("ND_Xoa") = False

                dsNguoiDung.Rows.Add(nd)
                XuLyDuLieu.GhiDuLieu("NguoiDung", dsNguoiDung)

                Dim dr As DialogResult = MessageBox.Show("Tạo thông tin người dùng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                If dr = DialogResult.OK Then
                    Close()
                    frmMain.DanhSáchNgườiDùngToolStripMenuItem_Click(sender, e)
                End If
            End If
        ElseIf key = "edit" Then
            If NullCheck_OK() And PassCheck_OK() Then
                Dim dsND As DataTable = XuLyDuLieu.DocDuLieu(String.Format("Select * from NguoiDung where ND_Ma = '{0}'", tbMaNguoiDung.Text))
                Dim dsNDView As DataView = New DataView(dsND)
                Dim NDView As DataRowView = dsNDView(0)
                Dim nd As DataRow = NDView.Row

                Dim dsTK As DataTable = XuLyDuLieu.DocDuLieu(String.Format("Select * from TaiKhoan where TK_Ma = '{0}'", nd("ND_MaTaiKhoan")))
                Dim dsTKView As DataView = New DataView(dsTK)
                Dim TKView As DataRowView = dsTKView(0)
                Dim tk As DataRow = TKView.Row

                nd("ND_Ten") = tbHoTen.Text
                nd("ND_NgaySinh") = dtp_NgaySinh.Value
                nd("ND_GioiTinh") = cbbGioiTinh.SelectedItem
                nd("ND_DiaChi") = tb_DiaChi.Text
                nd("ND_MaTaiKhoan") = tk("TK_Ma")
                nd("ND_Xoa") = False
                tk("TK_VaiTro") = cbbVaiTro.SelectedValue

                XuLyDuLieu.GhiDuLieu("NguoiDung", dsND)
                XuLyDuLieu.GhiDuLieu("TaiKhoan", dsTK)

                If button = "click" Then
                    tk("TK_TenDangNhap") = tbUsername.Text
                    tk("TK_MatKhau") = Util.GetHash(tb_XacNhanPass.Text)
                    tk("TK_VaiTro") = cbbVaiTro.SelectedValue
                    tk("TK_Xoa") = False

                    XuLyDuLieu.GhiDuLieu("TaiKhoan", dsTK)
                End If

                Dim dr As DialogResult = MessageBox.Show("Chỉnh sửa thông tin người dùng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                If dr = DialogResult.OK Then
                    Close()
                    frmMain.DanhSáchNgườiDùngToolStripMenuItem_Click(sender, e)
                End If
            End If
        End If
    End Sub

    Public Sub ComboBoxLoad()
        Dim dsVaiTro As DataTable = XuLyDuLieu.DocDuLieu("Select * from VaiTro where VT_Xoa = 'false'")
        cbbVaiTro.DataSource = dsVaiTro
        cbbVaiTro.DisplayMember = "VT_Ten"
        cbbVaiTro.ValueMember = "VT_Ma"
        If key = "edit" Then
            Dim ds As DataTable = XuLyDuLieu.DocDuLieu(String.Format("Select TK_VaiTro from TaiKhoan where TK_TenDangNhap = N'{0}'", tbUsername.Text))
            Dim row As DataRow = ds.Rows(0)
            Dim id As String = row(0).ToString
            cbbVaiTro.SelectedValue = id
        ElseIf key = "add" Then
            cbbGioiTinh.SelectedIndex = 0
            cbbVaiTro.SelectedIndex = 0
        End If
    End Sub

    Private Sub frmThietLapNguoiDung_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBoxLoad()
    End Sub

    Private Function PassCheck_OK() As Boolean
        If key = "add" Then
            If tbPassMoi.Text <> tb_XacNhanPass.Text Then
                MessageBox.Show("Mật khẩu xác thực không trùng khớp", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return False
            Else
                Return True
            End If

        ElseIf key = "edit" Then
            Dim dsTaiKhoan As DataTable = XuLyDuLieu.DocDuLieu(String.Format("Select * 
        from NguoiDung join TaiKhoan on ND_MaTaiKhoan = TK_Ma where TK_TenDangNhap = '{0}' and ND_Xoa = 'false' and TK_Xoa = 'false'", tbUsername.Text))
            Dim tk As DataRow = dsTaiKhoan.Rows(0)
            Dim mk As String = Util.GetHash(tbPassCu.Text)

            If tbPassMoi.Text <> tb_XacNhanPass.Text And button = "click" Then
                MessageBox.Show("Mật khẩu xác thực không trùng khớp", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return False
            ElseIf tk("TK_MatKhau") <> mk Then
                MessageBox.Show("Mật khẩu hiện tại không chính xác", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return False
            Else
                Return True
            End If
        End If
        Return False
    End Function

    Private Function NullCheck_OK() As Boolean
        If String.IsNullOrEmpty(tbHoTen.Text) Then
            MessageBox.Show("Họ tên người dùng không hợp lệ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        ElseIf String.IsNullOrEmpty(tb_DiaChi.Text) Then
            MessageBox.Show("Địa chỉ người dùng không hợp lệ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        ElseIf String.IsNullOrEmpty(tbUsername.Text) Then
            MessageBox.Show("Tên đăng nhập không hợp lệ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False

        ElseIf key = "add" Or (key = "edit" And button = "click") Then
            If String.IsNullOrEmpty(tbPassMoi.Text) Then
                MessageBox.Show("Mật khẩu không hợp lệ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return False
            ElseIf String.IsNullOrEmpty(tb_XacNhanPass.Text) Then
                MessageBox.Show("Xác nhận mật khẩu không hợp lệ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return False
            End If
        End If
        Return True
    End Function

    Private Function UsernameCheck_OK() As Boolean
        For Each row As DataRow In dsTaiKhoan.Rows
            Dim username As String = row(1).ToString
            If username = tbUsername.Text Then
                MessageBox.Show("Tên đăng nhập đã tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return False
            End If
        Next
        Return True
    End Function

    Private Sub btThemVT_Click(sender As Object, e As EventArgs) Handles btThemVT.Click
        Dim frm As frmQuyen_VaiTro = New frmQuyen_VaiTro
        frm.ControlBox = True
        frm.ShowDialog()
    End Sub

    Private Sub cbbVaiTro_Click(sender As Object, e As EventArgs) Handles cbbVaiTro.Click
        Dim dsVaiTro As DataTable = XuLyDuLieu.DocDuLieu("Select * from VaiTro where VT_Xoa = 'false'")
        cbbVaiTro.DataSource = dsVaiTro
        cbbVaiTro.DisplayMember = "VT_Ten"
        cbbVaiTro.ValueMember = "VT_Ma"
    End Sub
End Class