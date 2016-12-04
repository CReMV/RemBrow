﻿Public Class Settings
    Private Sub Settings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        HomePageSpace.Text = My.Settings.HomePage
    End Sub

    Private Sub SetHomePageButton_Click(sender As Object, e As EventArgs) Handles SetHomePageButton.Click
        My.Settings.HomePage = HomePageSpace.Text
        MsgBox("Done")
    End Sub

    Private Sub DefaultHomePageButton_Click(sender As Object, e As EventArgs) Handles DefaultHomePageButton.Click
        My.Settings.HomePage = ("http://www.google.com")
        MsgBox("Done")
    End Sub

    Private Sub SettingsExitButton_Click(sender As Object, e As EventArgs) Handles SettingsExitButton.Click
        Me.Visible = False
    End Sub
End Class