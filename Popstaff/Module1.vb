﻿Module Module1
    Function IsValidEmailFormat(ByVal s As String) As Boolean
        Try
            Dim a As New System.Net.Mail.MailAddress(s)
        Catch
            Return False
        End Try
        Return True
    End Function
End Module
