Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports System.Data
Imports System.Text
Imports System.Windows.Forms
Imports System.IO
Imports DevExpress.Utils
Imports DevExpress.XtraPivotGrid.Data

Namespace DevExpress.XtraPivotGrid.Demos.Modules
	Partial Public Class OLAPKPI
		Inherits DevExpress.XtraPivotGrid.Demos.TutorialControl
		Public Sub New()
			InitializeComponent()

            TutorialInfo.WhatsThisCodeFile = "VB\PivotGridMainDemo\Modules\OLAPKPI.vb"
            TutorialInfo.WhatsThisXMLFile = "OLAPKPI.xml"

			ddlStatusGraphics.Properties.Items.Clear()
			ddlStatusGraphics.Properties.Items.Add(PivotKPIGraphic.None)
			ddlStatusGraphics.Properties.Items.Add(PivotKPIGraphic.ServerDefined)
			ddlStatusGraphics.Properties.Items.Add(PivotKPIGraphic.Cylinder)
			ddlStatusGraphics.Properties.Items.Add(PivotKPIGraphic.Faces)
			ddlStatusGraphics.Properties.Items.Add(PivotKPIGraphic.Gauge)
			ddlStatusGraphics.Properties.Items.Add(PivotKPIGraphic.RoadSigns)
			ddlStatusGraphics.Properties.Items.Add(PivotKPIGraphic.Shapes)
			ddlStatusGraphics.Properties.Items.Add(PivotKPIGraphic.Thermometer)
			ddlStatusGraphics.Properties.Items.Add(PivotKPIGraphic.TrafficLights)
			ddlStatusGraphics.Properties.Items.Add(PivotKPIGraphic.VarianceArrow)
			ddlStatusGraphics.Properties.Items.Add(PivotKPIGraphic.ReversedCylinder)
			ddlStatusGraphics.Properties.Items.Add(PivotKPIGraphic.ReversedGauge)
			ddlStatusGraphics.Properties.Items.Add(PivotKPIGraphic.ReversedThermometer)
			ddlStatusGraphics.SelectedIndex = 1

			ddlTrendGraphics.Properties.Items.Clear()
			ddlTrendGraphics.Properties.Items.Add(PivotKPIGraphic.None)
			ddlTrendGraphics.Properties.Items.Add(PivotKPIGraphic.ServerDefined)
			ddlTrendGraphics.Properties.Items.Add(PivotKPIGraphic.StandardArrow)
			ddlTrendGraphics.Properties.Items.Add(PivotKPIGraphic.StatusArrow)
			ddlTrendGraphics.Properties.Items.Add(PivotKPIGraphic.ReversedStatusArrow)
			ddlTrendGraphics.Properties.Items.Add(PivotKPIGraphic.Faces)
			ddlTrendGraphics.SelectedIndex = 1

			panelError.Visible = False
			Dim cubeFile As String = Path.GetFullPath(FilesHelper.FindingFileName(Application.StartupPath, GetAdventureWorksFileName()))
			Try
				File.SetAttributes(cubeFile, FileAttributes.Normal)
				pivotGridControl.OLAPConnectionString = "Provider=msolap;Data Source=" & cubeFile & ";Initial Catalog=Adventure Works;Cube Name=Adventure Works;"
            Catch
                pivotGridControl.OLAPConnectionString = Nothing
                panelError.Visible = True
                pivotGridControl.Enabled = False
                panelConnection.Enabled = False
			End Try
			separator1.Visible = panelError.Visible
		End Sub
		Private Function GetAdventureWorksFileName() As String
            Return "Data\AdventureWorks.cub"
        End Function
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

		'<ddlStatusGraphics>
		Private Sub cbStatusGraphic_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles ddlStatusGraphics.SelectedIndexChanged
			If panelError.Visible Then
				Return
			End If
			pivotGridControl.Fields("[Measures].[Internet Revenue Status]").KPIGraphic = CType(ddlStatusGraphics.SelectedItem, PivotKPIGraphic)
		End Sub
		'</ddlStatusGraphics>

		'<ddlTrendGraphics>
		Private Sub cbTrendGraphic_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles ddlTrendGraphics.SelectedIndexChanged
			If panelError.Visible Then
				Return
			End If
			pivotGridControl.Fields("[Measures].[Internet Revenue Trend]").KPIGraphic = CType(ddlTrendGraphics.SelectedItem, PivotKPIGraphic)
		End Sub
		'</ddlTrendGraphics>
	End Class
End Namespace
