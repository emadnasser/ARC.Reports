Imports System
Imports System.Linq
Imports System.Windows.Data
Imports System.Windows.Markup
Imports DevExpress.Xpf.DemoBase
Imports System.Windows
Imports DevExpress.Xpf.Core
Imports DevExpress.Xpf.PivotGrid
Imports System.Collections.Generic
Imports System.Windows.Media.Imaging
Imports System.Reflection
Imports DevExpress.DemoData.Models

Namespace PivotGridDemo.PivotGrid
    Partial Public Class CustomLayout
        Inherits PivotGridDemoModule

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub PivotGridDemoModule_Loaded(ByVal sender As Object, ByVal e As RoutedEventArgs)
            pivotGrid.DataSource = NWindContext.Create().SalesPersons.ToList()
        End Sub
    End Class

    Public Class PivotImageExtension
        Inherits MarkupExtension

        Private Shared images As New Dictionary(Of String, BitmapImage)()
        Private Shared Function LoadImage(ByVal imageName As String) As BitmapImage
            Dim resourcePath As String = String.Format("DevExpress.Xpf.PivotGrid.Images.{0}.png", imageName)
            Dim asm As System.Reflection.Assembly = GetType(PivotGridControl).Assembly
            Return DevExpress.Xpf.Core.Native.ImageHelper.CreateImageFromEmbeddedResource(asm, resourcePath)
        End Function
        Public Shared Function GetImage(ByVal imageName As String) As BitmapImage
            Dim image As BitmapImage = Nothing
            If Not images.TryGetValue(imageName, image) Then
                image = LoadImage(imageName)
                images.Add(imageName, image)
            End If
            Return image
        End Function
        Public Property ImageName() As String

        Public Sub New()
        End Sub

        Public Sub New(ByVal imageName As String)
            Me.ImageName = imageName
        End Sub

        Public Overrides Function ProvideValue(ByVal serviceProvider As IServiceProvider) As Object
            Return GetImage(ImageName)
        End Function
    End Class
End Namespace
