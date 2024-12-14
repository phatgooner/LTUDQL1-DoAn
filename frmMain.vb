Imports System.Reflection
Imports System.Runtime.InteropServices.JavaScript.JSType
Imports DoAn_LTUDQL1_23880108

Public Class frmMain
    Dim frmList As List(Of Form)

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        frmList = New List(Of Form)
        Dim frm As frmDangNhap = New frmDangNhap
        Dim dr As DialogResult = frm.ShowDialog
        If dr = DialogResult.Yes Then
            Dim kq As DataTable = XuLyDuLieu.DocDuLieu(String.Format("Select ND_Ten from NguoiDung, TaiKhoan
                                                        where ND_MaTaiKhoan = TK_Ma and TK_TenDangNhap = '{0}'", frm.tbTen.Text))
            Dim ten As DataRow = kq.Rows(0)
            lbXinChao.Text = "Xin chào, " + ten("ND_Ten")
            frm.Hide()
            MànHìnhChínhToolStripMenuItem_Click(sender, e)
            'Thiết lập quyền cho tài khoản dựa trên username
            XuLyPhanQuyen(frm.tbTen.Text)
        Else
            Close()
        End If

    End Sub

    Private Sub ThoátToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ThoátToolStripMenuItem.Click
        Dim dr As DialogResult = MessageBox.Show("Bạn có chắc chắn muốn thoát khỏi chương trình?",
                                                  "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
        If dr = DialogResult.OK Then
            Application.Exit()
        End If
    End Sub

    Private Sub MànHìnhChínhToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MànHìnhChínhToolStripMenuItem.Click
        For Each childForm As Form In Me.MdiChildren
            childForm.Close()
        Next
        Dim frm As frmManHinhChinh = New frmManHinhChinh()
        frm.MdiParent = Me
        frm.Show()
        frm.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub DanhSáchSảnPhẩmToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DanhSáchSảnPhẩmToolStripMenuItem.Click
        For Each childForm As Form In Me.MdiChildren
            childForm.Close()
        Next
        Dim frm As frmDanhSachSanPham = New frmDanhSachSanPham()
        frm.MdiParent = Me
        frm.Show()
        frm.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub DanhSáchLoạiHàngToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DanhSáchLoạiHàngToolStripMenuItem.Click
        For Each childForm As Form In Me.MdiChildren
            childForm.Close()
        Next
        Dim frm As frmDanhSachLoaiHang = New frmDanhSachLoaiHang()
        frm.MdiParent = Me
        frm.Show()
        frm.WindowState = FormWindowState.Maximized
    End Sub

    Public Sub DanhSáchPhiếuNhậpToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DanhSáchPhiếuNhậpToolStripMenuItem.Click
        For Each childForm As Form In Me.MdiChildren
            childForm.Close()
        Next
        Dim frm As frmDanhSachPhieuNhap = New frmDanhSachPhieuNhap()
        frm.MdiParent = Me
        frm.Show()
        frm.WindowState = FormWindowState.Maximized
    End Sub

    Public Sub DanhSáchPhiếuXuấtToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DanhSáchPhiếuXuấtToolStripMenuItem.Click
        For Each childForm As Form In Me.MdiChildren
            childForm.Close()
        Next
        Dim frm As frmDanhSachPhieuXuat = New frmDanhSachPhieuXuat()
        frm.MdiParent = Me
        frm.Show()
        frm.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub QuảnLýLoạiHàngToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuảnLýLoạiHàngToolStripMenuItem.Click
        For Each childForm As Form In Me.MdiChildren
            childForm.Close()
        Next
        Dim frm As frmQuanLyLoaiHang = New frmQuanLyLoaiHang
        frm.MdiParent = Me
        frm.Show()
        frm.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub QuảnLýSảnPhẩmToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuảnLýSảnPhẩmToolStripMenuItem.Click
        For Each childForm As Form In Me.MdiChildren
            childForm.Close()
        Next
        Dim frm As frmQuanLySanPham = New frmQuanLySanPham
        frm.MdiParent = Me
        frm.Show()
        frm.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub NhàCungCấpToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NhàCungCấpToolStripMenuItem.Click
        For Each childForm As Form In Me.MdiChildren
            childForm.Close()
        Next
        Dim frm As frmQuanLyNhaCungCap = New frmQuanLyNhaCungCap
        frm.MdiParent = Me
        frm.Show()
        frm.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub NhómKháchHàngToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NhómKháchHàngToolStripMenuItem.Click
        For Each childForm As Form In Me.MdiChildren
            childForm.Close
        Next
        Dim frm As frmQuanLyNhomKhachHang = New frmQuanLyNhomKhachHang
        frm.MdiParent = Me
        frm.Show()
        frm.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub CáNhânToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CáNhânToolStripMenuItem.Click
        For Each childForm As Form In Me.MdiChildren
            childForm.Close()
        Next
        Dim frm As frmQuanLyKhachHang = New frmQuanLyKhachHang
        frm.MdiParent = Me
        frm.Show()
        frm.WindowState = FormWindowState.Maximized
    End Sub

    Public Sub PhiếuNhậpToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PhiếuNhậpToolStripMenuItem.Click
        For Each childForm As Form In Me.MdiChildren
            childForm.Close()
        Next
        Dim frm As frmQuanLyPhieuNhap = New frmQuanLyPhieuNhap
        frm.MdiParent = Me
        frm.Show()
        frm.WindowState = FormWindowState.Maximized
    End Sub

    Public Sub PhiếuXuấtToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PhiếuXuấtToolStripMenuItem.Click
        For Each childForm As Form In Me.MdiChildren
            childForm.Close()
        Next
        Dim frm As frmQuanLyPhieuXuat = New frmQuanLyPhieuXuat
        frm.MdiParent = Me
        frm.Show()
        frm.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub ThốngKêPhiếuNhậpToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ThốngKêPhiếuNhậpToolStripMenuItem.Click
        For Each childForm As Form In Me.MdiChildren
            childForm.Close()
        Next
        Dim frm As frmThongKePhieuNhap = New frmThongKePhieuNhap
        frm.MdiParent = Me
        frm.Show()
        frm.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub ThốngKêPhiếuXuấtToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ThốngKêPhiếuXuấtToolStripMenuItem.Click
        For Each childForm As Form In Me.MdiChildren
            childForm.Close()
        Next
        Dim frm As frmThongKePhieuXuat = New frmThongKePhieuXuat
        frm.MdiParent = Me
        frm.Show()
        frm.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub ThốngKêNhậpHàngToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ThốngKêNhậpHàngToolStripMenuItem.Click
        For Each childForm As Form In Me.MdiChildren
            childForm.Close()
        Next
        Dim frm As frmThongKeNhapHang = New frmThongKeNhapHang
        frm.MdiParent = Me
        frm.Show()
        frm.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub ThốngKêXuấtHàngToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ThốngKêXuấtHàngToolStripMenuItem.Click
        For Each childForm As Form In Me.MdiChildren
            childForm.Close()
        Next
        Dim frm As frmThongKeXuatHang = New frmThongKeXuatHang
        frm.MdiParent = Me
        frm.Show()
        frm.WindowState = FormWindowState.Maximized
    End Sub

    Public Sub DanhSáchNgườiDùngToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DanhSáchNgườiDùngToolStripMenuItem.Click
        For Each childForm As Form In Me.MdiChildren
            childForm.Close()
        Next
        Dim frm As frmNguoiDung = New frmNguoiDung
        frm.MdiParent = Me
        frm.Show()
        frm.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub QuyềnVàVaiTròToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuyềnVàVaiTròToolStripMenuItem.Click
        For Each childForm As Form In Me.MdiChildren
            childForm.Close()
        Next
        Dim frm As frmQuyen_VaiTro = New frmQuyen_VaiTro
        frm.MdiParent = Me
        frm.Show()
        frm.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub DanhSáchNhàCungCấpToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DanhSáchNhàCungCấpToolStripMenuItem.Click
        For Each childForm As Form In Me.MdiChildren
            childForm.Close()
        Next
        Dim frm As frmDanhSachNhaCungCap = New frmDanhSachNhaCungCap
        frm.MdiParent = Me
        frm.Show()
        frm.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub DanhSáchKháchHàngToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DanhSáchKháchHàngToolStripMenuItem.Click
        For Each childForm As Form In Me.MdiChildren
            childForm.Close()
        Next
        Dim frm As frmDanhSachKhachHang = New frmDanhSachKhachHang
        frm.MdiParent = Me
        frm.Show()
        frm.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub SảnPhẩmNhậpToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SảnPhẩmNhậpToolStripMenuItem.Click
        For Each childForm As Form In Me.MdiChildren
            childForm.Close()
        Next
        Dim frm As frmThongKeSanPhamNhap = New frmThongKeSanPhamNhap
        frm.MdiParent = Me
        frm.Show()
        frm.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub SảnPhẩmXuấtToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SảnPhẩmXuấtToolStripMenuItem.Click
        For Each childForm As Form In Me.MdiChildren
            childForm.Close()
        Next
        Dim frm As frmThongKeSanPhamXuat = New frmThongKeSanPhamXuat
        frm.MdiParent = Me
        frm.Show()
        frm.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub TìnhTrạngSốLượngToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TìnhTrạngSốLượngToolStripMenuItem.Click
        For Each childForm As Form In Me.MdiChildren
            childForm.Close()
        Next
        Dim frm As frmThongKeSoLuong = New frmThongKeSoLuong
        frm.MdiParent = Me
        frm.Show()
        frm.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub DanhSáchNhânViênToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DanhSáchNhânViênToolStripMenuItem.Click
        For Each childForm As Form In Me.MdiChildren
            childForm.Close()
        Next
        Dim frm As frmDanhSachNhanVien = New frmDanhSachNhanVien
        frm.MdiParent = Me
        frm.Show()
        frm.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub XuLyPhanQuyen(ByVal username As String)
        Dim data As DataTable = XuLyDuLieu.DocDuLieu(String.Format("select Q_Ma
        from TaiKhoan join VaiTro on TK_VaiTro = VT_Ma join VaiTro_Quyen on VT_Ma = VTQ_VaiTro join Quyen on VTQ_Quyen = Q_Ma
        where TK_TenDangNhap = '{0}'", username))
        For Each row As DataRow In data.Rows
            Dim rowValue As Integer = Integer.Parse(row(0))
            Select Case rowValue
                Case 1
                    DanhSáchHàngHóaToolStripMenuItem.Enabled = True
                Case 2
                    DanhSáchPhiếuToolStripMenuItem.Enabled = True
                Case 3
                    DanhSáchNhàCungCấpToolStripMenuItem.Enabled = True
                Case 4
                    DanhSáchKháchHàngToolStripMenuItem.Enabled = True
                Case 5
                    DanhSáchNhânViênToolStripMenuItem.Enabled = True
                Case 6
                    QuảnLýLoạiHàngToolStripMenuItem.Enabled = True
                Case 7
                    QuảnLýSảnPhẩmToolStripMenuItem.Enabled = True
                Case 8
                    NhàCungCấpToolStripMenuItem.Enabled = True
                Case 9
                    KháchHàngToolStripMenuItem.Enabled = True
                Case 10
                    PhiếuToolStripMenuItem.Enabled = True
                Case 11
                    ThốngKêSảnPhẩmToolStripMenuItem.Enabled = True
                Case 12
                    PhiếuToolStripMenuItem1.Enabled = True
                Case 13
                    NhậpXuấtToolStripMenuItem.Enabled = True
                Case 14
                    DanhSáchNgườiDùngToolStripMenuItem.Enabled = True
                Case 15
                    QuyềnVàVaiTròToolStripMenuItem.Enabled = True
            End Select
        Next
    End Sub

    Private Sub ĐăngXuấtToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ĐăngXuấtToolStripMenuItem.Click
        Dim dr = MessageBox.Show("Bạn có chắc chắn muốn đăng xuất?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If dr = DialogResult.Yes Then
            Application.Restart()
        End If
    End Sub
End Class
