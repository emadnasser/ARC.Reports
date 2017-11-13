<%@ Page Language="vb" AutoEventWireup="true" CodeFile="Standard_Editors.aspx.vb"
	Inherits="Modules_Standard_Editors" MasterPageFile="~/Site.master" %>
<asp:Content ContentPlaceHolderID="ContentHolder" ID="Content2" runat="server">
	<dx:ASPxGlobalEvents ID="ASPxGlobalEvents1" runat="server">
		<ClientSideEvents ControlsInitialized="function(s, e) { if (!e.isCallback) checkButton.SetEnabled(true); }" />
	</dx:ASPxGlobalEvents>
	<dx:ASPxSpellChecker ID="ASPxSpellChecker1" runat="server" ClientInstanceName="spellChecker"
		CheckedElementID="TextBox1" OnCheckedElementResolve="ASPxSpellChecker1_CheckedElementResolve"
		Culture="English (United States)">
		<Dictionaries>
			<dx:ASPxSpellCheckerISpellDictionary AlphabetPath="~/App_Data/Dictionaries/EnglishAlphabet.txt"
				GrammarPath="~/App_Data/Dictionaries/english.aff" DictionaryPath="~/App_Data/Dictionaries/american.xlg"
				CacheKey="ispellDic" Culture="English (United States)" EncodingName="Western European (Windows)">
			</dx:ASPxSpellCheckerISpellDictionary>
		</Dictionaries>
		<ClientSideEvents BeforeCheck="function(s, e) {	checkButton.SetEnabled(false); }"
			AfterCheck="function(s, e) { checkButton.SetEnabled(true); }" />
	</dx:ASPxSpellChecker>
	<dx:ASPxButton ID="checkButton" runat="server" ClientInstanceName="checkButton" ClientEnabled="false"
		Text="Check Spelling ..." AutoPostBack="False"  CssClass="OptionsBottomMargin">
		<ClientSideEvents Click="function(s, e) { spellChecker.Check(); }" />
	</dx:ASPxButton>
	<asp:TextBox runat="server" TextMode="MultiLine" Height="100px" Width="100%" ID="TextBox1">Accordnig to an englnsih unviersitry sutdy the oredr of letetrs in a word dosen't mttaer, the olny thnig thta's imporantt is that 
the frsit and last ltteer of eevry word is in the crrecot psoition. The rset can be jmbueld and one is stlil able to read the txet withuot dificultfiy.</asp:TextBox>
</asp:Content>