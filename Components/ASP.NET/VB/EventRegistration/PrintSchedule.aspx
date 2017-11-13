<%@ Page Language="vb" AutoEventWireup="true" CodeFile="PrintSchedule.aspx.vb" Inherits="PrintSchedule"
	Theme="Print" %>
<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
	<title>Event Registration Print</title>
	<link href="~/Styles/Site.css" rel="stylesheet" type="text/css" />
	<script src="Scripts/Scripts.js" type="text/javascript"></script>
</head>
<body>
	<form id="form1" target="_blank" runat="server">
	<dx:ASPxCallback ID="cbChangePrintingStatus" runat="server" ClientInstanceName="cbChangePrintingStatus"
		OnCallback="cbChangePrintingStatus_Callback">
		<ClientSideEvents EndCallback="OnEndChangePrintingStatusCallback"/>
	</dx:ASPxCallback>
	<dx:ASPxSplitter ID="ASPxSplitter1" runat="server" Orientation="Vertical" FullscreenMode="true"
		SeparatorVisible="false">
		<Panes>
			<dx:SplitterPane Size="34px">
				<PaneStyle CssClass="toolbar">
				</PaneStyle>
				<ContentCollection>
					<dx:SplitterContentControl runat="server">
					  <dx:ReportToolbar ID="ReportToolbar1" runat="server" ReportViewer="<%#ReportViewer1%>"
							ShowDefaultButtons="False" Width="600px" style="float: left;">
							<ClientSideEvents ItemValueChanged="OnReportToolbarItemValueChanged" />
							<Items>
								<dx:ReportToolbarLabel ItemKind="PageLabel" />
								<dx:ReportToolbarComboBox ItemKind="PageNumber" Width="94px">
								</dx:ReportToolbarComboBox>
								<dx:ReportToolbarLabel ItemKind="OfLabel" />
								<dx:ReportToolbarTextBox IsReadOnly="True" ItemKind="PageCount" />
								<dx:ReportToolbarSeparator />
								<dx:ReportToolbarComboBox Name="PrintSessionCollection" ItemKind="Custom">
									<Elements>
										<dx:ListElement Text="Attending sessions" Value="Selected" />
										<dx:ListElement Text="All sessions" Value="All" />
									</Elements>
								</dx:ReportToolbarComboBox>
								<dx:ReportToolbarButton ItemKind="PrintReport" ToolTip="Print the schedule" ImageUrl="~/Images/buttons/print.png"
									ImageUrlDisabled="~/Images/buttons/print.png" />
							</Items>
						</dx:ReportToolbar>
					</dx:SplitterContentControl>
				</ContentCollection>
			</dx:SplitterPane>
			<dx:SplitterPane ScrollBars="Auto">
				<ContentCollection>
					<dx:SplitterContentControl runat="server">
						<dx:ReportViewer ID="ReportViewer1" runat="server" ClientInstanceName="ClientReportViewer"
							AutoSize="true" LoadingPanelText="">
						</dx:ReportViewer>
					</dx:SplitterContentControl>
				</ContentCollection>
			</dx:SplitterPane>
		</Panes>
		<Styles>
			<Pane Paddings-Padding="0" Border-BorderWidth="0" HorizontalAlign="Center">
			</Pane>
		</Styles>
	</dx:ASPxSplitter>
	</form>
</body>
</html>