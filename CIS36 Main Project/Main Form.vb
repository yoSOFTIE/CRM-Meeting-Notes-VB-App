'Programmer: Jonathan Rodriguez
'Purpose: Final Project - Status Now
'Date: December 6th 2016

Option Explicit On
Option Infer Off
Option Strict On

Public Class frmMain
    Const intMAX As Integer = Integer.MaxValue
    Private strFileName As String
    Private strNotesPrior As String
    Private outFile As IO.StreamWriter
    Private dlgButton As DialogResult
    Private intFirstNoteLength As Integer

    ' closes file
    Private Sub CloseFile()
        outFile.Close()
    End Sub

    ' Saves history into text file. Provides option to make file Read Only
    Private Sub SaveSecureFile()
        ' adds final time elapsed and comment indicating that session has ended
        txtHistory.Text = strNotesPrior & "[" & lblHour.Text & lblCol1.Text & lblMinute.Text &
                lblCol2.Text & lblSeconds.Text & "]-> " & "...End Session"

        ' opens file that was created at beggining of session
        outFile = IO.File.AppendText(strFileName)

        ' writes history to file
        outFile.Write(txtHistory.Text)

        ' make file Read Only option
        dlgButton = MessageBox.Show("Would you like to SECURE session?", "Status Now",
                                    MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)

        ' If user wants file made Read Only attributes for file are modified
        If dlgButton = DialogResult.Yes Then
            My.Computer.FileSystem.GetFileInfo(strFileName).Attributes = IO.FileAttributes.ReadOnly
        End If

        'close the file
        Call CloseFile()
    End Sub

    ' send focus to file menu option in menu tool bar
    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles Me.Load
        ' set focus on File option in menu tool bar
        mnuFile.Select()
    End Sub

    ' Create a new file to begin a new session
    Private Sub mnuNewFile_Click(sender As Object, e As EventArgs) Handles mnuNewFile.Click
        ' prompt user to enter a session name
        strFileName = InputBox("Input new SESSION name.", "Status Now")

        ' validation selection structure if user inputed anything
        If strFileName = String.Empty Then
            ' message notifying user that a file name must be entered
            MessageBox.Show("File name must be specified", "Status Now",
                            MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            ' append file type extention to name of session to create file
            strFileName = strFileName & ".txt"

            ' validation selection structure if file name exists
            If IO.File.Exists(strFileName) Then
                ' message notifying user that file name already exits
                MessageBox.Show("File name already exists. Please enter another name.", "Status Now",
                                MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                ' create a file for output
                outFile = IO.File.CreateText(strFileName)
                ' calls sub procedure to close file
                Call CloseFile()

                ' enable objects in order to begin session
                btnStartSave.Enabled = True
                mnuEdit.Enabled = True
                txtHistory.Enabled = True

                ' change color of Edit menu tool bar, indicates it can be used now
                mnuEdit.ForeColor = Color.Black

                ' send focus to start button
                btnStartSave.Focus()
            End If
        End If
    End Sub

    ' copy history textbox content to clipboard
    Private Sub mnuEditHistoryCopyHistory_Click(sender As Object, e As EventArgs) Handles mnuEditHistoryCopyHistory.Click
        Dim strClipBoard As String = txtHistory.Text
        Clipboard.Clear()
        Clipboard.SetText(strClipBoard)
    End Sub

    ' enables content in history textbox to be edited
    Private Sub mnuEditHistoryEdit_Click(sender As Object, e As EventArgs) Handles mnuEditHistoryEdit.Click
        ' stops timer object tick event which also stops numbers in
        ' seconds, minutes, hours labels from updating
        tmrAccum.Stop()

        ' disables certain objects while in edit mode
        btnStartSave.Enabled = False
        btnPause.Enabled = False
        btnStop.Enabled = False
        txtNotes.Enabled = False
        txtHistory.ReadOnly = False

        'sends cursor focus to end of history textbox content
        txtHistory.SelectionStart = txtHistory.Text.Length
        txtHistory.ScrollToCaret()
    End Sub

    ' cancels/exits edit history
    Private Sub mnuEditHistoryCancelEdit_Click(sender As Object, e As EventArgs) Handles mnuEditHistoryCancelEdit.Click
        ' starts timer Tick event
        tmrAccum.Start()

        ' enables certain objects
        btnStartSave.Enabled = True
        btnPause.Enabled = True
        btnStop.Enabled = True
        txtNotes.Enabled = True
        txtHistory.ReadOnly = True

        ' sends focus to Notes text box
        txtNotes.Focus()
    End Sub

    ' clears history and resets timer
    Private Sub mnuEditHistoryClear_Click(sender As Object, e As EventArgs) Handles mnuEditHistoryClear.Click
        ' timer Tick event stops
        tmrAccum.Stop()

        ' resets objects by clearing textboxes and setting seconds, minutes, hours labels to '0'
        txtNotes.Text = String.Empty
        txtHistory.Text = String.Empty
        lblSeconds.Text = "0"
        lblMinute.Text = "0"
        lblHour.Text = "0"
        mnuEdit.Enabled = False
        btnStartSave.Text = "&Start"
        btnStartSave.Enabled = False
        btnPause.Enabled = False
        btnStop.Enabled = False
        txtNotes.Enabled = False
        txtHistory.Enabled = False
        My.Computer.FileSystem.DeleteFile(strFileName)
    End Sub

    ' Starts the timer, puts first note, and updates history with new notes
    Private Sub btnStartSave_Click(sender As Object, e As EventArgs) Handles btnStartSave.Click
        ' Puts first note in History indicating Session has started
        If lblMinute.Text = "0" AndAlso lblSeconds.Text = "0" AndAlso lblHour.Text = "0" Then
            ' integer variable store index of period in ".txt" part of file name
            ' store sub string of file name to string variable
            Dim intPeriodIndex As Integer = strFileName.IndexOf(".")
            Dim strSessionName As String = strFileName.Substring(0, intPeriodIndex)

            'first comment to be put into History textbox
            ' includes session name, and current date and time of computer (date/time converted to string)
            txtHistory.Text = "(Session: " & strSessionName.ToUpper & ")" & " - " & DateTime.Now.ToString() & ControlChars.NewLine &
                "••••••••••••••••••••••••••••••••••••••••••••••••" &
                ControlChars.NewLine & "[0:0:0] -> Session Start..." & ControlChars.NewLine &
            "••••••••••••••••••••••••••••••••••••••••••••••••" & ControlChars.NewLine

            ' stores history to append before new history
            strNotesPrior = txtHistory.Text
            intFirstNoteLength = strNotesPrior.Length
        End If

        ' validation to start timer
        If btnStartSave.Text <> "&Save" Then
            ' starts timer
            tmrAccum.Start()

            'changes text in button to save
            btnStartSave.Text = "&Save"

            ' enables certain object for use
            txtNotes.Enabled = True
            btnPause.Enabled = True
            btnStop.Enabled = True
        End If

        ' validation for when timer is already started and to update history with 
        ' notes If notes textbox contains any text
        If txtNotes.Text <> String.Empty Then
            txtHistory.Text = strNotesPrior & "[" & lblHour.Text & lblCol1.Text & lblMinute.Text &
                lblCol2.Text & lblSeconds.Text & "]-> " & txtNotes.Text & ControlChars.NewLine &
            "••••••••••••••••••••••••••••••••••••••••••••••••" & ControlChars.NewLine

            ' stores History to string variable and clears text in Notes text box
            strNotesPrior = txtHistory.Text
            txtNotes.Text = String.Empty
        End If

        ' sends carat to end of History textbox in order to have scroll bar move down to current hsitory position
        ' sends focus to Notes text box once scroll position changes
        txtHistory.SelectionStart = txtHistory.Text.Length
        txtHistory.ScrollToCaret()
        txtNotes.Focus()
    End Sub

    ' Pauses timer
    Private Sub btnPause_Click(sender As Object, e As EventArgs) Handles btnPause.Click
        ' Stops Tick event for timer object
        tmrAccum.Stop()

        ' Changes text in button
        btnStartSave.Text = "&Start"

        ' enables and disables certain objects
        txtNotes.Enabled = False
        btnStartSave.Enabled = True
        btnPause.Enabled = False

        txtNotes.Focus()
        txtNotes.SelectionStart = txtNotes.Text.Length
    End Sub

    ' stops timer, prompt user to save history to file
    Private Sub btnStop_Click(sender As Object, e As EventArgs) Handles btnStop.Click
        ' stop timer tick event
        tmrAccum.Stop()

        ' prompts user if they want to save notes
        dlgButton = MessageBox.Show("Do you want to save?", "Status Now", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)

        ' if user wants to save file calls save secure sub procedure
        If dlgButton = DialogResult.Yes Then
            Call SaveSecureFile()
        End If

        ' resets time labels to '0' and changes Text in button
        lblSeconds.Text = "0"
        lblMinute.Text = "0"
        lblHour.Text = "0"
        btnStartSave.Text = "&Start"

        ' disables certain objects
        txtNotes.Enabled = False
        txtHistory.Enabled = False
        btnStartSave.Enabled = False
        btnPause.Enabled = False
        btnStop.Enabled = False
        mnuEdit.Enabled = False

        ' changes color of edit menu tool bar option
        mnuEdit.ForeColor = Color.Silver

        ' clears Notes and History textbox
        txtNotes.Text = String.Empty
        txtHistory.Text = String.Empty
    End Sub

    ' accumulate and update time labels through Tick event
    Private Sub tmrAccum_Tick(sender As Object, e As EventArgs) Handles tmrAccum.Tick
        Dim intSeconds As Integer
        Dim intMinutes As Integer
        Dim intHours As Integer

        Integer.TryParse(lblSeconds.Text, intSeconds)
        Integer.TryParse(lblMinute.Text, intMinutes)
        Integer.TryParse(lblHour.Text, intHours)

        ' update seconds integer to update seconds label
        intSeconds += 1

        lblSeconds.Text = intSeconds.ToString

        ' updates minutes label
        If lblSeconds.Text = "60" Then
            lblSeconds.Text = "0"
            intMinutes += 1
            lblMinute.Text = intMinutes.ToString
        End If

        ' updates hours
        If lblMinute.Text = "60" Then
            lblMinute.Text = "0"
            intHours += 1
            lblHour.Text = intHours.ToString
        End If

        ' validates that Hours label can only reach up to integer max
        If lblHour.Text = intMAX.ToString Then
            lblSeconds.Text = "0"
            lblMinute.Text = "0"
            lblHour.Text = "0"
        End If
    End Sub


    Private Sub mnuExit_Click(sender As Object, e As EventArgs) Handles mnuExit.Click
        Me.Close()
    End Sub

    ' procedure for saving history to file
    Private Sub frmMain_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        ' save the list box information
        tmrAccum.Stop()

        ' ensures that file is either saved with History content or file is deleted if no notes were saved
        If strFileName <> String.Empty AndAlso txtHistory.Text <> String.Empty AndAlso
            txtHistory.Text.Length <> intFirstNoteLength Then
            dlgButton = MessageBox.Show("Do you want to save?", "Status Now", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation)

            ' validates if user wants to save file and what happens to file
            If dlgButton = DialogResult.Yes Then
                ' calls sub procedure to save and secure file
                Call SaveSecureFile()
            ElseIf dlgButton = DialogResult.Cancel Then
                e.Cancel = True
            Else
                ' deletes file if user does not want to save
                My.Computer.FileSystem.DeleteFile(strFileName)
            End If
        ElseIf strFileName <> String.Empty AndAlso txtHistory.Text = String.Empty Then
            ' deletes file if no notes were made
            My.Computer.FileSystem.DeleteFile(strFileName)
        End If
    End Sub

    ' prohibits return key in Notes and History
    Private Sub ProhibitReturn(sender As Object, e As KeyEventArgs) Handles txtNotes.KeyDown, txtHistory.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
        End If
    End Sub
End Class