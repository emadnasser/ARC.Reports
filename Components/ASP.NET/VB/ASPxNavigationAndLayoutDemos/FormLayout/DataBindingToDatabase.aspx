<%@ Page Language="vb" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="DataBindingToDatabase.aspx.vb" Inherits="FormLayout_DataBindingToDatabase" %>
<asp:Content ID="MainContent" ContentPlaceHolderID="ContentHolder" runat="Server">    
	<dx:ASPxFormLayout ID="formLayout" runat="server" DataSourceID="EmployeesDataSource" AlignItemCaptionsInAllGroups="True">
		<Items>
			<dx:LayoutGroup GroupBoxDecoration="None">
				<Items>
					<dx:LayoutItem Caption="Select record">
						<LayoutItemNestedControlCollection>
							<dx:LayoutItemNestedControlContainer runat="server" SupportsDisabledAttribute="True">
								<dx:ASPxComboBox ID="navigateComboBox" runat="server" 
									ValueType="System.String" AutoPostBack="true" SelectedIndex="0"
									OnSelectedIndexChanged="navigateComboBox_SelectedIndexChanged">
									<Items>
										<dx:ListEditItem Value="1" Text="Employee #1"/>
										<dx:ListEditItem Value="2" Text="Employee #2"/>
										<dx:ListEditItem Value="3" Text="Employee #3"/>
										<dx:ListEditItem Value="4" Text="Employee #4"/>
										<dx:ListEditItem Value="5" Text="Employee #5"/>        
									</Items>
								</dx:ASPxComboBox>
							</dx:LayoutItemNestedControlContainer>
						</LayoutItemNestedControlCollection>
					</dx:LayoutItem>
				</Items>
			</dx:LayoutGroup>
			<dx:EmptyLayoutItem />
			<dx:LayoutGroup Caption="Personal Information" ColCount="2">
				<Items>
					<dx:LayoutItem Caption="First Name" FieldName="FirstName">
						<LayoutItemNestedControlCollection>
							<dx:LayoutItemNestedControlContainer runat="server" SupportsDisabledAttribute="True">
								<dx:ASPxTextBox ID="firstNameTextBox" runat="server" Width="170px" />                                
							</dx:LayoutItemNestedControlContainer>
						</LayoutItemNestedControlCollection>
					</dx:LayoutItem>
					<dx:LayoutItem Caption="Last Name" FieldName="LastName">
						<LayoutItemNestedControlCollection>
							<dx:LayoutItemNestedControlContainer runat="server" SupportsDisabledAttribute="True">
								<dx:ASPxTextBox ID="lastNameTextBox" runat="server" Width="170px" />                                
							</dx:LayoutItemNestedControlContainer>
						</LayoutItemNestedControlCollection>
					</dx:LayoutItem>
					<dx:LayoutItem Caption="Birth Date" FieldName="BirthDate">
						<LayoutItemNestedControlCollection>
							<dx:LayoutItemNestedControlContainer runat="server" SupportsDisabledAttribute="True">
								<dx:ASPxDateEdit ID="birthDateEdit" runat="server" />
							</dx:LayoutItemNestedControlContainer>
						</LayoutItemNestedControlCollection>
					</dx:LayoutItem>
				</Items>
			</dx:LayoutGroup>
			<dx:LayoutGroup Caption="Work Information" ColCount="2">
				<Items>
					<dx:LayoutItem Caption="Position" FieldName="Title">
						<LayoutItemNestedControlCollection>
							<dx:LayoutItemNestedControlContainer runat="server" SupportsDisabledAttribute="True">
								<dx:ASPxTextBox ID="titleTextBox" runat="server" Width="170px" />                                
							</dx:LayoutItemNestedControlContainer>
						</LayoutItemNestedControlCollection>
					</dx:LayoutItem>
					<dx:LayoutItem Caption="Hire Date" FieldName="HireDate">
						<LayoutItemNestedControlCollection>
							<dx:LayoutItemNestedControlContainer runat="server" SupportsDisabledAttribute="True">
								<dx:ASPxDateEdit ID="hireDateEdit" runat="server" />                                
							</dx:LayoutItemNestedControlContainer>
						</LayoutItemNestedControlCollection>
					</dx:LayoutItem>
					<dx:LayoutItem Caption="Notes" ColSpan="2" FieldName="Notes">
						<LayoutItemNestedControlCollection>
							<dx:LayoutItemNestedControlContainer runat="server" SupportsDisabledAttribute="True">
								<dx:ASPxMemo ID="notesMemo" runat="server" Height="71px" Width="100%" Rows="8" />                                
							</dx:LayoutItemNestedControlContainer>
						</LayoutItemNestedControlCollection>
					</dx:LayoutItem>
				</Items>
			</dx:LayoutGroup>
			<dx:LayoutItem ShowCaption="False" HorizontalAlign="Right" Width="150">
				<LayoutItemNestedControlCollection>
					<dx:LayoutItemNestedControlContainer runat="server" SupportsDisabledAttribute="True">
						<dx:ASPxButton ID="updateButton" runat="server" Text="Update Record" OnClick="updateButton_Click" Width="150" />
					</dx:LayoutItemNestedControlContainer>
				</LayoutItemNestedControlCollection>
			</dx:LayoutItem>
		</Items>
	</dx:ASPxFormLayout>
	<dx:ASPxLabel runat="server" ID="errorMessageLabel" Visible="false" ForeColor="Red" EnableViewState="false" EncodeHtml="false" />
	<%--start highlighted block--%>
	<asp:SqlDataSource ID="EmployeesDataSource" runat="server" OnUpdating="EmployeesDataSource1_Modifying"
		SelectCommand="SELECT [EmployeeID], [FirstName], [LastName], [Title], [BirthDate], [HireDate], [Notes] FROM [Employees] WHERE ([EmployeeID] = @EmployeeID)" 
		UpdateCommand="UPDATE [Employees] SET [FirstName] = @FirstName, [LastName] = @LastName, [Title] = @Title, [BirthDate] = @BirthDate, [HireDate] = @HireDate, [Notes] = @Notes WHERE [EmployeeID] = @EmployeeID">        
		<SelectParameters>
			<asp:Parameter Name="EmployeeID" Type="Int32" DefaultValue="1" />
		</SelectParameters>
		<UpdateParameters>
			<asp:ControlParameter ControlID="formLayout$firstNameTextBox" Name="FirstName" PropertyName="Text" Type="String" />
			<asp:ControlParameter ControlID="formLayout$lastNameTextBox" Name="LastName" PropertyName="Text" Type="String" />
			<asp:ControlParameter ControlID="formLayout$titleTextBox" Name="Title" PropertyName="Text" Type="String" />
			<asp:ControlParameter ControlID="formLayout$birthDateEdit" Name="BirthDate" PropertyName="Value" Type="DateTime" />
			<asp:ControlParameter ControlID="formLayout$hireDateEdit" Name="HireDate" PropertyName="Value" Type="DateTime" />
			<asp:ControlParameter ControlID="formLayout$notesMemo" Name="Notes" PropertyName="Text" Type="String" />
			<asp:Parameter Name="EmployeeID" Type="Int32" />
		</UpdateParameters>
	</asp:SqlDataSource>    
	<%--end highlighted block--%>
</asp:Content>