<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomDictionary.aspx.cs"
    Inherits="Modules_CustomDictionary" MasterPageFile="~/Site.master" %>
<asp:Content ContentPlaceHolderID="ContentHolder" ID="Content2" runat="server">
    <dx:ASPxGlobalEvents ID="ASPxGlobalEvents1" runat="server">
        <ClientSideEvents ControlsInitialized="function(s, e) { if (!e.isCallback) checkButton.SetEnabled(true); }" />
    </dx:ASPxGlobalEvents>
    <dx:ASPxSpellChecker ID="ASPxSpellChecker1" runat="server" ClientInstanceName="spellChecker"
        CheckedElementID="memo" Culture="English (United States)">
        <Dictionaries>
            <dx:ASPxSpellCheckerISpellDictionary AlphabetPath="~/App_Data/Dictionaries/EnglishAlphabet.txt"
                GrammarPath="~/App_Data/Dictionaries/english.aff" DictionaryPath="~/App_Data/Dictionaries/american.xlg"
                CacheKey="ispellDic" Culture="English (United States)" EncodingName="Western European (Windows)">
            </dx:ASPxSpellCheckerISpellDictionary>
            <dx:ASPxSpellCheckerCustomDictionary AlphabetPath="~/App_Data/Dictionaries/EnglishAlphabet.txt"
                DictionaryPath="~/App_Data/Dictionaries/CustomEnglish.dic" CacheKey="customDic1"
                Culture="English (United States)" EncodingName="Western European (Windows)">
            </dx:ASPxSpellCheckerCustomDictionary>
        </Dictionaries>
        <ClientSideEvents BeforeCheck="function(s, e) {	checkButton.SetEnabled(false); }"
            AfterCheck="function(s, e) { checkButton.SetEnabled(true); }" />
    </dx:ASPxSpellChecker>
    <dx:ASPxButton ID="checkButton" runat="server" ClientInstanceName="checkButton" ClientEnabled="false"
        Text="Check Spelling ..." AutoPostBack="False"  CssClass="OptionsBottomMargin">
        <ClientSideEvents Click="function(s, e) { spellChecker.CheckElement(memo); }" />
    </dx:ASPxButton>
    <dx:ASPxMemo ID="memo" runat="server" Width="100%" Height="200px" ClientInstanceName="memo"
        Text="'What's going to be then, eh?' 
There was me, that is Alex, and my three droogs, that is Pete, Georgie, and Dim, Dim being really dim, and we sat in the Korova Milkbar making up rassoodocks what to do with the evening, a flip dark chill winter bastard through dry. The Korova Milkbar was a milk-plus mesto, and you may, O my brothers, have forgotten these mestos we like, things changing so skorry these days and everybody very quick to forget, newspapers not being read much neither.
(the beginning of A Clockwork Orange)">
    </dx:ASPxMemo>
</asp:Content>
