<%@ Page Language="vb" AutoEventWireup="true" MasterPageFile="~/Site.master" CodeFile="BinaryImageColumn.aspx.vb" Inherits="BinaryImageColumn" %>
<asp:Content ID="Content1" runat="server" ContentPlaceHolderID="ContentHolder">
	<dx:ASPxGridView ID="GridView" runat="server" AutogenerateColumns="False" DataSourceid="DemoDataSource1" KeyFieldName="ID" Width="500">
		<Columns>
			<dx:GridViewCommandColumn ShowEditButton="true" ShowNewButtonInHeader="true" CellStyle-VerticalAlign="Top"/>
			<dx:GridViewDataMemoColumn FieldName="Text" VisibleIndex="1" CellStyle-VerticalAlign="Top">
				<PropertiesMemoEdit Height="148" Width="250">
					<ValidationSettings ErrorDisplayMode="ImageWithTooltip">
						<RequiredField IsRequired="True" ErrorText="Text cannot be empty" />
					</ValidationSettings>
				</PropertiesMemoEdit>
			</dx:GridViewDataMemoColumn>
			<dx:GridViewDataBinaryImageColumn FieldName="Picture" VisibleIndex="2" Width="150">
				<PropertiesBinaryImage ImageHeight="150" ImageWidth="225" EnableServerResize="True">
					<EditingSettings Enabled="true" UploadSettings-UploadValidationSettings-MaxFileSize="4194304"/>
				</PropertiesBinaryImage>
			</dx:GridViewDataBinaryImageColumn>
		</Columns>
		<SettingsPager AlwaysShowPager="True" PageSize="4"/>
		<SettingsEditing UseFormLayout="True" Mode="EditForm" EditFormColumnCount="3"/>
		<EditFormLayoutProperties ColCount="2" SettingsItemCaptions-Location="Top">
			<Items>
				<dx:GridViewColumnLayoutItem ColumnName="Text" RequiredMarkDisplayMode="Hidden" VerticalAlign="Top"/>
				<dx:GridViewColumnLayoutItem ColumnName="Picture" HorizontalAlign="Right" HelpText="You can upload JPG, GIF or PNG file. Maximum fils size is 4MB." />
				<dx:EditModeCommandLayoutItem Colspan="2" ShowCancelButton="true" ShowUpdateButton="true" HorizontalAlign="Right"/>
			</Items>
		</EditFormLayoutProperties>
	</dx:ASPxGridView>
	<demo:DemoDataSource runat="server" ID="DemoDataSource1" IdentityKey="ID" DataSourceID="ImagesDataSource"></demo:DemoDataSource>
	<ef:EntityDataSource runat="server" ID="ImagesDataSource"  ContextTypeName="BinaryImagesContext" EntitySetName="BinaryImages" EnableInsert="true" EnableUpdate="true"/>
</asp:Content>