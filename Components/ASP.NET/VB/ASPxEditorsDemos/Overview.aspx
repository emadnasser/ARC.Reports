<%@ Page Language="vb" MasterPageFile="~/Site.master" AutoEventWireup="true" %>
<asp:Content ID="localCss" ContentPlaceHolderID="CustomHeadHolder" runat="server">
	<style type="text/css">
	   .TableCell
	   {
			vertical-align: top;
			padding-bottom: 20px;
			padding-right: 30px;
	   }
	   td:last-child.TableCell
	   {
			padding-right: 0px;
	   }
	   .ControlName
	   {
		   font-size: 15px;
		   padding-bottom: 3px;
	   }
	   .TableCell .dxeListBox_Moderno
	   {
		   Height: 147px;
	   }
	</style>
</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="OverviewDemoContentHolder" runat="Server">
	<table style="width: 100%">
		<tr>
			<td style="width: 163px;" class="TableCell">
				<div class="ControlName">ListBox</div>
				<dx:ASPxListBox ID="ASPxListBox1" runat="server" Width="163px">
					<Items>
						<dx:ListEditItem Value="Ana Trujillo" />
						<dx:ListEditItem Value="Giovanni Rovelli" Selected="true" />
						<dx:ListEditItem Value="Jaime Yorres" />
						<dx:ListEditItem Value="John Steel" />
					</Items>
				</dx:ASPxListBox>
			</td>
			<td class="TableCell">
				<div class="ControlName">ProgressBar</div>
				<dx:ASPxProgressBar ID="ASPxProgressBar1" ShowPosition="true" runat="server" Position="42" Width="358px">
				</dx:ASPxProgressBar>
				<div class="ControlName" style="padding-top: 15px;">TrackBar</div>
				<dx:ASPxTrackBar ID="ASPxTrackBar1" runat="server" Width="358px" MinValue="0" MaxValue="50" Step="1" LargeTickInterval="10"
					PositionStart="10" ScalePosition="LeftOrTop">
				</dx:ASPxTrackBar>
			</td>
		</tr>
	</table>
	<table style="width: 100%">
		<tr>
			<td style="width: 163px;" class="TableCell">
				<div class="ControlName">DropDownEdit</div>
				<dx:ASPxDropDownEdit ID="ASPxDropDownEdit1" runat="server" NullText="Text area"  Width="163px">
					<DropDownWindowTemplate>
						<div style="padding: 10px 0 10px 3px">Dropdown content</div>
					</DropDownWindowTemplate>
				</dx:ASPxDropDownEdit>
			</td>
			<td style="width: 163px;" class="TableCell">
				<div class="ControlName">ComboBox</div>
				<dx:ASPxComboBox ID="ASPxComboBox1" runat="server" Width="163px" >
					<Items>
						<dx:ListEditItem Value="Ana Trujillo" />
						<dx:ListEditItem Value="Giovanni Rovelli" />
						<dx:ListEditItem Value="Jaime Yorres" />
						<dx:ListEditItem Value="John Steel" Selected="true" />
					</Items>
				</dx:ASPxComboBox>
			</td>
			<td class="TableCell">
				<div class="ControlName">SpinEdit</div>
				<dx:ASPxSpinEdit ID="ASPxSpinEdit1" runat="server" Width="100%" Increment="100" Number="100" NumberType="Integer"
					MinValue="0" MaxValue="10000">
				</dx:ASPxSpinEdit>
			</td>
		</tr>
		<tr>
			<td class="TableCell">
				<div class="ControlName">DateEdit</div>
				<dx:ASPxDateEdit ID="ASPxDateEdit1" runat="server" EditFormat="Custom" Date="2009-11-02 09:23" Width="100%">
					<TimeSectionProperties>
						<TimeEditProperties EditFormatString="hh:mm tt" />
					</TimeSectionProperties>
				</dx:ASPxDateEdit>
			</td>
			<td class="TableCell">
				<div class="ControlName">TextBox</div>
				<dx:ASPxTextBox ID="ASPxTextBox1" runat="server" Text="123456" DisplayFormatString="[ 00 - 00 - 00 ]"
					Width="100%">
				</dx:ASPxTextBox>
			</td>
			<td class="TableCell">
				<div class="ControlName">TimeEdit</div>
				<dx:ASPxTimeEdit ID="ASPxTimeEdit1" Border-BorderStyle="NotSet" runat="server" Width="100%">
				</dx:ASPxTimeEdit>
			</td>
		</tr>
		<tr>
			<td class="TableCell">
				<div class="ControlName">ButtonEdit</div>
				<dx:ASPxButtonEdit ID="ASPxButtonEdit1" Text="Andy McKee - Rylynn"  Width="163px" runat="server">
					<Buttons>
						<dx:EditButton>
						</dx:EditButton>
					</Buttons>
				</dx:ASPxButtonEdit>
				<br/>
				<div class="ControlName">RadioButtonList</div>
				<dx:ASPxRadioButtonList ID="ASPxRadioButtonList1" runat="server" Width="100%" BackColor="Transparent"
					RepeatDirection="Horizontal">
					<Items>
						<dx:ListEditItem Value="ASP" Selected="true" />
						<dx:ListEditItem Value="WPF" />
					</Items>
				</dx:ASPxRadioButtonList>
			</td>
			<td class="TableCell">
				<div class="ControlName">ColorEdit</div>
				<dx:ASPxColorEdit ID="ASPxColorEdit1" runat="server" Width="100%" Color="#FF9900">
				</dx:ASPxColorEdit>
				<br />
				<div class="ControlName">CheckBoxList</div>
				<dx:ASPxCheckBoxList ID="ASPxCheckBoxList1" runat="server" Width="100%" RepeatDirection="Horizontal">
					<Items>
						<dx:ListEditItem Value="Wi-Fi" Selected="true" />
						<dx:ListEditItem Value="3G" />
					</Items>
				</dx:ASPxCheckBoxList>
			</td>
			<td class="TableCell" style="padding-bottom: 43px;">
				<div class="ControlName">Memo</div>
				<dx:ASPxMemo ID="ASPxMemo1" runat="server" Text="Confections - Desserts, candies, and sweet breads." Height="100%"
					Width="100%">
				</dx:ASPxMemo>
				<div style="margin-bottom: -23px"> </div>
			</td>
		</tr>
		<tr>
			<td class="TableCell">
				<div class="ControlName">RadioButton</div>
				<dx:ASPxRadioButton ID="ASPxRadioButton1" runat="server" Text="Click to change state" />
			</td>
			<td class="TableCell">
				<div class="ControlName">Checkbox</div>
				<dx:ASPxCheckbox ID="ASPxCheckBox1" runat="server" Text="Click to change state">
				</dx:ASPxCheckbox>
			</td>
			<td class="TableCell">
				<div class="ControlName">TokenBox</div>
				<dx:ASPxTokenBox ID="ASPxTokenBox1" runat="server" IncrementalFilteringMode="Contains"
					Width="100%" NullText="Type Jaime">
					<Items>
						<dx:ListEditItem Value="Ana Trujillo" />
						<dx:ListEditItem Value="Giovanni Rovelli"/>
						<dx:ListEditItem Value="Jaime Yorres" />
						<dx:ListEditItem Value="John Steel" />
					</Items>
				</dx:ASPxTokenBox>
			</td>
		</tr>
	</table>
	<table style="width: 100%">
		<tr>
			<td style="width: 163px;" class="TableCell">
				<div class="ControlName">Captcha</div>
				<dx:ASPxCaptcha id="Captcha" runat="server" codelength="7">
					<TextBox Position="Bottom" />
					<ChallengeImage Width="163"></ChallengeImage>
					<TextBoxStyle Width="163px" />
					<ValidationSettings ErrorText="The code is incorrect"></ValidationSettings>
				</dx:ASPxCaptcha>
				<div class="ControlName">Button</div>
				<dx:ASPxButton id="ASPxButton1" Width="163px" runat="server" text="Submit" AutoPostBack="true">
				</dx:ASPxButton>
			</td>
			<td style="vertical-align: top;">
				<div class="ControlName">Calendar</div>
				<dx:ASPxCalendar ID="ASPxCalendar1" runat="server" 
					ShowClearButton="true" ShowDayHeaders="true" 
					ShowHeader="true" ShowTodayButton="true" 
					ShowWeekNumbers="true" />
			</td>
		</tr>
	</table>
</asp:Content>