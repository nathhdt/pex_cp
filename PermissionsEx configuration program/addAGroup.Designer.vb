<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class addAGroup
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(addAGroup))
        Me.nameLabel = New System.Windows.Forms.Label()
        Me.nameTextBox = New System.Windows.Forms.TextBox()
        Me.prefixLabel = New System.Windows.Forms.Label()
        Me.permissionsLabel = New System.Windows.Forms.Label()
        Me.permissionTextBox = New System.Windows.Forms.TextBox()
        Me.addPermissionButton = New System.Windows.Forms.Button()
        Me.permissionsListBox = New System.Windows.Forms.ListBox()
        Me.ButtonemoveSelectedPermission = New System.Windows.Forms.Button()
        Me.defaultGroupCheckBox = New System.Windows.Forms.CheckBox()
        Me.permissionToBuildCheckBox = New System.Windows.Forms.CheckBox()
        Me.createGroupButton = New System.Windows.Forms.Button()
        Me.editPrefixButton = New System.Windows.Forms.Button()
        Me.prefix = New System.Windows.Forms.Label()
        Me.inheritanceLabel = New System.Windows.Forms.Label()
        Me.inheritanceComboBox = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'nameLabel
        '
        Me.nameLabel.AutoSize = True
        Me.nameLabel.Location = New System.Drawing.Point(12, 16)
        Me.nameLabel.Name = "nameLabel"
        Me.nameLabel.Size = New System.Drawing.Size(38, 13)
        Me.nameLabel.TabIndex = 10
        Me.nameLabel.Text = "Name:"
        '
        'nameTextBox
        '
        Me.nameTextBox.Location = New System.Drawing.Point(56, 13)
        Me.nameTextBox.Name = "nameTextBox"
        Me.nameTextBox.Size = New System.Drawing.Size(146, 20)
        Me.nameTextBox.TabIndex = 0
        '
        'prefixLabel
        '
        Me.prefixLabel.AutoSize = True
        Me.prefixLabel.Location = New System.Drawing.Point(12, 42)
        Me.prefixLabel.Name = "prefixLabel"
        Me.prefixLabel.Size = New System.Drawing.Size(36, 13)
        Me.prefixLabel.TabIndex = 11
        Me.prefixLabel.Text = "Prefix:"
        '
        'permissionsLabel
        '
        Me.permissionsLabel.AutoSize = True
        Me.permissionsLabel.Location = New System.Drawing.Point(12, 103)
        Me.permissionsLabel.Name = "permissionsLabel"
        Me.permissionsLabel.Size = New System.Drawing.Size(65, 13)
        Me.permissionsLabel.TabIndex = 14
        Me.permissionsLabel.Text = "Permissions:"
        '
        'permissionTextBox
        '
        Me.permissionTextBox.Location = New System.Drawing.Point(12, 119)
        Me.permissionTextBox.Name = "permissionTextBox"
        Me.permissionTextBox.Size = New System.Drawing.Size(160, 20)
        Me.permissionTextBox.TabIndex = 3
        '
        'addPermissionButton
        '
        Me.addPermissionButton.Location = New System.Drawing.Point(179, 117)
        Me.addPermissionButton.Name = "addPermissionButton"
        Me.addPermissionButton.Size = New System.Drawing.Size(23, 23)
        Me.addPermissionButton.TabIndex = 4
        Me.addPermissionButton.Text = "+"
        Me.addPermissionButton.UseVisualStyleBackColor = True
        '
        'permissionsListBox
        '
        Me.permissionsListBox.FormattingEnabled = True
        Me.permissionsListBox.Location = New System.Drawing.Point(12, 145)
        Me.permissionsListBox.Name = "permissionsListBox"
        Me.permissionsListBox.Size = New System.Drawing.Size(190, 82)
        Me.permissionsListBox.Sorted = True
        Me.permissionsListBox.TabIndex = 5
        '
        'ButtonemoveSelectedPermission
        '
        Me.ButtonemoveSelectedPermission.Location = New System.Drawing.Point(12, 233)
        Me.ButtonemoveSelectedPermission.Name = "ButtonemoveSelectedPermission"
        Me.ButtonemoveSelectedPermission.Size = New System.Drawing.Size(190, 23)
        Me.ButtonemoveSelectedPermission.TabIndex = 6
        Me.ButtonemoveSelectedPermission.Text = "Remove the selected permission"
        Me.ButtonemoveSelectedPermission.UseVisualStyleBackColor = True
        '
        'defaultGroupCheckBox
        '
        Me.defaultGroupCheckBox.AutoSize = True
        Me.defaultGroupCheckBox.Location = New System.Drawing.Point(12, 262)
        Me.defaultGroupCheckBox.Name = "defaultGroupCheckBox"
        Me.defaultGroupCheckBox.Size = New System.Drawing.Size(140, 17)
        Me.defaultGroupCheckBox.TabIndex = 7
        Me.defaultGroupCheckBox.Text = "Set this group as default"
        Me.defaultGroupCheckBox.UseVisualStyleBackColor = True
        '
        'permissionToBuildCheckBox
        '
        Me.permissionToBuildCheckBox.AutoSize = True
        Me.permissionToBuildCheckBox.Location = New System.Drawing.Point(12, 285)
        Me.permissionToBuildCheckBox.Name = "permissionToBuildCheckBox"
        Me.permissionToBuildCheckBox.Size = New System.Drawing.Size(152, 17)
        Me.permissionToBuildCheckBox.TabIndex = 8
        Me.permissionToBuildCheckBox.Text = "Add the permission to build"
        Me.permissionToBuildCheckBox.UseVisualStyleBackColor = True
        '
        'createGroupButton
        '
        Me.createGroupButton.Location = New System.Drawing.Point(108, 308)
        Me.createGroupButton.Name = "createGroupButton"
        Me.createGroupButton.Size = New System.Drawing.Size(94, 23)
        Me.createGroupButton.TabIndex = 9
        Me.createGroupButton.Text = "Create the group"
        Me.createGroupButton.UseVisualStyleBackColor = True
        '
        'editPrefixButton
        '
        Me.editPrefixButton.Location = New System.Drawing.Point(178, 37)
        Me.editPrefixButton.Name = "editPrefixButton"
        Me.editPrefixButton.Size = New System.Drawing.Size(24, 23)
        Me.editPrefixButton.TabIndex = 1
        Me.editPrefixButton.Text = "..."
        Me.editPrefixButton.UseVisualStyleBackColor = True
        '
        'prefix
        '
        Me.prefix.AutoSize = True
        Me.prefix.Location = New System.Drawing.Point(54, 42)
        Me.prefix.Name = "prefix"
        Me.prefix.Size = New System.Drawing.Size(40, 13)
        Me.prefix.TabIndex = 12
        Me.prefix.Text = "no one"
        '
        'inheritanceLabel
        '
        Me.inheritanceLabel.AutoSize = True
        Me.inheritanceLabel.Location = New System.Drawing.Point(12, 63)
        Me.inheritanceLabel.Name = "inheritanceLabel"
        Me.inheritanceLabel.Size = New System.Drawing.Size(63, 13)
        Me.inheritanceLabel.TabIndex = 13
        Me.inheritanceLabel.Text = "Inheritance:"
        '
        'inheritanceComboBox
        '
        Me.inheritanceComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.inheritanceComboBox.FormattingEnabled = True
        Me.inheritanceComboBox.Location = New System.Drawing.Point(12, 79)
        Me.inheritanceComboBox.Name = "inheritanceComboBox"
        Me.inheritanceComboBox.Size = New System.Drawing.Size(190, 21)
        Me.inheritanceComboBox.TabIndex = 2
        '
        'addAGroup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(214, 342)
        Me.Controls.Add(Me.inheritanceComboBox)
        Me.Controls.Add(Me.inheritanceLabel)
        Me.Controls.Add(Me.prefix)
        Me.Controls.Add(Me.editPrefixButton)
        Me.Controls.Add(Me.createGroupButton)
        Me.Controls.Add(Me.permissionToBuildCheckBox)
        Me.Controls.Add(Me.defaultGroupCheckBox)
        Me.Controls.Add(Me.ButtonemoveSelectedPermission)
        Me.Controls.Add(Me.permissionsListBox)
        Me.Controls.Add(Me.addPermissionButton)
        Me.Controls.Add(Me.permissionTextBox)
        Me.Controls.Add(Me.permissionsLabel)
        Me.Controls.Add(Me.prefixLabel)
        Me.Controls.Add(Me.nameTextBox)
        Me.Controls.Add(Me.nameLabel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "addAGroup"
        Me.Text = "Add a group"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents nameLabel As System.Windows.Forms.Label
    Friend WithEvents nameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents prefixLabel As System.Windows.Forms.Label
    Friend WithEvents permissionsLabel As System.Windows.Forms.Label
    Friend WithEvents permissionTextBox As System.Windows.Forms.TextBox
    Friend WithEvents addPermissionButton As System.Windows.Forms.Button
    Friend WithEvents permissionsListBox As System.Windows.Forms.ListBox
    Friend WithEvents ButtonemoveSelectedPermission As System.Windows.Forms.Button
    Friend WithEvents defaultGroupCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents permissionToBuildCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents createGroupButton As System.Windows.Forms.Button
    Friend WithEvents editPrefixButton As System.Windows.Forms.Button
    Friend WithEvents prefix As System.Windows.Forms.Label
    Friend WithEvents inheritanceLabel As Label
    Friend WithEvents inheritanceComboBox As ComboBox
End Class
