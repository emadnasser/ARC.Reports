Imports Microsoft.VisualBasic
Imports System

Imports DevExpress.Data.Filtering
Imports DevExpress.Xpo
Imports DevExpress.ExpressApp
Imports DevExpress.Persistent.BaseImpl
Imports DevExpress.ExpressApp.Security
Imports DevExpress.ExpressApp.PivotChart
Imports DevExpress.ExpressApp.Xpo
Imports DevExpress.ExpressApp.Updating
Imports DevExpress.Persistent.Base
Imports System.Data.SqlClient
Imports MainDemo.Module.BusinessObjects
Imports DevExpress.Persistent.BaseImpl.PermissionPolicy

Namespace MainDemo.Module.DatabaseUpdate
    Public Class Updater
        Inherits ModuleUpdater
        Public Sub New(ByVal objectSpace As IObjectSpace, ByVal currentDBVersion As Version)
            MyBase.New(objectSpace, currentDBVersion)
        End Sub
        Public Overrides Sub UpdateDatabaseAfterUpdateSchema()
            MyBase.UpdateDatabaseAfterUpdateSchema()

            If Not UpdateBusinessObjectsNamespace() Then

                UpdateAnalysisCriteriaColumn()

                Dim developerPosition As Position = ObjectSpace.FindObject(Of Position)(CriteriaOperator.Parse("Title == 'Developer'"))
                If developerPosition Is Nothing Then
                    developerPosition = ObjectSpace.CreateObject(Of Position)()
                    developerPosition.Title = "Developer"
                End If
                Dim managerPosition As Position = ObjectSpace.FindObject(Of Position)(CriteriaOperator.Parse("Title == 'Manager'"))
                If managerPosition Is Nothing Then
                    managerPosition = ObjectSpace.CreateObject(Of Position)()
                    managerPosition.Title = "Manager"
                End If

                Dim devDepartment As Department = ObjectSpace.FindObject(Of Department)(CriteriaOperator.Parse("Title == 'Development Department'"))
                If devDepartment Is Nothing Then
                    devDepartment = ObjectSpace.CreateObject(Of Department)()
                    devDepartment.Title = "Development Department"
                    devDepartment.Office = "205"
                    devDepartment.Positions.Add(developerPosition)
                    devDepartment.Positions.Add(managerPosition)
                End If

                Dim contactMary As Contact = ObjectSpace.FindObject(Of Contact)(CriteriaOperator.Parse("FirstName == 'Mary' && LastName == 'Tellitson'"))
                If contactMary Is Nothing Then
                    contactMary = ObjectSpace.CreateObject(Of Contact)()
                    contactMary.FirstName = "Mary"
                    contactMary.LastName = "Tellitson"
                    contactMary.Email = "mary_tellitson@md.com"
                    contactMary.Birthday = New DateTime(1980, 11, 27)
                    contactMary.Department = devDepartment
                    contactMary.Position = managerPosition
                End If

                Dim contactJohn As Contact = ObjectSpace.FindObject(Of Contact)(CriteriaOperator.Parse("FirstName == 'John' && LastName == 'Nilsen'"))
                If contactJohn Is Nothing Then
                    contactJohn = ObjectSpace.CreateObject(Of Contact)()
                    contactJohn.FirstName = "John"
                    contactJohn.LastName = "Nilsen"
                    contactJohn.Email = "john_nilsen@md.com"
                    contactJohn.Birthday = New DateTime(1981, 10, 3)
                    contactJohn.Department = devDepartment
                    contactJohn.Position = developerPosition
                End If

                If ObjectSpace.FindObject(Of DemoTask)(CriteriaOperator.Parse("Subject == 'Review reports'")) Is Nothing Then
                    Dim task As DemoTask = ObjectSpace.CreateObject(Of DemoTask)()
                    task.Subject = "Review reports"
                    task.AssignedTo = contactJohn
                    task.StartDate = DateTime.Parse("May 03, 2008")
                    task.DueDate = DateTime.Parse("September 06, 2008")
                    task.Status = DevExpress.Persistent.Base.General.TaskStatus.InProgress
                    task.Priority = Priority.High
                    task.EstimatedWork = 60
                    task.Description = "Analyse the reports and assign new tasks to employees."
                End If

                If ObjectSpace.FindObject(Of DemoTask)(CriteriaOperator.Parse("Subject == 'Fix breakfast'")) Is Nothing Then
                    Dim task As DemoTask = ObjectSpace.CreateObject(Of DemoTask)()
                    task.Subject = "Fix breakfast"
                    task.AssignedTo = contactMary
                    task.StartDate = DateTime.Parse("May 03, 2008")
                    task.DueDate = DateTime.Parse("May 04, 2008")
                    task.Status = DevExpress.Persistent.Base.General.TaskStatus.Completed
                    task.Priority = Priority.Low
                    task.EstimatedWork = 1
                    task.ActualWork = 3
                    task.Description = "The Development Department - by 9 a.m." & Constants.vbCrLf & "The R&QA Department - by 10 a.m."
                End If
                If ObjectSpace.FindObject(Of DemoTask)(CriteriaOperator.Parse("Subject == 'Task1'")) Is Nothing Then
                    Dim task As DemoTask = ObjectSpace.CreateObject(Of DemoTask)()
                    task.Subject = "Task1"
                    task.AssignedTo = contactJohn
                    task.StartDate = DateTime.Parse("June 03, 2008")
                    task.DueDate = DateTime.Parse("June 06, 2008")
                    task.Status = DevExpress.Persistent.Base.General.TaskStatus.Completed
                    task.Priority = Priority.High
                    task.EstimatedWork = 10
                    task.ActualWork = 15
                    task.Description = "A task designed specially to demonstrate the PivotChart module. Switch to the Reports navigation group to view the generated analysis."
                End If
                If ObjectSpace.FindObject(Of DemoTask)(CriteriaOperator.Parse("Subject == 'Task2'")) Is Nothing Then
                    Dim task As DemoTask = ObjectSpace.CreateObject(Of DemoTask)()
                    task.Subject = "Task2"
                    task.AssignedTo = contactJohn
                    task.StartDate = DateTime.Parse("July 03, 2008")
                    task.DueDate = DateTime.Parse("July 06, 2008")
                    task.Status = DevExpress.Persistent.Base.General.TaskStatus.Completed
                    task.Priority = Priority.Low
                    task.EstimatedWork = 8
                    task.ActualWork = 16
                    task.Description = "A task designed specially to demonstrate the PivotChart module. Switch to the Reports navigation group to view the generated analysis."
                End If
                CreateDataToBeAnalysed()

                '			#Region "Create a User for the Simple Security Strategy"
                '// If a simple user named 'Sam' doesn't exist in the database, create this simple user
                'SecuritySimpleUser adminUser = Session.FindObject<SecuritySimpleUser)(new BinaryOperator("UserName", "Sam"))
                'if(adminUser == null) {
                '    adminUser = new SecuritySimpleUser(Session)
                '    adminUser.UserName = "Sam"
                '}
                '// Make the user an administrator
                'adminUser.IsAdministrator = true
                '// Set a password if the standard authentication type is used
                'adminUser.SetPassword("")
                '			#End Region

                '			#Region "Create Users for the Complex Security Strategy"
                ' If a user named 'Sam' doesn't exist in the database, create this user
                Dim user1 As PermissionPolicyUser = ObjectSpace.FindObject(Of PermissionPolicyUser)(New BinaryOperator("UserName", "Sam"))
                If user1 Is Nothing Then
                    user1 = ObjectSpace.CreateObject(Of PermissionPolicyUser)()
                    user1.UserName = "Sam"
                    ' Set a password if the standard authentication type is used
                    user1.SetPassword("")
                End If
                ' If a user named 'John' doesn't exist in the database, create this user
                Dim user2 As PermissionPolicyUser = ObjectSpace.FindObject(Of PermissionPolicyUser)(New BinaryOperator("UserName", "John"))
                If user2 Is Nothing Then
                    user2 = ObjectSpace.CreateObject(Of PermissionPolicyUser)()
                    user2.UserName = "John"
                    ' Set a password if the standard authentication type is used
                    user2.SetPassword("")
                End If
                ' If a role with the Administrators name doesn't exist in the database, create this role
                Dim adminRole As PermissionPolicyRole = ObjectSpace.FindObject(Of PermissionPolicyRole)(New BinaryOperator("Name", "Administrators"))
                If adminRole Is Nothing Then
                    adminRole = ObjectSpace.CreateObject(Of PermissionPolicyRole)()
                    adminRole.Name = "Administrators"
                End If
                ' If a role with the Users name doesn't exist in the database, create this role
                Dim userRole As PermissionPolicyRole = ObjectSpace.FindObject(Of PermissionPolicyRole)(New BinaryOperator("Name", "Users"))
                If userRole Is Nothing Then
                    userRole = ObjectSpace.CreateObject(Of PermissionPolicyRole)()
                    userRole.Name = "Users"
                    userRole.PermissionPolicy = SecurityPermissionPolicy.AllowAllByDefault
                    userRole.AddTypePermission(Of PermissionPolicyRole)(SecurityOperations.FullAccess, SecurityPermissionState.Deny)
                    userRole.AddTypePermission(Of PermissionPolicyUser)(SecurityOperations.FullAccess, SecurityPermissionState.Deny)
                    userRole.AddObjectPermission(Of PermissionPolicyUser)(SecurityOperations.ReadOnlyAccess, "[Oid] = CurrentUserId()", SecurityPermissionState.Allow)
                    userRole.AddMemberPermission(Of PermissionPolicyUser)(SecurityOperations.Write, "ChangePasswordOnFirstLogon", Nothing, SecurityPermissionState.Allow)
                    userRole.AddMemberPermission(Of PermissionPolicyUser)(SecurityOperations.Write, "StoredPassword", Nothing, SecurityPermissionState.Allow)
                    userRole.AddTypePermission(Of PermissionPolicyRole)(SecurityOperations.Read, SecurityPermissionState.Allow)
                    userRole.AddTypePermission(Of PermissionPolicyTypePermissionObject)("Write;Delete;Navigate;Create", SecurityPermissionState.Deny)
                    userRole.AddTypePermission(Of PermissionPolicyMemberPermissionsObject)("Write;Delete;Navigate;Create", SecurityPermissionState.Deny)
                    userRole.AddTypePermission(Of PermissionPolicyObjectPermissionsObject)("Write;Delete;Navigate;Create", SecurityPermissionState.Deny)
                End If
                adminRole.IsAdministrative = True

                ' Add the Administrators role to the user1
                user1.Roles.Add(adminRole)
                ' Add the Users role to the user2
                user2.Roles.Add(userRole)
                '			#End Region

                ObjectSpace.CommitChanges()
            End If
        End Sub
        Private Sub CreateDataToBeAnalysed()
            Dim taskAnalysis1 As Analysis = ObjectSpace.FindObject(Of Analysis)(CriteriaOperator.Parse("Name='Completed tasks'"))
            If taskAnalysis1 Is Nothing Then
                taskAnalysis1 = ObjectSpace.CreateObject(Of Analysis)()
                taskAnalysis1.Name = "Completed tasks"
                taskAnalysis1.ObjectTypeName = GetType(DemoTask).FullName
                taskAnalysis1.Criteria = "[Status] = 'Completed'"
            End If
            Dim taskAnalysis2 As Analysis = ObjectSpace.FindObject(Of Analysis)(CriteriaOperator.Parse("Name='Estimated and actual work comparison'"))
            If taskAnalysis2 Is Nothing Then
                taskAnalysis2 = ObjectSpace.CreateObject(Of Analysis)()
                taskAnalysis2.Name = "Estimated and actual work comparison"
                taskAnalysis2.ObjectTypeName = GetType(DemoTask).FullName
            End If
        End Sub
        Private Sub UpdateAnalysisCriteriaColumn()
            If TypeOf DirectCast(ObjectSpace, XPObjectSpace).Session.Connection Is SqlConnection Then
                Dim length As Integer = CInt(Fix(ExecuteScalarCommand("select CHARACTER_MAXIMUM_LENGTH from INFORMATION_SCHEMA.Columns WHERE TABLE_NAME = 'Analysis' AND COLUMN_NAME = 'Criteria'", True)))
                If length <> -1 Then
                    ExecuteNonQueryCommand("alter table Analysis alter column Criteria nvarchar(max)", True)
                End If
            End If
        End Sub
        Private Function UpdateBusinessObjectsNamespace() As Boolean
            UpdateXPObjectType("MainDemo.Module.Contact", "MainDemo.Module.BusinessObjects.Contact", "MainDemo.Module")
            UpdateXPObjectType("MainDemo.Module.Department", "MainDemo.Module.BusinessObjects.Department", "MainDemo.Module")
            UpdateXPObjectType("MainDemo.Module.Position", "MainDemo.Module.BusinessObjects.Position", "MainDemo.Module")
            UpdateXPObjectType("MainDemo.Module.DemoTask", "MainDemo.Module.BusinessObjects.DemoTask", "MainDemo.Module")
            UpdateXPObjectType("MainDemo.Module.Payment", "MainDemo.Module.BusinessObjects.Payment", "MainDemo.Module")
            UpdateXPObjectType("MainDemo.Module.Resume", "MainDemo.Module.BusinessObjects.Resume", "MainDemo.Module")
            Dim isUpdated As Boolean = False
            For Each analysis As Analysis In ObjectSpace.GetObjects(Of Analysis)(ObjectSpace.ParseCriteria("StartsWith([ObjectTypeName], 'MainDemo.Module.')"))
                If Not analysis.ObjectTypeName.StartsWith("MainDemo.Module.BusinessObjects.") Then
                    analysis.ObjectTypeName = analysis.ObjectTypeName.Replace("MainDemo.Module.", "MainDemo.Module.BusinessObjects.")
                    isUpdated = True
                End If
            Next
            Return isUpdated
        End Function
    End Class
    Public MustInherit Class TaskAnalysis1LayoutUpdaterBase
        Protected MustOverride Function CreateAnalysisControl() As IAnalysisControl
        Protected MustOverride Function CreatePivotGridSettingsStore(ByVal control As IAnalysisControl) As IPivotGridSettingsStore
        Public Sub Update(ByVal analysis As Analysis)
            If analysis IsNot Nothing AndAlso (Not PivotGridSettingsHelper.HasPivotGridSettings(analysis)) Then
                Dim control As IAnalysisControl = CreateAnalysisControl()
                control.DataSource = New AnalysisDataSource(analysis, New XPCollection(Of DemoTask)(analysis.Session))
                control.Fields("Priority").Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
                control.Fields("Subject").Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
                control.Fields("AssignedTo.DisplayName").Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
                PivotGridSettingsHelper.SavePivotGridSettings(CreatePivotGridSettingsStore(control), analysis)
            End If
        End Sub
    End Class
    Public MustInherit Class TaskAnalysis2LayoutUpdaterBase
        Protected MustOverride Function CreateAnalysisControl() As IAnalysisControl
        Protected MustOverride Function CreatePivotGridSettingsStore(ByVal control As IAnalysisControl) As IPivotGridSettingsStore
        Public Sub Update(ByVal analysis As Analysis)
            If analysis IsNot Nothing AndAlso (Not PivotGridSettingsHelper.HasPivotGridSettings(analysis)) Then
                Dim control As IAnalysisControl = CreateAnalysisControl()
                control.DataSource = New AnalysisDataSource(analysis, New XPCollection(Of DemoTask)(analysis.Session))
                control.Fields("Status").Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
                control.Fields("Priority").Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
                control.Fields("EstimatedWork").Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
                control.Fields("ActualWork").Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
                control.Fields("AssignedTo.DisplayName").Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
                PivotGridSettingsHelper.SavePivotGridSettings(CreatePivotGridSettingsStore(control), analysis)
            End If
        End Sub
    End Class
End Namespace
