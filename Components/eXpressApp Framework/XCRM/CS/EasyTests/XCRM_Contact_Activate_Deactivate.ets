#DropDB XCRM_EasyTest

#Application XCRMFullWin
#Application XCRMFullWeb

#IncludeFile XCRM_Login.inc

#IncludeFile XCRM_AddContact.inc

*Action Navigation(Contacts)

*Action View(Active Contacts)

*SelectRecords
 Columns = Full Name
 Row = Contact1First Contact1Last
!ActionAvailable Activate ...

*Action Deactivate...
*HandleDialog
 Respond = Yes

*Action View(Inactive Contacts)
*SelectRecords
 Columns = Full Name
 Row = Contact1First Contact1Last

!ActionAvailable Deactivate...

*Action Activate...
*HandleDialog
 Respond = Yes

*Action View(Active Contacts)
*SelectRecords
 Columns = Full Name
 Row = Contact1First Contact1Last
 
!ActionAvailable Activate...
*ActionAvailable Deactivate...