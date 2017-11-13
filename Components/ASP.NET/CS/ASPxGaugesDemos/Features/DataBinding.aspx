<%@ Page Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="DataBinding.aspx.cs" Inherits="DataBindingPage" %>
<asp:Content runat="server" ContentPlaceHolderID="CustomHeadHolder">
    <%--start highlighted block--%>
    <script type="text/javascript">
        var isDirty;
        function PerformCallbackCore() {
            var gauge = window["gauge"];
            isDirty = gauge.InCallback();
            if (!isDirty)
                gauge.PerformCallback();
        }
        function OnChanged() {
            PerformCallbackCore();
        }
        function OnEndCallback() {
            if (isDirty)
                window.setTimeout(PerformCallbackCore, 0);
        }
    </script>
    <%--end highlighted block--%>
</asp:Content>
<asp:Content ID="Content1" runat="server" ContentPlaceHolderID="ContentHolder">
    <dx:ASPxGaugeControl runat="server" Width="290px" Height="290px" BackColor="Transparent" ID="gaugeControl" ClientInstanceName="gauge"
        SaveStateOnCallbacks="false" OnCustomCallback="OnGaugeCallback">
        <ClientSideEvents EndCallback="OnEndCallback" />
        <Gauges>
            <dx:CircularGauge ID="cGauge1" Bounds="0, 0, 290, 290">
                <backgroundlayers>
                                <dx:ArcScaleBackgroundLayerComponent Name="bg" ScaleCenterPos="0.5, 0.822" ScaleID="scale1"
                                    Size="250, 152" ZOrder="1000" ShapeType="CircularHalf_Style13"></dx:ArcScaleBackgroundLayerComponent>
                            </backgroundlayers>
                <labels>
                                <dx:LabelComponent AppearanceText-Font="Tahoma, 10pt, style=Bold" AppearanceText-TextBrush="&lt;BrushObject Type=&quot;Solid&quot; Data=&quot;Color:WhiteSmoke&quot;/&gt;"
                                    Text="HP" Name="criteria" Position="125, 100" ZOrder="-25"></dx:LabelComponent>
                                <dx:LabelComponent Text="&lt;color=Red&gt;First Car          &lt;color=Green&gt;Second Car"
                                    AllowHTMLString="True" Name="circularGauge1_Label2" Position="125, 180" Size="200, 25">
                                </dx:LabelComponent>
                            </labels>
                <needles>
                                <dx:ArcScaleNeedleComponent EndOffset="-7.5" StartOffset="-5" ScaleID="scale1" Name="needleHP2"
                                    ZOrder="-50" ShapeType="CircularFull_Style13"></dx:ArcScaleNeedleComponent>
                                <dx:ArcScaleNeedleComponent EndOffset="-7.5" Shader="&lt;ShaderObject Type=&quot;Style&quot; Data=&quot;Colors[Style1:LightGreen;Style2:]&quot;/&gt;"
                                    StartOffset="-5" ScaleID="scale2" Name="needleHP1" ZOrder="-50" ShapeType="CircularFull_Style13">
                                </dx:ArcScaleNeedleComponent>
                            </needles>
                <scales>
                                <dx:ArcScaleComponent Name="scale1" MaxValue="450" Value="250" MinorTickmark-ShapeType="Circular_Style13_4"
                                    MinorTickmark-ShapeOffset="4" Center="125, 130" EndAngle="0" MajorTickCount="7"
                                    MinorTickCount="4" MajorTickmark-TextOffset="10" MajorTickmark-TextOrientation="LeftToRight"
                                    MajorTickmark-FormatString="{0:F0}" MajorTickmark-ShapeType="Circular_Style13_5"
                                    MajorTickmark-ShapeOffset="-7" StartAngle="-180" RadiusX="105" RadiusY="105"
                                    AppearanceTickmarkText-Font="Tahoma, 6pt, style=Bold" OnDataBinding="OnScale1DataBinding">
                                </dx:ArcScaleComponent>
                                <dx:ArcScaleComponent Name="scale2" MaxValue="450" Value="50" MinorTickmark-ShapeType="Circular_Style13_4"
                                    MinorTickmark-ShowTick="False" MinorTickmark-ShapeOffset="4" Center="125, 130"
                                    EndAngle="0" MajorTickCount="7" MinorTickCount="4" MajorTickmark-TextOffset="10"
                                    MajorTickmark-ShowText="False" MajorTickmark-TextOrientation="LeftToRight" MajorTickmark-FormatString="{0:F0}"
                                    MajorTickmark-ShapeType="Circular_Style13_5" MajorTickmark-ShowTick="False" MajorTickmark-ShapeOffset="-7"
                                    StartAngle="-180" RadiusX="105" RadiusY="105" AppearanceTickmarkText-Font="Tahoma, 6pt, style=Bold"
                                    OnDataBinding="OnScale2DataBinding">
                                </dx:ArcScaleComponent>
                            </scales>
            </dx:CircularGauge>
        </Gauges>
    </dx:ASPxGaugeControl>
    <dx:ASPxRoundPanel ID="ASPxRoundPanel1" runat="server" ShowHeader="false" style="float: right">
        <PanelCollection>
            <dx:PanelContent runat="server">
                <table class="OptionsTable">
                    <tr>
                        <td>
                            First Car:
                        </td>
                        <td>
                            <dx:ASPxComboBox ID="firstCarID" runat="server" Height="21px" ValueType="System.String" Width="150px">
                                <ClientSideEvents ValueChanged="OnChanged" />
                            </dx:ASPxComboBox>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            Second Car:
                        </td>
                        <td>
                            <dx:ASPxComboBox ID="secondCarID" runat="server" Height="21px" ValueType="System.String" Width="150px">
                                <ClientSideEvents ValueChanged="OnChanged" />
                            </dx:ASPxComboBox>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            Comparsion Criteria:
                        </td>
                        <td>
                            <dx:ASPxComboBox ID="criteria" runat="server" Height="21px" SelectedIndex="0" ValueType="System.String" Width="150px">
                                <ClientSideEvents ValueChanged="OnChanged" />
                                <Items>
                                    <dx:ListEditItem Text="HP" Value="HP" />
                                    <dx:ListEditItem Text="Cylinders" Value="Cylinders" />
                                    <dx:ListEditItem Text="Liter" Value="Liter" />
                                    <dx:ListEditItem Text="MPG City" Value="MPG City" />
                                    <dx:ListEditItem Text="MPG Highway" Value="MPG Highway" />
                                </Items>
                            </dx:ASPxComboBox>
                        </td>
                    </tr>
                </table>
            </dx:PanelContent>
        </PanelCollection>
    </dx:ASPxRoundPanel>
    <asp:XmlDataSource ID="carsDS" runat="server" DataFile="~/App_Data/Cars.xml"></asp:XmlDataSource>
</asp:Content>
