Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Windows.Forms
Imports System.Reflection
Imports DevExpress.Utils.Frames
Imports DevExpress.XtraEditors
Imports DevExpress.DXperience.Demos
Imports DevExpress.XtraCharts.Designer

Namespace DevExpress.XtraCharts.Demos
	Public Class DemosInfo
		Inherits ModulesInfo
		Private Shared Sub UpdateModuleInfo(ByVal item As ModuleInfo)
			item.RecreateModuleIfNecessary(System.Reflection.Assembly.GetCallingAssembly())
		End Sub
		Public Shared Function DoShowModule(ByVal name As String, ByVal group As GroupControl, ByVal caption As ApplicationCaption, ByVal manager As ChartRibbonMenuManager) As TutorialControl
			Dim item As ModuleInfo = DemosInfo.GetItem(name)
			Dim currentCursor As Cursor = Cursor.Current
			Cursor.Current = Cursors.WaitCursor
			Try
				If Instance.CurrentModuleBase IsNot Nothing Then
					If Instance.CurrentModuleBase.Name = name Then
						Return Nothing
					End If
					Dim oldTutorial As Control = ChartModulesPool.GetPreviousModule()
					If oldTutorial Is Nothing Then
						oldTutorial = Instance.CurrentModuleBase.TModule
					End If
					If oldTutorial IsNot Nothing Then
						oldTutorial.Visible = False
					End If
				End If
				Dim tutorial As TutorialControlBase = CType(item.TModule, TutorialControlBase)
				tutorial.Bounds = group.DisplayRectangle
				tutorial.Visible = False
				tutorial.Capture = True
				Application.DoEvents()
				tutorial.Capture = False
				Instance.CurrentModuleBase = item
				group.Controls.Add(tutorial)
				tutorial.Dock = DockStyle.Fill
				Dim tc As TutorialControl = TryCast(tutorial, TutorialControl)
				If tc IsNot Nothing Then
					ChartModulesPool.RegisterModule(tc)
					UpdateModuleInfo(item)
					manager.AllowExport(tc.ExportedObject)
					manager.ShowReservGroup1(True)
					manager.ShowReservGroup2(True)
				Else
					manager.AllowExport(Nothing)
					manager.ShowReservGroup1(False)
					manager.ShowReservGroup2(False)
				End If
				tutorial.RibbonMenuManager = manager
				tutorial.TutorialName = name
				tutorial.Caption = caption
				tutorial.Visible = True
				item.WasShown = True
			Finally
				Cursor.Current = currentCursor
			End Try
			RaiseModuleChanged()
			Return TryCast(item.TModule, TutorialControl)
		End Function
		Public Shared Function SetAppearanceName(ByVal appearanceName As String) As String
			If Instance.CurrentModuleBase IsNot Nothing Then
				Dim chartModule As ChartDemoBase = TryCast(Instance.CurrentModuleBase.TModule, ChartDemoBase)
				If chartModule IsNot Nothing Then
					chartModule.AppearanceName = appearanceName
					Return chartModule.PaletteName
				End If
			End If
			Return String.Empty
		End Function
		Public Shared Function SetPaletteName(ByVal paletteName As String) As String
			If Instance.CurrentModuleBase IsNot Nothing Then
				Dim chartModule As ChartDemoBase = TryCast(Instance.CurrentModuleBase.TModule, ChartDemoBase)
				If chartModule IsNot Nothing Then
					chartModule.PaletteName = paletteName
					Return chartModule.AppearanceName
				End If
			End If
			Return String.Empty
		End Function
		Public Shared Sub RunChartWizard()
			If Instance.CurrentModuleBase IsNot Nothing Then
				Dim chartModule As ChartDemoBase = TryCast(Instance.CurrentModuleBase.TModule, ChartDemoBase)
				If chartModule IsNot Nothing Then
					Dim chartDesigner As New ChartDesigner(chartModule.ChartControl)
					chartDesigner.ShowDialog()
					chartModule.UpdateControls()
				End If
			End If
		End Sub
	End Class

	Public NotInheritable Class ChartModulesPool
		Private Const MaxModulesCount As Integer = 5

		Private Shared ReadOnly modules As New List(Of TutorialControl)(MaxModulesCount)

		Private Sub New()
		End Sub
		Private Shared Sub UnregisterModule(ByVal [module] As TutorialControl)
			Dim moduleInfo As ModuleInfo = ModulesInfo.GetItem([module].TutorialName)
			moduleInfo.ResetModule()
			[module].Dispose()
			modules.Remove([module])
		End Sub
		Public Shared Sub RegisterModule(ByVal [module] As TutorialControl)
			If modules.Contains([module]) Then
				modules.Remove([module])
			ElseIf modules.Count = MaxModulesCount Then
				UnregisterModule(modules(0))
			End If
			modules.Add([module])
		End Sub
		Public Shared Function GetPreviousModule() As Control
			Return If(modules.Count > 0, modules(modules.Count - 1), Nothing)
		End Function
	End Class
End Namespace
