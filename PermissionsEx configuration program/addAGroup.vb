'TODO: Système de permissions pré-enregistrées

'CHANGELOG: Symbole * et ' ajoutés pour les permissions

Public Class addAGroup

    Private Sub addAGroup_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        nameTextBox.Text = ""
        prefix.Text = "no one"
        prefix.ForeColor = Color.Black
        permissionTextBox.Text = ""
        permissionsListBox.Items.Clear()
        defaultGroupCheckBox.Checked = False
        permissionToBuildCheckBox.Checked = False
    End Sub

    Private Sub addPermissionButton_Click(sender As Object, e As EventArgs) Handles addPermissionButton.Click
        If permissionTextBox.Text = "" Then
            MsgBox("Please do not leave blank a permission.", vbExclamation & vbOKOnly, "Add a group")
            Exit Sub
        End If
        permissionsListBox.Items.Add(permissionTextBox.Text)
        permissionTextBox.Text = ""
    End Sub

    Private Sub ButtonemoveSelectedPermission_Click(sender As Object, e As EventArgs) Handles ButtonemoveSelectedPermission.Click
        If permissionsListBox.SelectedItem = Nothing Then
            MsgBox("Please select a permission to remove it.", vbExclamation & vbOKOnly, "Add a group")
            Exit Sub
        End If
        permissionsListBox.Items.Remove(permissionsListBox.SelectedItem)
    End Sub

    Private Sub nameTextBox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles nameTextBox.KeyPress
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

    Private Sub permissionTextBox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles permissionTextBox.KeyPress
        Dim KeyAscii As Short = Asc(e.KeyChar)
        Select Case KeyAscii
            Case System.Windows.Forms.Keys.Back 'Autorise le backspace
            Case 13
                e.Handled = True
                If permissionTextBox.Text = "" Then
                    MsgBox("Please do not leave blank a permission.", vbExclamation & vbOKOnly, "Add a group")
                    Exit Sub
                End If
                permissionsListBox.Items.Add(permissionTextBox.Text)
                permissionTextBox.Text = ""
                KeyAscii = 0
            Case Is <= 32
            Case 39 'Apostrophe
            Case 42 'Etoile
            Case 46 'Point
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

    Private Sub editPrefixButton_Click(sender As Object, e As EventArgs) Handles editPrefixButton.Click
        editThePrefix.ShowDialog()
    End Sub

    Private Sub createGroupButton_Click(sender As Object, e As EventArgs) Handles createGroupButton.Click
        'Vérifications nom et préfix
        If nameTextBox.Text = "" Then
            MsgBox("Please give a name for this group.", vbExclamation & vbOKOnly, "Add a group")
            Exit Sub
        End If
        If prefix.Text = "no one" Then
            MsgBox("Please make a prefix for this group.", vbExclamation & vbOKOnly, "Add a group")
            Exit Sub
        End If

        Dim defaultGroup As String = "false"
        Dim buildPermission As String = "false"

        'Check si le groupe est défaut et a les droits de construire
        If defaultGroupCheckBox.Checked Then
            defaultGroup = "true"
        End If
        If permissionToBuildCheckBox.Checked Then
            buildPermission = "true"
        End If

        'Set le préfix et sa couleur
        Dim finalPrefix As String = "''"
        If prefix.ForeColor = Color.DarkRed Then
            finalPrefix = "'&4" & prefix.Text & " &r'"
        ElseIf prefix.ForeColor = Color.OrangeRed Then
            finalPrefix = "'&c" & prefix.Text & " &r'"
        ElseIf prefix.ForeColor = Color.Orange Then
            finalPrefix = "'&6" & prefix.Text & " &r'"
        ElseIf prefix.ForeColor = Color.Yellow Then
            finalPrefix = "'&e" & prefix.Text & " &r'"
        ElseIf prefix.ForeColor = Color.DarkGreen Then
            finalPrefix = "'&2" & prefix.Text & " &r'"
        ElseIf prefix.ForeColor = Color.LightGreen Then
            finalPrefix = "'&a" & prefix.Text & " &r'"
        ElseIf prefix.ForeColor = Color.Aqua Then
            finalPrefix = "'&b" & prefix.Text & " &r'"
        ElseIf prefix.ForeColor = Color.DarkCyan Then
            finalPrefix = "'&3" & prefix.Text & " &r'"
        ElseIf prefix.ForeColor = Color.Blue Then
            finalPrefix = "'&1" & prefix.Text & " &r'"
        ElseIf prefix.ForeColor = Color.DarkBlue Then
            finalPrefix = "'&9" & prefix.Text & " &r'"
        ElseIf prefix.ForeColor = Color.MediumPurple Then
            finalPrefix = "'&d" & prefix.Text & " &r'"
        ElseIf prefix.ForeColor = Color.Purple Then
            finalPrefix = "'&5" & prefix.Text & " &r'"
        ElseIf prefix.ForeColor = Color.White Then
            finalPrefix = "'&f" & prefix.Text & " &r'"
        ElseIf prefix.ForeColor = Color.DarkGray Then
            finalPrefix = "'&7" & prefix.Text & " &r'"
        ElseIf prefix.ForeColor = Color.Gray Then
            finalPrefix = "'&8" & prefix.Text & " &r'"
        ElseIf prefix.ForeColor = Color.Black Then
            finalPrefix = "'&0" & prefix.Text & " &r'"
        Else
            finalPrefix = "'" & prefix.Text & "'"
        End If

        finalPrefix = finalPrefix.Replace("&&", "&")

        'Ajoute la base du groupe (nom, préfix, défaut, droit de construction et base les permissions)
        Main.permissionsFile.Items.Add("  " & nameTextBox.Text & ":")
        Main.permissionsFile.Items.Add("    " & "prefix: " & finalPrefix)
        Main.permissionsFile.Items.Add("    " & "default: " & defaultGroup)
        Main.permissionsFile.Items.Add("    " & "build: " & buildPermission)
        If inheritanceComboBox.Text <> "" Then
            Main.permissionsFile.Items.Add("    " & "inheritance: ")
            Main.permissionsFile.Items.Add("     - " & inheritanceComboBox.SelectedItem)
        End If
        Main.permissionsFile.Items.Add("    " & "permissions:")

        'Ajoute les permissions
        Dim index As Integer = 0
        Try
            While permissionsListBox.Items(index) <> Nothing
                Main.permissionsFile.Items.Add("    - " & permissionsListBox.Items(index).ToString)
                index = index + 1
            End While
        Catch ex As Exception
            'Erreur normale, fin de la liste des permissions attendue
        End Try

        'Ajoute le cas de fin

        Main.permissionsFile.Items.Add("#Group end")

        'Ajoute le groupe dans la liste
        Main.groupsListBox.Items.Add(nameTextBox.Text)

        'Clear et ferme la form
        nameTextBox.Text = ""
        prefix.Text = "no one"
        prefix.ForeColor = Color.Black
        inheritanceComboBox.Items.Clear()
        permissionTextBox.Text = ""
        permissionsListBox.Items.Clear()
        defaultGroupCheckBox.Checked = False
        permissionToBuildCheckBox.Checked = False
        Me.Close()

    End Sub

    Public Function defaultPermissionCheck()
        Dim index As Integer = 0

        Try
            While Main.permissionsFile.Items(index) <> Nothing
                index = index + 1
            End While
        Catch ex As Exception
            'Ne rien faire, erreur normale
        End Try

        For i = 0 To index
            Try
                If Main.permissionsFile.Items(i) = "    default: true" Then
                    defaultGroupCheckBox.Enabled = False
                    Return Nothing
                    Exit Function
                ElseIf Main.permissionsFile.Items(i) <> "    default: true" Then
                    defaultGroupCheckBox.Enabled = True
                End If
            Catch ex As Exception
                'Ne rien faire, erreur normale
            End Try
        Next
        Return Nothing
    End Function

    Private Sub addAGroup_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim index As Integer = 0

        inheritanceComboBox.Items.Add("")

        Try
            While Main.groupsListBox.Items(index) <> Nothing
                inheritanceComboBox.Items.Add(Main.groupsListBox.Items(index).ToString)
                index = index + 1
            End While
        Catch ex As Exception
            'Ne rien faire, erreur normale
        End Try

        defaultPermissionCheck()

    End Sub
End Class