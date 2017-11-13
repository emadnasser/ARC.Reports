﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Contacts.aspx.cs" Inherits="Contacts"
    EnableViewState="false" %>
<asp:Content ID="Content1" ContentPlaceHolderID="SideHolder" runat="Server">
    <div class="ContactsNavArea">
        <dx:ASPxNavBar runat="server" ID="ContactViewBar" AllowExpanding="False" Width="100%" ShowExpandButtons="False" CssClass="ContactViewBar">
            <Groups>
                <dx:NavBarGroup Text="Address Books" Name="AddressBooks">
                    <ContentTemplate>
                        <dx:ASPxRadioButtonList runat="server" ID="AddressBookList" CssClass="AddressBookList">
                            <Items>
                                <dx:ListEditItem Text="Personal" Value="0" Selected="True" />
                                <dx:ListEditItem Text="Business" Value="1" />
                            </Items>
                            <Border BorderWidth="0" />
                            <ClientSideEvents SelectedIndexChanged="MailDemo.ClientContactAddressBookList_SelectedIndexChanged" />
                        </dx:ASPxRadioButtonList>
                    </ContentTemplate>
                </dx:NavBarGroup>
                <dx:NavBarGroup Text="Sort" Name="Sort">
                    <ContentTemplate>
                        <div class="field">
                            <div class="label">
                                <dx:ASPxLabel ID="SortByLabel" runat="server" Text="Sort by:" AssociatedControlID="SortByCombo" />
                            </div>
                            <div class="editor">
                                <dx:ASPxComboBox ID="SortByCombo" runat="server" Width="120" SelectedIndex="0">
                                    <Items>
                                        <dx:ListEditItem Value="Name" />
                                        <dx:ListEditItem Value="Email" />
                                        <dx:ListEditItem Value="Country" />
                                    </Items>
                                    <ClientSideEvents SelectedIndexChanged="MailDemo.ClientContactSortByCombo_SelectedIndexChanged" />
                                </dx:ASPxComboBox>
                            </div>
                        </div>
                        <div class="field">
                            <div class="label">
                                <dx:ASPxLabel ID="SortDirectionLabel" runat="server" Text="Direction:" AssociatedControlID="SortDirectionCombo" />
                            </div>
                            <div class="editor">
                                <dx:ASPxComboBox ID="SortDirectionCombo" runat="server" Width="120" SelectedIndex="0">
                                    <Items>
                                        <dx:ListEditItem Text="Ascending" Value="0" />
                                        <dx:ListEditItem Text="Descending" Value="1" />
                                    </Items>
                                    <ClientSideEvents SelectedIndexChanged="MailDemo.ClientContactSortDirectionCombo_SelectedIndexChanged" />
                                </dx:ASPxComboBox>
                            </div>
                        </div>
                    </ContentTemplate>
                </dx:NavBarGroup>
            </Groups>
            <Paddings Padding="0" />
            <Border BorderWidth="0" />
        </dx:ASPxNavBar>
    </div>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainHolder" runat="Server">
    <dx:ASPxCardView ID="ContactCardView" ClientInstanceName="ClientContactCardView" OnCustomCallback="ContactDataView_CustomCallback" KeyFieldName="ID" Width="100%" runat="server">
        <CardLayoutProperties ColCount="2">
            <Items>
                <dx:CardViewColumnLayoutItem ShowCaption="False" VerticalAlign="Top" Width="40%" HorizontalAlign="Center">
                    <Template>
                        <dx:ASPxImage ID="ContactPhoto" ImageUrl="<%# GetContactImageUrl(Container) %>" Height="150" Width="125" CssClass="Photo" runat="server" />
                    </Template>
                </dx:CardViewColumnLayoutItem>
                <dx:CardViewLayoutGroup ShowCaption="False" CssClass="Info" Width="60%">
                    <Items>
                        <dx:CardViewColumnLayoutItem ColumnName="Name"/>
                        <dx:CardViewColumnLayoutItem ColumnName="Email"/>
                        <dx:CardViewColumnLayoutItem ColumnName="FullAddress"/>
                        <dx:CardViewColumnLayoutItem ColumnName="Phone"/>
                    </Items>
                    <Paddings Padding="0"></Paddings>
                </dx:CardViewLayoutGroup>
            </Items>
            <SettingsItemCaptions Location="Top" />
            <Styles>
                <LayoutItem>
                    <Caption ForeColor="Black">
                        <Font bold="True"></Font>
                    </Caption>
                    <Paddings Padding="2"></Paddings>
                    <NestedControlCell>
                        <Paddings Padding="0"></Paddings>
                    </NestedControlCell>
                </LayoutItem>
                <LayoutGroupBox>
                    <Border BorderWidth="0"></Border>
                </LayoutGroupBox>
            </Styles>
            <SettingsAdaptivity AdaptivityMode="SingleColumnWindowLimit" SwitchToSingleColumnAtWindowInnerWidth="1190"></SettingsAdaptivity>
        </CardLayoutProperties>
        <Columns>
            <dx:CardViewTextColumn FieldName="Name" />
            <dx:CardViewTextColumn FieldName="Email" />
            <dx:CardViewTextColumn FieldName="FullAddress" UnboundType="String" UnboundExpression="GetAddress([Address],[City],[Country])"/>
            <dx:CardViewTextColumn FieldName="Phone" />
        </Columns>
        <Templates>
            <CardHeader>
                <div class="CommandItems">
                    <dx:ASPxImage ID="DeleteContactImage" runat="server" SpriteCssClass="Sprite_RemoveSmall" Cursor="Pointer" OnLoad="DeleteContactImage_Load" ImageAlign="Right">
                        <ClientSideEvents Click="MailDemo.ClientDeleteContactImage_Click" />
                    </dx:ASPxImage>
                    <dx:ASPxImage ID="EditContactImage" runat="server" SpriteCssClass="Sprite_EditContact" Cursor="Pointer" OnLoad="EditContactImage_Load" ImageAlign="Right">
                        <ClientSideEvents Click="MailDemo.ClientEditContactImage_Click" />
                    </dx:ASPxImage>
                </div>
            </CardHeader>
        </Templates>
        <Settings LayoutMode="Flow" ShowCardHeader="True"></Settings>
        <SettingsPager Mode="ShowAllRecords"></SettingsPager>
        <SettingsSearchPanel CustomEditorID="SearchBox"></SettingsSearchPanel>
        <Styles>
            <FlowCard BackColor="White" CssClass="ContactCard">
            </FlowCard>
        </Styles>
        <Border BorderWidth="0"></Border>
    </dx:ASPxCardView>
    <dx:ASPxCallbackPanel runat="server" ID="ContactFormPanel" ClientInstanceName="ClientContactFormPanel" RenderMode="Div" Width="100%" Height="100%"
        ClientVisible="false">
        <PanelCollection>
            <dx:PanelContent>
                <table style="width: 100%">
                    <tr>
                        <td style="width: 15%;"></td>
                        <td style="width: 70%;">
                            <dx:ASPxFormLayout ID="ContactForm" runat="server" ColCount="3">
                                <Items>
                                    <dx:LayoutGroup Caption="MainInfo" GroupBoxDecoration="HeadingLine">
                                        <Items>
                                            <dx:LayoutItem Caption="Name">
                                                <LayoutItemNestedControlCollection>
                                                    <dx:LayoutItemNestedControlContainer runat="server">
                                                        <dx:ASPxTextBox ID="ContactNameEditor" runat="server" Width="100%" ClientInstanceName="ClientContactNameEditor">
                                                            <ValidationSettings SetFocusOnError="True" ValidateOnLeave="true" Display="Dynamic" ErrorDisplayMode="ImageWithTooltip">
                                                                <RequiredField IsRequired="True" ErrorText="Name is required" />
                                                            </ValidationSettings>
                                                        </dx:ASPxTextBox>
                                                    </dx:LayoutItemNestedControlContainer>
                                                </LayoutItemNestedControlCollection>
                                            </dx:LayoutItem>
                                            <dx:LayoutItem Caption="Email">
                                                <LayoutItemNestedControlCollection>
                                                    <dx:LayoutItemNestedControlContainer runat="server">
                                                        <dx:ASPxTextBox ID="ContactEmailEditor" runat="server" Width="100%" ClientInstanceName="ClientContactEmailEditor">
                                                            <ValidationSettings SetFocusOnError="True" ValidateOnLeave="true" Display="Dynamic" ErrorDisplayMode="ImageWithTooltip">
                                                                <RegularExpression ErrorText="Invalid e-mail" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" />
                                                                <RequiredField IsRequired="True" ErrorText="E-mail is required" />
                                                            </ValidationSettings>
                                                        </dx:ASPxTextBox>
                                                    </dx:LayoutItemNestedControlContainer>
                                                </LayoutItemNestedControlCollection>
                                            </dx:LayoutItem>
                                        </Items>
                                        <ParentContainerStyle CssClass="InfoLayoutGroup" />
                                    </dx:LayoutGroup>
                                    <dx:EmptyLayoutItem RowSpan="2">
                                        <ParentContainerStyle CssClass="EmptyLayoutItem" />
                                    </dx:EmptyLayoutItem>
                                    <dx:LayoutGroup Caption="Photo" RowSpan="2" GroupBoxDecoration="HeadingLine" Width="290px">
                                        <Items>
                                            <dx:LayoutItem ShowCaption="false">
                                                <LayoutItemNestedControlCollection>
                                                    <dx:LayoutItemNestedControlContainer runat="server">
                                                        <dx:ASPxBinaryImage ID="ContactPhotoImage" runat="server" ClientInstanceName="ClientContactPhotoImage" OnCustomCallback="ContactPhotoImage_CustomCallback" Width="260px" Height="312px" EmptyImage-Url="Content/Photo/User.png">
                                                            <ClientSideEvents EndCallback="MailDemo.ClientContactPhotoImage_EndCallback" ValueChanged="MailDemo.ClientContactPhotoImage_ValueChanged" />
                                                            <EditingSettings Enabled="true" />
                                                        </dx:ASPxBinaryImage>
                                                    </dx:LayoutItemNestedControlContainer>
                                                </LayoutItemNestedControlCollection>
                                            </dx:LayoutItem>
                                        </Items>
                                        <ParentContainerStyle CssClass="PhotoLayoutGroup" />
                                    </dx:LayoutGroup>
                                    <dx:LayoutGroup Caption="Additional Info" GroupBoxDecoration="HeadingLine">
                                        <Items>
                                            <dx:LayoutItem Caption="Address">
                                                <LayoutItemNestedControlCollection>
                                                    <dx:LayoutItemNestedControlContainer runat="server">
                                                        <dx:ASPxTextBox ID="ContactAddressEditor" runat="server" Width="100%" ClientInstanceName="ClientContactAddressEditor" />
                                                    </dx:LayoutItemNestedControlContainer>
                                                </LayoutItemNestedControlCollection>
                                            </dx:LayoutItem>
                                            <dx:LayoutItem Caption="Country">
                                                <LayoutItemNestedControlCollection>
                                                    <dx:LayoutItemNestedControlContainer runat="server">
                                                        <dx:ASPxComboBox ID="ContactCountryEditor" runat="server" Width="100%" ClientInstanceName="ClientContactCountryEditor" OnLoad="ContactCountryEditor_Load"
                                                            IncrementalFilteringMode="StartsWith" TextField="CountryName" ValueField="CountryName" EnableSynchronization="False"
                                                            DropDownStyle="DropDown">
                                                            <ClientSideEvents SelectedIndexChanged="MailDemo.ClientContactCountryEditor_SelectedIndexChanged" />
                                                        </dx:ASPxComboBox>
                                                    </dx:LayoutItemNestedControlContainer>
                                                </LayoutItemNestedControlCollection>
                                            </dx:LayoutItem>
                                            <dx:LayoutItem Caption="City">
                                                <LayoutItemNestedControlCollection>
                                                    <dx:LayoutItemNestedControlContainer runat="server">
                                                        <dx:ASPxComboBox ID="ContactCityEditor" runat="server" Width="100%" ClientInstanceName="ClientContactCityEditor"
                                                            OnCallback="ContactCityEditor_Callback" TextField="CityName" ValueField="CityName" IncrementalFilteringMode="StartsWith"
                                                            EnableSynchronization="False" DropDownStyle="DropDown">
                                                        </dx:ASPxComboBox>
                                                    </dx:LayoutItemNestedControlContainer>
                                                </LayoutItemNestedControlCollection>
                                            </dx:LayoutItem>
                                            <dx:LayoutItem Caption="Phone">
                                                <LayoutItemNestedControlCollection>
                                                    <dx:LayoutItemNestedControlContainer runat="server">
                                                        <dx:ASPxTextBox ID="ContactPhoneEditor" runat="server" Width="100%" ClientInstanceName="ClientContactPhoneEditor">
                                                            <MaskSettings Mask="1 (999) 000-0000" IncludeLiterals="All" />
                                                            <ValidationSettings Display="Dynamic" />
                                                        </dx:ASPxTextBox>
                                                    </dx:LayoutItemNestedControlContainer>
                                                </LayoutItemNestedControlCollection>
                                            </dx:LayoutItem>
                                        </Items>
                                        <ParentContainerStyle CssClass="InfoLayoutGroup" />
                                    </dx:LayoutGroup>
                                </Items>
                                <SettingsItemCaptions Location="Top" />
                            </dx:ASPxFormLayout>
                        </td>
                        <td style="width: 15%;"></td>
                    </tr>
                </table>
            </dx:PanelContent>
        </PanelCollection>
        <ClientSideEvents Init="MailDemo.ClientContactFormPanel_Init" />
    </dx:ASPxCallbackPanel>
    <ef:EntityDataSource ID="CountryDataSource" runat="server" ContextTypeName="WorldCitiesContext" EntitySetName="Countries" />
    <ef:EntityDataSource ID="CitiesDataSource" runat="server" ContextTypeName="WorldCitiesContext"
        CommandText="SELECT c.CityName FROM Cities AS c INNER JOIN Countries AS cr ON c.CountryId = cr.CountryID WHERE (cr.CountryName = @CountryName) order by c.CityName">
        <CommandParameters>
            <asp:Parameter Name="CountryName" Type="String" />
        </CommandParameters>
    </ef:EntityDataSource>
</asp:Content>