Imports Microsoft.VisualBasic
Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.Skins
Imports DevExpress.XtraLayout.Utils
Imports DevExpress.Xpo
Imports DevExpress.Xpo.DB
Imports DevExpress.Xpo.Metadata
Imports DevExpress.XtraEditors
Namespace DevExpress.XtraLayout.Demos
	Public Partial Class UserDetailsEditViewForm
		Inherits TutorialControl
		Protected isEditing As Boolean = False
		Public Sub New()
            XpoDefault.DataLayer = New SimpleDataLayer(New InMemoryDataStore(AutoCreateOption.DatabaseAndSchema))
			XpoDefault.Session.Delete(New XPCollection(GetType(DBObjects.Employees)))
			CreatePersons()
			InitializeComponent()
		End Sub
		Public Shared Sub CreatePersons()
			Dim emploee As DBObjects.Employees
			emploee = New DBObjects.Employees(XpoDefault.Session)
			emploee.Title = "Ms."
			emploee.FirstName = "Nancy"
			emploee.LastName = "Davolio"
			emploee.Notes = "Education includes a BA in psychology from Colorado State University in 1970.  She also completed The Art of the Cold Call.  Nancy is a member of Toastmasters International."
			emploee.Address = "507 - 20th Ave. E. Apt. 2A"
			emploee.Country = "USA"
			emploee.City = "Seattle"
			emploee.Save()

			emploee = New DBObjects.Employees(XpoDefault.Session)
			emploee.Title = "Dr."
			emploee.FirstName = "Andrew"
			emploee.LastName = "Fuller"
			emploee.Notes = "Andrew received his BTS commercial in 1974 and a Ph.D. in international marketing from the University of Dallas in 1981.  He is fluent in French and Italian and reads German.  He joined the company as a sales representative, was promoted to sales manager in January 1992 and to vice president of sales in March 1993.  Andrew is a member of the Sales Management Roundtable, the Seattle Chamber of Commerce, and the Pacific Rim Importers Association."
			emploee.Address = "908 W. Capital Way"
			emploee.Country = "USA"
			emploee.City = "Tacoma"
			emploee.HomePhone = "(206) 555-9482"
			emploee.Region = "WA"
			emploee.PostalCode = "98401"
			emploee.Save()

			emploee = New DBObjects.Employees(XpoDefault.Session)
			emploee.Title = "Ms."
			emploee.FirstName = "Janet"
			emploee.LastName = "Leverling"
			emploee.Notes = "Janet has a BS degree in chemistry from Boston College (1984).  She has also completed a certificate program in food retailing management.  Janet was hired as a sales associate in 1991 and promoted to sales representative in February 1992."
			emploee.City = "Kirkland"

			emploee = New DBObjects.Employees(XpoDefault.Session)
			emploee.Title = "Mr."
			emploee.FirstName = "John"
			emploee.LastName = "Doe"
			emploee.Save()

		End Sub
		Protected Overrides Sub OnLoad(ByVal e As EventArgs)
			MyBase.OnLoad(e)
			If Not Site Is Nothing AndAlso Site.DesignMode Then
			Return
			End If
			UpdateItemsVisibility()
		End Sub
		Private Sub dataLayoutControl1_CurrentRecordChanged(ByVal sender As Object, ByVal e As EventArgs) Handles dataLayoutControl1.CurrentRecordChanged
			UpdateItemsVisibility()
		End Sub
		Protected Sub UpdateItemsVisibility()
			If (Not dataLayoutControl1.IsInitialized) Then
			Return
			End If
			dataLayoutControl1.BeginUpdate()
			Try
				For Each item As BaseLayoutItem In dataLayoutControl1.Items
					Dim lci As LayoutControlItem = TryCast(item, LayoutControlItem)
					If Not lci Is Nothing AndAlso Not lci.Control Is Nothing Then
						If lci.Control.DataBindings.Count > 0 Then
							Dim be As BaseEdit = TryCast(lci.Control, BaseEdit)
							If Not be Is Nothing Then
                                Dim str As String = be.Properties.GetDisplayText(be.EditValue)
								be.Properties.ReadOnly = Not isEditing
								If isEditing Then
								lci.Visibility = LayoutVisibility.Always
								Else
									If be.EditValue Is Nothing OrElse str Is Nothing OrElse str = String.Empty Then
										lci.Visibility = LayoutVisibility.OnlyInCustomization
									Else
										lci.Visibility = LayoutVisibility.Always
									End If
								End If
							End If
						End If
					End If
				Next item
			Finally
				dataLayoutControl1.EndUpdate()
			End Try
		End Sub
		Private Sub simpleButton2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles simpleButton2.Click
			isEditing = Not isEditing
			If isEditing Then
			simpleButton2.Text = "View Data"
			Else
				simpleButton2.Text = "Edit Data"
			End If
			UpdateItemsVisibility()
		End Sub
	End Class
End Namespace
