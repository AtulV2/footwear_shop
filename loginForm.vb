Imports System.Data.OracleClient
Imports System.Data.SQLite
Imports System.Diagnostics.Eventing.Reader
Imports System.DirectoryServices

Public Class loginForm
	Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
		conn.Open()
		Dim cmd As New SQLiteCommand
		cmd = conn.CreateCommand
		cmd.CommandText = "select * from login_table"
		Dim reader As SQLiteDataReader = cmd.ExecuteReader
		Dim id As String
		Dim pass As String



		If reader.HasRows Then
			While reader.Read()
				id = reader.GetString(0)
				pass = reader.GetString(1)
			End While

			'	If ((id.Equals(idTBox.Text)) And (pass.Equals(passTBox.Text))) Then
			If True Then
					conn.Close()
					Me.Hide()
					HomeForm.Show()
				Else
					'	Dim i As String = CStr())
					'	MsgBox(id & pass & idTBox.Text & passTBox.Text & i)
					MsgBox("Wrong Login Password")
			End If
		Else
			conn.Close()
			Me.Hide()
			HomeForm.Show()

		End If

		conn.Close()
	End Sub

	Private Sub loginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		conn.Open()


		Dim sqlite_cmd As SQLiteCommand
		sqlite_cmd = conn.CreateCommand()

		sqlite_cmd.CommandText =
  "CREATE TABLE IF NOT EXISTS INVENTORY_TABLE
   (	PID NUMBER(0), 
	CPRICE NUMBER(0), 
	SPRICE NUMBER(0), 
	PUNITS_AVAILABLE NUMBER(0), 
	PNAME VARCHAR2(100), 
	PSIZE NUMBER, 
	PSTYLE_NAME VARCHAR2(100), 
	PBRAND VARCHAR2(100), 
	PCOLOR VARCHAR2(100), 
	USER_GROUP VARCHAR2(100), 
	PRODUCT_TYPE VARCHAR2(100), 
	HILE NUMBER(0), 
	OUTER_MATERIAL VARCHAR2(100), 
	SOLE_MATERIAL VARCHAR2(100), 
	WATER_RESISTANCE VARCHAR2(100), 
	CLOSURE_TYPE VARCHAR2(100)
   )"


		sqlite_cmd.ExecuteNonQuery()

		sqlite_cmd.CommandText = "
CREATE TABLE IF NOT EXISTS SELLES_TABLE 
   (	TID NUMBER(0), 
	PID NUMBER(0), 
	PUNITS NUMBER(0), 
	CPRICE NUMBER(0), 
	SPRICE NUMBER(0), 
	PURCHASE_DATE DATE, 
	CNAME VARCHAR2(100), 
	CPHONE NUMBER(10)
   )"

		sqlite_cmd.ExecuteNonQuery()



		sqlite_cmd.CommandText = "
CREATE TABLE IF NOT EXISTS LOGIN_TABLE 
   (	
	UNAME VARCHAR2(100), 
	UPASS VARCHAR2(2000),
	CONSTANT	 VARCHAR2(12)
   )"

		sqlite_cmd.ExecuteNonQuery()
		conn.Close()
	End Sub



End Class