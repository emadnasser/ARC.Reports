Imports Microsoft.VisualBasic
Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing
Imports System.Data
Imports System.Windows.Forms
Imports System.Data.OleDb
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.DXErrorProvider


Namespace DevExpress.XtraLayout.Demos
	''' <summary>
	''' Summary description for Employees.
	''' </summary>
	Public Partial Class Validating
		Inherits DevExpress.XtraLayout.Demos.TutorialControl
		Public Sub New()
			' This call is required by the Windows.Forms Form Designer.
			CreateWaitDialog()
			InitializeComponent()
			layoutControl1.SetDefaultLayout()
			InitData()
			' TODO: Add any initialization after the InitForm call
		End Sub
        Protected Overrides Sub OnVisibleChanged(ByVal sender As Object, ByVal e As System.EventArgs)
            If Me.Visible Then
                InitFields()
                ValidateFields()
            End If
            MyBase.OnVisibleChanged(sender, e)
        End Sub
        Private Sub InitData()
            Dim DBFileName As String = DevExpress.Utils.FilesHelper.FindingFileName(Application.StartupPath, "Data\nwind.mdb")
            If DBFileName <> "" Then
                Dim con As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & DBFileName
                Dim oleDBAdapter1 As OleDbDataAdapter = New OleDbDataAdapter("SELECT * FROM Categories", con)
                Dim oleDBAdapter2 As OleDbDataAdapter = New OleDbDataAdapter("SELECT * FROM Products", con)
                Dim oleDBAdapter3 As OleDbDataAdapter = New OleDbDataAdapter("SELECT * FROM [Order Details]", con)
                Dim oleDBAdapter4 As OleDbDataAdapter = New OleDbDataAdapter("SELECT * FROM Suppliers", con)

                SetWaitDialogCaption("Loading Categories...")
                oleDBAdapter1.Fill(dsCategories1.Categories)

                SetWaitDialogCaption("Loading Products...")
                oleDBAdapter2.Fill(dsCategories1.Products)

                SetWaitDialogCaption("Loading Order Details...")
                oleDBAdapter3.Fill(dsCategories1.Order_Details)

                SetWaitDialogCaption("Loading Suppliers...")
                oleDBAdapter4.Fill(dsCategories1.Suppliers)
            End If
        End Sub
		Private Sub InitFields()
			productNameTextEdit.Text = ""
			unitsInStockSpinEdit.EditValue = -1
			reorderLevelSpinEdit.EditValue = -1
			discountSpinEdit.EditValue = 0.60D
		End Sub
		Private Sub ValidateFields()
			Validate_EmptyStringRule(productNameTextEdit)
			Validate_LessThanMinRule(productsUnitPriceCalcEdit, Decimal.Zero)
			Validate_LessThanMinRule(orderUnitPriceCalcEdit, Decimal.Zero)
			Validate_LessThanMinRule(quantitySpinEdit, Decimal.Zero)
			Validate_LessThanMinRule(unitsInStockSpinEdit, Decimal.Zero)
			Validate_LessThanMinRule(reorderLevelSpinEdit, Decimal.Zero)
			Validate_LessThanMinRule(unitsOnOrderSpinEdit, Decimal.Zero)
			Validate_BetweenMinAndMaxRule(discountSpinEdit, Decimal.Zero, 0.5D)
		End Sub
		Private Sub checkEdit1_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles checkEdit1.CheckedChanged
			layoutControl1.BeginUpdate()
			unitsOnOrderSpinEdit.Enabled = Not checkEdit1.Checked
			reorderLevelSpinEdit.Enabled = unitsOnOrderSpinEdit.Enabled
			unitsInStockSpinEdit.Enabled = reorderLevelSpinEdit.Enabled
			productsUnitPriceCalcEdit.Enabled = unitsInStockSpinEdit.Enabled
			supplierLookUpEdit.Enabled = productsUnitPriceCalcEdit.Enabled
			quantityPerUnitTextEdit.Enabled = supplierLookUpEdit.Enabled
			productNameTextEdit.Enabled = quantityPerUnitTextEdit.Enabled
			layoutControl1.EndUpdate()
		End Sub
		Private Sub Detail_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles discountSpinEdit.Validated, orderUnitPriceCalcEdit.Validated, quantitySpinEdit.Validated
			CType(Me.BindingContext(Me.dataNavigator3.DataSource, Me.dataNavigator3.DataMember), CurrencyManager).EndCurrentEdit()
		End Sub
		Private Sub productNameTextEdit_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles productNameTextEdit.Validating
			Validate_EmptyStringRule(TryCast(sender, BaseEdit))
		End Sub
		Private Sub unitPriceCalcEdit_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles orderUnitPriceCalcEdit.Validating, productsUnitPriceCalcEdit.Validating
			Validate_LessThanMinRule(TryCast(sender, BaseEdit), Decimal.Zero)
		End Sub
		Private Sub quantitySpinEdit_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles unitsOnOrderSpinEdit.Validating, unitsInStockSpinEdit.Validating, reorderLevelSpinEdit.Validating, quantitySpinEdit.Validating
			Validate_LessThanMinRule(TryCast(sender, BaseEdit), Decimal.Zero)
		End Sub
		Private Sub discountSpinEdit_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles discountSpinEdit.Validating
			Validate_BetweenMinAndMaxRule(TryCast(sender, BaseEdit), Decimal.Zero, 0.50D)
        End Sub
        Private Sub dataNavigator3_PositionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dataNavigator2.PositionChanged, dataNavigator3.PositionChanged
            ValidateFields()
        End Sub
        Private Sub dataNavigator2_ButtonClick(ByVal sender As Object, ByVal e As XtraEditors.NavigatorButtonClickEventArgs) Handles dataNavigator2.ButtonClick, dataNavigator3.ButtonClick
            e.Handled = Me.dxErrorProvider1.HasErrors
        End Sub
        Private Sub Validate_EmptyStringRule(ByVal control As BaseEdit)
            If control.Text Is Nothing OrElse control.Text.Trim().Length = 0 Then
                dxErrorProvider1.SetError(control, "This field can't be empty", ErrorType.Critical)
            Else
                dxErrorProvider1.SetError(control, "")
            End If
        End Sub
		Private Sub Validate_LessThanMinRule(ByVal control As BaseEdit, ByVal min As Decimal)
			If Not(TypeOf control.EditValue Is Decimal) Then
			Return
			End If
			If CType(control.EditValue, Decimal) < min Then
                dxErrorProvider1.SetError(control, "Please enter a greater value than " & min.ToString(), ErrorType.Warning)
			Else
				dxErrorProvider1.SetError(control, "")
			End If
		End Sub
		Private Sub Validate_BetweenMinAndMaxRule(ByVal control As BaseEdit, ByVal min As Decimal, ByVal max As Decimal)
			If Not(TypeOf control.EditValue Is Decimal) Then
			Return
			End If
			Dim val As Decimal = CType(control.EditValue, Decimal)
			If (val < min) Then
                dxErrorProvider1.SetError(control, "Please enter a greater value than " & (min * 100).ToString(), ErrorType.Warning)
			ElseIf val > max Then
                dxErrorProvider1.SetError(control, "Please enter a value less than " & (max * 100).ToString(), ErrorType.Information)
			Else
				dxErrorProvider1.SetError(control, "")
			End If
        End Sub
    End Class
End Namespace
