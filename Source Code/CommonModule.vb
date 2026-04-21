'Imports Oracle.ManagedDataAccess.Client
Imports System.Data.SQLite
Module CommonModule
    ' Public cnn As New OracleConnection("DATA SOURCE=mydell:1521;USER ID=fsims;PASSWORD=fsims")
    Public conn As SQLiteConnection = New SQLiteConnection("Data Source=database.fsims;Version=3;")



End Module






