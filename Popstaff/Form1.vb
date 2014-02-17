Imports System.Text.RegularExpressions
Imports System
Imports System.Drawing
Imports System.Runtime.InteropServices
Imports System.Windows.Forms
Imports System.ComponentModel
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

    Private Sub OfficeEmailTextBox_TextChanged(sender As Object, e As EventArgs) Handles OfficeEmailTextBox.TextChanged

    End Sub


    Private Sub OfficeEmailTextBox_Validated(sender As Object, e As EventArgs) Handles OfficeEmailTextBox.Validated
        Dim pattern As String = "^[a-z][a-z|0-9|]*([_][a-z|0-9]+)*([.][a-z|0-9]+([_][a-z|0-9]+)*)?@[a-z][a-z|0-9|]*\.([a-z][a-z|0-9]*(\.[a-z][a-z|0-9]*)?)$"


        Dim match As System.Text.RegularExpressions.Match = Regex.Match(OfficeEmailTextBox.Text.Trim(), pattern, RegexOptions.IgnoreCase)
        If (match.Success) Then
            MessageBox.Show("Success", "Checking")
        Else
            MessageBox.Show("Please enter a valid email id", "Checking")
            OfficeEmailTextBox.Clear()
        End If
    End Sub

    Friend Sub HighlightRequiredFields(ByVal pnlContainer As Panel, ByVal gr As Graphics, ByVal fVisible As Boolean)
        Dim rect As Rectangle
        For Each oControl As Control In pnlContainer.Controls
            If TypeOf oControl.Tag Is String AndAlso oControl.Tag.ToString = "required" Then
                rect = oControl.Bounds
                rect.Inflate(1, 1)
                If fVisible Then
                    ControlPaint.DrawBorder(gr, rect, Color.Red, ButtonBorderStyle.Solid)
                Else
                    ControlPaint.DrawBorder(gr, rect, pnlContainer.BackColor, ButtonBorderStyle.None)
                End If
            End If
            If TypeOf oControl Is Panel Then HighlightRequiredFields(DirectCast(oControl, Panel), gr, fVisible)
        Next
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub NameTextBox_TextChanged(sender As Object, e As EventArgs) Handles NameTextBox.TextChanged

    End Sub
End Class
