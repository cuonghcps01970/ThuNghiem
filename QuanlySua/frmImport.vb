Imports System.IO
Public Class frmImport

   Dim strdocfile As String         'khai báo biến đọc file
   Dim arrmangluu As String()       'khai báo mảng để lưu dữ liệu đọc file
   Dim lstmoiluu As String

   'sự kiện click button thoát: đóng form nhập hàng
   Private Sub btnThoat_Click(ByVal sender As System.Object, _
                              ByVal e As System.EventArgs) Handles btnThoat.Click
      Me.Close()
   End Sub

   'sự kiện click button thêm: thêm thông tin nhập hàng vào list và lưu lại trong file
   Private Sub btnThem_Click(ByVal sender As System.Object, _
                             ByVal e As System.EventArgs) Handles btnThem.Click

      Dim strsave As StreamWriter 'khai báo biến Streamwriter
      'kiểm tra các textbox
      If txtSoluong.Text = "" OrElse cbbMasp.Text = "" OrElse cbbDvt.Text = "" _
         OrElse txtNhacungcap.Text = "" OrElse txtGiaban.Text = "" Then
         MessageBox.Show("Nhập đủ thông tin cần thiết (*)", "Thông báo", _
                         MessageBoxButtons.OK, MessageBoxIcon.Error)
      Else
         strsave = New StreamWriter("nhaphang.txt", True)
         strsave.WriteLine(cbbMasp.Text + "," + txtSoluong.Text + "," + _
                           cbbDvt.Text + "," + txtGiaban.Text + "," + _
                           dtpNgaynhap.Text + "," + txtGhichu.Text + "," + _
                           lblTenspResult.Text + "," + lblHangsxResult.Text + "," + _
                           lblLoaispResult.Text + "," + lblXuatxuResult.Text + "," + ptbHinhanh.ImageLocation)

         MessageBox.Show("Đã lưu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
         strsave.Close() 'đóng streamwriter
         'xóa textbox  và label sau khi lưu thành công
         cbbMasp.Text = ""
         txtSoluong.Clear()
         cbbDvt.Text = ""
         txtGiaban.Clear()
         txtNhacungcap.Clear()
         txtGhichu.Clear()
         lblTenspResult.Text = ""
         lblHangsxResult.Text = ""
         lblLoaispResult.Text = ""
         lblXuatxuResult.Text = ""
         ptbHinhanh.ImageLocation = ""

      End If

   End Sub

   'sự kiện load form nhập hàng lấy thông tin mã hàng từ file vào combobox
   Private Sub frmImport_Load(ByVal sender As System.Object, _
                              ByVal e As System.EventArgs) Handles MyBase.Load
      cbbMasp.Items.Clear()      'xóa item cũ trong combobox load lại item mới từ file
      'kiểm tra sự tồn tại của file, nếu có mới thực hiện
      If File.Exists("themsanpham.txt") = True Then
         Dim dulieu As StreamReader = New StreamReader("themsanpham.txt") 'mở file 
         'lấy dữ liệu từ file lên combobox
         Do While dulieu.EndOfStream = False 'lặp lại khi chưa đọc hết file
            strdocfile = dulieu.ReadLine()         'đọc từng dòng trong file
            arrmangluu = strdocfile.Split(",")     'ghi vào mảng
            lstmoiluu = arrmangluu(0)            'thêm mới dữ liệu
            cbbMasp.Items.Add(lstmoiluu)        'thêm item mới vào combobox
         Loop

         dulieu.Close()    'đóng file
      Else  'còn nếu file themsanpham.txt không tồn tại thì tạo ra file mới để tránh lỗi khi load
         Using strsave As New StreamWriter("themsanpham.txt", True)
         End Using

      End If

   End Sub

   'sự kiện khi chọn mã sp trong combobox hiển thị thông tin chi tiết của sản phẩm
   Private Sub cbbTensp_SelectedIndexChanged(ByVal sender As System.Object, _
                                             ByVal e As System.EventArgs) Handles cbbMasp.SelectedIndexChanged
      Dim strdocfile As String         'khai báo biến đọc file
      Dim arrmangluu As String()       'khai báo mảng để lưu dữ liệu đọc file
      Dim lstmoiluu As ListViewItem = New ListViewItem 'khai báo danh sách mới lưu
      Dim dulieu As StreamReader = New StreamReader("themsanpham.txt", True) 'mở file 
      'lấy dữ liệu từ file lên listview
      Do While dulieu.EndOfStream = False 'lặp lại khi chưa đọc hết file
         strdocfile = dulieu.ReadLine()         'đọc từng dòng trong file
         arrmangluu = strdocfile.Split(",")     'ghi vào mảng
         If cbbMasp.Text = arrmangluu(0) Then
            lblTenspResult.Text = arrmangluu(1)
            lblHangsxResult.Text = arrmangluu(2)
            lblLoaispResult.Text = arrmangluu(3)
            lblXuatxuResult.Text = arrmangluu(4)
            ptbHinhanh.ImageLocation = arrmangluu(5)
         End If
      Loop
      dulieu.Close()

   End Sub

   'chỉ cho phép nhập số vào textbox giá tiền
   Private Sub txtGiaban_KeyPress(ByVal sender As Object, _
                                  ByVal e As System.Windows.Forms.KeyPressEventArgs) _
                               Handles txtGiaban.KeyPress
      'kiểm tra phím nhấn nhập vào là phím số và phím điều khiển
      If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
         e.Handled = True
      Else
         e.Handled = False
      End If
   End Sub

   'chỉ cho phép nhập số vào textbox số lượng
   Private Sub txtSoluong_KeyPress(ByVal sender As Object, _
                                   ByVal e As System.Windows.Forms.KeyPressEventArgs) _
                                Handles txtSoluong.KeyPress
      If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
         e.Handled = True
      Else
         e.Handled = False
      End If
   End Sub
End Class