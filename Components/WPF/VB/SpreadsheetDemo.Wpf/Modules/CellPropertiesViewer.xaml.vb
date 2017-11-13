Imports DevExpress.Mvvm
Imports DevExpress.Spreadsheet
Imports System
Imports System.ComponentModel
Imports CellValue = DevExpress.Spreadsheet.CellValue
Namespace SpreadsheetDemo
    Partial Public Class CellPropertiesViewer
        Inherits SpreadsheetDemoModule

        Public Sub New()
            InitializeComponent()
            DataContext = New RangeAdapter()
            Me.spreadsheetControl1.Options.Culture = DefaultCulture
            Dim loaded As Boolean = Me.spreadsheetControl1.Document.LoadDocument(DemoUtils.GetRelativePath("CellPropertiesViewer_template.xlsx"))
            System.Diagnostics.Debug.Assert(loaded)
        End Sub

        Private Sub CustomExpand(ByVal sender As Object, ByVal args As DevExpress.Xpf.PropertyGrid.CustomExpandEventArgs)
            args.IsExpanded = True
        End Sub
    End Class
    Public Class RangeAdapter
        Inherits BindableBase


        Private range_Renamed As Range

        Public Sub New()
        End Sub
        Public Property Range() As Range
            Get
                Return range_Renamed
            End Get
            Set(ByVal value As Range)
                range_Renamed = value
                RaiseChanges()
            End Set
        End Property

        Private Sub RaiseChanges()
            RaisePropertyChanged(Function() Range)
            RaisePropertyChanged(Function() Cell)
            RaisePropertyChanged(Function() Value)
            RaisePropertyChanged(Function() ArrayFormula)
            RaisePropertyChanged(Function() Formula)
            RaisePropertyChanged(Function() Alignment)
            RaisePropertyChanged(Function() Borders)
            RaisePropertyChanged(Function() Fill)
            RaisePropertyChanged(Function() Font)
            RaisePropertyChanged(Function() Style)
            RaisePropertyChanged(Function() NumberFormat)
            RaisePropertyChanged(Function() Width)
            RaisePropertyChanged(Function() Height)
            RaisePropertyChanged(Function() WidthInCharacters)
            RaisePropertyChanged(Function() Protection)
            RaisePropertyChanged(Function() Locked)
        End Sub
        Public ReadOnly Property Cell() As Cell
            Get
                If Range Is Nothing Then
                    Return Nothing
                End If
                Return Range.Worksheet.Cells(Range.TopRowIndex, Range.LeftColumnIndex)
            End Get
        End Property
        <Category("CellContent")>
        Public ReadOnly Property Value() As CellValue
            Get
                If Range Is Nothing Then
                    Return Nothing
                End If
                Return Range.Value
            End Get
        End Property
        <Category("CellContent")>
        Public Property ArrayFormula() As String
            Get
                If Cell Is Nothing Then
                    Return Nothing
                End If
                Return Cell.ArrayFormula
            End Get
            Set(ByVal value As String)
                If Cell Is Nothing Then
                    Return
                End If
                Cell.ArrayFormula = value
            End Set
        End Property
        <Category("CellContent")>
        Public Property Formula() As String
            Get
                If Cell Is Nothing Then
                    Return Nothing
                End If
                Return Cell.Formula
            End Get
            Set(ByVal value As String)
                If Cell Is Nothing Then
                    Return
                End If
                Cell.Formula = value
            End Set
        End Property

        <Category("Formatting")>
        Public ReadOnly Property Alignment() As Alignment
            Get
                If Range Is Nothing Then
                    Return Nothing
                End If
                Return Range.Alignment
            End Get
        End Property
        <Category("Formatting")>
        Public ReadOnly Property Borders() As Borders
            Get
                If Range Is Nothing Then
                    Return Nothing
                End If
                Return Range.Borders
            End Get
        End Property
        <Category("Formatting")>
        Public ReadOnly Property Fill() As Fill
            Get
                If Range Is Nothing Then
                    Return Nothing
                End If
                Return Range.Fill
            End Get
        End Property
        <Category("Formatting")>
        Public ReadOnly Property Font() As DevExpress.Spreadsheet.SpreadsheetFont
            Get
                If Range Is Nothing Then
                    Return Nothing
                End If
                Return Range.Font
            End Get
        End Property
        <Category("Formatting")>
        Public ReadOnly Property Style() As Style
            Get
                If Range Is Nothing Then
                    Return Nothing
                End If
                Return Range.Style
            End Get
        End Property
        <Category("Formatting")>
        Public Property NumberFormat() As String
            Get
                If Cell Is Nothing Then
                    Return Nothing
                End If
                Return Cell.NumberFormat
            End Get
            Set(ByVal value As String)
                If Cell Is Nothing Then
                    Return
                End If
                Cell.NumberFormat = value
            End Set
        End Property

        <Category("Layout")>
        Public Property Width() As Double
            Get
                Return If(Range Is Nothing, 0R, Range.ColumnWidth)
            End Get
            Set(ByVal value As Double)
                If Range Is Nothing Then
                    Return
                End If
                Range.ColumnWidth = value
            End Set
        End Property
        <Category("Layout")>
        Public Property Height() As Double
            Get
                Return If(Range Is Nothing, 0R, Range.RowHeight)
            End Get
            Set(ByVal value As Double)
                If Range Is Nothing Then
                    Return
                End If
                Range.RowHeight = value
            End Set
        End Property
        <Category("Layout")>
        Public Property WidthInCharacters() As Double
            Get
                Return If(Range Is Nothing, 0R, Range.ColumnWidthInCharacters)
            End Get
            Set(ByVal value As Double)
                If Range Is Nothing Then
                    Return
                End If
                Range.ColumnWidthInCharacters = value
            End Set
        End Property

        <Category("Protection"), Browsable(False)>
        Public ReadOnly Property Protection() As Protection
            Get
                If Range Is Nothing Then
                    Return Nothing
                End If
                Return Range.Protection
            End Get
        End Property
        <Category("Protection")>
        Public Property Locked() As Boolean
            Get
                Return If(Protection Is Nothing, False, Protection.Locked)
            End Get
            Set(ByVal value As Boolean)
                If Protection Is Nothing Then
                    Return
                End If
                Protection.Locked = value
            End Set
        End Property
    End Class
End Namespace
