﻿using System;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Drawing;
using System.Drawing.Design;
using System.Windows.Forms;
using Common.Win;
using Common.Win.ColumnView;
using Common.Win.ColumnView.Design;
using Common.Win.ColumnView.Model;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Editors;
using DevExpress.ExpressApp.Model;
using DevExpress.ExpressApp.Win.Editors;
using DevExpress.Utils;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using ListView = DevExpress.ExpressApp.ListView;

[assembly: OnlineRepoLocation("http://goo.gl/vpjlu")]

namespace Common.Win.General.ToolTip {
    [ModelAbstractClass]
    public interface IModelColumnTooltipData : IModelColumn {
        IModelTooltipData TooltipData { get; }
    }
    public interface IModelTooltipData : IModelToolTipController {
        [Category("DataOnToolTip")]
        bool DataOnToolTip { get; set; }
        [Category("DataOnToolTip")]
        int MaxHeight { get; set; }
        [Category("DataOnToolTip")]
        int MaxWidth { get; set; }
        [Editor(typeof(MultilineStringEditor), typeof(UITypeEditor))]
        string ToolTipText { get; set; }

    }

    public class GridViewImageTextToolTipController : ViewController<ListView>, IModelExtender {
        ToolTipController _toolTipController;
        GridHitInfo _hotTrackInfo;

        protected override void OnViewControlsCreated() {
            base.OnViewControlsCreated();
            if (GridView == null) return;
            _toolTipController = new ToolTipController { ToolTipType = ToolTipType.SuperTip };
            _toolTipController.ReshowDelay = _toolTipController.InitialDelay;
            _toolTipController.AutoPopDelay = 10000;
            _toolTipController.AllowHtmlText = true;

            GridView.GridControl.MouseMove += GridControl_MouseMove;
            GridView.TopRowChanged += GridViewTopRowChanged;
            GridView.ShownEditor += HideHint;
            GridView.GridControl.MouseDown += HideHint;
            GridView.GridControl.MouseLeave += HideHint;
        }

        void HideHint(object sender, EventArgs eventArgs) {
            _toolTipController.HideHint();
        }

        protected virtual DevExpress.XtraGrid.Views.Grid.GridView GridView {
            get {
                if (View != null) {
                    var columnViewEditor = View.Editor as WinColumnsListEditor;
                    if (columnViewEditor != null) return columnViewEditor.ColumnView as DevExpress.XtraGrid.Views.Grid.GridView;
                }
                return null;
            }
        }

        public GridHitInfo HotTrackInfo {
            get { return _hotTrackInfo; }
            set {
                if (!value.InRowCell) {
                    _toolTipController.HideHint();
                    _hotTrackInfo = null;
                    return;
                }
                if (_hotTrackInfo != null && _hotTrackInfo.Column == value.Column && _hotTrackInfo.RowHandle == value.RowHandle)
                    return;
                _hotTrackInfo = value;

                var modelColumn = _hotTrackInfo.Column.GetModel();
                if (TooltipEnabled(modelColumn)) {
                    if (!HotTrackInfo.InRowCell || IsEditing) {
                        _toolTipController.HideHint();
                    } else
                        ShowToolTip((IModelColumnTooltipData)modelColumn);
                }
            }
        }

        bool TooltipEnabled(IModelColumnOptionsColumnView modelColumnOptionsColumnView) {
            var columnTooltipData = (IModelColumnTooltipData)modelColumnOptionsColumnView;
            return columnTooltipData != null && (columnTooltipData.TooltipData.DataOnToolTip || !string.IsNullOrEmpty(columnTooltipData.TooltipData.ToolTipText) || columnTooltipData.TooltipData.ToolTipController != null);
        }

        bool IsEditing {
            get {
                return GridView.ActiveEditor != null &&
                       HotTrackInfo.Column == GridView.FocusedColumn &&
                       HotTrackInfo.RowHandle == GridView.FocusedRowHandle;
            }
        }

        protected override void OnDeactivated() {
            base.OnDeactivated();
            if (GridView != null) {
                GridView.TopRowChanged += GridViewTopRowChanged;
                GridView.ShownEditor += HideHint;
                GridControl gridControl = GridView.GridControl;
                if (gridControl != null) {
                    gridControl.MouseMove += GridControl_MouseMove;
                    gridControl.MouseDown += HideHint;
                    gridControl.MouseLeave += HideHint;
                }
            }
            if (_toolTipController != null)
                _toolTipController.Dispose();
        }

        void ShowToolTip(IModelColumnTooltipData modelColumnTooltipData) {
            var toolTipControlInfo = new ToolTipControlInfo();
            var item = new ToolTipItem { ImageToTextDistance = 0 };
            var modelTooltipData = modelColumnTooltipData.TooltipData;
            if (modelTooltipData.DataOnToolTip) {
                var modelMember = modelColumnTooltipData.ModelMember;
                if (modelMember.MemberInfo.MemberType == typeof(Image)) {
                    var image = modelMember.MemberInfo.GetValue(GridView.GetRow(HotTrackInfo.RowHandle)) as Image;
                    if (modelTooltipData.MaxWidth > 0 && modelTooltipData.MaxHeight > 0)
                        image = image.CreateImage(modelTooltipData.MaxWidth, modelTooltipData.MaxHeight);
                    item.Image = image;
                } else
                    item.Text = string.Format("{0}", GridView.GetRowCellValue(HotTrackInfo.RowHandle, HotTrackInfo.Column));
            } else if (!string.IsNullOrEmpty(modelTooltipData.ToolTipText)) {
                item.Text = modelTooltipData.ToolTipText;
            } else {
                var controller = ObjectToolTipController(modelColumnTooltipData);
                controller.ShowHint(GridView.GetRow(HotTrackInfo.RowHandle), HotTrackInfo.HitPoint, ObjectSpace, _toolTipController);
                return;
            }
            toolTipControlInfo.Object = HotTrackInfo;
            toolTipControlInfo.SuperTip = new SuperToolTip();
            toolTipControlInfo.SuperTip.Items.Add(item);
            toolTipControlInfo.ToolTipPosition = Cursor.Position;
            _toolTipController.ShowHint(toolTipControlInfo);
        }

        ObjectToolTipController ObjectToolTipController(IModelColumnTooltipData modelColumnTooltipData) {
            var objects = new[] { View.Editor.Control };
            return (ObjectToolTipController)Activator.CreateInstance(modelColumnTooltipData.TooltipData.ToolTipController, objects);
        }

        void GridControl_MouseMove(object sender, MouseEventArgs e) {
            if (GridView != null)
                HotTrackInfo = GridView.CalcHitInfo(e.X, e.Y);
        }

        void GridViewTopRowChanged(object sender, EventArgs e) {
            if (_toolTipController != null) _toolTipController.HideHint();
            HotTrackInfo = GridView.CalcHitInfo(GridView.GridControl.PointToClient(Cursor.Position));
        }
        #region Implementation of IModelExtender
        public void ExtendModelInterfaces(ModelInterfaceExtenders extenders) {
            extenders.Add<IModelColumn, IModelColumnTooltipData>();
        }
        #endregion
    }
}
