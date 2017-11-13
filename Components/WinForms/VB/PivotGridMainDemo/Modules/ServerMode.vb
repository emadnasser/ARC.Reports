Imports Microsoft.VisualBasic
Imports System
Imports System.Data
Imports System.Diagnostics
Imports System.Windows.Forms
Imports DevExpress.Data.Linq
Imports DevExpress.XtraEditors
Imports DevExpress.XtraPivotGrid.Demos.Helpers

Namespace DevExpress.XtraPivotGrid.Demos.Modules
	Partial Public Class ServerMode
		Inherits TutorialControl
		Private ReadOnly stateNoData As NoDataState
		Private ReadOnly stateLinq2Sql As Linq2SqlState
		Private ReadOnly timer As New Stopwatch()
		Private currentState As DemoState

		Public ReadOnly Property PnlDemo() As PanelControl
			Get
				Return panelDemo
			End Get
		End Property
		Public ReadOnly Property PnlNoConnection() As PanelControl
			Get
				Return panelNoConnection
			End Get
		End Property
		Public WriteOnly Property PivotDataSource() As Object
			Set(ByVal value As Object)
				pivotGridControl.SetDataSourceAsync(value, Function(result) AnonymousMethod1(result))
			End Set
		End Property
		
		Private Function AnonymousMethod1(ByVal result As Object) As Boolean
			Return True
		End Function
		Private Property State() As DemoState
			Get
				Return currentState
			End Get
			Set(ByVal value As DemoState)
				If currentState Is value Then
					Return
				End If
				If currentState IsNot Nothing Then
					currentState.Leave()
					currentState = Nothing
				End If
				If (Not value.Enter()) Then
					stateNoData.Enter()
					currentState = stateNoData
				Else
					currentState = value
				End If
			End Set
		End Property
		Protected Overrides ReadOnly Property HideCustFormWhenSwitchDemo() As Boolean
			Get
				Return False
			End Get
		End Property

		Public Sub New()
			CreateWaitDialog()
			InitializeComponent()

            TutorialInfo.WhatsThisCodeFile = "VB\PivotGridMainDemo\Modules\ServerMode.vb"
            TutorialInfo.WhatsThisXMLFile = "ServerMode.xml"

			ServerParameters.LoadParameters()

			stateNoData = New NoDataState(Me)
			stateLinq2Sql = New Linq2SqlState(Me)

			State = stateNoData
		End Sub
        '<panelFieldCust>
        Private Sub ServerMode_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
            pivotGridControl.FieldsCustomization(panelFieldCust)
            State = stateLinq2Sql
        End Sub
        '</panelFieldCust>

        Private Sub btnGenerateDataSource_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnGenerateDataSource.Click
            RunDBGenerator(State)
        End Sub

        Private Sub btnGenerateDatasourceLarge_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnGenerateDatasourceLarge.Click
            RunDBGenerator(stateLinq2Sql)
        End Sub

        Private Sub RunDBGenerator(ByVal nextState As DemoState)
            Using formConnector As New frmSQLConnector(State.DBGeneratorString)
                If formConnector.ShowDialog() = DialogResult.OK Then
                    If State Is nextState Then
                        pivotGridControl.RefreshData()
                    Else
                        State = nextState
                    End If
                End If
            End Using
        End Sub

        Private startMemory As Long
        Private Sub pivotGridControl_AsyncOperationStarting(ByVal sender As Object, ByVal e As EventArgs) Handles pivotGridControl.AsyncOperationStarting
            lcTimeTaken.Text = "Working..."
            timer.Restart()
            startMemory = GC.GetTotalMemory(True)
        End Sub

        Private Sub pivotGridControl_AsyncOperationCompleted(ByVal sender As Object, ByVal e As EventArgs) Handles pivotGridControl.AsyncOperationCompleted
            timer.Stop()
            lcTimeTaken.Text = timer.ElapsedMilliseconds.ToString()
        End Sub

        Private MustInherit Class DemoState
            Protected demo As ServerMode

            Public MustOverride ReadOnly Property DBGeneratorString() As String

            Public Sub New(ByVal demo As ServerMode)
                Me.demo = demo
            End Sub
            Public MustOverride Function Enter() As Boolean
            Public MustOverride Sub Leave()
        End Class

        Private Class NoDataState
            Inherits DemoState
            Public Overrides ReadOnly Property DBGeneratorString() As String
                Get
                    Return "Start Demo"
                End Get
            End Property

            Public Sub New(ByVal demo As ServerMode)
                MyBase.New(demo)
            End Sub

            Public Overrides Function Enter() As Boolean
                'demo.PnlDemo.Visible = false;
                demo.PnlNoConnection.Visible = True
                demo.PnlNoConnection.Enabled = True
                Return True
            End Function
            Public Overrides Sub Leave()
            End Sub
        End Class

        Private MustInherit Class DataState
            Inherits DemoState
            Private firstEnter As Boolean = True

            Public Overrides ReadOnly Property DBGeneratorString() As String
                Get
                    Return "Return to demo"
                End Get
            End Property

            Protected MustOverride ReadOnly Property RgDataSourcesSelectedIndex() As Integer

            Public Sub New(ByVal demo As ServerMode)
                MyBase.New(demo)
            End Sub

            Protected MustOverride Function LoadData() As Boolean
            Protected MustOverride Sub CleanData()

            Public Overrides Function Enter() As Boolean
                demo.PnlDemo.Enabled = False
                demo.PnlNoConnection.Enabled = False
                Dim result As Boolean = LoadData()
                If result Then
                    demo.PnlDemo.Visible = True
                    demo.PnlDemo.Enabled = True
                    demo.PnlNoConnection.Visible = False
                ElseIf (Not firstEnter) Then
                    XtraMessageBox.Show("Failed to load data. Use the Generate Database button to check the connection parameters or generate a new sample database.", "Server Mode Demo", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
                If firstEnter Then
                    firstEnter = False
                End If
                Return result
            End Function

            Public Overrides Sub Leave()
                CleanData()
            End Sub
        End Class

        Private Class Linq2SqlState
            Inherits DataState
            Private dataContext As PivotGridDemoDBDataContext

            Public Sub New(ByVal demo As ServerMode)
                MyBase.New(demo)
            End Sub
            '<rgDataSources>
            Protected Overrides Function LoadData() As Boolean
                dataContext = DatabaseHelper.GetContext()
                If dataContext Is Nothing Then
                    Return False
                End If
                Try
                    Dim dataSource As New LinqServerModeSource()
                    dataSource.QueryableSource = dataContext.Sales
                    demo.PivotDataSource = dataSource
                Catch
                    Return False
                End Try
                Return True
            End Function
            '</rgDataSources>
            Protected Overrides Sub CleanData()
                demo.PivotDataSource = Nothing
                If dataContext IsNot Nothing Then
                    dataContext.Dispose()
                    dataContext = Nothing
                End If
            End Sub
            Protected Overrides ReadOnly Property RgDataSourcesSelectedIndex() As Integer
                Get
                    Return 0
                End Get
            End Property
        End Class
    End Class
End Namespace
