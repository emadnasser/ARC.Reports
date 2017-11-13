Imports Microsoft.VisualBasic
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraReports.UI
Imports System
Imports System.Collections.Generic

Namespace PivotGridOlapBrowser.Helpers
	Public Class BrowserGrid
		Inherits GridControl
		Implements IXRControlCreatable
		Public Sub New(ByVal pivot As BrowserPivot)
			Dim mainView As New GridView()
			mainView.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
			mainView.OptionsBehavior.Editable = False
			MainView = mainView
		End Sub
		#Region "IXRControlCreatable Members"
		Public Shadows Function CreateControl() As XRControl Implements IXRControlCreatable.CreateControl
			Return XRGridEx.Create(Me)
		End Function
		#End Region
	End Class
End Namespace
