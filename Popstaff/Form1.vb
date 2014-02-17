Public Class Form1
    Private DatabaseData As String = My.Application.Info.DirectoryPath & "\staff.xml"
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim currentArea = Screen.FromControl(Me).WorkingArea
        Me.Top = currentArea.Top + CInt((currentArea.Height / 2) - (Me.Height / 2))
        Me.Left = currentArea.Left + CInt((currentArea.Width / 2) - (Me.Width / 2))

        If My.Computer.FileSystem.FileExists(DatabaseData) = True Then
            Staff.ReadXml(DatabaseData)
        End If
    End Sub

    Private Sub StaffBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles StaffBindingNavigatorSaveItem.Click
        Me.Validate()
        StaffBindingSource.EndEdit()
        Staff.WriteXml(DatabaseData)
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        AboutBox1.ShowDialog()
    End Sub
End Class
