Public Class Settings
    Private Sub Settings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        HomePageSpace.Text = My.Settings.HomePage
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
End Class