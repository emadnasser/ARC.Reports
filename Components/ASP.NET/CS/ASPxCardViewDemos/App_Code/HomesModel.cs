using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Web;
using DevExpress.Web.Data;
using DevExpress.Web.Internal;

public class HomesDataProvider {
    const int ImageWidth = 250;
    const string 
        ImageFileNameFormat = "{0}.jpg",
        DataFileVirtualPath = "~/App_Data/Homes.xml",
        PhotoDirVirtualPath = "~/Content/HomesPhoto";

    static readonly object createLocker = new object();
    static List<Home> homes = null;

    static string MapPath(string path) { return HttpContext.Current.Server.MapPath(path); }
    static string DataFilePath { get { return MapPath(DataFileVirtualPath); } }
    static string PhotoDirPath { get { return MapPath(PhotoDirVirtualPath); } }
    static string PhotoUrl(int id) { return Path.Combine(PhotoDirVirtualPath, string.Format(ImageFileNameFormat, id)); }

    public static List<Home> Homes {
        get {
            if(homes == null)
                homes = CreateHomes();
            return homes;
        }
    }
    public static List<Home> SelectHomes() { return Homes; }

    static List<Home> CreateHomes() {
        lock(createLocker) {
            var dataSet = new DataSet();
            dataSet.ReadXml(DataFilePath);
            return dataSet.Tables[0].Select().Select(r => ConvertToHome(r)).ToList();
        }
    }

    static Home ConvertToHome(DataRow row) {
        var result = new Home {
            ID = row.Field<int>("ID"),
            Address = row.Field<string>("Address"),
            Baths = row.Field<short>("Baths"),
            Beds = row.Field<short>("Beds"),
            HouseSize = row.Field<double>("HouseSize"),
            LotSize = row.Field<double>("LotSize"),
            Price = row.Field<decimal>("Price"),
            YearBuilt = row.Field<string>("YearBuilt"),
            Photo = row.Field<byte[]>("Photo"),
            Features = row.Field<string>("Features"),
            Type = (HomeType)row.Field<int>("Type"),
            Status = (HomeStatus)row.Field<int>("Status")
        };
        result.PhotoUrl = GetPhotoUrl(result);
        return result;
    }
    
    static string GetPhotoUrl(Home item) {
        var url = PhotoUrl(item.ID);
        var serverPath = MapPath(url);

        if(!File.Exists(serverPath)) {
            if(!Directory.Exists(PhotoDirPath))
                Directory.CreateDirectory(PhotoDirPath);
            SaveImage(item.Photo, serverPath);
        }
        return url;
    }
    static void SaveImage(byte[] imageBytes, string path) {
        using(var stream = new MemoryStream(imageBytes))
        using(var img = Image.FromStream(stream)) {
            Size size = new Size(ImageWidth, (int)img.Height * ImageWidth / img.Width);
            using (Image thumbnail = new ImageThumbnailCreator(img).CreateImageThumbnail(size))
                ImageUtils.SaveImage(thumbnail, path);
        }
    }
}

public enum HomeType {
    [Description("Single Family Home")]
    SingleFamilyHome,
    [Description("Condo/Townhouse")]
    Townhome,
    [Description("Multi-Family Home")]
    MultiFamilyHome
};
public enum HomeStatus {
    [Description("New Construction")]
    NewConstruction,
    [Description("Foreclosures")]
    Foreclosures,
    [Description("Recently Sold")]
    RecentlySold
};

public class Home {
    public int ID { get; set; }
    public string Address { get; set; }
    public short Baths { get; set; }
    public short Beds { get; set; }
    public double HouseSize { get; set; }
    public double LotSize { get; set; }
    public decimal Price { get; set; }
    public string YearBuilt { get; set; }
    public byte[] Photo { get; set; }
    public string PhotoUrl { get; set; }
    public string Features { get; set; }
    public HomeType Type { get; set; }
    public HomeStatus Status { get; set; }
}
