Imports System.Threading
Imports System.Collections
Imports DevExpress.Data
Imports DevExpress.XtraCharts
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraGrid.Columns
Imports System.ComponentModel
Imports DevExpress.Skins

Namespace DevExpress.XtraGrid.Demos
    Partial Public Class RealTimeSourceDemo
        Inherits TutorialControl

        Private chtr As ChangeThread
        Private tr As Thread
        '<gridControl1>
        Private realTimeSource As RealTimeSource
        '</gridControl1>

        Private timerShow As Timer
        Private backgroundTimer As Timer
        Private syncContext As SynchronizationContext
        Private ReadOnly aEvent As New AutoResetEvent(True)
        Private ReadOnly editorProgressBar As RepositoryItemProgressBar
        Private isHide As Boolean = True
        Public Sub New()
            InitializeComponent()
            TutorialInfo.WhatsThisCodeFile = "VB\GridMainDemo\Modules\RealTimeSource.vb"
            TutorialInfo.WhatsThisXMLFile = "RealTimeSource.xml"
            editorProgressBar = New RepositoryItemProgressBar With {.Minimum = 300, .Maximum = 1000, .ShowTitle = True, .PercentView = False}
        End Sub

        Private Sub RealTimeSourceDemo_Disposed(ByVal sender As Object, ByVal e As EventArgs)
            DoHide()
        End Sub
        Protected Overrides Sub DoShow()
            MyBase.DoShow()
            isHide = False
            syncContext = SynchronizationContext.Current
            chtr = New ChangeThread(syncContext)
            trackBar1.Value = 10
            PatchInterval()
            '<gridControl1>
            realTimeSource = CreateRealTimeSource()
            gridControl1.DataSource = realTimeSource
            realTimeSource.DataSource = chtr.List
            '</gridControl1>
            timerShow = New Timer(AddressOf TimerShowCallback, Nothing, 0, 500)
            backgroundTimer = New Timer(AddressOf chtr.OnIdle, Nothing, TimeSpan.Zero, TimeSpan.FromMilliseconds(10))
            AddHandler Me.Disposed, AddressOf RealTimeSourceDemo_Disposed
            chartControl1.Series("UPSDiagram").Points.Clear()
            tr = New Thread(AddressOf chtr.Do)
            tr.IsBackground = True
            tr.Start()

            gridView1.GridControl.RepositoryItems.AddRange(New RepositoryItem() {editorProgressBar})
        End Sub
        Protected Overrides Sub DoHide()
            isHide = True
            chtr.Stop()
            If tr IsNot Nothing Then
                tr.Join()
            End If
            backgroundTimer.Dispose()
            timerShow.Dispose()
            If realTimeSource IsNot Nothing Then
                realTimeSource.DataSource = Nothing
                realTimeSource.Dispose()
            End If
            MyBase.DoHide()
        End Sub

        Private Shared Function CreateRealTimeSource() As RealTimeSource
            Dim rts As New RealTimeSource()
            Return rts
        End Function

        Private Sub TimerShowCallback(ByVal state As Object)
            If (Not aEvent.WaitOne(0)) OrElse isHide Then
                Return
            End If
            Dim changes As Double = chtr.ChangePerSecond
            aEvent.Reset()
            syncContext.Post(Function(x) AnonymousMethod1(x), changes)
        End Sub

        Private Function AnonymousMethod1(ByVal x As Object) As Boolean
            Try
                Dim changePerSecond As Double = CDbl(x)
                If chartControl1 IsNot Nothing AndAlso chartControl1.Series("UPSDiagram") IsNot Nothing AndAlso chartControl1.Series("UPSDiagram").Points IsNot Nothing Then
                    Do While chartControl1.Series("UPSDiagram").Points.Count >= 20
                        chartControl1.Series("UPSDiagram").Points.RemoveAt(0)
                    Loop
                    chartControl1.Series("UPSDiagram").Points.Add(New SeriesPoint(Date.Now.TimeOfDay.TotalSeconds, changePerSecond))
                End If
            Finally
                aEvent.Set()
            End Try
            Return True
        End Function

        Private Sub UnplugRTS_Click(ByVal sender As Object, ByVal e As EventArgs) Handles useRealtimeSource.CheckedChanged
            gridControl1.DataSource = Nothing
            If (Not useRealtimeSource.Checked) Then
                If realTimeSource IsNot Nothing Then
                    realTimeSource.DataSource = Nothing
                    realTimeSource.Dispose()
                    realTimeSource = Nothing
                End If
                chtr.UseRealtimeSource = False
                gridControl1.DataSource = chtr.List
            Else
                realTimeSource = CreateRealTimeSource()
                realTimeSource.DataSource = chtr.List
                gridControl1.DataSource = realTimeSource
                chtr.UseRealtimeSource = True
            End If
            PatchInterval()
        End Sub

        Private Sub trackBar1_Scroll(ByVal sender As Object, ByVal e As EventArgs) Handles trackBar1.ValueChanged
            If chtr Is Nothing Then
                Return
            End If
            PatchInterval()
        End Sub
        Private Sub PatchInterval()
            Dim pow As Double = (Me.trackBar1.Properties.Maximum - Me.trackBar1.Value + 3) / 2.0
            Me.chtr.InterEventDelay = CInt(Fix(Math.Pow(2.0, pow)))
        End Sub

        Private Sub gridView1_DataSourceChanged(ByVal sender As Object, ByVal e As EventArgs) Handles gridView1.DataSourceChanged
            Dim column As GridColumn = gridView1.Columns("DayVal")
            If column Is Nothing OrElse editorProgressBar Is Nothing Then
                Return
            End If
            column.ColumnEdit = editorProgressBar
        End Sub

        Private Sub gridView1_RowCellStyle(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs) Handles gridView1.RowCellStyle
            Dim val As Double = Convert.ToDouble(gridView1.GetRowCellValue(e.RowHandle, "ChgPercent"))
            If val < 0 Then
                e.Appearance.ForeColor = CommonColors.GetCriticalColor(DevExpress.LookAndFeel.UserLookAndFeel.Default)
            End If
        End Sub
    End Class
    Public Class ChangeThread
        Private ReadOnly collection As New BindingList(Of MarketData)()
        Public ReadOnly Property List() As IList
            Get
                Return Me.collection
            End Get
        End Property
        Private interEventDelay_Renamed As Integer = 1024000
        Public WriteOnly Property InterEventDelay() As Integer
            Set(ByVal value As Integer)
                Interlocked.Exchange(interEventDelay_Renamed, value)
            End Set
        End Property
        Private needStop As Integer
        Private ReadOnly sw As Stopwatch
        Private ReadOnly backgroundSw As New Stopwatch()
        Private useRealtimeSource_Renamed As Boolean = True
        Private ReadOnly context As SynchronizationContext
        Private changesFromPriopChangePerSecond As Integer = 0
        Private priorChanges As Integer
        Private lockObj As New Object()
        Public WriteOnly Property UseRealtimeSource() As Boolean
            Set(ByVal value As Boolean)
                SyncLock lockObj
                    useRealtimeSource_Renamed = value
                End SyncLock
            End Set
        End Property
        Public ReadOnly Property ChangePerSecond() As Integer
            Get
                If Interlocked.CompareExchange(changesFromPriopChangePerSecond, 0, 0) = 0 Then
                    Return priorChanges
                Else
                    Dim changes As Integer = Interlocked.Exchange(changesFromPriopChangePerSecond, 0)
                    Dim changeReportInterval As TimeSpan = sw.Elapsed
                    priorChanges = Convert.ToInt32(changes / changeReportInterval.TotalSeconds)
                    sw.Reset()
                    sw.Start()
                    Return priorChanges
                End If
            End Get
        End Property
        Public Sub New(ByVal context As SynchronizationContext)
            Dim data() As String = {"ANR", "FE", "GT", "PRGO", "APD", "PPL", "AES", "AVB", "IBM", "GAS", "EFX", "GPC", "ICE", "IVZ", "KO", "CCE", "SO", "STI", "BWA", "HRL", "WFM", "LM", "TROW", "K", "EXPE", "PCAR", "TRIP", "WHR", "WMT", "NU", "HST", "CVH", "LMT", "MAR", "CVC", "RF", "VMC", "PHM", "MU", "IRM", "AMT", "BXP", "STT", "PBCT", "FISV", "BLL", "MTB", "DIS", "LH", "AKAM", "CPB", "MYL", "LIFE", "LEG", "SCG", "CNX", "COL", "MCHP", "GR", "DUK", "BAC", "NUE", "UNM", "DLTR", "ABC", "TEG", "RRD", "EQR", "EXC", "BA", "CME", "NTRS", "VTR", "FITB", "PG", "KR", "M", "SNI", "ETN", "CLF", "PH", "KEY", "SHW", "HD", "AFL", "TSS", "CMI", "HBAN", "AEP", "BIG", "LTD", "ESRX", "GLW", "WPI", "MON", "AAPL", "DF", "T", "CMA", "THC", "LUV", "TXN", "TIE", "PX"}

            Me.sw = New Stopwatch()
            Me.context = context
            sw.Start()
            For Each name As String In data
                collection.Add(New MarketData(name))
            Next name
        End Sub

        Dim postedOperation As Integer = 0
        Public Sub [Do]()
            Dim rndRow As New Random()

            Do
                Dim watch As Stopwatch = Stopwatch.StartNew()
                Dim row_Renamed As Integer = rndRow.Next(0, collection.Count)
                SyncLock lockObj
                    If Not useRealtimeSource_Renamed Then
                        Interlocked.Increment(postedOperation)
                        context.Post(Function(x) AnonymousMethod1(x, row_Renamed), Nothing)
                    Else
                        collection(row_Renamed).Update()
                        collection.ResetItem(row_Renamed)
                    End If
                End SyncLock
                Me.changesFromPriopChangePerSecond += 1
                Do
                    Dim elapsed = watch.ElapsedTicks
                    Dim left = interEventDelay_Renamed - elapsed
                    If left <= 0 Then
                        If Not useRealtimeSource_Renamed Then
                            Thread.Sleep(0)
                            Do While backgroundSw.ElapsedMilliseconds > 12
                                If Interlocked.CompareExchange(needStop, 0, 0) <> 0 Then
                                    Exit Do
                                End If
                                Thread.Sleep(1)
                            Loop
                            If Interlocked.CompareExchange(postedOperation, 0, 0) > 100 Then
                                Do While Interlocked.CompareExchange(postedOperation, 0, 0) > 10
                                    If Interlocked.CompareExchange(needStop, 0, 0) <> 0 Then
                                        Exit Do
                                    End If
                                    Thread.Sleep(0)
                                Loop
                            End If
                        End If
                        Exit Do
                    End If
                    If left > 20000 Then
                        Thread.Sleep(1)
                    Else
                        Thread.Sleep(0)
                    End If
                Loop
                watch.Stop()
            Loop While Interlocked.CompareExchange(needStop, 0, 0) = 0
        End Sub

        Private Function AnonymousMethod1(ByVal x As Object, ByVal row_Renamed As Integer) As Boolean
            collection(row_Renamed).Update()
            collection.ResetItem(row_Renamed)
            Interlocked.Decrement(postedOperation)
            Return True
        End Function
        Public Sub [Stop]()
            Interlocked.Exchange(needStop, 1)
        End Sub
        Public Sub OnIdle(ByVal state As Object)
            context.Post(Function(x) AnonymousMethod3(x), Nothing)
        End Sub

        Private Function AnonymousMethod3(ByVal x As Object) As Boolean
            backgroundSw.Reset()
            backgroundSw.Start()
            Return True
        End Function
    End Class

    Public Class MarketData
        Private Shared ReadOnly rnd As New Random()
        Private Const MAX As Double = 950
        Private Const MIN As Double = 350
        Private privateTicker As String
        Public Property Ticker() As String
            Get
                Return privateTicker
            End Get
            Private Set(ByVal value As String)
                privateTicker = value
            End Set
        End Property
        Private last_Renamed As Double
        Public Property Last() As Double
            Get
                Return Math.Round(last_Renamed, 1)
            End Get
            Private Set(ByVal value As Double)
                last_Renamed = value
            End Set
        End Property
        Private chgPercent_Renamed As Double
        Public Property ChgPercent() As Double
            Get
                Return Math.Round(chgPercent_Renamed * 100, 2)
            End Get
            Private Set(ByVal value As Double)
                chgPercent_Renamed = value
            End Set
        End Property
        Private open_Renamed As Double
        Public Property Open() As Double
            Get
                Return Math.Round(open_Renamed, 1)
            End Get
            Private Set(ByVal value As Double)
                open_Renamed = value
            End Set
        End Property
        Private high_Renamed As Double
        Public Property High() As Double
            Get
                Return Math.Round(high_Renamed, 1)
            End Get
            Private Set(ByVal value As Double)
                high_Renamed = value
            End Set
        End Property
        Private low_Renamed As Double
        Public Property Low() As Double
            Get
                Return Math.Round(low_Renamed, 1)
            End Get
            Private Set(ByVal value As Double)
                low_Renamed = value
            End Set
        End Property
        Public [Date] As Date
        Public ReadOnly Property Time() As String
            Get
                Return [Date].ToLongTimeString()
            End Get
        End Property
        Private dayVal_Renamed As Double
        Public Property DayVal() As Double
            Get
                Return Math.Round(dayVal_Renamed, 1)
            End Get
            Private Set(ByVal value As Double)
                dayVal_Renamed = value
            End Set
        End Property

        Public Sub New(ByVal name As String)
            Ticker = name
            Open = (NextRnd() * (MAX - MIN)) + MIN
            DayVal = open_Renamed
            UpdateInternal(Open)
        End Sub
        Public Sub Update()
            Dim value As Double = DayVal - (MAX - MIN) * 0.05 + NextRnd() * (MAX - MIN) * 0.1
            If value <= MIN Then
                value = MIN
            End If
            If value >= MAX Then
                value = MAX
            End If
            UpdateInternal(value)
        End Sub
        Private Sub UpdateInternal(ByVal dayVal As Double)
            Last = Me.DayVal
            Me.DayVal = dayVal
            ChgPercent = (Me.DayVal - Last) / Me.DayVal
            High = Math.Max(Open, Math.Max(Me.DayVal, Last))
            Low = Math.Min(Open, Math.Min(Me.DayVal, Last))
            Me.Date = Date.Now
        End Sub
        Private Function NextRnd() As Double
            Dim value As Double = 0
            For i As Integer = 0 To 4
                value += rnd.NextDouble()
            Next i
            Return value / 5
        End Function
    End Class

End Namespace
