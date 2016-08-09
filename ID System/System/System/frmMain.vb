Public Class frmMain

  
    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        frmEmployeeList.MdiParent = Me
        frmEmployeeList.Show()
        frmEmployeeList.BringToFront()
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        frmAddEmployee.MdiParent = Me
        frmAddEmployee.Show()
        frmAddEmployee.BringToFront()
    End Sub


    Private Sub ToolStripButton3_Click(sender As Object, e As EventArgs) Handles ToolStripButton3.Click
        'frmGenerateID.MdiParent = Me
        'frmGenerateID.Show()
        'frmGenerateID.BringToFront()
        MsgBox("Feature is not available", MsgBoxStyle.Information)
    End Sub

 
    Private Sub UserToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UserToolStripMenuItem.Click
        frmUser.MdiParent = Me
        frmUser.Show()
        frmUser.BringToFront()
    End Sub

    Private Sub frmMain_FormClosing(sender As Object, e As Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If MsgBox("Do you want to exit?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            End
        Else
            e.Cancel = True
        End If
    End Sub

 
    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
        If usertype = "admin" Then
            FileMaintenanceToolStripMenuItem.Enabled = True
        Else
            FileMaintenanceToolStripMenuItem.Enabled = False
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Me.stTime.Text = Date.Now
    End Sub

    Private Sub OthersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OthersToolStripMenuItem.Click
        frmOthers.MdiParent = Me
        frmOthers.Show()
        frmOthers.BringToFront()
    End Sub
End Class