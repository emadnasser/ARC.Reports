using System;
using System.Drawing;
using System.IO;
using System.Web.UI;
using DevExpress.Web;
using DevExpress.Web.Demos;
using System.Configuration;

public partial class ASPxFilterControl_FilterExpression : Page {
    protected void Page_Load(object sender, EventArgs e) {
        if(!IsPostBack)
            ASPxFilterControl1.FilterExpression = "[Price] < 500000";

        UpdateDataViewFilterExpression();
    }

    protected void ASPxDataView1_CustomCallback(object sender, CallbackEventArgsBase e) {
        UpdateDataViewFilterExpression();
    }

    protected void ASPxFilterControl1_CustomJSProperties(object sender, CustomJSPropertiesEventArgs e) {
        e.Properties["cpFilterExpression"] = ASPxFilterControl1.GetFilterExpressionForDataSet();
    }

    protected void UpdateDataViewFilterExpression() {
        UpdateDataSourceFilterExpression();
        ASPxDataView1.DataBind();
    }

    protected void UpdateDataSourceFilterExpression() {
        if(ASPxFilterControl1.IsFilterExpressionValid()) {
            string filterExpression = ASPxFilterControl1.GetFilterExpressionForDataSet();
            ASPxLabel1.Text = filterExpression;
            HomesDataSource.FilterExpression = filterExpression;
        } else
            ASPxLabel1.Text = "Filter expression is not valid";
        if(string.IsNullOrEmpty(ASPxLabel1.Text))
            ASPxLabel1.Text = "Filter expression is empty";
    }
}
