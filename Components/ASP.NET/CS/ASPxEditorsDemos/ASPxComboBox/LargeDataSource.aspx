<%@ Page Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="LargeDataSource.aspx.cs"
    Inherits="ASPxComboBox_LargeDataSource" EnableSessionState="ReadOnly" %>
<asp:Content runat="server" ContentPlaceHolderID="CustomHeadHolder">
    <%--start highlighted block--%>
    <script type="text/javascript">
        var startTime;
        function OnBeginCallback() {
            startTime = new Date();
        }
        function OnEndCallback() {
            var result = new Date() - startTime;
            result /= 1000;
            result = result.toString();
            if(result.length > 4)
                result = result.substr(0, 4);
            time.SetText(result.toString() + " sec");
            label.SetText("Time to retrieve the last data:");
        }
    </script>
    <%--end highlighted block--%>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentHolder" runat="Server">
    <dx:CreateDatabaseControl runat="server" ID="CreateDatabaseControl" TableKey="GeneratedPersonTable" />
    <div runat="server" id="Demo">
        <div class="BottomPadding">
            <dx:ASPxLabel ID="ASPxLabel1" runat="server" Text="Type to search:" AssociatedControlID="ASPxComboBox1" />
        </div>
        <div style="float: left">
            <dx:ASPxComboBox ID="ASPxComboBox1" runat="server" EnableCallbackMode="true" CallbackPageSize="10"
                ValueType="System.String" ValueField="ID"
                OnItemsRequestedByFilterCondition="ASPxComboBox_OnItemsRequestedByFilterCondition_SQL"
                OnItemRequestedByValue="ASPxComboBox_OnItemRequestedByValue_SQL" TextFormatString="{0} {1} {2}"
                Width="400px" DropDownStyle="DropDown">
                <Columns>
                    <dx:ListBoxColumn FieldName="FirstName" />
                    <dx:ListBoxColumn FieldName="LastName" />
                    <dx:ListBoxColumn FieldName="Phone" />
                </Columns>
                <ClientSideEvents BeginCallback="function(s, e) { OnBeginCallback(); }" EndCallback="function(s, e) { OnEndCallback(); } " />
            </dx:ASPxComboBox>
        </div>
        <div style="float: left; margin-left: 2%">
            <table>
                <tr>
                    <td>FilterMinLength: &nbsp;</td>
                    <td>
                        <dx:ASPxSpinEdit ID="FilterMinLengthSpinEdit" runat="server" Number="0" MinValue="0" MaxValue="5" onvaluechanged="FilterMinLengthSpinEdit_ValueChanged" AutoPostBack="true" Width="60px" ValueChangedDelay="500" AllowNull="false" />           
                    </td>
                </tr>
            </table>
            <div class="TopPadding">
                <dx:ASPxLabel ID="ASPxLabel2" runat="server" ClientInstanceName="label" />
                <dx:ASPxLabel ID="ASPxLabel3" runat="server" ClientInstanceName="time" Font-Bold="true" />
            </div>
        </div>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" />
    </div>
</asp:Content>
