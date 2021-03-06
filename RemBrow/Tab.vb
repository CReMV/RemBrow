﻿Public Class Tab
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
            End Try
        Else AweControlA.Source = New Uri(My.Settings.SearchEngine & AddressBar.Text)
        End If
    End Sub
    Private Sub AddressBar_KeyDown(sender As Object, e As KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            If AddressBar.Text.Contains(".com") Or AddressBar.Text.Contains(".net") Or AddressBar.Text.Contains(".org") Or AddressBar.Text.Contains(".edu") Or AddressBar.Text.Contains(".gr") Then
                Try
                    AweControlA.Source = New Uri(AddressBar.Text)
                Catch ex As Exception
                    AweControlA.Source = New Uri("http://" + AddressBar.Text)
                End Try
            Else AweControlA.Source = New Uri(My.Settings.SearchEngine & AddressBar.Text)
            End If
        End If
    End Sub
    Private Sub AweControlA_LoadingFrameComplete(sender As Object, e As Awesomium.Core.FrameEventArgs) Handles AweControlA.LoadingFrameComplete
        LoadingIndicator.Visible = False
        Parent.Text = AweControlA.Title
    End Sub
    Private Sub AweControlA_LoadingFrame(sender As Object, e As Awesomium.Core.FrameEventArgs) Handles AweControlA.LoadingFrame
        LoadingIndicator.Visible = True
    End Sub
    Private Sub AddTabToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddTabToolStripMenuItem.Click
        Dim tab As New TabPage
        Dim newtab As New Tab
        newtab.Show()
        newtab.Dock = DockStyle.Fill
        newtab.TopLevel = False
        tab.Controls.Add(newtab)
        RemBrowMW.TabControl1.TabPages.Add(tab)
        RemBrowMW.TabControl1.SelectedTab = tab
    End Sub
    Private Sub RemoveTabToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RemoveTabToolStripMenuItem.Click
        If RemBrowMW.TabControl1.TabCount = 1 Then
            Dim tab As New TabPage
            Dim newtab As New Tab
            newtab.Show()
            newtab.Dock = DockStyle.Fill
            newtab.TopLevel = False
            tab.Controls.Add(newtab)
            RemBrowMW.TabControl1.TabPages.Add(tab)
            RemBrowMW.TabControl1.SelectedTab = tab
            RemBrowMW.TabControl1.SelectedTab.Dispose()
        Else
            RemBrowMW.TabControl1.SelectedTab.Dispose()
        End If
    End Sub
End Class