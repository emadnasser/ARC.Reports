<%@ Control Language="vb" AutoEventWireup="true" CodeFile="ShowDesignerButtonControl.ascx.vb"
	Inherits="UserControls_ShowDesignerButtonControl" %>
<a id="run-designer-button" class="ThemeButton run-designer-button" href="<%=Page.ResolveUrl(RunDesignerUrl)%>"
	title="Customize the report on the client side using the in-browser Report Designer.">
	<img class="run-designer-image" src="<%=Page.ResolveUrl("~/Content/RunDesigner.png")%>" alt="run report designer" />
	REPORT DESIGNER
	<div class="run-designer-tooltip-container">
		<div id="run-designer-tooltip" class="run-designer-tooltip">
			<div class="run-designer-corner">
			</div>
			<span class="run-designer-content">Customize the report on the client side using the in-browser Report Designer.</span>
		</div>
	</div>
</a>
<script type="text/javascript">
	(function() {
		var runDesignerButton = document.getElementById("run-designer-button"),
			runDesignerTooltip = document.getElementById("run-designer-tooltip");
		setTimeout(function() {
			runDesignerTooltip.className += " run-designer-fade";
		}, 5000);
		setTimeout(function() {
			runDesignerTooltip.style.display = "none";
		}, 7000);
	})();
</script>