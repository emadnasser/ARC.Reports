Imports Microsoft.VisualBasic
Imports DevExpress.Data.PivotGrid
Imports DevExpress.Utils
Imports DevExpress.XtraEditors.Controls
Imports System
Imports System.Collections
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms

Namespace DevExpress.XtraPivotGrid.Demos.Modules
	Partial Public Class SingleTotal
		Inherits DevExpress.XtraPivotGrid.Demos.TutorialControl
		Public Sub New()
			' This call is required by the Windows Form Designer.
			CreateWaitDialog()
			InitializeComponent()

            TutorialInfo.WhatsThisCodeFile = "VB\PivotGridMainDemo\Modules\SingleTotal.vb"
            TutorialInfo.WhatsThisXMLFile = "SingleTotal.xml"

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

		Private Sub SingleTotal_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
			pivotGridControl1.DataSource = GetNWindData("SalesPerson")
			fieldYear.FilterValues.FilterType = PivotFilterType.Included
            fieldYear.FilterValues.Add(2015)
			fieldCategoryName.FilterValues.FilterType = PivotFilterType.Included
			fieldCategoryName.FilterValues.Add("Beverages")
			fieldCategoryName.FilterValues.Add("Condiments")
			InitComboBoxes()
			AddOptions()
			pivotGridControl1.ValueImages = CategoryImageList
			UpdateListBoxColor(clbOptions)
			AddHandler (CType(RibbonMenuManager, PivotGridRibbonMenuManager)).ViewOptionsChanged, AddressOf OnRibbonViewOptionsChanged
		End Sub

		Protected Overrides Sub OnStyleChanged()
			MyBase.OnStyleChanged()
			UpdateListBoxColor(clbOptions)
		End Sub

		Private Sub InitComboBoxes()
			icbSummaryType.Properties.Items.AddEnum(GetType(PivotSummaryType))
			For Each field As PivotGridField In pivotGridControl1.Fields
				If field.Area = PivotArea.DataArea AndAlso field.Visible Then
					icbField.Properties.Items.Add(New ImageComboBoxItem(field.Caption.ToString(), field, -1))
				End If
			Next field
			icbField.SelectedIndex = 0
		End Sub
		'<clbOptions>
		Private Sub AddOptions()
			Dim excludedOptions As New List(Of String)(New String() { "ShowCustomTotalsForSingleValues" })
			Dim arr As New ArrayList()
			Dim pds As PropertyDescriptorCollection = TypeDescriptor.GetProperties(pivotGridControl1.OptionsView)
			For Each pd As PropertyDescriptor In pds
				If pd.PropertyType.Equals(GetType(Boolean)) AndAlso pd.Name.IndexOf("Total") > -1 AndAlso (Not excludedOptions.Contains(pd.Name)) Then
					arr.Add(pd.Name)
				End If
			Next pd
			arr.Sort()
			clbOptions.DataSource = arr
			For i As Integer = 0 To clbOptions.ItemCount - 1
				clbOptions.SetItemChecked(i, SetOptions.OptionValueByString(clbOptions.GetItemText(i), pivotGridControl1.OptionsView))
			Next i
		End Sub
		Private Sub OnRibbonViewOptionsChanged(ByVal s As Object, ByVal arg As DevExpress.XtraPivotGrid.Demos.ViewOptionsChangedEventArgs)
            If (CType(RibbonMenuManager, PivotGridRibbonMenuManager)).PivotGrid IsNot pivotGridControl1 Then
                Return
            End If
			For i As Integer = 0 To clbOptions.ItemCount - 1
				If clbOptions.GetItemText(i) = arg.Name Then
					clbOptions.SetItemChecked(i, arg.Value)
					Return
				End If
			Next i
		End Sub
		Private Sub clbOptions_ItemCheck(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ItemCheckEventArgs) Handles clbOptions.ItemCheck
			SetOptions.SetOptionValueByString(clbOptions.GetItemText(e.Index), pivotGridControl1.OptionsView, e.State = CheckState.Checked)
			CType(RibbonMenuManager, PivotGridRibbonMenuManager).RefreshOptionsMenu(pivotGridControl1)
		End Sub
		'</clbOptions>
		'<icbField>
		Private Sub icbField_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles icbField.SelectedIndexChanged
			Dim field As PivotGridField = TryCast(icbField.EditValue, PivotGridField)
			If field Is Nothing Then
				Return
			End If
			icbSummaryType.EditValue = field.SummaryType
			SetFieldFont(field)
			field.Appearance.ValueTotal.BackColor = Color.LightSkyBlue
		End Sub
		Private Sub SetFieldFont(ByVal field As PivotGridField)
			For Each fld As PivotGridField In pivotGridControl1.Fields
				If fld IsNot field Then
					If fld.Appearance.Header.Font.Bold Then
						fld.Appearance.Header.Font = New Font(fld.Appearance.Header.Font, FontStyle.Regular)
					End If
				Else
					fld.Appearance.Header.Font = New Font(fld.Appearance.Header.Font, FontStyle.Bold)
				End If
			Next fld
		End Sub
		'</icbField>
		'<icbSummaryType>
		Private Sub icbSummaryType_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles icbSummaryType.SelectedIndexChanged
			Dim field As PivotGridField = TryCast(icbField.EditValue, PivotGridField)
			If field Is Nothing Then
				Return
			End If
			field.SummaryType = CType(icbSummaryType.EditValue, PivotSummaryType)
			CorrectCellFormat(field)
		End Sub
		Private Sub CorrectCellFormat(ByVal field As PivotGridField)
			Select Case field.SummaryType
				Case PivotSummaryType.Average, PivotSummaryType.Max, PivotSummaryType.Min, PivotSummaryType.Sum, PivotSummaryType.Custom, PivotSummaryType.StdDev, PivotSummaryType.StdDevp
					If field Is fieldDiscount Then
						field.CellFormat.FormatString = "p"
					ElseIf field Is fieldQuantity Then
						field.CellFormat.FormatString = "n0"
					Else
						field.CellFormat.FormatString = "c2"
					End If
				Case PivotSummaryType.Count, PivotSummaryType.Var, PivotSummaryType.Varp
					field.CellFormat.FormatString = "n0"
				Case Else
					Throw New ArgumentException("Incorrect SummaryType")
			End Select
		End Sub
		'</icbSummaryType>
		Private Sub pivotGridControl1_CustomDrawFieldHeader(ByVal sender As Object, ByVal e As DevExpress.XtraPivotGrid.PivotCustomDrawFieldHeaderEventArgs) Handles pivotGridControl1.CustomDrawFieldHeader
			If e.Field.Area = PivotArea.DataArea Then
				e.Appearance.ForeColor = Blue
			End If
			If e.Field.Caption = "Data" Then
				e.Appearance.ForeColor = Red
			End If
		End Sub

		Private Sub pivotGridControl1_FieldValueImageIndex(ByVal sender As Object, ByVal e As DevExpress.XtraPivotGrid.PivotFieldImageIndexEventArgs) Handles pivotGridControl1.FieldValueImageIndex
			If e.Field Is fieldCategoryName AndAlso Comparer.Equals(e.ValueType, PivotGridValueType.Value) Then
				e.ImageIndex = GetCategoryIndexByName(e.Value)
			End If
		End Sub

		Protected Overrides Sub OnSetCaption(ByVal fCaption As String)
			Caption.Text = "Single Total (Automatic Totals)"
		End Sub
		'Custom total - percent of max value in sum
		Private Sub pivotGridControl1_CustomSummary(ByVal sender As Object, ByVal e As PivotGridCustomSummaryEventArgs) Handles pivotGridControl1.CustomSummary
			Dim ds As PivotDrillDownDataSource = e.CreateDrillDownDataSource()
			Dim max As Decimal = 0, sum As Decimal = 0
			For Each row As PivotDrillDownDataRow In ds
				Dim value As Decimal = Convert.ToDecimal(row(e.DataField))
				max = If(max < value, value, max)
				sum += value
			Next row
			If sum <> 0 Then
				e.CustomValue = max / sum * 100
			Else
				e.CustomValue = ""
			End If
		End Sub
	End Class
End Namespace

