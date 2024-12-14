<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmThietLapNguoiDung
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmThietLapNguoiDung))
        Label1 = New Label()
        gbThongTinChung = New GroupBox()
        tbHoTen = New TextBox()
        btThemVT = New Button()
        cbbGioiTinh = New ComboBox()
        tb_DiaChi = New TextBox()
        cbbVaiTro = New ComboBox()
        Label2 = New Label()
        Label5 = New Label()
        Label3 = New Label()
        Label6 = New Label()
        Label4 = New Label()
        Label7 = New Label()
        tbMaNguoiDung = New TextBox()
        dtp_NgaySinh = New DateTimePicker()
        gbThongTinDangNhap = New GroupBox()
        btDoiPass = New Button()
        lbNote = New Label()
        tbPassCu = New TextBox()
        tb_XacNhanPass = New TextBox()
        lbPassCu = New Label()
        lbXacNhanMK = New Label()
        tbPassMoi = New TextBox()
        lbMKmoi = New Label()
        tbUsername = New TextBox()
        Label8 = New Label()
        bt_LuuThongTin = New Button()
        gbThongTinChung.SuspendLayout()
        gbThongTinDangNhap.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.Top
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(163))
        Label1.Location = New Point(275, 26)
        Label1.Margin = New Padding(3)
        Label1.Name = "Label1"
        Label1.Size = New Size(297, 31)
        Label1.TabIndex = 25
        Label1.Text = "THÔNG TIN NGƯỜI DÙNG"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' gbThongTinChung
        ' 
        gbThongTinChung.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        gbThongTinChung.Controls.Add(tbHoTen)
        gbThongTinChung.Controls.Add(btThemVT)
        gbThongTinChung.Controls.Add(cbbGioiTinh)
        gbThongTinChung.Controls.Add(tb_DiaChi)
        gbThongTinChung.Controls.Add(cbbVaiTro)
        gbThongTinChung.Controls.Add(Label2)
        gbThongTinChung.Controls.Add(Label5)
        gbThongTinChung.Controls.Add(Label3)
        gbThongTinChung.Controls.Add(Label6)
        gbThongTinChung.Controls.Add(Label4)
        gbThongTinChung.Controls.Add(Label7)
        gbThongTinChung.Controls.Add(tbMaNguoiDung)
        gbThongTinChung.Controls.Add(dtp_NgaySinh)
        gbThongTinChung.Location = New Point(12, 76)
        gbThongTinChung.Name = "gbThongTinChung"
        gbThongTinChung.Size = New Size(823, 155)
        gbThongTinChung.TabIndex = 50
        gbThongTinChung.TabStop = False
        gbThongTinChung.Text = "Thông tin chung"
        ' 
        ' tbHoTen
        ' 
        tbHoTen.Anchor = AnchorStyles.Top
        tbHoTen.Location = New Point(149, 73)
        tbHoTen.Name = "tbHoTen"
        tbHoTen.Size = New Size(250, 27)
        tbHoTen.TabIndex = 1
        ' 
        ' btThemVT
        ' 
        btThemVT.Anchor = AnchorStyles.Top
        btThemVT.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(163))
        btThemVT.Location = New Point(766, 108)
        btThemVT.Name = "btThemVT"
        btThemVT.Size = New Size(30, 30)
        btThemVT.TabIndex = 6
        btThemVT.Text = "+"
        btThemVT.UseVisualStyleBackColor = True
        ' 
        ' cbbGioiTinh
        ' 
        cbbGioiTinh.Anchor = AnchorStyles.Top
        cbbGioiTinh.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        cbbGioiTinh.AutoCompleteSource = AutoCompleteSource.ListItems
        cbbGioiTinh.DropDownStyle = ComboBoxStyle.DropDownList
        cbbGioiTinh.FormattingEnabled = True
        cbbGioiTinh.Items.AddRange(New Object() {"Nam", "Nữ"})
        cbbGioiTinh.Location = New Point(532, 34)
        cbbGioiTinh.Name = "cbbGioiTinh"
        cbbGioiTinh.Size = New Size(235, 28)
        cbbGioiTinh.TabIndex = 3
        ' 
        ' tb_DiaChi
        ' 
        tb_DiaChi.Anchor = AnchorStyles.Top
        tb_DiaChi.Location = New Point(532, 73)
        tb_DiaChi.Name = "tb_DiaChi"
        tb_DiaChi.Size = New Size(235, 27)
        tb_DiaChi.TabIndex = 4
        ' 
        ' cbbVaiTro
        ' 
        cbbVaiTro.Anchor = AnchorStyles.Top
        cbbVaiTro.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        cbbVaiTro.AutoCompleteSource = AutoCompleteSource.ListItems
        cbbVaiTro.DropDownStyle = ComboBoxStyle.DropDownList
        cbbVaiTro.FormattingEnabled = True
        cbbVaiTro.Location = New Point(532, 109)
        cbbVaiTro.Name = "cbbVaiTro"
        cbbVaiTro.Size = New Size(234, 28)
        cbbVaiTro.TabIndex = 5
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.Top
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        Label2.Location = New Point(26, 40)
        Label2.Name = "Label2"
        Label2.Size = New Size(119, 20)
        Label2.TabIndex = 62
        Label2.Text = "Mã người dùng:"
        ' 
        ' Label5
        ' 
        Label5.Anchor = AnchorStyles.Top
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        Label5.Location = New Point(428, 112)
        Label5.Name = "Label5"
        Label5.Size = New Size(81, 20)
        Label5.TabIndex = 68
        Label5.Text = "Vai trò CV:"
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.Top
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        Label3.Location = New Point(26, 76)
        Label3.Name = "Label3"
        Label3.Size = New Size(79, 20)
        Label3.TabIndex = 63
        Label3.Text = "Họ và tên:"
        ' 
        ' Label6
        ' 
        Label6.Anchor = AnchorStyles.Top
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        Label6.Location = New Point(428, 76)
        Label6.Name = "Label6"
        Label6.Size = New Size(60, 20)
        Label6.TabIndex = 67
        Label6.Text = "Địa chỉ:"
        ' 
        ' Label4
        ' 
        Label4.Anchor = AnchorStyles.Top
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        Label4.Location = New Point(26, 112)
        Label4.Name = "Label4"
        Label4.Size = New Size(82, 20)
        Label4.TabIndex = 64
        Label4.Text = "Ngày sinh:"
        ' 
        ' Label7
        ' 
        Label7.Anchor = AnchorStyles.Top
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        Label7.Location = New Point(428, 40)
        Label7.Name = "Label7"
        Label7.Size = New Size(71, 20)
        Label7.TabIndex = 66
        Label7.Text = "Giới tính:"
        ' 
        ' tbMaNguoiDung
        ' 
        tbMaNguoiDung.Anchor = AnchorStyles.Top
        tbMaNguoiDung.Location = New Point(149, 35)
        tbMaNguoiDung.Name = "tbMaNguoiDung"
        tbMaNguoiDung.ReadOnly = True
        tbMaNguoiDung.Size = New Size(250, 27)
        tbMaNguoiDung.TabIndex = 0
        ' 
        ' dtp_NgaySinh
        ' 
        dtp_NgaySinh.Anchor = AnchorStyles.Top
        dtp_NgaySinh.Location = New Point(149, 110)
        dtp_NgaySinh.Name = "dtp_NgaySinh"
        dtp_NgaySinh.Size = New Size(250, 27)
        dtp_NgaySinh.TabIndex = 2
        dtp_NgaySinh.Value = New Date(2024, 11, 6, 0, 0, 0, 0)
        ' 
        ' gbThongTinDangNhap
        ' 
        gbThongTinDangNhap.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        gbThongTinDangNhap.Controls.Add(btDoiPass)
        gbThongTinDangNhap.Controls.Add(lbNote)
        gbThongTinDangNhap.Controls.Add(tbPassCu)
        gbThongTinDangNhap.Controls.Add(tb_XacNhanPass)
        gbThongTinDangNhap.Controls.Add(lbPassCu)
        gbThongTinDangNhap.Controls.Add(lbXacNhanMK)
        gbThongTinDangNhap.Controls.Add(tbPassMoi)
        gbThongTinDangNhap.Controls.Add(lbMKmoi)
        gbThongTinDangNhap.Controls.Add(tbUsername)
        gbThongTinDangNhap.Controls.Add(Label8)
        gbThongTinDangNhap.Location = New Point(12, 237)
        gbThongTinDangNhap.Name = "gbThongTinDangNhap"
        gbThongTinDangNhap.Size = New Size(823, 179)
        gbThongTinDangNhap.TabIndex = 51
        gbThongTinDangNhap.TabStop = False
        gbThongTinDangNhap.Text = "Thông tin đăng nhập"
        ' 
        ' btDoiPass
        ' 
        btDoiPass.Location = New Point(548, 105)
        btDoiPass.Name = "btDoiPass"
        btDoiPass.Size = New Size(140, 29)
        btDoiPass.TabIndex = 4
        btDoiPass.Text = "Đổi mật khẩu mới"
        btDoiPass.UseVisualStyleBackColor = True
        ' 
        ' lbNote
        ' 
        lbNote.AutoSize = True
        lbNote.Font = New Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, CByte(163))
        lbNote.Location = New Point(428, 66)
        lbNote.Name = "lbNote"
        lbNote.Size = New Size(380, 20)
        lbNote.TabIndex = 70
        lbNote.Text = "(*) Nhập mật khẩu hiện tại để xác nhận thay đổi thông tin"
        ' 
        ' tbPassCu
        ' 
        tbPassCu.Anchor = AnchorStyles.Top
        tbPassCu.Location = New Point(532, 36)
        tbPassCu.Name = "tbPassCu"
        tbPassCu.Size = New Size(234, 27)
        tbPassCu.TabIndex = 3
        tbPassCu.UseSystemPasswordChar = True
        ' 
        ' tb_XacNhanPass
        ' 
        tb_XacNhanPass.Anchor = AnchorStyles.Top
        tb_XacNhanPass.Location = New Point(149, 130)
        tb_XacNhanPass.Name = "tb_XacNhanPass"
        tb_XacNhanPass.Size = New Size(250, 27)
        tb_XacNhanPass.TabIndex = 2
        tb_XacNhanPass.UseSystemPasswordChar = True
        ' 
        ' lbPassCu
        ' 
        lbPassCu.Anchor = AnchorStyles.Top
        lbPassCu.AutoSize = True
        lbPassCu.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        lbPassCu.Location = New Point(428, 39)
        lbPassCu.Name = "lbPassCu"
        lbPassCu.Size = New Size(98, 20)
        lbPassCu.TabIndex = 65
        lbPassCu.Text = "*MK hiện tại:"
        ' 
        ' lbXacNhanMK
        ' 
        lbXacNhanMK.Anchor = AnchorStyles.Top
        lbXacNhanMK.AutoSize = True
        lbXacNhanMK.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        lbXacNhanMK.Location = New Point(29, 134)
        lbXacNhanMK.Name = "lbXacNhanMK"
        lbXacNhanMK.Size = New Size(103, 20)
        lbXacNhanMK.TabIndex = 69
        lbXacNhanMK.Text = "Xác nhận MK:"
        ' 
        ' tbPassMoi
        ' 
        tbPassMoi.Anchor = AnchorStyles.Top
        tbPassMoi.Location = New Point(149, 83)
        tbPassMoi.Name = "tbPassMoi"
        tbPassMoi.Size = New Size(250, 27)
        tbPassMoi.TabIndex = 1
        tbPassMoi.UseSystemPasswordChar = True
        ' 
        ' lbMKmoi
        ' 
        lbMKmoi.Anchor = AnchorStyles.Top
        lbMKmoi.AutoSize = True
        lbMKmoi.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        lbMKmoi.Location = New Point(29, 87)
        lbMKmoi.Name = "lbMKmoi"
        lbMKmoi.Size = New Size(108, 20)
        lbMKmoi.TabIndex = 67
        lbMKmoi.Text = "Mật khẩu mới:"
        ' 
        ' tbUsername
        ' 
        tbUsername.Anchor = AnchorStyles.Top
        tbUsername.Location = New Point(149, 36)
        tbUsername.Name = "tbUsername"
        tbUsername.Size = New Size(250, 27)
        tbUsername.TabIndex = 0
        ' 
        ' Label8
        ' 
        Label8.Anchor = AnchorStyles.Top
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        Label8.Location = New Point(29, 40)
        Label8.Name = "Label8"
        Label8.Size = New Size(115, 20)
        Label8.TabIndex = 65
        Label8.Text = "Tên đăng nhập:"
        ' 
        ' bt_LuuThongTin
        ' 
        bt_LuuThongTin.Anchor = AnchorStyles.Top
        bt_LuuThongTin.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold)
        bt_LuuThongTin.Image = CType(resources.GetObject("bt_LuuThongTin.Image"), Image)
        bt_LuuThongTin.ImageAlign = ContentAlignment.MiddleLeft
        bt_LuuThongTin.Location = New Point(339, 428)
        bt_LuuThongTin.Name = "bt_LuuThongTin"
        bt_LuuThongTin.Size = New Size(169, 42)
        bt_LuuThongTin.TabIndex = 0
        bt_LuuThongTin.Text = "Lưu thông tin"
        bt_LuuThongTin.TextAlign = ContentAlignment.MiddleRight
        bt_LuuThongTin.UseVisualStyleBackColor = True
        ' 
        ' frmThietLapNguoiDung
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(847, 485)
        Controls.Add(bt_LuuThongTin)
        Controls.Add(gbThongTinDangNhap)
        Controls.Add(gbThongTinChung)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        Name = "frmThietLapNguoiDung"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Thiết Lập Tài Khoản Người Dùng"
        gbThongTinChung.ResumeLayout(False)
        gbThongTinChung.PerformLayout()
        gbThongTinDangNhap.ResumeLayout(False)
        gbThongTinDangNhap.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents gbThongTinChung As GroupBox
    Friend WithEvents btThemVT As Button
    Friend WithEvents tb_DiaChi As TextBox
    Friend WithEvents cbbVaiTro As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents tbMaNguoiDung As TextBox
    Friend WithEvents dtp_NgaySinh As DateTimePicker
    Friend WithEvents cbbGioiTinh As ComboBox
    Friend WithEvents tbHoTen As TextBox
    Friend WithEvents gbThongTinDangNhap As GroupBox
    Friend WithEvents tb_XacNhanPass As TextBox
    Friend WithEvents lbXacNhanMK As Label
    Friend WithEvents tbPassMoi As TextBox
    Friend WithEvents lbMKmoi As Label
    Friend WithEvents tbUsername As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents tbPassCu As TextBox
    Friend WithEvents lbPassCu As Label
    Friend WithEvents bt_LuuThongTin As Button
    Friend WithEvents lbNote As Label
    Friend WithEvents btDoiPass As Button
End Class
