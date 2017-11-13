<%@ Page Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="PasteFormatting.aspx.cs"
    Inherits="Features_PasteFormatting" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" runat="Server">
    <dx:ASPxFormLayout ID="ASPxFormLayout2" runat="server" ShowItemCaptionColon="False"  AlignItemCaptionsInAllGroups="true" ColCount="2">
        <Paddings PaddingBottom="10px" />
        <Items>
            <dx:LayoutItem ShowCaption="False">
                <ParentContainerStyle>
                    <Paddings PaddingRight="30px" />
                </ParentContainerStyle>
                <layoutitemnestedcontrolcollection>
                    <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer14" runat="server">
                        <dx:ASPxCheckBox ID="cbEnablePasteOptions" runat="server" AutoPostBack="True" Checked="True"  Text="EnablePasteOptions" />
                    </dx:LayoutItemNestedControlContainer>
                </layoutitemnestedcontrolcollection>
                <captionsettings location="Right" verticalalign="Middle" />
            </dx:LayoutItem>
            <dx:LayoutItem Caption="PasteMode:">
                <ParentContainerStyle>
                    <Paddings PaddingTop="1px" />
                </ParentContainerStyle>
                <LayoutItemNestedControlCollection>
                    <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer13" runat="server">
                        <dx:ASPxComboBox ID="cbPasteMode" runat="server" AutoPostBack="True" Width="120px" ValueType="System.Int32" >
                            <Items>
                                <dx:ListEditItem Text="SourceFormatting" Value="0" />
                                <dx:ListEditItem Text="MergeFormatting" Value="1" />
                                <dx:ListEditItem Text="PlainText" Value="2" />
                            </Items>
                        </dx:ASPxComboBox>
                    </dx:LayoutItemNestedControlContainer>
                </LayoutItemNestedControlCollection>
            </dx:LayoutItem>
        </Items>
    </dx:ASPxFormLayout>
    <dx:ASPxHtmlEditor ID="DemoHtmlEditor" runat="server" Width="900px" Height="380">
        <SettingsHtmlEditing EnablePasteOptions="true" />
        <Toolbars>
            <dx:HtmlEditorToolbar Name="Toolbar">
                <Items>
                    <dx:ToolbarUndoButton>
                    </dx:ToolbarUndoButton>
                    <dx:ToolbarRedoButton>
                    </dx:ToolbarRedoButton>
                    <dx:ToolbarFontNameEdit BeginGroup="true">
                        <Items>
                            <dx:ToolbarListEditItem Text="Times New Roman" Value="Times New Roman" />
                            <dx:ToolbarListEditItem Text="Tahoma" Value="Tahoma" />
                            <dx:ToolbarListEditItem Text="Verdana" Value="Verdana" />
                            <dx:ToolbarListEditItem Text="Arial" Value="Arial" />
                            <dx:ToolbarListEditItem Text="MS Sans Serif" Value="MS Sans Serif" />
                            <dx:ToolbarListEditItem Text="Courier" Value="Courier" />
                        </Items>
                    </dx:ToolbarFontNameEdit>
                    <dx:ToolbarFontSizeEdit>
                        <Items>
                            <dx:ToolbarListEditItem Text="1 (8pt)" Value="1" />
                            <dx:ToolbarListEditItem Text="2 (10pt)" Value="2" />
                            <dx:ToolbarListEditItem Text="3 (12pt)" Value="3" />
                            <dx:ToolbarListEditItem Text="4 (14pt)" Value="4" />
                            <dx:ToolbarListEditItem Text="5 (18pt)" Value="5" />
                            <dx:ToolbarListEditItem Text="6 (24pt)" Value="6" />
                            <dx:ToolbarListEditItem Text="7 (36pt)" Value="7" />
                        </Items>
                    </dx:ToolbarFontSizeEdit>
                    <dx:ToolbarBoldButton BeginGroup="true">
                    </dx:ToolbarBoldButton>
                    <dx:ToolbarItalicButton>
                    </dx:ToolbarItalicButton>
                    <dx:ToolbarUnderlineButton>
                    </dx:ToolbarUnderlineButton>
                    <dx:ToolbarStrikethroughButton>
                    </dx:ToolbarStrikethroughButton>
                    <dx:ToolbarJustifyLeftButton BeginGroup="true">
                    </dx:ToolbarJustifyLeftButton>
                    <dx:ToolbarJustifyCenterButton>
                    </dx:ToolbarJustifyCenterButton>
                    <dx:ToolbarJustifyRightButton>
                    </dx:ToolbarJustifyRightButton>
                    <dx:ToolbarInsertImageDialogButton BeginGroup="True">
                    </dx:ToolbarInsertImageDialogButton>
                </Items>
            </dx:HtmlEditorToolbar>
        </Toolbars>
    </dx:ASPxHtmlEditor>
    <br />
    <div class="Note">
        Copy a part of editor content and paste it with formatting specified by the PasteMode combo box. Use the buttons that appear in the top right corner of the design area to change the paste formatting mode for the recently pasted content.
    </div>
</asp:Content>
