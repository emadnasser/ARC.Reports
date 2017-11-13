Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Diagnostics
Imports System.IO
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.Office.Internal
Imports DevExpress.XtraRichEdit.Demos.Forms
Imports DevExpress.XtraRichEdit.API.Native
Imports DevExpress.XtraRichEdit.Internal
Imports DevExpress.XtraEditors


Namespace DevExpress.XtraRichEdit.Demos
    Public Class MergeModuleBase
        Inherits DevExpress.XtraRichEdit.Demos.TutorialControl
        Private Shared firstName() As String = {"Nancy", "Andrew", "Janet", "Margaret", "Steven", "Michael", "Robert", "Laura", "Anne"}
        Private Shared lastName() As String = {"Davolio", "Fuller", "Leverling", "Peacock", "Buchanan", "Suyama", "King", "Callahan", "Dodsworth"}
        Private Shared city() As String = {"Seattle", "Tacoma", "Kirkland", "Redmond", "London", "London", "London", "Seattle", "London"}
        Private Shared country() As String = {"USA", "USA", "USA", "USA", "UK", "UK", "UK", "USA", "UK"}
        Private Shared address() As String = {"507 - 20th Ave. E. Apt. 2A", "908 W. Capital Way", "722 Moss Bay Blvd.", "4110 Old Redmond Rd.", "14 Garrett Hill", "Coventry House Miner Rd.", "Edgeham Hollow Winchester Way", "4726 - 11th Ave. N.E.", "7 Houndstooth Rd."}
        Private Shared position() As String = {"Sales Representative", "Vice President, Sales", "Sales Representative", "Sales Representative", "Sales Manager", "Sales Representative", "Sales Representative", "Inside Sales Coordinator", "Sales Representative"}
        Private Shared gender() As Char = {"F"c, "M"c, "F"c, "F"c, "M"c, "M"c, "M"c, "F"c, "F"c}
        Private Shared phone() As String = {"(206) 555-9857", "(206) 555-9482", "(206) 555-3412", "(206) 555-8122", "(71) 555-4848", "(71) 555-7773", "(71) 555-5598", "(206) 555-1189", "(71) 555-4444"}
        'Private Shared companyName() As String = {"Consolidated Holdings", "Around the Horn", "North/South", "Island Trading", "White Clover Markets", "Trail's Head Gourmet Provisioners", "The Cracker Box", "The Big Cheese", "Rattlesnake Canyon Grocery", "Split Rail Beer & Ale", "Hungry Coyote Import Store", "Great Lakes Food Market"}

        Protected Sub New()
        End Sub

        Public Overrides ReadOnly Property PrintingRichEditControl() As RichEditControl
            Get
                Return SourceRichEditControl
            End Get
        End Property
        Protected Overridable ReadOnly Property SourceRichEditControl() As RichEditControl
            Get
                Return Nothing
            End Get
        End Property

        Protected Friend Function GenerateEmployeeList() As List(Of Employee)
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
            result.HiringDate = DateTime.Now.AddDays(-(rnd.Next(0, 2000)))
            result.Position = position(rnd.Next(0, position.Length))
            result.Phone = phone(rnd.Next(0, phone.Length))
            result.CompanyName = CompanyName(rnd.Next(0, CompanyName.Length))
            result.HRManagerName = String.Format("{0} {1}", firstName(rnd.Next(0, firstName.Length)), lastName(rnd.Next(0, lastName.Length)))
            Return result
        End Function

        Protected Overridable Sub MergeToNewDocument()
            Dim form As MergeFieldsFormBase = CreateMergeFieldForm()
            If form.ShowDialog(Me) = DialogResult.OK Then
                Dim options As MailMergeOptions = SourceRichEditControl.Document.CreateMailMergeOptions()
                CalculateMailMergeOptions(form, options)
                options.MergeMode = MergeMode.NewSection
                If form.MergeDestination = MergeDestination.NewTab Then
                    MailMergeToNewControl(options)
                Else
                    MailMergeToNewFile(options)
                End If
            End If
        End Sub
        Protected Overridable Function CreateMergeFieldForm() As MergeFieldsFormBase
            Return Nothing
        End Function
        Protected Overridable Sub CalculateMailMergeOptions(ByVal form As MergeFieldsFormBase, ByVal options As MailMergeOptions)
        End Sub
        Protected Sub MailMergeToNewControl(ByVal options As MailMergeOptions)
            Dim form As New MergeResultingDocumentForm()
            SourceRichEditControl.Document.MailMerge(options, form.Document)
            form.Show(Me)
        End Sub
        Protected Sub MailMergeToNewFile(ByVal options As MailMergeOptions)
            Dim exportManagerService As IDocumentExportManagerService = CType(SourceRichEditControl.GetService(GetType(IDocumentExportManagerService)), IDocumentExportManagerService)
            Dim exporters As List(Of IExporter(Of DocumentFormat, Boolean)) = exportManagerService.GetExporters()
            Using saveFileDialog As New SaveFileDialog()
                saveFileDialog.Filter = CreateExportFilters(exporters)
                saveFileDialog.RestoreDirectory = True
                saveFileDialog.CheckFileExists = False
                saveFileDialog.CheckPathExists = True
                saveFileDialog.OverwritePrompt = True
                saveFileDialog.DereferenceLinks = True
                saveFileDialog.ValidateNames = True

                If saveFileDialog.ShowDialog(Me) <> DialogResult.OK Then
                    Return
                End If
                Dim fileName As String = saveFileDialog.FileName
                Dim documentFormat As DocumentFormat = GetDocumentFormat(fileName, exporters)
                SourceRichEditControl.Document.MailMerge(options, fileName, documentFormat)

                If XtraMessageBox.Show("Do you want to open this file?", "Mail Merge", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                    Dim process As New Process()
                    Try
                        process.StartInfo.FileName = fileName
                        process.Start()
                    Catch
                    End Try

                End If

            End Using
        End Sub
        Private Function CreateExportFilters(ByVal exporters As List(Of IExporter(Of DocumentFormat, Boolean))) As String
            Dim result As New StringBuilder()
            Dim count As Integer = exporters.Count
            For i As Integer = 0 To count - 1
                Dim filter As FileDialogFilter = exporters(i).Filter
                If filter.Extensions.Count > 0 Then
                    If i > 0 Then
                        result.Append("|"c)
                    End If
                    result.Append(filter.ToString())
                End If
            Next i
            Return result.ToString()
        End Function
        Private Function GetDocumentFormat(ByVal fileName As String, ByVal exporters As List(Of IExporter(Of DocumentFormat, Boolean))) As DocumentFormat
            Dim extension As String = Path.GetExtension(fileName).TrimStart("."c).ToLower()
            If String.IsNullOrEmpty(extension) Then
                Return DocumentFormat.Rtf
            End If
            Dim count As Integer = exporters.Count
            For i As Integer = 0 To count - 1
                Dim extensions As FileExtensionCollection = exporters(i).Filter.Extensions
                If extensions.IndexOf(extension) >= 0 Then
                    Return exporters(i).Format
                End If
            Next i
            Return DocumentFormat.Rtf
        End Function

        Public Shared Function GetEmployeeDataFromXml() As System.Data.DataTable
            Dim path As String = DemoUtils.GetRelativePath("TOC_Employees.xml")
            If String.IsNullOrEmpty(path) Then
                Return Nothing
            End If
            Dim EmployeeDataDS As New System.Data.DataSet()
            Dim schemaPath As String = DemoUtils.GetRelativePath("TOC_EmployeesSchema.xml")
            If Not [String].IsNullOrEmpty(schemaPath) Then
                EmployeeDataDS.ReadXmlSchema(schemaPath)
            End If
            EmployeeDataDS.ReadXml(path)
            Return EmployeeDataDS.Tables(1)
        End Function
    End Class
End Namespace
