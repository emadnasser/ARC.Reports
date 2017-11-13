Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.IO
Imports System.Linq
Imports System.Web
Imports DevExpress.Web
Imports DevExpress.Web.ASPxSpreadsheet

Namespace DevExpress.Web.Demos
	Public NotInheritable Class SpreadsheetDemoUtils
		Private Sub New()
		End Sub
		Public Shared Sub HideFileTab(ByVal spreadsheet As ASPxSpreadsheet.ASPxSpreadsheet)
			spreadsheet.CreateDefaultRibbonTabs(True)
			RemoveRibbonTab(spreadsheet, GetType(SRFileTab))
		End Sub

		Public Shared Sub CreateOverviewRibbon(ByVal spreadsheet As ASPxSpreadsheet.ASPxSpreadsheet)
			spreadsheet.CreateDefaultRibbonTabs(True)
			RemoveRibbonTab(spreadsheet, GetType(SRFileTab))
			RemoveRibbonTab(spreadsheet, GetType(SRPageLayoutTab))
		End Sub

		Private Shared Sub RemoveRibbonTab(ByVal spreadsheet As ASPxSpreadsheet.ASPxSpreadsheet, ByVal tabTypeToRemove As Type)
			For Each tab As RibbonTab In spreadsheet.RibbonTabs
				If tab.GetType() Is tabTypeToRemove Then
					spreadsheet.RibbonTabs.Remove(tab)
				   Exit For
				End If
			Next tab
		End Sub

		Public Shared Sub HideAllTabsExceptFileAndPageLayout(ByVal spreadsheet As ASPxSpreadsheet.ASPxSpreadsheet)
			spreadsheet.CreateDefaultRibbonTabs(True)

			ShowRibbonItemsOnly(spreadsheet, New Type() { GetType(SRFilePrintCommand), GetType(SRPageSetupMarginsCommand), GetType(SRPageSetupOrientationCommand), GetType(SRPageSetupPaperKindCommand), GetType(SRPrintGridlinesCommand), GetType(SRPrintHeadingsCommand) })
		End Sub

		Public Shared Sub HideAllTabsExceptHomeAndView(ByVal spreadsheet As ASPxSpreadsheet.ASPxSpreadsheet)
			spreadsheet.CreateDefaultRibbonTabs(True)

			RemoveRibbonTab(spreadsheet, GetType(SRFileTab))
			RemoveRibbonTab(spreadsheet, GetType(SRInsertTab))
			RemoveRibbonTab(spreadsheet, GetType(SRPageLayoutTab))
			RemoveRibbonTab(spreadsheet, GetType(SRPageLayoutTab))
			RemoveRibbonTab(spreadsheet, GetType(SRFormulasTab))
			RemoveRibbonTab(spreadsheet, GetType(SRDataTab))
		End Sub

		Public Shared Sub HidePageLayoutTab(ByVal spreadsheet As ASPxSpreadsheet.ASPxSpreadsheet)
			RemoveRibbonTab(spreadsheet, GetType(SRPageLayoutTab))
		End Sub

		Public Shared Sub HideFormulasTab(ByVal spreadsheet As ASPxSpreadsheet.ASPxSpreadsheet)
			RemoveRibbonTab(spreadsheet, GetType(SRFormulasTab))
		End Sub

		Private Shared Sub HideRibbonItems(ByVal spreadsheet As ASPxSpreadsheet.ASPxSpreadsheet, ByVal itemTypes() As Type)
			ProcessRibbonItems(spreadsheet, itemTypes, False)
		End Sub
		Private Shared Sub ShowRibbonItemsOnly(ByVal spreadsheet As ASPxSpreadsheet.ASPxSpreadsheet, ByVal itemTypes() As Type)
			ProcessRibbonItems(spreadsheet, itemTypes, True)
		End Sub
		Private Shared Sub ProcessRibbonItems(ByVal spreadsheet As ASPxSpreadsheet.ASPxSpreadsheet, ByVal targetTypes() As Type, ByVal removeNotInList As Boolean)
			Dim groups = New List(Of RibbonGroup)()
			Dim items = New List(Of RibbonItemBase)()

			Dim tabs As List(Of RibbonTab) = spreadsheet.RibbonTabs.ToList()
			For Each tab As RibbonTab In tabs
				groups.AddRange(tab.Groups)
			Next tab
			For Each group As RibbonGroup In groups
				items.AddRange(group.Items)
			Next group

			RemoveItemsByTypes(items, targetTypes, removeNotInList)
			RemoveEmptyGroups(groups)
			RemoveEmptyTabs(spreadsheet, tabs)
		End Sub

		Private Shared Sub RemoveItemsByTypes(ByVal items As List(Of RibbonItemBase), ByVal targetTypes() As Type, ByVal removeNotInList As Boolean)
			Dim targetItem = New List(Of RibbonItemBase)()
			Dim itemsNotInList = New List(Of RibbonItemBase)()
			GroupItemsByType(items, targetTypes, targetItem, itemsNotInList)

			If removeNotInList Then
				RemoveItems(itemsNotInList)
			Else
				RemoveItems(targetItem)
			End If

		End Sub

		Private Shared Sub GroupItemsByType(ByVal items As List(Of RibbonItemBase), ByVal targetTypes() As Type, ByVal targetItem As List(Of RibbonItemBase), ByVal itemsNotInList As List(Of RibbonItemBase))
			For Each item As RibbonItemBase In items
				If targetTypes.Contains(item.GetType()) Then
					targetItem.Add(item)
				Else
					itemsNotInList.Add(item)
				End If
			Next item
		End Sub

		Private Shared Sub RemoveItems(ByVal items As List(Of RibbonItemBase))
			For Each item As RibbonItemBase In items
				item.Group.Items.Remove(item)
			Next item
		End Sub
		Private Shared Sub RemoveEmptyGroups(ByVal groups As List(Of RibbonGroup))
			For Each group As RibbonGroup In groups
				If group.Items.IsEmpty Then
					group.Tab.Groups.Remove(group)
				End If
			Next group
		End Sub
		Private Shared Sub RemoveEmptyTabs(ByVal spreadsheet As ASPxSpreadsheet.ASPxSpreadsheet, ByVal tabs As List(Of RibbonTab))
			For Each tab As RibbonTab In tabs
				If tab.Groups.IsEmpty Then
					spreadsheet.RibbonTabs.Remove(tab)
				End If
			Next tab
		End Sub
	End Class
End Namespace
