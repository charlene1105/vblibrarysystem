<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainMenu
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
        Me.components = New System.ComponentModel.Container()
        Me.tmrDateTime = New System.Windows.Forms.Timer(Me.components)
        Me.FormSkin1 = New LibrarySystem.FormSkin()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.FlatLabel9 = New LibrarySystem.FlatLabel()
        Me.FlatGroupBox1 = New LibrarySystem.FlatGroupBox()
        Me.lblDateNow = New LibrarySystem.FlatLabel()
        Me.lblCurrentTime = New LibrarySystem.FlatLabel()
        Me.FlatMini1 = New LibrarySystem.FlatMini()
        Me.FlatClose1 = New LibrarySystem.FlatClose()
        Me.tabGrp = New LibrarySystem.FlatTabControl()
        Me.tabHome = New System.Windows.Forms.TabPage()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.tabBookInventory = New System.Windows.Forms.TabPage()
        Me.cmbBookInventorySearch = New System.Windows.Forms.ComboBox()
        Me.txtSearchBook = New System.Windows.Forms.TextBox()
        Me.btnDeleteBook = New System.Windows.Forms.Button()
        Me.btnEditBook = New System.Windows.Forms.Button()
        Me.btnAddBook = New System.Windows.Forms.Button()
        Me.FlatLabel3 = New LibrarySystem.FlatLabel()
        Me.lstvwBookInventory = New System.Windows.Forms.ListView()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.tabBorrowBook = New System.Windows.Forms.TabPage()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.lblBTransactionNo = New LibrarySystem.FlatLabel()
        Me.lblBDueDate = New LibrarySystem.FlatLabel()
        Me.FlatLabel24 = New LibrarySystem.FlatLabel()
        Me.lblBTransactionDate = New LibrarySystem.FlatLabel()
        Me.FlatLabel19 = New LibrarySystem.FlatLabel()
        Me.FlatLabel10 = New LibrarySystem.FlatLabel()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblErrorBorrowerID = New LibrarySystem.FlatLabel()
        Me.lblBMemberName = New LibrarySystem.FlatLabel()
        Me.FlatLabel41 = New LibrarySystem.FlatLabel()
        Me.cmbBMemberID = New System.Windows.Forms.ComboBox()
        Me.FlatLabel38 = New LibrarySystem.FlatLabel()
        Me.lblErrorBNotEnough = New LibrarySystem.FlatLabel()
        Me.lblBChange = New LibrarySystem.FlatLabel()
        Me.FlatLabel36 = New LibrarySystem.FlatLabel()
        Me.txtBPayment = New System.Windows.Forms.TextBox()
        Me.FlatLabel35 = New LibrarySystem.FlatLabel()
        Me.lblBTotalAmt = New LibrarySystem.FlatLabel()
        Me.FlatLabel33 = New LibrarySystem.FlatLabel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnRemoveBooktoBList = New System.Windows.Forms.Button()
        Me.lblBNoofAvailableBook = New LibrarySystem.FlatLabel()
        Me.FlatLabel39 = New LibrarySystem.FlatLabel()
        Me.lblErrorBookID = New LibrarySystem.FlatLabel()
        Me.lblBPublisher = New LibrarySystem.FlatLabel()
        Me.FlatLabel15 = New LibrarySystem.FlatLabel()
        Me.lblBCategory = New LibrarySystem.FlatLabel()
        Me.FlatLabel17 = New LibrarySystem.FlatLabel()
        Me.lblBPublishedYear = New LibrarySystem.FlatLabel()
        Me.FlatLabel13 = New LibrarySystem.FlatLabel()
        Me.lblBAuthor = New LibrarySystem.FlatLabel()
        Me.FlatLabel11 = New LibrarySystem.FlatLabel()
        Me.lblBTitle = New LibrarySystem.FlatLabel()
        Me.FlatLabel7 = New LibrarySystem.FlatLabel()
        Me.cmbBookID = New System.Windows.Forms.ComboBox()
        Me.btnAddBooktoBList = New System.Windows.Forms.Button()
        Me.FlatLabel5 = New LibrarySystem.FlatLabel()
        Me.lstvwBorrowBookList = New System.Windows.Forms.ListView()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.btnBorrowBookReceipt = New System.Windows.Forms.Button()
        Me.tabReturnBook = New System.Windows.Forms.TabPage()
        Me.pnlPenalty = New System.Windows.Forms.Panel()
        Me.FlatLabel12 = New LibrarySystem.FlatLabel()
        Me.lblErrorRBNotEnough = New LibrarySystem.FlatLabel()
        Me.lblRBPenalty = New LibrarySystem.FlatLabel()
        Me.FlatLabel8 = New LibrarySystem.FlatLabel()
        Me.txtRBPayment = New System.Windows.Forms.TextBox()
        Me.FlatLabel4 = New LibrarySystem.FlatLabel()
        Me.lblRBChange = New LibrarySystem.FlatLabel()
        Me.lblRBReturnDate = New LibrarySystem.FlatLabel()
        Me.FlatLabel20 = New LibrarySystem.FlatLabel()
        Me.lblRBBorrower = New LibrarySystem.FlatLabel()
        Me.FlatLabel18 = New LibrarySystem.FlatLabel()
        Me.lstvwReturnBookList = New System.Windows.Forms.ListView()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.lblRBDateBorrowed = New LibrarySystem.FlatLabel()
        Me.FlatLabel16 = New LibrarySystem.FlatLabel()
        Me.lblRBDueDate = New LibrarySystem.FlatLabel()
        Me.FlatLabel26 = New LibrarySystem.FlatLabel()
        Me.btnReturnBooks = New System.Windows.Forms.Button()
        Me.cmbRBTransactionNo = New System.Windows.Forms.ComboBox()
        Me.FlatLabel6 = New LibrarySystem.FlatLabel()
        Me.tabManageMembers = New System.Windows.Forms.TabPage()
        Me.cmbSearchBy = New System.Windows.Forms.ComboBox()
        Me.txtSearchMember = New System.Windows.Forms.TextBox()
        Me.btnDeleteMember = New System.Windows.Forms.Button()
        Me.btnEditMember = New System.Windows.Forms.Button()
        Me.btnAddMember = New System.Windows.Forms.Button()
        Me.FlatLabel1 = New LibrarySystem.FlatLabel()
        Me.lstvwMemberList = New System.Windows.Forms.ListView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.tabBorrowersList = New System.Windows.Forms.TabPage()
        Me.cmbBorrowerSearch = New System.Windows.Forms.ComboBox()
        Me.txtSearchBorrower = New System.Windows.Forms.TextBox()
        Me.FlatLabel2 = New LibrarySystem.FlatLabel()
        Me.lstvwBorrowersList = New System.Windows.Forms.ListView()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.lstvwBooksBorrowed = New System.Windows.Forms.ListView()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.btnManageMembers = New System.Windows.Forms.Button()
        Me.btnReturnBook = New System.Windows.Forms.Button()
        Me.btnBorrowBook = New System.Windows.Forms.Button()
        Me.btnBookInventory = New System.Windows.Forms.Button()
        Me.btnBorrowersList = New System.Windows.Forms.Button()
        Me.FormSkin1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.FlatGroupBox1.SuspendLayout()
        Me.tabGrp.SuspendLayout()
        Me.tabHome.SuspendLayout()
        Me.tabBookInventory.SuspendLayout()
        Me.tabBorrowBook.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.tabReturnBook.SuspendLayout()
        Me.pnlPenalty.SuspendLayout()
        Me.tabManageMembers.SuspendLayout()
        Me.tabBorrowersList.SuspendLayout()
        Me.SuspendLayout()
        '
        'tmrDateTime
        '
        Me.tmrDateTime.Interval = 1000
        '
        'FormSkin1
        '
        Me.FormSkin1.BackColor = System.Drawing.Color.White
        Me.FormSkin1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.FormSkin1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.FormSkin1.Controls.Add(Me.Panel2)
        Me.FormSkin1.Controls.Add(Me.FlatGroupBox1)
        Me.FormSkin1.Controls.Add(Me.FlatMini1)
        Me.FormSkin1.Controls.Add(Me.FlatClose1)
        Me.FormSkin1.Controls.Add(Me.tabGrp)
        Me.FormSkin1.Controls.Add(Me.btnLogout)
        Me.FormSkin1.Controls.Add(Me.btnManageMembers)
        Me.FormSkin1.Controls.Add(Me.btnReturnBook)
        Me.FormSkin1.Controls.Add(Me.btnBorrowBook)
        Me.FormSkin1.Controls.Add(Me.btnBookInventory)
        Me.FormSkin1.Controls.Add(Me.btnBorrowersList)
        Me.FormSkin1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FormSkin1.FlatColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.FormSkin1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormSkin1.HeaderColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.FormSkin1.HeaderMaximize = False
        Me.FormSkin1.Location = New System.Drawing.Point(0, 0)
        Me.FormSkin1.Name = "FormSkin1"
        Me.FormSkin1.Size = New System.Drawing.Size(1366, 768)
        Me.FormSkin1.TabIndex = 0
        Me.FormSkin1.Text = "Library System"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.Panel2.Controls.Add(Me.FlatLabel9)
        Me.Panel2.Location = New System.Drawing.Point(469, 46)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(890, 49)
        Me.Panel2.TabIndex = 75
        '
        'FlatLabel9
        '
        Me.FlatLabel9.AutoSize = True
        Me.FlatLabel9.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel9.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FlatLabel9.ForeColor = System.Drawing.Color.Orange
        Me.FlatLabel9.Location = New System.Drawing.Point(325, 8)
        Me.FlatLabel9.Name = "FlatLabel9"
        Me.FlatLabel9.Size = New System.Drawing.Size(212, 32)
        Me.FlatLabel9.TabIndex = 2
        Me.FlatLabel9.Text = "LIBRARY SYSTEM"
        '
        'FlatGroupBox1
        '
        Me.FlatGroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.FlatGroupBox1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.FlatGroupBox1.Controls.Add(Me.lblDateNow)
        Me.FlatGroupBox1.Controls.Add(Me.lblCurrentTime)
        Me.FlatGroupBox1.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.FlatGroupBox1.Location = New System.Drawing.Point(23, 47)
        Me.FlatGroupBox1.Name = "FlatGroupBox1"
        Me.FlatGroupBox1.ShowText = True
        Me.FlatGroupBox1.Size = New System.Drawing.Size(417, 61)
        Me.FlatGroupBox1.TabIndex = 19
        '
        'lblDateNow
        '
        Me.lblDateNow.AutoSize = True
        Me.lblDateNow.BackColor = System.Drawing.Color.Transparent
        Me.lblDateNow.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDateNow.ForeColor = System.Drawing.Color.White
        Me.lblDateNow.Location = New System.Drawing.Point(20, 20)
        Me.lblDateNow.Name = "lblDateNow"
        Me.lblDateNow.Size = New System.Drawing.Size(88, 21)
        Me.lblDateNow.TabIndex = 1
        Me.lblDateNow.Text = "FlatLabel9"
        '
        'lblCurrentTime
        '
        Me.lblCurrentTime.AutoSize = True
        Me.lblCurrentTime.BackColor = System.Drawing.Color.Transparent
        Me.lblCurrentTime.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCurrentTime.ForeColor = System.Drawing.Color.DarkOrange
        Me.lblCurrentTime.Location = New System.Drawing.Point(173, 11)
        Me.lblCurrentTime.Name = "lblCurrentTime"
        Me.lblCurrentTime.Size = New System.Drawing.Size(130, 32)
        Me.lblCurrentTime.TabIndex = 0
        Me.lblCurrentTime.Text = "FlatLabel9"
        '
        'FlatMini1
        '
        Me.FlatMini1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FlatMini1.BackColor = System.Drawing.Color.White
        Me.FlatMini1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.FlatMini1.Font = New System.Drawing.Font("Marlett", 12.0!)
        Me.FlatMini1.Location = New System.Drawing.Point(1310, 12)
        Me.FlatMini1.Name = "FlatMini1"
        Me.FlatMini1.Size = New System.Drawing.Size(18, 18)
        Me.FlatMini1.TabIndex = 18
        Me.FlatMini1.Text = "FlatMini1"
        Me.FlatMini1.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'FlatClose1
        '
        Me.FlatClose1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FlatClose1.BackColor = System.Drawing.Color.White
        Me.FlatClose1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.FlatClose1.Font = New System.Drawing.Font("Marlett", 10.0!)
        Me.FlatClose1.Location = New System.Drawing.Point(1336, 12)
        Me.FlatClose1.Name = "FlatClose1"
        Me.FlatClose1.Size = New System.Drawing.Size(18, 18)
        Me.FlatClose1.TabIndex = 16
        Me.FlatClose1.Text = "FlatClose1"
        Me.FlatClose1.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'tabGrp
        '
        Me.tabGrp.ActiveColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.tabGrp.BaseColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.tabGrp.Controls.Add(Me.tabHome)
        Me.tabGrp.Controls.Add(Me.tabBookInventory)
        Me.tabGrp.Controls.Add(Me.tabBorrowBook)
        Me.tabGrp.Controls.Add(Me.tabReturnBook)
        Me.tabGrp.Controls.Add(Me.tabManageMembers)
        Me.tabGrp.Controls.Add(Me.tabBorrowersList)
        Me.tabGrp.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.tabGrp.ItemSize = New System.Drawing.Size(120, 40)
        Me.tabGrp.Location = New System.Drawing.Point(468, 70)
        Me.tabGrp.Name = "tabGrp"
        Me.tabGrp.SelectedIndex = 0
        Me.tabGrp.Size = New System.Drawing.Size(891, 698)
        Me.tabGrp.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
        Me.tabGrp.TabIndex = 15
        '
        'tabHome
        '
        Me.tabHome.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.tabHome.Controls.Add(Me.Button9)
        Me.tabHome.Location = New System.Drawing.Point(4, 44)
        Me.tabHome.Name = "tabHome"
        Me.tabHome.Padding = New System.Windows.Forms.Padding(3)
        Me.tabHome.Size = New System.Drawing.Size(883, 650)
        Me.tabHome.TabIndex = 6
        Me.tabHome.Text = "Home"
        '
        'Button9
        '
        Me.Button9.BackColor = System.Drawing.Color.Teal
        Me.Button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button9.Font = New System.Drawing.Font("Segoe UI", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button9.ForeColor = System.Drawing.Color.White
        Me.Button9.Location = New System.Drawing.Point(93, 161)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(709, 283)
        Me.Button9.TabIndex = 16
        Me.Button9.Text = "WELCOME TO LIBRARY SYSTEM"
        Me.Button9.UseVisualStyleBackColor = False
        '
        'tabBookInventory
        '
        Me.tabBookInventory.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.tabBookInventory.Controls.Add(Me.cmbBookInventorySearch)
        Me.tabBookInventory.Controls.Add(Me.txtSearchBook)
        Me.tabBookInventory.Controls.Add(Me.btnDeleteBook)
        Me.tabBookInventory.Controls.Add(Me.btnEditBook)
        Me.tabBookInventory.Controls.Add(Me.btnAddBook)
        Me.tabBookInventory.Controls.Add(Me.FlatLabel3)
        Me.tabBookInventory.Controls.Add(Me.lstvwBookInventory)
        Me.tabBookInventory.Controls.Add(Me.Button10)
        Me.tabBookInventory.Location = New System.Drawing.Point(4, 44)
        Me.tabBookInventory.Name = "tabBookInventory"
        Me.tabBookInventory.Padding = New System.Windows.Forms.Padding(3)
        Me.tabBookInventory.Size = New System.Drawing.Size(883, 650)
        Me.tabBookInventory.TabIndex = 1
        Me.tabBookInventory.Text = "Book Inventory"
        '
        'cmbBookInventorySearch
        '
        Me.cmbBookInventorySearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbBookInventorySearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbBookInventorySearch.FormattingEnabled = True
        Me.cmbBookInventorySearch.Items.AddRange(New Object() {"Book ID", "Title", "Publisher", "Author", "Category", "Published Year"})
        Me.cmbBookInventorySearch.Location = New System.Drawing.Point(748, 68)
        Me.cmbBookInventorySearch.Name = "cmbBookInventorySearch"
        Me.cmbBookInventorySearch.Size = New System.Drawing.Size(121, 25)
        Me.cmbBookInventorySearch.TabIndex = 41
        '
        'txtSearchBook
        '
        Me.txtSearchBook.Location = New System.Drawing.Point(595, 68)
        Me.txtSearchBook.Name = "txtSearchBook"
        Me.txtSearchBook.Size = New System.Drawing.Size(138, 25)
        Me.txtSearchBook.TabIndex = 34
        '
        'btnDeleteBook
        '
        Me.btnDeleteBook.BackColor = System.Drawing.Color.Crimson
        Me.btnDeleteBook.Enabled = False
        Me.btnDeleteBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDeleteBook.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeleteBook.ForeColor = System.Drawing.Color.White
        Me.btnDeleteBook.Location = New System.Drawing.Point(399, 40)
        Me.btnDeleteBook.Name = "btnDeleteBook"
        Me.btnDeleteBook.Size = New System.Drawing.Size(185, 61)
        Me.btnDeleteBook.TabIndex = 32
        Me.btnDeleteBook.Text = "Delete Book"
        Me.btnDeleteBook.UseVisualStyleBackColor = False
        '
        'btnEditBook
        '
        Me.btnEditBook.BackColor = System.Drawing.Color.Crimson
        Me.btnEditBook.Enabled = False
        Me.btnEditBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditBook.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditBook.ForeColor = System.Drawing.Color.White
        Me.btnEditBook.Location = New System.Drawing.Point(208, 40)
        Me.btnEditBook.Name = "btnEditBook"
        Me.btnEditBook.Size = New System.Drawing.Size(185, 61)
        Me.btnEditBook.TabIndex = 31
        Me.btnEditBook.Text = "Edit Book"
        Me.btnEditBook.UseVisualStyleBackColor = False
        '
        'btnAddBook
        '
        Me.btnAddBook.BackColor = System.Drawing.Color.Crimson
        Me.btnAddBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddBook.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddBook.ForeColor = System.Drawing.Color.White
        Me.btnAddBook.Location = New System.Drawing.Point(17, 40)
        Me.btnAddBook.Name = "btnAddBook"
        Me.btnAddBook.Size = New System.Drawing.Size(185, 61)
        Me.btnAddBook.TabIndex = 17
        Me.btnAddBook.Text = "Add New Book"
        Me.btnAddBook.UseVisualStyleBackColor = False
        '
        'FlatLabel3
        '
        Me.FlatLabel3.AutoSize = True
        Me.FlatLabel3.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel3.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FlatLabel3.ForeColor = System.Drawing.Color.White
        Me.FlatLabel3.Location = New System.Drawing.Point(590, 40)
        Me.FlatLabel3.Name = "FlatLabel3"
        Me.FlatLabel3.Size = New System.Drawing.Size(123, 25)
        Me.FlatLabel3.TabIndex = 30
        Me.FlatLabel3.Text = "Search Book"
        '
        'lstvwBookInventory
        '
        Me.lstvwBookInventory.GridLines = True
        Me.lstvwBookInventory.Location = New System.Drawing.Point(17, 156)
        Me.lstvwBookInventory.Name = "lstvwBookInventory"
        Me.lstvwBookInventory.Size = New System.Drawing.Size(852, 463)
        Me.lstvwBookInventory.TabIndex = 26
        Me.lstvwBookInventory.UseCompatibleStateImageBehavior = False
        '
        'Button10
        '
        Me.Button10.BackColor = System.Drawing.Color.Tomato
        Me.Button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button10.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button10.ForeColor = System.Drawing.Color.White
        Me.Button10.Location = New System.Drawing.Point(17, 116)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(852, 43)
        Me.Button10.TabIndex = 16
        Me.Button10.Text = "BOOK INVENTORY"
        Me.Button10.UseVisualStyleBackColor = False
        '
        'tabBorrowBook
        '
        Me.tabBorrowBook.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.tabBorrowBook.Controls.Add(Me.GroupBox3)
        Me.tabBorrowBook.Controls.Add(Me.GroupBox2)
        Me.tabBorrowBook.Controls.Add(Me.lblErrorBNotEnough)
        Me.tabBorrowBook.Controls.Add(Me.lblBChange)
        Me.tabBorrowBook.Controls.Add(Me.FlatLabel36)
        Me.tabBorrowBook.Controls.Add(Me.txtBPayment)
        Me.tabBorrowBook.Controls.Add(Me.FlatLabel35)
        Me.tabBorrowBook.Controls.Add(Me.lblBTotalAmt)
        Me.tabBorrowBook.Controls.Add(Me.FlatLabel33)
        Me.tabBorrowBook.Controls.Add(Me.GroupBox1)
        Me.tabBorrowBook.Controls.Add(Me.lstvwBorrowBookList)
        Me.tabBorrowBook.Controls.Add(Me.Button2)
        Me.tabBorrowBook.Controls.Add(Me.btnBorrowBookReceipt)
        Me.tabBorrowBook.Location = New System.Drawing.Point(4, 44)
        Me.tabBorrowBook.Name = "tabBorrowBook"
        Me.tabBorrowBook.Size = New System.Drawing.Size(883, 650)
        Me.tabBorrowBook.TabIndex = 2
        Me.tabBorrowBook.Text = "Borrow Book"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.lblBTransactionNo)
        Me.GroupBox3.Controls.Add(Me.lblBDueDate)
        Me.GroupBox3.Controls.Add(Me.FlatLabel24)
        Me.GroupBox3.Controls.Add(Me.lblBTransactionDate)
        Me.GroupBox3.Controls.Add(Me.FlatLabel19)
        Me.GroupBox3.Controls.Add(Me.FlatLabel10)
        Me.GroupBox3.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.GroupBox3.Location = New System.Drawing.Point(33, 0)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(829, 85)
        Me.GroupBox3.TabIndex = 65
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Transaction Info"
        '
        'lblBTransactionNo
        '
        Me.lblBTransactionNo.AutoSize = True
        Me.lblBTransactionNo.BackColor = System.Drawing.Color.DimGray
        Me.lblBTransactionNo.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBTransactionNo.ForeColor = System.Drawing.Color.White
        Me.lblBTransactionNo.Location = New System.Drawing.Point(149, 23)
        Me.lblBTransactionNo.Name = "lblBTransactionNo"
        Me.lblBTransactionNo.Size = New System.Drawing.Size(90, 20)
        Me.lblBTransactionNo.TabIndex = 55
        Me.lblBTransactionNo.Text = "FlatLabel31"
        '
        'lblBDueDate
        '
        Me.lblBDueDate.AutoSize = True
        Me.lblBDueDate.BackColor = System.Drawing.Color.DimGray
        Me.lblBDueDate.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBDueDate.ForeColor = System.Drawing.Color.White
        Me.lblBDueDate.Location = New System.Drawing.Point(574, 58)
        Me.lblBDueDate.Name = "lblBDueDate"
        Me.lblBDueDate.Size = New System.Drawing.Size(90, 20)
        Me.lblBDueDate.TabIndex = 54
        Me.lblBDueDate.Text = "FlatLabel23"
        '
        'FlatLabel24
        '
        Me.FlatLabel24.AutoSize = True
        Me.FlatLabel24.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel24.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FlatLabel24.ForeColor = System.Drawing.Color.White
        Me.FlatLabel24.Location = New System.Drawing.Point(392, 58)
        Me.FlatLabel24.Name = "FlatLabel24"
        Me.FlatLabel24.Size = New System.Drawing.Size(74, 20)
        Me.FlatLabel24.TabIndex = 53
        Me.FlatLabel24.Text = "Due Date"
        '
        'lblBTransactionDate
        '
        Me.lblBTransactionDate.AutoSize = True
        Me.lblBTransactionDate.BackColor = System.Drawing.Color.DimGray
        Me.lblBTransactionDate.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBTransactionDate.ForeColor = System.Drawing.Color.White
        Me.lblBTransactionDate.Location = New System.Drawing.Point(574, 22)
        Me.lblBTransactionDate.Name = "lblBTransactionDate"
        Me.lblBTransactionDate.Size = New System.Drawing.Size(90, 20)
        Me.lblBTransactionDate.TabIndex = 52
        Me.lblBTransactionDate.Text = "FlatLabel18"
        '
        'FlatLabel19
        '
        Me.FlatLabel19.AutoSize = True
        Me.FlatLabel19.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel19.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FlatLabel19.ForeColor = System.Drawing.Color.White
        Me.FlatLabel19.Location = New System.Drawing.Point(390, 22)
        Me.FlatLabel19.Name = "FlatLabel19"
        Me.FlatLabel19.Size = New System.Drawing.Size(42, 20)
        Me.FlatLabel19.TabIndex = 51
        Me.FlatLabel19.Text = "Date"
        '
        'FlatLabel10
        '
        Me.FlatLabel10.AutoSize = True
        Me.FlatLabel10.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel10.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FlatLabel10.ForeColor = System.Drawing.Color.White
        Me.FlatLabel10.Location = New System.Drawing.Point(10, 23)
        Me.FlatLabel10.Name = "FlatLabel10"
        Me.FlatLabel10.Size = New System.Drawing.Size(111, 20)
        Me.FlatLabel10.TabIndex = 50
        Me.FlatLabel10.Text = "TransactionNo"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblErrorBorrowerID)
        Me.GroupBox2.Controls.Add(Me.lblBMemberName)
        Me.GroupBox2.Controls.Add(Me.FlatLabel41)
        Me.GroupBox2.Controls.Add(Me.cmbBMemberID)
        Me.GroupBox2.Controls.Add(Me.FlatLabel38)
        Me.GroupBox2.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.GroupBox2.Location = New System.Drawing.Point(32, 87)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(829, 85)
        Me.GroupBox2.TabIndex = 63
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Borrower's Info"
        '
        'lblErrorBorrowerID
        '
        Me.lblErrorBorrowerID.AutoSize = True
        Me.lblErrorBorrowerID.BackColor = System.Drawing.Color.Transparent
        Me.lblErrorBorrowerID.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblErrorBorrowerID.ForeColor = System.Drawing.Color.Red
        Me.lblErrorBorrowerID.Location = New System.Drawing.Point(158, 57)
        Me.lblErrorBorrowerID.Name = "lblErrorBorrowerID"
        Me.lblErrorBorrowerID.Size = New System.Drawing.Size(218, 20)
        Me.lblErrorBorrowerID.TabIndex = 65
        Me.lblErrorBorrowerID.Text = "Borrower's ID  does not exists"
        Me.lblErrorBorrowerID.Visible = False
        '
        'lblBMemberName
        '
        Me.lblBMemberName.AutoSize = True
        Me.lblBMemberName.BackColor = System.Drawing.Color.DimGray
        Me.lblBMemberName.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBMemberName.ForeColor = System.Drawing.Color.White
        Me.lblBMemberName.Location = New System.Drawing.Point(575, 29)
        Me.lblBMemberName.Name = "lblBMemberName"
        Me.lblBMemberName.Size = New System.Drawing.Size(137, 20)
        Me.lblBMemberName.TabIndex = 64
        Me.lblBMemberName.Text = "lblBMemberName"
        '
        'FlatLabel41
        '
        Me.FlatLabel41.AutoSize = True
        Me.FlatLabel41.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel41.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FlatLabel41.ForeColor = System.Drawing.Color.White
        Me.FlatLabel41.Location = New System.Drawing.Point(392, 29)
        Me.FlatLabel41.Name = "FlatLabel41"
        Me.FlatLabel41.Size = New System.Drawing.Size(114, 20)
        Me.FlatLabel41.TabIndex = 64
        Me.FlatLabel41.Text = "Member Name"
        '
        'cmbBMemberID
        '
        Me.cmbBMemberID.AutoCompleteCustomSource.AddRange(New String() {"0001", "0002"})
        Me.cmbBMemberID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbBMemberID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbBMemberID.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbBMemberID.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbBMemberID.FormattingEnabled = True
        Me.cmbBMemberID.Location = New System.Drawing.Point(158, 23)
        Me.cmbBMemberID.Name = "cmbBMemberID"
        Me.cmbBMemberID.Size = New System.Drawing.Size(201, 28)
        Me.cmbBMemberID.TabIndex = 61
        '
        'FlatLabel38
        '
        Me.FlatLabel38.AutoSize = True
        Me.FlatLabel38.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel38.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FlatLabel38.ForeColor = System.Drawing.Color.White
        Me.FlatLabel38.Location = New System.Drawing.Point(33, 26)
        Me.FlatLabel38.Name = "FlatLabel38"
        Me.FlatLabel38.Size = New System.Drawing.Size(84, 20)
        Me.FlatLabel38.TabIndex = 62
        Me.FlatLabel38.Text = "MemberID"
        '
        'lblErrorBNotEnough
        '
        Me.lblErrorBNotEnough.AutoSize = True
        Me.lblErrorBNotEnough.BackColor = System.Drawing.Color.Transparent
        Me.lblErrorBNotEnough.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblErrorBNotEnough.ForeColor = System.Drawing.Color.Red
        Me.lblErrorBNotEnough.Location = New System.Drawing.Point(401, 582)
        Me.lblErrorBNotEnough.Name = "lblErrorBNotEnough"
        Me.lblErrorBNotEnough.Size = New System.Drawing.Size(140, 17)
        Me.lblErrorBNotEnough.TabIndex = 61
        Me.lblErrorBNotEnough.Text = "Not enough payment"
        Me.lblErrorBNotEnough.Visible = False
        '
        'lblBChange
        '
        Me.lblBChange.AutoSize = True
        Me.lblBChange.BackColor = System.Drawing.Color.DimGray
        Me.lblBChange.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBChange.ForeColor = System.Drawing.Color.White
        Me.lblBChange.Location = New System.Drawing.Point(201, 613)
        Me.lblBChange.Name = "lblBChange"
        Me.lblBChange.Size = New System.Drawing.Size(113, 25)
        Me.lblBChange.TabIndex = 57
        Me.lblBChange.Text = "FlatLabel34"
        '
        'FlatLabel36
        '
        Me.FlatLabel36.AutoSize = True
        Me.FlatLabel36.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel36.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FlatLabel36.ForeColor = System.Drawing.Color.White
        Me.FlatLabel36.Location = New System.Drawing.Point(37, 610)
        Me.FlatLabel36.Name = "FlatLabel36"
        Me.FlatLabel36.Size = New System.Drawing.Size(87, 30)
        Me.FlatLabel36.TabIndex = 56
        Me.FlatLabel36.Text = "Change"
        '
        'txtBPayment
        '
        Me.txtBPayment.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBPayment.Location = New System.Drawing.Point(200, 575)
        Me.txtBPayment.Name = "txtBPayment"
        Me.txtBPayment.Size = New System.Drawing.Size(195, 33)
        Me.txtBPayment.TabIndex = 55
        '
        'FlatLabel35
        '
        Me.FlatLabel35.AutoSize = True
        Me.FlatLabel35.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel35.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FlatLabel35.ForeColor = System.Drawing.Color.White
        Me.FlatLabel35.Location = New System.Drawing.Point(37, 575)
        Me.FlatLabel35.Name = "FlatLabel35"
        Me.FlatLabel35.Size = New System.Drawing.Size(98, 30)
        Me.FlatLabel35.TabIndex = 54
        Me.FlatLabel35.Text = "Payment"
        '
        'lblBTotalAmt
        '
        Me.lblBTotalAmt.AutoSize = True
        Me.lblBTotalAmt.BackColor = System.Drawing.Color.DimGray
        Me.lblBTotalAmt.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBTotalAmt.ForeColor = System.Drawing.Color.White
        Me.lblBTotalAmt.Location = New System.Drawing.Point(201, 546)
        Me.lblBTotalAmt.Name = "lblBTotalAmt"
        Me.lblBTotalAmt.Size = New System.Drawing.Size(113, 25)
        Me.lblBTotalAmt.TabIndex = 53
        Me.lblBTotalAmt.Text = "FlatLabel32"
        '
        'FlatLabel33
        '
        Me.FlatLabel33.AutoSize = True
        Me.FlatLabel33.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel33.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FlatLabel33.ForeColor = System.Drawing.Color.White
        Me.FlatLabel33.Location = New System.Drawing.Point(37, 543)
        Me.FlatLabel33.Name = "FlatLabel33"
        Me.FlatLabel33.Size = New System.Drawing.Size(148, 30)
        Me.FlatLabel33.TabIndex = 52
        Me.FlatLabel33.Text = "Total Amount"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnRemoveBooktoBList)
        Me.GroupBox1.Controls.Add(Me.lblBNoofAvailableBook)
        Me.GroupBox1.Controls.Add(Me.FlatLabel39)
        Me.GroupBox1.Controls.Add(Me.lblErrorBookID)
        Me.GroupBox1.Controls.Add(Me.lblBPublisher)
        Me.GroupBox1.Controls.Add(Me.FlatLabel15)
        Me.GroupBox1.Controls.Add(Me.lblBCategory)
        Me.GroupBox1.Controls.Add(Me.FlatLabel17)
        Me.GroupBox1.Controls.Add(Me.lblBPublishedYear)
        Me.GroupBox1.Controls.Add(Me.FlatLabel13)
        Me.GroupBox1.Controls.Add(Me.lblBAuthor)
        Me.GroupBox1.Controls.Add(Me.FlatLabel11)
        Me.GroupBox1.Controls.Add(Me.lblBTitle)
        Me.GroupBox1.Controls.Add(Me.FlatLabel7)
        Me.GroupBox1.Controls.Add(Me.cmbBookID)
        Me.GroupBox1.Controls.Add(Me.btnAddBooktoBList)
        Me.GroupBox1.Controls.Add(Me.FlatLabel5)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.GroupBox1.Location = New System.Drawing.Point(32, 169)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(829, 188)
        Me.GroupBox1.TabIndex = 46
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Book Info"
        '
        'btnRemoveBooktoBList
        '
        Me.btnRemoveBooktoBList.BackColor = System.Drawing.Color.Firebrick
        Me.btnRemoveBooktoBList.Enabled = False
        Me.btnRemoveBooktoBList.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRemoveBooktoBList.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRemoveBooktoBList.ForeColor = System.Drawing.Color.White
        Me.btnRemoveBooktoBList.Location = New System.Drawing.Point(592, 117)
        Me.btnRemoveBooktoBList.Name = "btnRemoveBooktoBList"
        Me.btnRemoveBooktoBList.Size = New System.Drawing.Size(153, 62)
        Me.btnRemoveBooktoBList.TabIndex = 63
        Me.btnRemoveBooktoBList.Text = "Remove Book to List"
        Me.btnRemoveBooktoBList.UseVisualStyleBackColor = False
        '
        'lblBNoofAvailableBook
        '
        Me.lblBNoofAvailableBook.AutoSize = True
        Me.lblBNoofAvailableBook.BackColor = System.Drawing.Color.DimGray
        Me.lblBNoofAvailableBook.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBNoofAvailableBook.ForeColor = System.Drawing.Color.White
        Me.lblBNoofAvailableBook.Location = New System.Drawing.Point(625, 85)
        Me.lblBNoofAvailableBook.Name = "lblBNoofAvailableBook"
        Me.lblBNoofAvailableBook.Size = New System.Drawing.Size(90, 20)
        Me.lblBNoofAvailableBook.TabIndex = 62
        Me.lblBNoofAvailableBook.Text = "FlatLabel40"
        '
        'FlatLabel39
        '
        Me.FlatLabel39.AutoSize = True
        Me.FlatLabel39.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel39.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FlatLabel39.ForeColor = System.Drawing.Color.White
        Me.FlatLabel39.Location = New System.Drawing.Point(429, 85)
        Me.FlatLabel39.Name = "FlatLabel39"
        Me.FlatLabel39.Size = New System.Drawing.Size(157, 20)
        Me.FlatLabel39.TabIndex = 61
        Me.FlatLabel39.Text = "No of Available Book"
        '
        'lblErrorBookID
        '
        Me.lblErrorBookID.AutoSize = True
        Me.lblErrorBookID.BackColor = System.Drawing.Color.Transparent
        Me.lblErrorBookID.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblErrorBookID.ForeColor = System.Drawing.Color.Red
        Me.lblErrorBookID.Location = New System.Drawing.Point(158, 57)
        Me.lblErrorBookID.Name = "lblErrorBookID"
        Me.lblErrorBookID.Size = New System.Drawing.Size(116, 20)
        Me.lblErrorBookID.TabIndex = 60
        Me.lblErrorBookID.Text = "Item not found"
        Me.lblErrorBookID.Visible = False
        '
        'lblBPublisher
        '
        Me.lblBPublisher.AutoSize = True
        Me.lblBPublisher.BackColor = System.Drawing.Color.DimGray
        Me.lblBPublisher.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBPublisher.ForeColor = System.Drawing.Color.White
        Me.lblBPublisher.Location = New System.Drawing.Point(153, 153)
        Me.lblBPublisher.Name = "lblBPublisher"
        Me.lblBPublisher.Size = New System.Drawing.Size(90, 20)
        Me.lblBPublisher.TabIndex = 59
        Me.lblBPublisher.Text = "FlatLabel14"
        '
        'FlatLabel15
        '
        Me.FlatLabel15.AutoSize = True
        Me.FlatLabel15.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel15.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FlatLabel15.ForeColor = System.Drawing.Color.White
        Me.FlatLabel15.Location = New System.Drawing.Point(33, 149)
        Me.FlatLabel15.Name = "FlatLabel15"
        Me.FlatLabel15.Size = New System.Drawing.Size(74, 20)
        Me.FlatLabel15.TabIndex = 58
        Me.FlatLabel15.Text = "Publisher"
        '
        'lblBCategory
        '
        Me.lblBCategory.AutoSize = True
        Me.lblBCategory.BackColor = System.Drawing.Color.DimGray
        Me.lblBCategory.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBCategory.ForeColor = System.Drawing.Color.White
        Me.lblBCategory.Location = New System.Drawing.Point(153, 117)
        Me.lblBCategory.Name = "lblBCategory"
        Me.lblBCategory.Size = New System.Drawing.Size(90, 20)
        Me.lblBCategory.TabIndex = 57
        Me.lblBCategory.Text = "FlatLabel16"
        '
        'FlatLabel17
        '
        Me.FlatLabel17.AutoSize = True
        Me.FlatLabel17.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel17.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FlatLabel17.ForeColor = System.Drawing.Color.White
        Me.FlatLabel17.Location = New System.Drawing.Point(33, 112)
        Me.FlatLabel17.Name = "FlatLabel17"
        Me.FlatLabel17.Size = New System.Drawing.Size(73, 20)
        Me.FlatLabel17.TabIndex = 56
        Me.FlatLabel17.Text = "Category"
        '
        'lblBPublishedYear
        '
        Me.lblBPublishedYear.AutoSize = True
        Me.lblBPublishedYear.BackColor = System.Drawing.Color.DimGray
        Me.lblBPublishedYear.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBPublishedYear.ForeColor = System.Drawing.Color.White
        Me.lblBPublishedYear.Location = New System.Drawing.Point(625, 57)
        Me.lblBPublishedYear.Name = "lblBPublishedYear"
        Me.lblBPublishedYear.Size = New System.Drawing.Size(90, 20)
        Me.lblBPublishedYear.TabIndex = 55
        Me.lblBPublishedYear.Text = "FlatLabel12"
        '
        'FlatLabel13
        '
        Me.FlatLabel13.AutoSize = True
        Me.FlatLabel13.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel13.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FlatLabel13.ForeColor = System.Drawing.Color.White
        Me.FlatLabel13.Location = New System.Drawing.Point(429, 54)
        Me.FlatLabel13.Name = "FlatLabel13"
        Me.FlatLabel13.Size = New System.Drawing.Size(111, 20)
        Me.FlatLabel13.TabIndex = 54
        Me.FlatLabel13.Text = "Published Year"
        '
        'lblBAuthor
        '
        Me.lblBAuthor.AutoSize = True
        Me.lblBAuthor.BackColor = System.Drawing.Color.DimGray
        Me.lblBAuthor.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBAuthor.ForeColor = System.Drawing.Color.White
        Me.lblBAuthor.Location = New System.Drawing.Point(625, 26)
        Me.lblBAuthor.Name = "lblBAuthor"
        Me.lblBAuthor.Size = New System.Drawing.Size(81, 20)
        Me.lblBAuthor.TabIndex = 53
        Me.lblBAuthor.Text = "FlatLabel9"
        '
        'FlatLabel11
        '
        Me.FlatLabel11.AutoSize = True
        Me.FlatLabel11.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel11.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FlatLabel11.ForeColor = System.Drawing.Color.White
        Me.FlatLabel11.Location = New System.Drawing.Point(429, 23)
        Me.FlatLabel11.Name = "FlatLabel11"
        Me.FlatLabel11.Size = New System.Drawing.Size(59, 20)
        Me.FlatLabel11.TabIndex = 52
        Me.FlatLabel11.Text = "Author"
        '
        'lblBTitle
        '
        Me.lblBTitle.AutoSize = True
        Me.lblBTitle.BackColor = System.Drawing.Color.DimGray
        Me.lblBTitle.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBTitle.ForeColor = System.Drawing.Color.White
        Me.lblBTitle.Location = New System.Drawing.Point(153, 83)
        Me.lblBTitle.Name = "lblBTitle"
        Me.lblBTitle.Size = New System.Drawing.Size(81, 20)
        Me.lblBTitle.TabIndex = 51
        Me.lblBTitle.Text = "FlatLabel8"
        '
        'FlatLabel7
        '
        Me.FlatLabel7.AutoSize = True
        Me.FlatLabel7.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel7.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FlatLabel7.ForeColor = System.Drawing.Color.White
        Me.FlatLabel7.Location = New System.Drawing.Point(33, 78)
        Me.FlatLabel7.Name = "FlatLabel7"
        Me.FlatLabel7.Size = New System.Drawing.Size(40, 20)
        Me.FlatLabel7.TabIndex = 50
        Me.FlatLabel7.Text = "Title"
        '
        'cmbBookID
        '
        Me.cmbBookID.AutoCompleteCustomSource.AddRange(New String() {"0001", "0002"})
        Me.cmbBookID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbBookID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbBookID.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbBookID.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbBookID.FormattingEnabled = True
        Me.cmbBookID.Items.AddRange(New Object() {"0001", "0002"})
        Me.cmbBookID.Location = New System.Drawing.Point(158, 26)
        Me.cmbBookID.Name = "cmbBookID"
        Me.cmbBookID.Size = New System.Drawing.Size(201, 28)
        Me.cmbBookID.TabIndex = 49
        '
        'btnAddBooktoBList
        '
        Me.btnAddBooktoBList.BackColor = System.Drawing.Color.Firebrick
        Me.btnAddBooktoBList.Enabled = False
        Me.btnAddBooktoBList.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddBooktoBList.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddBooktoBList.ForeColor = System.Drawing.Color.White
        Me.btnAddBooktoBList.Location = New System.Drawing.Point(433, 117)
        Me.btnAddBooktoBList.Name = "btnAddBooktoBList"
        Me.btnAddBooktoBList.Size = New System.Drawing.Size(153, 62)
        Me.btnAddBooktoBList.TabIndex = 48
        Me.btnAddBooktoBList.Text = "Add Book to List"
        Me.btnAddBooktoBList.UseVisualStyleBackColor = False
        '
        'FlatLabel5
        '
        Me.FlatLabel5.AutoSize = True
        Me.FlatLabel5.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel5.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FlatLabel5.ForeColor = System.Drawing.Color.White
        Me.FlatLabel5.Location = New System.Drawing.Point(33, 22)
        Me.FlatLabel5.Name = "FlatLabel5"
        Me.FlatLabel5.Size = New System.Drawing.Size(81, 20)
        Me.FlatLabel5.TabIndex = 47
        Me.FlatLabel5.Text = "Item Code"
        '
        'lstvwBorrowBookList
        '
        Me.lstvwBorrowBookList.GridLines = True
        Me.lstvwBorrowBookList.Location = New System.Drawing.Point(32, 414)
        Me.lstvwBorrowBookList.Name = "lstvwBorrowBookList"
        Me.lstvwBorrowBookList.Size = New System.Drawing.Size(830, 128)
        Me.lstvwBorrowBookList.TabIndex = 29
        Me.lstvwBorrowBookList.UseCompatibleStateImageBehavior = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.DarkCyan
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(32, 372)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(830, 43)
        Me.Button2.TabIndex = 28
        Me.Button2.Text = "BOOKS TO BE BORROW"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'btnBorrowBookReceipt
        '
        Me.btnBorrowBookReceipt.BackColor = System.Drawing.Color.SeaGreen
        Me.btnBorrowBookReceipt.Enabled = False
        Me.btnBorrowBookReceipt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBorrowBookReceipt.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBorrowBookReceipt.ForeColor = System.Drawing.Color.White
        Me.btnBorrowBookReceipt.Location = New System.Drawing.Point(601, 575)
        Me.btnBorrowBookReceipt.Name = "btnBorrowBookReceipt"
        Me.btnBorrowBookReceipt.Size = New System.Drawing.Size(261, 63)
        Me.btnBorrowBookReceipt.TabIndex = 17
        Me.btnBorrowBookReceipt.Text = "Confirm and Show Receipt"
        Me.btnBorrowBookReceipt.UseVisualStyleBackColor = False
        '
        'tabReturnBook
        '
        Me.tabReturnBook.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.tabReturnBook.Controls.Add(Me.pnlPenalty)
        Me.tabReturnBook.Controls.Add(Me.lblRBReturnDate)
        Me.tabReturnBook.Controls.Add(Me.FlatLabel20)
        Me.tabReturnBook.Controls.Add(Me.lblRBBorrower)
        Me.tabReturnBook.Controls.Add(Me.FlatLabel18)
        Me.tabReturnBook.Controls.Add(Me.lstvwReturnBookList)
        Me.tabReturnBook.Controls.Add(Me.Button4)
        Me.tabReturnBook.Controls.Add(Me.lblRBDateBorrowed)
        Me.tabReturnBook.Controls.Add(Me.FlatLabel16)
        Me.tabReturnBook.Controls.Add(Me.lblRBDueDate)
        Me.tabReturnBook.Controls.Add(Me.FlatLabel26)
        Me.tabReturnBook.Controls.Add(Me.btnReturnBooks)
        Me.tabReturnBook.Controls.Add(Me.cmbRBTransactionNo)
        Me.tabReturnBook.Controls.Add(Me.FlatLabel6)
        Me.tabReturnBook.Location = New System.Drawing.Point(4, 44)
        Me.tabReturnBook.Name = "tabReturnBook"
        Me.tabReturnBook.Padding = New System.Windows.Forms.Padding(3)
        Me.tabReturnBook.Size = New System.Drawing.Size(883, 650)
        Me.tabReturnBook.TabIndex = 7
        Me.tabReturnBook.Text = "Return Book"
        '
        'pnlPenalty
        '
        Me.pnlPenalty.Controls.Add(Me.FlatLabel12)
        Me.pnlPenalty.Controls.Add(Me.lblErrorRBNotEnough)
        Me.pnlPenalty.Controls.Add(Me.lblRBPenalty)
        Me.pnlPenalty.Controls.Add(Me.FlatLabel8)
        Me.pnlPenalty.Controls.Add(Me.txtRBPayment)
        Me.pnlPenalty.Controls.Add(Me.FlatLabel4)
        Me.pnlPenalty.Controls.Add(Me.lblRBChange)
        Me.pnlPenalty.Enabled = False
        Me.pnlPenalty.Location = New System.Drawing.Point(474, 341)
        Me.pnlPenalty.Name = "pnlPenalty"
        Me.pnlPenalty.Size = New System.Drawing.Size(382, 177)
        Me.pnlPenalty.TabIndex = 74
        '
        'FlatLabel12
        '
        Me.FlatLabel12.AutoSize = True
        Me.FlatLabel12.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel12.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FlatLabel12.ForeColor = System.Drawing.Color.White
        Me.FlatLabel12.Location = New System.Drawing.Point(13, 20)
        Me.FlatLabel12.Name = "FlatLabel12"
        Me.FlatLabel12.Size = New System.Drawing.Size(85, 30)
        Me.FlatLabel12.TabIndex = 58
        Me.FlatLabel12.Text = "Penalty"
        '
        'lblErrorRBNotEnough
        '
        Me.lblErrorRBNotEnough.AutoSize = True
        Me.lblErrorRBNotEnough.BackColor = System.Drawing.Color.Transparent
        Me.lblErrorRBNotEnough.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblErrorRBNotEnough.ForeColor = System.Drawing.Color.Red
        Me.lblErrorRBNotEnough.Location = New System.Drawing.Point(173, 91)
        Me.lblErrorRBNotEnough.Name = "lblErrorRBNotEnough"
        Me.lblErrorRBNotEnough.Size = New System.Drawing.Size(140, 17)
        Me.lblErrorRBNotEnough.TabIndex = 73
        Me.lblErrorRBNotEnough.Text = "Not enough payment"
        Me.lblErrorRBNotEnough.Visible = False
        '
        'lblRBPenalty
        '
        Me.lblRBPenalty.AutoSize = True
        Me.lblRBPenalty.BackColor = System.Drawing.Color.Transparent
        Me.lblRBPenalty.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRBPenalty.ForeColor = System.Drawing.Color.DimGray
        Me.lblRBPenalty.Location = New System.Drawing.Point(177, 23)
        Me.lblRBPenalty.Name = "lblRBPenalty"
        Me.lblRBPenalty.Size = New System.Drawing.Size(113, 25)
        Me.lblRBPenalty.TabIndex = 59
        Me.lblRBPenalty.Text = "FlatLabel32"
        '
        'FlatLabel8
        '
        Me.FlatLabel8.AutoSize = True
        Me.FlatLabel8.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel8.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FlatLabel8.ForeColor = System.Drawing.Color.White
        Me.FlatLabel8.Location = New System.Drawing.Point(13, 52)
        Me.FlatLabel8.Name = "FlatLabel8"
        Me.FlatLabel8.Size = New System.Drawing.Size(98, 30)
        Me.FlatLabel8.TabIndex = 60
        Me.FlatLabel8.Text = "Payment"
        '
        'txtRBPayment
        '
        Me.txtRBPayment.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRBPayment.Location = New System.Drawing.Point(176, 52)
        Me.txtRBPayment.Name = "txtRBPayment"
        Me.txtRBPayment.Size = New System.Drawing.Size(195, 33)
        Me.txtRBPayment.TabIndex = 61
        '
        'FlatLabel4
        '
        Me.FlatLabel4.AutoSize = True
        Me.FlatLabel4.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel4.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FlatLabel4.ForeColor = System.Drawing.Color.White
        Me.FlatLabel4.Location = New System.Drawing.Point(13, 114)
        Me.FlatLabel4.Name = "FlatLabel4"
        Me.FlatLabel4.Size = New System.Drawing.Size(87, 30)
        Me.FlatLabel4.TabIndex = 62
        Me.FlatLabel4.Text = "Change"
        '
        'lblRBChange
        '
        Me.lblRBChange.AutoSize = True
        Me.lblRBChange.BackColor = System.Drawing.Color.DimGray
        Me.lblRBChange.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRBChange.ForeColor = System.Drawing.Color.White
        Me.lblRBChange.Location = New System.Drawing.Point(177, 117)
        Me.lblRBChange.Name = "lblRBChange"
        Me.lblRBChange.Size = New System.Drawing.Size(113, 25)
        Me.lblRBChange.TabIndex = 63
        Me.lblRBChange.Text = "FlatLabel34"
        '
        'lblRBReturnDate
        '
        Me.lblRBReturnDate.AutoSize = True
        Me.lblRBReturnDate.BackColor = System.Drawing.Color.DimGray
        Me.lblRBReturnDate.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRBReturnDate.ForeColor = System.Drawing.Color.White
        Me.lblRBReturnDate.Location = New System.Drawing.Point(681, 105)
        Me.lblRBReturnDate.Name = "lblRBReturnDate"
        Me.lblRBReturnDate.Size = New System.Drawing.Size(113, 25)
        Me.lblRBReturnDate.TabIndex = 72
        Me.lblRBReturnDate.Text = "FlatLabel14"
        '
        'FlatLabel20
        '
        Me.FlatLabel20.AutoSize = True
        Me.FlatLabel20.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel20.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FlatLabel20.ForeColor = System.Drawing.Color.White
        Me.FlatLabel20.Location = New System.Drawing.Point(512, 101)
        Me.FlatLabel20.Name = "FlatLabel20"
        Me.FlatLabel20.Size = New System.Drawing.Size(130, 30)
        Me.FlatLabel20.TabIndex = 71
        Me.FlatLabel20.Text = "Return Date"
        '
        'lblRBBorrower
        '
        Me.lblRBBorrower.AutoSize = True
        Me.lblRBBorrower.BackColor = System.Drawing.Color.DimGray
        Me.lblRBBorrower.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRBBorrower.ForeColor = System.Drawing.Color.White
        Me.lblRBBorrower.Location = New System.Drawing.Point(237, 84)
        Me.lblRBBorrower.Name = "lblRBBorrower"
        Me.lblRBBorrower.Size = New System.Drawing.Size(143, 25)
        Me.lblRBBorrower.TabIndex = 70
        Me.lblRBBorrower.Text = "lblRBBorrower"
        '
        'FlatLabel18
        '
        Me.FlatLabel18.AutoSize = True
        Me.FlatLabel18.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel18.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FlatLabel18.ForeColor = System.Drawing.Color.White
        Me.FlatLabel18.Location = New System.Drawing.Point(44, 79)
        Me.FlatLabel18.Name = "FlatLabel18"
        Me.FlatLabel18.Size = New System.Drawing.Size(104, 30)
        Me.FlatLabel18.TabIndex = 69
        Me.FlatLabel18.Text = "Borrower"
        '
        'lstvwReturnBookList
        '
        Me.lstvwReturnBookList.GridLines = True
        Me.lstvwReturnBookList.Location = New System.Drawing.Point(26, 190)
        Me.lstvwReturnBookList.Name = "lstvwReturnBookList"
        Me.lstvwReturnBookList.Size = New System.Drawing.Size(830, 128)
        Me.lstvwReturnBookList.TabIndex = 67
        Me.lstvwReturnBookList.UseCompatibleStateImageBehavior = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.DarkCyan
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.White
        Me.Button4.Location = New System.Drawing.Point(26, 148)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(830, 43)
        Me.Button4.TabIndex = 66
        Me.Button4.Text = "LIST OF BORROWED BOOKS"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'lblRBDateBorrowed
        '
        Me.lblRBDateBorrowed.AutoSize = True
        Me.lblRBDateBorrowed.BackColor = System.Drawing.Color.DimGray
        Me.lblRBDateBorrowed.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRBDateBorrowed.ForeColor = System.Drawing.Color.White
        Me.lblRBDateBorrowed.Location = New System.Drawing.Point(681, 39)
        Me.lblRBDateBorrowed.Name = "lblRBDateBorrowed"
        Me.lblRBDateBorrowed.Size = New System.Drawing.Size(113, 25)
        Me.lblRBDateBorrowed.TabIndex = 65
        Me.lblRBDateBorrowed.Text = "FlatLabel14"
        '
        'FlatLabel16
        '
        Me.FlatLabel16.AutoSize = True
        Me.FlatLabel16.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel16.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FlatLabel16.ForeColor = System.Drawing.Color.White
        Me.FlatLabel16.Location = New System.Drawing.Point(512, 34)
        Me.FlatLabel16.Name = "FlatLabel16"
        Me.FlatLabel16.Size = New System.Drawing.Size(160, 30)
        Me.FlatLabel16.TabIndex = 64
        Me.FlatLabel16.Text = "Date Borrowed"
        '
        'lblRBDueDate
        '
        Me.lblRBDueDate.AutoSize = True
        Me.lblRBDueDate.BackColor = System.Drawing.Color.DimGray
        Me.lblRBDueDate.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRBDueDate.ForeColor = System.Drawing.Color.White
        Me.lblRBDueDate.Location = New System.Drawing.Point(681, 71)
        Me.lblRBDueDate.Name = "lblRBDueDate"
        Me.lblRBDueDate.Size = New System.Drawing.Size(113, 25)
        Me.lblRBDueDate.TabIndex = 49
        Me.lblRBDueDate.Text = "FlatLabel25"
        '
        'FlatLabel26
        '
        Me.FlatLabel26.AutoSize = True
        Me.FlatLabel26.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel26.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FlatLabel26.ForeColor = System.Drawing.Color.White
        Me.FlatLabel26.Location = New System.Drawing.Point(512, 67)
        Me.FlatLabel26.Name = "FlatLabel26"
        Me.FlatLabel26.Size = New System.Drawing.Size(103, 30)
        Me.FlatLabel26.TabIndex = 48
        Me.FlatLabel26.Text = "Due Date"
        '
        'btnReturnBooks
        '
        Me.btnReturnBooks.BackColor = System.Drawing.Color.SeaGreen
        Me.btnReturnBooks.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReturnBooks.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReturnBooks.ForeColor = System.Drawing.Color.White
        Me.btnReturnBooks.Location = New System.Drawing.Point(279, 556)
        Me.btnReturnBooks.Name = "btnReturnBooks"
        Me.btnReturnBooks.Size = New System.Drawing.Size(324, 76)
        Me.btnReturnBooks.TabIndex = 31
        Me.btnReturnBooks.Text = "Return Book(s)"
        Me.btnReturnBooks.UseVisualStyleBackColor = False
        '
        'cmbRBTransactionNo
        '
        Me.cmbRBTransactionNo.AutoCompleteCustomSource.AddRange(New String() {"0001", "0002"})
        Me.cmbRBTransactionNo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbRBTransactionNo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbRBTransactionNo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbRBTransactionNo.FormattingEnabled = True
        Me.cmbRBTransactionNo.Items.AddRange(New Object() {"0001", "0002"})
        Me.cmbRBTransactionNo.Location = New System.Drawing.Point(242, 39)
        Me.cmbRBTransactionNo.Name = "cmbRBTransactionNo"
        Me.cmbRBTransactionNo.Size = New System.Drawing.Size(211, 25)
        Me.cmbRBTransactionNo.TabIndex = 30
        '
        'FlatLabel6
        '
        Me.FlatLabel6.AutoSize = True
        Me.FlatLabel6.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel6.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FlatLabel6.ForeColor = System.Drawing.Color.White
        Me.FlatLabel6.Location = New System.Drawing.Point(44, 34)
        Me.FlatLabel6.Name = "FlatLabel6"
        Me.FlatLabel6.Size = New System.Drawing.Size(155, 30)
        Me.FlatLabel6.TabIndex = 29
        Me.FlatLabel6.Text = "TransactionNo"
        '
        'tabManageMembers
        '
        Me.tabManageMembers.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.tabManageMembers.Controls.Add(Me.cmbSearchBy)
        Me.tabManageMembers.Controls.Add(Me.txtSearchMember)
        Me.tabManageMembers.Controls.Add(Me.btnDeleteMember)
        Me.tabManageMembers.Controls.Add(Me.btnEditMember)
        Me.tabManageMembers.Controls.Add(Me.btnAddMember)
        Me.tabManageMembers.Controls.Add(Me.FlatLabel1)
        Me.tabManageMembers.Controls.Add(Me.lstvwMemberList)
        Me.tabManageMembers.Controls.Add(Me.Button1)
        Me.tabManageMembers.Location = New System.Drawing.Point(4, 44)
        Me.tabManageMembers.Name = "tabManageMembers"
        Me.tabManageMembers.Size = New System.Drawing.Size(883, 650)
        Me.tabManageMembers.TabIndex = 4
        Me.tabManageMembers.Text = "Manage Members"
        '
        'cmbSearchBy
        '
        Me.cmbSearchBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSearchBy.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbSearchBy.FormattingEnabled = True
        Me.cmbSearchBy.Items.AddRange(New Object() {"MemberID", "Lastname", "Firstname", "MI", "Address", "ContactNo"})
        Me.cmbSearchBy.Location = New System.Drawing.Point(737, 81)
        Me.cmbSearchBy.Name = "cmbSearchBy"
        Me.cmbSearchBy.Size = New System.Drawing.Size(121, 25)
        Me.cmbSearchBy.TabIndex = 40
        '
        'txtSearchMember
        '
        Me.txtSearchMember.Location = New System.Drawing.Point(585, 81)
        Me.txtSearchMember.Name = "txtSearchMember"
        Me.txtSearchMember.Size = New System.Drawing.Size(146, 25)
        Me.txtSearchMember.TabIndex = 39
        '
        'btnDeleteMember
        '
        Me.btnDeleteMember.BackColor = System.Drawing.Color.Crimson
        Me.btnDeleteMember.Enabled = False
        Me.btnDeleteMember.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDeleteMember.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeleteMember.ForeColor = System.Drawing.Color.White
        Me.btnDeleteMember.Location = New System.Drawing.Point(394, 45)
        Me.btnDeleteMember.Name = "btnDeleteMember"
        Me.btnDeleteMember.Size = New System.Drawing.Size(185, 61)
        Me.btnDeleteMember.TabIndex = 38
        Me.btnDeleteMember.Text = "Delete Member"
        Me.btnDeleteMember.UseVisualStyleBackColor = False
        '
        'btnEditMember
        '
        Me.btnEditMember.BackColor = System.Drawing.Color.Crimson
        Me.btnEditMember.Enabled = False
        Me.btnEditMember.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditMember.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditMember.ForeColor = System.Drawing.Color.White
        Me.btnEditMember.Location = New System.Drawing.Point(203, 45)
        Me.btnEditMember.Name = "btnEditMember"
        Me.btnEditMember.Size = New System.Drawing.Size(185, 61)
        Me.btnEditMember.TabIndex = 37
        Me.btnEditMember.Text = "Edit Member"
        Me.btnEditMember.UseVisualStyleBackColor = False
        '
        'btnAddMember
        '
        Me.btnAddMember.BackColor = System.Drawing.Color.Crimson
        Me.btnAddMember.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddMember.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddMember.ForeColor = System.Drawing.Color.White
        Me.btnAddMember.Location = New System.Drawing.Point(12, 45)
        Me.btnAddMember.Name = "btnAddMember"
        Me.btnAddMember.Size = New System.Drawing.Size(185, 61)
        Me.btnAddMember.TabIndex = 35
        Me.btnAddMember.Text = "Add Member"
        Me.btnAddMember.UseVisualStyleBackColor = False
        '
        'FlatLabel1
        '
        Me.FlatLabel1.AutoSize = True
        Me.FlatLabel1.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FlatLabel1.ForeColor = System.Drawing.Color.White
        Me.FlatLabel1.Location = New System.Drawing.Point(580, 45)
        Me.FlatLabel1.Name = "FlatLabel1"
        Me.FlatLabel1.Size = New System.Drawing.Size(151, 25)
        Me.FlatLabel1.TabIndex = 36
        Me.FlatLabel1.Text = "Search Member"
        '
        'lstvwMemberList
        '
        Me.lstvwMemberList.GridLines = True
        Me.lstvwMemberList.Location = New System.Drawing.Point(12, 166)
        Me.lstvwMemberList.Name = "lstvwMemberList"
        Me.lstvwMemberList.Size = New System.Drawing.Size(855, 446)
        Me.lstvwMemberList.TabIndex = 32
        Me.lstvwMemberList.UseCompatibleStateImageBehavior = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Indigo
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(12, 124)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(855, 43)
        Me.Button1.TabIndex = 31
        Me.Button1.Text = "MEMBER LIST"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'tabBorrowersList
        '
        Me.tabBorrowersList.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.tabBorrowersList.Controls.Add(Me.cmbBorrowerSearch)
        Me.tabBorrowersList.Controls.Add(Me.txtSearchBorrower)
        Me.tabBorrowersList.Controls.Add(Me.FlatLabel2)
        Me.tabBorrowersList.Controls.Add(Me.lstvwBorrowersList)
        Me.tabBorrowersList.Controls.Add(Me.Button6)
        Me.tabBorrowersList.Controls.Add(Me.lstvwBooksBorrowed)
        Me.tabBorrowersList.Controls.Add(Me.Button3)
        Me.tabBorrowersList.Location = New System.Drawing.Point(4, 44)
        Me.tabBorrowersList.Name = "tabBorrowersList"
        Me.tabBorrowersList.Padding = New System.Windows.Forms.Padding(3)
        Me.tabBorrowersList.Size = New System.Drawing.Size(883, 650)
        Me.tabBorrowersList.TabIndex = 8
        Me.tabBorrowersList.Text = "Borrowers List"
        '
        'cmbBorrowerSearch
        '
        Me.cmbBorrowerSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbBorrowerSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbBorrowerSearch.FormattingEnabled = True
        Me.cmbBorrowerSearch.Items.AddRange(New Object() {"MemberID", "Lastname", "Firstname", "MI", "Address", "ContactNo"})
        Me.cmbBorrowerSearch.Location = New System.Drawing.Point(679, 20)
        Me.cmbBorrowerSearch.Name = "cmbBorrowerSearch"
        Me.cmbBorrowerSearch.Size = New System.Drawing.Size(172, 25)
        Me.cmbBorrowerSearch.TabIndex = 42
        '
        'txtSearchBorrower
        '
        Me.txtSearchBorrower.Location = New System.Drawing.Point(497, 20)
        Me.txtSearchBorrower.Name = "txtSearchBorrower"
        Me.txtSearchBorrower.Size = New System.Drawing.Size(176, 25)
        Me.txtSearchBorrower.TabIndex = 41
        '
        'FlatLabel2
        '
        Me.FlatLabel2.AutoSize = True
        Me.FlatLabel2.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel2.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FlatLabel2.ForeColor = System.Drawing.Color.White
        Me.FlatLabel2.Location = New System.Drawing.Point(321, 20)
        Me.FlatLabel2.Name = "FlatLabel2"
        Me.FlatLabel2.Size = New System.Drawing.Size(161, 25)
        Me.FlatLabel2.TabIndex = 40
        Me.FlatLabel2.Text = "Search Borrower"
        '
        'lstvwBorrowersList
        '
        Me.lstvwBorrowersList.GridLines = True
        Me.lstvwBorrowersList.Location = New System.Drawing.Point(21, 105)
        Me.lstvwBorrowersList.Name = "lstvwBorrowersList"
        Me.lstvwBorrowersList.Size = New System.Drawing.Size(830, 331)
        Me.lstvwBorrowersList.TabIndex = 33
        Me.lstvwBorrowersList.UseCompatibleStateImageBehavior = False
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.Firebrick
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.ForeColor = System.Drawing.Color.White
        Me.Button6.Location = New System.Drawing.Point(21, 62)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(830, 43)
        Me.Button6.TabIndex = 32
        Me.Button6.Text = "BORROWERS LIST"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'lstvwBooksBorrowed
        '
        Me.lstvwBooksBorrowed.GridLines = True
        Me.lstvwBooksBorrowed.Location = New System.Drawing.Point(21, 499)
        Me.lstvwBooksBorrowed.Name = "lstvwBooksBorrowed"
        Me.lstvwBooksBorrowed.Size = New System.Drawing.Size(830, 131)
        Me.lstvwBooksBorrowed.TabIndex = 31
        Me.lstvwBooksBorrowed.UseCompatibleStateImageBehavior = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.DarkCyan
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.White
        Me.Button3.Location = New System.Drawing.Point(21, 456)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(830, 43)
        Me.Button3.TabIndex = 30
        Me.Button3.Text = "BOOKS BORROWED"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'btnLogout
        '
        Me.btnLogout.BackColor = System.Drawing.Color.DarkSlateGray
        Me.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogout.Font = New System.Drawing.Font("Segoe UI", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogout.ForeColor = System.Drawing.Color.White
        Me.btnLogout.Location = New System.Drawing.Point(8, 646)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(458, 110)
        Me.btnLogout.TabIndex = 13
        Me.btnLogout.Text = "LOGOUT"
        Me.btnLogout.UseVisualStyleBackColor = False
        '
        'btnManageMembers
        '
        Me.btnManageMembers.BackColor = System.Drawing.Color.Indigo
        Me.btnManageMembers.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnManageMembers.Font = New System.Drawing.Font("Segoe UI", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnManageMembers.ForeColor = System.Drawing.Color.White
        Me.btnManageMembers.Location = New System.Drawing.Point(8, 436)
        Me.btnManageMembers.Name = "btnManageMembers"
        Me.btnManageMembers.Size = New System.Drawing.Size(458, 110)
        Me.btnManageMembers.TabIndex = 12
        Me.btnManageMembers.Text = "MANAGE MEMBERS"
        Me.btnManageMembers.UseVisualStyleBackColor = False
        '
        'btnReturnBook
        '
        Me.btnReturnBook.BackColor = System.Drawing.Color.SeaGreen
        Me.btnReturnBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReturnBook.Font = New System.Drawing.Font("Segoe UI", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReturnBook.ForeColor = System.Drawing.Color.White
        Me.btnReturnBook.Location = New System.Drawing.Point(8, 330)
        Me.btnReturnBook.Name = "btnReturnBook"
        Me.btnReturnBook.Size = New System.Drawing.Size(458, 110)
        Me.btnReturnBook.TabIndex = 10
        Me.btnReturnBook.Text = "RETURN BOOK"
        Me.btnReturnBook.UseVisualStyleBackColor = False
        '
        'btnBorrowBook
        '
        Me.btnBorrowBook.BackColor = System.Drawing.Color.DarkCyan
        Me.btnBorrowBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBorrowBook.Font = New System.Drawing.Font("Segoe UI", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBorrowBook.ForeColor = System.Drawing.Color.White
        Me.btnBorrowBook.Location = New System.Drawing.Point(8, 223)
        Me.btnBorrowBook.Name = "btnBorrowBook"
        Me.btnBorrowBook.Size = New System.Drawing.Size(458, 110)
        Me.btnBorrowBook.TabIndex = 9
        Me.btnBorrowBook.Text = " BORROW BOOK"
        Me.btnBorrowBook.UseVisualStyleBackColor = False
        '
        'btnBookInventory
        '
        Me.btnBookInventory.BackColor = System.Drawing.Color.Tomato
        Me.btnBookInventory.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBookInventory.Font = New System.Drawing.Font("Segoe UI", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBookInventory.ForeColor = System.Drawing.Color.White
        Me.btnBookInventory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBookInventory.Location = New System.Drawing.Point(8, 114)
        Me.btnBookInventory.Name = "btnBookInventory"
        Me.btnBookInventory.Size = New System.Drawing.Size(458, 110)
        Me.btnBookInventory.TabIndex = 8
        Me.btnBookInventory.Text = " BOOK INVENTORY"
        Me.btnBookInventory.UseVisualStyleBackColor = False
        '
        'btnBorrowersList
        '
        Me.btnBorrowersList.BackColor = System.Drawing.Color.Firebrick
        Me.btnBorrowersList.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBorrowersList.Font = New System.Drawing.Font("Segoe UI", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBorrowersList.ForeColor = System.Drawing.Color.White
        Me.btnBorrowersList.Location = New System.Drawing.Point(8, 542)
        Me.btnBorrowersList.Name = "btnBorrowersList"
        Me.btnBorrowersList.Size = New System.Drawing.Size(458, 110)
        Me.btnBorrowersList.TabIndex = 17
        Me.btnBorrowersList.Text = "BORROWERS LIST"
        Me.btnBorrowersList.UseVisualStyleBackColor = False
        '
        'MainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1366, 768)
        Me.Controls.Add(Me.FormSkin1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "MainMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MainMenu"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.FormSkin1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.FlatGroupBox1.ResumeLayout(False)
        Me.FlatGroupBox1.PerformLayout()
        Me.tabGrp.ResumeLayout(False)
        Me.tabHome.ResumeLayout(False)
        Me.tabBookInventory.ResumeLayout(False)
        Me.tabBookInventory.PerformLayout()
        Me.tabBorrowBook.ResumeLayout(False)
        Me.tabBorrowBook.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.tabReturnBook.ResumeLayout(False)
        Me.tabReturnBook.PerformLayout()
        Me.pnlPenalty.ResumeLayout(False)
        Me.pnlPenalty.PerformLayout()
        Me.tabManageMembers.ResumeLayout(False)
        Me.tabManageMembers.PerformLayout()
        Me.tabBorrowersList.ResumeLayout(False)
        Me.tabBorrowersList.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents FormSkin1 As LibrarySystem.FormSkin
    Friend WithEvents btnReturnBook As System.Windows.Forms.Button
    Friend WithEvents btnBorrowBook As System.Windows.Forms.Button
    Friend WithEvents btnBookInventory As System.Windows.Forms.Button
    Friend WithEvents btnLogout As System.Windows.Forms.Button
    Friend WithEvents btnManageMembers As System.Windows.Forms.Button
    Friend WithEvents tabGrp As LibrarySystem.FlatTabControl
    Friend WithEvents tabBookInventory As System.Windows.Forms.TabPage
    Friend WithEvents tabBorrowBook As System.Windows.Forms.TabPage
    Friend WithEvents tabManageMembers As System.Windows.Forms.TabPage
    Friend WithEvents tabHome As System.Windows.Forms.TabPage
    Friend WithEvents Button9 As System.Windows.Forms.Button
    Friend WithEvents lstvwBookInventory As System.Windows.Forms.ListView
    Friend WithEvents FlatLabel3 As LibrarySystem.FlatLabel
    Friend WithEvents Button10 As System.Windows.Forms.Button
    Friend WithEvents FlatClose1 As LibrarySystem.FlatClose
    Friend WithEvents lstvwMemberList As System.Windows.Forms.ListView
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents lstvwBorrowBookList As System.Windows.Forms.ListView
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents btnBorrowBookReceipt As System.Windows.Forms.Button
    Friend WithEvents tabReturnBook As System.Windows.Forms.TabPage
    Friend WithEvents FlatLabel6 As LibrarySystem.FlatLabel
    Friend WithEvents cmbRBTransactionNo As System.Windows.Forms.ComboBox
    Friend WithEvents btnReturnBooks As System.Windows.Forms.Button
    Friend WithEvents btnDeleteBook As System.Windows.Forms.Button
    Friend WithEvents btnEditBook As System.Windows.Forms.Button
    Friend WithEvents btnAddBook As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lblErrorBookID As LibrarySystem.FlatLabel
    Friend WithEvents lblBPublisher As LibrarySystem.FlatLabel
    Friend WithEvents FlatLabel15 As LibrarySystem.FlatLabel
    Friend WithEvents lblBCategory As LibrarySystem.FlatLabel
    Friend WithEvents FlatLabel17 As LibrarySystem.FlatLabel
    Friend WithEvents lblBPublishedYear As LibrarySystem.FlatLabel
    Friend WithEvents FlatLabel13 As LibrarySystem.FlatLabel
    Friend WithEvents lblBAuthor As LibrarySystem.FlatLabel
    Friend WithEvents FlatLabel11 As LibrarySystem.FlatLabel
    Friend WithEvents lblBTitle As LibrarySystem.FlatLabel
    Friend WithEvents FlatLabel7 As LibrarySystem.FlatLabel
    Friend WithEvents cmbBookID As System.Windows.Forms.ComboBox
    Friend WithEvents btnAddBooktoBList As System.Windows.Forms.Button
    Friend WithEvents FlatLabel5 As LibrarySystem.FlatLabel
    Friend WithEvents lblRBDueDate As LibrarySystem.FlatLabel
    Friend WithEvents FlatLabel26 As LibrarySystem.FlatLabel
    Friend WithEvents lblBChange As LibrarySystem.FlatLabel
    Friend WithEvents FlatLabel36 As LibrarySystem.FlatLabel
    Friend WithEvents txtBPayment As System.Windows.Forms.TextBox
    Friend WithEvents FlatLabel35 As LibrarySystem.FlatLabel
    Friend WithEvents lblBTotalAmt As LibrarySystem.FlatLabel
    Friend WithEvents FlatLabel33 As LibrarySystem.FlatLabel
    Friend WithEvents lblErrorBNotEnough As LibrarySystem.FlatLabel
    Friend WithEvents cmbBMemberID As System.Windows.Forms.ComboBox
    Friend WithEvents FlatLabel38 As LibrarySystem.FlatLabel
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents lblBNoofAvailableBook As LibrarySystem.FlatLabel
    Friend WithEvents FlatLabel39 As LibrarySystem.FlatLabel
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents lblBTransactionNo As LibrarySystem.FlatLabel
    Friend WithEvents lblBDueDate As LibrarySystem.FlatLabel
    Friend WithEvents FlatLabel24 As LibrarySystem.FlatLabel
    Friend WithEvents lblBTransactionDate As LibrarySystem.FlatLabel
    Friend WithEvents FlatLabel19 As LibrarySystem.FlatLabel
    Friend WithEvents FlatLabel10 As LibrarySystem.FlatLabel
    Friend WithEvents lblErrorBorrowerID As LibrarySystem.FlatLabel
    Friend WithEvents lblBMemberName As LibrarySystem.FlatLabel
    Friend WithEvents FlatLabel41 As LibrarySystem.FlatLabel
    Friend WithEvents btnBorrowersList As System.Windows.Forms.Button
    Friend WithEvents txtSearchBook As System.Windows.Forms.TextBox
    Friend WithEvents txtSearchMember As System.Windows.Forms.TextBox
    Friend WithEvents btnDeleteMember As System.Windows.Forms.Button
    Friend WithEvents btnEditMember As System.Windows.Forms.Button
    Friend WithEvents btnAddMember As System.Windows.Forms.Button
    Friend WithEvents FlatLabel1 As LibrarySystem.FlatLabel
    Friend WithEvents tabBorrowersList As System.Windows.Forms.TabPage
    Friend WithEvents lstvwBorrowersList As System.Windows.Forms.ListView
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents lstvwBooksBorrowed As System.Windows.Forms.ListView
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents lblRBDateBorrowed As LibrarySystem.FlatLabel
    Friend WithEvents FlatLabel16 As LibrarySystem.FlatLabel
    Friend WithEvents lblRBChange As LibrarySystem.FlatLabel
    Friend WithEvents FlatLabel4 As LibrarySystem.FlatLabel
    Friend WithEvents txtRBPayment As System.Windows.Forms.TextBox
    Friend WithEvents FlatLabel8 As LibrarySystem.FlatLabel
    Friend WithEvents lblRBPenalty As LibrarySystem.FlatLabel
    Friend WithEvents FlatLabel12 As LibrarySystem.FlatLabel
    Friend WithEvents lstvwReturnBookList As System.Windows.Forms.ListView
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents lblRBBorrower As LibrarySystem.FlatLabel
    Friend WithEvents FlatLabel18 As LibrarySystem.FlatLabel
    Friend WithEvents lblRBReturnDate As LibrarySystem.FlatLabel
    Friend WithEvents FlatLabel20 As LibrarySystem.FlatLabel
    Friend WithEvents lblErrorRBNotEnough As LibrarySystem.FlatLabel
    Friend WithEvents pnlPenalty As System.Windows.Forms.Panel
    Friend WithEvents txtSearchBorrower As System.Windows.Forms.TextBox
    Friend WithEvents FlatLabel2 As LibrarySystem.FlatLabel
    Friend WithEvents FlatMini1 As LibrarySystem.FlatMini
    Friend WithEvents tmrDateTime As System.Windows.Forms.Timer
    Friend WithEvents FlatGroupBox1 As LibrarySystem.FlatGroupBox
    Friend WithEvents lblCurrentTime As LibrarySystem.FlatLabel
    Friend WithEvents lblDateNow As LibrarySystem.FlatLabel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents FlatLabel9 As LibrarySystem.FlatLabel
    Friend WithEvents cmbSearchBy As System.Windows.Forms.ComboBox
    Friend WithEvents cmbBorrowerSearch As System.Windows.Forms.ComboBox
    Friend WithEvents btnRemoveBooktoBList As System.Windows.Forms.Button
    Friend WithEvents cmbBookInventorySearch As System.Windows.Forms.ComboBox
End Class
