<%@ Page Language="vb" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="DisplayFormat.aspx.vb"
	Inherits="Features_DisplayFormat" %>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentHolder" runat="Server">
	<table class="OptionsTable">
		<tr>
			<td style="width: 200px">
				<dx:ASPxSpinEdit ID="ASPxSpinEdit1" runat="server" DisplayFormatString="C" Number="799.95"
					Width="170" />
			</td>
			<td>
				C
			</td>
		</tr>
		<tr>
			<td>
				<dx:ASPxSpinEdit ID="ASPxSpinEdit2" runat="server" DisplayFormatString="#,#;-#,#;Zero"
					Number="0" Width="170" />
			</td>
			<td>
				#,#;-#,#;Zero
			</td>
		</tr>
		<tr>
			<td>
				<dx:ASPxSpinEdit ID="ASPxSpinEdit3" runat="server" DisplayFormatString="P" Number="0.5"
					Increment="0.1" Width="170" />
			</td>
			<td>
				P
			</td>
		</tr>
	</table>
	<table class="OptionsTable" style="margin-top: 32px">
		<tr>
			<td style="width: 200px">
				<dx:ASPxDateEdit ID="ASPxDateEdit1" runat="server" Date="1984-06-14" DisplayFormatString="D"
					Width="170">
				</dx:ASPxDateEdit>
			</td>
			<td>
				D
			</td>
		</tr>
		<tr>
			<td>
				<dx:ASPxDateEdit ID="ASPxDateEdit2" runat="server" Date="1979-02-28" DisplayFormatString="d MMM yyyy"
					PopupCalendarOwnerID="ASPxDateEdit1" Width="170">
				</dx:ASPxDateEdit>
			</td>
			<td>
				d MMM yyyy
			</td>
		</tr>
	</table>
	<table class="OptionsTable" style="margin-top: 32px">
		<tr>
			<td style="width: 200px">
				<dx:ASPxTextBox ID="ASPxTextBox1" runat="server" Text="123456" DisplayFormatString="[ 00 - 00 - 00 ]"
					Width="170">
				</dx:ASPxTextBox>
			</td>
			<td>
				[ 00 - 00 - 00 ]
			</td>
		</tr>
		<tr>
			<td>
				<dx:ASPxTextBox ID="ASPxTextBox2" runat="server" Text="support" DisplayFormatString="{0}@devexpress.com"
					Width="170">
				</dx:ASPxTextBox>
			</td>
			<td>
				{0}@devexpress.com
			</td>
		</tr>
	</table>
	<table class="OptionsTable" style="margin-top: 32px">
		<tr>
			<td style="width: 200px">
				<dx:ASPxComboBox ID="ASPxComboBox1" runat="server" DisplayFormatString="DXp v. {0}"
					SelectedIndex="0" ValueType="System.String">
					<Items>
						<dx:ListEditItem Text="2010.2" />
						<dx:ListEditItem Text="2011.1" />
						<dx:ListEditItem Text="2011.2" />
					</Items>
				</dx:ASPxComboBox>
			</td>
			<td>
				DXp v. {0}
			</td>
		</tr>
		<tr>
			<td>
				<dx:ASPxComboBox ID="ASPxComboBox2" runat="server" DataSourceID="EmployeesDataSource"
					DisplayFormatString="{0} from {2}" SelectedIndex="0" ValueField="EmployeeID"
					ValueType="System.Int32">
					<Columns>
						<dx:ListBoxColumn FieldName="FirstName" Width="100px" />
						<dx:ListBoxColumn FieldName="LastName" Width="100px" />
						<dx:ListBoxColumn FieldName="City" Width="100px" />
					</Columns>
				</dx:ASPxComboBox>
				<ef:EntityDataSource runat="server" ID="EmployeesDataSource" ContextTypeName="NorthwindContext" EntitySetName="Employees" />
			</td>
			<td>
				{0} from {2}
			</td>
		</tr>
	</table>
</asp:Content>