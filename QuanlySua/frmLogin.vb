Public Class frmLogin

   'Sự kiện khi click vào button đăng nhập
   Private Sub btnLogin_Click(ByVal sender As System.Object, _
                              ByVal e As System.EventArgs) Handles btnLogin.Click

      'nếu tài khoản và mật khẩu chưa nhập thì
      If txtLogin.Text = "" AndAlso txtPassword.Text = "" Then
         lblLoginError.Visible = True        'hiện label báo lỗi
         lblLoginError.Text = "Nhập tài khoản và mật khẩu!"
         txtLogin.Focus()                    'chuyển focus đến textbox tài khoản

         'nếu nhập đúng tài khoản và mật khẩu của admin thì
      ElseIf LCase(txtLogin.Text) = "admin" AndAlso txtPassword.Text = "admin" Then
         txtLogin.Clear()
         txtPassword.Clear()
         txtLogin.Focus()
         frmMain.Show()       'gọi form chính xuất hiện
         Me.Hide()            'ẩn form đăng nhập
         frmMain.lbltaikhoan.Text = "Bạn đang đăng nhập với tài khoản Admin"
         'nếu nhập đúng tài khoản và mật khẩu của banhang thì
      ElseIf LCase(txtLogin.Text) = "banhang" AndAlso txtPassword.Text = "Banhang" Then
         txtLogin.Clear()
         txtPassword.Clear()
         txtLogin.Focus()
         frmMain.Show()       'gọi form chính xuất hiện
         Me.Hide()            'ẩn form đăng nhập
         frmMain.mniNhapsp.Enabled = False
         frmMain.lbltaikhoan.Text = "Bạn đang đăng nhập với tài khoản Banhang"
         'vô hiệu hóa một số button đối với tài khoản bán hàng
         frmAdd.btnEdit.Enabled = False
         frmAdd.btnDelete.Enabled = False
         'nếu nhập đúng tài khoản admin mà ko nhập mật khẩu thì
      ElseIf LCase(txtLogin.Text) = "admin" AndAlso txtPassword.Text = "" Then
         txtPassword.Focus()  'để focus tại textbox nhập mật khẩu

         'nếu nhập đúng tài khoản admin mà sai mật khẩu thì
      ElseIf LCase(txtLogin.Text) = "admin" AndAlso txtPassword.Text <> "" _
         AndAlso txtPassword.Text <> "Admin" Then
         txtPassword.Text = ""         'xóa mật khẩu sai
         txtPassword.Focus()           'chuyển focus tại textbox nhập mật khẩu
         lblLoginError.Visible = True  'hiện label báo lỗi
         lblLoginError.Text = "Sai mật khẩu!"

         'nếu nhập đúng tài khoản banhang mà ko nhập mật khẩu thì
      ElseIf LCase(txtLogin.Text) = "banhang" AndAlso txtPassword.Text = "" Then
         txtPassword.Focus()  'để focus tại textbox nhập mật khẩu

         'nếu nhập đúng tài khoản banhang mà sai mật khẩu thì
      ElseIf LCase(txtLogin.Text) = "banhang" AndAlso txtPassword.Text <> "" _
         AndAlso txtPassword.Text <> "Banhang" Then
         txtPassword.Text = ""         'xóa mật khẩu sai
         txtPassword.Focus()           'chuyển focus tại textbox nhập mật khẩu
         lblLoginError.Visible = True  'hiện label báo lỗi
         lblLoginError.Text = "Sai mật khẩu!"

         'nếu không nhập đúng tài khoản thì
      ElseIf LCase(txtLogin.Text) <> "admin" AndAlso LCase(txtLogin.Text) <> "banhang" Then
         txtLogin.Focus()              'chuyển focus tại textbox nhập tài khoản
         lblLoginError.Visible = True  'hiện label báo lỗi
         lblLoginError.Text = "Sai tài khoản!"
      End If
   End Sub 'btnLogin

   'sự kiện khi click vào button Exit
   Private Sub btnExit_Click(ByVal sender As System.Object, _
               ByVal e As System.EventArgs) Handles btnExit.Click
      End      'kết thúc chương trình
   End Sub

   'sự kiện khi nhấp phím Enter trong textbox tài khoản
   Private Sub txtLogin_KeyDown(ByVal sender As Object, _
               ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtLogin.KeyDown

      If e.KeyCode = Keys.Enter Then   'nếu phím nhấn là phím Enter thì
         txtPassword.Focus()           'chuyển focus đến textbox nhập mật khẩu
         btnLogin.PerformClick()       'gọi sự kiện click button đăng nhập
      End If
   End Sub     'btnExit

   'sự kiện khi thay đổi nội dung trong textbox tài khoản
   Private Sub txtLogin_TextChanged(ByVal sender As System.Object, _
               ByVal e As System.EventArgs) Handles txtLogin.TextChanged
      lblLoginError.Hide()    'ẩn label báo lỗi nếu có
   End Sub

   'sự kiện khi nhấp phím Enter trong textbox mật khẩu
   Private Sub txtPassword_KeyDown(ByVal sender As Object, _
               ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtPassword.KeyDown
      If e.KeyCode = Keys.Enter Then      'nếu phím nhấn là phím Enter thì
         btnLogin.PerformClick()          'goi sự kiện click của button đăng nhập
      End If
   End Sub

   'sự kiện khi thay đổi nội dung trong textbox mật khẩu
   Private Sub txtPassword_TextChanged(ByVal sender As System.Object, _
               ByVal e As System.EventArgs) Handles txtPassword.TextChanged
      lblLoginError.Hide()    'ẩn label báo lỗi nếu có
   End Sub

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
