Imports MaterialSkin

Public Class frmLogin

    '//컨트롤 센터 설정
    Private Sub CenterMe()
        txtID.Left = (Me.Size.Width / 2) - (txtID.Width / 2)
        txtPW.Left = (Me.Size.Width / 2) - (txtPW.Width / 2)
    End Sub

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '//스킨 설정
        Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance

        SkinManager.AddFormToManage(Me)
        SkinManager.Theme = MaterialSkinManager.Themes.LIGHT
        SkinManager.ColorScheme = New ColorScheme(Primary.Yellow700, Primary.Yellow800, Primary.Yellow300, Accent.Orange700, TextShade.WHITE)

        CenterMe()

    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        frmCaptcha.Show()
        '//Me.Close()
    End Sub

    Private Sub MaterialLabel2_Click(sender As Object, e As EventArgs) Handles MaterialLabel2.Click
        ErrorMessage("Copyrightⓒ Reflection 2017" & vbCrLf & "Material Skin is made by IgnaceMaes.")
    End Sub
End Class