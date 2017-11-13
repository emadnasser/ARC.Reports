Imports Microsoft.VisualBasic
Imports System.Collections
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Linq
Imports System.Web
Imports System.Web.UI

Public Class HomesDataProvider
	Private Const HomesDataFile As String = "~/App_Data/Homes.xml"

	Private Shared Property Homes() As DataSet
	Private Shared ReadOnly Property Server() As HttpServerUtility
		Get
			Return HttpContext.Current.Server
		End Get
	End Property

	Public Shared Function GetHomes() As DataSet
		If Homes Is Nothing Then
			Homes = New DataSet()
			Homes.ReadXml(Server.MapPath(HomesDataFile))
		End If
		Return Homes
	End Function
End Class
