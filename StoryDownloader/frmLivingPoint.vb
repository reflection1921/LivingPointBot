Imports MaterialSkin
Imports Newtonsoft.Json.Linq

Public Class frmLivingPoint

    Public ROW_COUNT As String

    Private Sub frmLivingPoint_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '//스킨 설정
        Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance

        SkinManager.AddFormToManage(Me)
        SkinManager.Theme = MaterialSkinManager.Themes.LIGHT
        SkinManager.ColorScheme = New ColorScheme(Primary.Yellow700, Primary.Yellow800, Primary.Yellow300, Accent.Orange700, TextShade.WHITE)

        ROW_COUNT = sqlCountRow()
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click

        IE.Open("GET", "https://story.kakao.com/a/feeds")
        IE.SetRequestHeader("Referer", "https://story.kakao.com/")
        IE.SetRequestHeader("Content-Type", "application/x-www-form-urlencoded; charset=UTF-8")
        IE.SetRequestHeader("User-Agent", "Mozilla/5.0 (Windows NT 6.1; rv:35.0) Gecko/20100101 Firefox/35.0")
        IE.SetRequestHeader("Accept", "application/json")
        IE.SetRequestHeader("Accept-Language", "ko")
        IE.SetRequestHeader("Host", "story.kakao.com")
        IE.SetRequestHeader("Connection", "keep-alive")
        IE.SetRequestHeader("X-Kakao-ApiLevel", Kakao_API_Level)
        IE.SetRequestHeader("X-Kakao-VC", "d9c450ccd480ac0b0045")
        IE.SetRequestHeader("X-Kakao-DeviceInfo", "web:-;-;-")
        IE.SetRequestHeader("X-Requested-With", "XMLHttpRequest")
        IE.Send()

        Dim jsonFeed As JObject = JObject.Parse(IE.ResponseText)
        Dim feedArray As JArray = jsonFeed.SelectToken("feeds")

        For i = 0 To 12
            Dim tmpCmd As String
            Dim tmpSID As String
            Dim tmpUserID As String
            Dim tmpContent As String

            If feedArray.Item(i).Item("content").ToString() = "" Or Nothing Then
            Else
                tmpCmd = feedArray.Item(i).Item("content").ToString()
                tmpSID = feedArray.Item(i).Item("sid").ToString()
                tmpUserID = Split(tmpSID, ".")(0)

                If InStr(tmpCmd, "!L등록 ") Then
                    tmpContent = Split(tmpCmd, "!L등록 ")(1)

                    IE.Open("GET", "https://story.kakao.com/a/activities/" & tmpSID & "/comments")
                    IE.SetRequestHeader("Referer", "https://story.kakao.com/")
                    IE.SetRequestHeader("Content-Type", "application/x-www-form-urlencoded; charset=UTF-8")
                    IE.SetRequestHeader("User-Agent", "Mozilla/5.0 (Windows NT 6.1; rv:35.0) Gecko/20100101 Firefox/35.0")
                    IE.SetRequestHeader("Accept", "application/json")
                    IE.SetRequestHeader("Accept-Language", "ko")
                    IE.SetRequestHeader("Host", "story.kakao.com")
                    IE.SetRequestHeader("Connection", "keep-alive")
                    IE.SetRequestHeader("X-Kakao-ApiLevel", Kakao_API_Level)
                    IE.SetRequestHeader("X-Kakao-VC", "d9c450ccd480ac0b0045")
                    IE.SetRequestHeader("X-Kakao-DeviceInfo", "web:-;-;-")
                    IE.SetRequestHeader("X-Requested-With", "XMLHttpRequest")
                    IE.Send()

                    Dim commentArray As JArray = JArray.Parse(IE.ResponseText)
                    If InStr(commentArray.ToString, "[리빙포인트 등록 완료]") Then
                    Else
                        sqlRegister(tmpSID, tmpContent, Now)
                        ROW_COUNT = sqlCountRow()
                        txtRegisterID.Text = tmpSID
                        txtregLP.Text = tmpContent
                        sqlLogRegister(tmpUserID, tmpSID, "등록", "")
                        PostComment(tmpSID, "[리빙포인트 등록 완료]\r\n리빙포인트가 정상 등록되었습니다.")
                    End If

                ElseIf InStr(tmpCmd, "!리빙포인트") Then
                    IE.Open("GET", "https://story.kakao.com/a/activities/" & tmpSID & "/comments")
                    IE.SetRequestHeader("Referer", "https://story.kakao.com/")
                    IE.SetRequestHeader("Content-Type", "application/x-www-form-urlencoded; charset=UTF-8")
                    IE.SetRequestHeader("User-Agent", "Mozilla/5.0 (Windows NT 6.1; rv:35.0) Gecko/20100101 Firefox/35.0")
                    IE.SetRequestHeader("Accept", "application/json")
                    IE.SetRequestHeader("Accept-Language", "ko")
                    IE.SetRequestHeader("Host", "story.kakao.com")
                    IE.SetRequestHeader("Connection", "keep-alive")
                    IE.SetRequestHeader("X-Kakao-ApiLevel", Kakao_API_Level)
                    IE.SetRequestHeader("X-Kakao-VC", "d9c450ccd480ac0b0045")
                    IE.SetRequestHeader("X-Kakao-DeviceInfo", "web:-;-;-")
                    IE.SetRequestHeader("X-Requested-With", "XMLHttpRequest")
                    IE.Send()

                    Dim commentArray As JArray = JArray.Parse(IE.ResponseText)
                    If InStr(commentArray.ToString, "[리빙포인트]") Then
                    Else
                        PostComment(tmpSID, "[리빙포인트]\r\n" & sqlLPValue(RandNum(1, ROW_COUNT)))
                        sqlLogRegister(tmpUserID, tmpSID, "조회", "")
                    End If

                End If
            End If
        Next

    End Sub



    Private Sub timerRefresh_Tick(sender As Object, e As EventArgs) Handles timerRefresh.Tick
        lblNowTime.Text = Val(lblNowTime.Text) + 1

        If lblNowTime.Text = lblRefreshTime.Text Then

            btnRefresh.PerformClick()
            lblNowTime.Text = "0"
            lblRefreshTime.Text = RandNum("15", "65")
        End If
    End Sub

    Private Sub MaterialRaisedButton1_Click(sender As Object, e As EventArgs) Handles MaterialRaisedButton1.Click
        lblRefreshTime.Text = RandNum("15", "65")
        timerRefresh.Enabled = True
    End Sub

    Private Sub MaterialRaisedButton2_Click(sender As Object, e As EventArgs) Handles MaterialRaisedButton2.Click
        timerRefresh.Enabled = False
    End Sub

    Private Sub MaterialRaisedButton3_Click(sender As Object, e As EventArgs) Handles MaterialRaisedButton3.Click
        PostNote("[리빙포인트]\r\n리빙포인트 시스템 가동이 시작되었습니다.")
    End Sub

    Private Sub MaterialRaisedButton4_Click(sender As Object, e As EventArgs) Handles MaterialRaisedButton4.Click
        PostNote("[리빙포인트]\r\n리빙포인트 시스템이 재시작될 예정입니다.\r\n재시작 시간은 약 30초 입니다.")
    End Sub

    Private Sub MaterialRaisedButton5_Click(sender As Object, e As EventArgs) Handles MaterialRaisedButton5.Click
        PostNote("[리빙포인트]\r\n리빙포인트 시스템은 현재 점검 중입니다..")
    End Sub

    Private Sub timerUpload_Tick(sender As Object, e As EventArgs) Handles timerUpload.Tick
        lblLPWriteTime.Text = Val(lblLPWriteTime.Text) + 1

        If lblLPWriteTime.Text = 1800 Then
            PostNote("[리빙포인트]\r\n" & sqlLPValue(RandNum(1, ROW_COUNT)))
            sqlLogRegister("Reflection", "Reflection", "글작성", "프로그램")
            lblLPWriteTime.Text = "0"
        End If
    End Sub

    Private Sub MaterialRaisedButton6_Click(sender As Object, e As EventArgs) Handles MaterialRaisedButton6.Click
        PostNote("[리빙포인트]\r\n" & sqlLPValue(RandNum(1, ROW_COUNT)))
        sqlLogRegister("Reflection", "Reflection", "글작성", "프로그램")
    End Sub

    Private Sub MaterialRaisedButton7_Click(sender As Object, e As EventArgs) Handles MaterialRaisedButton7.Click
    End Sub
End Class