<%@ Page Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"%>
<asp:Content ID="Content1" ContentPlaceHolderID="OverviewDemoContentHolder" runat="Server">
    <div style="height: 170px;">
        <dx:ASPxRibbon ID="ASPxRibbon" runat="server">
            <Tabs>
                <dx:RibbonTab Name="Home" Text="Home">
                    <Groups>
                        <dx:RibbonGroup Name="Tasks" Text="Tasks">
                            <Items>
                                <dx:RibbonButtonItem Name="TasksList" Text="Tasks List" Size="Large">
                                    <LargeImage IconID="tasks_task_32x32" />
                                </dx:RibbonButtonItem>
                                <dx:RibbonButtonItem Name="NewTask" Text="New">
                                    <SmallImage IconID="tasks_newtask_16x16" />
                                </dx:RibbonButtonItem>
                                <dx:RibbonButtonItem Name="EditTask" Text="Edit">
                                    <SmallImage IconID="tasks_edittask_16x16" />
                                </dx:RibbonButtonItem>
                            </Items>
                        </dx:RibbonGroup>
                        <dx:RibbonGroup Name="SaveAndClose" Text="Save & Close">
                            <Items>
                                <dx:RibbonButtonItem Name="Save" Text="Save" Size="Large">
                                    <LargeImage IconID="save_save_32x32" />
                                </dx:RibbonButtonItem>
                                <dx:RibbonButtonItem Name="SaveTo">
                                    <SmallImage IconID="save_saveto_16x16" />
                                </dx:RibbonButtonItem>
                                <dx:RibbonButtonItem Name="SaveAndClose">
                                    <SmallImage IconID="save_saveandclose_16x16" />
                                </dx:RibbonButtonItem>
                                <dx:RibbonButtonItem Name="Close" Text="Close" Size="Large">
                                    <LargeImage IconID="actions_close_32x32" />
                                </dx:RibbonButtonItem>
                            </Items>
                        </dx:RibbonGroup>
                    </Groups>
                </dx:RibbonTab>
            </Tabs>
        </dx:ASPxRibbon>
    </div>
</asp:Content>
