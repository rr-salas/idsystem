<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGenerateID
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cmdSearch = New System.Windows.Forms.Button()
        Me.txtEmployeeNumber = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblCompany = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblHDMF = New System.Windows.Forms.Label()
        Me.lblPHIC = New System.Windows.Forms.Label()
        Me.lblTIN = New System.Windows.Forms.Label()
        Me.lblSSS = New System.Windows.Forms.Label()
        Me.lblAddress = New System.Windows.Forms.Label()
        Me.lblCPNumber = New System.Windows.Forms.Label()
        Me.lblContactPerson = New System.Windows.Forms.Label()
        Me.lblDepartment = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblIDNumber = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.lblIDDepartment = New System.Windows.Forms.Label()
        Me.lblIDName = New System.Windows.Forms.Label()
        Me.lblIDIDNumber = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 3)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(216, 36)
        Me.Label2.TabIndex = 29
        Me.Label2.Text = "Generate ID Card"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cmdSearch)
        Me.GroupBox2.Controls.Add(Me.txtEmployeeNumber)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(12, 38)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(386, 60)
        Me.GroupBox2.TabIndex = 30
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Search by:"
        '
        'cmdSearch
        '
        Me.cmdSearch.BackColor = System.Drawing.Color.White
        Me.cmdSearch.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.cmdSearch.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSearch.Location = New System.Drawing.Point(294, 20)
        Me.cmdSearch.Name = "cmdSearch"
        Me.cmdSearch.Size = New System.Drawing.Size(77, 26)
        Me.cmdSearch.TabIndex = 33
        Me.cmdSearch.Text = "Search"
        Me.cmdSearch.UseVisualStyleBackColor = False
        '
        'txtEmployeeNumber
        '
        Me.txtEmployeeNumber.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmployeeNumber.ForeColor = System.Drawing.Color.Black
        Me.txtEmployeeNumber.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txtEmployeeNumber.Location = New System.Drawing.Point(114, 20)
        Me.txtEmployeeNumber.MaxLength = 0
        Me.txtEmployeeNumber.Name = "txtEmployeeNumber"
        Me.txtEmployeeNumber.Size = New System.Drawing.Size(174, 23)
        Me.txtEmployeeNumber.TabIndex = 31
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(7, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 14)
        Me.Label1.TabIndex = 32
        Me.Label1.Text = "Employee Number:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblCompany)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.lblHDMF)
        Me.GroupBox1.Controls.Add(Me.lblPHIC)
        Me.GroupBox1.Controls.Add(Me.lblTIN)
        Me.GroupBox1.Controls.Add(Me.lblSSS)
        Me.GroupBox1.Controls.Add(Me.lblAddress)
        Me.GroupBox1.Controls.Add(Me.lblCPNumber)
        Me.GroupBox1.Controls.Add(Me.lblContactPerson)
        Me.GroupBox1.Controls.Add(Me.lblDepartment)
        Me.GroupBox1.Controls.Add(Me.lblName)
        Me.GroupBox1.Controls.Add(Me.lblIDNumber)
        Me.GroupBox1.Controls.Add(Me.Label18)
        Me.GroupBox1.Controls.Add(Me.Label17)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 104)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(386, 402)
        Me.GroupBox1.TabIndex = 31
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "ID Information"
        '
        'lblCompany
        '
        Me.lblCompany.AutoSize = True
        Me.lblCompany.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCompany.Location = New System.Drawing.Point(114, 173)
        Me.lblCompany.Name = "lblCompany"
        Me.lblCompany.Size = New System.Drawing.Size(0, 18)
        Me.lblCompany.TabIndex = 60
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(7, 177)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 18)
        Me.Label4.TabIndex = 59
        Me.Label4.Text = "Company:"
        '
        'lblHDMF
        '
        Me.lblHDMF.AutoSize = True
        Me.lblHDMF.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHDMF.Location = New System.Drawing.Point(114, 342)
        Me.lblHDMF.Name = "lblHDMF"
        Me.lblHDMF.Size = New System.Drawing.Size(0, 18)
        Me.lblHDMF.TabIndex = 58
        '
        'lblPHIC
        '
        Me.lblPHIC.AutoSize = True
        Me.lblPHIC.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPHIC.Location = New System.Drawing.Point(114, 312)
        Me.lblPHIC.Name = "lblPHIC"
        Me.lblPHIC.Size = New System.Drawing.Size(0, 18)
        Me.lblPHIC.TabIndex = 57
        '
        'lblTIN
        '
        Me.lblTIN.AutoSize = True
        Me.lblTIN.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTIN.Location = New System.Drawing.Point(114, 279)
        Me.lblTIN.Name = "lblTIN"
        Me.lblTIN.Size = New System.Drawing.Size(0, 18)
        Me.lblTIN.TabIndex = 56
        '
        'lblSSS
        '
        Me.lblSSS.AutoSize = True
        Me.lblSSS.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSSS.Location = New System.Drawing.Point(113, 249)
        Me.lblSSS.Name = "lblSSS"
        Me.lblSSS.Size = New System.Drawing.Size(0, 18)
        Me.lblSSS.TabIndex = 55
        '
        'lblAddress
        '
        Me.lblAddress.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddress.Location = New System.Drawing.Point(113, 215)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(258, 52)
        Me.lblAddress.TabIndex = 54
        '
        'lblCPNumber
        '
        Me.lblCPNumber.AutoSize = True
        Me.lblCPNumber.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCPNumber.Location = New System.Drawing.Point(113, 144)
        Me.lblCPNumber.Name = "lblCPNumber"
        Me.lblCPNumber.Size = New System.Drawing.Size(0, 18)
        Me.lblCPNumber.TabIndex = 53
        '
        'lblContactPerson
        '
        Me.lblContactPerson.AutoSize = True
        Me.lblContactPerson.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblContactPerson.Location = New System.Drawing.Point(113, 112)
        Me.lblContactPerson.Name = "lblContactPerson"
        Me.lblContactPerson.Size = New System.Drawing.Size(0, 18)
        Me.lblContactPerson.TabIndex = 52
        '
        'lblDepartment
        '
        Me.lblDepartment.AutoSize = True
        Me.lblDepartment.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDepartment.Location = New System.Drawing.Point(114, 82)
        Me.lblDepartment.Name = "lblDepartment"
        Me.lblDepartment.Size = New System.Drawing.Size(0, 18)
        Me.lblDepartment.TabIndex = 51
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(113, 54)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(0, 18)
        Me.lblName.TabIndex = 50
        '
        'lblIDNumber
        '
        Me.lblIDNumber.AutoSize = True
        Me.lblIDNumber.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIDNumber.Location = New System.Drawing.Point(114, 27)
        Me.lblIDNumber.Name = "lblIDNumber"
        Me.lblIDNumber.Size = New System.Drawing.Size(0, 18)
        Me.lblIDNumber.TabIndex = 49
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(7, 342)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(49, 18)
        Me.Label18.TabIndex = 44
        Me.Label18.Text = "HDMF:"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(7, 312)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(41, 18)
        Me.Label17.TabIndex = 43
        Me.Label17.Text = "PHIC:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(7, 279)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(33, 18)
        Me.Label16.TabIndex = 43
        Me.Label16.Text = "TIN:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(7, 249)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(33, 18)
        Me.Label15.TabIndex = 44
        Me.Label15.Text = "SSS:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(7, 215)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(62, 18)
        Me.Label13.TabIndex = 42
        Me.Label13.Text = "Address:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(7, 144)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(82, 18)
        Me.Label11.TabIndex = 40
        Me.Label11.Text = "CP Number:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(7, 112)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(105, 18)
        Me.Label9.TabIndex = 38
        Me.Label9.Text = "Contact Person:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(7, 82)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(87, 18)
        Me.Label7.TabIndex = 36
        Me.Label7.Text = "Department:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(7, 54)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 18)
        Me.Label5.TabIndex = 34
        Me.Label5.Text = "Name:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(7, 27)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 18)
        Me.Label3.TabIndex = 32
        Me.Label3.Text = "ID Number:"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(716, 180)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(76, 54)
        Me.Button1.TabIndex = 84
        Me.Button1.Text = "Print"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.PictureBox4)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Controls.Add(Me.lblIDDepartment)
        Me.Panel1.Controls.Add(Me.lblIDName)
        Me.Panel1.Controls.Add(Me.lblIDIDNumber)
        Me.Panel1.Controls.Add(Me.PictureBox3)
        Me.Panel1.Location = New System.Drawing.Point(404, 48)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(306, 459)
        Me.Panel1.TabIndex = 85
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.White
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.ErrorImage = Nothing
        Me.PictureBox1.InitialImage = Nothing
        Me.PictureBox1.Location = New System.Drawing.Point(121, 122)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(185, 235)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 97
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.White
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBox2.Location = New System.Drawing.Point(16, 228)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(95, 60)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 98
        Me.PictureBox2.TabStop = False
        '
        'lblIDDepartment
        '
        Me.lblIDDepartment.BackColor = System.Drawing.Color.Transparent
        Me.lblIDDepartment.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIDDepartment.Location = New System.Drawing.Point(22, 428)
        Me.lblIDDepartment.Name = "lblIDDepartment"
        Me.lblIDDepartment.Size = New System.Drawing.Size(268, 22)
        Me.lblIDDepartment.TabIndex = 88
        Me.lblIDDepartment.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblIDName
        '
        Me.lblIDName.BackColor = System.Drawing.Color.Transparent
        Me.lblIDName.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIDName.Location = New System.Drawing.Point(22, 361)
        Me.lblIDName.Name = "lblIDName"
        Me.lblIDName.Size = New System.Drawing.Size(268, 60)
        Me.lblIDName.TabIndex = 87
        '
        'lblIDIDNumber
        '
        Me.lblIDIDNumber.AutoSize = True
        Me.lblIDIDNumber.BackColor = System.Drawing.Color.Transparent
        Me.lblIDIDNumber.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIDIDNumber.Location = New System.Drawing.Point(175, 57)
        Me.lblIDIDNumber.Name = "lblIDIDNumber"
        Me.lblIDIDNumber.Size = New System.Drawing.Size(0, 32)
        Me.lblIDIDNumber.TabIndex = 86
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.PictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox3.ErrorImage = Nothing
        Me.PictureBox3.InitialImage = Nothing
        Me.PictureBox3.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(306, 458)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 99
        Me.PictureBox3.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.Color.White
        Me.PictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBox4.Location = New System.Drawing.Point(16, 110)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(159, 60)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 100
        Me.PictureBox4.TabStop = False
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(753, 436)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(142, 20)
        Me.TextBox1.TabIndex = 86
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(716, 248)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(76, 54)
        Me.Button2.TabIndex = 87
        Me.Button2.Text = "SAVE"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'frmGenerateID
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1191, 516)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmGenerateID"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " "
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtEmployeeNumber As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmdSearch As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents lblHDMF As System.Windows.Forms.Label
    Friend WithEvents lblPHIC As System.Windows.Forms.Label
    Friend WithEvents lblTIN As System.Windows.Forms.Label
    Friend WithEvents lblSSS As System.Windows.Forms.Label
    Friend WithEvents lblAddress As System.Windows.Forms.Label
    Friend WithEvents lblCPNumber As System.Windows.Forms.Label
    Friend WithEvents lblContactPerson As System.Windows.Forms.Label
    Friend WithEvents lblDepartment As System.Windows.Forms.Label
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents lblIDNumber As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents lblIDIDNumber As System.Windows.Forms.Label
    Friend WithEvents lblIDName As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents lblIDDepartment As System.Windows.Forms.Label
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents lblCompany As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
End Class
