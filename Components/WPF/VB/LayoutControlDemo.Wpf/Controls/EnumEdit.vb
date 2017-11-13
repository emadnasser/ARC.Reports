Imports System
Imports System.Collections
Imports System.Windows
Imports System.Windows.Controls

Namespace DevExpress.Xpf.LayoutControlDemo
    Public Class EnumEdit
        Inherits Control

        #Region "Dependency Properties"

        Public Shared ReadOnly ValueProperty As DependencyProperty = DependencyProperty.Register("Value", GetType(Object), GetType(EnumEdit), Nothing)
        Public Shared ReadOnly ValuesProperty As DependencyProperty = DependencyProperty.Register("Values", GetType(IEnumerable), GetType(EnumEdit), Nothing)
        Public Shared ReadOnly ValueTypeProperty As DependencyProperty = DependencyProperty.Register("ValueType", GetType(Type), GetType(EnumEdit), New PropertyMetadata(New PropertyChangedCallback(AddressOf OnValueTypeChanged)))

        Private Shared Sub OnValueTypeChanged(ByVal o As DependencyObject, ByVal e As DependencyPropertyChangedEventArgs)
            CType(o, EnumEdit).OnValueTypeChanged()
        End Sub

        #End Region ' Dependency Properties

        Public Sub New()
            DefaultStyleKey = GetType(EnumEdit)
        End Sub

        Public Property Value() As Object
            Get
                Return GetValue(ValueProperty)
            End Get
            Set(ByVal value As Object)
                SetValue(ValueProperty, value)
            End Set
        End Property
        Public Property Values() As IEnumerable
            Get
                Return DirectCast(GetValue(ValuesProperty), IEnumerable)
            End Get
            Private Set(ByVal value As IEnumerable)
                SetValue(ValuesProperty, value)
            End Set
        End Property
        Public Property ValueType() As Type
            Get
                Return DirectCast(GetValue(ValueTypeProperty), Type)
            End Get
            Set(ByVal value As Type)
                SetValue(ValueTypeProperty, value)
            End Set
        End Property

        Protected Overridable Sub OnValueTypeChanged()
            UpdateValues()
        End Sub
        Protected Sub UpdateValues()
            Values = System.Enum.GetValues(ValueType)
        End Sub
    End Class
End Namespace
