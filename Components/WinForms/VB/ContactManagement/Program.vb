Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Windows.Forms
Imports DevExpress.Xpo
Imports DevExpress.Xpo.DB

Namespace ContactManagement
	Friend NotInheritable Class Program
		Private Sub New()
		End Sub
		<STAThread> _
		Shared Sub Main(ByVal args() As String)

			Try
				Using localDBHelper As New MSSqlLocalDB2012Helper()
					Dim connectionString As String = Nothing
					If args IsNot Nothing AndAlso args.Length = 1 Then
						connectionString = args(0)
					Else
						If localDBHelper.Setup() Then
                            connectionString = MSSqlConnectionProvider.GetConnectionString(localDBHelper.LocalDBConnection, "CMDemo" & AssemblyInfo.Version)
						Else
							connectionString = InMemoryDataStore.GetConnectionString(System.IO.Path.ChangeExtension(System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, AppDomain.CurrentDomain.FriendlyName & "_DB"), "xml"))
						End If
					End If
					XpoDefault.DataLayer = XpoDefault.GetDataLayer(connectionString, AutoCreateOption.DatabaseAndSchema)
					Application.Run(New MainForm())
				End Using
			Catch e As Exception
				MessageBox.Show(e.ToString(), "ContactManagement", MessageBoxButtons.OK, MessageBoxIcon.Error)
			End Try
		End Sub

	End Class
End Namespace
