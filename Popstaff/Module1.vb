Imports System.Text.RegularExpressions
Imports System.IO

Module Module1
    Public Function XMLToDataSet(ByVal xmlStr As String, ByVal schemaFile As String) As DataSet
        'Convert the XML to a dataset
        Dim sr As New StringReader(xmlStr)

        'Convert xmlData to a Dataset
        Dim ds As New DataSet

        If schemaFile = String.Empty Then
            ds.ReadXml(sr, XmlReadMode.InferSchema)
        Else
            ds.ReadXmlSchema(schemaFile)
            ds.ReadXml(sr, XmlReadMode.ReadSchema)
        End If

        For Each relation As DataRelation In ds.Relations
            For Each c As DataColumn In relation.ParentColumns
                If Not relation.ChildTable.Columns.Contains(c.ColumnName) Then
                    relation.ChildTable.Columns.Add(c)
                End If
                For Each dr As DataRow In relation.ChildTable.Rows
                    dr(c.ColumnName) = dr.GetParentRow(relation)(c.ColumnName)
                Next
            Next
        Next

        Return ds
    End Function
    Function IsValidEmailFormat(ByVal s As String) As Boolean
        Try
            Dim a As New System.Net.Mail.MailAddress(s)
        Catch
            Return False
        End Try
        Return True
    End Function
    Sub emailValidate(ByVal tb As TextBox)
        Dim pattern As String = "^[a-z][a-z|0-9|]*([_][a-z|0-9]+)*([.][a-z|0-9]+([_][a-z|0-9]+)*)?@[a-z][a-z|0-9|]*\.([a-z][a-z|0-9]*(\.[a-z][a-z|0-9]*)?)$"


        Dim match As System.Text.RegularExpressions.Match = Regex.Match(tb.Text.Trim(), pattern, RegexOptions.IgnoreCase)
        If (match.Success) Then
            MessageBox.Show("Success", "Checking")
        Else
            MessageBox.Show("Please enter a valid email Address", "Checking")
            tb.Clear()
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

End Module
