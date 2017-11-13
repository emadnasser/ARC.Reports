Imports Microsoft.VisualBasic
Imports DevExpress.Web
Imports System
Imports System.Collections.Generic
Imports System.IO
Imports System.Linq
Imports System.Net
Imports System.ServiceModel.Syndication
Imports System.Text
Imports System.Web.UI
Imports System.Xml
Imports System.Xml.Linq

Partial Public Class Feeds
	Inherits System.Web.UI.Page
	Private Const FeedItemPreviewFormat As String = "<div class='FeedPreview'>" & "<div class='Subject'>{0}</div>" & "<div class='Info'>" & "<span>{1}</span>" & "<a href='{2}' target='_blank'>View on Web</a>" & "</div>" & "<div class='Separator'></div>" & "<div class='Body'>{3}</div>" & "</div>"
	Private Const GroupExtensionElementName As String = "group"
	Private Const DescriptionElementName As String = "description"
	Private Shared ReadOnly FeedRegistry As New Dictionary(Of String, String)()
	Private Shared LastFeedFetchTime As DateTime = DateTime.MinValue
	Private Shared ReadOnly FeedTTL As TimeSpan = TimeSpan.FromHours(2)
	Private Shared FetchedFeeds As New Dictionary(Of String, SyndicationFeed)()
	Private Shared ReadOnly FeedFetchLock As Object = New Object()

	Shared Sub New()
		FeedRegistry("Blogs") = "http://community.devexpress.com/blogs/MainFeed.aspx"
		FeedRegistry("Videos") = "http://www.youtube.com/feeds/videos.xml?channel_id=UCtOjyugQSbxjQGuimGVsLVg"
		FeedRegistry("Webinars") = "http://www.devexpress.com/rss/webinars/"
		FeedRegistry("News") = "http://www.devexpress.com/rss/news/news20.xml"
		FeedRegistry("BBC News") = "http://feeds.bbci.co.uk/news/rss.xml"
		FeedRegistry("Engadget") = "http://www.engadget.com/rss.xml"
		FeedRegistry("Stack Overflow") = "http://stackoverflow.com/feeds/tag?tagnames=devexpress&sort=newest"
	End Sub

	Protected ReadOnly Property SearchText() As String
		Get
			Return Utils.GetSearchText(Me)
		End Get
	End Property

	Protected Sub Page_PreInit(ByVal sender As Object, ByVal e As EventArgs)
		Utils.ApplyTheme(Me)
	End Sub

	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		LoadFeedToGrid()
	End Sub

	Protected Sub FeedItemPreviewPanel_Callback(ByVal sender As Object, ByVal e As CallbackEventArgsBase)
		Dim text As String = String.Format("Can't find feed with the key = {0}", e.Parameter)
		If (Not String.IsNullOrEmpty(e.Parameter)) Then
			Dim feedItem = CurrentFeed.Items.FirstOrDefault(Function(i) i.Id = e.Parameter)
			If feedItem IsNot Nothing Then
				text = FormatFeedItem(feedItem)
			End If
		End If
		FeedItemPreviewPanel.Controls.Add(New LiteralControl(text))
	End Sub

	Protected Sub FeedGrid_CustomCallback(ByVal sender As Object, ByVal e As ASPxGridViewCustomCallbackEventArgs)
		If e.Parameters = "FeedChanged" Then
			FeedGrid.SearchPanelFilter = String.Empty
		End If
		If e.Parameters = "Search" Then
			FeedGrid.SearchPanelFilter = SearchText
		End If
	End Sub

	Protected Function FormatFeedItem(ByVal feedItem As SyndicationItem) As String
		Dim description = GetFeedDescription(feedItem)
		Return String.Format(FeedItemPreviewFormat, feedItem.Title.Text, GetCreator(CurrentFeed, feedItem), feedItem.Links(0).Uri.AbsoluteUri, description)
	End Function

	Protected ReadOnly Property CurrentFeed() As SyndicationFeed
		Get
			Return GetFeed(FeedNavBar.SelectedItem.Text)
		End Get
	End Property

	Private Function GetFeed(ByVal key As String) As SyndicationFeed
		If (Not FetchedFeeds.ContainsKey(key)) OrElse DateTime.Now.Subtract(LastFeedFetchTime) > FeedTTL Then
			SyncLock FeedFetchLock
				Dim xmlString = LoadFeedString(FeedRegistry(key))

				If String.IsNullOrEmpty(xmlString) Then
					Return New SyndicationFeed()
				End If

				Using sreader = New StringReader(xmlString)
				Using reader = XmlReader.Create(sreader)
					FetchedFeeds(key) = SyndicationFeed.Load(reader)
				End Using
				End Using

				LastFeedFetchTime = DateTime.Now

			End SyncLock
		End If
		Return FetchedFeeds(key)
	End Function

	Private Function LoadFeedString(ByVal url As String) As String
		Dim xmlString = String.Empty
		Using wClient = New WebClient()
			xmlString = Utils.NormalizeXmlString(wClient.DownloadString(url))
		End Using

		Dim sb = New StringBuilder()
		For Each ch In xmlString
			If XmlConvert.IsXmlChar(ch) Then
				sb.Append(ch)
			End If
		Next ch
		Return sb.ToString()
	End Function

	Private Sub LoadFeedToGrid()
		Dim data = SelectData()
		If data.Count > 0 Then
			FeedGrid.DataSource = data
			FeedGrid.DataBind()
		Else
			FeedGrid.SettingsText.EmptyDataRow = String.Format("Please accept our apologies for the inconvenience. The feed URL is currently unavailable: {0}", FeedRegistry(FeedNavBar.SelectedItem.Text))
			FeedGrid.Settings.ShowFooter = False
		End If
	End Sub


	Private Function GetFeedDescription(ByVal item As SyndicationItem) As String
		If item.Summary IsNot Nothing Then
			Return item.Summary.Text
		End If

		Dim group = item.ElementExtensions.Where(Function(i) i.OuterName = GroupExtensionElementName).FirstOrDefault()
		If group Is Nothing Then
			Return Nothing
		End If

		Dim groupExtension = group.GetObject(Of XElement)()
		If groupExtension Is Nothing Then
			Return Nothing
		End If

		Dim descriptionElement = groupExtension.Elements().Where(Function(i) i.Name.LocalName = DescriptionElementName).FirstOrDefault()
		Return If(descriptionElement IsNot Nothing, descriptionElement.Value, Nothing)
	End Function

	Private Function SelectData() As List(Of Object)
		Dim list = New List(Of Object)()
		For Each item In CurrentFeed.Items
			Dim description = GetFeedDescription(item)
			If String.IsNullOrEmpty(description) OrElse description.Contains("<object") OrElse description.Contains("<embed") OrElse description.Contains("<iframe") OrElse description.Contains("Server Error") Then
				Continue For
			End If
			Try
				list.Add(New With {Key .ID = item.Id, Key .Date = item.PublishDate, Key .From = GetCreator(CurrentFeed, item), Key .Title = item.Title.Text, Key .Description = description, Key .Url = item.Links(0).Uri.AbsoluteUri})
			Catch
			End Try
		Next item
		Return list
	End Function

	Private Function GetCreator(ByVal feed As SyndicationFeed, ByVal item As SyndicationItem) As String
		If item.Authors.Count > 0 Then
			Return If(item.Authors(0).Name, item.Authors(0).Email)
		End If
		Dim creator = item.ElementExtensions.FirstOrDefault(Function(e) e.OuterName = "creator")
		If creator IsNot Nothing Then
			Return creator.GetReader().ReadInnerXml()
		End If
		Return feed.Title.Text
	End Function
End Class
