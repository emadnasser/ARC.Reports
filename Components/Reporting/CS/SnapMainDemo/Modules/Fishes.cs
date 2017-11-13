using DevExpress.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Xml.Serialization;

namespace DevExpress.Demos.DataSources {
    public class Fish {
        [DisplayName("ID")]
        public int ID { get; set; }
        [DisplayName("Category")]
        public string Category { get; set; }
        [DisplayName("Common Name")]
        public string CommonName { get; set; }
        [DisplayName("Notes")]
        public string Notes { get; set; }
        [DisplayName("Scientific Classification")]
        public ScientificClassification ScientificClassification { get; set; }
    }
    public class ScientificClassification {
        [XmlElement("Reference")]
        public string Hyperlink { get; set; }
        public string Kingdom { get; set; }
        public string Phylum { get; set; }
        [XmlElement("Class")]
        [DisplayName("Class")]
        public string _Class { get; set; }
        public string Order { get; set; }
        public string Family { get; set; }
        public string Genus { get; set; }
        public string Species { get; set; }
    }

    public static class FishesSource {
        static List<Fish> data;

        public static List<Fish> Data {
            get {
                if (data == null)
                    data = GetDataSource();
                return data;
            }
        }

        static List<Fish> GetDataSource() {
            return DataSourceHelper.GetDataSouresFromXml<Fish>("fishes.xml", "Fishes");
        }
    }

    public static class DataSourceHelper {
        public static List<T> GetDataSouresFromXml<T>(string fileName, string attribute) where T: class  {
            string path = FilesHelper.FindingFileName(AppDomain.CurrentDomain.BaseDirectory, "Data\\" + fileName, false);
            if (!File.Exists(path))
                return null;
            using(Stream stream = File.OpenRead(path)){
                XmlSerializer s = new XmlSerializer(typeof(List<T>), new XmlRootAttribute(attribute));
                return (List<T>)s.Deserialize(stream);
            }
        }
    }

    //[DisplayName("Fishes")]
    //public class Fishes : List<Fish> {
    //    public Fishes(string filePath) {
    //        if (File.Exists(filePath)) {
    //            using (Stream stream = File.OpenRead(filePath)) {
    //                this.LoadFrom(stream);
    //            }
    //        }
    //    }
    //    public Fishes(Stream stream) {
    //        this.LoadFrom(stream);
    //    }
    //    void LoadFrom(Stream stream) {
    //        TextReader input = new StreamReader(stream);
    //        string line;
    //        int id = 0;
    //        while ((line = input.ReadLine()) != null) {
    //            string[] items = line.Split('|');
    //            if (items.Length == 4) {
    //                Fish fishItem = new Fish(items[0], items[1], items[2], items[3], ++id);
    //                this.Add(fishItem);
    //            }
    //        }
    //        input.Close();
    //    }
    //}
    //public class Fish {
    //    private int id;
    //    private string category = "Undefined";
    //    private string commonName = "Undefined";
    //    private string speciesName = "Undefined";
    //    private string notes = "Undefined";

    //    [DisplayName("Fish Category")]
    //    public string Category {
    //        get { return category; }
    //        set { category = value; }
    //    }
    //    [DisplayName("Fish Common Name")]
    //    public string CommonName {
    //        get { return commonName; }
    //        set { commonName = value; }
    //    }
    //    [DisplayName("Fish Species Name")]
    //    public string SpeciesName {
    //        get { return speciesName; }
    //        set { speciesName = value; }
    //    }
    //    [DisplayName("Fish Notes")]
    //    public string Notes {
    //        get { return notes; }
    //        set { notes = value; }
    //    }
    //    [DisplayName("Fish ID")]
    //    public int ID {
    //        get { return id; }
    //        set { id = value; }
    //    }
    //    public Fish(string category, string commonName, string speciesName, string notes, int id) {
    //        this.category = category;
    //        this.commonName = commonName;
    //        this.speciesName = speciesName;
    //        this.notes = notes;
    //        this.id = id;
    //    }
    //}
}
