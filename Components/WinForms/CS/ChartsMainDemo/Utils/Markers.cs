using System;
using System.Collections;

namespace DevExpress.XtraCharts.Demos {
	struct MarkerKindStrings {
		public const string square = "Square";
		public const string diamond = "Diamond";
		public const string triangle = "Triangle";
		public const string invertedTriangle = "Inverted Triangle";
		public const string circle = "Circle";
		public const string plus = "Plus";
		public const string cross = "Cross";
		public const string star3 = "Star 3-points";
		public const string star4 = "Star 4-points";
		public const string star5 = "Star 5-points";
		public const string star6 = "Star 6-points";
		public const string star10 = "Star 10-points";
		public const string pentagon = "Pentagon";
		public const string hexagon = "Hexagon";
	}

	class MarkerKindItem {
		string text;
		MarkerKind markerKind;
			
		public string Text { get { return this.text; } }
		public MarkerKind MarkerKind { get { return this.markerKind; } }
			

		public MarkerKindItem(string text, MarkerKind markerKind) {
			this.text = text;
			this.markerKind = markerKind;
		}
		public override string ToString() {
			return this.text;
		}
	}

	class StarMarkerKindItem : MarkerKindItem {
		int pointCount;

		public int PointCount { get { return this.pointCount; } }


		public StarMarkerKindItem(string text, int pointCount) : base(text, MarkerKind.Star) {
			this.pointCount = pointCount;
		}
	}

	class MarkerKindItemCollection : CollectionBase {
		public static MarkerKindItemCollection CreateCollection() {
			MarkerKindItemCollection itemCollection = new MarkerKindItemCollection();
			itemCollection.Add(new MarkerKindItem(MarkerKindStrings.square, MarkerKind.Square));
			itemCollection.Add(new MarkerKindItem(MarkerKindStrings.diamond, MarkerKind.Diamond));
			itemCollection.Add(new MarkerKindItem(MarkerKindStrings.triangle, MarkerKind.Triangle));
			itemCollection.Add(new MarkerKindItem(MarkerKindStrings.invertedTriangle, MarkerKind.InvertedTriangle));
			itemCollection.Add(new MarkerKindItem(MarkerKindStrings.circle, MarkerKind.Circle));
			itemCollection.Add(new MarkerKindItem(MarkerKindStrings.plus, MarkerKind.Plus));
			itemCollection.Add(new MarkerKindItem(MarkerKindStrings.cross, MarkerKind.Cross));
			itemCollection.Add(new StarMarkerKindItem(MarkerKindStrings.star3, 3));
			itemCollection.Add(new StarMarkerKindItem(MarkerKindStrings.star4, 4));
			itemCollection.Add(new StarMarkerKindItem(MarkerKindStrings.star5, 5));
			itemCollection.Add(new StarMarkerKindItem(MarkerKindStrings.star6, 6));
			itemCollection.Add(new StarMarkerKindItem(MarkerKindStrings.star10, 10));
			itemCollection.Add(new MarkerKindItem(MarkerKindStrings.pentagon, MarkerKind.Pentagon));
			itemCollection.Add(new MarkerKindItem(MarkerKindStrings.hexagon, MarkerKind.Hexagon));
			return itemCollection;
		}

		public static string[] GetSizeArray() {
			return new string[] {"8", "10", "12", "14", "16", "18", "20", "22", "24", "26", "28", "30"};
		}

		public MarkerKindItemCollection() {
		}

		public int Add(MarkerKindItem value) {
			return(List.Add(value));
		}

		public void CopyTo(Object[] objects) {
			List.CopyTo(objects, 0);
		}

		public MarkerKindItem GetItemByKind(MarkerKind markerKind) {
			foreach(MarkerKindItem item in List)
				if (item.MarkerKind.Equals(markerKind))
					return item;
			return null;
		}

		public MarkerKindItem GetItemByStarPointCount(int pointCount) {
			foreach(MarkerKindItem item in List)
				if(item.MarkerKind.Equals(MarkerKind.Star) && ((StarMarkerKindItem)item).PointCount == pointCount)
					return item;
			return null;
		}
	}
}
