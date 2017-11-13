using System;
using System.Web.UI;
using DevExpress.Web;
using DevExpress.Web.Demos;

public partial class ASPxComboBox_LargeDataSource : Page {
    static ASPxComboBox_LargeDataSource() {
        PersonDataGenerator.Register();        
    }

    bool? _databaseReady;
    bool DatabaseReady {
        get { 
            if(!_databaseReady.HasValue)
                _databaseReady = DatabaseGenerator.IsReady(CreateDatabaseControl.TableKey);
            return _databaseReady.Value;
        }
    }

    protected void Page_Init(object sender, EventArgs e) {
        SqlDataSource1.ConnectionString = PersonDataGenerator.Table.ConnectionString;
        CreateDatabaseControl.Visible = !DatabaseReady;
        Demo.Visible = DatabaseReady;
    }

    protected void Page_Load(object sender, EventArgs e) {
        if(DatabaseReady && !IsPostBack)
            ASPxComboBox1.Focus();
    }

    protected void ASPxComboBox_OnItemsRequestedByFilterCondition_SQL(object source, ListEditItemsRequestedByFilterConditionEventArgs e) {
        ASPxComboBox comboBox = (ASPxComboBox)source;
        SqlDataSource1.SelectCommand =
               @"SELECT [ID], [Phone], [FirstName], [LastName] FROM (select [ID], [Phone], [FirstName], [LastName], row_number()over(order by t.[LastName]) as [rn] from [Persons]  as t where (([FirstName] + ' ' + [LastName] + ' ' + [Phone]) LIKE @filter)) as st where st.[rn] between @startIndex and @endIndex";

        SqlDataSource1.SelectParameters.Clear();
        SqlDataSource1.SelectParameters.Add("filter", TypeCode.String, string.Format("%{0}%", e.Filter));
        SqlDataSource1.SelectParameters.Add("startIndex", TypeCode.Int64, (e.BeginIndex + 1).ToString());
        SqlDataSource1.SelectParameters.Add("endIndex", TypeCode.Int64, (e.EndIndex + 1).ToString());
        comboBox.DataSource = SqlDataSource1;
        comboBox.DataBind();
    }

    protected void ASPxComboBox_OnItemRequestedByValue_SQL(object source, ListEditItemRequestedByValueEventArgs e) {
        long value = 0;
        if(e.Value == null || !Int64.TryParse(e.Value.ToString(), out value))
            return;
        ASPxComboBox comboBox = (ASPxComboBox)source;
        SqlDataSource1.SelectCommand = @"SELECT ID, LastName, [Phone], FirstName FROM Persons WHERE (ID = @ID) ORDER BY FirstName";

        SqlDataSource1.SelectParameters.Clear();
        SqlDataSource1.SelectParameters.Add("ID", TypeCode.Int64, e.Value.ToString());
        comboBox.DataSource = SqlDataSource1;
        comboBox.DataBind();
    }

  	protected void FilterMinLengthSpinEdit_ValueChanged(object sender, EventArgs e) {
        ASPxComboBox1.FilterMinLength = (int)((ASPxSpinEdit)sender).Number ;
    }

    string SectionParameter {
        get {
            return Page.Request.QueryString["Section"];
        }
    }
}
