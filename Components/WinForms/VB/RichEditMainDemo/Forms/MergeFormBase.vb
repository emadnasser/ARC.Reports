Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.Utils

Namespace DevExpress.XtraRichEdit.Demos.Forms
	Public Enum MergeDestination
		NewTab
		File
	End Enum
	Public Enum MergeRecords
		All
		Current
		Selected
		FromInterval
	End Enum

	Public Class MergeFieldsFormBase
		Inherits DevExpress.XtraEditors.XtraForm
		Private mergeRecords_Renamed As MergeRecords
		Private mergeDestination_Renamed As MergeDestination

		Protected Sub New()
		End Sub

		Public Property MergeDestination() As MergeDestination
			Get
				Return mergeDestination_Renamed
			End Get
			Set
				mergeDestination_Renamed = Value
			End Set
		End Property
		Public Property MergeRecords() As MergeRecords
			Get
				Return mergeRecords_Renamed
			End Get
			Set
				mergeRecords_Renamed = Value
			End Set
		End Property
	End Class
End Namespace
