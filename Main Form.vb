Imports System.Data.SqlClient
Public Class frmMain
	'Declare a subfunction to add Bank and Protected values into the TimeBank table.
	Private Sub UpdatePTOHours()
		'Declare double variables 
		Dim dblProtected = CDbl(lblProtected.Text)
		Dim dblBank = CDbl(lblBank.Text)
		Dim query As String = String.Empty
		query &= "UPDATE TimeBank SET BANK = @Bank, Protected = @Protected"

		Using conn As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\PTODB.mdf;Integrated Security=True;Connect Timeout=30")
			Using comm As New SqlCommand()
				With comm
					.Connection = conn
					.CommandType = CommandType.Text
					.CommandText = query
					.Parameters.AddWithValue("@Bank", dblBank)
					.Parameters.AddWithValue("@Protected", dblProtected)
				End With
				Try
					conn.Open()
					comm.ExecuteNonQuery()
				Catch ex As SqlException
					MessageBox.Show(ex.Message.ToString(), "Your entry did not record correctly.")
				End Try
			End Using
		End Using
	End Sub

	'Declare a subfunction to add Bank and Protected values into the TimeBank table.
	Private Sub AddPTOHours()
		'Declare double variables 
		Dim dblProtected = CDbl(lblProtected.Text)
		Dim dblBank = CDbl(lblBank.Text)
		Dim query As String = String.Empty
		query &= "INSERT INTO TimeBank (Bank, Protected) VALUES (@Bank, @Protected)"

		Using conn As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\PTODB.mdf;Integrated Security=True;Connect Timeout=30")
			Using comm As New SqlCommand()
				With comm
					.Connection = conn
					.CommandType = CommandType.Text
					.CommandText = query
					.Parameters.AddWithValue("@Bank", dblBank)
					.Parameters.AddWithValue("@Protected", dblProtected)
				End With
				Try
					conn.Open()
					comm.ExecuteNonQuery()
				Catch ex As SqlException
					MessageBox.Show(ex.Message.ToString(), "Your entry did not record correctly.")
				End Try
			End Using
		End Using
	End Sub

	'Declare a subfunction to add Bank and Protected values into the TimeBank table.
	Private Sub AddPTODates()
		'Declare variables for the duration
		Dim calendar = CDate(cdrTime.SelectionRange.Start.ToShortDateString)
		Dim ptoHours = CDbl(lblHours.Text)
		Dim ptoProtected As Boolean
		Dim ptoProtected1 As String

		If radProtected.Checked Then
			ptoProtected = True
			ptoProtected1 = "Protected"
		Else
			ptoProtected = False
			ptoProtected1 = "Not Protected"
		End If

		Dim query As String = String.Empty
		query &= "INSERT INTO PTO (PTODate, HoursUsed, ProtectedTime) VALUES (@PTODate, @HoursUsed, @ProtectedTime)"
		Using conn As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\PTODB.mdf;Integrated Security=True;Connect Timeout=30")
			Using comm As New SqlCommand()
				With comm
					.Connection = conn
					.CommandType = CommandType.Text
					.CommandText = query
					.Parameters.AddWithValue("@PTODate", calendar)
					.Parameters.AddWithValue("@HoursUsed", ptoHours)
					.Parameters.AddWithValue("@ProtectedTime", ptoProtected1)
				End With
				Try
					conn.Open()
					comm.ExecuteNonQuery()
					Me.PTOTableAdapter.Fill(Me.PTODBDataSet.PTO)
				Catch ex As SqlException
					MessageBox.Show(ex.Message.ToString(), "Your entry did not record correctly.")
				End Try
			End Using
		End Using
	End Sub

	'Declare a subfunction to Delete the selected record from the PTO table.
	Private Sub DeletePTODay()
		'Declare double variables 
		Dim strID As String = CStr(lblPTOID.Text)
		Dim query As String = String.Empty
		query &= "DELETE FROM PTO WHERE PTOID = @PTOID"

		Using conn As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\PTODB.mdf;Integrated Security=True;Connect Timeout=30")
			Using comm As New SqlCommand()
				With comm
					.Connection = conn
					.CommandType = CommandType.Text
					.CommandText = query
					.Parameters.AddWithValue("@PTOID", strID)
				End With
				Try
					conn.Open()
					comm.ExecuteNonQuery()
					Me.PTOTableAdapter.Fill(Me.PTODBDataSet1.PTO)
				Catch ex As SqlException
					MessageBox.Show(ex.Message.ToString(), "Your entry was not deleted correctly.")
				End Try
			End Using
		End Using
	End Sub

	'Declare a subfunction to Delete all records from the TimeBank table.
	Private Sub DeletePTOHours()
		'Declare double variables 
		Dim dblProtected = CDbl(lblProtected.Text)
		Dim dblBank = CDbl(lblBank.Text)
		Dim query As String = String.Empty
		query &= "DELETE FROM TimeBank"

		Using conn As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\PTODB.mdf;Integrated Security=True;Connect Timeout=30")
			Using comm As New SqlCommand()
				With comm
					.Connection = conn
					.CommandType = CommandType.Text
					.CommandText = query
				End With
				Try
					conn.Open()
					comm.ExecuteNonQuery()
				Catch ex As SqlException
					MessageBox.Show(ex.Message.ToString(), "Your entry was not deleted correctly.")
				End Try
			End Using
		End Using
	End Sub

	Private Sub DisplayPTO()
		Dim str As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\PTODB.mdf;Integrated Security=True;Connect Timeout=30"
		Dim conn As New SqlConnection(str)

		'Retrieve the PTO Hours from the database and display them in the appropriate labels (this is used on Form Load event).
		Try
			conn.Open()
			Dim query As String = String.Empty
			query &= "SELECT Bank, Protected FROM Timebank"

			Dim cmd As New SqlCommand(query, conn)
			Dim myReader As SqlDataReader = cmd.ExecuteReader()

			While myReader.Read
				lblBank.Text = myReader("Bank").ToString
				lblProtected.Text = myReader("Protected").ToString
			End While
		Catch ex As SqlException
			MsgBox(ex.ToString)
		Finally
			conn.Close()
		End Try
	End Sub

	Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		'TODO: This line of code loads data into the 'PTODBDataSet1.PTO' table. You can move, or remove it, as needed.
		Me.PTOTableAdapter.Fill(Me.PTODBDataSet1.PTO)
		Me.PTOTableAdapter.Fill(Me.PTODBDataSet.PTO)
		Me.TimeBankTableAdapter.Fill(Me.PTODBDataSet.TimeBank)
		DisplayPTO()

		cdrTime.SelectionRange.Start.ToShortDateString()

		'Assign the 64 protected hours a variable and input it into the label on form load.
		If lblProtected.Text = "" Then
			lblProtected.Text = 64
		End If

		'Check to see if the user has already entered time into the bank, if so then lock the controls to enter PTO hours.
		If lblBank.Text = "" Then
			txtBank.Enabled = True
			btnEnter.Enabled = True
		Else
			txtBank.Enabled = False
			btnEnter.Enabled = False
		End If

		'Change the column colors of the PTO datagrid.
		DataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.SteelBlue
		DataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White

	End Sub

	Private Sub mnuFileClear_Click(sender As Object, e As EventArgs) Handles mnuFileClear.Click
		'Use the DeletePTOHours subfunction to remove all PTO hours from the TimeBank table.
		DeletePTOHours()

		'Unlock the necessary objects so that a user can input PTO hours again.
		txtBank.Enabled = True
		btnEnter.Enabled = True
		lblBank.ResetText()
		lblProtected.Text = 64
		MessageBox.Show("PTO Bank has been deleted and hours can be entered again.")

	End Sub

	Private Sub mnuViewCalc_Click(sender As Object, e As EventArgs) Handles mnuViewCalc.Click
		'Open the Windows calculator for help with calculating how many days are left with the PTO available.
		Shell("C:\Windows\system32\calc.exe")
	End Sub

	Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
		'Show the about form.
		frmAbout.Show()
	End Sub

	Private Sub mnuFileExit_Click(sender As Object, e As EventArgs) Handles mnuFileExit.Click
		'Close the program upon clicking the mnuFileExit button.
		Me.Close()
	End Sub

	Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click
		'Declare the variables used for the PTO Bank.
		Dim strBank As String = txtBank.Text
		Dim dblBank As Double

		If strBank = "" Then
			MessageBox.Show("You must enter time into the PTO Bank.")
		Else
			dblBank = strBank
			lblBank.Text = dblBank
			txtBank.Enabled = False
			btnEnter.Enabled = False
			AddPTOHours()
			Me.TimeBankTableAdapter.Fill(Me.PTODBDataSet.TimeBank)
			MessageBox.Show("PTO hours entered successfully!")
		End If

	End Sub

	Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
		'Declare variables to assess how many PTO hours were used.
		Dim startTime As DateTime = cboStart.SelectedItem
		Dim endTime As DateTime = cboEnd.SelectedItem
		Dim duration As TimeSpan

		If cboStart.Text = "" Or cboEnd.Text = "" Then
			MessageBox.Show("You must entered a start and end time.")
		Else
			'Calculate the difference between the beginning and end times.
			duration = endTime - startTime
			lblHours.Text = duration.TotalHours
			lblBank.Text -= lblHours.Text

			'If the radio button for Protected time is selected then reduce the Protected Label.
			If radProtected.Checked Then
				lblProtected.Text -= lblHours.Text
			End If

			'Use UpdatePTOHours and AddPTODates subfunctions to update the values in the PTO table.
			UpdatePTOHours()
			AddPTODates()
			Me.PTOTableAdapter.Fill(Me.PTODBDataSet1.PTO)
			radProtected.Checked = False
		End If

	End Sub

	Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
		'Declare variable to be used to hold the PTO hours to be added back to the bank when a day/hours are deleted.
		Dim dblBankAdjustment = CDbl(lblPTOHours.Text)

		'Verify if the time was protected or not and adjust each bank accordingly.
		If lblPTOProtected.Text = "Protected" Then
			lblBank.Text += dblBankAdjustment
			lblProtected.Text += dblBankAdjustment
		Else
			lblBank.Text += dblBankAdjustment
		End If

		'Update the PTO hours in the database and delete the selected PTO day.
		UpdatePTOHours()
		DeletePTODay()


	End Sub
End Class
