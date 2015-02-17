<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddNewMember
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
        Me.lblMemberID = New LibrarySystem.FlatLabel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.FlatLabel5 = New LibrarySystem.FlatLabel()
        Me.txtMemberContactNo = New System.Windows.Forms.TextBox()
        Me.FlatLabel4 = New LibrarySystem.FlatLabel()
        Me.txtMemberAddress = New System.Windows.Forms.TextBox()
        Me.FlatLabel3 = New LibrarySystem.FlatLabel()
        Me.txtMemberMI = New System.Windows.Forms.TextBox()
        Me.Publisher = New LibrarySystem.FlatLabel()
        Me.txtMemberFirstName = New System.Windows.Forms.TextBox()
        Me.btnAddMember = New System.Windows.Forms.Button()
        Me.FlatLabel2 = New LibrarySystem.FlatLabel()
        Me.FlatLabel1 = New LibrarySystem.FlatLabel()
        Me.txtMemberLastName = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.FormSkin1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FormSkin1
        '
        Me.FormSkin1.BackColor = System.Drawing.Color.White
        Me.FormSkin1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.FormSkin1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.FormSkin1.Controls.Add(Me.Label6)
        Me.FormSkin1.Controls.Add(Me.lblMemberID)
        Me.FormSkin1.Controls.Add(Me.PictureBox1)
        Me.FormSkin1.Controls.Add(Me.FlatLabel5)
        Me.FormSkin1.Controls.Add(Me.txtMemberContactNo)
        Me.FormSkin1.Controls.Add(Me.FlatLabel4)
        Me.FormSkin1.Controls.Add(Me.txtMemberAddress)
        Me.FormSkin1.Controls.Add(Me.FlatLabel3)
        Me.FormSkin1.Controls.Add(Me.txtMemberMI)
        Me.FormSkin1.Controls.Add(Me.Publisher)
        Me.FormSkin1.Controls.Add(Me.txtMemberFirstName)
        Me.FormSkin1.Controls.Add(Me.btnAddMember)
        Me.FormSkin1.Controls.Add(Me.FlatLabel2)
        Me.FormSkin1.Controls.Add(Me.FlatLabel1)
        Me.FormSkin1.Controls.Add(Me.txtMemberLastName)
        Me.FormSkin1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FormSkin1.FlatColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.FormSkin1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormSkin1.HeaderColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.FormSkin1.HeaderMaximize = False
        Me.FormSkin1.Location = New System.Drawing.Point(0, 0)
        Me.FormSkin1.Name = "FormSkin1"
        Me.FormSkin1.Size = New System.Drawing.Size(402, 460)
        Me.FormSkin1.TabIndex = 2
        Me.FormSkin1.Text = "Add New Member"
        '
        'lblMemberID
        '
        Me.lblMemberID.AutoSize = True
        Me.lblMemberID.BackColor = System.Drawing.Color.DimGray
        Me.lblMemberID.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMemberID.ForeColor = System.Drawing.Color.White
        Me.lblMemberID.Location = New System.Drawing.Point(165, 93)
        Me.lblMemberID.Name = "lblMemberID"
        Me.lblMemberID.Size = New System.Drawing.Size(90, 20)
        Me.lblMemberID.TabIndex = 95
        Me.lblMemberID.Text = "FlatLabel31"
        '
        'PictureBox1
        '
        Me.PictureBox1.ErrorImage = Nothing
        Me.PictureBox1.Image = Global.LibrarySystem.My.Resources.Resources.btnFormClose
        Me.PictureBox1.Location = New System.Drawing.Point(376, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(18, 18)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 92
        Me.PictureBox1.TabStop = False
        '
        'FlatLabel5
        '
        Me.FlatLabel5.AutoSize = True
        Me.FlatLabel5.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel5.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FlatLabel5.ForeColor = System.Drawing.Color.DimGray
        Me.FlatLabel5.Location = New System.Drawing.Point(38, 307)
        Me.FlatLabel5.Name = "FlatLabel5"
        Me.FlatLabel5.Size = New System.Drawing.Size(88, 20)
        Me.FlatLabel5.TabIndex = 12
        Me.FlatLabel5.Text = "Contact No"
        '
        'txtMemberContactNo
        '
        Me.txtMemberContactNo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtMemberContactNo.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMemberContactNo.Location = New System.Drawing.Point(169, 307)
        Me.txtMemberContactNo.Name = "txtMemberContactNo"
        Me.txtMemberContactNo.Size = New System.Drawing.Size(187, 20)
        Me.txtMemberContactNo.TabIndex = 11
        '
        'FlatLabel4
        '
        Me.FlatLabel4.AutoSize = True
        Me.FlatLabel4.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel4.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FlatLabel4.ForeColor = System.Drawing.Color.DimGray
        Me.FlatLabel4.Location = New System.Drawing.Point(38, 266)
        Me.FlatLabel4.Name = "FlatLabel4"
        Me.FlatLabel4.Size = New System.Drawing.Size(66, 20)
        Me.FlatLabel4.TabIndex = 10
        Me.FlatLabel4.Text = "Address"
        '
        'txtMemberAddress
        '
        Me.txtMemberAddress.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtMemberAddress.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMemberAddress.Location = New System.Drawing.Point(169, 266)
        Me.txtMemberAddress.Name = "txtMemberAddress"
        Me.txtMemberAddress.Size = New System.Drawing.Size(187, 20)
        Me.txtMemberAddress.TabIndex = 9
        '
        'FlatLabel3
        '
        Me.FlatLabel3.AutoSize = True
        Me.FlatLabel3.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel3.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FlatLabel3.ForeColor = System.Drawing.Color.DimGray
        Me.FlatLabel3.Location = New System.Drawing.Point(38, 224)
        Me.FlatLabel3.Name = "FlatLabel3"
        Me.FlatLabel3.Size = New System.Drawing.Size(28, 20)
        Me.FlatLabel3.TabIndex = 8
        Me.FlatLabel3.Text = "MI"
        '
        'txtMemberMI
        '
        Me.txtMemberMI.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtMemberMI.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMemberMI.Location = New System.Drawing.Point(169, 224)
        Me.txtMemberMI.MaxLength = 3
        Me.txtMemberMI.Name = "txtMemberMI"
        Me.txtMemberMI.Size = New System.Drawing.Size(49, 20)
        Me.txtMemberMI.TabIndex = 7
        '
        'Publisher
        '
        Me.Publisher.AutoSize = True
        Me.Publisher.BackColor = System.Drawing.Color.Transparent
        Me.Publisher.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Publisher.ForeColor = System.Drawing.Color.DimGray
        Me.Publisher.Location = New System.Drawing.Point(38, 180)
        Me.Publisher.Name = "Publisher"
        Me.Publisher.Size = New System.Drawing.Size(86, 20)
        Me.Publisher.TabIndex = 6
        Me.Publisher.Text = "First Name"
        '
        'txtMemberFirstName
        '
        Me.txtMemberFirstName.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtMemberFirstName.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMemberFirstName.Location = New System.Drawing.Point(169, 180)
        Me.txtMemberFirstName.Name = "txtMemberFirstName"
        Me.txtMemberFirstName.Size = New System.Drawing.Size(187, 20)
        Me.txtMemberFirstName.TabIndex = 5
        '
        'btnAddMember
        '
        Me.btnAddMember.BackColor = System.Drawing.Color.SeaGreen
        Me.btnAddMember.Enabled = False
        Me.btnAddMember.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddMember.ForeColor = System.Drawing.Color.White
        Me.btnAddMember.Location = New System.Drawing.Point(169, 366)
        Me.btnAddMember.Name = "btnAddMember"
        Me.btnAddMember.Size = New System.Drawing.Size(187, 43)
        Me.btnAddMember.TabIndex = 4
        Me.btnAddMember.Text = "Add Member"
        Me.btnAddMember.UseVisualStyleBackColor = False
        '
        'FlatLabel2
        '
        Me.FlatLabel2.AutoSize = True
        Me.FlatLabel2.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel2.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FlatLabel2.ForeColor = System.Drawing.Color.DimGray
        Me.FlatLabel2.Location = New System.Drawing.Point(38, 134)
        Me.FlatLabel2.Name = "FlatLabel2"
        Me.FlatLabel2.Size = New System.Drawing.Size(84, 20)
        Me.FlatLabel2.TabIndex = 3
        Me.FlatLabel2.Text = "Last Name"
        '
        'FlatLabel1
        '
        Me.FlatLabel1.AutoSize = True
        Me.FlatLabel1.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel1.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FlatLabel1.ForeColor = System.Drawing.Color.DimGray
        Me.FlatLabel1.Location = New System.Drawing.Point(38, 93)
        Me.FlatLabel1.Name = "FlatLabel1"
        Me.FlatLabel1.Size = New System.Drawing.Size(88, 20)
        Me.FlatLabel1.TabIndex = 2
        Me.FlatLabel1.Text = "Member ID"
        '
        'txtMemberLastName
        '
        Me.txtMemberLastName.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtMemberLastName.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMemberLastName.Location = New System.Drawing.Point(169, 134)
        Me.txtMemberLastName.Name = "txtMemberLastName"
        Me.txtMemberLastName.Size = New System.Drawing.Size(187, 20)
        Me.txtMemberLastName.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Red
        Me.Label6.Location = New System.Drawing.Point(166, 338)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(126, 15)
        Me.Label6.TabIndex = 108
        Me.Label6.Text = "All fields are required"
        '
        'AddNewMember
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(402, 460)
        Me.Controls.Add(Me.FormSkin1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "AddNewMember"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add New Member"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.FormSkin1.ResumeLayout(False)
        Me.FormSkin1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents FormSkin1 As LibrarySystem.FormSkin
    Friend WithEvents lblMemberID As LibrarySystem.FlatLabel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents FlatLabel5 As LibrarySystem.FlatLabel
    Friend WithEvents txtMemberContactNo As System.Windows.Forms.TextBox
    Friend WithEvents FlatLabel4 As LibrarySystem.FlatLabel
    Friend WithEvents txtMemberAddress As System.Windows.Forms.TextBox
    Friend WithEvents FlatLabel3 As LibrarySystem.FlatLabel
    Friend WithEvents txtMemberMI As System.Windows.Forms.TextBox
    Friend WithEvents Publisher As LibrarySystem.FlatLabel
    Friend WithEvents txtMemberFirstName As System.Windows.Forms.TextBox
    Friend WithEvents btnAddMember As System.Windows.Forms.Button
    Friend WithEvents FlatLabel2 As LibrarySystem.FlatLabel
    Friend WithEvents FlatLabel1 As LibrarySystem.FlatLabel
    Friend WithEvents txtMemberLastName As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
End Class
