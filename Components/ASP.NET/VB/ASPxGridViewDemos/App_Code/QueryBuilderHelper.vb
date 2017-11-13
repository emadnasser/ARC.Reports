Imports Microsoft.VisualBasic
Imports DevExpress.DataAccess.ConnectionParameters
Imports DevExpress.DataAccess.Sql
Imports System.Configuration
Imports System.Web.SessionState

Public NotInheritable Class QueryBuilderHelper

	Private Shared ReadOnly ShowTooltipKey As String = "ShowTooltip"
	Private Shared ReadOnly SelectQueryKey As String = "SelectQuery"
	Private Shared ReadOnly SelectCommandKey As String = "SelectCommand"
	Private Shared ReadOnly DefaultSelectCommand As String = "select [Suppliers].[CompanyName],[Suppliers].[ContactName],[Suppliers].[City]," & ControlChars.CrLf & "		[Suppliers].[Country],[Products].[ProductName],[Products].[UnitPrice]" & ControlChars.CrLf & "from [dbo].[Suppliers] [Suppliers]" & ControlChars.CrLf & "inner join [dbo].[Products] [Products] on [Products].[SupplierID] = [Suppliers].[SupplierID]"

	Private Sub New()
	End Sub
	Private Shared Function GenerateDefaultQuery() As SelectQuery
		Return SelectQueryFluentBuilder.AddTable("Suppliers").SelectColumns("CompanyName", "ContactName", "City", "Country").Join("Products", DevExpress.Xpo.DB.JoinType.LeftOuter, "SupplierID", "SupplierID").SelectColumns("ProductName", "UnitPrice").Build("Query1")
	End Function

	Public Shared ReadOnly Property NorthwindConnectionString() As String
		Get
			Dim sqlExpressString As String = ConfigurationManager.ConnectionStrings("NorthwindConnectionString").ConnectionString
			Return DevExpress.Internal.DbEngineDetector.PatchConnectionString(sqlExpressString)
		End Get
	End Property

	Public Shared ReadOnly Property NorthwindConnectionParameters() As CustomStringConnectionParameters
		Get
			Return New CustomStringConnectionParameters(NorthwindConnectionString & ";XpoProvider=MSSqlServer")
		End Get
	End Property

	Public Shared Function LoadQuery(ByVal session As HttpSessionState) As SelectQuery
		Return If((TryCast(session(SelectQueryKey), SelectQuery)), GenerateDefaultQuery())
	End Function

	Public Shared Function LoadSelectCommand(ByVal session As HttpSessionState) As String
		Return If((TryCast(session(SelectCommandKey), String)), DefaultSelectCommand)
	End Function

	Public Shared Sub SaveQuery(ByVal selectCommand As String, ByVal query As SelectQuery, ByVal session As HttpSessionState)
		session(SelectQueryKey) = query
		session(SelectCommandKey) = selectCommand
	End Sub

	Public Shared Sub HideTooltip(ByVal session As HttpSessionState)
		session(ShowTooltipKey) = False
	End Sub
	Public Shared Function NeedToShowTooltip(ByVal session As HttpSessionState) As Boolean
		Dim showTooltipValue = session(ShowTooltipKey)
		Return If(TypeOf showTooltipValue Is Boolean, CBool(showTooltipValue), True)
	End Function
End Class
