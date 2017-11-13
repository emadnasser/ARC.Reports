Imports System
Imports System.ComponentModel
Imports System.Collections.Generic
Imports System.Diagnostics
Imports System.Text

Imports DevExpress.ExpressApp
Imports DevExpress.ExpressApp.Actions
Imports DevExpress.ExpressApp.Editors
Imports DevExpress.Persistent.Base
Imports System.Windows.Forms
Imports DevExpress.XtraEditors

Namespace MainDemo.Module.Win.Controllers
    Partial Public Class WinNullTextEditorController
        Inherits ViewController
        Public Sub New()
            InitializeComponent()
            RegisterActions(components)
        End Sub
        Private Sub InitNullText(ByVal propertyEditor As PropertyEditor)
            CType(propertyEditor.Control, BaseEdit).Properties.NullText = "N/A"
        End Sub
        Private Sub TryInitializeAnniversaryItem()
            Dim propertyEditor As PropertyEditor = TryCast((CType(View, DetailView)).FindItem("Anniversary"), PropertyEditor)
            If propertyEditor IsNot Nothing Then
                If propertyEditor.Control IsNot Nothing Then
                    InitNullText(propertyEditor)
                Else
                    AddHandler propertyEditor.ControlCreated, AddressOf propertyEditor_ControlCreated
                End If
            End If
        End Sub
        Private Sub WinNullTextEditorController_Activated(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Activated
            AddHandler CType(View, CompositeView).ItemsChanged, AddressOf WinNullTextEditorController_ItemsChanged
            TryInitializeAnniversaryItem()
        End Sub
        Private Sub WinNullTextEditorController_ItemsChanged(ByVal sender As Object, ByVal e As ViewItemsChangedEventArgs)
            If e.ChangedType = ViewItemsChangedType.Added AndAlso e.Item.Id = "Anniversary" Then
                TryInitializeAnniversaryItem()
            End If
        End Sub
        Private Sub propertyEditor_ControlCreated(ByVal sender As Object, ByVal e As EventArgs)
            InitNullText(CType(sender, PropertyEditor))
        End Sub
    End Class
End Namespace
