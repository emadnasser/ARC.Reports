Imports Microsoft.VisualBasic
Imports System
Imports System.Linq
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports DevExpress.Web

Partial Public Class Appearance_GridLines
	Inherits Page
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		Select Case cmbGridLines.SelectedIndex
			Case 0
				treeList.Settings.GridLines = GridLines.None
			Case 1
				treeList.Settings.GridLines = GridLines.Horizontal
			Case 2
				treeList.Settings.GridLines = GridLines.Vertical
			Case 3
				treeList.Settings.GridLines = GridLines.Both
		End Select
		treeList.Settings.ShowTreeLines = chkTreeLines.Checked
		treeList.Border.BorderStyle = If(chkBorder.Checked, BorderStyle.Solid, BorderStyle.None)
		treeList.Settings.SuppressOuterGridLines = chkBorder.Checked

		infoPanel.Visible = (Not CanChangeTreeLines) OrElse Not CanChangeGridLines
		cmbGridLines.Enabled = CanChangeGridLines
		chkTreeLines.Enabled = CanChangeTreeLines
	End Sub

	Private Shared NoGridLinesThemes() As String = { "DevEx", "Office2010Blue", "Office2010Black", "Office2010Silver" }
	Private Shared NoTreeLinesThemes() As String = { "DevEx", "Metropolis", "MetropolisBlue", "Moderno", "Office2010Blue", "Office2010Black", "Office2010Silver" }
	Private ReadOnly Property CanChangeGridLines() As Boolean
		Get
			Return Not NoGridLinesThemes.Contains(ASPxWebControl.GlobalTheme)
		End Get
	End Property
	Private ReadOnly Property CanChangeTreeLines() As Boolean
		Get
			Return Not NoTreeLinesThemes.Contains(ASPxWebControl.GlobalTheme)
		End Get
	End Property
End Class
