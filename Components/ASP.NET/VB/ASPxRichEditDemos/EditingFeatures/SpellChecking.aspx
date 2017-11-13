<%@ Page Language="vb" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="SpellChecking.aspx.vb"
	Inherits="RichEditDemoSpellChecking" %>
<asp:Content ID="Content" ContentPlaceHolderID="ContentHolder" runat="Server">
	<dx:ASPxRichEdit ID="DemoRichEdit" runat="server" Width="100%" Height="700px"
		ActiveTabIndex="0" ShowConfirmOnLosingChanges="false" OnPreRender="DemoRichEdit_PreRender">
		<Settings>
			<SpellChecker Enabled="true" SuggestionCount="4">
				<Dictionaries>
					<dx:ASPxSpellCheckerISpellDictionary
						AlphabetPath="~/App_Data/Dictionaries/EnglishAlphabet.txt"
						GrammarPath="~/App_Data/Dictionaries/english.aff"
						DictionaryPath="~/App_Data/Dictionaries/american.xlg"
						Culture="English (United States)"
						CacheKey="ISpellDic">
					</dx:ASPxSpellCheckerISpellDictionary>
				</Dictionaries>
			</SpellChecker>
		</Settings>
	</dx:ASPxRichEdit>
</asp:Content>