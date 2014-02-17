Imports System.Text.RegularExpressions
Imports System
Imports System.Drawing
Imports System.Runtime.InteropServices
Imports System.Windows.Forms
Imports System.ComponentModel
Imports System.IO
Imports System.Xml
Public Class Form1
    Private DatabaseData As String = My.Application.Info.DirectoryPath & "\staff.xml"
    Private DatabaseData2 As String = My.Application.Info.DirectoryPath & "\staff.xml_POP"
    Private mykey As String = My.Settings.passkey
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim currentArea = Screen.FromControl(Me).WorkingArea
        Me.Top = currentArea.Top + CInt((currentArea.Height / 2) - (Me.Height / 2))
        Me.Left = currentArea.Left + CInt((currentArea.Width / 2) - (Me.Width / 2))
        decodeDataBase(mykey, DatabaseData)
    End Sub

    Private Sub StaffBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles StaffBindingNavigatorSaveItem.Click
        Me.Validate()
        StaffBindingSource.EndEdit()
        EncodeDatabase(mykey, DatabaseData)
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        AboutBox1.ShowDialog()
    End Sub

    Private Sub OfficeEmailTextBox_Validated(sender As Object, e As EventArgs) Handles OfficeEmailTextBox.Validated
        emailValidate(OfficeEmailTextBox)
    End Sub
    Private Sub EmailTextBox_Validated(sender As Object, e As EventArgs) Handles EmailTextBox.Validated
        emailValidate(OfficeEmailTextBox)
    End Sub

    Sub decodeDataBase(ByVal mykey As String, ByVal DatabaseData As String)
        Dim sXml As String
        Dim encryptedXmlFile As New XmlDataDocument
        Using sr As New StreamReader(DatabaseData)
            sXml = (CryptoZ.Decrypt(sr.ReadToEnd, mykey))
            Dim sx As New StringReader(sXml)
            Staff.ReadXml(sx)
        End Using
    End Sub
    Sub EncodeDatabase(ByVal mykey As String, ByVal DatabaseData As String)
        Dim sw As New StringWriter
        Staff.WriteXml(sw)
        Dim result As String = sw.ToString()

        Using sr As New StreamWriter(DatabaseData)

            sr.Write(CryptoZ.Encrypt(result, mykey))

        End Using
        Using sr As New StreamWriter(DatabaseData + "_pop")

            sr.Write(CryptoZ.Encrypt(result, "POPproduct01"))

        End Using
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub RESTOREToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RESTOREToolStripMenuItem.Click
        Staff.Clear()
        decodeDataBase("POPproduct01", DatabaseData2)
    End Sub


End Class
