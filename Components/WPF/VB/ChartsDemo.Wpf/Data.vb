Imports System
Imports System.Collections
Imports System.Collections.Generic
Imports System.Data
Imports System.Globalization
Imports System.IO
Imports System.Linq
Imports System.Windows
Imports System.Windows.Media
Imports System.Windows.Media.Imaging
Imports System.Xml.Linq

Namespace ChartsDemo

    Public Class DevAVSalesMixByRegion
        Public ReadOnly Property Data() As DataTable
            Get
                Return GetData()
            End Get
        End Property

        Public Function GetData() As DataTable
            Dim table As New DataTable()
            table.Columns.AddRange(New DataColumn() {
                New DataColumn("ProductCategory", GetType(String)),
                New DataColumn("Region", GetType(String)),
                New DataColumn("Sales", GetType(Decimal))
            })

            table.Rows.Add("Video players", "Asia", 853D)
            table.Rows.Add("Video players", "Australia", 321D)
            table.Rows.Add("Video players", "Europe", 655D)
            table.Rows.Add("Video players", "North America", 1325D)
            table.Rows.Add("Video players", "South America", 653D)

            table.Rows.Add("Automation", "Asia", 172D)
            table.Rows.Add("Automation", "Australia", 255D)
            table.Rows.Add("Automation", "Europe", 981D)
            table.Rows.Add("Automation", "North America", 963D)
            table.Rows.Add("Automation", "South America", 123D)

            table.Rows.Add("Monitors", "Asia", 1011D)
            table.Rows.Add("Monitors", "Australia", 359D)
            table.Rows.Add("Monitors", "Europe", 721D)
            table.Rows.Add("Monitors", "North America", 565D)
            table.Rows.Add("Monitors", "South America", 532D)

            table.Rows.Add("Projectors", "Asia", 998D)
            table.Rows.Add("Projectors", "Australia", 222D)
            table.Rows.Add("Projectors", "Europe", 865D)
            table.Rows.Add("Projectors", "North America", 787D)
            table.Rows.Add("Projectors", "South America", 332D)

            table.Rows.Add("Televisions", "Asia", 1356D)
            table.Rows.Add("Televisions", "Australia", 232D)
            table.Rows.Add("Televisions", "Europe", 1323D)
            table.Rows.Add("Televisions", "North America", 1125D)
            table.Rows.Add("Televisions", "South America", 865D)

            Return table
        End Function
    End Class

    Public Class DevAVSalesInNorthAmerica
        Public ReadOnly Property Data() As DataTable
            Get
                Return GetData()
            End Get
        End Property

        Public Function GetData() As DataTable
            Dim table As New DataTable()
            table.Columns.AddRange(New DataColumn() {
                New DataColumn("ProductCategory", GetType(String)),
                New DataColumn("Sales", GetType(Decimal))
            })
            table.Rows.Add("Video players", 1325D)
            table.Rows.Add("Automation", 963D)
            table.Rows.Add("Monitors", 565D)
            table.Rows.Add("Projectors", 787D)
            table.Rows.Add("Televisions", 1125D)
            Return table
        End Function
    End Class


    Public Class DevAVSalesInSouthAmerica
        Public ReadOnly Property Data() As DataTable
            Get
                Return GetData()
            End Get
        End Property

        Public Function GetData() As DataTable
            Dim table As New DataTable()
            table.Columns.AddRange(New DataColumn() {
                New DataColumn("ProductCategory", GetType(String)),
                New DataColumn("Sales", GetType(Decimal))
            })
            table.Rows.Add("Video players", 653D)
            table.Rows.Add("Automation", 123D)
            table.Rows.Add("Monitors", 532D)
            table.Rows.Add("Projectors", 332D)
            table.Rows.Add("Televisions", 865D)
            Return table
        End Function
    End Class


    Public Class DevAVSalesByYear
        Public ReadOnly Property Data() As DataTable
            Get
                Return GetData()
            End Get
        End Property

        Public Function GetData() As DataTable
            Dim lastYear As Integer = Date.Now.Year - 1
            Dim table As New DataTable()
            table.Columns.AddRange(New DataColumn() {
                New DataColumn("Year", GetType(Integer)),
                New DataColumn("Region", GetType(String)),
                New DataColumn("Sales", GetType(Decimal))
            })

            table.Rows.Add(lastYear - 2, "Asia", 4.23D)
            table.Rows.Add(lastYear - 2, "North America", 3.485D)
            table.Rows.Add(lastYear - 2, "Europe", 3.088D)
            table.Rows.Add(lastYear - 2, "Australia", 1.78D)
            table.Rows.Add(lastYear - 2, "South America", 1.602D)

            table.Rows.Add(lastYear - 1, "Asia", 4.768D)
            table.Rows.Add(lastYear - 1, "North America", 3.747D)
            table.Rows.Add(lastYear - 1, "Europe", 3.357D)
            table.Rows.Add(lastYear - 1, "Australia", 1.957D)
            table.Rows.Add(lastYear - 1, "South America", 1.823D)

            table.Rows.Add(lastYear, "Asia", 5.289D)
            table.Rows.Add(lastYear, "North America", 4.182D)
            table.Rows.Add(lastYear, "Europe", 3.725D)
            table.Rows.Add(lastYear, "Australia", 2.272D)
            table.Rows.Add(lastYear, "South America", 2.117D)

            Return table
        End Function
    End Class


    Public Class DevAVSalesByLast10Years
        Public ReadOnly Property Data() As DataTable
            Get
                Return GetData()
            End Get
        End Property

        Public Function GetData() As DataTable
            Dim lastYear As Integer = Date.Now.Year - 1
            Dim table As New DataTable()
            table.Columns.AddRange(New DataColumn() {
                New DataColumn("Year", GetType(Date)),
                New DataColumn("Region", GetType(String)),
                New DataColumn("Sales", GetType(Decimal))
            })

            table.Rows.Add(New Date(lastYear - 10, 12, 31), "North America", 3.010D)
            table.Rows.Add(New Date(lastYear - 10, 12, 31), "Europe", 3.032D)
            table.Rows.Add(New Date(lastYear - 10, 12, 31), "Australia", 1.31D)

            table.Rows.Add(New Date(lastYear - 9, 12, 31), "North America", 3.212D)
            table.Rows.Add(New Date(lastYear - 9, 12, 31), "Europe", 3.050D)
            table.Rows.Add(New Date(lastYear - 9, 12, 31), "Australia", 1.64D)

            table.Rows.Add(New Date(lastYear - 8, 12, 31), "North America", 3.223D)
            table.Rows.Add(New Date(lastYear - 8, 12, 31), "Europe", 3.054D)
            table.Rows.Add(New Date(lastYear - 8, 12, 31), "Australia", 1.70D)

            table.Rows.Add(New Date(lastYear - 7, 12, 31), "North America", 3.001D)
            table.Rows.Add(New Date(lastYear - 7, 12, 31), "Europe", 2.775D)
            table.Rows.Add(New Date(lastYear - 7, 12, 31), "Australia", 1.083D)

            table.Rows.Add(New Date(lastYear - 6, 12, 31), "North America", 2.612D)
            table.Rows.Add(New Date(lastYear - 6, 12, 31), "Europe", 2.066D)
            table.Rows.Add(New Date(lastYear - 6, 12, 31), "Australia", 0.88D)

            table.Rows.Add(New Date(lastYear - 5, 12, 31), "North America", 2.666D)
            table.Rows.Add(New Date(lastYear - 5, 12, 31), "Europe", 2.078D)
            table.Rows.Add(New Date(lastYear - 5, 12, 31), "Australia", 1.09D)

            table.Rows.Add(New Date(lastYear - 4, 12, 31), "North America", 3.665D)
            table.Rows.Add(New Date(lastYear - 4, 12, 31), "Europe", 3.888D)
            table.Rows.Add(New Date(lastYear - 4, 12, 31), "Australia", 2.01D)

            table.Rows.Add(New Date(lastYear - 3, 12, 31), "North America", 3.555D)
            table.Rows.Add(New Date(lastYear - 3, 12, 31), "Europe", 3.008D)
            table.Rows.Add(New Date(lastYear - 3, 12, 31), "Australia", 1.85D)

            table.Rows.Add(New Date(lastYear - 2, 12, 31), "North America", 3.485D)
            table.Rows.Add(New Date(lastYear - 2, 12, 31), "Europe", 3.088D)
            table.Rows.Add(New Date(lastYear - 2, 12, 31), "Australia", 1.78D)

            table.Rows.Add(New Date(lastYear - 1, 12, 31), "North America", 3.747D)
            table.Rows.Add(New Date(lastYear - 1, 12, 31), "Europe", 3.357D)
            table.Rows.Add(New Date(lastYear - 1, 12, 31), "Australia", 1.957D)

            table.Rows.Add(New Date(lastYear, 12, 31), "North America", 4.182D)
            table.Rows.Add(New Date(lastYear, 12, 31), "Europe", 3.725D)
            table.Rows.Add(New Date(lastYear, 12, 31), "Australia", 2.272D)

            Return table
        End Function
    End Class


    Public Class AgeStructure

        Private Shared ageStructureTable_Renamed As DataTable
        Private Shared ReadOnly Property AgeStructureTable() As DataTable
            Get
                If ageStructureTable_Renamed Is Nothing Then
                    ageStructureTable_Renamed = LoadPopulationAgeStructure()
                End If
                Return ageStructureTable_Renamed
            End Get
        End Property

        Private Shared Function LoadPopulationAgeStructure() As DataTable
            Dim uri As New Uri("pack://application:,,,/ChartsDemo;component/Data/Population.xml")
            Dim xmlStream As Stream = Application.GetResourceStream(uri).Stream
            Dim xmlDataSet As New DataSet()
            xmlDataSet.ReadXml(xmlStream)
            xmlStream.Close()
            Return xmlDataSet.Tables("Population")
        End Function
        Public Shared Function GetDataByAgeAndGender() As IList
            Return AgeStructureTable.AsEnumerable().Select(Function(row) New With {Key .GenderAge = New GenderAgeInfo(row.Field(Of String)("Gender"), row.Field(Of String)("Age")), Key .Country = row.Field(Of String)("Country"), Key .Population = row.Field(Of Long)("Population")}).ToList()
        End Function
        Public Shared Function GetDataByMaleAge() As IList
            Return AgeStructureTable.AsEnumerable().Where(Function(row) row.Field(Of String)("Gender") = "Male").Select(Function(row) New With {Key .Age = row.Field(Of String)("Age"), Key .Country = row.Field(Of String)("Country"), Key .Population = row.Field(Of Long)("Population")}).ToList()
        End Function
        Public Shared Function GetPopulationAgeStructure() As IList
            Return AgeStructureTable.AsEnumerable().Select(Function(row) New AgePopulation(row.Field(Of String)("Country"), row.Field(Of String)("Age"), row.Field(Of String)("Gender"), row.Field(Of Long)("Population"))).ToList()
        End Function
    End Class


    Public Structure GenderAgeInfo

        Private gender_Renamed As String

        Private age_Renamed As String

        Public ReadOnly Property Gender() As String
            Get
                Return gender_Renamed
            End Get
        End Property
        Public ReadOnly Property Age() As String
            Get
                Return age_Renamed
            End Get
        End Property

        Public Sub New(ByVal gender As String, ByVal age As String)
            Me.gender_Renamed = gender
            Me.age_Renamed = age
        End Sub
        Public Overrides Function ToString() As String
            Return gender_Renamed & ": " & age_Renamed
        End Function
    End Structure


    Public Class PowerConsumption
        Public ReadOnly Property Data() As DataTable
            Get
                Return GetData()
            End Get
        End Property

        Public Function GetData() As DataTable
            Dim table As New DataTable()
            table.Columns.AddRange(New DataColumn() {
                New DataColumn("Branch", GetType(String)),
                New DataColumn("Time", GetType(Date)),
                New DataColumn("Power", GetType(Double))
            })

            table.Rows.Add("""Center"" Branch", New Date(1, 1, 1, 7, 0, 0), 429)
            table.Rows.Add("""Center"" Branch", New Date(1, 1, 1, 8, 0, 0), 432)
            table.Rows.Add("""Center"" Branch", New Date(1, 1, 1, 9, 0, 0), 301)
            table.Rows.Add("""Center"" Branch", New Date(1, 1, 1, 10, 0, 0), 307)
            table.Rows.Add("""Center"" Branch", New Date(1, 1, 1, 11, 0, 0), 310)
            table.Rows.Add("""Center"" Branch", New Date(1, 1, 1, 12, 0, 0), 380)
            table.Rows.Add("""Center"" Branch", New Date(1, 1, 1, 13, 0, 0), 384)
            table.Rows.Add("""Center"" Branch", New Date(1, 1, 1, 14, 0, 0), 398)
            table.Rows.Add("""Center"" Branch", New Date(1, 1, 1, 15, 0, 0), 379)
            table.Rows.Add("""Center"" Branch", New Date(1, 1, 1, 16, 0, 0), 220)
            table.Rows.Add("""Center"" Branch", New Date(1, 1, 1, 17, 0, 0), 321)
            table.Rows.Add("""Center"" Branch", New Date(1, 1, 1, 18, 0, 0), 341)
            table.Rows.Add("""Center"" Branch", New Date(1, 1, 1, 19, 0, 0), 368)
            table.Rows.Add("""Center"" Branch", New Date(1, 1, 1, 20, 0, 0), 557)
            table.Rows.Add("""Center"" Branch", New Date(1, 1, 1, 21, 0, 0), 523)
            table.Rows.Add("""Center"" Branch", New Date(1, 1, 1, 22, 0, 0), 501)
            table.Rows.Add("""Center"" Branch", New Date(1, 1, 1, 23, 0, 0), 443)

            table.Rows.Add("""East"" Branch", New Date(1, 1, 1, 7, 0, 0), 260)
            table.Rows.Add("""East"" Branch", New Date(1, 1, 1, 8, 0, 0), 287)
            table.Rows.Add("""East"" Branch", New Date(1, 1, 1, 9, 0, 0), 285)
            table.Rows.Add("""East"" Branch", New Date(1, 1, 1, 10, 0, 0), 281)
            table.Rows.Add("""East"" Branch", New Date(1, 1, 1, 11, 0, 0), 294)
            table.Rows.Add("""East"" Branch", New Date(1, 1, 1, 12, 0, 0), 303)
            table.Rows.Add("""East"" Branch", New Date(1, 1, 1, 13, 0, 0), 325)
            table.Rows.Add("""East"" Branch", New Date(1, 1, 1, 14, 0, 0), 336)
            table.Rows.Add("""East"" Branch", New Date(1, 1, 1, 15, 0, 0), 325)
            table.Rows.Add("""East"" Branch", New Date(1, 1, 1, 16, 0, 0), 186)
            table.Rows.Add("""East"" Branch", New Date(1, 1, 1, 17, 0, 0), 420)
            table.Rows.Add("""East"" Branch", New Date(1, 1, 1, 18, 0, 0), 455)
            table.Rows.Add("""East"" Branch", New Date(1, 1, 1, 19, 0, 0), 481)
            table.Rows.Add("""East"" Branch", New Date(1, 1, 1, 20, 0, 0), 487)
            table.Rows.Add("""East"" Branch", New Date(1, 1, 1, 21, 0, 0), 490)
            table.Rows.Add("""East"" Branch", New Date(1, 1, 1, 22, 0, 0), 467)
            table.Rows.Add("""East"" Branch", New Date(1, 1, 1, 23, 0, 0), 409)
            Return table
        End Function
    End Class


    Public Class DevAVBranchesSales
        Public ReadOnly Property Data() As DataTable
            Get
                Return GetData()
            End Get
        End Property

        Public Function GetData() As DataTable
            Dim lastYear As Integer = Date.Now.Year - 1
            Dim table As New DataTable()
            table.Columns.AddRange(New DataColumn() {
                New DataColumn("Year", GetType(Date)),
                New DataColumn("Company", GetType(String)),
                New DataColumn("Sales", GetType(Decimal))
            })

            table.Rows.Add(New Date(lastYear - 10, 12, 31), "DevAV North", 1.010D)
            table.Rows.Add(New Date(lastYear - 10, 12, 31), "DevAV Center", 3.032D)
            table.Rows.Add(New Date(lastYear - 10, 12, 31), "DevAV South", 1.31D)

            table.Rows.Add(New Date(lastYear - 9, 12, 31), "DevAV North", 1.512D)
            table.Rows.Add(New Date(lastYear - 9, 12, 31), "DevAV Center", 3.050D)
            table.Rows.Add(New Date(lastYear - 9, 12, 31), "DevAV South", 1.34D)

            table.Rows.Add(New Date(lastYear - 8, 12, 31), "DevAV North", 1.723D)
            table.Rows.Add(New Date(lastYear - 8, 12, 31), "DevAV West", 0.005D)
            table.Rows.Add(New Date(lastYear - 8, 12, 31), "DevAV Center", 3.054D)
            table.Rows.Add(New Date(lastYear - 8, 12, 31), "DevAV South", 1.30D)

            table.Rows.Add(New Date(lastYear - 7, 12, 31), "DevAV West", 0.31D)
            table.Rows.Add(New Date(lastYear - 7, 12, 31), "DevAV North", 2.001D)
            table.Rows.Add(New Date(lastYear - 7, 12, 31), "DevAV Center", 2.975D)
            table.Rows.Add(New Date(lastYear - 7, 12, 31), "DevAV South", 1.283D)

            table.Rows.Add(New Date(lastYear - 6, 12, 31), "DevAV West", 0.41D)
            table.Rows.Add(New Date(lastYear - 6, 12, 31), "DevAV North", 2.612D)
            table.Rows.Add(New Date(lastYear - 6, 12, 31), "DevAV Center", 2.066D)
            table.Rows.Add(New Date(lastYear - 6, 12, 31), "DevAV South", 0.88D)

            table.Rows.Add(New Date(lastYear - 5, 12, 31), "DevAV West", 0.95D)
            table.Rows.Add(New Date(lastYear - 5, 12, 31), "DevAV North", 2.666D)
            table.Rows.Add(New Date(lastYear - 5, 12, 31), "DevAV Center", 2.078D)
            table.Rows.Add(New Date(lastYear - 5, 12, 31), "DevAV South", 1.09D)

            table.Rows.Add(New Date(lastYear - 4, 12, 31), "DevAV West", 1.53D)
            table.Rows.Add(New Date(lastYear - 4, 12, 31), "DevAV North", 3.665D)
            table.Rows.Add(New Date(lastYear - 4, 12, 31), "DevAV Center", 3.888D)
            table.Rows.Add(New Date(lastYear - 4, 12, 31), "DevAV South", 1.01D)

            table.Rows.Add(New Date(lastYear - 3, 12, 31), "DevAV East", 0.004D)
            table.Rows.Add(New Date(lastYear - 3, 12, 31), "DevAV West", 1.75D)
            table.Rows.Add(New Date(lastYear - 3, 12, 31), "DevAV North", 3.555D)
            table.Rows.Add(New Date(lastYear - 3, 12, 31), "DevAV Center", 3.008D)
            table.Rows.Add(New Date(lastYear - 3, 12, 31), "DevAV South", 1.11D)

            table.Rows.Add(New Date(lastYear - 2, 12, 31), "DevAV East", 0.32D)
            table.Rows.Add(New Date(lastYear - 2, 12, 31), "DevAV West", 1.31D)
            table.Rows.Add(New Date(lastYear - 2, 12, 31), "DevAV North", 3.485D)
            table.Rows.Add(New Date(lastYear - 2, 12, 31), "DevAV Center", 3.088D)
            table.Rows.Add(New Date(lastYear - 2, 12, 31), "DevAV South", 1.12D)

            table.Rows.Add(New Date(lastYear - 1, 12, 31), "DevAV East", 0.51D)
            table.Rows.Add(New Date(lastYear - 1, 12, 31), "DevAV West", 1.31D)
            table.Rows.Add(New Date(lastYear - 1, 12, 31), "DevAV North", 3.747D)
            table.Rows.Add(New Date(lastYear - 1, 12, 31), "DevAV Center", 3.357D)
            table.Rows.Add(New Date(lastYear - 1, 12, 31), "DevAV South", 1.12D)

            table.Rows.Add(New Date(lastYear, 12, 31), "DevAV East", 1.71D)
            table.Rows.Add(New Date(lastYear, 12, 31), "DevAV West", 1.22D)
            table.Rows.Add(New Date(lastYear, 12, 31), "DevAV North", 4.182D)
            table.Rows.Add(New Date(lastYear, 12, 31), "DevAV Center", 3.725D)
            table.Rows.Add(New Date(lastYear, 12, 31), "DevAV South", 1.111D)

            Return table
        End Function
    End Class
    Public Class FuelPrices
        Public ReadOnly Property Data() As DataTable
            Get
                Return GetData()
            End Get
        End Property

        Public Function GetData() As DataTable
            Dim table As New DataTable()
            table.Columns.AddRange(New DataColumn() {
                New DataColumn("Date", GetType(Date)),
                New DataColumn("Price", GetType(Decimal))
            })
            table.Rows.Add(New Date(2016, 1, 1, 0, 0, 0), 2.143D)
            table.Rows.Add(New Date(2016, 2, 1, 0, 0, 0), 1.998D)
            table.Rows.Add(New Date(2016, 3, 1, 0, 0, 0), 2.090D)
            table.Rows.Add(New Date(2016, 4, 1, 0, 0, 0), 2.152D)
            table.Rows.Add(New Date(2016, 5, 1, 0, 0, 0), 2.315D)
            table.Rows.Add(New Date(2016, 6, 1, 0, 0, 0), 2.423D)
            table.Rows.Add(New Date(2016, 7, 1, 0, 0, 0), 2.405D)
            table.Rows.Add(New Date(2016, 8, 1, 0, 0, 0), 2.351D)
            table.Rows.Add(New Date(2016, 9, 1, 0, 0, 0), 2.394D)
            table.Rows.Add(New Date(2016, 10,1, 0, 0, 0), 2.454D)
            table.Rows.Add(New Date(2016, 11,1, 0, 0, 0), 2.439D)
            table.Rows.Add(New Date(2016, 12,1, 0, 0, 0), 2.510D)
            Return table
        End Function
    End Class


    Public Class HighestGrossingFilmsByYear
        Public ReadOnly Property Data() As DataTable
            Get
                Return GetData()
            End Get
        End Property

        Public Function GetData() As DataTable
            Dim table As New DataTable()
            table.Columns.AddRange(New DataColumn() {
                New DataColumn("Year", GetType(Date)),
                New DataColumn("Budget", GetType(Decimal)),
                New DataColumn("Grosses", GetType(Decimal)),
                New DataColumn("Title", GetType(String))
            })
            table.Rows.Add(New Date(2007, 1, 1), 300, 0.963, "Pirates of the Caribbean:" & ControlChars.Lf & "At World's End")
            table.Rows.Add(New Date(2008, 1, 1), 185, 1.004, "The Dark Knight")
            table.Rows.Add(New Date(2009, 1, 1), 237, 2.788, "Avatar")
            table.Rows.Add(New Date(2010, 1, 1), 200, 1.067, "Toy Story 3")
            table.Rows.Add(New Date(2011, 1, 1), 250, 1.341, "Harry Potter and the Deathly Hallows" & ControlChars.Lf & "Part 2")
            table.Rows.Add(New Date(2012, 1, 1), 220, 1.519, "Marvel's The Avengers")
            table.Rows.Add(New Date(2013, 1, 1), 150, 1.276, "Frozen")
            table.Rows.Add(New Date(2014, 1, 1), 210, 1.104, "Transformers:" & ControlChars.Lf & "Age of Extinction")
            table.Rows.Add(New Date(2015, 1, 1), 245, 2.068, "Star Wars:" & ControlChars.Lf & "The Force Awakens")
            table.Rows.Add(New Date(2016, 1, 1), 250, 1.153, "Captain America:" & ControlChars.Lf & "Civil War")
            Return table
        End Function
    End Class


    Public Class OutsideVendorCosts
        Public ReadOnly Property Data() As DataTable
            Get
                Return GetData()
            End Get
        End Property

        Public Function GetData() As DataTable
            Dim lastYear As Integer = Date.Now.Year - 1
            Dim table As New DataTable()
            table.Columns.AddRange(New DataColumn() {
                New DataColumn("Year", GetType(Date)),
                New DataColumn("Company", GetType(String)),
                New DataColumn("Costs", GetType(Decimal))
            })

            table.Rows.Add(New Date(lastYear - 6, 12, 31), "DevAV North", 362.5D)
            table.Rows.Add(New Date(lastYear - 5, 12, 31), "DevAV North", 348.4D)
            table.Rows.Add(New Date(lastYear - 4, 12, 31), "DevAV North", 279.0D)
            table.Rows.Add(New Date(lastYear - 3, 12, 31), "DevAV North", 230.9D)
            table.Rows.Add(New Date(lastYear - 2, 12, 31), "DevAV North", 203.5D)
            table.Rows.Add(New Date(lastYear - 1, 12, 31), "DevAV North", 197.1D)

            table.Rows.Add(New Date(lastYear - 6, 12, 31), "DevAV South", 277.0D)
            table.Rows.Add(New Date(lastYear - 5, 12, 31), "DevAV South", 328.5D)
            table.Rows.Add(New Date(lastYear - 4, 12, 31), "DevAV South", 297.0D)
            table.Rows.Add(New Date(lastYear - 3, 12, 31), "DevAV South", 255.3D)
            table.Rows.Add(New Date(lastYear - 2, 12, 31), "DevAV South", 173.5D)
            table.Rows.Add(New Date(lastYear - 1, 12, 31), "DevAV South", 131.8D)

            Return table
        End Function
    End Class


    Public Class GoogleStockData
        Public ReadOnly Property Data() As DataTable
            Get
                Return GetData()
            End Get
        End Property
        Public ReadOnly Property ShortData() As DataTable
            Get
                Return Data.AsEnumerable().Reverse().Take(30).Reverse().CopyToDataTable()
            End Get
        End Property

        Public Function GetData() As DataTable
            Return DataUtils.LoadDataTableFromXml("GoogleStockData.xml", "StockPrice")
        End Function
    End Class

    Public NotInheritable Class FinancialDataLoader

        Private Sub New()
        End Sub

        Private Shared positiveDynamic As ImageSource = New BitmapImage(New Uri("/ChartsDemo;component/Images/ArrowUp.png", UriKind.Relative))
        Private Shared negativeDynamic As ImageSource = New BitmapImage(New Uri("/ChartsDemo;component/Images/ArrowDown.png", UriKind.Relative))
        Private Shared zeroDynamic As ImageSource = New BitmapImage(New Uri("/ChartsDemo;component/Images/ZeroDynamic.png", UriKind.Relative))

        Private Shared Function GetStockDynamic(ByVal previousPointValue As Decimal, ByVal currentPointValue As Decimal) As StockDynamic
            If previousPointValue < currentPointValue Then
                Return New StockDynamic(New SolidColorBrush(Color.FromArgb(255, 63, 171, 0)), positiveDynamic)
            ElseIf previousPointValue > currentPointValue Then
                Return New StockDynamic(New SolidColorBrush(Color.FromArgb(255, 213, 50, 35)), negativeDynamic)
            Else
                Return New StockDynamic(New SolidColorBrush(Color.FromArgb(255, 161, 161, 161)), zeroDynamic)
            End If
        End Function
        Private Shared Function ReadDataPointFromXML(ByVal element As XElement) As StockDataPoint
            Dim point As New StockDataPoint()
            point.TradeDate = Date.ParseExact(element.Element("Date").Value, "yyyy-MM-dd", CultureInfo.InvariantCulture)
            point.Open = Convert.ToDecimal(element.Element("Open").Value, CultureInfo.InvariantCulture)
            point.Close = Convert.ToDecimal(element.Element("Close").Value, CultureInfo.InvariantCulture)
            point.Low = Convert.ToDecimal(element.Element("Low").Value, CultureInfo.InvariantCulture)
            point.High = Convert.ToDecimal(element.Element("High").Value, CultureInfo.InvariantCulture)
            point.ToolTipData = New ToolTipStockData()
            point.ToolTipData.Owner = point
            Return point
        End Function
        Public Shared Function GetGoogleStockData() As List(Of StockDataPoint)
            Dim document As XDocument = DataLoader.LoadXmlFromResources("/Data/GoogleStockData.xml")
            Dim result As New List(Of StockDataPoint)()
            If document IsNot Nothing Then
                Dim elements As IEnumerable(Of XElement) = document.Element("StockPrices").Elements("StockPrice").Reverse()
                Dim previousPoint As StockDataPoint = ReadDataPointFromXML(elements.ElementAt(0))
                For Each element As XElement In elements
                    Dim point As StockDataPoint = ReadDataPointFromXML(element)
                    point.ToolTipData.OpenDynamic = GetStockDynamic(previousPoint.Open, point.Open).ImageSource
                    point.ToolTipData.CloseDynamic = GetStockDynamic(previousPoint.Close, point.Close).ImageSource
                    point.ToolTipData.HighDynamic = GetStockDynamic(previousPoint.High, point.High).ImageSource
                    point.ToolTipData.LowDynamic = GetStockDynamic(previousPoint.Low, point.Low).ImageSource
                    point.ToolTipData.OpenFontBrush = GetStockDynamic(previousPoint.Open, point.Open).Brush
                    point.ToolTipData.CloseFontBrush = GetStockDynamic(previousPoint.Close, point.Close).Brush
                    point.ToolTipData.HighFontBrush = GetStockDynamic(previousPoint.High, point.High).Brush
                    point.ToolTipData.LowFontBrush = GetStockDynamic(previousPoint.Low, point.Low).Brush
                    result.Add(point)
                    previousPoint = point
                Next element
            End If
            Return result
        End Function
    End Class

    Public Class StockDataPoint
        Public Property ToolTipData() As ToolTipStockData
        Public Property TradeDate() As Date
        Public Property High() As Decimal
        Public Property Low() As Decimal
        Public Property Open() As Decimal
        Public Property Close() As Decimal
    End Class

    Public Class ToolTipStockData
        Public Property Owner() As StockDataPoint
        Public Property HighDynamic() As ImageSource
        Public Property LowDynamic() As ImageSource
        Public Property OpenDynamic() As ImageSource
        Public Property CloseDynamic() As ImageSource
        Public Property HighFontBrush() As Brush
        Public Property LowFontBrush() As Brush
        Public Property OpenFontBrush() As Brush
        Public Property CloseFontBrush() As Brush
    End Class

    Public Class StockDynamic
        Private privateBrush As Brush
        Public Property Brush() As Brush
            Get
                Return privateBrush
            End Get
            Private Set(ByVal value As Brush)
                privateBrush = value
            End Set
        End Property
        Private privateImageSource As ImageSource
        Public Property ImageSource() As ImageSource
            Get
                Return privateImageSource
            End Get
            Private Set(ByVal value As ImageSource)
                privateImageSource = value
            End Set
        End Property

        Public Sub New(ByVal brush As Brush, ByVal imageSource As ImageSource)
            Me.Brush = brush
            Me.ImageSource = imageSource
        End Sub
    End Class

    Public NotInheritable Class DataUtils

        Private Sub New()
        End Sub

        Public Shared Function LoadDataTableFromXml(ByVal fileName As String, ByVal tableName As String) As DataTable
            Dim uri As New Uri("pack://application:,,,/ChartsDemo;component/Data/" & fileName)
            Dim xmlStream As Stream = Application.GetResourceStream(uri).Stream
            Dim xmlDataSet As New DataSet()
            xmlDataSet.ReadXml(xmlStream)
            xmlStream.Close()
            Return xmlDataSet.Tables(tableName)
        End Function
    End Class


    Public Class GoldPrices
        Public ReadOnly Property Data() As List(Of GoldPrice)
            Get
                Return GetData()
            End Get
        End Property

        Private Function GetData() As List(Of GoldPrice)
            Dim document As XDocument = DataLoader.LoadXmlFromResources("/Data/GoldPrices.xml")
            Dim goldPrices As New List(Of GoldPrice)()
            If document IsNot Nothing Then
                For Each element As XElement In document.Element("GoldPrices").Elements()
                    Dim [date] As Date = Date.ParseExact(element.Element("Date").Value, "dd MMM yyyy", CultureInfo.InvariantCulture)
                    Dim price As Double = Convert.ToDouble(element.Element("Price").Value, CultureInfo.InvariantCulture)
                    goldPrices.Add(New GoldPrice([date], price))
                Next element
            End If
            Return goldPrices
        End Function
    End Class


    Public Class GoldPrice

        Private ReadOnly date_Renamed As Date

        Private ReadOnly price_Renamed As Double

        Public ReadOnly Property [Date]() As Date
            Get
                Return date_Renamed
            End Get
        End Property
        Public ReadOnly Property Price() As Double
            Get
                Return price_Renamed
            End Get
        End Property

        Public Sub New(ByVal [date] As Date, ByVal price As Double)
            Me.date_Renamed = [date]
            Me.price_Renamed = price
        End Sub
    End Class
End Namespace
