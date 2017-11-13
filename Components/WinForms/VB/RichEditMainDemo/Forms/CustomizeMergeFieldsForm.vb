Imports Microsoft.VisualBasic
Imports System
Imports System.Windows.Forms
Imports System.Drawing
Imports DevExpress.XtraRichEdit.API.Native
Imports DevExpress.XtraEditors.Repository

Namespace DevExpress.XtraRichEdit.Demos.Forms
	Partial Public Class CustomizeMergeFieldsForm
		Inherits DevExpress.XtraEditors.XtraForm
		Public Sub New(ByVal mergeFieldsNames() As MergeFieldNameInfo)
			InitializeComponent()

			gridControl1.DataSource = mergeFieldsNames

			Dim item As New RepositoryItemCheckEdit()
			gridControl1.RepositoryItems.Add(item)
			gridView1.Columns(0).ColumnEdit = item
		End Sub

		Private Sub btnOk_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnOk.Click
			Me.Close()
		End Sub
	End Class
End Namespace


