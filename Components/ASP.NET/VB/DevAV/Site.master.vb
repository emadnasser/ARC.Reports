Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports System.Xml
Imports DevExpress.Web

Partial Public Class SiteMaster
    Inherits System.Web.UI.MasterPage

    Private ReportNames As New Dictionary(Of String, String)()

    Protected ReadOnly Property BasePage() As BasePage
        Get
            Return TryCast(Page, BasePage)
        End Get
    End Property
    Protected ReadOnly Property FilterBag() As FilterBag
        Get
            Return BasePage.FilterBag
        End Get
    End Property

    Protected Sub Page_Init(ByVal sender As Object, ByVal e As EventArgs)
        SetupPage()
        LoadFilterControlColumns()
    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
        SearchBox.Visible = BasePage.HasSearchPanel
        If Not IsPostBack Then
            UpdateFilterControlExpression()
        End If
        LoadFilterNavBarItems()
    End Sub

    Public Sub SetupPage()
        BasePage.Title = BasePage.PageName & " - DevAV Demo | ASP.NET Controls by DevExpress"

        NavigationMenu.Items(0).Image.Url = String.Format("~/Content/Images/LogoMenuIcons/{0}.png", BasePage.PageName)
        Dim contentPane As SplitterPane = Splitter.GetPaneByName("MainContentPane")
        If contentPane IsNot Nothing Then
            contentPane.ScrollBars = If(BasePage.ContentHasScroll, ScrollBars.Auto, ScrollBars.None)
            contentPane.PaneStyle.CssClass = If(BasePage.ContentHasBorder, "mainContentPane frame", "mainContentPane")
        End If
        ReadOnlyPopup.Visible = DemoUtils.IsSiteMode
    End Sub

    Protected Sub MainCallbackPanel_Callback(ByVal sender As Object, ByVal e As CallbackEventArgsBase)
        Dim args = DemoUtils.DeserializeCallbackArgs(e.Parameter)
        If args.Count = 0 Then
            Return
        End If
        If args(0) = "SaveEditForm" Then
            BasePage.SaveEditFormChanges(args(2))
        End If
        If args(0) = "DeleteEntry" Then
            BasePage.DeleteEntry(args(1))
        End If
        If args(0) = "FilterChanged" Then
            FilterBag.FilterControlExpression = args(1)
            UpdateFilterControlExpression()
            MainCallbackPanel.JSProperties("cpSelectedFilterNavBarItemName") = FilterBag.GetActiveFilterName()
            BasePage.OnFilterChanged()
        End If
    End Sub

    Protected Sub UpdateFilterControlExpression()
        FilterControl.FilterExpression = FilterBag.FilterControlExpression
    End Sub

    Protected Sub LoadFilterControlColumns()
        For Each column In BasePage.GetFilterColumns()
            FilterControl.Columns.Add(column)
        Next column
    End Sub

    Protected Sub LoadFilterNavBarItems()
        Dim filterItems = FilterBag.GetFilterItems()
        For Each g In filterItems.GroupBy(Function(p) p.Value.IsCustom)
            Dim groupName = If(g.Key, "Custom", "Favorites")
            Dim group = FilterNavBar.Groups.FindByName(groupName)
            group.Items.Clear()
            For Each pair In g
                Dim filterItem = pair.Value
                Dim item = group.Items.Add(filterItem.Name, pair.Key)
                If FilterBag.GetIsActiveFilter(filterItem.Expression) Then
                    item.Selected = True
                End If
            Next pair
        Next g
        FilterNavBar.JSProperties("cpFilterExpressions") = filterItems.ToDictionary(Function(p) p.Key, Function(p) p.Value.Expression)
    End Sub

    Protected Sub SaveFilterButton_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim filterItem = FilterBag.CreateCustomFilter(CustomFilterTextBox.Text, FilterControl.FilterExpression)
        FilterBag.FilterControlExpression = filterItem.Expression
        UpdateFilterControlExpression()
        FilterPopup.ShowOnPageLoad = False
        LoadFilterNavBarItems()
        BasePage.OnFilterChanged()
    End Sub

    Protected Sub EditMessagePopup_CustomJSProperties(ByVal sender As Object, ByVal e As CustomJSPropertiesEventArgs)
        e.Properties("cpEmployeeEditMessageTemplate") = EmployeeEditMessageTemplate
        e.Properties("cpEditMessageTemplate") = EditMessageTemplate
    End Sub

    Protected ReadOnly Property EmployeeEditMessageTemplate() As String
        Get
            Return "This sample web application does not allow you to <<Operation>> records into the database."
        End Get
    End Property
    Protected ReadOnly Property EditMessageTemplate() As String
        Get
            Return EmployeeEditMessageTemplate & " To see how DevExpress ASP.NET Controls can help you build amazing data entry forms, navigate to the Employees Module."
        End Get
    End Property

    Protected Sub HiddenField_Init(ByVal sender As Object, ByVal e As EventArgs)
        DemoUtils.RegisterStateHiddenField(HiddenField)
    End Sub

    Protected Sub ToolbarMenu_ItemDataBound(ByVal source As Object, ByVal e As MenuItemEventArgs)
        Dim item = e.Item
        Dim itemHierarchyData As IHierarchyData = DirectCast(item.DataItem, IHierarchyData)
        Dim element = CType(itemHierarchyData.Item, XmlElement)

        Dim attr = element.Attributes("BeginGroup")
        If attr IsNot Nothing Then
            e.Item.BeginGroup = attr.Value = "True"
        End If
        attr = element.Attributes("Checked")
        If attr IsNot Nothing Then
            e.Item.Checked = attr.Value = "True"
        End If
        attr = element.Attributes("DropDownMode")
        If attr IsNot Nothing Then
            e.Item.DropDownMode = attr.Value = "True"
        End If
        attr = element.Attributes("UrlDisabled")
        If attr IsNot Nothing Then
            e.Item.Image.UrlDisabled = attr.Value
        End If
        attr = element.Attributes("ReportName")
        If attr IsNot Nothing Then
            ReportNames(e.Item.Name) = attr.Value
        End If
        BasePage.PrepareToolbarItem(e.Item) 'TODO rename
    End Sub
    Protected Sub ToolbarMenu_CustomJSProperties(ByVal sender As Object, ByVal e As CustomJSPropertiesEventArgs)
        e.Properties("cpReportNames") = ReportNames
    End Sub
    Protected Sub PageViewerPopup_CustomJSProperties(ByVal sender As Object, ByVal e As CustomJSPropertiesEventArgs)
        Dim reportTypes = System.Enum.GetValues(GetType(ReportType)).OfType(Of ReportType)()
        e.Properties("cpReportDisplayNames") = reportTypes.ToDictionary(Function(r) r.ToString(), Function(r) DemoUtils.GetReportDisplayName(r))
    End Sub
    Protected Sub ToolbarMenuDataSource_Init(ByVal sender As Object, ByVal e As EventArgs)
        ToolbarMenuDataSource.XPath = String.Format("Pages/{0}/Item", BasePage.PageName)
    End Sub

    Protected Sub CustomFilterTextBox_Load(ByVal sender As Object, ByVal e As EventArgs)
        CustomFilterTextBox.ClientEnabled = SaveCustomFilterCheckBox.Checked
    End Sub
End Class
