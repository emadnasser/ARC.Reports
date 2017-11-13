Imports System.Collections.Generic
Imports System

Namespace DevExpress.DevAV

    Friend MustInherit Class ProcessTracker
        Implements IObservable(Of String)

        Private observers As IList(Of IObserver(Of String))
        Protected Sub New()
            observers = New List(Of IObserver(Of String))()
        End Sub
        Public Function StartTracking(ByVal process As IProcess) As IDisposable
            Return New TrackingContext(process, Me)
        End Function
        Private Function IObservableGeneric_Subscribe(ByVal observer As IObserver(Of String)) As IDisposable Implements IObservable(Of String).Subscribe
            Return New Subscription(Me, observer)
        End Function
        Private Sub process_Start(ByVal sender As Object, ByVal e As ProcessStatusEventArgs)
            For Each observer As IObserver(Of String) In observers
                observer.OnNext(e.Status)
            Next observer
        End Sub
        Private Sub process_Running(ByVal sender As Object, ByVal e As ProcessStatusEventArgs)
            For Each observer As IObserver(Of String) In observers
                observer.OnNext(e.Status)
            Next observer
        End Sub
        Private Sub process_Complete(ByVal sender As Object, ByVal e As EventArgs)
            For Each observer As IObserver(Of String) In observers
                observer.OnCompleted()
            Next observer
        End Sub
        Private Class TrackingContext
            Implements IDisposable

            Private process As IProcess
            Private tracker As ProcessTracker
            Public Sub New(ByVal process As IProcess, ByVal tracker As ProcessTracker)
                AddHandler process.Start, AddressOf tracker.process_Start
                AddHandler process.Running, AddressOf tracker.process_Running
                AddHandler process.Complete, AddressOf tracker.process_Complete
                Me.process = process
                Me.tracker = tracker
            End Sub
            Private Sub IDisposable_Dispose() Implements IDisposable.Dispose
                RemoveHandler process.Start, AddressOf tracker.process_Start
                RemoveHandler process.Running, AddressOf tracker.process_Running
                RemoveHandler process.Complete, AddressOf tracker.process_Complete
                Me.tracker = Nothing
                Me.process = Nothing
            End Sub
        End Class
        Private Class Subscription
            Implements IDisposable

            Private observer As IObserver(Of String)
            Private tracker As ProcessTracker
            Public Sub New(ByVal tracker As ProcessTracker, ByVal observer As IObserver(Of String))
                If Not tracker.observers.Contains(observer) Then
                    tracker.observers.Add(observer)
                End If
                Me.tracker = tracker
                Me.observer = observer
            End Sub
            Private Sub IDisposable_Dispose() Implements IDisposable.Dispose
                tracker.observers.Remove(observer)
            End Sub
        End Class
    End Class
End Namespace
