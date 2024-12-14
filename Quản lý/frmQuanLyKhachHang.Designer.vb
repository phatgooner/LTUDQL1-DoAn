<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmQuanLyKhachHang
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmQuanLyKhachHang))
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        cbb_NhomKH = New ComboBox()
        Label5 = New Label()
        tb_SDT = New TextBox()
        Label6 = New Label()
        Label7 = New Label()
        tb_Ma = New TextBox()
        Label4 = New Label()
        tb_Ten = New TextBox()
        Label3 = New Label()
        Label2 = New Label()
        btTimKiem = New Button()
        btLuu = New Button()
        btSua = New Button()
        btXoa = New Button()
        btThem = New Button()
        Label1 = New Label()
        dgvDanhSachKhachHang = New DataGridView()
        tb_DiaChi = New TextBox()
        tb_Email = New TextBox()
        Panel1 = New Panel()
        btThemNKH = New Button()
        CType(dgvDanhSachKhachHang, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' cbb_NhomKH
        ' 
        cbb_NhomKH.Anchor = AnchorStyles.Top
        cbb_NhomKH.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        cbb_NhomKH.AutoCompleteSource = AutoCompleteSource.ListItems
        cbb_NhomKH.DropDownStyle = ComboBoxStyle.DropDownList
        cbb_NhomKH.FormattingEnabled = True
        cbb_NhomKH.Location = New Point(3, 3)
        cbb_NhomKH.Name = "cbb_NhomKH"
        cbb_NhomKH.Size = New Size(237, 28)
        cbb_NhomKH.TabIndex = 5
        ' 
        ' Label5
        ' 
        Label5.Anchor = AnchorStyles.Top
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        Label5.Location = New Point(584, 76)
        Label5.Name = "Label5"
        Label5.Size = New Size(50, 20)
        Label5.TabIndex = 54
        Label5.Text = "Email:"
        ' 
        ' tb_SDT
        ' 
        tb_SDT.Anchor = AnchorStyles.Top
        tb_SDT.Location = New Point(694, 119)
        tb_SDT.Name = "tb_SDT"
        tb_SDT.Size = New Size(237, 27)
        tb_SDT.TabIndex = 4
        ' 
        ' Label6
        ' 
        Label6.Anchor = AnchorStyles.Top
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        Label6.Location = New Point(584, 170)
        Label6.Name = "Label6"
        Label6.Size = New Size(80, 20)
        Label6.TabIndex = 53
        Label6.Text = "Nhóm KH:"
        ' 
        ' Label7
        ' 
        Label7.Anchor = AnchorStyles.Top
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        Label7.Location = New Point(584, 123)
        Label7.Name = "Label7"
        Label7.Size = New Size(103, 20)
        Label7.TabIndex = 52
        Label7.Text = "Số điện thoại:"
        ' 
        ' tb_Ma
        ' 
        tb_Ma.Anchor = AnchorStyles.Top
        tb_Ma.Location = New Point(148, 72)
        tb_Ma.Name = "tb_Ma"
        tb_Ma.Size = New Size(237, 27)
        tb_Ma.TabIndex = 0
        ' 
        ' Label4
        ' 
        Label4.Anchor = AnchorStyles.Top
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        Label4.Location = New Point(38, 76)
        Label4.Name = "Label4"
        Label4.Size = New Size(59, 20)
        Label4.TabIndex = 51
        Label4.Text = "Mã KH:"
        ' 
        ' tb_Ten
        ' 
        tb_Ten.Anchor = AnchorStyles.Top
        tb_Ten.Location = New Point(148, 119)
        tb_Ten.Name = "tb_Ten"
        tb_Ten.Size = New Size(237, 27)
        tb_Ten.TabIndex = 1
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.Top
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        Label3.Location = New Point(38, 170)
        Label3.Name = "Label3"
        Label3.Size = New Size(60, 20)
        Label3.TabIndex = 50
        Label3.Text = "Địa chỉ:"
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.Top
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        Label2.Location = New Point(38, 123)
        Label2.Name = "Label2"
        Label2.Size = New Size(61, 20)
        Label2.TabIndex = 49
        Label2.Text = "Tên KH:"
        ' 
        ' btTimKiem
        ' 
        btTimKiem.Anchor = AnchorStyles.Top
        btTimKiem.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold)
        btTimKiem.Image = CType(resources.GetObject("btTimKiem.Image"), Image)
        btTimKiem.ImageAlign = ContentAlignment.MiddleLeft
        btTimKiem.Location = New Point(713, 213)
        btTimKiem.Name = "btTimKiem"
        btTimKiem.Size = New Size(135, 42)
        btTimKiem.TabIndex = 10
        btTimKiem.Text = "Tìm kiếm"
        btTimKiem.TextAlign = ContentAlignment.MiddleRight
        btTimKiem.UseVisualStyleBackColor = True
        ' 
        ' btLuu
        ' 
        btLuu.Anchor = AnchorStyles.Top
        btLuu.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold)
        btLuu.Image = CType(resources.GetObject("btLuu.Image"), Image)
        btLuu.ImageAlign = ContentAlignment.MiddleLeft
        btLuu.Location = New Point(568, 213)
        btLuu.Name = "btLuu"
        btLuu.Size = New Size(92, 42)
        btLuu.TabIndex = 9
        btLuu.Text = "Lưu"
        btLuu.TextAlign = ContentAlignment.MiddleRight
        btLuu.UseVisualStyleBackColor = True
        ' 
        ' btSua
        ' 
        btSua.Anchor = AnchorStyles.Top
        btSua.Enabled = False
        btSua.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold)
        btSua.Image = CType(resources.GetObject("btSua.Image"), Image)
        btSua.ImageAlign = ContentAlignment.MiddleLeft
        btSua.Location = New Point(425, 213)
        btSua.Name = "btSua"
        btSua.Size = New Size(90, 42)
        btSua.TabIndex = 8
        btSua.Text = "Sửa"
        btSua.TextAlign = ContentAlignment.MiddleRight
        btSua.UseVisualStyleBackColor = True
        ' 
        ' btXoa
        ' 
        btXoa.Anchor = AnchorStyles.Top
        btXoa.Enabled = False
        btXoa.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold)
        btXoa.Image = CType(resources.GetObject("btXoa.Image"), Image)
        btXoa.ImageAlign = ContentAlignment.MiddleLeft
        btXoa.Location = New Point(280, 213)
        btXoa.Name = "btXoa"
        btXoa.Size = New Size(92, 42)
        btXoa.TabIndex = 7
        btXoa.Text = "Xóa"
        btXoa.TextAlign = ContentAlignment.MiddleRight
        btXoa.UseVisualStyleBackColor = True
        ' 
        ' btThem
        ' 
        btThem.Anchor = AnchorStyles.Top
        btThem.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold)
        btThem.Image = CType(resources.GetObject("btThem.Image"), Image)
        btThem.ImageAlign = ContentAlignment.MiddleLeft
        btThem.Location = New Point(120, 213)
        btThem.Name = "btThem"
        btThem.Size = New Size(107, 42)
        btThem.TabIndex = 6
        btThem.Text = "Thêm"
        btThem.TextAlign = ContentAlignment.MiddleRight
        btThem.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.Top
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(163))
        Label1.Location = New Point(347, 12)
        Label1.Margin = New Padding(3)
        Label1.Name = "Label1"
        Label1.Size = New Size(274, 31)
        Label1.TabIndex = 48
        Label1.Text = "QUẢN LÝ KHÁCH HÀNG"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' dgvDanhSachKhachHang
        ' 
        dgvDanhSachKhachHang.AllowUserToOrderColumns = True
        dgvDanhSachKhachHang.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        dgvDanhSachKhachHang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = SystemColors.Control
        DataGridViewCellStyle1.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(163))
        DataGridViewCellStyle1.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        dgvDanhSachKhachHang.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        dgvDanhSachKhachHang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvDanhSachKhachHang.Location = New Point(12, 266)
        dgvDanhSachKhachHang.Name = "dgvDanhSachKhachHang"
        dgvDanhSachKhachHang.ReadOnly = True
        dgvDanhSachKhachHang.RowHeadersWidth = 51
        dgvDanhSachKhachHang.Size = New Size(945, 172)
        dgvDanhSachKhachHang.TabIndex = 47
        ' 
        ' tb_DiaChi
        ' 
        tb_DiaChi.Anchor = AnchorStyles.Top
        tb_DiaChi.Location = New Point(148, 167)
        tb_DiaChi.Name = "tb_DiaChi"
        tb_DiaChi.Size = New Size(237, 27)
        tb_DiaChi.TabIndex = 2
        ' 
        ' tb_Email
        ' 
        tb_Email.Anchor = AnchorStyles.Top
        tb_Email.Location = New Point(694, 73)
        tb_Email.Name = "tb_Email"
        tb_Email.Size = New Size(237, 27)
        tb_Email.TabIndex = 3
        ' 
        ' Panel1
        ' 
        Panel1.Anchor = AnchorStyles.Top
        Panel1.Controls.Add(btThemNKH)
        Panel1.Controls.Add(cbb_NhomKH)
        Panel1.Location = New Point(692, 164)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(269, 34)
        Panel1.TabIndex = 55
        ' 
        ' btThemNKH
        ' 
        btThemNKH.Anchor = AnchorStyles.None
        btThemNKH.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(163))
        btThemNKH.Location = New Point(239, 2)
        btThemNKH.Name = "btThemNKH"
        btThemNKH.Size = New Size(30, 30)
        btThemNKH.TabIndex = 38
        btThemNKH.Text = "+"
        btThemNKH.UseVisualStyleBackColor = True
        ' 
        ' frmQuanLyKhachHang
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(969, 450)
        ControlBox = False
        Controls.Add(Panel1)
        Controls.Add(tb_Email)
        Controls.Add(tb_DiaChi)
        Controls.Add(Label5)
        Controls.Add(tb_SDT)
        Controls.Add(Label6)
        Controls.Add(Label7)
        Controls.Add(tb_Ma)
        Controls.Add(Label4)
        Controls.Add(tb_Ten)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(btTimKiem)
        Controls.Add(btLuu)
        Controls.Add(btSua)
        Controls.Add(btXoa)
        Controls.Add(btThem)
        Controls.Add(Label1)
        Controls.Add(dgvDanhSachKhachHang)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Name = "frmQuanLyKhachHang"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Quản Lý Khách Hàng"
        CType(dgvDanhSachKhachHang, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents cbb_NhomKH As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents tb_SDT As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents tb_Ma As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents tb_Ten As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btTimKiem As Button
    Friend WithEvents btLuu As Button
    Friend WithEvents btSua As Button
    Friend WithEvents btXoa As Button
    Friend WithEvents btThem As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents dgvDanhSachKhachHang As DataGridView
    Friend WithEvents tb_DiaChi As TextBox
    Friend WithEvents tb_Email As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btThemNKH As Button
End Class
