Imports System
Imports System.Collections.Generic
Imports DevExpress.XtraRichEdit.API.Native
Imports RichEditDemo.Controls
Imports DevExpress.Xpf.Core

Namespace RichEditDemo
    Partial Public Class SimpleDataMerge
        Inherits RichEditDemoModule

        Private employees As List(Of Employee)
        Private mergeFieldsNamesInfo() As MergeFieldNameInfo

        Public Sub New()
            InitializeComponent()
            ribbon.SelectedPage = pageMailings
            RtfLoadHelper.Load("MailMergeSimple.rtf", richEdit)
        End Sub

        Private Sub richEdit_Loaded(ByVal sender As Object, ByVal e As System.Windows.RoutedEventArgs)
            richEdit.ApplyTemplate()

            Me.employees = GenerateEmployeeList()
            Me.mergeFieldsNamesInfo = CreateMergeFieldsNamesInfo()
            richEdit.Options.MailMerge.DataSource = employees
            richEdit.Options.MailMerge.ViewMergedData = True
        End Sub


        #Region "Employee list generation"
        Private Shared firstName() As String = { "Nancy", "Andrew", "Janet", "Margaret", "Steven", "Michael", "Robert", "Laura", "Anne" }
        Private Shared lastName() As String = { "Davolio", "Fuller", "Leverling", "Peacock", "Buchanan", "Suyama", "King", "Callahan", "Dodsworth" }
        Private Shared city() As String = { "Seattle", "Tacoma", "Kirkland", "Redmond", "London", "London", "London", "Seattle", "London" }
        Private Shared country() As String = { "USA", "USA", "USA", "USA", "UK", "UK", "UK", "USA", "UK" }
        Private Shared address() As String = { "507 - 20th Ave. E. Apt. 2A", "908 W. Capital Way", "722 Moss Bay Blvd.", "4110 Old Redmond Rd.", "14 Garrett Hill", "Coventry House Miner Rd.", "Edgeham Hollow Winchester Way", "4726 - 11th Ave. N.E.", "7 Houndstooth Rd." }
        Private Shared position() As String = { "Sales Representative", "Vice President, Sales", "Sales Representative", "Sales Representative", "Sales Manager", "Sales Representative", "Sales Representative", "Inside Sales Coordinator", "Sales Representative" }
        Private Shared gender() As Char = { "F"c, "M"c, "F"c, "F"c, "M"c, "M"c, "M"c, "F"c, "F"c }
        Private Shared phone() As String = { "(206) 555-9857", "(206) 555-9482", "(206) 555-3412", "(206) 555-8122", "(71) 555-4848", "(71) 555-7773", "(71) 555-5598", "(206) 555-1189", "(71) 555-4444" }
        Private Shared companyName() As String = { "Consolidated Holdings", "Around the Horn", "North/South", "Island Trading", "White Clover Markets", "Trail's Head Gourmet Provisioners", "The Cracker Box", "The Big Cheese", "Rattlesnake Canyon Grocery", "Split Rail Beer & Ale", "Hungry Coyote Import Store", "Great Lakes Food Market" }
        Private Function GenerateEmployeeList() As List(Of Employee)
            Dim employees As New List(Of Employee)()
            For i As Integer = 0 To 9
                employees.Add(CreateEmployee(i))
            Next i
            Return employees
        End Function
        Private Function CreateEmployee(ByVal seed As Integer) As Employee
            Dim result As New Employee()
            Dim rnd As New Random(seed)
            Dim countryIndex As Integer = rnd.Next(0, country.Length)
            result.Country = country(countryIndex)
            result.Address = address(countryIndex)
            result.City = city(countryIndex)
            result.LastName = lastName(rnd.Next(0, lastName.Length))
            Dim firstNameIndex As Integer = rnd.Next(0, firstName.Length)
            result.FirstName = firstName(firstNameIndex)
            result.Gender = gender(firstNameIndex)
            result.HiringDate = Date.Now.AddDays(-(rnd.Next(0, 2000)))
            result.Position = position(rnd.Next(0, position.Length))
            result.Phone = phone(rnd.Next(0, phone.Length))
            result.CompanyName = companyName(rnd.Next(0, companyName.Length))
            result.HRManagerName = String.Format("{0} {1}", firstName(rnd.Next(0, firstName.Length)), lastName(rnd.Next(0, lastName.Length)))
            Return result
        End Function
        #End Region
        #Region "Merge field name list generation"
        Protected Friend Overridable Function CreateMergeFieldsNamesInfo() As MergeFieldNameInfo()
            Dim result As New List(Of MergeFieldNameInfo)()
            result.Add(CreateMergeFieldNameInfo("FirstName"))
            result.Add(CreateMergeFieldNameInfo("LastName"))
            result.Add(CreateMergeFieldNameInfo("HiringDate"))
            result.Add(CreateMergeFieldNameInfo("Address"))
            result.Add(CreateMergeFieldNameInfo("City"))
            result.Add(CreateMergeFieldNameInfo("Country"))
            result.Add(CreateMergeFieldNameInfo("Position"))
            result.Add(CreateMergeFieldNameInfo("CompanyName"))
            result.Add(CreateMergeFieldNameInfo("Gender"))
            result.Add(CreateMergeFieldNameInfo("Phone"))
            result.Add(CreateMergeFieldNameInfo("HRManagerName"))

            Return result.ToArray()
        End Function
        Private Function CreateMergeFieldNameInfo(ByVal fieldName As String) As MergeFieldNameInfo
            Dim displayName As String = CreateDisplayName(fieldName)
            Return New MergeFieldNameInfo(New MergeFieldName(fieldName, displayName))
        End Function
        Private Function CreateDisplayName(ByVal fieldName As String) As String
            fieldName = fieldName.Replace("_"c, " "c)
            fieldName = fieldName.Replace("."c, " "c)

            Dim prevChar As Char = " "c
            Dim count As Integer = fieldName.Length
            Dim sb As New System.Text.StringBuilder(count)
            For i As Integer = 0 To count - 1
                Dim ch As Char = fieldName.Chars(i)
                If Char.IsLower(prevChar) AndAlso Char.IsUpper(ch) Then
                    sb.Append(" "c)
                End If
                sb.Append(ch)
                prevChar = ch
            Next i
            Return sb.ToString()
        End Function
        #End Region

        Private Sub richEdit_CustomizeMergeFields(ByVal sender As Object, ByVal e As DevExpress.XtraRichEdit.CustomizeMergeFieldsEventArgs)
            e.MergeFieldsNames = CalculateAllowedFieldsNames()
        End Sub
        Private Function CalculateAllowedFieldsNames() As MergeFieldName()
            Dim result As New List(Of MergeFieldName)()
            For Each fieldNameInfo As MergeFieldNameInfo In mergeFieldsNamesInfo
                If fieldNameInfo.CanShow Then
                    Dim fieldName As MergeFieldName = fieldNameInfo.FieldName
                    Dim displayName As String = String.Format("{0} ({1})", fieldName.DisplayName, fieldName.Name)
                    result.Add(New MergeFieldName(fieldName.Name, displayName))
                End If
            Next fieldNameInfo
            Return result.ToArray()
        End Function
        Private Sub OnCustomizeMergeFields(ByVal sender As Object, ByVal e As DevExpress.Xpf.Bars.ItemClickEventArgs)
            Dim control As New CustomizeMergeFieldsControl(mergeFieldsNamesInfo)

            Dim parameters As New FloatingContainerParameters()
            parameters.Title = "Customize merge fields"
            parameters.CloseOnEscape = True
            parameters.AllowSizing = True

            FloatingContainer.ShowDialogContent(control, Me, System.Windows.Size.Empty, parameters, True)
        End Sub
    End Class

    Public Class Employee

        Private firstName_Renamed As String

        Private lastName_Renamed As String

        Private hiringDate_Renamed As Date

        Private address_Renamed As String

        Private city_Renamed As String

        Private country_Renamed As String

        Private position_Renamed As String

        Private companyName_Renamed As String

        Private gender_Renamed As Char

        Private phone_Renamed As String

        Private hrManagerName_Renamed As String

        Public Property FirstName() As String
            Get
                Return firstName_Renamed
            End Get
            Set(ByVal value As String)
                firstName_Renamed = value
            End Set
        End Property
        Public Property LastName() As String
            Get
                Return lastName_Renamed
            End Get
            Set(ByVal value As String)
                lastName_Renamed = value
            End Set
        End Property
        Public Property HiringDate() As Date
            Get
                Return hiringDate_Renamed
            End Get
            Set(ByVal value As Date)
                hiringDate_Renamed = value
            End Set
        End Property
        Public Property Address() As String
            Get
                Return address_Renamed
            End Get
            Set(ByVal value As String)
                address_Renamed = value
            End Set
        End Property
        Public Property City() As String
            Get
                Return city_Renamed
            End Get
            Set(ByVal value As String)
                city_Renamed = value
            End Set
        End Property
        Public Property Country() As String
            Get
                Return country_Renamed
            End Get
            Set(ByVal value As String)
                country_Renamed = value
            End Set
        End Property
        Public Property Position() As String
            Get
                Return position_Renamed
            End Get
            Set(ByVal value As String)
                position_Renamed = value
            End Set
        End Property
        Public Property CompanyName() As String
            Get
                Return companyName_Renamed
            End Get
            Set(ByVal value As String)
                companyName_Renamed = value
            End Set
        End Property
        Public Property Gender() As Char
            Get
                Return gender_Renamed
            End Get
            Set(ByVal value As Char)
                gender_Renamed = value
            End Set
        End Property
        Public Property Phone() As String
            Get
                Return phone_Renamed
            End Get
            Set(ByVal value As String)
                phone_Renamed = value
            End Set
        End Property
        Public Property HRManagerName() As String
            Get
                Return hrManagerName_Renamed
            End Get
            Set(ByVal value As String)
                hrManagerName_Renamed = value
            End Set
        End Property
    End Class
    Public Class MergeFieldNameInfo
        #Region "Fields"

        Private fieldName_Renamed As MergeFieldName

        Private canShow_Renamed As Boolean
        #End Region

        Public Sub New(ByVal fieldName As MergeFieldName)
            Me.fieldName_Renamed = fieldName
            Me.canShow_Renamed = True
        End Sub

        #Region "Properties"
        Public ReadOnly Property FieldName() As MergeFieldName
            Get
                Return fieldName_Renamed
            End Get
        End Property
        Public Property CanShow() As Boolean
            Get
                Return canShow_Renamed
            End Get
            Set(ByVal value As Boolean)
                canShow_Renamed = value
            End Set
        End Property
        #End Region
    End Class
End Namespace
