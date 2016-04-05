' Made By: Brandon Woodford

' Date: 2/7/2016 Updated: 3/01/2016

' Program Name: Fighting Game Analyzer

' Use: For comparing fighting game
' characters that are in the same game.
' Very useful for finding the strengths
' and weaknesses between characters.

Option Explicit On
Option Strict On
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data.SqlClient

Public Class MainFrm

    Dim currentChar As New Character()
    Dim charList As New BindingList(Of Character)

    ' Change the attached Path if you downloaded this.
    Dim connectionString As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Brandon\Desktop\Second Semester\Visual Basic\Final_Project\Final_Project\Characters.mdf;Integrated Security=True"

    ' On Form Load
    Private Sub MainFrm_Load(sender As Object, e As EventArgs) Handles Me.Load

        lstCharacters.DataSource = charList
        lstCharacters.DisplayMember = "Name"
        ResetStatsChar1()
        ResetStatsChar2()

        cbxGameTitle.Text = "Ultra Street Fighter 4" ' Delete this if adding in more games...

        Dim dbConnection As New SqlConnection(connectionString)

        ' Inputted for less delay on character combobox being populated
        dbConnection.Open()

    End Sub

    Private Sub cbxGameTitle_SelectedValueChanged(sender As Object, e As EventArgs) Handles cbxGameTitle.SelectedValueChanged

        If cbxGameTitle.Text = "Ultra Street Fighter 4" Then

            cbxCharName.Items.Clear()
            cbxCharName.Text = ""
            Clear()
            ResetStatsChar1()
            ResetStatsChar2()

            pbxGameImage.Image = Image.FromFile("images/UltraStreetFighter.png")

        End If

    End Sub

    Private Sub cbxCharName_MouseClick(sender As Object, e As MouseEventArgs) Handles cbxCharName.MouseClick

        populateCharacters()

    End Sub

    Private Sub populateCharacters()

        Dim dbConnection As New SqlConnection(connectionString)

        Dim sqlString As String = "SELECT Name FROM SFcharacters"
        Dim selectCommand As New SqlCommand(sqlString, dbConnection)

        If cbxGameTitle.Text = "Ultra Street Fighter 4" Then

            If cbxCharName.Items.Count = Nothing Then

                cbxCharName.Items.Add("*ADD ALL*")
                cbxCharName.Items.Add("")

                Try

                    dbConnection.Open()

                    Dim reader As SqlDataReader = selectCommand.ExecuteReader()

                    If reader.HasRows Then

                        While reader.Read

                            cbxCharName.Items.Add(reader.Item("Name").ToString)

                        End While

                    End If

                    dbConnection.Close()
                    dbConnection.Dispose()

                Catch ex As Exception

                    MessageBox.Show(ex.Message)

                End Try

            End If

        End If

    End Sub

    ' Combobox Selection
    Private Sub cbxCharName_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxCharName.SelectedIndexChanged

        AddItemsToArray()
        cbxCharName.Items.Clear()

    End Sub

    ' Add Characters to List
    Private Sub AddItemsToArray()

        Dim newCharacter As New Character()
        Dim checkForName As Integer
        Dim sqlCharName As String

        Dim dbConnection As New SqlConnection(connectionString)

        If cbxCharName.Text = "*ADD ALL*" And lstCharacters.Items.Count < 44 Then

            AddAllCharacters()

        ElseIf cbxCharName.Text = "" Then

            ' Do nothing

        Else

            ' Makes sure ADD ALL can not be added to list
            If cbxCharName.Text = "*ADD ALL*" Then

                cbxCharName.Text = ""

            Else

                newCharacter.Name = cbxCharName.Text

                'Clears the check of cbxCharName
                cbxCharName.Text = ""

                sqlCharName = newCharacter.Name

                checkForName = lstCharacters.FindString(newCharacter.Name)

                If checkForName >= 0 Then

                    MessageBox.Show("'" + newCharacter.Name + "'" + " has already been added to the list.")

                Else

                    Try

                        dbConnection.Open()

                        Dim sqlString As String = "SELECT * FROM SFcharacters WHERE Name = @CharName"
                        Dim selectCommand As New SqlCommand(sqlString, dbConnection)
                        selectCommand.Parameters.AddWithValue("@CharName", sqlCharName)

                        Dim reader As SqlDataReader = selectCommand.ExecuteReader()

                        If reader.HasRows Then

                            While reader.Read

                                newCharacter.LightPunch = reader.Item("LP_damage").ToString
                                newCharacter.HeavyPunch = reader.Item("HP_damage").ToString
                                newCharacter.LightKick = reader.Item("LK_damage").ToString
                                newCharacter.HeavyKick = reader.Item("HK_damage").ToString
                                newCharacter.Super = reader.Item("Sup_damage").ToString
                                newCharacter.CharNotes = reader.Item("Chara_Notes").ToString
                                newCharacter.characterID = reader.Item("Id").ToString

                            End While

                        End If

                        charList.Add(newCharacter)

                        dbConnection.Close()
                        dbConnection.Dispose()

                    Catch ex As Exception

                        MessageBox.Show(ex.Message)

                    End Try

                End If

            End If

        End If



    End Sub

    ' Add All Characters to List
    Private Sub AddAllCharacters()

        Clear()

        Dim count As Integer = 1

        While count <= 44

            ' DropDownStyle change for cbx.text manipulation
            cbxCharName.DropDownStyle = ComboBoxStyle.DropDown


            Dim dbConnection As New SqlConnection(connectionString)

            Try

                dbConnection.Open()

                Dim sqlString As String = "SELECT Name FROM SFcharacters WHERE Id = @count"

                Dim selectCommand As New SqlCommand(sqlString, dbConnection)

                selectCommand.Parameters.AddWithValue("@count", count)

                Dim reader As SqlDataReader = selectCommand.ExecuteReader()



                If reader.HasRows Then

                    While reader.Read

                        cbxCharName.Text = reader.Item("Name").ToString
                        AddItemsToArray()
                        count = count + 1

                    End While

                End If

                dbConnection.Close()
                dbConnection.Dispose()

            Catch ex As Exception

                MessageBox.Show(ex.Message)

            End Try

        End While

        cbxCharName.DropDownStyle = ComboBoxStyle.DropDownList

    End Sub

    ' Clear List
    Public Sub Clear()

        charList.Clear()

    End Sub

    ' Button for Character 1
    Private Sub btnAddChar1_Click(sender As Object, e As EventArgs) Handles btnAddChar1.Click

        currentChar = CType(lstCharacters.SelectedItem, Character)

        If lstCharacters.SelectedItem Is Nothing Then

            MessageBox.Show("Please select a Character Name.")

        Else

            If currentChar.Name = lblCharName2.Text Then

                MessageBox.Show("'" + currentChar.Name + "'" + " is already added into Character 2!")

            Else

                DisplayStatsChar1()

            End If

        End If

    End Sub

    Private Sub DisplayStatsChar1()

        lblCharName1.Text = currentChar.Name
        lblLP_Dmg1.Text = currentChar.LightPunch & " hp"
        lblHP_Dmg1.Text = currentChar.HeavyPunch & " hp"
        lblLK_Dmg1.Text = currentChar.LightKick & " hp"
        lblHK_Dmg1.Text = currentChar.HeavyKick & " hp"
        lblSuper_Dmg1.Text = currentChar.Super & " hp"
        rtbNotes1.Text = currentChar.CharNotes

    End Sub

    ' Button for Character 2
    Private Sub btnAddChar2_Click(sender As Object, e As EventArgs) Handles btnAddChar2.Click

        currentChar = CType(lstCharacters.SelectedItem, Character)

        If lstCharacters.SelectedItem Is Nothing Then

            MessageBox.Show("Please select a Character Name.")

        Else

            If currentChar.Name = lblCharName1.Text Then

                MessageBox.Show("'" + currentChar.Name + "'" + " is already added into Character 1!")

            Else

                DisplayStatsChar2()

            End If

        End If

    End Sub

    Private Sub DisplayStatsChar2()

        lblCharName2.Text = currentChar.Name
        lblLP_Dmg2.Text = currentChar.LightPunch & " hp"
        lblHP_Dmg2.Text = currentChar.HeavyPunch & " hp"
        lblLK_Dmg2.Text = currentChar.LightKick & " hp"
        lblHK_Dmg2.Text = currentChar.HeavyKick & " hp"
        lblSuper_Dmg2.Text = currentChar.Super & " hp"
        rtbNotes2.Text = currentChar.CharNotes

    End Sub

    ' Button Clearing Stats
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click

        ResetStatsChar1()
        ResetStatsChar2()

    End Sub

    Private Sub ResetStatsChar1()

        lblCharName1.Text = ""
        lblLP_Dmg1.Text = ""
        lblHP_Dmg1.Text = ""
        lblLK_Dmg1.Text = ""
        lblHK_Dmg1.Text = ""
        lblSuper_Dmg1.Text = ""
        rtbNotes1.Text = ""

    End Sub

    Private Sub ResetStatsChar2()

        'charName space is used for different value in comparison to char1
        lblCharName2.Text = " "
        lblLP_Dmg2.Text = ""
        lblHP_Dmg2.Text = ""
        lblLK_Dmg2.Text = ""
        lblHK_Dmg2.Text = ""
        lblSuper_Dmg2.Text = ""
        rtbNotes2.Text = ""

    End Sub

    ' Button Notes 1
    Private Sub btnNotes1_Click(sender As Object, e As EventArgs) Handles btnNotes1.Click

        Dim dbConnection As New SqlConnection(connectionString)

        Dim sqlString As String = "UPDATE SFcharacters SET Chara_Notes = @Chara_Notes WHERE Name = @CharName"
        Dim updateCommand As New SqlCommand(sqlString, dbConnection)

        dbConnection.Open()

        updateCommand.Parameters.Add("@CharName", SqlDbType.VarChar).Value = lblCharName1.Text
        updateCommand.Parameters.Add("@Chara_Notes", SqlDbType.VarChar).Value = rtbNotes1.Text

        Try
            updateCommand.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        dbConnection.Close()
        dbConnection.Dispose()

    End Sub

    ' Button Notes 2
    Private Sub btnNotes2_Click(sender As Object, e As EventArgs) Handles btnNotes2.Click

        Dim dbConnection As New SqlConnection(connectionString)

        Dim sqlString As String = "UPDATE SFcharacters SET Chara_Notes = @Chara_Notes WHERE Name = @CharName"
        Dim updateCommand As New SqlCommand(sqlString, dbConnection)

        dbConnection.Open()

        updateCommand.Parameters.Add("@CharName", SqlDbType.VarChar).Value = lblCharName2.Text
        updateCommand.Parameters.Add("@Chara_Notes", SqlDbType.VarChar).Value = rtbNotes2.Text

        Try
            updateCommand.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        dbConnection.Close()
        dbConnection.Dispose()

    End Sub

    ' Button Clear Character List
    Private Sub btnClearList_Click(sender As Object, e As EventArgs) Handles btnClearList.Click
        Clear()
    End Sub

    ' On Form Close
    Private Sub MainFrm_Closed(sender As Object, e As EventArgs) Handles Me.Closed

        Dim dbConnection As New SqlConnection(connectionString)

        dbConnection.Close()
        dbConnection.Dispose()

    End Sub

End Class