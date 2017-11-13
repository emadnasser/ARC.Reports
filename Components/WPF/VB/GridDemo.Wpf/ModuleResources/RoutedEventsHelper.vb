Imports System
Imports System.Windows
Imports System.Windows.Input
Imports DevExpress.Mvvm.UI.Interactivity
Imports DevExpress.Xpf.Utils
Imports System.Windows.Markup
Imports DevExpress.Xpf.Editors

Namespace GridDemo
    Public Class RoutedEventCommandHelper
        Inherits Behavior(Of FrameworkElement)

        Public Shared ReadOnly CommandProperty As DependencyProperty
        Shared Sub New()
            CommandProperty = DependencyPropertyManager.Register("Command", GetType(ICommand), GetType(RoutedEventCommandHelper), New PropertyMetadata(Nothing))
        End Sub
        Private ReadOnly handler As RoutedEventHandler
        Private routedEvent As RoutedEvent
        Public Sub New()
            Me.handler = New RoutedEventHandler(AddressOf OnRaiseEvent)
        End Sub
        Protected Overrides Sub OnAttached()
            MyBase.OnAttached()
            If [Event] Is Nothing Then
                Return
            End If
            UpdateSubsrcribtion()
        End Sub
        Private Sub UpdateSubsrcribtion()
            AssociatedObject.RemoveHandler([Event], handler)
            AssociatedObject.AddHandler([Event], Me.handler)
        End Sub
        Private Sub OnRaiseEvent(ByVal sender As Object, ByVal e As RoutedEventArgs)
            If Command Is Nothing Then
                Return
            End If
            Command.Execute(New RoutedEventHandlerArgs(sender, e))
        End Sub
        Public Property [Event]() As RoutedEvent
            Get
                Return Me.routedEvent
            End Get
            Set(ByVal value As RoutedEvent)
                Me.routedEvent = value
                If AssociatedObject Is Nothing Then
                    Return
                End If
                UpdateSubsrcribtion()
            End Set
        End Property
        Public Property Command() As ICommand
            Get
                Return DirectCast(GetValue(CommandProperty), ICommand)
            End Get
            Set(ByVal value As ICommand)
                SetValue(CommandProperty, value)
            End Set
        End Property
    End Class
    Public Class RoutedEventHandlerArgs
        Private privateSender As Object
        Public Property Sender() As Object
            Get
                Return privateSender
            End Get
            Private Set(ByVal value As Object)
                privateSender = value
            End Set
        End Property
        Private privateArgs As RoutedEventArgs
        Public Property Args() As RoutedEventArgs
            Get
                Return privateArgs
            End Get
            Private Set(ByVal value As RoutedEventArgs)
                privateArgs = value
            End Set
        End Property
        Public Sub New(ByVal sender As Object, ByVal e As RoutedEventArgs)
            Me.Sender = sender
            Args = e
        End Sub
    End Class
    Public Class EditValueChangedEventExtension
        Inherits MarkupExtension

        Public Sub New()
        End Sub
        Public Overrides Function ProvideValue(ByVal serviceProvider As IServiceProvider) As Object
            Return BaseEdit.EditValueChangedEvent
        End Function
    End Class
End Namespace
