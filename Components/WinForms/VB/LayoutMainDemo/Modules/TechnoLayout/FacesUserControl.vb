Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports System.Data
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraEditors

Namespace DevExpress.XtraLayout.Demos.Modules.TechnoLayout
    Partial Public Class FacesUserControl
        Inherits UserControl

        Public Sub New()
            InitializeComponent()
            SetPicture()
            layoutControl1.BeginUpdate()
            Try
                For Each item As LayoutControlItem In lcgFaces.Items
                    item.Size = New Size(CInt(Math.Truncate(Math.Round(item.Width * Skins.DpiProvider.Default.DpiScaleFactor))), CInt(Math.Truncate(Math.Round(item.Height * Skins.DpiProvider.Default.DpiScaleFactor))))
                Next item
            Finally
                layoutControl1.EndUpdate()
            End Try
        End Sub
        Private Sub SetPicture()
            Dim i As Integer = 0
            For Each lci As LayoutControlItem In lcgFaces.Items
                CType(lci.Control, PictureEdit).Image = imageCollection1.Images(i)
                i += 1
            Next lci
        End Sub
    End Class
End Namespace
