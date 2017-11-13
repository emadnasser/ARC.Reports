(function(reportDesigner) {
    reportDesigner.ExitDesigner.AddHandler(function(_) {
        window.location.replace($("#redirectValue").val());
    });
    window.addEventListener("beforeunload", function(e) {
        var designerModel = reportDesigner.GetDesignerModel();
        var viewer = designerModel.reportPreviewModel &&
        designerModel.reportPreviewModel.reportPreview &&
        designerModel.reportPreviewModel.reportPreview;
        setTimeout(function() {
            viewer && viewer.deactivate();
        }, 1)
    });
})(reportDesigner);
