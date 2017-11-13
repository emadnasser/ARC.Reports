Imports System.Collections.Generic
Imports System.IO
Imports System.Reflection
Imports System.Xml.Linq
Imports DevExpress.Xpf.DemoBase.DataClasses
Imports DevExpress.Xpf.DemoBase
Imports System.Xml
Imports DevExpress.XtraExport.Helpers
Imports DevExpress.Xpf.Grid.Printing

Namespace GridDemo
    <CodeFile("ModuleResources/BindingToXMLClasses.(cs)")>
    Partial Public Class BindingToXML
        Inherits GridDemoModule

        Public Sub New()
            InitializeComponent()
            Dim assembly As System.Reflection.Assembly = GetType(BindingToXML).Assembly
            Dim stream As Stream = EmployeesWithPhotoData.GetDataStream()
            Dim document As New XmlDocument()
            document.Load(stream)
            grid.ItemsSource = document.SelectNodes("/Employees/Employee")
        End Sub
        Protected Overrides Function GetReportView() As IGridViewFactory(Of ColumnWrapper, RowBaseWrapper)
            Return Nothing
        End Function
    End Class
End Namespace
