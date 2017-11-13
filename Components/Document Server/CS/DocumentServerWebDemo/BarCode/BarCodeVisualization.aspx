<%@ Page Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="BarCodeVisualization.aspx.cs" Inherits="BarCode_BarCodeVisualization" %>
<asp:Content ID="localCss" ContentPlaceHolderID="CustomHeadHolder" runat="server">
    <style type="text/css">
        #mainDiv
        {
            float: left;
            width: 600px;
        }
        .dxrpControl
        {
            margin-bottom: 2px;
        }
        .propertyEditors
        {
            float: right;
            margin-bottom: 2px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" runat="server">
    <script type="text/javascript">
    // <![CDATA[
        function UpdateImage() {
            var cbBarCodeValue = ComboBoxBarCode.GetValue();
            var txtBarCodeTextValue = txtBarCodeText.GetValue();
            var chkViewTextValue = chkViewText.GetChecked();
            var cbTextVertAlignValue = cbTextVertAlign.GetValue();
            var cbTextHorzAlignValue = cbTextHorzAlign.GetValue();
            var cbFontNameValue = cbFontName.GetValue();
            var spnBarCodeAngleValue = spnBarCodeAngle.GetValue();
            var clrBarCodeForeColorValue = clrBarCodeForeColor.GetValue();
            var clrBarCodeBackColorValue = clrBarCodeBackColor.GetValue();
            var chkTopCaptionValue = chkTopCaption.GetChecked();
            var txtTopCaptionTextValue = txtTopCaptionText.GetValue();
            var cbTopCaptionAlignmentValue = cbTopCaptionAlignment.GetValue();
            var clrTopCaptionForeColorValue = clrTopCaptionForeColor.GetValue();
            var cbTopCaptionFontNameValue = cbTopCaptionFontName.GetValue();
            var chkBottomCaptionValue = chkBottomCaption.GetChecked();
            var txtBottomCaptionTextValue = txtBottomCaptionText.GetValue();
            var cbBottomCaptionAlignmentValue = cbBottomCaptionAlignment.GetValue();
            var clrBottomCaptionForeColorValue = clrBottomCaptionForeColor.GetValue();
            var cbBottomCaptionFontNameValue = cbBottomCaptionFontName.GetValue();
            var image = document.getElementById("ContentHolder_imgBarCode");
            image.src = "BarCodeVisualization.aspx?image" +
                                                    "&cbBarCode=" + encodeURIComponent(cbBarCodeValue) +
                                                    "&txtBarCodeText=" + encodeURIComponent(txtBarCodeTextValue) +
                                                    "&chkViewText=" + encodeURIComponent(chkViewTextValue) +
                                                    "&cbTextVertAlign=" + encodeURIComponent(cbTextVertAlignValue) +
                                                    "&cbTextHorzAlign=" + encodeURIComponent(cbTextHorzAlignValue) +
                                                    "&cbFontName=" + encodeURIComponent(cbFontNameValue) +
                                                    "&spnBarCodeAngle=" + encodeURIComponent(spnBarCodeAngleValue) +
                                                    "&clrBarCodeForeColor=" + encodeURIComponent(clrBarCodeForeColorValue) +
                                                    "&clrBarCodeBackColor=" + encodeURIComponent(clrBarCodeBackColorValue) +
                                                    "&chkTopCaption=" + encodeURIComponent(chkTopCaptionValue) +
                                                    "&txtTopCaptionText=" + encodeURIComponent(txtTopCaptionTextValue) +
                                                    "&cbTopCaptionAlignment=" + encodeURIComponent(cbTopCaptionAlignmentValue) +
                                                    "&clrTopCaptionForeColor=" + encodeURIComponent(clrTopCaptionForeColorValue) +
                                                    "&cbTopCaptionFontName=" + encodeURIComponent(cbTopCaptionFontNameValue) +
                                                    "&chkBottomCaption=" + encodeURIComponent(chkBottomCaptionValue) +
                                                    "&txtBottomCaptionText=" + encodeURIComponent(txtBottomCaptionTextValue) +
                                                    "&cbBottomCaptionAlignment=" + encodeURIComponent(cbBottomCaptionAlignmentValue) +
                                                    "&clrBottomCaptionForeColor=" + encodeURIComponent(clrBottomCaptionForeColorValue) +
                                                    "&cbBottomCaptionFontName=" + encodeURIComponent(cbBottomCaptionFontNameValue);
        }
        function UpdateDescription() {
            var cbBarCodeValue = ComboBoxBarCode.GetValue();
            var description = document.getElementById("descriptionFrame");
            description.src = "BarCodeVisualization.aspx?description" +
                                                    "&cbBarCode=" + encodeURIComponent(cbBarCodeValue);
        }
    // ]]> 
    </script>
    <div id="mainDiv">
        <dx:ASPxComboBox ID="ComboBoxBarCode" ClientInstanceName="ComboBoxBarCode" runat="server" ValueType="System.String" Width="600px" Height="25px">
            <ClientSideEvents ValueChanged="function(s, e) { UpdateImage(); UpdateDescription(); }" />
        </dx:ASPxComboBox>
        <br />
        <dx:ASPxImage ID="imgBarCode" ClientInstanceName="imgBarCode" runat="server" AlternateText="No image data"
            ImageUrl="~/BarCode/BarCodeVisualization.aspx?image">
        </dx:ASPxImage>
        <br /><br />
        <iframe id="descriptionFrame" src="BarCodeVisualization.aspx?description" style="width: 100%; margin: 0; border: none;overflow:hidden;">Text</iframe>
    </div>
    <div style="float:right;width:270px;">
    <dx:ASPxRoundPanel ID="ASPxRoundPanel1" runat="server" Width="100%" HeaderText="BarCode Properties">
        <PanelCollection>
            <dx:PanelContent ID="Panelcontent1" runat="server">
                <dx:ASPxCheckBox ID="chkViewText" ClientInstanceName="chkViewText" runat="server" Text="Show Text">
                    <ClientSideEvents ValueChanged="function(s, e) { UpdateImage(); }" />
                </dx:ASPxCheckBox>
                <table style="width: 100%;">
                    <tr>
                        <td>Text:</td>
                        <td class="propertyEditors">
                            <dx:ASPxTextBox ID="txtBarCodeText" ClientInstanceName="txtBarCodeText" runat="server" Width="170px">
                                <ClientSideEvents ValueChanged="function(s, e) { UpdateImage(); }" />
                            </dx:ASPxTextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>Vert Align:</td>
                        <td class="propertyEditors">
                            <dx:ASPxComboBox ID="cbTextVertAlign" ClientInstanceName="cbTextVertAlign" runat="server" ValueType="System.String" SelectedIndex="1">
                                <Items>
                                    <dx:ListEditItem Text="Near" Value="Near"></dx:ListEditItem>
                                    <dx:ListEditItem Text="Center" Value="Center"></dx:ListEditItem>
                                    <dx:ListEditItem Text="Far" Value="Far"></dx:ListEditItem>
                                </Items>
                                <ClientSideEvents ValueChanged="function(s, e) { UpdateImage(); }" />
                            </dx:ASPxComboBox>
                        </td>
                    </tr>
                    <tr>
                        <td>Horz Align:</td>
                        <td class="propertyEditors">
                            <dx:ASPxComboBox ID="cbTextHorzAlign" ClientInstanceName="cbTextHorzAlign" runat="server" ValueType="System.String" SelectedIndex="1">
                                <Items>
                                    <dx:ListEditItem Text="Near" Value="Near"></dx:ListEditItem>
                                    <dx:ListEditItem Text="Center" Value="Center"></dx:ListEditItem>
                                    <dx:ListEditItem Text="Far" Value="Far"></dx:ListEditItem>
                                </Items>
                                <ClientSideEvents ValueChanged="function(s, e) { UpdateImage(); }" />
                            </dx:ASPxComboBox>
                        </td>
                    </tr>
                    <tr>
                        <td>Font Name:</td>
                        <td class="propertyEditors">
                            <dx:ASPxComboBox ID="cbFontName" ClientInstanceName="cbFontName" runat="server" ValueType="System.String">
                                <ClientSideEvents ValueChanged="function(s, e) { UpdateImage(); }" />
                            </dx:ASPxComboBox>
                        </td>
                    </tr>
                    <tr>
                        <td>Angle:</td>
                        <td class="propertyEditors">
                            <dx:ASPxSpinEdit ID="spnBarCodeAngle" ClientInstanceName="spnBarCodeAngle" runat="server" Height="21px" Number="0">
                                <ClientSideEvents ValueChanged="function(s, e) { UpdateImage(); }" />
                            </dx:ASPxSpinEdit>
                        </td>
                    </tr>
                    <tr>
                        <td>Fore Color:</td>
                        <td class="propertyEditors">
                            <dx:ASPxColorEdit ID="clrBarCodeForeColor" ClientInstanceName="clrBarCodeForeColor" runat="server">
                                <ClientSideEvents ValueChanged="function(s, e) { UpdateImage(); }" />
                            </dx:ASPxColorEdit>
                        </td>
                    </tr>
                    <tr>
                        <td>Back Color:</td>
                        <td class="propertyEditors">
                            <dx:ASPxColorEdit ID="clrBarCodeBackColor" ClientInstanceName="clrBarCodeBackColor" runat="server">
                                <ClientSideEvents ValueChanged="function(s, e) { UpdateImage(); }" />
                            </dx:ASPxColorEdit>
                        </td>
                    </tr>
                </table>
            </dx:PanelContent>
        </PanelCollection>
    </dx:ASPxRoundPanel>
    <dx:ASPxRoundPanel ID="ASPxRoundPanel2" runat="server" Width="100%" HeaderText="Top caption">
        <PanelCollection>
            <dx:PanelContent ID="Panelcontent2" runat="server">
                <dx:ASPxCheckBox ID="chkTopCaption" ClientInstanceName="chkTopCaption" runat="server" Text="Show Text">
                    <ClientSideEvents ValueChanged="function(s, e) { UpdateImage(); }" />
                </dx:ASPxCheckBox>
                <table style="width: 100%;">
                    <tr>
                        <td>Text:</td>
                        <td class="propertyEditors">
                            <dx:ASPxTextBox ID="txtTopCaptionText" ClientInstanceName="txtTopCaptionText" runat="server" Width="170px" Text="top caption">
                                <ClientSideEvents ValueChanged="function(s, e) { UpdateImage(); }" />
                            </dx:ASPxTextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>Alignment:</td>
                        <td class="propertyEditors">
                            <dx:ASPxComboBox ID="cbTopCaptionAlignment" ClientInstanceName="cbTopCaptionAlignment" runat="server" ValueType="System.String" SelectedIndex="1">
                                <Items>
                                    <dx:ListEditItem Text="Near" Value="Near"></dx:ListEditItem>
                                    <dx:ListEditItem Text="Center" Value="Center"></dx:ListEditItem>
                                    <dx:ListEditItem Text="Far" Value="Far"></dx:ListEditItem>
                                </Items>
                                <ClientSideEvents ValueChanged="function(s, e) { UpdateImage(); }" />
                            </dx:ASPxComboBox>
                        </td>
                    </tr>
                    <tr>
                        <td>Fore Color:</td>
                        <td class="propertyEditors">
                            <dx:ASPxColorEdit ID="clrTopCaptionForeColor" ClientInstanceName="clrTopCaptionForeColor" runat="server">
                                <ClientSideEvents ValueChanged="function(s, e) { UpdateImage(); }" />
                            </dx:ASPxColorEdit>
                        </td>
                    </tr>
                    <tr>
                        <td>Font Name:</td>
                        <td class="propertyEditors">
                            <dx:ASPxComboBox ID="cbTopCaptionFontName" ClientInstanceName="cbTopCaptionFontName" runat="server" ValueType="System.String">
                                <ClientSideEvents ValueChanged="function(s, e) { UpdateImage(); }" />
                            </dx:ASPxComboBox>
                        </td>
                    </tr>
                </table>
            </dx:PanelContent>
        </PanelCollection>
    </dx:ASPxRoundPanel>
    <dx:ASPxRoundPanel ID="ASPxRoundPanel3" runat="server" Width="100%" HeaderText="Bottom caption">
        <PanelCollection>
            <dx:PanelContent ID="Panelcontent3" runat="server">
                <dx:ASPxCheckBox ID="chkBottomCaption" ClientInstanceName="chkBottomCaption" runat="server" Text="Show Text">
                    <ClientSideEvents ValueChanged="function(s, e) { UpdateImage(); }" />
                </dx:ASPxCheckBox>
                <table style="width: 100%;">
                    <tr>
                        <td>Text:</td>
                        <td class="propertyEditors">
                            <dx:ASPxTextBox ID="txtBottomCaptionText" ClientInstanceName="txtBottomCaptionText" runat="server" Width="170px" Text="bottom caption">
                                <ClientSideEvents ValueChanged="function(s, e) { UpdateImage(); }" />
                            </dx:ASPxTextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>Alignment:</td>
                        <td class="propertyEditors">
                            <dx:ASPxComboBox ID="cbBottomCaptionAlignment" ClientInstanceName="cbBottomCaptionAlignment" runat="server" ValueType="System.String" SelectedIndex="1">
                                <Items>
                                    <dx:ListEditItem Text="Near" Value="Near"></dx:ListEditItem>
                                    <dx:ListEditItem Text="Center" Value="Center"></dx:ListEditItem>
                                    <dx:ListEditItem Text="Far" Value="Far"></dx:ListEditItem>
                                </Items>
                                <ClientSideEvents ValueChanged="function(s, e) { UpdateImage(); }" />
                            </dx:ASPxComboBox>
                        </td>
                    </tr>
                    <tr>
                        <td>Fore Color:</td>
                        <td class="propertyEditors">
                            <dx:ASPxColorEdit ID="clrBottomCaptionForeColor" ClientInstanceName="clrBottomCaptionForeColor" runat="server">
                                <ClientSideEvents ValueChanged="function(s, e) { UpdateImage(); }" />
                            </dx:ASPxColorEdit>
                        </td>
                    </tr>
                    <tr>
                        <td>Font Name:</td>
                        <td class="propertyEditors">
                            <dx:ASPxComboBox ID="cbBottomCaptionFontName" ClientInstanceName="cbBottomCaptionFontName" runat="server" ValueType="System.String">
                                <ClientSideEvents ValueChanged="function(s, e) { UpdateImage(); }" />
                            </dx:ASPxComboBox>
                        </td>
                    </tr>
                </table>
            </dx:PanelContent>
        </PanelCollection>
    </dx:ASPxRoundPanel>
    </div>
</asp:Content>
