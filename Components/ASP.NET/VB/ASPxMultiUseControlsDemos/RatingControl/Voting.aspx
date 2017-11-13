<%@ Page Language="vb" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Voting.aspx.vb"
	Inherits="RatingControl_Example" %>
<asp:Content runat="server" ContentPlaceHolderID="CustomHeadHolder">
	<%--start highlighted block--%>
	<script type="text/javascript">
		var titles = ["Very bad", "Bad", "Normal", "Good", "Very good"];
		var prevTitle;
		function myRating_Init(s, e) {
			var value = s.GetValue();
			if (value > 0)
				lbMyVote.SetText(titles[value - 1]);
			else
				lbMyVote.SetText('Vote here');
		}
		function myRating_ItemClick(s, e) {
			lbAllVotes.SetText("(Updating...)");
			prevTitle = titles[e.index];
			cbVoting.PerformCallback();
		}
		function myRating_ItemMouseOver(s, e) {
			prevTitle = lbMyVote.GetText();
			lbMyVote.SetText(titles[e.index]);
		}
		function myRating_ItemMouseOut(s, e) {
			lbMyVote.SetText(prevTitle);
		}
		function VotingCallbackComplete(s, e) {
			var ratingValues = e.result.split(' ');
			allRating.SetValue(ratingValues[1]);
			var labelText = ratingValues[0] + " votes (" + ratingValues[2] + ")";
			lbAllVotes.SetText(labelText);
		}
	</script>
	<%--end highlighted block--%>
</asp:Content>
<asp:Content ID="Content" ContentPlaceHolderID="ContentHolder" runat="Server">
	<dx:ASPxComboBox ID="cmbPrecision" runat="server" Width="110" AutoPostBack="true" Caption="Fill Precision">
		<RootStyle CssClass="OptionsBottomMargin"></RootStyle>
	</dx:ASPxComboBox>
	<dx:ASPxRoundPanel ID="ratingPanel" Width="400px" runat="server" ShowHeader="False"
		HorizontalAlign="Center">
		<PanelCollection>
			<dx:PanelContent ID="PanelContent1" runat="server">
				<div style="margin-bottom: 5px">
					<dx:ASPxRatingControl ID="allRating" runat="server" ReadOnly="true" ClientInstanceName="allRating" />
				</div>
				<dx:ASPxLabel ID="lbAllVotes" runat="server" ClientInstanceName="lbAllVotes" Font-Size="8pt" />
				<div style="margin: 14px 0 5px">
					<dx:ASPxRatingControl ID="myRating" runat="server" Value="0">
						<ClientSideEvents Init="myRating_Init" ItemClick="myRating_ItemClick" ItemMouseOver="myRating_ItemMouseOver"
							ItemMouseOut="myRating_ItemMouseOut" />
					</dx:ASPxRatingControl>
				</div>
				<dx:ASPxLabel ID="lbMyVote" runat="server" ClientInstanceName="lbMyVote" Font-Size="8pt" />
			</dx:PanelContent>
		</PanelCollection>
	</dx:ASPxRoundPanel>
	<dx:ASPxCallback ID="cbVoting" runat="server" ClientInstanceName="cbVoting" OnCallback="cbVoting_Callback">
		<ClientSideEvents CallbackComplete="VotingCallbackComplete" />
	</dx:ASPxCallback>
</asp:Content>