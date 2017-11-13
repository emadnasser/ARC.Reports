Imports System
Imports System.Collections.Generic
Imports System.Drawing
Imports System.Linq.Expressions
Imports System.Windows.Forms
Imports DevExpress.Data.Filtering.Helpers
Imports DevExpress.DevAV.Common.Utils
Imports DevExpress.Skins
Imports DevExpress.Utils
Imports DevExpress.XtraBars
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraEditors.Filtering
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Controls
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraLayout

Namespace DevExpress.DevAV
    Friend Class TaskPreviewGridView
        Inherits GridView

        Private rowFontSize As Single = AppearanceObject.DefaultFont.Size
        Public Sub New()
            Appearance.Row.Font = FontResources.GetSegoeUIFont(4)
            OptionsSelection.EnableAppearanceHideSelection = False
            OptionsView.AutoCalcPreviewLineCount = True
            OptionsView.EnableAppearanceEvenRow = True
            OptionsView.ShowGroupPanel = False
            OptionsView.ShowHorizontalLines = DevExpress.Utils.DefaultBoolean.False
            OptionsView.ShowIndicator = False
            OptionsView.ShowPreview = True
            OptionsView.ShowVerticalLines = DevExpress.Utils.DefaultBoolean.False
            PreviewIndent = 0
            AddHandler Me.RowCellStyle, Sub(s, e)
                e.Appearance.Font = FontResources.GetFont(e.Appearance.Font.FontFamily.Name, rowFontSize, e.Appearance.Font.Style)
                If e.RowHandle = FocusedRowHandle AndAlso GridControl.Focused Then
                    e.Appearance.BackColor = PaintAppearance.FocusedRow.BackColor
                Else
                    SetEvenRowAppearance(e.Appearance, e.RowHandle)
                End If
            End Sub
            AddHandler Me.CustomDrawRowPreview, Sub(s, e)
                If e.RowHandle = FocusedRowHandle AndAlso GridControl.Focused Then
                    e.Appearance.BackColor = PaintAppearance.FocusedRow.BackColor
                    e.Appearance.ForeColor = PaintAppearance.FocusedRow.ForeColor
                Else
                    SetEvenRowAppearance(e.Appearance, e.RowHandle)
                End If
            End Sub
        End Sub
        Private Sub SetEvenRowAppearance(ByVal appearance As AppearanceObject, ByVal rowHandle As Integer)
            If rowHandle Mod 2 = 0 Then
                appearance.BackColor = PaintAppearance.EvenRow.BackColor
            Else
                appearance.BackColor = PaintAppearance.Row.BackColor
            End If
        End Sub
        Public Sub SetViewFontSize(ByVal rowFontSize As Single, ByVal previewFontSize As Single)
            If previewFontSize > 0 Then
                Appearance.Preview.Font = FontResources.GetSegoeUIFont(previewFontSize)
            End If
            If rowFontSize > 0 Then
                Me.rowFontSize += rowFontSize
                Appearance.Row.Font = FontResources.GetSegoeUIFont(4)
            End If
        End Sub
        Protected Overrides ReadOnly Property IsAllowPixelScrollingPreview() As Boolean
            Get
                Return True
            End Get
        End Property
    End Class
    Friend Class ZoomLevelManager
        Private zoomControlCore As ZoomTrackBarControl
        Private zoomLevelCore As Integer = 0
        Private Shared zoomValues() As Integer = { 100, 110, 125, 150, 175, 200, 250, 300, 350, 400, 500 }
        Private editItem As BarEditItem
        Private captionItem As BarButtonItem
        Private viewModel As IZoomViewModel
        Public Sub New(ByVal beItem As BarEditItem, ByVal captionItem As BarButtonItem, ByVal viewModel As IZoomViewModel)
            Me.viewModel = viewModel
            If viewModel IsNot Nothing Then
                AddHandler viewModel.ZoomModuleChanged, AddressOf viewModel_SelectedModuleChanged
            End If
            Me.editItem = beItem
            Me.captionItem = captionItem
            If editItem IsNot Nothing Then
                AddHandler editItem.HiddenEditor, AddressOf beiZoom_HiddenEditor
                AddHandler editItem.ShownEditor, AddressOf beiZoom_ShownEditor
            End If
        End Sub
        Private zoomModule As ISupportZoom
        Private Sub viewModel_SelectedModuleChanged(ByVal sender As Object, ByVal e As EventArgs)
            If zoomModule IsNot Nothing Then
                RemoveHandler zoomModule.ZoomChanged, AddressOf zoomModule_ZoomChanged
            End If
            UpdateZoomLevelFromModule()
            zoomModule = TryCast(viewModel.ZoomModule, ISupportZoom)
            If zoomModule IsNot Nothing Then
                AddHandler zoomModule.ZoomChanged, AddressOf zoomModule_ZoomChanged
            End If
        End Sub
        Private ReadOnly Property ZoomControl() As ZoomTrackBarControl
            Get
                Return zoomControlCore
            End Get
        End Property
        Public Property ZoomLevel() As Integer
            Get
                Return zoomLevelCore
            End Get
            Set(ByVal value As Integer)
                If ZoomLevel = value Then
                    Return
                End If
                zoomLevelCore = value
                OnZoomLevelChanged(value)
            End Set
        End Property
        Private Sub OnZoomLevelChanged(ByVal value As Integer)
            Dim index As Integer = Array.IndexOf(zoomValues, value)
            If index = -1 Then
                value = (value \ 10)
            Else
                value = 10 + index
            End If
            editItem.EditValue = value
            captionItem.Caption = String.Format(" {0}%", ZoomLevel)
            UpdateModuleZoomLevel()
        End Sub
        Private Sub UpdateModuleZoomLevel()
            Dim supportZoom As ISupportZoom = TryCast(viewModel.ZoomModule, ISupportZoom)
            If supportZoom IsNot Nothing Then
                supportZoom.ZoomLevel = ZoomLevel
            End If
        End Sub
        Private Sub UpdateZoomLevelFromModule()
            Dim supportZoom As ISupportZoom = TryCast(viewModel.ZoomModule, ISupportZoom)
            If supportZoom IsNot Nothing Then
                ZoomLevel = supportZoom.ZoomLevel
            End If
            captionItem.Visibility = If(supportZoom IsNot Nothing, BarItemVisibility.Always, BarItemVisibility.Never)
            editItem.Visibility = captionItem.Visibility
        End Sub
        Private Sub zoomModule_ZoomChanged(ByVal sender As Object, ByVal e As EventArgs)
            UpdateZoomLevelFromModule()
        End Sub
        Private Sub beiZoom_ShownEditor(ByVal sender As Object, ByVal e As ItemClickEventArgs)
            Me.zoomControlCore = TryCast(editItem.Manager.ActiveEditor, ZoomTrackBarControl)
            If ZoomControl IsNot Nothing Then
                AddHandler ZoomControl.ValueChanged, AddressOf OnZoomValueChanged
                OnZoomValueChanged(ZoomControl, EventArgs.Empty)
            End If
        End Sub
        Private Sub beiZoom_HiddenEditor(ByVal sender As Object, ByVal e As ItemClickEventArgs)
            RemoveHandler ZoomControl.ValueChanged, AddressOf OnZoomValueChanged
            Me.zoomControlCore = Nothing
        End Sub
        Private Sub OnZoomValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            Dim val As Integer = ZoomControl.Value * 10
            If ZoomControl.Value > 10 Then
                val = zoomValues(ZoomControl.Value - 10)
            End If
            ZoomLevel = val
        End Sub
    End Class
    Friend NotInheritable Class GalleryItemAppearances

        Private Sub New()
        End Sub

        Public Shared Sub Apply(ByVal galleryItem As RibbonGalleryBarItem)
            galleryItem.Gallery.Appearance.ItemCaptionAppearance.Normal.Font = AppearanceObject.DefaultFont
            galleryItem.Gallery.Appearance.ItemCaptionAppearance.Normal.Options.UseFont = True
            galleryItem.Gallery.Appearance.ItemCaptionAppearance.Normal.TextOptions.HAlignment = HorzAlignment.Near
            galleryItem.Gallery.Appearance.ItemCaptionAppearance.Normal.Options.UseTextOptions = True
            galleryItem.Gallery.Appearance.ItemCaptionAppearance.Hovered.Font = AppearanceObject.DefaultFont
            galleryItem.Gallery.Appearance.ItemCaptionAppearance.Hovered.Options.UseFont = True
            galleryItem.Gallery.Appearance.ItemCaptionAppearance.Hovered.TextOptions.HAlignment = HorzAlignment.Near
            galleryItem.Gallery.Appearance.ItemCaptionAppearance.Hovered.Options.UseTextOptions = True
            galleryItem.Gallery.Appearance.ItemCaptionAppearance.Pressed.Font = AppearanceObject.DefaultFont
            galleryItem.Gallery.Appearance.ItemCaptionAppearance.Pressed.Options.UseFont = True
            galleryItem.Gallery.Appearance.ItemCaptionAppearance.Pressed.TextOptions.HAlignment = HorzAlignment.Near
            galleryItem.Gallery.Appearance.ItemCaptionAppearance.Pressed.Options.UseTextOptions = True
            galleryItem.Gallery.Appearance.ItemCaptionAppearance.Disabled.Font = AppearanceObject.DefaultFont
            galleryItem.Gallery.Appearance.ItemCaptionAppearance.Disabled.Options.UseFont = True
            galleryItem.Gallery.Appearance.ItemCaptionAppearance.Disabled.TextOptions.HAlignment = HorzAlignment.Near
            galleryItem.Gallery.Appearance.ItemCaptionAppearance.Disabled.Options.UseTextOptions = True
        End Sub
    End Class
    Friend NotInheritable Class FiltersTreeListAppearances

        Private Sub New()
        End Sub

        Public Shared Sub Apply(ByVal treeList As XtraTreeList.TreeList)
            treeList.BackColor = System.Drawing.Color.Transparent
            treeList.Appearance.Empty.BackColor = System.Drawing.Color.Transparent
            treeList.Appearance.Empty.Options.UseBackColor = True
            treeList.Appearance.Row.BackColor = System.Drawing.Color.Transparent
            treeList.Appearance.Row.Options.UseBackColor = True
            AddHandler treeList.LookAndFeel.StyleChanged, AddressOf LookAndFeel_StyleChanged
            Dim font = FontResources.GetSegoeUIFont(System.Drawing.FontStyle.Bold)
            treeList.Appearance.FocusedRow.Font = font
            treeList.Appearance.FocusedRow.Options.UseFont = True
            treeList.Appearance.HideSelectionRow.Font = font
            treeList.Appearance.HideSelectionRow.Options.UseFont = True
            treeList.Appearance.SelectedRow.Font = font
            treeList.Appearance.SelectedRow.Options.UseFont = True
        End Sub
        Private Shared Sub LookAndFeel_StyleChanged(ByVal sender As Object, ByVal e As EventArgs)
            Dim lf = DirectCast(sender, LookAndFeel.UserLookAndFeel)
            If lf IsNot Nothing Then
                Dim treeList = TryCast(lf.OwnerControl, XtraTreeList.TreeList)
                If treeList IsNot Nothing Then
                    treeList.Appearance.Row.ForeColor = GridHelper.GetTransparentRowForeColor(lf)
                End If
            End If
        End Sub
    End Class
    Friend NotInheritable Class GroupFiltersListViewAppearances

        Private Sub New()
        End Sub

        Public Shared Sub Apply(ByVal winExplorerView As XtraGrid.Views.WinExplorer.WinExplorerView)
            winExplorerView.Appearance.ItemDescriptionNormal.ForeColor = ColorHelper.DisabledTextColor
            winExplorerView.Appearance.ItemDescriptionNormal.Options.UseForeColor = True
            winExplorerView.Appearance.ItemDescriptionHovered.ForeColor = ColorHelper.DisabledTextColor
            winExplorerView.Appearance.ItemDescriptionHovered.Options.UseForeColor = True
            winExplorerView.Appearance.ItemDescriptionPressed.ForeColor = ColorHelper.DisabledTextColor
            winExplorerView.Appearance.ItemDescriptionPressed.Options.UseForeColor = True
        End Sub
    End Class
    Friend NotInheritable Class AppHelper

        Private Sub New()
        End Sub

        Public Shared Sub ProcessStart(ByVal name As String)
            ProcessStart(name, String.Empty)
        End Sub
        Public Shared Sub ProcessStart(ByVal name As String, ByVal arguments As String)
            Try
                Dim process As New System.Diagnostics.Process()
                process.StartInfo.FileName = name
                process.StartInfo.Arguments = arguments
                process.StartInfo.Verb = "Open"
                process.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Normal
                process.Start()
            Catch e1 As System.ComponentModel.Win32Exception
            End Try
        End Sub
        Public Shared ReadOnly Property AppIcon() As Icon
            Get
                Return DevExpress.Utils.ResourceImageHelper.CreateIconFromResourcesEx("DevExpress.DevAV.Resources.AppIcon.ico", GetType(MainForm).Assembly)
            End Get
        End Property
        Private Shared img As Image
        Public Shared ReadOnly Property AppImage() As Image
            Get
                If img Is Nothing Then
                    img = AppIcon.ToBitmap()
                End If
                Return img
            End Get
        End Property
        Private Shared wRef As WeakReference
        Public Shared Property MainForm() As MainForm
            Get
                Return If(wRef IsNot Nothing, TryCast(wRef.Target, MainForm), Nothing)
            End Get
            Set(ByVal value As MainForm)
                wRef = New WeakReference(value)
            End Set
        End Property
        Public Shared Function GetDefaultSize() As Single
            Return 8.25F
        End Function
    End Class
    Friend NotInheritable Class GridHelper

        Private Sub New()
        End Sub

        Public Shared Sub SetFindControlImages(ByVal grid As GridControl)
            SetFindControlImages(grid, True)
        End Sub
        Public Shared Sub SetFindControlImages(ByVal grid As GridControl, ByVal forceAlignment As Boolean)
            Dim fControl As FindControl = Nothing
            For Each ctrl As Control In grid.Controls
                fControl = TryCast(ctrl, FindControl)
                If fControl IsNot Nothing Then
                    Exit For
                End If
            Next ctrl
            If fControl IsNot Nothing Then
                Dim btn As EditorButton = fControl.FindEdit.Properties.Buttons(0)
                btn.Kind = XtraEditors.Controls.ButtonPredefines.Search
                btn = New EditorButton(ButtonPredefines.Close)
                btn.Visible = False
                fControl.FindEdit.Properties.Buttons.Add(btn)
                AddHandler fControl.FindEdit.ButtonClick, Sub(s, e)
                    If Not e.Button.IsDefaultButton Then
                        Dim edit As ButtonEdit = TryCast(s, ButtonEdit)
                        edit.Text = String.Empty
                    End If
                End Sub
                AddHandler fControl.FindEdit.EditValueChanged, Sub(s, e)
                    Dim edit As MRUEdit = TryCast(s, MRUEdit)
                    edit.Properties.BeginUpdate()
                    Try
                        edit.Properties.Buttons(0).Visible = String.IsNullOrEmpty(edit.Text)
                        edit.Properties.Buttons(1).Visible = Not String.IsNullOrEmpty(edit.Text)
                    Finally
                        edit.Properties.EndUpdate()
                    End Try
                End Sub
                If forceAlignment Then
                    Dim lc As LayoutControl = TryCast(fControl.FindEdit.Parent, LayoutControl)
                    lc.BeginUpdate()
                    Try
                        For i As Integer = lc.Root.Items.Count - 1 To 0 Step -1
                            Dim item As LayoutControlItem = TryCast(lc.Root.Items(i), LayoutControlItem)
                            If item Is Nothing Then
                                Continue For
                            End If
                            If item.Visibility = XtraLayout.Utils.LayoutVisibility.Never Then
                                lc.Root.Remove(item)
                            Else
                                item.ControlAlignment = System.Drawing.ContentAlignment.MiddleRight
                            End If
                        Next i
                    Finally
                        lc.EndUpdate()
                    End Try
                End If
            End If
        End Sub
        Friend Shared Sub HideCustomization(ByVal control As Control)
            If control Is Nothing Then
                Return
            End If
            For Each child As Control In control.Controls
                Dim grid As GridControl = TryCast(child, GridControl)
                If grid IsNot Nothing Then
                    Dim gridView As GridView = TryCast(grid.MainView, GridView)
                    If gridView IsNot Nothing Then
                        gridView.HideCustomization()
                    End If
                    Continue For
                Else
                    HideCustomization(child)
                End If
            Next child
        End Sub
        Friend Shared Function GetTransparentRowForeColor(ByVal lf As LookAndFeel.UserLookAndFeel) As Color
            Return If(DevExpress.Utils.Frames.FrameHelper.IsDarkSkin(lf) OrElse lf.ActiveSkinName = "VS2010", (If(lf.ActiveSkinName = "VS2010", ColorHelper.GetControlColor(lf), ColorHelper.TextColor)), Color.Empty)
        End Function
    End Class
    Friend NotInheritable Class ChartHelper

        Private Sub New()
        End Sub

        Friend Shared Function GetBackColor(ByVal chartControl As DevExpress.XtraCharts.ChartControl) As Color
            Return DirectCast(chartControl, DevExpress.XtraCharts.Native.IChartContainer).Chart.ActualBackColor
        End Function
    End Class
    Friend Class LabelTabController
        Private labels() As LabelControl
        Public Sub New(ByVal eValue As Object, ParamArray ByVal list() As LabelControl)
            Me.labels = list
            EditValue = eValue
            For Each lb As LabelControl In list
                AddHandler lb.Click, Sub(s, e) EditValue = CType(s, LabelControl).Tag
            Next lb
        End Sub
        Private editValueCore As Object
        Public Property EditValue() As Object
            Get
                Return editValueCore
            End Get
            Set(ByVal value As Object)
                If Object.Equals(editValueCore, value) Then
                    Return
                End If
                editValueCore = value
                OnEditValueChanged()
            End Set
        End Property
        Private Sub OnEditValueChanged()
            UpdateAppearance()
            RaiseEditValueChanged()
        End Sub
        Private Sub UpdateAppearance()
            For Each lc As LabelControl In labels
                Dim isSelected As Boolean = EditValue.Equals(lc.Tag)
                lc.Font = FontResources.GetFont(lc.Font.FontFamily.Name, 10.25F,If(isSelected, FontStyle.Bold, FontStyle.Regular))
                lc.Appearance.ForeColor = If(isSelected, ColorHelper.QuestionColor, Color.Empty)
            Next lc
        End Sub
        Public Event EditValueChanged As EventHandler
        Private Sub RaiseEditValueChanged()
            Dim handler As EventHandler = EditValueChangedEvent
            If handler IsNot Nothing Then
                handler(EditValue, EventArgs.Empty)
            End If
        End Sub
    End Class
    Friend NotInheritable Class FontResources

        Private Sub New()
        End Sub

        Private Shared cache As IDictionary(Of String, Font)
        Shared Sub New()
            cache = New Dictionary(Of String, Font)()
        End Sub
        Public Shared Function GetSegoeUIFont(ByVal fontStyle As FontStyle) As Font
            Dim defaultSize As Single = DevExpress.Utils.AppearanceObject.DefaultFont.Size
            Return GetFont("Segoe UI", defaultSize, fontStyle)
        End Function
        Public Shared Function GetSegoeUIFont(Optional ByVal sizeGrow As Single = 0) As Font
            Dim defaultSize As Single = DevExpress.Utils.AppearanceObject.DefaultFont.Size
            Return GetFont("Segoe UI", defaultSize + sizeGrow)
        End Function
        Public Shared Function GetSegoeUILightFont(Optional ByVal sizeGrow As Single = 0) As Font
            Dim defaultSize As Single = DevExpress.Utils.AppearanceObject.DefaultFont.Size
            Return GetFont("Segoe UI Light", defaultSize + sizeGrow)
        End Function
        Public Shared Function GetFont(ByVal familyName As String, ByVal size As Single, Optional ByVal style As FontStyle = FontStyle.Regular) As Font
            Dim key As String = familyName & "#" & size.ToString()
            If style <> FontStyle.Regular Then
                key &= ("#" & style.ToString())
            End If
            Dim result As Font = Nothing
            If Not cache.TryGetValue(key, result) Then
                Try
                    Dim family = FindFontFamily(familyName)
                    result = New Font(If(family, FontFamily.GenericSansSerif), size, style)
                Catch e1 As ArgumentException
                    result = DevExpress.Utils.AppearanceObject.DefaultFont
                End Try
                cache.Add(key, result)
            End If
            Return result
        End Function
        Private Shared Function FindFontFamily(ByVal familyName As String) As FontFamily
            Return Array.Find(FontFamily.Families, Function(f) f.Name = familyName)
        End Function
    End Class
    Friend NotInheritable Class ColorHelper

        Private Sub New()
        End Sub

        Public Shared Function GetControlColor(ByVal provider As DevExpress.LookAndFeel.UserLookAndFeel) As Color
            Return DevExpress.LookAndFeel.LookAndFeelHelper.GetSystemColor(provider, SystemColors.Control)
        End Function
        Public Shared ReadOnly Property TextColor() As Color
            Get
                Return CommonSkins.GetSkin(DevExpress.LookAndFeel.UserLookAndFeel.Default).Colors.GetColor(CommonColors.ControlText)
            End Get
        End Property
        Public Shared ReadOnly Property WindowColor() As Color
            Get
                Return CommonSkins.GetSkin(DevExpress.LookAndFeel.UserLookAndFeel.Default).Colors.GetColor(CommonColors.Window)
            End Get
        End Property
        Public Shared ReadOnly Property WindowTextColor() As Color
            Get
                Return CommonSkins.GetSkin(DevExpress.LookAndFeel.UserLookAndFeel.Default).Colors.GetColor(CommonColors.WindowText)
            End Get
        End Property
        Public Shared ReadOnly Property DisabledTextColor() As Color
            Get
                Return CommonSkins.GetSkin(DevExpress.LookAndFeel.UserLookAndFeel.Default).Colors.GetColor(CommonColors.DisabledText)
            End Get
        End Property
        Public Shared ReadOnly Property CriticalColor() As Color
            Get
                Return CommonColors.GetCriticalColor(DevExpress.LookAndFeel.UserLookAndFeel.Default)
            End Get
        End Property
        Public Shared ReadOnly Property WarningColor() As Color
            Get
                Return CommonColors.GetWarningColor(DevExpress.LookAndFeel.UserLookAndFeel.Default)
            End Get
        End Property
        Public Shared ReadOnly Property QuestionColor() As Color
            Get
                Return CommonColors.GetQuestionColor(DevExpress.LookAndFeel.UserLookAndFeel.Default)
            End Get
        End Property
        Public Shared ReadOnly Property InformationColor() As Color
            Get
                Return CommonColors.GetInformationColor(DevExpress.LookAndFeel.UserLookAndFeel.Default)
            End Get
        End Property
    End Class
    Friend NotInheritable Class EditorHelpers

        Private Sub New()
        End Sub

        Public Shared Function CreatePersonPrefixImageComboBox(Optional ByVal edit As RepositoryItemImageComboBox = Nothing, Optional ByVal collection As RepositoryItemCollection = Nothing) As RepositoryItemImageComboBox
            Dim ret As RepositoryItemImageComboBox = CreateEnumImageComboBox(Of PersonPrefix)(edit, collection)
            ret.SmallImages = CreatePersonPrefixImageCollection()
            If edit Is Nothing Then
                ret.GlyphAlignment = HorzAlignment.Center
            End If
            Return ret
        End Function
        Public Shared Function CreateTaskPriorityImageComboBox(Optional ByVal edit As RepositoryItemImageComboBox = Nothing, Optional ByVal collection As RepositoryItemCollection = Nothing) As RepositoryItemImageComboBox
            Dim ret As RepositoryItemImageComboBox = CreateEnumImageComboBox(Of EmployeeTaskPriority)(edit, collection)
            ret.SmallImages = CreateTaskPriorityImageCollection()
            If edit Is Nothing Then
                ret.GlyphAlignment = HorzAlignment.Center
            End If
            Return ret
        End Function
        Private Shared Function CreatePersonPrefixImageCollection() As ImageCollection
            Dim ret As New ImageCollection()
            ret.ImageSize = New Size(16, 16)
            ret.AddImage(My.Resources.Doctor)
            ret.AddImage(My.Resources.Mr)
            ret.AddImage(My.Resources.Ms)
            ret.AddImage(My.Resources.Miss)
            ret.AddImage(My.Resources.Mrs)
            Return ret
        End Function
        Private Shared Function CreateTaskPriorityImageCollection() As ImageCollection
            Dim ret As New ImageCollection()
            ret.ImageSize = New Size(16, 16)
            ret.AddImage(My.Resources.LowPriority)
            ret.AddImage(My.Resources.NormalPriority)
            ret.AddImage(My.Resources.MediumPriority)
            ret.AddImage(My.Resources.HighPriority)
            Return ret
        End Function
        Public Shared Function CreateManeuverImageComboBox(Optional ByVal edit As RepositoryItemImageComboBox = Nothing, Optional ByVal collection As RepositoryItemCollection = Nothing) As RepositoryItemImageComboBox
            Dim ret As RepositoryItemImageComboBox = CreateEnumImageComboBox(Of DevExpress.XtraMap.BingManeuverType)(edit, collection)
            For Each item As ImageComboBoxItem In ret.Items
                Select Case CType(item.Value, DevExpress.XtraMap.BingManeuverType)
                    Case DevExpress.XtraMap.BingManeuverType.DepartStart
                        item.ImageIndex = 0
                    Case DevExpress.XtraMap.BingManeuverType.TurnLeft
                        item.ImageIndex = 1
                    Case DevExpress.XtraMap.BingManeuverType.TurnRight
                        item.ImageIndex = 2
                    Case DevExpress.XtraMap.BingManeuverType.ArriveFinish
                        item.ImageIndex = 3
                    Case DevExpress.XtraMap.BingManeuverType.UTurn
                        item.ImageIndex = 4
                    Case DevExpress.XtraMap.BingManeuverType.BearLeft
                        item.ImageIndex = 5
                    Case DevExpress.XtraMap.BingManeuverType.BearRight
                        item.ImageIndex = 6
                End Select
                item.Description = String.Empty
            Next item
            ret.SmallImages = CreateBingManeuverTypeImageCollection()
            ret.GlyphAlignment = HorzAlignment.Center
            Return ret
        End Function
        Private Shared Function CreateBingManeuverTypeImageCollection() As ImageCollection
            Dim ret As New ImageCollection()
            ret.ImageSize = New Size(32, 32)
            ret.AddImage(My.Resources.icon_A_32)
            ret.AddImage(My.Resources.icon_arrow_left_32)
            ret.AddImage(My.Resources.icon_arrow_right_32)
            ret.AddImage(My.Resources.icon_B_32)
            ret.AddImage(My.Resources.icon_arrow_uturn_32)
            ret.AddImage(My.Resources.icon_arrow_bear_left_32)
            ret.AddImage(My.Resources.icon_arrow_bear_right_32)
            ret.AddImage(My.Resources.icon_arrow_forward_32)
            Return ret
        End Function
        Public Shared Function CreateEnumImageComboBox(Of TEnum)(ByVal container As DevExpress.XtraEditors.Container.EditorContainer, Optional ByVal displayTextConverter As Converter(Of TEnum, String) = Nothing) As RepositoryItemImageComboBox
            Return CreatEdit(Of RepositoryItemImageComboBox)(Nothing,If(container IsNot Nothing, container.RepositoryItems, Nothing), Sub(e) e.Items.AddEnum(Of TEnum)(displayTextConverter))
        End Function
        Public Shared Function CreateEnumImageComboBox(Of TEnum)(Optional ByVal edit As RepositoryItemImageComboBox = Nothing, Optional ByVal collection As RepositoryItemCollection = Nothing, Optional ByVal displayTextConverter As Converter(Of TEnum, String) = Nothing) As RepositoryItemImageComboBox
            Return CreatEdit(Of RepositoryItemImageComboBox)(edit, collection, Sub(e) e.Items.AddEnum(Of TEnum)(displayTextConverter))
        End Function
        Public Shared Function CreatDateEdit(Optional ByVal edit As RepositoryItemDateEdit = Nothing, Optional ByVal collection As RepositoryItemCollection = Nothing) As RepositoryItemDateEdit
            Return CreatEdit(Of RepositoryItemDateEdit)(edit, collection)
        End Function
        Public Shared Function CreatEdit(Of TEdit As {RepositoryItem, New})(Optional ByVal edit As TEdit = Nothing, Optional ByVal collection As RepositoryItemCollection = Nothing, Optional ByVal initialize As Action(Of TEdit) = Nothing) As TEdit
            edit = If(edit, New TEdit())
            If collection IsNot Nothing Then
                collection.Add(edit)
            End If
            If initialize IsNot Nothing Then
                initialize(edit)
            End If
            Return edit
        End Function
        Public Shared Sub ApplyBindingSettings(Of TEntity)(ByVal edit As BaseEdit, ByVal layoutControl As LayoutControl)
            Dim memberInfo = edit.DataBindings("EditValue").BindingMemberInfo
            If DataAnnotationHelper.IsRequired(Of TEntity)(memberInfo.BindingMember) Then
                If layoutControl IsNot Nothing Then
                    Dim itemForEdit = layoutControl.GetItemByControl(edit)
                    itemForEdit.AllowHtmlStringInCaption = True
                    itemForEdit.Text = itemForEdit.Text & " <color=red>*</color>"
                End If
            End If
            If TypeOf edit Is TextEdit Then
                If DataAnnotationHelper.IsPhone(Of TEntity)(memberInfo.BindingMember) Then
                    CType(edit, TextEdit).Properties.Mask.MaskType = XtraEditors.Mask.MaskType.Simple
                    CType(edit, TextEdit).Properties.Mask.EditMask = "(999) 000-0000"
                    CType(edit, TextEdit).Properties.Mask.UseMaskAsDisplayFormat = True
                End If
                If DataAnnotationHelper.IsZipcode(Of TEntity)(memberInfo.BindingMember) Then
                    CType(edit, TextEdit).Properties.Mask.MaskType = XtraEditors.Mask.MaskType.Simple
                    CType(edit, TextEdit).Properties.Mask.EditMask = "00000"
                    CType(edit, TextEdit).Properties.Mask.UseMaskAsDisplayFormat = True
                End If
            End If
        End Sub
    End Class
    Friend Class FilterColumnCollectionBuilder(Of TEntity)
        Private filterColumns As FilterColumnCollection
        Public Sub New()
            Me.filterColumns = New FilterColumnCollection()
        End Sub
        Public Sub New(ByVal filterColumns As FilterColumnCollection)
            Me.filterColumns = filterColumns
        End Sub
        Public Function Build() As FilterColumnCollection
            Return filterColumns
        End Function
        Public Function AddColumn(Of T)(ByVal expression As Expression(Of Func(Of TEntity, T)), Optional ByVal repositoryItem As DevExpress.XtraEditors.Repository.RepositoryItem = Nothing, Optional ByVal clauseClass As FilterColumnClauseClass = FilterColumnClauseClass.String, Optional ByVal caption As String = Nothing) As FilterColumnCollectionBuilder(Of TEntity)
            If repositoryItem Is Nothing Then
                If GetType(T) Is GetType(Boolean) OrElse (GetType(T) Is GetType(Boolean?)) Then
                    repositoryItem = EditorHelpers.CreatEdit(Of RepositoryItemCheckEdit)()
                    clauseClass = FilterColumnClauseClass.Generic
                End If
                If (GetType(T) Is GetType(Double)) OrElse (GetType(T) Is GetType(Double?)) OrElse (GetType(T) Is GetType(Decimal)) OrElse (GetType(T) Is GetType(Decimal?)) Then
                    repositoryItem = EditorHelpers.CreatEdit(Of RepositoryItemSpinEdit)()
                    clauseClass = FilterColumnClauseClass.Generic
                End If
                If GetType(T) Is GetType(Integer) OrElse (GetType(T) Is GetType(Integer?)) Then
                    Dim spinEdit = EditorHelpers.CreatEdit(Of RepositoryItemSpinEdit)()
                    spinEdit.IsFloatValue = False
                    repositoryItem = spinEdit
                    clauseClass = FilterColumnClauseClass.Generic
                End If
            End If
            filterColumns.Add(CreateColumn(expression, caption, Nothing, repositoryItem, clauseClass))
            Return Me
        End Function
        Public Function AddLookupColumn(Of T)(ByVal expression As Expression(Of Func(Of TEntity, T))) As FilterColumnCollectionBuilder(Of TEntity)
            Return AddColumn(expression, EditorHelpers.CreateEnumImageComboBox(Of T)(), FilterColumnClauseClass.Lookup)
        End Function
        Public Function AddDateTimeColumn(Of T)(ByVal expression As Expression(Of Func(Of TEntity, T))) As FilterColumnCollectionBuilder(Of TEntity)
            Return AddColumn(expression, EditorHelpers.CreatDateEdit(), FilterColumnClauseClass.DateTime)
        End Function
        Private Function CreateColumn(Of T)(ByVal expression As Expression(Of Func(Of TEntity, T)), ByVal caption As String, ByVal fieldName As String, ByVal repositoryItem As DevExpress.XtraEditors.Repository.RepositoryItem, ByVal clauseClass As FilterColumnClauseClass) As UnboundFilterColumn
            Dim member = (TryCast(expression.Body, MemberExpression)).Member
            If String.IsNullOrEmpty(fieldName) Then
                fieldName = GetFieldName(Of T)(expression)
            End If
            If String.IsNullOrEmpty(caption) Then
                caption = GetDisplayName(member)
            End If
            Return CreateColumn(Of T)(caption, fieldName, repositoryItem, clauseClass)
        End Function
        Private Function CreateColumn(Of T)(ByVal caption As String, ByVal fieldName As String, ByVal repositoryItem As DevExpress.XtraEditors.Repository.RepositoryItem, ByVal clauseClass As FilterColumnClauseClass) As UnboundFilterColumn
            Return New UnboundFilterColumn(caption, fieldName, GetType(T), repositoryItem, clauseClass)
        End Function
        Private Function GetFieldName(Of T)(ByVal expression As Expression(Of Func(Of TEntity, T))) As String
            Dim sb = New System.Text.StringBuilder()
            Dim [me] As MemberExpression = TryCast(expression.Body, MemberExpression)
            Do While [me] IsNot Nothing
                If sb.Length > 0 Then
                    sb.Insert(0, ".")
                End If
                sb.Insert(0, [me].Member.Name)
                [me] = TryCast([me].Expression, MemberExpression)
            Loop
            Return sb.ToString()
        End Function
        Private Function GetDisplayName(ByVal member As System.Reflection.MemberInfo) As String
            Dim displayName As String = member.Name
            If CheckDisplayNameAttribute(Of System.ComponentModel.DataAnnotations.DisplayAttribute)(member, Function(a) a.GetName(), displayName) Then
                Return displayName
            End If
            If CheckDisplayNameAttribute(Of System.ComponentModel.DisplayNameAttribute)(member, Function(a) a.DisplayName, displayName) Then
                Return displayName
            End If
            Return displayName
        End Function
        Private Function CheckDisplayNameAttribute(Of TAttribute As Attribute)(ByVal member As System.Reflection.MemberInfo, ByVal accessor As Func(Of TAttribute, String), ByRef displayName As String) As Boolean
            Dim displayAttributes = member.GetCustomAttributes(GetType(TAttribute), True)
            If displayAttributes.Length > 0 Then
                displayName = accessor(DirectCast(displayAttributes(0), TAttribute))
                Return True
            End If
            Return False
        End Function
    End Class
    Friend NotInheritable Class FilterControlWithoutLike

        Private Sub New()
        End Sub

        Public Shared Sub Apply(ByVal filterControl As FilterControl)
            AddHandler filterControl.PopupMenuShowing, AddressOf filterControl_PopupMenuShowing
        End Sub
        Private Shared Sub filterControl_PopupMenuShowing(ByVal sender As Object, ByVal e As XtraEditors.Filtering.PopupMenuShowingEventArgs)
            For i As Integer = e.Menu.Items.Count - 1 To 0 Step -1
                If e.Menu.Items(i).Caption = Localizer.Active.GetLocalizedString(StringId.FilterClauseLike) OrElse e.Menu.Items(i).Caption = Localizer.Active.GetLocalizedString(StringId.FilterClauseNotLike) Then
                    e.Menu.Items.RemoveAt(i)
                End If
            Next i
        End Sub
    End Class
    Friend Class DemoStartUp
        Implements IObserver(Of String)

        Private Sub IObserverGeneric_OnCompleted() Implements IObserver(Of String).OnCompleted
            XtraSplashScreen.SplashScreenManager.CloseForm(False, 1500, AppHelper.MainForm)
        End Sub
        Private Sub IObserverGeneric_OnNext(ByVal status As String) Implements IObserver(Of String).OnNext
            If DevExpress.XtraSplashScreen.SplashScreenManager.Default Is Nothing Then
                XtraSplashScreen.SplashScreenManager.ShowDefaultSplashScreen(AppHelper.MainForm, True, True, "DevExpress WinForms Controls", status)
            Else
                XtraSplashScreen.SplashScreenManager.SetDefaultSplashScreenStatus(False, status)
            End If
        End Sub
        Private Sub IObserverGeneric_OnError(ByVal [error] As Exception) Implements IObserver(Of String).OnError
            Throw [error]
        End Sub
    End Class
    Friend Class DataGenerationProgress
        Implements IObserver(Of String)

        Private Sub IObserverGeneric_OnNext(ByVal status As String) Implements IObserver(Of String).OnNext
            XtraSplashScreen.SplashScreenManager.SetDefaultSplashScreenStatus(False, status)
        End Sub
        Private Sub IObserverGeneric_OnCompleted() Implements IObserver(Of String).OnCompleted
        End Sub
        Private Sub IObserverGeneric_OnError(ByVal [error] As Exception) Implements IObserver(Of String).OnError
            Throw [error]
        End Sub
    End Class
    Public Class EntityEventArgs(Of TID)
        Inherits EventArgs

        Private entityKeyCore As TID
        Public Sub New(ByVal entityKey As TID)
            Me.entityKeyCore = entityKey
        End Sub
        Public ReadOnly Property Key() As TID
            Get
                Return entityKeyCore
            End Get
        End Property
    End Class
    Public Class EntitiesCountEventArgs
        Inherits EventArgs

        Public Sub New(ByVal count As Integer)
            Me.Count = count
        End Sub
        Private privateCount As Integer
        Public Property Count() As Integer
            Get
                Return privateCount
            End Get
            Private Set(ByVal value As Integer)
                privateCount = value
            End Set
        End Property
    End Class
    Public Class GroupEventArgs(Of TKey)
        Inherits EventArgs

        Private keysCore As IEnumerable(Of TKey)
        Public Sub New(ByVal keys As IEnumerable(Of TKey))
            Me.keysCore = keys
        End Sub
        Public ReadOnly Property Entities() As IEnumerable(Of TKey)
            Get
                Return keysCore
            End Get
        End Property
    End Class
End Namespace
