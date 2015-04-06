<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmView
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
      Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmView))
      Me.pnlThongtin = New System.Windows.Forms.Panel()
      Me.grbDanhsach = New System.Windows.Forms.GroupBox()
      Me.lsvDanhsachsp = New System.Windows.Forms.ListView()
      Me.lsvcolMasp = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
      Me.lsvcolTensp = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
      Me.lsvcolHangsx = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
      Me.lsvcolGiasp = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
      Me.lsvSoluong = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
      Me.lsvcolHinhanh = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
      Me.lsvcoldvt = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
      Me.grbSanpham = New System.Windows.Forms.GroupBox()
      Me.lblSttResult = New System.Windows.Forms.Label()
      Me.btnLast = New System.Windows.Forms.Button()
      Me.btnFirst = New System.Windows.Forms.Button()
      Me.btnNext = New System.Windows.Forms.Button()
      Me.btnPre = New System.Windows.Forms.Button()
      Me.btnDong = New System.Windows.Forms.Button()
      Me.lblHinhsp = New System.Windows.Forms.Label()
      Me.lblSoluongResult = New System.Windows.Forms.Label()
      Me.lblSoluongcon = New System.Windows.Forms.Label()
      Me.lblGiabanResult = New System.Windows.Forms.Label()
      Me.lblGiaban = New System.Windows.Forms.Label()
      Me.lblHangsxResult = New System.Windows.Forms.Label()
      Me.lblHangsx = New System.Windows.Forms.Label()
      Me.lblTenspResult = New System.Windows.Forms.Label()
      Me.lblTensp = New System.Windows.Forms.Label()
      Me.lblMasp = New System.Windows.Forms.Label()
      Me.ptbHinhsp = New System.Windows.Forms.PictureBox()
      Me.cbbMasp = New System.Windows.Forms.Label()
      Me.pnlThongtin.SuspendLayout()
      Me.grbDanhsach.SuspendLayout()
      Me.grbSanpham.SuspendLayout()
      CType(Me.ptbHinhsp, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.SuspendLayout()
      '
      'pnlThongtin
      '
      Me.pnlThongtin.BackColor = System.Drawing.Color.GhostWhite
      Me.pnlThongtin.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
      Me.pnlThongtin.Controls.Add(Me.grbDanhsach)
      Me.pnlThongtin.Controls.Add(Me.grbSanpham)
      Me.pnlThongtin.Dock = System.Windows.Forms.DockStyle.Fill
      Me.pnlThongtin.Location = New System.Drawing.Point(0, 0)
      Me.pnlThongtin.Name = "pnlThongtin"
      Me.pnlThongtin.Size = New System.Drawing.Size(794, 457)
      Me.pnlThongtin.TabIndex = 0
      '
      'grbDanhsach
      '
      Me.grbDanhsach.BackColor = System.Drawing.Color.PowderBlue
      Me.grbDanhsach.Controls.Add(Me.lsvDanhsachsp)
      Me.grbDanhsach.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.grbDanhsach.Location = New System.Drawing.Point(312, 9)
      Me.grbDanhsach.Name = "grbDanhsach"
      Me.grbDanhsach.Size = New System.Drawing.Size(468, 434)
      Me.grbDanhsach.TabIndex = 1
      Me.grbDanhsach.TabStop = False
      Me.grbDanhsach.Text = "Danh sách sản phẩm:"
      '
      'lsvDanhsachsp
      '
      Me.lsvDanhsachsp.BackColor = System.Drawing.Color.White
      Me.lsvDanhsachsp.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.lsvcolMasp, Me.lsvcolTensp, Me.lsvcolHangsx, Me.lsvcolGiasp, Me.lsvSoluong, Me.lsvcolHinhanh, Me.lsvcoldvt})
      Me.lsvDanhsachsp.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.lsvDanhsachsp.ForeColor = System.Drawing.Color.Black
      Me.lsvDanhsachsp.FullRowSelect = True
      Me.lsvDanhsachsp.GridLines = True
      Me.lsvDanhsachsp.Location = New System.Drawing.Point(6, 24)
      Me.lsvDanhsachsp.MultiSelect = False
      Me.lsvDanhsachsp.Name = "lsvDanhsachsp"
      Me.lsvDanhsachsp.Size = New System.Drawing.Size(456, 404)
      Me.lsvDanhsachsp.TabIndex = 10
      Me.lsvDanhsachsp.UseCompatibleStateImageBehavior = False
      Me.lsvDanhsachsp.View = System.Windows.Forms.View.Details
      '
      'lsvcolMasp
      '
      Me.lsvcolMasp.Text = "Mã SP"
      Me.lsvcolMasp.Width = 50
      '
      'lsvcolTensp
      '
      Me.lsvcolTensp.Text = "Tên sản phẩm"
      Me.lsvcolTensp.Width = 150
      '
      'lsvcolHangsx
      '
      Me.lsvcolHangsx.Text = "Hãng SX"
      Me.lsvcolHangsx.Width = 80
      '
      'lsvcolGiasp
      '
      Me.lsvcolGiasp.Text = "Giá bán"
      Me.lsvcolGiasp.Width = 100
      '
      'lsvSoluong
      '
      Me.lsvSoluong.Text = "Số lượng"
      Me.lsvSoluong.Width = 70
      '
      'lsvcolHinhanh
      '
      Me.lsvcolHinhanh.Text = "Hình ảnh"
      '
      'lsvcoldvt
      '
      Me.lsvcoldvt.Text = "Đvt"
      '
      'grbSanpham
      '
      Me.grbSanpham.BackColor = System.Drawing.Color.PowderBlue
      Me.grbSanpham.Controls.Add(Me.cbbMasp)
      Me.grbSanpham.Controls.Add(Me.lblSttResult)
      Me.grbSanpham.Controls.Add(Me.btnLast)
      Me.grbSanpham.Controls.Add(Me.btnFirst)
      Me.grbSanpham.Controls.Add(Me.btnNext)
      Me.grbSanpham.Controls.Add(Me.btnPre)
      Me.grbSanpham.Controls.Add(Me.btnDong)
      Me.grbSanpham.Controls.Add(Me.lblHinhsp)
      Me.grbSanpham.Controls.Add(Me.lblSoluongResult)
      Me.grbSanpham.Controls.Add(Me.lblSoluongcon)
      Me.grbSanpham.Controls.Add(Me.lblGiabanResult)
      Me.grbSanpham.Controls.Add(Me.lblGiaban)
      Me.grbSanpham.Controls.Add(Me.lblHangsxResult)
      Me.grbSanpham.Controls.Add(Me.lblHangsx)
      Me.grbSanpham.Controls.Add(Me.lblTenspResult)
      Me.grbSanpham.Controls.Add(Me.lblTensp)
      Me.grbSanpham.Controls.Add(Me.lblMasp)
      Me.grbSanpham.Controls.Add(Me.ptbHinhsp)
      Me.grbSanpham.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.grbSanpham.Location = New System.Drawing.Point(5, 9)
      Me.grbSanpham.Name = "grbSanpham"
      Me.grbSanpham.Size = New System.Drawing.Size(301, 434)
      Me.grbSanpham.TabIndex = 4
      Me.grbSanpham.TabStop = False
      Me.grbSanpham.Text = "Sản phẩm"
      '
      'lblSttResult
      '
      Me.lblSttResult.BackColor = System.Drawing.Color.GhostWhite
      Me.lblSttResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
      Me.lblSttResult.Location = New System.Drawing.Point(99, 394)
      Me.lblSttResult.Name = "lblSttResult"
      Me.lblSttResult.Size = New System.Drawing.Size(40, 25)
      Me.lblSttResult.TabIndex = 20
      Me.lblSttResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
      '
      'btnLast
      '
      Me.btnLast.Location = New System.Drawing.Point(186, 394)
      Me.btnLast.Name = "btnLast"
      Me.btnLast.Size = New System.Drawing.Size(35, 27)
      Me.btnLast.TabIndex = 19
      Me.btnLast.Text = ">|"
      Me.btnLast.UseVisualStyleBackColor = True
      '
      'btnFirst
      '
      Me.btnFirst.Location = New System.Drawing.Point(17, 394)
      Me.btnFirst.Name = "btnFirst"
      Me.btnFirst.Size = New System.Drawing.Size(35, 27)
      Me.btnFirst.TabIndex = 18
      Me.btnFirst.Text = "|<"
      Me.btnFirst.UseVisualStyleBackColor = True
      '
      'btnNext
      '
      Me.btnNext.Location = New System.Drawing.Point(145, 394)
      Me.btnNext.Name = "btnNext"
      Me.btnNext.Size = New System.Drawing.Size(35, 27)
      Me.btnNext.TabIndex = 16
      Me.btnNext.Text = ">"
      Me.btnNext.UseVisualStyleBackColor = True
      '
      'btnPre
      '
      Me.btnPre.Location = New System.Drawing.Point(58, 394)
      Me.btnPre.Name = "btnPre"
      Me.btnPre.Size = New System.Drawing.Size(35, 27)
      Me.btnPre.TabIndex = 15
      Me.btnPre.Text = "<"
      Me.btnPre.UseVisualStyleBackColor = True
      '
      'btnDong
      '
      Me.btnDong.Location = New System.Drawing.Point(227, 394)
      Me.btnDong.Name = "btnDong"
      Me.btnDong.Size = New System.Drawing.Size(62, 27)
      Me.btnDong.TabIndex = 13
      Me.btnDong.Text = "Đóng"
      Me.btnDong.UseVisualStyleBackColor = True
      '
      'lblHinhsp
      '
      Me.lblHinhsp.AutoSize = True
      Me.lblHinhsp.Location = New System.Drawing.Point(16, 193)
      Me.lblHinhsp.Name = "lblHinhsp"
      Me.lblHinhsp.Size = New System.Drawing.Size(62, 17)
      Me.lblHinhsp.TabIndex = 12
      Me.lblHinhsp.Text = "Hình ảnh:"
      '
      'lblSoluongResult
      '
      Me.lblSoluongResult.BackColor = System.Drawing.Color.GhostWhite
      Me.lblSoluongResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
      Me.lblSoluongResult.Location = New System.Drawing.Point(111, 157)
      Me.lblSoluongResult.Name = "lblSoluongResult"
      Me.lblSoluongResult.Size = New System.Drawing.Size(178, 25)
      Me.lblSoluongResult.TabIndex = 11
      Me.lblSoluongResult.TextAlign = System.Drawing.ContentAlignment.MiddleRight
      '
      'lblSoluongcon
      '
      Me.lblSoluongcon.AutoSize = True
      Me.lblSoluongcon.Location = New System.Drawing.Point(16, 161)
      Me.lblSoluongcon.Name = "lblSoluongcon"
      Me.lblSoluongcon.Size = New System.Drawing.Size(89, 17)
      Me.lblSoluongcon.TabIndex = 10
      Me.lblSoluongcon.Text = "Số lượng còn:"
      '
      'lblGiabanResult
      '
      Me.lblGiabanResult.BackColor = System.Drawing.Color.GhostWhite
      Me.lblGiabanResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
      Me.lblGiabanResult.Location = New System.Drawing.Point(111, 124)
      Me.lblGiabanResult.Name = "lblGiabanResult"
      Me.lblGiabanResult.Size = New System.Drawing.Size(178, 25)
      Me.lblGiabanResult.TabIndex = 9
      Me.lblGiabanResult.TextAlign = System.Drawing.ContentAlignment.MiddleRight
      '
      'lblGiaban
      '
      Me.lblGiaban.AutoSize = True
      Me.lblGiaban.Location = New System.Drawing.Point(16, 128)
      Me.lblGiaban.Name = "lblGiaban"
      Me.lblGiaban.Size = New System.Drawing.Size(56, 17)
      Me.lblGiaban.TabIndex = 8
      Me.lblGiaban.Text = "Giá bán:"
      '
      'lblHangsxResult
      '
      Me.lblHangsxResult.BackColor = System.Drawing.Color.GhostWhite
      Me.lblHangsxResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
      Me.lblHangsxResult.Location = New System.Drawing.Point(111, 91)
      Me.lblHangsxResult.Name = "lblHangsxResult"
      Me.lblHangsxResult.Size = New System.Drawing.Size(178, 25)
      Me.lblHangsxResult.TabIndex = 7
      Me.lblHangsxResult.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
      '
      'lblHangsx
      '
      Me.lblHangsx.AutoSize = True
      Me.lblHangsx.Location = New System.Drawing.Point(16, 95)
      Me.lblHangsx.Name = "lblHangsx"
      Me.lblHangsx.Size = New System.Drawing.Size(94, 17)
      Me.lblHangsx.TabIndex = 6
      Me.lblHangsx.Text = "Hãng sản xuất:"
      '
      'lblTenspResult
      '
      Me.lblTenspResult.BackColor = System.Drawing.Color.GhostWhite
      Me.lblTenspResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
      Me.lblTenspResult.Location = New System.Drawing.Point(111, 58)
      Me.lblTenspResult.Name = "lblTenspResult"
      Me.lblTenspResult.Size = New System.Drawing.Size(178, 25)
      Me.lblTenspResult.TabIndex = 5
      Me.lblTenspResult.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
      '
      'lblTensp
      '
      Me.lblTensp.AutoSize = True
      Me.lblTensp.Location = New System.Drawing.Point(16, 28)
      Me.lblTensp.Name = "lblTensp"
      Me.lblTensp.Size = New System.Drawing.Size(91, 17)
      Me.lblTensp.TabIndex = 4
      Me.lblTensp.Text = "Mã sản phẩm:"
      '
      'lblMasp
      '
      Me.lblMasp.AutoSize = True
      Me.lblMasp.Location = New System.Drawing.Point(16, 62)
      Me.lblMasp.Name = "lblMasp"
      Me.lblMasp.Size = New System.Drawing.Size(93, 17)
      Me.lblMasp.TabIndex = 1
      Me.lblMasp.Text = "Tên sản phẩm:"
      '
      'ptbHinhsp
      '
      Me.ptbHinhsp.BackColor = System.Drawing.Color.GhostWhite
      Me.ptbHinhsp.Location = New System.Drawing.Point(17, 220)
      Me.ptbHinhsp.Name = "ptbHinhsp"
      Me.ptbHinhsp.Size = New System.Drawing.Size(272, 168)
      Me.ptbHinhsp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
      Me.ptbHinhsp.TabIndex = 3
      Me.ptbHinhsp.TabStop = False
      '
      'cbbMasp
      '
      Me.cbbMasp.BackColor = System.Drawing.Color.GhostWhite
      Me.cbbMasp.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
      Me.cbbMasp.Location = New System.Drawing.Point(111, 24)
      Me.cbbMasp.Name = "cbbMasp"
      Me.cbbMasp.Size = New System.Drawing.Size(178, 25)
      Me.cbbMasp.TabIndex = 21
      Me.cbbMasp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
      '
      'frmView
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.BackColor = System.Drawing.Color.GhostWhite
      Me.ClientSize = New System.Drawing.Size(794, 457)
      Me.Controls.Add(Me.pnlThongtin)
      Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.ForeColor = System.Drawing.Color.Black
      Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
      Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
      Me.MaximizeBox = False
      Me.Name = "frmView"
      Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
      Me.Text = "Thông Tin Sản Phẩm"
      Me.pnlThongtin.ResumeLayout(False)
      Me.grbDanhsach.ResumeLayout(False)
      Me.grbSanpham.ResumeLayout(False)
      Me.grbSanpham.PerformLayout()
      CType(Me.ptbHinhsp, System.ComponentModel.ISupportInitialize).EndInit()
      Me.ResumeLayout(False)

   End Sub
   Friend WithEvents pnlThongtin As System.Windows.Forms.Panel
   Friend WithEvents grbSanpham As System.Windows.Forms.GroupBox
   Friend WithEvents ptbHinhsp As System.Windows.Forms.PictureBox
   Friend WithEvents lblMasp As System.Windows.Forms.Label
   Friend WithEvents lblHinhsp As System.Windows.Forms.Label
   Friend WithEvents lblSoluongResult As System.Windows.Forms.Label
   Friend WithEvents lblSoluongcon As System.Windows.Forms.Label
   Friend WithEvents lblGiabanResult As System.Windows.Forms.Label
   Friend WithEvents lblGiaban As System.Windows.Forms.Label
   Friend WithEvents lblHangsxResult As System.Windows.Forms.Label
   Friend WithEvents lblHangsx As System.Windows.Forms.Label
   Friend WithEvents lblTenspResult As System.Windows.Forms.Label
   Friend WithEvents lblTensp As System.Windows.Forms.Label
   Friend WithEvents grbDanhsach As System.Windows.Forms.GroupBox
   Friend WithEvents btnDong As System.Windows.Forms.Button
   Friend WithEvents btnNext As System.Windows.Forms.Button
   Friend WithEvents btnPre As System.Windows.Forms.Button
   Friend WithEvents lsvDanhsachsp As System.Windows.Forms.ListView
   Friend WithEvents lsvcolMasp As System.Windows.Forms.ColumnHeader
   Friend WithEvents lsvcolTensp As System.Windows.Forms.ColumnHeader
   Friend WithEvents lsvcolHangsx As System.Windows.Forms.ColumnHeader
   Friend WithEvents lsvcolGiasp As System.Windows.Forms.ColumnHeader
   Friend WithEvents lsvSoluong As System.Windows.Forms.ColumnHeader
   Friend WithEvents lsvcolHinhanh As System.Windows.Forms.ColumnHeader
   Friend WithEvents lsvcoldvt As System.Windows.Forms.ColumnHeader
   Friend WithEvents btnLast As System.Windows.Forms.Button
   Friend WithEvents btnFirst As System.Windows.Forms.Button
   Friend WithEvents lblSttResult As System.Windows.Forms.Label
   Friend WithEvents cbbMasp As System.Windows.Forms.Label
End Class
