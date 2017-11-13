Imports Microsoft.VisualBasic
Imports System
Imports System.Data

Namespace DevExpress.XtraGrid.Demos.Tutorials
	Public Class FilteredDataView
		Inherits DataView
		Private fAdditionalRowFilter As String = "", fRegularRowFilter As String = ""
		Public Sub New()
		End Sub
		Public Sub New(ByVal table As DataTable)
			MyBase.New(table)
		End Sub

		Public Overridable Property AdditionalRowFilter() As String
			Get
				Return fAdditionalRowFilter
			End Get
			Set
				If Value Is Nothing Then
				Value = ""
				End If
				Value = Value.Trim()
				If Value = AdditionalRowFilter Then
				Return
				End If
				fAdditionalRowFilter = Value
				OnFilterChanged()
			End Set
		End Property
		Public Overrides Property RowFilter() As String
			Get
				Return fRegularRowFilter
			End Get
			Set
				If Value Is Nothing Then
				Value = ""
				End If
				Value = Value.Trim()
				If Value = RowFilter Then
				Return
				End If
				fRegularRowFilter = Value
				OnFilterChanged()
			End Set
		End Property
		Protected Overridable Sub OnFilterChanged()
			Dim filterString As String = RowFilter
			If RowFilter.Length > 0 AndAlso AdditionalRowFilter.Length > 0 Then
				filterString = String.Format("({0}) AND ({1})", AdditionalRowFilter, RowFilter)
			Else
				filterString = AdditionalRowFilter & RowFilter
			End If
			MyBase.RowFilter = filterString
		End Sub
	End Class
End Namespace
