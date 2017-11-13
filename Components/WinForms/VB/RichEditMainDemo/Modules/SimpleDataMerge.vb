Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports DevExpress.XtraRichEdit.Demos.Forms
Imports DevExpress.XtraRichEdit.API.Native
Imports DevExpress.XtraBars

Namespace DevExpress.XtraRichEdit.Demos
	Partial Public Class SimpleDataMergeModule
		Inherits MergeModuleBase
		#Region "Fields"
		Private employees As List(Of Employee)
		Private mergeFieldsNamesInfo() As MergeFieldNameInfo
		#End Region

		Public Sub New()
			InitializeComponent()
			Me.employees = GenerateEmployeeList()
			Me.dataNavigator.DataSource = employees
			Me.sourceRichEditControl_Renamed.Options.MailMerge.DataSource = employees
			Me.mergeFieldsNamesInfo = CreateMergeFieldsNamesInfo()
			RtfLoadHelper.Load("MailMergeSimple.rtf", sourceRichEditControl_Renamed)
			CType(New RichEditDemoExceptionsHandler(sourceRichEditControl_Renamed), RichEditDemoExceptionsHandler).Install()
		End Sub

		Protected Overrides ReadOnly Property SourceRichEditControl() As RichEditControl
			Get
				Return sourceRichEditControl_Renamed
			End Get
		End Property

		#Region "MergeFieldNamesInfo generation"
		Protected Friend Overridable Function CreateMergeFieldsNamesInfo() As MergeFieldNameInfo()
			Dim result As New List(Of MergeFieldNameInfo)()
			result.Add(CreateMergeFieldNameInfo("FirstName"))
			result.Add(CreateMergeFieldNameInfo("LastName"))
			result.Add(CreateMergeFieldNameInfo("HiringDate"))
			result.Add(CreateMergeFieldNameInfo("Address"))
			result.Add(CreateMergeFieldNameInfo("City"))
			result.Add(CreateMergeFieldNameInfo("Country"))
			result.Add(CreateMergeFieldNameInfo("Position"))
			result.Add(CreateMergeFieldNameInfo("CompanyName"))
			result.Add(CreateMergeFieldNameInfo("Gender"))
			result.Add(CreateMergeFieldNameInfo("Phone"))
			result.Add(CreateMergeFieldNameInfo("HRManagerName"))

			Return result.ToArray()
		End Function
		Private Function CreateMergeFieldNameInfo(ByVal fieldName As String) As MergeFieldNameInfo
			Dim displayName As String = CreateDisplayName(fieldName)
			Return New MergeFieldNameInfo(New MergeFieldName(fieldName, displayName))
		End Function
		Private Function CreateDisplayName(ByVal fieldName As String) As String
			fieldName = fieldName.Replace("_"c, " "c)
			fieldName = fieldName.Replace("."c, " "c)

			Dim prevChar As Char = " "c
			Dim count As Integer = fieldName.Length
			Dim sb As New System.Text.StringBuilder(count)
			For i As Integer = 0 To count - 1
				Dim ch As Char = fieldName.Chars(i)
				If Char.IsLower(prevChar) AndAlso Char.IsUpper(ch) Then
					sb.Append(" "c)
				End If
				sb.Append(ch)
				prevChar = ch
			Next i
			Return sb.ToString()
		End Function
		#End Region

		Protected Overrides Sub CalculateMailMergeOptions(ByVal form As MergeFieldsFormBase, ByVal options As MailMergeOptions)
			If form.MergeRecords = MergeRecords.FromInterval Then
				options.FirstRecordIndex = Math.Max(0, (CType(form, MergeSimpleDataForm)).StartIndex - 1)
				options.LastRecordIndex = Math.Min(employees.Count - 1, (CType(form, MergeSimpleDataForm)).EndIndex - 1)
			ElseIf form.MergeRecords = MergeRecords.Current Then
				options.FirstRecordIndex = dataNavigator.Position
				options.LastRecordIndex = dataNavigator.Position
			End If
		End Sub
		Protected Overrides Function CreateMergeFieldForm() As MergeFieldsFormBase
			Return New MergeSimpleDataForm()
		End Function

		Private Sub mergeToNewDocumentClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles mergeToNewDocumentItem.ItemClick
			MergeToNewDocument()
		End Sub

        Private Sub sourceRichEditControl_DocumentLoaded(ByVal sender As Object, ByVal e As EventArgs) Handles sourceRichEditControl_Renamed.DocumentLoaded
            Me.sourceRichEditControl_Renamed.Document.Fields.Update()
        End Sub

        Private Sub sourceRichEditControl_CustomizeMergeFields(ByVal sender As Object, ByVal e As CustomizeMergeFieldsEventArgs) Handles sourceRichEditControl_Renamed.CustomizeMergeFields
            e.MergeFieldsNames = CalculateAllowedFieldsNames()
        End Sub
		Private Function CalculateAllowedFieldsNames() As MergeFieldName()
			Dim result As New List(Of MergeFieldName)()
			For Each fieldNameInfo As MergeFieldNameInfo In mergeFieldsNamesInfo
				If fieldNameInfo.CanShow Then
					Dim fieldName As MergeFieldName = fieldNameInfo.FieldName
					Dim displayName As String = String.Format("{0} ({1})", fieldName.DisplayName, fieldName.Name)
					result.Add(New MergeFieldName(fieldName.Name, displayName))
				End If
			Next fieldNameInfo
			Return result.ToArray()
		End Function
		Private Sub barButtonItem3_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs) Handles customizeMergeFieldsItem1.ItemClick
			Dim form As New CustomizeMergeFieldsForm(mergeFieldsNamesInfo)
			form.ShowDialog(Me)
		End Sub
	End Class
	Public Class Employee
		Private firstName_Renamed As String
		Private lastName_Renamed As String
		Private hiringDate_Renamed As DateTime
		Private address_Renamed As String
		Private city_Renamed As String
		Private country_Renamed As String
		Private position_Renamed As String
		Private companyName_Renamed As String
		Private gender_Renamed As Char
		Private phone_Renamed As String
		Private hrManagerName_Renamed As String

		Public Property FirstName() As String
			Get
				Return firstName_Renamed
			End Get
			Set(ByVal value As String)
				firstName_Renamed = value
			End Set
		End Property
		Public Property LastName() As String
			Get
				Return lastName_Renamed
			End Get
			Set(ByVal value As String)
				lastName_Renamed = value
			End Set
		End Property
		Public Property HiringDate() As DateTime
			Get
				Return hiringDate_Renamed
			End Get
			Set(ByVal value As DateTime)
				hiringDate_Renamed = value
			End Set
		End Property
		Public Property Address() As String
			Get
				Return address_Renamed
			End Get
			Set(ByVal value As String)
				address_Renamed = value
			End Set
		End Property
		Public Property City() As String
			Get
				Return city_Renamed
			End Get
			Set(ByVal value As String)
				city_Renamed = value
			End Set
		End Property
		Public Property Country() As String
			Get
				Return country_Renamed
			End Get
			Set(ByVal value As String)
				country_Renamed = value
			End Set
		End Property
		Public Property Position() As String
			Get
				Return position_Renamed
			End Get
			Set(ByVal value As String)
				position_Renamed = value
			End Set
		End Property
		Public Property CompanyName() As String
			Get
				Return companyName_Renamed
			End Get
			Set(ByVal value As String)
				companyName_Renamed = value
			End Set
		End Property
		Public Property Gender() As Char
			Get
				Return gender_Renamed
			End Get
			Set(ByVal value As Char)
				gender_Renamed = value
			End Set
		End Property
		Public Property Phone() As String
			Get
				Return phone_Renamed
			End Get
			Set(ByVal value As String)
				phone_Renamed = value
			End Set
		End Property
		Public Property HRManagerName() As String
			Get
				Return hrManagerName_Renamed
			End Get
			Set(ByVal value As String)
				hrManagerName_Renamed = value
			End Set
		End Property
	End Class
	Public Class MergeFieldNameInfo
		#Region "Fields"
		Private fieldName_Renamed As MergeFieldName
		Private canShow_Renamed As Boolean
		#End Region

		Public Sub New(ByVal fieldName As MergeFieldName)
			Me.fieldName_Renamed = fieldName
			Me.canShow_Renamed = True
		End Sub

		#Region "Properties"
		Public ReadOnly Property FieldName() As MergeFieldName
			Get
				Return fieldName_Renamed
			End Get
		End Property
		Public Property CanShow() As Boolean
			Get
				Return canShow_Renamed
			End Get
			Set(ByVal value As Boolean)
				canShow_Renamed = value
			End Set
		End Property
		#End Region
	End Class
End Namespace
