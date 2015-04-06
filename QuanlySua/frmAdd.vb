Imports System.IO

Public Class frmAdd


   'thủ tục kiểm tra các thông tin nhập vào textbox
   Function checktextbox() As Boolean
      Dim checkedfun As Boolean = True
      Dim laydulieu() As String = File.ReadAllLines(Application.StartupPath + "\themsanpham.txt")
      Dim dulieu As String = ""     'khai báo biến lưu dữ liệu với giá trị rỗng
      Dim ketquass As Boolean = False
      'kiểm tra mã sản phẩm trùng nhau
      For i As Integer = 0 To laydulieu.Length - 1
         For j As Integer = 0 To laydulieu(i).Length - 1
            If laydulieu(i)(j) <> "," Then
               dulieu += laydulieu(i)(j)
            ElseIf LCase(txtMasp.Text) = LCase(dulieu) Then 'mã sản phẩm không phân biệt chữ hoa chữ thường
               ketquass = True
               GoTo kiemtratextbox
            Else
               dulieu = ""
               Exit For
            End If
         Next
      Next
kiemtratextbox:
      If ketquass = True Then 'nếu trùng mã sản phẩm thì thông báo lỗi
         MessageBox.Show("Trùng mã sản phẩm", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error)
         txtMasp.Focus()
         checkedfun = False
      End If
      'kiểm tra các textbox
      If txtHangsx.Text = "" OrElse txtLoaisp.Text = "" OrElse txtMasp.Text = "" _
         OrElse txtTensp.Text = "" OrElse txtXuatx.Text = "" Then

         MessageBox.Show("Nhập đủ thông tin cần thiết (*)", "Thông báo", _
                         MessageBoxButtons.OK, MessageBoxIcon.Error)
         txtMasp.Focus()   'chuyển focus về textbox mã sản phẩm
         checkedfun = False
      End If

      Return checkedfun
   End Function

   'sự kiện button thoát: đóng form
   Private Sub btnExit_Click(ByVal sender As System.Object, _
                             ByVal e As System.EventArgs) Handles btnExit.Click
      'đóng form add
      Me.Close()
   End Sub

   'sự kiện click button Thêm: đưa dữ liệu từ textbox xuống listview và lưu vào file
   Private Sub btnSave_Click(ByVal sender As System.Object, _
                             ByVal e As System.EventArgs) Handles btnSave.Click

      'gọi thủ tục checktextbox để kiểm tra thông tin nhập vào textbox
      If checktextbox() Then
         Using strsave As New StreamWriter("themsanpham.txt", True)
            strsave.WriteLine(txtMasp.Text + "," + txtTensp.Text + "," + _
                              txtHangsx.Text + "," + txtLoaisp.Text + "," + _
                              txtXuatx.Text + "," + tenfile.Substring(0, tenfile.Length) + ",")
            strsave.Close() 'đóng file
         End Using

         MessageBox.Show("Đã lưu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)

         'đưa dữ liệu từ textbox xuống listview
         Dim lstmoiluu As ListViewItem
         lstmoiluu = New ListViewItem(txtMasp.Text)
         lstmoiluu.SubItems.Add(txtTensp.Text)
         lstmoiluu.SubItems.Add(txtHangsx.Text)
         lstmoiluu.SubItems.Add(txtLoaisp.Text)
         lstmoiluu.SubItems.Add(txtXuatx.Text)
         lstmoiluu.SubItems.Add(ptbHinhanh.ImageLocation)
         lsvthemsp.Items.Add(lstmoiluu)

         'xóa textbox sau khi lưu thành công
         txtHangsx.Clear()
         txtLoaisp.Clear()
         txtMasp.Clear()
         txtTensp.Clear()
         txtXuatx.Clear()
         ptbHinhanh.ImageLocation = "nopictures.png"
      End If
   End Sub

   Dim tenfile As String = ""   'biến lưu tên file hình ảnh

   'khi click vào picturebox mở hộp thoại chọn file hình ảnh để lưu ảnh sản phẩm
   Private Sub ptbHinhanh_Click(ByVal sender As System.Object, _
                                ByVal e As System.EventArgs) Handles ptbHinhanh.Click

      'nếu hộp thoại chọn file hiển thị thì
      If (ofdPicture.ShowDialog() = Windows.Forms.DialogResult.Cancel) Then
         tenfile = "chonhinh.png"
         ptbHinhanh.ImageLocation = tenfile
      Else
         tenfile = ofdPicture.SafeFileName
         If ktdinhdang(tenfile) = True Then
            FileCopy(ofdPicture.FileName, ofdPicture.SafeFileName)   'copy file vào thư mục nguồn
            tenfile = ofdPicture.SafeFileName
            ptbHinhanh.ImageLocation = tenfile
         Else
            tenfile = "chonhinh.png"
            ptbHinhanh.ImageLocation = tenfile
         End If
      End If
   End Sub

   'sự kiện load form Thêm sản phẩm
   Private Sub frmAdd_Load(ByVal sender As System.Object, _
                           ByVal e As System.EventArgs) Handles MyBase.Load
      'khi load form xóa listview và đọc lại thông tin từ file
      lsvthemsp.Items.Clear() 'xóa list

      If File.Exists("themsanpham.txt") = True Then   'nếu file tồn tại mới đọc dữ liệu

         'load lại thông tin từ file lên listview
         Dim dulieulist As StreamReader = New StreamReader("themsanpham.txt", True) 'mở file 
         Dim strdocfile As String         'khai báo biến đọc file
         Dim arrmangluu As String()       'khai báo mảng để lưu dữ liệu đọc file
         Dim lstmoiluu As ListViewItem = New ListViewItem 'khai báo danh sách mới lưu
         Do While dulieulist.EndOfStream = False 'lặp lại khi chưa đọc hết file
            strdocfile = dulieulist.ReadLine()         'đọc từng dòng trong file
            'strdocfilenhap = dulieunhap.ReadLine()
            arrmangluu = strdocfile.Split(",")     'ghi vào mảng
            'arrmangluunhap = strdocfilenhap.Split(",")

            lstmoiluu = New ListViewItem(arrmangluu(0))     'thêm mới dữ liệu
            lstmoiluu.SubItems.Add(arrmangluu(1))           'thêm từng  vào từng cột trong dòng
            lstmoiluu.SubItems.Add(arrmangluu(2))
            lstmoiluu.SubItems.Add(arrmangluu(3))
            lstmoiluu.SubItems.Add(arrmangluu(4))
            lstmoiluu.SubItems.Add(arrmangluu(5))
            lsvthemsp.Items.Add(lstmoiluu)        'thêm dòng mới vào listview
         Loop
         dulieulist.Close()    'đóng file
         btnEdit.Enabled = False    'vô hiệu hóa button sửa khi load form
         btnDelete.Enabled = False  'vô hiệu hóa button xóa khi load form
      Else     'nếu file chưa tồn tại thì tạo ra file mới
         Using strsave As New StreamWriter("themsanpham.txt", True)
         End Using
      End If

      'thiết lập kiểu hiển thị màu cho list
      For Co As Integer = 0 To lsvthemsp.Items.Count - 1 Step 2
         lsvthemsp.Items(Co).BackColor = Color.LemonChiffon
      Next

   End Sub

   'sự kiện khi click vào items trong list hiển thị thông tin lên lại textbox tương ứng
   Private Sub lsvthemsp_SelectedIndexChanged( _
                                             ByVal sender As System.Object, ByVal e As System.EventArgs) _
                                          Handles lsvthemsp.SelectedIndexChanged
      Dim lstrow As ListViewItem = New ListViewItem      'khai báo biến lưu dòng dữ liệu trong listview
      For Each lstrow In lsvthemsp.SelectedItems
         txtMasp.Text = lstrow.SubItems(0).Text
         txtTensp.Text = lstrow.SubItems(1).Text
         txtHangsx.Text = lstrow.SubItems(2).Text
         txtLoaisp.Text = lstrow.SubItems(3).Text
         txtXuatx.Text = lstrow.SubItems(4).Text
         ptbHinhanh.ImageLocation = lstrow.SubItems(5).Text
      Next
      'nếu đăng nhập bằng tài khoản bán hàng thì vô hiệu hóa button sửa và xóa
      If frmMain.lbltaikhoan.Text = "Bạn đang đăng nhập với tài khoản Banhang" Then
         btnEdit.Enabled = False    'vô hiệu hóa button sửa
         btnDelete.Enabled = False  'vô hiệu hóa button xóa
      Else  'ngược lại  thì enable button sửa và xóa
         btnEdit.Enabled = True
         btnDelete.Enabled = True
      End If
   End Sub

   'sự kiện button xóa: xóa dòng dữ liệu đang chọn khỏi listview
   Private Sub btnDelete_Click(ByVal sender As System.Object, _
                               ByVal e As System.EventArgs) Handles btnDelete.Click

      Dim i As Integer = lsvthemsp.FocusedItem.Index 'biến lấy số thư tự dòng đang chọn
      If MessageBox.Show("Bạn muốn xóa sản phẩm này", "Thông báo", _
                         MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
         lsvthemsp.Items(i).Remove()   'xóa dòng đang chọn khỏi list
         'xóa textbox tương ứng
         txtMasp.Clear()
         txtHangsx.Clear()
         txtLoaisp.Clear()
         txtTensp.Clear()
         txtXuatx.Clear()
         ptbHinhanh.ImageLocation = ""
      End If
   End Sub

   'sự kiện khi đóng form: lưu lại listview mới vào file(ghi đè lên dữ liệu cũ)
   Private Sub frmAdd_FormClosed(ByVal sender As Object, _
                                 ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
      'lưa lại list hiện tại vào file
      Dim luulailist As StreamWriter = New StreamWriter("themsanpham.txt", False) 'false ghi đè lên dữ liệu cũ
      Dim rowlist As String
      For i As Integer = 0 To lsvthemsp.Items.Count - 1 ' lưu lại chuỗi từ listview
         rowlist = lsvthemsp.Items(i).SubItems(0).Text + "," + lsvthemsp.Items(i).SubItems(1).Text _
            + "," + lsvthemsp.Items(i).SubItems(2).Text + "," + lsvthemsp.Items(i).SubItems(3).Text _
            + "," + lsvthemsp.Items(i).SubItems(4).Text + "," + lsvthemsp.Items(i).SubItems(5).Text
         luulailist.WriteLine(rowlist) 'ghi từng dòng vào file
      Next
      luulailist.Close() 'đóng file
      lsvthemsp.Items.Clear() 'clear list
   End Sub

   'sự kiện button sửa: lưu lại nội dung đã sửa xuống listview
   Private Sub btnEdit_Click(ByVal sender As System.Object, _
                             ByVal e As System.EventArgs) Handles btnEdit.Click

      Dim i As Integer = lsvthemsp.FocusedItem.Index 'biến lấy số thư tự dòng đang chọn
      'lấy dữ liệu từ textbox xuống dòng đang chọn
      'kiểm tra các điều kiện trên textbox
      If lsvthemsp.Items(i).SubItems(0).Text = txtMasp.Text Then
         lsvthemsp.Items(i).SubItems(1).Text = txtTensp.Text
         lsvthemsp.Items(i).SubItems(2).Text = txtHangsx.Text
         lsvthemsp.Items(i).SubItems(3).Text = txtLoaisp.Text
         lsvthemsp.Items(i).SubItems(4).Text = txtXuatx.Text
         lsvthemsp.Items(i).SubItems(5).Text = ptbHinhanh.ImageLocation
         MessageBox.Show("Đã lưu!", "Sửa thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information)
      ElseIf checktextbox() = False Then  'ko cho sửa mã sản phẩm trùng với mã đã có trong list
         lsvthemsp.Items(i).SubItems(0).Text = lsvthemsp.Items(i).SubItems(0).Text
         lsvthemsp.Items(i).SubItems(1).Text = lsvthemsp.Items(i).SubItems(1).Text
         lsvthemsp.Items(i).SubItems(2).Text = lsvthemsp.Items(i).SubItems(2).Text
         lsvthemsp.Items(i).SubItems(3).Text = lsvthemsp.Items(i).SubItems(3).Text
         lsvthemsp.Items(i).SubItems(4).Text = lsvthemsp.Items(i).SubItems(4).Text
         lsvthemsp.Items(i).SubItems(5).Text = lsvthemsp.Items(i).SubItems(5).Text
      Else
         lsvthemsp.Items(i).SubItems(0).Text = txtMasp.Text
         lsvthemsp.Items(i).SubItems(1).Text = txtTensp.Text
         lsvthemsp.Items(i).SubItems(2).Text = txtHangsx.Text
         lsvthemsp.Items(i).SubItems(3).Text = txtLoaisp.Text
         lsvthemsp.Items(i).SubItems(4).Text = txtXuatx.Text
         lsvthemsp.Items(i).SubItems(5).Text = ptbHinhanh.ImageLocation
         MessageBox.Show("Đã lưu!", "Sửa thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information)
      End If

   End Sub

   'thủ tục kiểm tra định dạng file hình ảnh
   Function ktdinhdang(ByVal loaianh As String) As Boolean
      If loaianh.EndsWith(".jpg") = False AndAlso loaianh.EndsWith(".png") = False _
         AndAlso loaianh.EndsWith(".JPG") = False AndAlso loaianh.EndsWith(".PNG") = False Then
         MessageBox.Show("Chọn định dạng ảnh '.jpg' hoặc '.png'", "Lỗi chọn file", _
                         MessageBoxButtons.OK, MessageBoxIcon.Error)
         Return False
      Else
         Return True
      End If
   End Function 'ktdinhdang

End Class 'frmAdd