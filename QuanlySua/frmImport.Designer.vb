<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmImport
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
      Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmImport))
      Me.lblMasp = New System.Windows.Forms.Label()
      Me.lblSoluong = New System.Windows.Forms.Label()
      Me.lblGiaban = New System.Windows.Forms.Label()
      Me.lblNgaynhap = New System.Windows.Forms.Label()
      Me.lblGhichu = New System.Windows.Forms.Label()
      Me.grbNhaphang = New System.Windows.Forms.GroupBox()
      Me.txtNhacungcap = New System.Windows.Forms.TextBox()
      Me.btnThoat = New System.Windows.Forms.Button()
      Me.btnThem = New System.Windows.Forms.Button()
      Me.txtGhichu = New System.Windows.Forms.TextBox()
      Me.dtpNgaynhap = New System.Windows.Forms.DateTimePicker()
      Me.txtGiaban = New System.Windows.Forms.TextBox()
      Me.cbbDvt = New System.Windows.Forms.ComboBox()
      Me.lblDvt = New System.Windows.Forms.Label()
      Me.txtSoluong = New System.Windows.Forms.TextBox()
      Me.lblTensp = New System.Windows.Forms.Label()
      Me.cbbMasp = New System.Windows.Forms.ComboBox()
      Me.lblNhacungcap = New System.Windows.Forms.Label()
      Me.grbThongtinsp = New System.Windows.Forms.GroupBox()
      Me.lblXuatxuResult = New System.Windows.Forms.Label()
      Me.lblLoaispResult = New System.Windows.Forms.Label()
      Me.lblTenspResult = New System.Windows.Forms.Label()
      Me.lblHangsxResult = New System.Windows.Forms.Label()
      Me.lblHinhanh = New System.Windows.Forms.Label()
      Me.ptbHinhanh = New System.Windows.Forms.PictureBox()
      Me.lblXuatxu = New System.Windows.Forms.Label()
      Me.lblLoaisp = New System.Windows.Forms.Label()
      Me.lblHangsx = New System.Windows.Forms.Label()
      Me.grbNhaphang.SuspendLayout()
      Me.grbThongtinsp.SuspendLayout()
      CType(Me.ptbHinhanh, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.SuspendLayout()
      '
      'lblMasp
      '
      Me.lblMasp.AutoSize = True
      Me.lblMasp.Location = New System.Drawing.Point(6, 31)
      Me.lblMasp.Name = "lblMasp"
      Me.lblMasp.Size = New System.Drawing.Size(93, 17)
      Me.lblMasp.TabIndex = 0
      Me.lblMasp.Text = "Tên sản phẩm:"
      '
      'lblSoluong
      '
      Me.lblSoluong.AutoSize = True
      Me.lblSoluong.Location = New System.Drawing.Point(6, 62)
      Me.lblSoluong.Name = "lblSoluong"
      Me.lblSoluong.Size = New System.Drawing.Size(73, 17)
      Me.lblSoluong.TabIndex = 2
      Me.lblSoluong.Text = "Số lượng: *"
      '
      'lblGiaban
      '
      Me.lblGiaban.AutoSize = True
      Me.lblGiaban.Location = New System.Drawing.Point(6, 124)
      Me.lblGiaban.Name = "lblGiaban"
      Me.lblGiaban.Size = New System.Drawing.Size(96, 17)
      Me.lblGiaban.TabIndex = 3
      Me.lblGiaban.Text = "Giá bán(Vnđ): *"
      '
      'lblNgaynhap
      '
      Me.lblNgaynhap.AutoSize = True
      Me.lblNgaynhap.Location = New System.Drawing.Point(6, 158)
      Me.lblNgaynhap.Name = "lblNgaynhap"
      Me.lblNgaynhap.Size = New System.Drawing.Size(84, 17)
      Me.lblNgaynhap.TabIndex = 4
      Me.lblNgaynhap.Text = "Ngày nhập: *"
      '
      'lblGhichu
      '
      Me.lblGhichu.AutoSize = True
      Me.lblGhichu.Location = New System.Drawing.Point(6, 217)
      Me.lblGhichu.Name = "lblGhichu"
      Me.lblGhichu.Size = New System.Drawing.Size(54, 17)
      Me.lblGhichu.TabIndex = 6
      Me.lblGhichu.Text = "Ghi chú:"
      '
      'grbNhaphang
      '
      Me.grbNhaphang.BackColor = System.Drawing.Color.PowderBlue
      Me.grbNhaphang.Controls.Add(Me.txtNhacungcap)
      Me.grbNhaphang.Controls.Add(Me.btnThoat)
      Me.grbNhaphang.Controls.Add(Me.btnThem)
      Me.grbNhaphang.Controls.Add(Me.txtGhichu)
      Me.grbNhaphang.Controls.Add(Me.dtpNgaynhap)
      Me.grbNhaphang.Controls.Add(Me.txtGiaban)
      Me.grbNhaphang.Controls.Add(Me.cbbDvt)
      Me.grbNhaphang.Controls.Add(Me.lblDvt)
      Me.grbNhaphang.Controls.Add(Me.txtSoluong)
      Me.grbNhaphang.Controls.Add(Me.lblTensp)
      Me.grbNhaphang.Controls.Add(Me.lblGhichu)
      Me.grbNhaphang.Controls.Add(Me.cbbMasp)
      Me.grbNhaphang.Controls.Add(Me.lblNhacungcap)
      Me.grbNhaphang.Controls.Add(Me.lblSoluong)
      Me.grbNhaphang.Controls.Add(Me.lblNgaynhap)
      Me.grbNhaphang.Controls.Add(Me.lblGiaban)
      Me.grbNhaphang.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.grbNhaphang.Location = New System.Drawing.Point(12, 12)
      Me.grbNhaphang.Name = "grbNhaphang"
      Me.grbNhaphang.Size = New System.Drawing.Size(264, 357)
      Me.grbNhaphang.TabIndex = 7
      Me.grbNhaphang.TabStop = False
      Me.grbNhaphang.Text = "Thông tin nhập"
      '
      'txtNhacungcap
      '
      Me.txtNhacungcap.BackColor = System.Drawing.Color.GhostWhite
      Me.txtNhacungcap.Location = New System.Drawing.Point(111, 183)
      Me.txtNhacungcap.Name = "txtNhacungcap"
      Me.txtNhacungcap.Size = New System.Drawing.Size(142, 25)
      Me.txtNhacungcap.TabIndex = 16
      '
      'btnThoat
      '
      Me.btnThoat.Location = New System.Drawing.Point(168, 303)
      Me.btnThoat.Name = "btnThoat"
      Me.btnThoat.Size = New System.Drawing.Size(85, 40)
      Me.btnThoat.TabIndex = 15
      Me.btnThoat.Text = "Thoát"
      Me.btnThoat.UseVisualStyleBackColor = True
      '
      'btnThem
      '
      Me.btnThem.Location = New System.Drawing.Point(64, 303)
      Me.btnThem.Name = "btnThem"
      Me.btnThem.Size = New System.Drawing.Size(85, 40)
      Me.btnThem.TabIndex = 14
      Me.btnThem.Text = "Thêm"
      Me.btnThem.UseVisualStyleBackColor = True
      '
      'txtGhichu
      '
      Me.txtGhichu.BackColor = System.Drawing.Color.GhostWhite
      Me.txtGhichu.Location = New System.Drawing.Point(66, 214)
      Me.txtGhichu.Multiline = True
      Me.txtGhichu.Name = "txtGhichu"
      Me.txtGhichu.Size = New System.Drawing.Size(187, 79)
      Me.txtGhichu.TabIndex = 13
      '
      'dtpNgaynhap
      '
      Me.dtpNgaynhap.CalendarMonthBackground = System.Drawing.Color.GhostWhite
      Me.dtpNgaynhap.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
      Me.dtpNgaynhap.Location = New System.Drawing.Point(111, 152)
      Me.dtpNgaynhap.MaxDate = New Date(3000, 12, 31, 0, 0, 0, 0)
      Me.dtpNgaynhap.MinDate = New Date(2000, 1, 1, 0, 0, 0, 0)
      Me.dtpNgaynhap.Name = "dtpNgaynhap"
      Me.dtpNgaynhap.Size = New System.Drawing.Size(142, 25)
      Me.dtpNgaynhap.TabIndex = 11
      Me.dtpNgaynhap.Value = New Date(2013, 6, 8, 0, 0, 0, 0)
      '
      'txtGiaban
      '
      Me.txtGiaban.BackColor = System.Drawing.Color.GhostWhite
      Me.txtGiaban.Location = New System.Drawing.Point(111, 121)
      Me.txtGiaban.Name = "txtGiaban"
      Me.txtGiaban.Size = New System.Drawing.Size(142, 25)
      Me.txtGiaban.TabIndex = 10
      '
      'cbbDvt
      '
      Me.cbbDvt.BackColor = System.Drawing.Color.GhostWhite
      Me.cbbDvt.FormattingEnabled = True
      Me.cbbDvt.Items.AddRange(New Object() {"Thùng", "Hộp", "Bịch"})
      Me.cbbDvt.Location = New System.Drawing.Point(111, 90)
      Me.cbbDvt.Name = "cbbDvt"
      Me.cbbDvt.Size = New System.Drawing.Size(142, 25)
      Me.cbbDvt.TabIndex = 9
      '
      'lblDvt
      '
      Me.lblDvt.AutoSize = True
      Me.lblDvt.Location = New System.Drawing.Point(6, 93)
      Me.lblDvt.Name = "lblDvt"
      Me.lblDvt.Size = New System.Drawing.Size(82, 17)
      Me.lblDvt.TabIndex = 8
      Me.lblDvt.Text = "Đơn vị tính: *"
      '
      'txtSoluong
      '
      Me.txtSoluong.BackColor = System.Drawing.Color.GhostWhite
      Me.txtSoluong.Location = New System.Drawing.Point(111, 59)
      Me.txtSoluong.Name = "txtSoluong"
      Me.txtSoluong.Size = New System.Drawing.Size(142, 25)
      Me.txtSoluong.TabIndex = 7
      '
      'lblTensp
      '
      Me.lblTensp.AutoSize = True
      Me.lblTensp.Location = New System.Drawing.Point(6, 31)
      Me.lblTensp.Name = "lblTensp"
      Me.lblTensp.Size = New System.Drawing.Size(91, 17)
      Me.lblTensp.TabIndex = 0
      Me.lblTensp.Text = "Mã sản phẩm:"
      '
      'cbbMasp
      '
      Me.cbbMasp.BackColor = System.Drawing.Color.GhostWhite
      Me.cbbMasp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
      Me.cbbMasp.FormattingEnabled = True
      Me.cbbMasp.Location = New System.Drawing.Point(111, 28)
      Me.cbbMasp.MaxDropDownItems = 10
      Me.cbbMasp.Name = "cbbMasp"
      Me.cbbMasp.Size = New System.Drawing.Size(142, 25)
      Me.cbbMasp.TabIndex = 1
      '
      'lblNhacungcap
      '
      Me.lblNhacungcap.AutoSize = True
      Me.lblNhacungcap.Location = New System.Drawing.Point(6, 186)
      Me.lblNhacungcap.Name = "lblNhacungcap"
      Me.lblNhacungcap.Size = New System.Drawing.Size(101, 17)
      Me.lblNhacungcap.TabIndex = 5
      Me.lblNhacungcap.Text = "Nhà cung cấp: *"
      '
      'grbThongtinsp
      '
      Me.grbThongtinsp.BackColor = System.Drawing.Color.PowderBlue
      Me.grbThongtinsp.Controls.Add(Me.lblXuatxuResult)
      Me.grbThongtinsp.Controls.Add(Me.lblLoaispResult)
      Me.grbThongtinsp.Controls.Add(Me.lblTenspResult)
      Me.grbThongtinsp.Controls.Add(Me.lblHangsxResult)
      Me.grbThongtinsp.Controls.Add(Me.lblHinhanh)
      Me.grbThongtinsp.Controls.Add(Me.ptbHinhanh)
      Me.grbThongtinsp.Controls.Add(Me.lblXuatxu)
      Me.grbThongtinsp.Controls.Add(Me.lblLoaisp)
      Me.grbThongtinsp.Controls.Add(Me.lblHangsx)
      Me.grbThongtinsp.Controls.Add(Me.lblMasp)
      Me.grbThongtinsp.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.grbThongtinsp.Location = New System.Drawing.Point(282, 12)
      Me.grbThongtinsp.Name = "grbThongtinsp"
      Me.grbThongtinsp.Size = New System.Drawing.Size(296, 357)
      Me.grbThongtinsp.TabIndex = 8
      Me.grbThongtinsp.TabStop = False
      Me.grbThongtinsp.Text = "Thông tin sản phẩm"
      '
      'lblXuatxuResult
      '
      Me.lblXuatxuResult.BackColor = System.Drawing.Color.GhostWhite
      Me.lblXuatxuResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
      Me.lblXuatxuResult.Location = New System.Drawing.Point(116, 120)
      Me.lblXuatxuResult.Name = "lblXuatxuResult"
      Me.lblXuatxuResult.Size = New System.Drawing.Size(163, 25)
      Me.lblXuatxuResult.TabIndex = 17
      Me.lblXuatxuResult.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
      '
      'lblLoaispResult
      '
      Me.lblLoaispResult.BackColor = System.Drawing.Color.GhostWhite
      Me.lblLoaispResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
      Me.lblLoaispResult.Location = New System.Drawing.Point(116, 89)
      Me.lblLoaispResult.Name = "lblLoaispResult"
      Me.lblLoaispResult.Size = New System.Drawing.Size(163, 25)
      Me.lblLoaispResult.TabIndex = 16
      Me.lblLoaispResult.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
      '
      'lblTenspResult
      '
      Me.lblTenspResult.BackColor = System.Drawing.Color.GhostWhite
      Me.lblTenspResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
      Me.lblTenspResult.Location = New System.Drawing.Point(116, 27)
      Me.lblTenspResult.Name = "lblTenspResult"
      Me.lblTenspResult.Size = New System.Drawing.Size(163, 25)
      Me.lblTenspResult.TabIndex = 15
      Me.lblTenspResult.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
      '
      'lblHangsxResult
      '
      Me.lblHangsxResult.BackColor = System.Drawing.Color.GhostWhite
      Me.lblHangsxResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
      Me.lblHangsxResult.Location = New System.Drawing.Point(116, 58)
      Me.lblHangsxResult.Name = "lblHangsxResult"
      Me.lblHangsxResult.Size = New System.Drawing.Size(163, 25)
      Me.lblHangsxResult.TabIndex = 14
      Me.lblHangsxResult.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
      '
      'lblHinhanh
      '
      Me.lblHinhanh.AutoSize = True
      Me.lblHinhanh.Location = New System.Drawing.Point(6, 158)
      Me.lblHinhanh.Name = "lblHinhanh"
      Me.lblHinhanh.Size = New System.Drawing.Size(66, 17)
      Me.lblHinhanh.TabIndex = 9
      Me.lblHinhanh.Text = "Hình ảnh: "
      '
      'ptbHinhanh
      '
      Me.ptbHinhanh.BackColor = System.Drawing.Color.GhostWhite
      Me.ptbHinhanh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
      Me.ptbHinhanh.Location = New System.Drawing.Point(18, 178)
      Me.ptbHinhanh.Name = "ptbHinhanh"
      Me.ptbHinhanh.Size = New System.Drawing.Size(260, 171)
      Me.ptbHinhanh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
      Me.ptbHinhanh.TabIndex = 8
      Me.ptbHinhanh.TabStop = False
      '
      'lblXuatxu
      '
      Me.lblXuatxu.AutoSize = True
      Me.lblXuatxu.Location = New System.Drawing.Point(6, 124)
      Me.lblXuatxu.Name = "lblXuatxu"
      Me.lblXuatxu.Size = New System.Drawing.Size(55, 17)
      Me.lblXuatxu.TabIndex = 6
      Me.lblXuatxu.Text = "Xuất xứ:"
      '
      'lblLoaisp
      '
      Me.lblLoaisp.AutoSize = True
      Me.lblLoaisp.Location = New System.Drawing.Point(6, 93)
      Me.lblLoaisp.Name = "lblLoaisp"
      Me.lblLoaisp.Size = New System.Drawing.Size(96, 17)
      Me.lblLoaisp.TabIndex = 4
      Me.lblLoaisp.Text = "Loại sản phẩm:"
      '
      'lblHangsx
      '
      Me.lblHangsx.AutoSize = True
      Me.lblHangsx.Location = New System.Drawing.Point(6, 63)
      Me.lblHangsx.Name = "lblHangsx"
      Me.lblHangsx.Size = New System.Drawing.Size(94, 17)
      Me.lblHangsx.TabIndex = 2
      Me.lblHangsx.Text = "Hãng sản xuất:"
      '
      'frmImport
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.BackColor = System.Drawing.Color.GhostWhite
      Me.ClientSize = New System.Drawing.Size(589, 379)
      Me.Controls.Add(Me.grbThongtinsp)
      Me.Controls.Add(Me.grbNhaphang)
      Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
      Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
      Me.MaximizeBox = False
      Me.Name = "frmImport"
      Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
      Me.Text = "Nhập Hàng"
      Me.grbNhaphang.ResumeLayout(False)
      Me.grbNhaphang.PerformLayout()
      Me.grbThongtinsp.ResumeLayout(False)
      Me.grbThongtinsp.PerformLayout()
      CType(Me.ptbHinhanh, System.ComponentModel.ISupportInitialize).EndInit()
      Me.ResumeLayout(False)

   End Sub
   Friend WithEvents lblMasp As System.Windows.Forms.Label
   Friend WithEvents lblSoluong As System.Windows.Forms.Label
   Friend WithEvents lblGiaban As System.Windows.Forms.Label
   Friend WithEvents lblNgaynhap As System.Windows.Forms.Label
   Friend WithEvents lblGhichu As System.Windows.Forms.Label
   Friend WithEvents grbNhaphang As System.Windows.Forms.GroupBox
   Friend WithEvents grbThongtinsp As System.Windows.Forms.GroupBox
   Friend WithEvents lblDvt As System.Windows.Forms.Label
   Friend WithEvents txtSoluong As System.Windows.Forms.TextBox
   Friend WithEvents cbbDvt As System.Windows.Forms.ComboBox
   Friend WithEvents txtGhichu As System.Windows.Forms.TextBox
   Friend WithEvents dtpNgaynhap As System.Windows.Forms.DateTimePicker
   Friend WithEvents txtGiaban As System.Windows.Forms.TextBox
   Friend WithEvents btnThoat As System.Windows.Forms.Button
   Friend WithEvents btnThem As System.Windows.Forms.Button
   Friend WithEvents lblTensp As System.Windows.Forms.Label
   Friend WithEvents lblHangsx As System.Windows.Forms.Label
   Friend WithEvents lblXuatxu As System.Windows.Forms.Label
   Friend WithEvents lblLoaisp As System.Windows.Forms.Label
   Friend WithEvents ptbHinhanh As System.Windows.Forms.PictureBox
   Friend WithEvents lblHinhanh As System.Windows.Forms.Label
   Friend WithEvents lblNhacungcap As System.Windows.Forms.Label
   Friend WithEvents txtNhacungcap As System.Windows.Forms.TextBox
   Friend WithEvents cbbMasp As System.Windows.Forms.ComboBox
   Friend WithEvents lblXuatxuResult As System.Windows.Forms.Label
   Friend WithEvents lblLoaispResult As System.Windows.Forms.Label
   Friend WithEvents lblTenspResult As System.Windows.Forms.Label
   Friend WithEvents lblHangsxResult As System.Windows.Forms.Label
End Class
