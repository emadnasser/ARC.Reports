Imports DevExpress.Xpf.DemoBase
Imports DevExpress.Xpf.Utils.Themes
Imports System.Windows
Imports DevExpress.Xpf.Scheduler
Imports System.Collections.Generic
Imports System
Imports DevExpress.XtraScheduler

Namespace SchedulerDemo
    Public Class SchedulerDemoModule
        Inherits DemoModule

        Public Shared ReadOnly SchedulerControlProperty As DependencyProperty

        Shared Sub New()
            SchedulerControlProperty = DependencyProperty.Register("SchedulerControl", GetType(SchedulerControl), GetType(SchedulerDemoModule), New PropertyMetadata(Nothing))
        End Sub

        Private ReadOnly views_Renamed As New List(Of SchedulerViewBase)()

        Public Property SchedulerControl() As SchedulerControl
            Get
                Return CType(GetValue(SchedulerControlProperty), SchedulerControl)
            End Get
            Set(ByVal value As SchedulerControl)
                SetValue(SchedulerControlProperty, value)
            End Set
        End Property
        Protected ReadOnly Property Views() As List(Of SchedulerViewBase)
            Get
                Return views_Renamed
            End Get
        End Property

        Public Overrides Sub OnApplyTemplate()
            MyBase.OnApplyTemplate()
            If SchedulerControl Is Nothing Then
                SchedulerControl = FindScheduler()
            End If
        End Sub
        Private Sub PopulateSchedulerViewList(ByVal scheduler As SchedulerControl)
            views_Renamed.Add(scheduler.DayView)
            views_Renamed.Add(scheduler.WorkWeekView)
            views_Renamed.Add(scheduler.WeekView)
            views_Renamed.Add(scheduler.MonthView)
            views_Renamed.Add(scheduler.TimelineView)
        End Sub

        Protected Overrides Function GetModuleDataContext() As Object
            Return FindScheduler()
        End Function
        Protected Overridable Function FindScheduler() As SchedulerControl
            Return CType(DemoModuleControl.FindDemoContent(GetType(SchedulerControl), CType(DemoModuleControl.Content, DependencyObject)), SchedulerControl)
        End Function

        Protected Sub InitializeScheduler()
            InitializeScheduler(False)
        End Sub
        Protected Sub InitializeScheduler(ByVal bindToDatabase As Boolean)
            Dim scheduler As SchedulerControl = FindScheduler()
            If scheduler Is Nothing Then
                Return
            End If
            If bindToDatabase Then
                SchedulerDataHelper.DataBindToDatabase(scheduler)
            Else
                SchedulerDataHelper.DataBind(scheduler)
            End If
            InitializeSchedulerProperties(scheduler)
        End Sub
        Protected Sub LoadDefaultAppoinmentStatuses(ByVal scheduler As SchedulerControl)
            scheduler.Storage.InnerStorage.Appointments.Statuses.LoadDefaults()
        End Sub
        Protected Sub InitializeSchedulerProperties(ByVal scheduler As SchedulerControl)
            PopulateSchedulerViewList(scheduler)
            scheduler.ShowBorder = False
            scheduler.Start = New Date(2016, 7, 13)
            AddHandler scheduler.CustomizeMessageBoxCaption, AddressOf Scheduler_CustomizeMessageBoxCaption
        End Sub

        Protected Overrides Sub RaiseBeforeModuleDisappear()
            Dim scheduler As SchedulerControl = FindScheduler()
            If scheduler IsNot Nothing Then
                SchedulerDataHelper.DataUnbind(scheduler)
                RemoveHandler scheduler.CustomizeMessageBoxCaption, AddressOf Scheduler_CustomizeMessageBoxCaption
            End If

            MyBase.RaiseBeforeModuleDisappear()
        End Sub

        Private Sub Scheduler_CustomizeMessageBoxCaption(ByVal sender As Object, ByVal e As CustomizeMessageBoxCaptionEventArgs)
            e.Caption = "DX Scheduler for WPF"
        End Sub
    End Class
End Namespace
