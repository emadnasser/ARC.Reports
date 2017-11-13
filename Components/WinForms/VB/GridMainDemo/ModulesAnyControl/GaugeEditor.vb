Imports System
Imports System.Drawing
Imports DevExpress.XtraEditors.CustomEditor
Imports DevExpress.XtraGauges.Win
Imports DevExpress.XtraGauges.Win.Base
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGauges.Core.Base

Namespace DevExpress.XtraGrid.Demos
    Partial Public Class GaugeEditor
        Inherits TutorialControl

        Private gcDataSource As TasksWithCategoriesDatasource
        Public Sub New()
            InitializeComponent()
            TutorialInfo.WhatsThisCodeFile = "VB\GridMainDemo\ModulesAnyControl\GaugeEditor.vb;"
            TutorialInfo.WhatsThisXMLFile = "GaugeEditor.xml"
            InitDefaultColors()
            InitPanelProperties()
            gcDataSource = New TasksWithCategoriesDatasource(gridControl1)
            CreateGaugeEdit(gaugeColumn, gaugeControl1)
        End Sub
        '<cpActive>
        Private Property InTimeColor() As Color
        '</cpActive>
        Private Property OutOfTimeColor() As Color
        Private Property LowPriorityColor() As Color
        Private Property MediumPriorityColor() As Color
        Private Property HighPriorityColor() As Color
        Private Sub InitPanelProperties()
            cpHighPriority.Color = HighPriorityColor
            cpMediumPriority.Color = MediumPriorityColor
            cpLowPriority.Color = LowPriorityColor
            cpOverDue.Color = OutOfTimeColor
            cpActive.Color = InTimeColor
            AddHandler cpActive.ColorChanged, AddressOf OnCPActiveChanged
            AddHandler cpActive.Closed, AddressOf cpClosed
            AddHandler cpOverDue.ColorChanged, AddressOf OnCPOverDueChanged
            AddHandler cpOverDue.Closed, AddressOf cpClosed
            AddHandler cpLowPriority.ColorChanged, AddressOf OnCPLowPriorityChanged
            AddHandler cpLowPriority.Closed, AddressOf cpClosed
            AddHandler cpMediumPriority.ColorChanged, AddressOf OnCPMediumPriorityChanged
            AddHandler cpMediumPriority.Closed, AddressOf cpClosed
            AddHandler cpHighPriority.ColorChanged, AddressOf OnCPHighPriorityChanged
            AddHandler cpHighPriority.Closed, AddressOf cpClosed
        End Sub
        Private Sub OnCPHighPriorityChanged(ByVal sender As Object, ByVal e As EventArgs)
            HighPriorityColor = cpHighPriority.Color
        End Sub
        Private Sub OnCPMediumPriorityChanged(ByVal sender As Object, ByVal e As EventArgs)
            MediumPriorityColor = cpMediumPriority.Color
        End Sub
        Private Sub OnCPLowPriorityChanged(ByVal sender As Object, ByVal e As EventArgs)
            LowPriorityColor = cpLowPriority.Color
        End Sub
        Private Sub OnCPOverDueChanged(ByVal sender As Object, ByVal e As EventArgs)
            OutOfTimeColor = cpOverDue.Color
        End Sub
        '<cpActive>
        Private Sub OnCPActiveChanged(ByVal sender As Object, ByVal e As EventArgs)
            InTimeColor = cpActive.Color
        End Sub
        Private Sub cpClosed(ByVal sender As Object, ByVal e As XtraEditors.Controls.ClosedEventArgs)
            layoutViewCard1.Update()
        End Sub
        '</cpActive>
        '</layoutControlGroup5>
        Private Sub InitDefaultColors()
            OutOfTimeColor = Color.FromArgb(206, 5, 5)
            InTimeColor = Color.FromArgb(137, 137, 137)
            LowPriorityColor = Color.FromArgb(42, 174, 85)
            MediumPriorityColor = Color.FromArgb(253, 163, 6)
            HighPriorityColor = Color.FromArgb(206, 5, 5)
        End Sub
        '<gridControl1>
        Private Shared Sub CreateGaugeEdit(ByVal column As GridColumn, ByVal gaugeControl As GaugeControl)
            If column.ColumnEdit IsNot Nothing Then
                Return
            End If
            Dim item As New RepositoryItemAnyControl()
            item.Control = gaugeControl
            column.View.GridControl.RepositoryItems.Add(item)
            column.ColumnEdit = item
        End Sub
        Private Sub layoutView1_CustomUnboundColumnData(ByVal sender As Object, ByVal e As Views.Base.CustomColumnDataEventArgs) Handles layoutView1.CustomUnboundColumnData
            Dim task As Task = (TryCast(e.Row, Task))
            Dim colorScheme As New ColorScheme()
            If e.IsGetData Then
                colorScheme.Color = GetColorByDay(task.DueDate)
                colorScheme.TargetElements = gaugeControl1.ColorScheme.TargetElements
                e.Value = New ExtendedEditValue() With {.Value = task.PercentComplete, .ColorScheme = colorScheme, .ImageColor = GetColorByPriority(task.Priority)}
            End If
        End Sub
        '</gridControl1>
        Private Function GetColorByDay(ByVal dueDate As Date) As Color
            If dueDate < Date.Today Then
                Return OutOfTimeColor
            End If
            Return InTimeColor
        End Function
        Private Function GetColorByPriority(ByVal priority As Priority) As Color
            If priority.Equals(priority.Low) Then
                Return LowPriorityColor
            End If
            If priority.Equals(priority.Medium) Then
                Return MediumPriorityColor
            End If
            Return HighPriorityColor
        End Function
        '<gridControl1>
        Private Class ExtendedEditValue
            Implements IValueProvider
            Implements IImageColorProvider
            Implements IColorSchemeProvider
            Public Property Value As Object Implements IValueProvider.Value
            Public Property ImageColor As Color Implements IImageColorProvider.ImageColor
            Public Property ColorScheme As ColorScheme Implements IColorSchemeProvider.ColorScheme
        End Class
        '</gridControl1>
    End Class
End Namespace
