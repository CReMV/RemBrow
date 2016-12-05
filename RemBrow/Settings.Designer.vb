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
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.HomePageSpace)
        Me.GroupBox1.Controls.Add(Me.SetHomePageButton)
        Me.GroupBox1.Controls.Add(Me.DefaultHomePageButton)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 13)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(259, 75)
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
        'Settings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightGray
        Me.ClientSize = New System.Drawing.Size(284, 462)
        Me.Controls.Add(Me.SettingsExitButton)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Settings"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "Settings"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents HomePageSpace As TextBox
    Friend WithEvents SetHomePageButton As Button
    Friend WithEvents DefaultHomePageButton As Button
    Friend WithEvents SettingsExitButton As Button
End Class
