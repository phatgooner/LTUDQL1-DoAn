﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDanhSachNhanVien
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
        cbHienTatCa = New CheckBox()
        tbTimKiem = New TextBox()
        Label2 = New Label()
        Label1 = New Label()
        dgvDanhSachNhanVien = New DataGridView()
        CType(dgvDanhSachNhanVien, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' cbHienTatCa
        ' 
        cbHienTatCa.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Right
        cbHienTatCa.AutoSize = True
        cbHienTatCa.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(163))
        cbHienTatCa.Location = New Point(670, 131)
        cbHienTatCa.Name = "cbHienTatCa"
        cbHienTatCa.Size = New Size(115, 27)
        cbHienTatCa.TabIndex = 19
        cbHienTatCa.Text = "Hiện tất cả"
        cbHienTatCa.UseVisualStyleBackColor = True
        ' 
        ' tbTimKiem
        ' 
        tbTimKiem.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        tbTimKiem.Location = New Point(97, 131)
        tbTimKiem.Name = "tbTimKiem"
        tbTimKiem.Size = New Size(567, 27)
        tbTimKiem.TabIndex = 18
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(163))
        Label2.Location = New Point(12, 132)
        Label2.Name = "Label2"
        Label2.Size = New Size(79, 23)
        Label2.TabIndex = 17
        Label2.Text = "Tìm kiếm"
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.Top
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(163))
        Label1.Location = New Point(258, 75)
        Label1.Margin = New Padding(3)
        Label1.Name = "Label1"
        Label1.Size = New Size(284, 31)
        Label1.TabIndex = 16
        Label1.Text = "DANH SÁCH NHÂN VIÊN"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' dgvDanhSachNhanVien
        ' 
        dgvDanhSachNhanVien.AllowUserToOrderColumns = True
        dgvDanhSachNhanVien.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        dgvDanhSachNhanVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = SystemColors.Control
        DataGridViewCellStyle1.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(163))
        DataGridViewCellStyle1.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        dgvDanhSachNhanVien.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        dgvDanhSachNhanVien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvDanhSachNhanVien.Location = New Point(12, 171)
        dgvDanhSachNhanVien.Name = "dgvDanhSachNhanVien"
        dgvDanhSachNhanVien.ReadOnly = True
        dgvDanhSachNhanVien.RowHeadersWidth = 51
        dgvDanhSachNhanVien.Size = New Size(776, 267)
        dgvDanhSachNhanVien.TabIndex = 15
        ' 
        ' frmDanhSachNhanVien
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        ControlBox = False
        Controls.Add(cbHienTatCa)
        Controls.Add(tbTimKiem)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(dgvDanhSachNhanVien)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Name = "frmDanhSachNhanVien"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Danh Sách Nhân Viên"
        CType(dgvDanhSachNhanVien, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents cbHienTatCa As CheckBox
    Friend WithEvents tbTimKiem As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents dgvDanhSachNhanVien As DataGridView
End Class
