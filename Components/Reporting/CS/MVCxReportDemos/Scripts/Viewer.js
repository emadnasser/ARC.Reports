window.addEventListener("beforeunload", function() {
    var viewer = window['webDocumentViewer'];
    var preview = viewer && viewer.previewModel && viewer.previewModel.reportPreview;
    if(preview)
      setTimeout(function() {
          preview.deactivate();
      }, 1);
})