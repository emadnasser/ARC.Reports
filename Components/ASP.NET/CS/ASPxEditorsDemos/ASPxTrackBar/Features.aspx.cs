using System;
using System.Web.UI;
using System.Web.UI.WebControls;
using DevExpress.Web;

public partial class ASPxTrackBar_Features : Page {
    protected void Page_Load(object sender, EventArgs e) {
        trackBar.Orientation = orientationComboBox.SelectedIndex == 1 ? Orientation.Vertical : Orientation.Horizontal;
        trackBar.Direction = directionComboBox.SelectedIndex == 1 ? Direction.Reversed : Direction.Normal;
        trackBar.ScalePosition = (ScalePosition)Enum.Parse(typeof(ScalePosition), scalePositionComboBox.Text);
        trackBar.ValueToolTipPosition = (ValueToolTipPosition)Enum.Parse(typeof(ValueToolTipPosition), valueToolTipPositionComboBox.Text);
        trackBar.ScaleLabelHighlightMode = (ScaleLabelHighlightMode)Enum.Parse(typeof(ScaleLabelHighlightMode), highlightModeComboBox.Text);
        trackBar.ShowDragHandles = showDHCheckBox.Checked;
        trackBar.ShowChangeButtons = showButtonsCheckBox.Checked;
        trackBar.EqualTickMarks = equalizeTickCheckBox.Checked;
        if(trackBar.Orientation == Orientation.Vertical)
            trackBar.Height = 256;
        else
            trackBar.Width = 256;
    }
}
