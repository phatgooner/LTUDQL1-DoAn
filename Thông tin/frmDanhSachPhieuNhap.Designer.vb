<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDanhSachPhieuNhap
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
        Label2 = New Label()
        Label1 = New Label()
        dgvDanhSachPhieuNhap = New DataGridView()
        dtpNgay1 = New DateTimePicker()
        dtpNgay2 = New DateTimePicker()
        Label3 = New Label()
        btTimKiem = New Button()
        btLamMoi = New Button()
        CType(dgvDanhSachPhieuNhap, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(163))
        Label2.Location = New Point(12, 131)
        Label2.Name = "Label2"
        Label2.Size = New Size(71, 23)
        Label2.TabIndex = 7
        Label2.Text = "Từ ngày"
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.Top
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(163))
        Label1.Location = New Point(287, 75)
        Label1.Margin = New Padding(3)
        Label1.Name = "Label1"
        Label1.Size = New Size(296, 31)
        Label1.TabIndex = 6
        Label1.Text = "DANH SÁCH PHIẾU NHẬP"
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
        dgvDanhSachPhieuNhap.Location = New Point(12, 171)
        dgvDanhSachPhieuNhap.Name = "dgvDanhSachPhieuNhap"
        dgvDanhSachPhieuNhap.ReadOnly = True
        dgvDanhSachPhieuNhap.RowHeadersWidth = 51
        dgvDanhSachPhieuNhap.Size = New Size(846, 267)
        dgvDanhSachPhieuNhap.TabIndex = 5
        ' 
        ' dtpNgay1
        ' 
        dtpNgay1.Location = New Point(89, 129)
        dtpNgay1.Name = "dtpNgay1"
        dtpNgay1.Size = New Size(250, 27)
        dtpNgay1.TabIndex = 10
        ' 
        ' dtpNgay2
        ' 
        dtpNgay2.Location = New Point(390, 129)
        dtpNgay2.Name = "dtpNgay2"
        dtpNgay2.Size = New Size(250, 27)
        dtpNgay2.TabIndex = 11
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(163))
        Label3.Location = New Point(345, 131)
        Label3.Name = "Label3"
        Label3.Size = New Size(39, 23)
        Label3.TabIndex = 12
        Label3.Text = "đến"
        ' 
        ' btTimKiem
        ' 
        btTimKiem.Location = New Point(646, 128)
        btTimKiem.Name = "btTimKiem"
        btTimKiem.Size = New Size(94, 29)
        btTimKiem.TabIndex = 13
        btTimKiem.Text = "Tìm kiếm"
        btTimKiem.UseVisualStyleBackColor = True
        ' 
        ' btLamMoi
        ' 
        btLamMoi.Location = New Point(746, 128)
        btLamMoi.Name = "btLamMoi"
        btLamMoi.Size = New Size(94, 29)
        btLamMoi.TabIndex = 14
        btLamMoi.Text = "Làm mới"
        btLamMoi.UseVisualStyleBackColor = True
        ' 
        ' frmDanhSachPhieuNhap
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
        Controls.Add(dgvDanhSachPhieuNhap)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Name = "frmDanhSachPhieuNhap"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Danh Sách Phiếu Nhập"
        CType(dgvDanhSachPhieuNhap, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents dgvDanhSachPhieuNhap As DataGridView
    Friend WithEvents dtpNgay1 As DateTimePicker
    Friend WithEvents dtpNgay2 As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents btTimKiem As Button
    Friend WithEvents btLamMoi As Button
End Class
