Imports System
Imports System.Collections.Generic
Imports System.Windows
Imports System.Windows.Controls
Imports XmlaMetaGetter = DevExpress.XtraPivotGrid.Data.OLAPMetaGetter
Imports DevExpress.Xpf.Editors
Imports DevExpress.XtraPivotGrid
Imports DevExpress.Xpf.Core

Namespace PivotGridDemo.PivotGrid

    Partial Public Class DataSourceDialog
        Inherits Control

        Private Const ConnectionStringName As String = "ConnectionString", CatalogsComboName As String = "CatalogsCombo", CubesComboName As String = "CubesCombo", UserName As String= "UserCombo", PasswordName As String = "PasswordCombo", ConnectButtonName As String = "Connect"

        Public Shared ReadOnly IsCatalogsRetrivingProperty As DependencyProperty
        Public Shared ReadOnly IsCubesRetrivingProperty As DependencyProperty
        Private metaGetter As New XmlaMetaGetter()

        Shared Sub New()
            Dim ownerType As Type = GetType(DataSourceDialog)
            IsCatalogsRetrivingProperty = DependencyProperty.Register("IsCatalogsRetriving", GetType(Boolean), ownerType, New PropertyMetadata(False))
            IsCubesRetrivingProperty = DependencyProperty.Register("IsCubesRetriving", GetType(Boolean), ownerType, New PropertyMetadata(False))
        End Sub

        Public Property IsCatalogsRetriving() As Boolean
            Get
                Return DirectCast(GetValue(IsCatalogsRetrivingProperty), Boolean)
            End Get
            Set(ByVal value As Boolean)
                SetValue(IsCatalogsRetrivingProperty, value)
            End Set
        End Property

        Public Property IsCubesRetriving() As Boolean
            Get
                Return DirectCast(GetValue(IsCubesRetrivingProperty), Boolean)
            End Get
            Set(ByVal value As Boolean)
                SetValue(IsCubesRetrivingProperty, value)
            End Set
        End Property

        Private Property CatalogsCombo() As ComboBoxEdit
        Private Property CubesCombo() As ComboBoxEdit
        Private Property ConnectionString() As TextEdit
        Private Property User() As TextEdit
        Private Property Password() As PasswordBoxEdit
        Private Property ConnectButton() As Button

        Public Overrides Sub OnApplyTemplate()
            MyBase.OnApplyTemplate()
            CatalogsCombo = TryCast(GetTemplateChild(CatalogsComboName), ComboBoxEdit)
            AddHandler CatalogsCombo.EditValueChanged, AddressOf OnCatalogsComboEditValueChanged
            CubesCombo = TryCast(GetTemplateChild(CubesComboName), ComboBoxEdit)
            ConnectionString = TryCast(GetTemplateChild(ConnectionStringName), TextEdit)
            User = TryCast(GetTemplateChild(UserName), TextEdit)
            Password = TryCast(GetTemplateChild(PasswordName), PasswordBoxEdit)
            ConnectButton = TryCast(GetTemplateChild(ConnectButtonName), Button)
            AddHandler ConnectButton.Click, AddressOf Connect
            ApplyPlatformTemplate()
        End Sub

        Private Sub Connect(ByVal sender As Object, ByVal e As RoutedEventArgs)
            ClearCombo(CatalogsCombo)
            ClearCombo(CubesCombo)
            IsCatalogsRetriving = True
            IsCubesRetriving = False
            metaGetter.ConnectionString = GetConnectionStringCore()
            If Not metaGetter.Connected Then
                ShowMessage("Invalid cube.")
                IsCatalogsRetriving = False
                Return
            End If
            RetriveCatalogsAndCubes()
        End Sub

        Private Sub OnCatalogsComboEditValueChanged(ByVal sender As Object, ByVal e As EditValueChangedEventArgs)
            IsCatalogsRetriving = False
            If IsCatalogEmpty() Then
                IsCubesRetriving = False
                Return
            End If
            IsCubesRetriving = True
            CubesCombo.Clear()
            metaGetter.ConnectionString = GetConnectionStringCore()
            RetriveCubes()
        End Sub

        Private Function CatalogOrCubeEmpty() As Boolean
            If IsCatalogEmpty() Then
                Return True
            End If
            Return CubesCombo.SelectedIndex < 0 OrElse String.IsNullOrEmpty(TryCast(CubesCombo.Items(CubesCombo.SelectedIndex), String))
        End Function
        Private Function IsCatalogEmpty() As Boolean
            Return CatalogsCombo.SelectedIndex < 0 OrElse String.IsNullOrEmpty(TryCast(CatalogsCombo.Items(CatalogsCombo.SelectedIndex), String))
        End Function
        Private Sub ClearCombo(ByVal edit As ComboBoxEdit)
            edit.Items.Clear()
            edit.EditValue = String.Empty
        End Sub
    End Class
End Namespace
