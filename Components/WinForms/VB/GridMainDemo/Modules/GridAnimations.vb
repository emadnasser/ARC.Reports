Imports System.Collections
Imports System.ComponentModel
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports System.Drawing.Imaging
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Localization
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.DXperience.Demos

Namespace DevExpress.XtraGrid.Demos
	''' <summary>
	''' Summary description for GridAnimations.
	''' </summary>
	Partial Public Class GridAnimations
		Inherits TutorialControl

		Public Sub New()
			' This call is required by the Windows.Forms Form Designer.
			InitializeComponent()
			TutorialInfo.WhatsThisCodeFile = "VB\GridMainDemo\Modules\GridAnimations.vb"
			TutorialInfo.WhatsThisXMLFile = "GridAnimations.xml"
			' TODO: Add any initialization after the InitForm call

		End Sub

		Public Overrides ReadOnly Property ExportView() As DevExpress.XtraGrid.Views.Base.BaseView
			Get
				Return gridView1
			End Get
		End Property
		Private Sub GridAnimations_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
			gridControl1.DataSource = OutlookData.CreateDataTable(4)
			gridView1.ExpandAllGroups()
			For Each mode As GridAnimationType In System.Enum.GetValues(GetType(GridAnimationType))
				icbAnimation.Properties.Items.Add(New ImageComboBoxItem(EnumTitlesKeeper(Of GridAnimationType).GetTitle(mode), mode, -1))
			Next mode
			icbAnimation.EditValue = gridView1.OptionsView.AnimationType
			OnStyleChanged()
		End Sub

		Private Sub gridView1_CustomDrawGroupRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.RowObjectCustomDrawEventArgs) Handles gridView1.CustomDrawGroupRow
			Dim info As GridGroupRowInfo = TryCast(e.Info, GridGroupRowInfo)
			If info Is Nothing Then
				Return
			End If
			info.GroupText = info.GroupText.Replace("1 " & My.Resources.Items, "1 " & My.Resources.Item)
		End Sub

		Private ht As New Hashtable()
		Private Sub gridView1_CustomUnboundColumnData(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs) Handles gridView1.CustomUnboundColumnData
			If e.IsGetData Then
				Dim row_Renamed As DataRow = CType(e.Row, DataRowView).Row
				Dim key As Integer = CInt(Fix(row_Renamed("Priority")))
				If key <> 1 Then
					If Not ht.ContainsKey(key) Then
						ht.Add(key, GetImage(key))
					End If
					e.Value = ht(key)
				End If
			End If
		End Sub

		Private Function GetImage(ByVal key As Integer) As Byte()
            Dim img As Image = DevExpress.Utils.ResourceImageHelper.CreateImageFromResources(String.Format("{0}.gif", GetPictureName(key)), GetType(GridAnimations).Assembly)
			Return DevExpress.XtraEditors.Controls.ByteImageConverter.ToByteArray(img, ImageFormat.Gif)
		End Function

		Private Function GetPictureName(ByVal key As Integer) As String
			If key = 0 Then
				Return "low"
				Else
					Return "high"
				End If
		End Function

		Private Sub gridView1_ShowFilterPopupListBox(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.FilterPopupListBoxEventArgs) Handles gridView1.ShowFilterPopupListBox
			If e.Column IsNot colPriority Then
				Return
			End If
			For i As Integer = e.ComboBox.Items.Count - 1 To 0 Step -1
				Dim item As FilterItem = TryCast(e.ComboBox.Items(i), FilterItem)
				If item Is Nothing Then
					Continue For
				End If
				If item.Text = GridLocalizer.Active.GetLocalizedString(GridStringId.PopupFilterCustom) Then
					e.ComboBox.Items.RemoveAt(i)
				End If
			Next i
			e.ComboBox.Items.Add(New FilterItem(My.Resources.LowPriority, New ColumnFilterInfo("[Priority] = 0", My.Resources.LowPriority)))
			e.ComboBox.Items.Add(New FilterItem(My.Resources.HighPriority, New ColumnFilterInfo("[Priority] = 2", My.Resources.HighPriority)))
		End Sub
		'<icbAnimation>
		Private Sub icbAnimation_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles icbAnimation.SelectedIndexChanged
			gridView1.OptionsView.AnimationType = CType(icbAnimation.EditValue, GridAnimationType)
		End Sub
		'</icbAnimation>
		Protected Overrides Sub OnStyleChanged()
			MyBase.OnStyleChanged()
			ColorHelper.UpdateColor(imageList1, gridControl1.LookAndFeel)
		End Sub
	End Class
End Namespace
