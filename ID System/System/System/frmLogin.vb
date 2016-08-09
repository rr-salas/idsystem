Imports MySql.Data.MySqlClient

Public Class frmLogin

    Private Sub cmdLogin_Click(sender As Object, e As EventArgs) Handles cmdLogin.Click
        Call main()
        Try
            cmd = New MySqlCommand("Select * from user where user_name= '" & txtUserName.Text & "' and password = MD5('" & txtPassword.Text & "')", cn)
            dr = cmd.ExecuteReader
            If dr.Read = True Then
                uname = dr("first_name") & " " & dr("last_name")
                usertype = dr("user_type")
                uid = dr("user_id")
                MsgBox("Welcome " & uname & ".", MsgBoxStyle.Information)
                dr.Close()
                frmMain.tsname.Text = usertype & "-" & uname
                Me.Hide()
                frmMain.Show()
            Else
                MsgBox("Access denied", vbExclamation)
                txtUserName.Text = ""
                txtPassword.Text = ""
                txtUserName.Focus()
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub cmdDelete_Click(sender As Object, e As EventArgs) Handles cmdDelete.Click
        Me.Close()
    End Sub

    Private Sub txtUserName_KeyDown(sender As Object, e As Windows.Forms.KeyEventArgs) Handles txtUserName.KeyDown
        If e.KeyCode = Keys.Enter Then
            cmdLogin_Click(sender, New System.EventArgs())
        End If
    End Sub

    Private Sub txtPassword_KeyDown(sender As Object, e As Windows.Forms.KeyEventArgs) Handles txtPassword.KeyDown
        If e.KeyCode = Keys.Enter Then

            cmdLogin_Click(sender, New System.EventArgs())
        End If
    End Sub


End Class