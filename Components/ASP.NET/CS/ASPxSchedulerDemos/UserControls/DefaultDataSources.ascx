<%@ Control Language="C#" AutoEventWireup="true" CodeFile="DefaultDataSources.ascx.cs" Inherits="DefaultDataSources" %>
<asp:ObjectDataSource ID="temporaryAppointmentDataSource" runat="server" DataObjectTypeName="CustomEvent" TypeName="CustomEventDataSource" DeleteMethod="DeleteMethodHandler" SelectMethod="SelectMethodHandler" InsertMethod="InsertMethodHandler" OnObjectCreated="temporaryAppointmentDataSource_ObjectCreated" UpdateMethod="UpdateMethodHandler">
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="temporaryResourceDataSource" runat="server" DataObjectTypeName="CustomResource" TypeName="CustomResourceDataSource" DeleteMethod="DeleteMethodHandler" SelectMethod="SelectMethodHandler" InsertMethod="InsertMethodHandler" OnObjectCreated="temporaryResourceDataSource_ObjectCreated" UpdateMethod="UpdateMethodHandler">
</asp:ObjectDataSource>
