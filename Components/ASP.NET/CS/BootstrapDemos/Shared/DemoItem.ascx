<%@ Control Language="C#" AutoEventWireup="true" CodeFile="DemoItem.ascx.cs" Inherits="DemoItem" %>
<h2 id="<%= HeaderID %>"><%= Title %></h2>
<asp:PlaceHolder runat="server" ID="phDescription" />
<div class="example">
    <asp:PlaceHolder runat="server" ID="phCreateDatabase" />
    <asp:PlaceHolder runat="server" ID="phExample" />
    <asp:PlaceHolder runat="server" ID="phCode">
    <div class="code">
        <div class="lang-group btn-group" runat="server" id="langgroup">
            <button type="button" data-code="aspx" class="btn btn-default active">ASPX</button>
            <button type="button" data-code="cs" id="btnCS" runat="server" class="btn btn-default">C#</button>
            <button type="button" data-code="js" id="btnJS" runat="server" class="btn btn-default">JS</button>
        </div>
        <button type="button" class="btn btn-default btn-copy">Copy</button>
        <pre data-code="aspx"><code class="xml"><asp:PlaceHolder runat="server" ID="phCodeAspx" /></code></pre>
        <pre data-code="cs" class="hidden"><code class="cs"><asp:PlaceHolder runat="server" ID="phCodeCs" /></code></pre>
        <pre data-code="js" class="hidden"><code class="js"><asp:PlaceHolder runat="server" ID="phCodeJs" /></code></pre>
    </div>
    </asp:PlaceHolder>
</div>
