<%@ Page Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="ComboBox.aspx.cs"
    Inherits="ToolbarItems_ComboBox" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" runat="Server">
    <%--start highlighted block--%>
    <script type="text/javascript">
    // <![CDATA[
        // Event handlers
        function OnCustomCommand(s, e) {
            if(e.commandName == "PxFontSize")
                SetFontSize(e.parameter);
        }
        function OnSelectionChanged(s, e) {
            var selection = HtmlEditor.GetSelection();
            var selectedElements = selection.GetElements();
            HtmlEditor.SetToolbarComboBoxValue("PxFontSize", GetPxFontSize(selectedElements, selection));
        }
        // Get current font size
        function GetPxFontSize(selectedElements, selection) {
            var size = "";
            if(selectedElements.length > 0) {
                size = GetElementPxFontSize(selectedElements[0]);
                for(var i = 1; i < selectedElements.length; i++)
                    size = GetElementPxFontSize(selectedElements[i]) == size ? size : "";
            }
            else {
                var selectedElement = selection.GetSelectedElement();
                if(selectedElement)
                    size = GetElementPxFontSize(selectedElement);
            }
            return size;
        }
        function GetElementPxFontSize(element) {
            var size = GetCurrentStyle(element.nodeType == 3 ? element.parentNode : element).fontSize;
            return size.indexOf("px") != -1 ? size : "";
        }
        function GetCurrentStyle(element) {
            return ASPxClientUtils.ie ? element.currentStyle : element.ownerDocument.defaultView.getComputedStyle(element, null);
        }
        // Set font size from ComboBox
        function SetFontSize(size) {
            var selection = HtmlEditor.GetSelection();
            var selectedElements = selection.GetElements();
            if(GetPxFontSize(selectedElements, selection) == size)
                return;
            var doc = selection.GetSelectedElement().ownerDocument;
            for(var i = 0; i < selectedElements.length; i++) {
                var curElement = selectedElements[i];
                if(curElement.nodeType == 3) {
                    var wrapper = doc.createElement("SPAN");
                    wrapper.style.fontSize = size;
                    curElement.parentNode.insertBefore(wrapper, curElement);
                    wrapper.appendChild(curElement);
                }
                else if(curElement.childNodes.length > 0)
                    curElement.style.fontSize = size;
            }
            HtmlEditor.SaveToUndoHistory();
        }
    // ]]> 
    </script>
    <%--end highlighted block--%>
    <dx:ASPxHtmlEditor ID="DemoHtmlEditor" runat="server" Height="380px" ClientInstanceName="HtmlEditor">
        <ClientSideEvents CustomCommand="OnCustomCommand" SelectionChanged="OnSelectionChanged" />
        <Toolbars>
            <dx:HtmlEditorToolbar>
                <Items>
                    <dx:ToolbarUndoButton>
                    </dx:ToolbarUndoButton>
                    <dx:ToolbarRedoButton>
                    </dx:ToolbarRedoButton>
                    <dx:ToolbarBoldButton BeginGroup="true">
                    </dx:ToolbarBoldButton>
                    <dx:ToolbarItalicButton>
                    </dx:ToolbarItalicButton>
                    <dx:ToolbarUnderlineButton>
                    </dx:ToolbarUnderlineButton>
                    <dx:ToolbarStrikethroughButton>
                    </dx:ToolbarStrikethroughButton>
                    <dx:ToolbarComboBox CommandName="PxFontSize" BeginGroup="true" DefaultCaption="Font Size">
                        <Items>
                            <dx:ToolbarCustomListEditItem Text="10px" Value="10px" />
                            <dx:ToolbarCustomListEditItem Text="12px" Value="12px" />
                            <dx:ToolbarCustomListEditItem Text="14px" Value="14px" />
                            <dx:ToolbarCustomListEditItem Text="16px" Value="16px" />
                            <dx:ToolbarCustomListEditItem Text="18px" Value="18px" />
                            <dx:ToolbarCustomListEditItem Text="20px" Value="20px" />
                            <dx:ToolbarCustomListEditItem Text="22px" Value="22px" />
                        </Items>
                    </dx:ToolbarComboBox>
                </Items>
            </dx:HtmlEditorToolbar>
        </Toolbars>
    </dx:ASPxHtmlEditor>
</asp:Content>
