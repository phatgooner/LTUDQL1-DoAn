<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmXemChiTietSanPham
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
        dgvChiTietSanPham = New DataGridView()
        CType(dgvChiTietSanPham, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.Top
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(163))
        Label1.Location = New Point(283, 75)
        Label1.Margin = New Padding(3)
        Label1.Name = "Label1"
        Label1.Size = New Size(235, 31)
        Label1.TabIndex = 11
        Label1.Text = "CHI TIẾT LOẠI HÀNG"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' dgvChiTietSanPham
        ' 
        dgvChiTietSanPham.AllowUserToOrderColumns = True
        dgvChiTietSanPham.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        dgvChiTietSanPham.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = SystemColors.Control
        DataGridViewCellStyle1.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(163))
        DataGridViewCellStyle1.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        dgvChiTietSanPham.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        dgvChiTietSanPham.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvChiTietSanPham.Location = New Point(12, 140)
        dgvChiTietSanPham.Name = "dgvChiTietSanPham"
        dgvChiTietSanPham.ReadOnly = True
        dgvChiTietSanPham.RowHeadersWidth = 51
        dgvChiTietSanPham.Size = New Size(776, 298)
        dgvChiTietSanPham.TabIndex = 10
        ' 
        ' frmXemChiTietSanPham
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Label1)
        Controls.Add(dgvChiTietSanPham)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Name = "frmXemChiTietSanPham"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Xem Chi Tiết"
        CType(dgvChiTietSanPham, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents dgvChiTietSanPham As DataGridView
End Class
