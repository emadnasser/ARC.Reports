using System;
using System.Collections.Generic;
using System.Drawing;
using System.Reflection;
using DevExpress.XtraBars.Docking2010;
using DevExpress.XtraEditors;
using DevExpress.DXperience.Demos;


namespace DevExpress.ApplicationUI.Demos {
    public partial class CustomHeaderButtons : TutorialControlBase {
        Dictionary<string, BaseButtonProperties> templatesButtonCore;
        public CustomHeaderButtons() {
            InitializeComponent();
            InitButtons();
            rgTemplatesButton.SelectedIndex = 0;
        }
        Dictionary<string, BaseButtonProperties> TemplatesButton {
            get {
                if(templatesButtonCore == null)
                    templatesButtonCore = new Dictionary<string, BaseButtonProperties>();
                return templatesButtonCore; 
            }
        }
        void InitButtons() {
            BaseButtonProperties customSimpleButton = new CustomPushButtonProperties();
            TemplatesButton.Add("PushButton", customSimpleButton);
            BaseButtonProperties customToggleButton = new CustomCheckButtonProperties();
            TemplatesButton.Add("CheckButton", customToggleButton);
            BaseButtonProperties customButtonWithImage = new CustomButtonWithImageProperties(imageList1.Images[5]);
            TemplatesButton.Add("ButtonWithImage", customButtonWithImage);
            BaseButtonProperties customButtonWithGlyphs = new CustomButtonWithGlyphsProperties(imageList1);
            TemplatesButton.Add("ButtonWithGlyphs", customButtonWithGlyphs);
            RadioGroup group = rgTemplatesButton;
            buttonPropertyGrid.SelectObject = actionDockPanel.Button;
        }
        void TemplatesButtonSelectedIndexChanged(object sender, EventArgs e) {
            RadioGroup group = sender as RadioGroup;
            if(group == null) return;
            BaseButtonProperties buttonProperties;
            if(TemplatesButton.TryGetValue(group.Properties.Items[group.SelectedIndex].Value.ToString(), out buttonProperties)) {
                buttonProperties.AssingProterties(actionDockPanel.Button);
                buttonPropertyGrid.RefreshPropertyGrid();
            }
        }

        class BaseButtonProperties {
            public BaseButtonProperties() {
                Caption = string.Empty;
                Image = null;
                Glyphs = null;
                Style = ButtonStyle.PushButton;
                UseCaption = true;
            }
            public string Caption { get; set; }
            public Image Image { get; set; }
            public object Glyphs { get; set; }
            public ButtonStyle Style { get; set; }
            public bool UseCaption { get; set; }
            public void AssingProterties(IButton button) {
                button.Properties.Caption = Caption;
                button.Properties.Image = Image;
                button.Properties.Glyphs = Glyphs;
                button.Properties.Style = Style;
                button.Properties.UseCaption = UseCaption;
            }
        }
        class CustomPushButtonProperties : BaseButtonProperties {
            public CustomPushButtonProperties()
                : base() {
                Caption = "Push button";
            }
        }
        class CustomCheckButtonProperties : BaseButtonProperties {
            public CustomCheckButtonProperties()
                : base() {
                Caption = "Check Button";
                Style = ButtonStyle.CheckButton;
            }
        }
        class CustomButtonWithImageProperties : BaseButtonProperties {
            public CustomButtonWithImageProperties(Image image)
                : base() {
                Caption = "Image";
                Image = image;
            }
        }
        class CustomButtonWithGlyphsProperties : BaseButtonProperties {
            public CustomButtonWithGlyphsProperties(object glyphs)
                : base() {
                Caption = "Glyphs";
                Style = ButtonStyle.CheckButton;
                Glyphs = glyphs;
                UseCaption = false;
            }
        }
    }
}
