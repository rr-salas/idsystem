Imports MySql.Data
Imports MySql.Data.MySqlClient
Imports System.Net.Mime.MediaTypeNames
Imports Microsoft.Office.Interop

Public Class frmEmployeeList
    Sub employeelist(ByVal all As String, ByVal nam As String, ByVal gen As String, ByVal mstat As String, ByVal addr As String, _
                     ByVal comp As String, ByVal loca As String, ByVal dept As String, ByVal es As String, ByVal pos As String)
        Call main()
        Try
            cmd = New MySqlCommand("Select * from employee_information where (employee_number like '%" & all & _
                                   "%' or last_name like '%" & all & _
                                   "%' or first_name like '%" & all & _
                                   "%' or middle_name like '%" & all & _
                                   "%' or gender like '" & all & _
                                   "%' or marital_status like '%" & all & _
                                   "%' or contact_number like '%" & all & _
                                   "%' or address like '%" & all & _
                                   "%' or contact_person like '%" & all & _
                                   "%' or cp_number like '%" & all & _
                                   "%' or company like '%" & all & _
                                   "%' or location like '%" & all & _
                                   "%' or department like '" & all & _
                                   "%' or position like '%" & all & _
                                   "%' or employee_status like '%" & all & _
                                   "%' or sss like '%" & all & _
                                   "%' or phic like '%" & all & _
                                   "%' or hdmf like '%" & all & _
                                   "%' or tin like '%" & all & _
                                   "%') and ( last_name like '%" & nam & _
                                   "%' or first_name like '%" & nam & _
                                   "%' or middle_name like '%" & nam & _
                                   "%') and gender like '" & gen & _
                                   "%' and marital_status like '%" & mstat & _
                                   "%' and address like '%" & addr & _
                                   "%' and company like '%" & comp & _
                                   "%' and location  like '%" & loca & _
                                   "%' and department like '" & dept & _
                                   "%' and employee_status like '%" & es & _
                                   "%' and position like '%" & pos & "%'", cn)
            dr = cmd.ExecuteReader
            Dim y As ListViewItem
            ListView1.Items.Clear()
            Do While dr.Read = True

                y = New ListViewItem(dr("employee_number").ToString)
                y.SubItems.Add(dr("last_name"))
                y.SubItems.Add(dr("first_name"))
                y.SubItems.Add(dr("middle_name"))
                y.SubItems.Add(dr("gender"))
                y.SubItems.Add(dr("marital_status"))
                y.SubItems.Add(dr("date_birth"))
                y.SubItems.Add(dr("contact_number"))
                y.SubItems.Add(dr("address"))
                y.SubItems.Add(dr("contact_person"))
                y.SubItems.Add(dr("cp_number"))
                y.SubItems.Add(dr("date_hired"))
                y.SubItems.Add(dr("company"))
                y.SubItems.Add(dr("location"))
                y.SubItems.Add(dr("department"))
                y.SubItems.Add(dr("position"))
                y.SubItems.Add(dr("employee_status"))
                y.SubItems.Add(dr("sss"))
                y.SubItems.Add(dr("phic"))
                y.SubItems.Add(dr("hdmf"))
                y.SubItems.Add(dr("tin"))
                If dr("employee_status") = "RESIGNED" Then
                    y.ForeColor = Color.Red
                End If
                ListView1.Items.Add(y)
            Loop
            dr.Close()
            Label1.Text = ListView1.Items.Count & "-Records"

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub
    Private Sub frmEmployeeList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        employeelist("", "", "", "", "", "", "", "", "", "")
        complist()
        loclist()
        deptlist()
    End Sub
    '======================searching=====================================================================================
    Private Sub RefreshToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RefreshToolStripMenuItem.Click
        employeelist("", "", "", "", "", "", "", "", "", "")
    End Sub
    Private Sub txtAll_TextChanged(sender As Object, e As EventArgs) Handles txtAll.TextChanged
        employeelist(Trim(txtAll.Text), Trim(txtName.Text), cmbGender.Text, cmbMaritalStatus.Text, Trim(txtAddress.Text), cmbCompany.Text, cmbLocation.Text, cmbDepartment.Text, cmbEmployeeStatus.Text, Trim(txtPosition.Text))
    End Sub
    Private Sub txtName_TextChanged(sender As Object, e As EventArgs) Handles txtName.TextChanged
        employeelist(Trim(txtAll.Text), Trim(txtName.Text), cmbGender.Text, cmbMaritalStatus.Text, Trim(txtAddress.Text), cmbCompany.Text, cmbLocation.Text, cmbDepartment.Text, cmbEmployeeStatus.Text, Trim(txtPosition.Text))
    End Sub
    Private Sub cmbCompany_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbCompany.SelectedIndexChanged
        employeelist(Trim(txtAll.Text), Trim(txtName.Text), cmbGender.Text, cmbMaritalStatus.Text, Trim(txtAddress.Text), cmbCompany.Text, cmbLocation.Text, cmbDepartment.Text, cmbEmployeeStatus.Text, Trim(txtPosition.Text))
    End Sub
    Private Sub cmbLocation_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbLocation.SelectedIndexChanged
        employeelist(Trim(txtAll.Text), Trim(txtName.Text), cmbGender.Text, cmbMaritalStatus.Text, Trim(txtAddress.Text), cmbCompany.Text, cmbLocation.Text, cmbDepartment.Text, cmbEmployeeStatus.Text, Trim(txtPosition.Text))
    End Sub
    Private Sub cmbDepartment_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbDepartment.SelectedIndexChanged
        employeelist(Trim(txtAll.Text), Trim(txtName.Text), cmbGender.Text, cmbMaritalStatus.Text, Trim(txtAddress.Text), cmbCompany.Text, cmbLocation.Text, cmbDepartment.Text, cmbEmployeeStatus.Text, Trim(txtPosition.Text))
    End Sub
    Private Sub cmbEmployeeStatus_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbEmployeeStatus.SelectedIndexChanged
        employeelist(Trim(txtAll.Text), Trim(txtName.Text), cmbGender.Text, cmbMaritalStatus.Text, Trim(txtAddress.Text), cmbCompany.Text, cmbLocation.Text, cmbDepartment.Text, cmbEmployeeStatus.Text, Trim(txtPosition.Text))
    End Sub
    Private Sub cmbGender_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbGender.SelectedIndexChanged
        employeelist(Trim(txtAll.Text), Trim(txtName.Text), cmbGender.Text, cmbMaritalStatus.Text, Trim(txtAddress.Text), cmbCompany.Text, cmbLocation.Text, cmbDepartment.Text, cmbEmployeeStatus.Text, Trim(txtPosition.Text))
    End Sub
    Private Sub cmbMaritalStatus_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbMaritalStatus.SelectedIndexChanged
        employeelist(Trim(txtAll.Text), Trim(txtName.Text), cmbGender.Text, cmbMaritalStatus.Text, Trim(txtAddress.Text), cmbCompany.Text, cmbLocation.Text, cmbDepartment.Text, cmbEmployeeStatus.Text, Trim(txtPosition.Text))
    End Sub
    Private Sub txtAddress_TextChanged(sender As Object, e As EventArgs) Handles txtAddress.TextChanged
        employeelist(Trim(txtAll.Text), Trim(txtName.Text), cmbGender.Text, cmbMaritalStatus.Text, Trim(txtAddress.Text), cmbCompany.Text, cmbLocation.Text, cmbDepartment.Text, cmbEmployeeStatus.Text, Trim(txtPosition.Text))
    End Sub
    Private Sub txtPosition_TextChanged(sender As Object, e As EventArgs) Handles txtPosition.TextChanged
        employeelist(Trim(txtAll.Text), Trim(txtName.Text), cmbGender.Text, cmbMaritalStatus.Text, Trim(txtAddress.Text), cmbCompany.Text, cmbLocation.Text, cmbDepartment.Text, cmbEmployeeStatus.Text, Trim(txtPosition.Text))
    End Sub
    '====================================================================================================================
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        frmAddEmployee.MdiParent = frmMain
        frmAddEmployee.Show()
        frmAddEmployee.BringToFront()
    End Sub

    Private Sub EditUserToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditUserToolStripMenuItem.Click
        cmdEdit_Click(sender, New System.EventArgs())
    End Sub

    Private Sub cmdEdit_Click(sender As Object, e As EventArgs) Handles cmdEdit.Click
        Try
            If ListView1.SelectedItems.Count > 0 Then
                loclist()
                deptlist()
                complist()
                frmEditEmployee.txtEmployeeNumber.Text = ListView1.SelectedItems(0).Text
                frmEditEmployee.txtLastName.Text = ListView1.SelectedItems(0).SubItems(1).Text
                frmEditEmployee.txtFirstName.Text = ListView1.SelectedItems(0).SubItems(2).Text
                frmEditEmployee.txtMiddleName.Text = ListView1.SelectedItems(0).SubItems(3).Text
                frmEditEmployee.cmbGender.Text = ListView1.SelectedItems(0).SubItems(4).Text
                frmEditEmployee.cmbMaritalStatus.Text = ListView1.SelectedItems(0).SubItems(5).Text
                frmEditEmployee.dtDateBirth.Value = ListView1.SelectedItems(0).SubItems(6).Text
                frmEditEmployee.txtAddress.Text = ListView1.SelectedItems(0).SubItems(8).Text
                frmEditEmployee.txtContactNumber.Text = ListView1.SelectedItems(0).SubItems(7).Text
                frmEditEmployee.txtContactPerson.Text = ListView1.SelectedItems(0).SubItems(9).Text
                frmEditEmployee.txtCPNumber.Text = ListView1.SelectedItems(0).SubItems(10).Text
                frmEditEmployee.dtDateHired.Value = ListView1.SelectedItems(0).SubItems(11).Text
                frmEditEmployee.cmbCompany.Text = ListView1.SelectedItems(0).SubItems(12).Text
                frmEditEmployee.cmbLocation.Text = ListView1.SelectedItems(0).SubItems(13).Text
                frmEditEmployee.cmbDepartment.Text = ListView1.SelectedItems(0).SubItems(14).Text
                frmEditEmployee.cmbEmployeeStatus.Text = ListView1.SelectedItems(0).SubItems(16).Text
                frmEditEmployee.txtPosition.Text = ListView1.SelectedItems(0).SubItems(15).Text
                frmEditEmployee.txtSSS.Text = ListView1.SelectedItems(0).SubItems(17).Text
                frmEditEmployee.txtPHIC.Text = ListView1.SelectedItems(0).SubItems(18).Text
                frmEditEmployee.txtHDMF.Text = ListView1.SelectedItems(0).SubItems(19).Text
                frmEditEmployee.txtTIN.Text = ListView1.SelectedItems(0).SubItems(20).Text
                frmEditEmployee.ShowDialog()
            Else
                MsgBox("Please select employee.", MsgBoxStyle.Information)
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub


    Private Sub cmdViewImage_Click(sender As Object, e As EventArgs) Handles cmdViewImage.Click
        If ListView1.SelectedItems.Count > 0 Then
            frmViewImage.lblEmployeeNumber.Text = ListView1.SelectedItems(0).Text
            frmViewImage.lblName.Text = ListView1.SelectedItems(0).SubItems(1).Text & ", " & ListView1.SelectedItems(0).SubItems(2).Text
            frmViewImage.ShowDialog()
            'frmViewImage.MdiParent = frmMain
            'frmViewImage.Show()
            'frmViewImage.BringToFront()
        Else
            MsgBox("Please select employee.", MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub ViewImageToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewImageToolStripMenuItem.Click
        cmdViewImage_Click(sender, New System.EventArgs())
    End Sub

    '===============generate location dept and company=====================================================
    Sub deptlist()
        Call main()
        cmd = New MySqlCommand("Select * from others_departments order by name asc", cn)
        dr = cmd.ExecuteReader
        frmEditEmployee.cmbDepartment.Items.Clear()
        frmEditEmployee.cmbDepartment.Items.Add("")
        cmbDepartment.Items.Clear()
        cmbDepartment.Items.Add("")
        Do While dr.Read
            frmEditEmployee.cmbDepartment.Items.Add(StrConv(dr("name"), VbStrConv.Uppercase))
            cmbDepartment.Items.Add(StrConv(dr("name"), VbStrConv.Uppercase))
        Loop
        dr.Close()
    End Sub
    Sub complist()
        Call main()
        cmd = New MySqlCommand("Select * from others_companies order by name asc", cn)
        dr = cmd.ExecuteReader
        frmEditEmployee.cmbCompany.Items.Clear()
        frmEditEmployee.cmbCompany.Items.Add("")
        cmbCompany.Items.Clear()
        cmbCompany.Items.Add("")
        Do While dr.Read
            frmEditEmployee.cmbCompany.Items.Add(StrConv(dr("name"), VbStrConv.Uppercase))
            cmbCompany.Items.Add(StrConv(dr("name"), VbStrConv.Uppercase))
        Loop
        dr.Close()
    End Sub
    Sub loclist()
        Call main()
        cmd = New MySqlCommand("Select * from others_locations order by name asc", cn)
        dr = cmd.ExecuteReader
        frmEditEmployee.cmbLocation.Items.Clear()
        frmEditEmployee.cmbLocation.Items.Add("")
        cmbLocation.Items.Clear()
        cmbLocation.Items.Add("")
        Do While dr.Read
            frmEditEmployee.cmbLocation.Items.Add(StrConv(dr("name"), VbStrConv.Uppercase))
            cmbLocation.Items.Add(StrConv(dr("name"), VbStrConv.Uppercase))
        Loop
        dr.Close()
    End Sub
    '===============export to excel=================================================================
    Private Sub cmdExcel_Click(sender As Object, e As EventArgs) Handles cmdExcel.Click
        Try
            SaveFileDialog1.Title = "Save Excel File"
            SaveFileDialog1.Filter = "Excel files (*.xls)|*.xls|Excel Files (*.xlsx)|*.xslx"
            SaveFileDialog1.ShowDialog()
            If SaveFileDialog1.FileName = "" Then
                Exit Sub
            End If
            Dim xls As New Excel.Application
            Dim book As Excel.Workbook
            Dim sheet As Excel.Worksheet
            xls.Workbooks.Add()
            book = xls.ActiveWorkbook
            sheet = book.ActiveSheet

            For i = 0 To Me.ListView1.Columns.Count - 1
                sheet.Cells(1, i + 1) = Me.ListView1.Columns(i).Text
            Next
            For i = 0 To Me.ListView1.Items.Count - 1
                For j = 0 To Me.ListView1.Items(i).SubItems.Count - 1
                    sheet.Cells(i + 2, j + 1) = Me.ListView1.Items(i).SubItems(j).Text
                Next
            Next

            book.SaveAs(SaveFileDialog1.FileName)
            xls.Workbooks.Close()
            xls.Quit()
            releaseObject(sheet)
            releaseObject(book)
            releaseObject(xls)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub releaseObject(ByVal obj As Object)
        Try
            System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
            obj = Nothing
        Catch ex As Exception
            obj = Nothing
        Finally
            GC.Collect()
        End Try
    End Sub

   
End Class