(function (chartDesigner) {
    chartDesigner.CustomizeMenuActions.AddHandler(function (_, e) {
        var saveAction = e.actions.filter(function (x) { return x.text === 'Save' })[0];
        saveAction.text = 'Save and Close';
    });
})(chartDesigner);