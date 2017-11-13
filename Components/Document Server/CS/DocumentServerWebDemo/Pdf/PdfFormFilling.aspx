<%@ Page Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="PdfFormFilling.aspx.cs"
    Inherits="PdfFormFilling" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" runat="Server">
    <dx:ASPxCallbackPanel ID="callbackPanel" ClientInstanceName="callbackPanel"
        runat="server" OnCallback="OnCallback">
        <PanelCollection>
            <dx:PanelContent runat="server">
                <table>
                    <tr>
                        <td style="border:solid; border-width:thin">
                           <img runat="server" alt="Page" ID="pageImage" style="vertical-align:middle;width:622px" />
                        </td>
                        <td style="vertical-align:top;padding-left:30px">
                            <dx:ASPxRoundPanel ID="roundPanel1" runat="server" ShowHeader="true" HeaderText="Demo options"
                                Width="100%">
                                <PanelCollection>
                                    <dx:PanelContent>
                                        <table class="OptionsTable">
                                            <tr>
                                                <td style="padding-right:30px;padding-left:30px"> <dx:ASPxLabel ID="lblFirstName" runat="server" Text="First name:" Wrap="False"/> </td>
                                                <td> <dx:ASPxTextBox ID="tbFirstName" runat="server" Text="Janet" Width="100%" /> </td>
                                            </tr>
                                            <tr>
                                                <td style="padding-right:30px;padding-left:30px"> <dx:ASPxLabel ID="lblLastName" runat="server" Text="Last name:" Wrap="False"/> </td>
                                                <td> <dx:ASPxTextBox ID="tbLastName" runat="server" Text="Leverling" Width="100%" /> </td>
                                            </tr>
                                            <tr>
                                                <td style="padding-right:30px;padding-left:30px;padding-top:19px"> <dx:ASPxLabel ID="lblGender" runat="server" Text="Gender:" /> </td>
                                                <td style="padding-top:19px"> 
                                                    <dx:ASPxRadioButton ID="rbMale" runat="server" GroupName="Gender" Text="Male" Width="100%" />
                                                </td>
                                            </tr>
                                            <tr>
                                                <td>
                                                   
                                                </td>
                                                <td>
                                                     <dx:ASPxRadioButton ID="rbFemale" runat="server" GroupName="Gender" Text="Female" Checked="true" Width="100%" />
                                                </td>
                                            </tr>
                                            <tr>
                                                <td  style="padding-right:30px;padding-left:30px;padding-top:19px"> <dx:ASPxLabel ID="lblDate" runat="server" Text="Date of Birth:" /> </td>
                                                <td style="padding-top:19px"> <dx:ASPxDateEdit ID="deDate" Date="08/30/1985" runat="server" Width="100%"></dx:ASPxDateEdit></td>
                                            </tr>
                                            <tr>
                                                <td style="padding-right:30px;padding-left:30px"> <dx:ASPxLabel ID="lblPassport" runat="server" Text="Passport No:" Wrap="False"/> </td>
                                                <td> <dx:ASPxTextBox ID="tePassport" runat="server" Text="31195855" Width="100%" /> </td>
                                            </tr>
                                            <tr>
                                                <td  style="padding-right:30px;padding-left:30px;padding-top:19px"> <dx:ASPxLabel ID="lblNationality" runat="server" Text="Nationality:" /> </td>
                                                <td style="padding-top:19px"> <dx:ASPxComboBox ID="cbeNationality" SelectedIndex="1" runat="server" Width="100%"/>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td style="padding-right:30px;padding-left:30px"> <dx:ASPxLabel ID="lblAddress" runat="server" Text="Address:" /> </td>
                                                <td> <dx:ASPxTextBox ID="tbAddress" runat="server" Width="100%" Text="98033, 722 Moss Bay Blvd., Kirkland, WA, USA"/> </td>
                                            </tr>     
                                            <tr>
                                                <td style="padding-right:30px;padding-left:30px"> <dx:ASPxLabel ID="lblVisa" runat="server" Text="Visa No:" /> </td>
                                                <td> <dx:ASPxTextBox ID="tbVisa" runat="server" Text="73203393" Width="100%" /> </td>
                                            </tr>
                                            <tr>
                                                <td style="padding-right:30px;padding-left:30px"> <dx:ASPxLabel ID="lblFlight" runat="server" Text="Flight No:" /> </td>
                                                <td> <dx:ASPxTextBox ID="tbFlight" runat="server" Text="(KL) KLM 876" Width="100%" /> </td>
                                            </tr>
                                            <tr>   
                                                <td></td>                                         
                                                <td style="padding-top:22px;padding-left:30px">
                                                    <dx:ASPxButton ID="btnFillForm" runat="server" Text="Submit" AutoPostBack="false" Height="25px" Width="100%">
                                                         <ClientSideEvents Click="function(s, e) { callbackPanel.PerformCallback(); }"/>
                                                    </dx:ASPxButton>
                                                </td>
                                            </tr>                               
                                        </table>                                    
                                    </dx:PanelContent>
                                </PanelCollection>
                            </dx:ASPxRoundPanel>
                        </td>
                    </tr>
                </table>
            </dx:PanelContent>
        </PanelCollection>
    </dx:ASPxCallbackPanel>
</asp:Content>
