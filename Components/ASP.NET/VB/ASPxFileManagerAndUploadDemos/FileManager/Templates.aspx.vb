Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports DevExpress.Web

Partial Public Class FileManager_Templates
	Inherits System.Web.UI.Page
	Private extensionsDisplayName_Renamed As Dictionary(Of String, String)

	Private ReadOnly Property ExtensionsDisplayName() As Dictionary(Of String, String)
		Get
			If extensionsDisplayName_Renamed Is Nothing Then
				extensionsDisplayName_Renamed = System.Xml.Linq.XDocument.Load(MapPath("~/Content/FileManager/ExtensionsDisplayName.xml")).Descendants("Extension").ToDictionary(Function(n) n.Attribute("Extension").Value, Function(n) n.Attribute("DisplayName").Value)
			End If
			Return extensionsDisplayName_Renamed
		End Get
	End Property

	Public Function GetFileType(ByVal file As FileManagerFile) As String
		Return ExtensionsDisplayName(file.Extension)
	End Function
	Public Function GetSize(ByVal file As FileManagerFile) As String
		Return file.Length / 1024 & " Kb"
	End Function
End Class
