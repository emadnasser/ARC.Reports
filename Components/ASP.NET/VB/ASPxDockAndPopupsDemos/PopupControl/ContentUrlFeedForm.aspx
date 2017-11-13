<!DOCTYPE html PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN">
<%@ Page Language="vb" AutoEventWireup="true" CodeFile="ContentUrlFeedForm.aspx.vb"
	Inherits="PopupControl_ContentUrldata2" %>
<html xmlns="http://www.w3.org/1999/xhtml" xml:lang="en" lang="en">
<head id="Head1" runat="server">
	<title>Feedback form</title>
	<link rel="stylesheet" type="text/css" href="Css/ContentUrlFeedForm.css">
</head>
<body style="background-image: none;">
	<form id="MailForm" runat="server">
		<table id="FeedBackTable" class="EditorsTable" style="width: 100%; height: 100%;">
			<tr>
				<td class="Label">
					<dx:ASPxLabel ID="LabelEmail" runat="server" Text="Email:" AssociatedControlID="TextBoxFrom" />
				</td>
				<td>
					<dx:ASPxTextBox ID="TextBoxEmail" runat="server" Width="100%" EnableViewState="False">
						<ValidationSettings ErrorDisplayMode="ImageWithTooltip" ErrorTextPosition="Left">
							<RequiredField ErrorText="E-mail is required" IsRequired="True" />
							<RegularExpression ErrorText="Invalid e-mail" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" />
						</ValidationSettings>
						<ClientSideEvents GotFocus="function(s, e) { s.SelectAll() }" />
					</dx:ASPxTextBox>
				</td>
			</tr>
			<tr>
				<td class="Label">
					<dx:ASPxLabel ID="LabelSubject" runat="server" Text="Subject:" AssociatedControlID="TextBoxSubject" />
				</td>
				<td>
					<dx:ASPxTextBox ID="TextBoxSubject" runat="server" Width="100%" EnableViewState="False">
						<ValidationSettings ErrorDisplayMode="ImageWithTooltip" ErrorTextPosition="Left" EnableCustomValidation="true" ErrorText="Must be under 50 characters">
							<RegularExpression ValidationExpression="^[\w\s]{0,50}" />
						</ValidationSettings>
						<ClientSideEvents GotFocus="function(s, e) { s.SelectAll() }" />
					</dx:ASPxTextBox>
				</td>
			</tr>
			<tr style="height: 100%">
				<td class="Label">
					<dx:ASPxLabel ID="LabelMessage" runat="server" Text="Message:" AssociatedControlID="TextBoxMessage" />
				</td>
				<td>
					<dx:ASPxMemo ID="TextBoxMessage" runat="server" Height="100%" Width="100%" EnableViewState="False">
						<ValidationSettings ErrorDisplayMode="ImageWithTooltip" ErrorTextPosition="Left">
							<RequiredField ErrorText="Message is required" IsRequired="True" />
						</ValidationSettings>
						<ClientSideEvents GotFocus="function(s, e) { s.SelectAll(); }" />
					</dx:ASPxMemo>
				</td>
			</tr>
			<tr>
				<td colspan="2">
					<dx:ASPxButton ID="ButtonSend" runat="server" Text="Send" OnClick="ButtonSend_Click" Width="61px" style="float: right; margin: 4px 0"/>
				</td>
			</tr>
		</table>
	</form>
</body>
</html>