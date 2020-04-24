<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class editThePrefix
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(editThePrefix))
        Me.textOfThePrefixLabel = New System.Windows.Forms.Label()
        Me.prefixTextBox = New System.Windows.Forms.TextBox()
        Me.styleOfThePrefixLabel = New System.Windows.Forms.Label()
        Me.bracketsRadioButton = New System.Windows.Forms.RadioButton()
        Me.hooksRadioButton = New System.Windows.Forms.RadioButton()
        Me.nothingRadioButton = New System.Windows.Forms.RadioButton()
        Me.colorOfThePrefixLabel = New System.Windows.Forms.Label()
        Me.colorsComboBox = New System.Windows.Forms.ComboBox()
        Me.finalPrefixLabel = New System.Windows.Forms.Label()
        Me.finishButton = New System.Windows.Forms.Button()
        Me.finalPrefix = New System.Windows.Forms.Label()
        Me.OwnPrefixRadioButton = New System.Windows.Forms.RadioButton()
        Me.OwnPrefix = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'textOfThePrefixLabel
        '
        Me.textOfThePrefixLabel.AutoSize = True
        Me.textOfThePrefixLabel.Location = New System.Drawing.Point(10, 13)
        Me.textOfThePrefixLabel.Name = "textOfThePrefixLabel"
        Me.textOfThePrefixLabel.Size = New System.Drawing.Size(107, 13)
        Me.textOfThePrefixLabel.TabIndex = 8
        Me.textOfThePrefixLabel.Text = "The text of the prefix:"
        '
        'prefixTextBox
        '
        Me.prefixTextBox.Location = New System.Drawing.Point(123, 10)
        Me.prefixTextBox.Name = "prefixTextBox"
        Me.prefixTextBox.Size = New System.Drawing.Size(119, 20)
        Me.prefixTextBox.TabIndex = 0
        '
        'styleOfThePrefixLabel
        '
        Me.styleOfThePrefixLabel.AutoSize = True
        Me.styleOfThePrefixLabel.Location = New System.Drawing.Point(10, 37)
        Me.styleOfThePrefixLabel.Name = "styleOfThePrefixLabel"
        Me.styleOfThePrefixLabel.Size = New System.Drawing.Size(111, 13)
        Me.styleOfThePrefixLabel.TabIndex = 9
        Me.styleOfThePrefixLabel.Text = "The style of the prefix:"
        '
        'bracketsRadioButton
        '
        Me.bracketsRadioButton.AutoSize = True
        Me.bracketsRadioButton.Location = New System.Drawing.Point(13, 53)
        Me.bracketsRadioButton.Name = "bracketsRadioButton"
        Me.bracketsRadioButton.Size = New System.Drawing.Size(34, 17)
        Me.bracketsRadioButton.TabIndex = 1
        Me.bracketsRadioButton.TabStop = True
        Me.bracketsRadioButton.Text = "( )"
        Me.bracketsRadioButton.UseVisualStyleBackColor = True
        '
        'hooksRadioButton
        '
        Me.hooksRadioButton.AutoSize = True
        Me.hooksRadioButton.Location = New System.Drawing.Point(13, 76)
        Me.hooksRadioButton.Name = "hooksRadioButton"
        Me.hooksRadioButton.Size = New System.Drawing.Size(34, 17)
        Me.hooksRadioButton.TabIndex = 2
        Me.hooksRadioButton.Text = "[ ]"
        Me.hooksRadioButton.UseVisualStyleBackColor = True
        '
        'nothingRadioButton
        '
        Me.nothingRadioButton.AutoSize = True
        Me.nothingRadioButton.Location = New System.Drawing.Point(13, 99)
        Me.nothingRadioButton.Name = "nothingRadioButton"
        Me.nothingRadioButton.Size = New System.Drawing.Size(14, 13)
        Me.nothingRadioButton.TabIndex = 3
        Me.nothingRadioButton.UseVisualStyleBackColor = True
        '
        'colorOfThePrefixLabel
        '
        Me.colorOfThePrefixLabel.AutoSize = True
        Me.colorOfThePrefixLabel.Location = New System.Drawing.Point(9, 164)
        Me.colorOfThePrefixLabel.Name = "colorOfThePrefixLabel"
        Me.colorOfThePrefixLabel.Size = New System.Drawing.Size(113, 13)
        Me.colorOfThePrefixLabel.TabIndex = 10
        Me.colorOfThePrefixLabel.Text = "The color of the prefix:"
        '
        'colorsComboBox
        '
        Me.colorsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.colorsComboBox.FormattingEnabled = True
        Me.colorsComboBox.Items.AddRange(New Object() {"Dark red", "Red", "Gold", "Yellow", "Dark green", "Green", "Aqua", "Dark aqua", "Blue", "Dark blue", "Light purple", "Dark purple", "White", "Gray", "Dark gray", "Black"})
        Me.colorsComboBox.Location = New System.Drawing.Point(12, 180)
        Me.colorsComboBox.Name = "colorsComboBox"
        Me.colorsComboBox.Size = New System.Drawing.Size(121, 21)
        Me.colorsComboBox.TabIndex = 6
        '
        'finalPrefixLabel
        '
        Me.finalPrefixLabel.AutoSize = True
        Me.finalPrefixLabel.Location = New System.Drawing.Point(10, 204)
        Me.finalPrefixLabel.Name = "finalPrefixLabel"
        Me.finalPrefixLabel.Size = New System.Drawing.Size(115, 13)
        Me.finalPrefixLabel.TabIndex = 11
        Me.finalPrefixLabel.Text = "Final view of the prefix:"
        '
        'finishButton
        '
        Me.finishButton.Location = New System.Drawing.Point(200, 219)
        Me.finishButton.Name = "finishButton"
        Me.finishButton.Size = New System.Drawing.Size(42, 23)
        Me.finishButton.TabIndex = 7
        Me.finishButton.Text = "Finish"
        Me.finishButton.UseVisualStyleBackColor = True
        '
        'finalPrefix
        '
        Me.finalPrefix.AutoSize = True
        Me.finalPrefix.Location = New System.Drawing.Point(125, 204)
        Me.finalPrefix.Name = "finalPrefix"
        Me.finalPrefix.Size = New System.Drawing.Size(0, 13)
        Me.finalPrefix.TabIndex = 12
        '
        'OwnPrefixRadioButton
        '
        Me.OwnPrefixRadioButton.AutoSize = True
        Me.OwnPrefixRadioButton.Location = New System.Drawing.Point(12, 118)
        Me.OwnPrefixRadioButton.Name = "OwnPrefixRadioButton"
        Me.OwnPrefixRadioButton.Size = New System.Drawing.Size(147, 17)
        Me.OwnPrefixRadioButton.TabIndex = 4
        Me.OwnPrefixRadioButton.TabStop = True
        Me.OwnPrefixRadioButton.Text = "Type your own prefix style"
        Me.OwnPrefixRadioButton.UseVisualStyleBackColor = True
        '
        'OwnPrefix
        '
        Me.OwnPrefix.Location = New System.Drawing.Point(29, 141)
        Me.OwnPrefix.Name = "OwnPrefix"
        Me.OwnPrefix.Size = New System.Drawing.Size(125, 20)
        Me.OwnPrefix.TabIndex = 5
        '
        'editThePrefix
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(254, 254)
        Me.Controls.Add(Me.OwnPrefix)
        Me.Controls.Add(Me.OwnPrefixRadioButton)
        Me.Controls.Add(Me.finalPrefix)
        Me.Controls.Add(Me.finishButton)
        Me.Controls.Add(Me.finalPrefixLabel)
        Me.Controls.Add(Me.colorsComboBox)
        Me.Controls.Add(Me.colorOfThePrefixLabel)
        Me.Controls.Add(Me.nothingRadioButton)
        Me.Controls.Add(Me.hooksRadioButton)
        Me.Controls.Add(Me.bracketsRadioButton)
        Me.Controls.Add(Me.styleOfThePrefixLabel)
        Me.Controls.Add(Me.prefixTextBox)
        Me.Controls.Add(Me.textOfThePrefixLabel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "editThePrefix"
        Me.Text = "Edit the prefix"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents textOfThePrefixLabel As System.Windows.Forms.Label
    Friend WithEvents prefixTextBox As System.Windows.Forms.TextBox
    Friend WithEvents styleOfThePrefixLabel As System.Windows.Forms.Label
    Friend WithEvents bracketsRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents hooksRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents nothingRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents colorOfThePrefixLabel As System.Windows.Forms.Label
    Friend WithEvents colorsComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents finalPrefixLabel As System.Windows.Forms.Label
    Friend WithEvents finishButton As System.Windows.Forms.Button
    Friend WithEvents finalPrefix As System.Windows.Forms.Label
    Friend WithEvents OwnPrefixRadioButton As RadioButton
    Friend WithEvents OwnPrefix As TextBox
End Class
