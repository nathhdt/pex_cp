'TODO: Système d'ajout de permissions spécifiques au joueur

Public Class addAPlayer
    Private Sub addAPlayer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim index As Integer = 0
        Try
            While Main.groupsListBox.Items(index) <> Nothing
                groupsList.Items.Add(Main.groupsListBox.Items(index).ToString)
                index = index + 1
            End While
        Catch ex As Exception
            'Ne rien faire, erreur normale
        End Try
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

    Private Sub addThePlayerButton_Click(sender As Object, e As EventArgs) Handles addThePlayerButton.Click
        If nameTextBox.Text = "" Then
            MsgBox("Please do not leave blank the player name.", vbExclamation & vbOKOnly, "Add a player")
            Exit Sub
        End If

        If groupsList.SelectedIndex = -1 Then
            MsgBox("Please select the group of the player.", vbExclamation & vbOKOnly, "Add a player")
            Exit Sub
        End If

        Main.permissionsFile.Items.Add("  " & nameTextBox.Text & ":")
        Main.permissionsFile.Items.Add("    group:")
        Main.permissionsFile.Items.Add("    - " & groupsList.SelectedItem.ToString)

        If permissionsListBox.Items.Count > 0 Then
            Main.permissionsFile.Items.Add("    permissions:")
            Dim index As Integer = 0
            Try
                While permissionsListBox.Items(index) <> Nothing
                    Main.permissionsFile.Items.Add("    - " & permissionsListBox.Items(index).ToString)
                    index = index + 1
                End While
            Catch ex As Exception
                'Erreur normale, fin de la liste des permissions attendue
            End Try

            Main.permissionsFile.Items.Add("#Player end")

        End If

        Main.playersListBox.Items.Add(nameTextBox.Text)

        nameTextBox.Text = ""
        groupsList.Items.Clear()
        Me.Close()

    End Sub

    Private Sub addAPlayer_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        nameTextBox.Text = ""
        groupsList.Items.Clear()
        permissionTextBox.Text = ""
        permissionsListBox.Items.Clear()

    End Sub
End Class