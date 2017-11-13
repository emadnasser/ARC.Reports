using System;
using System.Web.UI;

public partial class ASPxCaptcha_Features : Page {
    const int MaxCharacterSetLength = 50;
    const string CaptchaCssPostfixSessionKey = "6aad54c0-25ef-11df-8a39-0800200c9a66";

    protected void Page_Load(object sender, EventArgs e) {
        if (!IsPostBack) {
            Session[CaptchaCssPostfixSessionKey] = Captcha.CssPostfix;
            tbCharacterSet.Text = Captcha.CharacterSet;
            seCodeLength.Value = Captcha.CodeLength;
            cbFontFamily.Value = Captcha.ChallengeImage.FontFamily;
            InitializeAppearanceEditors();
        }
        if (Captcha.CssPostfix != (string)Session[CaptchaCssPostfixSessionKey]) {
            InitializeAppearanceEditors();
            Captcha.IsValid = true;
            Session[CaptchaCssPostfixSessionKey] = Captcha.CssPostfix;            
        }
    }

    protected void btnApply_Click(object sender, EventArgs e) {
        int parseResult = 0;
        if(tbCharacterSet.IsValid)
            Captcha.CharacterSet = tbCharacterSet.Text;
        if (int.TryParse(seCodeLength.Text, out parseResult))
            Captcha.CodeLength = parseResult;
        Captcha.ChallengeImage.FontFamily = cbFontFamily.Value.ToString();
        Captcha.ChallengeImage.ForegroundColor = ceForegroundColor.Color;
        Captcha.ChallengeImage.BackgroundColor = ceBackgroundColor.Color;
        Captcha.ChallengeImage.BorderColor = ceBorderColor.Color;
        if (int.TryParse(seBorderWidth.Text, out parseResult))
            Captcha.ChallengeImage.BorderWidth = parseResult;
        Captcha.ValidationSettings.SetFocusOnError = chbSetFocusOnError.Checked;
        Captcha.IsValid = true;
    }

    protected void InitializeAppearanceEditors() {
        ceForegroundColor.Color = Captcha.ChallengeImage.ForegroundColor;
        ceBackgroundColor.Color = Captcha.ChallengeImage.BackgroundColor;
        ceBorderColor.Color = Captcha.ChallengeImage.BorderColor;
        seBorderWidth.Value = Captcha.ChallengeImage.BorderWidth;
    }
}
