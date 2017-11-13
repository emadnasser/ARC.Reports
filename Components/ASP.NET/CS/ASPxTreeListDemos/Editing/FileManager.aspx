<%@ Page Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="FileManager.aspx.cs"
    Inherits="Editing_FileManager" %>
<asp:Content runat="server" ContentPlaceHolderID="CustomHeadHolder">
    <%--start highlighted block--%>
    <script type="text/javascript">
        // Button handlers
        function bNewFolder_Click(s, e) {
            var key = tree.GetFocusedNodeKey();
            tree.StartEditNewNode(key);
        }
        function bNewRoot_Click(s, e) {
            tree.StartEditNewNode();
        }
        function bDelete_Click(s, e) {
            if(!confirm("Are you sure?"))
                return;
            tree.DeleteNode(tree.GetFocusedNodeKey());
        }
        function bRename_Click(s, e) {
            tree.StartEdit(tree.GetFocusedNodeKey());
        }
        function bUpload_Click(s, e) {
            uploader.UploadFile();
        }
        // TreeList handlers
        function tree_Init(s, e) {
            FM_UpdateButtons();
        }
        function tree_FocusChanged(s, e) {
            FM_UpdateButtons();
        }
        function tree_BeginCallback(s, e) {
            FM_UpdateButtons(true);
        }
        function tree_EndCallback(s, e) {
            FM_UpdateButtons();
        }
        function tree_NodeClick(s, e) {
            var key = e.nodeKey;
            if(key == tree.GetFocusedNodeKey() && !tree.IsEditing())
                tree.StartEdit(key);
        }
        function tree_StartDragNode(s, e) {
            var rootTarget = document.getElementById("rootTarget");
            e.targets.push(rootTarget);
        }
        function tree_EndDragNode(s, e) {
            if(e.targetElement.id == "rootTarget") {
                e.cancel = true;
                tree.MoveNode(e.nodeKey, "");
            }
        }
        // Editor handlers
        function editor_Init(s, e) {
            s.SelectAll();
            s.SetFocus();
        }
        function editor_KeyPress(s, e) {
            var code = e.htmlEvent.keyCode;
            if(code == 13)
                tree.UpdateEdit();
            else if(code == 27)
                tree.CancelEdit();
            if(code == 13 || code == 27) {
                var he = e.htmlEvent;
                he.preventDefault && he.preventDefault();
                he.stopPropagation && he.stopPropagation();
                he.returnValue = false;
                he.cancelBubble = true;
            }
        }
        function editor_LostFocus(s, e) {
            tree.UpdateEdit();
        }
        // Uploader handlers
        function uploader_Complete(s, e) {
            tree.PerformCustomCallback("upload_complete");
        }
        // Helper functions
        function FM_UpdateButtons(disableAll) {
            var isEditing = tree.IsEditing();
            var focusedKey = tree.GetFocusedNodeKey();
            var isFolder = FM_IsFolderNode(focusedKey);
            bNewFolder.SetEnabled(!disableAll && !isEditing && isFolder);
            bNewRoot.SetEnabled(!disableAll && !isEditing);
            bDelete.SetEnabled(!disableAll && focusedKey != "" && !isEditing);
            bRename.SetEnabled(!disableAll && focusedKey != "" && !isEditing);
            bUpload.SetEnabled(!disableAll && !isEditing && isFolder);
        }
        function FM_IsFolderNode(key) {
            for(var i = 0; i < tree.cpFolderKeys.length; i++) {
                if(tree.cpFolderKeys[i] == key)
                    return true;
            }
            return false;
        }
    </script>
    <%--end highlighted block--%>
</asp:Content>
<asp:Content ContentPlaceHolderID="ContentHolder" runat="server">
    <table class="OptionsTable OptionsBottomMargin">
        <tr>
            <td>
                <dx:ASPxButton runat="server" ID="bNewFolder" ClientInstanceName="bNewFolder" UseSubmitBehavior="false"
                    AutoPostBack="false" Text="New Folder" Wrap="false">
                    <ClientSideEvents Click="bNewFolder_Click" />
                </dx:ASPxButton>
            </td>
            <td>
                <dx:ASPxButton runat="server" ID="bNewRoot" ClientInstanceName="bNewRoot" UseSubmitBehavior="false"
                    AutoPostBack="false" Text="Add Root" Wrap="false">
                    <ClientSideEvents Click="bNewRoot_Click" />
                </dx:ASPxButton>
            </td>
            <td>
                <dx:ASPxButton runat="server" ID="bDelete" ClientInstanceName="bDelete" UseSubmitBehavior="false"
                    AutoPostBack="false" Text="Delete">
                    <ClientSideEvents Click="bDelete_Click" />
                </dx:ASPxButton>
            </td>
            <td>
                <dx:ASPxButton runat="server" ID="bRename" ClientInstanceName="bRename" UseSubmitBehavior="false"
                    AutoPostBack="false" Text="Rename">
                    <ClientSideEvents Click="bRename_Click" />
                </dx:ASPxButton>
            </td>
            <td style="width: 100%">
            </td>
            <td>
                <dx:ASPxUploadControl runat="server" ID="uploader" ClientInstanceName="uploader" UploadMode="Advanced"
                    OnFileUploadComplete="uploader_FileUploadComplete">
                    <clientsideevents fileuploadcomplete="uploader_Complete" />
                </dx:ASPxUploadControl>
            </td>
            <td style="padding-right: 0">
                <dx:ASPxButton runat="server" ID="bUpload" ClientInstanceName="bUpload" UseSubmitBehavior="false"
                    AutoPostBack="false" Text="Upload">
                    <ClientSideEvents Click="bUpload_Click" />
                </dx:ASPxButton>
            </td>
        </tr>
    </table>
    <dx:ASPxTreeList runat="server" Width="100%" ID="tree" ClientInstanceName="tree"
        OnNodeInserting="tree_NodeInserting" OnVirtualModeCreateChildren="tree_VirtualModeCreateChildren"
        OnVirtualModeNodeCreating="tree_VirtualModeNodeCreating" OnCustomJSProperties="tree_CustomJSProperties"
        OnNodeUpdating="tree_NodeUpdating" OnNodeDeleting="tree_NodeDeleting" OnNodeValidating="tree_NodeValidating"
        OnCustomCallback="tree_CustomCallback" OnProcessDragNode="tree_ProcessDragNode"
        OnCustomNodeSort="tree_CustomNodeSort">
        <Columns>
            <dx:TreeListTextColumn FieldName="Name" SortIndex="0" SortOrder="Ascending">
                <CellStyle>
                    <Paddings Padding="1" />
                </CellStyle>
                <EditCellStyle>
                    <Paddings Padding="1" />
                </EditCellStyle>
                <DataCellTemplate>
                    <table style="width: 100%">
                        <tr>
                            <td style="width: 20px">
                                <dx:ASPxImage runat="server" Width="21" Height="21" ImageUrl='<%# GetNodeGlyph(Container) %>'
                                    ImageAlign="Top" />
                            </td>
                            <td>
                                <%# Container.Text %>
                            </td>
                        </tr>
                    </table>
                </DataCellTemplate>
                <EditCellTemplate>
                    <table style="width: 100%">
                        <tr>
                            <td style="width: 20px">
                                <dx:ASPxImage ID="ASPxImage1" runat="server" Width="21" Height="21"
                                    ImageUrl='<%# GetNodeGlyph(Container) %>' ImageAlign="Top" />
                            </td>
                            <td>
                                <dx:ASPxTextBox runat="server" ID="ed" Text='<%# Bind("Name") %>' Width="200px">
                                    <ClientSideEvents Init="editor_Init" KeyPress="editor_KeyPress" LostFocus="editor_LostFocus" />
                                </dx:ASPxTextBox>
                            </td>
                        </tr>
                    </table>
                </EditCellTemplate>
            </dx:TreeListTextColumn>
        </Columns>
        <ClientSideEvents Init="tree_Init" FocusedNodeChanged="tree_FocusChanged" BeginCallback="tree_BeginCallback"
            EndCallback="tree_EndCallback" NodeClick="tree_NodeClick" StartDragNode="tree_StartDragNode"
            EndDragNode="tree_EndDragNode" />
        <SettingsBehavior AllowFocusedNode="true" />
        <SettingsEditing AllowNodeDragDrop="true" AllowRecursiveDelete="true" />
    </dx:ASPxTreeList>
    <div id="rootTarget" style="height: 24px;">
    </div>
    <p>
        <small><b>Note:</b> New folders and uploaded files are available only in the current
            session. These will be automatically removed in 10 minutes after a session is closed.</small></p>
</asp:Content>
