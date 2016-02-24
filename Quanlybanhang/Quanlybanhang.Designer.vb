<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Quanlybanhang
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
        Me.dgv1 = New System.Windows.Forms.DataGridView()
        Me.btnadd = New System.Windows.Forms.Button()
        Me.btnedit = New System.Windows.Forms.Button()
        Me.btndelete = New System.Windows.Forms.Button()
        Me.lblsearch = New System.Windows.Forms.Label()
        Me.txtsearch = New System.Windows.Forms.TextBox()
        Me.cmbsearch = New System.Windows.Forms.ComboBox()
        CType(Me.dgv1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgv1
        '
        Me.dgv1.AllowUserToAddRows = False
        Me.dgv1.AllowUserToDeleteRows = False
        Me.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv1.Location = New System.Drawing.Point(16, 71)
        Me.dgv1.MultiSelect = False
        Me.dgv1.Name = "dgv1"
        Me.dgv1.ReadOnly = True
        Me.dgv1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv1.Size = New System.Drawing.Size(505, 274)
        Me.dgv1.TabIndex = 0
        '
        'btnadd
        '
        Me.btnadd.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.btnadd.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnadd.Location = New System.Drawing.Point(16, 358)
        Me.btnadd.Name = "btnadd"
        Me.btnadd.Size = New System.Drawing.Size(121, 37)
        Me.btnadd.TabIndex = 1
        Me.btnadd.Text = "Add"
        Me.btnadd.UseVisualStyleBackColor = True
        '
        'btnedit
        '
        Me.btnedit.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.btnedit.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnedit.Location = New System.Drawing.Point(213, 358)
        Me.btnedit.Name = "btnedit"
        Me.btnedit.Size = New System.Drawing.Size(121, 37)
        Me.btnedit.TabIndex = 1
        Me.btnedit.Text = "Edit"
        Me.btnedit.UseVisualStyleBackColor = True
        '
        'btndelete
        '
        Me.btndelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.btndelete.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btndelete.Location = New System.Drawing.Point(400, 358)
        Me.btndelete.Name = "btndelete"
        Me.btndelete.Size = New System.Drawing.Size(121, 37)
        Me.btndelete.TabIndex = 1
        Me.btndelete.Text = "Delete"
        Me.btndelete.UseVisualStyleBackColor = True
        '
        'lblsearch
        '
        Me.lblsearch.AutoSize = True
        Me.lblsearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.lblsearch.ForeColor = System.Drawing.Color.Red
        Me.lblsearch.Location = New System.Drawing.Point(12, 30)
        Me.lblsearch.Name = "lblsearch"
        Me.lblsearch.Size = New System.Drawing.Size(59, 17)
        Me.lblsearch.TabIndex = 2
        Me.lblsearch.Text = "Search"
        '
        'txtsearch
        '
        Me.txtsearch.Location = New System.Drawing.Point(241, 29)
        Me.txtsearch.Name = "txtsearch"
        Me.txtsearch.Size = New System.Drawing.Size(203, 20)
        Me.txtsearch.TabIndex = 3
        '
        'cmbsearch
        '
        Me.cmbsearch.FormattingEnabled = True
        Me.cmbsearch.Items.AddRange(New Object() {"Mã KH", "Tên KH "})
        Me.cmbsearch.Location = New System.Drawing.Point(94, 29)
        Me.cmbsearch.Name = "cmbsearch"
        Me.cmbsearch.Size = New System.Drawing.Size(117, 21)
        Me.cmbsearch.TabIndex = 0
        '
        'Quanlybanhang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(543, 398)
        Me.Controls.Add(Me.cmbsearch)
        Me.Controls.Add(Me.txtsearch)
        Me.Controls.Add(Me.lblsearch)
        Me.Controls.Add(Me.btndelete)
        Me.Controls.Add(Me.btnedit)
        Me.Controls.Add(Me.btnadd)
        Me.Controls.Add(Me.dgv1)
        Me.Name = "Quanlybanhang"
        Me.Text = "Quan Ly Ban Hang"
        CType(Me.dgv1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgv1 As System.Windows.Forms.DataGridView
    Friend WithEvents btnadd As System.Windows.Forms.Button
    Friend WithEvents btnedit As System.Windows.Forms.Button
    Friend WithEvents btndelete As System.Windows.Forms.Button
    Friend WithEvents lblsearch As System.Windows.Forms.Label
    Friend WithEvents txtsearch As System.Windows.Forms.TextBox
    Friend WithEvents cmbsearch As System.Windows.Forms.ComboBox

End Class
