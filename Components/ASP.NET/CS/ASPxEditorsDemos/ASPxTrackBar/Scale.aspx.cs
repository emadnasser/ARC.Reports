using System;
using System.Web.UI;
using DevExpress.Web;

public partial class ASPxTrackBar_Scale : Page {
    private struct TrackBarSettings {
        public decimal MinValue, MaxValue, LargeTickInterval, LargeTickStartValue, LargeTickEndValue, Step;
        public int SmallTickFrequency;
    }

    protected void Page_Load(object sender, EventArgs e) {
        UpdateTrackBarSettings();
    }

    protected void OnPredefinedSettingsComboBoxValueChanged(object sender, EventArgs e) {
        int defaultSettingIndex = (sender as ASPxComboBox).SelectedIndex;
        TrackBarSettings currentDefaultSettings = PredefinedSettings[defaultSettingIndex];
        minValueSpinEdit.Number = currentDefaultSettings.MinValue;
        maxValueSpinEdit.Number = currentDefaultSettings.MaxValue;
        largeTickIntervalSpinEdit.Number = currentDefaultSettings.LargeTickInterval;
        largeTickStartValueSpinEdit.Number = currentDefaultSettings.LargeTickStartValue;
        largeTickEndValueSpinEdit.Number = currentDefaultSettings.LargeTickEndValue;
        smallTickFrequencySpinEdit.Number = currentDefaultSettings.SmallTickFrequency;
        stepSpinEdit.Number = currentDefaultSettings.Step;
        UpdateTrackBarSettings();
    }

    protected void UpdateTrackBarSettings() {
        trackBar.MinValue = minValueSpinEdit.Number;
        trackBar.MaxValue = maxValueSpinEdit.Number;
        trackBar.LargeTickInterval = largeTickIntervalSpinEdit.Number;
        trackBar.LargeTickStartValue = largeTickStartValueSpinEdit.Number;
        trackBar.LargeTickEndValue = largeTickEndValueSpinEdit.Number;
        trackBar.SmallTickFrequency = (int)smallTickFrequencySpinEdit.Number;
        trackBar.Value = trackBar.MinValue;
        trackBar.Step = stepSpinEdit.Number;
    }

    private TrackBarSettings[] PredefinedSettings = new TrackBarSettings[] {
        new TrackBarSettings {
            MinValue = 0,
            MaxValue = 50,
            LargeTickInterval = 10,
            LargeTickStartValue = 0,
            LargeTickEndValue = 50,
            SmallTickFrequency = 5,
            Step = 1
        },
        new TrackBarSettings {
            MinValue = 0,
            MaxValue = 50,
            LargeTickInterval = 10,
            LargeTickStartValue = 5,
            LargeTickEndValue = 45,
            SmallTickFrequency = 5,
            Step = 1
        },
        new TrackBarSettings {
            MinValue = 0,
            MaxValue = 11,
            LargeTickInterval = 2,
            LargeTickStartValue = 0.5M,
            LargeTickEndValue = 10.5M,
            SmallTickFrequency = 1,
            Step = 0.5M
        },
        new TrackBarSettings {
            MinValue = -10,
            MaxValue = 30,
            LargeTickInterval = 10,
            LargeTickStartValue = 0,
            LargeTickEndValue = 30,
            SmallTickFrequency = 8,
            Step = 1
        }
    };
}
