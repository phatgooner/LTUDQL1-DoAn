<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDanhSachLoaiHang
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
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        dgvDanhSachLoaiHang = New DataGridView()
        Label1 = New Label()
        Label2 = New Label()
        tbTimKiem = New TextBox()
        cbHienTatCa = New CheckBox()
        CType(dgvDanhSachLoaiHang, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' dgvDanhSachLoaiHang
        ' 
        dgvDanhSachLoaiHang.AllowUserToOrderColumns = True
        dgvDanhSachLoaiHang.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        dgvDanhSachLoaiHang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = SystemColors.Control
        DataGridViewCellStyle1.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(163))
        DataGridViewCellStyle1.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        dgvDanhSachLoaiHang.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        dgvDanhSachLoaiHang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvDanhSachLoaiHang.Location = New Point(12, 171)
        dgvDanhSachLoaiHang.Name = "dgvDanhSachLoaiHang"
        dgvDanhSachLoaiHang.ReadOnly = True
        dgvDanhSachLoaiHang.RowHeadersWidth = 51
        dgvDanhSachLoaiHang.Size = New Size(776, 267)
        dgvDanhSachLoaiHang.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.Top
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(163))
        Label1.Location = New Point(260, 75)
        Label1.Margin = New Padding(3)
        Label1.Name = "Label1"
        Label1.Size = New Size(281, 31)
        Label1.TabIndex = 1
        Label1.Text = "DANH SÁCH LOẠI HÀNG"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(163))
        Label2.Location = New Point(12, 132)
        Label2.Name = "Label2"
        Label2.Size = New Size(79, 23)
        Label2.TabIndex = 2
        Label2.Text = "Tìm kiếm"
        ' 
        ' tbTimKiem
        ' 
        tbTimKiem.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        tbTimKiem.Location = New Point(97, 131)
        tbTimKiem.Name = "tbTimKiem"
        tbTimKiem.Size = New Size(567, 27)
        tbTimKiem.TabIndex = 3
        ' 
        ' cbHienTatCa
        ' 
        cbHienTatCa.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Right
        cbHienTatCa.AutoSize = True
        cbHienTatCa.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(163))
        cbHienTatCa.Location = New Point(670, 131)
        cbHienTatCa.Name = "cbHienTatCa"
        cbHienTatCa.Size = New Size(115, 27)
        cbHienTatCa.TabIndex = 4
        cbHienTatCa.Text = "Hiện tất cả"
        cbHienTatCa.UseVisualStyleBackColor = True
        ' 
        ' frmDanhSachLoaiHang
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        AutoSize = True
        ClientSize = New Size(800, 450)
        ControlBox = False
        Controls.Add(cbHienTatCa)
        Controls.Add(tbTimKiem)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(dgvDanhSachLoaiHang)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Name = "frmDanhSachLoaiHang"
        Text = "Danh Sách Loại Hàng"
        CType(dgvDanhSachLoaiHang, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents dgvDanhSachLoaiHang As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents tbTimKiem As TextBox
    Friend WithEvents cbHienTatCa As CheckBox
End Class
