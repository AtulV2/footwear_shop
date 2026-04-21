'Imports System.Data.SQLite

'Module Module1


'    Public Class Form1
'        Dim sqlite_conn As SQLiteConnection = New SQLiteConnection("Data Source=database.sqlite;Version=3;")
'        Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
'            sqlite_conn.Open()
'            Dim sqlite_cmd As SQLiteCommand
'            sqlite_cmd = sqlite_conn.CreateCommand()

'            sqlite_cmd.CommandText =
'  "CREATE TABLE IF NOT EXISTS  [Mytable] (
'  [Id]     INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,
'  [NAME]   NVARCHAR(2048) NULL)"


'            sqlite_cmd.ExecuteNonQuery()

'            sqlite_conn.Close()
'        End Sub

'        Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
'            Dim sqlite_cmd As SQLiteCommand
'            sqlite_conn.Open()

'            sqlite_cmd = sqlite_conn.CreateCommand()

'            sqlite_cmd.CommandText = "INSERT INTO Mytable (Id, NAME) VALUES (1, 'Hello World');"
'            sqlite_cmd.ExecuteNonQuery()
'            sqlite_conn.Close()

'        End Sub

'        Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
'            Dim sqlite_cmd As SQLiteCommand
'            Dim sqlite_datareader As SQLiteDataReader
'            sqlite_conn.Open()
'            sqlite_cmd = sqlite_conn.CreateCommand()

'            sqlite_cmd.CommandText = "SELECT * FROM Mytable"
'            sqlite_datareader = sqlite_cmd.ExecuteReader()


'            While sqlite_datareader.Read()


'                Dim idReader As String
'                Dim textReader As String

'                idReader = sqlite_datareader.GetValue(0)
'                textReader = sqlite_datareader.GetString(1)

'                ' OutputTextBox.Text = OutputTextBox.Text + idReader + " '" + textReader + "' " + Environment.NewLine
'            End While

'            sqlite_conn.Close()
'        End Sub
'    End Class

'End Module
