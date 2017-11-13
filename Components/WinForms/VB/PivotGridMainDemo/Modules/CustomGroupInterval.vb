Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms

Namespace DevExpress.XtraPivotGrid.Demos.Modules
	Partial Public Class CustomGroupInterval
		Inherits TutorialControl
		Public Sub New()
			CreateWaitDialog()
			InitializeComponent()

            TutorialInfo.WhatsThisCodeFile = "VB\PivotGridMainDemo\Modules\CustomGroupInterval.vb"
            TutorialInfo.WhatsThisXMLFile = "CustomGroupInterval.xml"
		End Sub
		Public Overrides ReadOnly Property ViewOptionsControl() As PivotGridControl
			Get
				Return pivotGridControl
			End Get
		End Property
		Public Overrides ReadOnly Property ExportControl() As PivotGridControl
			Get
				Return pivotGridControl
			End Get
		End Property
		Protected Overrides Sub OnLoad(ByVal e As EventArgs)
			MyBase.OnLoad(e)
			pivotGridControl.DataSource = GetNWindData("ProductReports")
			cbGroup.Properties.Items.Add(New cbItem("Group Products by First Characters", 0))
			cbGroup.Properties.Items.Add(New cbItem("Group Sales by Year and Quarter", 1))
			cbGroup.SelectedIndex = 0
		End Sub
		Private ReadOnly Property SelectedDemo() As Integer
			Get
				Return (CType(cbGroup.SelectedItem, cbItem)).Value
			End Get
		End Property
		'<cbGroup>
		Protected Sub PivotGridControl_CustomGroupInterval(ByVal sender As Object, ByVal e As PivotCustomGroupIntervalEventArgs) Handles pivotGridControl.CustomGroupInterval
			Select Case SelectedDemo
				Case 0
                    If Not Object.Equals(e.Field, pivotGridControl.Fields(0)) Then
                        Return
                    End If
					If Convert.ToChar(e.Value.ToString().Chars(0)) < "F"c Then
						e.GroupValue = "A-E"
						Return
					End If
					If Convert.ToChar(e.Value.ToString().Chars(0)) > "E"c AndAlso Convert.ToChar(e.Value.ToString().Chars(0)) < "T"c Then
						e.GroupValue = "F-S"
						Return
					End If
					If Convert.ToChar(e.Value.ToString().Chars(0)) > "S"c Then
						e.GroupValue = "T-Z"
					End If

				Case 1
                    If Not Object.Equals(e.Field, pivotGridControl.Fields(3)) Then
                        Return
                    End If
					e.GroupValue = (CDate(e.Value)).Year & " - " & (((CDate(e.Value)).Month - 1) / 3 + 1).ToString()
			End Select
		End Sub
		'</cbGroup>
		Protected Sub cbGroup_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbGroup.SelectedIndexChanged
			pivotGridControl.BeginUpdate()
			Select Case SelectedDemo
				Case 0
					pivotGridControl.Fields(0).Visible = True
					pivotGridControl.Fields(0).Caption = "Product Group"
					pivotGridControl.Fields(0).GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.Custom
					pivotGridControl.Fields(4).Caption = "Year"
					pivotGridControl.Fields(4).GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateYear

					pivotGridControl.Fields(3).Visible = False
					pivotGridControl.Fields(3).GroupInterval = PivotGroupInterval.Default
				Case 1
					pivotGridControl.Fields(3).Visible = True
					pivotGridControl.Fields(3).Caption = "Year - Quarter"
					pivotGridControl.Fields(3).GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.Custom
					pivotGridControl.Fields(3).AreaIndex = 0
					pivotGridControl.Fields(4).Caption = "Shipped Date"
					pivotGridControl.Fields(4).GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.Default

					pivotGridControl.Fields(0).Visible = False
					pivotGridControl.Fields(0).GroupInterval = PivotGroupInterval.Default
			End Select
			pivotGridControl.EndUpdate()
			pivotGridControl.CollapseAll()
		End Sub
		Private Class cbItem
			Public Name As String
			Public Value As Integer
			Public Sub New(ByVal name As String, ByVal value As Integer)
				Me.Name = name
				Me.Value = value
			End Sub
			Public Overrides Function ToString() As String
				Return Name
			End Function
		End Class
	End Class
End Namespace
