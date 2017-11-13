<%@ Page Language="vb" MasterPageFile="~/Site.master" AutoEventWireup="true" %>
<asp:Content ID="Content" ContentPlaceHolderID="OverviewDemoContentHolder" runat="Server">
	<dx:ASPxSpellChecker ID="ASPxSpellChecker1" runat="server" ClientInstanceName="spellChecker"
		CheckedElementID="TextBox1" Culture="English (United States)">
		<Dictionaries>
			<dx:ASPxSpellCheckerISpellDictionary AlphabetPath="~/App_Data/Dictionaries/EnglishAlphabet.txt"
				GrammarPath="~/App_Data/Dictionaries/english.aff" DictionaryPath="~/App_Data/Dictionaries/american.xlg"
				CacheKey="ispellDic" Culture="English (United States)" EncodingName="Western European (Windows)">
			</dx:ASPxSpellCheckerISpellDictionary>
		</Dictionaries>
		<ClientSideEvents BeforeCheck="function(s, e) {	checkButton.SetEnabled(false); }"
			AfterCheck="function(s, e) { checkButton.SetEnabled(true); }" />
	</dx:ASPxSpellChecker>
	<dx:ASPxButton ID="checkButton" runat="server" ClientInstanceName="checkButton"
		Text="Check Spelling ..." AutoPostBack="False">
		<ClientSideEvents Click="function(s, e) { spellChecker.Check(); }" />
	</dx:ASPxButton>
	<br />
	<br />
	<asp:TextBox runat="server" TextMode="MultiLine" Height="150px" Width="100%" ID="TextBox1">Andrewa receiveda his BTS commerciala in 1974 and a Ph.D. in internationala marketinga from the Universitya of Dallasa in 1981.  He is fluenta in Frencha and Italiana and reads German.a  He joineda the companya as a sales representative,a was promoteda to sales managera in Januarya 1992 and to vice presidenta of sales in March 1993.</asp:TextBox>
</asp:Content>