Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports System.Data
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraEditors
Imports DevExpress.XtraBars.Ribbon
Imports System.IO

Namespace DevExpress.XtraBars.Demos.RibbonSimplePad
	Partial Public Class RecentItemsControl
		Inherits RibbonApplicationUserControl
		Public Sub New()
			InitializeComponent()
			mruFileList_Renamed = New MRUArrayList(splitContainer1.Panel1, imageCollection3.Images(0), imageCollection3.Images(1), imageCollection1.Images(0), False, True)
			AddHandler mruFileList_Renamed.LabelClicked, AddressOf mruFileList_LabelClicked
			mruFolderList_Renamed = New MRUArrayList(panel2, imageCollection3.Images(0), imageCollection3.Images(1), imageCollection1.Images(1), False, True)
			AddHandler mruFolderList_Renamed.LabelClicked, AddressOf mruFolderList_LabelClicked
		End Sub

		Private Sub mruFolderList_LabelClicked(ByVal sender As Object, ByVal e As EventArgs)
			System.Diagnostics.Process.Start("explorer.exe", CStr(sender))
			BackstageView.Ribbon.HideApplicationButtonContentControl()
		End Sub

		Private Sub mruFileList_LabelClicked(ByVal sender As Object, ByVal e As EventArgs)
			Dim frm As frmMain = CType(BackstageView.Ribbon.FindForm(), frmMain)
			frm.OpenFile(CStr(sender))
			BackstageView.Ribbon.HideApplicationButtonContentControl()
		End Sub
		Private mruFileList_Renamed As MRUArrayList
		Private mruFolderList_Renamed As MRUArrayList
		Public ReadOnly Property MRUFileList() As MRUArrayList
			Get
				Return mruFileList_Renamed
			End Get
		End Property
		Public ReadOnly Property MRUFolderList() As MRUArrayList
			Get
				Return mruFolderList_Renamed
			End Get
		End Property

		Private Sub checkEdit1_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles checkEdit1.CheckedChanged
			spinEdit1.Enabled = checkEdit1.Checked
			UpdateRecentItems()
		End Sub
		Private Sub spinEdit1_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles spinEdit1.EditValueChanged
			UpdateRecentItems()
		End Sub
		Private Sub ClearRecentItems()
			If BackstageView Is Nothing Then
				Return
			End If
			Dim i As Integer = 0
			Do While i < BackstageView.Items.Count
				Dim item As BackstageViewButtonItem = TryCast(BackstageView.Items(i), BackstageViewButtonItem)
				If (item IsNot Nothing AndAlso item.Tag IsNot Nothing) OrElse TypeOf BackstageView.Items(i) Is BackstageViewItemSeparator Then
					If item IsNot Nothing Then
						RemoveHandler item.ItemClick, AddressOf OnRecentItemClick
					End If
					BackstageView.Items.RemoveAt(i)
				Else
					i += 1
				End If
			Loop
		End Sub
		Private Sub UpdateRecentItems()
            If IsNothing(BackstageView) Then
                Return
            End If
            BackstageView.BeginUpdate()
			Try
				ClearRecentItems()
				If checkEdit1.Checked Then
					InitRecentItems()
				End If
			Finally
				BackstageView.EndUpdate()
			End Try
		End Sub
		Private Sub InitRecentItems()
			BackstageView.Items.Insert(4, New BackstageViewItemSeparator())
			Dim itemCount As Integer = Math.Min(MRUFileList.Count, CInt(Fix(spinEdit1.Value)))
			For i As Integer = 0 To itemCount - 1
				Dim item As New BackstageViewButtonItem()
				item.Caption = Path.GetFileName(CStr(MRUFileList(i)))
				item.Glyph = imageCollection3.Images(2)
				item.Tag = CStr(MRUFileList(i))
				AddHandler item.ItemClick, AddressOf OnRecentItemClick
				BackstageView.Items.Insert(5+i, item)
			Next i
		End Sub
		Private Sub OnRecentItemClick(ByVal sender As Object, ByVal e As BackstageViewItemEventArgs)
			Dim frm As frmMain = CType(BackstageView.Ribbon.FindForm(), frmMain)
			frm.OpenFile(CStr(e.Item.Tag))
			BackstageView.Ribbon.HideApplicationButtonContentControl()
		End Sub
    End Class

    Public Class AutoHeightPanel
        Inherits Panel
        Protected Overrides Sub OnControlAdded(e As ControlEventArgs)
            MyBase.OnControlAdded(e)
            AddHandler e.Control.SizeChanged, AddressOf ControlSizeChanged
        End Sub
        Public Sub ControlSizeChanged(sender As Object, e As EventArgs)
            Height = CalcHeight()
        End Sub
        Protected Overrides Sub OnControlRemoved(e As ControlEventArgs)
            MyBase.OnControlRemoved(e)
            RemoveHandler e.Control.SizeChanged, AddressOf ControlSizeChanged
        End Sub

        Private Function CalcHeight() As Integer
            Dim res As Integer = 0
            Dim minY As Integer = Int32.MaxValue
            For Each c As Control In Controls
                res = Math.Max(res, c.Height)
                minY = Math.Min(res, c.Location.Y)
            Next
            Return res + minY * 2
        End Function

    End Class
End Namespace
