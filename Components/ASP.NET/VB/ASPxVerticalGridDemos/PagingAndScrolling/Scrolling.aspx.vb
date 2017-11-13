Imports Microsoft.VisualBasic
Imports System
Imports System.Web.UI
Imports System.Linq
Imports DevExpress.Web
Imports System.Web.UI.WebControls

Partial Public Class PagingAndScrolling_Scrolling
	Inherits Page
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		If (Not IsPostBack) Then
			For Each name As String In System.Enum.GetNames(GetType(ScrollBarMode))
				HorzScrollCombo.Items.Add(name)
				VertScrollCombo.Items.Add(name)
			Next name
			HorzScrollCombo.Text = ScrollBarMode.Auto.ToString()
			VertScrollCombo.Text = ScrollBarMode.Auto.ToString()
		End If

		Dim horizontalScrollBarMode = CType(System.Enum.Parse(GetType(ScrollBarMode), HorzScrollCombo.Text), ScrollBarMode)
		VerticalGrid.Settings.HorizontalScrollBarMode = horizontalScrollBarMode
		VerticalGrid.Settings.VerticalScrollBarMode = CType(System.Enum.Parse(GetType(ScrollBarMode), VertScrollCombo.Text), ScrollBarMode)

		Dim horzScrollingEnabled = Not horizontalScrollBarMode.Equals(ScrollBarMode.Hidden)
		Dim itemCount = If(horzScrollingEnabled, 10, 4)
		VerticalGrid.DataSource = HeadphonesDataProvider.SelectHeadphones().Take(itemCount)
		VerticalGrid.DataBind()
	End Sub
End Class
