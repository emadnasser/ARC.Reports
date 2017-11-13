Imports Microsoft.VisualBasic
Imports System
Imports System.Web.UI
Imports DevExpress.Web

Partial Public Class ImageSlider_Features
	Inherits Page
	Private Property CurrentEnableLoopNavigation() As Boolean
		Get
			Return chEnableLoopNavigation.Checked
		End Get
		Set(ByVal value As Boolean)
			chEnableLoopNavigation.Checked = value
		End Set
	End Property
	Private Property CurrentNavigationBarVisible() As Boolean
		Get
			Return chShowNavigationBar.Checked
		End Get
		Set(ByVal value As Boolean)
			chShowNavigationBar.Checked = value
		End Set
	End Property
	Private Property CurrentItemTextVisibility() As ElementVisibilityMode
		Get
			Return CType(ddlItemTextVisibility.Value, ElementVisibilityMode)
		End Get
		Set(ByVal value As ElementVisibilityMode)
			ddlItemTextVisibility.Value = CInt(Fix(value))
		End Set
	End Property
	Private Property CurrentNavigationBarPosition() As NavigationBarPosition
		Get
			Return CType(ddlNavigationBarPosition.Value, NavigationBarPosition)
		End Get
		Set(ByVal value As NavigationBarPosition)
			ddlNavigationBarPosition.Value = CInt(Fix(value))
		End Set
	End Property
	Private Property CurrentNavigationBarMode() As NavigationBarMode
		Get
			Return CType(ddlThumbnailBarMode.Value, NavigationBarMode)
		End Get
		Set(ByVal value As NavigationBarMode)
			ddlThumbnailBarMode.Value = CInt(Fix(value))
		End Set
	End Property
	Private Property CurrentNavigationBarPagingMode() As NavigationBarPagingMode
		Get
			Return CType(ddlNavigationBarPagingMode.Value, NavigationBarPagingMode)
		End Get
		Set(ByVal value As NavigationBarPagingMode)
			ddlNavigationBarPagingMode.Value = CInt(Fix(value))
		End Set
	End Property
	Private Property CurrentNavigationButtonVisibilityMode() As ElementVisibilityMode
		Get
			Return CType(ddlNavigationButtonsVisibility.Value, ElementVisibilityMode)
		End Get
		Set(ByVal value As ElementVisibilityMode)
			ddlNavigationButtonsVisibility.Value = CInt(Fix(value))
		End Set
	End Property
	Private Property CurrentNbNavigationButtonVisibilityMode() As ElementVisibilityMode
		Get
			Return CType(ddlNbNavigationButtonsVisibility.Value, ElementVisibilityMode)
		End Get
		Set(ByVal value As ElementVisibilityMode)
			ddlNbNavigationButtonsVisibility.Value = CInt(Fix(value))
		End Set
	End Property
	Private Property CurrentThumbnailsNavigationButtonPosition() As ThumbnailNavigationBarButtonPosition
		Get
			Return CType(ddlNbNavigationButtonsPosition.Value, ThumbnailNavigationBarButtonPosition)
		End Get
		Set(ByVal value As ThumbnailNavigationBarButtonPosition)
			ddlNbNavigationButtonsPosition.Value = CInt(Fix(value))
		End Set
	End Property
	Private Property CurrentAnimationType() As AnimationType
		Get
			Return CType(ddlAnimationType.Value, AnimationType)
		End Get
		Set(ByVal value As AnimationType)
			ddlAnimationType.Value = CInt(Fix(value))
		End Set
	End Property
	Private Property CurrentNavigationDirection() As NavigationDirection
		Get
			Return CType(ddlNavigationDirection.Value, NavigationDirection)
		End Get
		Set(ByVal value As NavigationDirection)
			ddlNavigationDirection.Value = CInt(Fix(value))
		End Set
	End Property
	Private Property CurrentImageSizeMode() As ImageSizeMode
		Get
			Return CType(ddlImageSizeMode.Value, ImageSizeMode)
		End Get
		Set(ByVal value As ImageSizeMode)
			ddlImageSizeMode.Value = CInt(Fix(value))
		End Set
	End Property
	Private Property EnablePagingGestures() As Boolean
		Get
			Return chEnablePagingGestures.Checked
		End Get
		Set(ByVal value As Boolean)
			chEnablePagingGestures.Checked = value
		End Set
	End Property
	Private Property AllowMouseWheel() As Boolean
		Get
			Return chAllowMouseWheel.Checked
		End Get
		Set(ByVal value As Boolean)
			chAllowMouseWheel.Checked = value
		End Set
	End Property
	Private Property EnablePagingByClick() As AutoBoolean
		Get
			Return CType(ddlEnablePagingByClick.Value, AutoBoolean)
		End Get
		Set(ByVal value As AutoBoolean)
			ddlEnablePagingByClick.Value = CInt(Fix(value))
		End Set
	End Property
	Private Property ImageLoadMode() As ImageLoadMode
		Get
			Return CType(ddlImageLoadMode.Value, ImageLoadMode)
		End Get
		Set(ByVal value As ImageLoadMode)
			ddlImageLoadMode.Value = CInt(Fix(value))
		End Set
	End Property
	Private Property CurretnExtremeItemClickMode() As ExtremeItemClickMode
		Get
			Return CType(ddlExtremeItemClickMode.Value, ExtremeItemClickMode)
		End Get
		Set(ByVal value As ExtremeItemClickMode)
			ddlExtremeItemClickMode.Value = CInt(Fix(value))
		End Set
	End Property

	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		If (Not IsPostBack) Then
			SelectPredefinedScenario(1)
		End If
		UpdateImageSliderProperties()
	End Sub

	Protected Sub cbPredefinedScenarios_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
		SelectPredefinedScenario(Convert.ToInt32(cbPredefinedScenarios.Value))
		UpdateImageSliderProperties()
	End Sub
	Protected Sub GeneralValueChanged(ByVal sender As Object, ByVal e As EventArgs)
		cbPredefinedScenarios.Value = "(Custom)"
	End Sub
	Private Sub SelectPredefinedScenario(ByVal index As Integer)
		Select Case index
			Case 1
			CurrentAnimationType = AnimationType.Slide
			CurrentNavigationDirection = NavigationDirection.Horizontal
			CurrentImageSizeMode = ImageSizeMode.ActualSizeOrFit
			CurrentNavigationButtonVisibilityMode = ElementVisibilityMode.OnMouseOver
			CurrentItemTextVisibility = ElementVisibilityMode.OnMouseOver

			CurrentNavigationBarVisible = True
			CurrentNavigationBarMode = NavigationBarMode.Thumbnails
			CurrentNavigationBarPosition = NavigationBarPosition.Bottom
			CurrentNbNavigationButtonVisibilityMode = ElementVisibilityMode.OnMouseOver
			Case 2 ' Fill and Crop, Dots
			CurrentNavigationDirection = NavigationDirection.Horizontal
			CurrentImageSizeMode = ImageSizeMode.FillAndCrop
			CurrentNavigationButtonVisibilityMode = ElementVisibilityMode.Always
			CurrentItemTextVisibility = ElementVisibilityMode.Always

			CurrentNavigationBarVisible = True
			CurrentNavigationBarMode = NavigationBarMode.Dots
			CurrentNavigationBarPosition = NavigationBarPosition.Bottom
			Case 3 ' Vertical Scrolling
			CurrentAnimationType = AnimationType.Slide
			CurrentNavigationDirection = NavigationDirection.Vertical
			CurrentImageSizeMode = ImageSizeMode.FillAndCrop
			CurrentNavigationButtonVisibilityMode = ElementVisibilityMode.Faded
			CurrentItemTextVisibility = ElementVisibilityMode.None

			CurrentNavigationBarVisible = True
			CurrentNavigationBarMode = NavigationBarMode.Thumbnails
			CurrentNavigationBarPosition = NavigationBarPosition.Left
			CurrentNbNavigationButtonVisibilityMode = ElementVisibilityMode.Faded
		End Select
	End Sub
	Private Sub UpdateImageSliderProperties()
		imageSlider.ShowNavigationBar = CurrentNavigationBarVisible

		imageSlider.SettingsImageArea.EnableLoopNavigation = CurrentEnableLoopNavigation
		imageSlider.SettingsImageArea.AnimationType = CurrentAnimationType
		imageSlider.SettingsImageArea.NavigationDirection = CurrentNavigationDirection
		imageSlider.SettingsImageArea.ImageSizeMode = CurrentImageSizeMode
		imageSlider.SettingsImageArea.NavigationButtonVisibility = CurrentNavigationButtonVisibilityMode
		imageSlider.SettingsImageArea.ItemTextVisibility = CurrentItemTextVisibility

		imageSlider.SettingsNavigationBar.Position = CurrentNavigationBarPosition
		imageSlider.SettingsNavigationBar.Mode = CurrentNavigationBarMode
		imageSlider.SettingsNavigationBar.ThumbnailsModeNavigationButtonVisibility = CurrentNbNavigationButtonVisibilityMode
		imageSlider.SettingsNavigationBar.PagingMode = CurrentNavigationBarPagingMode
		imageSlider.SettingsNavigationBar.ThumbnailsNavigationButtonPosition = CurrentThumbnailsNavigationButtonPosition

		imageSlider.SettingsBehavior.AllowMouseWheel = AllowMouseWheel
		imageSlider.SettingsBehavior.EnablePagingByClick = EnablePagingByClick
		imageSlider.SettingsBehavior.EnablePagingGestures = EnablePagingGestures
		imageSlider.SettingsBehavior.ImageLoadMode = ImageLoadMode
		imageSlider.SettingsBehavior.ExtremeItemClickMode = CurretnExtremeItemClickMode
	End Sub

End Class
