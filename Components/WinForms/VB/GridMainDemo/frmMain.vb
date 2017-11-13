Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data
Imports DevExpress.Utils
Imports DevExpress.DXperience.Demos
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Base
Imports System.Drawing.Drawing2D
Imports DevExpress.XtraGrid.Views.Layout
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.Utils.About
Imports DevExpress.Tutorials

Namespace DevExpress.XtraGrid.Demos
    Public Class frmMain
        Inherits DevExpress.DXperience.Demos.RibbonMainForm
        Protected Overrides ReadOnly Property FileType() As SourceFileType
            Get
                Return SourceFileType.VB
            End Get
        End Property
        Private showOutdated As Boolean = False
        Public Sub New(ByVal arguments() As String)
            MyBase.New(arguments)
            GetStartedLink = AssemblyInfo.DXLinkGetStartedWinGrid
            ToolTipController.DefaultController.ToolTipType = DevExpress.Utils.ToolTipType.SuperTip
        End Sub
        Protected Overrides ReadOnly Property DemoName() As String
            Get
                Return My.Resources.DemoName
            End Get
        End Property
        Protected Overrides Sub ShowAbout()
            GridControl.About()
        End Sub
        Protected Overrides Sub SetFormParam()
            Me.MinimumSize = New System.Drawing.Size(800, 600)
            Me.Icon = DevExpress.Utils.ResourceImageHelper.CreateIconFromResources("AppIcon.ico", GetType(frmMain).Assembly)
        End Sub
        Protected Overrides Function CreateRibbonMenuManager() As RibbonMenuManager
            Return New GridRibbonMenuManager(Me)
        End Function
        Protected Overrides Sub ShowModule(ByVal name As String, ByVal group As DevExpress.XtraEditors.GroupControl, ByVal lookAndFeel As DevExpress.LookAndFeel.DefaultLookAndFeel, ByVal caption As DevExpress.Utils.Frames.ApplicationCaption)
            DemosInfo.ShowModule(name, group, caption, TryCast(RibbonMenuManager, GridRibbonMenuManager))
        End Sub
        Protected Overrides ReadOnly Property NotTranslatedModuleTypes() As String
            Get
                If LocalizationHelper.IsJapanese Then
                    Return ";NWindNavigator;Styles;AlphaBlending;CustomDraw;"
                End If
                Return MyBase.NotTranslatedModuleTypes
            End Get
        End Property
        Protected Overrides Sub FillNavBar()
            DemosInfo.FillAccordionControl(accordionControl1, DevExpress.XtraNavBar.NavBarGroupStyle.SmallIconsText, showOutdated)
        End Sub
        Protected Overrides Sub RegisterEnumTitles()
            MyBase.RegisterEnumTitles()
            EnumTitlesKeeper(Of FindMode).RegisterTitle(FindMode.Default, My.Resources.FindModeDefault)
            EnumTitlesKeeper(Of FindMode).RegisterTitle(FindMode.Always, My.Resources.FindModeAlways)
            EnumTitlesKeeper(Of FindMode).RegisterTitle(FindMode.FindClick, My.Resources.FindModeFindClick)
            EnumTitlesKeeper(Of WaitAnimationOptions).RegisterTitle(WaitAnimationOptions.Default, My.Resources.WaitAnimationOptionsDefault)
            EnumTitlesKeeper(Of WaitAnimationOptions).RegisterTitle(WaitAnimationOptions.Indicator, My.Resources.WaitAnimationOptionsIndicator)
            EnumTitlesKeeper(Of WaitAnimationOptions).RegisterTitle(WaitAnimationOptions.Panel, My.Resources.WaitAnimationOptionsPanel)
            EnumTitlesKeeper(Of TextEditStyles).RegisterTitle(TextEditStyles.Standard, My.Resources.TextEditStylesStandard)
            EnumTitlesKeeper(Of TextEditStyles).RegisterTitle(TextEditStyles.DisableTextEditor, My.Resources.TextEditStylesDisableTextEditor)
            EnumTitlesKeeper(Of TextEditStyles).RegisterTitle(TextEditStyles.HideTextEditor, My.Resources.TextEditStylesHideTextEditor)
            EnumTitlesKeeper(Of PopupFilterMode).RegisterTitle(PopupFilterMode.Default, My.Resources.PopupFilterModeDefault)
            EnumTitlesKeeper(Of PopupFilterMode).RegisterTitle(PopupFilterMode.Contains, My.Resources.PopupFilterModeContains)
            EnumTitlesKeeper(Of PopupFilterMode).RegisterTitle(PopupFilterMode.StartsWith, My.Resources.PopupFilterModeStartsWith)
            EnumTitlesKeeper(Of GroupFooterShowMode).RegisterTitle(GroupFooterShowMode.VisibleAlways, My.Resources.GroupFooterShowModeVisibleAlways)
            EnumTitlesKeeper(Of GroupFooterShowMode).RegisterTitle(GroupFooterShowMode.VisibleIfExpanded, My.Resources.GroupFooterShowModeVisibleIfExpanded)
            EnumTitlesKeeper(Of GroupFooterShowMode).RegisterTitle(GroupFooterShowMode.Hidden, My.Resources.GroupFooterShowModeHidden)
            EnumTitlesKeeper(Of GridMultiSelectMode).RegisterTitle(GridMultiSelectMode.CellSelect, My.Resources.CellSelect)
            EnumTitlesKeeper(Of GridMultiSelectMode).RegisterTitle(GridMultiSelectMode.RowSelect, My.Resources.RowSelect)
            EnumTitlesKeeper(Of GridMultiSelectMode).RegisterTitle(GridMultiSelectMode.CheckBoxRowSelect, "Check Box Row Select")
            EnumTitlesKeeper(Of GridAnimationType).RegisterTitle(GridAnimationType.Default, My.Resources.GridAnimationTypeDefault)
            EnumTitlesKeeper(Of GridAnimationType).RegisterTitle(GridAnimationType.AnimateAllContent, My.Resources.GridAnimationTypeAnimateAllContent)
            EnumTitlesKeeper(Of GridAnimationType).RegisterTitle(GridAnimationType.AnimateFocusedItem, My.Resources.GridAnimationTypeAnimateFocusedItem)
            EnumTitlesKeeper(Of GridAnimationType).RegisterTitle(GridAnimationType.NeverAnimate, My.Resources.GridAnimationTypeNeverAnimate)
            EnumTitlesKeeper(Of DevExpress.XtraGrid.Demos.AdvancedGridEditing.MasterTablePosition).RegisterTitle(DevExpress.XtraGrid.Demos.AdvancedGridEditing.MasterTablePosition.Bottom, My.Resources.MasterTablePositionBottom)
            EnumTitlesKeeper(Of DevExpress.XtraGrid.Demos.AdvancedGridEditing.MasterTablePosition).RegisterTitle(DevExpress.XtraGrid.Demos.AdvancedGridEditing.MasterTablePosition.Left, My.Resources.MasterTablePositionLeft)
            EnumTitlesKeeper(Of DevExpress.XtraGrid.Demos.AdvancedGridEditing.MasterTablePosition).RegisterTitle(DevExpress.XtraGrid.Demos.AdvancedGridEditing.MasterTablePosition.Right, My.Resources.MasterTablePositionRight)
            EnumTitlesKeeper(Of DevExpress.XtraGrid.Demos.AdvancedGridEditing.MasterTablePosition).RegisterTitle(DevExpress.XtraGrid.Demos.AdvancedGridEditing.MasterTablePosition.Top, My.Resources.MasterTablePositionTop)
            EnumTitlesKeeper(Of InterpolationMode).RegisterTitle(InterpolationMode.Default, My.Resources.InterpolationModeDefault)
            EnumTitlesKeeper(Of InterpolationMode).RegisterTitle(InterpolationMode.Low, My.Resources.InterpolationModeLow)
            EnumTitlesKeeper(Of InterpolationMode).RegisterTitle(InterpolationMode.High, My.Resources.InterpolationModeHigh)
            EnumTitlesKeeper(Of InterpolationMode).RegisterTitle(InterpolationMode.Bicubic, My.Resources.InterpolationModeBicubic)
            EnumTitlesKeeper(Of InterpolationMode).RegisterTitle(InterpolationMode.Bilinear, My.Resources.InterpolationModeBilinear)
            EnumTitlesKeeper(Of InterpolationMode).RegisterTitle(InterpolationMode.NearestNeighbor, My.Resources.InterpolationModeNearestNeighbor)
            EnumTitlesKeeper(Of InterpolationMode).RegisterTitle(InterpolationMode.HighQualityBicubic, My.Resources.InterpolationModeHighQualityBicubic)
            EnumTitlesKeeper(Of InterpolationMode).RegisterTitle(InterpolationMode.HighQualityBilinear, My.Resources.InterpolationModeHighQualityBilinear)
            EnumTitlesKeeper(Of FormatCondition).RegisterTitle(FormatCondition.Between, My.Resources.FormatConditionEnumBetween)
            EnumTitlesKeeper(Of FormatCondition).RegisterTitle(FormatCondition.Equal, My.Resources.FormatConditionEnumEqual)
            EnumTitlesKeeper(Of FormatCondition).RegisterTitle(FormatCondition.Greater, My.Resources.FormatConditionEnumGreater)
            EnumTitlesKeeper(Of FormatCondition).RegisterTitle(FormatCondition.GreaterOrEqual, My.Resources.FormatConditionEnumGreaterOrEqual)
            EnumTitlesKeeper(Of FormatCondition).RegisterTitle(FormatCondition.Less, My.Resources.FormatConditionEnumLess)
            EnumTitlesKeeper(Of FormatCondition).RegisterTitle(FormatCondition.LessOrEqual, My.Resources.FormatConditionEnumLessOrEqual)
            EnumTitlesKeeper(Of FormatCondition).RegisterTitle(FormatCondition.None, My.Resources.FormatConditionEnumNone)
            EnumTitlesKeeper(Of FormatCondition).RegisterTitle(FormatCondition.NotBetween, My.Resources.FormatConditionEnumNotBetween)
            EnumTitlesKeeper(Of FormatCondition).RegisterTitle(FormatCondition.NotEqual, My.Resources.FormatConditionEnumNotEqual)
            EnumTitlesKeeper(Of GroupDrawMode).RegisterTitle(GroupDrawMode.Default, My.Resources.GroupDrawModeDefault)
            EnumTitlesKeeper(Of GroupDrawMode).RegisterTitle(GroupDrawMode.Office2003, My.Resources.GroupDrawModeOffice2003)
            EnumTitlesKeeper(Of GroupDrawMode).RegisterTitle(GroupDrawMode.Standard, My.Resources.GroupDrawModeStandard)
            EnumTitlesKeeper(Of DefaultBoolean).RegisterTitle(DefaultBoolean.Default, My.Resources.DefaultBooleanDefault)
            EnumTitlesKeeper(Of DefaultBoolean).RegisterTitle(DefaultBoolean.False, My.Resources.DefaultBooleanFalse)
            EnumTitlesKeeper(Of DefaultBoolean).RegisterTitle(DefaultBoolean.True, My.Resources.DefaultBooleanTrue)
            ResourcesKeeper.RegisterTitle("AllowCellMerge", My.Resources.AllowCellMerge)
            ResourcesKeeper.RegisterTitle("AllowHtmlDrawGroups", My.Resources.AllowHtmlDrawGroups)
            ResourcesKeeper.RegisterTitle("AllowHtmlDrawHeaders", My.Resources.AllowHtmlDrawHeaders)
            ResourcesKeeper.RegisterTitle("AutoCalcPreviewLineCount", My.Resources.AutoCalcPreviewLineCount)
            ResourcesKeeper.RegisterTitle("ColumnAutoWidth", My.Resources.ColumnAutoWidth)
            ResourcesKeeper.RegisterTitle("EnableAppearanceEvenRow", My.Resources.EnableAppearanceEvenRow)
            ResourcesKeeper.RegisterTitle("EnableAppearanceOddRow", My.Resources.EnableAppearanceOddRow)
            ResourcesKeeper.RegisterTitle("RowAutoHeight", My.Resources.RowAutoHeight)
            ResourcesKeeper.RegisterTitle("ShowAutoFilterRow", My.Resources.ShowAutoFilterRow)
            ResourcesKeeper.RegisterTitle("ShowChildrenInGroupPanel", My.Resources.ShowChildrenInGroupPanel)
            ResourcesKeeper.RegisterTitle("ShowColumnHeaders", My.Resources.ShowColumnHeaders)
            ResourcesKeeper.RegisterTitle("ShowDetailButtons", My.Resources.ShowDetailButtons)
            ResourcesKeeper.RegisterTitle("ShowFooter", My.Resources.ShowFooter)
            ResourcesKeeper.RegisterTitle("ShowGroupedColumns", My.Resources.ShowGroupedColumns)
            ResourcesKeeper.RegisterTitle("ShowGroupExpandCollapseButtons", My.Resources.ShowGroupExpandCollapseButtons)
            ResourcesKeeper.RegisterTitle("ShowGroupPanel", My.Resources.ShowGroupPanel)
            ResourcesKeeper.RegisterTitle("ShowIndicator", My.Resources.ShowIndicator)
            ResourcesKeeper.RegisterTitle("ShowPreview", My.Resources.ShowPreview)
            ResourcesKeeper.RegisterTitle("ShowViewCaption", My.Resources.ShowViewCaption)
            ResourcesKeeper.RegisterTitle("ShowBands", My.Resources.ShowBands)
            ResourcesKeeper.RegisterTitle("ShowCardCaption", My.Resources.ShowCardCaption)
            ResourcesKeeper.RegisterTitle("ShowCardExpandButton", My.Resources.ShowCardExpandButton)
            ResourcesKeeper.RegisterTitle("ShowEmptyFields", My.Resources.ShowEmptyFields)
            ResourcesKeeper.RegisterTitle("ShowFieldCaptions", My.Resources.ShowFieldCaptions)
            ResourcesKeeper.RegisterTitle("ShowFieldHints", My.Resources.ShowFieldHints)
            ResourcesKeeper.RegisterTitle("ShowHorzScrollBar", My.Resources.ShowHorzScrollBar)
            ResourcesKeeper.RegisterTitle("ShowLines", My.Resources.ShowLines)
            ResourcesKeeper.RegisterTitle("ShowQuickCustomizeButton", My.Resources.ShowQuickCustomizeButton)
            ResourcesKeeper.RegisterTitle("EnableAppearanceFocusedCell", My.Resources.EnableAppearanceFocusedCell)
            ResourcesKeeper.RegisterTitle("EnableAppearanceFocusedRow", My.Resources.EnableAppearanceFocusedRow)
            ResourcesKeeper.RegisterTitle("EnableAppearanceHideSelection", My.Resources.EnableAppearanceHideSelection)
            ResourcesKeeper.RegisterTitle("InvertSelection", My.Resources.InvertSelection)
            ResourcesKeeper.RegisterTitle("MultiSelect", My.Resources.MultiSelect)
            ResourcesKeeper.RegisterTitle("UseIndicatorForSelection", My.Resources.UseIndicatorForSelection)
            ResourcesKeeper.RegisterTitle("AllowGlyphSkinning", "Allow Glyph Skinning")
            ResourcesKeeper.RegisterTitle("ShowGroupPanelColumnsAsSingleRow", "Show Group Panel Columns As Single Row")
            ResourcesKeeper.RegisterTitle("ResetSelectionClickOutsideCheckboxSelector", "Reset Selection Click Outside Checkbox Selector")
            EnumTitlesKeeper(Of CardsAlignment).RegisterTitle(CardsAlignment.Center, My.Resources.CardsAlignmentCenter)
            EnumTitlesKeeper(Of CardsAlignment).RegisterTitle(CardsAlignment.Near, My.Resources.CardsAlignmentNear)
            EnumTitlesKeeper(Of CardsAlignment).RegisterTitle(CardsAlignment.Far, My.Resources.CardsAlignmentFar)
            EnumTitlesKeeper(Of FixedStyle).RegisterTitle(FixedStyle.None, My.Resources.NotFixed)
            EnumTitlesKeeper(Of FixedStyle).RegisterTitle(FixedStyle.Left, My.Resources.FixedLeft)
            EnumTitlesKeeper(Of FixedStyle).RegisterTitle(FixedStyle.Right, My.Resources.FixedRight)
            EnumTitlesKeeper(Of GridEditingMode).RegisterTitle(GridEditingMode.EditFormInplace, "Edit Form Inplace")
            EnumTitlesKeeper(Of GridEditingMode).RegisterTitle(GridEditingMode.EditFormInplaceHideCurrentRow, "Edit Form Inplace Hide Current Row")
            EnumTitlesKeeper(Of GridEditingMode).RegisterTitle(GridEditingMode.EditForm, "Edit Form")
            EnumTitlesKeeper(Of EditFormModifiedAction).RegisterTitle(EditFormModifiedAction.Default, "Default")
            EnumTitlesKeeper(Of EditFormModifiedAction).RegisterTitle(EditFormModifiedAction.Cancel, "Cancel")
            EnumTitlesKeeper(Of EditFormModifiedAction).RegisterTitle(EditFormModifiedAction.Nothing, "Nothing")
            EnumTitlesKeeper(Of EditFormModifiedAction).RegisterTitle(EditFormModifiedAction.Save, "Save")
            EnumTitlesKeeper(Of EditFormBindingMode).RegisterTitle(EditFormBindingMode.Default, "Default")
            EnumTitlesKeeper(Of EditFormBindingMode).RegisterTitle(EditFormBindingMode.Cached, "Cached")
            EnumTitlesKeeper(Of EditFormBindingMode).RegisterTitle(EditFormBindingMode.Direct, "Direct")
        End Sub

    End Class
End Namespace
