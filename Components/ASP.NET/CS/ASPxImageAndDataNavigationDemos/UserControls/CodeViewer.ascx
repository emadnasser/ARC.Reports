<%@ Control Language="C#" AutoEventWireup="true" CodeFile="CodeViewer.ascx.cs" Inherits="UserControls_CodeViewer" %>
<div class="NewWinLink">
    <a href="javascript:DXDemo.ShowCodeInNewWindow(<%= EncodeScriptForAttribute(Utils.CurrentDemoTitleHtml) %>, <%= EncodeScriptForAttribute(SourceCodePage.Title) %>)">Open in popup window
    </a>
</div>
<div id="CodeBlock<%= Index %>" class="<%= GetClassName() %>"
     <% if (DisableTextWrap) { %> 
       style ="width: 920px;white-space: nowrap;" <% } %>>
    <%= SourceCodePage.Code %>
</div>
