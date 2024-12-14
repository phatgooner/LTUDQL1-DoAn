<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmQuyen_VaiTro
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmQuyen_VaiTro))
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        tb_Ma = New TextBox()
        Label4 = New Label()
        tb_MoTa = New TextBox()
        tb_Ten = New TextBox()
        Label3 = New Label()
        Label2 = New Label()
        btTimKiem = New Button()
        btLuu = New Button()
        btSua = New Button()
        btXoa = New Button()
        btThem = New Button()
        Label1 = New Label()
        dgvDanhSachVaiTro = New DataGridView()
        CType(dgvDanhSachVaiTro, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' tb_Ma
        ' 
        tb_Ma.Location = New Point(122, 72)
        tb_Ma.Name = "tb_Ma"
        tb_Ma.ReadOnly = True
        tb_Ma.Size = New Size(312, 27)
        tb_Ma.TabIndex = 0
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        Label4.Location = New Point(12, 76)
        Label4.Name = "Label4"
        Label4.Size = New Size(83, 20)
        Label4.TabIndex = 29
        Label4.Text = "Mã vai trò:"
        ' 
        ' tb_MoTa
        ' 
        tb_MoTa.Location = New Point(122, 166)
        tb_MoTa.Name = "tb_MoTa"
        tb_MoTa.Size = New Size(312, 27)
        tb_MoTa.TabIndex = 2
        ' 
        ' tb_Ten
        ' 
        tb_Ten.Location = New Point(122, 119)
        tb_Ten.Name = "tb_Ten"
        tb_Ten.Size = New Size(312, 27)
        tb_Ten.TabIndex = 1
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        Label3.Location = New Point(12, 170)
        Label3.Name = "Label3"
        Label3.Size = New Size(53, 20)
        Label3.TabIndex = 28
        Label3.Text = "Mô tả:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        Label2.Location = New Point(12, 123)
        Label2.Name = "Label2"
        Label2.Size = New Size(85, 20)
        Label2.TabIndex = 27
        Label2.Text = "Tên vai trò:"
        ' 
        ' btTimKiem
        ' 
        btTimKiem.Anchor = AnchorStyles.Top
        btTimKiem.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold)
        btTimKiem.Image = CType(resources.GetObject("btTimKiem.Image"), Image)
        btTimKiem.ImageAlign = ContentAlignment.MiddleLeft
        btTimKiem.Location = New Point(629, 213)
        btTimKiem.Name = "btTimKiem"
        btTimKiem.Size = New Size(135, 42)
        btTimKiem.TabIndex = 7
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
        btLuu.Location = New Point(484, 213)
        btLuu.Name = "btLuu"
        btLuu.Size = New Size(92, 42)
        btLuu.TabIndex = 6
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
        btSua.Location = New Point(341, 213)
        btSua.Name = "btSua"
        btSua.Size = New Size(90, 42)
        btSua.TabIndex = 5
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
        btXoa.Location = New Point(196, 213)
        btXoa.Name = "btXoa"
        btXoa.Size = New Size(92, 42)
        btXoa.TabIndex = 4
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
        btThem.Location = New Point(36, 213)
        btThem.Name = "btThem"
        btThem.Size = New Size(107, 42)
        btThem.TabIndex = 3
        btThem.Text = "Thêm"
        btThem.TextAlign = ContentAlignment.MiddleRight
        btThem.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.Top
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(163))
        Label1.Location = New Point(179, 12)
        Label1.Margin = New Padding(3)
        Label1.Name = "Label1"
        Label1.Size = New Size(442, 31)
        Label1.TabIndex = 25
        Label1.Text = "QUẢN LÝ VAI TRÒ VÀ QUYỀN TRUY CẬP"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' dgvDanhSachVaiTro
        ' 
        dgvDanhSachVaiTro.AllowUserToOrderColumns = True
        dgvDanhSachVaiTro.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        dgvDanhSachVaiTro.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = SystemColors.Control
        DataGridViewCellStyle1.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(163))
        DataGridViewCellStyle1.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        dgvDanhSachVaiTro.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        dgvDanhSachVaiTro.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvDanhSachVaiTro.Location = New Point(12, 266)
        dgvDanhSachVaiTro.Name = "dgvDanhSachVaiTro"
        dgvDanhSachVaiTro.ReadOnly = True
        dgvDanhSachVaiTro.RowHeadersWidth = 51
        dgvDanhSachVaiTro.Size = New Size(776, 172)
        dgvDanhSachVaiTro.TabIndex = 8
        ' 
        ' frmQuyen_VaiTro
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        ControlBox = False
        Controls.Add(tb_Ma)
        Controls.Add(Label4)
        Controls.Add(tb_MoTa)
        Controls.Add(tb_Ten)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(btTimKiem)
        Controls.Add(btLuu)
        Controls.Add(btSua)
        Controls.Add(btXoa)
        Controls.Add(btThem)
        Controls.Add(Label1)
        Controls.Add(dgvDanhSachVaiTro)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Name = "frmQuyen_VaiTro"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Quản Lý Quyền Và Vai Trò"
        CType(dgvDanhSachVaiTro, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents tb_Ma As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents tb_MoTa As TextBox
    Friend WithEvents tb_Ten As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btTimKiem As Button
    Friend WithEvents btLuu As Button
    Friend WithEvents btSua As Button
    Friend WithEvents btXoa As Button
    Friend WithEvents btThem As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents dgvDanhSachVaiTro As DataGridView
End Class
