#DropDB XCRM_EasyTest

#Application XCRMFullWin
#Application XCRMFullWeb

#IncludeFile XCRM_Login.inc

*Action Navigation(Leads)
*Action New

*FillForm
 Topic = Lead Topic
 Company Name = Lead Company Name
 Last Name = Lead Last Name
 First Name = Lead First Name

*Action Save and Close

*Action Navigation(Reports.Reports)

*ProcessRecord
 Report Name = Leads By Lead Source

*Sleep 10000

#IfDef XCRMFullWin
*HandleDialog
 Close = True
#EndIf

#IfDef XCRMFullWeb
*Action Close
#EndIf

*CheckTable
 Columns = Report Name
 Row = Leads By Lead Source

*Action Navigation(Leads)
*Action View(Open Leads)

*SelectRecords
 Columns = Topic
 Row[0] = Lead Topic

*Action Show in Report(Leads By Lead Source)

*Sleep 10000

#IfDef XCRMFullWin
*HandleDialog
 Close = True
#EndIf

#IfDef XCRMFullWeb
*Action Close
#EndIf

*CheckTable
 Columns = Topic
 Row = Lead Topic