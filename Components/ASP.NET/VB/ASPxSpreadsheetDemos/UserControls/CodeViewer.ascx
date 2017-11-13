<%@ Control Language="vb" AutoEventWireup="true" CodeFile="CodeViewer.ascx.vb" Inherits="UserControls_CodeViewer" %>
<div class="NewWinLink">
	<a href="javascript:DXDemo.ShowCodeInNewWindow(<%=EncodeScriptForAttribute(Utils.CurrentDemoTitleHtml)%>, <%=EncodeScriptForAttribute(SourceCodePage.Title)%>)">Open in popup window
	</a>
</div>
<div id="CodeBlock<%=Index%>" class="<%=GetClassName()%>"
<%
		If DisableTextWrap Then
%>
	   style ="width: 920px;white-space: nowrap;" 
<%
		End If
%>
		  >
	<%=SourceCodePage.Code%>
</div>