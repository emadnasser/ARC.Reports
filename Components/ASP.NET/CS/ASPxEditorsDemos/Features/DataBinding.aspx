<%@ Page Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="DataBinding.aspx.cs"
    Inherits="Features_DataBinding" %>
<asp:Content ID="Content2" ContentPlaceHolderID="CustomHeadHolder" runat="server">
    <style type="text/css">
        .detailsView
        {
            border-collapse:separate;
            border-spacing: 4px;
        }
        .detailsViewPager > td > table
        {
            margin: 0 auto;
            border-collapse:separate;
            border-spacing: 4px;
        }
    </style>
    <%--start highlighted block--%>
    <script type="text/javascript">
        function RaiseClientValidation() {
            return ASPxClientEdit.ValidateGroup("");
        }
    </script>
    <%--end highlighted block--%>
</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" runat="server">    
    <asp:DetailsView runat="server" BorderStyle="None" CellPadding="-1" CellSpacing="-1"
        DataSourceID="ClubMembersDataSource" ID="ClubMemberCard"
        GridLines="None" AllowPaging="True" AutoGenerateRows="False" DataKeyNames="ClubMemberId"
        OnDataBound="OnDataBound" CssClass="detailsView">
        
        <PagerStyle CssClass="detailsViewPager" />
        <RowStyle Height="25" />
        <FieldHeaderStyle Width="100" />        
        <Fields>
            
            <asp:TemplateField SortExpression="ID" HeaderText="Member ID:" InsertVisible="False">
                <EditItemTemplate>
                    <dx:ASPxLabel ID="lblClubMemberId" runat="server" Text='<%# Bind("ClubMemberId") %>' />                    
                </EditItemTemplate>
                <ItemTemplate>
                    <%# Eval("ClubMemberId") %>                    
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField SortExpression="Name" HeaderText="Name:">
                <EditItemTemplate>
                    <dx:ASPxTextBox ID="tbName" runat="server" Width="200px" Value='<%# Bind("Name") %>'
                        MaxLength="128">
                        <ValidationSettings ErrorDisplayMode="ImageWithTooltip">
                            <RequiredField IsRequired="True" ErrorText="Name is required." />
                        </ValidationSettings>
                    </dx:ASPxTextBox>
                </EditItemTemplate>
                <ItemTemplate>
                    <%# Eval("Name") %>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField SortExpression="Gender" HeaderText="Gender:">
                <EditItemTemplate>
                    <dx:ASPxRadioButtonList ID="rblGender" runat="server" BackColor="Transparent" Value='<%# Bind("Gender") %>'
                        RepeatDirection="Horizontal" EncodeHtml="False">
                        <Items>
                            <dx:ListEditItem Text="Male" Value="Male" />
                            <dx:ListEditItem Text="Female" Value="Female" />
                        </Items>
                        <Paddings Padding="0px" />
                        <Border BorderStyle="None" />
                    </dx:ASPxRadioButtonList>
                </EditItemTemplate>
                <ItemTemplate>
                    <%# Eval("Gender") %>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField SortExpression="Birthday" HeaderText="Birthday:">
                <EditItemTemplate>
                    <dx:ASPxDateEdit ID="deBirthday" runat="server" Value='<%# Bind("Birthday") %>' Width="200px"
                        EditFormatString="MM/dd/yyyy">
                    </dx:ASPxDateEdit>
                </EditItemTemplate>
                <ItemTemplate>
                    <%# Eval("Birthday", "{0:d}") %>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField SortExpression="Occupation" HeaderText="Occupation:">
                <EditItemTemplate>
                    <dx:ASPxComboBox ID="cbOccupation" runat="server" DataSourceID="OccupationsDataSource"
                        Width="200px" Value='<%# Bind("Occupation") %>' ValueField="OccupationName" TextField="OccupationName"
                        MaxLength="128">
                    </dx:ASPxComboBox>
                </EditItemTemplate>
                <ItemTemplate>
                    <%# Eval("Occupation") %>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField SortExpression="Email" HeaderText="Email:">
                <EditItemTemplate>
                    <dx:ASPxTextBox ID="tbEmail" runat="server" Width="200px" Value='<%# Bind("Email") %>'
                        MaxLength="64">
                        <ValidationSettings ErrorDisplayMode="ImageWithTooltip">
                            <RequiredField IsRequired="True" ErrorText="E-mail is required." />
                            <RegularExpression ErrorText="Invalid e-mail." ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" />
                        </ValidationSettings>
                    </dx:ASPxTextBox>
                </EditItemTemplate>
                <ItemTemplate>
                    <%# Eval("Email") %>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField SortExpression="SubscriptionFlag" HeaderText="Subscription:">
                <EditItemTemplate>
                    <dx:ASPxCheckBox ID="ckbSubscriptionFlag" runat="server" ValueType="System.Byte"
                        ValueChecked="1" ValueUnchecked="0" Value='<%# Bind("SubscriptionFlag") %>'>
                    </dx:ASPxCheckBox>
                </EditItemTemplate>
                <ItemTemplate>
                    <%# Eval("SubscriptionFlag").ToString() == "1" ? "Yes" : "No" %>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField ShowHeader="False">
                <EditItemTemplate>
                    <table class="OptionsTable" style="margin: 8px 0 8px 96px">
                        <tr>
                            <td>
                                <dx:ASPxButton runat="server" ID="UpdateButton" Text="Update" CommandName="Update" />
                            </td>
                            <td>
                                <dx:ASPxButton runat="server" ID="CancelButton" Text="Cancel" CommandName="Cancel" CausesValidation="false" />
                            </td>
                        </tr>
                    </table>
                </EditItemTemplate>
                <InsertItemTemplate>
                    <table class="OptionsTable" style="margin: 8px 0 8px 96px">
                        <tr>
                            <td>
                                <dx:ASPxButton runat="server" ID="InsertButton" Text="Insert" CommandName="Insert" />
                            </td>
                            <td>
                                <dx:ASPxButton runat="server" ID="CancelButton" Text="Cancel" CommandName="Cancel" CausesValidation="false" />
                            </td>
                        </tr>
                    </table>
                </InsertItemTemplate>
                <ItemTemplate>
                    <table class="OptionsTable" style="margin: 8px 0 8px 96px">
                        <tr>
                            <td>
                                <dx:ASPxButton runat="server" ID="EditButton" Text="Edit" CommandName="Edit" />
                            </td>
                            <td>
                                <dx:ASPxButton runat="server" ID="NewButton" Text="New" CommandName="New" />
                            </td>
                        </tr>
                    </table>
                </ItemTemplate>
            </asp:TemplateField>
        </Fields>
    </asp:DetailsView>
    <div id="ReadonlyMessageHolder" runat="server" style="color: red; margin-top: 16px" enableviewstate="false"></div>
    <ef:EntityDataSource runat="server" ID="ClubMembersDataSource" ContextTypeName="EditorsSampleDBContext" EntitySetName="ClubMembers" OrderBy="it.ClubMemberId"
        EnableInsert="true" EnableDelete="true" EnableUpdate="true" OnUpdating="OnClubMemberDataSourceModifying" OnDeleting="OnClubMemberDataSourceModifying" OnInserting="OnClubMemberDataSourceModifying" />
    <ef:EntityDataSource runat="server" ID="OccupationsDataSource" ContextTypeName="EditorsSampleDBContext" EntitySetName="Occupations" />
</asp:Content>
