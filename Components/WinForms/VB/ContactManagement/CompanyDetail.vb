Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports DevExpress.Xpo

Namespace ContactManagement
	Public Partial Class CompanyDetail
		Inherits System.Windows.Forms.Form
		Private Sub SetupBindings()
			txtOID.DataBindings.Add("Text", theCompany, "Oid")
			txtName.DataBindings.Add("Text", theCompany, "Name")
			txtWebSite.DataBindings.Add("Text", theCompany, "WebSite")
			txtPhoneNumber.DataBindings.Add("Text", theCompany, "PhoneNumber")
			txtCreatedOn.DataBindings.Add("Text", theCompany, "CreatedOn")
		End Sub

		Public Property Company() As Company
			Get
				Return theCompany
			End Get
			Set
				theCompany = Value
				SetupBindings()
			End Set
		End Property

		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub btnSave_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSave.Click
			theCompany.Save()
		End Sub
	End Class
End Namespace
