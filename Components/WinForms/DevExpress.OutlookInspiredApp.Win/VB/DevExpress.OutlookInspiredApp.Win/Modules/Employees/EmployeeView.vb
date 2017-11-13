Imports DevExpress.XtraLayout.Utils
Imports DevExpress.XtraBars.Docking2010
Imports DevExpress.DevAV.ViewModels
Imports DevExpress.DevAV

Namespace DevExpress.DevAV.Modules

    Partial Public Class EmployeeView
        Inherits BaseModuleControl

        Public Sub New()
            MyBase.New(GetType(SynchronizedEmployeeViewModel))
            InitializeComponent()
            gvTasks.SetViewFontSize(2, 1)
            gvEvaluations.SetViewFontSize(2, 1)
            BindCommands()
            AddHandler ViewModel.EntityChanged, AddressOf ViewModel_EntityChanged
            lbEvaluations.Tag = True
            lbTasks.Tag = False
            AddHandler CType(New LabelTabController(lbTasks.Tag, lbEvaluations, lbTasks), LabelTabController).EditValueChanged, Sub(s, e)
                lciEvaluations.Visibility = If(CBool(s), LayoutVisibility.Always, LayoutVisibility.Never)
                lciTasks.Visibility = If((Not CBool(s)), LayoutVisibility.Always, LayoutVisibility.Never)
            End Sub
        End Sub
        Protected Overrides Sub OnDisposing()
            RemoveHandler ViewModel.EntityChanged, AddressOf ViewModel_EntityChanged
            MyBase.OnDisposing()
        End Sub
        Public ReadOnly Overloads Property ViewModel() As EmployeeViewModel
            Get
                Return GetViewModel(Of EmployeeViewModel)()
            End Get
        End Property
        Private Sub ViewModel_EntityChanged(ByVal sender As Object, ByVal e As System.EventArgs)
            QueueUIUpdate()
        End Sub
        Protected Overrides Sub OnDelayedUIUpdate()
            UpdateUI(ViewModel.Entity)
        End Sub
        Protected Overrides Sub OnLoad(ByVal e As System.EventArgs)
            MyBase.OnLoad(e)
            UpdateUI(ViewModel.Entity)
        End Sub
        Private Sub BindCommands()
            Dim fluent = mvvmContext.OfType(Of EmployeeViewModel)()
            fluent.BindCommand(ContactButton(0), Sub(x) x.Contacts.Message())
            fluent.BindCommand(ContactButton(1), Sub(x) x.Contacts.Phone())
            fluent.BindCommand(ContactButton(2), Sub(x) x.Contacts.VideoCall())
            fluent.BindCommand(ContactButton(3), Sub(x) x.Contacts.MailTo())
        End Sub
        Private Function ContactButton(ByVal index As Integer) As WindowsUIButton
            Return CType(buttonPanel.Buttons(index), WindowsUIButton)
        End Function
        Private Sub UpdateUI(ByVal employee As Employee)
            If employee IsNot Nothing Then
                If Not Object.Equals(bindingSource.DataSource, employee) Then
                    bindingSource.DataSource = employee
                Else
                    employee.ResetBindable()
                    bindingSource.ResetBindings(False)
                End If
                gcTasks.DataSource = employee.AssignedTasks
                gcEvaluations.DataSource = employee.Evaluations
            Else
                gcTasks.DataSource = Nothing
                gcEvaluations.DataSource = Nothing
            End If
            modueLayout.Visible = (employee IsNot Nothing)
        End Sub
        Public Property IsHorizontalLayout() As Boolean
            Get
                Return Not colDescription.Visible
            End Get
            Set(ByVal value As Boolean)
                gvEvaluations.OptionsView.ShowPreview = value
                gvTasks.OptionsView.ShowPreview = value
                colDescription.Visible = Not value
            End Set
        End Property
    End Class
End Namespace
