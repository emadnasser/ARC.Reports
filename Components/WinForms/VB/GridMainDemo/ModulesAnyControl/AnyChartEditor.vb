Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.Utils.Drawing
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraEditors.Drawing
Imports DevExpress.XtraEditors.Registrator
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraEditors.ViewInfo
Imports DevExpress.XtraPrinting
Imports System.Collections
Imports DevExpress.XtraCharts
Imports DevExpress.XtraEditors.CustomEditor

Namespace DevExpress.XtraGrid.Demos
    '<gridControl1>
    Public Class EmbeddedChartControl
        Inherits Control
        Implements IAnyControlEdit, ICloneable
        Private recommendedSize_Renamed As New Size(30, 30)
        Private chart_Renamed As ChartControl = Nothing
        Public Sub New()
        End Sub
        Public Sub New(ByVal chart As ChartControl)
            AddChart(chart)
        End Sub
        Public Sub AddChart(ByVal chart As ChartControl)
            If Me.chart_Renamed IsNot Nothing Then
                Me.chart_Renamed.Dispose()
            End If
            Me.chart_Renamed = chart
            Me.recommendedSize_Renamed = chart.Size
            Me.chart_Renamed.Parent = Me
            Me.chart_Renamed.Dock = DockStyle.Fill
        End Sub
        <DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden), Browsable(False)>
        Public ReadOnly Property Chart() As ChartControl
            Get
                Return chart_Renamed
            End Get
        End Property
        Public Property RecommendedSize() As Size
            Get
                Return recommendedSize_Renamed
            End Get
            Set(ByVal value As Size)
                recommendedSize_Renamed = value
            End Set
        End Property
        #Region "IAnyControlEdit Members"
        Private editValue_Renamed As Object = Nothing
        Private Event _editValueChanged As EventHandler
        Private Property IAnyControlEdit_EditValue() As Object Implements IAnyControlEdit.EditValue
            Get
                Return editValue_Renamed
            End Get
            Set(ByVal value As Object)
                If value Is editValue_Renamed Then
                    Return
                End If
                editValue_Renamed = value
                OnEditValueChanging(value)

            End Set
        End Property

        Private Sub OnEditValueChanging(ByVal value As Object)
            If Chart Is Nothing Then
                Return
            End If
            If TypeOf value Is IList OrElse value Is Nothing Then
                Chart.DataSource = value
            End If
        End Sub
        Private Custom Event EditValueChanged As EventHandler Implements IAnyControlEdit.EditValueChanged
            AddHandler(ByVal value As EventHandler)
                AddHandler _editValueChanged, value
            End AddHandler
            RemoveHandler(ByVal value As EventHandler)
                RemoveHandler _editValueChanged, value
            End RemoveHandler
            RaiseEvent(ByVal sender As System.Object, ByVal e As System.EventArgs)
                RaiseEvent _editValueChanged(sender, e)
            End RaiseEvent
        End Event
        Private Sub OnEditValueChanged()
            RaiseEvent _editValueChanged(Me, EventArgs.Empty)
        End Sub
        Private ReadOnly Property IAnyControlEdit_AllowBitmapCache() As Boolean Implements IAnyControlEdit.AllowBitmapCache
            Get
                Return True
            End Get
        End Property

        Private Function IAnyControlEdit_IsNeededKey(ByVal e As KeyEventArgs) As Boolean Implements IAnyControlEdit.IsNeededKey
            Return False
        End Function
        Private Sub IAnyControlEdit_SetupAsDrawControl() Implements IAnyControlEdit.SetupAsDrawControl
        End Sub
        Private Sub IAnyControlEdit_SetupAsEditControl() Implements IAnyControlEdit.SetupAsEditControl
        End Sub
        Private Function IAnyControlEdit_CalcSize(ByVal g As Graphics) As Size Implements IAnyControlEdit.CalcSize
            Return RecommendedSize
        End Function
        Private Function IAnyControlEdit_AllowClick(ByVal p As Point) As Boolean Implements IAnyControlEdit.AllowClick
            Return False
        End Function
        Private ReadOnly Property IAnyControlEdit_SupportsDraw() As Boolean Implements IAnyControlEdit.SupportsDraw
            Get
                Return False
            End Get
        End Property

        Private ReadOnly Property IAnyControlEdit_AllowBorder() As Boolean Implements IAnyControlEdit.AllowBorder
            Get
                Return True
            End Get
        End Property

        Private Sub IAnyControlEdit_Draw(ByVal cache As GraphicsCache, ByVal viewInfo As AnyControlEditViewInfo) Implements IAnyControlEdit.Draw
            Throw New NotImplementedException()
        End Sub

        Private Function IAnyControlEdit_GetDisplayText(ByVal editValue As Object) As String Implements IAnyControlEdit.GetDisplayText
            Return RepositoryItemAnyControl.GetBasicDisplayText(editValue)
        End Function
        #End Region

        Private Function ICloneable_Clone() As Object Implements ICloneable.Clone
            Dim c As New EmbeddedChartControl()
            If Chart IsNot Nothing Then
                c.AddChart(TryCast(Chart.Clone(), ChartControl))
                c.RecommendedSize = RecommendedSize
            End If
            Return c
        End Function
        Protected Overrides Sub OnBackColorChanged(ByVal e As EventArgs)
            MyBase.OnBackColorChanged(e)
            If Chart IsNot Nothing Then
                Chart.BackColor = BackColor
            End If
        End Sub
    End Class
    '</gridControl1>
End Namespace
