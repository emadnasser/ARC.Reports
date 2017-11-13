Imports System
Imports System.Windows.Controls

Namespace RichEditDemo.Controls
    Partial Public Class CustomizeMergeFieldsControl
        Inherits UserControl

        Public Sub New(ByVal mergeFieldsNames() As MergeFieldNameInfo)
            InitializeComponent()
            grid.ItemsSource = mergeFieldsNames
        End Sub
    End Class
End Namespace
