<%@ Page Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="DataBindingToSingleObject.aspx.cs" Inherits="FormLayout_DataBindingToSingleObject" %>
<asp:Content ID="MainContent" ContentPlaceHolderID="ContentHolder" runat="Server">
    <dx:ASPxFormLayout ID="formLayout" runat="server" AlignItemCaptionsInAllGroups="True">
        <Items>
            <dx:LayoutGroup Caption="Personal Information" GroupBoxDecoration="HeadingLine">
                <Items>
                    <dx:LayoutItem Caption="First Name" FieldName="FirstName">
                        <LayoutItemNestedControlCollection>
                            <dx:LayoutItemNestedControlContainer runat="server" SupportsDisabledAttribute="True">
                                <dx:ASPxTextBox ID="firstNameTextBox" runat="server" Width="200px" />                                
                            </dx:LayoutItemNestedControlContainer>
                        </LayoutItemNestedControlCollection>
                    </dx:LayoutItem>
                    <dx:LayoutItem Caption="Last Name" FieldName="LastName">
                        <LayoutItemNestedControlCollection>
                            <dx:LayoutItemNestedControlContainer runat="server" SupportsDisabledAttribute="True">
                                <dx:ASPxTextBox ID="lastNameTextBox" runat="server" Width="200px" />                                
                            </dx:LayoutItemNestedControlContainer>
                        </LayoutItemNestedControlCollection>
                    </dx:LayoutItem>
                    <dx:LayoutItem Caption="Gender" FieldName="Gender">
                        <LayoutItemNestedControlCollection>
                            <dx:LayoutItemNestedControlContainer runat="server" SupportsDisabledAttribute="True">
                                <dx:ASPxRadioButtonList ID="genderRadioButtonList" runat="server" RepeatDirection="Horizontal">
                                    <Items>
                                        <dx:ListEditItem Text="Male" Value="Male" />
                                        <dx:ListEditItem Text="Female" Value="Female" />
                                    </Items>
                                    <Border BorderStyle="None" />
                                </dx:ASPxRadioButtonList>
                            </dx:LayoutItemNestedControlContainer>
                        </LayoutItemNestedControlCollection>
                    </dx:LayoutItem>
                    <dx:LayoutItem Caption="Birth Date" FieldName="BirthDate">
                        <LayoutItemNestedControlCollection>
                            <dx:LayoutItemNestedControlContainer runat="server" SupportsDisabledAttribute="True">
                                <dx:ASPxDateEdit ID="birthDateEdit" runat="server" Width="200px" />                                
                            </dx:LayoutItemNestedControlContainer>
                        </LayoutItemNestedControlCollection>
                    </dx:LayoutItem>
                </Items>
            </dx:LayoutGroup>
            <dx:LayoutGroup Caption="Location" GroupBoxDecoration="HeadingLine">
                <Items>
                    <dx:LayoutItem Caption="Country" FieldName="CountryName">
                        <LayoutItemNestedControlCollection>
                            <dx:LayoutItemNestedControlContainer runat="server" SupportsDisabledAttribute="True">
                                <dx:ASPxComboBox ID="countryComboBox" runat="server" DataSourceID="CountriesDataSource" Width="200px"
                                 TextField="CountryName" ValueField="CountryName" />
                            </dx:LayoutItemNestedControlContainer>
                        </LayoutItemNestedControlCollection>
                    </dx:LayoutItem>
                    <dx:LayoutItem Caption="Address" FieldName="Address">
                        <LayoutItemNestedControlCollection>
                            <dx:LayoutItemNestedControlContainer runat="server" SupportsDisabledAttribute="True">
                                <dx:ASPxTextBox ID="addressTextBox" runat="server" Width="200px" />                                
                            </dx:LayoutItemNestedControlContainer>
                        </LayoutItemNestedControlCollection>
                    </dx:LayoutItem>
                    <dx:LayoutItem Caption="Phone Number" FieldName="PhoneNumber">
                        <LayoutItemNestedControlCollection>
                            <dx:LayoutItemNestedControlContainer runat="server" SupportsDisabledAttribute="True">
                                <dx:ASPxTextBox ID="phoneNumberTextBox" runat="server" Width="200px">
                                    <MaskSettings Mask="(999) 000-0000" />
                                </dx:ASPxTextBox>
                            </dx:LayoutItemNestedControlContainer>
                        </LayoutItemNestedControlCollection>
                    </dx:LayoutItem>                    
                </Items>
            </dx:LayoutGroup>
            <dx:LayoutItem ShowCaption="False" HorizontalAlign="Right" Width="100">
                <LayoutItemNestedControlCollection>
                    <dx:LayoutItemNestedControlContainer runat="server" SupportsDisabledAttribute="True">
                        <dx:ASPxButton ID="submitButton" runat="server" OnClick="submitButton_Click" 
                            Text="Submit" Width="100"/>                        
                    </dx:LayoutItemNestedControlContainer>
                </LayoutItemNestedControlCollection>
            </dx:LayoutItem>            
        </Items>
    </dx:ASPxFormLayout>
    <ef:EntityDataSource ID="CountriesDataSource" runat="server" ContextTypeName="WorldCitiesContext" EntitySetName="Countries" OrderBy="it.CountryName" />
</asp:Content>
