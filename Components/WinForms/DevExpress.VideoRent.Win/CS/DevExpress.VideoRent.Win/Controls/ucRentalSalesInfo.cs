using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.Xpo;
using DevExpress.Xpo.DB;
using DevExpress.Utils.Menu;
using DevExpress.Data.Filtering;
using DevExpress.VideoRent.Resources;

namespace DevExpress.VideoRent.Win.Controls {
    public partial class ucRentalSalesInfo : XtraUserControl {
        MovieCategoryPrice categoryPrice;
        MovieItem.CountInfo countInfo;
        MovieItemFormat? format;
        public ucRentalSalesInfo()
            : base() {
            InitializeComponent();
            ElementConstStringLoader.LoadConstStringsForUCRentalSalesInfo(this);
        }
        public ucRentalSalesInfo(MovieCategoryPrice categoryPrice, MovieItem.CountInfo countInfo, MovieItemFormat? format, IDXMenuManager manager)
            : this() {
            Init(categoryPrice, countInfo, format, manager);
        }
        public void Init(MovieCategoryPrice categoryPrice, MovieItem.CountInfo countInfo, MovieItemFormat? format, IDXMenuManager manager) {
            this.categoryPrice = categoryPrice;
            this.countInfo = countInfo;
            this.format = format;
            lcMain.MenuManager = manager;
            foreach(Control item in lcMain.Controls)
                AddControl(item);
            InitData();
        }
        void AddControl(Control item) {
            BaseEdit edit = item as BaseEdit;
            if(edit != null) 
                edit.MenuManager = lcMain.MenuManager;
        }
        void InitData() {
            if(categoryPrice == null) {
                lciDefaultPrice.Visibility = XtraLayout.Utils.LayoutVisibility.Never;
                lciDefaultDays.Visibility = XtraLayout.Utils.LayoutVisibility.Never;
            } else {
                teDefaultPrice.Text = categoryPrice.DefaultPrice.ToString();
                teDefaultDays.Text = categoryPrice.DefaultRentDays.ToString();
            }
            if(format == null)
                lbItemsCount.Text = string.Format(ConstStrings.Get("ItemsCountCaptionHtml"), countInfo.Total);
            else {
                int formatIndex = countInfo.FormatIndex(format.Value);
                lbItemsCount.Text = string.Format(ConstStrings.Get("ItemsCountCaptionHtml"), countInfo.WithFormat[formatIndex]);
            }
            lbItemsInfo.Text = GetCountInfoCaption(format, countInfo);
        }
        static string GetCountInfoCaption(MovieItemFormat? format, MovieItem.CountInfo countInfo) {
            int formatIndex = format == null ? -1 : countInfo.FormatIndex(format.Value);
            string ret = string.Format(ConstStrings.Get("ItemsCountDetailCaptionHtml"),
                format == null ? countInfo.WithStatus[countInfo.StatusIndex(MovieItemStatus.Rented)] : countInfo.WithFormatAndStatus[formatIndex, countInfo.StatusIndex(MovieItemStatus.Rented)],
                format == null ? countInfo.WithStatus[countInfo.StatusIndex(MovieItemStatus.Active)] : countInfo.WithFormatAndStatus[formatIndex, countInfo.StatusIndex(MovieItemStatus.Active)],
                format == null ? countInfo.ForSell : countInfo.WithFormatForSell[formatIndex],
                format == null ? countInfo.WithStatus[countInfo.StatusIndex(MovieItemStatus.Lost)] : countInfo.WithFormatAndStatus[formatIndex, countInfo.StatusIndex(MovieItemStatus.Lost)], 
                format == null ? countInfo.WithStatus[countInfo.StatusIndex(MovieItemStatus.Damaged)] : countInfo.WithFormatAndStatus[formatIndex, countInfo.StatusIndex(MovieItemStatus.Damaged)], 
                format == null ? countInfo.WithStatus[countInfo.StatusIndex(MovieItemStatus.Sold)] : countInfo.WithFormatAndStatus[formatIndex, countInfo.StatusIndex(MovieItemStatus.Sold)]);
            return ret;
        }
    }
}