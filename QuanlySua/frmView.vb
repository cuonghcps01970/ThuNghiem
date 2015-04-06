Imports System.IO

Public Class frmView

   Dim strdocfile As String         'khai báo biến đọc file
   Dim arrmangluu As String()       'khai báo mảng để lưu dữ liệu đọc file
   Dim lstmoiluu As ListViewItem = New ListViewItem 'khai báo danh sách mới lưu

   'sự kiện khi click vào button Đóng. đóng form lại
   Private Sub btnDong_Click(ByVal sender As System.Object, _
                             ByVal e As System.EventArgs) Handles btnDong.Click
      Me.Close()
   End Sub

   'sự kiện đọc dữ liệu từ file themsanpham.txt vào listview khi load form frmView
   Private Sub frmView_Load(ByVal sender As System.Object, _
                            ByVal e As System.EventArgs) Handles MyBase.Load
      lsvDanhsachsp.Items.Clear()      'xóa list cũ
      If File.Exists("nhaphang.txt") = True Then 'kiểm tra sự tồn tại của file, nếu có mới thực hiện

         'khai báo biến streamwriter nhận giá trị từ file themsanpham.txt
         Dim dulieu As StreamReader = New StreamReader("nhaphang.txt", True) 'mở file 
         'lấy dữ liệu từ file lên listview
         Do While dulieu.EndOfStream = False 'lặp lại khi chưa đọc hết file
            strdocfile = dulieu.ReadLine()         'đọc từng dòng trong file
            'strdocfilenhap = dulieunhap.ReadLine()
            arrmangluu = strdocfile.Split(",")     'ghi vào mảng
            'arrmangluunhap = strdocfilenhap.Split(",")

            lstmoiluu = New ListViewItem(arrmangluu(0))     'thêm mới dữ liệu
            lstmoiluu.SubItems.Add(arrmangluu(6))           'thêm từng  vào từng cột trong dòng
            lstmoiluu.SubItems.Add(arrmangluu(7))
            lstmoiluu.SubItems.Add(String.Format("{0:n}", Val(arrmangluu(3))))
            lstmoiluu.SubItems.Add(arrmangluu(1))
            lstmoiluu.SubItems.Add(arrmangluu(10))
            lstmoiluu.SubItems.Add(arrmangluu(2))
            lsvDanhsachsp.Items.Add(lstmoiluu)        'thêm dòng mới vào listview
         Loop
         dulieu.Close()    'đóng file
         lsvcolHinhanh.Width = 0

      Else 'nếu file chưa tồn tại thì tạo file mới để lưu dữ liệu
         Using strsave As New StreamWriter("nhaphang.txt", True)
         End Using
      End If
      If lsvDanhsachsp.Items.Count > 0 Then 'kiểm tra list và vô hiệu hóa các button khi load form
         lsvDanhsachsp.Items(0).Selected = True
         lblSttResult.Text = 1
      Else
         lblSttResult.Text = 0
         btnPre.Enabled = False
         btnNext.Enabled = False
         btnLast.Enabled = False
         btnFirst.Enabled = False

      End If

      'thiết lập kiểu hiển thị màu cho list
      For Co As Integer = 0 To lsvDanhsachsp.Items.Count - 1 Step 2
         lsvDanhsachsp.Items(Co).BackColor = Color.LemonChiffon
      Next

   End Sub

   'sự kiện khi click vào 1 dòng trong listview lấy dữ liệu trong từng cột lên textbox tương ứng
   Private Sub lstDanhsachsp_SelectedIndexChanged(ByVal sender As Object, _
                                                  ByVal e As System.EventArgs) Handles lsvDanhsachsp.SelectedIndexChanged
      Dim lstrow As ListViewItem = New ListViewItem      'khai báo biến lưu dòng dữ liệu trong listview
      For Each lstrow In lsvDanhsachsp.SelectedItems     '
         cbbMasp.Text = lstrow.SubItems(0).Text
         lblTenspResult.Text = lstrow.SubItems(1).Text
         lblHangsxResult.Text = lstrow.SubItems(2).Text
         lblGiabanResult.Text = String.Format("{0:n}", lstrow.SubItems(3).Text) & " Vnđ"
         lblSoluongResult.Text = lstrow.SubItems(4).Text & " " & lstrow.SubItems(6).Text
         ptbHinhsp.ImageLocation = lstrow.SubItems(5).Text
      Next
      If lsvDanhsachsp.Items(0).Selected = True Then  'nếu đang chọn dòng đầu tiên trong list thì
         btnFirst.Enabled = False      'vô hiệu hóa button first
         btnPre.Enabled = False        'vô hiệu hóa button lùi
      ElseIf lsvDanhsachsp.Items.Count = 0 Then 'còn nếu list ko có sp thì 
         btnPre.Enabled = False                 'vô hiệu hóa cả 4 button
         btnNext.Enabled = False
         btnLast.Enabled = False
         btnFirst.Enabled = False
      Else        'ngược lại enable button first và button lùi
         btnFirst.Enabled = True
         btnPre.Enabled = True
      End If
      If lsvDanhsachsp.Items(lsvDanhsachsp.Items.Count - 1).Selected = True _
         Then 'nếu đang chọn dòng cuối trong list thì
         btnLast.Enabled = False    'vô hiệu hóa button last
         btnNext.Enabled = False    'vô hiệu hóa button tiến
      Else              'ngược lại enable button last và button next
         btnLast.Enabled = True
         btnNext.Enabled = True
      End If

      'lấy số thứ tự dòng đang chọn hiển thị lên label
      For so As Integer = 0 To lsvDanhsachsp.Items.Count - 1
         If lsvDanhsachsp.Items(so).Selected = True Then
            lblSttResult.Text = so + 1
         End If
      Next

   End Sub

   'sự kiện button lùi chọn dòng sản phẩm phía trước sản phẩm đang chọn
   Private Sub btnPre_Click(ByVal sender As System.Object, _
                            ByVal e As System.EventArgs) Handles btnPre.Click
      Dim varstt As Integer
      If lsvDanhsachsp.Items.Count > 0 Then  'kiểm tra list ko trống thì mới thực hiện
         For varstt = 0 To lsvDanhsachsp.Items.Count - 1
            If lsvDanhsachsp.Items(varstt).Selected = True Then
               If varstt <> 0 Then
                  lsvDanhsachsp.Items(varstt - 1).Selected = True
               End If
               Exit For
            End If
         Next
      End If

   End Sub

   'sự kiện button tiến chọn dòng sản phẩm tiếp theo trong listview
   Private Sub btnNext_Click(ByVal sender As System.Object, _
                             ByVal e As System.EventArgs) Handles btnNext.Click
      Dim varstt As Integer
      If lsvDanhsachsp.Items.Count > 0 Then
         For varstt = 0 To lsvDanhsachsp.Items.Count - 1
            If lsvDanhsachsp.Items(varstt).Selected = True Then
               If varstt <> lsvDanhsachsp.Items.Count - 1 Then
                  lsvDanhsachsp.Items(varstt + 1).Selected = True
               End If
               Exit For
            End If
         Next
      End If
   End Sub

   Sub danhsach(ByVal i As Integer)
      Dim strsanpham As sanpham = dssp(i)
      cbbMasp.Text = strsanpham.strmasp
      lblTenspResult.Text = strsanpham.strtensp
      lblHangsxResult.Text = strsanpham.strhangsx
      lblGiabanResult.Text = strsanpham.vargiaban
      lblSoluongResult.Text = strsanpham.varsoluong
      ptbHinhsp.ImageLocation = strsanpham.pictures

   End Sub
   Public Structure sanpham
      Dim strmasp As String
      Dim strtensp As String
      Dim strhangsx As String
      Dim vargiaban As Decimal
      Dim varsoluong As Integer
      Dim strdvt As String
      Dim pictures As String
   End Structure
   Public Shared dssp As New List(Of sanpham)

   'sự kiện click button first chọn dòng sản phẩm đầu tiên trong listview
   Private Sub btnFirst_Click(ByVal sender As System.Object, _
                              ByVal e As System.EventArgs) Handles btnFirst.Click
      If lsvDanhsachsp.Items.Count > 0 Then ' nếu listview có tòn tại dữ liệu thì mới thực hiện
         lsvDanhsachsp.Items(lsvDanhsachsp.Items.Count - lsvDanhsachsp.Items.Count).Selected = True
         lblSttResult.Text = 1
      Else        'nếu listview trống thì label số trang = 0
         lblSttResult.Text = 0

      End If

   End Sub

   'sự kiện button last chọn dòng sản phẩm cuối cùng trong listview
   Private Sub btnLast_Click(ByVal sender As System.Object, _
                             ByVal e As System.EventArgs) Handles btnLast.Click
      If lsvDanhsachsp.Items.Count > 0 Then
         lsvDanhsachsp.Items(lsvDanhsachsp.Items.Count - 1).Selected = True
         lblSttResult.Text = lsvDanhsachsp.Items.Count
      Else
         lblSttResult.Text = 0
      End If

   End Sub

End Class