Imports Microsoft.VisualBasic
Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.Data.PivotGrid

Namespace DevExpress.XtraPivotGrid.Demos.Modules
	Partial Public Class Groups
		Inherits DevExpress.XtraPivotGrid.Demos.TutorialControl
		Public Sub New()
			' This call is required by the Windows Form Designer.
			CreateWaitDialog()
			InitializeComponent()

            TutorialInfo.WhatsThisCodeFile = "VB\PivotGridMainDemo\Modules\Groups.vb"
            TutorialInfo.WhatsThisXMLFile = "Groups.xml"

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
		Private groupColors() As Color

		'<pivotGridControl1>
		Private Sub Groups_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
			UpdateGroupColors()
			pivotGridControl1.DataSource = GetNWindData("SalesPerson")
			pivotGridControl1.HeaderImages = HeadersImageList
			pivotGridControl1.ValueImages = CategoryImageList
			fieldExtendedPrice.ImageIndex = 3
			fieldOrderDate1.ExpandedInFieldsGroup = False
			fieldExtendedPrice.ExpandedInFieldsGroup = False
			SetText((Not isExpanded))
		End Sub

		Private Sub UpdateGroupColors()
			Me.groupColors = New Color() { Green, Blue, Red }
		End Sub

		Private Sub pivotGridControl1_FieldValueImageIndex(ByVal sender As Object, ByVal e As DevExpress.XtraPivotGrid.PivotFieldImageIndexEventArgs) Handles pivotGridControl1.FieldValueImageIndex
			If e.Field Is fieldCategoryName AndAlso Comparer.Equals(e.ValueType, PivotGridValueType.Value) Then
				e.ImageIndex = GetCategoryIndexByName(e.Value)
			End If
		End Sub
		'</pivotGridControl1>

		'<sbExpandCollapse>
		Private Sub GroupsExpandCollapse(ByVal expand As Boolean)
			pivotGridControl1.BeginUpdate()
			Try
				For Each group As PivotGridGroup In pivotGridControl1.Groups
					For Each field As PivotGridField In group
						field.ExpandedInFieldsGroup = expand
					Next field
				Next group
			Finally
				pivotGridControl1.EndUpdate()
			End Try
		End Sub

		Private isExpanded As Boolean = True
		Private Sub sbExpand_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles sbExpandCollapse.Click
			isExpanded = Not isExpanded
			SetText((Not isExpanded))
			GroupsExpandCollapse(isExpanded)
		End Sub

		Private Sub SetText(ByVal expand As Boolean)
			If expand Then
				sbExpandCollapse.Text = "Expand All Groups"
			Else
				sbExpandCollapse.Text = "Collapse All Groups"
			End If
		End Sub
		'</sbExpandCollapse>

		Private Sub pivotGridControl1_CustomDrawFieldHeader(ByVal sender As Object, ByVal e As DevExpress.XtraPivotGrid.PivotCustomDrawFieldHeaderEventArgs) Handles pivotGridControl1.CustomDrawFieldHeader
			e.Appearance.ForeColor = groupColors(e.Field.Group.Index)
		End Sub

		Protected Overrides Sub OnStyleChanged()
			MyBase.OnStyleChanged()
			UpdateGroupColors()
		End Sub
	End Class
End Namespace

