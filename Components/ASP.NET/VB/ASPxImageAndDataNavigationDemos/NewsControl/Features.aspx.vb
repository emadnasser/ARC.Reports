Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.Web
Imports System.Web.UI
Imports System.Web.UI.WebControls

Partial Public Class NewsControl_Features
	Inherits Page

	Private ReadOnly Property CurrentEllipsisMode() As PagerEllipsisMode
		Get
			Return CType(System.Enum.Parse(GetType(PagerEllipsisMode), ddlEllipsisMode.SelectedItem.Value.ToString()), PagerEllipsisMode)
		End Get
	End Property

	Private ReadOnly Property CurrentPagerPosition() As PagerPosition
		Get
			Return CType(System.Enum.Parse(GetType(PagerPosition), ddlPosition.SelectedItem.Value.ToString()), PagerPosition)
		End Get
	End Property

	Private ReadOnly Property CurrentPageSizePosition() As PagerPageSizePosition
		Get
			Return CType(System.Enum.Parse(GetType(PagerPageSizePosition), ddlPageSizeItemPosition.SelectedItem.Value.ToString()), PagerPageSizePosition)
		End Get
	End Property

	Private ReadOnly Property CurrentEndlessPagingMode() As DataViewEndlessPagingMode
		Get
			Return CType(System.Enum.Parse(GetType(DataViewEndlessPagingMode), cbEndlessPagerMode.SelectedItem.Value.ToString()), DataViewEndlessPagingMode)
		End Get
	End Property

	Private ReadOnly Property CurrentDateHorizontalPosition() As DateHorizontalPosition
		Get
			Return CType(System.Enum.Parse(GetType(DateHorizontalPosition), ddlDateHorizontalPosition.SelectedItem.Value.ToString()), DateHorizontalPosition)
		End Get
	End Property

	Private ReadOnly Property CurrentDateVerticalPosition() As DateVerticalPosition
		Get
			Return CType(System.Enum.Parse(GetType(DateVerticalPosition), ddlDateVerticalPosition.SelectedItem.Value.ToString()), DateVerticalPosition)
		End Get
	End Property

	Private ReadOnly Property CurrentImagePosition() As HeadlineImagePosition
		Get
			Return CType(System.Enum.Parse(GetType(HeadlineImagePosition), ddlImagePosition.SelectedItem.Value.ToString()), HeadlineImagePosition)
		End Get
	End Property

	Private ReadOnly Property CurrentTailImagePosition() As TailImagePosition
		Get
			Return CType(System.Enum.Parse(GetType(TailImagePosition), ddlTailImagePosition.SelectedItem.Value.ToString()), TailImagePosition)
		End Get
	End Property

	Private ReadOnly Property CurrentTailPosition() As TailPosition
		Get
			Return CType(System.Enum.Parse(GetType(TailPosition), ddlTailPosition.SelectedItem.Value.ToString()), TailPosition)
		End Get
	End Property

	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		SetProperties()
	End Sub

	Protected Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs)
		Dim result As Integer = 0
		lblMaxLengthError.Visible = (Not Integer.TryParse(tbMaxLength.Text, result)) OrElse result < 0
		If (Not lblMaxLengthError.Visible) Then
			newsControl.ItemSettings.MaxLength = result
		End If
	End Sub

	Private Sub SetProperties()
		newsControl.ShowBackToTop = cbShowBackToTop.Checked
		newsControl.PagerSettings.ShowDisabledButtons = cbShowDisabledButtons.Checked
		newsControl.PagerSettings.ShowNumericButtons = cbShowNumericButtons.Checked
		newsControl.PagerSettings.ShowSeparators = cbShowSeparators.Checked
		newsControl.PagerSettings.PageSizeItemSettings.Visible = cbShowPageSizeItem.Checked
		newsControl.PagerSettings.PageSizeItemSettings.Position = CurrentPageSizePosition
		newsControl.PagerSettings.EndlessPagingMode = CurrentEndlessPagingMode
		newsControl.ItemSettings.ShowContentAsLink = cbShowContentAsLink.Checked
		newsControl.ItemSettings.ShowContentInToolTip = cbShowContentInToolTip.Checked
		newsControl.ItemSettings.ShowHeaderAsLink = cbShowHeaderAsLink.Checked
		newsControl.ItemSettings.ShowImageAsLink = cbShowImageAsLink.Checked
		newsControl.PagerSettings.EllipsisMode = CurrentEllipsisMode
		newsControl.PagerSettings.Position = CurrentPagerPosition
		newsControl.ItemSettings.DateHorizontalPosition = CurrentDateHorizontalPosition
		newsControl.ItemSettings.DateVerticalPosition = CurrentDateVerticalPosition
		newsControl.ItemSettings.ImagePosition = CurrentImagePosition
		newsControl.ItemSettings.TailImagePosition = CurrentTailImagePosition
		newsControl.ItemSettings.TailPosition = CurrentTailPosition

		If cbShowPageSizeItem.Checked Then
			newsControl.PagerAlign = DevExpress.Web.PagerAlign.Justify
		End If
	End Sub

End Class
