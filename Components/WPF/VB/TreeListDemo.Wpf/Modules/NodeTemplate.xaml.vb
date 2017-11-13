Imports System
Imports System.Collections.Generic
Imports System.Diagnostics
Imports System.IO
Imports System.Reflection
Imports System.Windows
Imports System.Windows.Controls
Imports System.Windows.Data
Imports System.Windows.Input
Imports System.Xml.Serialization
Imports DevExpress.Utils
Imports DevExpress.Xpf.Core
Imports DevExpress.Mvvm
Imports DevExpress.Xpf.DemoBase.Helpers
Imports DevExpress.Xpf.Editors
Imports DevExpress.Xpf.Grid


Namespace TreeListDemo
    Partial Public Class NodeTemplate
        Inherits TreeListDemoModule

        Public Sub New()
            InitializeComponent()
            view.ExpandAllNodes()
        End Sub
        Private Sub NodeTemplateListBox_SelectionChanged(ByVal sender As Object, ByVal e As EditValueChangedEventArgs)
            If treeList Is Nothing Then
                Return
            End If
            Select Case DirectCast(sender, ListBoxEdit).SelectedIndex
                Case 0
                    view.DataRowTemplate = CType(Resources("nodeDetailTemplate"), DataTemplate)
                Case 1
                    view.DataRowTemplate = CType(Resources("expandableNodeDetailTemplate"), DataTemplate)
                Case 2
                    view.DataRowTemplate = CType(Resources("nodeToolTipTemplate"), DataTemplate)
                Case 3
                    view.ClearValue(TreeListView.DataRowTemplateProperty)
            End Select
        End Sub
    End Class

    Public Class SpaceObjectsViewModel
        Public ReadOnly Property SpaceObjects() As IList(Of SpaceObjects)
            Get
                Return SpaceObjectData.DataSource
            End Get
        End Property
        Private privateShowWikiPageCommand As ICommand
        Public Property ShowWikiPageCommand() As ICommand
            Get
                Return privateShowWikiPageCommand
            End Get
            Private Set(ByVal value As ICommand)
                privateShowWikiPageCommand = value
            End Set
        End Property
        Public Sub New()
            ShowWikiPageCommand = New DelegateCommand(Of Object)(AddressOf OnLinkClick)
        End Sub
        Private Sub OnLinkClick(ByVal parameter As Object)
            Dim spaceObject As SpaceObjects = TryCast(parameter, SpaceObjects)
            If spaceObject Is Nothing Then
                Return
            End If
            Try
                Process.Start(spaceObject.WikiPage)
            Catch
            End Try
        End Sub
    End Class

    #Region "Converters"
    Public Class ImageDataToVisibilityConverter
        Implements IValueConverter

        #Region "IValueConverter Members"
        Private Function IValueConverter_Convert(ByVal value As Object, ByVal targetType As Type, ByVal parameter As Object, ByVal culture As System.Globalization.CultureInfo) As Object Implements IValueConverter.Convert
            If value Is Nothing OrElse DirectCast(value, Byte()).Length = 0 Then
                Return Visibility.Collapsed
            Else
                Return Visibility.Visible
            End If
        End Function
        Private Function IValueConverter_ConvertBack(ByVal value As Object, ByVal targetType As Type, ByVal parameter As Object, ByVal culture As System.Globalization.CultureInfo) As Object Implements IValueConverter.ConvertBack
            Throw New NotImplementedException()
        End Function
        #End Region
    End Class
    #End Region
    #Region "Classes"

    Public Class LinkButton
        Inherits Button

        Private ReadOnly underlineDecoration As TextDecorationCollection = TextDecorations.Underline
        Private textBlock As TextBlock
        Public Sub New()
            Me.SetDefaultStyleKey(GetType(LinkButton))
        End Sub
        Public Overrides Sub OnApplyTemplate()
            MyBase.OnApplyTemplate()
            textBlock = TryCast(GetTemplateChild("PART_Text"), TextBlock)
        End Sub
        Protected Overrides Sub OnMouseEnter(ByVal e As MouseEventArgs)
            MyBase.OnMouseEnter(e)
            If textBlock IsNot Nothing Then
                textBlock.TextDecorations = underlineDecoration
            End If
        End Sub
        Protected Overrides Sub OnMouseLeave(ByVal e As MouseEventArgs)
            MyBase.OnMouseLeave(e)
            If textBlock IsNot Nothing Then
                textBlock.TextDecorations = Nothing
            End If
        End Sub
    End Class
    #End Region
End Namespace
