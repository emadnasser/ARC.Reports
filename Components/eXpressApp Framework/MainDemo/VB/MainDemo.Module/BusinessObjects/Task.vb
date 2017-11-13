Imports System
Imports DevExpress.Xpo
Imports DevExpress.Persistent.Base
Imports DevExpress.Persistent.BaseImpl
Imports DevExpress.ExpressApp.ConditionalAppearance
Imports DevExpress.ExpressApp.Model

Namespace MainDemo.Module.BusinessObjects
    <DefaultClassOptions(), ModelDefault("Caption", "Task"), Appearance("FontColorRed", AppearanceItemType:="ViewItem", TargetItems:="*", Context:="ListView", Criteria:="Status!='Completed'", FontColor:="Red")> _
    Public Class DemoTask
        Inherits Task
        Implements IComparable
        Private priority_Renamed As Priority
        Private estimatedWork_Renamed As Integer
        Private actualWork_Renamed As Integer
        Public Sub New(ByVal session As Session)
            MyBase.New(session)
        End Sub
        <Appearance("PriorityBackColorPink", AppearanceItemType:="ViewItem", Criteria:="Priority=2", BackColor:="255, 240, 240")> _
        Public Property Priority() As Priority
            Get
                Return priority_Renamed
            End Get
            Set(ByVal value As Priority)
                SetPropertyValue("Priority", priority_Renamed, value)
            End Set
        End Property
        Public Overrides Sub AfterConstruction()
            MyBase.AfterConstruction()
            Priority = Priority.Normal
        End Sub
        <ToolTip("View, assign or remove contacts for the current task")> _
        <Association("Contact-DemoTask")> _
        Public ReadOnly Property Contacts() As XPCollection(Of Contact)
            Get
                Return GetCollection(Of Contact)("Contacts")
            End Get
        End Property
        Public Overrides Function ToString() As String
            Return Me.Subject
        End Function
        <Action(ToolTip:="Postpone the task to the next day", ImageName:="State_Task_Deferred")> _
        Public Sub Postpone()
            If DueDate = Date.MinValue Then
                DueDate = Date.Now
            End If
            DueDate = DueDate.Add(TimeSpan.FromDays(1))
        End Sub
        Public Property EstimatedWork() As Integer
            Get
                Return estimatedWork_Renamed
            End Get
            Set(ByVal value As Integer)
                SetPropertyValue(Of Integer)("EstimatedWork", estimatedWork_Renamed, value)
            End Set
        End Property
        Public Property ActualWork() As Integer
            Get
                Return actualWork_Renamed
            End Get
            Set(ByVal value As Integer)
                SetPropertyValue(Of Integer)("ActualWork", actualWork_Renamed, value)
            End Set
        End Property
    End Class
    Public Enum Priority
        <ImageName("State_Priority_Low")> _
        Low = 0
        <ImageName("State_Priority_Normal")> _
        Normal = 1
        <ImageName("State_Priority_High")> _
        High = 2
    End Enum
End Namespace
