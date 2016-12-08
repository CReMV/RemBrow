<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Tab
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.AddressBar = New Awesomium.Windows.Forms.AddressBox()
        Me.AweControlA = New Awesomium.Windows.Forms.WebControl(Me.components)
        Me.LoadingIndicator = New System.Windows.Forms.PictureBox()
        Me.GoButton = New System.Windows.Forms.Button()
        Me.HomeButton = New System.Windows.Forms.Button()
        Me.ReloadButton = New System.Windows.Forms.Button()
        Me.StopButton = New System.Windows.Forms.Button()
        Me.ForwardButton = New System.Windows.Forms.Button()
        Me.BackButton = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.RemBrowToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BookMarksToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1.SuspendLayout()
        CType(Me.LoadingIndicator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.AddressBar)
        Me.Panel1.Controls.Add(Me.LoadingIndicator)
        Me.Panel1.Controls.Add(Me.GoButton)
        Me.Panel1.Controls.Add(Me.HomeButton)
        Me.Panel1.Controls.Add(Me.ReloadButton)
        Me.Panel1.Controls.Add(Me.StopButton)
        Me.Panel1.Controls.Add(Me.ForwardButton)
        Me.Panel1.Controls.Add(Me.BackButton)
        Me.Panel1.Controls.Add(Me.MenuStrip1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1024, 39)
        Me.Panel1.TabIndex = 0
        '
        'AddressBar
        '
        Me.AddressBar.AcceptsReturn = True
        Me.AddressBar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AddressBar.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.AddressBar.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.AddressBar.Location = New System.Drawing.Point(453, 8)
        Me.AddressBar.Name = "AddressBar"
        Me.AddressBar.Size = New System.Drawing.Size(477, 22)
        Me.AddressBar.TabIndex = 16
        Me.AddressBar.URL = Nothing
        Me.AddressBar.WebControl = Me.AweControlA
        '
        'AweControlA
        '
        Me.AweControlA.BackColor = System.Drawing.Color.White
        Me.AweControlA.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AweControlA.Location = New System.Drawing.Point(0, 39)
        Me.AweControlA.Size = New System.Drawing.Size(1024, 561)
        Me.AweControlA.TabIndex = 1
        '
        'LoadingIndicator
        '
        Me.LoadingIndicator.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LoadingIndicator.BackgroundImage = Global.RemBrow.My.Resources.Resources.Loading
        Me.LoadingIndicator.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.LoadingIndicator.Image = Global.RemBrow.My.Resources.Resources.Loading
        Me.LoadingIndicator.Location = New System.Drawing.Point(982, 4)
        Me.LoadingIndicator.Name = "LoadingIndicator"
        Me.LoadingIndicator.Size = New System.Drawing.Size(30, 30)
        Me.LoadingIndicator.TabIndex = 15
        Me.LoadingIndicator.TabStop = False
        '
        'GoButton
        '
        Me.GoButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GoButton.Location = New System.Drawing.Point(936, 4)
        Me.GoButton.Name = "GoButton"
        Me.GoButton.Size = New System.Drawing.Size(40, 30)
        Me.GoButton.TabIndex = 13
        Me.GoButton.Text = "GO"
        Me.GoButton.UseVisualStyleBackColor = True
        '
        'HomeButton
        '
        Me.HomeButton.Location = New System.Drawing.Point(387, 4)
        Me.HomeButton.Name = "HomeButton"
        Me.HomeButton.Size = New System.Drawing.Size(60, 30)
        Me.HomeButton.TabIndex = 11
        Me.HomeButton.Text = "HOME"
        Me.HomeButton.UseVisualStyleBackColor = True
        '
        'ReloadButton
        '
        Me.ReloadButton.Location = New System.Drawing.Point(304, 4)
        Me.ReloadButton.Name = "ReloadButton"
        Me.ReloadButton.Size = New System.Drawing.Size(77, 30)
        Me.ReloadButton.TabIndex = 10
        Me.ReloadButton.Text = "RELOAD"
        Me.ReloadButton.UseVisualStyleBackColor = True
        '
        'StopButton
        '
        Me.StopButton.Location = New System.Drawing.Point(241, 4)
        Me.StopButton.Name = "StopButton"
        Me.StopButton.Size = New System.Drawing.Size(57, 30)
        Me.StopButton.TabIndex = 9
        Me.StopButton.Text = "STOP"
        Me.StopButton.UseVisualStyleBackColor = True
        '
        'ForwardButton
        '
        Me.ForwardButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ForwardButton.Location = New System.Drawing.Point(204, 4)
        Me.ForwardButton.Margin = New System.Windows.Forms.Padding(4)
        Me.ForwardButton.Name = "ForwardButton"
        Me.ForwardButton.Size = New System.Drawing.Size(30, 30)
        Me.ForwardButton.TabIndex = 8
        Me.ForwardButton.Text = ">"
        Me.ForwardButton.UseVisualStyleBackColor = True
        '
        'BackButton
        '
        Me.BackButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.BackButton.Location = New System.Drawing.Point(166, 4)
        Me.BackButton.Margin = New System.Windows.Forms.Padding(4)
        Me.BackButton.Name = "BackButton"
        Me.BackButton.Size = New System.Drawing.Size(30, 30)
        Me.BackButton.TabIndex = 7
        Me.BackButton.Text = "<"
        Me.BackButton.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RemBrowToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1024, 24)
        Me.MenuStrip1.TabIndex = 14
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'RemBrowToolStripMenuItem
        '
        Me.RemBrowToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SettingsToolStripMenuItem, Me.BookMarksToolStripMenuItem})
        Me.RemBrowToolStripMenuItem.Name = "RemBrowToolStripMenuItem"
        Me.RemBrowToolStripMenuItem.Size = New System.Drawing.Size(70, 20)
        Me.RemBrowToolStripMenuItem.Text = "RemBrow"
        '
        'SettingsToolStripMenuItem
        '
        Me.SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem"
        Me.SettingsToolStripMenuItem.Size = New System.Drawing.Size(133, 22)
        Me.SettingsToolStripMenuItem.Text = "Settings"
        '
        'BookMarksToolStripMenuItem
        '
        Me.BookMarksToolStripMenuItem.Name = "BookMarksToolStripMenuItem"
        Me.BookMarksToolStripMenuItem.Size = New System.Drawing.Size(133, 22)
        Me.BookMarksToolStripMenuItem.Text = "BookMarks"
        '
        'Tab
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(1024, 600)
        Me.Controls.Add(Me.AweControlA)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Tab"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "WebPageTab"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.LoadingIndicator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents GoButton As Button
    Friend WithEvents HomeButton As Button
    Friend WithEvents ReloadButton As Button
    Friend WithEvents StopButton As Button
    Friend WithEvents ForwardButton As Button
    Friend WithEvents BackButton As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents RemBrowToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SettingsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BookMarksToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LoadingIndicator As PictureBox
    Friend WithEvents AddressBar As Awesomium.Windows.Forms.AddressBox
    Friend WithEvents AweControlA As Awesomium.Windows.Forms.WebControl
End Class
