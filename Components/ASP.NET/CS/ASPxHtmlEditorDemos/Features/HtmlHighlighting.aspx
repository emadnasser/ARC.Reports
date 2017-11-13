<%@ Page Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="HtmlHighlighting.aspx.cs"
    Inherits="Features_HtmlHighlighting" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" runat="Server">
    <div style="float: left; padding-right: 20px;">
        <dx:ASPxHtmlEditor ID="DemoHtmlEditor" runat="server" Height="562px" Width="694px" ActiveView="Html">
            <SettingsDialogs>
                <InsertImageDialog>
                    <SettingsImageUpload UploadFolder="~/UploadFiles/Images/">
                        <ValidationSettings AllowedFileExtensions=".jpe,.jpeg,.jpg,.gif,.png" MaxFileSize="500000">
                        </ValidationSettings>
                    </SettingsImageUpload>
                </InsertImageDialog>
            </SettingsDialogs>
        </dx:ASPxHtmlEditor>
    </div>
    <dx:ASPxFormLayout ID="FormLayout" runat="server"  ShowItemCaptionColon="false" Width="200px">
        <Items>
            <dx:LayoutGroup Caption="HtmlView Settings" GroupBoxDecoration="HeadingLine">
                <ParentContainerStyle>
                    <Paddings Padding="0" />
                </ParentContainerStyle>
                <Items>
                    <dx:LayoutItem ShowCaption="False">
                        <LayoutItemNestedControlCollection>
                            <dx:LayoutItemNestedControlContainer runat="server">
                                <dx:ASPxCheckBox ID="cbEnableAutoCompletion" runat="server" AutoPostBack="True" Checked="true" Text="EnableAutoCompletion"  />
                            </dx:LayoutItemNestedControlContainer>
                        </LayoutItemNestedControlCollection>
                    </dx:LayoutItem>
                    <dx:LayoutItem ShowCaption="False">
                        <LayoutItemNestedControlCollection>
                            <dx:LayoutItemNestedControlContainer runat="server">
                                <dx:ASPxCheckBox ID="cbEnableTagAutoClosing" runat="server" AutoPostBack="True" Checked="true" Text="EnableTagAutoClosing"  />
                            </dx:LayoutItemNestedControlContainer>
                        </LayoutItemNestedControlCollection>
                    </dx:LayoutItem>
                    <dx:LayoutItem ShowCaption="False">
                        <LayoutItemNestedControlCollection>
                            <dx:LayoutItemNestedControlContainer runat="server">
                                <dx:ASPxCheckBox ID="cbHighlightActiveLine" runat="server" AutoPostBack="True" Checked="true" Text="HighlightActiveLine" />
                            </dx:LayoutItemNestedControlContainer>
                        </LayoutItemNestedControlCollection>
                    </dx:LayoutItem>
                    <dx:LayoutItem ShowCaption="False">
                        <LayoutItemNestedControlCollection>
                            <dx:LayoutItemNestedControlContainer runat="server">
                                <dx:ASPxCheckBox ID="cbHighlightMatchingTags" runat="server" AutoPostBack="True" Checked="true" Text="HighlightMatchingTags" />
                            </dx:LayoutItemNestedControlContainer>
                        </LayoutItemNestedControlCollection>
                    </dx:LayoutItem>
                    <dx:LayoutItem ShowCaption="False">
                        <LayoutItemNestedControlCollection>
                            <dx:LayoutItemNestedControlContainer runat="server">
                                <dx:ASPxCheckBox ID="cbShowCollapseTagButtons" runat="server" AutoPostBack="True" Checked="true" Text="ShowCollapseTagButtons"  />
                            </dx:LayoutItemNestedControlContainer>
                        </LayoutItemNestedControlCollection>
                    </dx:LayoutItem>
                    <dx:LayoutItem ShowCaption="False">
                        <LayoutItemNestedControlCollection>
                            <dx:LayoutItemNestedControlContainer runat="server">
                                <dx:ASPxCheckBox ID="cbShowLineNumbers" runat="server" AutoPostBack="True" Checked="true" Text="ShowLineNumbers"  />
                            </dx:LayoutItemNestedControlContainer>
                        </LayoutItemNestedControlCollection>
                    </dx:LayoutItem>
                    <dx:LayoutItem Caption="Mode:" CaptionSettings-Location="Top">
                        <LayoutItemNestedControlCollection>
                            <dx:LayoutItemNestedControlContainer runat="server">
                                <dx:ASPxComboBox ID="cbHtmlEditingMode" runat="server" AutoPostBack="True" Width="125px" ValueType="System.Int32" >
                                    <Items>
                                        <dx:ListEditItem Text="Simple" Value="0" />
                                        <dx:ListEditItem Text="Advanced" Value="1" Selected="true" />
                                        <dx:ListEditItem Text="Auto" Value="2" />
                                    </Items>
                                </dx:ASPxComboBox>
                            </dx:LayoutItemNestedControlContainer>
                        </LayoutItemNestedControlCollection>
                    </dx:LayoutItem>
                </Items>
            </dx:LayoutGroup>
        </Items>
    </dx:ASPxFormLayout>
</asp:Content>
