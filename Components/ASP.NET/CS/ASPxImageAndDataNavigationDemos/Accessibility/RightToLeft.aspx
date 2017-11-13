<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeFile="RightToLeft.aspx.cs" Inherits="Common_RightToLeft" %>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentHolder" runat="Server">
    <div dir="rtl" style="text-align: right">
        <dx:ASPxDataView runat="server" RightToLeft="True" DataSourceID="XmlDataSource1"
            ID="ASPxDataView1" Width="100%">
            <SettingsTableLayout ColumnCount="2" RowsPerPage="1" />
            <ItemTemplate>
                <p><b><%# Eval("Name") %></b></p>
                <p><%# Eval("Description") %></p>
                <dx:ASPxRatingControl ID="ASPxRatingControl1" runat="server" 
                    RightToLeft="True" Value='<%# GetRatingValue(Eval("Value")) %>' />                                                
            </ItemTemplate>
        </dx:ASPxDataView>
        <asp:XmlDataSource ID="XmlDataSource1" runat="server" DataFile="~/App_Data/ControlRatings.xml"
            XPath="/Controls/*" />
    </div>
    <script type="text/javascript">
    // <![CDATA[
        if(ASPxClientUtils.ie && ASPxClientUtils.browserVersion > 7 && document.body.offsetWidth % 2 > 0)
            document.body.style.width = (document.body.offsetWidth - 1) + "px";
    // ]]>
    </script>
</asp:Content>
