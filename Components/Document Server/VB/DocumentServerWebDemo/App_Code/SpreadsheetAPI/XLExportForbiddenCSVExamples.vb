Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic

Namespace DevExpress.DXperience.Demos
	#Region "XLExportForbiddenCSVModules"
	Public NotInheritable Class XLExportForbiddenCSVExamples
		Public Shared Examples As HashSet(Of String) = CreateNonCSVExamples()
		Private Sub New()
		End Sub
		Private Shared Function CreateNonCSVExamples() As HashSet(Of String)
			Dim result As New HashSet(Of String)()
			result.Add("Create Hidden Sheet")
			result.Add("Merge Cells")
			result.Add("Predefined Formatting")
			result.Add("Themed Formatting")
			result.Add("Alignment")
			result.Add("Borders")
			result.Add("Fill")
			result.Add("Font")
			result.Add("Average Rule")
			result.Add("Cell Is Rule")
			result.Add("Blanks Rule")
			result.Add("Duplicates Rule")
			result.Add("Expression Rule")
			result.Add("Specific Text Rule")
			result.Add("Time Period Rule")
			result.Add("Top/Bottom Rules")
			result.Add("Data Bar Rule")
			result.Add("Icon Set Rule")
			result.Add("Color Scale Rule")
			result.Add("Auto Filter")
			result.Add("Group/Outline")
			result.Add("Data Validation")
			result.Add("Freeze Row")
			result.Add("Freeze Column")
			result.Add("Freeze Panes")
			result.Add("Right to Left Sheet View")
			result.Add("Headers and Footers")
			result.Add("Page Breaks")
			result.Add("Page Margins")
			result.Add("Page Setup")
			result.Add("Print Area")
			result.Add("Print Options")
			result.Add("Print Titles")
			result.Add("Hyperlinks")
			result.Add("Formulas")
			result.Add("Shared Formulas")
			result.Add("Functions")
			result.Add("Document Properties")
			result.Add("Insert Picture")
			result.Add("Stretch Picture")
			result.Add("Fit Picture")
			result.Add("Hyperlink Click")
			result.Add("Add Sparklines Group")
			result.Add("Add Sparklines")
			result.Add("Adjust Scaling")
			result.Add("Highlight Values")
			result.Add("Display XAxis")
			result.Add("Setup Date Range")
			result.Add("Add Table")
			result.Add("Disable Filtering")
			result.Add("Hidden Header Row")
			result.Add("Hidden Total Row")
			result.Add("Side by Side Tables")
			result.Add("Table Style")
			result.Add("Table Style Options")
			result.Add("Custom Formatting")
			result.Add("Calculated Column")
			Return result
		End Function
	End Class
	#End Region
	#Region "XLExportForbiddenXLSModules"
	Public NotInheritable Class XLExportForbiddenXLSExamples
		Public Shared Examples As HashSet(Of String) = CreateNonXLSExamples()
		Private Sub New()
		End Sub
		Private Shared Function CreateNonXLSExamples() As HashSet(Of String)
			Dim result As New HashSet(Of String)()
			result.Add("Add Sparklines Group")
			result.Add("Add Sparklines")
			result.Add("Adjust Scaling")
			result.Add("Highlight Values")
			result.Add("Display XAxis")
			result.Add("Setup Date Range")
			Return result
		End Function
	End Class
	#End Region
End Namespace
