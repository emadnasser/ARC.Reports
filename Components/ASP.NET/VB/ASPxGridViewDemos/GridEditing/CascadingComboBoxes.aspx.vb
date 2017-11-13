Imports Microsoft.VisualBasic
Imports System
Imports System.Data
Imports System.Collections.Generic
Imports System.Web.UI
Imports System.Linq
Imports DevExpress.Web


Partial Public Class GridEditing_CascadingComboBoxes
	Inherits Page
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		If (Not IsPostBack) Then
			grid.StartEdit(3)
		End If
	End Sub

	Protected Sub grid_CellEditorInitialize(ByVal sender As Object, ByVal e As ASPxGridViewEditorEventArgs)
		If (Not grid.IsEditing) OrElse e.Column.FieldName <> "City" Then
			Return
		End If
		If e.KeyValue Is DBNull.Value OrElse e.KeyValue Is Nothing Then
			Return
		End If
		Dim val As Object = grid.GetRowValuesByKeyValue(e.KeyValue, "Country")
		If val Is DBNull.Value Then
			Return
		End If
		Dim country As String = CStr(val)

		Dim combo As ASPxComboBox = TryCast(e.Editor, ASPxComboBox)
		FillCityCombo(combo, country)

		AddHandler combo.Callback, AddressOf cmbCity_OnCallback
	End Sub

	Protected Sub FillCityCombo(ByVal cmb As ASPxComboBox, ByVal country As String)
		If String.IsNullOrEmpty(country) Then
			Return
		End If

		Dim cities As List(Of String) = GetCities(country)
		cmb.Items.Clear()
		For Each city As String In cities
			cmb.Items.Add(city)
		Next city
	End Sub
	Private Function GetCities(ByVal country As String) As List(Of String)
		Using context = New WorldCitiesContext()
			Return context.Cities.Where(Function(c) c.Country.CountryName = country).OrderBy(Function(c) c.CityName).Select(Function(c) c.CityName).ToList()
		End Using
	End Function

	Private Sub cmbCity_OnCallback(ByVal source As Object, ByVal e As CallbackEventArgsBase)
		FillCityCombo(TryCast(source, ASPxComboBox), e.Parameter)
	End Sub
End Class
