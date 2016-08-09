Imports MySql.Data.MySqlClient

Public Class frmOthers

    '===========================================================================================
    Sub companylist()
        Call main()
        Try
            cmd = New MySqlCommand("Select * from others_companies ", cn)
            dr = cmd.ExecuteReader
            Dim y As ListViewItem
            ListView1.Items.Clear()
            Do While dr.Read = True
                y = New ListViewItem(dr("id").ToString)
                y.SubItems.Add(dr("name"))
                ListView1.Items.Add(y)
            Loop
            dr.Close()
            lblCount1.Text = ListView1.Items.Count & "-Records"
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub
    '===========================================================================================
    Sub departmentlist()
        Call main()
        Try
            cmd = New MySqlCommand("Select * from others_departments ", cn)
            dr = cmd.ExecuteReader
            Dim y As ListViewItem
            ListView2.Items.Clear()
            Do While dr.Read = True
                y = New ListViewItem(dr("id").ToString)
                y.SubItems.Add(dr("name"))
                ListView2.Items.Add(y)
            Loop
            dr.Close()
            lblCount2.Text = ListView2.Items.Count & "-Records"
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub
    '===========================================================================================
    Sub locationlist()
        Call main()
        Try
            cmd = New MySqlCommand("Select * from others_locations ", cn)
            dr = cmd.ExecuteReader
            Dim y As ListViewItem
            ListView3.Items.Clear()
            Do While dr.Read = True
                y = New ListViewItem(dr("id").ToString)
                y.SubItems.Add(dr("name"))
                ListView3.Items.Add(y)
            Loop
            dr.Close()
            lblCount3.Text = ListView3.Items.Count & "-Records"
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub
    '===========================================================================================
    Sub companyaddresslist()
        Call main()
        Try
            cmd = New MySqlCommand("Select * from others_company_address", cn)
            dr = cmd.ExecuteReader
            Dim y As ListViewItem
            ListView4.Items.Clear()
            Do While dr.Read = True
                y = New ListViewItem(dr("id").ToString)
                y.SubItems.Add(dr("name"))
                ListView4.Items.Add(y)
            Loop
            dr.Close()
            lblCount4.Text = ListView4.Items.Count & "-Records"
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub frmOthers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        companylist()
        locationlist()
        departmentlist()
        companyaddresslist()
    End Sub

    Private Sub cmdSave_Click(sender As Object, e As EventArgs) Handles cmdSave.Click
        If Not (cmbType.Text = "" Or Trim(txtName.Text) = "") Then
            If MsgBox("Do you want to add?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                MsgBox("Added.", MsgBoxStyle.Information)
                If cmbType.Text = "COMPANY" Then
                    cmd = New MySqlCommand("INSERT INTO others_companies VALUES('" & "" & _
                                               "','" & Trim(txtName.Text) & "' )", cn)
                    cmd.ExecuteNonQuery()
                    companylist()
                ElseIf cmbType.Text = "DEPARTMENT" Then
                    cmd = New MySqlCommand("INSERT INTO others_departments VALUES('" & "" & _
                                            "','" & Trim(txtName.Text) & "' )", cn)
                    cmd.ExecuteNonQuery()
                    departmentlist()
                ElseIf cmbType.Text = "LOCATION" Then
                    cmd = New MySqlCommand("INSERT INTO others_locations VALUES('" & "" & _
                                            "','" & Trim(txtName.Text) & "' )", cn)
                    cmd.ExecuteNonQuery()
                    locationlist()
                ElseIf cmbType.Text = "COMPANY ADDRESS" Then
                    cmd = New MySqlCommand("INSERT INTO others_company_address VALUES('" & "" & _
                                            "','" & Trim(txtName.Text) & "' )", cn)
                    cmd.ExecuteNonQuery()
                    companyaddresslist()
                End If
                cmbType.Text = ""
                txtName.Text = ""
            End If
        Else
            MsgBox("Fill the required fields.", MsgBoxStyle.Information)
        End If
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class