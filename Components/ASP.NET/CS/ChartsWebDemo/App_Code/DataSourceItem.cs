using System.Collections.Generic;

public class DataSourceItem {
    public static List<DataSourceItem> GetDataSource() {
        var list = new List<DataSourceItem>();
        list.Add(new DataSourceItem("A", 20, 5, 8));
        list.Add(new DataSourceItem("B", 50, 3, 5));
        list.Add(new DataSourceItem("C", 40, 20, 10));
        list.Add(new DataSourceItem("D", 22, 15, 5));
        list.Add(new DataSourceItem("E", 30, 5, 8));
        list.Add(new DataSourceItem("F", 45, 5, 4));
        list.Add(new DataSourceItem("G", 35, 5, 3));
        list.Add(new DataSourceItem("H", 28, 4, 2));
        list.Add(new DataSourceItem("I", 46, 6, 4));
        list.Add(new DataSourceItem("J", 27, 8, 20));
        list.Add(new DataSourceItem("K", 20, 5, 8));
        list.Add(new DataSourceItem("L", 50, 3, 5));
        list.Add(new DataSourceItem("M", 40, 20, 10));
        list.Add(new DataSourceItem("N", 22, 15, 5));
        list.Add(new DataSourceItem("O", 30, 5, 8));
        list.Add(new DataSourceItem("P", 45, 5, 2));
        list.Add(new DataSourceItem("Q", 35, 5, 5));
        list.Add(new DataSourceItem("R", 28, 4, 4));
        list.Add(new DataSourceItem("S", 46, 6, 5));
        list.Add(new DataSourceItem("T", 27, 8, 8));
        return list;
    }

    public string Argument { get; private set; }
    public double Value { get; private set; }
    public double PositiveError { get; private set; }
    public double NegativeError { get; private set; }

    public DataSourceItem(string argument, double value, double positiveError, double negativeError) {
        Argument = argument;
        Value = value;
        PositiveError = positiveError;
        NegativeError = negativeError;
    }
}
