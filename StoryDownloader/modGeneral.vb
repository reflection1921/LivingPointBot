Imports System.Drawing.Text
Imports MySql.Data.MySqlClient

Module modGeneral

    Public IE As New WinHttp.WinHttpRequest
    Public connection As String = "server=" & DB_IP & ";user=" & DB_ID & ";database=" & DB_DBNAME & ";port=" & DB_PORT & ";password=" & DB_PASS

    Public Function ErrorMessage(Content As String)
        MsgBox(Content)
    End Function

    Public Function URLEncodeUTF8(ByVal Text As String) As String
        Dim i As Integer
        Dim Ansi() As Byte
        Dim AsciiCode As Short
        Dim strEncode As String

        Ansi = System.Text.Encoding.UTF8.GetBytes(Text)
        strEncode = ""

        For i = 0 To UBound(Ansi)
            AsciiCode = Ansi(i)

            Select Case AsciiCode
                Case 48 To 57, 65 To 90, 97 To 122
                    strEncode = strEncode & Chr(AsciiCode)
                Case 32
                    strEncode = strEncode & "+"
                Case Else
                    If AsciiCode < 16 Then
                        strEncode = strEncode & "%0" & Hex(AsciiCode)
                    Else
                        strEncode = strEncode & "%" & Hex(AsciiCode)
                    End If
            End Select
        Next i
        URLEncodeUTF8 = strEncode
    End Function

    Public Function sqlRegister(name As String, content As String, dates As String)

        Dim sqlQuery As String = " insert into lpdata (name, content, date, comments) values (@name, @content, @date, @comments)"

        Using sqlConn As New MySqlConnection(connection)
            Using sqlComm As New MySqlCommand()
                sqlComm.Connection = sqlConn
                sqlComm.CommandText = sqlQuery
                sqlComm.CommandType = CommandType.Text
                sqlComm.Parameters.AddWithValue("@name", name)
                sqlComm.Parameters.AddWithValue("@content", content)
                sqlComm.Parameters.AddWithValue("@date", Now)
                sqlComm.Parameters.AddWithValue("@comments", "유저 작성")
                sqlConn.Open()
                Dim sqlReader As MySqlDataReader = sqlComm.ExecuteReader()
                sqlConn.Close()
            End Using
        End Using
    End Function

    Public Function sqlLogRegister(userid As String, sid As String, command As String, comments As String)
        Dim sqlQuery As String = " insert into lplog (userid, sid, date, time, command, comments) values (@userid, @sid, @date, @time, @command, @comments)"

        Using sqlConn As New MySqlConnection(connection)
            Using sqlComm As New MySqlCommand()
                sqlComm.Connection = sqlConn
                sqlComm.CommandText = sqlQuery
                sqlComm.CommandType = CommandType.Text
                sqlComm.Parameters.AddWithValue("@userid", userid)
                sqlComm.Parameters.AddWithValue("@sid", sid)
                sqlComm.Parameters.AddWithValue("@date", Now.Date)
                sqlComm.Parameters.AddWithValue("@time", Now.Hour & "시" & " " & Now.Minute & "분")
                sqlComm.Parameters.AddWithValue("@command", command)
                sqlComm.Parameters.AddWithValue("@comments", comments)
                sqlConn.Open()
                Dim sqlReader As MySqlDataReader = sqlComm.ExecuteReader()
                sqlConn.Close()
            End Using
        End Using
    End Function

    Public Function sqlCountRow()
        Dim sqlQuery As String = "SELECT count(*) FROM lpdata"
        Dim tmpCount As Integer

        Using sqlConn As New MySqlConnection(connection)
            Using sqlComm As New MySqlCommand()
                sqlComm.Connection = sqlConn
                sqlComm.CommandText = sqlQuery
                sqlComm.CommandType = CommandType.Text
                sqlConn.Open()
                Dim sqlReader As MySqlDataReader = sqlComm.ExecuteReader()
                While sqlReader.Read()
                    tmpCount = sqlReader("count(*)").ToString()
                End While
                sqlConn.Close()
            End Using
        End Using

        Return tmpCount
    End Function

    Public Function RandNum(minValue As Integer, maxValue As Integer) As Integer

        Dim RandValue As Integer
        RandValue = Int((maxValue - minValue + 1) * Rnd() + minValue)
        Return RandValue

    End Function

    Public Function sqlLPValue(RndData As Integer)
        Dim tmpContent As String
        Dim sqlQuery As String = "select content from lpdata where id=@RNDVAL"
        Using sqlConn As New MySqlConnection(connection)
            Using sqlComm As New MySqlCommand()
                sqlComm.Connection = sqlConn

                sqlComm.CommandText = sqlQuery
                sqlComm.CommandType = CommandType.Text
                sqlComm.Parameters.AddWithValue("@RNDVAL", RndData)
                sqlConn.Open()
                Dim sqlReader As MySqlDataReader = sqlComm.ExecuteReader()
                While sqlReader.Read()
                    tmpContent = sqlReader("content").ToString()
                End While
                sqlConn.Close()
            End Using
        End Using
        Return tmpContent
    End Function

End Module
