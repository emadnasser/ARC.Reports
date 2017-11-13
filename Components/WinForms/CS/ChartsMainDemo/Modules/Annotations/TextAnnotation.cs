using DevExpress.XtraEditors;
using System;
using System.Drawing;

namespace DevExpress.XtraCharts.Demos.Annotations {
    public partial class TextAnnotationDemo : AnnotationDemoBase {
        TextAnnotation minAnnotation;
        TextAnnotation maxAnnotation;

        public TextAnnotationDemo() {
            InitializeComponent();
        }
        void SetAnnotationLines(TextAnnotation annotation, MemoExEdit textEdit) {
            if(annotation != null) {
                string[] oldLines = annotation.Lines;
                try {
                    annotation.Lines = textEdit.Lines;
                }
                catch {
                    textEdit.Lines = oldLines;
                    XtraMessageBox.Show(LookAndFeel.ActiveLookAndFeel, "Font size should be greater than 0.", "Argument Exception");
                }
            }
        }
        void meeMaxText_TextChanged(object sender, System.EventArgs e) {
                SetAnnotationLines(maxAnnotation, meeMaxText);
        }
        void meeMinText_TextChanged(object sender, System.EventArgs e) {
                SetAnnotationLines(minAnnotation, meeMinText);
        }
        protected override void AddAnnotation(SeriesPoint point, bool isMaximum) {
            TextAnnotation annotation = point.Annotations.AddTextAnnotation();
            if (isMaximum) {
                annotation.Name = "Maximum";
                if (meeMaxText != null)
                    annotation.Lines = maxAnnotation.Lines;
                else
                    annotation.Text = "This is a <b><size=+3>maximum</size></b> point.";
                maxAnnotation = annotation;
            }
            else {
                annotation.Name = "Minimum";
                if (meeMinText != null)
                    annotation.Lines = minAnnotation.Lines;
                else
                    annotation.Text = "This is a <b><size=+3>minimum</size></b> point.";
                minAnnotation = annotation;
            }
        }
    }
}
