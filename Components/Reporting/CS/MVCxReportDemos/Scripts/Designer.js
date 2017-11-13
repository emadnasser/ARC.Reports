(function(reportDesigner) {
    var suppressCloseConfirmation = false;
    $(window).on('beforeunload', function(e) {
        var designerModel = reportDesigner.GetDesignerModel();
        var viewer = designerModel.reportPreviewModel &&
        designerModel.reportPreviewModel.reportPreview;
        setTimeout(function() {
            viewer && viewer.deactivate();
        }, 1);
        if(!suppressCloseConfirmation && reportDesigner.GetDesignerModel().isDirty()) {
            return 'You have unsaved changes on the page';
        }
    });
    reportDesigner.ExitDesigner.AddHandler(function(_) {
        window.location.replace($("#redirectValue").val());
    });
})(reportDesigner);
