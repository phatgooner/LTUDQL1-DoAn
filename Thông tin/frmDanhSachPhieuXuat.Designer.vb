<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDanhSachPhieuXuat
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
        Label1 = New Label()
        dgvDanhSachPhieuXuat = New DataGridView()
        btTimKiem = New Button()
        Label3 = New Label()
        dtpNgay2 = New DateTimePicker()
        dtpNgay1 = New DateTimePicker()
        Label2 = New Label()
        btLamMoi = New Button()
        CType(dgvDanhSachPhieuXuat, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.Top
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(163))
        Label1.Location = New Point(290, 75)
        Label1.Margin = New Padding(3)
        Label1.Name = "Label1"
        Label1.Size = New Size(291, 31)
        Label1.TabIndex = 6
        Label1.Text = "DANH SÁCH PHIẾU XUẤT"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' dgvDanhSachPhieuXuat
        ' 
        dgvDanhSachPhieuXuat.AllowUserToOrderColumns = True
        dgvDanhSachPhieuXuat.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        dgvDanhSachPhieuXuat.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = SystemColors.Control
        DataGridViewCellStyle1.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(163))
        DataGridViewCellStyle1.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        dgvDanhSachPhieuXuat.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        dgvDanhSachPhieuXuat.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvDanhSachPhieuXuat.Location = New Point(12, 171)
        dgvDanhSachPhieuXuat.Name = "dgvDanhSachPhieuXuat"
        dgvDanhSachPhieuXuat.ReadOnly = True
        dgvDanhSachPhieuXuat.RowHeadersWidth = 51
        dgvDanhSachPhieuXuat.Size = New Size(846, 267)
        dgvDanhSachPhieuXuat.TabIndex = 5
        ' 
        ' btTimKiem
        ' 
        btTimKiem.Location = New Point(646, 129)
        btTimKiem.Name = "btTimKiem"
        btTimKiem.Size = New Size(94, 29)
        btTimKiem.TabIndex = 18
        btTimKiem.Text = "Tìm kiếm"
        btTimKiem.UseVisualStyleBackColor = True
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(163))
        Label3.Location = New Point(345, 132)
        Label3.Name = "Label3"
        Label3.Size = New Size(39, 23)
        Label3.TabIndex = 17
        Label3.Text = "đến"
        ' 
        ' dtpNgay2
        ' 
        dtpNgay2.Location = New Point(390, 130)
        dtpNgay2.Name = "dtpNgay2"
        dtpNgay2.Size = New Size(250, 27)
        dtpNgay2.TabIndex = 16
        ' 
        ' dtpNgay1
        ' 
        dtpNgay1.Location = New Point(89, 130)
        dtpNgay1.Name = "dtpNgay1"
        dtpNgay1.Size = New Size(250, 27)
        dtpNgay1.TabIndex = 15
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(163))
        Label2.Location = New Point(12, 132)
        Label2.Name = "Label2"
        Label2.Size = New Size(71, 23)
        Label2.TabIndex = 14
        Label2.Text = "Từ ngày"
        ' 
        ' btLamMoi
        ' 
        btLamMoi.Location = New Point(746, 129)
        btLamMoi.Name = "btLamMoi"
        btLamMoi.Size = New Size(94, 29)
        btLamMoi.TabIndex = 19
        btLamMoi.Text = "Làm mới"
        btLamMoi.UseVisualStyleBackColor = True
        ' 
        ' frmDanhSachPhieuXuat
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(870, 450)
        ControlBox = False
        Controls.Add(btLamMoi)
        Controls.Add(btTimKiem)
        Controls.Add(Label3)
        Controls.Add(dtpNgay2)
        Controls.Add(dtpNgay1)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(dgvDanhSachPhieuXuat)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Name = "frmDanhSachPhieuXuat"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Danh Sách Phiếu Xuất"
        CType(dgvDanhSachPhieuXuat, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents dgvDanhSachPhieuXuat As DataGridView
    Friend WithEvents btTimKiem As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents dtpNgay2 As DateTimePicker
    Friend WithEvents dtpNgay1 As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents btLamMoi As Button
End Class
