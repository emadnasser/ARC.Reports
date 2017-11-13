Imports System
Imports System.Windows
Imports System.Windows.Media
Imports System.Windows.Media.Animation
Imports DevExpress.Xpf.Utils
Imports System.Windows.Threading
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Collections.ObjectModel
Imports System.Collections.Specialized
Imports System.Collections
Imports DevExpress.Mvvm

Namespace GridDemo
    Public Class ProcessInfoAnimationElement
        Inherits FrameworkContentElement

        Public Shared ReadOnly CpuUsageProperty As DependencyProperty
        Public Shared ReadOnly MemoryUsageColorProperty As DependencyProperty
        Public Shared ReadOnly RevealProgressProperty As DependencyProperty
        Shared Sub New()
            CpuUsageProperty = DependencyPropertyManager.Register("CpuUsage", GetType(Double), GetType(ProcessInfoAnimationElement), New PropertyMetadata(0R))
            MemoryUsageColorProperty = DependencyPropertyManager.Register("MemoryUsageColor", GetType(Color), GetType(ProcessInfoAnimationElement), New PropertyMetadata(Color.FromArgb(&HFF, &H92, &H96, &H9C)))
            RevealProgressProperty = DependencyPropertyManager.Register("RevealProgress", GetType(Double), GetType(ProcessInfoAnimationElement), New PropertyMetadata(1R))
        End Sub
        Public Property CpuUsage() As Double
            Get
                Return DirectCast(GetValue(CpuUsageProperty), Double)
            End Get
            Set(ByVal value As Double)
                SetValue(CpuUsageProperty, value)
            End Set
        End Property
        Public Property MemoryUsageColor() As Color
            Get
                Return DirectCast(GetValue(MemoryUsageColorProperty), Color)
            End Get
            Set(ByVal value As Color)
                SetValue(MemoryUsageColorProperty, value)
            End Set
        End Property
        Public Property RevealProgress() As Double
            Get
                Return DirectCast(GetValue(RevealProgressProperty), Double)
            End Get
            Set(ByVal value As Double)
                SetValue(RevealProgressProperty, value)
            End Set
        End Property
    End Class
    Public Class ProcessInfo
        Inherits BindableBase


        Private pid_Renamed As Integer
        Private nameCore As String
        Private memoryUsageCore, cpuUsageCore As Integer
        Private isNew As Boolean

        Private history_Renamed As New CpuUsageHistory()
        Public ReadOnly Property History() As Object
            Get
                Return history_Renamed
            End Get
        End Property
        Public Sub New(ByVal pid As Integer, ByVal name As String, ByVal memoryUsage As Integer, ByVal cpuUsage As Integer, ByVal isNew As Boolean)
            Me.pid_Renamed = pid
            Me.nameCore = name
            Me.memoryUsageCore = memoryUsage
            Me.cpuUsageCore = cpuUsage
            Me.isNew = isNew
        End Sub
        Friend Property IsDeleting() As Boolean
        Public Property PID() As Integer
            Get
                Return pid_Renamed
            End Get
            Set(ByVal value As Integer)
                SetProperty(pid_Renamed, value, "PID")
            End Set
        End Property
        Public Property Name() As String
            Get
                Return nameCore
            End Get
            Set(ByVal value As String)
                SetProperty(nameCore, value, "Name")
            End Set
        End Property
        Public Property MemoryUsage() As Integer
            Get
                Return memoryUsageCore
            End Get
            Set(ByVal value As Integer)
                SetProperty(memoryUsageCore, value, "MemoryUsage")
            End Set
        End Property
        Public Property CpuUsage() As Integer
            Get
                Return cpuUsageCore
            End Get
            Set(ByVal value As Integer)
                SetProperty(cpuUsageCore, value, "CpuUsage")
            End Set
        End Property
        <Browsable(False)>
        Public Property Owner() As ProcessGenerator
    End Class
    Public Class ProcessInfoList
        Inherits ObservableCollection(Of ProcessInfo)

    End Class
    Public Class ProcessGenerator
        Inherits BindableBase

        Public Enum ProcessUpdateMode
            AddRemoveUpdate
            AddRemove
            Update
        End Enum
        Private Enum UpdateType
            Add
            Remove
            Change
        End Enum

        Private Const DefaultUpdateInterval As Double = 200R
        Private Const DefaultUpdateDuration As Double = 600R
        Private Const DefaultUpdateHistoryInterval As Double = 1000R
        Private Const DefaultProcessMaxCount As Integer = 25, DefaultProcessMinCount As Integer = 10
        Private ReadOnly ProcessNames() As String = {"wininit.exe", "svchost.exe", "svchost.exe", "svchost.exe", "svchost.exe", "System", "devenv.exe", "intetinfo.exe", "lsm.exe", "lsass.exe", "winlogon.exe", "services.exe"}

        Private updateIntervalCore As Double = DefaultUpdateInterval
        Private updateHistoryIntervalCore As Double = DefaultUpdateHistoryInterval
        Private processMaxCountCore As Integer = DefaultProcessMaxCount
        Private processMinCountCore As Integer = DefaultProcessMinCount
        Private updateModeCore As ProcessUpdateMode = ProcessUpdateMode.AddRemoveUpdate

        Private dispatcher As Dispatcher

        Private processes_Renamed As ProcessInfoList

        Private updateTimer_Renamed As DispatcherTimer
        Private realProcessCount As Integer
        Private [module] As ManagingLiveData
        Private random As New Random()
        Private animationElements As New Dictionary(Of Integer, ProcessInfoAnimationElement)()
        Public Sub New(ByVal [module] As ManagingLiveData)
            dispatcher = System.Windows.Threading.Dispatcher.CurrentDispatcher
            Me.processes_Renamed = New ProcessInfoList()
            Me.updateTimer_Renamed = New DispatcherTimer()
            Me.updateTimer_Renamed.Interval = TimeSpan.FromMilliseconds(DefaultUpdateInterval)
            AddHandler Me.updateTimer_Renamed.Tick, AddressOf OnTimerTick
            Me.updateHistoryTimer = New DispatcherTimer()
            Me.updateHistoryTimer.Interval = TimeSpan.FromMilliseconds(DefaultUpdateHistoryInterval)
            AddHandler Me.updateHistoryTimer.Tick, AddressOf OnHistoryTimerTick
            Me.module = [module]
        End Sub
        Public ReadOnly Property Processes() As ProcessInfoList
            Get
                Return processes_Renamed
            End Get
        End Property
        Protected Friend ReadOnly Property UpdateTimer() As DispatcherTimer
            Get
                Return updateTimer_Renamed
            End Get
        End Property
        Private Delegate Sub UpdateDelegate()
        Private Sub OnUpdateIntervalChanged()
            Me.UpdateTimer.Interval = TimeSpan.FromMilliseconds(UpdateInterval)
        End Sub
        Private Sub OnUpdateHistoryIntervalChanged()
            Me.updateHistoryTimer.Interval = TimeSpan.FromMilliseconds(UpdateHistoryInterval)
        End Sub
        Private Sub OnTimerTick(ByVal sender As Object, ByVal e As EventArgs)
            dispatcher.BeginInvoke(New Action(AddressOf UpdateProcessList), DispatcherPriority.Background)
        End Sub
        Private updateHistoryTimer As DispatcherTimer
        Private Sub OnHistoryTimerTick(ByVal sender As Object, ByVal e As EventArgs)
            For Each item As ProcessInfo In Processes
                DirectCast(item.History, CpuUsageHistory).AddHistoryValue(item.CpuUsage)
            Next item
        End Sub
        Protected Sub UpdateProcessList()
            PerformRandomUpdate()
        End Sub
        Private Function GetUpdateType() As UpdateType
            If CanAddRemove Then
                If CanUpdate Then
                    Return CType(random.Next(3), UpdateType)
                End If
                Return CType(random.Next(2), UpdateType)
            End If
            Return UpdateType.Change
        End Function
        Private ReadOnly Property CanAddRemove() As Boolean
            Get
                Return UpdateMode = ProcessUpdateMode.AddRemoveUpdate OrElse UpdateMode = ProcessUpdateMode.AddRemove
            End Get
        End Property
        Private ReadOnly Property CanUpdate() As Boolean
            Get
                Return UpdateMode = ProcessUpdateMode.AddRemoveUpdate OrElse UpdateMode = ProcessUpdateMode.Update
            End Get
        End Property

        Private Class ProcessToRemove
            Public Property ProcToRemove() As ProcessInfo
            Public Property ProcGenerator() As ProcessGenerator

            Public Sub OnStoryboardCompleted(ByVal sender As Object, ByVal e As EventArgs)
                ProcGenerator.RemoveProcess(ProcToRemove)
            End Sub
        End Class
        Protected Sub PerformRandomUpdate()
            Dim duration As TimeSpan = TimeSpan.FromMilliseconds(600)
            Dim info As ProcessInfo
            Select Case GetUpdateType()
                Case UpdateType.Add
                    info = AddProcess(True)
                    If info IsNot Nothing AndAlso [module].newRowCheckBox.IsChecked.Value Then
                        Dim storyboard As Storyboard = GetStoryboard("newRowStoryboard")
                        BeginStoryboard(storyboard, info, ProcessInfoAnimationElement.RevealProgressProperty)
                    End If
                Case UpdateType.Remove
                    If realProcessCount > 0 AndAlso realProcessCount > ProcessMinCount Then
                        info = GetRandomProcess()
                        realProcessCount -= 1
                        If [module].deleteRowCheckBox.IsChecked.Value Then
                            info.IsDeleting = True
                            Dim storyboard As Storyboard = GetStoryboard("deleteRowStoryboard")
                            Dim procToRemove As New ProcessToRemove() With {.ProcToRemove = info, .ProcGenerator = Me}
                            AddHandler storyboard.Completed, AddressOf procToRemove.OnStoryboardCompleted
                            BeginStoryboard(storyboard, info, ProcessInfoAnimationElement.RevealProgressProperty)
                        Else
                            RemoveProcess(info)
                        End If
                    End If
                Case UpdateType.Change
                    If realProcessCount > 0 Then
                        ModifyMemoryUsage()
                        ModifyCpuUsage()
                    End If
            End Select
        End Sub
        Private Sub RemoveProcess(ByVal info As ProcessInfo)
            Processes.Remove(info)
            animationElements.Remove(info.PID)
        End Sub
        Private Function GetStoryboard(ByVal resourceKey As String) As Storyboard
            Return StoryboardContainer.CreateStoryboard([module], resourceKey)
        End Function
        Private Sub BeginStoryboard(ByVal storyboard As Storyboard, ByVal info As ProcessInfo, ByVal [property] As DependencyProperty)
            System.Windows.Media.Animation.Storyboard.SetTargetProperty(storyboard, New PropertyPath([property].GetName()))
            System.Windows.Media.Animation.Storyboard.SetTarget(storyboard, GetAnimationElement(info))
            storyboard.Begin()
        End Sub
        Private Sub ModifyMemoryUsage()
            Dim info As ProcessInfo = GetRandomProcess()
            Dim oldMemoryUsageValue As Double = info.MemoryUsage
            info.MemoryUsage = random.Next(10000)

            If [module].memoryUsageCheckBox.IsChecked.Value Then
                Dim storyboard As Storyboard = GetStoryboard(If(oldMemoryUsageValue < info.MemoryUsage, "memoryUsageIncreasedColorStoryboard", "memoryUsageDecreasedColorStoryboard"))
                BeginStoryboard(storyboard, info, ProcessInfoAnimationElement.MemoryUsageColorProperty)
            End If
        End Sub
        Private Sub ModifyCpuUsage()
            Dim info As ProcessInfo = GetRandomProcess()
            info.CpuUsage = random.Next(60)
            Dim storyboard As Storyboard
            If [module].cpuUsageCheckBox.IsChecked.Value Then
                storyboard = GetStoryboard("cpuUsageChangeStoryboard")
                Dim animation As DoubleAnimationUsingKeyFrames = CType(storyboard.Children(0), DoubleAnimationUsingKeyFrames)
                animation.KeyFrames(0).Value = GetAnimationElement(info).CpuUsage
                animation.KeyFrames(1).Value = info.CpuUsage
            Else
                storyboard = New Storyboard()
                storyboard.Children.Add(New DoubleAnimation() With {.Duration = TimeSpan.Zero, .To = info.CpuUsage})
            End If
            BeginStoryboard(storyboard, info, ProcessInfoAnimationElement.CpuUsageProperty)
        End Sub
        Private Function GetRandomProcess() As ProcessInfo
            Do
                Dim info As ProcessInfo = Processes(random.Next(Processes.Count))
                If Not info.IsDeleting Then
                    Return info
                End If
            Loop
        End Function
        Private counter As Integer
        Private Function AddProcess(ByVal isNew As Boolean) As ProcessInfo
            Dim info As ProcessInfo = Nothing
            If realProcessCount < ProcessMaxCount Then
                Dim name As String = ProcessNames(random.Next(ProcessNames.Length))
                counter += 1
                info = New ProcessInfo(counter, name, random.Next(10000), random.Next(100), isNew)
                GetAnimationElement(info).CpuUsage = info.CpuUsage
                Processes.Insert(random.Next(Processes.Count), info)
                realProcessCount += 1
            End If
            Return info
        End Function
        Public Sub Initialize()
            Me.counter = 0
            Processes.Clear()
            realProcessCount = 0
            For i As Integer = 0 To ProcessMaxCount - 1
                AddProcess(False)
            Next i
        End Sub
        Public Sub Start()
            UpdateTimer.Start()
            updateHistoryTimer.Start()
        End Sub
        Public Sub [Stop]()
            UpdateTimer.Stop()
            updateHistoryTimer.Stop()
        End Sub
        Public Function GetAnimationElement(ByVal info As ProcessInfo) As ProcessInfoAnimationElement
            Dim result As ProcessInfoAnimationElement = Nothing
            If Not animationElements.TryGetValue(info.PID, result) Then
                result = New ProcessInfoAnimationElement()
                animationElements.Add(info.PID, result)
            End If
            Return result
        End Function
        Public Property UpdateInterval() As Double
            Get
                Return updateIntervalCore
            End Get
            Set(ByVal value As Double)
                SetProperty(updateIntervalCore, value, "UpdateInterval", AddressOf OnUpdateIntervalChanged)
            End Set
        End Property
        Public Property UpdateHistoryInterval() As Double
            Get
                Return updateHistoryIntervalCore
            End Get
            Set(ByVal value As Double)
                SetProperty(updateHistoryIntervalCore, value, "UpdateHistoryInterval", AddressOf OnUpdateHistoryIntervalChanged)
            End Set
        End Property
        Public Property ProcessMaxCount() As Integer
            Get
                Return processMaxCountCore
            End Get
            Set(ByVal value As Integer)
                SetProperty(processMaxCountCore, value, "ProcessMaxCount")
            End Set
        End Property
        Public Property ProcessMinCount() As Integer
            Get
                Return processMinCountCore
            End Get
            Set(ByVal value As Integer)
                SetProperty(processMinCountCore, value, "ProcessMinCount")
            End Set
        End Property
        Public Property UpdateMode() As ProcessUpdateMode
            Get
                Return updateModeCore
            End Get
            Set(ByVal value As ProcessUpdateMode)
                SetProperty(updateModeCore, value, "UpdateMode")
            End Set
        End Property
    End Class
    Public Class LiveDataChartElement
        Inherits FrameworkElement

        Private Const BarWidth As Integer = 4
        Private Const BarSpace As Integer = 1
        Private Const SegmentHeight As Integer = 2
        Private Const SegmentSpace As Integer = 1
        Private Const MaxBarHeight As Double = 19
        Public Shared ReadOnly CpuUsageHistoryProperty As DependencyProperty
        Public Shared ReadOnly BarBrushesProperty As DependencyProperty
        Shared Sub New()
            CpuUsageHistoryProperty = DependencyProperty.Register("CpuUsageHistory", GetType(CpuUsageHistory), GetType(LiveDataChartElement), New FrameworkPropertyMetadata(Nothing, New PropertyChangedCallback(AddressOf OnCpuUsageHistoryChanged)))
            BarBrushesProperty = DependencyProperty.Register("BarBrushes", GetType(IList), GetType(LiveDataChartElement), New FrameworkPropertyMetadata(Nothing, FrameworkPropertyMetadataOptions.AffectsRender))
        End Sub
        Private Shared Sub OnCpuUsageHistoryChanged(ByVal d As DependencyObject, ByVal e As DependencyPropertyChangedEventArgs)
            CType(d, LiveDataChartElement).OnCpuUsageHistoryChanged(DirectCast(e.OldValue, CpuUsageHistory))
        End Sub
        Public Property CpuUsageHistory() As CpuUsageHistory
            Get
                Return DirectCast(GetValue(CpuUsageHistoryProperty), CpuUsageHistory)
            End Get
            Set(ByVal value As CpuUsageHistory)
                SetValue(CpuUsageHistoryProperty, value)
            End Set
        End Property
        Public Property BarBrushes() As IList
            Get
                Return DirectCast(GetValue(BarBrushesProperty), IList)
            End Get
            Set(ByVal value As IList)
                SetValue(BarBrushesProperty, value)
            End Set
        End Property
        Protected Overrides Sub OnRender(ByVal drawingContext As DrawingContext)
            MyBase.OnRender(drawingContext)
            If CpuUsageHistory Is Nothing OrElse BarBrushes Is Nothing Then
                Return
            End If
            Dim barCount As Integer = CInt((Math.Floor((ActualWidth - BarWidth) / (BarWidth + BarSpace) + 1)))
            Dim startHitoryIndex As Integer = Math.Max(0, CpuUsageHistory.Count - barCount)
            For i As Integer = startHitoryIndex To CpuUsageHistory.Count - 1
                Dim placeIndex As Integer = i - startHitoryIndex

                Dim height_Renamed As Double = Math.Round(MaxBarHeight * (CpuUsageHistory(i) / 100R))
                Dim segmentCount As Integer = CInt((Math.Floor((height_Renamed - SegmentHeight) / (SegmentHeight + SegmentSpace) + 1)))
                For j As Integer = 0 To segmentCount - 1
                    Dim rect As New Rect(placeIndex * (BarWidth + BarSpace), ActualHeight - j * (SegmentHeight + SegmentSpace), BarWidth, SegmentHeight)
                    drawingContext.DrawRectangle(DirectCast(BarBrushes(j), Brush), Nothing, rect)
                Next j
            Next i
        End Sub
        Private Sub OnCpuUsageHistoryChanged(ByVal oldValue As CpuUsageHistory)
            If oldValue IsNot Nothing Then
                RemoveHandler oldValue.CollectionChanged, AddressOf OnCpuUsageHistoryCollectionChanged
            End If
            If CpuUsageHistory IsNot Nothing Then
                AddHandler CpuUsageHistory.CollectionChanged, AddressOf OnCpuUsageHistoryCollectionChanged
            End If
            InvalidateVisual()
        End Sub

        Private Sub OnCpuUsageHistoryCollectionChanged(ByVal sender As Object, ByVal e As NotifyCollectionChangedEventArgs)
            InvalidateVisual()
        End Sub
    End Class
    Public Class CpuUsageHistory
        Inherits ObservableCollection(Of Double)

        Public Sub AddHistoryValue(ByVal value As Double)
            Add(value)
            If Count > 100 Then
                RemoveAt(0)
            End If
        End Sub
    End Class
End Namespace
