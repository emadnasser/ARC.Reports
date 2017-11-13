using DevExpress.Web.Demos;

public partial class PivotGridDemoDBDataContextExt : PivotGridDemoDBDataContext {
    static string ConnectionString {
        get { return PivotGridServerModeDataGenerator.Table.ConnectionString; }
    }
    public PivotGridDemoDBDataContextExt() : base(ConnectionString) { }
}
