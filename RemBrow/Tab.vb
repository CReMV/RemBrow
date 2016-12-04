﻿Public Class Tab
    Private Sub SettingsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SettingsToolStripMenuItem.Click
        Settings.Show()
    End Sub
    Private Sub Tab_Load(sender As Object, e As EventArgs) Handles Me.Load
        WebControl1.Source = New Uri(My.Settings.HomePage)
    End Sub

    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click
        If WebControl1.CanGoBack Then
            WebControl1.GoBack()
        End If
    End Sub

    Private Sub ForwardButton_Click(sender As Object, e As EventArgs) Handles ForwardButton.Click
        If WebControl1.CanGoForward Then
            WebControl1.GoForward()
        End If
    End Sub

    Private Sub StopButton_Click(sender As Object, e As EventArgs) Handles StopButton.Click
        If WebControl1.IsNavigating Then
            WebControl1.Stop()
        End If
    End Sub

    Private Sub ReloadButton_Click(sender As Object, e As EventArgs) Handles ReloadButton.Click
        WebControl1.Reload(ignoreCache:=True)
    End Sub

    Private Sub HomeButton_Click(sender As Object, e As EventArgs) Handles HomeButton.Click
        WebControl1.Source = New Uri(My.Settings.HomePage)
    End Sub

    Private Sub GoButton_Click(sender As Object, e As EventArgs) Handles GoButton.Click
        If AddressBar.Text.Contains(".com") Or AddressBar.Text.Contains(".net") Or AddressBar.Text.Contains(".org") Or AddressBar.Text.Contains(".edu") Or AddressBar.Text.Contains(".gr") And AddressBar.Text.Contains("http://") Then
            Try
                WebControl1.Source = New Uri(AddressBar.Text)
            Catch ex As System.UriFormatException
                WebControl1.Source = New Uri("http://" + AddressBar.Text)
                AddressBar.Text = "http://" + AddressBar.Text
            End Try
        Else : WebControl1.Source = New Uri("https://www.google.gr/webhp?sourceid=chrome-instant&ion=1&espv=2&ie=UTF-8#q=" & AddressBar.Text)
        End If
    End Sub

    Private Sub AddressBar_KeyDown(sender As Object, e As KeyEventArgs) Handles AddressBar.KeyDown
        If AddressBar.Text.Contains(".com") Or AddressBar.Text.Contains(".net") Or AddressBar.Text.Contains(".org") Or AddressBar.Text.Contains(".edu") Or AddressBar.Text.Contains(".gr") And AddressBar.Text.Contains("http://") Then
            Try
                WebControl1.Source = New Uri(AddressBar.Text)
            Catch ex As System.UriFormatException
                WebControl1.Source = New Uri("http://" + AddressBar.Text)
                AddressBar.Text = "http://" + AddressBar.Text
            End Try
        Else : WebControl1.Source = New Uri("https://www.google.gr/webhp?sourceid=chrome-instant&ion=1&espv=2&ie=UTF-8#q=" & AddressBar.Text)
        End If
    End Sub

    Private Sub WebControl1_LoadingFrameComplete(sender As Object, e As Awesomium.Core.LoadingFrameEventArgs) Handles WebControl1.LoadingFrameComplete
        LoadingIndicator.Visible = False
        Parent.Text = WebControl1.Title
        AddressBar.Text = WebControl1.Source.ToString
    End Sub
    Private Sub WebControl1_LoadingFrame(sender As Object, e As Awesomium.Core.LoadingFrameEventArgs) Handles WebControl1.LoadingFrame
        LoadingIndicator.Visible = True
    End Sub
End Class