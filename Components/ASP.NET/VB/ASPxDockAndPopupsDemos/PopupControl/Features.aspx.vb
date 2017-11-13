Imports Microsoft.VisualBasic
Imports System
Imports System.Web.UI
Imports DevExpress.Web
Imports System.Web.UI.WebControls

Partial Public Class PopupControl_Features
	Inherits Page
	Private Const defaulOpacity As Integer = 100
	Private ReadOnly Property CurrentPopupHorizontalAlign() As PopupHorizontalAlign
		Get
			Return CType(System.Enum.Parse(GetType(PopupHorizontalAlign), ddlPopupHorizontalAlign.SelectedItem.Value.ToString()), PopupHorizontalAlign)
		End Get
	End Property

	Private ReadOnly Property CurrentPopupVerticalAlign() As PopupVerticalAlign
		Get
			Return CType(System.Enum.Parse(GetType(PopupVerticalAlign), ddlPopupVerticalAlign.SelectedItem.Value.ToString()), PopupVerticalAlign)
		End Get
	End Property

	Private ReadOnly Property CurrentDragElement() As DragElement
		Get
			Return CType(System.Enum.Parse(GetType(DragElement), ddlDragElement.SelectedItem.Value.ToString()), DragElement)
		End Get
	End Property

	Private ReadOnly Property CurrentResizingMode() As ResizingMode
		Get
			Return CType(System.Enum.Parse(GetType(ResizingMode), ddlResizeMode.SelectedItem.Value.ToString()), ResizingMode)
		End Get
	End Property

	Private ReadOnly Property CurrentShowSizeGripMode() As ShowSizeGrip
		Get
			Return CType(System.Enum.Parse(GetType(ShowSizeGrip), ddlShowSizeGrip.SelectedItem.Value.ToString()), ShowSizeGrip)
		End Get
	End Property

	Private ReadOnly Property CurrentCloseAction() As CloseAction
		Get
			Return CType(System.Enum.Parse(GetType(CloseAction), ddlCloseAction.SelectedItem.Value.ToString()), CloseAction)
		End Get
	End Property

	Private ReadOnly Property CurrentPopupAction() As PopupAction
		Get
			Return CType(System.Enum.Parse(GetType(PopupAction), ddlPopupAction.SelectedItem.Value.ToString()), PopupAction)
		End Get
	End Property

	Private ReadOnly Property CurrentScrollBars() As ScrollBars
		Get
			Return CType(System.Enum.Parse(GetType(ScrollBars), ddlScrollBars.SelectedItem.Value.ToString()), ScrollBars)
		End Get
	End Property

	Private ReadOnly Property CurrentPopupAnimationType() As AnimationType
		Get
			Return CType(System.Enum.Parse(GetType(AnimationType), ddlPopupAnimationType.SelectedItem.Value.ToString()), AnimationType)
		End Get
	End Property
	Private ReadOnly Property CurrentCloseAnimationType() As AnimationType
		Get
			Return CType(System.Enum.Parse(GetType(AnimationType), ddlCloseAnimationType.SelectedItem.Value.ToString()), AnimationType)
		End Get
	End Property

	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		If (Not IsPostBack) Then
			Return
		End If
		pcMain.Width = 330
		pcMain.Height = 250
		pcMain.AllowDragging = cbAllowDragging.Checked
		pcMain.ShowCloseButton = cbShowCloseButton.Checked
		pcMain.ShowFooter = cbShowFooter.Checked
		pcMain.ShowHeader = cbShowHeader.Checked
		pcMain.ShowShadow = cbShowShadow.Checked
		pcMain.AllowResize = cbAllowResize.Checked
		pcMain.PopupHorizontalAlign = CurrentPopupHorizontalAlign
		pcMain.PopupVerticalAlign = CurrentPopupVerticalAlign
		pcMain.DragElement = CurrentDragElement
		pcMain.ResizingMode = CurrentResizingMode
		pcMain.ShowSizeGrip = CurrentShowSizeGripMode
		pcMain.CloseAction = CurrentCloseAction
		pcMain.CloseOnEscape = cbCloseOnEscape.Checked
		pcMain.PopupAction = CurrentPopupAction
		pcMain.ScrollBars = CurrentScrollBars
		pcMain.PopupAnimationType = CurrentPopupAnimationType
		pcMain.CloseAnimationType = CurrentCloseAnimationType
	End Sub

	Protected Sub ddlCloseAction_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
		hlHide.Visible = pcMain.CloseAction = CloseAction.None
	End Sub

	Protected Sub ddlPopupAction_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
		hlShow.Visible = pcMain.PopupAction = PopupAction.None
		lblCursor.Style(HtmlTextWriterStyle.Cursor) = If(hlShow.Visible, String.Empty, "pointer")
	End Sub

	Protected Sub ddlScrollBars_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
		If CurrentScrollBars = ScrollBars.Horizontal Then
			pcMain.Height = Unit.Empty
		End If
		If CurrentScrollBars = ScrollBars.Vertical Then
			pcMain.Width = 372
		End If
	End Sub

	Protected Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs)
		Dim result As Integer = 0

		lblPopupHorizontalOffsetError.Visible = Not Integer.TryParse(tbPopupHorizontalOffset.Text, result)
		If (Not lblPopupHorizontalOffsetError.Visible) Then
			pcMain.PopupHorizontalOffset = result
		End If

		lblPopupVerticalOffsetError.Visible = Not Integer.TryParse(tbPopupVerticalOffset.Text, result)
		If (Not lblPopupVerticalOffsetError.Visible) Then
			pcMain.PopupVerticalOffset = result
		End If

		lblAppearAfterError.Visible = (Not Integer.TryParse(tbAppearAfter.Text, result)) OrElse result < 0
		If (Not lblAppearAfterError.Visible) Then
			pcMain.AppearAfter = result
		End If

		lblDisappearAfterError.Visible = (Not Integer.TryParse(tbDisappearAfter.Text, result)) OrElse result < 0
		If (Not lblDisappearAfterError.Visible) Then
			pcMain.DisappearAfter = result
		End If

		lblOpacityError.Visible = (Not Integer.TryParse(tbOpacity.Text, result)) OrElse result < 0 OrElse result > 100
		If (Not lblOpacityError.Visible) Then
			pcMain.Opacity = result
		End If
	End Sub

End Class
