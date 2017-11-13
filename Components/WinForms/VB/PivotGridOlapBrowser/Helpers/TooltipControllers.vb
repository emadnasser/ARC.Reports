Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Text
Imports DevExpress.Utils
Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.XtraPivotGrid

Namespace PivotGridOlapBrowser.Helpers
	Public Class MethodDelayer
		Implements IDisposable
		Public Delegate Sub MethodDelegate()

		Private timer_Renamed As Timer
		Private ReadOnly method As MethodDelegate
		Private ReadOnly delay As Integer

		Public Sub New(ByVal method As MethodDelegate, ByVal delay As Integer)
			Me.method = method
			Me.delay = delay
		End Sub

		Protected ReadOnly Property Timer() As Timer
			Get
				If timer_Renamed Is Nothing Then
					timer_Renamed = New Timer()
					timer_Renamed.Interval = Me.delay
					timer_Renamed.Enabled = False
					AddHandler timer_Renamed.Tick, AddressOf timer_Tick
				End If
				Return timer_Renamed
			End Get
		End Property

		Private Sub timer_Tick(ByVal sender As Object, ByVal e As EventArgs)
			Timer.Stop()
			Me.method()
		End Sub

		Public Sub Invoke()
			If Me.delay = 0 Then
				Me.method()
				Return
			End If
			If Timer.Enabled Then
				Timer.Stop()
			End If
			Timer.Start()
		End Sub

		#Region "IDisposable Members"
		Public Sub Dispose() Implements IDisposable.Dispose
			Dispose(True)
			GC.SuppressFinalize(Me)
		End Sub
		Protected Overrides Sub Finalize()
			Dispose(False)
		End Sub
		Protected Overridable Sub Dispose(ByVal disposing As Boolean)
			If disposing Then
				If Me.timer_Renamed IsNot Nothing Then
					Me.timer_Renamed.Dispose()
					Me.timer_Renamed = Nothing
				End If
			End If
		End Sub
		#End Region
	End Class

	Public MustInherit Class ObjectToolTipController
		Implements IDisposable
		Private ReadOnly controller As ToolTipController
		Private ReadOnly parent As Control
		Private editObject_Renamed As Object
		Private location As Point

		Private delayer As MethodDelayer

		Public Sub New(ByVal parent As Control)
			Me.parent = parent
			AddHandler Me.parent.Disposed, AddressOf OnParentDisposed
			Me.controller = New ToolTipController()
			Me.controller.InitialDelay = 0
			Me.controller.ToolTipType = ToolTipType.SuperTip
			Me.controller.AllowHtmlText = True
			Me.controller.ReshowDelay = controller.InitialDelay
			Me.controller.AutoPopDelay = 10000
			Me.delayer = New MethodDelayer(AddressOf ShowHintCore, 500)
			AddHandler parent.MouseDown, AddressOf OnParentMouseDown
			AddHandler parent.MouseLeave, AddressOf OnParentMouseLeave
			Dim pivot As PivotGridControl = TryCast(parent, PivotGridControl)
			If pivot IsNot Nothing Then
				AddHandler pivot.LeftTopCellChanged, AddressOf OnPivotLeftTopCellChanged
			End If
		End Sub
		Private Sub OnParentDisposed(ByVal sender As Object, ByVal e As System.EventArgs)
			Dispose()
		End Sub
		Private Sub OnParentMouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
			HideHint(False)
		End Sub
		Private Sub OnParentMouseLeave(ByVal sender As Object, ByVal e As System.EventArgs)
			HideHint(True)
		End Sub
		Private Sub OnPivotLeftTopCellChanged(ByVal sender As Object, ByVal e As PivotLeftTopCellChangedEventArgs)
			HideHint(True)
		End Sub
		Public ReadOnly Property EditObject() As Object
			Get
				Return editObject_Renamed
			End Get
		End Property

		Public Sub ShowHint(ByVal editObject As Object, ByVal location As Point)
			If Object.Equals(editObject, Me.editObject_Renamed) Then
				Return
			End If
			Me.editObject_Renamed = editObject
			Me.location = location
			Me.delayer.Invoke()
		End Sub
		Private Sub ShowHintCore()
			Dim info As New ToolTipControlInfo()
			Dim item As New ToolTipItem()
			InitToolTipItem(item)
			item.ImageToTextDistance = 10
			info.Object = DateTime.Now.Ticks
			info.SuperTip = New SuperToolTip()
			info.SuperTip.Items.Add(item)
			info.ToolTipPosition = Me.parent.PointToScreen(Me.location)
			controller.ShowHint(info)
		End Sub
		Protected MustOverride Sub InitToolTipItem(ByVal item As ToolTipItem)
		Public Sub HideHint(ByVal clearCurrentObject As Boolean)
			If clearCurrentObject Then
				Me.editObject_Renamed = Nothing
			End If
			Me.controller.HideHint()
		End Sub

		#Region "IDisposable Members"
		Public Sub Dispose() Implements IDisposable.Dispose
			Me.Dispose(True)
			GC.SuppressFinalize(Me)
		End Sub
		Protected Overridable Sub Dispose(ByVal disposing As Boolean)
			If disposing Then
				Me.controller.Dispose()
				Me.delayer.Dispose()
			End If
		End Sub
		Protected Overrides Sub Finalize()
			Dispose(False)
		End Sub
		#End Region
	End Class

	Public MustInherit Class FieldValueTooltipController
		Inherits ObjectToolTipController
		Public Sub New(ByVal parent As PivotGridControl)
			MyBase.New(parent)
			AddHandler parent.FieldTooltipShowing, AddressOf OnFieldTooltipShowing
		End Sub

		Private Sub OnFieldTooltipShowing(ByVal sender As Object, ByVal e As PivotFieldTooltipShowingEventArgs)
			If e.HitInfo.HitTest = PivotGridHitTest.Value Then
				e.ShowTooltip = False
			End If
		End Sub
	End Class

	Public Class MemberPropertiesToolTipController
		Inherits FieldValueTooltipController
		Private Const MaxPhotoWidth As Integer = 120, MaxPhotoHeight As Integer = 120

		Public Sub New(ByVal parent As PivotGridControl)
			MyBase.New(parent)
		End Sub

		Private ReadOnly Property CurrentMember() As IOLAPMember
			Get
				Return TryCast(EditObject, IOLAPMember)
			End Get
		End Property

		Protected Overrides Sub InitToolTipItem(ByVal item As ToolTipItem)
			If CurrentMember Is Nothing Then
				Return
			End If
			Dim text As New StringBuilder()
			text.Append("<b>").Append(CurrentMember.Caption).Append(" (").Append(CurrentMember.Level.Caption).AppendLine(")</b>")
			For Each prop As OLAPMemberProperty In CurrentMember.Properties
				text.Append(prop.Name).Append(": ").Append(prop.Value).AppendLine()
			Next prop
			item.Text = text.ToString()
		End Sub
	End Class
End Namespace
