Imports System.IO
Imports DevExpress.ExpressApp
Imports DevExpress.Data.Filtering
Imports DevExpress.Persistent.Base
Imports DevExpress.ExpressApp.Utils
Imports DevExpress.ExpressApp.Updating
Imports DevExpress.Persistent.BaseImpl

Public Class Updater
    Inherits ModuleUpdater
    Private rnd As New Random()

    Public Sub New(ByVal objectSpace As IObjectSpace, ByVal currentDBVersion As Version)
        MyBase.New(objectSpace, currentDBVersion)
    End Sub
    Public Overrides Sub UpdateDatabaseAfterUpdateSchema()
        MyBase.UpdateDatabaseAfterUpdateSchema()
        If ObjectSpace.CanInstantiate(GetType(Project)) Then
            CreatePlanningData()
        End If
        If ObjectSpace.CanInstantiate(GetType(Customer)) Then
            CreateMarketingData()
        End If
    End Sub
    Private Function GetEmbeddedResourceImage(ByVal shortName As String) As Image
        Try
            Return Image.FromStream(GetEmbeddedResourceStream(shortName))
        Catch
            Return Nothing
        End Try
    End Function
    Private Function GetEmbeddedResourceStream(ByVal shortName As String) As Stream
        Dim embeddedResourceName As String = Array.Find(Of String)(Me.GetType().Assembly.GetManifestResourceNames(), Function(s) s.Contains(shortName))
        Return Me.GetType().Assembly.GetManifestResourceStream(embeddedResourceName)
    End Function
    Private Function GetEmbeddedResourceByteArray(ByVal shortName As String) As Byte()
        Dim stream As UnmanagedMemoryStream = DirectCast(GetEmbeddedResourceStream(shortName), UnmanagedMemoryStream)
        stream.Position = 0
        Dim result As Byte() = New Byte(CInt(stream.Length - 1)) {}
        stream.Read(result, 0, CInt(stream.Length))
        Return result
    End Function

    Private Sub CreatePlanningData()
        Tracing.Tracer.LogText("Creating Persons")
        Dim john As Person = CreatePerson("Nilsen", "John", GetEmbeddedResourceByteArray("m01.jpg"), "John@example.com")
        Dim sam As Person = CreatePerson("Peterson", "Sam", GetEmbeddedResourceByteArray("m03.jpg"), "Sam@example.com")
        Dim mary As Person = CreatePerson("Tellitson", "Mary", GetEmbeddedResourceByteArray("w02.jpg"), "Mary@example.com")
        Dim lily As Person = CreatePerson("Johnson", "Lily", GetEmbeddedResourceByteArray("w04.jpg"), "Lily@example.com")

        Tracing.Tracer.LogText("Creating 'General DevExpress XAF Evaluation' Project & Tasks")
        Dim generalEvaluationProject As Project = CreateProject("General DevExpress XAF Evaluation", mary)
        CreateProjectTask(generalEvaluationProject, "1. Check general product and company information, licensing and pricing", "http://www.devexpress.com/xaf", ProjectTaskStatus.Completed, mary)
        CreateProjectTask(generalEvaluationProject, "2. Check features of the DevExpress WinForms, ASP.NET WebForms & DevExtreme HTML5/JavaScript controls used in XAF", "http://www.devexpress.com/asp" & ControlChars.CrLf & "http://www.devexpress.com/winforms" & ControlChars.CrLf & "https://js.devexpress.com/", ProjectTaskStatus.NotStarted, mary)
        CreateProjectTask(generalEvaluationProject, "3. Download a free 30-day trial (free technical support included)", "http://www.devexpress.com/Home/Try.xml", ProjectTaskStatus.Completed, mary)
        CreateProjectTask(generalEvaluationProject, "4. Play with online demo applications on the web site and research local demos in the Demo Center from the installation", "SimpleProjectManager, MainDemo, XCRM, XVideoRental, FeatureCenter, SecurityDemo, WorkflowDemo, etc. at %public%\Documents\", ProjectTaskStatus.InProgress, mary)
        CreateProjectTask(generalEvaluationProject, "5. Analyze key characteristics (look & feel, features set, performance, usability, etc.)", "http://www.devexpress.com/xaf", ProjectTaskStatus.InProgress, mary)
        CreateProjectTask(generalEvaluationProject, "6. Try the Getting Started tutorials and build a few a prototypes", "https://documentation.devexpress.com/#eXpressAppFramework/CustomDocument113577", ProjectTaskStatus.InProgress, mary)
        CreateProjectTask(generalEvaluationProject, "7. Check support options and learning materials (documentation, examples, videos, blogs, webinars, etc.)", "http://www.devexpress.com/support/" & ControlChars.CrLf, ProjectTaskStatus.Completed, mary)
        CreateProjectTask(generalEvaluationProject, "8. Learn more about the Universal subscription features", "http://www.devexpress.com/Subscriptions/Universal.xml", ProjectTaskStatus.Completed, mary)
        CreateProjectTask(generalEvaluationProject, "9. Consider using a live chat on site or emailing at info@devexpress.com if you have any pre-sales questions", "http://www.devexpress.com/Home/ContactUs.xml", ProjectTaskStatus.Deferred, mary)
        Tracing.Tracer.LogText("Creating 'DevExpress XAF Features Overview' Project & Tasks")
        Dim featuresOverviewProject As Project = CreateProject("DevExpress XAF Features Overview", sam)
        Try
            Dim doc As XDocument = XDocument.Load(GetEmbeddedResourceStream("ProjectTasks.xml"))
            For Each el As XElement In doc.Root.Elements()
                Dim subject As XAttribute = el.Attribute("Subject")
                If subject IsNot Nothing Then
                    Dim task As ProjectTask = ObjectSpace.FindObject(Of ProjectTask)(New BinaryOperator("Subject", subject.Value))
                    If task Is Nothing Then
                        task = ObjectSpace.CreateObject(Of ProjectTask)()
                        task.Subject = subject.Value

                        Dim notes As XElement = el.Element(XName.Get("Notes"))
                        If notes IsNot Nothing Then
                            task.Notes = notes.Value.Replace(vbLf, Environment.NewLine)
                        End If
                        task.AssignedTo = If(rnd.Next(5) Mod 2 = 0, (If(rnd.Next(6) Mod 2 = 0, sam, lily)), john)
                        task.Project = featuresOverviewProject
                        task.Status = If(rnd.Next(7) Mod 2 = 0, (If(rnd.Next(8) Mod 2 = 0, ProjectTaskStatus.InProgress, ProjectTaskStatus.Completed)), (If(rnd.Next(9) Mod 2 = 0, ProjectTaskStatus.NotStarted, ProjectTaskStatus.Completed)))
                        If task.Status = ProjectTaskStatus.InProgress OrElse task.Status = ProjectTaskStatus.Completed Then
                            task.StartDate = Date.Now.AddDays(rnd.Next(1) * (-1))
                        End If
                        If task.Status = ProjectTaskStatus.Completed Then
                            task.EndDate = Date.Now.AddDays(rnd.Next(2))
                        End If
                    End If
                End If
                ObjectSpace.CommitChanges()
            Next el
        Catch ex As Exception
            Tracing.Tracer.LogError(ex)
        End Try
    End Sub

    Private Sub CreateMarketingData()
        Tracing.Tracer.LogText("Creating Customers and Testimonials")
        Try
            Dim doc As XDocument = XDocument.Load(GetEmbeddedResourceStream("Testimonials.xml"))
            For Each el As XElement In doc.Root.Elements()
                Dim firstName As XAttribute = el.Attribute("FirstName")
                If firstName IsNot Nothing Then
                    Dim customer As Customer = ObjectSpace.FindObject(Of Customer)(New BinaryOperator("FirstName", firstName.Value))
                    If customer Is Nothing Then
                        customer = ObjectSpace.CreateObject(Of Customer)()
                        customer.FirstName = firstName.Value
                        customer.Email = customer.FirstName + "@company.com"
                        Dim lastName As XAttribute = el.Attribute("LastName")
                        If lastName IsNot Nothing Then
                            customer.LastName = lastName.Value
                        End If
                        Dim company As XAttribute = el.Attribute("Company")
                        If company IsNot Nothing Then
                            customer.Company = company.Value
                        End If
                        Dim occupation As XAttribute = el.Attribute("Occupation")
                        If occupation IsNot Nothing Then
                            customer.Occupation = occupation.Value
                        End If
                        Dim photo As XAttribute = el.Attribute("Photo")
                        If photo IsNot Nothing Then
                            customer.Photo = GetEmbeddedResourceByteArray(photo.Value)
                        Else
                            customer.Photo = GetEmbeddedResourceByteArray("Unknown-user.png")
                        End If

                        Dim testimonial As Testimonial = ObjectSpace.CreateObject(Of Testimonial)()
                        Dim quote As XAttribute = el.Attribute("Quote")
                        If quote IsNot Nothing Then
                            testimonial.Quote = quote.Value
                        End If
                        Dim highlight As XAttribute = el.Attribute("Highlight")
                        If highlight IsNot Nothing Then
                            testimonial.Highlight = highlight.Value
                        End If
                        Dim tags As XAttribute = el.Attribute("Tags")
                        If tags IsNot Nothing Then
                            testimonial.Tags = tags.Value
                        End If
                        Dim caseStudyUrl As XAttribute = el.Attribute("CaseStudyUrl")
                        If caseStudyUrl IsNot Nothing Then
                            testimonial.CaseStudyUrl = caseStudyUrl.Value
                        End If
                        testimonial.Customer = customer
                    End If
                End If
                ObjectSpace.CommitChanges()
            Next el
        Catch ex As Exception
            Tracing.Tracer.LogError(ex)
        End Try
    End Sub

    Private Function CreateProject(ByVal name As String, ByVal manager As Person) As Project
        Dim project As Project = ObjectSpace.FindObject(Of Project)(New BinaryOperator("Name", name))
        If project Is Nothing Then
            project = ObjectSpace.CreateObject(Of Project)()
            project.Name = name
            project.Manager = manager
            project.Save()
        End If
        Return project
    End Function
    Private Function CreateProjectTask(ByVal project As Project, ByVal subject As String, ByVal notes As String, ByVal status As ProjectTaskStatus, ByVal assignedTo As Person) As ProjectTask
        Dim task As ProjectTask = ObjectSpace.FindObject(Of ProjectTask)(New BinaryOperator("Subject", subject))
        If task Is Nothing Then
            task = ObjectSpace.CreateObject(Of ProjectTask)()
            task.Project = project
            task.Subject = subject
            task.Notes = notes
            task.Status = status
            task.AssignedTo = assignedTo
            If task.Status = ProjectTaskStatus.InProgress OrElse task.Status = ProjectTaskStatus.Completed Then
                task.StartDate = Date.Now.AddDays(rnd.Next(1) * (-1))
            End If
            If task.Status = ProjectTaskStatus.Completed Then
                task.EndDate = Date.Now.AddDays(rnd.Next(2))
            End If
            task.Save()
        End If
        Return task
    End Function
    Private Function CreatePerson(ByVal lastName As String, ByVal firstName As String, ByVal photo As Byte(), ByVal email As String) As Person
        Dim person As Person = ObjectSpace.FindObject(Of Person)(New BinaryOperator("FirstName", firstName))
        If person Is Nothing Then
            person = ObjectSpace.CreateObject(Of Person)()
            person.FirstName = firstName
            person.LastName = lastName
            person.Photo = photo
            person.Email = email
            If person.FirstName = "Sam" Then
                person.Birthday = New Date(1955, 12, 1)
            Else
                person.Birthday = New Date(Date.Now.Year - (20 + rnd.Next(10)), rnd.Next(11) + 1, rnd.Next(27) + 1)
            End If
            Dim workPhone1 As PhoneNumber = ObjectSpace.CreateObject(Of PhoneNumber)()
            workPhone1.Number = "(818)3383-3389"
            workPhone1.PhoneType = "Work"
            person.PhoneNumbers.Add(workPhone1)
            Dim homePhone As PhoneNumber = ObjectSpace.CreateObject(Of PhoneNumber)()
            homePhone.Number = "(818)3383-3383"
            homePhone.PhoneType = "Home"
            person.PhoneNumbers.Add(homePhone)
            Dim address As Address = ObjectSpace.CreateObject(Of Address)()
            Dim country As Country = ObjectSpace.FindObject(Of Country)(CriteriaOperator.Parse("Name='USA'"))
            If country Is Nothing Then
                country = ObjectSpace.CreateObject(Of Country)()

                country.Name = "USA"
                country.PhoneCode = "1"
            End If
            address.Country = country
            address.City = "Glendale"
            address.ZipPostal = "91203"
            address.StateProvince = "CA"
            address.Street = "505 N. Brand Blvd, 16th Floor"
            person.Address1 = address
            person.Save()
        End If
        Return person
    End Function
End Class
