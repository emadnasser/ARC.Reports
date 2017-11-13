<%@ Page Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="MaskedInput.aspx.cs"
    Inherits="Features_MaskedInput" %>
<asp:Content runat="server" ContentPlaceHolderID="CustomHeadHolder">
    <%--start highlighted block--%>
    <script type="text/javascript">
        function phone_InitAndKeyUp(s,e) {
            document.getElementById("phoneValue").innerHTML=s.GetValue();
        }
        function price_InitAndKeyUp(s,e) {
            document.getElementById("priceValue").innerHTML=s.GetValue();
        }
    </script>
    <%--end highlighted block--%>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentHolder" runat="server">
    <table class="OptionsTable" style="margin-bottom: 16px;">
        <tr>
            <td style="width: 100px">
                Zip Code: &nbsp;
            </td>
            <td style="width: 240px">
                <dx:ASPxTextBox ID="txtZip" runat="server" Width="150">
                    <MaskSettings Mask="00000" ErrorText="Please input missing digits" />
                    <ValidationSettings ErrorDisplayMode="ImageWithTooltip" />
                </dx:ASPxTextBox>          
            </td>
            <td rowspan="2">
                <div>
                    Mask = 00000
                </div>
                <div class="TopPadding">
                   ErrorText = &quot;Please input missing digits&quot; 
                </div>
                <div class="TopPadding">
                    <table>
                        <tr>
                            <td>PromptChar =&nbsp;</td>
                            <td>
                                <dx:ASPxComboBox ID="cmbPromtChar" runat="server" AutoPostBack="true" Width="50"
                                    DropDownWidth="50" SelectedIndex="0">
                                    <Items>
                                        <dx:ListEditItem Value="_" />
                                        <dx:ListEditItem Value="#" />
                                    </Items>
                                </dx:ASPxComboBox>
                            </td>
                        </tr>
                    </table>            
                </div>
            </td>
        </tr>
        <tr>
            <td colspan="2" style="height: 40px">
            </td>
        </tr>
    </table>    
    <table class="OptionsTable" style="margin-bottom: 16px;">
        <tr>
            <td style="width: 100px">
                Phone Number: &nbsp;
            </td>
            <td style="width: 240px">
                <dx:ASPxTextBox ID="txtPhone" runat="server" Width="150" ClientInstanceName="clTxtPhone">
                    <MaskSettings Mask="+1 (999) 000-0000" IncludeLiterals="None" />
                    <ValidationSettings ErrorDisplayMode="ImageWithTooltip" />
                    <ClientSideEvents Init="phone_InitAndKeyUp" KeyUp="phone_InitAndKeyUp" />
                </dx:ASPxTextBox>     
            </td>
            <td rowspan="2">
                <div>
                    <div>
                        Mask = +1 (999) 000-0000
                    </div>
                    <div class="TopPadding">
                       IncludeLiterals = None
                    </div>
                    <div class="TopPadding">
                        Value = <span id="phoneValue"></span>
                    </div>
                </div>
            </td>
        </tr>
        <tr>
            <td colspan="2" style="height: 25px">
            </td>
        </tr>
    </table>    
    <table class="OptionsTable" style="margin-bottom: 16px;">
        <tr>
            <td style="width: 100px">
                Price: &nbsp;
            </td>
            <td style="width: 240px">
                <dx:ASPxTextBox ID="txtPrice" runat="server" Width="150">
                    <MaskSettings Mask="$<0..99999g>.<00..99>" IncludeLiterals="DecimalSymbol" />
                    <ValidationSettings ErrorDisplayMode="ImageWithTooltip" />
                    <ClientSideEvents Init="price_InitAndKeyUp" KeyUp="price_InitAndKeyUp" />
                </dx:ASPxTextBox>
            </td>
            <td rowspan="2">
                <div>
                    <div>
                        Mask = $&lt;0..99999g&gt;.&lt;00..99&gt;
                    </div>
                    <div class="TopPadding">
                       IncludeLiterals = DecimalSymbol
                    </div>
                    <div class="TopPadding">
                        Value = <span id="priceValue"></span>
                    </div>
                </div>
            </td>
        </tr>
        <tr>
            <td colspan="2" style="height: 25px">
            </td>
        </tr>
    </table>    
    <table class="OptionsTable" style="margin-bottom: 16px;">
        <tr>
            <td style="width: 100px">
                Date:&nbsp;
            </td>
            <td style="width: 240px">
                <dx:ASPxDateEdit ID="dateEdit" runat="server" Width="150" EditFormat="Custom" UseMaskBehavior="true" />
            </td>
            <td rowspan="2">
                <div>
                    <div>
                        UseMaskBehavior = True
                    </div>
                    <div class="TopPadding">
                        <table>
                            <tr>
                                <td>EditFormatString =&nbsp;</td>
                                <td>
                                    <dx:ASPxComboBox ID="cmbDateType" runat="server" Width="150" AutoPostBack="true"
                                        SelectedIndex="0">
                                        <Items>
                                            <dx:ListEditItem Value="MMMM dd, yyyy" />
                                            <dx:ListEditItem Value="MM/dd/yyyy hh:mm tt" />
                                        </Items>
                                    </dx:ASPxComboBox>
                                </td>
                            </tr>
                        </table>               
                    </div>
                </div>
            </td>
        </tr>
        <tr>
            <td colspan="2" style="height: 20px">
            </td>
        </tr>
    </table>    
    <table class="OptionsTable" style="margin-bottom: 16px;">
        <tr>
            <td style="width: 100px">
                Promo Code:&nbsp;
            </td>
            <td style="width: 240px">
                <dx:ASPxTextBox ID="txtPromoCode" runat="server" Width="150">
                    <MaskSettings ShowHints="true" Mask="<HOME|*BUSINESS>->aaaa-aaaa" />
                    <ValidationSettings ErrorDisplayMode="ImageWithTooltip" />
                </dx:ASPxTextBox>      
            </td>
            <td rowspan="2">
                <div>
                    <div>
                        Mask = &lt;HOME|*BUSINESS&gt;-&gt;aaaa-aaaa
                    </div>
                    <div class="TopPadding">
                       ShowHints = True
                    </div>
                </div>
            </td>
        </tr>
        <tr>
            <td colspan="2" style="height: 7px">
            </td>
        </tr>
    </table>    
    
</asp:Content>      
