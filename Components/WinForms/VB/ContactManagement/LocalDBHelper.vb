Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports DevExpress.Xpo.DB.Helpers

Namespace ContactManagement
	Public Class MSSqlLocalDB2012Helper
		Implements IDisposable
		Private localDBConnection_Renamed As String
		Public ReadOnly Property LocalDBConnection() As String
			Get
				Return localDBConnection_Renamed
			End Get
		End Property
		Private isMSSqlLocalDBApiExists As Boolean
        Public Const LocalDBInstanceName As String = "XpoDemos"
		Public Function Setup() As Boolean
			Try
				Using localdb As New MSSqlLocalDBApi()
					Dim info As MSSqlLocalDBInstanceInfo = localdb.GetInstanceInfo(LocalDBInstanceName)
					If (Not info.Exists) Then
						Dim versions() As String = localdb.GetVersions()
						Array.Sort(versions)
						localdb.CreateInstance(versions(versions.Length - 1), LocalDBInstanceName)
					End If
					If (Not info.IsRunning) Then
						localdb.StartInstance(LocalDBInstanceName, localDBConnection_Renamed)
					End If
				End Using
				isMSSqlLocalDBApiExists = True
			Catch
			End Try
			Return isMSSqlLocalDBApiExists
		End Function
		Public Sub TearDown()
			If isMSSqlLocalDBApiExists Then
				Try
					Using localdb As New MSSqlLocalDBApi()
						Dim info As MSSqlLocalDBInstanceInfo = localdb.GetInstanceInfo(LocalDBInstanceName)
						If (Not info.Exists) Then
							Return
						End If
						If info.IsRunning Then
							localdb.StopInstance(LocalDBInstanceName, MSSqlLocalDBShutdownFlags.None, 5000)
						End If
					End Using
				Catch
				End Try
			End If
		End Sub
		Private Sub Dispose() Implements IDisposable.Dispose
			TearDown()
		End Sub
	End Class
End Namespace
