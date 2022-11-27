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
		Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
		Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.mnuFileClear = New System.Windows.Forms.ToolStripMenuItem()
		Me.mnuFileExit = New System.Windows.Forms.ToolStripMenuItem()
		Me.mnuViewAbout = New System.Windows.Forms.ToolStripMenuItem()
		Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.mnuViewCalc = New System.Windows.Forms.ToolStripMenuItem()
		Me.cboStart = New System.Windows.Forms.ComboBox()
		Me.cboEnd = New System.Windows.Forms.ComboBox()
		Me.txtBank = New System.Windows.Forms.TextBox()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.lblBank = New System.Windows.Forms.Label()
		Me.TimeBankBindingSource = New System.Windows.Forms.BindingSource(Me.components)
		Me.PTODBDataSet = New ASDU_PTO_Tracker.PTODBDataSet()
		Me.cdrTime = New System.Windows.Forms.MonthCalendar()
		Me.lblProtected = New System.Windows.Forms.Label()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.Label5 = New System.Windows.Forms.Label()
		Me.btnEnter = New System.Windows.Forms.Button()
		Me.GroupBox1 = New System.Windows.Forms.GroupBox()
		Me.GroupBox2 = New System.Windows.Forms.GroupBox()
		Me.Label9 = New System.Windows.Forms.Label()
		Me.lblHours = New System.Windows.Forms.Label()
		Me.radProtected = New System.Windows.Forms.RadioButton()
		Me.btnSubmit = New System.Windows.Forms.Button()
		Me.Label7 = New System.Windows.Forms.Label()
		Me.Label6 = New System.Windows.Forms.Label()
		Me.TextBox1 = New System.Windows.Forms.TextBox()
		Me.PictureBox1 = New System.Windows.Forms.PictureBox()
		Me.btnDelete = New System.Windows.Forms.Button()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.lblPTOID = New System.Windows.Forms.Label()
		Me.PTOBindingSource = New System.Windows.Forms.BindingSource(Me.components)
		Me.PTODBDataSet1 = New ASDU_PTO_Tracker.PTODBDataSet()
		Me.TimeBankTableAdapter = New ASDU_PTO_Tracker.PTODBDataSetTableAdapters.TimeBankTableAdapter()
		Me.DataGridView1 = New System.Windows.Forms.DataGridView()
		Me.PTOIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.PTODateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.HoursUsedDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.ProtectedTimeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.PTOTableAdapter = New ASDU_PTO_Tracker.PTODBDataSetTableAdapters.PTOTableAdapter()
		Me.lblPTOHours = New System.Windows.Forms.Label()
		Me.Label8 = New System.Windows.Forms.Label()
		Me.lblPTOProtected = New System.Windows.Forms.Label()
		Me.Label11 = New System.Windows.Forms.Label()
		Me.MenuStrip1.SuspendLayout()
		CType(Me.TimeBankBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.PTODBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.GroupBox1.SuspendLayout()
		Me.GroupBox2.SuspendLayout()
		CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.PTOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.PTODBDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'MenuStrip1
		'
		Me.MenuStrip1.BackColor = System.Drawing.Color.White
		Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.mnuViewAbout})
		Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
		Me.MenuStrip1.Name = "MenuStrip1"
		Me.MenuStrip1.Size = New System.Drawing.Size(1139, 24)
		Me.MenuStrip1.TabIndex = 0
		Me.MenuStrip1.Text = "MenuStrip1"
		'
		'FileToolStripMenuItem
		'
		Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFileClear, Me.mnuFileExit})
		Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
		Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
		Me.FileToolStripMenuItem.Text = "File"
		'
		'mnuFileClear
		'
		Me.mnuFileClear.Name = "mnuFileClear"
		Me.mnuFileClear.Size = New System.Drawing.Size(154, 22)
		Me.mnuFileClear.Text = "Clear PTO Bank"
		'
		'mnuFileExit
		'
		Me.mnuFileExit.Name = "mnuFileExit"
		Me.mnuFileExit.Size = New System.Drawing.Size(154, 22)
		Me.mnuFileExit.Text = "Exit"
		'
		'mnuViewAbout
		'
		Me.mnuViewAbout.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem, Me.mnuViewCalc})
		Me.mnuViewAbout.Name = "mnuViewAbout"
		Me.mnuViewAbout.Size = New System.Drawing.Size(44, 20)
		Me.mnuViewAbout.Text = "View"
		'
		'AboutToolStripMenuItem
		'
		Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
		Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
		Me.AboutToolStripMenuItem.Text = "About"
		'
		'mnuViewCalc
		'
		Me.mnuViewCalc.Name = "mnuViewCalc"
		Me.mnuViewCalc.Size = New System.Drawing.Size(180, 22)
		Me.mnuViewCalc.Text = "Windows Calculator"
		'
		'cboStart
		'
		Me.cboStart.DropDownHeight = 138
		Me.cboStart.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cboStart.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cboStart.FormattingEnabled = True
		Me.cboStart.IntegralHeight = False
		Me.cboStart.Items.AddRange(New Object() {"8:00 AM", "8:15 AM", "8:30 AM", "8:45 AM", "9:00 AM", "9:15 AM", "9:30 AM", "9:45 AM", "10:00 AM", "10:15 AM", "10:30 AM", "10:45 AM", "11:00 AM", "11:15 AM", "11:30 AM", "11:45 AM", "12:00 PM", "12:15 PM", "12:30 PM", "12:45 PM", "1:00 PM", "1:15 PM", "1:30 PM", "1:45 PM", "2:00 PM", "2:15 PM", "2:30 PM", "2:45 PM", "3:00 PM", "3:15 PM", "3:30 PM", "3:45 PM", "4:00 PM", "4:15 PM", "4:30 PM", "4:45 PM", "5:00 PM", "5:15 PM", "5:30 PM", "5:45 PM", "6:00 PM", "6:15 PM", "6:30 PM", "6:45 PM", "7:00 PM", "7:15 PM", "7:30 PM", "7:45 PM", "8:00 PM"})
		Me.cboStart.Location = New System.Drawing.Point(251, 46)
		Me.cboStart.MaxDropDownItems = 5
		Me.cboStart.Name = "cboStart"
		Me.cboStart.Size = New System.Drawing.Size(100, 23)
		Me.cboStart.TabIndex = 0
		'
		'cboEnd
		'
		Me.cboEnd.DropDownHeight = 138
		Me.cboEnd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cboEnd.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cboEnd.FormattingEnabled = True
		Me.cboEnd.IntegralHeight = False
		Me.cboEnd.Items.AddRange(New Object() {"8:00 AM", "8:15 AM", "8:30 AM", "8:45 AM", "9:00 AM", "9:15 AM", "9:30 AM", "9:45 AM", "10:00 AM", "10:15 AM", "10:30 AM", "10:45 AM", "11:00 AM", "11:15 AM", "11:30 AM", "11:45 AM", "12:00 PM", "12:15 PM", "12:30 PM", "12:45 PM", "1:00 PM", "1:15 PM", "1:30 PM", "1:45 PM", "2:00 PM", "2:15 PM", "2:30 PM", "2:45 PM", "3:00 PM", "3:15 PM", "3:30 PM", "3:45 PM", "4:00 PM", "4:15 PM", "4:30 PM", "4:45 PM", "5:00 PM", "5:15 PM", "5:30 PM", "5:45 PM", "6:00 PM", "6:15 PM", "6:30 PM", "6:45 PM", "7:00 PM", "7:15 PM", "7:30 PM", "7:45 PM", "8:00 PM"})
		Me.cboEnd.Location = New System.Drawing.Point(251, 96)
		Me.cboEnd.MaxDropDownItems = 5
		Me.cboEnd.Name = "cboEnd"
		Me.cboEnd.Size = New System.Drawing.Size(100, 23)
		Me.cboEnd.TabIndex = 1
		'
		'txtBank
		'
		Me.txtBank.Location = New System.Drawing.Point(9, 51)
		Me.txtBank.Name = "txtBank"
		Me.txtBank.Size = New System.Drawing.Size(100, 23)
		Me.txtBank.TabIndex = 0
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Location = New System.Drawing.Point(6, 33)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(103, 15)
		Me.Label1.TabIndex = 4
		Me.Label1.Text = "PTO Bank (Hours):"
		'
		'lblBank
		'
		Me.lblBank.AutoSize = True
		Me.lblBank.BackColor = System.Drawing.Color.GhostWhite
		Me.lblBank.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.lblBank.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TimeBankBindingSource, "Bank", True))
		Me.lblBank.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblBank.Location = New System.Drawing.Point(139, 51)
		Me.lblBank.MinimumSize = New System.Drawing.Size(100, 23)
		Me.lblBank.Name = "lblBank"
		Me.lblBank.Size = New System.Drawing.Size(100, 23)
		Me.lblBank.TabIndex = 5
		Me.lblBank.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'TimeBankBindingSource
		'
		Me.TimeBankBindingSource.DataMember = "TimeBank"
		Me.TimeBankBindingSource.DataSource = Me.PTODBDataSet
		'
		'PTODBDataSet
		'
		Me.PTODBDataSet.DataSetName = "PTODBDataSet"
		Me.PTODBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
		'
		'cdrTime
		'
		Me.cdrTime.Location = New System.Drawing.Point(12, 28)
		Me.cdrTime.Name = "cdrTime"
		Me.cdrTime.TabIndex = 6
		'
		'lblProtected
		'
		Me.lblProtected.AutoSize = True
		Me.lblProtected.BackColor = System.Drawing.Color.GhostWhite
		Me.lblProtected.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.lblProtected.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TimeBankBindingSource, "Protected", True))
		Me.lblProtected.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblProtected.Location = New System.Drawing.Point(139, 98)
		Me.lblProtected.MinimumSize = New System.Drawing.Size(100, 23)
		Me.lblProtected.Name = "lblProtected"
		Me.lblProtected.Size = New System.Drawing.Size(100, 23)
		Me.lblProtected.TabIndex = 8
		Me.lblProtected.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'Label4
		'
		Me.Label4.AutoSize = True
		Me.Label4.Location = New System.Drawing.Point(136, 83)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(85, 15)
		Me.Label4.TabIndex = 9
		Me.Label4.Text = "Protected PTO:"
		'
		'Label5
		'
		Me.Label5.AutoSize = True
		Me.Label5.Location = New System.Drawing.Point(136, 33)
		Me.Label5.Name = "Label5"
		Me.Label5.Size = New System.Drawing.Size(59, 15)
		Me.Label5.TabIndex = 10
		Me.Label5.Text = "Total PTO:"
		'
		'btnEnter
		'
		Me.btnEnter.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue
		Me.btnEnter.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray
		Me.btnEnter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue
		Me.btnEnter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnEnter.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnEnter.Location = New System.Drawing.Point(9, 83)
		Me.btnEnter.Name = "btnEnter"
		Me.btnEnter.Size = New System.Drawing.Size(100, 38)
		Me.btnEnter.TabIndex = 1
		Me.btnEnter.Text = "Enter PTO"
		Me.btnEnter.UseVisualStyleBackColor = True
		'
		'GroupBox1
		'
		Me.GroupBox1.Controls.Add(Me.btnEnter)
		Me.GroupBox1.Controls.Add(Me.lblProtected)
		Me.GroupBox1.Controls.Add(Me.Label5)
		Me.GroupBox1.Controls.Add(Me.txtBank)
		Me.GroupBox1.Controls.Add(Me.Label4)
		Me.GroupBox1.Controls.Add(Me.Label1)
		Me.GroupBox1.Controls.Add(Me.lblBank)
		Me.GroupBox1.Location = New System.Drawing.Point(37, 169)
		Me.GroupBox1.Name = "GroupBox1"
		Me.GroupBox1.Size = New System.Drawing.Size(251, 139)
		Me.GroupBox1.TabIndex = 12
		Me.GroupBox1.TabStop = False
		Me.GroupBox1.Text = "PTO Bank"
		'
		'GroupBox2
		'
		Me.GroupBox2.Controls.Add(Me.Label9)
		Me.GroupBox2.Controls.Add(Me.lblHours)
		Me.GroupBox2.Controls.Add(Me.radProtected)
		Me.GroupBox2.Controls.Add(Me.btnSubmit)
		Me.GroupBox2.Controls.Add(Me.Label7)
		Me.GroupBox2.Controls.Add(Me.Label6)
		Me.GroupBox2.Controls.Add(Me.cdrTime)
		Me.GroupBox2.Controls.Add(Me.cboEnd)
		Me.GroupBox2.Controls.Add(Me.cboStart)
		Me.GroupBox2.Location = New System.Drawing.Point(294, 169)
		Me.GroupBox2.Name = "GroupBox2"
		Me.GroupBox2.Size = New System.Drawing.Size(364, 280)
		Me.GroupBox2.TabIndex = 13
		Me.GroupBox2.TabStop = False
		Me.GroupBox2.Text = "Time Away Selection"
		'
		'Label9
		'
		Me.Label9.AutoSize = True
		Me.Label9.Location = New System.Drawing.Point(248, 152)
		Me.Label9.Name = "Label9"
		Me.Label9.Size = New System.Drawing.Size(100, 15)
		Me.Label9.TabIndex = 15
		Me.Label9.Text = "Hours Scheduled:"
		'
		'lblHours
		'
		Me.lblHours.AutoSize = True
		Me.lblHours.BackColor = System.Drawing.Color.GhostWhite
		Me.lblHours.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.lblHours.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblHours.Location = New System.Drawing.Point(251, 167)
		Me.lblHours.MinimumSize = New System.Drawing.Size(100, 23)
		Me.lblHours.Name = "lblHours"
		Me.lblHours.Size = New System.Drawing.Size(100, 23)
		Me.lblHours.TabIndex = 12
		Me.lblHours.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'radProtected
		'
		Me.radProtected.AutoSize = True
		Me.radProtected.Location = New System.Drawing.Point(251, 125)
		Me.radProtected.Name = "radProtected"
		Me.radProtected.Size = New System.Drawing.Size(76, 19)
		Me.radProtected.TabIndex = 2
		Me.radProtected.TabStop = True
		Me.radProtected.Text = "Protected"
		Me.radProtected.UseVisualStyleBackColor = True
		'
		'btnSubmit
		'
		Me.btnSubmit.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue
		Me.btnSubmit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray
		Me.btnSubmit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue
		Me.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnSubmit.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnSubmit.Location = New System.Drawing.Point(128, 216)
		Me.btnSubmit.Name = "btnSubmit"
		Me.btnSubmit.Size = New System.Drawing.Size(100, 38)
		Me.btnSubmit.TabIndex = 3
		Me.btnSubmit.Text = "Submit PTO"
		Me.btnSubmit.UseVisualStyleBackColor = True
		'
		'Label7
		'
		Me.Label7.AutoSize = True
		Me.Label7.Location = New System.Drawing.Point(248, 78)
		Me.Label7.Name = "Label7"
		Me.Label7.Size = New System.Drawing.Size(59, 15)
		Me.Label7.TabIndex = 13
		Me.Label7.Text = "End Time:"
		'
		'Label6
		'
		Me.Label6.AutoSize = True
		Me.Label6.Location = New System.Drawing.Point(248, 28)
		Me.Label6.Name = "Label6"
		Me.Label6.Size = New System.Drawing.Size(63, 15)
		Me.Label6.TabIndex = 8
		Me.Label6.Text = "Start Time:"
		'
		'TextBox1
		'
		Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.TextBox1.Location = New System.Drawing.Point(37, 314)
		Me.TextBox1.Multiline = True
		Me.TextBox1.Name = "TextBox1"
		Me.TextBox1.ReadOnly = True
		Me.TextBox1.Size = New System.Drawing.Size(251, 135)
		Me.TextBox1.TabIndex = 14
		Me.TextBox1.Text = resources.GetString("TextBox1.Text")
		'
		'PictureBox1
		'
		Me.PictureBox1.Image = Global.ASDU_PTO_Tracker.My.Resources.Resources.allstateLogo
		Me.PictureBox1.Location = New System.Drawing.Point(306, -56)
		Me.PictureBox1.Name = "PictureBox1"
		Me.PictureBox1.Size = New System.Drawing.Size(500, 250)
		Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
		Me.PictureBox1.TabIndex = 7
		Me.PictureBox1.TabStop = False
		'
		'btnDelete
		'
		Me.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue
		Me.btnDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray
		Me.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue
		Me.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnDelete.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnDelete.Location = New System.Drawing.Point(1009, 134)
		Me.btnDelete.Name = "btnDelete"
		Me.btnDelete.Size = New System.Drawing.Size(100, 38)
		Me.btnDelete.TabIndex = 8
		Me.btnDelete.Text = "&Delete"
		Me.btnDelete.UseVisualStyleBackColor = True
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Location = New System.Drawing.Point(661, 134)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(96, 15)
		Me.Label2.TabIndex = 16
		Me.Label2.Text = "PTO ID Selection:"
		'
		'lblPTOID
		'
		Me.lblPTOID.AutoSize = True
		Me.lblPTOID.BackColor = System.Drawing.Color.GhostWhite
		Me.lblPTOID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.lblPTOID.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PTOBindingSource, "PTOID", True))
		Me.lblPTOID.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblPTOID.Location = New System.Drawing.Point(664, 149)
		Me.lblPTOID.MinimumSize = New System.Drawing.Size(100, 23)
		Me.lblPTOID.Name = "lblPTOID"
		Me.lblPTOID.Size = New System.Drawing.Size(100, 23)
		Me.lblPTOID.TabIndex = 16
		Me.lblPTOID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'PTOBindingSource
		'
		Me.PTOBindingSource.DataMember = "PTO"
		Me.PTOBindingSource.DataSource = Me.PTODBDataSet1
		'
		'PTODBDataSet1
		'
		Me.PTODBDataSet1.DataSetName = "PTODBDataSet"
		Me.PTODBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
		'
		'TimeBankTableAdapter
		'
		Me.TimeBankTableAdapter.ClearBeforeFill = True
		'
		'DataGridView1
		'
		Me.DataGridView1.AutoGenerateColumns = False
		Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
		Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PTOIDDataGridViewTextBoxColumn, Me.PTODateDataGridViewTextBoxColumn, Me.HoursUsedDataGridViewTextBoxColumn, Me.ProtectedTimeDataGridViewTextBoxColumn})
		Me.DataGridView1.DataSource = Me.PTOBindingSource
		Me.DataGridView1.EnableHeadersVisualStyles = False
		Me.DataGridView1.Location = New System.Drawing.Point(664, 178)
		Me.DataGridView1.Name = "DataGridView1"
		Me.DataGridView1.Size = New System.Drawing.Size(445, 271)
		Me.DataGridView1.TabIndex = 15
		'
		'PTOIDDataGridViewTextBoxColumn
		'
		Me.PTOIDDataGridViewTextBoxColumn.DataPropertyName = "PTOID"
		Me.PTOIDDataGridViewTextBoxColumn.HeaderText = "PTO ID"
		Me.PTOIDDataGridViewTextBoxColumn.Name = "PTOIDDataGridViewTextBoxColumn"
		Me.PTOIDDataGridViewTextBoxColumn.ReadOnly = True
		'
		'PTODateDataGridViewTextBoxColumn
		'
		Me.PTODateDataGridViewTextBoxColumn.DataPropertyName = "PTODate"
		Me.PTODateDataGridViewTextBoxColumn.HeaderText = "PTO Date"
		Me.PTODateDataGridViewTextBoxColumn.Name = "PTODateDataGridViewTextBoxColumn"
		'
		'HoursUsedDataGridViewTextBoxColumn
		'
		Me.HoursUsedDataGridViewTextBoxColumn.DataPropertyName = "HoursUsed"
		Me.HoursUsedDataGridViewTextBoxColumn.HeaderText = "Hours Used"
		Me.HoursUsedDataGridViewTextBoxColumn.Name = "HoursUsedDataGridViewTextBoxColumn"
		'
		'ProtectedTimeDataGridViewTextBoxColumn
		'
		Me.ProtectedTimeDataGridViewTextBoxColumn.DataPropertyName = "ProtectedTime"
		Me.ProtectedTimeDataGridViewTextBoxColumn.HeaderText = "Protected Time"
		Me.ProtectedTimeDataGridViewTextBoxColumn.Name = "ProtectedTimeDataGridViewTextBoxColumn"
		'
		'PTOTableAdapter
		'
		Me.PTOTableAdapter.ClearBeforeFill = True
		'
		'lblPTOHours
		'
		Me.lblPTOHours.AutoSize = True
		Me.lblPTOHours.BackColor = System.Drawing.Color.GhostWhite
		Me.lblPTOHours.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.lblPTOHours.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PTOBindingSource, "PTOID", True))
		Me.lblPTOHours.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblPTOHours.Location = New System.Drawing.Point(770, 149)
		Me.lblPTOHours.MinimumSize = New System.Drawing.Size(50, 23)
		Me.lblPTOHours.Name = "lblPTOHours"
		Me.lblPTOHours.Size = New System.Drawing.Size(50, 23)
		Me.lblPTOHours.TabIndex = 17
		Me.lblPTOHours.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'Label8
		'
		Me.Label8.AutoSize = True
		Me.Label8.Location = New System.Drawing.Point(767, 134)
		Me.Label8.Name = "Label8"
		Me.Label8.Size = New System.Drawing.Size(42, 15)
		Me.Label8.TabIndex = 18
		Me.Label8.Text = "Hours:"
		'
		'lblPTOProtected
		'
		Me.lblPTOProtected.AutoSize = True
		Me.lblPTOProtected.BackColor = System.Drawing.Color.GhostWhite
		Me.lblPTOProtected.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.lblPTOProtected.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PTOBindingSource, "PTOID", True))
		Me.lblPTOProtected.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblPTOProtected.Location = New System.Drawing.Point(826, 149)
		Me.lblPTOProtected.MinimumSize = New System.Drawing.Size(85, 23)
		Me.lblPTOProtected.Name = "lblPTOProtected"
		Me.lblPTOProtected.Size = New System.Drawing.Size(85, 23)
		Me.lblPTOProtected.TabIndex = 19
		Me.lblPTOProtected.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'Label11
		'
		Me.Label11.AutoSize = True
		Me.Label11.Location = New System.Drawing.Point(823, 134)
		Me.Label11.Name = "Label11"
		Me.Label11.Size = New System.Drawing.Size(61, 15)
		Me.Label11.TabIndex = 20
		Me.Label11.Text = "Protected:"
		'
		'frmMain
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.Color.White
		Me.ClientSize = New System.Drawing.Size(1139, 466)
		Me.Controls.Add(Me.Label11)
		Me.Controls.Add(Me.lblPTOProtected)
		Me.Controls.Add(Me.Label8)
		Me.Controls.Add(Me.lblPTOHours)
		Me.Controls.Add(Me.lblPTOID)
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.btnDelete)
		Me.Controls.Add(Me.DataGridView1)
		Me.Controls.Add(Me.TextBox1)
		Me.Controls.Add(Me.MenuStrip1)
		Me.Controls.Add(Me.GroupBox1)
		Me.Controls.Add(Me.GroupBox2)
		Me.Controls.Add(Me.PictureBox1)
		Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
		Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.MainMenuStrip = Me.MenuStrip1
		Me.MaximizeBox = False
		Me.Name = "frmMain"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "ASDU PTO Tracker"
		Me.MenuStrip1.ResumeLayout(False)
		Me.MenuStrip1.PerformLayout()
		CType(Me.TimeBankBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.PTODBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
		Me.GroupBox1.ResumeLayout(False)
		Me.GroupBox1.PerformLayout()
		Me.GroupBox2.ResumeLayout(False)
		Me.GroupBox2.PerformLayout()
		CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.PTOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.PTODBDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents MenuStrip1 As MenuStrip
	Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents mnuFileClear As ToolStripMenuItem
	Friend WithEvents mnuFileExit As ToolStripMenuItem
	Friend WithEvents mnuViewAbout As ToolStripMenuItem
	Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents mnuViewCalc As ToolStripMenuItem
	Friend WithEvents cboStart As ComboBox
	Friend WithEvents cboEnd As ComboBox
	Friend WithEvents txtBank As TextBox
	Friend WithEvents Label1 As Label
	Friend WithEvents lblBank As Label
	Friend WithEvents cdrTime As MonthCalendar
	Friend WithEvents PictureBox1 As PictureBox
	Friend WithEvents lblProtected As Label
	Friend WithEvents Label4 As Label
	Friend WithEvents Label5 As Label
	Friend WithEvents btnEnter As Button
	Friend WithEvents GroupBox1 As GroupBox
	Friend WithEvents GroupBox2 As GroupBox
	Friend WithEvents Label7 As Label
	Friend WithEvents Label6 As Label
	Friend WithEvents radProtected As RadioButton
	Friend WithEvents btnSubmit As Button
	Friend WithEvents TextBox1 As TextBox
	Friend WithEvents Label9 As Label
	Friend WithEvents lblHours As Label
	Friend WithEvents PTODBDataSet As PTODBDataSet
	Friend WithEvents TimeBankBindingSource As BindingSource
	Friend WithEvents TimeBankTableAdapter As PTODBDataSetTableAdapters.TimeBankTableAdapter
	Friend WithEvents btnDelete As Button
	Friend WithEvents Label2 As Label
	Friend WithEvents lblPTOID As Label
	Friend WithEvents DataGridView1 As DataGridView
	Friend WithEvents PTODBDataSet1 As PTODBDataSet
	Friend WithEvents PTOBindingSource As BindingSource
	Friend WithEvents PTOTableAdapter As PTODBDataSetTableAdapters.PTOTableAdapter
	Friend WithEvents PTOIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
	Friend WithEvents PTODateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
	Friend WithEvents HoursUsedDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
	Friend WithEvents ProtectedTimeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
	Friend WithEvents lblPTOHours As Label
	Friend WithEvents Label8 As Label
	Friend WithEvents lblPTOProtected As Label
	Friend WithEvents Label11 As Label
End Class
