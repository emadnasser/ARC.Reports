Imports DevExpress.Xpf.DemoBase.Helpers
Imports GridDemo.Controls
Imports System
Imports System.Collections.Generic
Imports System.Data.Linq
Imports System.Reflection
Imports System.Xml
Imports PersonInfo = GridDemo.Controls.Person

Namespace GridDemo
    Public Class PersonGenerator
        Private rnd As New Random()

        Private lastNames As List(Of String) = Dump("LastNames.xml")
        Private firstNames As List(Of String) = Dump("FirstNames.xml")
        Private cities As List(Of String) = Dump("Cities.xml")
        Private streets As List(Of String) = Dump("Streets.xml")

        Private Shared employeeJobTitles() As String = { "Accounting Manager", "Assistant Sales Agent", "Assistant Sales Representative", "Coordinator Foreign Markets", "Export Administrator", "International Marketing Manager", "Marketing Assistant", "Marketing Manager", "Marketing Representative", "Order Administrator", "Product Manager", "Purchasing Agent", "Purchasing Manager", "Regional Account Representative", "Sales Agent", "Sales Associate", "Sales Manager", "Sales Representative" }
        Private Shared ownerJobTitles() As String = { "Owner", "Owner/Marketing Assistant"}
        Private Shared companySuffixes() As String = { "General Partnership", "LP", "LLP", "LLP", "LLLP", "LLC", "PLLC", "Corp.", "Inc.", "PC", "Company", "Limited", "Urban Development", "Finance", "Mobile", "Foundation", "Association", "Bank", "Industries", "Motors", "Electric" }

        Private Shared Function Dump(ByVal fileName As String) As List(Of String)
            Dim result = New List(Of String)()
            Dim assembly As System.Reflection.Assembly = GetType(PersonGenerator).Assembly
            Dim file = assembly.GetManifestResourceStream(DemoHelper.GetPath(assembly.GetName().Name & ".Data.", assembly) & fileName)
            If file IsNot Nothing Then
                Dim reader = New XmlTextReader(file)
                Do While reader.Read()
                    If reader.NodeType = XmlNodeType.Text Then
                        Dim nodeValue As String = reader.Value
                        If Not String.IsNullOrEmpty(nodeValue) Then
                            result.Add(reader.Value)
                        End If
                    End If
                Loop
            End If
            Return result
        End Function


        Public Function CreatePerson() As PersonInfo
            Dim person = New PersonInfo()
            Dim firstName As String = GenerateFirstName()
            Dim lastName As String = GenerateLastName()
            person.FullName = CreateFullName(firstName, lastName)
            Dim companyBaseName As String = GetRandomElement(lastNames)
            Dim companySuffix As String = GetRandomElement(companySuffixes)
            person.Company = CreateCompanyName(companyBaseName, companySuffix)
            person.JobTitle = GenerateJobTitle()
            person.City = GenerateCity()
            person.Address = GenerateAddress()
            person.Phone = GeneratePhone()
            person.Email = CreateEmail(firstName, lastName, companyBaseName)
            Return person
        End Function

        Private Function GenerateFirstName() As String
            Return GetRandomElement(firstNames)
        End Function
        Private Function GenerateLastName() As String
            Return GetRandomElement(lastNames)
        End Function
        Private Function CreateFullName(ByVal firstName As String, ByVal lastName As String) As String
            Return firstName & " " & lastName
        End Function
        Private Function CreateCompanyName(ByVal companyBase As String, ByVal companySuffix As String) As String
            Return companyBase & " " & companySuffix
        End Function
        Private Function GenerateJobTitle() As String
            If rnd.NextDouble() > 0.9 Then
                Return GetRandomElement(ownerJobTitles)
            End If
            Return GetRandomElement(employeeJobTitles)
        End Function
        Private Function GenerateCity() As String
            Return GetRandomElement(cities)
        End Function
        Private Function GenerateAddress() As String
            Return String.Format("{0}, {1}-{2}", GetRandomElement(streets), rnd.Next(1, 99), rnd.Next(10, 999))
        End Function
        Private Function GeneratePhone() As String
            Return String.Format("({0}) {1}-{2}", rnd.Next(100, 999), rnd.Next(100, 999), rnd.Next(1000, 9999))
        End Function
        Private Function CreateEmail(ByVal firstName As String, ByVal lastName As String, ByVal companyBaseName As String) As String
            Return firstName.ToLowerInvariant() & "." & lastName.ToLowerInvariant() & "@" & companyBaseName.ToLowerInvariant() & ".com"
        End Function
        Private Function GetRandomElement(Of T)(ByVal list As IList(Of T)) As T
            Return list(rnd.Next(0, list.Count - 1))
        End Function
    End Class

    Public Class ServerModePeopleDataGenerator
        Inherits ServerModeRecordsGeneratorBase

        Public Sub New(ByVal parentWindow As SQLConnectionWindow, ByVal clearRecords As Boolean)
            MyBase.New(parentWindow, clearRecords)
        End Sub

        Private context As PersonDataContext

        Private personGenerator As New PersonGenerator()

        Protected Overrides ReadOnly Property DataBaseContext() As DataContext
            Get
                Return context
            End Get
        End Property

        Protected Overrides Sub SetupDataContext(ByVal connection As String)
            context = CreateContext(connection)
        End Sub
        Private Function CreateContext(ByVal connection As String) As PersonDataContext
            Return New PersonDataContext(connection)
        End Function

        Protected Overrides Sub AddNewItem()
            context.Person.InsertOnSubmit(personGenerator.CreatePerson())
        End Sub

        Protected Overrides ReadOnly Property TableName() As String
            Get
                Return ServerModeOptions.PersonTableName
            End Get
        End Property

        Protected Overrides Sub CreateTable()
            DataBaseContext.ExecuteCommand(String.Format("" & ControlChars.CrLf & _
"            CREATE TABLE {0}(" & ControlChars.CrLf & _
"            [PersonID] [int] NOT NULL IDENTITY," & ControlChars.CrLf & _
"            [FullName] [nvarchar](max) NULL," & ControlChars.CrLf & _
"            [Company] [nvarchar](max) NULL," & ControlChars.CrLf & _
"            [JobTitle] [nvarchar](max) NULL," & ControlChars.CrLf & _
"            [City] [nvarchar](max) NULL," & ControlChars.CrLf & _
"            [Address] [nvarchar](max) NULL," & ControlChars.CrLf & _
"            [Phone] [nvarchar](max) NULL," & ControlChars.CrLf & _
"            [Email] [nvarchar](max) NULL," & ControlChars.CrLf & _
"            CONSTRAINT {0}_pk PRIMARY KEY (PersonID)" & ControlChars.CrLf & _
"            );" & ControlChars.CrLf & _
"            ", TableName))
        End Sub

        Protected Overrides Sub Clear()
            DataBaseContext.ExecuteCommand("DELETE FROM " & TableName & " WHERE PersonID>=0")
            DataBaseContext.ExecuteCommand(String.Format("DBCC CHECKIDENT('{0}', RESEED, 0)", TableName))
        End Sub
    End Class
    Public Class PeopleGeneratorProvider
        Inherits ServerModeRecordsGeneratorProviderBase

        Public Overrides Function Create(ByVal parentWindow As SQLConnectionWindow, ByVal clearRecords As Boolean) As ServerModeRecordsGeneratorBase
            Return New ServerModePeopleDataGenerator(parentWindow, clearRecords)
        End Function

        Public Overrides Function CalcRecordCount(ByVal serverConnectionString As String) As Integer
            Return CalcRecordCountCore(Function() New PersonDataContext(serverConnectionString), Function(x) x.Person)
        End Function
    End Class
End Namespace
