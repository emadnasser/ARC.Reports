Imports System
Imports System.ComponentModel
Imports System.Linq
Imports System.Windows.Forms
Imports DevExpress.DXperience.Demos
Imports DevExpress.Utils
Imports DevExpress.XtraBars.Ribbon
Imports DevExpress.XtraDiagram.Utils

Namespace DevExpress.XtraDiagram.Demos
    Partial Public Class DiagramTutorialControlBase
        Inherits TutorialControlBase

        #Region "Static"

        Public Shared Function GetDataFileName(ByVal fileName As String) As String
            Return FilesHelper.FindingFileName(Application.StartupPath, "Data\Diagram\" & fileName)
        End Function

        Private Shared Sub SubscribeRibbonEvents(ByVal ribbon As RibbonControl)
            If ribbon IsNot Nothing Then
                AddHandler ribbon.Merge, AddressOf Ribbon_Merge
                AddHandler ribbon.UnMerge, AddressOf Ribbon_UnMerge
            End If
        End Sub
        Private Shared Sub UnsubscribeRibbonEvents(ByVal ribbon As RibbonControl)
            If ribbon IsNot Nothing Then
                RemoveHandler ribbon.Merge, AddressOf Ribbon_Merge
                RemoveHandler ribbon.UnMerge, AddressOf Ribbon_UnMerge
            End If
        End Sub
        Private Shared Sub Ribbon_Merge(ByVal sender As Object, ByVal e As RibbonMergeEventArgs)
            e.MergeOwner.ApplicationButtonDropDownControl = e.MergedChild.ApplicationButtonDropDownControl
            e.MergeOwner.ToolbarLocation = RibbonQuickAccessToolbarLocation.Default
            e.MergeOwner.ShowApplicationButton = DefaultBoolean.Default
        End Sub
        Private Shared Sub Ribbon_UnMerge(ByVal sender As Object, ByVal e As RibbonMergeEventArgs)
            e.MergeOwner.ApplicationButtonDropDownControl = Nothing
            e.MergeOwner.ToolbarLocation = RibbonQuickAccessToolbarLocation.Hidden
            e.MergeOwner.ShowApplicationButton = DefaultBoolean.False
        End Sub

        #End Region
        Private showOptionsPanelCore As Boolean = False

        <DefaultValue(False)>
        Public Property ShowOptionsPanel() As Boolean
            Get
                Return Me.showOptionsPanelCore
            End Get
            Set(ByVal value As Boolean)
                If showOptionsPanelCore = value Then
                    Return
                End If
                showOptionsPanelCore = value
                UpdatePanelOptionsVisibility()
            End Set
        End Property

        Public Overrides Property AutoMergeRibbon() As Boolean
            Get
                Return True
            End Get
            Set(ByVal value As Boolean)
            End Set
        End Property
        Protected ReadOnly Property OptionsPanel() As Control
            Get
                Return Me.optionsPanel_Renamed
            End Get
        End Property
        Protected ReadOnly Property Diagram() As DiagramControl
            Get
                Return Me.diagramControl
            End Get
        End Property
        Protected Overridable ReadOnly Property Ribbon() As RibbonControl
            Get
                Return Nothing
            End Get
        End Property

        Public Sub New()
            InitializeComponent()
        End Sub

        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            UnsubscribeRibbonEvents(Ribbon)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub
        Protected Overrides Sub OnLoad(ByVal e As EventArgs)
            MyBase.OnLoad(e)
            UpdatePanelOptionsVisibility()
            If Ribbon IsNot Nothing Then
                BarUtils.ForEachRibbonPageGroup(Ribbon, Sub(group) group.Visible = group.ItemLinks.Any(Function(x) x.CanVisible))
            End If
            SubscribeRibbonEvents(Ribbon)
        End Sub
        Private Sub UpdatePanelOptionsVisibility()
            Me.navigationPane1.Visible = ShowOptionsPanel
        End Sub
        Protected Sub LoadDocument(ByVal fileName As String)
            Dim filePath As String = GetDataFileName(fileName)
            Diagram.LoadDocument(filePath)
        End Sub
    End Class
End Namespace
