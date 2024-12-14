<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmQuanLySanPham
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmQuanLySanPham))
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        tb_Ten = New TextBox()
        Label4 = New Label()
        tb_MoTa = New TextBox()
        Label3 = New Label()
        Label2 = New Label()
        btTimKiem = New Button()
        btLuu = New Button()
        btSua = New Button()
        btXoa = New Button()
        btThem = New Button()
        Label1 = New Label()
        dgvDanhSachSanPham = New DataGridView()
        Label5 = New Label()
        tb_GiaBan = New TextBox()
        tb_GiaNhap = New TextBox()
        Label6 = New Label()
        Label7 = New Label()
        cbbDanhMuc = New ComboBox()
        cbb_NSX = New ComboBox()
        btThemDanhMuc = New Button()
        btThemNSX = New Button()
        Panel1 = New Panel()
        CType(dgvDanhSachSanPham, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' tb_Ten
        ' 
        tb_Ten.Anchor = AnchorStyles.Top
        tb_Ten.Location = New Point(148, 72)
        tb_Ten.Name = "tb_Ten"
        tb_Ten.Size = New Size(237, 27)
        tb_Ten.TabIndex = 0
        ' 
        ' Label4
        ' 
        Label4.Anchor = AnchorStyles.Top
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        Label4.Location = New Point(38, 76)
        Label4.Name = "Label4"
        Label4.Size = New Size(107, 20)
        Label4.TabIndex = 29
        Label4.Text = "Tên sản phẩm:"
        ' 
        ' tb_MoTa
        ' 
        tb_MoTa.Anchor = AnchorStyles.Top
        tb_MoTa.Location = New Point(148, 119)
        tb_MoTa.Name = "tb_MoTa"
        tb_MoTa.Size = New Size(237, 27)
        tb_MoTa.TabIndex = 1
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.Top
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        Label3.Location = New Point(38, 170)
        Label3.Name = "Label3"
        Label3.Size = New Size(83, 20)
        Label3.TabIndex = 26
        Label3.Text = "Danh mục:"
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.Top
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        Label2.Location = New Point(38, 123)
        Label2.Name = "Label2"
        Label2.Size = New Size(53, 20)
        Label2.TabIndex = 25
        Label2.Text = "Mô tả:"
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
        Label1.Location = New Point(363, 12)
        Label1.Margin = New Padding(3)
        Label1.Name = "Label1"
        Label1.Size = New Size(242, 31)
        Label1.TabIndex = 19
        Label1.Text = "QUẢN LÝ SẢN PHẨM"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' dgvDanhSachSanPham
        ' 
        dgvDanhSachSanPham.AllowUserToOrderColumns = True
        dgvDanhSachSanPham.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        dgvDanhSachSanPham.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = SystemColors.Control
        DataGridViewCellStyle1.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(163))
        DataGridViewCellStyle1.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        dgvDanhSachSanPham.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        dgvDanhSachSanPham.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvDanhSachSanPham.Location = New Point(12, 266)
        dgvDanhSachSanPham.Name = "dgvDanhSachSanPham"
        dgvDanhSachSanPham.ReadOnly = True
        dgvDanhSachSanPham.RowHeadersWidth = 51
        dgvDanhSachSanPham.Size = New Size(945, 172)
        dgvDanhSachSanPham.TabIndex = 18
        ' 
        ' Label5
        ' 
        Label5.Anchor = AnchorStyles.Top
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        Label5.Location = New Point(584, 76)
        Label5.Name = "Label5"
        Label5.Size = New Size(103, 20)
        Label5.TabIndex = 35
        Label5.Text = "Nhà sản xuất:"
        ' 
        ' tb_GiaBan
        ' 
        tb_GiaBan.Anchor = AnchorStyles.Top
        tb_GiaBan.Location = New Point(694, 166)
        tb_GiaBan.Name = "tb_GiaBan"
        tb_GiaBan.Size = New Size(237, 27)
        tb_GiaBan.TabIndex = 5
        ' 
        ' tb_GiaNhap
        ' 
        tb_GiaNhap.Anchor = AnchorStyles.Top
        tb_GiaNhap.Location = New Point(694, 119)
        tb_GiaNhap.Name = "tb_GiaNhap"
        tb_GiaNhap.Size = New Size(237, 27)
        tb_GiaNhap.TabIndex = 4
        ' 
        ' Label6
        ' 
        Label6.Anchor = AnchorStyles.Top
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        Label6.Location = New Point(584, 170)
        Label6.Name = "Label6"
        Label6.Size = New Size(65, 20)
        Label6.TabIndex = 32
        Label6.Text = "Giá bán:"
        ' 
        ' Label7
        ' 
        Label7.Anchor = AnchorStyles.Top
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        Label7.Location = New Point(584, 123)
        Label7.Name = "Label7"
        Label7.Size = New Size(74, 20)
        Label7.TabIndex = 31
        Label7.Text = "Giá nhập:"
        ' 
        ' cbbDanhMuc
        ' 
        cbbDanhMuc.Anchor = AnchorStyles.Top
        cbbDanhMuc.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        cbbDanhMuc.AutoCompleteSource = AutoCompleteSource.ListItems
        cbbDanhMuc.DropDownStyle = ComboBoxStyle.DropDownList
        cbbDanhMuc.FormattingEnabled = True
        cbbDanhMuc.Location = New Point(148, 166)
        cbbDanhMuc.Name = "cbbDanhMuc"
        cbbDanhMuc.Size = New Size(237, 28)
        cbbDanhMuc.TabIndex = 2
        ' 
        ' cbb_NSX
        ' 
        cbb_NSX.Anchor = AnchorStyles.Top
        cbb_NSX.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        cbb_NSX.AutoCompleteSource = AutoCompleteSource.ListItems
        cbb_NSX.DropDownStyle = ComboBoxStyle.DropDownList
        cbb_NSX.FormattingEnabled = True
        cbb_NSX.Location = New Point(3, 2)
        cbb_NSX.Name = "cbb_NSX"
        cbb_NSX.Size = New Size(237, 28)
        cbb_NSX.TabIndex = 3
        ' 
        ' btThemDanhMuc
        ' 
        btThemDanhMuc.Anchor = AnchorStyles.Top
        btThemDanhMuc.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(163))
        btThemDanhMuc.Location = New Point(385, 165)
        btThemDanhMuc.Name = "btThemDanhMuc"
        btThemDanhMuc.Size = New Size(30, 30)
        btThemDanhMuc.TabIndex = 36
        btThemDanhMuc.Text = "+"
        btThemDanhMuc.UseVisualStyleBackColor = True
        ' 
        ' btThemNSX
        ' 
        btThemNSX.Anchor = AnchorStyles.None
        btThemNSX.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(163))
        btThemNSX.Location = New Point(240, 1)
        btThemNSX.Name = "btThemNSX"
        btThemNSX.Size = New Size(30, 30)
        btThemNSX.TabIndex = 37
        btThemNSX.Text = "+"
        btThemNSX.UseVisualStyleBackColor = True
        ' 
        ' Panel1
        ' 
        Panel1.Anchor = AnchorStyles.Top
        Panel1.Controls.Add(cbb_NSX)
        Panel1.Controls.Add(btThemNSX)
        Panel1.Location = New Point(693, 70)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(274, 33)
        Panel1.TabIndex = 38
        ' 
        ' frmQuanLySanPham
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(969, 450)
        ControlBox = False
        Controls.Add(Panel1)
        Controls.Add(btThemDanhMuc)
        Controls.Add(cbbDanhMuc)
        Controls.Add(Label5)
        Controls.Add(tb_GiaBan)
        Controls.Add(tb_GiaNhap)
        Controls.Add(Label6)
        Controls.Add(Label7)
        Controls.Add(tb_Ten)
        Controls.Add(Label4)
        Controls.Add(tb_MoTa)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(btTimKiem)
        Controls.Add(btLuu)
        Controls.Add(btSua)
        Controls.Add(btXoa)
        Controls.Add(btThem)
        Controls.Add(Label1)
        Controls.Add(dgvDanhSachSanPham)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Name = "frmQuanLySanPham"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Quản Lý Sản Phẩm"
        CType(dgvDanhSachSanPham, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents tb_Ten As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents tb_MoTa As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btTimKiem As Button
    Friend WithEvents btLuu As Button
    Friend WithEvents btSua As Button
    Friend WithEvents btXoa As Button
    Friend WithEvents btThem As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents dgvDanhSachSanPham As DataGridView
    Friend WithEvents Label5 As Label
    Friend WithEvents tb_GiaBan As TextBox
    Friend WithEvents tb_GiaNhap As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents cbbDanhMuc As ComboBox
    Friend WithEvents cbb_NSX As ComboBox
    Friend WithEvents btThemDanhMuc As Button
    Friend WithEvents btThemNSX As Button
    Friend WithEvents Panel1 As Panel
End Class
