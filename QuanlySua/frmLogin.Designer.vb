<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLogin
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
        Dim grbLogin As System.Windows.Forms.GroupBox
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLogin))
        Me.txtLogin = New System.Windows.Forms.TextBox()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblLoginError = New System.Windows.Forms.Label()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.lblLogin = New System.Windows.Forms.Label()
        grbLogin = New System.Windows.Forms.GroupBox()
        grbLogin.SuspendLayout()
        Me.SuspendLayout()
        '
        'grbLogin
        '
        grbLogin.BackColor = System.Drawing.Color.Transparent
        grbLogin.Controls.Add(Me.txtLogin)
        grbLogin.Controls.Add(Me.btnExit)
        grbLogin.Controls.Add(Me.lblLoginError)
        grbLogin.Controls.Add(Me.btnLogin)
        grbLogin.Controls.Add(Me.txtPassword)
        grbLogin.Controls.Add(Me.lblPassword)
        grbLogin.Controls.Add(Me.lblLogin)
        grbLogin.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        grbLogin.ForeColor = System.Drawing.Color.DarkOrange
        grbLogin.Location = New System.Drawing.Point(12, 9)
        grbLogin.Name = "grbLogin"
        grbLogin.Size = New System.Drawing.Size(364, 172)
        grbLogin.TabIndex = 0
        grbLogin.TabStop = False
        grbLogin.Text = "Đăng nhập"
        '
        'txtLogin
        '
        Me.txtLogin.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLogin.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.txtLogin.Location = New System.Drawing.Point(121, 49)
        Me.txtLogin.MaxLength = 20
        Me.txtLogin.Name = "txtLogin"
        Me.txtLogin.Size = New System.Drawing.Size(198, 25)
        Me.txtLogin.TabIndex = 1
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.btnExit.Image = Global.QuanlySua.My.Resources.Resources._1370891310_101
        Me.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnExit.Location = New System.Drawing.Point(229, 116)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(90, 27)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "Thoát"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblLoginError
        '
        Me.lblLoginError.BackColor = System.Drawing.Color.Transparent
        Me.lblLoginError.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLoginError.ForeColor = System.Drawing.Color.OrangeRed
        Me.lblLoginError.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblLoginError.Location = New System.Drawing.Point(132, 19)
        Me.lblLoginError.Name = "lblLoginError"
        Me.lblLoginError.Size = New System.Drawing.Size(187, 23)
        Me.lblLoginError.TabIndex = 5
        Me.lblLoginError.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblLoginError.Visible = False
        '
        'btnLogin
        '
        Me.btnLogin.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogin.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.btnLogin.Image = Global.QuanlySua.My.Resources.Resources._1370891259_clean
        Me.btnLogin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLogin.Location = New System.Drawing.Point(121, 116)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(90, 27)
        Me.btnLogin.TabIndex = 3
        Me.btnLogin.Text = "     Đăng nhập"
        Me.btnLogin.UseVisualStyleBackColor = True
        '
        'txtPassword
        '
        Me.txtPassword.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.txtPassword.Location = New System.Drawing.Point(121, 81)
        Me.txtPassword.MaxLength = 30
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(198, 25)
        Me.txtPassword.TabIndex = 2
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPassword.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.lblPassword.Location = New System.Drawing.Point(26, 84)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(65, 17)
        Me.lblPassword.TabIndex = 1
        Me.lblPassword.Text = "Mật khẩu:"
        '
        'lblLogin
        '
        Me.lblLogin.AutoSize = True
        Me.lblLogin.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLogin.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.lblLogin.Location = New System.Drawing.Point(26, 52)
        Me.lblLogin.Name = "lblLogin"
        Me.lblLogin.Size = New System.Drawing.Size(89, 17)
        Me.lblLogin.TabIndex = 0
        Me.lblLogin.Text = "Tên tài khoản:"
        '
        'frmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.GhostWhite
        Me.ClientSize = New System.Drawing.Size(388, 193)
        Me.ControlBox = False
        Me.Controls.Add(grbLogin)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cửa Hàng Sữa 171"
        grbLogin.ResumeLayout(False)
        grbLogin.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
   Friend WithEvents lblPassword As System.Windows.Forms.Label
   Friend WithEvents lblLogin As System.Windows.Forms.Label
   Friend WithEvents txtPassword As System.Windows.Forms.TextBox
   Friend WithEvents btnLogin As System.Windows.Forms.Button
   Friend WithEvents lblLoginError As System.Windows.Forms.Label
   Friend WithEvents btnExit As System.Windows.Forms.Button
   Friend WithEvents txtLogin As System.Windows.Forms.TextBox

End Class
