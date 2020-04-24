<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.welcomeLabel = New System.Windows.Forms.Label()
        Me.developperLabel = New System.Windows.Forms.Label()
        Me.welcomeLabel2 = New System.Windows.Forms.Label()
        Me.groupsGroupBox = New System.Windows.Forms.GroupBox()
        Me.finishTheGroupsButton = New System.Windows.Forms.Button()
        Me.listOfTheGroupsLabel = New System.Windows.Forms.Label()
        Me.groupsListBox = New System.Windows.Forms.ListBox()
        Me.removeGroupButton = New System.Windows.Forms.Button()
        Me.addGroupButton = New System.Windows.Forms.Button()
        Me.playersGroupBox = New System.Windows.Forms.GroupBox()
        Me.finishThePlayersButton = New System.Windows.Forms.Button()
        Me.listOfThePlayersLabel = New System.Windows.Forms.Label()
        Me.playersListBox = New System.Windows.Forms.ListBox()
        Me.removePlayerButton = New System.Windows.Forms.Button()
        Me.addPlayerButton = New System.Windows.Forms.Button()
        Me.createButton = New System.Windows.Forms.Button()
        Me.permissionsFile = New System.Windows.Forms.ListBox()
        Me.VersionLabel = New System.Windows.Forms.Label()
        Me.groupsGroupBox.SuspendLayout()
        Me.playersGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'welcomeLabel
        '
        Me.welcomeLabel.AutoSize = True
        Me.welcomeLabel.Location = New System.Drawing.Point(13, 11)
        Me.welcomeLabel.Name = "welcomeLabel"
        Me.welcomeLabel.Size = New System.Drawing.Size(260, 13)
        Me.welcomeLabel.TabIndex = 0
        Me.welcomeLabel.Text = "Welcome to the PermissionsEx configuration program!"
        '
        'developperLabel
        '
        Me.developperLabel.AutoSize = True
        Me.developperLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.developperLabel.Location = New System.Drawing.Point(291, 246)
        Me.developperLabel.Name = "developperLabel"
        Me.developperLabel.Size = New System.Drawing.Size(131, 13)
        Me.developperLabel.TabIndex = 1
        Me.developperLabel.Text = "Developer: nathan060700"
        '
        'welcomeLabel2
        '
        Me.welcomeLabel2.AutoSize = True
        Me.welcomeLabel2.Location = New System.Drawing.Point(13, 28)
        Me.welcomeLabel2.Name = "welcomeLabel2"
        Me.welcomeLabel2.Size = New System.Drawing.Size(290, 13)
        Me.welcomeLabel2.TabIndex = 2
        Me.welcomeLabel2.Text = "This program will help you to create your permissions.yml file!"
        '
        'groupsGroupBox
        '
        Me.groupsGroupBox.Controls.Add(Me.finishTheGroupsButton)
        Me.groupsGroupBox.Controls.Add(Me.listOfTheGroupsLabel)
        Me.groupsGroupBox.Controls.Add(Me.groupsListBox)
        Me.groupsGroupBox.Controls.Add(Me.removeGroupButton)
        Me.groupsGroupBox.Controls.Add(Me.addGroupButton)
        Me.groupsGroupBox.Location = New System.Drawing.Point(13, 47)
        Me.groupsGroupBox.Name = "groupsGroupBox"
        Me.groupsGroupBox.Size = New System.Drawing.Size(200, 166)
        Me.groupsGroupBox.TabIndex = 1
        Me.groupsGroupBox.TabStop = False
        Me.groupsGroupBox.Text = "Groups"
        '
        'finishTheGroupsButton
        '
        Me.finishTheGroupsButton.Location = New System.Drawing.Point(48, 137)
        Me.finishTheGroupsButton.Name = "finishTheGroupsButton"
        Me.finishTheGroupsButton.Size = New System.Drawing.Size(96, 23)
        Me.finishTheGroupsButton.TabIndex = 3
        Me.finishTheGroupsButton.Text = "Finish the groups"
        Me.finishTheGroupsButton.UseVisualStyleBackColor = True
        '
        'listOfTheGroupsLabel
        '
        Me.listOfTheGroupsLabel.AutoSize = True
        Me.listOfTheGroupsLabel.Location = New System.Drawing.Point(6, 46)
        Me.listOfTheGroupsLabel.Name = "listOfTheGroupsLabel"
        Me.listOfTheGroupsLabel.Size = New System.Drawing.Size(91, 13)
        Me.listOfTheGroupsLabel.TabIndex = 4
        Me.listOfTheGroupsLabel.Text = "List of the groups:"
        '
        'groupsListBox
        '
        Me.groupsListBox.FormattingEnabled = True
        Me.groupsListBox.Location = New System.Drawing.Point(6, 62)
        Me.groupsListBox.Name = "groupsListBox"
        Me.groupsListBox.Size = New System.Drawing.Size(187, 69)
        Me.groupsListBox.TabIndex = 2
        Me.groupsListBox.UseTabStops = False
        '
        'removeGroupButton
        '
        Me.removeGroupButton.Location = New System.Drawing.Point(36, 20)
        Me.removeGroupButton.Name = "removeGroupButton"
        Me.removeGroupButton.Size = New System.Drawing.Size(23, 23)
        Me.removeGroupButton.TabIndex = 1
        Me.removeGroupButton.Text = "-"
        Me.removeGroupButton.UseVisualStyleBackColor = True
        '
        'addGroupButton
        '
        Me.addGroupButton.Location = New System.Drawing.Point(7, 20)
        Me.addGroupButton.Name = "addGroupButton"
        Me.addGroupButton.Size = New System.Drawing.Size(23, 23)
        Me.addGroupButton.TabIndex = 0
        Me.addGroupButton.Text = "+"
        Me.addGroupButton.UseVisualStyleBackColor = True
        '
        'playersGroupBox
        '
        Me.playersGroupBox.Controls.Add(Me.finishThePlayersButton)
        Me.playersGroupBox.Controls.Add(Me.listOfThePlayersLabel)
        Me.playersGroupBox.Controls.Add(Me.playersListBox)
        Me.playersGroupBox.Controls.Add(Me.removePlayerButton)
        Me.playersGroupBox.Controls.Add(Me.addPlayerButton)
        Me.playersGroupBox.Location = New System.Drawing.Point(219, 47)
        Me.playersGroupBox.Name = "playersGroupBox"
        Me.playersGroupBox.Size = New System.Drawing.Size(200, 166)
        Me.playersGroupBox.TabIndex = 2
        Me.playersGroupBox.TabStop = False
        Me.playersGroupBox.Text = "Players"
        '
        'finishThePlayersButton
        '
        Me.finishThePlayersButton.Location = New System.Drawing.Point(50, 137)
        Me.finishThePlayersButton.Name = "finishThePlayersButton"
        Me.finishThePlayersButton.Size = New System.Drawing.Size(96, 23)
        Me.finishThePlayersButton.TabIndex = 3
        Me.finishThePlayersButton.Text = "Finish the players"
        Me.finishThePlayersButton.UseVisualStyleBackColor = True
        '
        'listOfThePlayersLabel
        '
        Me.listOfThePlayersLabel.AutoSize = True
        Me.listOfThePlayersLabel.Location = New System.Drawing.Point(6, 46)
        Me.listOfThePlayersLabel.Name = "listOfThePlayersLabel"
        Me.listOfThePlayersLabel.Size = New System.Drawing.Size(92, 13)
        Me.listOfThePlayersLabel.TabIndex = 4
        Me.listOfThePlayersLabel.Text = "List of the players:"
        '
        'playersListBox
        '
        Me.playersListBox.FormattingEnabled = True
        Me.playersListBox.Location = New System.Drawing.Point(6, 62)
        Me.playersListBox.Name = "playersListBox"
        Me.playersListBox.Size = New System.Drawing.Size(187, 69)
        Me.playersListBox.TabIndex = 2
        Me.playersListBox.TabStop = False
        '
        'removePlayerButton
        '
        Me.removePlayerButton.Location = New System.Drawing.Point(36, 20)
        Me.removePlayerButton.Name = "removePlayerButton"
        Me.removePlayerButton.Size = New System.Drawing.Size(23, 23)
        Me.removePlayerButton.TabIndex = 1
        Me.removePlayerButton.Text = "-"
        Me.removePlayerButton.UseVisualStyleBackColor = True
        '
        'addPlayerButton
        '
        Me.addPlayerButton.Location = New System.Drawing.Point(7, 20)
        Me.addPlayerButton.Name = "addPlayerButton"
        Me.addPlayerButton.Size = New System.Drawing.Size(23, 23)
        Me.addPlayerButton.TabIndex = 0
        Me.addPlayerButton.Text = "+"
        Me.addPlayerButton.UseVisualStyleBackColor = True
        '
        'createButton
        '
        Me.createButton.Location = New System.Drawing.Point(134, 220)
        Me.createButton.Name = "createButton"
        Me.createButton.Size = New System.Drawing.Size(163, 23)
        Me.createButton.TabIndex = 3
        Me.createButton.Text = "Create your permissions.yml file!"
        Me.createButton.UseVisualStyleBackColor = True
        '
        'permissionsFile
        '
        Me.permissionsFile.FormattingEnabled = True
        Me.permissionsFile.Items.AddRange(New Object() {"groups:"})
        Me.permissionsFile.Location = New System.Drawing.Point(12, 220)
        Me.permissionsFile.Name = "permissionsFile"
        Me.permissionsFile.Size = New System.Drawing.Size(136, 17)
        Me.permissionsFile.TabIndex = 9
        Me.permissionsFile.Visible = False
        '
        'VersionLabel
        '
        Me.VersionLabel.AutoSize = True
        Me.VersionLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.VersionLabel.Location = New System.Drawing.Point(10, 246)
        Me.VersionLabel.Name = "VersionLabel"
        Me.VersionLabel.Size = New System.Drawing.Size(45, 13)
        Me.VersionLabel.TabIndex = 10
        Me.VersionLabel.Text = "Version:"
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(434, 267)
        Me.Controls.Add(Me.VersionLabel)
        Me.Controls.Add(Me.permissionsFile)
        Me.Controls.Add(Me.createButton)
        Me.Controls.Add(Me.playersGroupBox)
        Me.Controls.Add(Me.groupsGroupBox)
        Me.Controls.Add(Me.welcomeLabel2)
        Me.Controls.Add(Me.developperLabel)
        Me.Controls.Add(Me.welcomeLabel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Main"
        Me.Text = "PermissionsEx configuration program"
        Me.groupsGroupBox.ResumeLayout(False)
        Me.groupsGroupBox.PerformLayout()
        Me.playersGroupBox.ResumeLayout(False)
        Me.playersGroupBox.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents welcomeLabel As System.Windows.Forms.Label
    Friend WithEvents developperLabel As System.Windows.Forms.Label
    Friend WithEvents welcomeLabel2 As System.Windows.Forms.Label
    Friend WithEvents groupsGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents finishTheGroupsButton As System.Windows.Forms.Button
    Friend WithEvents listOfTheGroupsLabel As System.Windows.Forms.Label
    Friend WithEvents groupsListBox As System.Windows.Forms.ListBox
    Friend WithEvents removeGroupButton As System.Windows.Forms.Button
    Friend WithEvents addGroupButton As System.Windows.Forms.Button
    Friend WithEvents playersGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents finishThePlayersButton As System.Windows.Forms.Button
    Friend WithEvents listOfThePlayersLabel As System.Windows.Forms.Label
    Friend WithEvents playersListBox As System.Windows.Forms.ListBox
    Friend WithEvents removePlayerButton As System.Windows.Forms.Button
    Friend WithEvents addPlayerButton As System.Windows.Forms.Button
    Friend WithEvents createButton As System.Windows.Forms.Button
    Friend WithEvents permissionsFile As System.Windows.Forms.ListBox
    Friend WithEvents VersionLabel As Label
End Class
