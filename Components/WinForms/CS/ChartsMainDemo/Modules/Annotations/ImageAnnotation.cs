namespace DevExpress.XtraCharts.Demos.Annotations {
    public partial class ImageAnnotationDemo : AnnotationDemoBase {
        public ImageAnnotationDemo() {
            InitializeComponent();
        }
        protected override void AddAnnotation(SeriesPoint point, bool isMaximum) {
            ImageAnnotation annotation = point.Annotations.AddImageAnnotation();
            if (isMaximum) {
                annotation.Name = "Maximum";
                annotation.Image.Image = global::DevExpress.XtraCharts.Demos.Properties.Resources.AnnotationMaximum;
            }
            else {
                annotation.Name = "Minimum";
                annotation.Image.Image = global::DevExpress.XtraCharts.Demos.Properties.Resources.AnnotationMinimum;
            }
        }
    }
}
