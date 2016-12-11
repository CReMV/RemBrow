Public Class Settings
    Private Sub Settings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        HomePageSpace.Text = My.Settings.HomePage
        If (My.Settings.SearchEngine = ("https://gr.search.yahoo.com/search?p=")) Then
            SE2.Select()
        ElseIf (My.Settings.SearchEngine = ("https://www.bing.com/search?q=")) Then
            SE3.Select()
        Else
            SE1.Select()
        End If
    End Sub
    Private Sub SetHomePageButton_Click(sender As Object, e As EventArgs) Handles SetHomePageButton.Click
        My.Settings.HomePage = HomePageSpace.Text
        MsgBox("New Home Page set!")
    End Sub
    Private Sub DefaultHomePageButton_Click(sender As Object, e As EventArgs) Handles DefaultHomePageButton.Click
        My.Settings.HomePage = ("http://www.google.com")
        HomePageSpace.Text = My.Settings.HomePage
        MsgBox("Home Page reverted to default!")
    End Sub
    Private Sub SettingsExitButton_Click(sender As Object, e As EventArgs) Handles SettingsExitButton.Click
        Me.Visible = False
    End Sub
    Private Sub SE1_CheckedChanged(sender As Object, e As EventArgs) Handles SE1.CheckedChanged
        My.Settings.SearchEngine = ("https://www.google.gr/webhp?sourceid=chrome-instant&ion=1&espv=2&ie=UTF-8#q=")
    End Sub
    Private Sub SE2_CheckedChanged(sender As Object, e As EventArgs) Handles SE2.CheckedChanged
        My.Settings.SearchEngine = ("https://gr.search.yahoo.com/search?p=")
    End Sub
    Private Sub SE3_CheckedChanged(sender As Object, e As EventArgs) Handles SE3.CheckedChanged
        My.Settings.SearchEngine = ("https://www.bing.com/search?q=")
    End Sub
End Class