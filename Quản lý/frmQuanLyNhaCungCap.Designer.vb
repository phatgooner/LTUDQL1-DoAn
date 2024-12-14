<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmQuanLyNhaCungCap
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmQuanLyNhaCungCap))
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Label5 = New Label()
        tb_NLL = New TextBox()
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
        dgvDanhSachNhaCungCap = New DataGridView()
        tb_MoTa = New TextBox()
        tb_DiaChi = New TextBox()
        CType(dgvDanhSachNhaCungCap, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label5
        ' 
        Label5.Anchor = AnchorStyles.Top
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        Label5.Location = New Point(509, 76)
        Label5.Name = "Label5"
        Label5.Size = New Size(60, 20)
        Label5.TabIndex = 54
        Label5.Text = "Địa chỉ:"
        ' 
        ' tb_NLL
        ' 
        tb_NLL.Anchor = AnchorStyles.Top
        tb_NLL.Location = New Point(619, 166)
        tb_NLL.Name = "tb_NLL"
        tb_NLL.Size = New Size(237, 27)
        tb_NLL.TabIndex = 5
        ' 
        ' tb_SDT
        ' 
        tb_SDT.Anchor = AnchorStyles.Top
        tb_SDT.Location = New Point(619, 119)
        tb_SDT.Name = "tb_SDT"
        tb_SDT.Size = New Size(237, 27)
        tb_SDT.TabIndex = 4
        ' 
        ' Label6
        ' 
        Label6.Anchor = AnchorStyles.Top
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        Label6.Location = New Point(509, 170)
        Label6.Name = "Label6"
        Label6.Size = New Size(108, 20)
        Label6.TabIndex = 51
        Label6.Text = "Người liên lạc:"
        ' 
        ' Label7
        ' 
        Label7.Anchor = AnchorStyles.Top
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        Label7.Location = New Point(509, 123)
        Label7.Name = "Label7"
        Label7.Size = New Size(103, 20)
        Label7.TabIndex = 50
        Label7.Text = "Số điện thoại:"
        ' 
        ' tb_Ma
        ' 
        tb_Ma.Anchor = AnchorStyles.Top
        tb_Ma.Location = New Point(172, 72)
        tb_Ma.Name = "tb_Ma"
        tb_Ma.Size = New Size(237, 27)
        tb_Ma.TabIndex = 0
        ' 
        ' Label4
        ' 
        Label4.Anchor = AnchorStyles.Top
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        Label4.Location = New Point(113, 76)
        Label4.Name = "Label4"
        Label4.Size = New Size(35, 20)
        Label4.TabIndex = 48
        Label4.Text = "Mã:"
        ' 
        ' tb_Ten
        ' 
        tb_Ten.Anchor = AnchorStyles.Top
        tb_Ten.Location = New Point(172, 119)
        tb_Ten.Name = "tb_Ten"
        tb_Ten.Size = New Size(237, 27)
        tb_Ten.TabIndex = 1
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.Top
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        Label3.Location = New Point(113, 170)
        Label3.Name = "Label3"
        Label3.Size = New Size(53, 20)
        Label3.TabIndex = 46
        Label3.Text = "Mô tả:"
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.Top
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        Label2.Location = New Point(113, 123)
        Label2.Name = "Label2"
        Label2.Size = New Size(37, 20)
        Label2.TabIndex = 45
        Label2.Text = "Tên:"
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
        Label1.Location = New Point(338, 12)
        Label1.Margin = New Padding(3)
        Label1.Name = "Label1"
        Label1.Size = New Size(292, 31)
        Label1.TabIndex = 39
        Label1.Text = "QUẢN LÝ NHÀ CUNG CẤP"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' dgvDanhSachNhaCungCap
        ' 
        dgvDanhSachNhaCungCap.AllowUserToOrderColumns = True
        dgvDanhSachNhaCungCap.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        dgvDanhSachNhaCungCap.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = SystemColors.Control
        DataGridViewCellStyle1.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(163))
        DataGridViewCellStyle1.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        dgvDanhSachNhaCungCap.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        dgvDanhSachNhaCungCap.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvDanhSachNhaCungCap.Location = New Point(12, 266)
        dgvDanhSachNhaCungCap.Name = "dgvDanhSachNhaCungCap"
        dgvDanhSachNhaCungCap.ReadOnly = True
        dgvDanhSachNhaCungCap.RowHeadersWidth = 51
        dgvDanhSachNhaCungCap.Size = New Size(945, 172)
        dgvDanhSachNhaCungCap.TabIndex = 38
        ' 
        ' tb_MoTa
        ' 
        tb_MoTa.Anchor = AnchorStyles.Top
        tb_MoTa.Location = New Point(172, 166)
        tb_MoTa.Name = "tb_MoTa"
        tb_MoTa.Size = New Size(237, 27)
        tb_MoTa.TabIndex = 2
        ' 
        ' tb_DiaChi
        ' 
        tb_DiaChi.Anchor = AnchorStyles.Top
        tb_DiaChi.Location = New Point(619, 72)
        tb_DiaChi.Name = "tb_DiaChi"
        tb_DiaChi.Size = New Size(237, 27)
        tb_DiaChi.TabIndex = 3
        ' 
        ' frmQuanLyNhaCungCap
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(969, 450)
        ControlBox = False
        Controls.Add(tb_DiaChi)
        Controls.Add(tb_MoTa)
        Controls.Add(Label5)
        Controls.Add(tb_NLL)
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
        Controls.Add(dgvDanhSachNhaCungCap)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Name = "frmQuanLyNhaCungCap"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Quản Lý Nhà Cung Cấp"
        CType(dgvDanhSachNhaCungCap, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Label5 As Label
    Friend WithEvents tb_NLL As TextBox
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
    Friend WithEvents dgvDanhSachNhaCungCap As DataGridView
    Friend WithEvents tb_MoTa As TextBox
    Friend WithEvents tb_DiaChi As TextBox
End Class
