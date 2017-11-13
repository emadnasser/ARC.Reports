using System;
using System.Collections.Generic;
using System.Linq;

namespace DevExpress.XtraLayout.Demos.Modules {
    public class MultilanguageFormLoader : MarshalByRefObject {
        private DevExpress.XtraLayout.Demos.MultilanguageForm form;
        private System.Globalization.CultureInfo oldCulture;

        private void SetDpiMode(int selectDpiMode) {
            float scale = 0f;
            form.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            switch (selectDpiMode) {
                case 0:
                    scale = 0.75f;
                    break;
                case 1:
                    scale = 1f;
                    break;
                case 2:
                    scale = 1.25f;
                    break;
                case 3:
                    scale = 1.5f;
                    break;
            }
            form.ChangedSize(scale);
        }
        private void SetLayoutMode(int selectLayoutMode) {
            switch (selectLayoutMode) {
                case 0:
                    form.SetLayout(DevExpress.XtraLayout.Utils.LayoutMode.Flow);
                    break;
                case 1:
                    form.SetLayout(DevExpress.XtraLayout.Utils.LayoutMode.Regular);
                    break;
            }
        }
        private string SetLocalization(int selectLocalizationMode) {
            string localization = string.Empty;
            switch (selectLocalizationMode) {
                case 0:
                    localization = "en";
                    break;
                case 1:
                    localization = "de-DE";
                    break;
            }
            return localization;
        }
        private void SetSizeMode(int selectSizeMode) {
            switch(selectSizeMode) {
                case 0:
                    form.ShowAnimation();
                    break;
                case 1:
                    form.Size = form.Landscape;
                    break;
                case 2:
                    form.Size = form.Portrait;
                    break;
            }
        }

        protected void RestoreCulture() {
            System.Threading.Thread.CurrentThread.CurrentUICulture = oldCulture;
        }
        protected void SaveCulture() {
            oldCulture = System.Threading.Thread.CurrentThread.CurrentUICulture;
        }

        public void Load(int selectLocalizationMode, int selectLayoutMode, int selectSizeMode, int selectDpiMode) {
            string localization = SetLocalization(selectLocalizationMode);
            SaveCulture();
            System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo(localization);
            form = new DevExpress.XtraLayout.Demos.MultilanguageForm();
            SetLayoutMode(selectLayoutMode);
            SetDpiMode(selectDpiMode); 
            SetSizeMode(selectSizeMode);
            form.ShowDialog();
            RestoreCulture();
        }
    }
}
