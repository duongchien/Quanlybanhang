
Public Class Quanlybanhang
    Private _DBAccess As New DataBaseAccess

    'dinh nghia thu tuc load du lieu tu bang khach hang vào Gridview
    Private Sub loadDataOnGridview()
        Dim sqlQuery As String = ("SELECT * FROM [dbo].[KhachHang]")
        Dim dTable As DataTable = _DBAccess.GetDataTable(sqlQuery)
        Me.dgv1.DataSource = dTable

    End Sub
    'dinh nghia thu tuc cho phan search du lieu
    Private Sub Search(value As String)
        Dim sqlQuery As String = ("SELECT * FROM [dbo].[KhachHang] ")
        If Me.cmbsearch.SelectedIndex = 0 Then
            ' tim theo ma
            sqlQuery += String.Format("where MaKH like '%{0}%'", value)
        ElseIf Me.cmbsearch.SelectedIndex = 1 Then
            'tim theo ten
            sqlQuery += String.Format("where TenKH like '%{0}%'", value)
        End If
        Dim dTable As DataTable = _DBAccess.GetDataTable(sqlQuery)
        Me.dgv1.DataSource = dTable
    End Sub


    Private Sub Quanlybanhang_Load_1(sender As Object, e As EventArgs) Handles MyBase.Load
        loadDataOnGridview()
    End Sub


    Private Sub txtsearch_TextChanged(sender As Object, e As EventArgs) Handles txtsearch.TextChanged
        Search(Me.txtsearch.Text)
    End Sub

    Private Sub btnadd_Click(sender As Object, e As EventArgs) Handles btnadd.Click
        Dim frm As New khachhang(False)
        frm.ShowDialog()
        If frm.DialogResult() = Windows.Forms.DialogResult.OK Then
            'load du lieu
            loadDataOnGridview()
        End If
    End Sub
    'them khach hang
    Private Sub btnedit_Click(sender As Object, e As EventArgs) Handles btnedit.Click
        Dim frm As New khachhang(True)
        With Me.dgv1
            frm.txtmakh.Text = .Rows(.CurrentCell.RowIndex).Cells("MaKH").Value
            frm.txttenkh.Text = .Rows(.CurrentCell.RowIndex).Cells("TenKH").Value
            frm.txtdiachi.Text = .Rows(.CurrentCell.RowIndex).Cells("Diachi").Value
            frm.txtsdt.Text = .Rows(.CurrentCell.RowIndex).Cells("SDT").Value
            frm.txtgioitinh.Text = .Rows(.CurrentCell.RowIndex).Cells("GioiTinh").Value
        End With
        frm.ShowDialog()
        'sua du lieu thanh cong va load lai du lieu vao Gridview
        If frm.DialogResult = Windows.Forms.DialogResult.OK Then
            loadDataOnGridview()
        End If
    End Sub

    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click
        'khai báo bien lay ma khach hang cua dong can xóa tren Datagridview 
        Dim makh As String = Me.dgv1.Rows(Me.dgv1.CurrentCell.RowIndex).Cells("MaKH").Value
        'khai bao cau lẹn Query de xoa
        Dim sqlQuery As String = String.Format("DELETE KhachHang WHERE MaKH = '{0}'", makh)
        If _DBAccess.ExecuteNoneQuery(sqlQuery) Then ' Neu xoa thanh cong thi thong bao
            MessageBox.Show("Xóa thành công !", "Thông báo", MessageBoxButtons.OK)
            'Load du lieu tren DataGridview
            loadDataOnGridview()
        Else ' lỗi thì thông báo
            MessageBox.Show("Xóa không thành công !", "Error", MessageBoxButtons.OK)
            'Load du lieu tren DataGridview
            loadDataOnGridview()
        End If
    End Sub
End Class
