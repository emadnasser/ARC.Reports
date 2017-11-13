using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.Utils.Animation;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors;

namespace DevExpress.XtraEditors.Demos {
    public partial class ModuleProgressPanel : TutorialControl {
        public ModuleProgressPanel() {
            InitializeComponent();
            TutorialInfo.WhatsThisCodeFile = "CS\\EditorsMainDemo\\Modules\\ModuleProgressPanel.cs";
            TutorialInfo.WhatsThisXMLFile = "DevExpress.XtraEditors.Demos.CodeInfo.progressPanel.xml";
        }

        protected override void UpdateTabControlPosition(XtraTab.XtraTabControl tabControl) { }
        protected override void CalcContentCore() {
            CalcLayoutControlBounds(layoutControl1);
        }
        // <comboBoxAnimationType>
        private void comboBoxAnimationType_SelectedIndexChanged(object sender, EventArgs e) {
            switch((string)comboBoxAnimationType.SelectedItem) {
                case ("Default"):
                    progressPanelSample.WaitAnimationType = WaitingAnimatorType.Default;
                    break;
                case ("Line"):
                    progressPanelSample.WaitAnimationType = WaitingAnimatorType.Line;
                    break;
                case ("Ring"):
                    progressPanelSample.WaitAnimationType = WaitingAnimatorType.Ring;
                    break;
            }
            // <skip>
            spinElementCount.Enabled = (progressPanelSample.WaitAnimationType != WaitingAnimatorType.Default);
            spinAcceleration.Enabled = (progressPanelSample.WaitAnimationType != WaitingAnimatorType.Default);
            spinSpeed.Enabled = (progressPanelSample.WaitAnimationType != WaitingAnimatorType.Default);
            colorEditElementColor.Enabled = (progressPanelSample.WaitAnimationType != WaitingAnimatorType.Default);
            spinLineHeight.Enabled = (progressPanelSample.WaitAnimationType == WaitingAnimatorType.Line);
            comboBoxLineElementType.Enabled = (progressPanelSample.WaitAnimationType == WaitingAnimatorType.Line);
            spinRingDiameter.Enabled = (progressPanelSample.WaitAnimationType == WaitingAnimatorType.Ring);
            // </skip>
        }
        // </comboBoxAnimationType>

        // <spinElementCount>
        private void spinElementCount_EditValueChanged(object sender, EventArgs e) {
            progressPanelSample.AnimationElementCount = (int)spinElementCount.Value;
        }
        // </spinElementCount>

        // <spinAcceleration>
        private void spinAcceleration_EditValueChanged(object sender, EventArgs e) {
            progressPanelSample.AnimationAcceleration = (float)spinAcceleration.Value;
        }
        // </spinAcceleration>

        // <spinSpeed>
        private void spinSpeed_EditValueChanged(object sender, EventArgs e) {
            progressPanelSample.AnimationSpeed = (float)spinSpeed.Value;
        }
        // </spinSpeed>

        // <spinLineHeight>
        private void spinLineHeight_EditValueChanged(object sender, EventArgs e) {
            progressPanelSample.LineAnimationElementHeight = (int)spinLineHeight.Value;
        }
        // </spinLineHeight>

        // <comboBoxLineElementType>
        private void comboBoxLineElementType_SelectedIndexChanged(object sender, EventArgs e) {
            switch((string)comboBoxLineElementType.SelectedItem) {
                case ("Circle"):
                    progressPanelSample.LineAnimationElementType = LineAnimationElementType.Circle;
                    break;
                case ("Rectangle"):
                    progressPanelSample.LineAnimationElementType = LineAnimationElementType.Rectangle;
                    break;
                case ("Triangle"):
                    progressPanelSample.LineAnimationElementType = LineAnimationElementType.Triangle;
                    break;
            }
        }
        // </comboBoxLineElementType>

        // <spinRingDiameter>
        private void spinRingDiameter_EditValueChanged(object sender, EventArgs e) {
            progressPanelSample.RingAnimationDiameter = (int)spinRingDiameter.Value;
        }
        // </spinRingDiameter>

        // <colorEditElementColor>
        private void colorEditElementColor_EditValueChanged(object sender, EventArgs e) {
            progressPanelSample.Appearance.ForeColor = colorEditElementColor.Color;
        }
        // </colorEditElementColor>

        // <spinFrameCount>
        private void spinFrameCount_EditValueChanged(object sender, EventArgs e) {
            progressPanelSample.FrameCount = (int)spinFrameCount.Value;
        }
        // </spinFrameCount>

        // <spinFrameInterval>
        private void spinFrameInterval_EditValueChanged(object sender, EventArgs e) {
            progressPanelSample.FrameInterval = (int)spinFrameInterval.Value;
        }
        // </spinFrameInterval>
    }
}
