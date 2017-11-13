using System;
using System.Drawing;
using System.Web.UI;
using DevExpress.Web;

public partial class ASPxColorEdit_Example : Page {

    public enum Palette {
        Default = 0,
        Gray,
        Red,
        Green,
        Blue = 4
    };

    protected static int CountHues = 40;

    protected void Page_Load(object sender, EventArgs e) {
        bool enableCustomColors = ASPxCheckBoxEnableCustomColors.Checked;
        int columns = (int)ASPxSpinEditColumns.Number;

        ColorEditHeaderBackColor.ColumnCount = columns;
        ColorEditBackColor.ColumnCount = columns;
        ColorEditBorderColor.ColumnCount = columns;
        ColorEditForeColor.ColumnCount = columns;

        ColorEditHeaderBackColor.EnableCustomColors = enableCustomColors;
        ColorEditBackColor.EnableCustomColors = enableCustomColors;
        ColorEditBorderColor.EnableCustomColors = enableCustomColors;
        ColorEditForeColor.EnableCustomColors = enableCustomColors;

        ColorEditItemCollection pallete = new ColorEditItemCollection();
        if(ASPxComboBoxPalettes.SelectedIndex == (int)Palette.Default)
            pallete.CreateDefaultItems(true);
        else
            pallete.Assign(CreatePalette(CountHues, (Palette)ASPxComboBoxPalettes.SelectedIndex));
       
        ColorEditHeaderBackColor.Items.Assign(pallete);
        ColorEditBackColor.Items.Assign(pallete);
        ColorEditBorderColor.Items.Assign(pallete);
        ColorEditForeColor.Items.Assign(pallete);

        ApplyColorOnRoundPanel();
    }

    protected void OnCallBack(object sender, EventArgs e) {
        ApplyColorOnRoundPanel();
    }

    protected void ApplyColorOnRoundPanel() {
        RoundPanel.HeaderStyle.BackColor = ColorEditHeaderBackColor.Color;
        RoundPanel.BackColor = ColorEditBackColor.Color;
        RoundPanel.Border.BorderColor = ColorEditBorderColor.Color;
        RoundPanel.ForeColor = ColorEditForeColor.Color;
    }

    protected ColorEditItemCollection CreatePalette(int countColors, Palette palette) {
        ColorEditItemCollection colorEditItemCollection = new ColorEditItemCollection();
        int step = 256 / countColors;
    
        for(int i = 0; i < countColors; i++)
            colorEditItemCollection.Add(GetHue(palette, i * step));

        return colorEditItemCollection;
    }

    protected Color GetHue(Palette palette, int value) {
        Color color = Color.Empty;
        switch(palette) {
            case Palette.Red:
                color = Color.FromArgb(value, 0, 0);
                break;
            case Palette.Green:
                color = Color.FromArgb(0, value, 0);
                break;
            case Palette.Blue:
                color = Color.FromArgb(0, 0, value);
                break;
            case Palette.Gray:
                color = Color.FromArgb(value, value, value);
                break;
        }
        return color;
    }
}
