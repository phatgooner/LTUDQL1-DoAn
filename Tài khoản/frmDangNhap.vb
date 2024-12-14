Public Class frmDangNhap

    Private Sub btDangNhap_Click(sender As Object, e As EventArgs) Handles btDangNhap.Click
        Dim dsTaiKhoan As DataTable = XuLyDuLieu.DocDuLieu(String.Format("Select * 
        from NguoiDung join TaiKhoan on ND_MaTaiKhoan = TK_Ma where TK_TenDangNhap = '{0}' and ND_Xoa = 'false' and TK_Xoa = 'false'", tbTen.Text))

        If dsTaiKhoan.Rows.Count = 1 Then
            Dim tk As DataRow = dsTaiKhoan.Rows(0)
            Dim mk As String = Util.GetHash(tbMatKhau.Text)
            If tk("TK_TenDangNhap") = tbTen.Text And tk("TK_MatKhau") = mk Then
                Me.DialogResult = DialogResult.Yes
            Else
                MessageBox.Show("Bạn đã nhập sai tên đăng nhập hoặc mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            MessageBox.Show("Bạn đã nhập sai tên đăng nhập hoặc mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btThoat_Click(sender As Object, e As EventArgs) Handles btThoat.Click
        Dim dr As DialogResult = MessageBox.Show("Bạn có chắc chắn muốn thoát khỏi chương trình?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
        If dr = DialogResult.OK Then
            Close()
        End If
    End Sub

    Private Sub tbMatKhau_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbMatKhau.KeyPress
        If e.KeyChar = Chr(13) Then
            btDangNhap_Click(sender, e)
        End If
    End Sub

    Private Sub tbTen_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbTen.KeyPress
        If e.KeyChar = Chr(13) Then
            btDangNhap_Click(sender, e)
        End If
    End Sub
End Class