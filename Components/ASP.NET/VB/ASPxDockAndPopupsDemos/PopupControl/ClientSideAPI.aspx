<%@ Page Language="vb" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="ClientSideAPI.aspx.vb"
	Inherits="PopupControl_ClientSideAPI" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" runat="Server">
	<%--start highlighted block--%>
	<script type="text/javascript">
		function TextBox_OnChange() {
			if (IsErrorVisible())
				ValidateField();
		}
		function ValidateField() {
			var txtLogin = document.getElementById('txtLogin');
			var txtPassword = document.getElementById('txtPassword');
			var txtEmail = document.getElementById('txtEmail');
			var isLogin = CheckLogin(txtLogin.value);
			var isPassword = CheckPassword(txtPassword.value);
			var isEmail = CheckEmail(txtEmail.value);
			var errorText = '';
			if (!isLogin)
				errorText += 'Invalid login.';
			if (!isPassword) {
				if (errorText != '')
					errorText += '<br /><br />';
				errorText += 'Invalid password.';
			}
			if (!isEmail) {
				if (errorText != '')
					errorText += '<br /><br />';
				errorText += 'Invalid email address.';
			}
			if (isLogin && isPassword && isEmail) {
				SetErrorVisible(false);
			} else {
				SetErrorString(errorText);
				SetErrorVisible(true);
			}
		}
		function CheckLogin(value) {
			return CheckRegExp("^[a-z]+$", value);
		}
		function CheckPassword(value) {
			return CheckRegExp("^[0-9]+$", value);
		}
		function CheckEmail(value) {
			return CheckRegExp("^\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*$", value);
		}
		function CheckRegExp(pattern, value) {
			var reg = new RegExp(pattern);
			return reg.exec(value) != null ? true : false;
		}
		function SetHintVisible(name, value) {
			var popupControl = GetPopupControl('Hint');
			var hintWindow = popupControl.GetWindowByName(name);
			if (value)
				popupControl.ShowWindow(hintWindow);
			else
				popupControl.HideWindow(hintWindow);
		}
		function SetErrorVisible(value) {
			var popupControl = GetPopupControl('Error');
			if (value)
				popupControl.Show();
			else
				popupControl.Hide();
		}
		function SetErrorString(text) {
			var popupControl = GetPopupControl('Error');
			popupControl.SetContentHTML(text);
		}
		function IsErrorVisible() {
			var popupControl = GetPopupControl('Error');
			return popupControl.IsVisible();
		}
		function GetPopupControl(name) {
			if (name == 'Hint')
				return ASPxPopupHintClientControl;
			else if (name == 'Error')
				return ASPxPopupErrorClientControl;
		}
	</script>
	<%--end highlighted block--%>
	<dx:ASPxPopupControl ClientInstanceName="ASPxPopupHintClientControl" SkinID="None"
		Width="200px" ID="pcHint" runat="server" EncodeHtml="false" EnableViewState="False"
		PopupHorizontalAlign="OutsideRight" PopupVerticalAlign="TopSides" ShowHeader="False"
		EnableHotTrack="False" PopupHorizontalOffset="1" PopupAction="None" CloseAction="CloseButton"
		PopupVerticalOffset="-10" EnableHierarchyRecreation="True">
		<Windows>
			<dx:PopupWindow Name="Login" Text="Login should consist of &lt;b&gt;a-z&lt;/b&gt;."
				PopupElementID="txtLogin">
			</dx:PopupWindow>
			<dx:PopupWindow Name="Password" Text="Password should consist of &lt;b&gt;0-9&lt;/b&gt;."
				PopupElementID="txtPassword">
			</dx:PopupWindow>
			<dx:PopupWindow Name="Email" Text="For instance, &lt;b&gt;myname@example.com&lt;/b&gt;. This will be used to sign-in to your account."
				PopupElementID="txtEmail">
			</dx:PopupWindow>
		</Windows>
		<ContentStyle BackColor="#FFFBBA" ForeColor="#916E04">
			<Paddings PaddingBottom="12px" PaddingLeft="14px" PaddingRight="14px" PaddingTop="12px" />
			<Border BorderWidth="0px" />
		</ContentStyle>
		<Border BorderColor="#FFC800" BorderStyle="Solid" BorderWidth="1px" />
	</dx:ASPxPopupControl>
	<dx:ASPxPopupControl ClientInstanceName="ASPxPopupErrorClientControl" ShowShadow="false"
		PopupElementID="actionArea" Width="210px" ID="pcError" runat="server" EnableViewState="False"
		PopupHorizontalAlign="LeftSides" PopupVerticalAlign="TopSides" ShowHeader="False"
		EnableHotTrack="False" CloseAction="CloseButton" PopupHorizontalOffset="7" PopupVerticalOffset="128"
		PopupAction="None" EnableHierarchyRecreation="True">
		<ContentStyle BackColor="#FFFBBA" ForeColor="#FF3333">
			<Paddings PaddingBottom="12px" PaddingLeft="14px" PaddingRight="14px" PaddingTop="12px" />
			<Border BorderWidth="0px" />
		</ContentStyle>
		<Border BorderColor="#FFC800" BorderStyle="Solid" BorderWidth="1px" />
	</dx:ASPxPopupControl>
	<div style="height: 212px;">
		<table id="actionArea" class="PopupControlCSAPI">
			<tr>
				<td>
					<label id="lblLogin" for="txtLogin">
						Login:
					</label>
				</td>
				<td>
					<input style="width: 150px;" onblur="SetHintVisible('Login', false);" onfocus="SetHintVisible('Login', true);"
						onchange="TextBox_OnChange();" id="txtLogin" type="text" />
				</td>
			</tr>
			<tr>
				<td>
					<label id="lblPassword" for="txtPassword">
						Password:
					</label>
				</td>
				<td>
					<input style="width: 150px;" onblur="SetHintVisible('Password', false);" onfocus="SetHintVisible('Password', true);"
						onchange="TextBox_OnChange();" id="txtPassword" type="password" />
				</td>
			</tr>
			<tr>
				<td>
					<label id="lblEmail" for="txtEmail">
						E-mail:
					</label>
				</td>
				<td>
					<input style="width: 150px;" onblur="SetHintVisible('Email', false);" onfocus="SetHintVisible('Email', true);"
						onchange="TextBox_OnChange();" id="txtEmail" type="text" />
				</td>
			</tr>
			<tr>
				<td>
				</td>
				<td>
					<dx:ASPxButton AutoPostBack="False" runat="server" CssClass="DemoButton" ID="btnValidate"
						Text="Submit" Style="margin: 0px;">
						<ClientSideEvents Click="function(s, e) { ValidateField(); return false; }" />
					</dx:ASPxButton>
				</td>
			</tr>
		</table>
	</div>
</asp:Content>