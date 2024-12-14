<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDangNhap
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDangNhap))
        btThoat = New Button()
        btDangNhap = New Button()
        Label3 = New Label()
        Label4 = New Label()
        tbMatKhau = New TextBox()
        tbTen = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        SuspendLayout()
        ' 
        ' btThoat
        ' 
        btThoat.Location = New Point(427, 312)
        btThoat.Name = "btThoat"
        btThoat.Size = New Size(94, 29)
        btThoat.TabIndex = 20
        btThoat.Text = "Thoát"
        btThoat.UseVisualStyleBackColor = True
        ' 
        ' btDangNhap
        ' 
        btDangNhap.Location = New Point(269, 312)
        btDangNhap.Name = "btDangNhap"
        btDangNhap.Size = New Size(94, 29)
        btDangNhap.TabIndex = 3
        btDangNhap.Text = "Đăng Nhập"
        btDangNhap.UseVisualStyleBackColor = True
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        Label3.Location = New Point(251, 254)
        Label3.Name = "Label3"
        Label3.Size = New Size(75, 20)
        Label3.TabIndex = 18
        Label3.Text = "Mật Khẩu"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        Label4.Location = New Point(251, 196)
        Label4.Name = "Label4"
        Label4.Size = New Size(116, 20)
        Label4.TabIndex = 17
        Label4.Text = "Tên Đăng Nhập"
        ' 
        ' tbMatKhau
        ' 
        tbMatKhau.Location = New Point(394, 251)
        tbMatKhau.Name = "tbMatKhau"
        tbMatKhau.Size = New Size(156, 27)
        tbMatKhau.TabIndex = 2
        tbMatKhau.UseSystemPasswordChar = True
        ' 
        ' tbTen
        ' 
        tbTen.Location = New Point(394, 193)
        tbTen.Name = "tbTen"
        tbTen.Size = New Size(156, 27)
        tbTen.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, CByte(163))
        Label1.Location = New Point(25, 45)
        Label1.Name = "Label1"
        Label1.Size = New Size(751, 35)
        Label1.TabIndex = 21
        Label1.Text = "CHÀO MỪNG BẠN ĐẾN VỚI ỨNG DỤNG QUẢN LÝ KHO HÀNG"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(163))
        Label2.Location = New Point(229, 128)
        Label2.Name = "Label2"
        Label2.Size = New Size(343, 28)
        Label2.TabIndex = 22
        Label2.Text = "Vui lòng đăng nhập tài khoản của bạn"
        ' 
        ' frmDangNhap
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.PapayaWhip
        ClientSize = New Size(800, 450)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(btThoat)
        Controls.Add(btDangNhap)
        Controls.Add(Label3)
        Controls.Add(Label4)
        Controls.Add(tbMatKhau)
        Controls.Add(tbTen)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximizeBox = False
        Name = "frmDangNhap"
        StartPosition = FormStartPosition.CenterScreen
        Text = "ĐĂNG NHẬP TÀI KHOẢN"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btThoat As Button
    Friend WithEvents btDangNhap As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents tbMatKhau As TextBox
    Friend WithEvents tbTen As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
