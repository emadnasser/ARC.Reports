Imports System
Imports System.Data
Imports System.Globalization
Imports System.IO
Imports DevExpress.Xpf.Editors
Namespace MapDemo
    Partial Public Class BubbleCharts
        Inherits MapDemoModule

        Private Const MinMag As Double = 6.5
        Private Const MaxMag As Double = 9
        Private dataTable As DataTable

        Public ReadOnly Property Data() As DataTable
            Get
                Return dataTable
            End Get
        End Property

        Public Sub New()
            InitializeComponent()
            lbYearsFilter.SelectAll()
            DataContext = Me
            SetData()
        End Sub
        Private Function CreateData() As DataTable
            Dim ds As New DataSet()
            Dim documentStream As Stream = DataLoader.LoadStreamFromResources("/Data/Earthquakes.xml")
            ds.ReadXml(documentStream)
            Return ds.Tables(0)
        End Function
        Private Sub SetData()
            Me.dataTable = CreateData()
            UpdateFilter(MinMag, MaxMag)
        End Sub
        Private Sub UpdateFilter(ByVal minMagnitude As Double, ByVal maxMagnitude As Double)
            If Data IsNot Nothing Then
                Dim magnitudeFilter As String = GetMagnitudeFilter(minMagnitude, maxMagnitude)
                Dim yearFilter As String = GetYearFilterString()
                Dim filter As String = String.Format(CultureInfo.InvariantCulture, "({0}) AND ({1})", magnitudeFilter, yearFilter)
                Data.DefaultView.RowFilter = filter
            End If
        End Sub
        Private Function GetMagnitudeFilter(ByVal min As Double, ByVal max As Double) As String
            Return String.Format(CultureInfo.InvariantCulture, "mag >= {0} AND mag <= {1}", min, max)
        End Function
        Private Function GetYearFilterString() As String
            Dim filter As String = ""
            Dim baseStr As String = "(yr = {0}) OR "

            For Each item As ListBoxEditItem In lbYearsFilter.SelectedItems
                Dim year As Integer = Convert.ToInt32(item.Tag)
                filter = String.Concat(filter, String.Format(baseStr, year))
            Next item
            If filter.Length > 0 Then
                filter = filter.Remove(filter.Length - 4, 4)
            End If
            Return If(filter.Length > 0, filter, "FALSE")
        End Function
        Private Sub lbYearsFilter_EditValueChanged(ByVal sender As Object, ByVal e As EditValueChangedEventArgs)
            Update()
        End Sub
        Private Sub tbMagnitudeFilter_EditValueChanged(ByVal sender As Object, ByVal e As EditValueChangedEventArgs)
            Update()
        End Sub
        Private Sub Update()
            Dim range As TrackBarEditRange = CType(tbMagnitudeFilter.EditValue, TrackBarEditRange)
            UpdateFilter(range.SelectionStart, range.SelectionEnd)
        End Sub
    End Class
End Namespace
