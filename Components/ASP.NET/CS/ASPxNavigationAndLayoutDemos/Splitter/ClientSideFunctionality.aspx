<%@ Page Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="ClientSideFunctionality.aspx.cs"
    Inherits="Splitter_ClientSideFunctionality" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" runat="Server">
    <script type="text/javascript">
    // <![CDATA[
        function AllowResize(value) {
            splitter.SetAllowResize(value);
        }
        var selectedPane = "First";
        function ComboBoxValueChanged(newValue) {
            selectedPane = newValue;
            UpdateButtonState();
        }
        var isCollapseButton = true;
        function CollapseExpandButtonClick(button) {
            var pane = splitter.GetPaneByName(selectedPane);
            var secondPane = splitter.GetPaneByName((selectedPane == "First") ? "Second" : "First");
            var allowCollapse = !pane.IsCollapsed() && !secondPane.IsCollapsed();
            var allowExpand = pane.IsCollapsed();
            if (isCollapseButton && allowCollapse)
                pane.Collapse(secondPane);
            else if (!isCollapseButton && allowExpand)
                pane.Expand();
        }
        function UpdateButtonState() {
            var pane = splitter.GetPaneByName(selectedPane);
            var secondPane = splitter.GetPaneByName((selectedPane == "First") ? "Second" : "First");
            if (secondPane.IsCollapsed()) {
                isCollapseButton = true;
                collapseExpandButton.SetEnabled(false);
            }
            else {
                isCollapseButton = !pane.IsCollapsed();
                collapseExpandButton.SetEnabled(true);
            }
            if (isCollapseButton)
                collapseExpandButton.SetText("Collapse pane");
            else
                collapseExpandButton.SetText("Expand pane");
        }
        function UpdateContentUrl(s, e) {
            splitter.GetPaneByName('Second').SetContentUrl(s.GetValue());
            e.processOnServer = false;
        }
        function UpdatePaneWidth(s, e) {
            splitter.GetPaneByName('First').SetSize(s.GetValue());
            e.processOnServer = false;
        }
    // ]]> 
    </script>
    <table class="OptionsTable BottomMargin">
        <tr>
            <td>
                <dx:ASPxCheckBox ID="ASPxCheckBox1" runat="server" Text="Allow sizing" Checked="True">
                    <ClientSideEvents ValueChanged="function(s, e) { AllowResize(s.GetValue()); }" />
                </dx:ASPxCheckBox>
            </td>
            <td></td>
            <td></td>
        </tr>
        <tr>
            <td>
                <dx:ASPxLabel ID="ASPxLabel2" runat="server" Text="ContentUrl for the second pane:">
                </dx:ASPxLabel>
            </td>
            <td>
                <dx:ASPxComboBox ID="ASPxComboBox2" runat="server">
                    <Items>
                        <dx:ListEditItem Text="Page 1" Value="SamplePages/Page1.aspx" Selected="True" />
                        <dx:ListEditItem Text="Page 2" Value="SamplePages/Page2.aspx" />
                        <dx:ListEditItem Text="Page 3" Value="SamplePages/Page3.aspx" />
                    </Items>
                    <ClientSideEvents ValueChanged="UpdateContentUrl" />
                </dx:ASPxComboBox>
            </td>
            <td></td>
        </tr>
        <tr>
            <td>
                <dx:ASPxLabel ID="ASPxLabel3" runat="server" Text="Width of the first pane:">
                </dx:ASPxLabel>
            </td>
            <td>
                <dx:ASPxComboBox ID="ASPxComboBox3" runat="server" ClientInstanceName="paneWidthCombobox">
                    <Items>
                        <dx:ListEditItem Text="15%" Value="15%" Selected="true" />
                        <dx:ListEditItem Text="300px" Value="300px" />
                        <dx:ListEditItem Text="400px" Value="400px" />
                    </Items>
                    <ClientSideEvents ValueChanged="UpdatePaneWidth" />
                </dx:ASPxComboBox>
            </td>
            <td></td>
        </tr>
        <tr>
            <td>
                <dx:ASPxLabel ID="ASPxLabel1" runat="server" Text="Collapse/Expand panes:">
                </dx:ASPxLabel>
            </td>
            <td>
                <dx:ASPxComboBox ID="ASPxComboBox1" runat="server" ValueType="System.String" SelectedIndex="0">
                    <Items>
                        <dx:ListEditItem Text="First pane" Value="First" />
                        <dx:ListEditItem Text="Second pane" Value="Second" />
                    </Items>
                    <ClientSideEvents ValueChanged="function(s, e) { ComboBoxValueChanged(s.GetValue()); }" />
                </dx:ASPxComboBox>
            </td>
            <td>
                <dx:ASPxButton ID="ASPxButton1" runat="server" Text="Collapse pane" AutoPostBack="False"
                    ClientInstanceName="collapseExpandButton" Width="120px">
                    <ClientSideEvents Click="CollapseExpandButtonClick" />
                </dx:ASPxButton>
            </td>
        </tr>
    </table>
    <dx:ASPxSplitter ID="ASPxSplitter1" runat="server" Height="400px" Width="100%" ShowCollapseBackwardButton="True"
        ShowCollapseForwardButton="True" ClientInstanceName="splitter">
        <Panes>
            <dx:SplitterPane Name="First" Size="15%">
                <ContentCollection>
                    <dx:SplitterContentControl ID="SplitterContentControl1" runat="server">
                    </dx:SplitterContentControl>
                </ContentCollection>
            </dx:SplitterPane>
            <dx:SplitterPane Name="Second" ContentUrl="SamplePages/Page1.aspx">
                <ContentCollection>
                    <dx:SplitterContentControl ID="SplitterContentControl3" runat="server">
                    </dx:SplitterContentControl>
                </ContentCollection>
            </dx:SplitterPane>
        </Panes>
        <ClientSideEvents PaneCollapsed="UpdateButtonState" PaneExpanded="UpdateButtonState" />
    </dx:ASPxSplitter>
</asp:Content>
