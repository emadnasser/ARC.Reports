Imports Microsoft.VisualBasic
Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms
Imports System.Data
Imports DevExpress.XtraEditors.Controls
Imports System.Collections.Generic
Imports DevExpress.Utils.Menu
Imports DevExpress.Data

Namespace DevExpress.XtraPivotGrid.Demos.Modules
	Partial Public Class UnboundExpressions
		Inherits DevExpress.XtraPivotGrid.Demos.TutorialControl
		Public Sub New()
			' This call is required by the Windows Form Designer.
			CreateWaitDialog()
			InitializeComponent()

            TutorialInfo.WhatsThisCodeFile = "VB\PivotGridMainDemo\Modules\UnboundExpressions.vb"
            TutorialInfo.WhatsThisXMLFile = "UnboundExpressions.xml"
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

		Private Sub UnboundColumns_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
			pivotGridControl1.DataSource = GetNWindData("SalesPerson")
			icbSalesPerson.SelectedIndex = 0
			pivotGridControl1.HeaderImages = HeadersImageList
			fieldSalesPerson.ImageIndex = 0
			ResetFieldHeadersFont()
			pivotGridControl1.BestFit()
		End Sub

		Private Sub ResetFieldHeadersFont()
			For Each field As PivotGridField In pivotGridControl1.Fields
				If IsFieldUnboundExpression(field) Then
					field.Appearance.Header.Font = New Font(field.Appearance.Header.Font, FontStyle.Bold)
				Else
					field.Appearance.Header.Font = New Font(field.Appearance.Header.Font, FontStyle.Regular)
				End If
			Next field
		End Sub

		Private Function IsFieldValueExpression(ByVal field As PivotGridField) As Boolean
			If IsFieldUnboundExpression(field) AndAlso field.Area <> PivotArea.DataArea Then
				Return True
			End If
			Return False
		End Function

		Private Function IsFieldUnboundExpression(ByVal field As PivotGridField) As Boolean
			If field IsNot Nothing AndAlso field.UnboundType <> UnboundColumnType.Bound Then
				Return True
			End If
			Return False
		End Function

		Private Function IsFieldSummaryExpression(ByVal field As PivotGridField) As Boolean
			If IsFieldUnboundExpression(field) AndAlso field.Area = PivotArea.DataArea Then
				Return True
			End If
			Return False
		End Function

		Private hoverField_Renamed As PivotGridField
		Private Property HoverField() As PivotGridField
			Get
				Return hoverField_Renamed
			End Get
			Set(ByVal value As PivotGridField)
				If hoverField_Renamed Is value Then
					Return
				End If
				hoverField_Renamed = value
				If hoverField_Renamed Is Nothing OrElse hoverField_Renamed.Area = PivotArea.DataArea Then
					pivotGridControl1.Invalidate()
				End If
			End Set
		End Property
		Private hoverFieldValue_Renamed As Object
		Private Property HoverFieldValue() As Object
			Get
				Return hoverFieldValue_Renamed
			End Get
			Set(ByVal value As Object)
				If hoverFieldValue_Renamed Is value Then
					Return
				End If
				hoverFieldValue_Renamed = value
				pivotGridControl1.Invalidate()
			End Set
		End Property

		Private removeField_Renamed As PivotGridField
		Private Sub RemoveField(ByVal sender As Object, ByVal e As EventArgs)
			If removeField_Renamed IsNot Nothing Then
				pivotGridControl1.Fields.Remove(removeField_Renamed)
			End If
		End Sub
		'<icbSalesPerson>
		Private Sub icb_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles icbSalesPerson.SelectedIndexChanged
			fieldSalesPerson.UnboundExpression = icbSalesPerson.EditValue.ToString()
		End Sub
		'</icbSalesPerson>

		Private Sub pivotGridControl1_CustomDrawFieldValue(ByVal sender As Object, ByVal e As PivotCustomDrawFieldValueEventArgs) Handles pivotGridControl1.CustomDrawFieldValue
			If HoverField IsNot Nothing AndAlso e.Field Is HoverField AndAlso (e.Field.Area = PivotArea.DataArea OrElse e.Value Is HoverFieldValue) Then
				e.Appearance.Font = New Font(e.Appearance.Font, FontStyle.Underline)
				e.Appearance.ForeColor = Color.Red
			Else
				If IsFieldUnboundExpression(e.Field) Then
					e.Appearance.Font = New Font(e.Appearance.Font, FontStyle.Underline)
					e.Appearance.ForeColor = Color.Blue
				Else
                    e.DefaultDraw()
                End If
			End If
		End Sub

		Private Sub pivotGridControl1_MouseMove(ByVal sender As Object, ByVal e As MouseEventArgs) Handles pivotGridControl1.MouseMove
			Dim info As PivotGridHitInfo = pivotGridControl1.CalcHitInfo(New Point(e.X, e.Y))
			If info.ValueInfo IsNot Nothing AndAlso IsFieldUnboundExpression(info.ValueInfo.Field) Then
				HoverField = info.ValueInfo.Field
				If HoverField.Area = PivotArea.RowArea Then
					HoverFieldValue = info.ValueInfo.Value
				Else
					HoverFieldValue = Nothing
				End If
				pivotGridControl1.Cursor = Cursors.Hand
			Else
				HoverField = Nothing
				HoverFieldValue = Nothing
				pivotGridControl1.Cursor = Cursors.Default
			End If
		End Sub

		Private Sub pivotGridControl1_MouseClick(ByVal sender As Object, ByVal e As MouseEventArgs) Handles pivotGridControl1.MouseClick
			If e.Button <> MouseButtons.Left Then
				Return
			End If
			Dim info As PivotGridHitInfo = pivotGridControl1.CalcHitInfo(New Point(e.X, e.Y))
			If info.ValueInfo IsNot Nothing AndAlso IsFieldUnboundExpression(info.ValueInfo.Field) Then
				pivotGridControl1.ShowUnboundExpressionEditor(info.ValueInfo.Field)
			End If
		End Sub

		Private Sub pivotGridControl1_PopupMenuShowing(ByVal sender As Object, ByVal e As PopupMenuShowingEventArgs) Handles pivotGridControl1.PopupMenuShowing
			If e.HitInfo.ValueInfo IsNot Nothing AndAlso IsFieldSummaryExpression(e.HitInfo.ValueInfo.Field) Then
				removeField_Renamed = e.HitInfo.ValueInfo.Field
				Dim item As New DXMenuItem("Remove this bonus", AddressOf RemoveField)
				item.BeginGroup = True
				e.Menu.Items.Add(item)
			End If
		End Sub

		Private Sub pivotGridControl1_FieldUnboundExpressionChanged(ByVal sender As Object, ByVal e As PivotFieldEventArgs) Handles pivotGridControl1.FieldUnboundExpressionChanged
			e.Field.BestFit()
		End Sub
		'<btnAddBonus>
		Private Sub btnAddBonus_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnAddBonus.Click
			Using addNewBonus As New AddNewBonus()
				addNewBonus.PivotGrid = pivotGridControl1
				If addNewBonus.ShowDialog() = DialogResult.OK Then

				End If
			End Using
		End Sub
		'</btnAddBonus>
	End Class
End Namespace

