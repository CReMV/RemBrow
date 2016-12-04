Public Class RemBrowMW
    Private Sub RemBrowMW_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim tab As New TabPage
        Dim newtab As New Tab
        newtab.Show()
        NewTab.Dock = DockStyle.Fill
        NewTab.TopLevel = False
        tab.Controls.Add(newtab)
        Me.TabControl1.TabPages.Add(tab)
    End Sub
End Class
