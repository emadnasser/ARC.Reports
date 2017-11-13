Imports System
Imports System.Windows
Imports System.Windows.Controls
Imports DevExpress.Xpf.DemoBase
Imports DevExpress.Xpf.Core
Imports DevExpress.Utils
Imports DevExpress.DemoData
Imports DevExpress.DemoData.Models
Imports System.Collections.Generic


Namespace CommonDemo
   <CodeFile("ModuleResources/MultiColumnLookupEditorTemplates(.SL).xaml")>
   Partial Public Class StandaloneMultiColumnLookupEditor
       Inherits CommonDemoModule

        Private Property NWind() As NWindDataLoader
        Private ReadOnly Property GenericXamlName() As String
            Get
                Return "Generic.xaml"
            End Get
        End Property
        Private ReadOnly Property Products() As IList(Of Product)
            Get
                Return DirectCast(lookUpEdit.DataContext, IList(Of Product))
            End Get
        End Property
        Private ReadOnly Property NewItemRowID() As Integer
            Get
                Return Products.Count + 1
            End Get
        End Property
        Public Sub New()
            Resources.MergedDictionaries.Add(New ResourceDictionary() With {.Source = New Uri(String.Format("/{0};component/Themes/{1}", AssemblyHelper.GetPartialName(GetType(StandaloneMultiColumnLookupEditor).Assembly), GenericXamlName), UriKind.Relative)})
            InitializeComponent()
            NWind = TryCast(Resources("NWindDataLoader"), NWindDataLoader)
        End Sub
        Private control As Control
        Private Sub lookUpEdit_ProcessNewValue(ByVal sender As DependencyObject, ByVal e As DevExpress.Xpf.Editors.ProcessNewValueEventArgs)
            If Not CBool(chProcessNewValue.IsChecked) Then
                Return
            End If

            control = New ContentControl With {.Template = CType(Resources("addNewRecordTemplate"), ControlTemplate), .Tag = e}
            Dim row As New Product()
            row.ProductName = e.DisplayText
            control.DataContext = row
            Dim owner As FrameworkElement = TryCast(sender, FrameworkElement)
            Dim closeHandler As DialogClosedDelegate = AddressOf CloseAddNewRecordHandler

            FloatingContainer.ShowDialogContent(control, owner, Size.Empty, New FloatingContainerParameters() With {.Title = "Add New Record", .AllowSizing = False, .ClosedDelegate = closeHandler, .ContainerFocusable = False, .ShowModal = True})

            e.PostponedValidation = True
            e.Handled = True
        End Sub

        Private Sub CloseAddNewRecordHandler(ByVal close? As Boolean)
            If close.HasValue AndAlso close.Value Then
                Products.Add(DirectCast(control.DataContext, Product))
            End If
            control = Nothing
        End Sub
        Protected Overrides Function GetModuleDataContext() As Object
            Return lookUpEdit
        End Function
   End Class
End Namespace
