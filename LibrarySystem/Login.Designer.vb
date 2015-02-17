<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Me.FlatLabel3 = New LibrarySystem.FlatLabel()
        Me.FlatClose1 = New LibrarySystem.FlatClose()
        Me.lblError = New LibrarySystem.FlatLabel()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.FlatLabel2 = New LibrarySystem.FlatLabel()
        Me.FlatLabel1 = New LibrarySystem.FlatLabel()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.FormSkin1.SuspendLayout()
        Me.SuspendLayout()
        '
        'FormSkin1
        '
        Me.FormSkin1.BackColor = System.Drawing.Color.White
        Me.FormSkin1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.FormSkin1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.FormSkin1.Controls.Add(Me.FlatLabel3)
        Me.FormSkin1.Controls.Add(Me.FlatClose1)
        Me.FormSkin1.Controls.Add(Me.lblError)
        Me.FormSkin1.Controls.Add(Me.btnLogin)
        Me.FormSkin1.Controls.Add(Me.FlatLabel2)
        Me.FormSkin1.Controls.Add(Me.FlatLabel1)
        Me.FormSkin1.Controls.Add(Me.txtPassword)
        Me.FormSkin1.Controls.Add(Me.txtUsername)
        Me.FormSkin1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FormSkin1.FlatColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.FormSkin1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormSkin1.HeaderColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.FormSkin1.HeaderMaximize = False
        Me.FormSkin1.Location = New System.Drawing.Point(0, 0)
        Me.FormSkin1.Name = "FormSkin1"
        Me.FormSkin1.Size = New System.Drawing.Size(401, 266)
        Me.FormSkin1.TabIndex = 0
        Me.FormSkin1.Text = "Library System Login"
        '
        'FlatLabel3
        '
        Me.FlatLabel3.AutoSize = True
        Me.FlatLabel3.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FlatLabel3.ForeColor = System.Drawing.Color.Blue
        Me.FlatLabel3.Location = New System.Drawing.Point(147, 238)
        Me.FlatLabel3.Name = "FlatLabel3"
        Me.FlatLabel3.Size = New System.Drawing.Size(93, 15)
        Me.FlatLabel3.TabIndex = 63
        Me.FlatLabel3.Text = "Add new admin"
        '
        'FlatClose1
        '
        Me.FlatClose1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FlatClose1.BackColor = System.Drawing.Color.White
        Me.FlatClose1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.FlatClose1.Font = New System.Drawing.Font("Marlett", 10.0!)
        Me.FlatClose1.Location = New System.Drawing.Point(371, 12)
        Me.FlatClose1.Name = "FlatClose1"
        Me.FlatClose1.Size = New System.Drawing.Size(18, 18)
        Me.FlatClose1.TabIndex = 62
        Me.FlatClose1.Text = "FlatClose1"
        Me.FlatClose1.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'lblError
        '
        Me.lblError.AutoSize = True
        Me.lblError.BackColor = System.Drawing.Color.Transparent
        Me.lblError.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblError.ForeColor = System.Drawing.Color.Red
        Me.lblError.Location = New System.Drawing.Point(146, 151)
        Me.lblError.Name = "lblError"
        Me.lblError.Size = New System.Drawing.Size(220, 20)
        Me.lblError.TabIndex = 61
        Me.lblError.Text = "Wrong username or password"
        Me.lblError.Visible = False
        '
        'btnLogin
        '
        Me.btnLogin.BackColor = System.Drawing.Color.SeaGreen
        Me.btnLogin.Enabled = False
        Me.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogin.ForeColor = System.Drawing.Color.White
        Me.btnLogin.Location = New System.Drawing.Point(150, 184)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(187, 43)
        Me.btnLogin.TabIndex = 4
        Me.btnLogin.Text = "Login"
        Me.btnLogin.UseVisualStyleBackColor = False
        '
        'FlatLabel2
        '
        Me.FlatLabel2.AutoSize = True
        Me.FlatLabel2.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FlatLabel2.ForeColor = System.Drawing.Color.DimGray
        Me.FlatLabel2.Location = New System.Drawing.Point(59, 126)
        Me.FlatLabel2.Name = "FlatLabel2"
        Me.FlatLabel2.Size = New System.Drawing.Size(59, 15)
        Me.FlatLabel2.TabIndex = 3
        Me.FlatLabel2.Text = "Password"
        '
        'FlatLabel1
        '
        Me.FlatLabel1.AutoSize = True
        Me.FlatLabel1.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FlatLabel1.ForeColor = System.Drawing.Color.DimGray
        Me.FlatLabel1.Location = New System.Drawing.Point(59, 85)
        Me.FlatLabel1.Name = "FlatLabel1"
        Me.FlatLabel1.Size = New System.Drawing.Size(64, 15)
        Me.FlatLabel1.TabIndex = 2
        Me.FlatLabel1.Text = "Username"
        '
        'txtPassword
        '
        Me.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPassword.Location = New System.Drawing.Point(150, 126)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(187, 22)
        Me.txtPassword.TabIndex = 1
        Me.txtPassword.UseSystemPasswordChar = True
        '
        'txtUsername
        '
        Me.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtUsername.Location = New System.Drawing.Point(150, 82)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(187, 22)
        Me.txtUsername.TabIndex = 0
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(401, 266)
        Me.Controls.Add(Me.FormSkin1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.FormSkin1.ResumeLayout(False)
        Me.FormSkin1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents FormSkin1 As LibrarySystem.FormSkin
    Friend WithEvents btnLogin As System.Windows.Forms.Button
    Friend WithEvents FlatLabel2 As LibrarySystem.FlatLabel
    Friend WithEvents FlatLabel1 As LibrarySystem.FlatLabel
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents txtUsername As System.Windows.Forms.TextBox
    Friend WithEvents lblError As LibrarySystem.FlatLabel
    Friend WithEvents FlatClose1 As LibrarySystem.FlatClose
    Friend WithEvents FlatLabel3 As LibrarySystem.FlatLabel

End Class
