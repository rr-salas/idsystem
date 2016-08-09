Imports MySql.Data.MySqlClient
Imports System.IO
Imports System.Text
Imports System.Security.Cryptography
Public Class frmUser
    '=====================user list======================================================================
    Sub userlist(ByVal search As String)
        Call main()
        Try
            cmd = New MySqlCommand("Select * from user where user_id like '%" & search & "%' or user_name like '%" & search & "%' or last_name like '%" & search & "%'  or first_name like '%" & search & "%'  or user_type like '%" & search & "%'", cn)
            dr = cmd.ExecuteReader
            Dim y As ListViewItem
            ListView1.Items.Clear()
            Do While dr.Read = True
                y = New ListViewItem(dr("user_id").ToString)
                y.SubItems.Add(dr("user_name"))
                y.SubItems.Add(dr("last_name"))
                y.SubItems.Add(dr("first_name"))
                y.SubItems.Add(dr("user_type"))
                ListView1.Items.Add(y)
            Loop
            dr.Close()
            lblCount.Text = ListView1.Items.Count & "-Records"
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub
    Private Sub frmUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        userlist("")
    End Sub
    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        userlist(Trim(txtSearch.Text))
    End Sub
    '======================cleardata======================================================================
    Sub clear()
        txtUserID.Text = ""
        txtUsername.Text = ""
        txtPassword.Text = ""
        txtLastName.Text = ""
        txtFirstName.Text = ""
        cmbUserType.Text = ""
    End Sub
    '=======================increment======================================================================
    Sub lastrecord()
        Call main()
        Dim a As String
        cmd = New MySqlCommand("Select max(id) as userid from user", cn)
        dr = cmd.ExecuteReader
        dr.Read()
        a = (dr("userid") + 1) + 1000
        txtUserID.Text = a.Remove(0, 1)
        dr.Close()
    End Sub
    '=================Password Encryption==================================================================
    Private Function md5(sPassword As String) As String
        Dim x As New System.Security.Cryptography.MD5CryptoServiceProvider()
        Dim bs As Byte() = System.Text.Encoding.UTF8.GetBytes(sPassword)
        bs = x.ComputeHash(bs)
        Dim s As New System.Text.StringBuilder()
        For Each b As Byte In bs
            s.Append(b.ToString("x2").ToLower())
        Next
        Return s.ToString()
    End Function
    '====================add button========================================================================
    Private Sub cmdAdd_Click(sender As Object, e As EventArgs) Handles cmdAdd.Click
        gb1.Enabled = False
        gb2.Enabled = True
        cmdSave.Enabled = True
        cmdUpdate.Enabled = False
        cmdCancel.Enabled = True
        txtUsername.Focus()
        lastrecord()
    End Sub
    '=======================save button=========================================================================
    Private Sub cmdSave_Click(sender As Object, e As EventArgs) Handles cmdSave.Click
        Try
            Call main()
            If Not (Trim(txtUserID.Text) = "" Or Trim(txtUsername.Text) = "" Or Trim(txtLastName.Text) = "" Or Trim(txtFirstName.Text) = "" Or cmbUserType.Text = "") Then
                If txtUsername.TextLength > 4 Then
                    If txtPassword.TextLength > 4 Then
                        If MsgBox("Do you want to save?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                            cmd = New MySqlCommand("INSERT INTO user VALUES('" & "" & _
                                                   "','" & txtUserID.Text & _
                                                   "','" & Trim(txtUsername.Text) & _
                                                   "','" & md5(Trim(txtPassword.Text)) & _
                                                   "','" & Trim(txtLastName.Text) & _
                                                   "','" & Trim(txtFirstName.Text) & _
                                                   "','" & cmbUserType.Text & "' )", cn)
                            cmd.ExecuteNonQuery()
                            clear()
                            userlist("")
                            lastrecord()
                            txtUsername.Focus()
                        End If
                    Else
                        MsgBox("Password atleast 5 characters.", MsgBoxStyle.Information)
                        txtPassword.Focus()
                    End If
                Else
                    MsgBox("Username atleast 5 characters.", MsgBoxStyle.Information)
                    txtUsername.Focus()
                End If
            Else
                MsgBox("Please fill all the required fields.", MsgBoxStyle.Information)
                txtUsername.Focus()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub
    '=========================edit button==============================================================================
    Private Sub cmdEdit_Click(sender As Object, e As EventArgs) Handles cmdEdit.Click
        If ListView1.SelectedItems.Count > 0 Then
            gb1.Enabled = False
            gb2.Enabled = True
            cmdSave.Enabled = False
            cmdUpdate.Enabled = True
            cmdCancel.Enabled = True
            txtUsername.Focus()
            txtUserID.Text = ListView1.SelectedItems(0).Text
            txtUsername.Text = ListView1.SelectedItems(0).SubItems(1).Text
            txtLastName.Text = ListView1.SelectedItems(0).SubItems(2).Text
            txtFirstName.Text = ListView1.SelectedItems(0).SubItems(3).Text
            cmbUserType.Text = ListView1.SelectedItems(0).SubItems(4).Text
        Else
            MsgBox("Please select user.", MsgBoxStyle.Critical)
        End If
    End Sub
    '======================update button==============================================================================
    Private Sub cmdUpdate_Click(sender As Object, e As EventArgs) Handles cmdUpdate.Click
        Try
            Call main()
            If Not (Trim(txtUserID.Text) = "" Or Trim(txtUsername.Text) = "" Or Trim(txtLastName.Text) = "" Or Trim(txtFirstName.Text) = "" Or cmbUserType.Text = "") Then
                If txtUsername.TextLength > 4 Then
                    If txtPassword.TextLength > 4 Then
                        If MsgBox("Do you want to update?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                            cmd = New MySqlCommand("UPDATE user SET user_name= '" & txtUsername.Text & _
                                      "', password = '" & md5(txtPassword.Text) & _
                                      "', last_name = '" & Trim(txtLastName.Text) & _
                                      "', first_name = '" & Trim(txtFirstName.Text) & _
                                       "', user_type = '" & cmbUserType.Text & _
                                      "' WHERE user_id = '" & txtUserID.Text & "'", cn)
                            cmd.ExecuteNonQuery()
                            MsgBox("Updated.", MsgBoxStyle.Information)
                            clear()
                            userlist("")
                            gb1.Enabled = True
                            gb2.Enabled = False
                        End If
                    Else
                        MsgBox("Password atleast 5 characters.", MsgBoxStyle.Information)
                        txtPassword.Focus()
                    End If
                Else
                    MsgBox("Username atleast 5 characters.", MsgBoxStyle.Information)
                    txtUsername.Focus()
                End If
            Else
                MsgBox("Please fill all the required fields.", MsgBoxStyle.Information)
                txtUsername.Focus()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub
    '======================delete button=================================================================================
    Private Sub cmdDelete_Click(sender As Object, e As EventArgs) Handles cmdDelete.Click
        If ListView1.SelectedItems.Count > 0 Then
        Else
            MsgBox("Please select user.", MsgBoxStyle.Critical)
        End If
    End Sub
    '==============cancel button==========================================================================================
    Private Sub cmdCancel_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click
        gb1.Enabled = True
        gb2.Enabled = False
        clear()
        txtSearch.Focus()
    End Sub


End Class