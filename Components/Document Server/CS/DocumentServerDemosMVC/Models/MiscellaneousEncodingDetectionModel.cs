using System.Collections.Generic;
namespace DevExpress.Web.Demos {
    public class MiscellaneousEncodingDetectionModel {
        public const string DefaultFileName = "english.txt";
        public MiscellaneousEncodingDetectionModel() {
            DefaultFileNames = CreateDefaultNames();

        }
                
        public string TextWithoutEncodingDetection { get; set; }
        public string TextWithEncodingDetection { get; set; }
        public string ActiveFileName { get; set; }
        public string ActivePredefinedFileName { get; set; }
        public List<string> DefaultFileNames { get; private set; }
        public string EncodingName { get; set; }

        List<string> CreateDefaultNames() {
            List<string> result = new List<string>();
            result.Add(DefaultFileName);
            result.Add("german.txt");
            result.Add("spanish.txt");
            result.Add("russian.txt");
            result.Add("greek.txt");
            result.Add("chinese.txt");
            result.Add("japanese.txt");
            return result;
        }        
    }
}
