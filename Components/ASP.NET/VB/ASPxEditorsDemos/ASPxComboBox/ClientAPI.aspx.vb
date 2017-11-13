Imports Microsoft.VisualBasic
Imports System
Imports System.Data
Imports System.Web.UI
Imports DevExpress.Web
Imports System.Linq

Partial Public Class ASPxComboBox_ClientAPI
	Inherits Page
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		If (Not IsPostBack) Then
			CmbCountry.Value = "Mexico"
			FillCityCombo("Mexico")
		End If
	End Sub
	Protected Sub CmbCity_Callback(ByVal source As Object, ByVal e As CallbackEventArgsBase)
		FillCityCombo(e.Parameter)
	End Sub

	Protected Sub FillCityCombo(ByVal countryName As String)
		If String.IsNullOrEmpty(countryName) Then
			Return
		End If

		Using context = New WorldCitiesContext()
			Dim country = context.Countries.SingleOrDefault(Function(c) c.CountryName = countryName)
			CmbCity.DataSource = context.Cities.Where(Function(c) c.Country.CountryName = countryName).OrderBy(Function(c) c.CityName).ToList()
			CmbCity.DataBind()
			CmbCity.Value = country.City.CityName
		End Using
	End Sub
End Class
