<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAdd
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
      Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAdd))
      Me.btnSave = New System.Windows.Forms.Button()
      Me.btnExit = New System.Windows.Forms.Button()
      Me.ofdPicture = New System.Windows.Forms.OpenFileDialog()
      Me.grbThongtinsp = New System.Windows.Forms.GroupBox()
      Me.btnDelete = New System.Windows.Forms.Button()
      Me.btnEdit = New System.Windows.Forms.Button()
      Me.lsvthemsp = New System.Windows.Forms.ListView()
      Me.lsvcolMasp = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
      Me.lsvcolTensp = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
      Me.lsvcolHangsx = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
      Me.lsvcolLoaisp = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
      Me.lsvcolXuatxu = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
      Me.lsvcoltenfile = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
      Me.txtXuatx = New System.Windows.Forms.TextBox()
      Me.txtLoaisp = New System.Windows.Forms.TextBox()
      Me.txtHangsx = New System.Windows.Forms.TextBox()
      Me.txtTensp = New System.Windows.Forms.TextBox()
      Me.txtMasp = New System.Windows.Forms.TextBox()
      Me.lblmasp = New System.Windows.Forms.Label()
      Me.lblThongtin = New System.Windows.Forms.Label()
      Me.lblXuatxu = New System.Windows.Forms.Label()
      Me.lblLoaisp = New System.Windows.Forms.Label()
      Me.lblHangsx = New System.Windows.Forms.Label()
      Me.lblTensp = New System.Windows.Forms.Label()
      Me.ptbHinhanh = New System.Windows.Forms.PictureBox()
      Me.grbThongtinsp.SuspendLayout()
      CType(Me.ptbHinhanh, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.SuspendLayout()
      '
      'btnSave
      '
      Me.btnSave.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.btnSave.Location = New System.Drawing.Point(93, 384)
      Me.btnSave.Name = "btnSave"
      Me.btnSave.Size = New System.Drawing.Size(75, 30)
      Me.btnSave.TabIndex = 7
      Me.btnSave.Text = "Thêm"
      Me.btnSave.UseVisualStyleBackColor = True
      '
      'btnExit
      '
      Me.btnExit.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.btnExit.Location = New System.Drawing.Point(336, 384)
      Me.btnExit.Name = "btnExit"
      Me.btnExit.Size = New System.Drawing.Size(75, 30)
      Me.btnExit.TabIndex = 9
      Me.btnExit.Text = "Thoát"
      Me.btnExit.UseVisualStyleBackColor = True
      '
      'ofdPicture
      '
      Me.ofdPicture.FileName = "OpenFileDialog1"
      '
      'grbThongtinsp
      '
      Me.grbThongtinsp.BackColor = System.Drawing.Color.PowderBlue
      Me.grbThongtinsp.Controls.Add(Me.btnDelete)
      Me.grbThongtinsp.Controls.Add(Me.btnEdit)
      Me.grbThongtinsp.Controls.Add(Me.lsvthemsp)
      Me.grbThongtinsp.Controls.Add(Me.txtXuatx)
      Me.grbThongtinsp.Controls.Add(Me.txtLoaisp)
      Me.grbThongtinsp.Controls.Add(Me.btnExit)
      Me.grbThongtinsp.Controls.Add(Me.btnSave)
      Me.grbThongtinsp.Controls.Add(Me.txtHangsx)
      Me.grbThongtinsp.Controls.Add(Me.txtTensp)
      Me.grbThongtinsp.Controls.Add(Me.txtMasp)
      Me.grbThongtinsp.Controls.Add(Me.lblmasp)
      Me.grbThongtinsp.Controls.Add(Me.lblThongtin)
      Me.grbThongtinsp.Controls.Add(Me.ptbHinhanh)
      Me.grbThongtinsp.Controls.Add(Me.lblXuatxu)
      Me.grbThongtinsp.Controls.Add(Me.lblLoaisp)
      Me.grbThongtinsp.Controls.Add(Me.lblHangsx)
      Me.grbThongtinsp.Controls.Add(Me.lblTensp)
      Me.grbThongtinsp.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.grbThongtinsp.Location = New System.Drawing.Point(8, 7)
      Me.grbThongtinsp.Name = "grbThongtinsp"
      Me.grbThongtinsp.Size = New System.Drawing.Size(504, 420)
      Me.grbThongtinsp.TabIndex = 9
      Me.grbThongtinsp.TabStop = False
      Me.grbThongtinsp.Text = "Thông tin sản phẩm"
      '
      'btnDelete
      '
      Me.btnDelete.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.btnDelete.Location = New System.Drawing.Point(255, 384)
      Me.btnDelete.Name = "btnDelete"
      Me.btnDelete.Size = New System.Drawing.Size(75, 30)
      Me.btnDelete.TabIndex = 13
      Me.btnDelete.Text = "Xóa"
      Me.btnDelete.UseVisualStyleBackColor = True
      '
      'btnEdit
      '
      Me.btnEdit.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.btnEdit.Location = New System.Drawing.Point(174, 384)
      Me.btnEdit.Name = "btnEdit"
      Me.btnEdit.Size = New System.Drawing.Size(75, 30)
      Me.btnEdit.TabIndex = 12
      Me.btnEdit.Text = "Sửa"
      Me.btnEdit.UseVisualStyleBackColor = True
      '
      'lsvthemsp
      '
      Me.lsvthemsp.BackColor = System.Drawing.Color.White
      Me.lsvthemsp.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.lsvcolMasp, Me.lsvcolTensp, Me.lsvcolHangsx, Me.lsvcolLoaisp, Me.lsvcolXuatxu, Me.lsvcoltenfile})
      Me.lsvthemsp.FullRowSelect = True
      Me.lsvthemsp.GridLines = True
      Me.lsvthemsp.Location = New System.Drawing.Point(9, 217)
      Me.lsvthemsp.MultiSelect = False
      Me.lsvthemsp.Name = "lsvthemsp"
      Me.lsvthemsp.Size = New System.Drawing.Size(494, 161)
      Me.lsvthemsp.TabIndex = 11
      Me.lsvthemsp.UseCompatibleStateImageBehavior = False
      Me.lsvthemsp.View = System.Windows.Forms.View.Details
      '
      'lsvcolMasp
      '
      Me.lsvcolMasp.Text = "Mã SP"
      '
      'lsvcolTensp
      '
      Me.lsvcolTensp.Text = "Tên sản phẩm"
      Me.lsvcolTensp.Width = 160
      '
      'lsvcolHangsx
      '
      Me.lsvcolHangsx.Text = "Hãng SX"
      Me.lsvcolHangsx.Width = 90
      '
      'lsvcolLoaisp
      '
      Me.lsvcolLoaisp.Text = "Loại SP"
      Me.lsvcolLoaisp.Width = 90
      '
      'lsvcolXuatxu
      '
      Me.lsvcolXuatxu.Text = "Xuất xứ"
      Me.lsvcolXuatxu.Width = 90
      '
      'lsvcoltenfile
      '
      Me.lsvcoltenfile.Text = "Tên file"
      Me.lsvcoltenfile.Width = 0
      '
      'txtXuatx
      '
      Me.txtXuatx.Location = New System.Drawing.Point(113, 160)
      Me.txtXuatx.Name = "txtXuatx"
      Me.txtXuatx.Size = New System.Drawing.Size(156, 25)
      Me.txtXuatx.TabIndex = 5
      '
      'txtLoaisp
      '
      Me.txtLoaisp.Location = New System.Drawing.Point(113, 126)
      Me.txtLoaisp.Name = "txtLoaisp"
      Me.txtLoaisp.Size = New System.Drawing.Size(156, 25)
      Me.txtLoaisp.TabIndex = 4
      '
      'txtHangsx
      '
      Me.txtHangsx.Location = New System.Drawing.Point(113, 92)
      Me.txtHangsx.Name = "txtHangsx"
      Me.txtHangsx.Size = New System.Drawing.Size(156, 25)
      Me.txtHangsx.TabIndex = 3
      '
      'txtTensp
      '
      Me.txtTensp.Location = New System.Drawing.Point(113, 58)
      Me.txtTensp.Name = "txtTensp"
      Me.txtTensp.Size = New System.Drawing.Size(156, 25)
      Me.txtTensp.TabIndex = 2
      '
      'txtMasp
      '
      Me.txtMasp.Location = New System.Drawing.Point(113, 24)
      Me.txtMasp.Name = "txtMasp"
      Me.txtMasp.Size = New System.Drawing.Size(156, 25)
      Me.txtMasp.TabIndex = 1
      '
      'lblmasp
      '
      Me.lblmasp.AutoSize = True
      Me.lblmasp.Location = New System.Drawing.Point(6, 27)
      Me.lblmasp.Name = "lblmasp"
      Me.lblmasp.Size = New System.Drawing.Size(100, 17)
      Me.lblmasp.TabIndex = 10
      Me.lblmasp.Text = "Mã sản phẩm: *"
      '
      'lblThongtin
      '
      Me.lblThongtin.AutoSize = True
      Me.lblThongtin.Location = New System.Drawing.Point(6, 197)
      Me.lblThongtin.Name = "lblThongtin"
      Me.lblThongtin.Size = New System.Drawing.Size(132, 17)
      Me.lblThongtin.TabIndex = 9
      Me.lblThongtin.Text = "Danh sách sản phẩm:"
      '
      'lblXuatxu
      '
      Me.lblXuatxu.AutoSize = True
      Me.lblXuatxu.Location = New System.Drawing.Point(6, 163)
      Me.lblXuatxu.Name = "lblXuatxu"
      Me.lblXuatxu.Size = New System.Drawing.Size(64, 17)
      Me.lblXuatxu.TabIndex = 6
      Me.lblXuatxu.Text = "Xuất xứ: *"
      '
      'lblLoaisp
      '
      Me.lblLoaisp.AutoSize = True
      Me.lblLoaisp.Location = New System.Drawing.Point(6, 129)
      Me.lblLoaisp.Name = "lblLoaisp"
      Me.lblLoaisp.Size = New System.Drawing.Size(105, 17)
      Me.lblLoaisp.TabIndex = 4
      Me.lblLoaisp.Text = "Loại sản phẩm: *"
      '
      'lblHangsx
      '
      Me.lblHangsx.AutoSize = True
      Me.lblHangsx.Location = New System.Drawing.Point(6, 95)
      Me.lblHangsx.Name = "lblHangsx"
      Me.lblHangsx.Size = New System.Drawing.Size(103, 17)
      Me.lblHangsx.TabIndex = 2
      Me.lblHangsx.Text = "Hãng sản xuất: *"
      '
      'lblTensp
      '
      Me.lblTensp.AutoSize = True
      Me.lblTensp.Location = New System.Drawing.Point(6, 61)
      Me.lblTensp.Name = "lblTensp"
      Me.lblTensp.Size = New System.Drawing.Size(102, 17)
      Me.lblTensp.TabIndex = 0
      Me.lblTensp.Text = "Tên sản phẩm: *"
      '
      'ptbHinhanh
      '
      Me.ptbHinhanh.BackColor = System.Drawing.Color.GhostWhite
      Me.ptbHinhanh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
      Me.ptbHinhanh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
      Me.ptbHinhanh.Image = Global.QuanlySua.My.Resources.Resources.chonhinh
      Me.ptbHinhanh.Location = New System.Drawing.Point(326, 24)
      Me.ptbHinhanh.Name = "ptbHinhanh"
      Me.ptbHinhanh.Size = New System.Drawing.Size(177, 161)
      Me.ptbHinhanh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
      Me.ptbHinhanh.TabIndex = 8
      Me.ptbHinhanh.TabStop = False
      '
      'frmAdd
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.BackColor = System.Drawing.Color.PowderBlue
      Me.ClientSize = New System.Drawing.Size(524, 439)
      Me.Controls.Add(Me.grbThongtinsp)
      Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
      Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
      Me.MaximizeBox = False
      Me.Name = "frmAdd"
      Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
      Me.Text = "Thêm Sản Phẩm"
      Me.grbThongtinsp.ResumeLayout(False)
      Me.grbThongtinsp.PerformLayout()
      CType(Me.ptbHinhanh, System.ComponentModel.ISupportInitialize).EndInit()
      Me.ResumeLayout(False)

   End Sub
   Friend WithEvents btnSave As System.Windows.Forms.Button
   Friend WithEvents btnExit As System.Windows.Forms.Button
   Friend WithEvents ofdPicture As System.Windows.Forms.OpenFileDialog
   Friend WithEvents grbThongtinsp As System.Windows.Forms.GroupBox
   Friend WithEvents lblThongtin As System.Windows.Forms.Label
   Friend WithEvents ptbHinhanh As System.Windows.Forms.PictureBox
   Friend WithEvents lblXuatxu As System.Windows.Forms.Label
   Friend WithEvents lblLoaisp As System.Windows.Forms.Label
   Friend WithEvents lblHangsx As System.Windows.Forms.Label
   Friend WithEvents lblTensp As System.Windows.Forms.Label
   Friend WithEvents lblmasp As System.Windows.Forms.Label
   Friend WithEvents txtXuatx As System.Windows.Forms.TextBox
   Friend WithEvents txtLoaisp As System.Windows.Forms.TextBox
   Friend WithEvents txtHangsx As System.Windows.Forms.TextBox
   Friend WithEvents txtTensp As System.Windows.Forms.TextBox
   Friend WithEvents txtMasp As System.Windows.Forms.TextBox
   Friend WithEvents lsvthemsp As System.Windows.Forms.ListView
   Friend WithEvents lsvcolMasp As System.Windows.Forms.ColumnHeader
   Friend WithEvents lsvcolTensp As System.Windows.Forms.ColumnHeader
   Friend WithEvents lsvcolHangsx As System.Windows.Forms.ColumnHeader
   Friend WithEvents lsvcolLoaisp As System.Windows.Forms.ColumnHeader
   Friend WithEvents lsvcolXuatxu As System.Windows.Forms.ColumnHeader
   Friend WithEvents btnDelete As System.Windows.Forms.Button
   Friend WithEvents btnEdit As System.Windows.Forms.Button
   Friend WithEvents lsvcoltenfile As System.Windows.Forms.ColumnHeader
End Class
