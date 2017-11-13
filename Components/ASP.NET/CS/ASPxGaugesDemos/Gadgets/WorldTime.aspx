<%@ Page Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="WorldTime.aspx.cs"
    Inherits="Gadgets_WorldTime" %>
<asp:Content ID="Content1" runat="server" ContentPlaceHolderID="ContentHolder">
    <dx:ASPxCallbackPanel ID="ASPxCallbackPanel1" runat="server" ClientInstanceName="TimerCallbackPanel"
        Width="800px" OnCallback="OnTimerCallback" BackColor="White" Height="550px" SettingsLoadingPanel-Enabled="false">
        <PanelCollection>
            <dx:PanelContent runat="server">
                <table style="width: 100%">
                    <tr style="height: 275px">
                        <td style="width: 33%;">
                            <dx:ASPxGaugeControl runat="server" Width="250px" Height="250px" BackColor="White"
                                ID="Washington">
                                <Gauges>
                                    <dx:CircularGauge Bounds="0, 0, 250, 250" ID="gaugeUSA">
                                        <Indicators>
                                            <dx:ArcScaleStateIndicatorComponent Name="usaIndicator1" Center="75, 218" ScaleID="usaScale1"
                                                Size="40, 21" ZOrder="-100">
                                                <States>
                                                    <dx:ScaleIndicatorStateWeb Name="Default" IntervalLength="12" ShapeType="FlagUSA"></dx:ScaleIndicatorStateWeb>
                                                </States>
                                            </dx:ArcScaleStateIndicatorComponent>
                                            <dx:ArcScaleStateIndicatorComponent Name="usaIndicator2" Center="118, 223" Shader="&lt;ShaderObject Type=&quot;Style&quot; Data=&quot;Colors[Style1:White;Style2:]&quot;/&gt;"
                                                ScaleID="usaScale1" Size="20, 20" ZOrder="-100">
                                                <States>
                                                    <dx:ScaleIndicatorStateWeb Name="Default" IntervalLength="12" ShapeType="CurrencyUSD">
                                                    </dx:ScaleIndicatorStateWeb>
                                                </States>
                                            </dx:ArcScaleStateIndicatorComponent>
                                            <dx:ArcScaleStateIndicatorComponent Name="usaIndicator3" Center="195, 223" ScaleID="usaScale1"
                                                Size="15, 15" ZOrder="-100">
                                                <States>
                                                    <dx:ScaleIndicatorStateWeb Name="Default" IntervalLength="12" ShapeType="Arrow1"></dx:ScaleIndicatorStateWeb>
                                                </States>
                                            </dx:ArcScaleStateIndicatorComponent>
                                        </Indicators>
                                        <Scales>
                                            <dx:ArcScaleComponent Name="usaScale1" MaxValue="12" MinorTickmark-ShapeType="Circular_Style5_5"
                                                MinorTickmark-ShapeOffset="-1.5" Center="125, 110" EndAngle="270" MajorTickCount="13"
                                                MinorTickCount="4" MajorTickmark-TextOffset="-18" MajorTickmark-TextOrientation="LeftToRight"
                                                MajorTickmark-FormatString="{0:F0}" MajorTickmark-ShapeType="Circular_Style5_2"
                                                MajorTickmark-ShowFirst="False" MajorTickmark-ShapeOffset="-9.5" StartAngle="-90"
                                                RadiusX="74" RadiusY="74" AppearanceTickmarkText-Font="Tahoma, 10pt" AppearanceTickmarkText-TextBrush="&lt;BrushObject Type=&quot;Solid&quot; Data=&quot;Color:Black&quot;/&gt;">
                                                <Labels>
                                                    <dx:ScaleLabelWeb Name="Label0" Position="125, 135" Text="Washington" FormatString="{0}"
                                                        Size="70, 20" AppearanceText-Font="Tahoma, 8pt" AppearanceText-TextBrush="&lt;BrushObject Type=&quot;Solid&quot; Data=&quot;Color:Black&quot;/&gt;">
                                                    </dx:ScaleLabelWeb>
                                                    <dx:ScaleLabelWeb Name="Label1" Position="75, 238" AppearanceText-TextBrush="&lt;BrushObject Type=&quot;Solid&quot;  Data=&quot;Color:White&quot;/&gt;" Text="U.S.A." FormatString="{0}"
                                                        Size="50, 15"></dx:ScaleLabelWeb>
                                                    <dx:ScaleLabelWeb Name="Label2" Position="160, 225" AppearanceText-TextBrush="&lt;BrushObject Type=&quot;Solid&quot;  Data=&quot;Color:White&quot;/&gt;" Text="100" FormatString="{0:F2}"
                                                        Size="70, 20" AppearanceText-Font="Tahoma, 12pt"></dx:ScaleLabelWeb>
                                                </Labels>
                                            </dx:ArcScaleComponent>
                                            <dx:ArcScaleComponent Name="usaScale2" MaxValue="12" Value="3" Center="125, 110"
                                                EndAngle="270" MajorTickCount="2" MinorTickCount="0" MajorTickmark-ShowText="False"
                                                MajorTickmark-ShowTick="False" MajorTickmark-TextOrientation="LeftToRight" StartAngle="-90"
                                                RadiusX="74" RadiusY="74">
                                            </dx:ArcScaleComponent>
                                        </Scales>
                                        <EffectLayers>
                                            <dx:ArcScaleEffectLayerComponent Name="usaEffect" ScaleCenterPos="0.5, 1" ScaleID="usaScale1"
                                                Size="170, 85" ZOrder="-1000" ShapeType="CircularFull_Clock"></dx:ArcScaleEffectLayerComponent>
                                        </EffectLayers>
                                        <SpindleCaps>
                                            <dx:ArcScaleSpindleCapComponent Name="usaCap" ScaleID="usaScale1" Size="12, 12" ZOrder="-100"
                                                ShapeType="CircularFull_Clock"></dx:ArcScaleSpindleCapComponent>
                                        </SpindleCaps>
                                        <BackgroundLayers>
                                            <dx:ArcScaleBackgroundLayerComponent Name="usaBg" ScaleCenterPos="0.504, 0.436" ScaleID="usaScale1"
                                                Size="216, 250" ZOrder="1000" ShapeType="CircularFull_WorldTimeClock"></dx:ArcScaleBackgroundLayerComponent>
                                        </BackgroundLayers>
                                        <Needles>
                                            <dx:ArcScaleNeedleComponent EndOffset="10" ScaleID="usaScale1" Name="usaNeedle1"
                                                ZOrder="-50" ShapeType="CircularFull_ClockHour"></dx:ArcScaleNeedleComponent>
                                            <dx:ArcScaleNeedleComponent EndOffset="-5" ScaleID="usaScale2" Name="usaNeedle2"
                                                ZOrder="-51" ShapeType="CircularFull_ClockMinute"></dx:ArcScaleNeedleComponent>
                                        </Needles>
                                    </dx:CircularGauge>
                                </Gauges>
                            </dx:ASPxGaugeControl>
                        </td>
                        <td style="width: 33%;">
                            <dx:ASPxGaugeControl runat="server" Width="250px" Height="250px" BackColor="White"
                                ID="Paris">
                                <Gauges>
                                    <dx:CircularGauge ID="gaugeFrance" Bounds="0, 0, 250, 250">
                                        <BackgroundLayers>
                                            <dx:ArcScaleBackgroundLayerComponent Name="franceBg" ScaleCenterPos="0.504, 0.436"
                                                ScaleID="franceScale1" ShapeType="CircularFull_WorldTimeClock" Size="216, 250"
                                                ZOrder="1000" />
                                        </BackgroundLayers>
                                        <Indicators>
                                            <dx:ArcScaleStateIndicatorComponent Center="75, 218" Name="franceIndicator1" ScaleID="franceScale1"
                                                Size="40, 21" ZOrder="-100">
                                                <States>
                                                    <dx:ScaleIndicatorStateWeb IntervalLength="12" Name="Default" ShapeType="FlagFrance" />
                                                </States>
                                            </dx:ArcScaleStateIndicatorComponent>
                                            <dx:ArcScaleStateIndicatorComponent Center="118, 223" Name="franceIndicator2" ScaleID="franceScale1"
                                                Shader="&lt;ShaderObject Type=&quot;Gray&quot;/&gt;" Size="20, 20" ZOrder="-100">
                                                <States>
                                                    <dx:ScaleIndicatorStateWeb IntervalLength="12" Name="Default" ShapeType="CurrencyEUR" />
                                                </States>
                                            </dx:ArcScaleStateIndicatorComponent>
                                            <dx:ArcScaleStateIndicatorComponent Center="195, 223" Name="franceIndicator3" ScaleID="franceScale1"
                                                Size="15, 15" ZOrder="-100">
                                                <States>
                                                    <dx:ScaleIndicatorStateWeb IntervalLength="12" Name="Default" ShapeType="Arrow1" />
                                                </States>
                                            </dx:ArcScaleStateIndicatorComponent>
                                        </Indicators>
                                        <Needles>
                                            <dx:ArcScaleNeedleComponent EndOffset="10" Name="franceNeedle1" ScaleID="franceScale1"
                                                ShapeType="CircularFull_ClockHour" ZOrder="-50" />
                                            <dx:ArcScaleNeedleComponent EndOffset="-5" Name="franceNeedle2" ScaleID="franceScale2"
                                                ShapeType="CircularFull_ClockMinute" ZOrder="-51" />
                                        </Needles>
                                        <SpindleCaps>
                                            <dx:ArcScaleSpindleCapComponent Name="franceCap1" ScaleID="franceScale1" ShapeType="CircularFull_Clock"
                                                Size="12, 12" ZOrder="-100" />
                                        </SpindleCaps>
                                        <EffectLayers>
                                            <dx:ArcScaleEffectLayerComponent Name="francsEffect1" ScaleCenterPos="0.5, 1" ScaleID="franceScale1"
                                                Shader="&lt;ShaderObject Type=&quot;Opacity&quot; Data=&quot;Opacity[0.7]&quot;/&gt;"
                                                ShapeType="CircularFull_Clock" Size="170, 85" ZOrder="-1000" />
                                        </EffectLayers>
                                        <Scales>
                                            <dx:ArcScaleComponent AppearanceTickmarkText-Font="Tahoma, 10pt" AppearanceTickmarkText-TextBrush="&lt;BrushObject Type=&quot;Solid&quot; Data=&quot;Color:Black&quot;/&gt;"
                                                Center="125, 110" EndAngle="270" MajorTickCount="13" MajorTickmark-FormatString="{0:F0}"
                                                MajorTickmark-ShapeOffset="-9.5" MajorTickmark-ShapeType="Circular_Style5_2"
                                                MajorTickmark-ShowFirst="False" MajorTickmark-TextOffset="-18" MajorTickmark-TextOrientation="LeftToRight"
                                                MaxValue="12" MinorTickCount="4" MinorTickmark-ShapeOffset="-1.5" MinorTickmark-ShapeType="Circular_Style5_5"
                                                Name="franceScale1" RadiusX="74" RadiusY="74" StartAngle="-90">
                                                <Labels>
                                                    <dx:ScaleLabelWeb AppearanceText-Font="Tahoma, 8pt" AppearanceText-TextBrush="&lt;BrushObject Type=&quot;Solid&quot; Data=&quot;Color:Black&quot;/&gt;"
                                                        FormatString="{0}" Name="Label0" Position="125, 135" Size="70, 20" Text="Paris" />
                                                    <dx:ScaleLabelWeb AppearanceText-TextBrush="&lt;BrushObject Type=&quot;Solid&quot;  Data=&quot;Color:White&quot;/&gt;" FormatString="{0}" Name="Label1" Position="75, 238" Size="50, 15"
                                                        Text="France" />
                                                    <dx:ScaleLabelWeb AppearanceText-TextBrush="&lt;BrushObject Type=&quot;Solid&quot;  Data=&quot;Color:White&quot;/&gt;" AppearanceText-Font="Tahoma, 12pt" FormatString="{0:F4}" Name="Label2"
                                                        Position="160, 225" Size="70, 20" Text="72.87" />
                                                </Labels>
                                            </dx:ArcScaleComponent>
                                            <dx:ArcScaleComponent Center="125, 110" EndAngle="270" MajorTickCount="2" MajorTickmark-ShowText="False"
                                                MajorTickmark-ShowTick="False" MajorTickmark-TextOrientation="LeftToRight" MaxValue="12"
                                                MinorTickCount="0" Name="franceScale2" RadiusX="74" RadiusY="74" StartAngle="-90"
                                                Value="3">
                                            </dx:ArcScaleComponent>
                                        </Scales>
                                    </dx:CircularGauge>
                                </Gauges>
                            </dx:ASPxGaugeControl>
                        </td>
                        <td style="width: 33%;">
                            <dx:ASPxGaugeControl runat="server" Width="250px" Height="250px" BackColor="White"
                                ID="Moscow">
                                <Gauges>
                                    <dx:CircularGauge ID="russiaGauge" Bounds="0, 0, 250, 250">
                                        <BackgroundLayers>
                                            <dx:ArcScaleBackgroundLayerComponent Name="russiaBg1" ScaleCenterPos="0.504, 0.436"
                                                ScaleID="russiaScale1" ShapeType="CircularFull_WorldTimeClock" Size="216, 250"
                                                ZOrder="1000" />
                                        </BackgroundLayers>
                                        <Indicators>
                                            <dx:ArcScaleStateIndicatorComponent Center="75, 218" Name="russiaIndicator1" ScaleID="russiaScale1"
                                                Size="40, 21" ZOrder="-100">
                                                <States>
                                                    <dx:ScaleIndicatorStateWeb IntervalLength="12" Name="Default" ShapeType="FlagRussia" />
                                                </States>
                                            </dx:ArcScaleStateIndicatorComponent>
                                            <dx:ArcScaleStateIndicatorComponent Center="118, 223" Name="russiaIndicator2" ScaleID="russiaScale1"
                                                Shader="&lt;ShaderObject Type=&quot;Gray&quot;/&gt;" Size="20, 20" ZOrder="-100">
                                                <States>
                                                    <dx:ScaleIndicatorStateWeb IntervalLength="12" Name="Default" ShapeType="CurrencyRUR" />
                                                </States>
                                            </dx:ArcScaleStateIndicatorComponent>
                                            <dx:ArcScaleStateIndicatorComponent Center="205, 223" Name="russiaIndicator3" ScaleID="russiaScale1"
                                                Size="15, 15" ZOrder="-100">
                                                <States>
                                                    <dx:ScaleIndicatorStateWeb IntervalLength="12" Name="Default" ShapeType="Arrow2" />
                                                </States>
                                            </dx:ArcScaleStateIndicatorComponent>
                                        </Indicators>
                                        <Needles>
                                            <dx:ArcScaleNeedleComponent EndOffset="10" Name="russiaNeedle1" ScaleID="russiaScale1"
                                                ShapeType="CircularFull_ClockHour" ZOrder="-50" />
                                            <dx:ArcScaleNeedleComponent EndOffset="-5" Name="russiaNeedle2" ScaleID="russiaScale2"
                                                ShapeType="CircularFull_ClockMinute" ZOrder="-51" />
                                        </Needles>
                                        <SpindleCaps>
                                            <dx:ArcScaleSpindleCapComponent Name="russiaCap1" ScaleID="russiaScale1" ShapeType="CircularFull_Clock"
                                                Size="12, 12" ZOrder="-100" />
                                        </SpindleCaps>
                                        <EffectLayers>
                                            <dx:ArcScaleEffectLayerComponent Name="russiaEffect1" ScaleCenterPos="0.5, 1" ScaleID="russiaScale1"
                                                Shader="&lt;ShaderObject Type=&quot;Opacity&quot; Data=&quot;Opacity[0.7]&quot;/&gt;"
                                                ShapeType="CircularFull_Clock" Size="170, 85" ZOrder="-1000" />
                                        </EffectLayers>
                                        <Scales>
                                            <dx:ArcScaleComponent AppearanceTickmarkText-Font="Tahoma, 10pt" AppearanceTickmarkText-TextBrush="&lt;BrushObject Type=&quot;Solid&quot; Data=&quot;Color:Black&quot;/&gt;"
                                                Center="125, 110" EndAngle="270" MajorTickCount="13" MajorTickmark-FormatString="{0:F0}"
                                                MajorTickmark-ShapeOffset="-9.5" MajorTickmark-ShapeType="Circular_Style5_2"
                                                MajorTickmark-ShowFirst="False" MajorTickmark-TextOffset="-18" MajorTickmark-TextOrientation="LeftToRight"
                                                MaxValue="12" MinorTickCount="4" MinorTickmark-ShapeOffset="-1.5" MinorTickmark-ShapeType="Circular_Style5_5"
                                                Name="russiaScale1" RadiusX="74" RadiusY="74" StartAngle="-90">
                                                <Labels>
                                                    <dx:ScaleLabelWeb AppearanceText-Font="Tahoma, 8pt" AppearanceText-TextBrush="&lt;BrushObject Type=&quot;Solid&quot; Data=&quot;Color:Black&quot;/&gt;"
                                                        FormatString="{0}" Name="Label0" Position="125, 135" Size="70, 20" Text="Moscow" />
                                                    <dx:ScaleLabelWeb AppearanceText-TextBrush="&lt;BrushObject Type=&quot;Solid&quot;  Data=&quot;Color:White&quot;/&gt;" FormatString="{0}" Name="Label1" Position="75, 238" Size="50, 15"
                                                        Text="Russia" />
                                                    <dx:ScaleLabelWeb AppearanceText-TextBrush="&lt;BrushObject Type=&quot;Solid&quot;  Data=&quot;Color:White&quot;/&gt;" AppearanceText-Font="Tahoma, 12pt" FormatString="{0:F4}" Name="Label2"
                                                        Position="165, 225" Size="70, 20" Text="3066.4" />
                                                </Labels>
                                            </dx:ArcScaleComponent>
                                            <dx:ArcScaleComponent Center="125, 110" EndAngle="270" MajorTickCount="2" MajorTickmark-ShowText="False"
                                                MajorTickmark-ShowTick="False" MajorTickmark-TextOrientation="LeftToRight" MaxValue="12"
                                                MinorTickCount="0" Name="russiaScale2" RadiusX="74" RadiusY="74" StartAngle="-90"
                                                Value="3">
                                            </dx:ArcScaleComponent>
                                        </Scales>
                                    </dx:CircularGauge>
                                </Gauges>
                            </dx:ASPxGaugeControl>
                        </td>
                    </tr>
                    <tr style="height: 275px">
                        <td style="width: 33%;">
                            <dx:ASPxGaugeControl runat="server" Width="250px" Height="250px" BackColor="White"
                                ID="London">
                                <Gauges>
                                    <dx:CircularGauge ID="ukGauge" Bounds="0, 0, 250, 250">
                                        <BackgroundLayers>
                                            <dx:ArcScaleBackgroundLayerComponent Name="ukBg1" ScaleCenterPos="0.504, 0.436" ScaleID="ukScale1"
                                                ShapeType="CircularFull_WorldTimeClock" Size="216, 250" ZOrder="1000" />
                                        </BackgroundLayers>
                                        <Indicators>
                                            <dx:ArcScaleStateIndicatorComponent Center="75, 218" Name="ukIndicator1" ScaleID="ukScale1"
                                                Size="40, 21" ZOrder="-100">
                                                <States>
                                                    <dx:ScaleIndicatorStateWeb IntervalLength="12" Name="Default" ShapeType="FlagUK" />
                                                </States>
                                            </dx:ArcScaleStateIndicatorComponent>
                                            <dx:ArcScaleStateIndicatorComponent Center="130, 223" Name="ukIndicator2" ScaleID="ukScale1"
                                                Shader="&lt;ShaderObject Type=&quot;Gray&quot;/&gt;" Size="20, 20" ZOrder="-100">
                                                <States>
                                                    <dx:ScaleIndicatorStateWeb IntervalLength="12" Name="Default" ShapeType="CurrencyGBP" />
                                                </States>
                                            </dx:ArcScaleStateIndicatorComponent>
                                            <dx:ArcScaleStateIndicatorComponent Center="203, 223" Name="ukIndicator3" ScaleID="ukScale1"
                                                Size="15, 15" ZOrder="-100">
                                                <States>
                                                    <dx:ScaleIndicatorStateWeb IntervalLength="12" Name="Default" ShapeType="Arrow9" />
                                                </States>
                                            </dx:ArcScaleStateIndicatorComponent>
                                        </Indicators>
                                        <Needles>
                                            <dx:ArcScaleNeedleComponent EndOffset="10" Name="ukNeedle1" ScaleID="ukScale1" ShapeType="CircularFull_ClockHour"
                                                ZOrder="-50" />
                                            <dx:ArcScaleNeedleComponent EndOffset="-5" Name="ukNeedle2" ScaleID="ukScale2" ShapeType="CircularFull_ClockMinute"
                                                ZOrder="-51" />
                                        </Needles>
                                        <SpindleCaps>
                                            <dx:ArcScaleSpindleCapComponent Name="ukCap1" ScaleID="ukScale1" ShapeType="CircularFull_Clock"
                                                Size="12, 12" ZOrder="-100" />
                                        </SpindleCaps>
                                        <EffectLayers>
                                            <dx:ArcScaleEffectLayerComponent Name="ukEffect1" ScaleCenterPos="0.5, 1" ScaleID="ukScale1"
                                                Shader="&lt;ShaderObject Type=&quot;Opacity&quot; Data=&quot;Opacity[0.7]&quot;/&gt;"
                                                ShapeType="CircularFull_Clock" Size="170, 85" ZOrder="-1000" />
                                        </EffectLayers>
                                        <Scales>
                                            <dx:ArcScaleComponent AppearanceTickmarkText-Font="Tahoma, 10pt" AppearanceTickmarkText-TextBrush="&lt;BrushObject Type=&quot;Solid&quot; Data=&quot;Color:Black&quot;/&gt;"
                                                Center="125, 110" EndAngle="270" MajorTickCount="13" MajorTickmark-FormatString="{0:F0}"
                                                MajorTickmark-ShapeOffset="-9.5" MajorTickmark-ShapeType="Circular_Style5_2"
                                                MajorTickmark-ShowFirst="False" MajorTickmark-TextOffset="-18" MajorTickmark-TextOrientation="LeftToRight"
                                                MaxValue="12" MinorTickCount="4" MinorTickmark-ShapeOffset="-1.5" MinorTickmark-ShapeType="Circular_Style5_5"
                                                Name="ukScale1" RadiusX="74" RadiusY="74" StartAngle="-90">
                                                <Labels>
                                                    <dx:ScaleLabelWeb AppearanceText-Font="Tahoma, 8pt" AppearanceText-TextBrush="&lt;BrushObject Type=&quot;Solid&quot; Data=&quot;Color:Black&quot;/&gt;"
                                                        FormatString="{0}" Name="Label0" Position="125, 135" Size="70, 20" Text="London" />
                                                    <dx:ScaleLabelWeb AppearanceText-TextBrush="&lt;BrushObject Type=&quot;Solid&quot;  Data=&quot;Color:White&quot;/&gt;" FormatString="{0}" Name="Label1" Position="75, 238" Size="90, 15"
                                                        Text="United Kingdom" />
                                                    <dx:ScaleLabelWeb AppearanceText-TextBrush="&lt;BrushObject Type=&quot;Solid&quot;  Data=&quot;Color:White&quot;/&gt;" AppearanceText-Font="Tahoma, 12pt" FormatString="{0:F4}" Name="Label2"
                                                        Position="168, 225" Size="70, 20" Text="62.56" />
                                                </Labels>
                                            </dx:ArcScaleComponent>
                                            <dx:ArcScaleComponent Center="125, 110" EndAngle="270" MajorTickCount="2" MajorTickmark-ShowText="False"
                                                MajorTickmark-ShowTick="False" MajorTickmark-TextOrientation="LeftToRight" MaxValue="12"
                                                MinorTickCount="0" Name="ukScale2" RadiusX="74" RadiusY="74" StartAngle="-90"
                                                Value="3">
                                            </dx:ArcScaleComponent>
                                        </Scales>
                                    </dx:CircularGauge>
                                </Gauges>
                            </dx:ASPxGaugeControl>
                        </td>
                        <td style="width: 33%;">
                            <dx:ASPxGaugeControl runat="server" Width="250px" Height="250px" BackColor="White"
                                ID="Tokyo">
                                <Gauges>
                                    <dx:CircularGauge ID="gaugeJapan" Bounds="0, 0, 250, 250">
                                        <BackgroundLayers>
                                            <dx:ArcScaleBackgroundLayerComponent Name="japanBg1" ScaleCenterPos="0.504, 0.436"
                                                ScaleID="japanScale1" ShapeType="CircularFull_WorldTimeClock" Size="216, 250"
                                                ZOrder="1000" />
                                        </BackgroundLayers>
                                        <Indicators>
                                            <dx:ArcScaleStateIndicatorComponent Center="75, 218" Name="japanIndicator1" ScaleID="japanScale1"
                                                Size="40, 21" ZOrder="-100">
                                                <States>
                                                    <dx:ScaleIndicatorStateWeb IntervalLength="12" Name="Default" ShapeType="FlagJapan" />
                                                </States>
                                            </dx:ArcScaleStateIndicatorComponent>
                                            <dx:ArcScaleStateIndicatorComponent Center="118, 223" Name="japanIndicator2" ScaleID="japanScale1"
                                                Shader="&lt;ShaderObject Type=&quot;Gray&quot;/&gt;" Size="20, 20" ZOrder="-100">
                                                <States>
                                                    <dx:ScaleIndicatorStateWeb IntervalLength="12" Name="Default" ShapeType="CurrencyJPY" />
                                                </States>
                                            </dx:ArcScaleStateIndicatorComponent>
                                            <dx:ArcScaleStateIndicatorComponent Center="213, 223" Name="japanIndicator3" ScaleID="japanScale1"
                                                Size="15, 15" ZOrder="-100">
                                                <States>
                                                    <dx:ScaleIndicatorStateWeb IntervalLength="12" Name="Default" ShapeType="Arrow10" />
                                                </States>
                                            </dx:ArcScaleStateIndicatorComponent>
                                        </Indicators>
                                        <Needles>
                                            <dx:ArcScaleNeedleComponent EndOffset="10" Name="japanNeedle1" ScaleID="japanScale1"
                                                ShapeType="CircularFull_ClockHour" ZOrder="-50" />
                                            <dx:ArcScaleNeedleComponent EndOffset="-5" Name="japanNeedle2" ScaleID="japanScale2"
                                                ShapeType="CircularFull_ClockMinute" ZOrder="-51" />
                                        </Needles>
                                        <SpindleCaps>
                                            <dx:ArcScaleSpindleCapComponent Name="japanCap1" ScaleID="japanScale1" ShapeType="CircularFull_Clock"
                                                Size="12, 12" ZOrder="-100" />
                                        </SpindleCaps>
                                        <EffectLayers>
                                            <dx:ArcScaleEffectLayerComponent Name="japanEffect1" ScaleCenterPos="0.5, 1" ScaleID="japanScale1"
                                                Shader="&lt;ShaderObject Type=&quot;Opacity&quot; Data=&quot;Opacity[0.7]&quot;/&gt;"
                                                ShapeType="CircularFull_Clock" Size="170, 85" ZOrder="-1000" />
                                        </EffectLayers>
                                        <Scales>
                                            <dx:ArcScaleComponent AppearanceTickmarkText-Font="Tahoma, 10pt" AppearanceTickmarkText-TextBrush="&lt;BrushObject Type=&quot;Solid&quot; Data=&quot;Color:Black&quot;/&gt;"
                                                Center="125, 110" EndAngle="270" MajorTickCount="13" MajorTickmark-FormatString="{0:F0}"
                                                MajorTickmark-ShapeOffset="-9.5" MajorTickmark-ShapeType="Circular_Style5_2"
                                                MajorTickmark-ShowFirst="False" MajorTickmark-TextOffset="-18" MajorTickmark-TextOrientation="LeftToRight"
                                                MaxValue="12" MinorTickCount="4" MinorTickmark-ShapeOffset="-1.5" MinorTickmark-ShapeType="Circular_Style5_5"
                                                Name="japanScale1" RadiusX="74" RadiusY="74" StartAngle="-90">
                                                <Labels>
                                                    <dx:ScaleLabelWeb AppearanceText-Font="Tahoma, 8pt" AppearanceText-TextBrush="&lt;BrushObject Type=&quot;Solid&quot; Data=&quot;Color:Black&quot;/&gt;"
                                                        FormatString="{0}" Name="Label0" Position="125, 135" Size="70, 20" Text="Tokyo" />
                                                    <dx:ScaleLabelWeb AppearanceText-TextBrush="&lt;BrushObject Type=&quot;Solid&quot;  Data=&quot;Color:White&quot;/&gt;" FormatString="{0}" Name="Label1" Position="75, 238" Size="50, 15"
                                                        Text="Japan" />
                                                    <dx:ScaleLabelWeb AppearanceText-TextBrush="&lt;BrushObject Type=&quot;Solid&quot;  Data=&quot;Color:White&quot;/&gt;" AppearanceText-Font="Tahoma, 12pt" FormatString="{0:F4}" Name="Label2"
                                                        Position="168, 225" Size="90, 20" Text="7811.9" />
                                                </Labels>
                                            </dx:ArcScaleComponent>
                                            <dx:ArcScaleComponent Center="125, 110" EndAngle="270" MajorTickCount="2" MajorTickmark-ShowText="False"
                                                MajorTickmark-ShowTick="False" MajorTickmark-TextOrientation="LeftToRight" MaxValue="12"
                                                MinorTickCount="0" Name="japanScale2" RadiusX="74" RadiusY="74" StartAngle="-90"
                                                Value="3">
                                            </dx:ArcScaleComponent>
                                        </Scales>
                                    </dx:CircularGauge>
                                </Gauges>
                            </dx:ASPxGaugeControl>
                        </td>
                        <td style="width: 33%;">
                            <dx:ASPxGaugeControl runat="server" Width="250px" Height="250px" BackColor="White"
                                ID="Rome">
                                <Gauges>
                                    <dx:CircularGauge ID="gaugeItaly" Bounds="0, 0, 250, 250">
                                        <BackgroundLayers>
                                            <dx:ArcScaleBackgroundLayerComponent Name="italyBg1" ScaleCenterPos="0.504, 0.436"
                                                ScaleID="italyScale1" ShapeType="CircularFull_WorldTimeClock" Size="216, 250"
                                                ZOrder="1000" />
                                        </BackgroundLayers>
                                        <Indicators>
                                            <dx:ArcScaleStateIndicatorComponent Center="75, 218" Name="italyIndicator1" ScaleID="italyScale1"
                                                Size="40, 21" ZOrder="-100">
                                                <States>
                                                    <dx:ScaleIndicatorStateWeb IntervalLength="12" Name="Default" ShapeType="FlagItaly" />
                                                </States>
                                            </dx:ArcScaleStateIndicatorComponent>
                                            <dx:ArcScaleStateIndicatorComponent Center="118, 223" Name="italyIndicator2" ScaleID="italyScale1"
                                                Shader="&lt;ShaderObject Type=&quot;Gray&quot;/&gt;" Size="20, 20" ZOrder="-100">
                                                <States>
                                                    <dx:ScaleIndicatorStateWeb IntervalLength="12" Name="Default" ShapeType="CurrencyEUR" />
                                                </States>
                                            </dx:ArcScaleStateIndicatorComponent>
                                            <dx:ArcScaleStateIndicatorComponent Center="195, 223" Name="italyIndicator3" ScaleID="italyScale1"
                                                Size="15, 15" ZOrder="-100">
                                                <States>
                                                    <dx:ScaleIndicatorStateWeb IntervalLength="12" Name="Default" ShapeType="Arrow1" />
                                                </States>
                                            </dx:ArcScaleStateIndicatorComponent>
                                        </Indicators>
                                        <Needles>
                                            <dx:ArcScaleNeedleComponent EndOffset="10" Name="italyNeedle1" ScaleID="italyScale1"
                                                ShapeType="CircularFull_ClockHour" ZOrder="-50" />
                                            <dx:ArcScaleNeedleComponent EndOffset="-5" Name="italyNeedle2" ScaleID="italyScale2"
                                                ShapeType="CircularFull_ClockMinute" ZOrder="-51" />
                                        </Needles>
                                        <SpindleCaps>
                                            <dx:ArcScaleSpindleCapComponent Name="italyCap1" ScaleID="italyScale1" ShapeType="CircularFull_Clock"
                                                Size="12, 12" ZOrder="-100" />
                                        </SpindleCaps>
                                        <EffectLayers>
                                            <dx:ArcScaleEffectLayerComponent Name="italyEffect1" ScaleCenterPos="0.5, 1" ScaleID="italyScale1"
                                                Shader="&lt;ShaderObject Type=&quot;Opacity&quot; Data=&quot;Opacity[0.7]&quot;/&gt;"
                                                ShapeType="CircularFull_Clock" Size="170, 85" ZOrder="-1000" />
                                        </EffectLayers>
                                        <Scales>
                                            <dx:ArcScaleComponent AppearanceTickmarkText-Font="Tahoma, 10pt" AppearanceTickmarkText-TextBrush="&lt;BrushObject Type=&quot;Solid&quot; Data=&quot;Color:Black&quot;/&gt;"
                                                Center="125, 110" EndAngle="270" MajorTickCount="13" MajorTickmark-FormatString="{0:F0}"
                                                MajorTickmark-ShapeOffset="-9.5" MajorTickmark-ShapeType="Circular_Style5_2"
                                                MajorTickmark-ShowFirst="False" MajorTickmark-TextOffset="-18" MajorTickmark-TextOrientation="LeftToRight"
                                                MaxValue="12" MinorTickCount="4" MinorTickmark-ShapeOffset="-1.5" MinorTickmark-ShapeType="Circular_Style5_5"
                                                Name="italyScale1" RadiusX="74" RadiusY="74" StartAngle="-90">
                                                <Labels>
                                                    <dx:ScaleLabelWeb AppearanceText-Font="Tahoma, 8pt" AppearanceText-TextBrush="&lt;BrushObject Type=&quot;Solid&quot; Data=&quot;Color:Black&quot;/&gt;"
                                                        FormatString="{0}" Name="Label0" Position="125, 135" Size="70, 20" Text="Rome" />
                                                    <dx:ScaleLabelWeb AppearanceText-TextBrush="&lt;BrushObject Type=&quot;Solid&quot;  Data=&quot;Color:White&quot;/&gt;" FormatString="{0}" Name="Label1" Position="75, 238" Size="50, 15"
                                                        Text="Italy" />
                                                    <dx:ScaleLabelWeb AppearanceText-TextBrush="&lt;BrushObject Type=&quot;Solid&quot;  Data=&quot;Color:White&quot;/&gt;" AppearanceText-Font="Tahoma, 12pt" FormatString="{0:F4}" Name="Label2"
                                                        Position="160, 225" Size="70, 20" Text="72.87" />
                                                </Labels>
                                            </dx:ArcScaleComponent>
                                            <dx:ArcScaleComponent Center="125, 110" EndAngle="270" MajorTickCount="2" MajorTickmark-ShowText="False"
                                                MajorTickmark-ShowTick="False" MajorTickmark-TextOrientation="LeftToRight" MaxValue="12"
                                                MinorTickCount="0" Name="italyScale2" RadiusX="74" RadiusY="74" StartAngle="-90"
                                                Value="3">
                                            </dx:ArcScaleComponent>
                                        </Scales>
                                    </dx:CircularGauge>
                                </Gauges>
                            </dx:ASPxGaugeControl>
                        </td>
                    </tr>
                </table>
            </dx:PanelContent>
        </PanelCollection>
    </dx:ASPxCallbackPanel>
    <dx:ASPxTimer ID="ASPxTimer1" runat="server" Interval="30000">
        <ClientSideEvents Tick="function(s, e) {
	                TimerCallbackPanel.PerformCallback(&quot;OnTimer&quot;);
	         }"></ClientSideEvents>
    </dx:ASPxTimer>
</asp:Content>
