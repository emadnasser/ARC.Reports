<%@ Page Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Features.aspx.cs"
    Inherits="RoundPanel_Features" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" runat="Server">
    <div>
        <div style="padding: 20px; display: inline-block; vertical-align: top;">
            <dx:ASPxRoundPanel ID="ASPxRoundPanel1" ClientInstanceName="roundPanel" HeaderText="ASP.NET WebForms" runat="server" Width="270">
                <PanelCollection>
                    <dx:PanelContent>
                        <h4>95+ ASP.NET Controls</h4>
                        <br />
                        The controls that ship as part of the DevExpress ASP.NET Subscription help you create engaging, 
                        interactive and touch-enabled web experiences that emulate 
                        the capabilities of today’s most popular web applications and 
                        maintain the highest performance standards regardless of the demands placed upon 
                        your web application by your end-users.
                    </dx:PanelContent>
                </PanelCollection>
            </dx:ASPxRoundPanel>
        </div>
        <div style="padding: 0px 20px 20px 40px; display: inline-block;">
            <dx:ASPxFormLayout ID="ASPxFormLayout1" runat="server">
                <Items>
                    <dx:LayoutGroup GroupBoxDecoration="None">
                        <Items>
                            <dx:LayoutItem Caption="View">
                                <CaptionCellStyle Paddings-Padding="0">
                                </CaptionCellStyle>
                            </dx:LayoutItem>
                            <dx:LayoutGroup GroupBoxDecoration="None">
                                <Items>
                                    <dx:LayoutItem ShowCaption="False">
                                        <LayoutItemNestedControlCollection>
                                            <dx:LayoutItemNestedControlContainer>
                                                <dx:ASPxRadioButtonList ID="rpView" runat="server" AutoPostBack="true" ValueType="System.Int32">
                                                    <Items>
                                                        <dx:ListEditItem Text="Standard" Value="0" Selected="true" />
                                                        <dx:ListEditItem Text="GroupBox" Value="1" />
                                                    </Items>
                                                    <Border BorderColor="Transparent" />
                                                    <Paddings Padding="0" />
                                                </dx:ASPxRadioButtonList>
                                            </dx:LayoutItemNestedControlContainer>
                                        </LayoutItemNestedControlCollection>
                                    </dx:LayoutItem>
                                </Items>
                            </dx:LayoutGroup>
                        </Items>
                    </dx:LayoutGroup>
                    <dx:LayoutGroup GroupBoxDecoration="None">
                        <Items>
                            <dx:LayoutItem ShowCaption="False">
                                <LayoutItemNestedControlCollection>
                                    <dx:LayoutItemNestedControlContainer>
                                        <dx:ASPxCheckBox ID="rpShowHeader" runat="server" Text="ShowHeader" Checked="true"
                                            AutoPostBack="true">
                                        </dx:ASPxCheckBox>
                                    </dx:LayoutItemNestedControlContainer>
                                </LayoutItemNestedControlCollection>
                            </dx:LayoutItem>
                            <dx:LayoutGroup GroupBoxDecoration="None" Name="CollapsingSettingsGroup">
                                <Items>
                                    <dx:LayoutItem ShowCaption="False">
                                        <LayoutItemNestedControlCollection>
                                            <dx:LayoutItemNestedControlContainer>
                                                <dx:ASPxCheckBox ID="rpAllowCollapsingByHeaderClick" Text="AllowCollapsingByHeaderClick" runat="server" Checked="true"
                                                    AutoPostBack="true">
                                                </dx:ASPxCheckBox>
                                            </dx:LayoutItemNestedControlContainer>
                                        </LayoutItemNestedControlCollection>
                                    </dx:LayoutItem>
                                    <dx:LayoutItem ShowCaption="False">
                                        <LayoutItemNestedControlCollection>
                                            <dx:LayoutItemNestedControlContainer>
                                                <dx:ASPxCheckBox ID="rpShowCollapseButton" Text="ShowCollapseButton" runat="server"
                                                    Checked="true" AutoPostBack="true">
                                                </dx:ASPxCheckBox>
                                            </dx:LayoutItemNestedControlContainer>
                                        </LayoutItemNestedControlCollection>
                                    </dx:LayoutItem>
                                    <dx:LayoutItem ShowCaption="False">
                                        <LayoutItemNestedControlCollection>
                                            <dx:LayoutItemNestedControlContainer>
                                                <dx:ASPxCheckBox ID="rpEnableAnimation" runat="server" Checked="true" Text="EnableAnimation"
                                                    AutoPostBack="true">
                                                </dx:ASPxCheckBox>
                                            </dx:LayoutItemNestedControlContainer>
                                        </LayoutItemNestedControlCollection>
                                    </dx:LayoutItem>
                                </Items>
                            </dx:LayoutGroup>
                        </Items>
                    </dx:LayoutGroup>
                </Items>
            </dx:ASPxFormLayout>
        </div>
    </div>
</asp:Content>
