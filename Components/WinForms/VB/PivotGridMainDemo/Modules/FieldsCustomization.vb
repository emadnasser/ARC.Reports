Imports Microsoft.VisualBasic
Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.Data.PivotGrid
Imports DevExpress.XtraPivotGrid.Customization
Imports System.Collections.Generic

Namespace DevExpress.XtraPivotGrid.Demos.Modules
	Partial Public Class FieldsCustomization
		Inherits DevExpress.XtraPivotGrid.Demos.TutorialControl
		Public Sub New()
			' This call is required by the Windows Form Designer.
			CreateWaitDialog()
			InitializeComponent()

            TutorialInfo.WhatsThisCodeFile = "VB\PivotGridMainDemo\Modules\FieldsCustomization.vb"
            TutorialInfo.WhatsThisXMLFile = "FieldsCustomization.xml"

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

		Private showCustomization As Boolean = False
		Private Sub FieldsCustomization_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
			pivotGridControl1.DataSource = GetNWindData("SalesPerson")
			InitComboBoxes()
			pivotGridControl1.ValueImages = CategoryImageList
			pivotGridControl1.HeaderImages = HeadersImageList
			fieldSalesPerson.ImageIndex = 0
			fieldOrderID.ImageIndex = 1
		End Sub

		Private Sub InitComboBoxes()
			icbHideFields.Properties.Items.AddEnum(GetType(AllowHideFieldsType))
			icbHideFields.EditValue = pivotGridControl1.OptionsCustomization.AllowHideFields

			icbCustomizationStyle.Properties.Items.AddEnum(GetType(CustomizationFormStyle))
			icbCustomizationStyle.EditValue = pivotGridControl1.OptionsCustomization.CustomizationFormStyle
		End Sub

		Protected Overrides Sub DoShow()
			pivotGridControl1.FieldsCustomization(pivotGridControl1.PointToScreen(New Point(Width - 100, 0)))
		End Sub


		Private Sub InitCustomization(ByVal show As Boolean)
			showCustomization = show
			sbCustomizationForm.Text = If(showCustomization, "Hide Customization Form", "Show Customization Form")
		End Sub

		Private Sub pivotGridControl1_ShowCustomizationForm(ByVal sender As Object, ByVal e As System.EventArgs) Handles pivotGridControl1.ShowCustomizationForm
			InitCustomization(True)
		End Sub

		Private Sub pivotGridControl1_HideCustomizationForm(ByVal sender As Object, ByVal e As System.EventArgs) Handles pivotGridControl1.HideCustomizationForm
			InitCustomization(False)
		End Sub

		'<sbCustomizationForm>
		Private Sub sbCustomizationForm_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles sbCustomizationForm.Click
			If showCustomization Then
				pivotGridControl1.DestroyCustomization()
			Else
				pivotGridControl1.FieldsCustomization()
			End If
		End Sub
		'</sbCustomizationForm>

		Private Sub pivotGridControl1_FieldValueImageIndex(ByVal sender As Object, ByVal e As DevExpress.XtraPivotGrid.PivotFieldImageIndexEventArgs) Handles pivotGridControl1.FieldValueImageIndex
			If e.Field Is fieldCategoryName AndAlso Comparer.Equals(e.ValueType, PivotGridValueType.Value) Then
				e.ImageIndex = GetCategoryIndexByName(e.Value)
			End If
		End Sub

		'<icbHideFields>
		Private Sub icbHideFields_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles icbHideFields.SelectedIndexChanged
			pivotGridControl1.OptionsCustomization.AllowHideFields = CType(icbHideFields.EditValue, AllowHideFieldsType)
		End Sub
		'</icbHideFields>

		'<icbCustomizationStyle>
		Private Sub icbCustomizationStyle_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles icbCustomizationStyle.SelectedIndexChanged
			pivotGridControl1.OptionsCustomization.CustomizationFormStyle = CType(icbCustomizationStyle.EditValue, CustomizationFormStyle)
			If showCustomization Then
				pivotGridControl1.DestroyCustomization()
				Dim showPoint As Point = pivotGridControl1.CustomizationFormBounds.Location
				pivotGridControl1.FieldsCustomization(showPoint)
			End If
		End Sub
		'</icbCustomizationStyle>
	End Class
End Namespace

