<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.mnsMainMenu = New System.Windows.Forms.MenuStrip()
        Me.mniHethong = New System.Windows.Forms.ToolStripMenuItem()
        Me.mniLogout = New System.Windows.Forms.ToolStripMenuItem()
        Me.mniExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.mniQuanlysp = New System.Windows.Forms.ToolStripMenuItem()
        Me.mniThemsp = New System.Windows.Forms.ToolStripMenuItem()
        Me.mniNhapsp = New System.Windows.Forms.ToolStripMenuItem()
        Me.mniXemsp = New System.Windows.Forms.ToolStripMenuItem()
        Me.mniThongtin = New System.Windows.Forms.ToolStripMenuItem()
        Me.mniBanquyen = New System.Windows.Forms.ToolStripMenuItem()
        Me.mniTrogiup = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblTench = New System.Windows.Forms.Label()
        Me.lblTenpm = New System.Windows.Forms.Label()
        Me.stsStatus = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lbltaikhoan = New System.Windows.Forms.Label()
        Me.ptbLogo = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.mnsMainMenu.SuspendLayout()
        Me.stsStatus.SuspendLayout()
        CType(Me.ptbLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'mnsMainMenu
        '
        Me.mnsMainMenu.BackColor = System.Drawing.Color.GhostWhite
        Me.mnsMainMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mniHethong, Me.mniQuanlysp, Me.mniThongtin})
        Me.mnsMainMenu.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow
        Me.mnsMainMenu.Location = New System.Drawing.Point(0, 0)
        Me.mnsMainMenu.Name = "mnsMainMenu"
        Me.mnsMainMenu.Padding = New System.Windows.Forms.Padding(7, 2, 0, 2)
        Me.mnsMainMenu.Size = New System.Drawing.Size(794, 24)
        Me.mnsMainMenu.TabIndex = 0
        Me.mnsMainMenu.Text = "Menu"
        '
        'mniHethong
        '
        Me.mniHethong.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mniLogout, Me.mniExit})
        Me.mniHethong.Name = "mniHethong"
        Me.mniHethong.Size = New System.Drawing.Size(69, 20)
        Me.mniHethong.Text = "&Hệ thống"
        '
        'mniLogout
        '
        Me.mniLogout.BackColor = System.Drawing.Color.White
        Me.mniLogout.Image = Global.QuanlySua.My.Resources.Resources._1370169928_logout
        Me.mniLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.mniLogout.Name = "mniLogout"
        Me.mniLogout.Size = New System.Drawing.Size(127, 22)
        Me.mniLogout.Text = "&Đăng xuất"
        '
        'mniExit
        '
        Me.mniExit.BackColor = System.Drawing.Color.GhostWhite
        Me.mniExit.Image = Global.QuanlySua.My.Resources.Resources._1370170634_button_cancel
        Me.mniExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.mniExit.Name = "mniExit"
        Me.mniExit.Size = New System.Drawing.Size(127, 22)
        Me.mniExit.Text = "&Đóng"
        '
        'mniQuanlysp
        '
        Me.mniQuanlysp.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mniThemsp, Me.mniNhapsp, Me.mniXemsp})
        Me.mniQuanlysp.Name = "mniQuanlysp"
        Me.mniQuanlysp.Size = New System.Drawing.Size(115, 20)
        Me.mniQuanlysp.Text = "&Quản lý sản phẩm"
        '
        'mniThemsp
        '
        Me.mniThemsp.BackColor = System.Drawing.Color.GhostWhite
        Me.mniThemsp.Image = Global.QuanlySua.My.Resources.Resources._1370173291_insert_object
        Me.mniThemsp.Name = "mniThemsp"
        Me.mniThemsp.Size = New System.Drawing.Size(160, 22)
        Me.mniThemsp.Text = "&Thêm sản phẩm"
        '
        'mniNhapsp
        '
        Me.mniNhapsp.BackColor = System.Drawing.Color.White
        Me.mniNhapsp.Image = Global.QuanlySua.My.Resources.Resources._1370173368_add_address
        Me.mniNhapsp.Name = "mniNhapsp"
        Me.mniNhapsp.Size = New System.Drawing.Size(160, 22)
        Me.mniNhapsp.Text = "&Nhập hàng"
        '
        'mniXemsp
        '
        Me.mniXemsp.BackColor = System.Drawing.Color.White
        Me.mniXemsp.Image = Global.QuanlySua.My.Resources.Resources._1370184898_224230_viewer1
        Me.mniXemsp.Name = "mniXemsp"
        Me.mniXemsp.Size = New System.Drawing.Size(160, 22)
        Me.mniXemsp.Text = "&Xem sản phẩm"
        '
        'mniThongtin
        '
        Me.mniThongtin.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mniBanquyen, Me.mniTrogiup})
        Me.mniThongtin.Name = "mniThongtin"
        Me.mniThongtin.Size = New System.Drawing.Size(71, 20)
        Me.mniThongtin.Text = "&Thông tin"
        '
        'mniBanquyen
        '
        Me.mniBanquyen.BackColor = System.Drawing.Color.GhostWhite
        Me.mniBanquyen.Image = Global.QuanlySua.My.Resources.Resources._1370174346_Information
        Me.mniBanquyen.Name = "mniBanquyen"
        Me.mniBanquyen.Size = New System.Drawing.Size(130, 22)
        Me.mniBanquyen.Text = "&Bản quyền"
        '
        'mniTrogiup
        '
        Me.mniTrogiup.BackColor = System.Drawing.Color.White
        Me.mniTrogiup.Image = Global.QuanlySua.My.Resources.Resources._1370174377_system_help
        Me.mniTrogiup.Name = "mniTrogiup"
        Me.mniTrogiup.Size = New System.Drawing.Size(130, 22)
        Me.mniTrogiup.Text = "&Trợ giúp"
        '
        'lblTench
        '
        Me.lblTench.AutoSize = True
        Me.lblTench.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTench.ForeColor = System.Drawing.Color.Black
        Me.lblTench.Location = New System.Drawing.Point(12, 36)
        Me.lblTench.Name = "lblTench"
        Me.lblTench.Size = New System.Drawing.Size(322, 21)
        Me.lblTench.TabIndex = 3
        Me.lblTench.Text = "Cửa hàng sữa 171 - Dinh dưỡng cho mọi nhà"
        '
        'lblTenpm
        '
        Me.lblTenpm.AutoSize = True
        Me.lblTenpm.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTenpm.ForeColor = System.Drawing.Color.Firebrick
        Me.lblTenpm.Location = New System.Drawing.Point(204, 80)
        Me.lblTenpm.Name = "lblTenpm"
        Me.lblTenpm.Size = New System.Drawing.Size(387, 21)
        Me.lblTenpm.TabIndex = 4
        Me.lblTenpm.Text = "PHẦN MỀM QUẢN LÝ SẢN PHẨM CỬA HÀNG SỮA"
        '
        'stsStatus
        '
        Me.stsStatus.BackColor = System.Drawing.Color.GhostWhite
        Me.stsStatus.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1})
        Me.stsStatus.Location = New System.Drawing.Point(0, 549)
        Me.stsStatus.Name = "stsStatus"
        Me.stsStatus.Size = New System.Drawing.Size(794, 22)
        Me.stsStatus.TabIndex = 5
        Me.stsStatus.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(159, 17)
        Me.ToolStripStatusLabel1.Text = "Lương Thanh Tâm - PS00922"
        '
        'lbltaikhoan
        '
        Me.lbltaikhoan.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltaikhoan.Location = New System.Drawing.Point(520, 507)
        Me.lbltaikhoan.Name = "lbltaikhoan"
        Me.lbltaikhoan.Size = New System.Drawing.Size(262, 26)
        Me.lbltaikhoan.TabIndex = 7
        Me.lbltaikhoan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ptbLogo
        '
        Me.ptbLogo.Image = Global.QuanlySua.My.Resources.Resources.LOGOFPOLY
        Me.ptbLogo.Location = New System.Drawing.Point(213, 229)
        Me.ptbLogo.Name = "ptbLogo"
        Me.ptbLogo.Size = New System.Drawing.Size(369, 112)
        Me.ptbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ptbLogo.TabIndex = 6
        Me.ptbLogo.TabStop = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(330, 153)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.PowderBlue
        Me.ClientSize = New System.Drawing.Size(794, 571)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lbltaikhoan)
        Me.Controls.Add(Me.ptbLogo)
        Me.Controls.Add(Me.stsStatus)
        Me.Controls.Add(Me.lblTenpm)
        Me.Controls.Add(Me.lblTench)
        Me.Controls.Add(Me.mnsMainMenu)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.mnsMainMenu
        Me.MaximizeBox = False
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Quản Lý Sản Phẩm"
        Me.mnsMainMenu.ResumeLayout(False)
        Me.mnsMainMenu.PerformLayout()
        Me.stsStatus.ResumeLayout(False)
        Me.stsStatus.PerformLayout()
        CType(Me.ptbLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
   Friend WithEvents mnsMainMenu As System.Windows.Forms.MenuStrip
   Friend WithEvents mniHethong As System.Windows.Forms.ToolStripMenuItem
   Friend WithEvents mniLogout As System.Windows.Forms.ToolStripMenuItem
   Friend WithEvents mniQuanlysp As System.Windows.Forms.ToolStripMenuItem
   Friend WithEvents mniThemsp As System.Windows.Forms.ToolStripMenuItem
   Friend WithEvents mniNhapsp As System.Windows.Forms.ToolStripMenuItem
   Friend WithEvents mniXemsp As System.Windows.Forms.ToolStripMenuItem
   Friend WithEvents mniThongtin As System.Windows.Forms.ToolStripMenuItem
   Friend WithEvents mniBanquyen As System.Windows.Forms.ToolStripMenuItem
   Friend WithEvents mniTrogiup As System.Windows.Forms.ToolStripMenuItem
   Friend WithEvents mniExit As System.Windows.Forms.ToolStripMenuItem
   Friend WithEvents lblTench As System.Windows.Forms.Label
   Friend WithEvents lblTenpm As System.Windows.Forms.Label
   Friend WithEvents stsStatus As System.Windows.Forms.StatusStrip
   Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
   Friend WithEvents ptbLogo As System.Windows.Forms.PictureBox
    Friend WithEvents lbltaikhoan As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
