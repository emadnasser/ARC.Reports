Imports Microsoft.VisualBasic
Imports System
Imports System.ComponentModel.DataAnnotations

Namespace DevExpress.XtraScheduler.Demos
	Public Class Patient
		<Key> _
		Public Property Id() As Int64
		Public Property Name() As String
		Public Property Birthday() As DateTime
		Public Property Phone() As String
	End Class
End Namespace
