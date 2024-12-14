<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmXemChiTietQuyenTruyCap
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
        dgvDanhSachQuyen = New DataGridView()
        Label1 = New Label()
        CType(dgvDanhSachQuyen, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' dgvDanhSachQuyen
        ' 
        dgvDanhSachQuyen.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        dgvDanhSachQuyen.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = SystemColors.Control
        DataGridViewCellStyle1.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(163))
        DataGridViewCellStyle1.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        dgvDanhSachQuyen.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        dgvDanhSachQuyen.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvDanhSachQuyen.Location = New Point(12, 124)
        dgvDanhSachQuyen.Name = "dgvDanhSachQuyen"
        dgvDanhSachQuyen.ReadOnly = True
        dgvDanhSachQuyen.RowHeadersWidth = 51
        dgvDanhSachQuyen.Size = New Size(608, 412)
        dgvDanhSachQuyen.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.Top
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(163))
        Label1.Location = New Point(142, 48)
        Label1.Margin = New Padding(3)
        Label1.Name = "Label1"
        Label1.Size = New Size(349, 31)
        Label1.TabIndex = 2
        Label1.Text = "DANH SÁCH QUYỀN TRUY CẬP"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' frmXemChiTietQuyenTruyCap
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(632, 548)
        Controls.Add(Label1)
        Controls.Add(dgvDanhSachQuyen)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Name = "frmXemChiTietQuyenTruyCap"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Chi Tiết Quyền Truy Cập"
        CType(dgvDanhSachQuyen, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents dgvDanhSachQuyen As DataGridView
    Friend WithEvents Label1 As Label
End Class
