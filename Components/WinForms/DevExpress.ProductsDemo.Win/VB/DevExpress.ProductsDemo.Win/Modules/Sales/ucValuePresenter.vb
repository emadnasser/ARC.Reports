﻿Imports System.ComponentModel
Imports System.Text

Namespace DevExpress.SalesDemo.Win.Modules
	Partial Public Class ucValuePresenter
		Inherits UserControl

		Private doubleValue As Double
		Private valueFormat_Renamed As String

		Public Property ValueTextColor() As Color
			Get
				Return labelValue.ForeColor
			End Get
			Set(ByVal value As Color)
				labelValue.ForeColor = value
			End Set
		End Property
		Public Property TitleText() As String
			Get
				Return labelTitle.Text
			End Get
			Set(ByVal value As String)
				labelTitle.Text = value
			End Set
		End Property
		Public Property ValueFormat() As String
			Get
				Return valueFormat_Renamed
			End Get
			Set(ByVal value As String)
				valueFormat_Renamed = value
				UpdateValueText()
			End Set
		End Property
		Public Property Value() As Double
			Get
				Return doubleValue
			End Get
			Set(ByVal value As Double)
				doubleValue = value
				UpdateValueText()
			End Set
		End Property

		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub UpdateValueText()
			If valueFormat_Renamed IsNot Nothing Then
				labelValue.Text = String.Format(valueFormat_Renamed, doubleValue)
			Else
				labelValue.Text = doubleValue.ToString()
			End If
		End Sub
	End Class
End Namespace
