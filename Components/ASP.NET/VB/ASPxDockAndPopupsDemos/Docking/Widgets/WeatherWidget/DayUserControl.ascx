<%@ Control Language="vb" ClassName="DayUserControl" %>
<script runat="server">
	Dim dayOfWeekHyperLinkText As String
	Dim weatherImageUrl_Renamed As String
	Dim temperatureHyperLinkText As String
	Protected Sub Page_Init(ByVal sender As Object, ByVal e As EventArgs)
		DayOfWeekHyperLink.Text = DayOfWeek
		WeatherImage.ImageUrl = WeatherImageUrl
		TemperatureHyperLink.Text = Temperature
	End Sub
	Public Property DayOfWeek() As String
		Get
			Return dayOfWeekHyperLinkText
		End Get
		Set(ByVal value As String)
			dayOfWeekHyperLinkText = value
		End Set
	End Property
	Public Property WeatherImageUrl() As String
		Get
			Return weatherImageUrl_Renamed
		End Get
		Set(ByVal value As String)
			weatherImageUrl_Renamed = value
		End Set
	End Property
	Public Property Temperature() As String
		Get
			Return temperatureHyperLinkText
		End Get
		Set(ByVal value As String)
			temperatureHyperLinkText = value
		End Set
	End Property
</script>
<div class="dayUCContainer">
	<div>
		<dx:ASPxHyperLink ID="DayOfWeekHyperLink" runat="server">
		</dx:ASPxHyperLink>
	</div>
	<dx:ASPxImage runat="server" ID="WeatherImage">
	</dx:ASPxImage>
	<div>
		<dx:ASPxHyperLink ID="TemperatureHyperLink" runat="server" Wrap="False">
		</dx:ASPxHyperLink>
	</div>
</div>