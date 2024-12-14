<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmThietLapQuyenTruyCap
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmThietLapQuyenTruyCap))
        Label1 = New Label()
        dgvDanhSachQuyen = New DataGridView()
        Label2 = New Label()
        cbbQuyen = New ComboBox()
        btXoa = New Button()
        btThem = New Button()
        btLuu = New Button()
        Label3 = New Label()
        tbMaVaiTro = New TextBox()
        CType(dgvDanhSachQuyen, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.Top
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(163))
        Label1.Location = New Point(301, 48)
        Label1.Margin = New Padding(3)
        Label1.Name = "Label1"
        Label1.Size = New Size(324, 31)
        Label1.TabIndex = 4
        Label1.Text = "THIẾT LẬP QUYỀN TRUY CẬP"
        Label1.TextAlign = ContentAlignment.MiddleCenter
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
        dgvDanhSachQuyen.Location = New Point(12, 232)
        dgvDanhSachQuyen.Name = "dgvDanhSachQuyen"
        dgvDanhSachQuyen.ReadOnly = True
        dgvDanhSachQuyen.RowHeadersWidth = 51
        dgvDanhSachQuyen.Size = New Size(903, 304)
        dgvDanhSachQuyen.TabIndex = 3
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.Top
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(163))
        Label2.Location = New Point(345, 129)
        Label2.Name = "Label2"
        Label2.Size = New Size(118, 20)
        Label2.TabIndex = 5
        Label2.Text = "Quyền truy cập:"
        ' 
        ' cbbQuyen
        ' 
        cbbQuyen.Anchor = AnchorStyles.Top
        cbbQuyen.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        cbbQuyen.AutoCompleteSource = AutoCompleteSource.ListItems
        cbbQuyen.DropDownStyle = ComboBoxStyle.DropDownList
        cbbQuyen.FormattingEnabled = True
        cbbQuyen.Location = New Point(469, 125)
        cbbQuyen.Name = "cbbQuyen"
        cbbQuyen.Size = New Size(359, 28)
        cbbQuyen.TabIndex = 6
        ' 
        ' btXoa
        ' 
        btXoa.Anchor = AnchorStyles.Top
        btXoa.Enabled = False
        btXoa.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold)
        btXoa.Image = CType(resources.GetObject("btXoa.Image"), Image)
        btXoa.ImageAlign = ContentAlignment.MiddleLeft
        btXoa.Location = New Point(425, 174)
        btXoa.Name = "btXoa"
        btXoa.Size = New Size(92, 42)
        btXoa.TabIndex = 8
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
        btThem.Location = New Point(267, 174)
        btThem.Name = "btThem"
        btThem.Size = New Size(107, 42)
        btThem.TabIndex = 7
        btThem.Text = "Thêm"
        btThem.TextAlign = ContentAlignment.MiddleRight
        btThem.UseVisualStyleBackColor = True
        ' 
        ' btLuu
        ' 
        btLuu.Anchor = AnchorStyles.Top
        btLuu.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold)
        btLuu.Image = CType(resources.GetObject("btLuu.Image"), Image)
        btLuu.ImageAlign = ContentAlignment.MiddleLeft
        btLuu.Location = New Point(568, 174)
        btLuu.Name = "btLuu"
        btLuu.Size = New Size(92, 42)
        btLuu.TabIndex = 9
        btLuu.Text = "Lưu"
        btLuu.TextAlign = ContentAlignment.MiddleRight
        btLuu.UseVisualStyleBackColor = True
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.Top
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(163))
        Label3.Location = New Point(99, 129)
        Label3.Name = "Label3"
        Label3.Size = New Size(83, 20)
        Label3.TabIndex = 10
        Label3.Text = "Mã vai trò:"
        ' 
        ' tbMaVaiTro
        ' 
        tbMaVaiTro.Anchor = AnchorStyles.Top
        tbMaVaiTro.Location = New Point(188, 126)
        tbMaVaiTro.Name = "tbMaVaiTro"
        tbMaVaiTro.ReadOnly = True
        tbMaVaiTro.Size = New Size(91, 27)
        tbMaVaiTro.TabIndex = 11
        ' 
        ' frmThietLapQuyenTruyCap
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(927, 548)
        Controls.Add(tbMaVaiTro)
        Controls.Add(Label3)
        Controls.Add(btLuu)
        Controls.Add(btXoa)
        Controls.Add(btThem)
        Controls.Add(cbbQuyen)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(dgvDanhSachQuyen)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Name = "frmThietLapQuyenTruyCap"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Thiết Lập Quyền Truy Cập"
        CType(dgvDanhSachQuyen, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents dgvDanhSachQuyen As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents cbbQuyen As ComboBox
    Friend WithEvents btXoa As Button
    Friend WithEvents btThem As Button
    Friend WithEvents btLuu As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents tbMaVaiTro As TextBox
End Class
