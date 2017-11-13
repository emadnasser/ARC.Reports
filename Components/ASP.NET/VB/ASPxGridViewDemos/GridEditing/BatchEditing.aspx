<%@ Page Title="" Language="vb" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="BatchEditing.aspx.vb" Inherits="GridEditing_BatchEditing" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" Runat="Server">
	<table class="OptionsTable BottomMargin">
	<tr><td>
		<dx:ASPxLabel ID="EditModeLabel" runat="server" Text="Edit mode:" AssociatedControlID="EditModeCombo" />
	</td><td>
		<dx:ASPxComboBox runat="server" ID="EditModeCombo" AutoPostBack="true" SelectedIndex="0">
			<Items>
				<dx:ListEditItem Value="Cell" />
				<dx:ListEditItem Value="Row" />
			</Items>
		</dx:ASPxComboBox>
	</td></tr><tr><td>
		<dx:ASPxLabel ID="StartEditActionLabel" runat="server" Text="Start edit action:" AssociatedControlID="StartEditActionCombo" />
	</td><td>
		<dx:ASPxComboBox runat="server" ID="StartEditActionCombo" AutoPostBack="true" SelectedIndex="2">
			<Items>
				<dx:ListEditItem Value="Click" />
				<dx:ListEditItem Value="DblClick" />
				<dx:ListEditItem Value="FocusedCellClick" />
			</Items>
		</dx:ASPxComboBox>
	</td></tr> <tr><td>
		<dx:ASPxLabel ID="HighlightDeletedRowsLabel" runat="server" Text="Highlight deleted rows:" AssociatedControlID="cbHighlightDeletedRows" />
	</td><td>
		<dx:ASPxCheckBox runat="server" ID="cbHighlightDeletedRows" AutoPostBack="true" Checked="true" />
	</td></tr>
	</table>
	<br />
	<dx:ASPxGridView ID="Grid" runat="server" DataSourceID="DemoDataSource1" KeyFieldName="ProductID" EnableRowsCache="false" ClientInstanceName="grid" Width="100%">
		<Columns>
			<dx:GridViewCommandColumn ShowNewButtonInHeader="true" ShowDeleteButton="True" Width="50" />
			<dx:GridViewDataTextColumn FieldName="ProductName" >
				 <PropertiesTextEdit >
					<ValidationSettings Display="Dynamic" RequiredField-IsRequired="true" />
				</PropertiesTextEdit>
			</dx:GridViewDataTextColumn>
			<dx:GridViewDataComboBoxColumn FieldName="CategoryID" Caption="Category Name">
				<PropertiesComboBox DataSourceID="CategoriesDataSource" ValueType="System.Int32" ValueField="CategoryID" TextField="CategoryName" />
			</dx:GridViewDataComboBoxColumn>
			<dx:GridViewDataTextColumn FieldName="QuantityPerUnit" />
			<dx:GridViewDataSpinEditColumn FieldName="UnitPrice">
				<PropertiesSpinEdit DisplayFormatString="c" DisplayFormatInEditMode="true" MinValue="0" MaxValue="60000">
					<ValidationSettings Display="Dynamic" RequiredField-IsRequired="true" />
				</PropertiesSpinEdit>
			</dx:GridViewDataSpinEditColumn>
			<dx:GridViewDataSpinEditColumn FieldName="UnitsInStock">
				<PropertiesSpinEdit MinValue="0" MaxValue="10000" NumberType="Integer" />
			</dx:GridViewDataSpinEditColumn>
			<dx:GridViewDataCheckColumn FieldName="Discontinued">
				<PropertiesCheckEdit AllowGrayed="true" AllowGrayedByClick="false" />
			</dx:GridViewDataCheckColumn>
		</Columns>
		<SettingsEditing Mode="Batch" />
	</dx:ASPxGridView>
	<demo:DemoDataSource runat="server" ID="DemoDataSource1" IdentityKey="ProductID" DataSourceID="ProductsDataSource" IsSiteMode="True"></demo:DemoDataSource>
	<ef:EntityDataSource runat="server" ID="ProductsDataSource"
		ContextTypeName="NorthwindContext"
		EnableDelete="True" EnableInsert="True" EnableUpdate="True"
		EntitySetName="Products">
	</ef:EntityDataSource>
	<ef:EntityDataSource runat="server" ID="CategoriesDataSource" ContextTypeName="NorthwindContext" EntitySetName="Categories"></ef:EntityDataSource>
</asp:Content>