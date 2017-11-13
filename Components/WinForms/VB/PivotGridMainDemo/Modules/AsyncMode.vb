Imports Microsoft.VisualBasic
Imports DevExpress.Utils
Imports DevExpress.XtraEditors
Imports DevExpress.XtraPivotGrid.Demos.Helpers
Imports System
Imports System.Windows.Forms

Namespace DevExpress.XtraPivotGrid.Demos.Modules
    Partial Public Class AsynchronousMode
        Inherits TutorialControl
        Private isDataBaseGeneratorRunned As Boolean = False
		Private actionState As ActionState = ActionState.Normal

        Protected Overrides ReadOnly Property HideCustFormWhenSwitchDemo() As Boolean
            Get
                Return False
            End Get
        End Property
        Public Sub New()
            CreateWaitDialog()
            InitializeComponent()

            TutorialInfo.WhatsThisCodeFile = "VB\PivotGridMainDemo\Modules\AsyncMode.vb"
            TutorialInfo.WhatsThisXMLFile = "AsyncMode.xml"

            rgDataSources.SelectedIndex = 0
            ServerParameters.LoadParameters()
        End Sub
        Private Sub AsynchronousMode_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
            pivotGridControl.FieldsCustomization(splitContainerControl1.Panel2)
            UpdateGenerateDataSourceButtonPosition()
        End Sub
        Private Sub AsynchronousMode_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Resize
            UpdateGenerateDataSourceButtonPosition()
        End Sub
        Private Sub splitContainerControl1_SplitterMoved(ByVal sender As Object, ByVal e As EventArgs) Handles splitContainerControl1.SplitterMoved
            UpdateGenerateDataSourceButtonPosition()
        End Sub
        Private Sub UpdateGenerateDataSourceButtonPosition()
            btnGenerateDataSource.Left = Math.Max(splitContainerControl1.SplitterBounds.Left - btnGenerateDataSource.Width, rgDataSources.Right + rgDataSources.Margin.Right)
        End Sub
        '<btnGenerateDataSource>
        Private Sub btnGenerateDataSource_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnGenerateDataSource.Click
            RunDBGenerator("Return to Demo")
        End Sub
        '</btnGenerateDataSource>
        '<rgDataSources>
        Private Sub rgDataSources_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles rgDataSources.SelectedIndexChanged
            DisableControls()
            Select Case rgDataSources.SelectedIndex
                Case 0
                    Initialize(InitializerDataSource.OlapCube)
                Case 1
                    Initialize(InitializerDataSource.TableDataSource)
            End Select
        End Sub
        '</rgDataSources>
        '<btnGenerateDataSource>
        Private Sub RunDBGenerator(ByVal demoString As String)
            Using formConnector As New frmSQLConnector(demoString)
                formConnector.ShowDialog()
                If rgDataSources.SelectedIndex = 1 Then
                    rgDataSources.Enabled = False
                    isDataBaseGeneratorRunned = True
                    Initialize(InitializerDataSource.TableDataSource)
                End If
            End Using
        End Sub
        '</btnGenerateDataSource>
        Private Sub Initialize(ByVal dataSourceType As InitializerDataSource)
			actionState = ActionState.Connect
            AsynchronousPivotInitializer.Initialize(pivotGridControl, AddressOf AsyncInitializationCompleted, dataSourceType)
			actionState = ActionState.Normal
        End Sub
        Private Sub DisableControls()
            rgDataSources.Enabled = False
            btnGenerateDataSource.Enabled = False
        End Sub
        Private Sub EnableControls()
            rgDataSources.Enabled = True
            btnGenerateDataSource.Enabled = True
        End Sub
        Private Sub AsyncInitializationCompleted(ByVal result As AsyncOperationResult)
            EnableControls()
            If result Is Nothing Then
                If Not isDataBaseGeneratorRunned Then
                    RunDBGenerator("Start Demo")
                End If
                pivotGridControl.Enabled = False
                labelError.Text = If(rgDataSources.SelectedIndex = 0, AsynchronousPivotInitializer.OlapError, AsynchronousPivotInitializer.TableError)
                panelError.Visible = True
            Else
                pivotGridControl.Enabled = True
                panelError.Visible = False
            End If
        End Sub
        '<pivotGridControl>
        Private Sub pivotGridControl1_CellDoubleClick(ByVal sender As Object, ByVal e As PivotCellEventArgs) Handles pivotGridControl.CellDoubleClick
			actionState = ActionState.DrillDown
            Dim showDrillDownAction As AsyncCompletedHandler = Function(result) AnonymousMethod1(result)
            pivotGridControl.CreateDrillDownDataSourceAsync(e.ColumnIndex, e.RowIndex, showDrillDownAction)
        End Sub

		Private Function AnonymousMethod1(ByVal result As AsyncOperationResult) As Object
			If result.Exception IsNot Nothing Then
				XtraMessageBox.Show(result.Exception.Message)
			Else
                ShowDrillDown(CType(result.Value, PivotDrillDownDataSource))
			End If
			actionState = ActionState.Normal
			Return Nothing
        End Function
        Private Sub ShowDrillDown(ByVal drillDownDataSource As PivotDrillDownDataSource)
            If drillDownDataSource.RowCount = 0 Then
                'Also shows for calculated datafields in this demo
				XtraMessageBox.Show("DrillDown doesn't contains results")
                Return
            End If
            Dim form As New XtraForm()
            form.Text = String.Format("Drill Down Results: {0} Rows", drillDownDataSource.RowCount)
            form.Width = 520
            form.Height = 300
            form.StartPosition = FormStartPosition.CenterParent
            Dim grid As New DataGridView()
            grid.Parent = form
            grid.Dock = DockStyle.Fill
            grid.DataSource = drillDownDataSource
            form.Icon = ResourceImageHelper.CreateIconFromResourcesEx("DevExpress.XtraPivotGrid.Demos.AppIcon.ico", GetType(AsynchronousMode).Assembly)
            form.ShowDialog()
            form.Dispose()
        End Sub
        '</pivotGridControl>
        Private Sub pivotGridControl_AsyncOperationCompleted(ByVal sender As Object, ByVal e As EventArgs) Handles pivotGridControl.AsyncOperationCompleted
            EnableControls()
        End Sub
        Private Sub pivotGridControl_AsyncOperationStarting(ByVal sender As Object, ByVal e As EventArgs) Handles pivotGridControl.AsyncOperationStarting
            DisableControls()
        End Sub

		Private Sub pivotGridControl_QueryException(ByVal sender As Object, ByVal e As PivotQueryExceptionEventArgs) Handles pivotGridControl.QueryException
			If actionState = ActionState.Normal Then
				e.Handled = True
			End If
		End Sub
    End Class
	Public Enum ActionState
		Normal
		Connect
		DrillDown
	End Enum
End Namespace
