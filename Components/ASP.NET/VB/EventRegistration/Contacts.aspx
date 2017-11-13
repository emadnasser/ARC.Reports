<%@ Page Language="vb" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Contacts.aspx.vb"
	Theme="DXConnect" Inherits="Contacts" %>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
	<div class="contentHeader">
		<div class="content">
			<img id="contactsTitle" src="Images/title_contacts.png" alt="Contacts" />
		</div>
	</div>
	<div class="content contacts">
		<div class="map">
			<div class="mapBox">
				<iframe src="https://maps.google.ru/maps?ie=UTF8&amp;cid=38947384813906844&amp;q=DevExpress&amp;iwloc=A&amp;hl=en&amp;ll=34.154838,-118.255700&amp;output=embed">
				</iframe>
			</div>
			<a href="https://maps.google.ru/maps?ie=UTF8&amp;cid=38947384813906844&amp;q=DevExpress&amp;iwloc=A&amp;hl=en&amp;ll=34.154838,-118.255700">
				View Larger Map</a>
		</div>
		<h3>
			Contact Developer Express</h3>
		<span>If you need to contact Developer Express, you can do so by using one of the following
			methods. We are here to help, so do not hesitate to communicate with us when required.
			<br />
			<br />
			When calling us by phone, please remember that our offices are open from 7:30AM
			to 4:30PM PST.</span>
		<h4>
			Location:</h4>
		<span>505 N. Brand Blvd, 16th Floor<br />
			Glendale CA 91203<br />
			USA</span>
		<h4>
			Telephone:</h4>
		<span>+ 1 (818) 844 3383</span>
		<h4>
			Fax:</h4>
		<span>+ 1 (818) 844 3389</span>
		<h4>
			Email:</h4>
		<span><a href="mailto:ClientServices@devexpress.com">ClientServices@devexpress.com</a></span>
	</div>
</asp:Content>