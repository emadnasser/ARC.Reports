<%@ Page Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="StateIndicatorGauge.aspx.cs" Inherits="StateIndicatorGaugePage" %>
<asp:Content runat="server" ContentPlaceHolderID="CustomHeadHolder">
    <%--start highlighted block--%>
    <script type="text/javascript">
        function Gauge1Changed() { OnChanged("Gauge1"); }
        function Gauge2Changed() { OnChanged("Gauge2"); }
        function Gauge3Changed() { OnChanged("Gauge3"); }
        function Gauge4Changed() { OnChanged("Gauge4"); }
        function Gauge5Changed() { OnChanged("Gauge5"); }
        function Gauge6Changed() { OnChanged("Gauge6"); }
        function Gauge1EndCallback() { OnEndCallback('Gauge1'); }
        function Gauge2EndCallback() { OnEndCallback('Gauge2'); }
        function Gauge3EndCallback() { OnEndCallback('Gauge3'); }
        function Gauge4EndCallback() { OnEndCallback('Gauge4'); }
        function Gauge5EndCallback() { OnEndCallback('Gauge5'); }
        function Gauge6EndCallback() { OnEndCallback('Gauge6'); }
        //
        var isDirty;
        function PerformCallbackCore(gaugeName) {
            var gauge = window[gaugeName];
            isDirty = gauge.InCallback();
            if (!isDirty)
                gauge.PerformCallback();
        }
        function OnChanged(gaugeName) {
            PerformCallbackCore(gaugeName);
        }
        function OnEndCallback(gaugeName) {
            if (isDirty)
                window.setTimeout(function() { PerformCallbackCore(gaugeName) }, 0);
        }
    </script>
    <%--end highlighted block--%>
</asp:Content>
<asp:Content ID="Content1" runat="server" ContentPlaceHolderID="ContentHolder">
    <dx:ASPxPageControl ID="ASPxPageControl1" runat="server" ActiveTabIndex="0" Width="100%">
        <TabPages>
            <dx:TabPage Text="Arrows">
                <ContentCollection>
                    <dx:ContentControl runat="server">
                        <dx:ASPxGaugeControl runat="server" Width="350px" Height="350px" BackColor="Transparent" ID="gControl_Page1" ClientInstanceName="Gauge1"
                            SaveStateOnCallbacks="false" OnCustomCallback="OnGauge1CustomCallback">
                            <ClientSideEvents EndCallback="Gauge1EndCallback" />
                            <Gauges>
                                <dx:StateIndicatorGauge Bounds="0, 0, 350, 350" ID="sGauge1">
                                    <indicators>
                                                    <dx:StateIndicatorComponent ID="indicator1" Center="124, 124" Name="stateIndicatorComponent1" StateIndex="0">
                                                        <States>
                                                            <dx:IndicatorStateWeb Name="State1" ShapeType="Arrow1" />
                                                            <dx:IndicatorStateWeb Name="State2" ShapeType="Arrow2" />
                                                            <dx:IndicatorStateWeb Name="State3" ShapeType="Arrow3" />
                                                            <dx:IndicatorStateWeb Name="State4" ShapeType="Arrow4" />
                                                            <dx:IndicatorStateWeb Name="State5" ShapeType="Arrow5" />
                                                            <dx:IndicatorStateWeb Name="State6" ShapeType="Arrow6" />
                                                            <dx:IndicatorStateWeb Name="State7" ShapeType="Arrow7" />
                                                            <dx:IndicatorStateWeb Name="State8" ShapeType="Arrow8" />
                                                            <dx:IndicatorStateWeb Name="State9" ShapeType="Arrow9" />
                                                            <dx:IndicatorStateWeb Name="State10" ShapeType="Arrow10" />
                                                        </States>
                                                    </dx:StateIndicatorComponent>
                                                </indicators>
                                </dx:StateIndicatorGauge>
                            </Gauges>
                        </dx:ASPxGaugeControl>
                        <dx:ASPxRoundPanel runat="server" ID="ASPxRoundPanel_1" ShowHeader="false" style="float: right">
                            <PanelCollection>
                                <dx:PanelContent runat="server">
                                    <table class="OptionsTable">
                                        <tr>
                                            <td>
                                                State Index:
                                            </td>
                                            <td>
                                                <dx:ASPxSpinEdit ID="state1" runat="server" MaxValue="9" MinValue="0" Number="0" Width="100px" NumberType="Integer" AllowNull="False">
                                                    <ClientSideEvents NumberChanged="Gauge1Changed" />
                                                </dx:ASPxSpinEdit>
                                            </td>
                                        </tr>
                                    </table>
                                </dx:PanelContent>
                            </PanelCollection>
                        </dx:ASPxRoundPanel>
                    </dx:ContentControl>
                </ContentCollection>
            </dx:TabPage>
            <dx:TabPage Text="Currency Symbols">
                <ContentCollection>
                    <dx:ContentControl runat="server">
                        <dx:ASPxGaugeControl runat="server" Width="350px" Height="350px" BackColor="Transparent" ID="gControl_Page2" ClientInstanceName="Gauge2"
                            SaveStateOnCallbacks="false" OnCustomCallback="OnGauge2CustomCallback">
                            <ClientSideEvents EndCallback="Gauge2EndCallback" />
                            <Gauges>
                                <dx:StateIndicatorGauge Bounds="0, 0, 350, 350" ID="sGauge2">
                                    <indicators>
                                                    <dx:StateIndicatorComponent ID="indicator2" Center="124, 124" Name="stateIndicatorComponent2" StateIndex="0">
                                                        <States>
                                                            <dx:IndicatorStateWeb Name="USD" ShapeType="CurrencyUSD" />
                                                            <dx:IndicatorStateWeb Name="Cent" ShapeType="CurrencyCent" />
                                                            <dx:IndicatorStateWeb Name="EUR" ShapeType="CurrencyEUR" />
                                                            <dx:IndicatorStateWeb Name="UAH" ShapeType="CurrencyUAH" />
                                                            <dx:IndicatorStateWeb Name="GBP" ShapeType="CurrencyGBP" />
                                                            <dx:IndicatorStateWeb Name="JPY" ShapeType="CurrencyJPY" />
                                                            <dx:IndicatorStateWeb Name="ITL" ShapeType="CurrencyITL" />
                                                            <dx:IndicatorStateWeb Name="ESP" ShapeType="CurrencyESP" />
                                                            <dx:IndicatorStateWeb Name="FRF" ShapeType="CurrencyFRF" />
                                                            <dx:IndicatorStateWeb Name="NLG" ShapeType="CurrencyNLG" />
                                                            <dx:IndicatorStateWeb Name="INR" ShapeType="CurrencyINR" />
                                                            <dx:IndicatorStateWeb Name="BRR" ShapeType="CurrencyBRR" />
                                                            <dx:IndicatorStateWeb Name="ILS" ShapeType="CurrencyILS" />
                                                            <dx:IndicatorStateWeb Name="MNT" ShapeType="CurrencyMNT" />
                                                            <dx:IndicatorStateWeb Name="KRW" ShapeType="CurrencyKRW" />
                                                            <dx:IndicatorStateWeb Name="CRC" ShapeType="CurrencyCRC" />
                                                            <dx:IndicatorStateWeb Name="NGN" ShapeType="CurrencyNGN" />
                                                            <dx:IndicatorStateWeb Name="LAK" ShapeType="CurrencyLAK" />
                                                            <dx:IndicatorStateWeb Name="RUR" ShapeType="CurrencyRUR" />
                                                            <dx:IndicatorStateWeb Name="General" ShapeType="Currency" />
                                                        </States>
                                                    </dx:StateIndicatorComponent>
                                                </indicators>
                                </dx:StateIndicatorGauge>
                            </Gauges>
                        </dx:ASPxGaugeControl>
                        <dx:ASPxRoundPanel runat="server" ID="ASPxRoundPanel2" ShowHeader="false" style="float: right">
                            <PanelCollection>
                                <dx:PanelContent runat="server">
                                    <table class="OptionsTable">
                                        <tr>
                                            <td>
                                                State Index:
                                            </td>
                                            <td>
                                                <dx:ASPxSpinEdit ID="state2" runat="server" MaxValue="19" MinValue="0" Number="0" Width="100px" NumberType="Integer" AllowNull="False">
                                                    <ClientSideEvents NumberChanged="Gauge2Changed" />
                                                </dx:ASPxSpinEdit>
                                            </td>
                                        </tr>
                                    </table>
                                </dx:PanelContent>
                            </PanelCollection>
                        </dx:ASPxRoundPanel>
                    </dx:ContentControl>
                </ContentCollection>
            </dx:TabPage>
            <dx:TabPage Text="Flags">
                <ContentCollection>
                    <dx:ContentControl runat="server">
                        <dx:ASPxGaugeControl runat="server" Width="350px" Height="350px" BackColor="Transparent" ID="gControl_Page3" ClientInstanceName="Gauge3"
                            SaveStateOnCallbacks="false" OnCustomCallback="OnGauge3CustomCallback">
                            <ClientSideEvents EndCallback="Gauge3EndCallback" />
                            <Gauges>
                                <dx:StateIndicatorGauge Bounds="0, 0, 350, 350" ID="sGauge3">
                                    <indicators>
                                                    <dx:StateIndicatorComponent ID="indicator3" Center="124, 124" Name="stateIndicatorComponent3" StateIndex="0"
                                                        Size="250,130">
                                                        <States>
                                                            <dx:IndicatorStateWeb Name="USA" ShapeType="FlagUSA" />
                                                            <dx:IndicatorStateWeb Name="China" ShapeType="FlagChina" />
                                                            <dx:IndicatorStateWeb Name="Japan" ShapeType="FlagJapan" />
                                                            <dx:IndicatorStateWeb Name="India" ShapeType="FlagIndia" />
                                                            <dx:IndicatorStateWeb Name="Germany" ShapeType="FlagGermany" />
                                                            <dx:IndicatorStateWeb Name="UK" ShapeType="FlagUK" />
                                                            <dx:IndicatorStateWeb Name="Russia" ShapeType="FlagRussia" />
                                                            <dx:IndicatorStateWeb Name="France" ShapeType="FlagFrance" />
                                                            <dx:IndicatorStateWeb Name="Brazil" ShapeType="FlagBrazil" />
                                                            <dx:IndicatorStateWeb Name="Italy" ShapeType="FlagItaly" />
                                                            <dx:IndicatorStateWeb Name="Spain" ShapeType="FlagSpain" />
                                                            <dx:IndicatorStateWeb Name="Canada" ShapeType="FlagCanada" />
                                                            <dx:IndicatorStateWeb Name="SouthKorea" ShapeType="FlagSouthKorea" />
                                                            <dx:IndicatorStateWeb Name="Iran" ShapeType="FlagIran" />
                                                            <dx:IndicatorStateWeb Name="Indonesia" ShapeType="FlagIndonesia" />
                                                            <dx:IndicatorStateWeb Name="Australia" ShapeType="FlagAustralia" />
                                                            <dx:IndicatorStateWeb Name="Taiwan" ShapeType="FlagTaiwan" />
                                                            <dx:IndicatorStateWeb Name="Turkey" ShapeType="FlagTurkey" />
                                                            <dx:IndicatorStateWeb Name="Netherlands" ShapeType="FlagNetherlands" />
                                                        </States>
                                                    </dx:StateIndicatorComponent>
                                                </indicators>
                                </dx:StateIndicatorGauge>
                            </Gauges>
                        </dx:ASPxGaugeControl>
                        <dx:ASPxRoundPanel runat="server" ID="ASPxRoundPanel3" ShowHeader="false" style="float: right">
                            <PanelCollection>
                                <dx:PanelContent runat="server">
                                    <table class="OptionsTable">
                                        <tr>
                                            <td>
                                                State Index:
                                            </td>
                                            <td>
                                                <dx:ASPxSpinEdit ID="state3" runat="server" MaxValue="18" MinValue="0" Number="0" Width="100px" NumberType="Integer" AllowNull="False">
                                                    <ClientSideEvents NumberChanged="Gauge3Changed" />
                                                </dx:ASPxSpinEdit>
                                            </td>
                                        </tr>
                                    </table>
                                </dx:PanelContent>
                            </PanelCollection>
                        </dx:ASPxRoundPanel>
                    </dx:ContentControl>
                </ContentCollection>
            </dx:TabPage>
            <dx:TabPage Text="Smiles">
                <ContentCollection>
                    <dx:ContentControl runat="server">
                        <dx:ASPxGaugeControl runat="server" Width="350px" Height="350px" BackColor="Transparent" ID="gControl_Page4" ClientInstanceName="Gauge4"
                            SaveStateOnCallbacks="false" OnCustomCallback="OnGauge4CustomCallback">
                            <ClientSideEvents EndCallback="Gauge4EndCallback" />
                            <Gauges>
                                <dx:StateIndicatorGauge Bounds="0, 0, 350, 350" ID="sGauge4">
                                    <indicators>
                                                    <dx:StateIndicatorComponent ID="indicator4" Center="124, 124" Name="stateIndicatorComponent4" StateIndex="0">
                                                        <States>
                                                            <dx:IndicatorStateWeb Name="State1" ShapeType="Smile1" />
                                                            <dx:IndicatorStateWeb Name="State2" ShapeType="Smile2" />
                                                            <dx:IndicatorStateWeb Name="State3" ShapeType="Smile3" />
                                                            <dx:IndicatorStateWeb Name="State4" ShapeType="Smile4" />
                                                            <dx:IndicatorStateWeb Name="State5" ShapeType="Smile5" />
                                                        </States>
                                                    </dx:StateIndicatorComponent>
                                                </indicators>
                                </dx:StateIndicatorGauge>
                            </Gauges>
                        </dx:ASPxGaugeControl>
                        <dx:ASPxRoundPanel runat="server" ID="ASPxRoundPanel4" ShowHeader="false" style="float: right">
                            <PanelCollection>
                                <dx:PanelContent runat="server">
                                    <table class="OptionsTable">
                                        <tr>
                                            <td>
                                                State Index:
                                            </td>
                                            <td>
                                                <dx:ASPxSpinEdit ID="state4" runat="server" MaxValue="4" MinValue="0" Number="0" Width="100px" NumberType="Integer" AllowNull="False">
                                                    <ClientSideEvents NumberChanged="Gauge4Changed" />
                                                </dx:ASPxSpinEdit>
                                            </td>
                                        </tr>
                                    </table>
                                </dx:PanelContent>
                            </PanelCollection>
                        </dx:ASPxRoundPanel>
                    </dx:ContentControl>
                </ContentCollection>
            </dx:TabPage>
            <dx:TabPage Text="Traffic Lights">
                <ContentCollection>
                    <dx:ContentControl runat="server">
                        <dx:ASPxGaugeControl runat="server" Width="350px" Height="350px" BackColor="Transparent" ID="gControl_Page5" ClientInstanceName="Gauge5"
                            SaveStateOnCallbacks="false" OnCustomCallback="OnGauge5CustomCallback">
                            <ClientSideEvents EndCallback="Gauge5EndCallback" />
                            <Gauges>
                                <dx:StateIndicatorGauge Bounds="0, 0, 350, 350" ID="sGauge5">
                                    <indicators>
                                                    <dx:StateIndicatorComponent ID="indicator5" Center="124, 124" Name="stateIndicatorComponent5" StateIndex="0"
                                                        Size="100,200">
                                                        <States>
                                                            <dx:IndicatorStateWeb Name="State1" ShapeType="TrafficLight1" />
                                                            <dx:IndicatorStateWeb Name="State2" ShapeType="TrafficLight2" />
                                                            <dx:IndicatorStateWeb Name="State3" ShapeType="TrafficLight3" />
                                                            <dx:IndicatorStateWeb Name="State4" ShapeType="TrafficLight4" />
                                                        </States>
                                                    </dx:StateIndicatorComponent>
                                                </indicators>
                                </dx:StateIndicatorGauge>
                            </Gauges>
                        </dx:ASPxGaugeControl>
                        <dx:ASPxRoundPanel runat="server" ID="ASPxRoundPanel5" ShowHeader="false" style="float: right">
                            <PanelCollection>
                                <dx:PanelContent runat="server">
                                    <table class="OptionsTable">
                                        <tr>
                                            <td>
                                                State Index:
                                            </td>
                                            <td>
                                                <dx:ASPxSpinEdit ID="state5" runat="server" MaxValue="3" MinValue="0" Number="0" Width="100px" NumberType="Integer" AllowNull="False">
                                                    <ClientSideEvents NumberChanged="Gauge5Changed" />
                                                </dx:ASPxSpinEdit>
                                            </td>
                                        </tr>
                                    </table>
                                </dx:PanelContent>
                            </PanelCollection>
                        </dx:ASPxRoundPanel>
                    </dx:ContentControl>
                </ContentCollection>
            </dx:TabPage>
            <dx:TabPage Text="Electric Lights">
                <ContentCollection>
                    <dx:ContentControl runat="server">
                        <dx:ASPxGaugeControl runat="server" Width="350px" Height="350px" BackColor="Transparent" ID="gControl_Page6" ClientInstanceName="Gauge6"
                            SaveStateOnCallbacks="false" OnCustomCallback="OnGauge6CustomCallback">
                            <ClientSideEvents EndCallback="Gauge6EndCallback" />
                            <Gauges>
                                <dx:StateIndicatorGauge Bounds="0, 0, 350, 350" ID="sGauge6">
                                    <indicators>
                                                    <dx:StateIndicatorComponent ID="indicator6" Center="124, 124" Name="stateIndicatorComponent6" StateIndex="0">
                                                        <States>
                                                            <dx:IndicatorStateWeb Name="State1" ShapeType="ElectricLight1" />
                                                            <dx:IndicatorStateWeb Name="State2" ShapeType="ElectricLight2" />
                                                            <dx:IndicatorStateWeb Name="State3" ShapeType="ElectricLight3" />
                                                            <dx:IndicatorStateWeb Name="State4" ShapeType="ElectricLight4" />
                                                        </States>
                                                    </dx:StateIndicatorComponent>
                                                </indicators>
                                </dx:StateIndicatorGauge>
                            </Gauges>
                        </dx:ASPxGaugeControl>
                        <dx:ASPxRoundPanel runat="server" ID="ASPxRoundPanel6" ShowHeader="false" style="float: right">
                            <PanelCollection>
                                <dx:PanelContent runat="server">
                                    <table class="OptionsTable">
                                        <tr>
                                            <td>
                                                State Index:
                                            </td>
                                            <td>
                                                <dx:ASPxSpinEdit ID="state6" runat="server" MaxValue="3" MinValue="0" Number="0" Width="100px" NumberType="Integer" AllowNull="False">
                                                    <ClientSideEvents NumberChanged="Gauge6Changed" />
                                                </dx:ASPxSpinEdit>
                                            </td>
                                        </tr>
                                    </table>
                                </dx:PanelContent>
                            </PanelCollection>
                        </dx:ASPxRoundPanel>
                    </dx:ContentControl>
                </ContentCollection>
            </dx:TabPage>
        </TabPages>
    </dx:ASPxPageControl>
</asp:Content>
