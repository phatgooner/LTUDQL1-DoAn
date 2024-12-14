<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmQuanLyPhieuNhap
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmQuanLyPhieuNhap))
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        btTimKiem = New Button()
        btSua = New Button()
        btXoa = New Button()
        btThem = New Button()
        Label1 = New Label()
        dgvDanhSachPhieuNhap = New DataGridView()
        CType(dgvDanhSachPhieuNhap, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btTimKiem
        ' 
        btTimKiem.Anchor = AnchorStyles.Top
        btTimKiem.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold)
        btTimKiem.Image = CType(resources.GetObject("btTimKiem.Image"), Image)
        btTimKiem.ImageAlign = ContentAlignment.MiddleLeft
        btTimKiem.Location = New Point(563, 131)
        btTimKiem.Name = "btTimKiem"
        btTimKiem.Size = New Size(135, 42)
        btTimKiem.TabIndex = 3
        btTimKiem.Text = "Tìm kiếm"
        btTimKiem.TextAlign = ContentAlignment.MiddleRight
        btTimKiem.UseVisualStyleBackColor = True
        ' 
        ' btSua
        ' 
        btSua.Anchor = AnchorStyles.Top
        btSua.Enabled = False
        btSua.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold)
        btSua.Image = CType(resources.GetObject("btSua.Image"), Image)
        btSua.ImageAlign = ContentAlignment.MiddleLeft
        btSua.Location = New Point(416, 131)
        btSua.Name = "btSua"
        btSua.Size = New Size(90, 42)
        btSua.TabIndex = 2
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
        btXoa.Location = New Point(267, 131)
        btXoa.Name = "btXoa"
        btXoa.Size = New Size(92, 42)
        btXoa.TabIndex = 1
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
        btThem.Location = New Point(103, 131)
        btThem.Name = "btThem"
        btThem.Size = New Size(107, 42)
        btThem.TabIndex = 0
        btThem.Text = "Thêm"
        btThem.TextAlign = ContentAlignment.MiddleRight
        btThem.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.Top
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(163))
        Label1.Location = New Point(271, 55)
        Label1.Margin = New Padding(3)
        Label1.Name = "Label1"
        Label1.Size = New Size(259, 31)
        Label1.TabIndex = 25
        Label1.Text = "QUẢN LÝ PHIẾU NHẬP"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' dgvDanhSachPhieuNhap
        ' 
        dgvDanhSachPhieuNhap.AllowUserToOrderColumns = True
        dgvDanhSachPhieuNhap.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        dgvDanhSachPhieuNhap.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = SystemColors.Control
        DataGridViewCellStyle1.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(163))
        DataGridViewCellStyle1.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        dgvDanhSachPhieuNhap.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        dgvDanhSachPhieuNhap.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvDanhSachPhieuNhap.Location = New Point(12, 196)
        dgvDanhSachPhieuNhap.Name = "dgvDanhSachPhieuNhap"
        dgvDanhSachPhieuNhap.ReadOnly = True
        dgvDanhSachPhieuNhap.RowHeadersWidth = 51
        dgvDanhSachPhieuNhap.Size = New Size(776, 242)
        dgvDanhSachPhieuNhap.TabIndex = 23
        ' 
        ' frmQuanLyPhieuNhap
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        ControlBox = False
        Controls.Add(btTimKiem)
        Controls.Add(btSua)
        Controls.Add(btXoa)
        Controls.Add(btThem)
        Controls.Add(Label1)
        Controls.Add(dgvDanhSachPhieuNhap)
        Name = "frmQuanLyPhieuNhap"
        Text = "Quản Lý Phiếu Nhập"
        CType(dgvDanhSachPhieuNhap, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btTimKiem As Button
    Friend WithEvents btSua As Button
    Friend WithEvents btXoa As Button
    Friend WithEvents btThem As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents dgvDanhSachPhieuNhap As DataGridView
End Class
