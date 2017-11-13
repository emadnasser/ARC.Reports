Imports Microsoft.VisualBasic
Imports DevExpress.Utils
Imports DevExpress.XtraEditors
Imports DevExpress.XtraPivotGrid.Demos.Helpers
Imports System
Imports System.Drawing
Imports System.Windows.Forms

Namespace DevExpress.XtraPivotGrid.Demos.Modules
	Partial Public Class OLAPDrillDown
		Inherits TutorialControl
		Public Sub New()
			CreateWaitDialog()
			InitializeComponent()

            TutorialInfo.WhatsThisCodeFile = "VB\PivotGridMainDemo\Modules\OLAPDrillDown.vb"
            TutorialInfo.WhatsThisXMLFile = "OLAPDrillDown.xml"

			Dim success As Boolean = OLAPConfigurator.CreateSampleOLAPConfiguration(pivotGridControl)

			controlPanel.Visible = Not success
			paddingPanel.Visible = Not success

			Dim fieldCountry As PivotGridField = pivotGridControl.Fields(OLAPConfigurator.CountryFieldName)
			If fieldCountry IsNot Nothing Then
				fieldCountry.Visible = True
				fieldCountry.Area = PivotArea.ColumnArea
			End If
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
			pivotGridControl.ExpandAll()
			pivotGridControl.Cells.FocusedCell = New Point(1, 12)
		End Sub
		'<pivotGridControl>
		Private Sub pivotGridControl_CellDoubleClick(ByVal sender As Object, ByVal e As PivotCellEventArgs) Handles pivotGridControl.CellDoubleClick
			Try
			ShowDrilldown(e.CreateDrillDownDataSource())
			Catch ex As Exception
				XtraMessageBox.Show(ex.Message)
			End Try
		End Sub

		Private Sub ShowDrilldown(ByVal ds As PivotDrillDownDataSource)
			Dim form As New XtraForm()
			form.Text = "Drill Down Form"
			form.StartPosition = FormStartPosition.CenterParent
			Dim grid As New DataGridView()
			grid.Parent = form
			grid.Dock = DockStyle.Fill
			grid.DataSource = ds
            form.Icon = ResourceImageHelper.CreateIconFromResourcesEx("DevExpress.XtraPivotGrid.Demos.AppIcon.ico", GetType(OLAPDrillDown).Assembly)
			form.Width = 520
			form.Height = 300
			form.ShowDialog()
			form.Dispose()
		End Sub
		'</pivotGridControl>

	End Class
End Namespace
