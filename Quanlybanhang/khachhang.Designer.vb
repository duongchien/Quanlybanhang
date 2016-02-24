<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class khachhang
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtmakh = New System.Windows.Forms.TextBox()
        Me.txttenkh = New System.Windows.Forms.TextBox()
        Me.txtdiachi = New System.Windows.Forms.TextBox()
        Me.txtsdt = New System.Windows.Forms.TextBox()
        Me.btnok = New System.Windows.Forms.Button()
        Me.btncancel = New System.Windows.Forms.Button()
        Me.lblgioitinh = New System.Windows.Forms.Label()
        Me.txtgioitinh = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Mã khách hàng :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(21, 76)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Tên KH :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(21, 117)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Địa Chỉ :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(21, 157)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(35, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "SĐT :"
        '
        'txtmakh
        '
        Me.txtmakh.Location = New System.Drawing.Point(110, 37)
        Me.txtmakh.Name = "txtmakh"
        Me.txtmakh.Size = New System.Drawing.Size(256, 20)
        Me.txtmakh.TabIndex = 1
        '
        'txttenkh
        '
        Me.txttenkh.Location = New System.Drawing.Point(110, 73)
        Me.txttenkh.Name = "txttenkh"
        Me.txttenkh.Size = New System.Drawing.Size(256, 20)
        Me.txttenkh.TabIndex = 1
        '
        'txtdiachi
        '
        Me.txtdiachi.Location = New System.Drawing.Point(110, 114)
        Me.txtdiachi.Name = "txtdiachi"
        Me.txtdiachi.Size = New System.Drawing.Size(256, 20)
        Me.txtdiachi.TabIndex = 1
        '
        'txtsdt
        '
        Me.txtsdt.Location = New System.Drawing.Point(110, 154)
        Me.txtsdt.Name = "txtsdt"
        Me.txtsdt.Size = New System.Drawing.Size(256, 20)
        Me.txtsdt.TabIndex = 1
        '
        'btnok
        '
        Me.btnok.Location = New System.Drawing.Point(86, 239)
        Me.btnok.Name = "btnok"
        Me.btnok.Size = New System.Drawing.Size(101, 32)
        Me.btnok.TabIndex = 2
        Me.btnok.Text = "&OK"
        Me.btnok.UseVisualStyleBackColor = True
        '
        'btncancel
        '
        Me.btncancel.Location = New System.Drawing.Point(223, 239)
        Me.btncancel.Name = "btncancel"
        Me.btncancel.Size = New System.Drawing.Size(101, 32)
        Me.btncancel.TabIndex = 2
        Me.btncancel.Text = "&Cencel"
        Me.btncancel.UseVisualStyleBackColor = True
        '
        'lblgioitinh
        '
        Me.lblgioitinh.AutoSize = True
        Me.lblgioitinh.Location = New System.Drawing.Point(21, 194)
        Me.lblgioitinh.Name = "lblgioitinh"
        Me.lblgioitinh.Size = New System.Drawing.Size(50, 13)
        Me.lblgioitinh.TabIndex = 0
        Me.lblgioitinh.Text = "Giới tính:"
        '
        'txtgioitinh
        '
        Me.txtgioitinh.Location = New System.Drawing.Point(110, 191)
        Me.txtgioitinh.Name = "txtgioitinh"
        Me.txtgioitinh.Size = New System.Drawing.Size(256, 20)
        Me.txtgioitinh.TabIndex = 1
        '
        'khachhang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(441, 283)
        Me.Controls.Add(Me.btncancel)
        Me.Controls.Add(Me.btnok)
        Me.Controls.Add(Me.txtgioitinh)
        Me.Controls.Add(Me.txtsdt)
        Me.Controls.Add(Me.txtdiachi)
        Me.Controls.Add(Me.txttenkh)
        Me.Controls.Add(Me.txtmakh)
        Me.Controls.Add(Me.lblgioitinh)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "khachhang"
        Me.Text = "Khách hàng"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtmakh As System.Windows.Forms.TextBox
    Friend WithEvents txttenkh As System.Windows.Forms.TextBox
    Friend WithEvents txtdiachi As System.Windows.Forms.TextBox
    Friend WithEvents txtsdt As System.Windows.Forms.TextBox
    Friend WithEvents btnok As System.Windows.Forms.Button
    Friend WithEvents btncancel As System.Windows.Forms.Button
    Friend WithEvents lblgioitinh As System.Windows.Forms.Label
    Friend WithEvents txtgioitinh As System.Windows.Forms.TextBox
End Class
