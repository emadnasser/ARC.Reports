Imports System.Collections
Imports System.ComponentModel
Imports System.Reflection
Imports DevExpress.Utils
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.Grid

Namespace DevExpress.XtraGrid.Demos
    Partial Public Class GridSheet
        Inherits TutorialControl

        '<gridControl1>
        Private spread As New SpreadData()
        '</gridControl1>

        Public Sub New()
            ' This call is required by the Windows Form Designer.
            InitializeComponent()
            TutorialInfo.WhatsThisCodeFile = "VB\GridMainDemo\Modules\GridSheet.vb"
            TutorialInfo.WhatsThisXMLFile = "GridSheet.xml"
            CreateUserAppearances()
            '<gridControl1>
            Me.spread.CreateGridDataSource(gridView1, Me.repositoryItemSpinEdit, Me.appHeader)
            gridControl1.DataSource = Me.spread
            '</gridControl1>
            OnStyleChanged()
        End Sub

        Private appStyle1, appStyle2, appHeader As AppearanceDefault

        Protected Overrides Sub OnSwitchStyle()
            'gridView1.RowHeight = GridHelper.GetGridViewInfo(gridView1).MinRowHeight + 2;
        End Sub

        Private Sub CreateUserAppearances()
            appStyle1 = New AppearanceDefault(SystemColors.ActiveCaptionText, SystemColors.ActiveCaption, DevExpress.Utils.HorzAlignment.Center, DevExpress.Utils.VertAlignment.Default, AppearanceObject.DefaultFont)
            appStyle2 = New AppearanceDefault(SystemColors.Highlight, SystemColors.Control, DevExpress.Utils.HorzAlignment.Center, DevExpress.Utils.VertAlignment.Default, New Font(AppearanceObject.DefaultFont, FontStyle.Bold))
            appHeader = New AppearanceDefault(SystemColors.WindowText, SystemColors.Control, DevExpress.Utils.HorzAlignment.Center, DevExpress.Utils.VertAlignment.Default, AppearanceObject.DefaultFont)
            appStyle1.BorderColor = appStyle1.BackColor
            appStyle2.BorderColor = appStyle2.BackColor
            appHeader.BorderColor = appHeader.BackColor
        End Sub
        Sub UpdateAppearance(focused As Boolean, appObject As AppearanceObject)
            If focused Then
                AppearanceHelper.Apply(appObject, If(IsXPStyle, appStyle2, appStyle1))
            Else
                AppearanceHelper.Apply(appObject, appHeader)
            End If
        End Sub
        Private Sub gridView1_CustomDrawRowIndicator(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs) Handles gridView1.CustomDrawRowIndicator
            Dim rowIndex As Integer = e.RowHandle
            If rowIndex >= 0 Then
                rowIndex += 1
                e.Info.DisplayText = rowIndex.ToString()
            End If
            UpdateAppearance(e.RowHandle = gridView1.FocusedRowHandle, e.Appearance)
            e.Info.ImageIndex = -1
        End Sub

        Private ReadOnly Property IsXPStyle() As Boolean
            Get
                Return True
            End Get
        End Property
        Private Sub gridView1_CustomDrawColumnHeader(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.ColumnHeaderCustomDrawEventArgs) Handles gridView1.CustomDrawColumnHeader
            UpdateAppearance(e.Column Is gridView1.FocusedColumn, e.Appearance)
        End Sub

        Private Sub gridView1_FocusedColumnChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedColumnChangedEventArgs) Handles gridView1.FocusedColumnChanged
            Me.gridView1.InvalidateColumnHeader(e.PrevFocusedColumn)
            Me.gridView1.InvalidateColumnHeader(e.FocusedColumn)
        End Sub

        '<gridControl1>
        '~Calculate values for the unbound Total column:
        Private Sub gridView1_CustomUnboundColumnData(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs) Handles gridView1.CustomUnboundColumnData
            If e.IsGetData Then
                e.Value = Me.spread.GetCell(e.ListSourceRowIndex, e.Column.ColumnHandle)
            Else
                Me.spread.SetCell(e.ListSourceRowIndex, e.Column.ColumnHandle, e.Value)
            End If
        End Sub
        '~Update summaries when cell values change:
        Private Sub gridView1_CellValueChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles gridView1.CellValueChanged
            Me.gridView1.UpdateTotalSummary()
        End Sub

        '~Calculate summaries via the Spread object and provide summary values to the grid immediately once a summary calculation has been started:
        Private Sub gridView1_CustomSummaryCalculate(ByVal sender As Object, ByVal e As DevExpress.Data.CustomSummaryEventArgs) Handles gridView1.CustomSummaryCalculate
            If e.SummaryProcess = DevExpress.Data.CustomSummaryProcess.Start Then
                e.TotalValueReady = True
                Dim item As GridSummaryItem = CType(e.Item, GridSummaryItem)
                e.TotalValue = Me.spread.GetSummary(CType(item.Tag, GridColumn).ColumnHandle)
            End If
        End Sub
        '</gridControl1>

        Private Sub gridView1_CustomDrawCell(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs) Handles gridView1.CustomDrawCell
            If e.Column.AbsoluteIndex = Me.gridView1.Columns.Count - 1 Then
                Dim propertyInfo As PropertyInfo = GetType(DevExpress.XtraGrid.Views.Base.BaseView).GetProperty("Painter", BindingFlags.Instance Or BindingFlags.NonPublic)
                If propertyInfo IsNot Nothing Then
                    Dim painter As DevExpress.XtraGrid.Views.Grid.Drawing.GridPainter = TryCast(propertyInfo.GetValue(Me.gridView1, Nothing), DevExpress.XtraGrid.Views.Grid.Drawing.GridPainter)
                    If painter IsNot Nothing Then
                        Dim ci As New DevExpress.XtraGrid.Drawing.GridFooterCellInfoArgs()
                        If e.CellValue IsNot Nothing Then
                            ci.DisplayText = e.CellValue.ToString()
                        Else
                            ci.DisplayText = "0"
                        End If
                        ci.Bounds = e.Bounds
                        Dim cache As New DevExpress.Utils.Drawing.GraphicsCache(e.Graphics)
                        ci.Cache = cache
                        ci.Appearance.Assign(gridView1.PaintAppearance.FooterPanel)
                        painter.ElementsPainter.FooterCell.CalcObjectBounds(ci)
                        Dim caption As String = ci.DisplayText
                        ci.DisplayText = ""
                        Dim r As Rectangle = ci.Bounds
                        r.Inflate(-2, 0)
                        painter.ElementsPainter.FooterPanel.DrawObject(ci)
                        painter.ElementsPainter.FooterCell.DrawObject(ci)
                        ci.Appearance.DrawString(cache, caption, r)
                        e.Handled = True
                        cache.Dispose()
                    End If
                End If
            End If
        End Sub

        Protected Overrides Sub OnStyleChanged()
            MyBase.OnStyleChanged()
            appHeader.ForeColor = ColorHelper.GetHeaderForeColor(gridControl1.LookAndFeel)
        End Sub
    End Class
    '<gridControl1>
    Public Class SpreadData
        Implements IList, ITypedList

        Private fData As New Hashtable()
        '~Row number
        Private fCount As Integer = 1000000
        Public Const ColumnCount As Integer = 257
        Public Const TotalColumn As Integer = ColumnCount - 1
        Public Sub New()
        End Sub
        Private Function ITypedList_GetItemProperties(ByVal listAccessor() As PropertyDescriptor) As PropertyDescriptorCollection Implements ITypedList.GetItemProperties
            Return Nothing
        End Function
        Private Function ITypedList_GetListName(ByVal listAccessor() As PropertyDescriptor) As String Implements ITypedList.GetListName
            Return ""
        End Function
        Friend Sub CreateGridDataSource(ByVal view As GridView, ByVal editor As DevExpress.XtraEditors.Repository.RepositoryItem, ByVal totalAppearance As AppearanceDefault)
            view.BeginDataUpdate()
            view.Columns.Clear()
            Try
                For i As Integer = 0 To SpreadData.ColumnCount - 1
                    Dim col As New GridColumn()
                    view.Columns.Add(col)
                    col.FieldName = GetColumnCaption(i)
                    col.Caption = col.FieldName
                    col.UnboundType = DevExpress.Data.UnboundColumnType.Decimal
                    col.Visible = True
                    col.SummaryItem.Tag = col
                    col.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Custom
                    col.ColumnEdit = editor
                    If IsTotalColumn(i) Then
                        col.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Right
                        col.AppearanceHeader.Assign(totalAppearance)
                        col.OptionsColumn.ReadOnly = True
                        col.OptionsColumn.AllowEdit = False
                        col.OptionsColumn.AllowMove = False
                    End If
                Next i
            Finally
                view.EndDataUpdate()
            End Try
        End Sub
        Private Function IsTotalColumn(ByVal col As Integer) As Boolean
            Return col = TotalColumn
        End Function
        Private Function GetColumnCaption(ByVal col As Integer) As String
            If IsTotalColumn(col) Then
                Return My.Resources.Total
            End If
            Const bchar As Char = "A"c
            Const echar As Char = "Z"c
            Dim max As Integer = AscW(echar) - AscW(bchar) + 1
            Dim d As Integer = col \ max
            Dim res As String = String.Empty
            If d > 0 Then
                res &= ChrW(AscW(bchar) + d - 1)
            End If
            res &= ChrW(AscW(bchar) + col Mod max)
            Return res
        End Function


        Public Sub UpdateRowSummary(ByVal row_Renamed As Integer)
            Dim res As Decimal = 0
            For n As Integer = 0 To ColumnCount - 2
                res += GetCellDecimal(row_Renamed, n)
            Next n
            SetCell(row_Renamed, TotalColumn, res)
        End Sub
        Private Function GetCellDecimal(ByVal row_Renamed As Integer, ByVal col As Integer) As Decimal
            Dim val As Object = GetCell(row_Renamed, col)
            If val Is Nothing Then
                Return 0
            End If
            Return CDec(val)
        End Function

        Public Function GetSummary(ByVal col As Integer) As Decimal
            Dim hash As Hashtable = CType(Me.fData(col), Hashtable)
            If hash Is Nothing Then
                Return 0
            End If
            Dim res As Decimal = 0
            For Each obj As Object In hash.Values
                res += CDec(obj)
            Next obj
            Return res
        End Function
        Public Sub SetCell(ByVal row_Renamed As Integer, ByVal col As Integer, ByVal val As Object)
            Dim hash As Hashtable = CType(Me.fData(col), Hashtable)
            If hash Is Nothing Then
                hash = New Hashtable()
                hash(row_Renamed) = val
                Me.fData(col) = hash
            Else
                hash(row_Renamed) = val
            End If
            If col <> TotalColumn Then
                UpdateRowSummary(row_Renamed)
            End If
        End Sub
        Public Function GetCell(ByVal row_Renamed As Integer, ByVal col As Integer) As Object
            Dim hash As Hashtable = CType(Me.fData(col), Hashtable)
            If hash Is Nothing Then
                Return Nothing
            End If
            Return hash(row_Renamed)
        End Function

        Public ReadOnly Property Count() As Integer Implements System.Collections.ICollection.Count
            Get
                Return fCount
            End Get
        End Property

        Default Public Property Item(ByVal index As Integer) As Object Implements IList.Item
            Get
                Return index
            End Get
            Set(ByVal value As Object)
            End Set
        End Property

        Public ReadOnly Property IsReadOnly() As Boolean Implements IList.IsReadOnly
            Get
                Return False
            End Get
        End Property
        Public Sub RemoveAt(ByVal index As Integer) Implements IList.RemoveAt
        End Sub
        Public Sub Insert(ByVal index As Integer, ByVal value As Object) Implements IList.Insert
        End Sub
        Public Sub Remove(ByVal value As Object) Implements IList.Remove
        End Sub
        Public Function Contains(ByVal value As Object) As Boolean Implements IList.Contains
            Return True
        End Function
        Public Sub Clear() Implements IList.Clear
        End Sub
        Public Function IndexOf(ByVal value As Object) As Integer Implements IList.IndexOf
            Return -1
        End Function
        Public Function Add(ByVal value As Object) As Integer Implements IList.Add
            Return -1
        End Function
        Public ReadOnly Property IsFixedSize() As Boolean Implements IList.IsFixedSize
            Get
                Return True
            End Get
        End Property
        Public ReadOnly Property IsSynchronized() As Boolean Implements System.Collections.ICollection.IsSynchronized
            Get
                Return True
            End Get
        End Property
        Public Sub CopyTo(ByVal array As Array, ByVal index As Integer) Implements System.Collections.ICollection.CopyTo
        End Sub
        Public ReadOnly Property SyncRoot() As Object Implements System.Collections.ICollection.SyncRoot
            Get
                Return Me
            End Get
        End Property
        Public Function GetEnumerator() As IEnumerator Implements System.Collections.IEnumerable.GetEnumerator
            Return Nothing
        End Function
    End Class
    '</gridControl1>
End Namespace

