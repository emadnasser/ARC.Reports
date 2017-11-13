<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AdaptiveLayoutPage.aspx.cs" Inherits="Panel_AdaptiveLayoutPage" %>
<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta name="viewport" content="width=device-width, user-scalable=no, maximum-scale=1.0, minimum-scale=1.0" />
    <title>Adaptive Layout - ASP.NET GridView Control</title>
    <%--start highlighted block--%>
    <style>
        body, form
        {
            padding: 0;
            margin: 0;
            overflow: hidden;
            min-height: 200px;
            min-width: 400px;
        }
    </style>
    <script type="text/javascript">
        function UpdateGridHeight(){
            sampleGrid.SetHeight(0);
            var containerHeight = ASPxClientUtils.GetDocumentClientHeight();
            if(document.body.scrollHeight > containerHeight)
                containerHeight = document.body.scrollHeight;
            sampleGrid.SetHeight(containerHeight);
        }
    </script>
    <%--end highlighted block--%>
</head>
<body>
    <form id="form1" runat="server">
        <dx:ASPxGridView runat="server" Width="100%" ID="ASPxGridView1" ClientInstanceName="sampleGrid"
            AutoGenerateColumns="False" DataSourceID="DemoDataSource1" KeyFieldName="ProductID" EnableRowsCache="false">
            <Settings VerticalScrollBarMode="Visible" VerticalScrollableHeight="500" />
            <SettingsAdaptivity AdaptivityMode="HideDataCellsWindowLimit" HideDataCellsAtWindowInnerWidth="800" AllowOnlyOneAdaptiveDetailExpanded="true" AdaptiveDetailColumnCount="2"></SettingsAdaptivity>
            <EditFormLayoutProperties>
                <SettingsAdaptivity AdaptivityMode="SingleColumnWindowLimit" SwitchToSingleColumnAtWindowInnerWidth="600" />
            </EditFormLayoutProperties>
            <SettingsEditing Mode="EditForm"></SettingsEditing>
            <Columns>
                <dx:GridViewCommandColumn ShowNewButtonInHeader="true" ShowDeleteButton="True" ShowEditButton="true" Width="100px" />
                <dx:GridViewDataTextColumn FieldName="ProductName">
                </dx:GridViewDataTextColumn>
                <dx:GridViewDataComboBoxColumn FieldName="CategoryID" Caption="Category Name" AdaptivePriority="1">
                    <PropertiesComboBox DataSourceID="CategoriesDataSource" ValueType="System.Int32" ValueField="CategoryID" TextField="CategoryName" />
                </dx:GridViewDataComboBoxColumn>
                <dx:GridViewDataTextColumn FieldName="QuantityPerUnit" AdaptivePriority="1" />
                <dx:GridViewDataSpinEditColumn FieldName="UnitPrice" Width="100px">
                    <PropertiesSpinEdit DisplayFormatString="c" DisplayFormatInEditMode="true" MinValue="0" MaxValue="60000">
                        <ValidationSettings Display="Dynamic" RequiredField-IsRequired="true" />
                    </PropertiesSpinEdit>
                </dx:GridViewDataSpinEditColumn>
                <dx:GridViewDataSpinEditColumn FieldName="UnitsInStock" Width="100px">
                    <PropertiesSpinEdit MinValue="0" MaxValue="10000" />
                </dx:GridViewDataSpinEditColumn>
                <dx:GridViewDataCheckColumn FieldName="Discontinued" Width="100px" AdaptivePriority="2">
                    <PropertiesCheckEdit AllowGrayed="true" AllowGrayedByClick="false" />
                </dx:GridViewDataCheckColumn>
            </Columns>
            <settingspager pagesize="30" numericbuttoncount="6" />
            <Styles>
                <Cell Wrap="False"></Cell>
            </Styles>
        </dx:ASPxGridView>
        <%--start highlighted block--%>
        <script type="text/javascript">
            ASPxClientControl.GetControlCollection().ControlsInitialized.AddHandler(function(s,e){
                UpdateGridHeight();
            });
            ASPxClientControl.GetControlCollection().BrowserWindowResized.AddHandler(function(s,e){
                UpdateGridHeight();
            });
            ASPxClientControl.GetControlCollection().EndCallback.AddHandler(function(s,e){
                UpdateGridHeight();
            });
        </script>
        <%--end highlighted block--%>
        <demo:DemoDataSource runat="server" ID="DemoDataSource1" IdentityKey="ProductID" DataSourceID="ProductsDataSource" IsSiteMode="True"></demo:DemoDataSource>
        <ef:EntityDataSource runat="server" ID="ProductsDataSource"
            ContextTypeName="NorthwindContext"
            EnableDelete="True" EnableInsert="True" EnableUpdate="True"
            EntitySetName="Products">
        </ef:EntityDataSource>
        <ef:EntityDataSource runat="server" ID="CategoriesDataSource" ContextTypeName="NorthwindContext" EntitySetName="Categories"></ef:EntityDataSource>
    </form>
</body>
</html>
