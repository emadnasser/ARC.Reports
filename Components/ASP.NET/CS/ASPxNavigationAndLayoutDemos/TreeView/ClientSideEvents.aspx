<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeFile="ClientSideEvents.aspx.cs" Inherits="TreeView_ClientSideEvents" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" runat="Server">
    <div style="height: 340px;">
        <dx:ASPxTreeView ID="treeView" runat="server" AllowSelectNode="true" AllowCheckNodes="true">
            <Nodes>
                <dx:TreeViewNode Text="Arrays" Name="arrays">
                    <Nodes>
                        <dx:TreeViewNode Text="Associative array" Name="associativeArray">
                        </dx:TreeViewNode>
                        <dx:TreeViewNode Text="Multimap" Name="multimap">
                        </dx:TreeViewNode>
                        <dx:TreeViewNode Text="Set" Name="set">
                        </dx:TreeViewNode>
                        <dx:TreeViewNode Text="Multiset" Name="multiset">
                        </dx:TreeViewNode>
                        <dx:TreeViewNode Text="Hash table" Name="hashTable">
                        </dx:TreeViewNode>
                    </Nodes>
                </dx:TreeViewNode>
                <dx:TreeViewNode Text="Lists" Name="lists">
                    <Nodes>
                        <dx:TreeViewNode Text="Double-ended queue" Name="doubleEndedQueue">
                        </dx:TreeViewNode>
                        <dx:TreeViewNode Text="Linked list" Name="linkedList">
                        </dx:TreeViewNode>
                        <dx:TreeViewNode Text="Queue" Name="queue">
                        </dx:TreeViewNode>
                        <dx:TreeViewNode Text="Stack" Name="stack">
                        </dx:TreeViewNode>
                        <dx:TreeViewNode Text="Circular queue/buffer" Name="circularQueueAndBuffer">
                        </dx:TreeViewNode>
                    </Nodes>
                </dx:TreeViewNode>
            </Nodes>
            <ClientSideEvents Init="function(s, e) { DXEventMonitor.Trace(s, e, 'Init') }" ExpandedChanging="function(s, e) { DXEventMonitor.Trace(s, e, 'ExpandedChanging') }"
                ExpandedChanged="function(s, e) { DXEventMonitor.Trace(s, e, 'ExpandedChanged') }"
                NodeClick="function(s, e) { DXEventMonitor.Trace(s, e, 'NodeClick') }"
                CheckedChanged="function(s, e) { DXEventMonitor.Trace(s, e, 'CheckedChanged') }" />
        </dx:ASPxTreeView>
    </div>
    <div class="Clear"></div>
    <dx:EventMonitor runat="server" ID="EventMonitor" EventNames="Init, ExpandedChanging, ExpandedChanged, CheckedChanged, NodeClick" EventLogWidth="540" />
</asp:Content>
