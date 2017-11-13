<%@ Page Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="KPI.aspx.cs"
    Inherits="OLAP_KPI" %>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentHolder" runat="Server">
    <asp:Panel ID="panelOptions" runat="server">
        <table class="OptionsTable BottomMargin">
            <tr>
                <td>
                    Status Graphics:&nbsp;&nbsp;
                </td>
                <td>
                    <dx:ASPxComboBox runat="server" SelectedIndex="0" ValueType="System.String" AutoPostBack="True"
                        ID="ddlStatusGraphics" OnSelectedIndexChanged="ddlStatusGraphics_SelectedIndexChanged" />
                </td>
            </tr>
            <tr>
                <td>
                    Trend Graphics:&nbsp;&nbsp;
                </td>
                <td>
                    <dx:ASPxComboBox runat="server" SelectedIndex="0" ValueType="System.String" AutoPostBack="True"
                        ID="ddlTrendGraphics" OnSelectedIndexChanged="ddlTrendGraphics_SelectedIndexChanged" />
                </td>
            </tr>
        </table>
    </asp:Panel>
    <dx:ASPxPivotGrid ID="pivotGrid" runat="server" ClientInstanceName="pivotGrid" CssClass="" Width="100%"
        OLAPConnectionString="<%$ ConnectionStrings:AdventureWorksCubeFileConnection %>" >
        <Groups>
            <dx:PivotGridWebGroup Caption="Date.Fiscal" Hierarchy="[Date].[Fiscal]" />
        </Groups>
        <Fields>
            <dx:PivotGridField ID="field" Area="DataArea" AreaIndex="0" Caption="Internet Revenue"
                CellFormat-FormatString="c2" CellFormat-FormatType="Numeric" FieldName="[Measures].[Internet Sales Amount]" />
            <dx:PivotGridField ID="field1" Area="DataArea" AreaIndex="1" Caption="Goal" FieldName="[Measures].[Internet Revenue Goal]"
                CellFormat-FormatString="c2" CellFormat-FormatType="Numeric" />
            <dx:PivotGridField ID="fieldStatus" Area="DataArea" AreaIndex="2" Caption="Status"
                FieldName="[Measures].[Internet Revenue Status]" />
            <dx:PivotGridField ID="fieldTrend" Area="DataArea" AreaIndex="3" Caption="Trend"
                FieldName="[Measures].[Internet Revenue Trend]" />
            <dx:PivotGridField ID="field4" Area="RowArea" AreaIndex="0" Caption="Fiscal Year"
                FieldName="[Date].[Fiscal].[Fiscal Year]" GroupIndex="0" InnerGroupIndex="0" />
            <dx:PivotGridField ID="field6" Area="RowArea" AreaIndex="1" Caption="Fiscal Semester"
                FieldName="[Date].[Fiscal].[Fiscal Semester]" GroupIndex="0" InnerGroupIndex="1" />
            <dx:PivotGridField ID="field5" Area="RowArea" AreaIndex="2" Caption="Fiscal Quarter"
                FieldName="[Date].[Fiscal].[Fiscal Quarter]" GroupIndex="0" InnerGroupIndex="2" />
        </Fields>
        <OptionsView HorizontalScrollBarMode="Auto" />
        <OptionsFilter NativeCheckBoxes="False" />
        <Styles>
            <FieldValueStyle Wrap="False" />
        </Styles>
    </dx:ASPxPivotGrid>
</asp:Content>
