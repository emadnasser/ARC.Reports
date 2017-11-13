<%@ Page Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="NullText.aspx.cs"
    Inherits="Features_NullText" %>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentHolder" runat="Server">
    <dx:ASPxFormLayout ID="ASPxFormLayout" runat="server">
        <Items>
            <dx:LayoutItem Caption="Name:">
                <LayoutItemNestedControlCollection>
                    <dx:LayoutItemNestedControlContainer>
                        <dx:ASPxButtonEdit ID="TextBox" runat="server" NullText="Enter your name..." Width="170px">
                            <ClearButton DisplayMode="OnHover"></ClearButton>
                        </dx:ASPxButtonEdit>
                    </dx:LayoutItemNestedControlContainer>
                </LayoutItemNestedControlCollection>
            </dx:LayoutItem>
            <dx:LayoutItem Caption="Password:">
                <LayoutItemNestedControlCollection>
                    <dx:LayoutItemNestedControlContainer>
                        <dx:ASPxButtonEdit ID="PasswordTextBox" runat="server" NullText="Enter your password..." Password="true" Width="170px">
                            <ClearButton DisplayMode="OnHover"></ClearButton>
                        </dx:ASPxButtonEdit>
                    </dx:LayoutItemNestedControlContainer>
                </LayoutItemNestedControlCollection>
            </dx:LayoutItem>
            <dx:LayoutItem Caption="Product:">
                <LayoutItemNestedControlCollection>
                    <dx:LayoutItemNestedControlContainer>
                        <dx:ASPxComboBox ID="ProductComboBox" runat="server" NullText="Choose the product..." Width="170px" DropDownStyle="DropDown">
                            <ClearButton DisplayMode="OnHover"></ClearButton>
                            <Items>
                                <dx:ListEditItem Selected="false" Text="WinForms Controls" Value="0" />
                                <dx:ListEditItem Selected="false" Text="ASP.NET Controls" Value="1" />
                                <dx:ListEditItem Selected="false" Text="MVC Extensions" Value="2" />
                                <dx:ListEditItem Selected="false" Text="WPF Controls" Value="3" />
                                <dx:ListEditItem Selected="false" Text="Silverlight Controls" Value="4" />
                                <dx:ListEditItem Selected="false" Text="Windows 8 XAML Controls" Value="5" />
                                <dx:ListEditItem Selected="false" Text="HTML JS Data Visualization Widgets" Value="6" />
                                <dx:ListEditItem Selected="false" Text="HTML JS Multi-Use Widgets" Value="7" />
                                <dx:ListEditItem Selected="false" Text="HTML JS Multi-Channel Framework" Value="8" />
                                <dx:ListEditItem Selected="false" Text="CodeRush" Value="9" />
                                <dx:ListEditItem Selected="false" Text="Data Visualization Dashboard" Value="10" />
                                <dx:ListEditItem Selected="false" Text="Report Server" Value="11" />
                                <dx:ListEditItem Selected="false" Text="eXpressApp Framework" Value="12" />
                                <dx:ListEditItem Selected="false" Text="Coded UI Support for WinForms Controls" Value="13" />
                            </Items>
                        </dx:ASPxComboBox>
                    </dx:LayoutItemNestedControlContainer>
                </LayoutItemNestedControlCollection>
            </dx:LayoutItem>
            <dx:LayoutItem Caption="Quantity:">
                <LayoutItemNestedControlCollection>
                    <dx:LayoutItemNestedControlContainer>
                        <dx:ASPxSpinEdit ID="QuantityEdit" runat="server" NullText="From 1 to 10..." Width="170px"
                            MinValue="1" MaxValue="10">
                            <ClearButton DisplayMode="OnHover"></ClearButton>
                        </dx:ASPxSpinEdit>
                    </dx:LayoutItemNestedControlContainer>
                </LayoutItemNestedControlCollection>
            </dx:LayoutItem>
            <dx:LayoutItem Caption="Employee:">
                <LayoutItemNestedControlCollection>
                    <dx:LayoutItemNestedControlContainer>
                        <dx:ASPxGridLookup ID="EmployeeGridLookup" runat="server" DataSourceID="EmployeesDataSource"
                            NullText="Select employee..." AutoGenerateColumns="false" KeyFieldName="EmployeeID" TextFormatString="{0} {1}">
                            <GridViewProperties>
                                <SettingsBehavior AutoExpandAllGroups="true" />
                            </GridViewProperties>
                            <Columns>
                                <dx:GridViewDataTextColumn Caption="First Name" FieldName="FirstName" SortOrder="Ascending"></dx:GridViewDataTextColumn>
                                <dx:GridViewDataTextColumn Caption="Last Name" FieldName="LastName"></dx:GridViewDataTextColumn>
                                <dx:GridViewDataTextColumn Caption="City" FieldName="City"></dx:GridViewDataTextColumn>
                                <dx:GridViewDataTextColumn Caption="Country" FieldName="Country" GroupIndex="0"></dx:GridViewDataTextColumn>
                            </Columns>
                            <ClearButton DisplayMode="OnHover"></ClearButton>
                        </dx:ASPxGridLookup>
                    </dx:LayoutItemNestedControlContainer>
                </LayoutItemNestedControlCollection>
            </dx:LayoutItem>
            <dx:LayoutItem Caption="Date:">
                <LayoutItemNestedControlCollection>
                    <dx:LayoutItemNestedControlContainer>
                        <dx:ASPxDateEdit ID="DateEdit" ClientInstanceName="dateEdit" runat="server" NullText="mm/dd/yyyy" EditFormat="Custom"
                            EditFormatString="MM/dd/yyyy" Width="170px">
                            <ClearButton DisplayMode="OnHover"></ClearButton>
                        </dx:ASPxDateEdit>
                    </dx:LayoutItemNestedControlContainer>
                </LayoutItemNestedControlCollection>
            </dx:LayoutItem>
            <dx:LayoutItem Caption="Time:">
                <LayoutItemNestedControlCollection>
                    <dx:LayoutItemNestedControlContainer>
                        <dx:ASPxTimeEdit ID="TimeEdit" ClientInstanceName="timeEdit" runat="server" NullText="hh:mm" Width="170px"
                             EditFormat="Custom" EditFormatString="HH:mm">
                            <ClearButton DisplayMode="OnHover"></ClearButton>
                        </dx:ASPxTimeEdit>
                    </dx:LayoutItemNestedControlContainer>
                </LayoutItemNestedControlCollection>
            </dx:LayoutItem>
            <dx:LayoutItem Caption="Notes:">
                <LayoutItemNestedControlCollection>
                    <dx:LayoutItemNestedControlContainer>
                        <dx:ASPxMemo ID="Notes" runat="server" NullText="If any..." Width="170px" Height="71px">
                        </dx:ASPxMemo>
                    </dx:LayoutItemNestedControlContainer>
                </LayoutItemNestedControlCollection>
            </dx:LayoutItem>
            <dx:LayoutItem Caption="">
                <LayoutItemNestedControlCollection>
                    <dx:LayoutItemNestedControlContainer>
                        <dx:ASPxButton ID="ClearButton" runat="server" AutoPostBack="False" 
                            Text="Clear" UseSubmitBehavior="False">
                            <ClientSideEvents Click="function(s, e) {
                                ASPxClientEdit.ClearEditorsInContainer(form1);
                            }" />
                        </dx:ASPxButton>
                    </dx:LayoutItemNestedControlContainer>
                </LayoutItemNestedControlCollection>
            </dx:LayoutItem>
        </Items>
    </dx:ASPxFormLayout>
    <ef:EntityDataSource runat="server" ID="EmployeesDataSource" ContextTypeName="NorthwindContext" EntitySetName="Employees" />
</asp:Content>
