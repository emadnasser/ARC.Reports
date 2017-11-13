<%@ Page Language="vb" AutoEventWireup="true" CodeFile="Container.aspx.vb" Inherits="Modules_Container"
	MasterPageFile="~/Site.master" %>
<asp:Content ContentPlaceHolderID="ContentHolder" ID="Content2" runat="server">
	<dx:ASPxGlobalEvents ID="ASPxGlobalEvents1" runat="server">
		<ClientSideEvents ControlsInitialized="function(s, e) { if(!e.isCallback) checkButton.SetEnabled(true); }" />
	</dx:ASPxGlobalEvents>
	<dx:ASPxSpellChecker ID="ASPxSpellChecker1" runat="server" ClientInstanceName="spellChecker"
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
		Text="Check Spelling ..." AutoPostBack="False" CssClass="OptionsBottomMargin">
		<ClientSideEvents Click="function(s, e) { spellChecker.CheckElementsInContainer(document.getElementById('ContainerToCheck')) }" />
	</dx:ASPxButton>
	<table id="ContainerToCheck">
		<tr>
			<td>
				<table class="OptionsTable">
					<tr>
						<td>
							Name:
						</td>
						<td>
							<dx:ASPxTextBox ID="txtName" runat="server" Text="Nancy Davolio" Width="100%" />
						</td>
					</tr>
					<tr>
						<td>
							Position:
						</td>
						<td>
							<dx:ASPxTextBox ID="txtPosition" runat="server" Text="Sales Reprseentative" Width="100%" />
						</td>
					</tr>
					<tr>
						<td>
							Birth Date:
						</td>
						<td>
							<dx:ASPxDateEdit ID="edtDateEdit" runat="server" Date="1948-12-08" />
						</td>
					</tr>
					<tr>
						<td>
							Address:
						</td>
						<td>
							<dx:ASPxTextBox ID="txtAddress" runat="server" Text="USA, Seattle, 507-20th Ave. E. Apt. 2A"
								Width="100%" />
						</td>
					</tr>
					<tr>
						<td>
							About:
						</td>
						<td>
							<dx:ASPxMemo ID="memoAbout" runat="server" Text="Education includes a BA in psyhology from Colorado State Univercity in 1970.  She also completed &quot;The Art of the Cold Call.&quot;  Nancy is a member of Toastmasters Internationa."
								Width="100%" Rows="8" />
						</td>
					</tr>
				</table>
			</td>
			<td>
				<dx:ASPxImage ID="image" runat="server" ImageUrl="Images/Nancy.jpg" Height="160px"
					Width="160px" />                
			</td>
		</tr>
	</table>
</asp:Content>