Imports System

Namespace DevExpress.DevAV

    Public Interface IProcess
        Event Start As ProcessStatusEventHandler
        Event Running As ProcessStatusEventHandler
        Event Complete As EventHandler
    End Interface
    Public Delegate Sub ProcessStatusEventHandler(ByVal sender As Object, ByVal e As ProcessStatusEventArgs)
    Public Class ProcessStatusEventArgs
        Inherits EventArgs

        Public Sub New(ByVal status As String)
            Me.Status = status
        End Sub
        Private privateStatus As String
        Public Property Status() As String
            Get
                Return privateStatus
            End Get
            Private Set(ByVal value As String)
                privateStatus = value
            End Set
        End Property
    End Class
    Friend Class StartUpProcess
        Implements IProcess, IDisposable

        Private Shared process As StartUpProcess
        Private tracker As IDisposable
        Public Sub New()
            process = Me
            tracker = StartUpProcessTracker.Instance.StartTracking(Me)
        End Sub
        Private Sub IDisposable_Dispose() Implements IDisposable.Dispose
            tracker.Dispose()
            process = Nothing
        End Sub
        Public Shared ReadOnly Property Status() As IObservable(Of String)
            Get
                Return StartUpProcessTracker.Instance
            End Get
        End Property
        Public Shared Sub OnStart(ByVal status As String)
            If process IsNot Nothing Then
                process.RaiseStart(status)
            End If
        End Sub
        Public Shared Sub OnRunning(ByVal status As String)
            If process IsNot Nothing Then
                process.RaiseRunning(status)
            End If
        End Sub
        Public Shared Sub OnComplete()
            If process IsNot Nothing Then
                process.RaiseComplete()
            End If
        End Sub
        #Region "ProcessTracker"
        Private Class StartUpProcessTracker
            Inherits ProcessTracker

            Friend Shared Instance As New StartUpProcessTracker()
        End Class
        #End Region ' ProcessTracker
        #Region "IProcess Members"
        Private startCore As ProcessStatusEventHandler
        Private Custom Event Start As ProcessStatusEventHandler Implements IProcess.Start
            AddHandler(ByVal value As ProcessStatusEventHandler)
                startCore = DirectCast(System.Delegate.Combine(startCore, value), ProcessStatusEventHandler)
            End AddHandler
            RemoveHandler(ByVal value As ProcessStatusEventHandler)
                startCore = DirectCast(System.Delegate.Remove(startCore, value), ProcessStatusEventHandler)
            End RemoveHandler
            RaiseEvent(ByVal sender As Object, ByVal e As ProcessStatusEventArgs)
                If startCore IsNot Nothing Then
                    For Each d As ProcessStatusEventHandler In startCore.GetInvocationList()
                        d.Invoke(sender, e)
                    Next d
                End If
            End RaiseEvent
        End Event
        Private runningCore As ProcessStatusEventHandler
        Private Custom Event Running As ProcessStatusEventHandler Implements IProcess.Running
            AddHandler(ByVal value As ProcessStatusEventHandler)
                runningCore = DirectCast(System.Delegate.Combine(runningCore, value), ProcessStatusEventHandler)
            End AddHandler
            RemoveHandler(ByVal value As ProcessStatusEventHandler)
                runningCore = DirectCast(System.Delegate.Remove(runningCore, value), ProcessStatusEventHandler)
            End RemoveHandler
            RaiseEvent(ByVal sender As Object, ByVal e As ProcessStatusEventArgs)
                If runningCore IsNot Nothing Then
                    For Each d As ProcessStatusEventHandler In runningCore.GetInvocationList()
                        d.Invoke(sender, e)
                    Next d
                End If
            End RaiseEvent
        End Event
        Private completeCore As EventHandler
        Private Custom Event Complete As EventHandler Implements IProcess.Complete
            AddHandler(ByVal value As EventHandler)
                completeCore = DirectCast(System.Delegate.Combine(completeCore, value), EventHandler)
            End AddHandler
            RemoveHandler(ByVal value As EventHandler)
                completeCore = DirectCast(System.Delegate.Remove(completeCore, value), EventHandler)
            End RemoveHandler
            RaiseEvent(ByVal sender As System.Object, ByVal e As System.EventArgs)
                If completeCore IsNot Nothing Then
                    For Each d As EventHandler In completeCore.GetInvocationList()
                        d.Invoke(sender, e)
                    Next d
                End If
            End RaiseEvent
        End Event
        Private Sub RaiseStart(ByVal status As String)
            If startCore IsNot Nothing Then
                startCore(Me, New ProcessStatusEventArgs(status))
            End If
        End Sub
        Private Sub RaiseRunning(ByVal status As String)
            If runningCore IsNot Nothing Then
                runningCore(Me, New ProcessStatusEventArgs(status))
            End If
        End Sub
        Private Sub RaiseComplete()
            If completeCore IsNot Nothing Then
                completeCore(Me, EventArgs.Empty)
            End If
        End Sub
        #End Region
    End Class
End Namespace
