<%@ Control Language="C#" AutoEventWireup="true" CodeFile="ToolbarExport.ascx.cs" Inherits="DemosExport.ToolbarExport" %>
<div class="OptionsBottomMargin">
    <dx:ASPxMenu runat="server" ID="MenuExportButtons" ClientInstanceName="MenuExportButtons" ShowAsToolbar="true" OnItemClick="MenuExportButtons_ItemClick" AutoPostBack="true">
        <Items>
            <dx:MenuItem Name="ToolbarCaption">
                <Template>
                    <div class="exportToolbarCaption">
                        <dx:ASPxLabel runat="server" ID="labelCaption" Text="Export type:" />
                    </div>
                </Template>
            </dx:MenuItem>
        </Items>
    </dx:ASPxMenu>
</div>
