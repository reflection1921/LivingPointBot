Module modKakao
    Public Function refreshFeed()
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
    End Function

    Public Function PostComment(BoardNum As String, Content As String)

        IE.Open("POST", "https://story.kakao.com/a/activities/" & BoardNum & "/comments?_=143144664245215")
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
        IE.Send("text=" & URLEncodeUTF8("여기를 눌러 답변을 확인해보세요!") & "&decorators=%5B%7B%22type%22%3A%22text%22%2C%22text%22%3A%22" & URLEncodeUTF8(Content) & "%22%7D%5D")

    End Function

    Public Function PostNote(content As String)
        IE.Open("POST", "https://story.kakao.com/a/activities?_=1423185686003148")
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
        IE.Send("content=%5B%7B%22type%22%3A%22text%22%2C%22text%22%3A%22" & URLEncodeUTF8(content) & "%22%7D%5D&permission=F&comment_all_writable=true&enable_share=true")

    End Function
End Module
