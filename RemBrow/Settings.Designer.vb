<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Settings
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.HomePageSpace = New System.Windows.Forms.TextBox()
        Me.SetHomePageButton = New System.Windows.Forms.Button()
        Me.DefaultHomePageButton = New System.Windows.Forms.Button()
        Me.SettingsExitButton = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.SE1 = New System.Windows.Forms.RadioButton()
        Me.SE2 = New System.Windows.Forms.RadioButton()
        Me.SE3 = New System.Windows.Forms.RadioButton()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.HomePageSpace)
        Me.GroupBox1.Controls.Add(Me.SetHomePageButton)
        Me.GroupBox1.Controls.Add(Me.DefaultHomePageButton)
        Me.GroupBox1.Location = New System.Drawing.Point(9, 13)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(0)
        Me.GroupBox1.Size = New System.Drawing.Size(266, 75)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "HomePage"
        '
        'HomePageSpace
        '
        Me.HomePageSpace.Location = New System.Drawing.Point(6, 19)
        Me.HomePageSpace.Multiline = True
        Me.HomePageSpace.Name = "HomePageSpace"
        Me.HomePageSpace.Size = New System.Drawing.Size(247, 20)
        Me.HomePageSpace.TabIndex = 2
        '
        'SetHomePageButton
        '
        Me.SetHomePageButton.Location = New System.Drawing.Point(97, 45)
        Me.SetHomePageButton.Name = "SetHomePageButton"
        Me.SetHomePageButton.Size = New System.Drawing.Size(75, 23)
        Me.SetHomePageButton.TabIndex = 1
        Me.SetHomePageButton.Text = "Set"
        Me.SetHomePageButton.UseVisualStyleBackColor = True
        '
        'DefaultHomePageButton
        '
        Me.DefaultHomePageButton.Location = New System.Drawing.Point(178, 45)
        Me.DefaultHomePageButton.Name = "DefaultHomePageButton"
        Me.DefaultHomePageButton.Size = New System.Drawing.Size(75, 23)
        Me.DefaultHomePageButton.TabIndex = 0
        Me.DefaultHomePageButton.Text = "Default"
        Me.DefaultHomePageButton.UseVisualStyleBackColor = True
        '
        'SettingsExitButton
        '
        Me.SettingsExitButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SettingsExitButton.Location = New System.Drawing.Point(233, 427)
        Me.SettingsExitButton.Name = "SettingsExitButton"
        Me.SettingsExitButton.Size = New System.Drawing.Size(39, 23)
        Me.SettingsExitButton.TabIndex = 1
        Me.SettingsExitButton.Text = "Exit"
        Me.SettingsExitButton.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.SE3)
        Me.GroupBox2.Controls.Add(Me.SE2)
        Me.GroupBox2.Controls.Add(Me.SE1)
        Me.GroupBox2.Location = New System.Drawing.Point(9, 98)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(0)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(0)
        Me.GroupBox2.Size = New System.Drawing.Size(266, 88)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Search Engines"
        '
        'SE1
        '
        Me.SE1.AutoSize = True
        Me.SE1.Location = New System.Drawing.Point(6, 17)
        Me.SE1.Name = "SE1"
        Me.SE1.Size = New System.Drawing.Size(59, 17)
        Me.SE1.TabIndex = 0
        Me.SE1.TabStop = True
        Me.SE1.Text = "Google"
        Me.SE1.UseVisualStyleBackColor = True
        '
        'SE2
        '
        Me.SE2.AutoSize = True
        Me.SE2.Location = New System.Drawing.Point(6, 40)
        Me.SE2.Name = "SE2"
        Me.SE2.Size = New System.Drawing.Size(56, 17)
        Me.SE2.TabIndex = 1
        Me.SE2.TabStop = True
        Me.SE2.Text = "Yahoo"
        Me.SE2.UseVisualStyleBackColor = True
        '
        'SE3
        '
        Me.SE3.AutoSize = True
        Me.SE3.Location = New System.Drawing.Point(6, 63)
        Me.SE3.Name = "SE3"
        Me.SE3.Size = New System.Drawing.Size(46, 17)
        Me.SE3.TabIndex = 2
        Me.SE3.TabStop = True
        Me.SE3.Text = "Bing"
        Me.SE3.UseVisualStyleBackColor = True
        '
        'Settings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightGray
        Me.ClientSize = New System.Drawing.Size(284, 462)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.SettingsExitButton)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Settings"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "Settings"
        Me.TopMost = True
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents HomePageSpace As TextBox
    Friend WithEvents SetHomePageButton As Button
    Friend WithEvents DefaultHomePageButton As Button
    Friend WithEvents SettingsExitButton As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents SE3 As RadioButton
    Friend WithEvents SE2 As RadioButton
    Friend WithEvents SE1 As RadioButton
End Class
