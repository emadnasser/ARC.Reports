Imports System.Text
Imports DevExpress.XtraNavBar
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.LookAndFeel
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Controls
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.Skins
Imports DevExpress.XtraEditors.DXErrorProvider
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.Data.Helpers
Imports DevExpress.Utils
Imports System.Collections
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraSpellChecker
Imports System.IO
Imports DevExpress.Utils.Zip
Imports System.Globalization
Imports DevExpress.XtraRichEdit
Imports DevExpress.Demos.OpenWeatherService
Imports DevExpress.XtraMap
Imports DevExpress.ProductsDemo.Win.Modules
Imports DevExpress.MailDemo.Win
Imports DevExpress.MailClient.Win

Namespace DevExpress.ProductsDemo.Win
	Public Class GridHelper
		Public Shared Sub GridViewFocusObject(ByVal cView As ColumnView, ByVal obj As Object)
			If obj Is Nothing Then
				Return
			End If
			Dim oldFocusedRowHandle As Integer = cView.FocusedRowHandle
			For i As Integer = 0 To cView.DataRowCount - 1
				Dim rowObj As Object = TryCast(cView.GetRow(i), Object)
				If rowObj Is Nothing Then
					Continue For
				End If
				If ReferenceEquals(obj, rowObj) Then
					If i = oldFocusedRowHandle Then
						cView.FocusedRowHandle = GridControl.InvalidRowHandle
					End If
					cView.FocusedRowHandle = i
					Exit For
				End If
			Next i
		End Sub
		Public Shared Sub SetFindControlImages(ByVal grid As GridControl)
			Dim fControl As FindControl = Nothing
			For Each ctrl As Control In grid.Controls
				fControl = TryCast(ctrl, FindControl)
				If fControl IsNot Nothing Then
					Exit For
				End If
			Next ctrl
			If fControl IsNot Nothing Then
				fControl.FindButton.Image = My.Resources.Search
				fControl.ClearButton.Image = My.Resources.Delete_16x16
				fControl.CalcButtonsBestFit()
			End If
		End Sub
	End Class
	Public Class ImageHelper
		Public Shared Function GetScaleImage(ByVal image As Image, ByVal size As Size) As Bitmap
			Return New Bitmap(image, size.Width, size.Height)
		End Function
	End Class
	Public Class ColorHelper
		Public Shared Sub UpdateColor(ByVal list As ImageList, ByVal lf As UserLookAndFeel)
			For i As Integer = 0 To list.Images.Count - 1
				list.Images(i) = SetColor(TryCast(list.Images(i), Bitmap), GetHeaderForeColor(lf))
			Next i
		End Sub
		Public Shared Function GetHeaderForeColor(ByVal lf As UserLookAndFeel) As Color
			Dim ret As Color = SystemColors.ControlText
			If lf.ActiveStyle <> ActiveLookAndFeelStyle.Skin Then
				Return ret
			End If
			Return GridSkins.GetSkin(lf)(GridSkins.SkinHeader).Color.GetForeColor()
		End Function
		Private Shared Function SetColor(ByVal bmp As Bitmap, ByVal color As Color) As Bitmap
			For i As Integer = 0 To bmp.Width - 1
				For j As Integer = 0 To bmp.Height - 1
					If bmp.GetPixel(i, j).Name <> "0" Then
						bmp.SetPixel(i, j, color)
					End If
				Next j
			Next i
			Return bmp
		End Function
		Public Shared ReadOnly Property DisabledTextColor() As Color
			Get
				Return CommonSkins.GetSkin(DevExpress.LookAndFeel.UserLookAndFeel.Default).Colors.GetColor("DisabledText")
			End Get
		End Property
		Public Shared ReadOnly Property CriticalColor() As Color
			Get
				Return CommonColors.GetCriticalColor(DevExpress.LookAndFeel.UserLookAndFeel.Default)
			End Get
		End Property
		Public Shared ReadOnly Property WarningColor() As Color
			Get
				Return CommonColors.GetWarningColor(DevExpress.LookAndFeel.UserLookAndFeel.Default)
			End Get
		End Property
		Private Shared Function GetRGBColor(ByVal color As Color) As String
			Return String.Format("{0},{1},{2}", color.R, color.G, color.B)
		End Function
	End Class
	Public Class ObjectHelper
		Public Shared Sub StartProcess(ByVal processName As String)
			Try
				Process.Start(processName)
			Catch ex As Exception
				XtraMessageBox.Show(ex.Message, My.Resources.Error, MessageBoxButtons.OK, MessageBoxIcon.Error)
			End Try
		End Sub
	End Class

	Public Class ValidationRulesHelper
		Private Shared ruleIsNotBlank_Renamed As ConditionValidationRule = Nothing
		Public Shared ReadOnly Property RuleIsNotBlank() As ConditionValidationRule
			Get
				If ruleIsNotBlank_Renamed Is Nothing Then
					ruleIsNotBlank_Renamed = New ConditionValidationRule()
					ruleIsNotBlank_Renamed.ConditionOperator = ConditionOperator.IsNotBlank
					ruleIsNotBlank_Renamed.ErrorText = My.Resources.RuleIsNotBlankWarning
					ruleIsNotBlank_Renamed.ErrorType = ErrorType.Critical
				End If
				Return ruleIsNotBlank_Renamed
			End Get
		End Property
	End Class
	Public Class EditorHelper
		Public Shared Function CreateTaskStatusImageComboBox(ByVal edit As RepositoryItemImageComboBox) As RepositoryItemImageComboBox
			Dim arr As Array = System.Enum.GetValues(GetType(TaskStatus))
			edit.Items.Clear()
			For Each status As TaskStatus In arr
				edit.Items.Add(New ImageComboBoxItem(GetStringByTaskStatus(status), status, CInt(status)))
			Next status
			Return edit
		End Function
		Private Shared Function GetStringByTaskStatus(ByVal status As TaskStatus) As String
			Select Case status
				Case TaskStatus.Completed
					Return My.Resources.TaskStatusCompleted
				Case TaskStatus.Deferred
					Return My.Resources.TaskStatusDeferred
				Case TaskStatus.InProgress
					Return My.Resources.TaskStatusInProgress
				Case TaskStatus.WaitingOnSomeoneElse
					Return My.Resources.TaskStatusWaitingOnSomeoneElse
			End Select
			Return My.Resources.TaskStatusNotStarted
		End Function
		Public Shared Function CreateTaskCategoryImageComboBox(ByVal edit As RepositoryItemImageComboBox) As RepositoryItemImageComboBox
			edit.Items.Clear()
			edit.Items.Add(New ImageComboBoxItem(My.Resources.TaskCategoryHouseChores, TaskCategory.HouseChores, 0))
			edit.Items.Add(New ImageComboBoxItem(My.Resources.TaskCategoryShopping, TaskCategory.Shopping, 1))
			edit.Items.Add(New ImageComboBoxItem(My.Resources.TaskCategoryOffice, TaskCategory.Office, 2))
			Return edit
		End Function
		Public Shared Function CreateFlagStatusImageComboBox(ByVal edit As RepositoryItemImageComboBox) As RepositoryItemImageComboBox
			edit.Items.Clear()
			edit.SmallImages = CreateFlagStatusImageCollection()
			edit.GlyphAlignment = HorzAlignment.Center
			edit.Items.Add(New ImageComboBoxItem(My.Resources.Today, FlagStatus.Today, CInt(FlagStatus.Today)))
			edit.Items.Add(New ImageComboBoxItem(My.Resources.Tomorrow, FlagStatus.Tomorrow, CInt(FlagStatus.Tomorrow)))
			edit.Items.Add(New ImageComboBoxItem(My.Resources.ThisWeek, FlagStatus.ThisWeek, CInt(FlagStatus.ThisWeek)))
			edit.Items.Add(New ImageComboBoxItem(My.Resources.NextWeek, FlagStatus.NextWeek, CInt(FlagStatus.NextWeek)))
			edit.Items.Add(New ImageComboBoxItem(My.Resources.NoDate, FlagStatus.NoDate, CInt(FlagStatus.NoDate)))
			edit.Items.Add(New ImageComboBoxItem(My.Resources.Custom, FlagStatus.Custom, CInt(FlagStatus.Custom)))
			edit.Items.Add(New ImageComboBoxItem(My.Resources.Completed, FlagStatus.Completed, CInt(FlagStatus.Completed)))
			Return edit
		End Function
		Public Shared Sub InitPersonComboBox(ByVal edit As RepositoryItemImageComboBox)
			Dim iCollection As New ImageCollection()
			iCollection.AddImage(My.Resources.Mr)
			iCollection.AddImage(My.Resources.Ms)
			edit.Items.Add(New ImageComboBoxItem(My.Resources.Male, ContactGender.Male, 0))
			edit.Items.Add(New ImageComboBoxItem(My.Resources.Female, ContactGender.Female, 1))
			edit.SmallImages = iCollection
		End Sub
		Public Shared Sub InitTitleComboBox(ByVal edit As RepositoryItemImageComboBox)
			Dim iCollection As New ImageCollection()
			iCollection.AddImage(My.Resources.Doctor)
			iCollection.AddImage(My.Resources.Miss)
			iCollection.AddImage(My.Resources.Mr)
			iCollection.AddImage(My.Resources.Mrs)
			iCollection.AddImage(My.Resources.Ms)
			iCollection.AddImage(My.Resources.Professor)
			edit.Items.Add(New ImageComboBoxItem(String.Empty, ContactTitle.None, -1))
			edit.Items.Add(New ImageComboBoxItem(GetTitleNameByContactTitle(ContactTitle.Dr), ContactTitle.Dr, 0))
			edit.Items.Add(New ImageComboBoxItem(GetTitleNameByContactTitle(ContactTitle.Miss), ContactTitle.Miss, 1))
			edit.Items.Add(New ImageComboBoxItem(GetTitleNameByContactTitle(ContactTitle.Mr), ContactTitle.Mr, 2))
			edit.Items.Add(New ImageComboBoxItem(GetTitleNameByContactTitle(ContactTitle.Mrs), ContactTitle.Mrs, 3))
			edit.Items.Add(New ImageComboBoxItem(GetTitleNameByContactTitle(ContactTitle.Ms), ContactTitle.Ms, 4))
			edit.Items.Add(New ImageComboBoxItem(GetTitleNameByContactTitle(ContactTitle.Prof), ContactTitle.Prof, 5))
			edit.SmallImages = iCollection
		End Sub
		Public Shared Sub InitPriorityComboBox(ByVal edit As RepositoryItemImageComboBox)
			edit.Items.Clear()
			edit.Items.AddRange(New DevExpress.XtraEditors.Controls.ImageComboBoxItem() { New DevExpress.XtraEditors.Controls.ImageComboBoxItem(My.Resources.PriorityLow, 0, 0), New DevExpress.XtraEditors.Controls.ImageComboBoxItem(My.Resources.PriorityMedium, 1, -1), New DevExpress.XtraEditors.Controls.ImageComboBoxItem(My.Resources.PriorityHigh, 2, 1)})
		End Sub
		Public Shared Function GetTitleNameByContactTitle(ByVal title As ContactTitle) As String
			Select Case title
				Case ContactTitle.Dr
					Return My.Resources.ContactTitleDr
				Case ContactTitle.Miss
					Return My.Resources.ContactTitleMiss
				Case ContactTitle.Mr
					Return My.Resources.ContactTitleMr
				Case ContactTitle.Mrs
					Return My.Resources.ContactTitleMrs
				Case ContactTitle.Ms
					Return My.Resources.ContactTitleMs
				Case ContactTitle.Prof
					Return My.Resources.ContactTitleProf
			End Select
			Return String.Empty
		End Function
		Private Shared Function CreateFlagStatusImageCollection() As ImageCollection
			Dim ret As New ImageCollection()
			ret.AddImage(My.Resources.Today_Flag)
			ret.AddImage(My.Resources.Tomorrow_Flag)
			ret.AddImage(My.Resources.ThisWeek_Flag)
			ret.AddImage(My.Resources.NextWeek_Flag)
			ret.AddImage(My.Resources.NoDate_Flag)
			ret.AddImage(My.Resources.Custom_Flag)
			ret.AddImage(My.Resources.Completed_16x16)
			Return ret
		End Function

		Friend Shared Function GetCities() As List(Of String)
			Dim cities As IEnumerable = ( _
			    From contact In DataHelper.Contacts _
			    Select contact.City).OrderBy(Function(s) s).Distinct()
			Return cities.Cast(Of String)().ToList()
		End Function
		Friend Shared Function GetStates() As List(Of String)
			Dim states As IEnumerable = ( _
			    From contact In DataHelper.Contacts _
			    Select contact.State).OrderBy(Function(s) s).Distinct()
			Return states.Cast(Of String)().ToList()
		End Function
	End Class
	Public Class MapUtils
        Private Shared key As String = DevExpress.Map.Native.DXBingKeyVerifier.BingKeyWinProductsDemo
        Public Shared ReadOnly Property DevExpressBingKey() As String
            Get
                Return key
            End Get
        End Property

		Public Shared Function CreateBingDataProvider(ByVal kind As BingMapKind) As BingMapDataProvider
            Return New BingMapDataProvider() With {.BingKey = DevExpressBingKey, .Kind = kind}
		End Function
		Public Shared Function LoadXml(ByVal name As String) As XDocument
			Try
				Return XDocument.Load("file:\\" & DemoUtils.GetRelativePath(name))
			Catch
				Return Nothing
			End Try
		End Function
	End Class

	Public Class DemoWeatherItemFactory
		Inherits DefaultMapItemFactory

		Protected Overrides Sub InitializeItem(ByVal item As MapItem, ByVal obj As Object)
			Dim cityWeather As CityWeather = TryCast(obj, CityWeather)
			Dim element As MapCustomElement = TryCast(item, MapCustomElement)
			If element Is Nothing OrElse cityWeather Is Nothing Then
				Return
			End If
			element.ImageUri = New Uri(cityWeather.WeatherIconPath)
		End Sub
	End Class

End Namespace
