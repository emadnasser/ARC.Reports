Imports DevExpress.Xpf.Core.Native
Imports System
Imports System.Collections.Generic
Imports System.Collections.ObjectModel
Imports System.Data
Imports System.IO
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Xml
Imports Task = ProductsDemo.Modules.Task

Namespace ProductsDemo.Modules
    Public Class DataBaseHelper
        Private Shared instanse As DataBaseHelper = Nothing
        Public Shared ReadOnly Property Instance() As DataBaseHelper
            Get
                If instanse Is Nothing Then
                    instanse = New DataBaseHelper()
                End If
                Return instanse
            End Get
        End Property

        Private Sub New()
            Contacts = FillContacts()
            FillAppointments()
            Tasks = FillTasks()
        End Sub

        Private Function FillTasks() As List(Of Task)
            Dim ret As New List(Of Task)()
            For i As Integer = 0 To TaskGenerator.CustomerCount - 1
                For Each s As String In CollectionResources.OfficeTasks
                    ret.Add(TaskGenerator.CreateTask(s, TaskCategory.Work))
                Next s
            Next i
            For Each s As String In CollectionResources.HouseTasks
                ret.Add(TaskGenerator.CreateTask(s, TaskCategory.HouseChores))
            Next s
            For Each s As String In CollectionResources.ShoppingTasks
                ret.Add(TaskGenerator.CreateTask(s, TaskCategory.Shopping))
            Next s
            Return ret
        End Function
        Private Function FillContacts() As List(Of Contact)
            Dim doc As New XmlDocument()

            Dim contacts_Renamed As New List(Of Contact)()
            Dim customers As XmlNodeList = Nothing
            Dim names As XmlNodeList = Nothing
            Dim contact As Contact = Nothing
            Try
                Dim fileName As String = Utils.GetRelativePath("VideoRent.xml")
                doc.Load(fileName)
                customers = doc.GetElementsByTagName("Customer")
                names = doc.GetElementsByTagName("Person")
            Catch e1 As Exception
                Return contacts_Renamed
            End Try
            For Each customer As XmlNode In customers
                contact = New Contact()
                contact.Name = New Name()
                contact.Name.MiddleName = customer("MiddleName").InnerText
                contact.Email = customer("Email").ChildNodes(0).Value
                contact.Email = contact.Email.Replace("dxvideorent.com", "dxmail.net")
                contact.Address = New Address(customer("Address").ChildNodes(0).Value)
                contact.Phone = customer("Phone").ChildNodes(0).Value
                contact.Activity = GetContactActivity(customer("CustomerId").InnerText)
                If customer("Photo") IsNot Nothing Then
                    contact.Photo = ImageHelper.CreateImageFromStream(New MemoryStream(Convert.FromBase64String(customer("Photo").ChildNodes(0).Value)))
                End If
                FillPersonInformation(contact, names, customer("Oid").ChildNodes(0).Value)
                contacts_Renamed.Add(contact)
            Next customer
            Return contacts_Renamed
        End Function
        Private Function GetContactActivity(ByVal customerId As String) As List(Of Integer)
            Dim activity As New List(Of Integer)()
            Dim seed As Integer = Integer.Parse(customerId)
            Dim rnd As New Random(seed)
            For i As Integer = 0 To 5
                activity.Add(rnd.Next(0, 10))
            Next i
            Return activity
        End Function
        Private Sub FillPersonInformation(ByVal contact As Contact, ByVal names As XmlNodeList, ByVal id As String)
            For Each customer As XmlNode In names
                If customer("Oid").ChildNodes(0).Value = id Then
                    contact.Name.FirstName = customer("FirstName").ChildNodes(0).Value
                    contact.Name.LastName = customer("LastName").ChildNodes(0).Value
                    contact.Gender = DirectCast(System.Enum.Parse(GetType(ContactGender), customer("Gender").ChildNodes(0).Value), ContactGender)
                    Dim birthDate As String = customer("BirthDate").ChildNodes(0).Value
                    contact.BirthDate = New Date(Convert.ToInt32(birthDate.Substring(0, 4)), Convert.ToInt32(birthDate.Substring(5, 2)), Convert.ToInt32(birthDate.Substring(8, 2)))
                End If
            Next customer
        End Sub
        Private Sub FillAppointments()
            Appointments = New ObservableCollection(Of Appointment)()
            Dim appointmentsTable As DataTable = CreateDataTable("Appointments")
            If appointmentsTable IsNot Nothing AndAlso appointmentsTable.Rows.Count > 0 Then
                For Each row As DataRow In appointmentsTable.Rows
                    Appointments.Add(CreateAppointment(row))
                Next row
            End If
        End Sub
        Private Function CreateDataTable(ByVal table As String) As DataTable
            Dim dataSet As New DataSet()
            Try
                Dim dataFile As String = Utils.GetRelativePath("Mail.xml")
                If dataFile <> String.Empty Then
                    Dim fi As New FileInfo(dataFile)
                    dataSet.ReadXml(fi.FullName)
                    Return dataSet.Tables(table)
                End If
            Catch e1 As Exception
            End Try
            Return Nothing
        End Function
        Private Function CreateAppointment(ByVal row As DataRow) As Appointment
            Dim appointment As New Appointment()
            appointment.EventType = DirectCast(row("EventType"), Integer?)
            appointment.StartDate = DirectCast(row("StartDate"), Date?)
            appointment.EndDate = DirectCast(row("EndDate"), Date?)
            appointment.AllDay = DirectCast(row("AllDay"), Boolean?)
            appointment.Subject = Convert.ToString(row("Subject"))
            appointment.Location = Convert.ToString(row("Location"))
            appointment.Description = Convert.ToString(row("Description"))
            appointment.Status = DirectCast(row("Status"), Integer?)
            appointment.Label = DirectCast(row("Label"), Integer?)
            appointment.RecurrenceInfo = Convert.ToString(row("RecurrenceInfo"))
            appointment.ReminderInfo = Convert.ToString(row("ReminderInfo"))
            appointment.ContactInfo = Convert.ToString(row("ContactInfo"))
            Return appointment
        End Function

        Private privateContacts As List(Of Contact)
        Public Property Contacts() As List(Of Contact)
            Get
                Return privateContacts
            End Get
            Private Set(ByVal value As List(Of Contact))
                privateContacts = value
            End Set
        End Property
        Private privateTasks As List(Of ProductsDemo.Modules.Task)
        Public Property Tasks() As List(Of ProductsDemo.Modules.Task)
            Get
                Return privateTasks
            End Get
            Private Set(ByVal value As List(Of ProductsDemo.Modules.Task))
                privateTasks = value
            End Set
        End Property
        Private privateAppointments As ObservableCollection(Of Appointment)
        Public Property Appointments() As ObservableCollection(Of Appointment)
            Get
                Return privateAppointments
            End Get
            Private Set(ByVal value As ObservableCollection(Of Appointment))
                privateAppointments = value
            End Set
        End Property
    End Class

    Friend Class TaskGenerator
        Public Shared CustomerCount As Integer = 10
        Private Shared rndGenerator As New Random()

        Private Shared customers_Renamed As List(Of Contact)
        Friend Shared ReadOnly Property Customers() As List(Of Contact)
            Get
                If customers_Renamed Is Nothing Then
                    customers_Renamed = New List(Of Contact)()
                    Dim temp As List(Of Contact) = DataBaseHelper.Instance.Contacts
                    If temp.Count > CustomerCount Then
                        Do While customers_Renamed.Count < CustomerCount
                            Dim contact As Contact = GetCustomer(rndGenerator.Next(temp.Count - 1), customers_Renamed, temp)
                            If contact IsNot Nothing Then
                                customers_Renamed.Add(contact)
                            End If
                        Loop
                    End If
                End If
                Return customers_Renamed
            End Get
        End Property
        Private Shared Function GetCustomer(ByVal index As Integer, ByVal customers As List(Of Contact), ByVal contacts As List(Of Contact)) As Contact
            Dim contact As Contact = contacts(index)
            For Each c As Contact In customers
                If ReferenceEquals(c, contact) Then
                    Return Nothing
                End If
            Next c
            Return contact
        End Function
        Public Shared Function CreateTask(ByVal subject As String, ByVal category As TaskCategory) As Task
            Dim task As New Task(subject, category, Date.Now.AddHours(-rndGenerator.Next(96)))
            Dim rndStatus As Integer = rndGenerator.Next(10)
            If task.TimeDiff.TotalHours > 12 Then
                If task.TimeDiff.TotalHours > 80 Then
                    task.Status = TaskStatus.Completed

                Else
                    task.Status = TaskStatus.InProgress
                    task.PercentComplete = rndGenerator.Next(9) * 10
                End If
                task.StartDate = task.CreatedDate.AddMinutes(rndGenerator.Next(720)).Date
            End If
            If rndStatus <> 5 Then
                task.DueDate = task.CreatedDate.AddHours((90 - rndStatus * 9) + 24).Date
            End If
            If rndStatus > 8 Then
                task.Priority = TaskPriority.High
            End If
            If rndStatus < 3 Then
                task.Priority = TaskPriority.Low
            End If
            If rndStatus = 6 AndAlso task.Status = TaskStatus.InProgress Then
                task.Status = TaskStatus.Deferred
            End If
            If rndStatus = 4 AndAlso task.Status = TaskStatus.InProgress AndAlso task.PercentComplete < 40 Then
                task.Status = TaskStatus.WaitingOnSomeoneElse
            End If
            If task.Category = TaskCategory.Work AndAlso rndStatus <> 7 AndAlso Customers.Count > 0 Then
                task.AssignTo = Customers(rndGenerator.Next(Customers.Count))
            End If
            If task.Status = TaskStatus.Completed Then
                If task.StartDate Is Nothing Then
                    task.StartDate = task.CreatedDate.AddHours(12).Date
                End If
                task.CompletedDate = task.StartDate.Value.AddHours(rndGenerator.Next(48) + 24)
            End If
            Return task
        End Function
    End Class

    Public Class CollectionResources
        Public Shared HouseTasks As New List(Of String)() From {"Set-up home theater (surround sound) system", "Install 3 overhead lights in bedroom", "Change light bulbs in backyard", "Install a programmable thermostat", "Install ceiling fan in John's bedroom", "Install LED lights in kitchen", "Check wiring in main electricity panel", "Replace master bedroom light switch with dimmer", "Install an new electric outlet in garage", "Install electric outlet and ethernet drop in closet", "Install chandelier in dining room", "Hook up DVD Player to TV for kids", "Clean the House top to bottom", "Light cleaning of the house", "Clean the entire house", "Clean and organize basement", "Pick up clothes for charity event", "Ironing, laundry and vacuuming", "Take kids to park and play baseball on Sunday", "Clean art studio", "Bake brownies and send them to neighbors", "Assemble Kitchen Cart", "Move piano", "Clean backyard", "Clean out garage", "Organize guest bedroom", "Clean out closet", "Preapre for yard sale", "Sorting clothing for give-away", "Organize Storage Room"}
        Public Shared ShoppingTasks As New List(Of String)() From {"Shopping at Macy's", "Return coffee machine", "Purchase plastic trash bins", "Shop for dinner ingredients at the store", "Buy new utensils for kitchen", "Send post card to Timothy", "Buy dining table and TV stand online", "Buy ingredients for Pasta Bolognese", "Size 3 diapers (3 cases)", "Order 3 pizzas", "Find out where to buy the new tablet", "Buy broccoli and tomatoes", "Buy bottle of Champagne", "Grocery shopping at Market Basket", "Find a bike at a store close to me", "Return jeans at JCrew", "Buy dog food for Fido", "Buy rigid foam insulation", "Purchase 3 24-packs of bottled Coke", "Purchase & deliver flowers to my home"}
        Public Shared OfficeTasks As New List(Of String)() From {"Input bank statement transactions into Excel spreadsheet", "Schedule appointments and pay bills", "Place new address stickers on envelopes", "Set up and arrange appointments", "Copy PDF file into Word", "Organize business expenses (last 6 months)", "Return samples to vendor", "Organize receipts and match them up with business expenses and trips ", "File papers and receipts", "Ship out CDs to customers", "Respond to e-mails until noon", "Enter expenses into an online accounting system", "Conduct inventory of all furniture in office", "Arrange travel to conference", "Staple flyers to gift bags", "File and shred mail", "Print copies of brochures", "Enter all receipts into an Excel spreadsheet", "Research possible vendors", "Sort through paper receipts", "Re-package products for retail sale", "Scan docs, and put in desktop folder", "Print registration stickers"}
    End Class
End Namespace
