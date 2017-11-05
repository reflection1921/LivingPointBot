<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCaptcha
    Inherits MaterialSkin.Controls.MaterialForm

    'Form은 Dispose를 재정의하여 구성 요소 목록을 정리합니다.
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

    'Windows Form 디자이너에 필요합니다.
    Private components As System.ComponentModel.IContainer

    '참고: 다음 프로시저는 Windows Form 디자이너에 필요합니다.
    '수정하려면 Windows Form 디자이너를 사용하십시오.  
    '코드 편집기에서는 수정하지 마세요.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnLogin = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.wbCaptcha = New System.Windows.Forms.WebBrowser()
        Me.txtCaptcha = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.SuspendLayout()
        '
        'btnLogin
        '
        Me.btnLogin.AutoSize = True
        Me.btnLogin.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnLogin.Depth = 0
        Me.btnLogin.Icon = Nothing
        Me.btnLogin.Location = New System.Drawing.Point(470, 316)
        Me.btnLogin.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Primary = True
        Me.btnLogin.Size = New System.Drawing.Size(46, 36)
        Me.btnLogin.TabIndex = 13
        Me.btnLogin.Text = "확인"
        Me.btnLogin.UseVisualStyleBackColor = True
        '
        'wbCaptcha
        '
        Me.wbCaptcha.Location = New System.Drawing.Point(103, 145)
        Me.wbCaptcha.MinimumSize = New System.Drawing.Size(20, 20)
        Me.wbCaptcha.Name = "wbCaptcha"
        Me.wbCaptcha.Size = New System.Drawing.Size(345, 113)
        Me.wbCaptcha.TabIndex = 12
        '
        'txtCaptcha
        '
        Me.txtCaptcha.Depth = 0
        Me.txtCaptcha.Hint = "캡챠 코드 입력"
        Me.txtCaptcha.Location = New System.Drawing.Point(103, 264)
        Me.txtCaptcha.MaxLength = 32767
        Me.txtCaptcha.MouseState = MaterialSkin.MouseState.HOVER
        Me.txtCaptcha.Name = "txtCaptcha"
        Me.txtCaptcha.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtCaptcha.SelectedText = ""
        Me.txtCaptcha.SelectionLength = 0
        Me.txtCaptcha.SelectionStart = 0
        Me.txtCaptcha.Size = New System.Drawing.Size(345, 27)
        Me.txtCaptcha.TabIndex = 11
        Me.txtCaptcha.TabStop = False
        Me.txtCaptcha.UseSystemPasswordChar = False
        '
        'frmCaptcha
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(533, 364)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.wbCaptcha)
        Me.Controls.Add(Me.txtCaptcha)
        Me.MaximizeBox = False
        Me.Name = "frmCaptcha"
        Me.Sizable = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "캡챠"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnLogin As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents wbCaptcha As WebBrowser
    Friend WithEvents txtCaptcha As MaterialSkin.Controls.MaterialSingleLineTextField
End Class
