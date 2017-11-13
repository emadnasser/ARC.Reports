<%@ Page Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Subreports.aspx.cs"
    Inherits="ReportTypes_Subreports" %>
<asp:Content ID="Content2" ContentPlaceHolderID="CustomHeadHolder" runat="Server">
    <link rel="stylesheet" type="text/css" href="<%= Page.ResolveClientUrl("~/Content/RunDesignerButton.css") %>" />
    <link rel="stylesheet" type="text/css" href="<%= Page.ResolveClientUrl("~/Content/ViewerSelector.css") %>" />
    <script type="text/javascript">
        (function(window) {
            function editorInitialized() {
                if(fromDateParameter && fromDateParameter.isInitialized
                    && toDateParameter && toDateParameter.isInitialized) {
                    editorInitializedCore();
                }
            }
            function editorInitializedCore() {
                fromDateParameter.ValueChanged.AddHandler(function() {
                    toDateParameter.Validate();
                });
                fromDateParameter.Validation.AddHandler(function(editor, e) {
                    e.isValid = editor.GetValue() <= toDateParameter.GetValue();
                });
                toDateParameter.ValueChanged.AddHandler(function() {
                    fromDateParameter.Validate();
                });
                toDateParameter.Validation.AddHandler(function(editor, e) {
                    e.isValid = toDateParameter.GetValue() >= fromDateParameter.GetValue();
                });
            }
            window.editorInitialized = editorInitialized;
        })(window);
    </script>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="TopRightMenuRegion" runat="Server">
    <dx:ViewerSelector ID="viewerSelector" runat="server" />
    <dx:ShowDesignerButton ID="showDesignerButton" runat="server" />
</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" runat="Server">
    <% if(IsASPViewer) { %>
    <dx:ASPxDocumentViewer runat="server" ID="documentViewer" OnCustomizeParameterEditors="documentViewer_CustomizeParameterEditors" EnableViewState="False" />
    <% } else if(IsHTML5Viewer) { %>
    <dx:ASPxWebDocumentViewer runat="server" ID="webDocumentViewer" ClientInstanceName="webDocumentViewer" EnableViewState="False" />
    <% } else if(IsMobileViewer) { %>
    <dx:MobileEmulator ID="mobileEmulator" runat="server" />
    <% } %>
</asp:Content>
