<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.lblSeconds = New System.Windows.Forms.Label()
        Me.lblMinute = New System.Windows.Forms.Label()
        Me.lblHour = New System.Windows.Forms.Label()
        Me.btnStop = New System.Windows.Forms.Button()
        Me.btnStartSave = New System.Windows.Forms.Button()
        Me.btnPause = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblCol2 = New System.Windows.Forms.Label()
        Me.lblCol1 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.mnuFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuNewFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuEdit = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuEditHistory = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuEditHistoryCopyHistory = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuEditHistoryEdit = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuEditHistoryCancelEdit = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuEditHistoryClear = New System.Windows.Forms.ToolStripMenuItem()
        Me.txtNotes = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tmrAccum = New System.Windows.Forms.Timer(Me.components)
        Me.lblH = New System.Windows.Forms.Label()
        Me.lblM = New System.Windows.Forms.Label()
        Me.lblS = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txtHistory = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblSeconds
        '
        Me.lblSeconds.BackColor = System.Drawing.Color.Khaki
        Me.lblSeconds.Font = New System.Drawing.Font("Adobe Fan Heiti Std B", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSeconds.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.lblSeconds.Location = New System.Drawing.Point(356, 206)
        Me.lblSeconds.Name = "lblSeconds"
        Me.lblSeconds.Size = New System.Drawing.Size(83, 86)
        Me.lblSeconds.TabIndex = 9
        Me.lblSeconds.Text = "0"
        Me.lblSeconds.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblMinute
        '
        Me.lblMinute.BackColor = System.Drawing.Color.Khaki
        Me.lblMinute.Font = New System.Drawing.Font("Adobe Fan Heiti Std B", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMinute.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.lblMinute.Location = New System.Drawing.Point(238, 206)
        Me.lblMinute.Name = "lblMinute"
        Me.lblMinute.Size = New System.Drawing.Size(83, 86)
        Me.lblMinute.TabIndex = 6
        Me.lblMinute.Text = "0"
        Me.lblMinute.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblHour
        '
        Me.lblHour.BackColor = System.Drawing.Color.Khaki
        Me.lblHour.Font = New System.Drawing.Font("Adobe Fan Heiti Std B", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHour.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.lblHour.Location = New System.Drawing.Point(120, 206)
        Me.lblHour.Name = "lblHour"
        Me.lblHour.Size = New System.Drawing.Size(83, 86)
        Me.lblHour.TabIndex = 3
        Me.lblHour.Text = "0"
        Me.lblHour.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnStop
        '
        Me.btnStop.Enabled = False
        Me.btnStop.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnStop.FlatAppearance.BorderSize = 9
        Me.btnStop.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStop.Location = New System.Drawing.Point(366, 337)
        Me.btnStop.Name = "btnStop"
        Me.btnStop.Size = New System.Drawing.Size(158, 39)
        Me.btnStop.TabIndex = 14
        Me.btnStop.Text = "S&top"
        Me.btnStop.UseVisualStyleBackColor = True
        '
        'btnStartSave
        '
        Me.btnStartSave.Enabled = False
        Me.btnStartSave.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnStartSave.FlatAppearance.BorderSize = 9
        Me.btnStartSave.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStartSave.Location = New System.Drawing.Point(34, 337)
        Me.btnStartSave.Name = "btnStartSave"
        Me.btnStartSave.Size = New System.Drawing.Size(158, 39)
        Me.btnStartSave.TabIndex = 12
        Me.btnStartSave.Text = "&Start"
        Me.btnStartSave.UseVisualStyleBackColor = True
        '
        'btnPause
        '
        Me.btnPause.Enabled = False
        Me.btnPause.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnPause.FlatAppearance.BorderSize = 9
        Me.btnPause.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPause.Location = New System.Drawing.Point(200, 337)
        Me.btnPause.Name = "btnPause"
        Me.btnPause.Size = New System.Drawing.Size(158, 39)
        Me.btnPause.TabIndex = 13
        Me.btnPause.Text = "&Pause"
        Me.btnPause.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label7.Font = New System.Drawing.Font("Sitka Small", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(189, 65)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(309, 73)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Status Now"
        '
        'lblCol2
        '
        Me.lblCol2.AutoSize = True
        Me.lblCol2.BackColor = System.Drawing.Color.Khaki
        Me.lblCol2.Font = New System.Drawing.Font("Adobe Fan Heiti Std B", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCol2.Location = New System.Drawing.Point(323, 221)
        Me.lblCol2.Name = "lblCol2"
        Me.lblCol2.Size = New System.Drawing.Size(29, 46)
        Me.lblCol2.TabIndex = 7
        Me.lblCol2.Text = ":"
        '
        'lblCol1
        '
        Me.lblCol1.AutoSize = True
        Me.lblCol1.BackColor = System.Drawing.Color.Khaki
        Me.lblCol1.Font = New System.Drawing.Font("Adobe Fan Heiti Std B", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCol1.Location = New System.Drawing.Point(205, 221)
        Me.lblCol1.Name = "lblCol1"
        Me.lblCol1.Size = New System.Drawing.Size(29, 46)
        Me.lblCol1.TabIndex = 4
        Me.lblCol1.Text = ":"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFile, Me.mnuEdit})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(84, 24)
        Me.MenuStrip1.TabIndex = 15
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'mnuFile
        '
        Me.mnuFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuNewFile, Me.ToolStripSeparator1, Me.mnuExit})
        Me.mnuFile.Name = "mnuFile"
        Me.mnuFile.Size = New System.Drawing.Size(37, 20)
        Me.mnuFile.Text = "&File"
        '
        'mnuNewFile
        '
        Me.mnuNewFile.Name = "mnuNewFile"
        Me.mnuNewFile.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.mnuNewFile.Size = New System.Drawing.Size(171, 22)
        Me.mnuNewFile.Text = "&New File..."
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(168, 6)
        '
        'mnuExit
        '
        Me.mnuExit.Name = "mnuExit"
        Me.mnuExit.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.F4), System.Windows.Forms.Keys)
        Me.mnuExit.Size = New System.Drawing.Size(171, 22)
        Me.mnuExit.Text = "E&xit"
        '
        'mnuEdit
        '
        Me.mnuEdit.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuEditHistory})
        Me.mnuEdit.Enabled = False
        Me.mnuEdit.ForeColor = System.Drawing.Color.Silver
        Me.mnuEdit.Name = "mnuEdit"
        Me.mnuEdit.Size = New System.Drawing.Size(39, 20)
        Me.mnuEdit.Text = "&Edit"
        '
        'mnuEditHistory
        '
        Me.mnuEditHistory.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuEditHistoryCopyHistory, Me.mnuEditHistoryEdit, Me.mnuEditHistoryCancelEdit, Me.mnuEditHistoryClear})
        Me.mnuEditHistory.Name = "mnuEditHistory"
        Me.mnuEditHistory.Size = New System.Drawing.Size(152, 22)
        Me.mnuEditHistory.Text = "&History"
        '
        'mnuEditHistoryCopyHistory
        '
        Me.mnuEditHistoryCopyHistory.Name = "mnuEditHistoryCopyHistory"
        Me.mnuEditHistoryCopyHistory.Size = New System.Drawing.Size(175, 22)
        Me.mnuEditHistoryCopyHistory.Text = "Copy h&istory"
        '
        'mnuEditHistoryEdit
        '
        Me.mnuEditHistoryEdit.Name = "mnuEditHistoryEdit"
        Me.mnuEditHistoryEdit.ShortcutKeys = System.Windows.Forms.Keys.F1
        Me.mnuEditHistoryEdit.Size = New System.Drawing.Size(175, 22)
        Me.mnuEditHistoryEdit.Text = "&Edit"
        '
        'mnuEditHistoryCancelEdit
        '
        Me.mnuEditHistoryCancelEdit.Name = "mnuEditHistoryCancelEdit"
        Me.mnuEditHistoryCancelEdit.ShortcutKeyDisplayString = ""
        Me.mnuEditHistoryCancelEdit.ShortcutKeys = System.Windows.Forms.Keys.F2
        Me.mnuEditHistoryCancelEdit.Size = New System.Drawing.Size(175, 22)
        Me.mnuEditHistoryCancelEdit.Text = "&Cancel edit"
        '
        'mnuEditHistoryClear
        '
        Me.mnuEditHistoryClear.Name = "mnuEditHistoryClear"
        Me.mnuEditHistoryClear.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
            Or System.Windows.Forms.Keys.D), System.Windows.Forms.Keys)
        Me.mnuEditHistoryClear.Size = New System.Drawing.Size(175, 22)
        Me.mnuEditHistoryClear.Text = "C&lear"
        '
        'txtNotes
        '
        Me.txtNotes.Enabled = False
        Me.txtNotes.Font = New System.Drawing.Font("Prestige Elite Std", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNotes.Location = New System.Drawing.Point(566, 61)
        Me.txtNotes.Multiline = True
        Me.txtNotes.Name = "txtNotes"
        Me.txtNotes.Size = New System.Drawing.Size(708, 109)
        Me.txtNotes.TabIndex = 11
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(562, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 20)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Notes:"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Khaki
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label2.Location = New System.Drawing.Point(34, 170)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(490, 146)
        Me.Label2.TabIndex = 1
        '
        'tmrAccum
        '
        Me.tmrAccum.Interval = 1000
        '
        'lblH
        '
        Me.lblH.AutoSize = True
        Me.lblH.BackColor = System.Drawing.Color.Khaki
        Me.lblH.Font = New System.Drawing.Font("Segoe UI", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblH.Location = New System.Drawing.Point(148, 189)
        Me.lblH.Name = "lblH"
        Me.lblH.Size = New System.Drawing.Size(20, 20)
        Me.lblH.TabIndex = 2
        Me.lblH.Text = "H"
        '
        'lblM
        '
        Me.lblM.AutoSize = True
        Me.lblM.BackColor = System.Drawing.Color.Khaki
        Me.lblM.Font = New System.Drawing.Font("Segoe UI", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblM.Location = New System.Drawing.Point(264, 189)
        Me.lblM.Name = "lblM"
        Me.lblM.Size = New System.Drawing.Size(23, 20)
        Me.lblM.TabIndex = 5
        Me.lblM.Text = "M"
        '
        'lblS
        '
        Me.lblS.AutoSize = True
        Me.lblS.BackColor = System.Drawing.Color.Khaki
        Me.lblS.Font = New System.Drawing.Font("Segoe UI", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblS.Location = New System.Drawing.Point(386, 189)
        Me.lblS.Name = "lblS"
        Me.lblS.Size = New System.Drawing.Size(17, 20)
        Me.lblS.TabIndex = 8
        Me.lblS.Text = "S"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(49, 57)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(112, 91)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 20
        Me.PictureBox1.TabStop = False
        '
        'txtHistory
        '
        Me.txtHistory.BackColor = System.Drawing.Color.Black
        Me.txtHistory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtHistory.Enabled = False
        Me.txtHistory.Font = New System.Drawing.Font("Prestige Elite Std", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHistory.ForeColor = System.Drawing.Color.White
        Me.txtHistory.Location = New System.Drawing.Point(566, 210)
        Me.txtHistory.Multiline = True
        Me.txtHistory.Name = "txtHistory"
        Me.txtHistory.ReadOnly = True
        Me.txtHistory.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtHistory.Size = New System.Drawing.Size(708, 180)
        Me.txtHistory.TabIndex = 16
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(562, 187)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 20)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "History:"
        '
        'frmMain
        '
        Me.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar
        Me.AllowDrop = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1306, 421)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtHistory)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lblS)
        Me.Controls.Add(Me.lblM)
        Me.Controls.Add(Me.lblH)
        Me.Controls.Add(Me.lblCol2)
        Me.Controls.Add(Me.lblCol1)
        Me.Controls.Add(Me.lblSeconds)
        Me.Controls.Add(Me.lblMinute)
        Me.Controls.Add(Me.lblHour)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtNotes)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.btnPause)
        Me.Controls.Add(Me.btnStartSave)
        Me.Controls.Add(Me.btnStop)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.HelpButton = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Status Now"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblSeconds As Label
    Friend WithEvents lblMinute As Label
    Friend WithEvents lblHour As Label
    Friend WithEvents btnStop As Button
    Friend WithEvents btnStartSave As Button
    Friend WithEvents btnPause As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents lblCol2 As Label
    Friend WithEvents lblCol1 As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents txtNotes As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents tmrAccum As Timer
    Friend WithEvents mnuFile As ToolStripMenuItem
    Friend WithEvents lblH As Label
    Friend WithEvents lblM As Label
    Friend WithEvents lblS As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents mnuNewFile As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents mnuExit As ToolStripMenuItem
    Friend WithEvents txtHistory As TextBox
    Friend WithEvents mnuEdit As ToolStripMenuItem
    Friend WithEvents mnuEditHistory As ToolStripMenuItem
    Friend WithEvents mnuEditHistoryCopyHistory As ToolStripMenuItem
    Friend WithEvents mnuEditHistoryEdit As ToolStripMenuItem
    Friend WithEvents mnuEditHistoryCancelEdit As ToolStripMenuItem
    Friend WithEvents mnuEditHistoryClear As ToolStripMenuItem
    Friend WithEvents Label3 As Label
End Class
