Imports DevExpress.Xpo
Imports DevExpress.Persistent.Base
Imports DevExpress.Persistent.BaseImpl
Imports DevExpress.Persistent.Validation
Imports System.ComponentModel
Imports DevExpress.ExpressApp
Imports DevExpress.ExpressApp.ConditionalAppearance

<ImageName("BO_Folder"), NavigationItem("Planning")> _
Public Class Project
    Inherits BaseObject
    Public Sub New(ByVal session As Session)
        MyBase.New(session)
    End Sub
    <RuleRequiredField> _
    Public Property Name() As String
    Public Property Manager() As Person
    <Size(SizeAttribute.Unlimited)> _
    Public Property Description() As String
    <Association, Aggregated> _
    Public ReadOnly Property Tasks() As XPCollection(Of ProjectTask)
        Get
            Return GetCollection(Of ProjectTask)("Tasks")
        End Get
    End Property
End Class
Public Enum ProjectTaskStatus
    <ImageName("State_Task_NotStarted")> _
    NotStarted = 0
    <ImageName("State_Task_InProgress")> _
    InProgress = 1
    <ImageName("State_Validation_Valid")> _
    Completed = 2
    <ImageName("State_Task_Deferred")> _
    Deferred = 3
End Enum

<ImageName("BO_Task"), NavigationItem("Planning"), DefaultProperty("Subject"), DefaultListViewOptions(MasterDetailMode.ListViewOnly, True, NewItemRowPosition.Top), Appearance("Completed1", TargetItems:="Subject", Criteria:=ProjectTask.CompletedCriteria, FontStyle:=FontStyle.Strikeout, FontColor:="ForestGreen"), Appearance("Completed2", TargetItems:="*;Status;AssignedTo", Criteria:=ProjectTask.CompletedCriteria, Enabled:=False), Appearance("InProgress", TargetItems:="Subject;AssignedTo", Criteria:=ProjectTask.InProgressCriteria, BackColor:="LemonChiffon"), Appearance("Deferred", TargetItems:="Subject", Criteria:=ProjectTask.DeferredCriteria, BackColor:="MistyRose"), RuleCriteria("EndDate >= StartDate")> _
Public Class ProjectTask
    Inherits BaseObject
    Public Const CompletedCriteria As String = "Status = 'Completed'"
    Public Const DeferredCriteria As String = "Status = 'Deferred'"
    Public Const InProgressCriteria As String = "Status = 'InProgress'"
    Public Sub New(ByVal session As Session)
        MyBase.New(session)
    End Sub
    <Size(255), RuleRequiredField> _
    Public Property Subject() As String
    <ImmediatePostData> _
    Public Property Status() As ProjectTaskStatus
    <RuleRequiredField(TargetCriteria:=ProjectTask.CompletedCriteria)> _
    Public Property AssignedTo() As Person
    Public Property StartDate() As Date
    Public Property EndDate() As Date
    <Size(SizeAttribute.Unlimited)> _
    Public Property Notes() As String
    <Association> _
    Public Property Project() As Project
End Class
