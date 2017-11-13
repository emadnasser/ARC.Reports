Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports DevExpress.Xpf.DemoBase.Helpers
Imports System.Threading
Imports System.Windows.Threading
Imports System.Collections
Imports DevExpress.Mvvm

Namespace GridDemo
    Public Class RealtimeDataSourceViewModel
        Inherits BindableBase


        Private ReadOnly changeThread_Renamed As ChangeThread
        Private ReadOnly thread As Thread
        Private ReadOnly timerShow As DispatcherTimer
        Private ReadOnly backgroundTimer As DispatcherTimer

        Public Sub New()
            changeThread_Renamed = New ChangeThread()
            Dim chtrDo As ThreadStart = CType(System.Delegate.CreateDelegate(GetType(ThreadStart), changeThread_Renamed, "Do"), ThreadStart)
            thread = New Thread(chtrDo)
            thread.IsBackground = True
            changeThread_Renamed.NeedStop = False
            timerShow = New DispatcherTimer(TimeSpan.FromSeconds(0.5), DispatcherPriority.Send, AddressOf TimerShowCallback, Dispatcher.CurrentDispatcher)
            Dim onIdle As EventHandler = CType(System.Delegate.CreateDelegate(GetType(EventHandler), GetType(ChangeThread), "OnIdle"), EventHandler)
            backgroundTimer = New DispatcherTimer(TimeSpan.FromMilliseconds(10), DispatcherPriority.Background, onIdle, Dispatcher.CurrentDispatcher)
            thread.Start()
        End Sub

        Public Event TimerShowTick As EventHandler
        Public ReadOnly Property ChangePerSecond() As Integer
            Get
                Return changeThread_Renamed.ChangePerSecond
            End Get
        End Property
        Public WriteOnly Property InterEventDelay() As Integer
            Set(ByVal value As Integer)
                Interlocked.Exchange(changeThread_Renamed.InterEventDelay, value)
            End Set
        End Property

        Private withRealTimeSource_Renamed As Boolean
        Public Property WithRealTimeSource() As Boolean
            Get
                Return withRealTimeSource_Renamed
            End Get
            Set(ByVal value As Boolean)
                SetProperty(withRealTimeSource_Renamed, value, Function() WithRealTimeSource)
            End Set
        End Property
        Public ReadOnly Property List() As IList
            Get
                Return changeThread_Renamed.List
            End Get
        End Property
        Public Sub Update()
            WithRealTimeSource = Not WithRealTimeSource
            If WithRealTimeSource Then
                GridDemo.ChangeThread.UserRealtimeSource = True
            Else
                GridDemo.ChangeThread.UserRealtimeSource = False
            End If
        End Sub
        Public Sub Dispose()
            changeThread_Renamed.Stop()
            timerShow.Stop()
            backgroundTimer.Stop()
        End Sub
        Private Sub TimerShowCallback(ByVal sender As Object, ByVal e As EventArgs)
            RaiseTimerShowTickEvent()
        End Sub
        Private Sub RaiseTimerShowTickEvent()
            RaiseEvent TimerShowTick(Me, EventArgs.Empty)
        End Sub
    End Class
End Namespace
