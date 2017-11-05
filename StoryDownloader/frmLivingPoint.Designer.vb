<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLivingPoint
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
        Me.components = New System.ComponentModel.Container()
        Me.MaterialLabel1 = New MaterialSkin.Controls.MaterialLabel()
        Me.lblNowTime = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialLabel2 = New MaterialSkin.Controls.MaterialLabel()
        Me.lblRefreshTime = New MaterialSkin.Controls.MaterialLabel()
        Me.lblRestTime = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialLabel4 = New MaterialSkin.Controls.MaterialLabel()
        Me.lblActiveTime = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialLabel6 = New MaterialSkin.Controls.MaterialLabel()
        Me.txtregLP = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.txtRegisterID = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.lblLPWriteTime = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialLabel5 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialRaisedButton1 = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.btnRefresh = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.MaterialRaisedButton3 = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.MaterialRaisedButton4 = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.MaterialRaisedButton5 = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.timerRefresh = New System.Windows.Forms.Timer(Me.components)
        Me.MaterialRaisedButton2 = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.timerUpload = New System.Windows.Forms.Timer(Me.components)
        Me.MaterialRaisedButton6 = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.MaterialRaisedButton7 = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.SuspendLayout()
        '
        'MaterialLabel1
        '
        Me.MaterialLabel1.AutoSize = True
        Me.MaterialLabel1.Depth = 0
        Me.MaterialLabel1.Font = New System.Drawing.Font("Noto Sans KR Regular", 11.0!)
        Me.MaterialLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel1.Location = New System.Drawing.Point(24, 74)
        Me.MaterialLabel1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel1.Name = "MaterialLabel1"
        Me.MaterialLabel1.Size = New System.Drawing.Size(116, 22)
        Me.MaterialLabel1.TabIndex = 1
        Me.MaterialLabel1.Text = "봇 새로고침 시간"
        '
        'lblNowTime
        '
        Me.lblNowTime.Depth = 0
        Me.lblNowTime.Font = New System.Drawing.Font("Noto Sans KR Regular", 11.0!)
        Me.lblNowTime.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblNowTime.Location = New System.Drawing.Point(40, 96)
        Me.lblNowTime.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblNowTime.Name = "lblNowTime"
        Me.lblNowTime.Size = New System.Drawing.Size(27, 24)
        Me.lblNowTime.TabIndex = 2
        Me.lblNowTime.Text = "0"
        '
        'MaterialLabel2
        '
        Me.MaterialLabel2.Depth = 0
        Me.MaterialLabel2.Font = New System.Drawing.Font("Noto Sans KR Regular", 11.0!)
        Me.MaterialLabel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel2.Location = New System.Drawing.Point(73, 96)
        Me.MaterialLabel2.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel2.Name = "MaterialLabel2"
        Me.MaterialLabel2.Size = New System.Drawing.Size(15, 24)
        Me.MaterialLabel2.TabIndex = 3
        Me.MaterialLabel2.Text = "/"
        '
        'lblRefreshTime
        '
        Me.lblRefreshTime.Depth = 0
        Me.lblRefreshTime.Font = New System.Drawing.Font("Noto Sans KR Regular", 11.0!)
        Me.lblRefreshTime.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblRefreshTime.Location = New System.Drawing.Point(94, 96)
        Me.lblRefreshTime.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblRefreshTime.Name = "lblRefreshTime"
        Me.lblRefreshTime.Size = New System.Drawing.Size(26, 24)
        Me.lblRefreshTime.TabIndex = 4
        Me.lblRefreshTime.Text = "0"
        '
        'lblRestTime
        '
        Me.lblRestTime.Depth = 0
        Me.lblRestTime.Font = New System.Drawing.Font("Noto Sans KR Regular", 11.0!)
        Me.lblRestTime.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblRestTime.Location = New System.Drawing.Point(95, 150)
        Me.lblRestTime.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblRestTime.Name = "lblRestTime"
        Me.lblRestTime.Size = New System.Drawing.Size(42, 24)
        Me.lblRestTime.TabIndex = 8
        Me.lblRestTime.Text = "0"
        '
        'MaterialLabel4
        '
        Me.MaterialLabel4.Depth = 0
        Me.MaterialLabel4.Font = New System.Drawing.Font("Noto Sans KR Regular", 11.0!)
        Me.MaterialLabel4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel4.Location = New System.Drawing.Point(74, 150)
        Me.MaterialLabel4.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel4.Name = "MaterialLabel4"
        Me.MaterialLabel4.Size = New System.Drawing.Size(15, 24)
        Me.MaterialLabel4.TabIndex = 7
        Me.MaterialLabel4.Text = "/"
        '
        'lblActiveTime
        '
        Me.lblActiveTime.Depth = 0
        Me.lblActiveTime.Font = New System.Drawing.Font("Noto Sans KR Regular", 11.0!)
        Me.lblActiveTime.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblActiveTime.Location = New System.Drawing.Point(26, 150)
        Me.lblActiveTime.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblActiveTime.Name = "lblActiveTime"
        Me.lblActiveTime.Size = New System.Drawing.Size(42, 24)
        Me.lblActiveTime.TabIndex = 6
        Me.lblActiveTime.Text = "0"
        '
        'MaterialLabel6
        '
        Me.MaterialLabel6.AutoSize = True
        Me.MaterialLabel6.Depth = 0
        Me.MaterialLabel6.Font = New System.Drawing.Font("Noto Sans KR Regular", 11.0!)
        Me.MaterialLabel6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel6.Location = New System.Drawing.Point(18, 128)
        Me.MaterialLabel6.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel6.Name = "MaterialLabel6"
        Me.MaterialLabel6.Size = New System.Drawing.Size(129, 22)
        Me.MaterialLabel6.TabIndex = 5
        Me.MaterialLabel6.Text = "봇 작동 / 휴식 시간"
        '
        'txtregLP
        '
        Me.txtregLP.Depth = 0
        Me.txtregLP.Hint = ""
        Me.txtregLP.Location = New System.Drawing.Point(179, 69)
        Me.txtregLP.MaxLength = 32767
        Me.txtregLP.MouseState = MaterialSkin.MouseState.HOVER
        Me.txtregLP.Name = "txtregLP"
        Me.txtregLP.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtregLP.SelectedText = ""
        Me.txtregLP.SelectionLength = 0
        Me.txtregLP.SelectionStart = 0
        Me.txtregLP.Size = New System.Drawing.Size(300, 27)
        Me.txtregLP.TabIndex = 9
        Me.txtregLP.TabStop = False
        Me.txtregLP.Text = "배가 고프면 밥을 먹으면 된다."
        Me.txtregLP.UseSystemPasswordChar = False
        '
        'txtRegisterID
        '
        Me.txtRegisterID.Depth = 0
        Me.txtRegisterID.Hint = ""
        Me.txtRegisterID.Location = New System.Drawing.Point(179, 102)
        Me.txtRegisterID.MaxLength = 32767
        Me.txtRegisterID.MouseState = MaterialSkin.MouseState.HOVER
        Me.txtRegisterID.Name = "txtRegisterID"
        Me.txtRegisterID.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtRegisterID.SelectedText = ""
        Me.txtRegisterID.SelectionLength = 0
        Me.txtRegisterID.SelectionStart = 0
        Me.txtRegisterID.Size = New System.Drawing.Size(300, 27)
        Me.txtRegisterID.TabIndex = 10
        Me.txtRegisterID.TabStop = False
        Me.txtRegisterID.Text = "리빙포인트 등록자 ID"
        Me.txtRegisterID.UseSystemPasswordChar = False
        '
        'lblLPWriteTime
        '
        Me.lblLPWriteTime.Depth = 0
        Me.lblLPWriteTime.Font = New System.Drawing.Font("Noto Sans KR Regular", 11.0!)
        Me.lblLPWriteTime.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblLPWriteTime.Location = New System.Drawing.Point(62, 209)
        Me.lblLPWriteTime.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblLPWriteTime.Name = "lblLPWriteTime"
        Me.lblLPWriteTime.Size = New System.Drawing.Size(42, 24)
        Me.lblLPWriteTime.TabIndex = 12
        Me.lblLPWriteTime.Text = "0"
        '
        'MaterialLabel5
        '
        Me.MaterialLabel5.AutoSize = True
        Me.MaterialLabel5.Depth = 0
        Me.MaterialLabel5.Font = New System.Drawing.Font("Noto Sans KR Regular", 11.0!)
        Me.MaterialLabel5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel5.Location = New System.Drawing.Point(13, 187)
        Me.MaterialLabel5.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel5.Name = "MaterialLabel5"
        Me.MaterialLabel5.Size = New System.Drawing.Size(144, 22)
        Me.MaterialLabel5.TabIndex = 11
        Me.MaterialLabel5.Text = "리빙포인트 작성 시간"
        '
        'MaterialRaisedButton1
        '
        Me.MaterialRaisedButton1.AutoSize = True
        Me.MaterialRaisedButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.MaterialRaisedButton1.Depth = 0
        Me.MaterialRaisedButton1.Icon = Nothing
        Me.MaterialRaisedButton1.Location = New System.Drawing.Point(179, 135)
        Me.MaterialRaisedButton1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialRaisedButton1.Name = "MaterialRaisedButton1"
        Me.MaterialRaisedButton1.Primary = True
        Me.MaterialRaisedButton1.Size = New System.Drawing.Size(75, 36)
        Me.MaterialRaisedButton1.TabIndex = 13
        Me.MaterialRaisedButton1.Text = "봇 자동화"
        Me.MaterialRaisedButton1.UseVisualStyleBackColor = True
        '
        'btnRefresh
        '
        Me.btnRefresh.AutoSize = True
        Me.btnRefresh.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnRefresh.Depth = 0
        Me.btnRefresh.Icon = Nothing
        Me.btnRefresh.Location = New System.Drawing.Point(341, 135)
        Me.btnRefresh.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Primary = True
        Me.btnRefresh.Size = New System.Drawing.Size(71, 36)
        Me.btnRefresh.TabIndex = 14
        Me.btnRefresh.Text = "새로고침"
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'MaterialRaisedButton3
        '
        Me.MaterialRaisedButton3.AutoSize = True
        Me.MaterialRaisedButton3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.MaterialRaisedButton3.Depth = 0
        Me.MaterialRaisedButton3.Icon = Nothing
        Me.MaterialRaisedButton3.Location = New System.Drawing.Point(179, 177)
        Me.MaterialRaisedButton3.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialRaisedButton3.Name = "MaterialRaisedButton3"
        Me.MaterialRaisedButton3.Primary = True
        Me.MaterialRaisedButton3.Size = New System.Drawing.Size(92, 36)
        Me.MaterialRaisedButton3.TabIndex = 15
        Me.MaterialRaisedButton3.Text = "봇 시작 알림"
        Me.MaterialRaisedButton3.UseVisualStyleBackColor = True
        '
        'MaterialRaisedButton4
        '
        Me.MaterialRaisedButton4.AutoSize = True
        Me.MaterialRaisedButton4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.MaterialRaisedButton4.Depth = 0
        Me.MaterialRaisedButton4.Icon = Nothing
        Me.MaterialRaisedButton4.Location = New System.Drawing.Point(277, 177)
        Me.MaterialRaisedButton4.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialRaisedButton4.Name = "MaterialRaisedButton4"
        Me.MaterialRaisedButton4.Primary = True
        Me.MaterialRaisedButton4.Size = New System.Drawing.Size(104, 36)
        Me.MaterialRaisedButton4.TabIndex = 16
        Me.MaterialRaisedButton4.Text = "봇 재시작 알림"
        Me.MaterialRaisedButton4.UseVisualStyleBackColor = True
        '
        'MaterialRaisedButton5
        '
        Me.MaterialRaisedButton5.AutoSize = True
        Me.MaterialRaisedButton5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.MaterialRaisedButton5.Depth = 0
        Me.MaterialRaisedButton5.Icon = Nothing
        Me.MaterialRaisedButton5.Location = New System.Drawing.Point(387, 177)
        Me.MaterialRaisedButton5.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialRaisedButton5.Name = "MaterialRaisedButton5"
        Me.MaterialRaisedButton5.Primary = True
        Me.MaterialRaisedButton5.Size = New System.Drawing.Size(92, 36)
        Me.MaterialRaisedButton5.TabIndex = 17
        Me.MaterialRaisedButton5.Text = "봇 점검 알림"
        Me.MaterialRaisedButton5.UseVisualStyleBackColor = True
        '
        'timerRefresh
        '
        Me.timerRefresh.Interval = 1000
        '
        'MaterialRaisedButton2
        '
        Me.MaterialRaisedButton2.AutoSize = True
        Me.MaterialRaisedButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.MaterialRaisedButton2.Depth = 0
        Me.MaterialRaisedButton2.Icon = Nothing
        Me.MaterialRaisedButton2.Location = New System.Drawing.Point(260, 135)
        Me.MaterialRaisedButton2.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialRaisedButton2.Name = "MaterialRaisedButton2"
        Me.MaterialRaisedButton2.Primary = True
        Me.MaterialRaisedButton2.Size = New System.Drawing.Size(75, 36)
        Me.MaterialRaisedButton2.TabIndex = 18
        Me.MaterialRaisedButton2.Text = "봇 수동화"
        Me.MaterialRaisedButton2.UseVisualStyleBackColor = True
        '
        'timerUpload
        '
        Me.timerUpload.Enabled = True
        Me.timerUpload.Interval = 1024
        '
        'MaterialRaisedButton6
        '
        Me.MaterialRaisedButton6.AutoSize = True
        Me.MaterialRaisedButton6.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.MaterialRaisedButton6.Depth = 0
        Me.MaterialRaisedButton6.Icon = Nothing
        Me.MaterialRaisedButton6.Location = New System.Drawing.Point(418, 135)
        Me.MaterialRaisedButton6.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialRaisedButton6.Name = "MaterialRaisedButton6"
        Me.MaterialRaisedButton6.Primary = True
        Me.MaterialRaisedButton6.Size = New System.Drawing.Size(46, 36)
        Me.MaterialRaisedButton6.TabIndex = 19
        Me.MaterialRaisedButton6.Text = "작성"
        Me.MaterialRaisedButton6.UseVisualStyleBackColor = True
        '
        'MaterialRaisedButton7
        '
        Me.MaterialRaisedButton7.AutoSize = True
        Me.MaterialRaisedButton7.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.MaterialRaisedButton7.Depth = 0
        Me.MaterialRaisedButton7.Icon = Nothing
        Me.MaterialRaisedButton7.Location = New System.Drawing.Point(179, 219)
        Me.MaterialRaisedButton7.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialRaisedButton7.Name = "MaterialRaisedButton7"
        Me.MaterialRaisedButton7.Primary = True
        Me.MaterialRaisedButton7.Size = New System.Drawing.Size(26, 36)
        Me.MaterialRaisedButton7.TabIndex = 20
        Me.MaterialRaisedButton7.Text = "-"
        Me.MaterialRaisedButton7.UseVisualStyleBackColor = True
        '
        'frmLivingPoint
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(493, 260)
        Me.Controls.Add(Me.MaterialRaisedButton7)
        Me.Controls.Add(Me.MaterialRaisedButton6)
        Me.Controls.Add(Me.MaterialRaisedButton2)
        Me.Controls.Add(Me.MaterialRaisedButton5)
        Me.Controls.Add(Me.MaterialRaisedButton4)
        Me.Controls.Add(Me.MaterialRaisedButton3)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.MaterialRaisedButton1)
        Me.Controls.Add(Me.lblLPWriteTime)
        Me.Controls.Add(Me.MaterialLabel5)
        Me.Controls.Add(Me.txtRegisterID)
        Me.Controls.Add(Me.txtregLP)
        Me.Controls.Add(Me.lblRestTime)
        Me.Controls.Add(Me.MaterialLabel4)
        Me.Controls.Add(Me.lblActiveTime)
        Me.Controls.Add(Me.MaterialLabel6)
        Me.Controls.Add(Me.lblRefreshTime)
        Me.Controls.Add(Me.MaterialLabel2)
        Me.Controls.Add(Me.lblNowTime)
        Me.Controls.Add(Me.MaterialLabel1)
        Me.MaximizeBox = False
        Me.Name = "frmLivingPoint"
        Me.Text = "LivingPoint Bot"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MaterialLabel1 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents lblNowTime As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel2 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents lblRefreshTime As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents lblRestTime As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel4 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents lblActiveTime As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel6 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents txtregLP As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents txtRegisterID As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents lblLPWriteTime As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel5 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialRaisedButton1 As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents btnRefresh As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents MaterialRaisedButton3 As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents MaterialRaisedButton4 As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents MaterialRaisedButton5 As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents timerRefresh As Timer
    Friend WithEvents MaterialRaisedButton2 As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents timerUpload As Timer
    Friend WithEvents MaterialRaisedButton6 As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents MaterialRaisedButton7 As MaterialSkin.Controls.MaterialRaisedButton
End Class
