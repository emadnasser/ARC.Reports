<%@ Control Language="vb" %>
<script runat="server">

	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		LoadTreeView()
		IntroPageLink.Visible = Utils.IsSiteMode
		If DemosModel.Instance.ExpandAllDemosAtFirstTime Then
			NavigationTreeView.SaveStateToCookies = True
			NavigationTreeView.SaveStateToCookiesID = "NavigationTreeViewState"
			If Request.Cookies("NavigationTreeViewState") Is Nothing Then
				NavigationTreeView.ExpandAll()
			End If
		End If
	End Sub
	Protected Sub NavigationTreeView_PreRender(ByVal sender As Object, ByVal e As EventArgs)
		If NavigationTreeView.Nodes.Count = 1 AndAlso NavigationTreeView.Nodes(0).Nodes.Count = 1 Then
			NavigationTreeView.Nodes(0).Nodes(0).Expanded = True
		End If
		Dim node As TreeViewNode = NavigationTreeView.Nodes.FindByName(Utils.CurrentDemoNodeName)
		NavigationTreeView.SelectedNode = node
		If node IsNot Nothing Then
			NavigationTreeView.ExpandToNode(node)
			node.Expanded = True
			Do While node IsNot Nothing
				node.NodeStyle.CssClass = "demo-selected"
				node = node.Parent
			Loop
		End If
	End Sub
	Sub LoadTreeView()
		If (Not Utils.IsSiteMode) Then
			LoadTreeView(Utils.CurrentDemo.Product)
		Else
			For Each demoProduct In DemosModel.Instance.SortedDemoProducts
				If (Not demoProduct.HideNavItem) AndAlso (Not demoProduct.IsRootDemo) Then
					LoadTreeView(demoProduct)
				End If
			Next demoProduct
		End If
	End Sub
	Sub LoadTreeView(ByVal product As DemoProductModel)
		Dim demoProductNode As TreeViewNode = NavigationTreeView.Nodes.Add(product.NavItemTitle, String.Empty, String.Empty, Utils.GenerateDemoUrl(product.Intro))
		demoProductNode.Name = product.Key
		If product.IsPreview Then
			SetPreviewMarker(demoProductNode)
		End If
		If product.IsNew Then
			SetNewMarker(demoProductNode)
		End If
		LoadTreeView(product, demoProductNode)
	End Sub
	Sub LoadTreeView(ByVal product As DemoProductModel, ByVal productNode As TreeViewNode)
		If product.Overview IsNot Nothing Then
			Dim overviewNode As TreeViewNode = productNode.Nodes.Add(product.Overview.Key, String.Empty, String.Empty, Utils.GenerateDemoUrl(product.Overview))
			overviewNode.Name = String.Format("{0}_{1}", product.Key, product.Overview.Key)
		End If
		For Each group In product.Groups
			Dim groupNode As TreeViewNode = productNode.Nodes.Add(group.Title)
			groupNode.Name = String.Format("{0}_{1}", product.Key, group.Key)
			For Each demo In group.GetAllDemos()
				Dim demoNode As TreeViewNode = groupNode.Nodes.Add(If(TypeOf demo Is OverviewPageModel, demo.Key, demo.Title), String.Empty, String.Empty, Utils.GenerateDemoUrl(demo))
				demoNode.Name = String.Format("{0}_{1}_{2}", product.Key, group.Key, demo.Key)
				If demo.IsUpdated Then
					SetUpdatedMarker(demoNode)
				End If
				If demo.IsNew Then
					SetNewMarker(demoNode)
				End If
				If demo.IsPreview Then
					SetPreviewMarker(demoNode)
				End If
			Next demo
			If group.IsNew Then
				SetNewMarker(groupNode)
			End If
		Next group
	End Sub
	Sub SetNewMarker(ByVal node As TreeViewNode)
		If (Not node.Text.Contains("<span")) Then
			node.Text &= "<span class=""NewIco""></span>"
		End If
		SetUpdatedMarker(node.Parent)
	End Sub
	Sub SetUpdatedMarker(ByVal node As TreeViewNode)
		Do While node IsNot Nothing
			If (Not node.Text.Contains("<span")) Then
				node.Text &= "<span class=""UpdatedIco""></span>"
			End If
			node = node.Parent
		Loop
	End Sub
	Sub SetPreviewMarker(ByVal node As TreeViewNode)
		If (Not node.Text.Contains("<span")) Then
			node.Text &= "<span class=""PreviewIco""></span>"
		End If
		SetUpdatedMarker(node.Parent)
	End Sub
</script>
<div class="IntroPageLink" runat="server" id="IntroPageLink">
<%
	   If Utils.RootProduct IsNot Nothing Then
%>
	<dx:ASPxImage runat="server" SpriteCssClass="Ico"></dx:ASPxImage>
	<a class="Text" href="<%=Utils.GenerateDemoUrl(Utils.RootProduct.Intro)%>">
		<%=Utils.RootProduct.NavItemTitle%>
	</a>
<%
	   End If
%>
</div>
<dx:ASPxTreeView runat="server" ID="NavigationTreeView" OnPreRender="NavigationTreeView_PreRender" Width="268px"
	EnableViewState="false" EnableTheming="false" AccessibilityCompliant="true" CssClass="DemoTree" ShowTreeLines="false" EncodeHtml="false">
	<ClientSideEvents NodeClick="DXDemo.treeViewNodeClick" ExpandedChanging="DXDemo.treeViewExpandedChanging" />
</dx:ASPxTreeView>