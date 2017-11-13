window.addEventListener("beforeunload", function(e) {
    var viewer = window['webDocumentViewer'];
    var preview = viewer &&
        viewer.previewModel &&
        viewer.previewModel.reportPreview;
    if(preview)
        setTimeout(function() {
            preview.deactivate();
        }, 1)
});