Imports MaterialSkin
Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '//스킨 및 폰트 관련 설정
        Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance
        'LoadFont()
        'SkinManager.ROBOTO_MEDIUM_10 = New Font(NotoSansKR_Medium.Families(0), 10)
        'SkinManager.ROBOTO_MEDIUM_11 = New Font(NotoSansKR_Medium.Families(0), 11)
        'SkinManager.ROBOTO_MEDIUM_12 = New Font(NotoSansKR_Medium.Families(0), 12)
        'SkinManager.ROBOTO_REGULAR_11 = New Font(NotoSansKR_Regular.Families(0), 11)
        SkinManager.AddFormToManage(Me)
        SkinManager.Theme = MaterialSkinManager.Themes.LIGHT
        SkinManager.ColorScheme = New ColorScheme(Primary.Yellow700, Primary.Yellow800, Primary.Yellow300, Accent.LightBlue200, TextShade.WHITE)

        frmLogin.Show()
        Me.Close()
    End Sub
End Class
