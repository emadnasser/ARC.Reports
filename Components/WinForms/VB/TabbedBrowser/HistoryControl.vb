Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo

Namespace TabbedBrowser
	Partial Public Class HistoryControl
		Inherits XtraUserControl
		Private allHistory As Dictionary(Of String, Date)
		Private data As List(Of HistoryItem)
		Private Shared ReadOnly itemClickCore As New Object()
		Public Custom Event ItemClick As EventHandler
			AddHandler(ByVal value As EventHandler)
				Events.AddHandler(itemClickCore, value)
			End AddHandler
			RemoveHandler(ByVal value As EventHandler)
				Events.RemoveHandler(itemClickCore, value)
			End RemoveHandler
			RaiseEvent(ByVal sender As Object, ByVal e As EventArgs)
			End RaiseEvent
		End Event
		Public Sub New()
			InitializeComponent()
			Me.allHistory = New Dictionary(Of String,Date)()
			data = New List(Of HistoryItem)()
		End Sub
		Private Sub FillGridWithHistoryItems()
			data.Clear()
			For Each item In allHistory
				data.Add(New HistoryItem() With {.Url = item.Key, .LastDate = item.Value.ToString()})
			Next item
			gridControl1.DataSource = data
		End Sub
		Private Sub OpenNew_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles barButtonItemNewTab.ItemClick, barButtonItemNewWindow.ItemClick
			Dim handler As EventHandler = CType(Events(itemClickCore), EventHandler)
			If handler IsNot Nothing Then
				handler(gridView1.GetFocusedRow(), e)
			End If
		End Sub
		Private Sub ClearHistory_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles barButtonItemClear.ItemClick
			Me.allHistory.Clear()
			Update(Me.allHistory)
		End Sub
		Public Overloads Sub Update(ByVal allHistory As Dictionary(Of String, Date))
			Me.allHistory = allHistory
			FillGridWithHistoryItems()
			gridView1.RefreshData()
        End Sub
        Private Sub gridView1_DoubleClick(ByVal sender As Object, ByVal e As EventArgs) Handles gridView1.DoubleClick
            Dim view As GridView = CType(sender, GridView)
            Dim pt As Point = view.GridControl.PointToClient(Control.MousePosition)
            If (DoRowDoubleClick(view, pt)) Then
                Dim handler As EventHandler = CType(Events(itemClickCore), EventHandler)
                If handler IsNot Nothing Then
                    handler(view.GetFocusedRow(), e)
                End If
            End If
        End Sub
        Private Function DoRowDoubleClick(ByVal view As GridView, ByVal pt As Point) As Boolean
            Dim info As GridHitInfo = view.CalcHitInfo(pt)
            If info.InRow Or info.InRowCell Then
                Return True
            End If
            Return False
        End Function
	End Class
	Friend Class HistoryItem
		Private urlCore, dateCore As String
		Public Property Url() As String
			Get
				Return urlCore
			End Get
			Set(ByVal value As String)
				urlCore = value
			End Set
		End Property
		Public Property LastDate() As String
			Get
				Return dateCore
			End Get
			Set(ByVal value As String)
				dateCore = value
			End Set
		End Property
	End Class
End Namespace
