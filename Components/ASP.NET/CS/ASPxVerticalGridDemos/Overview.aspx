<%@ Page Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Overview.aspx.cs" Inherits="Overview"%>
<asp:Content ID="Content" ContentPlaceHolderID="OverviewDemoContentHolder" runat="Server">
    
    <dx:ASPxVerticalGrid ID="VerticalGrid" runat="server" DataSourceID="EmployeesDataSource" EnableRecordsCache="false" >
        <Rows>
            <dx:VerticalGridBinaryImageRow FieldName="Photo" RecordStyle-HorizontalAlign="Center">
                <PropertiesBinaryImage ImageHeight="170" />
            </dx:VerticalGridBinaryImageRow>
            
            <dx:VerticalGridDataRow Caption="Name" FieldName="PersonalInfo" UnboundType="String" UnboundExpression="[TitleOfCourtesy] + ' ' + [FirstName] + ' ' + [LastName]">
                <Rows>
                    <dx:VerticalGridDataRow FieldName="FirstName" />
                    <dx:VerticalGridDataRow FieldName="LastName" />
                    <dx:VerticalGridDataRow FieldName="BirthDate" />
                    <dx:VerticalGridDataRow FieldName="HireDate" />
                </Rows>
            </dx:VerticalGridDataRow>
            <dx:VerticalGridCategoryRow Caption="Address">
                <Rows>
                    <dx:VerticalGridDataRow FieldName="Address" />
                    <dx:VerticalGridDataRow FieldName="City" />
                    <dx:VerticalGridDataRow FieldName="Country" />
                </Rows>
            </dx:VerticalGridCategoryRow>
            <dx:VerticalGridCategoryRow Caption="Phone">
                <Rows>
                    <dx:VerticalGridDataRow FieldName="HomePhone" />
                    <dx:VerticalGridDataRow FieldName="Extension" />
                </Rows>
            </dx:VerticalGridCategoryRow>
        </Rows>
    </dx:ASPxVerticalGrid>
    <ef:EntityDataSource runat="server" ID="EmployeesDataSource" ContextTypeName="NorthwindContext" EntitySetName="Employees" 
        Select="top(2) it.Photo, it.FirstName, it.LastName, it.TitleOfCourtesy, it.BirthDate, it.HireDate, it.Address, it.City, it.Country, it.HomePhone, it.Extension" />
</asp:Content>
