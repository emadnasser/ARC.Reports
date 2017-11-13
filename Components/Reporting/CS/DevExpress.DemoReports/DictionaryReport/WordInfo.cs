namespace XtraReportsDemos.DictionaryReport {
    public class WordInfo {
        readonly string word;

        public string Word { get { return word; } }
        public string FirstLetter { get { return Word[0].ToString().ToUpperInvariant(); } }

        public WordInfo(string word) {
            this.word = word;
        }
    }
}
