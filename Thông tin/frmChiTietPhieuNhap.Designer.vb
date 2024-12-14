<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmChiTietPhieuNhap
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
        dgvChiTietPhieuNhap = New DataGridView()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        lbMa = New Label()
        lbTen = New Label()
        lbNgay = New Label()
        lbTongSoTien = New Label()
        Label6 = New Label()
        lbNguoiLapPhieu = New Label()
        CType(dgvChiTietPhieuNhap, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' dgvChiTietPhieuNhap
        ' 
        dgvChiTietPhieuNhap.AllowUserToOrderColumns = True
        dgvChiTietPhieuNhap.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        dgvChiTietPhieuNhap.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = SystemColors.Control
        DataGridViewCellStyle1.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(163))
        DataGridViewCellStyle1.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        dgvChiTietPhieuNhap.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        dgvChiTietPhieuNhap.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvChiTietPhieuNhap.Location = New Point(12, 187)
        dgvChiTietPhieuNhap.Name = "dgvChiTietPhieuNhap"
        dgvChiTietPhieuNhap.ReadOnly = True
        dgvChiTietPhieuNhap.RowHeadersWidth = 51
        dgvChiTietPhieuNhap.Size = New Size(776, 130)
        dgvChiTietPhieuNhap.TabIndex = 6
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.Top
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(163))
        Label1.Location = New Point(275, 25)
        Label1.Margin = New Padding(3)
        Label1.Name = "Label1"
        Label1.Size = New Size(250, 31)
        Label1.TabIndex = 12
        Label1.Text = "CHI TIẾT PHIẾU NHẬP"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label2.Location = New Point(12, 80)
        Label2.Name = "Label2"
        Label2.Size = New Size(117, 20)
        Label2.TabIndex = 13
        Label2.Text = "Mã phiếu nhập:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label3.Location = New Point(12, 117)
        Label3.Name = "Label3"
        Label3.Size = New Size(134, 20)
        Label3.TabIndex = 14
        Label3.Text = "Tên nhà cung cấp:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label4.Location = New Point(12, 152)
        Label4.Name = "Label4"
        Label4.Size = New Size(120, 20)
        Label4.TabIndex = 15
        Label4.Text = "Ngày tạo phiếu:"
        ' 
        ' lbMa
        ' 
        lbMa.AutoSize = True
        lbMa.Location = New Point(152, 80)
        lbMa.Name = "lbMa"
        lbMa.Size = New Size(30, 20)
        lbMa.TabIndex = 16
        lbMa.Text = "Mã"
        ' 
        ' lbTen
        ' 
        lbTen.AutoSize = True
        lbTen.Location = New Point(152, 117)
        lbTen.Name = "lbTen"
        lbTen.Size = New Size(32, 20)
        lbTen.TabIndex = 17
        lbTen.Text = "Tên"
        ' 
        ' lbNgay
        ' 
        lbNgay.AutoSize = True
        lbNgay.Location = New Point(152, 152)
        lbNgay.Name = "lbNgay"
        lbNgay.Size = New Size(44, 20)
        lbNgay.TabIndex = 18
        lbNgay.Text = "Ngày"
        ' 
        ' lbTongSoTien
        ' 
        lbTongSoTien.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        lbTongSoTien.AutoSize = True
        lbTongSoTien.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(163))
        lbTongSoTien.Location = New Point(685, 330)
        lbTongSoTien.Name = "lbTongSoTien"
        lbTongSoTien.Size = New Size(103, 20)
        lbTongSoTien.TabIndex = 20
        lbTongSoTien.Text = "TỔNG CỘNG:"
        lbTongSoTien.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label6
        ' 
        Label6.Anchor = AnchorStyles.Bottom
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(163))
        Label6.Location = New Point(340, 350)
        Label6.Name = "Label6"
        Label6.Size = New Size(121, 20)
        Label6.TabIndex = 21
        Label6.Text = "Người lập phiếu"
        ' 
        ' lbNguoiLapPhieu
        ' 
        lbNguoiLapPhieu.Anchor = AnchorStyles.Bottom
        lbNguoiLapPhieu.AutoSize = True
        lbNguoiLapPhieu.Location = New Point(338, 421)
        lbNguoiLapPhieu.Name = "lbNguoiLapPhieu"
        lbNguoiLapPhieu.Size = New Size(117, 20)
        lbNguoiLapPhieu.TabIndex = 22
        lbNguoiLapPhieu.Text = "Người lập phiếu"
        ' 
        ' frmChiTietPhieuNhap
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(lbNguoiLapPhieu)
        Controls.Add(Label6)
        Controls.Add(lbTongSoTien)
        Controls.Add(lbNgay)
        Controls.Add(lbTen)
        Controls.Add(lbMa)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(dgvChiTietPhieuNhap)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Name = "frmChiTietPhieuNhap"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Chi Tiết Phiếu Nhập"
        CType(dgvChiTietPhieuNhap, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents dgvChiTietPhieuNhap As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lbMa As Label
    Friend WithEvents lbTen As Label
    Friend WithEvents lbNgay As Label
    Friend WithEvents lbTongSoTien As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents lbNguoiLapPhieu As Label
End Class
