<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class addAPlayer
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(addAPlayer))
        Me.nameTextBox = New System.Windows.Forms.TextBox()
        Me.nameLabel = New System.Windows.Forms.Label()
        Me.selectPlayerGroupLabel = New System.Windows.Forms.Label()
        Me.groupsList = New System.Windows.Forms.ListBox()
        Me.addThePlayerButton = New System.Windows.Forms.Button()
        Me.ButtonemoveSelectedPermission = New System.Windows.Forms.Button()
        Me.permissionsListBox = New System.Windows.Forms.ListBox()
        Me.addPermissionButton = New System.Windows.Forms.Button()
        Me.permissionTextBox = New System.Windows.Forms.TextBox()
        Me.permissionsLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'nameTextBox
        '
        Me.nameTextBox.Location = New System.Drawing.Point(56, 13)
        Me.nameTextBox.Name = "nameTextBox"
        Me.nameTextBox.Size = New System.Drawing.Size(146, 20)
        Me.nameTextBox.TabIndex = 0
        '
        'nameLabel
        '
        Me.nameLabel.AutoSize = True
        Me.nameLabel.Location = New System.Drawing.Point(12, 16)
        Me.nameLabel.Name = "nameLabel"
        Me.nameLabel.Size = New System.Drawing.Size(38, 13)
        Me.nameLabel.TabIndex = 7
        Me.nameLabel.Text = "Name:"
        '
        'selectPlayerGroupLabel
        '
        Me.selectPlayerGroupLabel.AutoSize = True
        Me.selectPlayerGroupLabel.Location = New System.Drawing.Point(12, 39)
        Me.selectPlayerGroupLabel.Name = "selectPlayerGroupLabel"
        Me.selectPlayerGroupLabel.Size = New System.Drawing.Size(126, 13)
        Me.selectPlayerGroupLabel.TabIndex = 8
        Me.selectPlayerGroupLabel.Text = "Select the player's group:"
        '
        'groupsList
        '
        Me.groupsList.FormattingEnabled = True
        Me.groupsList.Location = New System.Drawing.Point(13, 56)
        Me.groupsList.Name = "groupsList"
        Me.groupsList.Size = New System.Drawing.Size(189, 82)
        Me.groupsList.TabIndex = 1
        '
        'addThePlayerButton
        '
        Me.addThePlayerButton.Location = New System.Drawing.Point(120, 300)
        Me.addThePlayerButton.Name = "addThePlayerButton"
        Me.addThePlayerButton.Size = New System.Drawing.Size(83, 23)
        Me.addThePlayerButton.TabIndex = 6
        Me.addThePlayerButton.Text = "Add the player"
        Me.addThePlayerButton.UseVisualStyleBackColor = True
        '
        'ButtonemoveSelectedPermission
        '
        Me.ButtonemoveSelectedPermission.Location = New System.Drawing.Point(13, 271)
        Me.ButtonemoveSelectedPermission.Name = "ButtonemoveSelectedPermission"
        Me.ButtonemoveSelectedPermission.Size = New System.Drawing.Size(190, 23)
        Me.ButtonemoveSelectedPermission.TabIndex = 5
        Me.ButtonemoveSelectedPermission.Text = "Remove the selected permission"
        Me.ButtonemoveSelectedPermission.UseVisualStyleBackColor = True
        '
        'permissionsListBox
        '
        Me.permissionsListBox.FormattingEnabled = True
        Me.permissionsListBox.Location = New System.Drawing.Point(13, 183)
        Me.permissionsListBox.Name = "permissionsListBox"
        Me.permissionsListBox.Size = New System.Drawing.Size(190, 82)
        Me.permissionsListBox.Sorted = True
        Me.permissionsListBox.TabIndex = 4
        '
        'addPermissionButton
        '
        Me.addPermissionButton.Location = New System.Drawing.Point(180, 155)
        Me.addPermissionButton.Name = "addPermissionButton"
        Me.addPermissionButton.Size = New System.Drawing.Size(23, 23)
        Me.addPermissionButton.TabIndex = 3
        Me.addPermissionButton.Text = "+"
        Me.addPermissionButton.UseVisualStyleBackColor = True
        '
        'permissionTextBox
        '
        Me.permissionTextBox.Location = New System.Drawing.Point(13, 157)
        Me.permissionTextBox.Name = "permissionTextBox"
        Me.permissionTextBox.Size = New System.Drawing.Size(160, 20)
        Me.permissionTextBox.TabIndex = 2
        '
        'permissionsLabel
        '
        Me.permissionsLabel.AutoSize = True
        Me.permissionsLabel.Location = New System.Drawing.Point(13, 141)
        Me.permissionsLabel.Name = "permissionsLabel"
        Me.permissionsLabel.Size = New System.Drawing.Size(65, 13)
        Me.permissionsLabel.TabIndex = 9
        Me.permissionsLabel.Text = "Permissions:"
        '
        'addAPlayer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(214, 333)
        Me.Controls.Add(Me.ButtonemoveSelectedPermission)
        Me.Controls.Add(Me.permissionsListBox)
        Me.Controls.Add(Me.addPermissionButton)
        Me.Controls.Add(Me.permissionTextBox)
        Me.Controls.Add(Me.permissionsLabel)
        Me.Controls.Add(Me.addThePlayerButton)
        Me.Controls.Add(Me.groupsList)
        Me.Controls.Add(Me.selectPlayerGroupLabel)
        Me.Controls.Add(Me.nameTextBox)
        Me.Controls.Add(Me.nameLabel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "addAPlayer"
        Me.Text = "Add a player"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents nameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents nameLabel As System.Windows.Forms.Label
    Friend WithEvents selectPlayerGroupLabel As System.Windows.Forms.Label
    Friend WithEvents groupsList As System.Windows.Forms.ListBox
    Friend WithEvents addThePlayerButton As System.Windows.Forms.Button
    Friend WithEvents ButtonemoveSelectedPermission As Button
    Friend WithEvents permissionsListBox As ListBox
    Friend WithEvents addPermissionButton As Button
    Friend WithEvents permissionTextBox As TextBox
    Friend WithEvents permissionsLabel As Label
End Class
