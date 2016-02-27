<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRMMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FRMMain))
        Me.btnAuthorizeApp = New System.Windows.Forms.Button()
        Me.btnLikes = New System.Windows.Forms.Button()
        Me.lbUserAccessToken = New System.Windows.Forms.Label()
        Me.tbUserAccessToken = New System.Windows.Forms.TextBox()
        Me.btnSaveUserAccessToken = New System.Windows.Forms.Button()
        Me.tbObjectID = New System.Windows.Forms.TextBox()
        Me.lbObjectID = New System.Windows.Forms.Label()
        Me.btnClearCookies = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TMRGetUpdatedLikes = New System.Windows.Forms.Timer(Me.components)
        Me.lbGetPossibleLikes = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnAuthorizeApp
        '
        Me.btnAuthorizeApp.Location = New System.Drawing.Point(12, 12)
        Me.btnAuthorizeApp.Name = "btnAuthorizeApp"
        Me.btnAuthorizeApp.Size = New System.Drawing.Size(200, 25)
        Me.btnAuthorizeApp.TabIndex = 0
        Me.btnAuthorizeApp.Text = "Authenticate App (Get access tokens)"
        Me.btnAuthorizeApp.UseVisualStyleBackColor = True
        '
        'btnLikes
        '
        Me.btnLikes.Enabled = False
        Me.btnLikes.Location = New System.Drawing.Point(83, 173)
        Me.btnLikes.Name = "btnLikes"
        Me.btnLikes.Size = New System.Drawing.Size(51, 23)
        Me.btnLikes.TabIndex = 1
        Me.btnLikes.Text = "Likes"
        Me.btnLikes.UseVisualStyleBackColor = True
        '
        'lbUserAccessToken
        '
        Me.lbUserAccessToken.AutoSize = True
        Me.lbUserAccessToken.Location = New System.Drawing.Point(60, 80)
        Me.lbUserAccessToken.Name = "lbUserAccessToken"
        Me.lbUserAccessToken.Size = New System.Drawing.Size(85, 13)
        Me.lbUserAccessToken.TabIndex = 2
        Me.lbUserAccessToken.Text = "Access_Token :"
        '
        'tbUserAccessToken
        '
        Me.tbUserAccessToken.Location = New System.Drawing.Point(15, 96)
        Me.tbUserAccessToken.Name = "tbUserAccessToken"
        Me.tbUserAccessToken.ReadOnly = True
        Me.tbUserAccessToken.Size = New System.Drawing.Size(142, 20)
        Me.tbUserAccessToken.TabIndex = 3
        '
        'btnSaveUserAccessToken
        '
        Me.btnSaveUserAccessToken.Enabled = False
        Me.btnSaveUserAccessToken.Location = New System.Drawing.Point(162, 94)
        Me.btnSaveUserAccessToken.Name = "btnSaveUserAccessToken"
        Me.btnSaveUserAccessToken.Size = New System.Drawing.Size(49, 23)
        Me.btnSaveUserAccessToken.TabIndex = 4
        Me.btnSaveUserAccessToken.Text = "Save"
        Me.btnSaveUserAccessToken.UseVisualStyleBackColor = True
        '
        'tbObjectID
        '
        Me.tbObjectID.Enabled = False
        Me.tbObjectID.Location = New System.Drawing.Point(15, 147)
        Me.tbObjectID.Name = "tbObjectID"
        Me.tbObjectID.Size = New System.Drawing.Size(195, 20)
        Me.tbObjectID.TabIndex = 5
        '
        'lbObjectID
        '
        Me.lbObjectID.AutoSize = True
        Me.lbObjectID.Location = New System.Drawing.Point(87, 131)
        Me.lbObjectID.Name = "lbObjectID"
        Me.lbObjectID.Size = New System.Drawing.Size(58, 13)
        Me.lbObjectID.TabIndex = 6
        Me.lbObjectID.Text = "Object ID :"
        '
        'btnClearCookies
        '
        Me.btnClearCookies.Location = New System.Drawing.Point(12, 43)
        Me.btnClearCookies.Name = "btnClearCookies"
        Me.btnClearCookies.Size = New System.Drawing.Size(200, 23)
        Me.btnClearCookies.TabIndex = 7
        Me.btnClearCookies.Text = "Clear Cookies (Logout current account)"
        Me.btnClearCookies.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 233)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(190, 26)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Legends :" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Object ID = Status/Photo/Comment ID"
        '
        'TMRGetUpdatedLikes
        '
        Me.TMRGetUpdatedLikes.Enabled = True
        Me.TMRGetUpdatedLikes.Interval = 10000
        '
        'lbGetPossibleLikes
        '
        Me.lbGetPossibleLikes.AutoSize = True
        Me.lbGetPossibleLikes.Location = New System.Drawing.Point(12, 210)
        Me.lbGetPossibleLikes.Name = "lbGetPossibleLikes"
        Me.lbGetPossibleLikes.Size = New System.Drawing.Size(135, 13)
        Me.lbGetPossibleLikes.TabIndex = 10
        Me.lbGetPossibleLikes.Text = "Possible number of likes : ?"
        '
        'FRMMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(222, 268)
        Me.Controls.Add(Me.lbGetPossibleLikes)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnClearCookies)
        Me.Controls.Add(Me.lbObjectID)
        Me.Controls.Add(Me.tbObjectID)
        Me.Controls.Add(Me.btnSaveUserAccessToken)
        Me.Controls.Add(Me.tbUserAccessToken)
        Me.Controls.Add(Me.lbUserAccessToken)
        Me.Controls.Add(Me.btnLikes)
        Me.Controls.Add(Me.btnAuthorizeApp)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FRMMain"
        Me.Text = "Facebook Bot"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnAuthorizeApp As System.Windows.Forms.Button
    Friend WithEvents btnLikes As System.Windows.Forms.Button
    Friend WithEvents lbUserAccessToken As System.Windows.Forms.Label
    Friend WithEvents tbUserAccessToken As System.Windows.Forms.TextBox
    Friend WithEvents btnSaveUserAccessToken As System.Windows.Forms.Button
    Friend WithEvents tbObjectID As System.Windows.Forms.TextBox
    Friend WithEvents lbObjectID As System.Windows.Forms.Label
    Friend WithEvents btnClearCookies As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TMRGetUpdatedLikes As System.Windows.Forms.Timer
    Friend WithEvents lbGetPossibleLikes As System.Windows.Forms.Label

End Class
