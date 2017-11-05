<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmLogin
    Inherits MaterialSkin.Controls.MaterialForm

    'Form은 Dispose를 재정의하여 구성 요소 목록을 정리합니다.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.txtPW = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.txtID = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.btnLogin = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.MaterialLabel2 = New MaterialSkin.Controls.MaterialLabel()
        Me.SuspendLayout()
        '
        'txtPW
        '
        Me.txtPW.Depth = 0
        Me.txtPW.Hint = "비밀번호"
        Me.txtPW.Location = New System.Drawing.Point(140, 213)
        Me.txtPW.MaxLength = 32767
        Me.txtPW.MouseState = MaterialSkin.MouseState.HOVER
        Me.txtPW.Name = "txtPW"
        Me.txtPW.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.txtPW.SelectedText = ""
        Me.txtPW.SelectionLength = 0
        Me.txtPW.SelectionStart = 0
        Me.txtPW.Size = New System.Drawing.Size(257, 27)
        Me.txtPW.TabIndex = 10
        Me.txtPW.TabStop = False
        Me.txtPW.UseSystemPasswordChar = False
        '
        'txtID
        '
        Me.txtID.Depth = 0
        Me.txtID.Hint = "이메일 아이디"
        Me.txtID.Location = New System.Drawing.Point(140, 180)
        Me.txtID.MaxLength = 32767
        Me.txtID.MouseState = MaterialSkin.MouseState.HOVER
        Me.txtID.Name = "txtID"
        Me.txtID.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtID.SelectedText = ""
        Me.txtID.SelectionLength = 0
        Me.txtID.SelectionStart = 0
        Me.txtID.Size = New System.Drawing.Size(257, 27)
        Me.txtID.TabIndex = 9
        Me.txtID.TabStop = False
        Me.txtID.UseSystemPasswordChar = False
        '
        'btnLogin
        '
        Me.btnLogin.AutoSize = True
        Me.btnLogin.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnLogin.Depth = 0
        Me.btnLogin.Icon = Nothing
        Me.btnLogin.Location = New System.Drawing.Point(460, 316)
        Me.btnLogin.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Primary = True
        Me.btnLogin.Size = New System.Drawing.Size(63, 36)
        Me.btnLogin.TabIndex = 8
        Me.btnLogin.Text = "LOGIN"
        Me.btnLogin.UseVisualStyleBackColor = True
        '
        'MaterialLabel2
        '
        Me.MaterialLabel2.AutoSize = True
        Me.MaterialLabel2.Depth = 0
        Me.MaterialLabel2.Font = New System.Drawing.Font("Noto Sans KR Regular", 11.0!)
        Me.MaterialLabel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel2.Location = New System.Drawing.Point(12, 333)
        Me.MaterialLabel2.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel2.Name = "MaterialLabel2"
        Me.MaterialLabel2.Size = New System.Drawing.Size(98, 22)
        Me.MaterialLabel2.TabIndex = 12
        Me.MaterialLabel2.Text = "프로그램 정보"
        '
        'frmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(533, 364)
        Me.Controls.Add(Me.MaterialLabel2)
        Me.Controls.Add(Me.txtPW)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.btnLogin)
        Me.MaximizeBox = False
        Me.Name = "frmLogin"
        Me.Sizable = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "로그인"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtPW As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents txtID As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents btnLogin As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents MaterialLabel2 As MaterialSkin.Controls.MaterialLabel
End Class
