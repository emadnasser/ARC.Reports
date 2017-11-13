﻿Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.Tutorials
Imports System.Drawing
Imports DevExpress.Utils.About

Namespace DevExpress.XtraRichEdit.Demos
	Partial Public Class About
        Inherits ucOverviewPage
		Public Sub New()
			InitializeComponent()
		End Sub

        Protected Overrides ReadOnly Property Line1Text As String
			Get
                Return "The XtraRichEdit Suite"
			End Get
		End Property
        Protected Overrides ReadOnly Property Line2Text As String
            Get
                Return "Office® inspired WYSIWYG word processing for the WinForms platform."
            End Get
        End Property
        Protected Overrides ReadOnly Property Line3Text As String
            Get
                Return "DevExpress Desktop Controls"
            End Get
        End Property
        Protected Overrides ReadOnly Property Line4Text As String
			Get
                Return votedVSM
			End Get
		End Property
	End Class
End Namespace

