<%@ Page Language="vb" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="ClientSideAPI.aspx.vb"
	Inherits="Timer_ClientSideAPI" %>
<asp:Content runat="server" ContentPlaceHolderID="CustomHeadHolder">
	<%--start highlighted block--%>
	<script type="text/javascript">
		var ballDX = 2;
		var ballDY = 3;
		var maxBallX = 0;
		var maxBallY = 0;
		function OnTimerInit() {
			var boxStyle = document.getElementById("divBox").style;
			maxBallX = parseInt(boxStyle.width) - 36;
			maxBallY = parseInt(boxStyle.height) - 36;
		}
		function MoveBall() {
			var ballStyle = document.getElementById("spanBall").style;
			var x = parseInt(ballStyle.left);
			var y = parseInt(ballStyle.top);
			var newX = x + ballDX;
			var newY = y + ballDY;
			if (ballDX < 0 && newX <= 0) {
				ballDX = -ballDX;
				newX = 0;
			}
			else if (ballDX > 0 && newX >= maxBallX) {
				ballDX = -ballDX;
				newX = maxBallX;
			}
			if (ballDY < 0 && newY <= 0) {
				ballDY = -ballDY;
				newY = 0;
			}
			else if (ballDY > 0 && newY >= maxBallY) {
				ballDY = -ballDY;
				newY = maxBallY;
			}
			ballStyle.top = newY + "px";
			ballStyle.left = newX + "px";
		}
	</script>
	<%--end highlighted block--%>
</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" runat="Server">
	<table class="OptionsTable OptionsBottomMargin">
		<tr>
			<td>
				<dx:ASPxComboBox ID="ASPxComboBox1" runat="server" SelectedIndex="1" Width="56px" Caption="Interval (ms)">
					<ClientSideEvents TextChanged="function(s, e) { Timer1.SetInterval(s.GetSelectedItem().value); }" />
					<Items>
						<dx:ListEditItem Value="15" Text="15" />
						<dx:ListEditItem Value="25" Text="25" />
						<dx:ListEditItem Value="100" Text="100" />
					</Items>
				</dx:ASPxComboBox>
			</td>
			<td class="LeftPadding">
				<dx:ASPxCheckBox runat="server" ID="cbTimer" Checked="True" Text="Enabled">
					<ClientSideEvents CheckedChanged="function(s, e) { Timer1.SetEnabled(s.GetChecked()); }" />
				</dx:ASPxCheckBox>
			</td>
		</tr>
	</table>
	<div id="divBox" style="width: 320px; height: 240px; background: #FFFFFF; border: solid 1px #D5D7DC;">
		<div style="position: relative; top: 0px; left: 0px;" id="spanBall">
			<img width="36" height="36" alt="" src="Images/Ball.png" /></div>
	</div>
	<dx:ASPxTimer ID="ASPxTimer1" runat="server" Interval="25" ClientInstanceName="Timer1">
		<ClientSideEvents Init="OnTimerInit" Tick="MoveBall"></ClientSideEvents>
	</dx:ASPxTimer>
</asp:Content>