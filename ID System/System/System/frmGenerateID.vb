Imports MySql.Data.MySqlClient
Imports System.Drawing.Printing
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.ComponentModel

Public Class frmGenerateID

    Private Sub cmdSearch_Click(sender As Object, e As EventArgs) Handles cmdSearch.Click
        Dim midd As String

        ' Try
        Call main()
        cmd = New MySqlCommand("Select * from employee_information where employeenumber='" & Trim(txtEmployeeNumber.Text) & "'", cn)
        dr = cmd.ExecuteReader
        If dr.HasRows Then
            MsgBox("Data found.", MsgBoxStyle.Information)
            dr.Read()
            midd = dr("middlename")
            lblIDNumber.Text = dr("IDnumber")
            lblName.Text = dr("FirstName") & " " & midd.Substring(0, 1) & "." & " " & dr("LastName")
            lblDepartment.Text = dr("Department")
            lblContactPerson.Text = dr("ContactPerson")
            lblCPNumber.Text = dr("CpNumber")
            lblAddress.Text = dr("address")
            lblSSS.Text = dr("SSS")
            lblTIN.Text = dr("TIN")
            lblPHIC.Text = dr("PHIC")
            lblHDMF.Text = dr("HDMF")
            lblCompany.Text = dr("Company")
            '=============      
            lblIDIDNumber.Text = dr("IDNumber")
            lblIDName.Text = dr("FirstName") & " " & midd.Substring(0, 1) & "." & " " & dr("LastName")
            TextBox1.Text = dr("FirstName") & " " & midd.Substring(0, 1) & "." & " " & dr("LastName")
            lblIDDepartment.Text = dr("Department")
        Else
            MsgBox("No data found.", MsgBoxStyle.Exclamation)
            clear()
        End If
        dr.Close()
        generateimage()
        generatefront()
        'generatelogo()
        txtEmployeeNumber.Text = ""
        'Catch ex As Exception
        '    MsgBox(ex.Message, MsgBoxStyle.Critical)
        'End Try
    End Sub
    Sub generateimage()
        Dim arrImage() As Byte
        Dim arrImage1() As Byte
        cmd = New MySqlCommand("Select * from images_employee where employeenumber='" & Trim(txtEmployeeNumber.Text) & "'", cn)
        dr = cmd.ExecuteReader
        If dr.HasRows Then
            dr.Read()
            arrImage = dr("employeephoto")
            arrImage1 = dr("employeesignature")
            Dim mstream As New System.IO.MemoryStream(arrImage)
            Dim mstream1 As New System.IO.MemoryStream(arrImage1)

            PictureBox1.Image = Image.FromStream(mstream)
            PictureBox2.Image = Image.FromStream(mstream1)
            dr.Close()
        Else
            PictureBox1.Image = Nothing
            PictureBox2.Image = Nothing

        End If
        dr.Close()
    End Sub
    Sub generatefront()
        Dim arrImage() As Byte
        cmd = New MySqlCommand("Select * from images_idcolor where color in (Select color from others_departments where name= '" & lblDepartment.Text & "')", cn)
        dr = cmd.ExecuteReader
        If dr.HasRows Then
            dr.Read()
            arrImage = dr("front")
            Dim mstream As New System.IO.MemoryStream(arrImage)
            PictureBox3.Image = Image.FromStream(mstream)
        Else
            PictureBox3.Image = Nothing

        End If
        dr.Close()
    End Sub
    Sub generatelogo()
        Dim arrImage() As Byte
        cmd = New MySqlCommand("Select * from images_companylogo where name='" & lblCompany.Text & "'", cn)
        dr = cmd.ExecuteReader
        If dr.HasRows Then
            dr.Read()
            arrImage = dr("logo")
            Dim mstream As New System.IO.MemoryStream(arrImage)
            PictureBox4.Image = Image.FromStream(mstream)
        Else
            PictureBox4.Image = Nothing
        End If
        dr.Close()
    End Sub
    Sub clear()
        lblIDNumber.Text = ""
        lblName.Text = ""
        lblDepartment.Text = ""
        lblContactPerson.Text = ""
        lblCPNumber.Text = ""
        lblAddress.Text = ""
        lblSSS.Text = ""
        lblTIN.Text = ""
        lblPHIC.Text = ""
        lblHDMF.Text = ""
        lblCompany.Text = ""
        lblIDIDNumber.Text = ""
        lblIDName.Text = ""
        lblIDDepartment.Text = ""
    End Sub

    Private Sub txtEmployeeNumber_KeyDown(sender As Object, e As KeyEventArgs) Handles txtEmployeeNumber.KeyDown
        If e.KeyCode = Keys.Enter Then
            cmdSearch_Click(sender, New System.EventArgs())
        End If
    End Sub

    Private BMP As Bitmap
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim pd As New PrintDocument
        Dim pdialog As New PrintDialog

        BMP = New Bitmap(PictureBox3.Width, PictureBox3.Height, System.Drawing.Imaging.PixelFormat.Format32bppArgb)
        PictureBox3.DrawToBitmap(BMP, New Rectangle(0, 0, 811, 1280))
        AddHandler pd.PrintPage, (Sub(s, args)
                                      args.Graphics.DrawImage(BMP, 0, 0)
                                      args.HasMorePages = False
                                  End Sub)
        'choose a printer
        If pdialog.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
            pd.PrinterSettings.PrinterName = pdialog.PrinterSettings.PrinterName
            pd.Print()
        End If
    End Sub

    Private Sub frmGenerateID_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PictureBox4.Parent = PictureBox3
        PictureBox2.Parent = PictureBox3
        PictureBox1.Parent = PictureBox3
        lblIDIDNumber.Parent = PictureBox3
        lblIDName.Parent = PictureBox3
        lblIDDepartment.Parent = PictureBox3


        PictureBox2.SendToBack()
        PictureBox1.SendToBack()
        PictureBox4.BringToFront()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        lblIDName.Text = TextBox1.Text
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        PictureBox4.Parent = PictureBox3
        PictureBox2.Parent = PictureBox3
        PictureBox1.Parent = PictureBox3
        lblIDIDNumber.Parent = PictureBox3
        lblIDName.Parent = PictureBox3
        lblIDDepartment.Parent = PictureBox3


        PictureBox2.BringToFront()
        PictureBox1.SendToBack()
        PictureBox4.BringToFront()

        BMP = New Bitmap(PictureBox3.Width, PictureBox3.Height, System.Drawing.Imaging.PixelFormat.Format32bppArgb)
        PictureBox3.DrawToBitmap(BMP, New Rectangle(0, 0, 811, 1280))

        SaveFileDialog1.Filter = "Picture File|*.*|Bitmap|*.bmp|GIF|*.gif|JPEG|*.jpg|PNG|*.png"
        SaveFileDialog1.ShowDialog()

        If SaveFileDialog1.FileName.Length > 0 Then
            BMP.Save(SaveFileDialog1.FileName)
        End If

    End Sub
End Class