<%@ Control Language="vb" AutoEventWireup="true" CodeFile="ShowQueryBuilderButtonControl.ascx.vb"
	Inherits="UserControls_ShowQueryBuilderButtonControl" %>
<a id="run-designer-button" class="ThemeButton run-designer-button" href="<%=Page.ResolveUrl("~/DataBinding/QueryBuilder.aspx")%>"
	title="Customize the 'SELECT' statement on the client side using the in-browser Query Builder.">
	<img class="run-designer-image" src="<%=Page.ResolveUrl("~/Content/RunQueryBuilder.png")%>" alt="run query builder" />
	QUERY BUILDER
	<div class="run-designer-tooltip-container">
		<div id="run-designer-tooltip" class="run-designer-tooltip">
			<div class="run-designer-corner">
			</div>
			<span class="run-designer-content">Customize the 'SELECT' statement on the client side using the in-browser Query Builder.</span>
		</div>
	</div>
	<dx:ASPxHiddenField runat="server" ClientInstanceName="hfShowTooltip" ID="hfShowTooltip">
	</dx:ASPxHiddenField>
</a>
<script type="text/javascript">
	(function() {
		var runDesignerTooltip = document.getElementById("run-designer-tooltip");
		if (!hfShowTooltip.Get("showTooltip")) {
			runDesignerTooltip.style.display = "none";
			return;
		}
		setTimeout(function() {
			runDesignerTooltip.className += " run-designer-fade";
		}, 5000);
		setTimeout(function() {
			runDesignerTooltip.style.display = "none";
		}, 7000);
	})();
</script>