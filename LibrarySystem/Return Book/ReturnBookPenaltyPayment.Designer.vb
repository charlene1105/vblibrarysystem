<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReturnBookPenaltyPayment
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
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.lblRBChange = New LibrarySystem.FlatLabel()
        Me.lblRBPayment = New LibrarySystem.FlatLabel()
        Me.lblRBTotalAmt = New LibrarySystem.FlatLabel()
        Me.lblRBBorrower = New LibrarySystem.FlatLabel()
        Me.lblRBDueDate = New LibrarySystem.FlatLabel()
        Me.lblRBReturnDate = New LibrarySystem.FlatLabel()
        Me.lblRBTransactionNo = New LibrarySystem.FlatLabel()
        Me.FlatLabel6 = New LibrarySystem.FlatLabel()
        Me.FlatLabel5 = New LibrarySystem.FlatLabel()
        Me.FlatLabel4 = New LibrarySystem.FlatLabel()
        Me.FlatLabel3 = New LibrarySystem.FlatLabel()
        Me.FlatLabel2 = New LibrarySystem.FlatLabel()
        Me.FlatLabel1 = New LibrarySystem.FlatLabel()
        Me.FlatLabel10 = New LibrarySystem.FlatLabel()
        Me.lstvwReturnBookList = New System.Windows.Forms.ListView()
        Me.FormSkin1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FormSkin1
        '
        Me.FormSkin1.BackColor = System.Drawing.Color.White
        Me.FormSkin1.BaseColor = System.Drawing.Color.White
        Me.FormSkin1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.FormSkin1.Controls.Add(Me.lstvwReturnBookList)
        Me.FormSkin1.Controls.Add(Me.PictureBox2)
        Me.FormSkin1.Controls.Add(Me.lblRBChange)
        Me.FormSkin1.Controls.Add(Me.lblRBPayment)
        Me.FormSkin1.Controls.Add(Me.lblRBTotalAmt)
        Me.FormSkin1.Controls.Add(Me.lblRBBorrower)
        Me.FormSkin1.Controls.Add(Me.lblRBDueDate)
        Me.FormSkin1.Controls.Add(Me.lblRBReturnDate)
        Me.FormSkin1.Controls.Add(Me.lblRBTransactionNo)
        Me.FormSkin1.Controls.Add(Me.FlatLabel6)
        Me.FormSkin1.Controls.Add(Me.FlatLabel5)
        Me.FormSkin1.Controls.Add(Me.FlatLabel4)
        Me.FormSkin1.Controls.Add(Me.FlatLabel3)
        Me.FormSkin1.Controls.Add(Me.FlatLabel2)
        Me.FormSkin1.Controls.Add(Me.FlatLabel1)
        Me.FormSkin1.Controls.Add(Me.FlatLabel10)
        Me.FormSkin1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FormSkin1.FlatColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.FormSkin1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.FormSkin1.HeaderColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.FormSkin1.HeaderMaximize = False
        Me.FormSkin1.Location = New System.Drawing.Point(0, 0)
        Me.FormSkin1.Name = "FormSkin1"
        Me.FormSkin1.Size = New System.Drawing.Size(430, 501)
        Me.FormSkin1.TabIndex = 0
        Me.FormSkin1.Text = "FormSkin1"
        '
        'PictureBox2
        '
        Me.PictureBox2.ErrorImage = Nothing
        Me.PictureBox2.Image = Global.LibrarySystem.My.Resources.Resources.btnFormClose
        Me.PictureBox2.Location = New System.Drawing.Point(400, 12)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(18, 18)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox2.TabIndex = 124
        Me.PictureBox2.TabStop = False
        '
        'lblRBChange
        '
        Me.lblRBChange.AutoSize = True
        Me.lblRBChange.BackColor = System.Drawing.Color.Transparent
        Me.lblRBChange.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRBChange.ForeColor = System.Drawing.Color.MidnightBlue
        Me.lblRBChange.Location = New System.Drawing.Point(273, 464)
        Me.lblRBChange.Name = "lblRBChange"
        Me.lblRBChange.Size = New System.Drawing.Size(70, 17)
        Me.lblRBChange.TabIndex = 123
        Me.lblRBChange.Text = "Total Amt"
        '
        'lblRBPayment
        '
        Me.lblRBPayment.AutoSize = True
        Me.lblRBPayment.BackColor = System.Drawing.Color.Transparent
        Me.lblRBPayment.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRBPayment.ForeColor = System.Drawing.Color.MidnightBlue
        Me.lblRBPayment.Location = New System.Drawing.Point(273, 439)
        Me.lblRBPayment.Name = "lblRBPayment"
        Me.lblRBPayment.Size = New System.Drawing.Size(70, 17)
        Me.lblRBPayment.TabIndex = 122
        Me.lblRBPayment.Text = "Total Amt"
        '
        'lblRBTotalAmt
        '
        Me.lblRBTotalAmt.AutoSize = True
        Me.lblRBTotalAmt.BackColor = System.Drawing.Color.Transparent
        Me.lblRBTotalAmt.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRBTotalAmt.ForeColor = System.Drawing.Color.MidnightBlue
        Me.lblRBTotalAmt.Location = New System.Drawing.Point(273, 413)
        Me.lblRBTotalAmt.Name = "lblRBTotalAmt"
        Me.lblRBTotalAmt.Size = New System.Drawing.Size(70, 17)
        Me.lblRBTotalAmt.TabIndex = 121
        Me.lblRBTotalAmt.Text = "Total Amt"
        '
        'lblRBBorrower
        '
        Me.lblRBBorrower.AutoSize = True
        Me.lblRBBorrower.BackColor = System.Drawing.Color.Transparent
        Me.lblRBBorrower.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRBBorrower.ForeColor = System.Drawing.Color.MidnightBlue
        Me.lblRBBorrower.Location = New System.Drawing.Point(193, 162)
        Me.lblRBBorrower.Name = "lblRBBorrower"
        Me.lblRBBorrower.Size = New System.Drawing.Size(98, 17)
        Me.lblRBBorrower.TabIndex = 120
        Me.lblRBBorrower.Text = "TransactionNo"
        '
        'lblRBDueDate
        '
        Me.lblRBDueDate.AutoSize = True
        Me.lblRBDueDate.BackColor = System.Drawing.Color.Transparent
        Me.lblRBDueDate.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRBDueDate.ForeColor = System.Drawing.Color.MidnightBlue
        Me.lblRBDueDate.Location = New System.Drawing.Point(193, 86)
        Me.lblRBDueDate.Name = "lblRBDueDate"
        Me.lblRBDueDate.Size = New System.Drawing.Size(98, 17)
        Me.lblRBDueDate.TabIndex = 119
        Me.lblRBDueDate.Text = "TransactionNo"
        '
        'lblRBReturnDate
        '
        Me.lblRBReturnDate.AutoSize = True
        Me.lblRBReturnDate.BackColor = System.Drawing.Color.Transparent
        Me.lblRBReturnDate.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRBReturnDate.ForeColor = System.Drawing.Color.MidnightBlue
        Me.lblRBReturnDate.Location = New System.Drawing.Point(193, 107)
        Me.lblRBReturnDate.Name = "lblRBReturnDate"
        Me.lblRBReturnDate.Size = New System.Drawing.Size(98, 17)
        Me.lblRBReturnDate.TabIndex = 118
        Me.lblRBReturnDate.Text = "TransactionNo"
        '
        'lblRBTransactionNo
        '
        Me.lblRBTransactionNo.AutoSize = True
        Me.lblRBTransactionNo.BackColor = System.Drawing.Color.Transparent
        Me.lblRBTransactionNo.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRBTransactionNo.ForeColor = System.Drawing.Color.MidnightBlue
        Me.lblRBTransactionNo.Location = New System.Drawing.Point(193, 65)
        Me.lblRBTransactionNo.Name = "lblRBTransactionNo"
        Me.lblRBTransactionNo.Size = New System.Drawing.Size(98, 17)
        Me.lblRBTransactionNo.TabIndex = 117
        Me.lblRBTransactionNo.Text = "TransactionNo"
        '
        'FlatLabel6
        '
        Me.FlatLabel6.AutoSize = True
        Me.FlatLabel6.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel6.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FlatLabel6.ForeColor = System.Drawing.Color.MidnightBlue
        Me.FlatLabel6.Location = New System.Drawing.Point(42, 162)
        Me.FlatLabel6.Name = "FlatLabel6"
        Me.FlatLabel6.Size = New System.Drawing.Size(121, 17)
        Me.FlatLabel6.TabIndex = 116
        Me.FlatLabel6.Text = "Name of Borrower"
        '
        'FlatLabel5
        '
        Me.FlatLabel5.AutoSize = True
        Me.FlatLabel5.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel5.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FlatLabel5.ForeColor = System.Drawing.Color.MidnightBlue
        Me.FlatLabel5.Location = New System.Drawing.Point(188, 464)
        Me.FlatLabel5.Name = "FlatLabel5"
        Me.FlatLabel5.Size = New System.Drawing.Size(54, 17)
        Me.FlatLabel5.TabIndex = 115
        Me.FlatLabel5.Text = "Change"
        '
        'FlatLabel4
        '
        Me.FlatLabel4.AutoSize = True
        Me.FlatLabel4.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel4.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FlatLabel4.ForeColor = System.Drawing.Color.MidnightBlue
        Me.FlatLabel4.Location = New System.Drawing.Point(188, 439)
        Me.FlatLabel4.Name = "FlatLabel4"
        Me.FlatLabel4.Size = New System.Drawing.Size(62, 17)
        Me.FlatLabel4.TabIndex = 114
        Me.FlatLabel4.Text = "Payment"
        '
        'FlatLabel3
        '
        Me.FlatLabel3.AutoSize = True
        Me.FlatLabel3.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FlatLabel3.ForeColor = System.Drawing.Color.MidnightBlue
        Me.FlatLabel3.Location = New System.Drawing.Point(188, 413)
        Me.FlatLabel3.Name = "FlatLabel3"
        Me.FlatLabel3.Size = New System.Drawing.Size(54, 17)
        Me.FlatLabel3.TabIndex = 113
        Me.FlatLabel3.Text = "Penalty"
        '
        'FlatLabel2
        '
        Me.FlatLabel2.AutoSize = True
        Me.FlatLabel2.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FlatLabel2.ForeColor = System.Drawing.Color.MidnightBlue
        Me.FlatLabel2.Location = New System.Drawing.Point(42, 107)
        Me.FlatLabel2.Name = "FlatLabel2"
        Me.FlatLabel2.Size = New System.Drawing.Size(82, 17)
        Me.FlatLabel2.TabIndex = 112
        Me.FlatLabel2.Text = "Return Date"
        '
        'FlatLabel1
        '
        Me.FlatLabel1.AutoSize = True
        Me.FlatLabel1.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FlatLabel1.ForeColor = System.Drawing.Color.MidnightBlue
        Me.FlatLabel1.Location = New System.Drawing.Point(42, 86)
        Me.FlatLabel1.Name = "FlatLabel1"
        Me.FlatLabel1.Size = New System.Drawing.Size(66, 17)
        Me.FlatLabel1.TabIndex = 111
        Me.FlatLabel1.Text = "Due Date"
        '
        'FlatLabel10
        '
        Me.FlatLabel10.AutoSize = True
        Me.FlatLabel10.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel10.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FlatLabel10.ForeColor = System.Drawing.Color.MidnightBlue
        Me.FlatLabel10.Location = New System.Drawing.Point(42, 65)
        Me.FlatLabel10.Name = "FlatLabel10"
        Me.FlatLabel10.Size = New System.Drawing.Size(98, 17)
        Me.FlatLabel10.TabIndex = 110
        Me.FlatLabel10.Text = "TransactionNo"
        '
        'lstvwReturnBookList
        '
        Me.lstvwReturnBookList.GridLines = True
        Me.lstvwReturnBookList.Location = New System.Drawing.Point(12, 202)
        Me.lstvwReturnBookList.Name = "lstvwReturnBookList"
        Me.lstvwReturnBookList.Size = New System.Drawing.Size(406, 195)
        Me.lstvwReturnBookList.TabIndex = 125
        Me.lstvwReturnBookList.UseCompatibleStateImageBehavior = False
        '
        'ReturnBookPenaltyPayment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(430, 501)
        Me.Controls.Add(Me.FormSkin1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ReturnBookPenaltyPayment"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ReturnBookPenaltyPayment"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.FormSkin1.ResumeLayout(False)
        Me.FormSkin1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents FormSkin1 As LibrarySystem.FormSkin
    Friend WithEvents lblRBChange As LibrarySystem.FlatLabel
    Friend WithEvents lblRBPayment As LibrarySystem.FlatLabel
    Friend WithEvents lblRBTotalAmt As LibrarySystem.FlatLabel
    Friend WithEvents lblRBBorrower As LibrarySystem.FlatLabel
    Friend WithEvents lblRBDueDate As LibrarySystem.FlatLabel
    Friend WithEvents lblRBReturnDate As LibrarySystem.FlatLabel
    Friend WithEvents lblRBTransactionNo As LibrarySystem.FlatLabel
    Friend WithEvents FlatLabel6 As LibrarySystem.FlatLabel
    Friend WithEvents FlatLabel5 As LibrarySystem.FlatLabel
    Friend WithEvents FlatLabel4 As LibrarySystem.FlatLabel
    Friend WithEvents FlatLabel3 As LibrarySystem.FlatLabel
    Friend WithEvents FlatLabel2 As LibrarySystem.FlatLabel
    Friend WithEvents FlatLabel1 As LibrarySystem.FlatLabel
    Friend WithEvents FlatLabel10 As LibrarySystem.FlatLabel
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents lstvwReturnBookList As System.Windows.Forms.ListView
End Class
