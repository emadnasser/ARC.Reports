Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Windows
Imports DevExpress.Xpf.Utils
Imports System.Windows.Input
Imports DevExpress.Xpf.Grid
Imports DevExpress.Xpf.DemoBase.DataClasses
Imports System.Windows.Media.Imaging
Imports System.Windows.Media
Imports DevExpress.Xpf.Grid.TreeList

Namespace GridDemo
    Public Class CustomNodeImageSelector
        Inherits TreeListNodeImageSelector

        Public Sub New()
            ImageCache = New Dictionary(Of String, ImageSource)()
        End Sub
        Private Property ImageCache() As Dictionary(Of String, ImageSource)
        Public Overrides Function [Select](ByVal rowData As TreeListRowData) As ImageSource
            Dim groupName As String = TryCast(rowData.View.DataControl.GetCellValue(rowData.RowHandle.Value, "GroupName"), String)
            If ImageCache.ContainsKey(groupName) Then
                Return ImageCache(groupName)
            End If
            Dim image As ImageSource = New BitmapImage(New Uri(GroupNameToImageConverter.GetImagePathByGroupName(groupName), UriKind.Relative))
            ImageCache.Add(groupName, image)
            Return image
        End Function
    End Class
End Namespace
