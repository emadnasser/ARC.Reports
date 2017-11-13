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
Imports System.Text.RegularExpressions

Namespace DevExpress.MailClient.Win
	Public Class MyGridView
		Inherits GridView

		Protected Overrides ReadOnly Property IsAllowPixelScrollingPreview() As Boolean
			Get
				Return True
			End Get
		End Property
	End Class
	Public Class GridHelper
		Public Shared Sub GetChildDataRowHandles(ByVal view As GridView, ByVal rowHandle As Integer, ByVal list As List(Of Message))
			For i As Integer = 0 To view.GetChildRowCount(rowHandle) - 1
				Dim row As Integer = view.GetChildRowHandle(rowHandle, i)
				If row >= 0 Then
					list.Add(TryCast(view.GetRow(row), Message))
				Else
					GetChildDataRowHandles(view, row, list)
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
	End Class
	Public Class ImageHelper
		Public Shared Function GetScaleImage(ByVal image As Image, ByVal size As Size) As Bitmap
			Return New Bitmap(image, size.Width, size.Height)
		End Function
		Public Shared Function GetFaviconIconPath(ByVal link As String) As String
			link = ObjectHelper.GetCorrectUrl(link)
			Dim links() As String = link.Split("/"c)
			If links.Length > 1 Then
				Return String.Format("http://{0}/favicon.ico", links(2))
			End If
			Return Nothing
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
		Public Shared ReadOnly Property HtmlHyperLinkTextColor() As String
			Get
				Dim color As Color = EditorsSkins.GetSkin(DevExpress.LookAndFeel.UserLookAndFeel.Default).Colors.GetColor("HyperLinkTextColor")
				Return GetRGBColor(color)
			End Get
		End Property
		Public Shared ReadOnly Property HtmlHighlightTextColor() As String
			Get
				Dim color As Color = CommonSkins.GetSkin(DevExpress.LookAndFeel.UserLookAndFeel.Default).Colors.GetColor("HighlightText")
				Return GetRGBColor(color)
			End Get
		End Property
		Public Shared ReadOnly Property HtmlControlTextColor() As String
			Get
				Dim color As Color = CommonSkins.GetSkin(DevExpress.LookAndFeel.UserLookAndFeel.Default).Colors.GetColor("ControlText")
				Return GetRGBColor(color)
			End Get
		End Property
		Public Shared ReadOnly Property HtmlControlTextColor2() As String
			Get
				Dim color As Color = CommonSkins.GetSkin(DevExpress.LookAndFeel.UserLookAndFeel.Default).Colors.GetColor("WindowText")
				Return GetRGBColor(color)
			End Get
		End Property
		Public Shared ReadOnly Property HtmlQuestionColor() As String
			Get
				Dim color As Color = CommonColors.GetQuestionColor(DevExpress.LookAndFeel.UserLookAndFeel.Default)
				Return GetRGBColor(color)
			End Get
		End Property
		Public Shared ReadOnly Property HtmlWarningColor() As String
			Get
				Dim color As Color = CommonColors.GetWarningColor(DevExpress.LookAndFeel.UserLookAndFeel.Default)
				Return GetRGBColor(color)
			End Get
		End Property
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
		Private Shared rich As New RichEditDocumentServer()
		Public Shared Function GetPlainText(ByVal htmlText As String) As String
			rich.HtmlText = htmlText
			Return rich.Text.TrimStart()
		End Function
		Public Shared Sub ShowWebSite(ByVal url As String)
			If url Is Nothing Then
				Return
			End If
			Dim processName As String = GetCorrectUrl(url)
			If processName.Length = 0 Then
				Return
			End If
			StartProcess(processName)
		End Sub
		Public Shared Function GetCorrectUrl(ByVal url As String) As String
			Dim ret As String = url.Replace(" ", String.Empty)
			If ret.Length = 0 Then
				Return String.Empty
			End If
			Const protocol As String = "http://"
			Const protocol2 As String = "https://"
			If ret.IndexOf(protocol) <> 0 AndAlso ret.IndexOf(protocol2) <> 0 Then
				ret = protocol & ret
			End If
			Return ret
		End Function
		Public Shared Sub StartProcess(ByVal processName As String)
			Try
				Process.Start(processName)
			Catch ex As Exception
				XtraMessageBox.Show(ex.Message, My.Resources.Error, MessageBoxButtons.OK, MessageBoxIcon.Error)
			End Try
		End Sub
	End Class
	Public Class NavBarHelper
		Public Shared Sub DeleteEmptyGroup(ByVal nb As NavBarControl)
			For i As Integer = nb.Groups.Count - 1 To 0 Step -1
				If nb.Groups(i).ItemLinks.Count = 0 Then
					nb.Groups.RemoveAt(i)
				End If
			Next i
		End Sub
		Public Shared Function GetFirstItem(ByVal nb As NavBarControl) As NavBarItemLink
			For Each group As NavBarGroup In nb.Groups
				For Each link As NavBarItemLink In group.ItemLinks
					Return link
				Next link
			Next group
			Return Nothing
		End Function
		Public Shared Function GetGroupByName(ByVal groupName As String, ByVal navBar As NavBarControl) As NavBarGroup
			Dim group As NavBarGroup = Nothing
			For Each fGroup As NavBarGroup In navBar.Groups
				If fGroup.Name.Equals(groupName) Then
					group = fGroup
				End If
			Next fGroup
			If group Is Nothing Then
				group = New NavBarGroup(groupName)
				group.Name = groupName
				navBar.Groups.Add(group)
			End If
			Return group
		End Function
		Public Shared Sub SetNavBarItemImage(ByVal item As NavBarItem, ByVal link As String)
			Dim pe As New PictureEdit()
			pe.LoadAsync(ImageHelper.GetFaviconIconPath(link))
			pe.Tag = item
			AddHandler pe.LoadCompleted, AddressOf pe_LoadCompleted

		End Sub
		Private Shared Sub pe_LoadCompleted(ByVal sender As Object, ByVal e As EventArgs)
			Dim pe As RepositoryItemPictureEdit = TryCast(sender, RepositoryItemPictureEdit)
			Dim item As NavBarItem = TryCast(pe.OwnerEdit.Tag, NavBarItem)
			item.SmallImage = ImageHelper.GetScaleImage(CType(pe.OwnerEdit, PictureEdit).Image, New Size(16, 16))
			pe.OwnerEdit.Dispose()
			pe.Dispose()
		End Sub
		Public Shared Function GetGroupNames(ByVal navBar As NavBarControl) As Object()
			Dim ret As New List(Of String)()
			For Each group As NavBarGroup In navBar.Groups
				ret.Add(group.Caption)
			Next group
			Return ret.ToArray()
		End Function
		Public Shared Function GetItemNames(ByVal navBar As NavBarControl) As List(Of String)
			Dim ret As New List(Of String)()
			For Each item As NavBarItem In navBar.Items
				ret.Add(item.Caption)
			Next item
			Return ret
		End Function

		Public Shared Function GetUniqueItemName(ByVal name As String, ByVal navBar As NavBarControl) As String
			Dim names As List(Of String) = GetItemNames(navBar)
			For i As Integer = 1 To 9998
				Dim ret As String = String.Format("{0}{1}", name, i)
				If Not names.Contains(ret) Then
					Return ret
				End If
			Next i
			Return String.Empty

		End Function
	End Class
	Public Class UniqueNameValidationRule
		Inherits ValidationRule

		Private values As List(Of String)
		Public Sub New(ByVal values As List(Of String))
			Me.values = values
		End Sub
		Public Overrides Function Validate(ByVal control As Control, ByVal value As Object) As Boolean
			Dim str As String = CStr(value)
			For Each val As String In values
				If Not ValidationHelper.Validate(str, ConditionOperator.NotEquals, val, Nothing, Nothing, False) Then
					Return False
				End If
			Next val
			Return True
		End Function
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
		Public Shared Sub InitPriorityComboBox(ByVal edit As RepositoryItemImageComboBox)
			edit.Items.Clear()
			edit.Items.AddRange(New DevExpress.XtraEditors.Controls.ImageComboBoxItem() { New DevExpress.XtraEditors.Controls.ImageComboBoxItem(My.Resources.PriorityLow, 0, 0), New DevExpress.XtraEditors.Controls.ImageComboBoxItem(My.Resources.PriorityMedium, 1, -1), New DevExpress.XtraEditors.Controls.ImageComboBoxItem(My.Resources.PriorityHigh, 2, 1)})
		End Sub
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
	Public Class DictionaryHelper
		Public Shared Sub InitDictionary(ByVal spellChecker As SpellChecker)
			If LocalizationHelper.IsJapanese Then
				spellChecker.SpellCheckMode = SpellCheckMode.OnDemand
			End If
			If spellChecker.Dictionaries.Count > 0 Then
				Return
			End If
			spellChecker.Dictionaries.Add(GetDefaultDictionary())
		End Sub
		Private Shared Function GetDefaultDictionary() As ISpellCheckerDictionary
			Dim dic As New SpellCheckerISpellDictionary()
            Dim zipFileStream As Stream = System.Reflection.Assembly.GetExecutingAssembly().GetManifestResourceStream("default.zip")
			Dim files As InternalZipFileCollection = InternalZipArchive.Open(zipFileStream)
			Dim alphabetStream As Stream = GetFileStream(files, "EnglishAlphabet.txt")
			Dim dictionaryStream As Stream = GetFileStream(files, "american.xlg")
			Dim grammarStream As Stream = GetFileStream(files, "english.aff")
			Try
				dic.LoadFromStream(dictionaryStream, grammarStream, alphabetStream)
			Catch
			Finally
				dictionaryStream.Dispose()
				grammarStream.Dispose()
				zipFileStream.Dispose()
				alphabetStream.Dispose()
				DisposeZipFileStreams(files)
			End Try
			dic.Culture = New CultureInfo("en-US")
			Return dic
		End Function
		Private Shared Function GetFileStream(ByVal files As InternalZipFileCollection, ByVal name As String) As Stream
			Dim stream As Stream = files.Find(Function(file As InternalZipFile) file.FileName.IndexOf(name) >= 0).FileDataStream
			Try
				Return CreateMemoryStream(stream)
			Finally
				stream.Close()
			End Try
		End Function
		Private Shared Function CreateMemoryStream(ByVal stream As Stream) As Stream
			Dim result As New MemoryStream()
			Do
				Dim readedByte As Integer = stream.ReadByte()
				If readedByte < 0 Then
					Exit Do
				End If
				result.WriteByte(CByte(readedByte))
			Loop
			result.Flush()
			result.Seek(0, SeekOrigin.Begin)
			Return result
		End Function
		Private Shared Sub DisposeZipFileStreams(ByVal files As InternalZipFileCollection)
			For Each file As InternalZipFile In files
				file.FileDataStream.Dispose()
			Next file
		End Sub
    End Class
    Public Class TokenEditHelper
        Public Shared Sub InitializeHistory(ByVal tokenEdit As TokenEdit)
            For Each contact As Contact In DataHelper.Contacts
                Dim item As New TokenEditToken(contact.Email, contact)
                tokenEdit.Properties.Tokens.Add(item)
            Next contact
        End Sub
        Public Shared Function GetValue(ByVal value As String) As String
            If String.IsNullOrEmpty(value) Then
                Return Nothing
            End If
            Dim builder As New StringBuilder()
            For Each name As String In value.Split(","c)
                builder.Append(GetEmailAddress(name.Trim()))
                builder.Append(", ")
            Next name
            Return builder.ToString()
        End Function
        Shared Function GetEmailAddress(ByVal value As String) As String
            If TextHelper.IsMailAddressValid(value) Then
                Return value
            End If
            Dim contact As Contact = DataHelper.FindByName(value)
            If contact IsNot Nothing Then
                Return contact.Email
            End If
            Return FormatEmail(value)
        End Function
        Shared Function FormatEmail(ByVal value As String) As String
            Dim builder As New StringBuilder(value)
            builder.Replace(" (", "_")
            builder.Replace(")"c, "_"c)
            builder.Replace(" "c, "_"c)
            builder.Replace("-"c, "_"c)
            builder.Append("@dxmail.net")
            Return builder.ToString()
        End Function
    End Class
    Public Class TextHelper
        Public Shared Function IsMailAddressValid(ByVal mailAddress As String) As Boolean
            Return MailRegex.IsMatch(mailAddress)
        End Function
        Private Shared MailRegex As New Regex("\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*", RegexOptions.Compiled)
    End Class
End Namespace
