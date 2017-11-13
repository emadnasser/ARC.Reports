<%@ Page Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="TabbedGroups.aspx.cs" Inherits="FormLayout_TabbedGroups" %>
<asp:Content ContentPlaceHolderID="CustomHeadHolder" runat="server">
    <style type="text/css">
        .container {
            width: 400px;
        }
        .parentContainer {
            width: 100%;
        }
        .tabbedGroupPageControlCell {
            padding-left: 0px;
            padding-right: 0px;
        }
        .tabbedGroupPageControlCell .dxflPCSys {
            padding-bottom: 10px;
            border-top: 1px Solid #A8A8A8;
        }
        .selectedElement,
        .tabbedGroupPageControlCell .dxflPCSys {
            background-color: #FDFBBA;
        }
        .radioButtonList .dxe {
            padding:0px!important;   
        }
    </style>
    <%--start highlighted block--%>
    <script type="text/javascript">
        var lastValidationResult = false;
        function OnContactMethodChanged(s, e) {
            var selectedIndex = s.GetSelectedIndex();
            UpdateRadioButtonListDecoration(s);
            tabbedGroupPageControl.SetActiveTabIndex(selectedIndex);
        }
        function UpdateRadioButtonListDecoration(radioButtonList) {
            var selectedIndex = radioButtonList.GetSelectedIndex();
            for (var i = 0; i < radioButtonList.GetItemCount(); i++)
                radioButtonList.GetItemElement(i).parentNode.className = i === selectedIndex ? "selectedElement" : "";
        }
        function OnTabbedGroupPageControlInit(s, e) {
            s.SetActiveTabIndex(radioButtonList.GetSelectedIndex());
        }
        function OnEmailValidation(s, e) {
            var valid = mail.GetText() == retypeEmail.GetText();
            if (s === retypeEmail && mail.GetIsValid())
                e.isValid = valid;
        }
        function OnSubmitButtonClick() {
            if (lastValidationResult)
                alert('Thank you!');
        }
        function OnValidationComplete(s, e) {
            lastValidationResult = e.isValid;
        }
    </script>
    <%--end highlighted block--%>
</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" runat="Server">
    <dx:ASPxGlobalEvents runat="server" ClientSideEvents-ValidationCompleted="OnValidationComplete" />
    <div class="container">
        <dx:ASPxFormLayout runat="server" AlignItemCaptions="false" RequiredMarkDisplayMode="All" Width="100%" ShowItemCaptionColon="false" EncodeHtml="false">
            <Items>
                <dx:LayoutItem Caption="<b>Contact me through:</b>" CaptionSettings-Location="Top">
                    <ParentContainerStyle Paddings-Padding="0" />
                    <CaptionCellStyle Paddings-PaddingLeft="5" />
                    <LayoutItemNestedControlCollection>
                        <dx:LayoutItemNestedControlContainer>
                            <dx:ASPxRadioButtonList runat="server" ID="radioButtonList" ClientSideEvents-SelectedIndexChanged="OnContactMethodChanged" CssClass="radioButtonList"
                                Border-BorderWidth="0" ClientSideEvents-Init="UpdateRadioButtonListDecoration" SelectedIndex="0" ClientInstanceName="radioButtonList" Width="100%">
                               <ValidationSettings ErrorDisplayMode="Text" SetFocusOnError="true" Display="Dynamic">
                                    <RequiredField IsRequired="true" />
                                </ValidationSettings>
                                <Items>
                                    <dx:ListEditItem Text="Email" Value="0" />
                                    <dx:ListEditItem Text="Phone" Value="1" />
                                    <dx:ListEditItem Text="SMS" Value="2" />
                                    <dx:ListEditItem Text="Instant Messenger" Value="3" />
                                    <dx:ListEditItem Text="Postal Service" Value="4" />
                                </Items>
                            </dx:ASPxRadioButtonList>
                        </dx:LayoutItemNestedControlContainer>
                    </LayoutItemNestedControlCollection>
                </dx:LayoutItem>
                <dx:TabbedLayoutGroup Caption="TabbedGroup" ClientInstanceName="tabbedGroupPageControl" ShowGroupDecoration="false" Width="100%">
                    <ParentContainerStyle CssClass="tabbedGroupPageControlCell" />
                    <ClientSideEvents Init="OnTabbedGroupPageControlInit" />
                    <Items>
                        <dx:LayoutGroup GroupBoxDecoration="None" SettingsItemCaptions-Location="Top">
                            <Items>
                                <dx:LayoutItem Caption="Email" RequiredMarkDisplayMode="Required">
                                     <LayoutItemNestedControlCollection>
                                        <dx:LayoutItemNestedControlContainer>
                                            <dx:ASPxTextBox ID="emailTextBox" runat="server" ClientSideEvents-Validation="OnEmailValidation" ClientInstanceName="mail" Width="170">
                                                 <ValidationSettings ErrorDisplayMode="Text" SetFocusOnError="true">
                                                    <RegularExpression ErrorText="Invalid e-mail" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" />
                                                    <RequiredField IsRequired="True" ErrorText="The value is required" />
                                                </ValidationSettings>
                                            </dx:ASPxTextBox>
                                         </dx:LayoutItemNestedControlContainer>
                                    </LayoutItemNestedControlCollection>
                                </dx:LayoutItem>
                                <dx:LayoutItem Caption="Retype Email" RequiredMarkDisplayMode="Required" HelpText="Please, retype email address to exclude a mistake">
                                    <HelpTextSettings Position="Bottom" />
                                    <LayoutItemNestedControlCollection>
                                        <dx:LayoutItemNestedControlContainer>
                                            <dx:ASPxTextBox ID="retypeEmailTextBox" runat="server" ClientInstanceName="retypeEmail" ClientSideEvents-Validation="OnEmailValidation" Width="170">
                                                <ValidationSettings ErrorText="Emails do not match" ErrorDisplayMode="Text" SetFocusOnError="true" />
                                            </dx:ASPxTextBox>
                                        </dx:LayoutItemNestedControlContainer>
                                    </LayoutItemNestedControlCollection>
                                </dx:LayoutItem>
                            </Items>
                        </dx:LayoutGroup>
                        <dx:LayoutGroup GroupBoxDecoration="None" SettingsItemCaptions-Location="Top" ColCount="2">
                            <Items>
                                <dx:LayoutItem Caption="Phone Number" RequiredMarkDisplayMode="Required" HelpText="Example: (920) 321-6789." HelpTextSettings-Position="Bottom">
                                    <LayoutItemNestedControlCollection>
                                        <dx:LayoutItemNestedControlContainer>
                                             <dx:ASPxTextBox ID="phoneTextBox" runat="server" Width="130">
                                                <MaskSettings Mask="(999) 000-0000" IncludeLiterals="None" ErrorText="*" />
                                                <ValidationSettings ErrorDisplayMode="Text" Display="Dynamic" SetFocusOnError="true"/>
                                            </dx:ASPxTextBox> 
                                        </dx:LayoutItemNestedControlContainer>
                                    </LayoutItemNestedControlCollection>
                                </dx:LayoutItem>
                                <dx:LayoutItem Caption="Extension" VerticalAlign="Top">
                                    <ParentContainerStyle CssClass="parentContainer" />
                                    <LayoutItemNestedControlCollection>
                                        <dx:LayoutItemNestedControlContainer>
                                            <dx:ASPxTextBox ID="extensionTextBox" runat="server" Width="40" />
                                        </dx:LayoutItemNestedControlContainer>
                                    </LayoutItemNestedControlCollection>
                                </dx:LayoutItem>
                                <dx:LayoutItem ShowCaption="False" ColSpan="2" RequiredMarkDisplayMode="Hidden">
                                     <ParentContainerStyle Paddings-PaddingTop="10" />
                                     <LayoutItemNestedControlCollection>
                                        <dx:LayoutItemNestedControlContainer>
                                            <dx:ASPxLabel runat="server" Text="Best Time to Call" />
                                        </dx:LayoutItemNestedControlContainer>
                                    </LayoutItemNestedControlCollection>
                                </dx:LayoutItem>
                                <dx:LayoutItem Caption="From:" CaptionSettings-Location="Left" RequiredMarkDisplayMode="Hidden">
                                    <LayoutItemNestedControlCollection>
                                        <dx:LayoutItemNestedControlContainer>
                                            <dx:ASPxTimeEdit ID="fromTimeEdit" runat="server" Width="110" />
                                         </dx:LayoutItemNestedControlContainer>
                                    </LayoutItemNestedControlCollection>
                                </dx:LayoutItem>
                                <dx:LayoutItem Caption="To:" CaptionSettings-Location="Left" RequiredMarkDisplayMode="Hidden">
                                    <LayoutItemNestedControlCollection>
                                        <dx:LayoutItemNestedControlContainer>
                                            <dx:ASPxTimeEdit ID="toTimeEdit" runat="server" Width="110" />
                                        </dx:LayoutItemNestedControlContainer>
                                    </LayoutItemNestedControlCollection>
                                </dx:LayoutItem>
                            </Items>
                        </dx:LayoutGroup>
                        <dx:LayoutGroup GroupBoxDecoration="None" SettingsItemCaptions-Location="Top">
                            <Items>
                                <dx:LayoutItem Caption="Mobile Service Provider">
                                    <LayoutItemNestedControlCollection>
                                        <dx:LayoutItemNestedControlContainer>
                                            <dx:ASPxComboBox ID="providerComboBox" runat="server">
                                                <Items>
                                                    <dx:ListEditItem Text="Verizon Wireless" Value="0" />
                                                    <dx:ListEditItem Text="Sprint" Value="1" />
                                                    <dx:ListEditItem Text="AT&T" Value="2" />
                                                    <dx:ListEditItem Text="T-Mobile" Value="3" />
                                                </Items>
                                                <ValidationSettings ErrorDisplayMode="Text" SetFocusOnError="true">
                                                    <RequiredField IsRequired="true" />
                                                </ValidationSettings>
                                            </dx:ASPxComboBox>
                                         </dx:LayoutItemNestedControlContainer>
                                    </LayoutItemNestedControlCollection>
                                </dx:LayoutItem>
                                <dx:LayoutItem Caption="Phone Number" RequiredMarkDisplayMode="Required" HelpText="Example: (920) 321-6789." HelpTextSettings-Position="Bottom">
                                     <LayoutItemNestedControlCollection>
                                        <dx:LayoutItemNestedControlContainer>
                                             <dx:ASPxTextBox ID="phoneNumberTextBox" runat="server" Width="130">
                                                <MaskSettings Mask="(999) 000-0000" IncludeLiterals="None" ErrorText="*" />
                                                <ValidationSettings ErrorDisplayMode="Text" Display="Dynamic" SetFocusOnError="true" />
                                            </dx:ASPxTextBox> 
                                        </dx:LayoutItemNestedControlContainer>
                                    </LayoutItemNestedControlCollection>
                                </dx:LayoutItem>
                            </Items>
                        </dx:LayoutGroup>
                        <dx:LayoutGroup GroupBoxDecoration="None" SettingsItemCaptions-Location="Top">
                            <Items>
                                <dx:LayoutItem Caption="Instant Messenger service">
                                    <LayoutItemNestedControlCollection>
                                        <dx:LayoutItemNestedControlContainer>
                                            <dx:ASPxComboBox ID="messengerServiceComboBox" runat="server">
                                                <Items>
                                                    <dx:ListEditItem Text="MSN" Value="1" />
                                                    <dx:ListEditItem Text="Skype" Value="2" />
                                                    <dx:ListEditItem Text="Jabber" Value="3" />
                                                    <dx:ListEditItem Text="ICQ" Value="4" />
                                                </Items>
                                                 <ValidationSettings ErrorDisplayMode="Text" SetFocusOnError="true">
                                                    <RequiredField IsRequired="true" />
                                                </ValidationSettings>
                                            </dx:ASPxComboBox>
                                        </dx:LayoutItemNestedControlContainer>
                                    </LayoutItemNestedControlCollection>
                                </dx:LayoutItem>
                                <dx:LayoutItem Caption="Messenger ID" HelpText="Please enter your messenger identificator">
                                    <HelpTextSettings Position="Bottom" />
                                     <LayoutItemNestedControlCollection>
                                        <dx:LayoutItemNestedControlContainer>
                                            <dx:ASPxTextBox ID="messengerIDTextBox" runat="server" Width="100%">
                                                 <ValidationSettings ErrorDisplayMode="Text" SetFocusOnError="true">
                                                    <RequiredField IsRequired="true" />
                                                </ValidationSettings>
                                            </dx:ASPxTextBox> 
                                        </dx:LayoutItemNestedControlContainer>
                                    </LayoutItemNestedControlCollection>
                                </dx:LayoutItem>
                            </Items>
                        </dx:LayoutGroup>
                        <dx:LayoutGroup GroupBoxDecoration="None" SettingsItemCaptions-Location="Top" ColCount="2">
                            <Items>
                                <dx:LayoutItem Caption="Address" ColSpan="2">
                                     <LayoutItemNestedControlCollection>
                                        <dx:LayoutItemNestedControlContainer>
                                            <dx:ASPxTextBox ID="addressTextBox" runat="server" Width="100%">
                                                <ValidationSettings ErrorDisplayMode="Text" ErrorText="*" SetFocusOnError="true">
                                                    <RequiredField IsRequired="true" />
                                                </ValidationSettings>
                                            </dx:ASPxTextBox>
                                         </dx:LayoutItemNestedControlContainer>
                                    </LayoutItemNestedControlCollection>
                                </dx:LayoutItem>                                
                                <dx:LayoutItem Caption="City" ColSpan="2">
                                    <LayoutItemNestedControlCollection>
                                        <dx:LayoutItemNestedControlContainer>
                                            <dx:ASPxTextBox ID="cityTextBox" runat="server" Width="100%">
                                                <ValidationSettings ErrorDisplayMode="Text" ErrorText="*" SetFocusOnError="true">
                                                    <RequiredField IsRequired="true" />
                                                </ValidationSettings>
                                            </dx:ASPxTextBox>
                                       </dx:LayoutItemNestedControlContainer>
                                    </LayoutItemNestedControlCollection>
                                </dx:LayoutItem>
                                <dx:LayoutItem Caption="Post Code">
                                    <LayoutItemNestedControlCollection>
                                        <dx:LayoutItemNestedControlContainer>
                                            <dx:ASPxSpinEdit ID="postCodeSpinEdit" runat="server" Width="100" MaxLength="9"> 
                                                <ValidationSettings ErrorDisplayMode="Text" ErrorText="*" SetFocusOnError="true">
                                                    <RequiredField IsRequired="true" />
                                                </ValidationSettings>
                                                <SpinButtons ShowIncrementButtons="false" />
                                            </dx:ASPxSpinEdit>
                                         </dx:LayoutItemNestedControlContainer>
                                    </LayoutItemNestedControlCollection>
                                </dx:LayoutItem>
                                <dx:LayoutItem Caption="Country">
                                    <ParentContainerStyle CssClass="parentContainer" />
                                    <LayoutItemNestedControlCollection>
                                        <dx:LayoutItemNestedControlContainer>
                                            <dx:ASPxComboBox ID="countrySpinEdit" runat="server" DropDownStyle="DropDownList" IncrementalFilteringMode="StartsWith"
                                                DataSourceID="CountriesDataSource" TextField="CountryName" ValueField="CountryName">
                                                <ValidationSettings ErrorDisplayMode="Text" ErrorText="*" SetFocusOnError="true">
                                                    <RequiredField IsRequired="true" />
                                                </ValidationSettings>
                                            </dx:ASPxComboBox>
                                        </dx:LayoutItemNestedControlContainer>
                                    </LayoutItemNestedControlCollection>
                                </dx:LayoutItem>
                            </Items>
                        </dx:LayoutGroup>
                    </Items>
                </dx:TabbedLayoutGroup>
                <dx:LayoutItem ShowCaption="False" HorizontalAlign="Right" RequiredMarkDisplayMode="Hidden">
                    <ParentContainerStyle Paddings-PaddingTop="5" Paddings-PaddingRight="0" />
                    <LayoutItemNestedControlCollection>
                        <dx:LayoutItemNestedControlContainer>
                            <dx:ASPxButton runat="server" ID="submitButton" Text="Submit" ValidateInvisibleEditors="false" Width="70"
                                ClientSideEvents-Click="OnSubmitButtonClick" />
                        </dx:LayoutItemNestedControlContainer>
                    </LayoutItemNestedControlCollection>
                </dx:LayoutItem>
            </Items>
        </dx:ASPxFormLayout>
    </div>
    <ef:EntityDataSource ID="CountriesDataSource" runat="server" ContextTypeName="WorldCitiesContext" EntitySetName="Countries" OrderBy="it.CountryName" />
</asp:Content>
