Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Windows.Media
Imports System.Windows.Media.Imaging
Imports DevExpress.DemoData.Models
Imports DevExpress.Mvvm.DataAnnotations
Imports DevExpress.Mvvm.Native
Imports DevExpress.Mvvm.POCO

Namespace DockingDemo.ViewModels
    Public Class DashboardViewModel
        Public Sub New()
            Teams = DashboardViewModelData.GetTeams()
            CurrentTeam = Teams(0)
        End Sub

        <BindableProperty(OnPropertyChangedMethodName := "OnCurrentTeamChanged")>
        Public Overridable Property CurrentTeam() As Team
        Public Property Teams() As List(Of Team)

        Protected Sub OnCurrentTeamChanged()
            If CurrentTeam.CurrentProject Is Nothing Then
                CurrentTeam.CurrentProject = CurrentTeam.Projects(0)
            End If
        End Sub
    End Class
    Public Class Team
        Protected Sub New(ByVal name As String)
            Me.Name = name
            Projects = New List(Of Project)()
            Members = New List(Of Person)()
        End Sub
        Public Overridable Property CurrentProject() As Project
        Public ReadOnly Property Lead() As Person
            Get
                Return Members(0)
            End Get
        End Property
        Private privateMembers As List(Of Person)
        Public Property Members() As List(Of Person)
            Get
                Return privateMembers
            End Get
            Private Set(ByVal value As List(Of Person))
                privateMembers = value
            End Set
        End Property
        Private privateName As String
        Public Property Name() As String
            Get
                Return privateName
            End Get
            Private Set(ByVal value As String)
                privateName = value
            End Set
        End Property
        Private privateProjects As List(Of Project)
        Public Property Projects() As List(Of Project)
            Get
                Return privateProjects
            End Get
            Private Set(ByVal value As List(Of Project))
                privateProjects = value
            End Set
        End Property

        Public Shared Function Create(ByVal teamName As String) As Team
            Return ViewModelSource.Create(Function() New Team(teamName))
        End Function
        Public Sub AddMembers(ParamArray ByVal members() As Person)
            Me.Members.AddRange(members)
        End Sub
        Public Sub AddProjects(ParamArray ByVal projects() As Project)
            Me.Projects.AddRange(projects)
            If CurrentProject Is Nothing Then
                CurrentProject = Me.Projects(0)
            End If
        End Sub
    End Class
    Public Class Person
        Private ReadOnly employee As DevExpress.DemoData.Models.Employee


        Protected Sub New(ByVal employee_Renamed As DevExpress.DemoData.Models.Employee)
            Me.employee = employee_Renamed
        End Sub

        Public ReadOnly Property Address() As String
            Get
                Return employee.Address
            End Get
        End Property
        Public ReadOnly Property Email() As String
            Get
                Return employee.Email
            End Get
        End Property
        Public ReadOnly Property FullName() As String
            Get
                Return employee.FullName
            End Get
        End Property
        Private privateJobTitle As String
        Public Property JobTitle() As String
            Get
                Return privateJobTitle
            End Get
            Private Set(ByVal value As String)
                privateJobTitle = value
            End Set
        End Property
        Public ReadOnly Property Phone() As String
            Get
                Return employee.HomePhone
            End Get
        End Property
        Public ReadOnly Property Photo() As Byte()
            Get
                Return employee.Photo
            End Get
        End Property


        Public Shared Function Create(ByVal employee_Renamed As DevExpress.DemoData.Models.Employee) As Person

            Dim person_Renamed = ViewModelSource.Create(Function() New Person(employee_Renamed))
            person_Renamed.JobTitle = titles(titleRandom.Next(titles.Length))
            Return person_Renamed
        End Function
        Private Shared titles() As String = { "Developer", "Designer", "Support Developer", "Technical Writer" }
        Private Shared titleRandom As New Random()

    End Class
    Public Class Project
        Public Sub New(ByVal title As String)
            Me.Title = title
        End Sub

        Public Property BugsTotal() As Integer
        Public Property History() As ImageSource
        Public Property IssuesTotal() As Integer
        Public Property Title() As String
    End Class
    #Region "SampleData"
    Public NotInheritable Class DashboardViewModelData

        Private Sub New()
        End Sub

        Public Shared Function GetTeams() As List(Of Team)
            Return CreateSampleData()
        End Function
        Private Shared Function CreateSampleData() As List(Of Team)

            Dim project1 As New Project("Billing System") With {.BugsTotal = 15, .IssuesTotal = 27, .History = New BitmapImage(New Uri("/DockingDemo;component/Images/Dashboard/history1.png", UriKind.Relative))}
            Dim project2 As New Project("Contract Management System") With {.BugsTotal = 15, .IssuesTotal = 24, .History = New BitmapImage(New Uri("/DockingDemo;component/Images/Dashboard/history2.png", UriKind.Relative))}
            Dim project3 As New Project("Internal Software") With {.BugsTotal = 40, .IssuesTotal = 50, .History = New BitmapImage(New Uri("/DockingDemo;component/Images/Dashboard/history3.png", UriKind.Relative))}
            Dim project4 As New Project("Company WebSite") With {.BugsTotal = 20, .IssuesTotal = 22, .History = New BitmapImage(New Uri("/DockingDemo;component/Images/Dashboard/history4.png", UriKind.Relative))}

            Dim employees = NWindContext.Create().Employees.AsEnumerable().Reverse().Select(Function(x) Person.Create(x))

            Dim badBoysTeam As Team = Team.Create("Bad Boys")
            badBoysTeam.AddProjects(project1, project2)
            badBoysTeam.AddMembers(employees.Take(5).OrderBy(Function(x) x.JobTitle).ToArray())

            Dim dreamGirlsTeam As Team = Team.Create("Dream Girls")
            dreamGirlsTeam.AddProjects(project3, project4)
            dreamGirlsTeam.AddMembers(employees.Skip(5).OrderBy(Function(x) x.JobTitle).ToArray())

            Return New List(Of Team)() From {badBoysTeam, dreamGirlsTeam}
        End Function
    End Class
    #End Region ' SampleData
End Namespace
