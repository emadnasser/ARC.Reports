<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ASPxGridView.aspx.cs" Inherits="Modules_ASPxGridView"
    MasterPageFile="~/Site.master" %>
<asp:Content ContentPlaceHolderID="CustomHeadHolder" ID="Content1" runat="server">
    <style type="text/css">
        a.Disabled
        {
            color: #C0C0C0 !important;
            cursor: Default;
        }
    </style>
</asp:Content>
<asp:Content ContentPlaceHolderID="ContentHolder" ID="Content2" runat="server">
    <script type="text/javascript">
// <![CDATA[
        var isCheckInProcess = false;
        function CheckEditForm(button) {
            if(!isCheckInProcess) {
                var form = ASPxClientUtils.GetParentByClassName(button, "dxgv");
                spellChecker.CheckElementsInContainer(form);
            }
        }
        function CheckButtonEnabled(value) {
            isCheckInProcess = !value;
            var element = document.getElementById('checkButton');
            if(element != null) element.className = value ? "" : "Disabled";
        }
    // ]]> 
    </script>
    <dx:ASPxGlobalEvents ID="ASPxGlobalEvents1" runat="server">
        <ClientSideEvents ControlsInitialized="function(s, e) { if(!isCheckInProcess) CheckButtonEnabled(true); }" />
    </dx:ASPxGlobalEvents>
    <dx:ASPxSpellChecker ID="ASPxSpellChecker1" runat="server" ClientInstanceName="spellChecker"
        CheckedElementID="ASPxMemo1" Culture="English (United States)">
        <ClientSideEvents CheckCompleteFormShowing="function(s, e) { e.cancel = true; }"
            BeforeCheck="function(s, e) {	CheckButtonEnabled(false); }" AfterCheck="function(s, e) { CheckButtonEnabled(true); }" />
        <Dictionaries>
            <dx:ASPxSpellCheckerISpellDictionary AlphabetPath="~/App_Data/Dictionaries/EnglishAlphabet.txt"
                GrammarPath="~/App_Data/Dictionaries/english.aff" DictionaryPath="~/App_Data/Dictionaries/american.xlg"
                CacheKey="ispellDic" Culture="English (United States)" EncodingName="Western European (Windows)">
            </dx:ASPxSpellCheckerISpellDictionary>
        </Dictionaries>
    </dx:ASPxSpellChecker>
    <dx:ASPxGridView runat="server" ClientInstanceName="grid" KeyFieldName="EmployeeID"
        AutoGenerateColumns="False" DataSourceID="DemoDataSource1" Width="100%" ID="ASPxGridView1"
        OnCellEditorInitialize="ASPxGridView1_CellEditorInitialize">
        <Columns>
            <dx:GridViewCommandColumn ShowEditButton="true" VisibleIndex="0" />
            <dx:GridViewDataTextColumn FieldName="EmployeeID" ReadOnly="True" VisibleIndex="1">
                <EditFormSettings Visible="False" />
            </dx:GridViewDataTextColumn>
            <dx:GridViewDataTextColumn FieldName="LastName" VisibleIndex="2" />
            <dx:GridViewDataTextColumn FieldName="FirstName" VisibleIndex="3" />
            <dx:GridViewDataMemoColumn FieldName="Notes" VisibleIndex="4">
                <PropertiesMemoEdit Height="200" />
            </dx:GridViewDataMemoColumn>
            <dx:GridViewDataTextColumn FieldName="Title" VisibleIndex="5" />
            <dx:GridViewDataDateColumn FieldName="BirthDate" VisibleIndex="6" />
        </Columns>
        <SettingsPager PageSize="2" />
        <Templates>
            <EditForm>
                <dx:ASPxGridViewTemplateReplacement ID="editors" ReplacementType="EditFormEditors"
                    runat="server">
                </dx:ASPxGridViewTemplateReplacement>
                <table style="width: 100%;">
                    <tr>
                        <td style="text-align: right">
                            <a id="checkButton" href="javascript:void('0')" class="Disabled" onclick="CheckEditForm(this);">
                                Check Spelling</a>
                            <dx:ASPxGridViewTemplateReplacement ID="updateButton" ReplacementType="EditFormUpdateButton"
                                runat="server">
                            </dx:ASPxGridViewTemplateReplacement>
                            <dx:ASPxGridViewTemplateReplacement ID="cancelButton" ReplacementType="EditFormCancelButton"
                                runat="server">
                            </dx:ASPxGridViewTemplateReplacement>
                        </td>
                    </tr>
                </table>
            </EditForm>
        </Templates>
    </dx:ASPxGridView>
    <demo:DemoDataSource runat="server" ID="DemoDataSource1" DataSourceID="EmployeesDataSource" IdentityKey="EmployeeID" />
    <ef:EntityDataSource runat="server" ID="EmployeesDataSource" ContextTypeName="NorthwindContext" EntitySetName="Employees" EnableUpdate="true"
        OnUpdating="EmployeesDataSource_Updating" />
</asp:Content>
