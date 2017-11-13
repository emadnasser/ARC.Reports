function aspxTimeZoneEditComboSelectedIndexChangedEx(name, tzId, indx) {
    var timeZoneEdit = ASPxClientControl.GetControlCollection().Get(name);
    if (timeZoneEdit)
        timeZoneEdit.ChangeTimeZoneId(tzId, indx);
}

////////////////////////////////////////////////////////////////////////////////
// ASPxClientTimeZoneEdit
////////////////////////////////////////////////////////////////////////////////
ASPxClientTimeZoneEditEx = ASPx.CreateClass(ASPx.SchedulerRelatedControlBase, {
    ChangeTimeZoneId: function(tzId, indx) {
        var schedulerControl = ASPxClientControl.GetControlCollection().Get(this.schedulerControlId);
        if (schedulerControl) 
            schedulerControl.RaiseCallback("UTZCH|" + tzId + "," + indx);
    }
});
////////////////////////////////////////////////////////////////////////////////


