Public Class khachhang
    Private _DBAccess As New DataBaseAccess
    'khai bao bien de biet duoc trang thai Edit hay insert 
    Private _isEdit As Boolean = False
    Public Sub New(isEdit As Boolean)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        _isEdit = isEdit
    End Sub

    'dinh nghia ham them ban ghi khach hàng vao database
    Private Function insertkhachhang()
        Dim splQuery As String = "INSERT INTO [dbo].[KhachHang] ([MaKH],[TenKH],[Diachi],[SDT],[GioiTinh])"
        splQuery += String.Format("VALUES ('{0}','{1}','{2}','{3}','{4}')", txtmakh.Text, txttenkh.Text, txtdiachi.Text, txtsdt.Text, txtgioitinh.Text)
        Return _DBAccess.ExecuteNoneQuery(splQuery)

    End Function

    'dinh nghia ham update
    Private Function updatekhachhang() As Boolean
        Dim sqlQuery As String = String.Format("UPDATE [dbo].[KhachHang] SET TenKH = '{0}',Diachi = '{1}', SDT = '{2}',GioiTinh = '{3}' WHERE MaKH = '{4}'", _
                                               Me.txttenkh.Text, Me.txtdiachi.Text, Me.txtsdt.Text, Me.txtgioitinh.Text, Me.txtmakh.Text)
        Return _DBAccess.ExecuteNoneQuery(sqlQuery)

    End Function
    'DINH nghia ham kiem tra giá tri truoc khi insert vao database
    Private Function IsEmpty() As Boolean
        Return (String.IsNullOrEmpty(txtmakh.Text) OrElse String.IsNullOrEmpty(txttenkh.Text) OrElse String.IsNullOrEmpty(txtdiachi.Text) OrElse _
                String.IsNullOrEmpty(txtsdt.Text) OrElse String.IsNullOrEmpty(txtgioitinh.Text))
    End Function

    Private Sub btnok_Click(sender As Object, e As EventArgs) Handles btnok.Click
        If IsEmpty() Then 'kiem tra du lieu truoc khi thuc hien them, sua , xoa
            MessageBox.Show("Nhap gia tri vào trước khi ghi vao Database ", "Error", MessageBoxButtons.OK)
        Else
            If _isEdit Then 'Neu nhu la Edit thi goi ham update 
                If updatekhachhang() Then
                    MessageBox.Show("Sua du lieu thanh cong !", "Thong bao", MessageBoxButtons.OK)
                    Me.DialogResult() = Windows.Forms.DialogResult.OK
                Else 'neu loi
                    MessageBox.Show("Sua du lieu khong thanh cong !", "Error", MessageBoxButtons.OK)
                    Me.DialogResult() = Windows.Forms.DialogResult.No
                End If

            Else 'neu khong phai thi goi ham insert
            
            If insertkhachhang() Then 'thong bao khi insert du lieu thanh cong
                    MessageBox.Show("Thêm giữ liệu thành công !", "thông báo", MessageBoxButtons.OK)
                Me.DialogResult() = Windows.Forms.DialogResult.OK

            Else 'thong bao khi insert du lieu khong thanh cong
                MessageBox.Show("Thêm giữ liệu không thành công", "Error", MessageBoxButtons.OK)
                Me.DialogResult() = Windows.Forms.DialogResult.No
                End If
            End If
            Me.Close()
        End If
    End Sub

    Private Sub btncancel_Click(sender As Object, e As EventArgs) Handles btncancel.Click
        Me.Close()
    End Sub


End Class