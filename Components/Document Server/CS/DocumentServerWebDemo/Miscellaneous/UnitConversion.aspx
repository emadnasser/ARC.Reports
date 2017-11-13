<%@ Page Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="UnitConversion.aspx.cs"
    Inherits="Miscellaneous_UnitConversion" %>
<asp:Content ID="Content2" ContentPlaceHolderID="CustomHeadHolder" runat="server">
    <style type="text/css">
        .PropertyLayoutTable {
            margin-top: 20px;
        }
            .PropertyLayoutTable > tbody > tr > td {
                padding: 2px 8px 4px 0;
            }
        .alignedColumn {
            padding-left: 50px !important;
        }
    </style>
</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" runat="server">
    <script type="text/javascript">
        function OnEndCallback(s, e) {
            var data = s.Get('data');
            for (var field in data)
                window[field].SetNumber(data[field]);
            if (ASPxClientEdit.GetFocusedEditor())
                ASPx.Selection.SetCaretPosition(ASPxClientEdit.GetFocusedEditor().GetInputElement(), 0);
        }
        function OnValueChanged(sender, name) {
            window.setTimeout(function () {
                hfCallback.PerformCallback(name);
            }, 0);
        }
    </script>
    <dx:ASPxHiddenField ID="hfCallback" runat="server" OnCustomCallback="hf_CustomCallback"
        ClientInstanceName="hfCallback">
        <ClientSideEvents EndCallback="OnEndCallback"></ClientSideEvents>
    </dx:ASPxHiddenField>
    <dx:ASPxPageControl ID="ASPxPageControl1" ClientInstanceName="ASPxPageControl1" runat="server"
        ActiveTabIndex="0" Width="100%" EnableViewState="False" EnableHierarchyRecreation="True"
        BorderRight-BorderWidth="0" BorderRight-BorderStyle="None">
        <ContentStyle>
            <Paddings PaddingTop="21px" PaddingRight="0px" PaddingBottom="1px"></Paddings>
        </ContentStyle>
        <TabPages>
            <dx:TabPage Name="TPMass" Text="Weight and Mass">
                <ContentCollection>
                    <dx:ContentControl ID="ContentControl1" runat="server">
                            <dx:PanelContent ID="PanelContent3" runat="server" >
                                <dx:ASPxLabel ID="ASPxLabel1" runat="server" Text="WEIGHT AND MASS" Font-Size="30px"/>
                                <table class="PropertyLayoutTable">
                                    <tr>
                                        <td>
                                            <dx:ASPxSpinEdit ID="seGramm" runat="server" Width="113" HorizontalAlign="Right" ClientInstanceName="seGramm">
                                                <ClientSideEvents NumberChanged="function(s,e ) {OnValueChanged(s, 'seGramm'); }"></ClientSideEvents>
                                            </dx:ASPxSpinEdit>
                                        </td>
                                        <td>
                                            <dx:ASPxLabel ID="ASPxLabel2" runat="server" Text="Gram"/>1
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <dx:ASPxSpinEdit ID="seKilogramm" runat="server" Width="113" HorizontalAlign="Right" ClientInstanceName="seKilogramm">
                                                <ClientSideEvents NumberChanged="function(s,e ) {OnValueChanged(s, 'seKilogramm'); }"></ClientSideEvents>
                                            </dx:ASPxSpinEdit>
                                        </td>
                                        <td>
                                            <dx:ASPxLabel ID="ASPxLabel3" runat="server" Text="Kilogram"/>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <dx:ASPxSpinEdit ID="sePoundMass" runat="server" Width="113" HorizontalAlign="Right" ClientInstanceName="sePoundMass">
                                                <ClientSideEvents NumberChanged="function(s,e ) {OnValueChanged(s, 'sePoundMass'); }"></ClientSideEvents>
                                            </dx:ASPxSpinEdit>
                                        </td>
                                        <td>
                                            <dx:ASPxLabel ID="ASPxLabel4" runat="server" Text="Pound mass"/>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <dx:ASPxSpinEdit ID="seOunceMass" runat="server" Width="113" HorizontalAlign="Right" ClientInstanceName="seOunceMass">
                                                <ClientSideEvents NumberChanged="function(s,e ) {OnValueChanged(s, 'seOunceMass'); }"></ClientSideEvents>
                                            </dx:ASPxSpinEdit>
                                        </td>
                                        <td>
                                            <dx:ASPxLabel ID="ASPxLabel5" runat="server" Text="Ounce mass"/>
                                        </td>
                                    </tr>
                                </table>
                            </dx:PanelContent>                                
                    </dx:ContentControl>
                </ContentCollection>
            </dx:TabPage>
            <dx:TabPage Name="TPDistanceAndSquare" Text="Distance and Square">
                <ContentCollection>
                    <dx:ContentControl ID="ContentControl2" runat="server">
                            <dx:PanelContent ID="PanelContent1" runat="server">
                                <dx:ASPxLabel ID="ASPxLabel6" runat="server" Text="DISTANCE AND SQUARE" Font-Size="30px"/>
                                <table class="PropertyLayoutTable">
                                    <tr>
                                        <td>
                                            <dx:ASPxSpinEdit ID="seKilometer" runat="server" Number="1" Width="113" HorizontalAlign="Right" TabIndex="1" ClientInstanceName="seKilometer">
                                                <ClientSideEvents NumberChanged="function(s,e ) {OnValueChanged(s, 'seKilometer'); }"></ClientSideEvents>
                                            </dx:ASPxSpinEdit>
                                        </td>
                                        <td>
                                            <dx:ASPxLabel ID="ASPxLabel7" runat="server" Text="Kilometer"/>
                                        </td>
                                        <td class="alignedColumn">
                                            <dx:ASPxSpinEdit ID="seMeter" runat="server" Number="1" Width="113" HorizontalAlign="Right" TabIndex="4" ClientInstanceName="seMeter">
                                                <ClientSideEvents NumberChanged="function(s,e ) {OnValueChanged(s, 'seMeter'); }"></ClientSideEvents>
                                            </dx:ASPxSpinEdit>
                                        </td>
                                        <td>
                                            <dx:ASPxLabel ID="ASPxLabel9" runat="server" Text="Meter"/>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <dx:ASPxSpinEdit ID="seStatuteMile" runat="server" Width="113" HorizontalAlign="Right" TabIndex="2" ClientInstanceName="seStatuteMile">
                                                <ClientSideEvents NumberChanged="function(s,e ) {OnValueChanged(s, 'seStatuteMile'); }"></ClientSideEvents>
                                            </dx:ASPxSpinEdit>
                                        </td>
                                        <td>
                                            <dx:ASPxLabel ID="ASPxLabel8" runat="server" Text="Statute mile"/>
                                        </td>
                                        <td class="alignedColumn">
                                            <dx:ASPxSpinEdit ID="seMeterToFoot" runat="server" Number="1" Width="113" HorizontalAlign="Right" TabIndex="5" ClientInstanceName="seMeterToFoot">
                                                <ClientSideEvents NumberChanged="function(s,e ) {OnValueChanged(s,'seMeterToFoot'); }"></ClientSideEvents>
                                            </dx:ASPxSpinEdit>
                                        </td>
                                        <td>
                                            <dx:ASPxLabel ID="ASPxLabel10" runat="server" Text="Foot"/>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <dx:ASPxSpinEdit ID="seNauticalMile" runat="server" Width="113" HorizontalAlign="Right" TabIndex="3" ClientInstanceName="seNauticalMile">
                                                <ClientSideEvents NumberChanged="function(s,e ) {OnValueChanged(s,'seNauticalMile'); }"></ClientSideEvents>
                                            </dx:ASPxSpinEdit>
                                        </td>
                                        <td>
                                            <dx:ASPxLabel ID="ASPxLabel11" runat="server" Text="Nautical mile"/>
                                        </td>
                                        <td class="alignedColumn">
                                            <dx:ASPxSpinEdit ID="seYard" runat="server" Number="1" Width="113" HorizontalAlign="Right" TabIndex="6" ClientInstanceName="seYard">
                                                <ClientSideEvents NumberChanged="function(s,e ) {OnValueChanged(s,'seYard'); }"></ClientSideEvents>
                                            </dx:ASPxSpinEdit>
                                        </td>
                                        <td>
                                            <dx:ASPxLabel ID="ASPxLabel12" runat="server" Text="Yard"/>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td colspan="4" style="height:40px"></td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <dx:ASPxSpinEdit ID="seCentimeter" runat="server" Number="1" Width="113" HorizontalAlign="Right" TabIndex="7" ClientInstanceName="seCentimeter">
                                                <ClientSideEvents NumberChanged="function(s,e ) {OnValueChanged(s,'seCentimeter'); }"></ClientSideEvents>
                                            </dx:ASPxSpinEdit>
                                        </td>
                                        <td>
                                            <dx:ASPxLabel ID="ASPxLabel13" runat="server" Text="Centimeter"/>
                                        </td>
                                        <td class="alignedColumn">
                                            <dx:ASPxSpinEdit ID="seSquareMeter" runat="server" Number="1" Width="113" HorizontalAlign="Right" TabIndex="10" ClientInstanceName="seSquareMeter">
                                                <ClientSideEvents NumberChanged="function(s,e ) {OnValueChanged(s,'seSquareMeter'); }"></ClientSideEvents>
                                            </dx:ASPxSpinEdit>
                                        </td>
                                        <td>
                                            <dx:ASPxLabel ID="ASPxLabel14" runat="server" Text="Square meter"/>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <dx:ASPxSpinEdit ID="seInch" runat="server" Width="113" HorizontalAlign="Right" TabIndex="8" ClientInstanceName="seInch">
                                                <ClientSideEvents NumberChanged="function(s,e ) {OnValueChanged(s,'seInch'); }"></ClientSideEvents>
                                            </dx:ASPxSpinEdit>
                                        </td>
                                        <td>
                                            <dx:ASPxLabel ID="ASPxLabel15" runat="server" Text="Inch"/>
                                        </td>
                                        <td class="alignedColumn">
                                            <dx:ASPxSpinEdit ID="seSquareFeet" runat="server" Number="1" Width="113" HorizontalAlign="Right" TabIndex="11" ClientInstanceName="seSquareFeet">
                                                <ClientSideEvents NumberChanged="function(s,e ) {OnValueChanged(s,'seSquareFeet'); }"></ClientSideEvents>
                                            </dx:ASPxSpinEdit>
                                        </td>
                                        <td>
                                            <dx:ASPxLabel ID="ASPxLabel16" runat="server" Text="Square feet"/>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <dx:ASPxSpinEdit ID="seCentimeterToFoot" runat="server" Width="113" HorizontalAlign="Right" TabIndex="9" ClientInstanceName="seCentimeterToFoot">
                                                <ClientSideEvents NumberChanged="function(s,e ) {OnValueChanged(s,'seCentimeterToFoot'); }"></ClientSideEvents>
                                            </dx:ASPxSpinEdit>
                                        </td>
                                        <td>
                                            <dx:ASPxLabel ID="ASPxLabel17" runat="server" Text="Foot"/>
                                        </td>
                                        <td>
                                        </td>
                                        <td>
                                        </td>
                                    </tr>
                                </table>
                            </dx:PanelContent>
                    </dx:ContentControl>
                </ContentCollection>
            </dx:TabPage>
            <dx:TabPage Name="TPTemperatureAndPressure" Text="Temperature and Pressure">
                <ContentCollection>
                    <dx:ContentControl ID="ContentControl3" runat="server">
                            <dx:PanelContent ID="PanelContent2" runat="server">
                                <dx:ASPxLabel ID="ASPxLabel18" runat="server" Text="TEMPERATURE AND PRESSURE" Font-Size="30px"/>
                                <table class="PropertyLayoutTable">
                                    <tr>
                                        <td>
                                            <dx:ASPxSpinEdit ID="seCelsius" runat="server" Number="1" Width="113" HorizontalAlign="Right" TabIndex="1" ClientInstanceName="seCelsius">
                                                <ClientSideEvents NumberChanged="function(s,e ) {OnValueChanged(s, 'seCelsius'); }"></ClientSideEvents>
                                            </dx:ASPxSpinEdit>
                                        </td>
                                        <td>
                                            <dx:ASPxLabel ID="ASPxLabel19" runat="server" Text="Celsius"/>
                                        </td>
                                        <td class="alignedColumn">
                                            <dx:ASPxSpinEdit ID="seKilopascal" runat="server" Number="1" Width="113" HorizontalAlign="Right" TabIndex="4" ClientInstanceName="seKilopascal">
                                                <ClientSideEvents NumberChanged="function(s,e ) {OnValueChanged(s, 'seKilopascal'); }"></ClientSideEvents>
                                            </dx:ASPxSpinEdit>
                                        </td>
                                        <td>
                                            <dx:ASPxLabel ID="ASPxLabel20" runat="server" Text="Kilopascal"/>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <dx:ASPxSpinEdit ID="seFahrenheit" runat="server" Width="113" HorizontalAlign="Right" TabIndex="2" ClientInstanceName="seFahrenheit">
                                                <ClientSideEvents NumberChanged="function(s,e ) {OnValueChanged(s, 'seFahrenheit'); }"></ClientSideEvents>
                                            </dx:ASPxSpinEdit>
                                        </td>
                                        <td>
                                            <dx:ASPxLabel ID="ASPxLabel21" runat="server" Text="Fahrenheit"/>
                                        </td>
                                        <td class="alignedColumn">
                                            <dx:ASPxSpinEdit ID="seAtmosphere" runat="server" Number="1" Width="113" HorizontalAlign="Right" TabIndex="5" ClientInstanceName="seAtmosphere">
                                                <ClientSideEvents NumberChanged="function(s,e ) {OnValueChanged(s, 'seAtmosphere'); }"></ClientSideEvents>
                                            </dx:ASPxSpinEdit>
                                        </td>
                                        <td>
                                            <dx:ASPxLabel ID="ASPxLabel22" runat="server" Text="Atmosphere"/>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <dx:ASPxSpinEdit ID="seKelvin" runat="server" Width="113" HorizontalAlign="Right" TabIndex="3" ClientInstanceName="seKelvin">
                                                <ClientSideEvents NumberChanged="function(s,e ) {OnValueChanged(s, 'seKelvin'); }"></ClientSideEvents>
                                            </dx:ASPxSpinEdit>
                                        </td>
                                        <td>
                                            <dx:ASPxLabel ID="ASPxLabel23" runat="server" Text="Kelvin"/>
                                        </td>
                                        <td class="alignedColumn">
                                            <dx:ASPxSpinEdit ID="seMmOfMercury" runat="server" Number="1" Width="113" HorizontalAlign="Right" TabIndex="6" ClientInstanceName="seMmOfMercury">
                                                <ClientSideEvents NumberChanged="function(s,e ) {OnValueChanged(s, 'seMmOfMercury'); }"></ClientSideEvents>
                                            </dx:ASPxSpinEdit>
                                        </td>
                                        <td>
                                            <dx:ASPxLabel ID="ASPxLabel24" runat="server" Text="mm of Mercury"/>
                                        </td>
                                    </tr>
                                </table>
                            </dx:PanelContent>
                    </dx:ContentControl>
                </ContentCollection>
            </dx:TabPage>
            <dx:TabPage Name="TPForceAndPower" Text="Force and Power">
                <ContentCollection>
                    <dx:ContentControl ID="ContentControl4" runat="server">
                            <dx:PanelContent ID="PanelContent4" runat="server">
                                <dx:ASPxLabel ID="ASPxLabel25" runat="server" Text="FORCE AND POWER" Font-Size="30px"/>
                                <table class="PropertyLayoutTable">
                                    <tr>
                                        <td>
                                            <dx:ASPxSpinEdit ID="seNewton" runat="server" Number="1" Width="113" HorizontalAlign="Right" TabIndex="1" ClientInstanceName="seNewton">
                                                <ClientSideEvents NumberChanged="function(s,e ) {OnValueChanged(s, 'seNewton'); }"></ClientSideEvents>
                                            </dx:ASPxSpinEdit>
                                        </td>
                                        <td>
                                            <dx:ASPxLabel ID="ASPxLabel26" runat="server" Text="Newton"/>
                                        </td>
                                        <td class="alignedColumn">
                                            <dx:ASPxSpinEdit ID="seHorsepower" runat="server" Number="1" Width="113" HorizontalAlign="Right" TabIndex="5" ClientInstanceName="seHorsepower">
                                                <ClientSideEvents NumberChanged="function(s,e ) {OnValueChanged(s, 'seHorsepower'); }"></ClientSideEvents>
                                            </dx:ASPxSpinEdit>
                                        </td>
                                        <td>
                                            <dx:ASPxLabel ID="ASPxLabel27" runat="server" Text="Horsepower"/>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <dx:ASPxSpinEdit ID="seDyne" runat="server" Width="113" HorizontalAlign="Right" TabIndex="2" ClientInstanceName="seDyne">
                                                <ClientSideEvents NumberChanged="function(s,e ) {OnValueChanged(s, 'seDyne'); }"></ClientSideEvents>
                                            </dx:ASPxSpinEdit>
                                        </td>
                                        <td>
                                            <dx:ASPxLabel ID="ASPxLabel28" runat="server" Text="Dyne"/>
                                        </td>
                                        <td class="alignedColumn">
                                            <dx:ASPxSpinEdit ID="seWatt" runat="server" Number="1" Width="113" HorizontalAlign="Right" TabIndex="6" ClientInstanceName="seWatt">
                                                <ClientSideEvents NumberChanged="function(s,e ) {OnValueChanged(s, 'seWatt'); }"></ClientSideEvents>
                                            </dx:ASPxSpinEdit>
                                        </td>
                                        <td>
                                            <dx:ASPxLabel ID="ASPxLabel29" runat="server" Text="Watt"/>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <dx:ASPxSpinEdit ID="sePoundForce" runat="server" Width="113" HorizontalAlign="Right" TabIndex="3" ClientInstanceName="sePoundForce">
                                                <ClientSideEvents NumberChanged="function(s,e ) {OnValueChanged(s, 'sePoundForce'); }"></ClientSideEvents>
                                            </dx:ASPxSpinEdit>
                                        </td>
                                        <td>
                                            <dx:ASPxLabel ID="ASPxLabel30" runat="server" Text="Pound force"/>
                                        </td>
                                        <td>
                                        </td>
                                        <td>
                                        </td>
                                    </tr>
                                </table>
                            </dx:PanelContent>
                    </dx:ContentControl>
                </ContentCollection>
            </dx:TabPage>
        </TabPages>
        <BorderRight BorderStyle="None" BorderWidth="0px"></BorderRight>
    </dx:ASPxPageControl>
</asp:Content>
