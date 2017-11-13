using DevExpress.Web;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.ServiceModel.Syndication;
using System.Text;
using System.Web.UI;
using System.Xml;
using System.Xml.Linq;

public partial class Feeds : System.Web.UI.Page {
    const string
        FeedItemPreviewFormat =
            "<div class='FeedPreview'>" +
                    "<div class='Subject'>{0}</div>" +
                    "<div class='Info'>" +
                        "<span>{1}</span>" +
                        "<a href='{2}' target='_blank'>View on Web</a>" +
                    "</div>" +
                    "<div class='Separator'></div>" +
                    "<div class='Body'>{3}</div>" +
                "</div>";
    const string GroupExtensionElementName = "group";
    const string DescriptionElementName = "description";
    static readonly Dictionary<string, string> FeedRegistry = new Dictionary<string, string>();    
    static DateTime LastFeedFetchTime = DateTime.MinValue;
    static readonly TimeSpan FeedTTL = TimeSpan.FromHours(2);
    static Dictionary<string, SyndicationFeed> FetchedFeeds = new Dictionary<string, SyndicationFeed>();
    static readonly object FeedFetchLock = new object();

    static Feeds() {
        FeedRegistry["Blogs"] = "http://community.devexpress.com/blogs/MainFeed.aspx";
        FeedRegistry["Videos"] = "http://www.youtube.com/feeds/videos.xml?channel_id=UCtOjyugQSbxjQGuimGVsLVg";
        FeedRegistry["Webinars"] = "http://www.devexpress.com/rss/webinars/";
        FeedRegistry["News"] = "http://www.devexpress.com/rss/news/news20.xml";
        FeedRegistry["BBC News"] = "http://feeds.bbci.co.uk/news/rss.xml";
        FeedRegistry["Engadget"] = "http://www.engadget.com/rss.xml";
        FeedRegistry["Stack Overflow"] = "http://stackoverflow.com/feeds/tag?tagnames=devexpress&sort=newest";
    }

    protected string SearchText { get { return Utils.GetSearchText(this); } }

    protected void Page_PreInit(object sender, EventArgs e) {
        Utils.ApplyTheme(this);
    }
    
    protected void Page_Load(object sender, EventArgs e) {
        LoadFeedToGrid();
    }

    protected void FeedItemPreviewPanel_Callback(object sender, CallbackEventArgsBase e) {
        string text = string.Format("Can't find feed with the key = {0}", e.Parameter);
        if(!string.IsNullOrEmpty(e.Parameter)) {
            var feedItem = CurrentFeed.Items.FirstOrDefault(i => i.Id == e.Parameter);
            if(feedItem != null)
                text = FormatFeedItem(feedItem);
        }
        FeedItemPreviewPanel.Controls.Add(new LiteralControl(text));
    }

    protected void FeedGrid_CustomCallback(object sender, ASPxGridViewCustomCallbackEventArgs e) {
        if(e.Parameters == "FeedChanged")
            FeedGrid.SearchPanelFilter = string.Empty;
        if(e.Parameters == "Search")
            FeedGrid.SearchPanelFilter = SearchText;
    }

    protected string FormatFeedItem(SyndicationItem feedItem) {
        var description = GetFeedDescription(feedItem);
        return 
            string.Format(FeedItemPreviewFormat,
                feedItem.Title.Text,
                GetCreator(CurrentFeed, feedItem), 
                feedItem.Links[0].Uri.AbsoluteUri,
                description
            );
    }

    protected SyndicationFeed CurrentFeed {
        get { return GetFeed(FeedNavBar.SelectedItem.Text); }
    }

    SyndicationFeed GetFeed(string key) {
        if(!FetchedFeeds.ContainsKey(key) || DateTime.Now - LastFeedFetchTime > FeedTTL) {
            lock(FeedFetchLock) {
                var xmlString = LoadFeedString(FeedRegistry[key]);

                if(string.IsNullOrEmpty(xmlString))
                    return new SyndicationFeed();

                using(var sreader = new StringReader(xmlString))
                using(var reader = XmlReader.Create(sreader))
                    FetchedFeeds[key] = SyndicationFeed.Load(reader);

                LastFeedFetchTime = DateTime.Now;
                
            }
        }
        return FetchedFeeds[key];
    }

    string LoadFeedString(string url) {
        var xmlString = string.Empty;
        using(var wClient = new WebClient())
            xmlString = Utils.NormalizeXmlString(wClient.DownloadString(url));

        var sb = new StringBuilder();
        foreach(var ch in xmlString) {
            if(XmlConvert.IsXmlChar(ch))
                sb.Append(ch);
        }
        return sb.ToString();
    }

    void LoadFeedToGrid() {
        var data = SelectData();
        if(data.Count > 0) {
            FeedGrid.DataSource = data;
            FeedGrid.DataBind();
        } else {
            FeedGrid.SettingsText.EmptyDataRow = string.Format(
                "Please accept our apologies for the inconvenience. The feed URL is currently unavailable: {0}", FeedRegistry[FeedNavBar.SelectedItem.Text]);
            FeedGrid.Settings.ShowFooter = false;
        }
    }


    string GetFeedDescription(SyndicationItem item) {
        if(item.Summary != null)
            return item.Summary.Text;

        var group = item.ElementExtensions.Where(i => i.OuterName == GroupExtensionElementName).FirstOrDefault();
        if(group == null)
            return null;
        
        var groupExtension = group.GetObject<XElement>();
        if(groupExtension == null)
            return null;

        var descriptionElement = groupExtension.Elements().Where(i => i.Name.LocalName == DescriptionElementName).FirstOrDefault();
        return descriptionElement != null ? descriptionElement.Value : null;
    }

    List<object> SelectData() {
        var list = new List<object>();
        foreach(var item in CurrentFeed.Items) {
            var description = GetFeedDescription(item);
            if(string.IsNullOrEmpty(description) || description.Contains("<object") || description.Contains("<embed") || description.Contains("<iframe") || description.Contains("Server Error"))
                continue;
            try {
                list.Add(new {
                    ID = item.Id,
                    Date = item.PublishDate,
                    From = GetCreator(CurrentFeed, item),
                    Title = item.Title.Text,
                    Description = description,
                    Url = item.Links[0].Uri.AbsoluteUri
                });
            }
            catch { }
        }
        return list;
    }

    string GetCreator(SyndicationFeed feed, SyndicationItem item) {
        if(item.Authors.Count > 0)
            return item.Authors[0].Name ?? item.Authors[0].Email;
        var creator = item.ElementExtensions.FirstOrDefault(e => e.OuterName == "creator");
        if(creator != null)
            return creator.GetReader().ReadInnerXml();
        return feed.Title.Text;
    }
}
