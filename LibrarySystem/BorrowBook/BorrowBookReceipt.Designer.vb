<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BorrowBookReceipt
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
        Me.FormSkin1 = New LibrarySystem.FormSkin()
        Me.lblBRChange = New LibrarySystem.FlatLabel()
        Me.lblBRPayment = New LibrarySystem.FlatLabel()
        Me.lblBRTotalAmt = New LibrarySystem.FlatLabel()
        Me.lblBRBorrower = New LibrarySystem.FlatLabel()
        Me.lblBRDueDate = New LibrarySystem.FlatLabel()
        Me.lblBRBorrowedDate = New LibrarySystem.FlatLabel()
        Me.lblBRTransactionNo = New LibrarySystem.FlatLabel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.FlatLabel6 = New LibrarySystem.FlatLabel()
        Me.FlatLabel5 = New LibrarySystem.FlatLabel()
        Me.FlatLabel4 = New LibrarySystem.FlatLabel()
        Me.FlatLabel3 = New LibrarySystem.FlatLabel()
        Me.FlatLabel2 = New LibrarySystem.FlatLabel()
        Me.FlatLabel1 = New LibrarySystem.FlatLabel()
        Me.FlatLabel10 = New LibrarySystem.FlatLabel()
        Me.lstvwBorrowBookList = New System.Windows.Forms.ListView()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.FormSkin1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FormSkin1
        '
        Me.FormSkin1.BackColor = System.Drawing.Color.White
        Me.FormSkin1.BaseColor = System.Drawing.Color.White
        Me.FormSkin1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.FormSkin1.Controls.Add(Me.lblBRChange)
        Me.FormSkin1.Controls.Add(Me.lblBRPayment)
        Me.FormSkin1.Controls.Add(Me.lblBRTotalAmt)
        Me.FormSkin1.Controls.Add(Me.lblBRBorrower)
        Me.FormSkin1.Controls.Add(Me.lblBRDueDate)
        Me.FormSkin1.Controls.Add(Me.lblBRBorrowedDate)
        Me.FormSkin1.Controls.Add(Me.lblBRTransactionNo)
        Me.FormSkin1.Controls.Add(Me.PictureBox2)
        Me.FormSkin1.Controls.Add(Me.FlatLabel6)
        Me.FormSkin1.Controls.Add(Me.FlatLabel5)
        Me.FormSkin1.Controls.Add(Me.FlatLabel4)
        Me.FormSkin1.Controls.Add(Me.FlatLabel3)
        Me.FormSkin1.Controls.Add(Me.FlatLabel2)
        Me.FormSkin1.Controls.Add(Me.FlatLabel1)
        Me.FormSkin1.Controls.Add(Me.FlatLabel10)
        Me.FormSkin1.Controls.Add(Me.lstvwBorrowBookList)
        Me.FormSkin1.Controls.Add(Me.PictureBox1)
        Me.FormSkin1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FormSkin1.FlatColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.FormSkin1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormSkin1.HeaderColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.FormSkin1.HeaderMaximize = False
        Me.FormSkin1.Location = New System.Drawing.Point(0, 0)
        Me.FormSkin1.Name = "FormSkin1"
        Me.FormSkin1.Size = New System.Drawing.Size(424, 530)
        Me.FormSkin1.TabIndex = 3
        Me.FormSkin1.Text = "Borrow Book Receipt"
        '
        'lblBRChange
        '
        Me.lblBRChange.AutoSize = True
        Me.lblBRChange.BackColor = System.Drawing.Color.Transparent
        Me.lblBRChange.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBRChange.ForeColor = System.Drawing.Color.MidnightBlue
        Me.lblBRChange.Location = New System.Drawing.Point(268, 469)
        Me.lblBRChange.Name = "lblBRChange"
        Me.lblBRChange.Size = New System.Drawing.Size(70, 17)
        Me.lblBRChange.TabIndex = 108
        Me.lblBRChange.Text = "Total Amt"
        '
        'lblBRPayment
        '
        Me.lblBRPayment.AutoSize = True
        Me.lblBRPayment.BackColor = System.Drawing.Color.Transparent
        Me.lblBRPayment.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBRPayment.ForeColor = System.Drawing.Color.MidnightBlue
        Me.lblBRPayment.Location = New System.Drawing.Point(268, 444)
        Me.lblBRPayment.Name = "lblBRPayment"
        Me.lblBRPayment.Size = New System.Drawing.Size(70, 17)
        Me.lblBRPayment.TabIndex = 107
        Me.lblBRPayment.Text = "Total Amt"
        '
        'lblBRTotalAmt
        '
        Me.lblBRTotalAmt.AutoSize = True
        Me.lblBRTotalAmt.BackColor = System.Drawing.Color.Transparent
        Me.lblBRTotalAmt.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBRTotalAmt.ForeColor = System.Drawing.Color.MidnightBlue
        Me.lblBRTotalAmt.Location = New System.Drawing.Point(268, 418)
        Me.lblBRTotalAmt.Name = "lblBRTotalAmt"
        Me.lblBRTotalAmt.Size = New System.Drawing.Size(70, 17)
        Me.lblBRTotalAmt.TabIndex = 106
        Me.lblBRTotalAmt.Text = "Total Amt"
        '
        'lblBRBorrower
        '
        Me.lblBRBorrower.AutoSize = True
        Me.lblBRBorrower.BackColor = System.Drawing.Color.Transparent
        Me.lblBRBorrower.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBRBorrower.ForeColor = System.Drawing.Color.MidnightBlue
        Me.lblBRBorrower.Location = New System.Drawing.Point(188, 142)
        Me.lblBRBorrower.Name = "lblBRBorrower"
        Me.lblBRBorrower.Size = New System.Drawing.Size(98, 17)
        Me.lblBRBorrower.TabIndex = 105
        Me.lblBRBorrower.Text = "TransactionNo"
        '
        'lblBRDueDate
        '
        Me.lblBRDueDate.AutoSize = True
        Me.lblBRDueDate.BackColor = System.Drawing.Color.Transparent
        Me.lblBRDueDate.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBRDueDate.ForeColor = System.Drawing.Color.MidnightBlue
        Me.lblBRDueDate.Location = New System.Drawing.Point(188, 114)
        Me.lblBRDueDate.Name = "lblBRDueDate"
        Me.lblBRDueDate.Size = New System.Drawing.Size(98, 17)
        Me.lblBRDueDate.TabIndex = 104
        Me.lblBRDueDate.Text = "TransactionNo"
        '
        'lblBRBorrowedDate
        '
        Me.lblBRBorrowedDate.AutoSize = True
        Me.lblBRBorrowedDate.BackColor = System.Drawing.Color.Transparent
        Me.lblBRBorrowedDate.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBRBorrowedDate.ForeColor = System.Drawing.Color.MidnightBlue
        Me.lblBRBorrowedDate.Location = New System.Drawing.Point(188, 92)
        Me.lblBRBorrowedDate.Name = "lblBRBorrowedDate"
        Me.lblBRBorrowedDate.Size = New System.Drawing.Size(98, 17)
        Me.lblBRBorrowedDate.TabIndex = 103
        Me.lblBRBorrowedDate.Text = "TransactionNo"
        '
        'lblBRTransactionNo
        '
        Me.lblBRTransactionNo.AutoSize = True
        Me.lblBRTransactionNo.BackColor = System.Drawing.Color.Transparent
        Me.lblBRTransactionNo.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBRTransactionNo.ForeColor = System.Drawing.Color.MidnightBlue
        Me.lblBRTransactionNo.Location = New System.Drawing.Point(188, 70)
        Me.lblBRTransactionNo.Name = "lblBRTransactionNo"
        Me.lblBRTransactionNo.Size = New System.Drawing.Size(98, 17)
        Me.lblBRTransactionNo.TabIndex = 102
        Me.lblBRTransactionNo.Text = "TransactionNo"
        '
        'PictureBox2
        '
        Me.PictureBox2.ErrorImage = Nothing
        Me.PictureBox2.Image = Global.LibrarySystem.My.Resources.Resources.btnFormClose
        Me.PictureBox2.Location = New System.Drawing.Point(395, 12)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(18, 18)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox2.TabIndex = 101
        Me.PictureBox2.TabStop = False
        '
        'FlatLabel6
        '
        Me.FlatLabel6.AutoSize = True
        Me.FlatLabel6.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel6.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FlatLabel6.ForeColor = System.Drawing.Color.MidnightBlue
        Me.FlatLabel6.Location = New System.Drawing.Point(37, 142)
        Me.FlatLabel6.Name = "FlatLabel6"
        Me.FlatLabel6.Size = New System.Drawing.Size(121, 17)
        Me.FlatLabel6.TabIndex = 100
        Me.FlatLabel6.Text = "Name of Borrower"
        '
        'FlatLabel5
        '
        Me.FlatLabel5.AutoSize = True
        Me.FlatLabel5.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel5.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FlatLabel5.ForeColor = System.Drawing.Color.MidnightBlue
        Me.FlatLabel5.Location = New System.Drawing.Point(183, 469)
        Me.FlatLabel5.Name = "FlatLabel5"
        Me.FlatLabel5.Size = New System.Drawing.Size(54, 17)
        Me.FlatLabel5.TabIndex = 99
        Me.FlatLabel5.Text = "Change"
        '
        'FlatLabel4
        '
        Me.FlatLabel4.AutoSize = True
        Me.FlatLabel4.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel4.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FlatLabel4.ForeColor = System.Drawing.Color.MidnightBlue
        Me.FlatLabel4.Location = New System.Drawing.Point(183, 444)
        Me.FlatLabel4.Name = "FlatLabel4"
        Me.FlatLabel4.Size = New System.Drawing.Size(62, 17)
        Me.FlatLabel4.TabIndex = 98
        Me.FlatLabel4.Text = "Payment"
        '
        'FlatLabel3
        '
        Me.FlatLabel3.AutoSize = True
        Me.FlatLabel3.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FlatLabel3.ForeColor = System.Drawing.Color.MidnightBlue
        Me.FlatLabel3.Location = New System.Drawing.Point(183, 418)
        Me.FlatLabel3.Name = "FlatLabel3"
        Me.FlatLabel3.Size = New System.Drawing.Size(70, 17)
        Me.FlatLabel3.TabIndex = 97
        Me.FlatLabel3.Text = "Total Amt"
        '
        'FlatLabel2
        '
        Me.FlatLabel2.AutoSize = True
        Me.FlatLabel2.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FlatLabel2.ForeColor = System.Drawing.Color.MidnightBlue
        Me.FlatLabel2.Location = New System.Drawing.Point(37, 92)
        Me.FlatLabel2.Name = "FlatLabel2"
        Me.FlatLabel2.Size = New System.Drawing.Size(100, 17)
        Me.FlatLabel2.TabIndex = 96
        Me.FlatLabel2.Text = "Borrowed Date"
        '
        'FlatLabel1
        '
        Me.FlatLabel1.AutoSize = True
        Me.FlatLabel1.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FlatLabel1.ForeColor = System.Drawing.Color.MidnightBlue
        Me.FlatLabel1.Location = New System.Drawing.Point(37, 114)
        Me.FlatLabel1.Name = "FlatLabel1"
        Me.FlatLabel1.Size = New System.Drawing.Size(66, 17)
        Me.FlatLabel1.TabIndex = 95
        Me.FlatLabel1.Text = "Due Date"
        '
        'FlatLabel10
        '
        Me.FlatLabel10.AutoSize = True
        Me.FlatLabel10.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel10.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FlatLabel10.ForeColor = System.Drawing.Color.MidnightBlue
        Me.FlatLabel10.Location = New System.Drawing.Point(37, 70)
        Me.FlatLabel10.Name = "FlatLabel10"
        Me.FlatLabel10.Size = New System.Drawing.Size(98, 17)
        Me.FlatLabel10.TabIndex = 94
        Me.FlatLabel10.Text = "TransactionNo"
        '
        'lstvwBorrowBookList
        '
        Me.lstvwBorrowBookList.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstvwBorrowBookList.ForeColor = System.Drawing.Color.SteelBlue
        Me.lstvwBorrowBookList.GridLines = True
        Me.lstvwBorrowBookList.Location = New System.Drawing.Point(40, 172)
        Me.lstvwBorrowBookList.Name = "lstvwBorrowBookList"
        Me.lstvwBorrowBookList.Size = New System.Drawing.Size(350, 208)
        Me.lstvwBorrowBookList.TabIndex = 93
        Me.lstvwBorrowBookList.UseCompatibleStateImageBehavior = False
        '
        'PictureBox1
        '
        Me.PictureBox1.ErrorImage = Nothing
        Me.PictureBox1.Image = Global.LibrarySystem.My.Resources.Resources.btnFormClose
        Me.PictureBox1.Location = New System.Drawing.Point(485, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(18, 18)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 92
        Me.PictureBox1.TabStop = False
        '
        'BorrowBookReceipt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.ClientSize = New System.Drawing.Size(424, 530)
        Me.Controls.Add(Me.FormSkin1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "BorrowBookReceipt"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "BorrowBookPayment"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.FormSkin1.ResumeLayout(False)
        Me.FormSkin1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents FormSkin1 As LibrarySystem.FormSkin
    Friend WithEvents lstvwBorrowBookList As System.Windows.Forms.ListView
    Friend WithEvents FlatLabel2 As LibrarySystem.FlatLabel
    Friend WithEvents FlatLabel1 As LibrarySystem.FlatLabel
    Friend WithEvents FlatLabel10 As LibrarySystem.FlatLabel
    Friend WithEvents FlatLabel5 As LibrarySystem.FlatLabel
    Friend WithEvents FlatLabel4 As LibrarySystem.FlatLabel
    Friend WithEvents FlatLabel3 As LibrarySystem.FlatLabel
    Friend WithEvents FlatLabel6 As LibrarySystem.FlatLabel
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents lblBRChange As LibrarySystem.FlatLabel
    Friend WithEvents lblBRPayment As LibrarySystem.FlatLabel
    Friend WithEvents lblBRTotalAmt As LibrarySystem.FlatLabel
    Friend WithEvents lblBRBorrower As LibrarySystem.FlatLabel
    Friend WithEvents lblBRDueDate As LibrarySystem.FlatLabel
    Friend WithEvents lblBRBorrowedDate As LibrarySystem.FlatLabel
    Friend WithEvents lblBRTransactionNo As LibrarySystem.FlatLabel
End Class
