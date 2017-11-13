﻿Imports System
Imports System.Windows
Imports System.ComponentModel.DataAnnotations
Imports DevExpress.Mvvm.DataAnnotations

Namespace GridDemo
    <MetadataType(GetType(DataAnnotationsElement1Metadata))>
    Public Class DataAnnotationsElement1_FluentAPI
        Public Property IntProperty() As Integer
        Public Property NullableIntProperty() As Integer?
        Public Property DoubleProperty() As Double
        Public Property NullableDoubleProperty() As Double?
        Public Property BoolProperty() As Boolean
        Public Property NullableBoolProperty() As Boolean?
        Public Property CharProperty() As Char
        Public Property NullableCharProperty() As Char?
        Public Property EnumProperty() As Gender
        Public Property NullableEnumProperty() As Gender?
        Public Property StringProperty() As String
        Public Property DateTimeProperty() As Date
        Public Property NullableDateTimeProperty() As Date?
        Public Property DecimalProperty() As Decimal
        Public Property NullableDecimalProperty() As Decimal?
        Public Property ComplexTypeProperty() As Point
        Public Property CurrencyProperty() As Decimal
        Public Property MultilineTextProperty() As String
        Public Property PhoneNumberProperty() As String
    End Class

    Public Class DataAnnotationsElement1Metadata
        Implements IMetadataProvider(Of DataAnnotationsElement1_FluentAPI)

        Private Sub IMetadataProviderGeneric_BuildMetadata(ByVal builder As MetadataBuilder(Of DataAnnotationsElement1_FluentAPI)) Implements IMetadataProvider(Of DataAnnotationsElement1_FluentAPI).BuildMetadata
            builder.Property(Function(p) p.IntProperty).DisplayName("Int")
            builder.Property(Function(p) p.NullableIntProperty).DisplayName("Nullable Int")
            builder.Property(Function(p) p.DoubleProperty).DisplayName("Double")
            builder.Property(Function(p) p.NullableDoubleProperty).DisplayName("Nullable Double")
            builder.Property(Function(p) p.BoolProperty).DisplayName("Bool")
            builder.Property(Function(p) p.NullableBoolProperty).DisplayName("Nullable Bool")
            builder.Property(Function(p) p.CharProperty).DisplayName("Char")
            builder.Property(Function(p) p.NullableCharProperty).DisplayName("Nullable Char")
            builder.Property(Function(p) p.EnumProperty).DisplayName("Enum")
            builder.Property(Function(p) p.NullableEnumProperty).DisplayName("Nullable Enum")
            builder.Property(Function(p) p.StringProperty).DisplayName("String")
            builder.Property(Function(p) p.DateTimeProperty).DisplayName("DateTime")
            builder.Property(Function(p) p.NullableDateTimeProperty).DisplayName("Nullable DateTime")
            builder.Property(Function(p) p.DecimalProperty).DisplayName("Decimal")
            builder.Property(Function(p) p.NullableDecimalProperty).DisplayName("Nullable Decimal")
            builder.Property(Function(p) p.ComplexTypeProperty).DisplayName("Point")
            builder.Property(Function(p) p.CurrencyProperty).CurrencyDataType().DisplayName("Currency")
            builder.Property(Function(p) p.MultilineTextProperty).MultilineTextDataType().DisplayName("Multiline Text")
            builder.Property(Function(p) p.PhoneNumberProperty).PhoneNumberDataType().DisplayName("Phone Number")

            builder.Group("Numeric Types").ContainsProperty(Function(p) p.IntProperty).ContainsProperty(Function(p) p.NullableIntProperty).ContainsProperty(Function(p) p.DoubleProperty).ContainsProperty(Function(p) p.NullableDoubleProperty).ContainsProperty(Function(p) p.DecimalProperty).ContainsProperty(Function(p) p.NullableDecimalProperty).ContainsProperty(Function(p) p.CurrencyProperty)
            builder.Group("Bool Types").ContainsProperty(Function(p) p.BoolProperty).ContainsProperty(Function(p) p.NullableBoolProperty)
            builder.Group("Char And String Types").ContainsProperty(Function(p) p.CharProperty).ContainsProperty(Function(p) p.NullableCharProperty).ContainsProperty(Function(p) p.StringProperty).ContainsProperty(Function(p) p.MultilineTextProperty).ContainsProperty(Function(p) p.PhoneNumberProperty)
            builder.Group("Enum Types").ContainsProperty(Function(p) p.EnumProperty).ContainsProperty(Function(p) p.NullableEnumProperty)
            builder.Group("Date Types").ContainsProperty(Function(p) p.DateTimeProperty).ContainsProperty(Function(p) p.NullableDateTimeProperty)
            builder.Group("Complex Types").ContainsProperty(Function(p) p.ComplexTypeProperty)
        End Sub
    End Class
End Namespace