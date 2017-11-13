<%@ Page Language="vb" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="DropdownMenu.aspx.vb"
	Inherits="ToolbarItems_DropdownMenu" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" runat="Server">
	<%--start highlighted block--%>
	<script type="text/javascript">
	// <![CDATA[
		function OnCommandExecute(s, e) {
			if (e.commandName == "InsertDateTime")
				InsertDateTime(e.parameter);
		}
		function InsertDateTime(value) {
			HtmlEditor.GetSelection().SetHtml(GetDateString(value));
		}
		var dateTimeData = {};
		dateTimeData.Months = ["January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"];
		dateTimeData.DaysOfWeek = ["Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday"];
		function GetDateString(format) {
			var date = new Date();
			var result = format;
			var hours = date.getHours();
			var pmam = "AM";
			if (hours >= 12) {
				pmam = "PM";
				hours -= 12;
			}
			result = result.replace("%y", date.getFullYear());
			result = result.replace("%mf", dateTimeData.Months[date.getMonth()]);
			result = result.replace("%m", GetTwoDigitsNumber(date.getMonth() + 1));
			result = result.replace("%df", dateTimeData.DaysOfWeek[date.getDay()]);
			result = result.replace("%d", GetTwoDigitsNumber(date.getDate()));
			result = result.replace("%h", hours);
			result = result.replace("%M", GetTwoDigitsNumber(date.getMinutes()));
			result = result.replace("%s", GetTwoDigitsNumber(date.getSeconds()));
			result = result.replace("%p", pmam);
			return result;
		}
		function GetTwoDigitsNumber(number) {
			return (number < 10 ? "0" : "") + number;
		}
	// ]]> 
	</script>
	<%--end highlighted block--%>
	<dx:ASPxHtmlEditor ID="DemoHtmlEditor" runat="server" Height="300px" ClientInstanceName="HtmlEditor">
		<ClientSideEvents CustomCommand="OnCommandExecute" />
		<Toolbars>
			<dx:HtmlEditorToolbar>
				<Items>
					<dx:ToolbarUndoButton>
					</dx:ToolbarUndoButton>
					<dx:ToolbarRedoButton>
					</dx:ToolbarRedoButton>
					<dx:ToolbarJustifyLeftButton BeginGroup="True">
					</dx:ToolbarJustifyLeftButton>
					<dx:ToolbarJustifyCenterButton>
					</dx:ToolbarJustifyCenterButton>
					<dx:ToolbarJustifyRightButton>
					</dx:ToolbarJustifyRightButton>
					<dx:ToolbarJustifyFullButton>
					</dx:ToolbarJustifyFullButton>
					<dx:ToolbarDropDownMenu BeginGroup="true" CommandName="InsertDateTime" ToolTip="Insert Date and Time">
						<Image Url="~/Content/Demo/Toolbar/date.png" Height="16px" Width="16px">
						</Image>
						<Items>
							<dx:ToolbarMenuItem Text="MM/dd/yyyy" Value="%m/%d/%y">
							</dx:ToolbarMenuItem>
							<dx:ToolbarMenuItem Text="yyyy-MM-dd" Value="%y-%m-%d">
							</dx:ToolbarMenuItem>
							<dx:ToolbarMenuItem Text="Month dd, yyyy" Value="%mf %d, %y">
							</dx:ToolbarMenuItem>
							<dx:ToolbarMenuItem Text="Day of Week, Month dd, yyyy" Value="%df, %mf %d, %y">
							</dx:ToolbarMenuItem>
							<dx:ToolbarMenuItem Text="h:mm AM" Value="%h:%M %p" BeginGroup="true">
							</dx:ToolbarMenuItem>
							<dx:ToolbarMenuItem Text="h:mm:ss AM" Value="%h:%M:%s %p">
							</dx:ToolbarMenuItem>
							<dx:ToolbarMenuItem Text="MM/dd/yyyy h:mm AM" Value="%m/%d/%y %h:%M %p" BeginGroup="true">
							</dx:ToolbarMenuItem>
							<dx:ToolbarMenuItem Text="yyyy-MM-dd h:mm:ss AM" Value="%y-%m-%d %h:%M:%s %p">
							</dx:ToolbarMenuItem>
						</Items>
					</dx:ToolbarDropDownMenu>
				</Items>
			</dx:HtmlEditorToolbar>
		</Toolbars>
	</dx:ASPxHtmlEditor>
</asp:Content>