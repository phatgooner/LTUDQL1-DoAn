<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmThongKeXuatHang
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
        cbbNam = New ComboBox()
        Label4 = New Label()
        Label3 = New Label()
        cbbThang = New ComboBox()
        Label1 = New Label()
        dgvThongKeSoLuong = New DataGridView()
        CType(dgvThongKeSoLuong, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' cbbNam
        ' 
        cbbNam.Anchor = AnchorStyles.Top
        cbbNam.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        cbbNam.AutoCompleteSource = AutoCompleteSource.ListItems
        cbbNam.DropDownStyle = ComboBoxStyle.DropDownList
        cbbNam.FormattingEnabled = True
        cbbNam.Items.AddRange(New Object() {"2018", "2019", "2020", "2021", "2022", "2023", "2024"})
        cbbNam.Location = New Point(465, 128)
        cbbNam.Name = "cbbNam"
        cbbNam.Size = New Size(71, 28)
        cbbNam.TabIndex = 34
        ' 
        ' Label4
        ' 
        Label4.Anchor = AnchorStyles.Top
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(163))
        Label4.Location = New Point(414, 129)
        Label4.Name = "Label4"
        Label4.Size = New Size(51, 23)
        Label4.TabIndex = 33
        Label4.Text = "Năm:"
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.Top
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(163))
        Label3.Location = New Point(265, 129)
        Label3.Name = "Label3"
        Label3.Size = New Size(62, 23)
        Label3.TabIndex = 32
        Label3.Text = "Tháng:"
        ' 
        ' cbbThang
        ' 
        cbbThang.Anchor = AnchorStyles.Top
        cbbThang.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        cbbThang.AutoCompleteSource = AutoCompleteSource.ListItems
        cbbThang.DropDownStyle = ComboBoxStyle.DropDownList
        cbbThang.FormattingEnabled = True
        cbbThang.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12"})
        cbbThang.Location = New Point(327, 128)
        cbbThang.Name = "cbbThang"
        cbbThang.Size = New Size(71, 28)
        cbbThang.TabIndex = 31
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.Top
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(163))
        Label1.Location = New Point(161, 75)
        Label1.Margin = New Padding(3)
        Label1.Name = "Label1"
        Label1.Size = New Size(479, 31)
        Label1.TabIndex = 30
        Label1.Text = "THỐNG KÊ XUẤT KHO THEO KHÁCH HÀNG"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' dgvThongKeSoLuong
        ' 
        dgvThongKeSoLuong.AllowUserToOrderColumns = True
        dgvThongKeSoLuong.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        dgvThongKeSoLuong.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = SystemColors.Control
        DataGridViewCellStyle1.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(163))
        DataGridViewCellStyle1.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        dgvThongKeSoLuong.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        dgvThongKeSoLuong.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvThongKeSoLuong.Location = New Point(12, 171)
        dgvThongKeSoLuong.Name = "dgvThongKeSoLuong"
        dgvThongKeSoLuong.ReadOnly = True
        dgvThongKeSoLuong.RowHeadersWidth = 51
        dgvThongKeSoLuong.Size = New Size(776, 267)
        dgvThongKeSoLuong.TabIndex = 29
        ' 
        ' frmThongKeXuatHang
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        ControlBox = False
        Controls.Add(cbbNam)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(cbbThang)
        Controls.Add(Label1)
        Controls.Add(dgvThongKeSoLuong)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Name = "frmThongKeXuatHang"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Thống Kê Xuất Hàng"
        CType(dgvThongKeSoLuong, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents cbbNam As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents cbbThang As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents dgvThongKeSoLuong As DataGridView
End Class
