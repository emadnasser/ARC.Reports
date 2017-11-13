Imports Microsoft.VisualBasic
Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.Data.PivotGrid

Namespace DevExpress.XtraPivotGrid.Demos.Modules
	Partial Public Class HitInfo
		Inherits DevExpress.XtraPivotGrid.Demos.TutorialControl
		Public Sub New()
			' This call is required by the Windows Form Designer.
			CreateWaitDialog()
			InitializeComponent()

            TutorialInfo.WhatsThisCodeFile = "VB\PivotGridMainDemo\Modules\HitInfo.vb"
            TutorialInfo.WhatsThisXMLFile = "HitInfo.xml"

			' TODO: Add any initialization after the InitializeComponent call
		End Sub

		Public Overrides ReadOnly Property ViewOptionsControl() As PivotGridControl
			Get
				Return pivotGridControl1
			End Get
		End Property
		Public Overrides ReadOnly Property ExportControl() As PivotGridControl
			Get
				Return pivotGridControl1
			End Get
		End Property

		Private Sub HitInfo_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
			pivotGridControl1.DataSource = GetNWindData("SalesPerson")
			pivotGridControl1.HeaderImages = HeadersImageList
			pivotGridControl1.ValueImages = CategoryImageList
			fieldSalesPerson.ImageIndex = 0
			fieldCountry.CollapseValue("UK")
			cellInfo1.Dock = DockStyle.Fill
			valueInfo1.Dock = DockStyle.Fill
			headersAreaInfo1.Dock = DockStyle.Fill
			ShowHitInfo(Nothing)
		End Sub


		Private Sub pivotGridControl1_FieldValueImageIndex(ByVal sender As Object, ByVal e As DevExpress.XtraPivotGrid.PivotFieldImageIndexEventArgs) Handles pivotGridControl1.FieldValueImageIndex
			If e.Field Is fieldCategoryName AndAlso Comparer.Equals(e.ValueType, PivotGridValueType.Value) Then
				e.ImageIndex = GetCategoryIndexByName(e.Value)
			End If
		End Sub

		'<pivotGridControl1>
		Private Sub pivotGridControl1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pivotGridControl1.MouseMove
			ShowHitInfo(pivotGridControl1.CalcHitInfo(New Point(e.X, e.Y)))
		End Sub

		Private Sub pivotGridControl1_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles pivotGridControl1.MouseLeave
			ShowHitInfo(pivotGridControl1.CalcHitInfo(New Point(-1, -1)))
		End Sub

		'<panelControl1>
		Private Sub ShowHitInfo(ByVal info As PivotGridHitInfo)
			cellInfo1.Init(info)
			valueInfo1.Init(info)
			headersAreaInfo1.Init(info)
			If info Is Nothing Then
				Return
			End If
			lbHitTest.Text = info.HitTest.ToString()
		End Sub
		'</panelControl1>
		'</pivotGridControl1>

		Private Sub paddingPanel_Paint(ByVal sender As Object, ByVal e As PaintEventArgs) Handles paddingPanel.Paint

		End Sub
	End Class
End Namespace

