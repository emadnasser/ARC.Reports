Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports System.Data
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.Utils.Drawing.Animation
Imports DevExpress.XtraLayout.Utils
Imports DevExpress.XtraEditors
Imports DevExpress.Utils

Namespace DevExpress.XtraLayout.Demos
    Partial Public Class TechnoLayout
        Inherits TutorialControl

        Public Sub New()
            InitializeComponent()
            DirectCast(facesUserControl1.layoutControl1, ILayoutControl).EnableCustomizationMode = True
            AddHandler facesUserControl1.layoutControl1.ItemSelectionChanged, AddressOf layoutControl1_ItemSelectionChanged
            facesUserControl1.layoutControlItem1.Selected = True
            If Skins.DpiProvider.Default.DpiScaleFactor > 1.4 Then
                Me.navigationPage1.ImageUri.Uri = "Properties;Size32x32;Office2013"
            End If
        End Sub

        Private Property Selected() As Object

        Private Sub layoutControl1_ItemSelectionChanged(ByVal sender As Object, ByVal e As EventArgs)
            propertyGrid.Rows.Clear()
            If TypeOf sender Is LayoutControlGroup Then
                propertyGrid.SelectedObject = New LayoutGroupCustomWrapper(TryCast(sender, LayoutControlGroup))
            End If
            If TypeOf sender Is LayoutControlItem Then
                propertyGrid.SelectedObject = New LayoutItemCustomWrapper(TryCast(sender, LayoutControlItem))
            End If
            Selected = sender
        End Sub

        Public Class LayoutItemCustomWrapper
            Inherits BasePropertyGridObjectWrapper

            Public Sub New(ByVal item As LayoutControlItem)
                SetWrappedObject(item)
            End Sub
            <Category("Name"), DefaultValue(True)>
            Public Overridable ReadOnly Property Name() As String
                Get
                    Return Item.Name
                End Get
            End Property
            <Category("Text"), DefaultValue(True)>
            Public Overridable Property TextVisible() As Boolean
                Get
                    Return Item.TextVisible
                End Get
                Set(ByVal value As Boolean)
                    Item.TextVisible = value
                End Set
            End Property
            <Category("Text"), DefaultValue("")>
            Public Overridable Property Text() As String
                Get
                    Return Item.Text
                End Get
                Set(ByVal value As String)
                    Item.Text = value
                End Set
            End Property
            <Category("Text"), DefaultValue(Locations.Default)>
            Public Overridable Property TextLocation() As Locations
                Get
                    Return Item.TextLocation
                End Get
                Set(ByVal value As Locations)
                    Item.TextLocation = value
                End Set
            End Property


            <Category("OptionsFlowLayoutItem"), DefaultValue(False)>
            Public Overridable Property StartNewLine() As Boolean
                Get
                    Return Item.StartNewLine
                End Get
                Set(ByVal value As Boolean)
                    Item.StartNewLine = value
                End Set
            End Property

            Public Overridable Property Size() As Size
                Get
                    Return Item.Size
                End Get
                Set(ByVal value As Size)
                    Item.Size = value
                End Set
            End Property
            Public Overridable Property MaxSize() As Size
                Get
                    Return Item.MaxSize
                End Get
                Set(ByVal value As Size)
                    Item.MaxSize = value
                End Set
            End Property
            Public Overridable Property MinSize() As Size
                Get
                    Return Item.MinSize
                End Get
                Set(ByVal value As Size)
                    Item.MinSize = value
                End Set
            End Property
            Public Overridable Property Spacing() As DevExpress.XtraLayout.Utils.Padding
                Get
                    Return Item.Spacing
                End Get
                Set(ByVal value As DevExpress.XtraLayout.Utils.Padding)
                    Item.Spacing = value
                End Set
            End Property

            Protected ReadOnly Property Item() As LayoutControlItem
                Get
                    Return TryCast(WrappedObject, LayoutControlItem)
                End Get
            End Property
            Public Overrides Function Clone() As BasePropertyGridObjectWrapper
                Return New LayoutItemCustomWrapper(Item)
            End Function
        End Class
        Public Class LayoutGroupCustomWrapper
            Inherits BasePropertyGridObjectWrapper

            Public Sub New(ByVal group As LayoutControlGroup)
                SetWrappedObject(group)
            End Sub
            <DefaultValue(LayoutMode.Regular), Category("Group")>
            Public Overridable Property LayoutMode() As LayoutMode
                Get
                    Return Group.LayoutMode
                End Get
                Set(ByVal value As LayoutMode)
                    Group.LayoutMode = value
                End Set
            End Property
            <Category("OptionsFlowLayoutGroup")>
            Public Overridable Property FlowDirection() As FlowDirection
                Get
                    Return Group.FlowDirection
                End Get
                Set(ByVal value As FlowDirection)
                    Group.FlowDirection = value
                End Set
            End Property
            Protected ReadOnly Property Group() As LayoutControlGroup
                Get
                    Return TryCast(WrappedObject, LayoutControlGroup)
                End Get
            End Property
            Public Overrides Function Clone() As BasePropertyGridObjectWrapper
                Return New LayoutGroupCustomWrapper(Group)
            End Function
        End Class

        Private Sub zoomTrackBarControl1_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles ztbcSize.EditValueChanged
            facesUserControl1.layoutControl1.BeginUpdate()
            Try
                For Each item As LayoutControlItem In facesUserControl1.lcgFaces.Items
                    item.Size = New Size(CInt(Math.Truncate(Math.Round(ztbcSize.Value * Skins.DpiProvider.Default.DpiScaleFactor))), CInt(Math.Truncate(Math.Round(ztbcSize.Value * Skins.DpiProvider.Default.DpiScaleFactor))))
                Next item
            Finally
                facesUserControl1.layoutControl1.EndUpdate()
            End Try
            layoutControl1_ItemSelectionChanged(Selected, Nothing)
        End Sub

        Private Sub zoomTrackBarControl2_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles ztbcSpacing.EditValueChanged
            facesUserControl1.layoutControl1.BeginUpdate()
            Try
                For Each item As LayoutControlItem In facesUserControl1.lcgFaces.Items
                    item.Spacing = New Utils.Padding(CInt(Math.Truncate(Math.Round(ztbcSpacing.Value * Skins.DpiProvider.Default.DpiScaleFactor))))
                Next item
            Finally
                facesUserControl1.layoutControl1.EndUpdate()
            End Try
            layoutControl1_ItemSelectionChanged(Selected, Nothing)
        End Sub

        Private Sub cheCustomizationMode_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cheCustomizationMode.CheckedChanged
            DirectCast(facesUserControl1.layoutControl1, ILayoutControl).EnableCustomizationMode = cheCustomizationMode.Checked
            layoutControlItem5.Visibility = If(cheCustomizationMode.Checked, LayoutVisibility.Always, LayoutVisibility.Never)

        End Sub
    End Class
End Namespace
