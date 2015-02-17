<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BookList
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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.FlatLabel3 = New LibrarySystem.FlatLabel()
        Me.txtSearchSupplier = New System.Windows.Forms.TextBox()
        Me.lstvwBookInventory = New System.Windows.Forms.ListView()
        Me.FlatLabel1 = New LibrarySystem.FlatLabel()
        Me.txtSearchBook = New System.Windows.Forms.TextBox()
        Me.FormSkin1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FormSkin1
        '
        Me.FormSkin1.BackColor = System.Drawing.Color.White
        Me.FormSkin1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.FormSkin1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.FormSkin1.Controls.Add(Me.FlatLabel1)
        Me.FormSkin1.Controls.Add(Me.txtSearchBook)
        Me.FormSkin1.Controls.Add(Me.FlatLabel3)
        Me.FormSkin1.Controls.Add(Me.txtSearchSupplier)
        Me.FormSkin1.Controls.Add(Me.lstvwBookInventory)
        Me.FormSkin1.Controls.Add(Me.PictureBox1)
        Me.FormSkin1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FormSkin1.FlatColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.FormSkin1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormSkin1.HeaderColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.FormSkin1.HeaderMaximize = False
        Me.FormSkin1.Location = New System.Drawing.Point(0, 0)
        Me.FormSkin1.Name = "FormSkin1"
        Me.FormSkin1.Size = New System.Drawing.Size(496, 443)
        Me.FormSkin1.TabIndex = 2
        Me.FormSkin1.Text = "Add New Book"
        '
        'PictureBox1
        '
        Me.PictureBox1.ErrorImage = Nothing
        Me.PictureBox1.Image = Global.LibrarySystem.My.Resources.Resources.btnFormClose
        Me.PictureBox1.Location = New System.Drawing.Point(466, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(18, 18)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 92
        Me.PictureBox1.TabStop = False
        '
        'FlatLabel3
        '
        Me.FlatLabel3.AutoSize = True
        Me.FlatLabel3.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FlatLabel3.ForeColor = System.Drawing.Color.White
        Me.FlatLabel3.Location = New System.Drawing.Point(321, -55)
        Me.FlatLabel3.Name = "FlatLabel3"
        Me.FlatLabel3.Size = New System.Drawing.Size(104, 21)
        Me.FlatLabel3.TabIndex = 96
        Me.FlatLabel3.Text = "Search Book"
        '
        'txtSearchSupplier
        '
        Me.txtSearchSupplier.Location = New System.Drawing.Point(443, -55)
        Me.txtSearchSupplier.Name = "txtSearchSupplier"
        Me.txtSearchSupplier.Size = New System.Drawing.Size(10, 29)
        Me.txtSearchSupplier.TabIndex = 95
        '
        'lstvwBookInventory
        '
        Me.lstvwBookInventory.GridLines = True
        Me.lstvwBookInventory.Location = New System.Drawing.Point(31, 106)
        Me.lstvwBookInventory.Name = "lstvwBookInventory"
        Me.lstvwBookInventory.OwnerDraw = True
        Me.lstvwBookInventory.Size = New System.Drawing.Size(437, 290)
        Me.lstvwBookInventory.TabIndex = 94
        Me.lstvwBookInventory.UseCompatibleStateImageBehavior = False
        '
        'FlatLabel1
        '
        Me.FlatLabel1.AutoSize = True
        Me.FlatLabel1.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FlatLabel1.ForeColor = System.Drawing.Color.DimGray
        Me.FlatLabel1.Location = New System.Drawing.Point(152, 64)
        Me.FlatLabel1.Name = "FlatLabel1"
        Me.FlatLabel1.Size = New System.Drawing.Size(104, 21)
        Me.FlatLabel1.TabIndex = 98
        Me.FlatLabel1.Text = "Search Book"
        '
        'txtSearchBook
        '
        Me.txtSearchBook.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtSearchBook.Location = New System.Drawing.Point(273, 64)
        Me.txtSearchBook.Name = "txtSearchBook"
        Me.txtSearchBook.Size = New System.Drawing.Size(195, 22)
        Me.txtSearchBook.TabIndex = 97
        '
        'BookList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(496, 443)
        Me.Controls.Add(Me.FormSkin1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "BookList"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "BookList"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.FormSkin1.ResumeLayout(False)
        Me.FormSkin1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents FormSkin1 As LibrarySystem.FormSkin
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents FlatLabel3 As LibrarySystem.FlatLabel
    Friend WithEvents txtSearchSupplier As System.Windows.Forms.TextBox
    Friend WithEvents lstvwBookInventory As System.Windows.Forms.ListView
    Friend WithEvents FlatLabel1 As LibrarySystem.FlatLabel
    Friend WithEvents txtSearchBook As System.Windows.Forms.TextBox
End Class
