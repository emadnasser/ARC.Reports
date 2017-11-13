Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports DevExpress.XtraEditors

Namespace PhotoViewer
	Partial Public Class DateFilter
		Inherits XtraUserControl
		Private Shared ReadOnly selectionChangedCore As Object = New Object()
        Public Sub New()
            InitializeComponent()
            AddHandler Me.calendar.SizeChanged, AddressOf OnStartDateSizeChanged
        End Sub
        Private Sub OnStartDateSizeChanged(sender As Object, e As EventArgs)
            UpdateStartDateLocation()
        End Sub
        Protected Overrides Sub OnSizeChanged(ByVal e As EventArgs)
            MyBase.OnSizeChanged(e)
            UpdateStartDateLocation()
        End Sub
        Private Sub UpdateStartDateLocation()
            Dim pt As Point = New Point(DisplayRectangle.X + (DisplayRectangle.Width - calendar.Width) \ 2, DisplayRectangle.Y + (panel1.Top - DisplayRectangle.Y - calendar.Height) \ 2)
            pt.X = Math.Max(0, pt.X)
            pt.Y = Math.Max(0, pt.Y)
            calendar.Location = pt
        End Sub
		Public ReadOnly Property StartDate() As DateTime
			Get
				If AllowFilter Then
					Return calendar.SelectionStart
				Else
					Return DateTime.MinValue
				End If
			End Get
		End Property
		Public ReadOnly Property EndDate() As DateTime
			Get
				If AllowFilter Then
					Return calendar.SelectionEnd
				Else
					Return DateTime.MinValue
				End If
			End Get
		End Property
		Public ReadOnly Property AllowFilter() As Boolean
			Get
				Return allowFilterCheck.Checked
			End Get
		End Property
		Protected Sub RaiseSelectionChanged()
			Dim handler As EventHandler = TryCast(Events(selectionChangedCore), EventHandler)
			If handler IsNot Nothing Then
				handler(Me, EventArgs.Empty)
			End If
		End Sub
		Public Custom Event SelectionChanged As EventHandler
			AddHandler(ByVal value As EventHandler)
				Events.AddHandler(selectionChangedCore, value)
			End AddHandler
			RemoveHandler(ByVal value As EventHandler)
				Events.RemoveHandler(selectionChangedCore, value)
			End RemoveHandler
			RaiseEvent(ByVal sender As System.Object, ByVal e As System.EventArgs)
			End RaiseEvent
		End Event
		Private Sub allowFilterCheck_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles allowFilterCheck.CheckedChanged
			RaiseSelectionChanged()
		End Sub
		Private Sub startDate_SelectionChanged(ByVal sender As Object, ByVal e As EventArgs) Handles calendar.SelectionChanged
			RaiseSelectionChanged()
		End Sub
		Private Sub endDate_SelectionChanged(ByVal sender As Object, ByVal e As EventArgs)
			RaiseSelectionChanged()
		End Sub
	End Class
End Namespace
