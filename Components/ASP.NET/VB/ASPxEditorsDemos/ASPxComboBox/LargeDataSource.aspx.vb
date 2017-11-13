Imports Microsoft.VisualBasic
Imports System
Imports System.Web.UI
Imports DevExpress.Web
Imports DevExpress.Web.Demos

Partial Public Class ASPxComboBox_LargeDataSource
	Inherits Page
	Shared Sub New()
		PersonDataGenerator.Register()
	End Sub

	Private _databaseReady? As Boolean
	Private ReadOnly Property DatabaseReady() As Boolean
		Get
			If (Not _databaseReady.HasValue) Then
				_databaseReady = DatabaseGenerator.IsReady(CreateDatabaseControl.TableKey)
			End If
			Return _databaseReady.Value
		End Get
	End Property

	Protected Sub Page_Init(ByVal sender As Object, ByVal e As EventArgs)
		SqlDataSource1.ConnectionString = PersonDataGenerator.Table.ConnectionString
		CreateDatabaseControl.Visible = Not DatabaseReady
		Demo.Visible = DatabaseReady
	End Sub

	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		If DatabaseReady AndAlso (Not IsPostBack) Then
			ASPxComboBox1.Focus()
		End If
	End Sub

	Protected Sub ASPxComboBox_OnItemsRequestedByFilterCondition_SQL(ByVal source As Object, ByVal e As ListEditItemsRequestedByFilterConditionEventArgs)
		Dim comboBox As ASPxComboBox = CType(source, ASPxComboBox)
		SqlDataSource1.SelectCommand = "SELECT [ID], [Phone], [FirstName], [LastName] FROM (select [ID], [Phone], [FirstName], [LastName], row_number()over(order by t.[LastName]) as [rn] from [Persons]  as t where (([FirstName] + ' ' + [LastName] + ' ' + [Phone]) LIKE @filter)) as st where st.[rn] between @startIndex and @endIndex"

		SqlDataSource1.SelectParameters.Clear()
		SqlDataSource1.SelectParameters.Add("filter", TypeCode.String, String.Format("%{0}%", e.Filter))
		SqlDataSource1.SelectParameters.Add("startIndex", TypeCode.Int64, (e.BeginIndex + 1).ToString())
		SqlDataSource1.SelectParameters.Add("endIndex", TypeCode.Int64, (e.EndIndex + 1).ToString())
		comboBox.DataSource = SqlDataSource1
		comboBox.DataBind()
	End Sub

	Protected Sub ASPxComboBox_OnItemRequestedByValue_SQL(ByVal source As Object, ByVal e As ListEditItemRequestedByValueEventArgs)
		Dim value As Long = 0
		If e.Value Is Nothing OrElse (Not Int64.TryParse(e.Value.ToString(), value)) Then
			Return
		End If
		Dim comboBox As ASPxComboBox = CType(source, ASPxComboBox)
		SqlDataSource1.SelectCommand = "SELECT ID, LastName, [Phone], FirstName FROM Persons WHERE (ID = @ID) ORDER BY FirstName"

		SqlDataSource1.SelectParameters.Clear()
		SqlDataSource1.SelectParameters.Add("ID", TypeCode.Int64, e.Value.ToString())
		comboBox.DataSource = SqlDataSource1
		comboBox.DataBind()
	End Sub

	  Protected Sub FilterMinLengthSpinEdit_ValueChanged(ByVal sender As Object, ByVal e As EventArgs)
		ASPxComboBox1.FilterMinLength = CInt(Fix((CType(sender, ASPxSpinEdit)).Number))
	  End Sub

	Private ReadOnly Property SectionParameter() As String
		Get
			Return Page.Request.QueryString("Section")
		End Get
	End Property
End Class
