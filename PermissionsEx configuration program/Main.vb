Imports System.IO

Public Class Main

    Private Sub addGroupButton_Click(sender As Object, e As EventArgs) Handles addGroupButton.Click
        addAGroup.ShowDialog()
        addAGroup.defaultPermissionCheck()
    End Sub

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        addPlayerButton.Enabled = False
        removePlayerButton.Enabled = False
        playersListBox.Enabled = False
        finishThePlayersButton.Enabled = False
        createButton.Enabled = False
        'Version
        VersionLabel.Text = "Version: " & Me.GetType.Assembly.GetName.Version.ToString
    End Sub

    Private Sub removeGroupButton_Click(sender As Object, e As EventArgs) Handles removeGroupButton.Click
        Dim selectedGroup As String
        If groupsListBox.SelectedItem = Nothing Then
            MsgBox("Please select a group to remove it.", vbExclamation & vbOKOnly, "Remove a group")
            Exit Sub
        End If
        selectedGroup = groupsListBox.SelectedItem.ToString

        Dim index As Integer = 0

        Try
            While permissionsFile.Items(index) <> "  " & selectedGroup & ":"
                index = index + 1
            End While
        Catch ex As Exception
            'Ne rien faire, erreur normale
        End Try

        Try
            While permissionsFile.Items(index) <> "#Group end"
                permissionsFile.Items.RemoveAt(index)
            End While
        Catch ex As Exception
            'Ne rien faire, erreur normale
        End Try

        permissionsFile.Items.RemoveAt(index)

        groupsListBox.Items.Remove(groupsListBox.SelectedItem)

        addAGroup.defaultPermissionCheck()

    End Sub

    Private Sub finishTheGroupsButton_Click(sender As Object, e As EventArgs) Handles finishTheGroupsButton.Click
        'Exit sub si pas de groupe
        If groupsListBox.Items.Count = 0 Then
            MsgBox("Please create at least one group to fill in the players part.", vbExclamation & vbOKOnly, "Finish the groups")
            Exit Sub
        End If
        'Désactive la partie groupe
        addGroupButton.Enabled = False
        removeGroupButton.Enabled = False
        groupsListBox.Enabled = False
        finishTheGroupsButton.Enabled = False
        'Active la partie joueurs
        addPlayerButton.Enabled = True
        removePlayerButton.Enabled = True
        playersListBox.Enabled = True
        finishThePlayersButton.Enabled = True

        permissionsFile.Items.Add("users:")
    End Sub

    Private Sub addPlayerButton_Click(sender As Object, e As EventArgs) Handles addPlayerButton.Click
        addAPlayer.ShowDialog()
    End Sub

    Private Sub removePlayerButton_Click(sender As Object, e As EventArgs) Handles removePlayerButton.Click
        Dim selectedPlayer As String
        If playersListBox.SelectedItem = Nothing Then
            MsgBox("Please select a player to remove it.", vbExclamation & vbOKOnly, "Remove a player")
            Exit Sub
        End If
        selectedPlayer = playersListBox.SelectedItem.ToString

        Dim index As Integer = 0

        Try
            While permissionsFile.Items(index) <> "  " & selectedPlayer & ":"
                index = index + 1
            End While
        Catch ex As Exception
            'Ne rien faire, erreur normale
        End Try

        Try
            While permissionsFile.Items(index) <> "#Player end"
                permissionsFile.Items.RemoveAt(index)
            End While
        Catch ex As Exception
            'Ne rien faire, erreur normale
        End Try

        playersListBox.Items.Remove(playersListBox.SelectedItem)
    End Sub

    Private Sub finishThePlayersButton_Click(sender As Object, e As EventArgs) Handles finishThePlayersButton.Click
        addPlayerButton.Enabled = False
        removePlayerButton.Enabled = False
        playersListBox.Enabled = False
        finishThePlayersButton.Enabled = False
        createButton.Enabled = True
    End Sub

    Private Sub createButton_Click(sender As Object, e As EventArgs) Handles createButton.Click
        Dim link As String
        Dim fileDialog As SaveFileDialog = New SaveFileDialog
        fileDialog.Filter = "YML permissions file|permissions.yml"
        fileDialog.FileName = "permissions"
        fileDialog.Title = "Create your permissions.yml file"
        fileDialog.FilterIndex = 1
        fileDialog.CheckFileExists = False

        Dim UserClickedOK As Boolean = fileDialog.ShowDialog

        If (UserClickedOK = True) Then

            addAPlayer.permissionsListBox.Items.Clear()
            addAGroup.inheritanceComboBox.Items.Clear()

            addAGroup.defaultGroupCheckBox.Enabled = True

            link = fileDialog.FileName
            Dim createdPermissionsFile As StreamWriter = New StreamWriter(link)
            Dim index As Integer = 0

            Try
                While permissionsFile.Items(index) <> Nothing
                    If permissionsFile.Items(index) = "#Group end" Then
                        permissionsFile.Items.RemoveAt(index)
                    End If
                    If permissionsFile.Items(index) = "#Player end" Then
                        permissionsFile.Items.RemoveAt(index)
                    End If
                    If permissionsFile.Items(index) = "users:" And playersListBox.Items.Count = 0 Then
                        permissionsFile.Items.RemoveAt(index)
                    End If
                    index = index + 1
                End While
            Catch ex As Exception
                'Ne rien faire, erreur normale
            End Try

            index = 0

            Try
                While permissionsFile.Items(index) <> Nothing
                    createdPermissionsFile.WriteLine(permissionsFile.Items(index).ToString)
                    index = index + 1
                End While
            Catch ex As Exception
                'Ne rien faire, erreur normale
            End Try

            createdPermissionsFile.WriteLine("#File generated with PermissionsEx configuration program")
            createdPermissionsFile.WriteLine("#Credits: Nathan HAUDOT (nathan060700)")

            createdPermissionsFile.Close()

            MsgBox("You successfully created your permissions.yml file, now you can use it for your server!", vbInformation & vbOKOnly, "Create your permissions.yml file")

            permissionsFile.Items.Clear()
            createButton.Enabled = False
            addPlayerButton.Enabled = False
            removePlayerButton.Enabled = False
            playersListBox.Items.Clear()
            playersListBox.Enabled = False
            addGroupButton.Enabled = True
            removeGroupButton.Enabled = True
            groupsListBox.Items.Clear()
            groupsListBox.Enabled = True
            finishTheGroupsButton.Enabled = True

        End If

    End Sub
End Class
