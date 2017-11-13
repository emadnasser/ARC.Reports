﻿Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing
Imports System.Data
Imports System.Windows.Forms
Imports DevExpress.XtraRichEdit

Namespace DevExpress.XtraLayout.Demos
    ''' <summary>
    ''' Summary description for Employees.
    ''' </summary>
    Partial Public Class OneNote
        Inherits DevExpress.XtraLayout.Demos.TutorialControl

        Public Sub New()
            ' This call is required by the Windows.Forms Form Designer.
            CreateWaitDialog()
            InitializeComponent()

            ' TODO: Add any initialization after the InitForm call

        End Sub
        Protected Overrides Sub OnLoad(ByVal e As EventArgs)
            MyBase.OnLoad(e)
            webBrowser1.Url = New System.Uri("https://www.devexpress.com/Products/NET/Controls/WinForms/Layout/")
        End Sub
    End Class
End Namespace
