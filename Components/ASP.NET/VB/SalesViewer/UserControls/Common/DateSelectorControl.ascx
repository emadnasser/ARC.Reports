<%@ Control Language="vb" AutoEventWireup="true" CodeFile="DateSelectorControl.ascx.vb" Inherits="DateSelectorControl" %>
<div class="dateSelectorControl">
    <div class="prevButton" id="PrevButton" runat="server"></div>
    <div><%=Text%></div>
    <div class="nextButton" id="NextButton" runat="server"></div>
</div>
<dx:ASPxHiddenField ID="DateSelectorHiddenField" runat="server" ClientIDMode="AutoID"></dx:ASPxHiddenField>