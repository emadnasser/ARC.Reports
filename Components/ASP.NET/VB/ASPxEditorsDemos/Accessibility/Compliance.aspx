<%@ Page Language="vb" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Compliance.aspx.vb"
	Inherits="Accessibility_Compliance" %>
<asp:Content ID="Content1" runat="server" ContentPlaceHolderID="CustomTopAreaHolder">
	<dx:SkipRepetitiveNavigationLinksControl ID="SkipRepetitiveNavigationLinksControl1" runat="server" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentHolder" runat="Server">
	<div role="form" aria-labelledby="header ASPxLabel1">
		<h3 id="header">Customer Info</h3>
		<dx:ASPxFormLayout ID="ASPxFormLayout1" runat="server" AlignItemCaptionsInAllGroups="true" UseDefaultPaddings="false">
			<Styles LayoutGroup-Cell-Paddings-Padding="0"/>
			<Items>
				<dx:EmptyLayoutItem Height="20px" />
				<dx:LayoutItem ShowCaption="false">
					<LayoutItemNestedControlCollection>
						<dx:LayoutItemNestedControlContainer>
							<dx:ASPxLabel ID="ASPxLabel1" runat="server" Text="Fields marked with an asterisk (*) are required." ClientIDMode="Static" />
						</dx:LayoutItemNestedControlContainer>
					</LayoutItemNestedControlCollection>
				</dx:LayoutItem>
				<dx:EmptyLayoutItem Height="20px" />
				<dx:LayoutItem Caption="Name">
					<LayoutItemNestedControlCollection>
						<dx:LayoutItemNestedControlContainer>
							<dx:ASPxTextBox ID="tbName" runat="server" Width="200px" AccessibilityCompliant="true">
								<ValidationSettings SetFocusOnError="true">
									<RequiredField IsRequired="True" ErrorText="Name is required" />
								</ValidationSettings>
							</dx:ASPxTextBox>
						</dx:LayoutItemNestedControlContainer>
					</LayoutItemNestedControlCollection>
				</dx:LayoutItem>
				<dx:LayoutItem Caption="Birthday">
					<LayoutItemNestedControlCollection>
						<dx:LayoutItemNestedControlContainer>
							<dx:ASPxDateEdit ID="deBirthday" runat="server" Width="200px">
								<ValidationSettings SetFocusOnError="true">
									<RequiredField IsRequired="True" ErrorText="Birthday is required" />
								</ValidationSettings>
							</dx:ASPxDateEdit>
						</dx:LayoutItemNestedControlContainer>
					</LayoutItemNestedControlCollection>
				</dx:LayoutItem>
				<dx:LayoutItem Caption="Occupation">
					<LayoutItemNestedControlCollection>
						<dx:LayoutItemNestedControlContainer>
							<dx:ASPxComboBox ID="cbOccupation" runat="server" Width="200px" DropDownStyle="DropDown" AccessibilityCompliant="true"
								DataSourceID="OccupationsDataSource" ValueField="OccupationName" TextField="OccupationName" MaxLength="128" IncrementalFilteringMode="StartsWith">
								<ValidationSettings SetFocusOnError="true">
									<RequiredField IsRequired="True" ErrorText="Occupation is required" />
								</ValidationSettings>
							</dx:ASPxComboBox>
						</dx:LayoutItemNestedControlContainer>
					</LayoutItemNestedControlCollection>
				</dx:LayoutItem>
				<dx:LayoutItem Caption="Gender">
					<LayoutItemNestedControlCollection>
						<dx:LayoutItemNestedControlContainer>
							<dx:ASPxRadioButtonList ID="rblGender" runat="server" RepeatDirection="Horizontal" AccessibilityCompliant="true">
								<Items>
									<dx:ListEditItem Text="Male" Value="1" />
									<dx:ListEditItem Text="Female" Value="2" />
								</Items>
								<Border BorderColor="Transparent" />
							</dx:ASPxRadioButtonList>
						</dx:LayoutItemNestedControlContainer>
					</LayoutItemNestedControlCollection>
				</dx:LayoutItem>
				<dx:EmptyLayoutItem Height="20px" />
				<dx:LayoutItem ShowCaption="false" RequiredMarkDisplayMode="Hidden">
					<LayoutItemNestedControlCollection>
						<dx:LayoutItemNestedControlContainer>
							<dx:ASPxCheckBox ID="chkAgree" runat="server" Text="I agree with terms of use (*)" ValueUnchecked="" AccessibilityCompliant="true">
								<ValidationSettings Display="Dynamic" SetFocusOnError="true">
									<RequiredField IsRequired="True" ErrorText="You need to agree to proceed" />
								</ValidationSettings>
							</dx:ASPxCheckBox>
						</dx:LayoutItemNestedControlContainer>
					</LayoutItemNestedControlCollection>
				</dx:LayoutItem>
				<dx:EmptyLayoutItem Height="20" />
				<dx:LayoutItem ShowCaption="false">
					<LayoutItemNestedControlCollection>
						<dx:LayoutItemNestedControlContainer>
							<dx:ASPxButton ID="btnSubmit" runat="server" Text="Submit" AccessibilityCompliant="true" />
						</dx:LayoutItemNestedControlContainer>
					</LayoutItemNestedControlCollection>
				</dx:LayoutItem>
			</Items>
		</dx:ASPxFormLayout>
	</div>
	<dx:AccessibilityValidatorLink ID="ValidatorLink" runat="server" />
	<ef:EntityDataSource runat="server" ID="OccupationsDataSource" ContextTypeName="EditorsSampleDBContext" 
		EntitySetName="Occupations" OrderBy="it.OccupationName" />
</asp:Content>