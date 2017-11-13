Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Reflection
Imports DevExpress.Utils
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraEditors.Popup
Imports DevExpress.XtraTab
Imports DevExpress.XtraBars

Namespace DevExpress.XtraBars.Demos.RibbonSimplePad
    Public Class PopupColor
        Inherits XtraUserControl
        Implements IPopupColorPickEdit
        Private popupContainer As PopupControlContainer
        Private main As frmMain
        Private builder As PopupColorBuilderEx
        Public Sub New(ByVal container As PopupControlContainer, ByVal parent As frmMain)
            Me.popupContainer = container
            Me.builder = CreatePopupColorEditBuilder()
            container.Controls.Add(builder.TabControl)
            Me.popupContainer.Size = builder.CalcContentSize()
            Me.main = parent
        End Sub
        Public ReadOnly Property PopupColorBuilder As PopupColorBuilder
            Get
                Return CType(builder, PopupColorBuilder)
            End Get
        End Property
        Protected Function CreatePopupColorEditBuilder() As PopupColorBuilderEx
            Return New DemoPopupColorBuilderEx(Me)
        End Function
        Public Sub ClosePopup() Implements IPopupColorEdit.ClosePopup
            Me.popupContainer.HidePopup()
        End Sub

        Public ReadOnly Property Color As Color Implements IPopupColorEdit.Color
            Get
                Return (CType(PopupColorBuilder.ResultValue, Color))
            End Get
        End Property

        Public Function CreateColorListBox() As ColorListBox Implements IPopupColorEdit.CreateColorListBox
            Return New ColorListBox()
        End Function

        Public Function CreateTabControl() As ColorEditTabControlBase Implements IPopupColorEdit.CreateTabControl
            Return (CType(New DevExpress.XtraEditors.PopupColorPickEditForm.ColorPickEditTabControl(Me), ColorEditTabControlBase))
        End Function

        Public ReadOnly Property EditValue As Object Implements IPopupColorEdit.EditValue
            Get
                Return Nothing
            End Get
        End Property

        Public ReadOnly Property IsPopupOpen As Boolean Implements IPopupColorEdit.IsPopupOpen
            Get
                Return True
            End Get
        End Property

        Public ReadOnly Property LookAndFeel1 As LookAndFeel.UserLookAndFeel Implements IPopupColorEdit.LookAndFeel
            Get
                Return LookAndFeel
            End Get
        End Property

        Public Sub OnColorChanged() Implements IPopupColorEdit.OnColorChanged
            main.CurrentRichTextBox.SelectionColor = (CType(PopupColorBuilder.ResultValue, Color))
        End Sub

        Public ReadOnly Property Properties As Repository.RepositoryItemColorEdit Implements IPopupColorEdit.Properties
            Get
                Return New DevExpress.XtraEditors.Repository.RepositoryItemColorPickEdit()
            End Get
        End Property

        Public Sub ClosePopup1(mode As PopupCloseMode) Implements IPopupColorPickEdit.ClosePopup
            If Me.popupContainer IsNot Nothing Then
                Me.popupContainer.HidePopup()
            End If
        End Sub
        Public ReadOnly Property HasBorder As Boolean Implements IPopupColorPickEdit.HasBorder
            Get
                Return False
            End Get
        End Property
        Public ReadOnly Property OwnerEdit As ColorPickEditBase Implements IPopupColorPickEdit.OwnerEdit
            Get
                Return Nothing
            End Get
        End Property
        Public Sub SetSelectedColorItem(colorItem As ColorItem) Implements IPopupColorPickEdit.SetSelectedColorItem
        End Sub
    End Class

    Public Class DemoPopupColorBuilderEx
        Inherits PopupColorBuilderEx
        Public Sub New(ByVal owner As IPopupColorPickEdit)
            MyBase.New(owner)
        End Sub
        Protected Overrides Function CreateTabControl() As ColorEditTabControlBase
            Dim tab As ColorEditTabControlBase = MyBase.CreateTabControl()
            tab.Dock = DockStyle.Fill
            Return tab
        End Function
    End Class

End Namespace
