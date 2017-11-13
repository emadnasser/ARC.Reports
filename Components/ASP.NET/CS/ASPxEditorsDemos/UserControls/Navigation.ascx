<%@ Control Language="C#" %>
<script runat="server">
              
    protected void Page_Load(object sender, EventArgs e) {
        LoadTreeView();
        IntroPageLink.Visible = Utils.IsSiteMode;
        if(DemosModel.Instance.ExpandAllDemosAtFirstTime) {
            NavigationTreeView.SaveStateToCookies = true;
            NavigationTreeView.SaveStateToCookiesID = "NavigationTreeViewState";
            if(Request.Cookies["NavigationTreeViewState"] == null)
                NavigationTreeView.ExpandAll();
        }
    }
    protected void NavigationTreeView_PreRender(object sender, EventArgs e) {
        if(NavigationTreeView.Nodes.Count == 1 && NavigationTreeView.Nodes[0].Nodes.Count == 1)
            NavigationTreeView.Nodes[0].Nodes[0].Expanded = true;
        TreeViewNode node = NavigationTreeView.Nodes.FindByName(Utils.CurrentDemoNodeName);
        NavigationTreeView.SelectedNode = node;
        if(node != null) {
            NavigationTreeView.ExpandToNode(node);
            node.Expanded = true;
            while(node != null) {
                node.NodeStyle.CssClass = "demo-selected";
                node = node.Parent;
            }
        }
    }
    void LoadTreeView() {
        if(!Utils.IsSiteMode)
            LoadTreeView(Utils.CurrentDemo.Product);
        else {
            foreach(var demoProduct in DemosModel.Instance.SortedDemoProducts) {
                if(!demoProduct.HideNavItem && !demoProduct.IsRootDemo)
                    LoadTreeView(demoProduct);
            }
        }
    }
    void LoadTreeView(DemoProductModel product) {
        TreeViewNode demoProductNode = NavigationTreeView.Nodes.Add(product.NavItemTitle, string.Empty, string.Empty, Utils.GenerateDemoUrl(product.Intro));
        demoProductNode.Name = product.Key;
        if(product.IsPreview)
            SetPreviewMarker(demoProductNode);
        if(product.IsNew)
            SetNewMarker(demoProductNode);
        LoadTreeView(product, demoProductNode);
    }
    void LoadTreeView(DemoProductModel product, TreeViewNode productNode) {
        if(product.Overview != null) {
            TreeViewNode overviewNode = productNode.Nodes.Add(product.Overview.Key, string.Empty, string.Empty, Utils.GenerateDemoUrl(product.Overview));
            overviewNode.Name = string.Format("{0}_{1}", product.Key, product.Overview.Key);
        }
        foreach(var group in product.Groups) {
            TreeViewNode groupNode = productNode.Nodes.Add(group.Title);
            groupNode.Name = string.Format("{0}_{1}", product.Key, group.Key);
            foreach(var demo in group.GetAllDemos()) {
                TreeViewNode demoNode = groupNode.Nodes.Add(demo is OverviewPageModel ? demo.Key : demo.Title, string.Empty, string.Empty, Utils.GenerateDemoUrl(demo));
                demoNode.Name = string.Format("{0}_{1}_{2}", product.Key, group.Key, demo.Key);
                if(demo.IsUpdated)
                    SetUpdatedMarker(demoNode);
                if(demo.IsNew)
                    SetNewMarker(demoNode);
                if(demo.IsPreview)
                    SetPreviewMarker(demoNode);
            }
            if(group.IsNew)
                SetNewMarker(groupNode);
        }
    }
    void SetNewMarker(TreeViewNode node) {
        if(!node.Text.Contains("<span"))
            node.Text += "<span class=\"NewIco\"></span>";
        SetUpdatedMarker(node.Parent);
    }
    void SetUpdatedMarker(TreeViewNode node) {
        while(node != null) {
            if(!node.Text.Contains("<span"))
                node.Text += "<span class=\"UpdatedIco\"></span>";
            node = node.Parent;
        }
    }
    void SetPreviewMarker(TreeViewNode node) {
        if(!node.Text.Contains("<span"))
            node.Text += "<span class=\"PreviewIco\"></span>";
        SetUpdatedMarker(node.Parent);
    }
</script>
<div class="IntroPageLink" runat="server" id="IntroPageLink">
    <% if(Utils.RootProduct != null) { %>
    <dx:ASPxImage runat="server" SpriteCssClass="Ico"></dx:ASPxImage>
    <a class="Text" href="<%= Utils.GenerateDemoUrl(Utils.RootProduct.Intro) %>">
        <%= Utils.RootProduct.NavItemTitle%>
    </a>
    <% } %>
</div>
<dx:ASPxTreeView runat="server" ID="NavigationTreeView" OnPreRender="NavigationTreeView_PreRender" Width="268px"
    EnableViewState="false" EnableTheming="false" AccessibilityCompliant="true" CssClass="DemoTree" ShowTreeLines="false" EncodeHtml="false">
    <ClientSideEvents NodeClick="DXDemo.treeViewNodeClick" ExpandedChanging="DXDemo.treeViewExpandedChanging" />
</dx:ASPxTreeView>
