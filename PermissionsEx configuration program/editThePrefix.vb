Public Class editThePrefix

    Private Sub editThePrefix_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        prefixTextBox.Text = ""
        bracketsRadioButton.Checked = False
        hooksRadioButton.Checked = False
        nothingRadioButton.Checked = False
        colorsComboBox.SelectedItem = Nothing
        finalPrefix.Text = ""
        finalPrefix.ForeColor = Color.Black
    End Sub

    Private Sub prefixTextBox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles prefixTextBox.KeyPress
        Dim KeyAscii As Short = Asc(e.KeyChar)
        Select Case KeyAscii
            Case System.Windows.Forms.Keys.Back 'Autorise le backspace
            Case 13
            Case Is <= 32
            Case 48 To 57 'Nombres
                Exit Sub
            Case 65 To 90 'Alphabet majuscule
                Exit Sub
            Case 97 To 122 'Alphabet minuscule
                Exit Sub
            Case Else
                e.Handled = True
        End Select
    End Sub

    Private Sub OwnPrefix_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles OwnPrefix.KeyPress
        Dim KeyAscii As Short = Asc(e.KeyChar)
        Select Case KeyAscii
            Case System.Windows.Forms.Keys.Back 'Autorise le backspace
            Case 13
            Case Is <= 32
            Case 48 To 57 'Nombres
                Exit Sub
            Case 65 To 90 'Alphabet majuscule
                Exit Sub
            Case 97 To 122 'Alphabet minuscule
                Exit Sub
            Case 35 To 64 'Caractères spéciaux utilisables
                Exit Sub
            Case 91 To 93 'Caractères spéciaux utilisables
                Exit Sub
            Case 123 To 125 'Caractères spéciaux utilisables
                Exit Sub
            Case Else
                e.Handled = True
        End Select
    End Sub


    Private Sub prefixTextBox_TextChanged(sender As Object, e As EventArgs) Handles prefixTextBox.TextChanged
        bracketsRadioButton.Text = "(" & prefixTextBox.Text & ")"
        hooksRadioButton.Text = "[" & prefixTextBox.Text & "]"
        nothingRadioButton.Text = prefixTextBox.Text
        reloadPrefixView()
    End Sub

    Private Sub bracketsRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles bracketsRadioButton.CheckedChanged
        finalPrefix.Text = ""
        colorsComboBox.Enabled = True
        reloadPrefixView()
        OwnPrefix.Enabled = False
    End Sub

    Private Sub hooksRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles hooksRadioButton.CheckedChanged
        finalPrefix.Text = ""
        colorsComboBox.Enabled = True
        reloadPrefixView()
        OwnPrefix.Enabled = False
    End Sub

    Private Sub nothingRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles nothingRadioButton.CheckedChanged
        finalPrefix.Text = ""
        colorsComboBox.Enabled = True
        reloadPrefixView()
        OwnPrefix.Enabled = False
    End Sub

    Private Sub colorsComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles colorsComboBox.SelectedIndexChanged
        reloadPrefixView()
    End Sub

    Public Function reloadPrefixView()
        If bracketsRadioButton.Checked Then
            If colorsComboBox.Text = "Dark red" Then
                finalPrefix.Text = "(" & prefixTextBox.Text & ")"
                finalPrefix.ForeColor = Color.DarkRed
            End If
            If colorsComboBox.Text = "Red" Then
                finalPrefix.Text = "(" & prefixTextBox.Text & ")"
                finalPrefix.ForeColor = Color.OrangeRed
            End If
            If colorsComboBox.Text = "Gold" Then
                finalPrefix.Text = "(" & prefixTextBox.Text & ")"
                finalPrefix.ForeColor = Color.Orange
            End If
            If colorsComboBox.Text = "Yellow" Then
                finalPrefix.Text = "(" & prefixTextBox.Text & ")"
                finalPrefix.ForeColor = Color.Yellow
            End If
            If colorsComboBox.Text = "Dark green" Then
                finalPrefix.Text = "(" & prefixTextBox.Text & ")"
                finalPrefix.ForeColor = Color.DarkGreen
            End If
            If colorsComboBox.Text = "Green" Then
                finalPrefix.Text = "(" & prefixTextBox.Text & ")"
                finalPrefix.ForeColor = Color.LightGreen
            End If
            If colorsComboBox.Text = "Aqua" Then
                finalPrefix.Text = "(" & prefixTextBox.Text & ")"
                finalPrefix.ForeColor = Color.Aqua
            End If
            If colorsComboBox.Text = "Dark aqua" Then
                finalPrefix.Text = "(" & prefixTextBox.Text & ")"
                finalPrefix.ForeColor = Color.DarkCyan
            End If
            If colorsComboBox.Text = "Blue" Then
                finalPrefix.Text = "(" & prefixTextBox.Text & ")"
                finalPrefix.ForeColor = Color.Blue
            End If
            If colorsComboBox.Text = "Dark blue" Then
                finalPrefix.Text = "(" & prefixTextBox.Text & ")"
                finalPrefix.ForeColor = Color.DarkBlue
            End If
            If colorsComboBox.Text = "Light purple" Then
                finalPrefix.Text = "(" & prefixTextBox.Text & ")"
                finalPrefix.ForeColor = Color.MediumPurple
            End If
            If colorsComboBox.Text = "Dark purple" Then
                finalPrefix.Text = "(" & prefixTextBox.Text & ")"
                finalPrefix.ForeColor = Color.Purple
            End If
            If colorsComboBox.Text = "White" Then
                finalPrefix.Text = "(" & prefixTextBox.Text & ")"
                finalPrefix.ForeColor = Color.White
            End If
            If colorsComboBox.Text = "Gray" Then
                finalPrefix.Text = "(" & prefixTextBox.Text & ")"
                finalPrefix.ForeColor = Color.DarkGray
            End If
            If colorsComboBox.Text = "Dark gray" Then
                finalPrefix.Text = "(" & prefixTextBox.Text & ")"
                finalPrefix.ForeColor = Color.Gray
            End If
            If colorsComboBox.Text = "Black" Then
                finalPrefix.Text = "(" & prefixTextBox.Text & ")"
                finalPrefix.ForeColor = Color.Black
            End If
        ElseIf hooksRadioButton.Checked Then
            If colorsComboBox.Text = "Dark red" Then
                finalPrefix.Text = "[" & prefixTextBox.Text & "]"
                finalPrefix.ForeColor = Color.DarkRed
            End If
            If colorsComboBox.Text = "Red" Then
                finalPrefix.Text = "[" & prefixTextBox.Text & "]"
                finalPrefix.ForeColor = Color.OrangeRed
            End If
            If colorsComboBox.Text = "Gold" Then
                finalPrefix.Text = "[" & prefixTextBox.Text & "]"
                finalPrefix.ForeColor = Color.Orange
            End If
            If colorsComboBox.Text = "Yellow" Then
                finalPrefix.Text = "[" & prefixTextBox.Text & "]"
                finalPrefix.ForeColor = Color.Yellow
            End If
            If colorsComboBox.Text = "Dark green" Then
                finalPrefix.Text = "[" & prefixTextBox.Text & "]"
                finalPrefix.ForeColor = Color.DarkGreen
            End If
            If colorsComboBox.Text = "Green" Then
                finalPrefix.Text = "[" & prefixTextBox.Text & "]"
                finalPrefix.ForeColor = Color.LightGreen
            End If
            If colorsComboBox.Text = "Aqua" Then
                finalPrefix.Text = "[" & prefixTextBox.Text & "]"
                finalPrefix.ForeColor = Color.Aqua
            End If
            If colorsComboBox.Text = "Dark aqua" Then
                finalPrefix.Text = "[" & prefixTextBox.Text & "]"
                finalPrefix.ForeColor = Color.DarkCyan
            End If
            If colorsComboBox.Text = "Blue" Then
                finalPrefix.Text = "[" & prefixTextBox.Text & "]"
                finalPrefix.ForeColor = Color.Blue
            End If
            If colorsComboBox.Text = "Dark blue" Then
                finalPrefix.Text = "[" & prefixTextBox.Text & "]"
                finalPrefix.ForeColor = Color.DarkBlue
            End If
            If colorsComboBox.Text = "Light purple" Then
                finalPrefix.Text = "[" & prefixTextBox.Text & "]"
                finalPrefix.ForeColor = Color.MediumPurple
            End If
            If colorsComboBox.Text = "Dark purple" Then
                finalPrefix.Text = "[" & prefixTextBox.Text & "]"
                finalPrefix.ForeColor = Color.Purple
            End If
            If colorsComboBox.Text = "White" Then
                finalPrefix.Text = "[" & prefixTextBox.Text & "]"
                finalPrefix.ForeColor = Color.White
            End If
            If colorsComboBox.Text = "Gray" Then
                finalPrefix.Text = "[" & prefixTextBox.Text & "]"
                finalPrefix.ForeColor = Color.DarkGray
            End If
            If colorsComboBox.Text = "Dark gray" Then
                finalPrefix.Text = "[" & prefixTextBox.Text & "]"
                finalPrefix.ForeColor = Color.Gray
            End If
            If colorsComboBox.Text = "Black" Then
                finalPrefix.Text = "[" & prefixTextBox.Text & "]"
                finalPrefix.ForeColor = Color.Black
            End If
        ElseIf nothingRadioButton.Checked Then
            If colorsComboBox.Text = "Dark red" Then
                finalPrefix.Text = prefixTextBox.Text
                finalPrefix.ForeColor = Color.DarkRed
            End If
            If colorsComboBox.Text = "Red" Then
                finalPrefix.Text = prefixTextBox.Text
                finalPrefix.ForeColor = Color.OrangeRed
            End If
            If colorsComboBox.Text = "Gold" Then
                finalPrefix.Text = prefixTextBox.Text
                finalPrefix.ForeColor = Color.Orange
            End If
            If colorsComboBox.Text = "Yellow" Then
                finalPrefix.Text = prefixTextBox.Text
                finalPrefix.ForeColor = Color.Yellow
            End If
            If colorsComboBox.Text = "Dark green" Then
                finalPrefix.Text = prefixTextBox.Text
                finalPrefix.ForeColor = Color.DarkGreen
            End If
            If colorsComboBox.Text = "Green" Then
                finalPrefix.Text = prefixTextBox.Text
                finalPrefix.ForeColor = Color.LightGreen
            End If
            If colorsComboBox.Text = "Aqua" Then
                finalPrefix.Text = prefixTextBox.Text
                finalPrefix.ForeColor = Color.Aqua
            End If
            If colorsComboBox.Text = "Dark aqua" Then
                finalPrefix.Text = prefixTextBox.Text
                finalPrefix.ForeColor = Color.DarkCyan
            End If
            If colorsComboBox.Text = "Blue" Then
                finalPrefix.Text = prefixTextBox.Text
                finalPrefix.ForeColor = Color.Blue
            End If
            If colorsComboBox.Text = "Dark blue" Then
                finalPrefix.Text = prefixTextBox.Text
                finalPrefix.ForeColor = Color.DarkBlue
            End If
            If colorsComboBox.Text = "Light purple" Then
                finalPrefix.Text = prefixTextBox.Text
                finalPrefix.ForeColor = Color.MediumPurple
            End If
            If colorsComboBox.Text = "Dark purple" Then
                finalPrefix.Text = prefixTextBox.Text
                finalPrefix.ForeColor = Color.Purple
            End If
            If colorsComboBox.Text = "White" Then
                finalPrefix.Text = prefixTextBox.Text
                finalPrefix.ForeColor = Color.White
            End If
            If colorsComboBox.Text = "Gray" Then
                finalPrefix.Text = prefixTextBox.Text
                finalPrefix.ForeColor = Color.DarkGray
            End If
            If colorsComboBox.Text = "Dark gray" Then
                finalPrefix.Text = prefixTextBox.Text
                finalPrefix.ForeColor = Color.Gray
            End If
            If colorsComboBox.Text = "Black" Then
                finalPrefix.Text = prefixTextBox.Text
                finalPrefix.ForeColor = Color.Black
            End If
        End If

        Return Nothing
    End Function

    Private Sub finishButton_Click(sender As Object, e As EventArgs) Handles finishButton.Click
        If prefixTextBox.Text = "" Then
            MsgBox("Please do not leave blank the prefix.", vbExclamation & vbOKOnly, "Edit the prefix")
            Exit Sub
        End If

        If bracketsRadioButton.Checked = False And hooksRadioButton.Checked = False And nothingRadioButton.Checked = False And OwnPrefixRadioButton.Checked = False And colorsComboBox.SelectedIndex = -1 Then
            MsgBox("Please choose the style and the color of the prefix.", vbExclamation & vbOKOnly, "Edit the prefix")
            Exit Sub
        End If

        If bracketsRadioButton.Checked = False And hooksRadioButton.Checked = False And nothingRadioButton.Checked = False And OwnPrefixRadioButton.Checked = False Then
            MsgBox("Please choose the style of the prefix.", vbExclamation & vbOKOnly, "Edit the prefix")
            Exit Sub
        End If

        If OwnPrefixRadioButton.Checked = True Then
            OwnPrefix.Text = OwnPrefix.Text.Replace("&", "&&")
            addAGroup.prefix.Text = OwnPrefix.Text
            prefixTextBox.Text = ""
            bracketsRadioButton.Checked = False
            hooksRadioButton.Checked = False
            nothingRadioButton.Checked = False
            colorsComboBox.SelectedIndex = -1
            OwnPrefix.Text = ""
            OwnPrefixRadioButton.Checked = False

            finalPrefix.Text = ""

            Me.Hide()
            Exit Sub
        End If

        If colorsComboBox.SelectedIndex = -1 Then
            MsgBox("Please choose the color of the prefix.", vbExclamation & vbOKOnly, "Edit the prefix")
            Exit Sub
        End If

        If bracketsRadioButton.Checked Then
            If colorsComboBox.Text = "Dark red" Then
                addAGroup.prefix.Text = "(" & prefixTextBox.Text & ")"
                addAGroup.prefix.ForeColor = Color.DarkRed
            End If
            If colorsComboBox.Text = "Red" Then
                addAGroup.prefix.Text = "(" & prefixTextBox.Text & ")"
                addAGroup.prefix.ForeColor = Color.OrangeRed
            End If
            If colorsComboBox.Text = "Gold" Then
                addAGroup.prefix.Text = "(" & prefixTextBox.Text & ")"
                addAGroup.prefix.ForeColor = Color.Orange
            End If
            If colorsComboBox.Text = "Yellow" Then
                addAGroup.prefix.Text = "(" & prefixTextBox.Text & ")"
                addAGroup.prefix.ForeColor = Color.Yellow
            End If
            If colorsComboBox.Text = "Dark green" Then
                addAGroup.prefix.Text = "(" & prefixTextBox.Text & ")"
                addAGroup.prefix.ForeColor = Color.DarkGreen
            End If
            If colorsComboBox.Text = "Green" Then
                addAGroup.prefix.Text = "(" & prefixTextBox.Text & ")"
                addAGroup.prefix.ForeColor = Color.LightGreen
            End If
            If colorsComboBox.Text = "Aqua" Then
                addAGroup.prefix.Text = "(" & prefixTextBox.Text & ")"
                addAGroup.prefix.ForeColor = Color.Aqua
            End If
            If colorsComboBox.Text = "Dark aqua" Then
                addAGroup.prefix.Text = "(" & prefixTextBox.Text & ")"
                addAGroup.prefix.ForeColor = Color.DarkCyan
            End If
            If colorsComboBox.Text = "Blue" Then
                addAGroup.prefix.Text = "(" & prefixTextBox.Text & ")"
                addAGroup.prefix.ForeColor = Color.Blue
            End If
            If colorsComboBox.Text = "Dark blue" Then
                addAGroup.prefix.Text = "(" & prefixTextBox.Text & ")"
                addAGroup.prefix.ForeColor = Color.DarkBlue
            End If
            If colorsComboBox.Text = "Light purple" Then
                addAGroup.prefix.Text = "(" & prefixTextBox.Text & ")"
                addAGroup.prefix.ForeColor = Color.MediumPurple
            End If
            If colorsComboBox.Text = "Dark purple" Then
                addAGroup.prefix.Text = "(" & prefixTextBox.Text & ")"
                addAGroup.prefix.ForeColor = Color.Purple
            End If
            If colorsComboBox.Text = "White" Then
                addAGroup.prefix.Text = "(" & prefixTextBox.Text & ")"
                addAGroup.prefix.ForeColor = Color.White
            End If
            If colorsComboBox.Text = "Gray" Then
                addAGroup.prefix.Text = "(" & prefixTextBox.Text & ")"
                addAGroup.prefix.ForeColor = Color.DarkGray
            End If
            If colorsComboBox.Text = "Dark gray" Then
                addAGroup.prefix.Text = "(" & prefixTextBox.Text & ")"
                addAGroup.prefix.ForeColor = Color.Gray
            End If
            If colorsComboBox.Text = "Black" Then
                addAGroup.prefix.Text = "(" & prefixTextBox.Text & ")"
                addAGroup.prefix.ForeColor = Color.Black
            End If
        ElseIf hooksRadioButton.Checked Then
            If colorsComboBox.Text = "Dark red" Then
                addAGroup.prefix.Text = "[" & prefixTextBox.Text & "]"
                addAGroup.prefix.ForeColor = Color.DarkRed
            End If
            If colorsComboBox.Text = "Red" Then
                addAGroup.prefix.Text = "[" & prefixTextBox.Text & "]"
                addAGroup.prefix.ForeColor = Color.OrangeRed
            End If
            If colorsComboBox.Text = "Gold" Then
                addAGroup.prefix.Text = "[" & prefixTextBox.Text & "]"
                addAGroup.prefix.ForeColor = Color.Orange
            End If
            If colorsComboBox.Text = "Yellow" Then
                addAGroup.prefix.Text = "[" & prefixTextBox.Text & "]"
                addAGroup.prefix.ForeColor = Color.Yellow
            End If
            If colorsComboBox.Text = "Dark green" Then
                addAGroup.prefix.Text = "[" & prefixTextBox.Text & "]"
                addAGroup.prefix.ForeColor = Color.DarkGreen
            End If
            If colorsComboBox.Text = "Green" Then
                addAGroup.prefix.Text = "[" & prefixTextBox.Text & "]"
                addAGroup.prefix.ForeColor = Color.LightGreen
            End If
            If colorsComboBox.Text = "Aqua" Then
                addAGroup.prefix.Text = "[" & prefixTextBox.Text & "]"
                addAGroup.prefix.ForeColor = Color.Aqua
            End If
            If colorsComboBox.Text = "Dark aqua" Then
                addAGroup.prefix.Text = "[" & prefixTextBox.Text & "]"
                addAGroup.prefix.ForeColor = Color.DarkCyan
            End If
            If colorsComboBox.Text = "Blue" Then
                addAGroup.prefix.Text = "[" & prefixTextBox.Text & "]"
                addAGroup.prefix.ForeColor = Color.Blue
            End If
            If colorsComboBox.Text = "Dark blue" Then
                addAGroup.prefix.Text = "[" & prefixTextBox.Text & "]"
                addAGroup.prefix.ForeColor = Color.DarkBlue
            End If
            If colorsComboBox.Text = "Light purple" Then
                addAGroup.prefix.Text = "[" & prefixTextBox.Text & "]"
                addAGroup.prefix.ForeColor = Color.MediumPurple
            End If
            If colorsComboBox.Text = "Dark purple" Then
                addAGroup.prefix.Text = "[" & prefixTextBox.Text & "]"
                addAGroup.prefix.ForeColor = Color.Purple
            End If
            If colorsComboBox.Text = "White" Then
                addAGroup.prefix.Text = "[" & prefixTextBox.Text & "]"
                addAGroup.prefix.ForeColor = Color.White
            End If
            If colorsComboBox.Text = "Gray" Then
                addAGroup.prefix.Text = "[" & prefixTextBox.Text & "]"
                addAGroup.prefix.ForeColor = Color.DarkGray
            End If
            If colorsComboBox.Text = "Dark gray" Then
                addAGroup.prefix.Text = "[" & prefixTextBox.Text & "]"
                addAGroup.prefix.ForeColor = Color.Gray
            End If
            If colorsComboBox.Text = "Black" Then
                addAGroup.prefix.Text = "[" & prefixTextBox.Text & "]"
                addAGroup.prefix.ForeColor = Color.Black
            End If
        ElseIf nothingRadioButton.Checked Then
            If colorsComboBox.Text = "Dark red" Then
                addAGroup.prefix.Text = prefixTextBox.Text
                addAGroup.prefix.ForeColor = Color.DarkRed
            End If
            If colorsComboBox.Text = "Red" Then
                addAGroup.prefix.Text = prefixTextBox.Text
                addAGroup.prefix.ForeColor = Color.OrangeRed
            End If
            If colorsComboBox.Text = "Gold" Then
                addAGroup.prefix.Text = prefixTextBox.Text
                addAGroup.prefix.ForeColor = Color.Orange
            End If
            If colorsComboBox.Text = "Yellow" Then
                addAGroup.prefix.Text = prefixTextBox.Text
                addAGroup.prefix.ForeColor = Color.Yellow
            End If
            If colorsComboBox.Text = "Dark green" Then
                addAGroup.prefix.Text = prefixTextBox.Text
                addAGroup.prefix.ForeColor = Color.DarkGreen
            End If
            If colorsComboBox.Text = "Green" Then
                addAGroup.prefix.Text = prefixTextBox.Text
                addAGroup.prefix.ForeColor = Color.LightGreen
            End If
            If colorsComboBox.Text = "Aqua" Then
                addAGroup.prefix.Text = prefixTextBox.Text
                addAGroup.prefix.ForeColor = Color.Aqua
            End If
            If colorsComboBox.Text = "Dark aqua" Then
                addAGroup.prefix.Text = prefixTextBox.Text
                addAGroup.prefix.ForeColor = Color.DarkCyan
            End If
            If colorsComboBox.Text = "Blue" Then
                addAGroup.prefix.Text = prefixTextBox.Text
                addAGroup.prefix.ForeColor = Color.Blue
            End If
            If colorsComboBox.Text = "Dark blue" Then
                addAGroup.prefix.Text = prefixTextBox.Text
                addAGroup.prefix.ForeColor = Color.DarkBlue
            End If
            If colorsComboBox.Text = "Light purple" Then
                addAGroup.prefix.Text = prefixTextBox.Text
                addAGroup.prefix.ForeColor = Color.MediumPurple
            End If
            If colorsComboBox.Text = "Dark purple" Then
                addAGroup.prefix.Text = prefixTextBox.Text
                addAGroup.prefix.ForeColor = Color.Purple
            End If
            If colorsComboBox.Text = "White" Then
                addAGroup.prefix.Text = prefixTextBox.Text
                addAGroup.prefix.ForeColor = Color.White
            End If
            If colorsComboBox.Text = "Gray" Then
                addAGroup.prefix.Text = prefixTextBox.Text
                addAGroup.prefix.ForeColor = Color.DarkGray
            End If
            If colorsComboBox.Text = "Dark gray" Then
                addAGroup.prefix.Text = prefixTextBox.Text
                addAGroup.prefix.ForeColor = Color.Gray
            End If
            If colorsComboBox.Text = "Black" Then
                addAGroup.prefix.Text = prefixTextBox.Text
                addAGroup.prefix.ForeColor = Color.Black
            End If
        End If

        prefixTextBox.Text = ""
        bracketsRadioButton.Checked = False
        hooksRadioButton.Checked = False
        nothingRadioButton.Checked = False
        colorsComboBox.SelectedIndex = -1

        finalPrefix.Text = ""

        Me.Hide()

    End Sub

    Private Sub editThePrefix_Load(sender As Object, e As EventArgs) Handles Me.Load
        prefixTextBox.Text = addAGroup.nameTextBox.Text
        OwnPrefix.Enabled = False
    End Sub

    Private Sub OwnPrefixRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles OwnPrefixRadioButton.CheckedChanged
        OwnPrefix.Enabled = True
        finalPrefix.ForeColor = Color.Black
        finalPrefix.Text = "(only with setup prefixes)"
        colorsComboBox.Enabled = False
    End Sub
End Class