Imports MaterialSkin

Public Class frmCaptcha

    Dim captchacode As String

    '//컨트롤 센터 설정
    Private Sub CenterMe()
        txtCaptcha.Left = (Me.Size.Width / 2) - (txtCaptcha.Width / 2)
        wbCaptcha.Left = (Me.Size.Width / 2) - (wbCaptcha.Width / 2)
    End Sub

    Private Sub frmCaptcha_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '//스킨 설정
        Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance
        'LoadFont()
        'SkinManager.ROBOTO_MEDIUM_10 = New Font(NotoSansKR_Medium.Families(0), 10)
        'SkinManager.ROBOTO_MEDIUM_11 = New Font(NotoSansKR_Medium.Families(0), 11)
        'SkinManager.ROBOTO_MEDIUM_12 = New Font(NotoSansKR_Medium.Families(0), 12)
        'SkinManager.ROBOTO_REGULAR_11 = New Font(NotoSansKR_Regular.Families(0), 11)
        SkinManager.AddFormToManage(Me)
        SkinManager.Theme = MaterialSkinManager.Themes.LIGHT
        SkinManager.ColorScheme = New ColorScheme(Primary.Yellow700, Primary.Yellow800, Primary.Yellow300, Accent.Orange700, TextShade.WHITE)

        CenterMe()

        frmLogin.Hide()

        IE.Open("GET", "https://www.google.com/recaptcha/api/challenge?k=6LfIz_USAAAAALNnNqQJK8YI9SrPuNJqQeMgY0DY&ajax=1&cachestop=0.27867610606292925&lang=ko")
        IE.SetRequestHeader("User-Agent", "Mozilla/5.0 (Windows NT 6.1; rv:35.0) Gecko/20100101 Firefox/35.0")
        IE.SetRequestHeader("Host", "www.google.com")
        IE.SetRequestHeader("Accept-Language", "ko-kr,ko;q=0.8,en-us;q=0.5,en;q=0.3")
        IE.SetRequestHeader("Referer", "https://accounts.kakao.com/weblogin/main_captcha?continue=https%3A%2F%2Fstory.kakao.com")
        IE.Send()

        captchacode = Split(Split(IE.ResponseText, ": '")(1), "',")(0)

        wbCaptcha.Navigate("https://www.google.com/recaptcha/api/image?c=" & captchacode)
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        '/*로그인*/
        IE.Open("POST", "https://accounts.kakao.com/weblogin/authenticate_captcha")
        IE.SetRequestHeader("Referer", "https://accounts.kakao.com/weblogin/main_captcha?continue=https%3A%2F%2Fstory.kakao.com")
        IE.SetRequestHeader("Content-Type", "application/x-www-form-urlencoded")
        IE.SetRequestHeader("User-Agent", "Mozilla/5.0 (Windows NT 6.1; rv:35.0) Gecko/20100101 Firefox/35.0")
        IE.SetRequestHeader("Accept", "text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8")
        IE.SetRequestHeader("Accept-Language", "ko-kr,ko;q=0.8,en-us;q=0.5,en;q=0.3")
        IE.SetRequestHeader("Host", "accounts.kakao.com")
        IE.Send("type=w&continue=https%3A%2F%2Fstory.kakao.com&email=" & frmLogin.txtID.Text & "&password=" & frmLogin.txtPW.Text & "&recaptcha_challenge_field=" & CaptchaCode & "&recaptcha_response_field=" & txtCaptcha.Text & "&callback_url=https%3A%2F%2Faccounts.kakao.com%2Fcb.html&scriptVersion=1.3.0")

        '/*로그인 성공여부 검사(친구목록 API)*/
        IE.Open("GET", "https://story.kakao.com/a/friends")
        IE.SetRequestHeader("Host", "story.kakao.com")
        IE.SetRequestHeader("User-Agent", "Mozilla/5.0 (Windows NT 6.1; rv:35.0) Gecko/20100101 Firefox/35.0")
        IE.SetRequestHeader("Accept", "application/json")
        IE.SetRequestHeader("Accept-Language", "ko")
        IE.SetRequestHeader("Connection", "keep-alive")
        IE.SetRequestHeader("X-Kakao-ApiLevel", "29")
        IE.SetRequestHeader("X-Kakao-DeviceInfo", "web:-;-;-")
        IE.SetRequestHeader("X-Requested-With", "XMLHttpRequest")
        IE.SetRequestHeader("Referer", "https://story.kakao.com/")
        IE.Send()

        '/*성공여부 체크*/
        If InStr(IE.ResponseText, "profile_thumbnail_url") Then
            frmLivingPoint.Show()
            frmLogin.Close()
            Me.Close()

        Else
            frmLogin.Show()
            Me.Close()

        End If
    End Sub

End Class