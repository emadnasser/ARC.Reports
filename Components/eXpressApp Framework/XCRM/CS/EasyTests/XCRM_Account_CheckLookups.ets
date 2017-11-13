#DropDB XCRM_EasyTest

#Application XCRMFullWin
#Application XCRMFullWeb

#IncludeFile XCRM_Login.inc

#IncludeFile XCRM_AddLead.inc

*Action Navigation(Accounts)

*Action View(Active Accounts)

*Action New

*FillForm
 Account Name = Account1

*FillForm
 Source Lead = Lead1First Lead1Last
 Owner = User1 User1

*Action Save and Close

#IfDef XCRMFullWeb
*Action Navigation(Accounts)
#EndIf

*ProcessRecord
 Account Name = Account1

*CheckFieldValues
 Source Lead = Lead1First Lead1Last
 Owner = User1 User1