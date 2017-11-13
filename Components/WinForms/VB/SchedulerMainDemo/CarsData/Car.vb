Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel.DataAnnotations
Imports System.Linq
Imports System.Text

Namespace DevExpress.XtraScheduler.Demos
	Public Class Car
		Public Sub New(ByVal carId As Integer, ByVal caption As String)
			Id = carId
			Caption = caption
		End Sub

		<Key> _
		Public Property Id() As Int32
		Public Property Caption() As String
	End Class
End Namespace
