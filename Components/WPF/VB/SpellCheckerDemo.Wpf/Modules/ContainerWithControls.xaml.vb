Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Net
Imports System.Windows
Imports System.Windows.Controls
Imports System.Windows.Documents
Imports System.Windows.Input
Imports System.Windows.Media
Imports System.Windows.Media.Animation
Imports System.Windows.Shapes
Imports DevExpress.XtraRichEdit.Commands

Namespace SpellCheckerDemo
    Partial Public Class ContainerWithControls
        Inherits SpellCheckerDemoModule

        Public Shared ReadOnly EmployeeProperty As DependencyProperty

        Shared Sub New()
            EmployeeProperty = DependencyProperty.Register("Employee", GetType(Employees), GetType(ContainerWithControls), New PropertyMetadata(EmployeesData.DataSource(0)))
        End Sub

        Public Sub New()
            InitializeComponent()
            Me.txtAbout.SelectAllOnGotFocus = False
        End Sub

        Public Property Employee() As Employees
            Get
                Return CType(GetValue(EmployeeProperty), Employees)
            End Get
            Set(ByVal value As Employees)
                SetValue(EmployeeProperty, value)
            End Set
        End Property

        Private Sub Button_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
            SpellChecker.CheckContainer(RootLayout)
        End Sub
    End Class
End Namespace
