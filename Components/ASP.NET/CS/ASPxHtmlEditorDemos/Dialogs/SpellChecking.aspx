<%@ Page Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="SpellChecking.aspx.cs"
    Inherits="Dialogs_SpellChecking" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" runat="Server">
    <dx:ASPxHtmlEditor ID="DemoHtmlEditor" runat="server" ClientInstanceName="HtmlEditor"
        Height="500px" Width="900px">
        <SettingsDialogs>
            <InsertImageDialog>
                <SettingsImageUpload UploadFolder="~/UploadFiles/Images/">
                    <ValidationSettings MaxFileSize="500000">
                    </ValidationSettings>
                </SettingsImageUpload>
            </InsertImageDialog>
        </SettingsDialogs>
        <SettingsSpellChecker Culture="English (United States)">
            <Dictionaries>
                <dx:ASPxSpellCheckerISpellDictionary AlphabetPath="~/App_Data/Dictionaries/EnglishAlphabet.txt"
                    GrammarPath="~/App_Data/Dictionaries/english.aff" DictionaryPath="~/App_Data/Dictionaries/american.xlg"
                    CacheKey="ispellDic" Culture="English (United States)" EncodingName="Western European (Windows)">
                </dx:ASPxSpellCheckerISpellDictionary>
            </Dictionaries>
        </SettingsSpellChecker>
        <Toolbars>
            <dx:HtmlEditorToolbar Name="Toolbar">
                <Items>
                    <dx:ToolbarUndoButton>
                    </dx:ToolbarUndoButton>
                    <dx:ToolbarRedoButton>
                    </dx:ToolbarRedoButton>
                    <dx:ToolbarBoldButton BeginGroup="True">
                    </dx:ToolbarBoldButton>
                    <dx:ToolbarItalicButton>
                    </dx:ToolbarItalicButton>
                    <dx:ToolbarUnderlineButton>
                    </dx:ToolbarUnderlineButton>
                    <dx:ToolbarStrikethroughButton>
                    </dx:ToolbarStrikethroughButton>
                    <dx:ToolbarCheckSpellingButton BeginGroup="True">
                    </dx:ToolbarCheckSpellingButton>
                </Items>
            </dx:HtmlEditorToolbar>
        </Toolbars>
    </dx:ASPxHtmlEditor>
</asp:Content>
