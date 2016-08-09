Imports MySql.Data.MySqlClient

Public Class frmViewImage

    Sub generateimage()
        Try
            Dim arrImage() As Byte
            Dim arrImage1() As Byte
            cmd = New MySqlCommand("Select * from employee_images where employee_number='" & Trim(lblEmployeeNumber.Text) & "'", cn)
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
    Private Sub frmViewImage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        generateimage()
    End Sub
End Class