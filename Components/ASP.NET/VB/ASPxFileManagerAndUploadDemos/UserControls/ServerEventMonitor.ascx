<%@ Control Language="vb" %>
<script runat="server">

	Dim _eventNames As String
	Dim _eventLogWidth As Integer
	Public Property EventNames() As String
		Get
			Return _eventNames
		End Get
		Set(ByVal value As String)
			_eventNames = value
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
	Public Sub TraceEvent(ByVal sender As Object, ByVal e As EventArgs, ByVal eventName As String)
		If (Not IsTraceEnabled(eventName)) Then
			Return
		End If

		Dim builder As New StringBuilder()
		builder.Append("<table cellspacing=""0"" cellpadding=""0"" border=""0"">")
		AppendRow(builder, "Sender", (TryCast(sender, Control)).ID)
		AppendRow(builder, "EventType", eventName)
		Dim count As Integer = 0
		For Each prop As System.Reflection.PropertyInfo In e.GetType().GetProperties(System.Reflection.BindingFlags.Instance Or System.Reflection.BindingFlags.Public)
			Try
				Dim value As Object = If(prop.PropertyType.IsValueType, prop.GetValue(e, Nothing), "[" & prop.PropertyType.Name & "]")
				AppendRow(builder,If(count > 0, "", "Arguments"), prop.Name & " = " & value)
				If (Not prop.PropertyType.IsValueType) Then
					TryTraceCollectionItemArgument(prop, e, builder)
				End If
				count += 1
			Catch
			End Try
		Next prop
		builder.Append("</table><br />")
		builder.Append(EventLog.InnerHtml)
		EventLog.InnerHtml = builder.ToString()
	End Sub
	Sub TryTraceCollectionItemArgument(ByVal prop As System.Reflection.PropertyInfo, ByVal e As EventArgs, ByVal builder As StringBuilder)
		Try
			Dim item As CollectionItem = TryCast(prop.GetValue(e, Nothing), CollectionItem)
			If item Is Nothing Then
				Return
			End If
			Dim itemPropNames() As String = { "Name", "Text" }
			For Each itemPropName As String In itemPropNames
				Dim itemProp As System.Reflection.PropertyInfo = item.GetType().GetProperty(itemPropName)
				If itemProp Is Nothing Then
					Continue For
				End If
				Dim itemPropValue As String = TryCast(itemProp.GetValue(item, Nothing), String)
				If (Not String.IsNullOrEmpty(itemPropValue)) Then
					AppendRow(builder, "", prop.Name & "." & itemPropName & " = " & itemPropValue)
					Return
				End If
			Next itemPropName
		Catch
		End Try
	End Sub
	Function IsTraceEnabled(ByVal eventName As String) As Boolean
		For Each item As RepeaterItem In Repeater.Items
			For Each control As Control In item.Controls
				Dim box As ASPxCheckBox = TryCast(control, ASPxCheckBox)
				If box IsNot Nothing AndAlso box.Text = eventName Then
					Return box.Checked
				End If
			Next control
		Next item
		Return False
	End Function
	Sub AppendRow(ByVal builder As StringBuilder, ByVal name As String, ByVal content As String)
		builder.Append("<tr valign=""top""><td style=""width: 100px"">")
		If (Not String.IsNullOrEmpty(name)) Then
			builder.AppendFormat("<b>{0}:</b>", HttpUtility.HtmlEncode(name))
		End If
		builder.AppendFormat("<td>{0}</td></tr>", HttpUtility.HtmlEncode(content))
	End Sub
	Protected Function GetEventNameList() As IEnumerable(Of String)
		Dim eventNameList() As String = Regex.Split(EventNames, "[^A-Za-z_]+")
		For index As Integer = 0 To eventNameList.Length - 1
			eventNameList.SetValue(eventNameList(index).Replace("_", " "), index)
		Next index
		Return eventNameList
	End Function
	Protected Sub Page_Init(ByVal sender As Object, ByVal e As EventArgs)
		Repeater.DataSource = GetEventNameList()
		Repeater.DataBind()
		If EventLogWidth > 0 Then
			EventLog.Style.Add("width", EventLogWidth & "px")
		End If
	End Sub
	Protected Sub ClearButton_Click(ByVal sender As Object, ByVal e As EventArgs)
		EventLog.InnerHtml = ""
	End Sub

</script>

<div class="EventLogPanel">
	<div runat="server" id="EventLog" class="EventLog"></div>
	<dx:ASPxButton runat="server" ID="ClearButton" Text="Clear" OnClick="ClearButton_Click" />    
</div>
<div class="EventListPanel">
	<div>Trace Events:</div>
	<asp:Repeater runat="server" ID="Repeater">
		<ItemTemplate>          
			<dx:ASPxCheckBox AutoPostBack="true" ID="CheckBox" runat="server" Text="<%#Container.DataItem%>" Checked="true" />
		</ItemTemplate>
	</asp:Repeater>
</div>