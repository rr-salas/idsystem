Imports MySql.Data
Imports MySql.Data.MySqlClient
Public Class frmAddEmployee
    Dim a As OpenFileDialog = New OpenFileDialog
    Dim lr As String
    Private Sub frmAddEmployee_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        complist()
        deptlist()
        loclist()
    End Sub
    '===============================save button===========================================================================================
    Private Sub cmdSave_Click(sender As Object, e As EventArgs) Handles cmdSave.Click
        Try
            If Not (Trim(txtLastName.Text) = "" Or Trim(txtFirstName.Text) = "" Or cmbGender.Text = "" Or cmbMaritalStatus.Text = "" _
            Or Trim(txtAddress.Text) = "" Or Trim(txtContactNumber.Text) = "" Or Trim(txtContactPerson.Text) = "" Or Trim(txtCPNumber.Text) = "" _
            Or cmbCompany.Text = "" Or cmbLocation.Text = "" Or cmbDepartment.Text = "" Or Trim(txtPosition.Text) = "" Or cmbEmployeeStatus.Text = "") Then

                If MsgBox("Do you want to add employee?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                    cmd = New MySqlCommand("INSERT INTO employee_images VALUES('" & "" & _
                                               "','" & txtEmployeeNumber.Text & _
                                               "','" & "" & _
                                               "','" & "" & "' )", cn)
                    cmd.ExecuteNonQuery()
                    '==========================insert image=================================================================================
                    If Not (PictureBox1.Image Is Nothing Or PictureBox2.Image Is Nothing) Then
                        Dim mstream As New System.IO.MemoryStream()
                        Dim mstream1 As New System.IO.MemoryStream()
                        PictureBox1.Image.Save(mstream, System.Drawing.Imaging.ImageFormat.Jpeg)
                        PictureBox2.Image.Save(mstream1, System.Drawing.Imaging.ImageFormat.Jpeg)
                        Dim arrImage() As Byte = mstream.GetBuffer()
                        Dim arrImage1() As Byte = mstream1.GetBuffer()
                        mstream.Close()
                        mstream1.Close()
                        cmd = New MySqlCommand("UPDATE employee_images SET employee_photo= @Photo , employee_signature=@Photo1 WHERE employee_number = @id", cn)
                        cmd.Parameters.AddWithValue("@id", txtEmployeeNumber.Text)
                        cmd.Parameters.AddWithValue("@Photo", arrImage)
                        cmd.Parameters.AddWithValue("@Photo1", arrImage1)
                        cmd.ExecuteNonQuery()
                    End If
                    '===========================insert employee data ======================================================================
                    cmd = New MySqlCommand("INSERT INTO employee_information VALUES('" & txtEmployeeNumber.Text & _
                                          "','" & txtEmployeeNumber.Text & _
                                          "','" & Trim(StrConv(txtLastName.Text, VbStrConv.Uppercase)) & _
                                          "','" & Trim(StrConv(txtFirstName.Text, VbStrConv.Uppercase)) & _
                                          "','" & Trim(StrConv(txtMiddleName.Text, VbStrConv.Uppercase)) & _
                                          "','" & cmbGender.Text & _
                                          "','" & cmbMaritalStatus.Text & _
                                          "','" & dtDateBirth.Value.ToString("yyyy-MM-dd") & _
                                          "','" & txtContactNumber.Text & _
                                          "','" & Trim(StrConv(txtAddress.Text, VbStrConv.Uppercase)) & _
                                          "','" & Trim(StrConv(txtContactPerson.Text, VbStrConv.Uppercase)) & _
                                          "','" & txtCPNumber.Text & _
                                          "','" & dtDateHired.Value.ToString("yyyy-MM-dd") & _
                                          "','" & cmbCompany.Text & _
                                          "','" & cmbLocation.Text & _
                                          "','" & cmbDepartment.Text & _
                                          "','" & Trim(StrConv(txtPosition.Text, VbStrConv.Uppercase)) & _
                                          "','" & cmbEmployeeStatus.Text & _
                                          "','" & txtSSS.Text & _
                                          "','" & txtPHIC.Text & _
                                          "','" & txtHDMF.Text & _
                                          "','" & txtTIN.Text & "' )", cn)
                    cmd.ExecuteNonQuery()
                    '==========================================================================

                    MsgBox("Employee added.", MsgBoxStyle.Information)
                    clear()
                    lastrecord()
                End If
            Else
                MsgBox("Fill all the required information.", MsgBoxStyle.Information)
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub
    '==============================clear text fields==========================================================
    Sub clear()
        txtEmployeeNumber.Text = ""
        txtLastName.Text = ""
        txtFirstName.Text = ""
        txtMiddleName.Text = ""
        cmbGender.Text = ""
        cmbMaritalStatus.Text = ""
        txtContactNumber.Text = ""
        txtAddress.Text = ""
        txtContactPerson.Text = ""
        txtCPNumber.Text = ""
        cmbCompany.Text = ""
        cmbDepartment.Text = ""
        cmbLocation.Text = ""
        txtPosition.Text = ""
        cmbEmployeeStatus.Text = ""
        txtSSS.Text = ""
        txtPHIC.Text = ""
        txtTIN.Text = ""
        txtHDMF.Text = ""
        PictureBox1.Image = Nothing
        PictureBox2.Image = Nothing
    End Sub
    '===============================upload employee photo=======================================
    Private Sub cmdUpload_Click(sender As Object, e As EventArgs) Handles cmdUpload.Click
        Try
            a.Filter = "Picture File|*.*|Bitmap|*.bmp|GIF|*.gif|JPEG|*.jpg|PNG|*.png"
            If a.ShowDialog() = Windows.Forms.DialogResult.OK Then
                PictureBox1.Image = Image.FromFile(a.FileName)
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub
    Private Sub cmdClear_Click(sender As Object, e As EventArgs) Handles cmdClear.Click
        Try
            PictureBox1.Image = Nothing
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub
    '===============================upload employee signature===================================
    Private Sub cmdUpload1_Click(sender As Object, e As EventArgs) Handles cmdUpload1.Click
        Try
            a.Filter = "Picture File|*.*|Bitmap|*.bmp|GIF|*.gif|JPEG|*.jpg|PNG|*.png"
            If a.ShowDialog() = Windows.Forms.DialogResult.OK Then
                PictureBox2.Image = Image.FromFile(a.FileName)
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub
    Private Sub cmdClear1_Click(sender As Object, e As EventArgs) Handles cmdClear1.Click
        Try
            PictureBox2.Image = Nothing
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub
    '===============generate location dept and company=====================================================
    Sub deptlist()
        Call main()
        cmd = New MySqlCommand("Select * from others_departments order by name asc", cn)
        dr = cmd.ExecuteReader
        cmbDepartment.Items.Clear()
        cmbDepartment.Items.Add("")
        Do While dr.Read
            cmbDepartment.Items.Add(StrConv(dr("name"), VbStrConv.Uppercase))
        Loop
        dr.Close()
    End Sub
    Sub complist()
        Call main()
        cmd = New MySqlCommand("Select * from others_companies order by name asc", cn)
        dr = cmd.ExecuteReader
        cmbCompany.Items.Clear()
        cmbCompany.Items.Add("")
        Do While dr.Read
            cmbCompany.Items.Add(StrConv(dr("name"), VbStrConv.Uppercase))
        Loop
        dr.Close()
    End Sub
    Sub loclist()
        Call main()
        cmd = New MySqlCommand("Select * from others_locations order by name asc", cn)
        dr = cmd.ExecuteReader
        cmbLocation.Items.Clear()
        cmbLocation.Items.Add("")
        Do While dr.Read
            cmbLocation.Items.Add(StrConv(dr("name"), VbStrConv.Uppercase))
        Loop
        dr.Close()
    End Sub
    '=========================cancel button============================================================
    Private Sub cmdCancel_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click
        Me.Close()
    End Sub

    'Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
    '    SaveFileDialog1.Filter = "Picture File|*.*|Bitmap|*.bmp|GIF|*.gif|JPEG|*.jpg|PNG|*.png"
    '    SaveFileDialog1.ShowDialog()
    '    If SaveFileDialog1.FileName.Length > 0 Then

    '        PictureBox1.Image.Save(SaveFileDialog1.FileName)
    '    End If
    'End Sub

    Private Sub frmAddEmployee_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lastrecord()
    End Sub
    Sub lastrecord()
        Call main()
        cmd = New MySqlCommand("Select max(id) as userid from employee_information", cn)
        dr = cmd.ExecuteReader
        dr.Read()
        lblID.Text = (dr("userid") + 1)
        lr = (dr("userid") + 1) + 100000000
        txtEmployeeNumber.Text = lr.Remove(0, 1)
        dr.Close()
    End Sub
End Class