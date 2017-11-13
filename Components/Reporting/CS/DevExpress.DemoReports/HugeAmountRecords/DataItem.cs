using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XtraReportsDemos.HugeAmountRecords {
    public class DataItem {
        public static IList<DataItem> CreateItems(int rowCount) {
            DataItem[] items = new DataItem[rowCount];
            Random random = new Random();
            DateTime time = DateTime.Now;
            for(int i = 0; i < rowCount; i++)
                items[i] = new DataItem() {
                    ColumnID = i + 1,
                    ColumnText = "Text " + (i % 100 + 1),
                    ColumnBool = (random.Next(1000) % 2 == 1),
                    ColumnDate = time.AddDays(random.Next(100)),
                    ColumnCurrency = Math.Round(random.NextDouble() * 10000000.0) / 1000
                };
            return items;
        }
        public int ColumnID { get; set; }
        public string ColumnText { get; set; }
        public bool ColumnBool { get; set; }
        public DateTime ColumnDate { get; set; }
        public double ColumnCurrency { get; set; }
    }
}
