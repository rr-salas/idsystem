Imports MySql.Data.MySqlClient

Public Class frmEditEmployee
    Dim a As OpenFileDialog = New OpenFileDialog
    Private Sub cndUpdate_Click(sender As Object, e As EventArgs) Handles cndUpdate.Click
        If Not (Trim(txtLastName.Text) = "" Or Trim(txtFirstName.Text) = "" Or cmbGender.Text = "" Or cmbMaritalStatus.Text = "" _
            Or Trim(txtAddress.Text) = "" Or Trim(txtContactNumber.Text) = "" Or Trim(txtContactPerson.Text) = "" Or Trim(txtCPNumber.Text) = "" _
            Or cmbCompany.Text = "" Or cmbLocation.Text = "" Or cmbDepartment.Text = "" Or Trim(txtPosition.Text) = "" Or cmbEmployeeStatus.Text = "") Then
            If MsgBox("Do you want to update?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                cmd = New MySqlCommand("UPDATE employee_information SET last_name= '" & Trim(StrConv(txtLastName.Text, VbStrConv.Uppercase)) & _
                                  "', first_name = '" & Trim(StrConv(txtFirstName.Text, VbStrConv.Uppercase)) & _
                                  "', middle_name = '" & Trim(StrConv(txtMiddleName.Text, VbStrConv.Uppercase)) & _
                                  "', gender = '" & cmbGender.Text & _
                                  "', marital_status = '" & cmbMaritalStatus.Text & _
                                  "', date_birth = '" & dtDateBirth.Value.ToString("yyyy-MM-dd") & _
                                  "', contact_number = '" & txtContactNumber.Text & _
                                  "', address = '" & Trim(StrConv(txtAddress.Text, VbStrConv.Uppercase)) & _
                                  "', contact_person = '" & Trim(StrConv(txtContactPerson.Text, VbStrConv.Uppercase)) & _
                                  "', cp_number = '" & txtCPNumber.Text & _
                                  "', date_hired = '" & dtDateHired.Value.ToString("yyyy-MM-dd") & _
                                  "', company = '" & cmbCompany.Text & _
                                  "', location = '" & cmbLocation.Text & _
                                  "', department = '" & cmbDepartment.Text & _
                                  "', position = '" & Trim(StrConv(txtPosition.Text, VbStrConv.Uppercase)) & _
                                  "', employee_status = '" & cmbEmployeeStatus.Text & _
                                  "', sss = '" & txtSSS.Text & _
                                  "', phic = '" & txtPHIC.Text & _
                                  "', hdmf = '" & txtHDMF.Text & _
                                  "', tin = '" & txtTIN.Text & _
                                  "' WHERE employee_number = '" & txtEmployeeNumber.Text & "'", cn)
                cmd.ExecuteNonQuery()
                '==========================insert image=================================================================================
                If Not (PictureBox1.Image Is Nothing Or PictureBox2.Image Is Nothing) Then
                    Dim mstream As New System.IO.MemoryStream()
                    Dim mstream1 As New System.IO.MemoryStream
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
                Else
                    cmd = New MySqlCommand("UPDATE employee_images SET employee_photo= @Photo , employee_signature=@Photo1 WHERE employee_number = @id", cn)
                    cmd.Parameters.AddWithValue("@id", txtEmployeeNumber.Text)
                    cmd.Parameters.AddWithValue("@Photo", "")
                    cmd.Parameters.AddWithValue("@Photo1", "")
                    cmd.ExecuteNonQuery()
                End If
                '=====================================================================================================================
                MsgBox("Updated.", MsgBoxStyle.Information)
                Me.Close()
            End If
        Else
            MsgBox("Fill all the required information.", MsgBoxStyle.Information)
        End If
    End Sub
    Private Sub frmEditEmployee_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        generateimage()
    End Sub

    Sub generateimage()
        Try
            Dim arrImage() As Byte
            Dim arrImage1() As Byte
            cmd = New MySqlCommand("Select * from employee_images where employee_number='" & Trim(txtEmployeeNumber.Text) & "'", cn)
            dr = cmd.ExecuteReader
            If dr.HasRows Then
                dr.Read()
                arrImage = dr("employee_photo")
                arrImage1 = dr("employee_signature")
                dr.Close()
                Dim mstream As New System.IO.MemoryStream(arrImage)
                Dim mstream1 As New System.IO.MemoryStream(arrImage1)
                PictureBox1.Image = Image.FromStream(mstream)
                PictureBox2.Image = Image.FromStream(mstream1)
            Else
                PictureBox1.Image = Nothing
                PictureBox2.Image = Nothing
                dr.Close()
            End If
            dr.Close()
        Catch
            PictureBox1.Image = Nothing
            PictureBox2.Image = Nothing
        End Try
    End Sub

    Private Sub cmdClear_Click(sender As Object, e As EventArgs) Handles cmdClear.Click
        Try
            PictureBox1.Image = Nothing
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

    Private Sub cmdCancel_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click
        Me.Close()
    End Sub
End Class