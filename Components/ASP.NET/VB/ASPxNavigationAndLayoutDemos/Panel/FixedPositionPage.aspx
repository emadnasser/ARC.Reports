<%@ Page Language="vb" AutoEventWireup="true" CodeFile="FixedPositionPage.aspx.vb"
	Inherits="Panel_FixedPositionPage" %>
<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
	<title>Fixed Position - ASP.NET Panel Control</title>
	<style>
		body, form
		{
			padding: 0;
			margin: 0;
		}
		body
		{
			background-color: #F4F0DB;
			font: 14px Tahoma;
		}
		.pnl-content
		{
			font-size: 14px;
			padding: 20px;
			text-align: center;
			white-space: normal;
		}
		.body-content
		{
			margin: 0 auto;
			padding: 0 10px 40px;
			width: 80%;
			min-width: 200px;
			line-height: 150%;
			text-align: center;
		}
		.body-content h3
		{
			padding: 40px 0 20px;
		}
	</style>
</head>
<body>
	<form id="form1" runat="server">
		<dx:ASPxPanel id="TopPanel" runat="server" fixedposition="WindowTop" fixedpositionoverlap="true" backcolor="#DBF4DE">
			<PanelCollection>
				<dx:PanelContent runat="server" SupportsDisabledAttribute="True">
					<div class="pnl-content">This is ASPxPanel control with FixedPosition=WindowTop</div>
				</dx:PanelContent>
			</PanelCollection>
		</dx:ASPxPanel>
		<dx:ASPxPanel id="LeftPanel" runat="server" fixedposition="WindowLeft" fixedpositionoverlap="true" backcolor="#F3EAFB">
			<PanelCollection>
				<dx:PanelContent runat="server" SupportsDisabledAttribute="True">
					<div class="pnl-content" style="width: 200px;">This is ASPxPanel control with FixedPosition=WindowLeft</div>
				</dx:PanelContent>
			</PanelCollection>
		</dx:ASPxPanel>
		<dx:ASPxCallbackPanel id="BottomPanel" runat="server" fixedposition="WindowBottom" backcolor="#DBEBF4">
			<PanelCollection>
				<dx:PanelContent runat="server" SupportsDisabledAttribute="True">
					<div class="pnl-content" >This is ASPxPanel control with FixedPosition=WindowBottom</div>
				</dx:PanelContent>
			</PanelCollection>
		</dx:ASPxCallbackPanel>
		<div class="body-content">
			<h3>UI Controls for Your Next Great Web App</h3>
			<p>
				With DevExpress web controls, you can build a bridge to the future on the platform you know and love. The 175+ AJAX controls and MVC extensions that make up the DevExpress ASP.NET Subscription have been engineered so you can deliver exceptional, touch-enabled, interactive experiences for the web, regardless of the target browser or computing device. DevExpress web UI components support all major browsers including Internet Explorer, FireFox, Chrome, Safari and Opera, and are continuously tested to ensure the best possible compatibility across platforms, operating systems and devices.
			</p>
			<p>
				And to ensure you can build your best and meet the needs of your enterprise each and every time, the DevExpress ASP.NET Subscription ships with 20 built-in application themes that can be used out-of-the box or customized via our ASP.NET Theme Builder.
			</p>
			<h3>UI Controls for Your Next Great Hybrid App</h3>
			<p>
				With DevExpress UI controls, you'll be able to deliver elegant line-of-business applications that emulate the touch-first Windows 8 Pro UX and maintain backward compatibility with previous versions of the Windows operating system. Whether you need to create a tile-based, modern UI application for Windows or need to quickly convert an existing application for use on Microsoft Surface, the DevExpress WinForms & WPF Subscriptions will help you deliver immersive business solutions, without abandoning your existing code investments. And because we continue to extend our .NET product line with enterprise-ready capabilities designed to help you build next-generation user experiences on the platform of your choice, you can rest assured that your apps will never be left behind, regardless of changes made to Windows or the introduction of new device form-factors.
			</p>
			<h3>UI Controls for Your Next Great Mobile App</h3>
			<p>
				Create highly-responsive mobile apps that meet the needs of your ever-changing enterprise and the BYOD world. Use the power of HTML, CSS3 and JavaScript to deliver line-of-business solutions that look, feel and behave just like native apps, without learning multiple languages or frameworks.
			</p>
			<p>
				DevExpress Universal ships with DevExtreme—the framework you'll need to deliver beautiful, easy-to-use HTML5/ JavaScript applications for smartphones, tablets and desktop browsers. With nine high-impact themes replicating today's most popular mobile OS interfaces, DevExtreme apps automatically apply the appropriate theme to your solution so your "write once, use everywhere" apps look great, regardless of the end-user's device or platform choice.
			</p>
			<h3>UI Controls for Your Next Great Dashboard App</h3>
			<p>
				With DevExpress Dashboard for .NET, creating insightful and information-rich decision support systems for executives and business users across platforms and devices is a simple matter of selecting the appropriate UI element (Chart, Pivot Table, Data Card, Gauge, Map or Grid) and dropping data fields onto corresponding arguments, values and series. And because DevExpress Dashboard elements automatically provide the best data visualization option for you, results are immediate, accurate and always relevant.
			</p>
			<p>
				With full Visual Studio integration, DevExpress Dashboard allows you to deliver business solutions that target Windows, the Web and Mobile devices with breathtaking ease. It's built so you can manage everything inside your favorite IDE: from data-binding and dashboard design to filtering, drill down and event handling.  
			</p>
		</div>
	</form>
</body>
</html>