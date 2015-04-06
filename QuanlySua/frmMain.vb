Public Class frmMain

   'sự kiện click menu Đóng : kết thúc chương trình
   Private Sub mniExit_Click(ByVal sender As System.Object, _
                             ByVal e As System.EventArgs) Handles mniExit.Click
      End
   End Sub

   'sự kiện click menu logout thoát tài khoản đang đăng nhập, goi lại form đăng nhập
   Private Sub mniLogout_Click(ByVal sender As System.Object, _
                               ByVal e As System.EventArgs) Handles mniLogout.Click
      lbltaikhoan.Text = ""
      frmLogin.Show()
      Me.Hide()
   End Sub

   'sự kiên click vào menu thêm hiển thị form thêm sản phẩm
   Private Sub mniThemsp_Click(ByVal sender As System.Object, _
                               ByVal e As System.EventArgs) Handles mniThemsp.Click
      frmAdd.ShowDialog()
   End Sub

   'sự kiện click vào menu nhập sản phẩm hiển thị form import
   Private Sub mniNhapsp_Click(ByVal sender As System.Object, _
                               ByVal e As System.EventArgs) Handles mniNhapsp.Click
      frmImport.ShowDialog()
   End Sub

   'sự kiện khi click menu xem sản phẩm hiển thị form xem thông tin sản phẩm
   Private Sub mniXemsp_Click(ByVal sender As System.Object, _
                              ByVal e As System.EventArgs) Handles mniXemsp.Click
      frmView.ShowDialog()
   End Sub

   'sự kiện click vào menu thông tin hiển thị form thông tin bản quyền phần mềm
   Private Sub mniBanquyen_Click(ByVal sender As System.Object, _
                                 ByVal e As System.EventArgs) Handles mniBanquyen.Click
      frmAbout.ShowDialog()
   End Sub

   Private Sub frmMain_FormClosed(ByVal sender As Object, _
                                  ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
      End
   End Sub

   'sự kiện click vào menu trợ giúp hiển thị file hướng dẫn sử dụng
   Private Sub mniTrogiup_Click(ByVal sender As System.Object, _
                                ByVal e As System.EventArgs) Handles mniTrogiup.Click
      Help.ShowHelp(Me, "Assignment.chm")
   End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class