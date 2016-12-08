Public Class Tab
    Private Sub SettingsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SettingsToolStripMenuItem.Click
        Settings.Show()
    End Sub
    Private Sub Tab_Load(sender As Object, e As EventArgs) Handles Me.Load
        AweControlA.Source = New Uri(My.Settings.HomePage)
    End Sub
    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click
        If AweControlA.CanGoBack Then
            AweControlA.GoBack()
        End If
    End Sub
    Private Sub ForwardButton_Click(sender As Object, e As EventArgs) Handles ForwardButton.Click
        If AweControlA.CanGoForward Then
            AweControlA.GoForward()
        End If
    End Sub
    Private Sub StopButton_Click(sender As Object, e As EventArgs) Handles StopButton.Click
        If AweControlA.IsNavigating Then
            AweControlA.Stop()
        End If
    End Sub
    Private Sub ReloadButton_Click(sender As Object, e As EventArgs) Handles ReloadButton.Click
        AweControlA.Reload(ignoreCache:=True)
    End Sub
    Private Sub HomeButton_Click(sender As Object, e As EventArgs) Handles HomeButton.Click
        AweControlA.Source = New Uri(My.Settings.HomePage)
    End Sub
    Private Sub GoButton_Click(sender As Object, e As EventArgs) Handles GoButton.Click
        If AddressBar.Text.Contains(".com") Or AddressBar.Text.Contains(".net") Or AddressBar.Text.Contains(".org") Or AddressBar.Text.Contains(".edu") Or AddressBar.Text.Contains(".gr") Then
            Try
                AweControlA.Source = New Uri(AddressBar.Text)
            Catch ex As Exception
                AweControlA.Source = New Uri("http://" + AddressBar.Text)
                AddressBar.Text = "http://" + AddressBar.Text
            End Try
        Else : AweControlA.Source = New Uri("https://www.google.gr/webhp?sourceid=chrome-instant&ion=1&espv=2&ie=UTF-8#q=" & AddressBar.Text)
        End If
    End Sub
    Private Sub AddressBar_KeyDown(sender As Object, e As KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            If AddressBar.Text.Contains(".com") Or AddressBar.Text.Contains(".net") Or AddressBar.Text.Contains(".org") Or AddressBar.Text.Contains(".edu") Or AddressBar.Text.Contains(".gr") Then
                Try
                    AweControlA.Source = New Uri(AddressBar.Text)
                Catch ex As Exception
                    AweControlA.Source = New Uri("http://" + AddressBar.Text)
                    AddressBar.Text = "http://" + AddressBar.Text
                End Try
            Else : AweControlA.Source = New Uri("https://www.google.gr/webhp?sourceid=chrome-instant&ion=1&espv=2&ie=UTF-8#q=" & AddressBar.Text)
            End If
        End If
    End Sub
    'Private Sub AweControlA_LoadingFrameComplete(sender As Object, e As Awesomium.Core.LoadingFrameEventArgs) Handles AweControlA.LoadingFrameComplete
    '    LoadingIndicator.Enabled = False
    '    Parent.Text = AweControlA.Title
    'End Sub
    'Private Sub AweControlA_LoadingFrame(sender As Object, e As Awesomium.Core.LoadingFrameEventArgs) Handles AweControlA.LoadingFrame
    '    LoadingIndicator.Enabled = True
    'End Sub
End Class