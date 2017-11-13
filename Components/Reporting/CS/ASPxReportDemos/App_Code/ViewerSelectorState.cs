using System;
using System.Linq;
using DevExpress.Web.Internal;

namespace DevExpress.Web.Demos {
    public static class ViewerSelectorState {
        public const string Key = "CurrentViewer";
        public const string ModernViewer = "HTML5";
        public const string ClassicViewer = "ASP";
        public const string MobileViewer = "Mobile";

        public static readonly Item[] Items;

        static ViewerSelectorState() {
            var generateAspViewerUrlDelegate = new Func<Uri, string>(GenerateAspViewerUrl);
            var generateHtml5ViewerUrlDelegate = new Func<Uri, string>(GenerateHtml5ViewerUrl);
            var generateMobileViewerUrlDelegate = new Func<Uri, string>(GenerateMobileViewerUrl);
            Items = new Item[] {
                new Item(generateAspViewerUrlDelegate) { Name = "ASP", Text = "ASP.NET Viewer", CssClass = "viewer-selector-asp" },
                new Item(generateHtml5ViewerUrlDelegate) { Name = "HTML5", Text = "HTML JS Viewer", CssClass = "viewer-selector-html5" },
                new Item(generateMobileViewerUrlDelegate) { Name = "Mobile", Text = "Mobile Viewer", CssClass = "viewer-selector-html5" }
            };
        }

        public static Item GetByName(string name) {
            return Items.FirstOrDefault(x => x.Name == name);
        }

        static string GenerateAspViewerUrl(Uri requestUrl) {
            var builder = new UriBuilder(requestUrl);
            builder.Query = Key + "=" + ClassicViewer;
            return builder.ToString();
        }

        static string GenerateHtml5ViewerUrl(Uri requestUrl) {
            var builder = new UriBuilder(requestUrl);
            builder.Query = "";
            return builder.ToString();
        }

        static string GenerateMobileViewerUrl(Uri requestUrl) {
            var builder = new UriBuilder(requestUrl);
            builder.Query = Key + "=" + MobileViewer;
            return builder.ToString();
        }

        public class Item {
            readonly Func<Uri, string> generateUrl;

            public Item(Func<Uri, string> generateUrl) {
                this.generateUrl = generateUrl;
            }

            public string GenerateUrl(Uri requestUri) {
                return generateUrl(requestUri);
            }

            public string Name { get; set; }
            public string Text { get; set; }
            public string CssClass { get; set; }
        }
    }
}
