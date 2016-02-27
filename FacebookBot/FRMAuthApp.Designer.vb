<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRMAuthApp
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
        Me.WBAuthApp = New System.Windows.Forms.WebBrowser()
        Me.SuspendLayout()
        '
        'WBAuthApp
        '
        Me.WBAuthApp.Dock = System.Windows.Forms.DockStyle.Fill
        Me.WBAuthApp.Location = New System.Drawing.Point(0, 0)
        Me.WBAuthApp.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WBAuthApp.Name = "WBAuthApp"
        Me.WBAuthApp.ScriptErrorsSuppressed = True
        Me.WBAuthApp.Size = New System.Drawing.Size(625, 396)
        Me.WBAuthApp.TabIndex = 1
        '
        'FRMAuthApp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(625, 396)
        Me.Controls.Add(Me.WBAuthApp)
        Me.Name = "FRMAuthApp"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents WBAuthApp As System.Windows.Forms.WebBrowser
End Class
