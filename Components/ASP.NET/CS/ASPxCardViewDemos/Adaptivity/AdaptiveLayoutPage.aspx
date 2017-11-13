<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AdaptiveLayoutPage.aspx.cs" Inherits="Panel_AdaptiveLayoutPage" %>
<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta name="viewport" content="width=device-width, user-scalable=no, maximum-scale=1.0, minimum-scale=1.0" />
    <title>Adaptive Layout - ASP.NET CardView Control</title>
    <style>
        body, form
        {
            padding: 0;
            margin: 0;
            overflow: hidden;
            min-height: 200px;
            min-width: 400px;
        }
        @media all and (max-width: 600px) {
            .FlowCard {
                width: 225px !important;
                height: 650px !important;
            }
        }
    </style>
    <script type="text/javascript">
        function UpdateCardViewHeight(){
            cardView.SetHeight(0);
            var containerHeight = ASPxClientUtils.GetDocumentClientHeight();
            if(document.body.scrollHeight > containerHeight)
                containerHeight = document.body.scrollHeight;
            cardView.SetHeight(containerHeight);
        }
    </script>
</head>
<body>
    <form id="form1" runat="server">
        <dx:ASPxCardView ID="CardView" runat="server" DataSourceID="EmployeesDataSource" Width="100%" ClientInstanceName="cardView" EnableCardsCache="false">
            <Columns>
                <dx:CardViewBinaryImageColumn FieldName="Photo" />
                <dx:CardViewTextColumn FieldName="FullName" Caption="Name" UnboundType="String" UnboundExpression="Concat([FirstName], ' ', [LastName])" />
                <dx:CardViewTextColumn FieldName="Title" />
                <dx:CardViewDateColumn FieldName="HireDate" />
                <dx:CardViewTextColumn FieldName="FullAddress" Caption="Address" UnboundType="String" UnboundExpression="Concat([Address], ', ', [City], ', ', [Country])" />
                <dx:CardViewTextColumn FieldName="HomePhone" />
            </Columns>
            <CardLayoutProperties ColCount="2">
                <Items>
                    <dx:CardViewColumnLayoutItem ColumnName="Photo" ShowCaption="False" HorizontalAlign="Center" VerticalAlign="Middle" Width="40%" />
                    <dx:CardViewLayoutGroup ShowCaption="False" GroupBoxDecoration="None" Width="60%">
                        <Items>
                            <dx:CardViewColumnLayoutItem ColumnName="FullName" />
                            <dx:CardViewColumnLayoutItem ColumnName="Title" />
                            <dx:CardViewColumnLayoutItem ColumnName="HireDate" />
                            <dx:CardViewColumnLayoutItem ColumnName="FullAddress" />
                            <dx:CardViewColumnLayoutItem ColumnName="HomePhone" />
                        </Items>
                    </dx:CardViewLayoutGroup>
                </Items>
                <SettingsAdaptivity AdaptivityMode="SingleColumnWindowLimit" SwitchToSingleColumnAtWindowInnerWidth="600" />
            </CardLayoutProperties>
            <Settings LayoutMode="Flow" VerticalScrollBarMode="Auto" />
            <Styles>
                <FlowCard Width="530" Height="300" CssClass="FlowCard" />
            </Styles>
        </dx:ASPxCardView>
        <ef:EntityDataSource runat="server" ID="EmployeesDataSource" ContextTypeName="NorthwindContext" EntitySetName="Employees"/>
        <script type="text/javascript">
        // <![CDATA[
            ASPxClientControl.GetControlCollection().ControlsInitialized.AddHandler(function(s,e){
                UpdateCardViewHeight();
            });
            ASPxClientControl.GetControlCollection().BrowserWindowResized.AddHandler(function(s,e){
                UpdateCardViewHeight();
            });
        // ]]> 
        </script>
    </form>
</body>
</html>
