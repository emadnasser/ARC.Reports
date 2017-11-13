Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Collections.ObjectModel
Imports System.Collections
Imports System.Diagnostics
Imports System.Threading
Imports System.ComponentModel
Imports DevExpress.Mvvm

Namespace GridDemo
    Public Class ChangeThread
        Private ReadOnly collection As New ObservableCollection(Of MarketData)()
        Public ReadOnly Property List() As IList
            Get
                Return Me.collection
            End Get
        End Property
        Public InterEventDelay As Integer = 1024000
        Public NeedStop As Boolean
        Private ReadOnly sw As Stopwatch
        Private ReadOnly Shared backgroundSw As New Stopwatch()
        Private ReadOnly Shared syncObject As New Object()
        Public Shared UserRealtimeSource As Boolean = True
        Private Shared ReadOnly Property backgroungTimerElapsed() As Integer
            Get
                SyncLock syncObject
                    Return CInt(backgroundSw.ElapsedMilliseconds)
                End SyncLock
            End Get
        End Property
        Private changesFromPriopChangePerSecond As Integer = 0
        Private priorChanges As Integer
        Public ReadOnly Property ChangePerSecond() As Integer
            Get
                If Interlocked.CompareExchange(changesFromPriopChangePerSecond, 0, 0) = 0 Then
                    Return priorChanges
                Else
                    Dim changes As Integer = Interlocked.Exchange(changesFromPriopChangePerSecond, 0)
                    Dim changeReportInterval As TimeSpan = sw.Elapsed
                    priorChanges = Convert.ToInt32(changes / changeReportInterval.TotalSeconds)
                    sw.Restart()
                    Return priorChanges
                End If
            End Get
        End Property
        Public Sub New()
            Me.NeedStop = False
            Me.sw = New Stopwatch()
            sw.Start()
            collection.Add(New MarketData("ANR"))
            collection.Add(New MarketData("FE"))
            collection.Add(New MarketData("GT"))
            collection.Add(New MarketData("PRGO"))
            collection.Add(New MarketData("APD"))
            collection.Add(New MarketData("PPL"))
            collection.Add(New MarketData("AES"))
            collection.Add(New MarketData("AVB"))
            collection.Add(New MarketData("IBM"))
            collection.Add(New MarketData("GAS"))
            collection.Add(New MarketData("EFX"))
            collection.Add(New MarketData("GPC"))
            collection.Add(New MarketData("ICE"))
            collection.Add(New MarketData("IVZ"))
            collection.Add(New MarketData("KO"))
            collection.Add(New MarketData("CCE"))
            collection.Add(New MarketData("SO"))
            collection.Add(New MarketData("STI"))
            collection.Add(New MarketData("BWA"))
            collection.Add(New MarketData("HRL"))
            collection.Add(New MarketData("WFM"))
            collection.Add(New MarketData("LM"))
            collection.Add(New MarketData("TROW"))
            collection.Add(New MarketData("K"))
            collection.Add(New MarketData("EXPE"))
            collection.Add(New MarketData("PCAR"))
            collection.Add(New MarketData("TRIP"))
            collection.Add(New MarketData("WHR"))
            collection.Add(New MarketData("WMT"))
            collection.Add(New MarketData("NU"))
            collection.Add(New MarketData("HST"))
            collection.Add(New MarketData("CVH"))
            collection.Add(New MarketData("LMT"))
            collection.Add(New MarketData("MAR"))
            collection.Add(New MarketData("CVC"))
            collection.Add(New MarketData("RF"))
            collection.Add(New MarketData("VMC"))
            collection.Add(New MarketData("PHM"))
            collection.Add(New MarketData("MU"))
            collection.Add(New MarketData("IRM"))
            collection.Add(New MarketData("AMT"))
            collection.Add(New MarketData("BXP"))
            collection.Add(New MarketData("STT"))
            collection.Add(New MarketData("PBCT"))
            collection.Add(New MarketData("FISV"))
            collection.Add(New MarketData("BLL"))
            collection.Add(New MarketData("MTB"))
            collection.Add(New MarketData("DIS"))
            collection.Add(New MarketData("LH"))
            collection.Add(New MarketData("AKAM"))
            collection.Add(New MarketData("CPB"))
            collection.Add(New MarketData("MYL"))
            collection.Add(New MarketData("LIFE"))
            collection.Add(New MarketData("LEG"))
            collection.Add(New MarketData("SCG"))
            collection.Add(New MarketData("CNX"))
            collection.Add(New MarketData("COL"))
            collection.Add(New MarketData("MCHP"))
            collection.Add(New MarketData("GR"))
            collection.Add(New MarketData("DUK"))
            collection.Add(New MarketData("BAC"))
            collection.Add(New MarketData("NUE"))
            collection.Add(New MarketData("UNM"))
            collection.Add(New MarketData("DLTR"))
            collection.Add(New MarketData("ABC"))
            collection.Add(New MarketData("TEG"))
            collection.Add(New MarketData("RRD"))
            collection.Add(New MarketData("EQR"))
            collection.Add(New MarketData("EXC"))
            collection.Add(New MarketData("BA"))
            collection.Add(New MarketData("CME"))
            collection.Add(New MarketData("NTRS"))
            collection.Add(New MarketData("VTR"))
            collection.Add(New MarketData("FITB"))
            collection.Add(New MarketData("PG"))
            collection.Add(New MarketData("KR"))
            collection.Add(New MarketData("M"))
            collection.Add(New MarketData("SNI"))
            collection.Add(New MarketData("ETN"))
            collection.Add(New MarketData("CLF"))
            collection.Add(New MarketData("PH"))
            collection.Add(New MarketData("KEY"))
            collection.Add(New MarketData("SHW"))
            collection.Add(New MarketData("HD"))
            collection.Add(New MarketData("AFL"))
            collection.Add(New MarketData("TSS"))
            collection.Add(New MarketData("CMI"))
            collection.Add(New MarketData("HBAN"))
            collection.Add(New MarketData("AEP"))
            collection.Add(New MarketData("BIG"))
            collection.Add(New MarketData("LTD"))
            collection.Add(New MarketData("ESRX"))
            collection.Add(New MarketData("GLW"))
            collection.Add(New MarketData("WPI"))
            collection.Add(New MarketData("MON"))
            collection.Add(New MarketData("AAPL"))
            collection.Add(New MarketData("DF"))
            collection.Add(New MarketData("T"))
            collection.Add(New MarketData("CMA"))
            collection.Add(New MarketData("THC"))
            collection.Add(New MarketData("LUV"))
            collection.Add(New MarketData("TXN"))
            collection.Add(New MarketData("TIE"))
            collection.Add(New MarketData("PX"))
        End Sub
        Public Sub [Do]()
            Dim rndRow As New Random()
            Do
                Dim watch As Stopwatch = Stopwatch.StartNew()
                Dim row As Integer = rndRow.Next(0, collection.Count)
                collection(row).Update()
                Interlocked.Increment(changesFromPriopChangePerSecond)
                Do
                    Dim elapsed = watch.ElapsedTicks
                    Dim left = InterEventDelay - elapsed
                    If left <= 0 Then
                        Do While (Not UserRealtimeSource) AndAlso backgroungTimerElapsed > 12
                            Thread.Sleep(2)
                        Loop
                        Exit Do
                    End If
                    If left > 2000 Then
                        Thread.Sleep(1)
                    Else
                        Thread.Sleep(0)
                    End If
                Loop
                watch.Stop()
            Loop While Not NeedStop
        End Sub
        Public Sub [Stop]()
            Me.NeedStop = True
        End Sub
        Public Shared Sub OnIdle(ByVal sender As Object, ByVal e As EventArgs)
            backgroundSw.Restart()
        End Sub
    End Class
    Public Class MarketData
        Inherits BindableBase

        Private ReadOnly Shared rnd As New Random()
        Private Const Max As Double = 950
        Private Const Min As Double = 350
        Private tickerCore As String
        Private lastCore As Double
        Private chgPercentCore As Double
        Private openCore As Double
        Private highCore As Double
        Private lowCore As Double
        Private dateCore As Date
        Private dayValCore As Double

        Public Sub New(ByVal name As String)
            tickerCore = name
            openCore = NextRnd() * (Max - Min) + Min
            dayValCore = Open
            UpdateInternal(Open)
        End Sub
        Public ReadOnly Property Ticker() As String
            Get
                Return tickerCore
            End Get
        End Property
        Public ReadOnly Property Last() As Double
            Get
                Return lastCore
            End Get
        End Property
        Public ReadOnly Property ChgPercent() As Double
            Get
                Return chgPercentCore
            End Get
        End Property
        Public ReadOnly Property Open() As Double
            Get
                Return openCore
            End Get
        End Property
        Public ReadOnly Property High() As Double
            Get
                Return highCore
            End Get
        End Property
        Public ReadOnly Property Low() As Double
            Get
                Return lowCore
            End Get
        End Property
        Public ReadOnly Property [Date]() As Date
            Get
                Return dateCore
            End Get
        End Property
        Public ReadOnly Property DayVal() As Double
            Get
                Return dayValCore
            End Get
        End Property

        Public Sub Update()
            Dim value As Double = DayVal - (Max - Min) * 0.05 + NextRnd() * (Max - Min) * 0.1
            If value <= Min Then
                value = Min
            End If
            If value >= Max Then
                value = Max
            End If
            UpdateInternal(value)
        End Sub
        Private Sub UpdateInternal(ByVal value As Double)
            lastCore = DayVal
            dayValCore = value
            chgPercentCore = (DayVal - Last) * 100.0 / DayVal
            highCore = Math.Max(Open, Math.Max(DayVal, Last))
            lowCore = Math.Min(Open, Math.Min(DayVal, Last))
            dateCore = Date.Now
            RaisePropertyChanged("")
        End Sub
        Private Shared Function NextRnd() As Double
            Dim value As Double = 0
            For i As Integer = 0 To 4
                value += rnd.NextDouble()
            Next i
            Return value / 5
        End Function
    End Class
End Namespace
