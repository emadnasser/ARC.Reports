Imports Microsoft.VisualBasic
Imports System
Imports System.Web.UI

Partial Public Class Shaping_Export
	Inherits Page
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		If (Not IsPostBack) Then
			treeList.DataBind()
			treeList.ExpandToLevel(1)
		End If
	End Sub
	Protected Sub btnExportToPdf_Click(ByVal sender As Object, ByVal e As EventArgs)
		PrepareExporter()
		treeListExporter.WritePdfToResponse()
	End Sub
	Protected Sub btnExportToXls_Click(ByVal sender As Object, ByVal e As EventArgs)
		PrepareExporter()
		treeListExporter.WriteXlsToResponse()
	End Sub
	Protected Sub btnExportToXlsx_Click(ByVal sender As Object, ByVal e As EventArgs)
		PrepareExporter()
		treeListExporter.WriteXlsxToResponse()
	End Sub
	Protected Sub btnExportToRtf_Click(ByVal sender As Object, ByVal e As EventArgs)
		PrepareExporter()
		treeListExporter.WriteRtfToResponse()
	End Sub
	Private Sub PrepareExporter()
		treeListExporter.Settings.AutoWidth = chkAutoWidth.Checked
		treeListExporter.Settings.ExpandAllNodes = chkExpandAll.Checked
	End Sub
End Class
