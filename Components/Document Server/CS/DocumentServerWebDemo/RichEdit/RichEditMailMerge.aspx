<%@ Page Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="RichEditMailMerge.aspx.cs"
    Inherits="RichEdit_MailMerge" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" runat="server">
    <script type="text/javascript">
        // <![CDATA[
        function OnEmployeeChanged(cmbEmployee) {
            cbCustomer.PerformCallback(cmbEmployee.GetValue().toString());
        }
        function OnEmployeeInit(cmbEmployee) {
            cbEmployee.PerformCallback("init");
        }
        function UpdatePreview() {
            var cmbEmployeeValue = cbEmployee.GetValue();
            var cmbCustomerValue = cbCustomer.GetValue();
            var previewFrame = document.getElementById("previewFrame");
            previewFrame.src = "RichEditMailMerge.aspx?preview" +
                                                     "&employee=" + encodeURIComponent(cmbEmployeeValue) +
                                                     "&customer=" + encodeURIComponent(cmbCustomerValue);
        }
        // ]]> 
    </script>
    <dx:ASPxRoundPanel ID="ASPxRoundPanel1" runat="server" Width="100%" HeaderText="Demo Options">
        <PanelCollection>
            <dx:PanelContent ID="PanelContent1" runat="server">
                <table style="height: 40px; float: left;">
                    <tr>
                        <td style="height: 26px;">
                            <dx:ASPxLabel ID="lblEmployee" runat="server" Text="Employee: " AssociatedControlID="cbEmployee">
                            </dx:ASPxLabel>
                        </td>
                        <td>
                            <dx:ASPxComboBox ID="cbEmployee" ClientInstanceName="cbEmployee" runat="server" ValueType="System.Int32"
                                OnCallback="cbEmployee_Callback" Width="215px">
                                <ClientSideEvents SelectedIndexChanged="function(s, e) { OnEmployeeChanged(s); }"
                                    Init="function(s, e) { OnEmployeeInit(s); }" />
                            </dx:ASPxComboBox>
                        </td>
                    </tr>
                    <tr>
                        <td style="height: 26px;">
                            <dx:ASPxLabel ID="lblCustomer" runat="server" Text="Customer: " AssociatedControlID="cbCustomer">
                            </dx:ASPxLabel>
                        </td>
                        <td>
                            <dx:ASPxComboBox ID="cbCustomer" ClientInstanceName="cbCustomer" runat="server" ValueType="System.String"
                                OnCallback="cbCustomer_Callback" Width="215px">
                                <ClientSideEvents ValueChanged="function(s, e) { UpdatePreview(); }" />
                            </dx:ASPxComboBox>
                        </td>
                    </tr>
                    <tr>
                        <td style="height: 26px;">
                            <dx:ASPxLabel ID="lblDownloadType" runat="server" Text="File&nbsp;Type: " AssociatedControlID="cbDownloadType"
                                Style="margin-right: 7px;">
                            </dx:ASPxLabel>
                        </td>
                        <td>
                            <dx:ASPxComboBox ID="cbDownloadType" runat="server" ValueType="System.Int32" SelectedIndex="0"
                                ClientInstanceName="cbDownloadType" Width="215px" Style="margin-right: 9px;">
                                <Items>
                                    <dx:ListEditItem Text="Rich Text Format (*.rtf)" Value="1" />
                                    <dx:ListEditItem Text="Microsoft Word Document (*.doc)" Value="2" />
                                    <dx:ListEditItem Text="Word 2007 Document (*.docx)" Value="3" />
                                    <dx:ListEditItem Text="Portable Document Format (*.pdf)" Value="4" />
                                    <dx:ListEditItem Text="Text Files (*.txt)" Value="5" />
                                    <dx:ListEditItem Text="Web Archive, single file (*.mht)" Value="6" />
                                    <dx:ListEditItem Text="OpenDocument Text Document (*.odt)" Value="7" />
                                    <dx:ListEditItem Text="Word XML Document (*.xml)" Value="8" />
                                    <dx:ListEditItem Text="Electronic Publication (*.epub)" Value="9" />
                                </Items>
                            </dx:ASPxComboBox>
                        </td>
                        <td>
                            <dx:ASPxButton ID="btnDownload" runat="server" Text="Download" OnClick="btnDownload_Click" />
                        </td>
                    </tr>
                </table>
            </dx:PanelContent>
        </PanelCollection>
    </dx:ASPxRoundPanel>
    <br />
    <iframe id="previewFrame" src="RichEditMailMerge.aspx?preview"
        style="width: 100%;height: 400px;border: 2px solid rgb(224, 224, 224);"></iframe>
</asp:Content>
