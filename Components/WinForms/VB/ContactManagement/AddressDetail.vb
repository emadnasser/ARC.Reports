Imports Microsoft.VisualBasic
Imports System
Imports System.IO
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports DevExpress.Xpo

Namespace ContactManagement
	''' <summary>
	''' Summary description for AddressDetail.
	''' </summary>
	Public Partial Class AddressDetail
		Inherits System.Windows.Forms.Form
		Private Sub SetupBindings()
			txtOID.DataBindings.Add("Text", theAddress, "Oid")
			txtOwner.DataBindings.Add("Text", theAddress.Owner, "DisplayName")
			txtCity.DataBindings.Add("Text", theAddress, "City")
			txtStreet.DataBindings.Add("Text", theAddress, "Street")
			chkDefault.DataBindings.Add("Checked", theAddress, "IsDefault")
		End Sub

		Public Sub New()
			'
			' Required for Windows Form Designer support
			'
			InitializeComponent()

			'
			' TODO: Add any constructor code after InitializeComponent call
			'
		End Sub

		Public WriteOnly Property Address() As Address
			Set
				theAddress = Value
				SetupBindings()
			End Set
		End Property

		Private Sub btnSave_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSave.Click
			If chkDefault.Checked Then
				theAddress.Owner.DefaultAddress = theAddress
			End If
			theAddress.Save()
		End Sub
	End Class
End Namespace
