Imports System
Imports System.Collections.Generic
Imports System.Collections.ObjectModel
Imports System.IO
Imports System.Linq
Imports System.Text
Imports System.Xml
Imports System.Xml.Serialization
Imports DevExpress.Data.Filtering
Imports System.Windows.Media
Imports System.Configuration
Imports System.Linq.Expressions
Imports System.ComponentModel
Imports DevExpress.Mvvm

Namespace DevExpress.DevAV.ViewModels
    Public MustInherit Class FilterItemBase
        Protected Sub New()
        End Sub
        Public Overridable Property Name() As String
        Public Overridable Property FilterCriteria() As CriteriaOperator
    End Class
    Public Interface IFilterTreeModelPageSpecificSettings
        ReadOnly Property StaticFiltersTitle() As String
        Property StaticFilters() As FilterInfoList
        Property CustomFilters() As FilterInfoList
        Property GroupFilters() As FilterInfoList
        ReadOnly Property Settings() As ApplicationSettingsBase
        ReadOnly Property HiddenFilterProperties() As IEnumerable(Of String)
        ReadOnly Property AdditionalFilterProperties() As IEnumerable(Of String)
    End Interface

    Public Class FilterTreeModelPageSpecificSettings(Of TSettings As ApplicationSettingsBase)
        Implements IFilterTreeModelPageSpecificSettings


        Private ReadOnly staticFiltersTitle_Renamed As String

        Private ReadOnly settings_Renamed As TSettings
        Private ReadOnly customFiltersProperty As PropertyDescriptor
        Private ReadOnly staticFiltersProperty As PropertyDescriptor
        Private ReadOnly groupFiltersProperty As PropertyDescriptor

        Private ReadOnly hiddenFilterProperties_Renamed As IEnumerable(Of String)

        Private ReadOnly additionalFilterProperties_Renamed As IEnumerable(Of String)

        Public Sub New(ByVal settings As TSettings, ByVal staticFiltersTitle As String, ByVal getStaticFiltersExpression As Expression(Of Func(Of TSettings, FilterInfoList)), ByVal getCustomFiltersExpression As Expression(Of Func(Of TSettings, FilterInfoList)), ByVal getGroupFiltersExpression As Expression(Of Func(Of TSettings, FilterInfoList)), Optional ByVal hiddenFilterProperties As IEnumerable(Of String) = Nothing, Optional ByVal additionalFilterProperties As IEnumerable(Of String) = Nothing)
            Me.settings_Renamed = settings
            Me.staticFiltersTitle_Renamed = staticFiltersTitle
            staticFiltersProperty = GetProperty(getStaticFiltersExpression)
            customFiltersProperty = GetProperty(getCustomFiltersExpression)
            groupFiltersProperty = GetProperty(getGroupFiltersExpression)
            Me.hiddenFilterProperties_Renamed = hiddenFilterProperties
            Me.additionalFilterProperties_Renamed = additionalFilterProperties
        End Sub
        Private Property IFilterTreeModelPageSpecificSettings_CustomFilters() As FilterInfoList Implements IFilterTreeModelPageSpecificSettings.CustomFilters
            Get
                Return GetFilters(customFiltersProperty)
            End Get
            Set(ByVal value As FilterInfoList)
                SetFilters(customFiltersProperty, value)
            End Set
        End Property
        Private Property IFilterTreeModelPageSpecificSettings_StaticFilters() As FilterInfoList Implements IFilterTreeModelPageSpecificSettings.StaticFilters
            Get
                Return GetFilters(staticFiltersProperty)
            End Get
            Set(ByVal value As FilterInfoList)
                SetFilters(staticFiltersProperty, value)
            End Set
        End Property
        Private Property IFilterTreeModelPageSpecificSettings_GroupFilters() As FilterInfoList Implements IFilterTreeModelPageSpecificSettings.GroupFilters
            Get
                Return GetFilters(groupFiltersProperty)
            End Get
            Set(ByVal value As FilterInfoList)
                SetFilters(groupFiltersProperty, value)
            End Set
        End Property
        Private ReadOnly Property IFilterTreeModelPageSpecificSettings_Settings() As ApplicationSettingsBase Implements IFilterTreeModelPageSpecificSettings.Settings
            Get
                Return settings_Renamed
            End Get
        End Property
        Private ReadOnly Property IFilterTreeModelPageSpecificSettings_StaticFiltersTitle() As String Implements IFilterTreeModelPageSpecificSettings.StaticFiltersTitle
            Get
                Return staticFiltersTitle_Renamed
            End Get
        End Property
        Private ReadOnly Property IFilterTreeModelPageSpecificSettings_HiddenFilterProperties() As IEnumerable(Of String) Implements IFilterTreeModelPageSpecificSettings.HiddenFilterProperties
            Get
                Return hiddenFilterProperties_Renamed
            End Get
        End Property
        Private ReadOnly Property IFilterTreeModelPageSpecificSettings_AdditionalFilterProperties() As IEnumerable(Of String) Implements IFilterTreeModelPageSpecificSettings.AdditionalFilterProperties
            Get
                Return additionalFilterProperties_Renamed
            End Get
        End Property

        Private Function GetProperty(ByVal expression As Expression(Of Func(Of TSettings, FilterInfoList))) As PropertyDescriptor
            If expression IsNot Nothing Then
                Return TypeDescriptor.GetProperties(settings_Renamed)(GetPropertyName(expression))
            End If
            Return Nothing
        End Function
        Private Function GetFilters(ByVal [property] As PropertyDescriptor) As FilterInfoList
            Return If([property] IsNot Nothing, DirectCast([property].GetValue(settings_Renamed), FilterInfoList), Nothing)
        End Function
        Private Sub SetFilters(ByVal [property] As PropertyDescriptor, ByVal value As FilterInfoList)
            If [property] IsNot Nothing Then
                [property].SetValue(settings_Renamed, value)
            End If
        End Sub
        Private Shared Function GetPropertyName(ByVal expression As Expression(Of Func(Of TSettings, FilterInfoList))) As String
            Dim memberExpression As MemberExpression = TryCast(expression.Body, MemberExpression)
            If memberExpression Is Nothing Then
                Throw New ArgumentException("expression")
            End If
            Return memberExpression.Member.Name
        End Function
    End Class

    Public Class FilterInfo
        Public Property Name() As String
        Public Property FilterCriteria() As String
        Public Property ImageUri() As String
    End Class
    Public Class FilterInfoList
        Inherits List(Of FilterInfo)

        Public Sub New()
        End Sub
        Public Sub New(ByVal filters As IEnumerable(Of FilterInfo))
            MyBase.New(filters)
        End Sub
    End Class
    Public MustInherit Class FilterTreeViewModelBase
        Shared Sub New()
            Dim enums = GetType(EmployeeStatus).Assembly.GetTypes().Where(Function(t) t.IsEnum)
            For Each e As Type In enums
                EnumProcessingHelper.RegisterEnum(e)
            Next e
        End Sub
        Protected settings As IFilterTreeModelPageSpecificSettings
        Public Sub New(ByVal settings As IFilterTreeModelPageSpecificSettings)
            Me.settings = settings
        End Sub
        Public Overridable Sub Init()
            StaticFilters = CreateFilterItems(settings.StaticFilters)
            CustomFilters = CreateFilterItems(settings.CustomFilters)
            SelectedItem = StaticFilters.FirstOrDefault()
        End Sub

        Public Overridable Property StaticFilters() As ObservableCollection(Of FilterItemBase)
        Public Overridable Property CustomFilters() As ObservableCollection(Of FilterItemBase)
        Public Overridable Property SelectedItem() As FilterItemBase

        Protected Sub AddNewCustomFilter(ByVal filterItem As FilterItemBase)
            Dim existing = CustomFilters.FirstOrDefault(Function(fi) fi.Name = filterItem.Name)
            If existing IsNot Nothing Then
                CustomFilters.Remove(existing)
            End If
            CustomFilters.Add(filterItem)
            SaveCustomFilters()
        End Sub

        Public Overridable Sub DeleteCustomFilter(ByVal filterItem As FilterItemBase)
            CustomFilters.Remove(filterItem)
            SaveCustomFilters()
        End Sub

        Public Overridable Sub DuplicateFilter(ByVal filterItem As FilterItemBase)
            Dim newItem = CreateFilterItem("Copy of " & filterItem.Name, filterItem.FilterCriteria, Nothing)
            CustomFilters.Add(newItem)
            SaveCustomFilters()
        End Sub
        Public Overridable Sub ResetCustomFilters()
            If CustomFilters.Contains(SelectedItem) Then
                SelectedItem = Nothing
            End If
            settings.CustomFilters = New FilterInfoList()
            CustomFilters.Clear()
            settings.Settings.Save()
        End Sub

        Protected Function CreateFilterItems(ByVal filters As IEnumerable(Of FilterInfo)) As ObservableCollection(Of FilterItemBase)
            If filters Is Nothing Then
                Return New ObservableCollection(Of FilterItemBase)()
            End If
            Return New ObservableCollection(Of FilterItemBase)(filters.Select(Function(x) CreateFilterItem(x.Name, CriteriaOperator.Parse(x.FilterCriteria), x.ImageUri)))
        End Function

        Protected MustOverride Function CreateFilterItem(ByVal name As String, ByVal filterCriteria As CriteriaOperator, ByVal imageUri As String) As FilterItemBase

        Protected Sub SaveCustomFilters()
            settings.CustomFilters = SaveToSettings(CustomFilters)
            settings.Settings.Save()
        End Sub
        Protected Function SaveToSettings(ByVal filters As ObservableCollection(Of FilterItemBase)) As FilterInfoList
            Return New FilterInfoList(filters.Select(Function(fi) New FilterInfo With {.Name = fi.Name, .FilterCriteria = CriteriaOperator.ToString(fi.FilterCriteria)}))
        End Function
        Private privateViewModel As Object
        Protected Property ViewModel() As Object
            Get
                Return privateViewModel
            End Get
            Private Set(ByVal value As Object)
                privateViewModel = value
            End Set
        End Property
        Public Overridable Sub SetViewModel(ByVal viewModel As Object)
            Me.ViewModel = viewModel
        End Sub
    End Class
End Namespace
