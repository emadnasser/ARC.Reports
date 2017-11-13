window.DevAV = (function() { 
    var updateTimerID = -1;
    var updateTimeout = 300;
    var searchBoxTimer = -1;
    var cardClassName = "dvCard";
    var cardViewFocusClassName = "focusCard";
    var pendingCallbacks = { };


    var callbackHelper = (function() {
        var callbackControlQueue = [],
            currentCallbackControl = null;

        function doCallback(callbackControl, args, sender, beforeCallback, afterCallback) {
            if (!currentCallbackControl) {
                currentCallbackControl = callbackControl;
                if(typeof(detailsCallbackPanel) !== "undefined" && callbackControl == mainCallbackPanel)
                    detailsCallbackPanel.cpSkipUpdateDetails = true;
                if(!callbackControl.cpHasEndCallbackHandler) {
                    callbackControl.EndCallback.AddHandler(onEndCallback);
                    callbackControl.cpHasEndCallbackHandler = true;
                    callbackControl.cpAfterCallback = afterCallback;
                }
                if(beforeCallback)
                    beforeCallback();
                callbackControl.PerformCallback(args);
            } else
                placeInQueue(callbackControl.name, args, getSenderId(sender));
        };
        function getSenderId(senderObject) {
            if (senderObject.constructor === String)
                return senderObject;
            return senderObject.name || senderObject.id;
        };
        function placeInQueue(callbackControlName, args, sender) {
            var queue = callbackControlQueue;
            for (var i = 0; i < queue.length; i++) {
                if (queue[i].controlName == callbackControlName && queue[i].sender == sender) {
                    queue[i].args = args;
                    return;
                }
            }
            queue.push({ controlName: callbackControlName, args: args, sender: sender });
        };
        function onEndCallback(sender) {
            var queueItem;
            var queuedControl;

            do {
                queueItem = callbackControlQueue.shift();
                queuedControl = queueItem ? getControlInstance(queueItem.controlName) : null;
            } while(!queuedControl && callbackControlQueue.length > 0);

            if(!queuedControl || queuedControl != sender) {
                sender.EndCallback.RemoveHandler(onEndCallback);
                sender.cpHasEndCallbackHandler = false;
                if(sender.cpAfterCallback)
                    sender.cpAfterCallback();
            }
            
            currentCallbackControl = null;
            if(queuedControl)
                doCallback(queuedControl, queueItem.args, queueItem.sender);
        }
        function getControlInstance(name) {
            var controls = ASPx.GetControlCollection().GetControlsByPredicate(function(c) {return c.name === name});
            return controls && controls.length > 0 ? controls[0] : null;
        }
        return {
            DoCallback: doCallback
        };
    })();

    function updateDetailInfo(sender) { // TODO use one method to create timer
        if(detailsCallbackPanel.cpSkipUpdateDetails) {
            detailsCallbackPanel.cpSkipUpdateDetails = false;
            return;
        }
        if(updateTimerID > -1)
            window.clearTimeout(updateTimerID);
        updateTimerID = window.setTimeout(function() {
            window.clearTimeout(updateTimerID);
            callbackHelper.DoCallback(detailsCallbackPanel, "", sender);
        }, updateTimeout);
    };
    function addTask(employeeID, sender) {
        employeeID = employeeID ? employeeID.toString() : "";
        performTaskCommand("New", employeeID, sender);
    }
    function editTask(id, sender) {
        performTaskCommand("Edit", id, sender);
    };
    function performTaskCommand(commandName, args, sender) {
        showClearedPopup(taskEditPopup);
        callbackHelper.DoCallback(taskEditPopup, commandName + "|" + args, sender);
    };
    function deleteTask(id, sender) {
        if(checkReadOnlyMode())
            return;
        if(confirm("Remove task?"))
            callbackHelper.DoCallback(mainCallbackPanel, serializeArgs(["DeleteEntry", id]), sender);
    };
    function gridCustomizationWindow_CloseUp() {
        toolbarMenu.GetItemByName("ColumnsCustomization").SetChecked(false);
    };
    function cardView_Init(s, e) {
        ASPxClientUtils.AttachEventToElement(s.GetMainElement(), "click", function(evt) {
            var cardID = getCardID(ASPxClientUtils.GetEventSource(evt));
            if(cardID)
                selectCard(cardID, s);
        });
        if(s.cpSelectedItemID)
            selectCard(s.cpSelectedItemID, s);
        
        setToolbarCWItemEnabled(false);
    };
    function cardView_EndCallback(s, e) {
        if(s.cpSelectedItemID)
            selectCard(s.cpSelectedItemID, s);
    };

    function selectCard(id, sender) {
        var card = document.getElementById(id);
        if(!card || card.className.indexOf(cardViewFocusClassName) > -1) 
            return;

        var prevSelectedCard = document.getElementById(hiddenField.Get("ID"));
        if(prevSelectedCard)
            prevSelectedCard.className = ASPxClientUtils.Trim(prevSelectedCard.className.replace(cardViewFocusClassName, ""));

        card.className += " " + cardViewFocusClassName;
        hiddenField.Set("ID", id);
        
        var updateDetails = page === employeePage; //TODO add flag to the page 
        if(updateDetails)
            callbackHelper.DoCallback(detailsCallbackPanel, "", sender);
    };
    function getCardID(element) {
        while(element && element.tagName !== "BODY") {
            if(element.className && element.className.indexOf(cardClassName) > -1)
                return element.id;
            element = element.parentNode;
        }
        return null;
    };
    function setToolbarCWItemEnabled(enabled) {
        var item = toolbarMenu.GetItemByName("ColumnsCustomization");
        if(!item)
            return;
        item.SetEnabled(enabled);
        item.SetChecked(false);        
    }

    function employeeSaveButton_Click(s, e) {
        var commandName = employeeEditPopup.cpEmployeeID ? "Edit" : "New";
        saveEditForm(employeeEditPopup, serializeArgs([ commandName, employeeEditPopup.cpEmployeeID ]));
    };
    function employeeCancelButton_Click(s, e) {
        employeeEditPopup.Hide();
    };
    function evaluationSaveButton_Click(s, e) {
        saveEditForm(evaluationEditPopup, serializeArgs([ evaluationEditPopup.cpEvaluationID ]), true);
    };
    function evaluationCancelButton_Click(s, e) {
        evaluationEditPopup.Hide();
    };
    function taskSaveButton_Click(s, e) {
        var commandName = taskEditPopup.cpTaskID ? "Edit" : "New";
        saveEditForm(taskEditPopup, serializeArgs([ commandName, taskEditPopup.cpTaskID ]), page === employeePage);
    };
    function taskCancelButton_Click(s, e) {
        taskEditPopup.Hide();
    };
    function customerSaveButton_Click(s, e) { // TODO rename CustomerEmployeeForm(Button)_Click
        saveEditForm(customerEmployeeEditPopup, serializeArgs([ customerEmployeeEditPopup.cpCustomerEmployeeID ]), true);
    };
    function customerCancelButton_Click(s, e) {
        customerEmployeeEditPopup.Hide();
    };
    function revenueAnalysisCloseButton_Click(s, e) {
        revenueAnalysisPopup.Hide();
    };

    function getViewModeCore(key) {
        return ASPxClientUtils.GetCookie(key);
    };
    function setViewModeCore(key, value) {
        ASPxClientUtils.SetCookie(key, value);
    };
    function showEditMessagePopup(messageTemplate, operation) {
        var message = messageTemplate.replace("<<Operation>>", operation);
        editMessagePopup.SetContentHtml(message);
        editMessagePopup.Show();
    };
    function checkReadOnlyMode() {
        if(window.readOnlyPopup) { // TODO use hiddenField and one popupControl to readOnly and edit message
            readOnlyPopup.Show();
            return true;
        }
        return false;
    };
    function showClearedPopup(popup) {
        popup.Show();
        ASPxClientEdit.ClearEditorsInContainer(document.getElementById("EditFormsContainer"));
    };

    function getAttribute(element, attrName) {
        if(element.getAttribute)
            return element.getAttribute(attrName);
        else if(element.getProperty)
            return element.getProperty(attrName);
    };

    function saveEditForm(popup, args, isDetail) {
        if(!ASPxClientEdit.ValidateEditorsInContainer(popup.GetMainElement()))
            return;
        popup.Hide();
        if(checkReadOnlyMode())
            return;
        var callbackArgs = ["SaveEditForm", popup.cpEditFormName, args];
        var panel = isDetail ? detailsCallbackPanel : mainCallbackPanel;
        callbackHelper.DoCallback(panel, serializeArgs(callbackArgs), popup);
    };

    function showPivotGrid() {
        revenueAnalysisPopup.SetContentUrl("PivotGrid.aspx");
        revenueAnalysisPopup.Show();
    };

    function openReport(reportName, itemID) {
        var url = "DocumentViewer.aspx?ReportArgs=" + serializeArgs([ reportName, itemID ]);
        openPageViewerPopup(url, reportName);
    };
    function openSpreadsheet(reportName, itemID) {
        var url = "Spreadsheet.aspx?ReportArgs=" + serializeArgs([ reportName, itemID ]);
        openPageViewerPopup(url, reportName);
    };
    function openPageViewerPopup(contentUrl, reportName) {
        pageViewerPopup.SetHeaderText(pageViewerPopup.cpReportDisplayNames[reportName]);
        pageViewerPopup.Show();
        pageViewerPopup.SetContentUrl(contentUrl);        
    };

    var dashboardPage = (function() {
        function toolbarMenu_ItemClick(s, e) {
            switch(e.item.name) {
                case "PivotGrid":
                case "RevenueChart":
                case "OpportunitiesChart":
                    var panel = dockManager.GetPanelByUID(e.item.name);
                    if(e.item.GetChecked())
                        panel.Show()
                    else
                        panel.Hide();
            }
        }

        function pivotGridPanel_CloseUp(s, e) {
            uncheckToolbarMenuItem(s.panelUID);
        }
        function revenueChartPanel_CloseUp(s, e) {
            uncheckToolbarMenuItem(s.panelUID);
        }
        function opportunitiesChartPanel_CloseUp(s, e) {
            uncheckToolbarMenuItem(s.panelUID);
        }
        function uncheckToolbarMenuItem(itemName) {
            toolbarMenu.GetItemByName(itemName).SetChecked(false);
        }

        function dockManager_Init(s, e) {
            revenueChart.GetMainElement().style.width = "100%"; // TODO check this case
            opportunitiesChart.GetMainElement().style.width = "100%";
            tileLayoutHelper.DockManager_Init(s, e);
        };
        function dockManager_StartPanelDragging(s, e) {
            tileLayoutHelper.DockManager_StartPanelDragging(s, e);
        }
        function dockManager_EndPanelDragging(s, e) {
            tileLayoutHelper.DockManager_EndPanelDragging(s, e);
        }
        function dockManager_AfterDock(s, e) {
            tileLayoutHelper.DockManager_AfterDock(s, e);
        }
        function dockManager_PanelCloseUp(s, e) {
            tileLayoutHelper.DockManager_PanelCloseUp(s, e);
        }
        
        var tileLayoutHelper = (function() {
            var zones = [ ];
            var zoneDimensionsCache = [ ];
            var draggingPanel;

            function dockManager_Init(s, e) {
                zones = dockManager.GetZones();
                adjustPanes();
                ASPxClientControl.GetControlCollection().BrowserWindowResized.AddHandler(onWindowResize);
            }
            function dockManager_StartPanelDragging(s, e) {
                draggingPanel = e.panel;
                ASPxClientUtils.AttachEventToElement(document, "mousemove", onMouseMove);
            }
            function dockManager_EndPanelDragging(s, e) {
                if(!e.panel.GetOwnerZone())
                    dockPanelToVacantZone(e.panel);
                ASPxClientUtils.DetachEventFromElement(document, "mousemove", onMouseMove);
                draggingPanel = null;
            }
            function dockManager_AfterDock(s, e) {
                var zone = e.panel.GetOwnerZone();
                if(zone.GetPanelCount() > 1) {
                    dockPanelToVacantZone(zone.GetPanels()[0]);
                    zone.GetMainElement().style.height = e.panel.GetMainElement().offsetHeight + "px";
                }
                adjustPanes();
                adjustTopDockZone();
            }
            function dockManager_PanelCloseUp(s, e) {
                adjustTopDockZone();
            }

            function adjustTopDockZone() {
                var zone = dockManager.GetZoneByUID("TopDockZone");
                if(!zone.GetPanelByVisibleIndex(0).GetVisible())
                    zone.GetMainElement().style.height = "1px";
            }
            function onWindowResize() {
                window.clearTimeout(updateTimerID);
                updateTimerID = window.setTimeout(adjustPanes, updateTimeout);
            }
            function adjustPanes() {
                window.clearTimeout(updateTimerID);
                adjustChartSize(revenueChart);
                adjustChartSize(opportunitiesChart);
                updateZoneDimensionsCache();
            }
            function adjustChartSize(chart) {
                var mainElement = chart.GetMainElement();
                var img = mainElement.getElementsByTagName("IMG")[0];
                var chartWidth = mainElement.offsetWidth;
                var imgWidth = img.offsetWidth;
                if(imgWidth < chartWidth && imgWidth < 500 || imgWidth > chartWidth)
                    callbackHelper.DoCallback(chart, chartWidth, chart);
            };
            function onMouseMove(e) {
                var zone = getZoneUnderCursor(e);                
                if(!zone || !draggingPanel)
                    return;
                var zonePanel = zone.GetPanelCount() > 0 && zone.GetPanels()[0];
                if(!zonePanel || zonePanel.panelUID === draggingPanel.panelUID)
                    return;
                dockPanelToVacantZone(zonePanel, zone);
                zone.ShowPanelPlaceholder(draggingPanel);
            }

            function dockPanelToVacantZone(panel, overredZone) {
                var vacantZone = getVacantZone(overredZone);
                panel.Dock(vacantZone);
                panel.GetMainElement().style.width = panel.GetMainElement().parentNode.offsetWidth;
            };
            function getZoneUnderCursor(e) {
                var evtX = ASPxClientUtils.GetEventX(e),
                    evtY = ASPxClientUtils.GetEventY(e);        
                for(var i = 0; i < zoneDimensionsCache.length; i++) {
                    var zd = zoneDimensionsCache[i];
                    if(evtX > zd.x && evtX < zd.x + zd.w && evtY > zd.y && evtY < zd.y + zd.h)
                        return dockManager.GetZoneByUID(zd.zoneUID);
                }
                return null;           
            };
            function getVacantZone(excludeZone) {
                for(var i = 0; i < zones.length; i++) {
                    var isExcludedZone = excludeZone && (zones[i].zoneUID === excludeZone.zoneUID); 
                    if(!isExcludedZone && zones[i].GetPanelCount() === 0)
                        return zones[i];
                }
            };
            function updateZoneDimensionsCache() {
                zoneDimensionsCache = [];
                for(var i = 0; i < zones.length; i++) {
                    var zoneElem = zones[i].GetMainElement();
                    zoneDimensionsCache.push({
                        zoneUID : zones[i].zoneUID,
                        x: ASPxClientUtils.GetAbsoluteX(zoneElem),
                        y: ASPxClientUtils.GetAbsoluteY(zoneElem),
                        w: zones[i].GetWidth(),
                        h: zones[i].GetHeight()
                    });
                }
            };
            return {
                DockManager_Init: dockManager_Init,
                DockManager_StartPanelDragging: dockManager_StartPanelDragging,
                DockManager_EndPanelDragging: dockManager_EndPanelDragging,
                DockManager_AfterDock: dockManager_AfterDock,
                DockManager_PanelCloseUp: dockManager_PanelCloseUp
            };
        })();

        return {
            DockManager_Init: dockManager_Init,
            DockManager_StartPanelDragging: dockManager_StartPanelDragging,
            DockManager_EndPanelDragging: dockManager_EndPanelDragging,
            DockManager_AfterDock: dockManager_AfterDock,
            DockManager_PanelCloseUp: dockManager_PanelCloseUp,
            PivotGridPanel_CloseUp: pivotGridPanel_CloseUp,
            RevenueChartPanel_CloseUp: revenueChartPanel_CloseUp,
            OpportunitiesChartPanel_CloseUp: opportunitiesChartPanel_CloseUp,
            ToolbarMenu_ItemClick: toolbarMenu_ItemClick
        };
    })();

    var employeePage = (function() {
        function toolbarMenu_ItemClick(s, e) {
            var employeeID = getSelectedEmployeeID();
            if(!employeeID)
                return;
            var name = e.item.name;
            switch(name) {
                case "GridView":
                    if(isGridViewMode())
                        return;
                    setViewMode(name);
                    callbackHelper.DoCallback(mainCallbackPanel, "", s, disableToolbarMenu, enableToolbarMenu);
                    break;
                case "CardsView":
                    if(!isGridViewMode())
                        return;
                    setViewMode(name);
                    callbackHelper.DoCallback(mainCallbackPanel, "", s, disableToolbarMenu, enableToolbarMenu);
                    break;
                case "ColumnsCustomization":
                    if(employeesGrid.IsCustomizationWindowVisible())
                        employeesGrid.HideCustomizationWindow();
                    else
                        employeesGrid.ShowCustomizationWindow(e.htmlElement);
                    break;
                case "New":
                    addEmployee();
                    break;
                case "Delete":
                    deleteEmployee(employeeID, s);
                    break;
                case "Meeting":
                    showEditMessagePopup(editMessagePopup.cpEmployeeEditMessageTemplate, "create new meeting");
                    break;
                case "Task":
                    addTask(employeeID, s);
                    break;
            }
        }
        function enableToolbarMenu() {
            toolbarMenu.SetEnabled(true);
        }
        function disableToolbarMenu() {
            toolbarMenu.SetEnabled(false);
        }

        function employeesGrid_Init(s, e) {
            setToolbarCWItemEnabled(true);
        }
        function employeesGrid_FocusedRowChanged(s, e) {
            updateDetailInfo(s);
        }
        function employeesGrid_EndCallback(s, e) {
            updateDetailInfo(s); // TODO check this case
        }
        function employeesGrid_ContextMenuItemClick(s, e) {
            switch(e.item.name) {
                case "NewRow":
                    addEmployee();
                    e.handled = true;
                    break;
                case "EditRow":
                    editEmployee(s.GetRowKey(e.elementIndex), s);
                    e.handled = true;
                    break;
                case "DeleteRow":
                    deleteEmployee(s.GetRowKey(e.elementIndex), s);
                    e.handled = true;
                    break;
            }
        }

        function gridEditButton_Click(e) {
            var src = ASPxClientUtils.GetEventSource(e);
            editEmployee(src.id, src);
        };

        function addEmployee() {
            employeeEditPopup.SetHeaderText("New Employee");
            showClearedPopup(employeeEditPopup);
            firstNameTextBox.Focus();
        }
        function editEmployee(id, sender) { // TODO
            showClearedPopup(employeeEditPopup);
            callbackHelper.DoCallback(employeeEditPopup, id, sender);
        }
        function deleteEmployee(id, sender) {
            if(checkReadOnlyMode())
                return;
            if(confirm("Remove employee?"))
                callbackHelper.DoCallback(mainCallbackPanel, serializeArgs(["DeleteEntry", id]), sender);
        }
        
        function employeeEditButton_Click(s, e) {
            editEmployee(s.cpEmployeeID, s);
        }

        function evaluationGrid_CustomButtonClick(s, e) {
            if(e.buttonID === "EvaluationEditBtn")
                editEvaluation(s.GetRowKey(e.visibleIndex), s);
            if(e.buttonID === "EvaluationDeleteBtn") {
                if(checkReadOnlyMode())
                        return;
                if(confirm("Remove Evaluation?")) {
                    var rowIndex = s.GetFocusedRowIndex();
                    callbackHelper.DoCallback(detailsCallbackPanel, serializeArgs(["DeleteEntry", "Evaluation", rowIndex >= 0 ? s.GetRowKey(rowIndex) : ""]), s);
                }
            }
        }

        function taskGrid_CustomButtonClick(s, e) {
            if(e.buttonID === "EditBtn")
                editTask(s.GetRowKey(e.visibleIndex), s);
            if(e.buttonID === "DeleteBtn") {
                if(checkReadOnlyMode())
                    return;
                if(confirm("Remove Task?")) {
                    var rowIndex = s.GetFocusedRowIndex();
                    callbackHelper.DoCallback(detailsCallbackPanel, serializeArgs(["DeleteEntry", "Task", rowIndex >= 0 ? s.GetRowKey(rowIndex) : ""]), s);
                }
            }
        }

        function editEvaluation(id, sender) {
            showClearedPopup(evaluationEditPopup);
            callbackHelper.DoCallback(evaluationEditPopup, id, sender);
        }
        function getSelectedEmployeeID() {
            var getIndex, getKey;
            try {
                if(isGridViewMode()) {
                    getIndex = employeesGrid.GetFocusedRowIndex.aspxBind(employeesGrid);
                    getKey = employeesGrid.GetRowKey.aspxBind(employeesGrid);
                } else {
                    getIndex = employeeCardView.GetFocusedCardIndex.aspxBind(employeeCardView);
                    getKey = employeeCardView.GetCardKey.aspxBind(employeeCardView);
                }
                if(getIndex() >= 0)
                    return getKey(getIndex()); 
            } catch(e) {
            }
            return null;
        }
        function getViewMode() {
            return getViewModeCore("EmployeeViewMode");
        };
        function setViewMode(value) {
            setViewModeCore("EmployeeViewMode", value);
        };
        function isGridViewMode() {
            var viewMode = getViewMode();
            return !viewMode || viewMode === "GridView";
        };
        function getSelectedItemID() {
            return getSelectedEmployeeID();
        }

    return {
        ToolbarMenu_ItemClick: toolbarMenu_ItemClick,
        EmployeesGrid_Init: employeesGrid_Init,
        EmployeesGrid_FocusedRowChanged: employeesGrid_FocusedRowChanged,
        EmployeesGrid_EndCallback: employeesGrid_EndCallback,
        EmployeesGrid_ContextMenuItemClick: employeesGrid_ContextMenuItemClick,
        GridEditButton_Click: gridEditButton_Click,
        EmployeeEditButton_Click: employeeEditButton_Click,
        EvaluationGrid_CustomButtonClick: evaluationGrid_CustomButtonClick,
        TaskGrid_CustomButtonClick: taskGrid_CustomButtonClick,
        GetSelectedItemID: getSelectedItemID,
        IsGridViewMode: isGridViewMode
    }; 
    })();

    var customerPage = (function() {
        function toolbarMenu_ItemClick(s, e) {
            switch(e.item.name) {
                case "ColumnsCustomization":
                    if(customerGrid.IsCustomizationWindowVisible())
                        customerGrid.HideCustomizationWindow();
                    else
                        customerGrid.ShowCustomizationWindow(e.htmlElement);
                    break;
                case "New":
                    showEditMessagePopup(editMessagePopup.cpEditMessageTemplate, "insert new customer");
                    break;
                case "Delete":
                    showEditMessagePopup(editMessagePopup.cpEditMessageTemplate, "delete customer");
                    break;
                case "ShowPivotGrid":
                    showPivotGrid();
                    break;
            }
        }

        function gridEditButton_Click(e) {
            showEditMessagePopup(editMessagePopup.cpEditMessageTemplate, "edit customer's");
        };

        function customerGrid_FocusedRowChanged(s, e) {
            updateDetailInfo(s);
        }

        function customerGrid_ContextMenuItemClick(s, e) {
            switch(e.item.name) {
                case "NewRow":
                    showEditMessagePopup(editMessagePopup.cpEditMessageTemplate, "insert new customer");
                    e.handled = true;
                    break;
                case "EditRow":
                    showEditMessagePopup(editMessagePopup.cpEditMessageTemplate, "edit customer's");
                    e.handled = true;
                    break;
                case "DeleteRow":
                    showEditMessagePopup(editMessagePopup.cpEditMessageTemplate, "delete customer");
                    e.handled = true;
                    break;
            }
        }

        function customerEmployeeButton_Click(s, e) {
            startEditCustomerEmployee(s.cpCustomerEmployeeID, s);
        }
        function startEditCustomerEmployee(id, sender) {
            showClearedPopup(customerEmployeeEditPopup);
            callbackHelper.DoCallback(customerEmployeeEditPopup, id, sender);
        }
        function sliderMenu_ItemClick(s, e) {
            if(e.item.name === "Root")
                return;
            ASPxClientUtils.SetCookie("CustomerImageSliderMode", e.item.name);
            updateDetailInfo(s);
        }

        function getSelectedItemID() {
            var rowIndex = customerGrid.GetFocusedRowIndex();
            return rowIndex >= 0 ? customerGrid.GetRowKey(rowIndex) : null;
        }

        return {
            ToolbarMenu_ItemClick: toolbarMenu_ItemClick,
            GridEditButton_Click: gridEditButton_Click,
            CustomerGrid_FocusedRowChanged: customerGrid_FocusedRowChanged,
            CustomerGrid_ContextMenuItemClick: customerGrid_ContextMenuItemClick,
            CustomerEmployeeButton_Click: customerEmployeeButton_Click,
            SliderMenu_ItemClick: sliderMenu_ItemClick,
            GetSelectedItemID: getSelectedItemID
        };
    })();

    var productPage = (function() {
        function toolbarMenu_ItemClick(s, e) { 
            var name = e.item.name;
            switch(name) {
                case "ColumnsCustomization":
                    if(productGrid.IsCustomizationWindowVisible())
                        productGrid.HideCustomizationWindow();
                    else
                        productGrid.ShowCustomizationWindow(e.htmlElement);
                    break;
                case "New":
                    showEditMessagePopup(editMessagePopup.cpEditMessageTemplate, "insert new product");
                    break;
                case "Delete":
                    showEditMessagePopup(editMessagePopup.cpEditMessageTemplate, "delete product");
                    break;
                case "ShowPivotGrid":
                    showPivotGrid();
                    break;
            }
        }
        function productGrid_FocusedRowChanged(s, e) {
            updateDetailInfo(s);
        }
        function productGrid_ContextMenuItemClick(s, e) {
            switch(e.item.name) {
                case "NewRow":
                    showEditMessagePopup(editMessagePopup.cpEditMessageTemplate, "insert new product");
                    e.handled = true;
                    break;
                case "EditRow":
                    showEditMessagePopup(editMessagePopup.cpEditMessageTemplate, "edit product");
                    e.handled = true;
                    break;
                case "DeleteRow":
                    showEditMessagePopup(editMessagePopup.cpEditMessageTemplate, "delete product");
                    e.handled = true;
                    break;
            }
        }
        function productImageSlider_ThumbnailItemClick(s, e) {
            callbackHelper.DoCallback(productPopup, s.GetActiveItemIndex(), s);
            productPopup.Show();
        }
        function productImageUpload_FileUploadStart(s, e) {
            e.cancel = checkReadOnlyMode();
        }
        function productImageUpload_FileUploadComplete(s, e) {
            updateDetailInfo(s);
        }
        function productUploadButton_Click(s, e) {
            productImageUpload.Upload();
        }
        function getSelectedItemID() {
            var rowIndex = productGrid.GetFocusedRowIndex();
            return rowIndex >= 0 ? productGrid.GetRowKey(rowIndex) : null;
        }

        return {
            ToolbarMenu_ItemClick: toolbarMenu_ItemClick,
            ProductGrid_FocusedRowChanged: productGrid_FocusedRowChanged,
            ProductGrid_ContextMenuItemClick: productGrid_ContextMenuItemClick,
            ProductImageSlider_ThumbnailItemClick: productImageSlider_ThumbnailItemClick,
            ProductImageUpload_FileUploadStart: productImageUpload_FileUploadStart,
            ProductImageUpload_FileUploadComplete: productImageUpload_FileUploadComplete,
            ProductUploadButton_Click: productUploadButton_Click,
            GetSelectedItemID: getSelectedItemID
        };
    })();

    var taskPage = (function() {
        function toolbarMenu_ItemClick(s, e) { 
            var name = e.item.name;
            switch(name) {
                case "GridView":
                    if(isGridViewMode())
                        return;
                    setViewMode("GridView");
                    callbackHelper.DoCallback(mainCallbackPanel, "", s);
                    break;
                case "CardsView":
                    if(!isGridViewMode())
                        return;
                    setViewMode("CardsView");
                    callbackHelper.DoCallback(mainCallbackPanel, "", s);
                    break;
                case "New":
                    taskEditPopup.SetHeaderText("New Task");
                    addTask("", s);
                    break;
            }
        }
        function taskGrid_CustomButtonClick(s, e) {
            switch(e.buttonID) {
                case "EditBtn":
                    editTask(s.GetRowKey(e.visibleIndex), s);
                    break;
                case "DeleteBtn":
                    deleteTask(s.GetRowKey(e.visibleIndex), s);
                    break;
            }
        }
        function tasksGrid_ContextMenuItemClick(s, e) {
            switch(e.item.name) {
                case "NewRow":
                    addTask("", s);
                    e.handled = true;
                    break;
                case "EditRow":
                    editTask(s.GetRowKey(e.elementIndex), s);
                    e.handled = true;
                    break;
                case "DeleteRow":
                    deleteTask(s.GetRowKey(e.elementIndex), s);
                    e.handled = true;
                    break;
            }
        }

        function viewButton_Click(s, e) {
            performTaskCommand("Show", s.cpTaskID, s);
        }
        function editButton_Click(s, e) {
            editTask(s.cpTaskID, s);
        }
        function deleteButton_Click(s, e) {
            deleteTask(s.cpTaskID, s);
        }

        function getViewMode() {
            return getViewModeCore("TaskViewMode");
        }
        function setViewMode(value) {
            setViewModeCore("TaskViewMode", value);
        }
        function isGridViewMode() {
            var viewMode = getViewMode();
            return !viewMode || viewMode === "GridView";
        }
        return {
            ToolbarMenu_ItemClick: toolbarMenu_ItemClick,
            TaskGrid_CustomButtonClick: taskGrid_CustomButtonClick,
            TasksGrid_ContextMenuItemClick: tasksGrid_ContextMenuItemClick,
            ViewButton_Click: viewButton_Click,
            EditButton_Click: editButton_Click,
            DeleteButton_Click: deleteButton_Click,
            IsGridViewMode: isGridViewMode
        };
    })();

    function getCurrentPage() {
        var pageName = DevAVPageName;
        switch(pageName) {
            case "Dashboard":
                return dashboardPage;
            case "Employees":
                return employeePage;
            case "Customers":
                return customerPage;
            case "Products":
                return productPage;
            case "Tasks":
                return taskPage;
        }
    };
    var page = getCurrentPage();

    function gridEditButton_Click(event) {
        page.GridEditButton_Click(event);
        ASPxClientUtils.PreventEventAndBubble(event);
    }

    function adjustMainContentPaneSize() {
        var pane = splitter.GetPaneByName("MainContentPane");

        if(page === customerPage)
            adjustControlSize(pane, customerGrid, detailsCallbackPanel);
        
        if(page === employeePage)
            adjustControlSize(pane, page.IsGridViewMode() ? employeesGrid : employeeCardView, detailsCallbackPanel);

        if(page === taskPage)
            adjustControlSize(pane, page.IsGridViewMode() ? taskGrid : taskCardView);

        if(page === productPage)
            adjustControlSize(pane, productGrid, detailsCallbackPanel);
    }
    function adjustControlSize(splitterPane, grid, detailPanel, minHeight) {
        grid.SetHeight(splitterPane.GetClientHeight() - (detailPanel ? detailPanel.GetHeight() : 0));
    }

    function filterNavBar_Init(s, e) {
        loadFilterNavBarSelectedItem();
    };
    function filterNavBar_ItemClick(s, e) {
        if(e.item.name !== s.cpPrevSelectedItemName)
            changeFilter(s.cpFilterExpressions[e.item.name], s);
    };
    
    function searchBox_KeyDown(s, e) {
        window.clearTimeout(searchBoxTimer);
        searchBoxTimer = window.setTimeout(function() { onSearchTextChanged(s); }, 1200);
        e = e.htmlEvent;
        if(e.keyCode === 13) {
            if(e.preventDefault)
                e.preventDefault();
            else
                e.returnValue = false;
        }
    };
    function searchBox_TextChanged(s, e) {
        onSearchTextChanged(s);
    };
    function onSearchTextChanged(sender) {
        window.clearTimeout(searchBoxTimer);
        var searchText = searchBox.GetText();
        if(hiddenField.Get("SearchText") == searchText)
            return;
        hiddenField.Set("SearchText", searchText);
        callbackHelper.DoCallback(mainCallbackPanel, serializeArgs( ["Search"] ), sender);
    };

    function filterControl_Applied(s, e) {
        changeFilter(e.filterExpression, s);
    }
    function saveCustomFilterCheckBox_CheckedChanged(s, e) {
        customFilterTextBox.SetEnabled(s.GetChecked());
        customFilterTextBox.SetIsValid(true);
    }
    function customFilterTextBox_Validation(s, e) {
        e.isValid = !!e.value || !saveCustomFilterCheckBox.GetChecked();
    }
    function saveFilterButton_Click(s, e) {
        if(saveCustomFilterCheckBox.GetChecked()) {
            var validated = ASPxClientEdit.ValidateEditorsInContainer(filterPopup.GetMainElement());
            if(validated)
                filterPopup.Hide();
            return;
        }
        e.processOnServer = false;
        filterPopup.Hide();
        filterControl.Apply();
    }
    function cancelFilterButton_Click(s, e) {
        filterPopup.Hide();
    }

    function mainCallbackPanel_EndCallback(s, e) {
        if(s.cpSelectedFilterNavBarItemName)
            updateFilterNavBarSelection(s.cpSelectedFilterNavBarItemName);
        adjustMainContentPaneSize();
    }


    function splitter_PaneResized(s, e) {
        if(e.pane.name == 'MainContentPane')
            window.setTimeout(function() { adjustMainContentPaneSize(); }, 0);
    }

    function pageViewerPopup_Shown(s, e) {
        preparePopupWithIframe(s);
    }
    function revenueAnalysisPopup_Shown(s, e) {
        preparePopupWithIframe(s);
    }
    function pageViewerPopup_CloseUp(s, e) {
        s.SetContentUrl("");
    }
    function revenueAnalysisPopup_CloseUp(s, e) {
        s.SetContentUrl("");
    }

    function toolbarMenu_ItemClick(s, e) {
        var name = e.item.name;
        var selectedItemID = page.GetSelectedItemID && page.GetSelectedItemID();
        if(name === "Print" || e.item.parent && e.item.parent.name === "Print")
            openReport(s.cpReportNames[name], selectedItemID);
        if(name === "ExportToSpreadsheet")
            openSpreadsheet(s.cpReportNames[name], selectedItemID);
        if(name === "Filter")
            filterPopup.Show();

        page.ToolbarMenu_ItemClick(s, e);
    }

    function preparePopupWithIframe(popup) {
        var iframe = popup.GetContentIFrame();
        setAttribute(iframe, "scrolling", "no");
        iframe.style.overflow = "hidden";
    };

    function updateFilterNavBarSelection(selectedItemName) {
        var oldItem = filterNavBar.GetSelectedItem();
        var newItem = filterNavBar.GetItemByName(selectedItemName);
        if(oldItem && newItem && filterNavBar.cpFilterExpressions[oldItem.name] === filterNavBar.cpFilterExpressions[newItem.name])
            return;
        filterNavBar.SetSelectedItem(newItem);
        loadFilterNavBarSelectedItem();
    }
    
    function changeFilter(expression, sender) {
        callbackHelper.DoCallback(mainCallbackPanel, serializeArgs([ "FilterChanged", expression ]), sender);
        loadFilterNavBarSelectedItem();
    }

    function loadFilterNavBarSelectedItem() {
        var item = filterNavBar.GetSelectedItem();
        filterNavBar.cpPrevSelectedItemName = item ? item.name : "";
    }

    function serializeArgs(args) {
        var result = [];
        for(var i = 0; i < args.length; i++) {
            var value = args[i] ? args[i].toString() : "";
            result.push(value.length);
            result.push("|");
            result.push(value);
        }
        return result.join("");
    }
    function setAttribute(element, attrName, value) {
        if(element.setAttribute)
            element.setAttribute(attrName, value);
        else if(element.setProperty)
            element.setProperty(attrName, value, "");
    }

    function employeeEditPopup_EndCallback(s, e) {
        s.SetHeaderText(s.cpHeaderText);
        firstNameTextBox.Focus();
    }
    function evaluationEditPopup_EndCallback(s, e) {
        s.SetHeaderText(s.cpHeaderText);
        evaluationSubjectTextBox.Focus();
    }
    function taskEditPopup_EndCallback(s, e) {
        s.SetHeaderText(s.cpHeaderText);
        OwnerComboBox.Focus();
    }
    function customerEditPopup_EndCallback(s, e) {
        s.SetHeaderText(s.cpHeaderText);
        firstNameTextBox.Focus();
    }
    
    return { 
        Page: page,
        FilterNavBar_Init: filterNavBar_Init,
        FilterNavBar_ItemClick: filterNavBar_ItemClick,
        SearchBox_KeyDown: searchBox_KeyDown,
        SearchBox_TextChanged: searchBox_TextChanged,
        FilterControl_Applied: filterControl_Applied,
        SaveCustomFilterCheckBox_CheckedChanged: saveCustomFilterCheckBox_CheckedChanged,
        CustomFilterTextBox_Validation: customFilterTextBox_Validation,
        SaveFilterButton_Click: saveFilterButton_Click,
        CancelFilterButton_Click: cancelFilterButton_Click,
        MainCallbackPanel_EndCallback: mainCallbackPanel_EndCallback,
        Splitter_PaneResized: splitter_PaneResized,
        PageViewerPopup_Shown: pageViewerPopup_Shown,
        PageViewerPopup_CloseUp: pageViewerPopup_CloseUp,
        RevenueAnalysisPopup_Shown: revenueAnalysisPopup_Shown,
        RevenueAnalysisPopup_CloseUp: revenueAnalysisPopup_CloseUp,
        RevenueAnalysisCloseButton_Click: revenueAnalysisCloseButton_Click,
        ToolbarMenu_ItemClick: toolbarMenu_ItemClick,
        GridEditButton_Click: gridEditButton_Click,
        GridCustomizationWindow_CloseUp: gridCustomizationWindow_CloseUp,
        CardView_Init: cardView_Init,
        CardView_EndCallback: cardView_EndCallback,
        EmployeeCancelButton_Click: employeeCancelButton_Click,
        EmployeeSaveButton_Click: employeeSaveButton_Click,
        EvaluationSaveButton_Click: evaluationSaveButton_Click,
        EvaluationCancelButton_Click: evaluationCancelButton_Click,
        TaskSaveButton_Click: taskSaveButton_Click,
        TaskCancelButton_Click: taskCancelButton_Click,
        CustomerCancelButton_Click: customerCancelButton_Click,
        CustomerSaveButton_Click: customerSaveButton_Click,
        EmployeeEditPopup_EndCallback: employeeEditPopup_EndCallback,
        EvaluationEditPopup_EndCallback: evaluationEditPopup_EndCallback,
        TaskEditPopup_EndCallback: taskEditPopup_EndCallback,
        CustomerEditPopup_EndCallback: customerEditPopup_EndCallback
    }; 
})();