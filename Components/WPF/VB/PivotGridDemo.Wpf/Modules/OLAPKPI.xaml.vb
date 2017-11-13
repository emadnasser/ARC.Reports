Imports System
Imports System.IO
Imports System.Windows
Imports System.Windows.Data
Imports System.Windows.Markup
Imports DevExpress.DemoData.Helpers
Imports DevExpress.Xpf.Core
Imports DevExpress.Xpf.DemoBase
Imports DevExpress.Xpf.DemoBase.Helpers
Imports DevExpress.Xpf.Editors
Imports DevExpress.Xpf.PivotGrid
Imports System.Windows.Threading

Namespace PivotGridDemo.PivotGrid
    Partial Public Class OLAPKPI
        Inherits PivotGridDemoModule

        Public Sub New()
            InitializeComponent()

            cbStatusGraphics.ItemsSource = System.Enum.GetValues(GetType(PivotKpiGraphic))
            cbStatusGraphics.SelectedIndex = 1
            cbTrendGraphics.ItemsSource = System.Enum.GetValues(GetType(PivotKpiGraphic))
            cbTrendGraphics.SelectedIndex = 1

            InitPivotGrid()
        End Sub

        Private Sub InitPivotGrid()
            pivotGrid.OlapConnectionString = SampleConnectionString
        End Sub

        Private Shared sampleFileName_Renamed As String

        Private ReadOnly Property SampleConnectionString() As String
            Get
                Return "Provider=msolap;Data Source=" & SampleFileName & ";Initial Catalog=Adventure Works;Cube Name=Adventure Works"
            End Get
        End Property
        Protected Shared ReadOnly Property SampleFileName() As String
            Get
                If String.IsNullOrEmpty(sampleFileName_Renamed) Then
                    sampleFileName_Renamed = Path.GetFullPath(DataFilesHelper.FindFile(GetSampleCubeFileName(), DataFilesHelper.DataPath))
                    If File.Exists(sampleFileName_Renamed) Then
      Try
       File.SetAttributes(sampleFileName_Renamed, FileAttributes.Normal)
      Catch
      End Try
                    End If
                End If
                Return sampleFileName_Renamed
            End Get
        End Property

        Private Shared Function GetSampleCubeFileName() As String
            Return "AdventureWorks.cub"
        End Function

        Private Sub cbStatusGraphics_SelectedIndexChanged(ByVal sender As Object, ByVal e As RoutedEventArgs)
            fieldStatus.KpiGraphic = CType(DirectCast(sender, ComboBoxEdit).SelectedItem, PivotKpiGraphic)
        End Sub

        Private Sub cbTrendGraphics_SelectedIndexChanged(ByVal sender As Object, ByVal e As RoutedEventArgs)
            fieldTrend.KpiGraphic = CType(DirectCast(sender, ComboBoxEdit).SelectedItem, PivotKpiGraphic)
        End Sub

        Private Sub OnPivotGridOlapException(ByVal sender As Object, ByVal e As PivotOlapExceptionEventArgs)
            e.Handled = True
            pivotGrid.Dispatcher.BeginInvoke(New Action(Sub() ShowOLAPErrorMessage(e)))
        End Sub

        Private Sub ShowOLAPErrorMessage(ByVal e As PivotOlapExceptionEventArgs)
            errorText.Text = (e.Exception.Message & ControlChars.CrLf & " " & (If(e.Exception.InnerException IsNot Nothing, e.Exception.InnerException.Message, String.Empty)))
            VisualStateManager.GoToState(Me, "ShowErrorMessage", True)
            Dim timer As New DispatcherTimer()
            timer.Interval = New TimeSpan(0, 0, 10)
            AddHandler timer.Tick, AddressOf OnTimerTick
            timer.Start()
            e.Handled = True
        End Sub

        Private Sub OnTimerTick(ByVal sender1 As Object, ByVal e1 As EventArgs)
            Dim self As DispatcherTimer = TryCast(sender1, DispatcherTimer)
            If self Is Nothing Then
                Return
            End If
            self.Stop()
            RemoveHandler self.Tick, AddressOf OnTimerTick
            VisualStateManager.GoToState(Me, "HideErrorMessage", True)
        End Sub
    End Class
End Namespace
