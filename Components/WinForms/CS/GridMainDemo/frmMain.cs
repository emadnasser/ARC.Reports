using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using DevExpress.Utils;
using DevExpress.DXperience.Demos;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Base;
using System.Drawing.Drawing2D;
using DevExpress.XtraGrid.Views.Layout;
using DevExpress.XtraGrid.Columns;
using DevExpress.Utils.About;

namespace DevExpress.XtraGrid.Demos {
	public class frmMain : DevExpress.DXperience.Demos.RibbonMainForm {
        bool showOutdated = false;
        public frmMain(string[] arguments) : base(arguments) {
            GetStartedLink = AssemblyInfo.DXLinkGetStartedWinGrid;
            ToolTipController.DefaultController.ToolTipType = DevExpress.Utils.ToolTipType.SuperTip;
          //  navBarControl1.Parent.Width = 230;
        }
        protected override string ProductName { get { return "XtraGrid"; } }
        protected override string DemoName { get { return Properties.Resources.DemoName; } }
        protected override void ShowAbout() {
            GridControl.About();
        }
		protected override void SetFormParam() {
            this.Icon = DevExpress.Utils.ResourceImageHelper.CreateIconFromResources("DevExpress.XtraGrid.Demos.AppIcon.ico", typeof(frmMain).Assembly);
		}
        protected override RibbonMenuManager CreateRibbonMenuManager() {
            return new GridRibbonMenuManager(this);
        }
		protected override void ShowModule(string name, DevExpress.XtraEditors.GroupControl group, DevExpress.LookAndFeel.DefaultLookAndFeel lookAndFeel, DevExpress.Utils.Frames.ApplicationCaption caption) {
			DemosInfo.ShowModule(name, group, caption, RibbonMenuManager as GridRibbonMenuManager);
		}
        protected override string NotTranslatedModuleTypes {
            get {
                if(LocalizationHelper.IsJapanese)
                    return ";NWindNavigator;Styles;AlphaBlending;CustomDraw;";
                return base.NotTranslatedModuleTypes;
            }
        }
		protected override void FillNavBar() { 
			DemosInfo.FillAccordionControl(accordionControl1, DevExpress.XtraNavBar.NavBarGroupStyle.SmallIconsText, showOutdated);
        }
        protected override void RegisterEnumTitles() {
            base.RegisterEnumTitles();
            EnumTitlesKeeper<FindMode>.RegisterTitle(FindMode.Default, Properties.Resources.FindModeDefault);
            EnumTitlesKeeper<FindMode>.RegisterTitle(FindMode.Always, Properties.Resources.FindModeAlways);
            EnumTitlesKeeper<FindMode>.RegisterTitle(FindMode.FindClick, Properties.Resources.FindModeFindClick);
            EnumTitlesKeeper<WaitAnimationOptions>.RegisterTitle(WaitAnimationOptions.Default, Properties.Resources.WaitAnimationOptionsDefault);
            EnumTitlesKeeper<WaitAnimationOptions>.RegisterTitle(WaitAnimationOptions.Indicator, Properties.Resources.WaitAnimationOptionsIndicator);
            EnumTitlesKeeper<WaitAnimationOptions>.RegisterTitle(WaitAnimationOptions.Panel, Properties.Resources.WaitAnimationOptionsPanel);
            EnumTitlesKeeper<TextEditStyles>.RegisterTitle(TextEditStyles.Standard, Properties.Resources.TextEditStylesStandard);
            EnumTitlesKeeper<TextEditStyles>.RegisterTitle(TextEditStyles.DisableTextEditor, Properties.Resources.TextEditStylesDisableTextEditor);
            EnumTitlesKeeper<TextEditStyles>.RegisterTitle(TextEditStyles.HideTextEditor, Properties.Resources.TextEditStylesHideTextEditor);
            EnumTitlesKeeper<PopupFilterMode>.RegisterTitle(PopupFilterMode.Default, Properties.Resources.PopupFilterModeDefault);
            EnumTitlesKeeper<PopupFilterMode>.RegisterTitle(PopupFilterMode.Contains, Properties.Resources.PopupFilterModeContains);
            EnumTitlesKeeper<PopupFilterMode>.RegisterTitle(PopupFilterMode.StartsWith, Properties.Resources.PopupFilterModeStartsWith);
            EnumTitlesKeeper<GroupFooterShowMode>.RegisterTitle(GroupFooterShowMode.VisibleAlways, Properties.Resources.GroupFooterShowModeVisibleAlways);
            EnumTitlesKeeper<GroupFooterShowMode>.RegisterTitle(GroupFooterShowMode.VisibleIfExpanded, Properties.Resources.GroupFooterShowModeVisibleIfExpanded);
            EnumTitlesKeeper<GroupFooterShowMode>.RegisterTitle(GroupFooterShowMode.Hidden, Properties.Resources.GroupFooterShowModeHidden);
            EnumTitlesKeeper<GridMultiSelectMode>.RegisterTitle(GridMultiSelectMode.CellSelect, Properties.Resources.CellSelect);
            EnumTitlesKeeper<GridMultiSelectMode>.RegisterTitle(GridMultiSelectMode.RowSelect, Properties.Resources.RowSelect);
            EnumTitlesKeeper<GridMultiSelectMode>.RegisterTitle(GridMultiSelectMode.CheckBoxRowSelect, "Check Box Row Select");
            EnumTitlesKeeper<GridAnimationType>.RegisterTitle(GridAnimationType.Default, Properties.Resources.GridAnimationTypeDefault);
            EnumTitlesKeeper<GridAnimationType>.RegisterTitle(GridAnimationType.AnimateAllContent, Properties.Resources.GridAnimationTypeAnimateAllContent);
            EnumTitlesKeeper<GridAnimationType>.RegisterTitle(GridAnimationType.AnimateFocusedItem, Properties.Resources.GridAnimationTypeAnimateFocusedItem);
            EnumTitlesKeeper<GridAnimationType>.RegisterTitle(GridAnimationType.NeverAnimate, Properties.Resources.GridAnimationTypeNeverAnimate);
            EnumTitlesKeeper<DevExpress.XtraGrid.Demos.AdvancedGridEditing.MasterTablePosition>.RegisterTitle(DevExpress.XtraGrid.Demos.AdvancedGridEditing.MasterTablePosition.Bottom, Properties.Resources.MasterTablePositionBottom);
            EnumTitlesKeeper<DevExpress.XtraGrid.Demos.AdvancedGridEditing.MasterTablePosition>.RegisterTitle(DevExpress.XtraGrid.Demos.AdvancedGridEditing.MasterTablePosition.Left, Properties.Resources.MasterTablePositionLeft);
            EnumTitlesKeeper<DevExpress.XtraGrid.Demos.AdvancedGridEditing.MasterTablePosition>.RegisterTitle(DevExpress.XtraGrid.Demos.AdvancedGridEditing.MasterTablePosition.Right, Properties.Resources.MasterTablePositionRight);
            EnumTitlesKeeper<DevExpress.XtraGrid.Demos.AdvancedGridEditing.MasterTablePosition>.RegisterTitle(DevExpress.XtraGrid.Demos.AdvancedGridEditing.MasterTablePosition.Top, Properties.Resources.MasterTablePositionTop);
            EnumTitlesKeeper<InterpolationMode>.RegisterTitle(InterpolationMode.Default, Properties.Resources.InterpolationModeDefault);
            EnumTitlesKeeper<InterpolationMode>.RegisterTitle(InterpolationMode.Low, Properties.Resources.InterpolationModeLow);
            EnumTitlesKeeper<InterpolationMode>.RegisterTitle(InterpolationMode.High, Properties.Resources.InterpolationModeHigh);
            EnumTitlesKeeper<InterpolationMode>.RegisterTitle(InterpolationMode.Bicubic, Properties.Resources.InterpolationModeBicubic);
            EnumTitlesKeeper<InterpolationMode>.RegisterTitle(InterpolationMode.Bilinear, Properties.Resources.InterpolationModeBilinear);
            EnumTitlesKeeper<InterpolationMode>.RegisterTitle(InterpolationMode.NearestNeighbor, Properties.Resources.InterpolationModeNearestNeighbor);
            EnumTitlesKeeper<InterpolationMode>.RegisterTitle(InterpolationMode.HighQualityBicubic, Properties.Resources.InterpolationModeHighQualityBicubic);
            EnumTitlesKeeper<InterpolationMode>.RegisterTitle(InterpolationMode.HighQualityBilinear, Properties.Resources.InterpolationModeHighQualityBilinear);
            EnumTitlesKeeper<FormatCondition>.RegisterTitle(FormatCondition.Between, Properties.Resources.FormatConditionEnumBetween);
            EnumTitlesKeeper<FormatCondition>.RegisterTitle(FormatCondition.Equal, Properties.Resources.FormatConditionEnumEqual);
            EnumTitlesKeeper<FormatCondition>.RegisterTitle(FormatCondition.Greater, Properties.Resources.FormatConditionEnumGreater);
            EnumTitlesKeeper<FormatCondition>.RegisterTitle(FormatCondition.GreaterOrEqual, Properties.Resources.FormatConditionEnumGreaterOrEqual);
            EnumTitlesKeeper<FormatCondition>.RegisterTitle(FormatCondition.Less, Properties.Resources.FormatConditionEnumLess);
            EnumTitlesKeeper<FormatCondition>.RegisterTitle(FormatCondition.LessOrEqual, Properties.Resources.FormatConditionEnumLessOrEqual);
            EnumTitlesKeeper<FormatCondition>.RegisterTitle(FormatCondition.None, Properties.Resources.FormatConditionEnumNone);
            EnumTitlesKeeper<FormatCondition>.RegisterTitle(FormatCondition.NotBetween, Properties.Resources.FormatConditionEnumNotBetween);
            EnumTitlesKeeper<FormatCondition>.RegisterTitle(FormatCondition.NotEqual, Properties.Resources.FormatConditionEnumNotEqual);
            EnumTitlesKeeper<GroupDrawMode>.RegisterTitle(GroupDrawMode.Default, Properties.Resources.GroupDrawModeDefault);
            EnumTitlesKeeper<GroupDrawMode>.RegisterTitle(GroupDrawMode.Office2003, Properties.Resources.GroupDrawModeOffice2003);
            EnumTitlesKeeper<GroupDrawMode>.RegisterTitle(GroupDrawMode.Standard, Properties.Resources.GroupDrawModeStandard);
            EnumTitlesKeeper<DefaultBoolean>.RegisterTitle(DefaultBoolean.Default, Properties.Resources.DefaultBooleanDefault);
            EnumTitlesKeeper<DefaultBoolean>.RegisterTitle(DefaultBoolean.False, Properties.Resources.DefaultBooleanFalse);
            EnumTitlesKeeper<DefaultBoolean>.RegisterTitle(DefaultBoolean.True, Properties.Resources.DefaultBooleanTrue);
            ResourcesKeeper.RegisterTitle("AllowCellMerge", Properties.Resources.AllowCellMerge);
            ResourcesKeeper.RegisterTitle("AllowHtmlDrawGroups", Properties.Resources.AllowHtmlDrawGroups);
            ResourcesKeeper.RegisterTitle("AllowHtmlDrawHeaders", Properties.Resources.AllowHtmlDrawHeaders);
            ResourcesKeeper.RegisterTitle("AutoCalcPreviewLineCount", Properties.Resources.AutoCalcPreviewLineCount);
            ResourcesKeeper.RegisterTitle("ColumnAutoWidth", Properties.Resources.ColumnAutoWidth);
            ResourcesKeeper.RegisterTitle("EnableAppearanceEvenRow", Properties.Resources.EnableAppearanceEvenRow);
            ResourcesKeeper.RegisterTitle("EnableAppearanceOddRow", Properties.Resources.EnableAppearanceOddRow);
            ResourcesKeeper.RegisterTitle("RowAutoHeight", Properties.Resources.RowAutoHeight);
            ResourcesKeeper.RegisterTitle("ShowAutoFilterRow", Properties.Resources.ShowAutoFilterRow);
            ResourcesKeeper.RegisterTitle("ShowChildrenInGroupPanel", Properties.Resources.ShowChildrenInGroupPanel);
            ResourcesKeeper.RegisterTitle("ShowColumnHeaders", Properties.Resources.ShowColumnHeaders);
            ResourcesKeeper.RegisterTitle("ShowDetailButtons", Properties.Resources.ShowDetailButtons);
            ResourcesKeeper.RegisterTitle("ShowFooter", Properties.Resources.ShowFooter);
            ResourcesKeeper.RegisterTitle("ShowGroupedColumns", Properties.Resources.ShowGroupedColumns);
            ResourcesKeeper.RegisterTitle("ShowGroupExpandCollapseButtons", Properties.Resources.ShowGroupExpandCollapseButtons);
            ResourcesKeeper.RegisterTitle("ShowGroupPanel", Properties.Resources.ShowGroupPanel);
            ResourcesKeeper.RegisterTitle("ShowIndicator", Properties.Resources.ShowIndicator);
            ResourcesKeeper.RegisterTitle("ShowPreview", Properties.Resources.ShowPreview);
            ResourcesKeeper.RegisterTitle("ShowViewCaption", Properties.Resources.ShowViewCaption);
            ResourcesKeeper.RegisterTitle("ShowBands", Properties.Resources.ShowBands);
            ResourcesKeeper.RegisterTitle("ShowCardCaption", Properties.Resources.ShowCardCaption);
            ResourcesKeeper.RegisterTitle("ShowCardExpandButton", Properties.Resources.ShowCardExpandButton);
            ResourcesKeeper.RegisterTitle("ShowEmptyFields", Properties.Resources.ShowEmptyFields);
            ResourcesKeeper.RegisterTitle("ShowFieldCaptions", Properties.Resources.ShowFieldCaptions);
            ResourcesKeeper.RegisterTitle("ShowFieldHints", Properties.Resources.ShowFieldHints);
            ResourcesKeeper.RegisterTitle("ShowHorzScrollBar", Properties.Resources.ShowHorzScrollBar);
            ResourcesKeeper.RegisterTitle("ShowLines", Properties.Resources.ShowLines);
            ResourcesKeeper.RegisterTitle("ShowQuickCustomizeButton", Properties.Resources.ShowQuickCustomizeButton);
            ResourcesKeeper.RegisterTitle("EnableAppearanceFocusedCell", Properties.Resources.EnableAppearanceFocusedCell);
            ResourcesKeeper.RegisterTitle("EnableAppearanceFocusedRow", Properties.Resources.EnableAppearanceFocusedRow);
            ResourcesKeeper.RegisterTitle("EnableAppearanceHideSelection", Properties.Resources.EnableAppearanceHideSelection);
            ResourcesKeeper.RegisterTitle("InvertSelection", Properties.Resources.InvertSelection);
            ResourcesKeeper.RegisterTitle("MultiSelect", Properties.Resources.MultiSelect);
            ResourcesKeeper.RegisterTitle("AllowGlyphSkinning", "Allow Glyph Skinning");
            ResourcesKeeper.RegisterTitle("ShowGroupPanelColumnsAsSingleRow", "Show Group Panel Columns As Single Row");
            ResourcesKeeper.RegisterTitle("ResetSelectionClickOutsideCheckboxSelector", "Reset Selection Click Outside Checkbox Selector");
            ResourcesKeeper.RegisterTitle("UseIndicatorForSelection", Properties.Resources.UseIndicatorForSelection);
            EnumTitlesKeeper<CardsAlignment>.RegisterTitle(CardsAlignment.Center, Properties.Resources.CardsAlignmentCenter);
            EnumTitlesKeeper<CardsAlignment>.RegisterTitle(CardsAlignment.Near, Properties.Resources.CardsAlignmentNear);
            EnumTitlesKeeper<CardsAlignment>.RegisterTitle(CardsAlignment.Far, Properties.Resources.CardsAlignmentFar);
            EnumTitlesKeeper<FixedStyle>.RegisterTitle(FixedStyle.None, Properties.Resources.NotFixed);
            EnumTitlesKeeper<FixedStyle>.RegisterTitle(FixedStyle.Left, Properties.Resources.FixedLeft);
            EnumTitlesKeeper<FixedStyle>.RegisterTitle(FixedStyle.Right, Properties.Resources.FixedRight);
            EnumTitlesKeeper<GridEditingMode>.RegisterTitle(GridEditingMode.EditFormInplace, "Edit Form Inplace");
            EnumTitlesKeeper<GridEditingMode>.RegisterTitle(GridEditingMode.EditFormInplaceHideCurrentRow, "Edit Form Inplace Hide Current Row");
            EnumTitlesKeeper<GridEditingMode>.RegisterTitle(GridEditingMode.EditForm, "Edit Form");
            EnumTitlesKeeper<EditFormModifiedAction>.RegisterTitle(EditFormModifiedAction.Default, "Default");
            EnumTitlesKeeper<EditFormModifiedAction>.RegisterTitle(EditFormModifiedAction.Cancel, "Cancel");
            EnumTitlesKeeper<EditFormModifiedAction>.RegisterTitle(EditFormModifiedAction.Nothing, "Nothing");
            EnumTitlesKeeper<EditFormModifiedAction>.RegisterTitle(EditFormModifiedAction.Save, "Save");
            EnumTitlesKeeper<EditFormBindingMode>.RegisterTitle(EditFormBindingMode.Default, "Default");
            EnumTitlesKeeper<EditFormBindingMode>.RegisterTitle(EditFormBindingMode.Cached, "Cached");
            EnumTitlesKeeper<EditFormBindingMode>.RegisterTitle(EditFormBindingMode.Direct, "Direct");
        }
        
	}
}
