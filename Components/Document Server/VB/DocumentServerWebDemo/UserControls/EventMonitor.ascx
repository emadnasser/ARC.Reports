<%@ Control Language="vb" %>
<script runat="server">

	Dim _eventNames As String
	Dim _scrollContainerHeight As Integer
	Dim _eventLogHeight As Integer
	Dim _eventLogWidth As Integer
	Dim _showEventListPanel As Boolean = True
	Public Property EventNames() As String
		Get
			Return _eventNames
		End Get
		Set(ByVal value As String)
			_eventNames = value
		End Set
	End Property
	Public Property ShowEventListPanel() As Boolean
		Get
			Return _showEventListPanel
		End Get
		Set(ByVal value As Boolean)
			_showEventListPanel = value
		End Set
	End Property
	Public Property ScrollContainerHeight() As Integer
		Get
			Return _scrollContainerHeight
		End Get
		Set(ByVal value As Integer)
			_scrollContainerHeight = value
		End Set
	End Property
	Public Property EventLogHeight() As Integer
		Get
			Return _eventLogHeight
		End Get
		Set(ByVal value As Integer)
			_eventLogHeight = value
		End Set
	End Property
	Public Property EventLogWidth() As Integer
		Get
			Return _eventLogWidth
		End Get
		Set(ByVal value As Integer)
			_eventLogWidth = value
		End Set
	End Property
	Protected Function GetEventNameList() As IEnumerable(Of String)
		Return Regex.Split(EventNames, "[^A-Za-z_]+")
	End Function
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		Repeater.DataSource = GetEventNameList()
		Repeater.DataBind()
	End Sub
	Protected Function GetStyleAttribute() As String
		If EventLogWidth > 0 OrElse EventLogHeight > 0 Then
			Dim heightStr As String = If((EventLogHeight > 0), String.Format("height: {0}px", EventLogHeight), String.Empty)
			Dim widthStr As String = If((EventLogWidth > 0), String.Format("width: {0}px", EventLogWidth), String.Empty)
			Return String.Format("style=""{0}; {1};""", widthStr, heightStr)
		End If
		Return Nothing
	End Function
	Function GetScrollHeight() As String
		If ScrollContainerHeight > 0 Then
			Return String.Format("style=""{0}: {1}px;""", "height", ScrollContainerHeight)
		End If
		Return ""
	End Function
</script>
<script type="text/javascript">

	function ClearButton_Click() {
		DXEventMonitor.Clear();
	}
</script>
<div class="EventLogPanel">
	<div id="EventLog" <%=GetStyleAttribute()%>></div>
	<dx:ASPxButton runat="server" ID="ClearButton" AutoPostBack="false" Text="Clear">
		<ClientSideEvents Click="ClearButton_Click" />
	</dx:ASPxButton>
</div>
<%
   If ShowEventListPanel Then
%>
<div id="EventListContainer" class="EventListPanel" <%=GetScrollHeight()%> >
	<div>Trace Events:</div>
	<asp:Repeater runat="server" ID="Repeater">
		<ItemTemplate>            
			<input type="checkbox" id="EventCheck<%#Container.DataItem%>" checked="checked" />
			<label for="EventCheck<%#Container.DataItem%>"><%#Container.DataItem.ToString().Replace("_"," ")%></label>
			<br />
		</ItemTemplate>
	</asp:Repeater>
</div>     
<%
   End If
%>