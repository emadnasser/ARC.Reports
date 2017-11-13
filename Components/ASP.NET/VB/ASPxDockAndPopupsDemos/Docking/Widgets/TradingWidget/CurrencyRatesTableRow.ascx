<%@ Control Language="vb" ClassName="CurrencyRatesTableRow" %>
<script runat="server">
	Dim currency_Renamed As String
	Dim value_Renamed As Single
	Dim growth_Renamed As Single
	Public Property Currency() As String
		Get
			Return currency_Renamed
		End Get
		Set(ByVal value As String)
			currency_Renamed = value
		End Set
	End Property
	Public Property Value() As Single
		Get
			Return value_Renamed
		End Get
		Set(ByVal value As Single)
			Me.value_Renamed = value
		End Set
	End Property
	Public Property Growth() As Single
		Get
			Return growth_Renamed
		End Get
		Set(ByVal value As Single)
			growth_Renamed = value
		End Set
	End Property
	Protected Sub Page_Init(ByVal sender As Object, ByVal e As EventArgs)
		CurrencyHyperLink.Text = Currency
		ValueLabel.Text = Value.ToString()
		GrowthLabel.Text = Growth.ToString()
		If Growth >= 0 Then
			GrowthLabel.ForeColor = System.Drawing.Color.Green
		Else
			GrowthLabel.ForeColor = System.Drawing.Color.Red
		End If
	End Sub
</script>
<tr>
	<td style="width: 30%"><dx:ASPxHyperLink runat="server" ID="CurrencyHyperLink" NavigateUrl="javascript:void(0)" /></td>
	<td style="width: 30%"><dx:ASPxLabel runat="server" ID="ValueLabel" /></td>
	<td style="width: 30%"><dx:ASPxLabel runat="server" ID="GrowthLabel"/></td>
</tr>