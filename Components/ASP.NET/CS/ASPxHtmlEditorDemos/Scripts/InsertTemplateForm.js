function OnCustomDialogOpened() {
    RestoreInsertTemplateFormDialogState();
    templatesGrid.Focus();
}

function OnCustomDialogClosed(s, e) {
    if(e.name == "InsertTemplate" && (e.status == "ok" || e.status == "dbl")) {
        if(e.data) {
            if(e.data.overwrite)
                HtmlEditor.SetHtml(e.data.html, false)
            else
                HtmlEditor.ExecuteCommand(ASPxClientCommandConsts.PASTEHTML_COMMAND, e.data.html);
        }

        SaveInsertTemplateFormDialogState();
    }
}

function OnCustomDialogClosing(s, e) {
    if(e.name == "InsertTemplate" && e.status == "ok") {
        RetrieveTemplateHtml(e.status);
        e.handled = true;
    }
}

function OnGridRowDblClick(s, e) {
    RetrieveTemplateHtml("dbl");
}

function RetrieveTemplateHtml(status) {
    loadingPanel.ShowInElement(templatesGrid.GetMainElement().parentNode);

    templatesGrid.GetRowValues(
        templatesGrid.GetFocusedRowIndex(),
        "Html",
        function(html) {
            loadingPanel.Hide();

            ASPxClientHtmlEditor.CustomDialogComplete(
                status,
                {
                    "html": html,
                    "overwrite": overwriteCheckBox.GetChecked()
                }
            );
        }
    );
}

var insertTemplateFormDialogState = {};

function SaveInsertTemplateFormDialogState() {
    insertTemplateFormDialogState.focusedRow = templatesGrid.GetFocusedRowIndex();
    insertTemplateFormDialogState.overwrite = overwriteCheckBox.GetChecked();
}

function RestoreInsertTemplateFormDialogState() {
    if(insertTemplateFormDialogState.focusedRow)
        templatesGrid.SetFocusedRowIndex(insertTemplateFormDialogState.focusedRow);

    if(insertTemplateFormDialogState.overwrite != undefined)
        overwriteCheckBox.SetChecked(insertTemplateFormDialogState.overwrite);
}