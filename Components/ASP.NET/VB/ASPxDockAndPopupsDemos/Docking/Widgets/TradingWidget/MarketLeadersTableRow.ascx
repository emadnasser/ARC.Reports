<%@ Control Language="vb" ClassName="MarketLeadersTableRow" %>
<script runat="server">
	Dim index_Renamed As String
	Dim value_Renamed As String
	Dim growth_Renamed As String

	Public Property Index() As String
		Get
			Return index_Renamed
		End Get
		Set(ByVal value As String)
			index_Renamed = value
		End Set
	End Property
	Public Property Value() As String
		Get
			Return value_Renamed
		End Get
		Set(ByVal value As String)
			Me.value_Renamed = value
		End Set
	End Property
	Public Property Growth() As String
		Get
			Return growth_Renamed
		End Get
		Set(ByVal value As String)
			growth_Renamed = value
		End Set
	End Property
	Protected Sub Page_Init(ByVal sender As Object, ByVal e As EventArgs)
		IndexHyperLink.Text = Index
		ValueLabel.Text = Value
		GrowthLabel.Text = Growth
	End Sub
</script>
<tr>
	<td style="width: 30%"><dx:ASPxHyperLink runat="server" ID="IndexHyperLink" NavigateUrl="javascript:void(0)" /></td>
	<td style="width: 30%"><dx:ASPxLabel runat="server" ID="ValueLabel" /></td>
	<td style="width: 30%"><dx:ASPxLabel runat="server" ID="GrowthLabel" ForeColor="Green"/></td>
</tr>